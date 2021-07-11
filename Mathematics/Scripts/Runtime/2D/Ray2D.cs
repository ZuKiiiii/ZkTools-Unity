using System;
using UnityEngine;

namespace ZkTools.Mathematics.Geometry2D
{
	[Serializable]
	public struct Ray2D : IFormattable
	{
		#region ==============================[Variables]==============================

			public Vector2 origin;

			public Vector2 direction;

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Ray2D (Vector2 p_direction)
			{
				origin = Vector2.zero;
				direction = p_direction;
			}

			public Ray2D (Vector2 p_origin, Vector2 p_direction)
			{
				origin = p_origin;
				direction = p_direction;
			}

		#endregion

		#region ==============================[Static Methods]==============================

			public static float Distance (Ray2D p_lhs, Ray2D p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			public static float Distance (Ray2D p_lhs, Ray2D p_rhs, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs, out p_closestPoint0, out p_closestPoint1));
			}

			public static float Distance (Ray2D p_ray, Line2D p_line)
			{
				return Line2D.Distance(p_line, p_ray);
			}

			public static float Distance (Ray2D p_ray, Line2D p_line, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return Line2D.Distance(p_line, p_ray, out p_closestPoint0, out p_closestPoint1);
			}

			public static float Distance (Ray2D p_ray, Segment2D p_segment)
			{
				return MathF.Sqrt(DistanceSqr(p_ray, p_segment));
			}

			public static float Distance (Ray2D p_ray, Segment2D p_segment, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return MathF.Sqrt(DistanceSqr(p_ray, p_segment, out p_closestPoint0, out p_closestPoint1));
			}

			public static float Distance (Ray2D p_ray, Vector2 p_point)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Ray2D p_lhs, Ray2D p_rhs)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Ray2D p_lhs, Ray2D p_rhs, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Ray2D p_ray, Line2D p_line)
			{
				return Line2D.DistanceSqr(p_line, p_ray);
			}

			public static float DistanceSqr (Ray2D p_ray, Line2D p_line, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				return Line2D.DistanceSqr(p_line, p_line, out p_closestPoint0, out p_closestPoint1);
			}

			public static float DistanceSqr (Ray2D p_ray, Segment2D p_segment)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Ray2D p_ray, Segment2D p_segment, out Vector2 p_closestPoint0, out Vector2 p_closestPoint1)
			{
				throw new System.NotImplementedException();
			}

			public static float DistanceSqr (Ray2D p_ray, Vector2 p_point)
			{
				throw new System.NotImplementedException();
			}

			public static Vector2 Project (Ray2D p_ray, Vector2 p_point)
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
				return origin + p_t * direction;
			}

			public Vector2 EvalClamped (float p_t)
			{
				return origin + MathF.Clamp(p_t) * direction;
			}

			public Vector2 Project (Vector2 p_point)
			{
				return Project(this, p_point);
			}

			public void Set (Vector2 p_origin, Vector2 p_direction)
			{
				origin = p_origin;
				direction = p_direction;
			}

		#endregion

		#region ==============================[Methods]==============================

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				throw new NotImplementedException();
			}

		#endregion

		#region ==============================[Operatord]==============================

			public static implicit operator Ray2D (UnityEngine.Ray2D p_unityRay)
			{
				return new Ray2D(p_unityRay.origin, p_unityRay.direction);
			}

			public static implicit operator UnityEngine.Ray2D (Ray2D p_ray)
			{
				return new UnityEngine.Ray2D(p_ray.origin, p_ray.direction);
			}

		#endregion
	}
}

