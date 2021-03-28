using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Extensions
{
	public static partial class Vector2X
	{
		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Ceil (Vector2 p_vector)
			{
				return new Vector2(MathF.Ceil(p_vector.x), MathF.Ceil(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2Int CeilToInt (Vector2 p_vector)
			{
				return new Vector2Int(MathF.CeilToInt(p_vector.x), MathF.CeilToInt(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Center (Vector2 p_lhs, Vector2 p_rhs)
			{
				return (p_lhs + p_rhs) * 0.5f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 CenterDirection (Vector2 p_lhs, Vector2 p_rhs)
			{
				return (p_lhs + p_rhs).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Clamp (Vector2 p_vector, Vector2 p_min, Vector2 p_max)
			{
				return new Vector2(MathF.Clamp(p_vector.x, p_min.x, p_max.x), MathF.Clamp(p_vector.y, p_min.y, p_max.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Clamp (Vector2 p_vector, float p_min, Vector2 p_max)
			{
				return new Vector2(MathF.Clamp(p_vector.x, p_min, p_max.x), MathF.Clamp(p_vector.y, p_min, p_max.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Clamp (Vector2 p_vector, Vector2 p_min, float p_max)
			{
				return new Vector2(MathF.Clamp(p_vector.x, p_min.x, p_max), MathF.Clamp(p_vector.y, p_min.y, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Clamp (Vector2 p_vector, float p_min, float p_max)
			{
				return new Vector2(MathF.Clamp(p_vector.x, p_min, p_max), MathF.Clamp(p_vector.y, p_min, p_max));
			}

			public static Vector2 ClampMagnitude (Vector2 p_vector, float p_minMagnitude, float p_maxMagnitude)
			{
				float thisMagnitude = p_vector.magnitude;
				if (thisMagnitude.IsNearlyZero())
					return Vector2.zero;

				return MathF.Clamp(thisMagnitude, p_minMagnitude, p_maxMagnitude) * p_vector / thisMagnitude;
			}

			public static Vector2 ClampMaxMagnitude (Vector2 p_vector, float p_maxMagnitude)
			{
				p_maxMagnitude = MathF.Max(p_maxMagnitude, 0.0f);
				float magnitudeSquared = p_vector.sqrMagnitude;

				return magnitudeSquared > MathF.Square(p_maxMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_maxMagnitude) : p_vector;
			}

			public static Vector2 ClampMinMagnitude (this Vector2 p_this, float p_minMagnitude)
			{
				p_minMagnitude = MathF.Max(p_minMagnitude, 0.0f);
				float magnitudeSquared = p_this.sqrMagnitude;

				return magnitudeSquared < MathF.Square(p_minMagnitude) ? p_this * (MathF.InvSqrt(magnitudeSquared) * p_minMagnitude) : p_this;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cross (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs.x * p_rhs.y - p_lhs.y * p_rhs.x;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Direction (float p_angleRad)
			{
				return new Vector2(Trigo.Cos(p_angleRad), Trigo.Sin(p_angleRad));
			}

			// [MethodImpl(MethodImplOptions.AggressiveInlining)]
			// public static float Cross (float p_lhs, Vector2 p_rhs)
			// {
			// }

			// [MethodImpl(MethodImplOptions.AggressiveInlining)]
			// public static float Cross (Vector2 p_lhs, float p_rhs)
			// {
			// }

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Direction (Vector2 p_from, Vector2 p_to)
			{
				return FromTo(p_from, p_to).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (Vector2 p_lhs, Vector2 p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs.x * p_rhs.x + p_lhs.y * p_rhs.y;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Dot (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs.x * p_rhs.x + p_lhs.y * p_rhs.y;
			}

			public static void Exec (ref Vector2 p_vector, Func<float, float> p_xAction, Func<float, float> p_yAction)
			{
				p_vector.x = p_xAction?.Invoke(p_vector.x) ?? p_vector.x;
				p_vector.y = p_yAction?.Invoke(p_vector.y) ?? p_vector.y;
			}

			// p_direction must be normalized !!!;
			public static Vector2 ExtractDotVector (Vector2 p_vector, Vector2 p_direction)
			{
				float amount = Vector2.Dot(p_vector, p_direction);
				return p_direction * amount;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Floor (Vector2 p_vector)
			{
				return new Vector2(MathF.Floor(p_vector.x), MathF.Floor(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2Int FloorToInt (Vector2 p_vector)
			{
				return new Vector2Int(MathF.FloorToInt(p_vector.x), MathF.FloorToInt(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 FromTo (Vector2 p_from, Vector2 p_to)
			{
				return p_to - p_from;
			}

			public static Vector2 GetAbs (this Vector2 p_this)
			{
				return new Vector2(MathF.Abs(p_this.x), MathF.Abs(p_this.y));
			}

			public static float GetAbsMax (this Vector2 p_this)
			{
				return MathF.Max(MathF.Abs(p_this.x), MathF.Abs(p_this.y));
			}

			public static float GetAbsMin(this Vector2 p_this)
			{
				return MathF.Min(MathF.Abs(p_this.x), MathF.Abs(p_this.y));
			}

			public static float GetMax (this Vector2 p_this)
			{
				return MathF.Max(p_this.x, p_this.y);
			}

			public static float GetMin (this Vector2 p_this)
			{
				return MathF.Max(p_this.x, p_this.y);
			}

			public static bool IsCollinear (Vector2 p_lhs, Vector2 p_rhs)
			{
				return Cross(p_lhs, p_rhs).IsZero();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InverseLerp (Vector2 p_a, Vector2 p_b, Vector2 p_value)
			{
				return (p_value - p_a) / (p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InverseLerpClamped (Vector2 p_a, Vector2 p_b, Vector2 p_value, Vector2 p_min, Vector2 p_max)
			{
				return Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (this Vector2 p_lhs, Vector2 p_rhs, float p_tolerance = float.Epsilon)
			{
				return IsNearlyEqual(p_lhs, p_rhs, Vector2.one * p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (this Vector2 p_lhs, Vector2 p_rhs, Vector2 p_tolerance)
			{
				return	MathF.IsNearlyEqual(p_lhs.x, p_rhs.x, p_tolerance.x) && MathF.IsNearlyEqual(p_lhs.y, p_rhs.y, p_tolerance.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this Vector2 p_this, float p_tolerance = float.Epsilon)
			{
				return p_this.IsNearlyZero(Vector2.one * p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this Vector2 p_this, Vector2 p_tolerance)
			{
				return	p_this.x.IsNearlyZero(p_tolerance.x) && p_this.y.IsNearlyZero(p_tolerance.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOrthogonal (Vector2 p_lhs, Vector2 p_rhs)
			{
				return Vector2.Dot(p_lhs, p_rhs).IsZero();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOrthogonal (Vector2 p_lhs, Vector2 p_rhs, float p_tolerance)
			{
				return MathF.IsNearlyZero(Vector2.Dot(p_lhs, p_rhs), p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (this Vector2 p_this)
			{
				return p_this == Vector2.zero;
			}

			public static Vector2 Lerp (Vector2 p_a, Vector2 p_b, float p_t)
			{
				return Lerp(p_a, p_b, new Vector2(p_t, p_t));
			}

			public static Vector2 Lerp (Vector2 p_a, Vector2 p_b, Vector2 p_t)
			{
				return new Vector2(MathF.Lerp(p_a.x, p_b.x, p_t.x), MathF.Lerp(p_a.y, p_b.y, p_t.y));
			}

			public static Vector2 LerpClamped (Vector2 p_a, Vector2 p_b, float p_t)
			{
				return LerpClamped(p_a, p_b, new Vector2(p_t, p_t));
			}

			public static Vector2 LerpClamped (Vector2 p_a, Vector2 p_b, Vector2 p_t)
			{
				return new Vector2(MathF.LerpClamped(p_a.x, p_b.x, p_t.x), MathF.LerpClamped(p_a.y, p_b.y, p_t.y));
			}
			
			public static Vector2 Max (Vector2 p_lhs, Vector2 p_rhs)
			{
				return new Vector2(MathF.Max(p_lhs.x, p_rhs.x), MathF.Max(p_lhs.y, p_rhs.y));
			}

			public static Vector2 Min (Vector2 p_lhs, Vector2 p_rhs)
			{
				return new Vector2(MathF.Min(p_lhs.x, p_rhs.x), MathF.Min(p_lhs.y, p_rhs.y));
			}

			public static Vector2 Remap (Vector2 p_value, Vector2 p_inMin, Vector2 p_inMax, Vector2 p_outMin, Vector2 p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerp(p_inMin, p_inMax, p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 RemapClamped (Vector2 p_value, Vector2 p_inMin, Vector2 p_inMax, Vector2 p_outMin, Vector2 p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerpClamped(p_inMin, p_inMax, p_value, Vector2.zero, Vector2.one));
			}

			public static Vector2 RemoveDotVector (Vector2 p_vector, Vector2 p_direction)
			{
				return p_vector - ExtractDotVector(p_vector, p_direction);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Round (Vector2 p_vector)
			{
				return new Vector2(MathF.Round(p_vector.x), MathF.Round(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2Int RoundToInt (Vector2 p_vector)
			{
				return new Vector2Int(MathF.RoundToInt(p_vector.x), MathF.RoundToInt(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 WithMagnitude (this Vector2 p_this, float p_magnitude)
			{
				return p_this.normalized * p_magnitude;
			}

		#endregion
	}
}
