using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using ZkTools.Mathematics.Angles;

namespace ZkTools.Mathematics.Extensions
{
	public static class Vector3X
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Abs (Vector3 p_vector)
			{
				return new Vector3(MathF.Abs(p_vector.x), MathF.Abs(p_vector.y), MathF.Abs(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Add (Vector3 p_lhs, Vector3 p_rhs)
			{
				return p_lhs + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Add (ref Vector3 p_lhs, Vector3 p_rhs)
			{
				p_lhs += p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Add (Vector3 p_lhs, float p_rhs)
			{
				return p_lhs + Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Add (ref Vector3 p_lhs, float p_rhs)
			{
				p_lhs += Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Add (float p_lhs, Vector3 p_rhs)
			{
				return Replicate(p_lhs) + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian Angle (Vector3 p_from, Vector3 p_to)
			{
				return Trigo.Acos(Dot(p_from, p_to) / MathF.Sqrt(p_from.sqrMagnitude * p_to.sqrMagnitude));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian AngleCCW (Vector3 p_from, Vector3 p_to, Vector3 p_axis)
			{
				return Det(p_from, p_to, p_axis) > 0 ? Angle(p_from, p_to) : Radian.One - Angle(p_from, p_to);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian AngleCW (Vector3 p_from, Vector3 p_to, Vector3 p_axis)
			{
				return Det(p_from, p_to, p_axis) < 0 ? Angle(p_from, p_to) : Radian.One - Angle(p_from, p_to);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Back (float p_scale = 1.0f)
			{
				return new Vector3(0.0f, 0.0f, -p_scale);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Ceil (Vector3 p_vector)
			{
				return new Vector3(MathF.Ceil(p_vector.x), MathF.Ceil(p_vector.y), MathF.Ceil(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int CeilToInt (Vector3 p_vector)
			{
				return new Vector3Int(MathF.CeilToInt(p_vector.x), MathF.CeilToInt(p_vector.y), MathF.CeilToInt(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Center (Vector3 p_lhs, Vector3 p_rhs)
			{
				return (p_lhs + p_rhs) * 0.5f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 CenterDirection (Vector3 p_lhs, Vector3 p_rhs)
			{
				return (p_lhs + p_rhs).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Clamp (Vector3 p_vector, Vector3 p_min, Vector3 p_max)
			{
				return new Vector3(MathF.Clamp(p_vector.x, p_min.x, p_max.x), MathF.Clamp(p_vector.y, p_min.y, p_max.y), MathF.Clamp(p_vector.z, p_min.z, p_max.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Clamp (Vector3 p_vector, float p_min, Vector3 p_max)
			{
				return new Vector3(MathF.Clamp(p_vector.x, p_min, p_max.x), MathF.Clamp(p_vector.y, p_min, p_max.y), MathF.Clamp(p_vector.z, p_min, p_max.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Clamp (Vector3 p_vector, Vector3 p_min, float p_max)
			{
				return new Vector3(MathF.Clamp(p_vector.x, p_min.x, p_max), MathF.Clamp(p_vector.y, p_min.y, p_max), MathF.Clamp(p_vector.z, p_min.z, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Clamp (Vector3 p_vector, float p_min = 0.0f, float p_max = 1.0f)
			{
				return new Vector3(MathF.Clamp(p_vector.x, p_min, p_max), MathF.Clamp(p_vector.y, p_min, p_max), MathF.Clamp(p_vector.z, p_min, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 ClampMagnitude (Vector3 p_vector, float p_minMagnitude, float p_maxMagnitude)
			{
				float thisMagnitude = p_vector.magnitude;
				return thisMagnitude < p_minMagnitude ? (p_vector / thisMagnitude) * p_minMagnitude :
					thisMagnitude > p_maxMagnitude ? (p_vector / thisMagnitude) * p_maxMagnitude : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 ClampMaxMagnitude (Vector3 p_vector, float p_maxMagnitude)
			{
				float magnitudeSquared = p_vector.magnitude;
				return magnitudeSquared > MathF.Square(p_maxMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_maxMagnitude) : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 ClampMinMagnitude (Vector3 p_vector, float p_minMagnitude)
			{
				float magnitudeSquared = p_vector.sqrMagnitude;
				return magnitudeSquared < MathF.Square(p_minMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_minMagnitude) : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Cross (Vector3 p_lhs, Vector3 p_rhs)
			{
				return new Vector3 (p_lhs.y * p_rhs.z - p_lhs.z * p_rhs.y, p_lhs.z * p_rhs.x - p_lhs.x * p_rhs.z, p_lhs.x * p_rhs.y - p_lhs.y * p_rhs.x);
			}

			//  determinant
			// [MethodImpl(MethodImplOptions.AggressiveInlining)]
			// public static float Cross (float p_lhs, Vector3 p_rhs)
			// {
			// }

			// [MethodImpl(MethodImplOptions.AggressiveInlining)]
			// public static float Cross (Vector3 p_lhs, float p_rhs)
			// {
			// }

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Det (Vector3 p_a, Vector3 p_b, Vector3 p_c)
			{
				return (p_a.x * p_b.y * p_c.z) + (p_a.y * p_b.z * p_c.x) + (p_a.z * p_b.x * p_c.y) - (p_a.z * p_b.y * p_c.x) - (p_a.y * p_b.x * p_c.z) - (p_a.x * p_b.z * p_c.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Direction (Vector3 p_from, Vector3 p_to)
			{
				return FromTo(p_from, p_to).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DirectionTo (this Vector3 p_this, Vector3 p_to)
			{
				return Direction(p_this, p_to);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Div (Vector3 p_lhs, Vector3 p_rhs)
			{
				return new Vector3(p_lhs.x / p_rhs.x, p_lhs.y / p_rhs.y, p_lhs.z / p_rhs.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Div (ref Vector3 p_lhs, Vector3 p_rhs)
			{
				p_lhs = Div(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Div (Vector3 p_lhs, float p_rhs)
			{
				return p_lhs / p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Div (ref Vector3 p_lhs, float p_rhs)
			{
				p_lhs /= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DivSafe (Vector3 p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DivSafe (ref Vector3 p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DivSafe (Vector3 p_dividend, float p_divisor, Vector3 p_defaultValue)
			{
				return p_divisor.IsZero() ? p_defaultValue : p_dividend / p_divisor;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DivSafe (ref Vector3 p_dividend, float p_divisor, Vector3 p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DivSafe (Vector3 p_dividend, Vector3 p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DivSafe (ref Vector3 p_dividend, Vector3 p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DivSafe (Vector3 p_dividend, Vector3 p_divisor, Vector3 p_defaultValue)
			{
				return new Vector3
				(
					MathF.DivSafe(p_dividend.x, p_divisor.x, p_defaultValue.x),
					MathF.DivSafe(p_dividend.y, p_divisor.y, p_defaultValue.y),
					MathF.DivSafe(p_dividend.z, p_divisor.z, p_defaultValue.z)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 DivSafe (ref Vector3 p_dividend, Vector3 p_divisor, Vector3 p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Dot (Vector3 p_lhs, Vector3 p_rhs)
			{
				return p_lhs.x * p_rhs.x + p_lhs.y * p_rhs.y + p_lhs.z * p_rhs.z;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Down (float p_scale = 1.0f)
			{
				return new Vector3(0.0f, p_scale, 0.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (Vector3 p_lhs, Vector3 p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (Vector3 p_lhs, Vector3 p_rhs)
			{
				return MathF.Square(p_rhs.x - p_lhs.x) + MathF.Square(p_rhs.y - p_lhs.y) + MathF.Square(p_rhs.z - p_lhs.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Exec (ref Vector3 p_vector, Func<float, float> p_action)
			{
				p_vector.x = p_action?.Invoke(p_vector.x) ?? p_vector.x;
				p_vector.y = p_action?.Invoke(p_vector.y) ?? p_vector.y;
				p_vector.z = p_action?.Invoke(p_vector.z) ?? p_vector.z;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Exec (ref Vector3 p_vector, Func<float, float> p_xAction, Func<float, float> p_yAction, Func<float, float> p_zAction)
			{
				p_vector.x = p_xAction?.Invoke(p_vector.x) ?? p_vector.x;
				p_vector.y = p_yAction?.Invoke(p_vector.y) ?? p_vector.y;
				p_vector.z = p_yAction?.Invoke(p_vector.z) ?? p_vector.z;
			}

			// p_direction must be normalized !!!;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 ExtractDotVector (Vector3 p_vector, Vector3 p_direction)
			{
				return p_direction * Vector3.Dot(p_vector, p_direction);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Floor (Vector3 p_vector)
			{
				return new Vector3(MathF.Floor(p_vector.x), MathF.Floor(p_vector.y), MathF.Floor(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int FloorToInt (Vector3 p_vector)
			{
				return new Vector3Int(MathF.FloorToInt(p_vector.x), MathF.FloorToInt(p_vector.y), MathF.FloorToInt(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Forward (float p_scale = 1.0f)
			{
				return new Vector3(0.0f, 0.0f, p_scale);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Frac (Vector3 p_value)
			{
				return p_value - Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 FromTo (Vector3 p_from, Vector3 p_to)
			{
				return p_to - p_from;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAbs (this Vector3 p_this)
			{
				return Abs(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAbsMax (this Vector3 p_this)
			{
				return Max(Abs(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAbsMin (this Vector3 p_this)
			{
				return Max(Abs(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitude (this Vector3 p_this, out Vector3 p_direction, out float p_magnitude)
			{
				p_magnitude = p_this.magnitude;
				p_direction = p_this / p_magnitude;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector3 p_direction, float p_magnitude) GetDirectionAndMagnitude (this Vector3 p_this)
			{
				float magnitude = p_this.magnitude;
				Vector3 direction = p_this / magnitude;
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitudeSafe (this Vector3 p_this, out Vector3 p_direction, out float p_magnitude, float p_defaultValue = 0.0f)
			{
				p_magnitude = p_this.magnitude;
				p_direction = DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitudeSafe (this Vector3 p_this, out Vector3 p_direction, out float p_magnitude, Vector3 p_defaultValue)
			{
				p_magnitude = p_this.magnitude;
				p_direction = DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector3 p_direction, float p_magnitude) GetDirectionAndMagnitudeSafe (this Vector3 p_this, float p_defaultValue = 0.0f)
			{
				float magnitude = p_this.magnitude;
				Vector3 direction = DivSafe(p_this, magnitude, p_defaultValue);
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector3 p_direction, float p_magnitude) GetDirectionAndMagnitudeSafe (this Vector3 p_this, Vector3 p_defaultValue)
			{
				float magnitude = p_this.magnitude;
				Vector3 direction = DivSafe(p_this, magnitude, p_defaultValue);
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMax (this Vector3 p_this)
			{
				return Max(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMaxAbs (this Vector3 p_this)
			{
				return MathF.Abs(Max(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMin (this Vector3 p_this)
			{
				return Min(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMinAbs (this Vector3 p_this)
			{
				return MathF.Abs(Min(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsCollinear (Vector3 p_lhs, Vector3 p_rhs)
			{
				return Cross(p_lhs, p_rhs).IsZero();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNormalized (this Vector3 p_this)
			{
				return p_this.sqrMagnitude == 1.0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsUnit (this Vector3 p_this, float p_epsilon = float.Epsilon)
			{
				return MathF.IsNearlyEqual(p_this.sqrMagnitude, 1.0f, p_epsilon);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InverseLerp (Vector3 p_a, Vector3 p_b, Vector3 p_value)
			{
				return Div(p_value - p_a, p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InverseLerpClamped (Vector3 p_a, Vector3 p_b, Vector3 p_value, Vector3 p_min, Vector3 p_max)
			{
				return Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (this Vector3 p_lhs, Vector3 p_rhs, float p_tolerance = float.Epsilon)
			{
				return IsNearlyEqual(p_lhs, p_rhs, Vector3.one * p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (this Vector3 p_lhs, Vector3 p_rhs, Vector3 p_tolerance)
			{
				return	MathF.IsNearlyEqual(p_lhs.x, p_rhs.x, p_tolerance.x) && MathF.IsNearlyEqual(p_lhs.y, p_rhs.y, p_tolerance.y) && MathF.IsNearlyEqual(p_lhs.z, p_rhs.z, p_tolerance.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this Vector3 p_this, float p_tolerance = float.Epsilon)
			{
				return p_this.IsNearlyZero(Vector3.one * p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this Vector3 p_this, Vector3 p_tolerance)
			{
				return	p_this.x.IsNearlyZero(p_tolerance.x) && p_this.y.IsNearlyZero(p_tolerance.y) && p_this.z.IsNearlyZero(p_tolerance.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOrthogonal (Vector3 p_lhs, Vector3 p_rhs)
			{
				return Vector3.Dot(p_lhs, p_rhs).IsZero();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOrthogonal (Vector3 p_lhs, Vector3 p_rhs, float p_tolerance)
			{
				return MathF.IsNearlyZero(Vector3.Dot(p_lhs, p_rhs), p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (this Vector3 p_this)
			{
				return p_this == Vector3.zero;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Left (float p_scale = 1.0f)
			{
				return new Vector3(-p_scale, 0.0f, 0.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Lerp (Vector3 p_a, Vector3 p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Lerp (Vector3 p_a, Vector3 p_b, Vector3 p_t)
			{
				return new Vector3(MathF.Lerp(p_a.x, p_b.x, p_t.x), MathF.Lerp(p_a.y, p_b.y, p_t.y), MathF.Lerp(p_a.z, p_b.z, p_t.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 LerpClamped (Vector3 p_a, Vector3 p_b, float p_t)
			{
				return LerpClamped(p_a, p_b, new Vector3(p_t, p_t, p_t));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 LerpClamped (Vector3 p_a, Vector3 p_b, Vector3 p_t)
			{
				return new Vector3(MathF.LerpClamped(p_a.x, p_b.x, p_t.x), MathF.LerpClamped(p_a.y, p_b.y, p_t.y), MathF.LerpClamped(p_a.z, p_b.z, p_t.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (Vector3 p_vector)
			{
				return MathF.Max(p_vector.x, p_vector.y, p_vector.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Max (Vector3 p_lhs, Vector3 p_rhs)
			{
				return new Vector3(MathF.Max(p_lhs.x, p_rhs.x), MathF.Max(p_lhs.y, p_rhs.y), MathF.Max(p_lhs.z, p_rhs.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Max (Vector3 p_a, Vector3 p_b, Vector3 p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Max (Vector3 p_a, Vector3 p_b, Vector3 p_c, Vector3 p_d)
			{
				return Max(Max(Max(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Max (params Vector3[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (Vector3 p_vector)
			{
				return MathF.Min(p_vector.x, p_vector.y, p_vector.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Min (Vector3 p_lhs, Vector3 p_rhs)
			{
				return new Vector3(MathF.Min(p_lhs.x, p_rhs.x), MathF.Min(p_lhs.y, p_rhs.y), MathF.Min(p_lhs.z, p_rhs.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Min (Vector3 p_a, Vector3 p_b, Vector3 p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Min (Vector3 p_a, Vector3 p_b, Vector3 p_c, Vector3 p_d)
			{
				return Min(Min(Min(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Min (params Vector3[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Mul (Vector3 p_lhs, Vector3 p_rhs)
			{
				return new Vector3(p_lhs.x * p_rhs.x, p_lhs.y * p_rhs.y, p_lhs.z * p_rhs.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Mul (ref Vector3 p_lhs, Vector3 p_rhs)
			{
				p_lhs = Mul(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Mul (Vector3 p_lhs, float p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Mul (ref Vector3 p_lhs, float p_rhs)
			{
				p_lhs *= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Mul (float p_lhs, Vector3 p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Normalized (this Vector3 p_vector)
			{
				return p_vector / p_vector.magnitude;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 NormalizedSafe (this Vector3 p_vector, float p_defaultValue = 0.0f)
			{
				return NormalizedSafe(p_vector, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 NormalizedSafe (this Vector3 p_vector, Vector3 p_defaultValue)
			{
				return p_vector.IsZero() ? p_defaultValue : Normalized(p_vector);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Remap (Vector3 p_value, Vector3 p_inMin, Vector3 p_inMax, Vector3 p_outMin, Vector3 p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerp(p_inMin, p_inMax, p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Remap (Vector3 p_value, Bounds p_in, Bounds p_out)
			{
				return Remap(p_value, p_in.min, p_in.max, p_out.min, p_out.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 RemapClamped (Vector3 p_value, Vector3 p_inMin, Vector3 p_inMax, Vector3 p_outMin, Vector3 p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerpClamped(p_inMin, p_inMax, p_value, Vector3.zero, Vector3.one));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 RemapClamped (Vector3 p_value, Bounds p_in, Bounds p_out)
			{
				return RemapClamped(p_value, p_in.min, p_in.max, p_out.min, p_out.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 RemoveDotVector (Vector3 p_vector, Vector3 p_direction)
			{
				return p_vector - ExtractDotVector(p_vector, p_direction);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Replicate (float p_value)
			{
				return new Vector3(p_value, p_value, p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Right (float p_scale = 1.0f)
			{
				return new Vector3(p_scale, 0.0f, 0.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Round (Vector3 p_vector)
			{
				return new Vector3(MathF.Round(p_vector.x), MathF.Round(p_vector.y), MathF.Round(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Round (Vector3 p_value, float p_snapInterval)
			{
				return Round(p_value / p_snapInterval) * p_snapInterval;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Round (Vector3 p_value, Vector3 p_snapInterval)
			{
				return Mul(Round(Div(p_value, p_snapInterval)), p_snapInterval);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int RoundToInt (Vector3 p_vector)
			{
				return new Vector3Int(MathF.RoundToInt(p_vector.x), MathF.RoundToInt(p_vector.y), MathF.RoundToInt(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool SameDirection (Vector3 p_lhs, Vector3 p_rhs)
			{
				return Dot(p_lhs, p_rhs) > 0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sign (Vector3 p_value)
			{
				return new Vector3(MathF.Sign(p_value.x), MathF.Sign(p_value.y), MathF.Sign(p_value.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sign (Vector3 p_value, float p_tolerance)
			{
				return new Vector3(MathF.Sign(p_value.x, p_tolerance), MathF.Sign(p_value.y, p_tolerance), MathF.Sign(p_value.z, p_tolerance));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sign (Vector3 p_value, Vector3 p_tolerance)
			{
				return new Vector3(MathF.Sign(p_value.x, p_tolerance.x), MathF.Sign(p_value.y, p_tolerance.y), MathF.Sign(p_value.z, p_tolerance.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int SignAsInt (Vector3 p_value)
			{
				return new Vector3Int(MathF.SignAsInt(p_value.x), MathF.SignAsInt(p_value.y), MathF.SignAsInt(p_value.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int SignAsInt (Vector3 p_value, float p_tolerance)
			{
				return new Vector3Int(MathF.SignAsInt(p_value.x, p_tolerance), MathF.SignAsInt(p_value.y, p_tolerance), MathF.SignAsInt(p_value.z, p_tolerance));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int SignAsInt (Vector3 p_value, Vector3 p_tolerance)
			{
				return new Vector3Int(MathF.SignAsInt(p_value.x, p_tolerance.x), MathF.SignAsInt(p_value.y, p_tolerance.y), MathF.SignAsInt(p_value.z, p_tolerance.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian SignedAngle (Vector3 p_from, Vector3 p_to)
			{
				return SignedAngle(p_from, p_to, Cross(p_from, p_to));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian SignedAngle (Vector3 p_from, Vector3 p_to, Vector3 p_axis)
			{
				return Angle(p_from, p_to) * MathF.SignPos(Det(p_from, p_to, p_axis));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 SignPos (Vector3 p_value)
			{
				return new Vector3(MathF.SignPos(p_value.x), MathF.SignPos(p_value.y), MathF.SignPos(p_value.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int SignPosAsInt (Vector3 p_value)
			{
				return new Vector3Int(MathF.SignPosAsInt(p_value.x), MathF.SignPosAsInt(p_value.y), MathF.SignPosAsInt(p_value.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sqrt (Vector3 p_vector)
			{
				return new Vector3(MathF.Sqrt(p_vector.x), MathF.Sqrt(p_vector.y), MathF.Sqrt(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sub (Vector3 p_lhs, Vector3 p_rhs)
			{
				return p_lhs - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sub (ref Vector3 p_lhs, Vector3 p_rhs)
			{
				p_lhs -= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sub (Vector3 p_lhs, float p_rhs)
			{
				return p_lhs - Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sub (ref Vector3 p_lhs, float p_rhs)
			{
				p_lhs -= Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Sub (float p_lhs, Vector3 p_rhs)
			{
				return Replicate(p_lhs) - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 To (this Vector3 p_this, Vector3 p_target)
			{
				return FromTo(p_this, p_target);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Up (float p_scale = 1.0f)
			{
				return new Vector3(0.0f, p_scale, 0.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 WeightedSum (Vector2 p_weight, Vector3 p_a, Vector3 p_b)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 WeightedSum (float p_weightA, float p_weightB, Vector3 p_a, Vector3 p_b)
			{
				return p_a * p_weightA + p_b * p_weightB;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 WeightedSum (Vector3 p_weight, Vector3 p_a, Vector3 p_b, Vector3 p_c)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_weight.z, p_a, p_b, p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 WeightedSum (float p_weightA, float p_weightB, float p_weightC, Vector3 p_a, Vector3 p_b, Vector3 p_c)
			{
				return p_a * p_weightA + p_b * p_weightB + p_c * p_weightC;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 WeightedSum (Vector4 p_weight, Vector3 p_a, Vector3 p_b, Vector3 p_c, Vector3 p_d)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_weight.z, p_weight.w, p_a, p_b, p_c, p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 WeightedSum (float p_weightA, float p_weightB, float p_weightC, float p_weightD, Vector3 p_a, Vector3 p_b, Vector3 p_c, Vector3 p_d)
			{
				return p_a * p_weightA + p_b * p_weightB + p_c * p_weightC + p_d * p_weightD;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 WithMagnitude (this Vector3 p_this, float p_magnitude)
			{
				return p_this.normalized * p_magnitude;
			}

		#endregion
	}
}
