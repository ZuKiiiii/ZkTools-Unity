using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using ZkTools.Mathematics.Extensions;

namespace ZkTools.Mathematics.Geometry2D
{
	[System.Serializable]
	public struct Circle2D : IEquatable<Circle2D>, IFormattable
	{
		#region ==============================[Editable Variables]==============================

			public static Circle2D Trigonometric = new Circle2D(Vector2.zero, 1.0f);

		#endregion

		#region ==============================[Variables]==============================

			public Vector2 center;

			public float radius;

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Circle2D (Circle2D p_circle)
			{
				center = p_circle.center;
				radius = p_circle.radius;
			}
			
			public Circle2D (Vector2 p_center, float p_radius = 1.0f)
			{
				center = p_center;
				radius = p_radius;
			}

			public Circle2D (Vector2 p_a, Vector2 p_b)
			{
				center = Vector2X.Center(p_a, p_b);
				radius = Vector2.Distance(p_a, p_b) * 0.5f;
			}

			// public Circle2D (Vector3 p_a, Vector3 p_b, Vector3 p_c)
			// {
			// }
			//
			// public Circle2D (Triangle2D p_triangle)
			// {
			//
			// }

		#endregion
		
		#region ==============================[Properties]==============================

			public float Area => RadiusToArea(radius);
		
			public float Perimeter => RadiusToPerimeter(radius);

			#endregion
		
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AreaToPerimeter (float p_area)
			{
				return MathF.Sqrt(2.0f * p_area / Trigo.Tau);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AreaToRadius (float p_area)
			{
				return MathF.Sqrt(2.0f * p_area / Trigo.Tau);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 ClosestPoint (float p_radius, Vector2 p_point)
			{
				float distanceSqr = DistanceSqr(p_radius, p_point);
				if (distanceSqr <= MathF.Square(p_radius))
					return p_point;

				return Project(p_radius, p_point);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 ClosestPoint (Vector2 p_center, float p_radius, Vector2 p_point)
			{
				float distanceSqr = DistanceSqr(p_center, p_radius, p_point);
				if (distanceSqr <= MathF.Square(p_radius))
					return p_point;

				return Project(p_radius, p_point);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool Contain (float p_radius, Vector2 p_point)
			{
				return DistanceSqr(p_radius, p_point) <= MathF.Square(p_radius);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool Contain (Vector2 p_center, float p_radius, Vector2 p_point)
			{
				return DistanceSqr(p_center, p_radius, p_point) <= MathF.Square(p_radius);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Direction (float p_angle)
			{
				return new Vector2(Trigo.Cos(p_angle), Trigo.Sin(p_angle));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (float p_radius,  Vector3 p_point)
			{
				return MathF.Sqrt(DistanceSqr(p_radius, p_point));
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (Vector3 p_center, float p_radius, Vector3 p_point)
			{
				return MathF.Sqrt(DistanceSqr(p_center, p_radius, p_point));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (float p_radius,  Vector3 p_point)
			{
				return MathF.Square(p_point.x) + MathF.Square(p_point.y) - MathF.Square(p_radius);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (Vector3 p_center, float p_radius, Vector3 p_point)
			{
				return MathF.Square(p_point.x - p_center.x) + MathF.Square(p_point.y - p_center.y) - MathF.Square(p_radius);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Encapsulate (ref float p_radius, Vector2 p_point)
			{
				float distanceSqr = DistanceSqr(p_radius, p_point);
				if (distanceSqr > MathF.Square(p_radius))
					p_radius += MathF.Sqrt(distanceSqr) - p_radius;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Encapsulate (Vector2 p_center, ref float p_radius, Vector2 p_point)
			{
				float distanceSqr = DistanceSqr(p_radius, p_point);
				if (distanceSqr > MathF.Square(p_radius))
					p_radius += MathF.Sqrt(distanceSqr) - p_radius;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Eval (Vector2 p_center, float p_radius, float p_angle)
			{
				return  p_center + p_radius * Direction(p_angle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float PerimeterToArea (float p_perimeter)
			{
				return MathF.Square(p_perimeter) / (2.0f * Trigo.Tau);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float PerimeterToRadius (float p_perimeter)
			{
				return p_perimeter / Trigo.Tau;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Project (float p_radius, Vector2 p_point)
			{
				return p_point.normalized * p_radius;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Project (Vector2 p_center, float p_radius, Vector2 p_point)
			{
				return Vector2X.Direction(p_center, p_point) * p_radius;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadiusToArea (float p_radius)
			{
				return MathF.Square(p_radius) * Trigo.Pi;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadiusToPerimeter (float p_radius)
			{
				return p_radius * Trigo.Tau;;
			}

		#endregion
		
		#region ==============================[Methods]==============================

			public float Distance (Vector2 p_point)
			{
				return Distance(center, radius, p_point);
			}

			public Vector2 ClosestPoint (Vector2 p_point)
			{
				return ClosestPoint(center, radius, p_point);
			}

			public void Encapsulate (Vector2 p_point)
			{
				Encapsulate(center, ref radius, p_point);
			}

			public Vector2 Eval (float p_angle)
			{
				return Eval(center, radius, p_angle);
			}

			public Vector2 Eval (float p_radius, float p_angle)
			{
				return Eval(center, p_radius, p_angle);
			}

			public Vector2 Eval (Vector2 p_center, float p_angle)
			{
				return Eval(p_center, radius, p_angle);
			}

			public Circle2D GetEncapsulated (Vector2 p_point)
			{
				Circle2D result = this;
				result.Encapsulate(p_point);
				return result;
			}

			public Vector2 Project (Vector2 p_point)
			{
				return Project(center, radius, p_point);
			}

			public bool Contain (Vector2 p_point)
			{
				return Contain(center, radius, p_point);
			}

			public string ToString (string p_format)
			{
				return "(Center = " + center.ToString(p_format) + ", Radius = " + radius.ToString(p_format) + ")";
			}

		#endregion

		#region ==============================[Operator]==============================

			public static bool operator== (Circle2D p_lhs, Circle2D p_rhs)
			{
				return (p_lhs.center == p_rhs.center) && (p_lhs.radius == p_rhs.radius);
			}

			public static bool operator!= (Circle2D p_lhs, Circle2D p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public bool Equals (Circle2D p_other)
			{
				return center.Equals(p_other.center) && radius.Equals(p_other.radius);
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is Circle2D other && Equals(other);
			}

			public override int GetHashCode ()
			{
				unchecked
				{
					return (center.GetHashCode() * 397) ^ radius.GetHashCode();
				}
			}

			public override string ToString ()
			{
				return "(Center = " + center + ", Radius = " + radius + ")";
			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return "(Center = " + center.ToString(p_format, p_formatProvider) + ", Radius = " + radius.ToString(p_format, p_formatProvider) + ")";
			}

			#endregion
	}
}