using System;
using UnityEngine;
using ZkTools.Mathematics.Extensions;

namespace ZkTools.Mathematics.Geometry2D
{
	[System.Serializable]
	public struct Line2D : IEquatable<Line2D>, IFormattable
	{
		#region // ==============================[Static Variables]============================== //

			public static readonly Line2D Down = new Line2D(Vector2.zero, Vector2.down);

			public static readonly Line2D Left = new Line2D(Vector2.zero, Vector2.left);

			public static readonly Line2D Right = new Line2D(Vector2.zero, Vector2.right);

			public static readonly Line2D Up = new Line2D(Vector2.zero, Vector2.up);

		#endregion

		#region // ==============================[Editable Variables]============================== //

			public Vector2 origin;

			// Must be unit length
			public Vector2 direction;

		#endregion

		#region // ==============================[Constructor + Destructor]============================== //

			public Line2D (Vector2 p_direction)
			{
				origin = Vector2.zero;
				direction = p_direction;
			}

			public Line2D (Vector2 p_origin, Vector2 p_direction)
			{
				origin = p_origin;
				direction = p_direction;
			}

		#endregion

		#region // ==============================[Static Methods]============================== //

			public static Line2D Bisector (Vector2 p_a, Vector2 p_b)
			{
				return new Line2D((p_a + p_b) * 0.5f, Vector2X.Direction(p_a, p_b).Perpendicular());
			}

			public static Line2D Bisector (Segment2D p_segment)
			{
				return Bisector(p_segment.a, p_segment.b);
			}

			public static float Distance (Line2D p_lhs, Line2D p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			public static float Distance (Line2D p_lhs, Line2D p_rhs, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs, out p_closestPoint0, out p_closestPoint1));
			}

			public static float Distance (Line2D p_line, Ray2D p_ray)
			{
				return MathF.Sqrt(DistanceSqr(p_line, p_ray));
			}

			public static float Distance (Line2D p_line, Ray2D p_ray, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return MathF.Sqrt(DistanceSqr(p_line, p_ray, out p_closestPoint0, out p_closestPoint1));
			}

			public static float Distance (Line2D p_line, Segment2D p_segment)
			{
				return MathF.Sqrt(DistanceSqr(p_line, p_segment));
			}

			public static float Distance (Line2D p_line, Segment2D p_segment, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return MathF.Sqrt(DistanceSqr(p_line, p_segment, out p_closestPoint0, out p_closestPoint1));
			}

			public static float Distance (Line2D p_line, Vector2 p_point)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Line2D p_lhs, Line2D p_rhs)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Line2D p_lhs, Line2D p_rhs, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Line2D p_line, Ray2D p_ray)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Line2D p_line, Ray2D p_ray, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Line2D p_line, Segment2D p_segment)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Line2D p_line, Segment2D p_segment, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				throw new System.NotImplementedException();
			}

			public static Line2D FromPoints (Vector2 p_a, Vector2 p_b)
			{
				return new Line2D(p_a, Vector2X.FromTo(p_a, p_b).normalized);
			}

			public static Line2D ParallelTo (Line2D p_line, float p_distance)
			{
				return new Line2D(p_line.origin + p_distance * p_line.direction.Perpendicular());
			}

			public static Line2D Perpendicular (Line2D p_line, Vector2 p_point)
			{
				return new Line2D(p_point, p_line.direction.Perpendicular());
			}

			public static Vector2 Project (Vector2 p_lineOrigin, Vector2 p_lineDirection, Vector2 p_point)
			{
				throw new NotImplementedException();
			}

			public static Vector2 Project (Line2D p_line, Vector2 p_point)
			{
				return Project(p_line.origin, p_line.direction, p_point);
			}

			public static float SignedDistance (Line2D p_line, Vector2 p_point)
			{
				throw new System.NotImplementedException();
			}

		#endregion

		#region // ==============================[Methods]============================== //

			public float Distance (Vector2 p_point)
			{
				return Distance(this, p_point);
			}

			public float DistanceSqr (Vector2 p_point)
			{
				return MathF.Square(Distance(this, p_point));
			}

			public Vector2 Eval (float p_t)
			{
				return origin + p_t * direction;
			}

			public Segment2D GetSegment (float p_length)
			{
				return new Segment2D(this, p_length);
			}
			
			public Vector2 Project (Vector2 p_point)
			{
				throw new System.NotImplementedException();
			}

			public int QuerySide (Vector2 p_point, float p_epsilon = float.Epsilon)
			{
				throw new NotImplementedException();
			}

			public bool QuerySideNegative (Vector2 p_point, float p_epsilon = float.Epsilon)
			{
				throw new NotImplementedException();
			}

			public bool QuerySidePositive(Vector2 p_point, float p_epsilon = float.Epsilon)
			{
				throw new NotImplementedException();
			}

			public Vector2 Reflect (Vector2 p_point)
			{
				throw new System.NotImplementedException();
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public bool Equals(Line2D other)
			{
				throw new NotImplementedException();
			}

			public string ToString(string format, IFormatProvider formatProvider)
			{
				throw new NotImplementedException();
			}

		#endregion

	}
}