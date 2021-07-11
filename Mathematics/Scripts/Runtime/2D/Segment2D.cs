using System;
using UnityEngine;
using ZkTools.Mathematics.Extensions;

namespace ZkTools.Mathematics.Geometry2D
{
	[Serializable]
	public struct Segment2D : IEquatable<Segment2D>, IFormattable
	{
		#region ==============================[Variables]==============================

			public Vector2 a;

			public Vector2 b;

		#endregion

		#region ==============================[Properties]==============================

			public Vector2 AB => Vector2X.FromTo(a, b);

			public Vector2 BA => Vector2X.FromTo(b, a);

			public Line2D Bisector => Line2D.Bisector(a, b);

			public Vector2 Center => Vector2X.Center(a, b);

			public float Length => AB.magnitude;

			public float LengthSqr => AB.sqrMagnitude;

			public Line2D LineAB => new Line2D(a, AB.normalized);

			public Line2D LineBA => new Line2D(b, BA.normalized);

			public Segment2D Inverse => new Segment2D(b, a);

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Segment2D (Vector2 p_a, Vector2 p_b)
			{
				a = p_a;
				b = p_b;
			}

			public Segment2D (Vector2 p_origin, Vector2 p_direction, float p_length)
			{
				a = p_origin;
				b = p_origin + p_direction * p_length;
			}

			public Segment2D (Line2D p_line, float p_length)
			{
				a = p_line.origin;
				b = p_line.Eval(p_length);
			}

		#endregion

		#region ==============================[Static Methods]==============================

			public static float Distance (Segment2D p_lhs, Segment2D p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			public static float Distance (Segment2D p_lhs, Segment2D p_rhs, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs, out p_closestPoint0, out p_closestPoint1));
			}

			public static float Distance (Segment2D p_segment, Vector2 p_point)
			{
				return MathF.Sqrt(DistanceSqr(p_segment, p_point));
			}

			public static float Distance (Segment2D p_segment, Vector2 p_point, out Vector2 p_closestPoint)
			{
				return MathF.Sqrt(DistanceSqr(p_segment, p_point, out p_closestPoint));
			}

			public static float Distance (Segment2D p_segment, Ray2D p_ray)
			{
				return MathF.Sqrt(DistanceSqr(p_segment, p_ray));
			}

			public static float Distance (Segment2D p_segment, Ray2D p_ray, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return MathF.Sqrt(DistanceSqr(p_segment, p_ray, out p_closestPoint0, out p_closestPoint1));
			}

			public static float DistanceSqr(Segment2D p_segment, Vector2 p_point)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Segment2D p_segment, Vector2 p_point, out Vector2 p_closestPoint)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Segment2D p_segment, Ray2D p_ray)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Segment2D p_segment, Ray2D p_ray, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Segment2D p_lhs, Segment2D p_rhs)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Segment2D p_lhs, Segment2D p_rhs, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				throw new System.NotImplementedException();
			}

			public static Vector2 Project (Segment2D p_segment, Vector2 p_point)
			{
				throw new System.NotImplementedException();
			}

		#endregion

		#region ==============================[Methods]==============================

			public float Distance (Vector2 p_point)
			{
				return Distance(this, p_point);
			}

			public float DistanceSqr (Vector2 p_point)
			{
				return DistanceSqr(this, p_point);
			}

			public Vector2 Eval (float p_t)
			{
				return Vector2X.Lerp(a, b, p_t);
			}

			public Vector2 EvalClamped (float p_t)
			{
				return Vector2X.LerpClamped(a, b, p_t);
			}

			public Vector2 Project (Vector2 p_project)
			{
				throw new System.NotImplementedException();
			}

			public void Set (Vector2 p_a, Vector2 p_b)
			{
				a = p_a;
				b = p_b;
			}

			public void Set (Vector2 p_origin, Vector2 p_direction, float p_length)
			{
				a = p_origin;
				b = p_origin + p_direction * p_length;
			}

			public void Set (Line2D p_line, float p_length)
			{
				a = p_line.origin;
				b = p_line.Eval(p_length);
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public bool Equals(Segment2D p_other)
			{
				throw new NotImplementedException();
			}

			public string ToString(string p_format, IFormatProvider p_formatProvider)
			{
				throw new NotImplementedException();
			}

		#endregion
	}
}

