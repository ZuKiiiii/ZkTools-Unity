using System;
using System.Collections.Generic;
using UnityEngine;
using ZkTools.Mathematics.Extensions;
using ZkTools.Mathematics.Ranges;

namespace ZkTools.Mathematics.Geometry2D
{
	[Serializable]
	public struct AABB2D : IEquatable<AABB2D>, IFormattable
	{
		#region // ==============================[Editable Variables]============================== //

			public Vector2 min;

			public Vector2 max;

		#endregion
		
		#region // ==============================[Properties]============================== //

			public float Area => Width * Height;

			public Vector2 Center
			{
				get => Vector2X.Center(min, max);
				set
				{
					Vector2 extents = Extents;
					min = value - extents;
					max = value + extents;
				}
			}

			public Vector2 BotRight
			{
				get => new Vector2(max.x, min.y);
				set
				{
					max.x = value.x;
					min.y = value.y;
				}
			}

			public Vector2 BotLeft
			{
				get => min;
				set => min = value;
			}

			public Vector2 Extents
			{
				get => Size * 0.5f;
				set
				{
					Vector2 center = Center;
					min = center - value;
					min = center + value;
				}
			}

			public float Height
			{
				get => max.y - min.y;
				set
				{
					Vector2 center = Center;
					min.y = center.y - value;
					min.y = center.y + value;
				}
			}

			public bool IsValidX => max.x >= min.x;

			public bool IsValidY => max.y >= min.y;

			public bool IsValid =>  IsValidX && IsValidY;

			public float Perimeter => 2 * (Width + Height);

			public Vector2 Size
			{
				get => max - min;
				set => Extents = value * 0.5f;
			}

			public Vector2 this [int p_index]
			{
				get => Vertices[p_index];
				set
				{
					switch (p_index)
					{
						case 0 : BotLeft = value; break;
						case 1 : TopLeft = value; break;
						case 2 : TopRight = value; break;
						case 3 : BotRight = value; break;
						default : throw new System.IndexOutOfRangeException("Index of " + p_index + " is not valid ! Range of AABB2D : [0,3] !");
					}
				}
			}

			public Vector2 TopRight
			{
				get => max;
				set => max = value;
			}

			public Vector2 TopLeft
			{
				get => new Vector2(min.x, max.y);
				set
				{
					min.x = value.x;
					max.y = value.y;
				}
			}

			public Vector2[] Vertices => new Vector2[4] {BotLeft, TopLeft, TopRight, BotRight};

			public float Width
			{
				get => max.x - min.x;
				set
				{
					Vector2 center = Center;
					min.x = center.x - value;
					min.x = center.x + value;
				}
			}

		#endregion

		#region // ==============================[Constructor + Destructor]============================== //

			public AABB2D (float p_x, float p_y)
			{
				min = new Vector2(p_x, p_y);
				max = min;
			}

			public AABB2D (Vector2 p_point)
			{
				min = p_point;
				max = p_point;
			}
			
			public AABB2D (float p_xMin, float p_yMin, float p_xMax, float p_yMax)
			{
				min = new Vector2(p_xMin, p_yMin);
				max = new Vector2(p_xMax, p_yMax);
			}

			public AABB2D (Vector2 p_min, Vector2 p_max)
			{
				min = p_min;
				max = p_max;
			}

			public AABB2D (AABB2D p_copy)
			{
				min = p_copy.min;
				max = p_copy.max;
			}
			
		#endregion

		#region // ==============================[Static Methods]============================== //

			public static float Distance (AABB2D p_aabb, Vector2 p_point)
			{
				return MathF.Sqrt(DistanceSqr(p_aabb, p_point));
			}

			public static float Distance (AABB2D p_aabb, Vector2 p_point, out Vector2 p_closestPoint)
			{
				return MathF.Sqrt(DistanceSqr(p_aabb, p_point, out p_closestPoint));
			}

			public static float DistanceSqr (AABB2D p_aabb, Vector2 p_point)
			{
				float distanceSqr = 0.0f;

				if (p_point.x < p_aabb.min.x)
					distanceSqr += MathF.DistanceSqr(p_point.x, p_aabb.min.x);
				else if (p_aabb.min.x > p_aabb.max.x)
					distanceSqr += MathF.DistanceSqr(p_point.x, p_aabb.max.x);
				
				if (p_point.y < p_aabb.min.y)
					distanceSqr += MathF.DistanceSqr(p_point.y, p_aabb.min.y);
				else if (p_aabb.min.y > p_aabb.max.y)
					distanceSqr += MathF.DistanceSqr(p_point.y, p_aabb.max.y);

				return distanceSqr;
			}

			public static float DistanceSqr(AABB2D p_aabb, Vector2 p_point, out Vector2 p_closestPoint)
			{
				float distanceSqr = 0.0f;
				float delta = 0.0f;
				p_closestPoint = p_point;

				if (p_point.x < p_aabb.min.x)
				{
					delta = p_aabb.min.x - p_point.x;
					distanceSqr += MathF.Square(delta);
					p_closestPoint.x += delta;
				}
				else if (p_aabb.min.x > p_aabb.max.x)
				{
					delta = p_point.x - p_aabb.max.x;
					distanceSqr += MathF.Square(delta);
					p_closestPoint.x -= delta;
				}

				if (p_point.y < p_aabb.min.y)
				{
					delta = p_aabb.min.y - p_point.y;
					distanceSqr += MathF.Square(delta);
					p_closestPoint.y += delta;
				}
				else if (p_aabb.min.y > p_aabb.max.y)
				{
					delta = p_point.y - p_aabb.max.y;
					distanceSqr += MathF.Square(delta);
					p_closestPoint.y -= delta;
				}

				return distanceSqr;
			}

			public static AABB2D FromCenterAndExtents (float p_x, float p_y, float p_halfWidth, float p_halfHeight)
			{
				return new AABB2D(p_x - p_halfWidth, p_y - p_halfHeight, p_x + p_halfWidth, p_y + p_halfHeight);
			}

			public static AABB2D FromCenterAndExtents (float p_x, float p_y, Vector2 p_extents)
			{
				return FromCenterAndExtents(p_x, p_y, p_extents.x, p_extents.y);
			}

			public static AABB2D FromCenterAndExtents (Vector2 p_center, float p_halfWidth, float p_halfHeight)
			{
				return FromCenterAndExtents(p_center, p_halfWidth, p_halfHeight);
			}

			public static AABB2D FromCenterAndExtents (Vector2 p_center, Vector2 p_extents)
			{
				return FromCenterAndExtents(p_center.x, p_center.y, p_extents.x, p_extents.y);
			}

			public static AABB2D FromCenterAndSize (float p_x, float p_y, float p_width, float p_height)
			{
				return FromCenterAndExtents(p_x, p_y, p_width * 0.5f, p_height * 0.5f);
			}

			public static AABB2D FromCenterAndSize (float p_x, float p_y, Vector2 p_size)
			{
				return FromCenterAndSize(p_x, p_y, p_size.x, p_size.y);
			}

			public static AABB2D FromCenterAndSize (Vector2 p_center, float p_width, float p_height)
			{
				return FromCenterAndSize(p_center, p_width, p_height);
			}

			public static AABB2D FromCenterAndSize (Vector2 p_center, Vector2 p_size)
			{
				return FromCenterAndSize(p_center.x, p_center.y, p_size.x, p_size.y);
			}

			public static AABB2D FromPoints (Vector2 p_point0, Vector2 p_point1)
			{
				AABB2D result;

				if (p_point0.x < p_point1.x)
				{
					result.min.x = p_point0.x;
					result.max.x = p_point1.x;
				}
				else
				{
					result.min.x = p_point1.x;
					result.max.x = p_point0.x;
				}

				if (p_point0.y < p_point1.y)
				{
					result.min.y = p_point0.y;
					result.max.y = p_point1.y;
				}
				else
				{
					result.min.y = p_point1.y;
					result.max.y = p_point0.y;
				}

				return result;
			}

			public static AABB2D FromPoints (IEnumerable<Vector2> p_points)
			{
				AABB2D result = new AABB2D();
				foreach (Vector2 point in p_points)
					result.Expand(point);
				return result;
			}

			public static AABB2D? Intersection (AABB2D p_lhs, AABB2D p_rhs)
			{
				if (!IsOverlapping(p_lhs, p_rhs))
					return null;

				return new AABB2D(Vector2X.Max(p_lhs.min, p_rhs.min), Vector2X.Min(p_lhs.max, p_rhs.max));
			}

			public static bool Intersection (AABB2D p_aabb, Ray2D p_ray)
			{
				throw new System.NotImplementedException();
			}

			public static bool Intersection (AABB2D p_aabb, Ray2D p_ray, out Intersection_AABB_Ray_2D p_info)
			{
				throw new System.NotImplementedException();
			}

			public static bool IsOverlapping (AABB2D p_lhs, AABB2D p_rhs)
			{
				return IsOverlappingX(p_lhs, p_rhs) && IsOverlappingY(p_lhs, p_rhs);
			}

			public static bool IsOverlappingX (AABB2D p_lhs, AABB2D p_rhs)
			{
				return Range.IsOverlapping(p_lhs.min.x, p_lhs.max.x, p_rhs.min.x, p_rhs.max.x);
			}

			public static bool IsOverlappingY (AABB2D p_lhs, AABB2D p_rhs)
			{
				return Range.IsOverlapping(p_lhs.min.y, p_lhs.max.y, p_rhs.min.y, p_rhs.max.y);
			}

			
		#endregion

		#region // ==============================[Methods]============================== //

			public void ClosestPoint (Vector2 p_point)
			{
				throw new NotImplementedException();
			}

			public bool Contains (Vector2 p_point)
			{
				return !((p_point.x < min.x) || (p_point.x > max.x) || (p_point.y < min.y) || (p_point.y > max.y));
			}

			public void Distance (Vector2 p_point)
			{
				throw new NotImplementedException();
			}

			public void DistanceSqr (Vector2 p_point)
			{
				throw new NotImplementedException();
			}

			public void Encapsulate (float p_x, float p_y)
			{
				this = GetEncapsulated(p_x, p_y);
			}
			
			public void Encapsulate (Vector2 p_point)
			{
				Encapsulate(p_point.x, p_point.y);
			}

			public void Encapsulate (AABB2D p_aabb)
			{
				this = GetEncapsulated(p_aabb);
			}
			
			public void Expand (float p_value)
			{
				Expand(p_value, p_value);
			}

			public void Expand (float p_minExp, float p_maxExp)
			{
				
			}

			public void Expand (Vector2 p_values)
			{
				Expand(p_values.x, p_values.y);
			}

			public void GetExpanded (float p_value)
			{
				throw new NotImplementedException();
			}

			public void GetExpanded (float p_minExp, float p_maxExp)
			{
				throw new NotImplementedException();
			}

			public void GetExpanded (Vector2 p_values)
			{
				throw new NotImplementedException();
			}

			public AABB2D GetEncapsulated (float p_x, float p_y)
			{
				Vector2 minResult = new Vector2(MathF.Min(p_x, min.x), MathF.Min(p_y, min.y));
				Vector2 maxResult = new Vector2(MathF.Max(p_x, max.x), MathF.Max(p_y, max.y));

				return new AABB2D(minResult, maxResult);
			}
			
			public AABB2D GetEncapsulated (Vector2 p_point)
			{
				return GetEncapsulated(p_point.x, p_point.y);
			}

			public AABB2D GetEncapsulated (AABB2D p_aabb)
			{
				return GetEncapsulated(p_aabb.min).GetEncapsulated(p_aabb.max);
			}
			
			public void GetMoved (Vector2 p_destination)
			{
				throw new NotImplementedException();
			}

			public void GetVertices(out Vector2 p_botLeft, out Vector2 p_topLeft, out Vector2 p_topRight, out Vector2 p_botRight)
			{
				p_botLeft = BotLeft;
				p_topLeft = TopLeft;
				p_topRight = TopRight;
				p_botRight = BotRight;
			}

			public void Move (Vector2 p_destination)
			{
				throw new NotImplementedException();
			}

			public void Resolve ()
			{
				ResolveX();
				ResolveY();
			}

			public void ResolveX ()
			{
				if (!IsValidX)
					Helper.Swap(ref min.x, ref max.x);
			}

			public void ResolveY ()
			{
				if (!IsValidY)
					Helper.Swap(ref min.y, ref max.y);
			}

			public void Set (float p_x, float p_y)
			{
				min = new Vector2(p_x, p_y);
				max = min;
			}

			public void Set (Vector2 p_point)
			{
				min = p_point;
				max = p_point;
			}

			public void Set (float p_xMin, float p_yMin, float p_xMax, float p_yMax)
			{
				min = new Vector2(p_xMin, p_yMin);
				max = new Vector2(p_xMax, p_yMax);
			}

			public void Set (Vector2 p_min, Vector2 p_max)
			{
				min = p_min;
				max = p_max;
			}

			public void Shift (Vector2 p_offset)
			{
				throw new NotImplementedException();
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public bool Equals (AABB2D other)
			{
				return min.Equals(other.min) && max.Equals(other.max);
			}

			public override bool Equals(object obj)
			{
				return obj is AABB2D other && Equals(other);
			}

			public override int GetHashCode()
			{
				unchecked
				{
					return (min.GetHashCode() * 397) ^ max.GetHashCode();
				}
			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				throw new NotImplementedException();
			}

		#endregion

		#region // ==============================[Operators]============================== //

			public static bool operator== (AABB2D p_lhs, AABB2D p_rhs)
			{
				return p_lhs.min == p_rhs.min && p_lhs.max == p_rhs.max;
			}

			public static bool operator!= (AABB2D p_lhs, AABB2D p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static implicit operator UnityEngine.Rect (AABB2D p_aabb)
			{
				return Rect.MinMaxRect(p_aabb.min.x, p_aabb.min.y, p_aabb.max.x, p_aabb.max.y);
			}
			
			public static implicit operator AABB2D (UnityEngine.Rect p_rect)
			{
				return new AABB2D(p_rect.xMin, p_rect.xMax, p_rect.yMin, p_rect.yMax);
			}

		#endregion
	}

	public struct Intersection_AABB_Ray_2D
	{
		
	}
}