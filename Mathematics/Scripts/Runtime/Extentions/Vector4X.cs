using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Extensions
{
	public static class Vector4X
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Abs (Vector4 p_vector)
			{
				return new Vector4(MathF.Abs(p_vector.x), MathF.Abs(p_vector.y), MathF.Abs(p_vector.z), MathF.Abs(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (ref Vector4 p_lhs, Vector4 p_rhs)
			{
				p_lhs += p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (Vector4 p_lhs, float p_rhs)
			{
				return p_lhs + Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (ref Vector4 p_lhs, float p_rhs)
			{
				p_lhs += Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (float p_lhs, Vector4 p_rhs)
			{
				return Replicate(p_lhs) + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Ceil (Vector4 p_vector)
			{
				return new Vector4(MathF.Ceil(p_vector.x), MathF.Ceil(p_vector.y), MathF.Ceil(p_vector.z), MathF.Ceil(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Center (Vector4 p_lhs, Vector4 p_rhs)
			{
				return (p_lhs + p_rhs) * 0.5f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 CenterDirection (Vector4 p_lhs, Vector4 p_rhs)
			{
				return (p_lhs + p_rhs).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, Vector4 p_min, Vector4 p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min.x, p_max.x), MathF.Clamp(p_vector.y, p_min.y, p_max.y), MathF.Clamp(p_vector.z, p_min.z, p_max.z), MathF.Clamp(p_vector.w, p_min.w, p_max.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, float p_min, Vector4 p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min, p_max.x), MathF.Clamp(p_vector.y, p_min, p_max.y), MathF.Clamp(p_vector.z, p_min, p_max.z), MathF.Clamp(p_vector.w, p_min, p_max.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, Vector4 p_min, float p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min.x, p_max), MathF.Clamp(p_vector.y, p_min.y, p_max), MathF.Clamp(p_vector.z, p_min.z, p_max), MathF.Clamp(p_vector.w, p_min.w, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, float p_min = 0.0f, float p_max = 1.0f)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min, p_max), MathF.Clamp(p_vector.y, p_min, p_max), MathF.Clamp(p_vector.z, p_min, p_max), MathF.Clamp(p_vector.w, p_min, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 ClampMagnitude (Vector4 p_vector, float p_minMagnitude, float p_maxMagnitude)
			{
				float thisMagnitude = p_vector.magnitude;
				return thisMagnitude < p_minMagnitude ? (p_vector / thisMagnitude) * p_minMagnitude :
					thisMagnitude > p_maxMagnitude ? (p_vector / thisMagnitude) * p_maxMagnitude : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 ClampMaxMagnitude (Vector4 p_vector, float p_maxMagnitude)
			{
				float magnitudeSquared = p_vector.magnitude;
				return magnitudeSquared > MathF.Square(p_maxMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_maxMagnitude) : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 ClampMinMagnitude (Vector4 p_vector, float p_minMagnitude)
			{
				float magnitudeSquared = p_vector.sqrMagnitude;
				return magnitudeSquared < MathF.Square(p_minMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_minMagnitude) : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (Vector4 p_lhs, Vector4 p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (Vector4 p_lhs, Vector4 p_rhs)
			{
				return MathF.Square(p_rhs.x - p_lhs.x) + MathF.Square(p_rhs.y - p_lhs.y) + MathF.Square(p_rhs.z - p_lhs.z) + MathF.Square(p_rhs.w - p_lhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Direction (Vector4 p_from, Vector4 p_to)
			{
				return FromTo(p_from, p_to).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DirectionTo (this Vector4 p_this, Vector4 p_to)
			{
				return Direction(p_this, p_to);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Div (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(p_lhs.x / p_rhs.x, p_lhs.y / p_rhs.y, p_lhs.z / p_rhs.z, p_lhs.w / p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Div (ref Vector4 p_lhs, Vector4 p_rhs)
			{
				p_lhs = Div(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Div (Vector4 p_lhs, float p_rhs)
			{
				return p_lhs / p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Div (ref Vector4 p_lhs, float p_rhs)
			{
				p_lhs /= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (Vector4 p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (ref Vector4 p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (Vector4 p_dividend, float p_divisor, Vector4 p_defaultValue)
			{
				return p_divisor.IsZero() ? p_defaultValue : p_dividend / p_divisor;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (ref Vector4 p_dividend, float p_divisor, Vector4 p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (Vector4 p_dividend, Vector4 p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (ref Vector4 p_dividend, Vector4 p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (Vector4 p_dividend, Vector4 p_divisor, Vector4 p_defaultValue)
			{
				return new Vector4
				(
					MathF.DivSafe(p_dividend.x, p_divisor.x, p_defaultValue.x),
					MathF.DivSafe(p_dividend.y, p_divisor.y, p_defaultValue.y),
					MathF.DivSafe(p_dividend.z, p_divisor.z, p_defaultValue.z),
					MathF.DivSafe(p_dividend.w, p_divisor.w, p_defaultValue.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (ref Vector4 p_dividend, Vector4 p_divisor, Vector4 p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Dot (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs.x * p_rhs.x + p_lhs.y * p_rhs.y + p_lhs.z * p_rhs.z + p_lhs.w * p_rhs.w;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Floor (Vector4 p_vector)
			{
				return new Vector4(MathF.Floor(p_vector.x), MathF.Floor(p_vector.y), MathF.Floor(p_vector.z), MathF.Floor(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Frac (Vector4 p_value)
			{
				return p_value - Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 FromTo (Vector4 p_from, Vector4 p_to)
			{
				return p_to - p_from;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetAbs (this Vector4 p_this)
			{
				return Abs(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAbsMax (this Vector4 p_this)
			{
				return Max(Abs(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAbsMin (this Vector4 p_this)
			{
				return Min(Abs(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMax (this Vector4 p_this)
			{
				return Max(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMaxAbs (this Vector4 p_this)
			{
				return MathF.Abs(Max(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMin (this Vector4 p_this)
			{
				return Min(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMinAbs (this Vector4 p_this)
			{
				return MathF.Abs(Min(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 InverseLerp (Vector4 p_a, Vector4 p_b, Vector4 p_value)
			{
				return Div(p_value - p_a, p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 InverseLerpClamped (Vector4 p_a, Vector4 p_b, Vector4 p_value, Vector4 p_min, Vector4 p_max)
			{
				return Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsDifferent (Vector4 p_lhs, Vector4 p_rhs)
			{
				return !IsEqual(p_lhs, p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsDifferent4D (Vector4 p_lhs, Vector4 p_rhs)
			{
				return !IsEqual4D(p_lhs, p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsEqual (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs == p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsEqual4D (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4b(p_lhs.x == p_rhs.x, p_lhs.y == p_rhs.y, p_lhs.z == p_rhs.z, p_lhs.w == p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsGreater (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs.x > p_rhs.x && p_lhs.y > p_rhs.y && p_lhs.z > p_rhs.z && p_lhs.w > p_rhs.w;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsGreater4D (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4b(p_lhs.x > p_rhs.x, p_lhs.y > p_rhs.y, p_lhs.z > p_rhs.z, p_lhs.w > p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsGreaterEqual (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs.x >= p_rhs.x && p_lhs.y >= p_rhs.y && p_lhs.z >= p_rhs.z && p_lhs.w >= p_rhs.w;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsGreaterEqual4D (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4b(p_lhs.x >= p_rhs.x, p_lhs.y >= p_rhs.y, p_lhs.z >= p_rhs.z, p_lhs.w >= p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsLess (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs.x < p_rhs.x && p_lhs.y < p_rhs.y && p_lhs.z < p_rhs.z && p_lhs.w < p_rhs.w;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsLess4D (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4b(p_lhs.x < p_rhs.x, p_lhs.y < p_rhs.y, p_lhs.z < p_rhs.z, p_lhs.w < p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsLessEqual (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs.x <= p_rhs.x && p_lhs.y <= p_rhs.y && p_lhs.z <= p_rhs.z && p_lhs.w <= p_rhs.w;

			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsLessEqual4D (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4b(p_lhs.x <= p_rhs.x, p_lhs.y <= p_rhs.y, p_lhs.z <= p_rhs.z, p_lhs.w <= p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return MathF.IsNearlyEqual(p_lhs.x, p_rhs.x, p_tolerance) && MathF.IsNearlyEqual(p_lhs.y, p_rhs.y, p_tolerance) && MathF.IsNearlyEqual(p_lhs.z, p_rhs.z, p_tolerance) && MathF.IsNearlyEqual(p_lhs.w, p_rhs.w, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyEqual4D (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return new Vector4b
				(
					MathF.IsNearlyEqual(p_lhs.x, p_rhs.x, p_tolerance),
					MathF.IsNearlyEqual(p_lhs.y, p_rhs.y, p_tolerance),
					MathF.IsNearlyEqual(p_lhs.z, p_rhs.z, p_tolerance),
					MathF.IsNearlyEqual(p_lhs.w, p_rhs.w, p_tolerance)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return MathF.IsNearlyEqual(p_lhs.x, p_rhs.x, p_tolerance.x) && MathF.IsNearlyEqual(p_lhs.y, p_rhs.y, p_tolerance.y) && MathF.IsNearlyEqual(p_lhs.z, p_rhs.z, p_tolerance.z) && MathF.IsNearlyEqual(p_lhs.w, p_rhs.w, p_tolerance.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyEqual4D (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return new Vector4b
				(
					MathF.IsNearlyEqual(p_lhs.x, p_rhs.x, p_tolerance.x),
					MathF.IsNearlyEqual(p_lhs.y, p_rhs.y, p_tolerance.y),
					MathF.IsNearlyEqual(p_lhs.z, p_rhs.z, p_tolerance.z),
					MathF.IsNearlyEqual(p_lhs.w, p_rhs.w, p_tolerance.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyGreater (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return MathF.IsNearlyGreater(p_lhs.x, p_rhs.x, p_tolerance) && MathF.IsNearlyGreater(p_lhs.y, p_rhs.y, p_tolerance) && MathF.IsNearlyGreater(p_lhs.z, p_rhs.z, p_tolerance) && MathF.IsNearlyGreater(p_lhs.w, p_rhs.w, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyGreater4D (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return new Vector4b
				(
					MathF.IsNearlyGreater(p_lhs.x, p_rhs.x, p_tolerance),
					MathF.IsNearlyGreater(p_lhs.y, p_rhs.y, p_tolerance),
					MathF.IsNearlyGreater(p_lhs.z, p_rhs.z, p_tolerance),
					MathF.IsNearlyGreater(p_lhs.w, p_rhs.w, p_tolerance)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyGreater (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return new Vector4b
				(
					MathF.IsNearlyGreater(p_lhs.x, p_rhs.x, p_tolerance.x),
					MathF.IsNearlyGreater(p_lhs.y, p_rhs.y, p_tolerance.y),
					MathF.IsNearlyGreater(p_lhs.z, p_rhs.z, p_tolerance.z),
					MathF.IsNearlyGreater(p_lhs.w, p_rhs.w, p_tolerance.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyGreater4D (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return new Vector4b
				(
					MathF.IsNearlyGreater(p_lhs.x, p_rhs.x, p_tolerance.x),
					MathF.IsNearlyGreater(p_lhs.y, p_rhs.y, p_tolerance.y),
					MathF.IsNearlyGreater(p_lhs.z, p_rhs.z, p_tolerance.z),
					MathF.IsNearlyGreater(p_lhs.w, p_rhs.w, p_tolerance.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyGreaterEqual (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return MathF.IsNearlyGreaterEqual(p_lhs.x, p_rhs.x, p_tolerance) && MathF.IsNearlyGreaterEqual(p_lhs.y, p_rhs.y, p_tolerance) && MathF.IsNearlyGreaterEqual(p_lhs.z, p_rhs.z, p_tolerance) && MathF.IsNearlyGreaterEqual(p_lhs.w, p_rhs.w, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyGreaterEqual4D (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return new Vector4b
				(
					MathF.IsNearlyGreaterEqual(p_lhs.x, p_rhs.x, p_tolerance),
					MathF.IsNearlyGreaterEqual(p_lhs.y, p_rhs.y, p_tolerance),
					MathF.IsNearlyGreaterEqual(p_lhs.z, p_rhs.z, p_tolerance),
					MathF.IsNearlyGreaterEqual(p_lhs.w, p_rhs.w, p_tolerance)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyGreaterEqual (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return MathF.IsNearlyGreaterEqual(p_lhs.x, p_rhs.x, p_tolerance.x) && MathF.IsNearlyGreaterEqual(p_lhs.y, p_rhs.y, p_tolerance.y) && MathF.IsNearlyGreaterEqual(p_lhs.z, p_rhs.z, p_tolerance.z) && MathF.IsNearlyGreaterEqual(p_lhs.w, p_rhs.w, p_tolerance.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyGreaterEqual4D (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return new Vector4b
				(
					MathF.IsNearlyGreaterEqual(p_lhs.x, p_rhs.x, p_tolerance.x),
					MathF.IsNearlyGreaterEqual(p_lhs.y, p_rhs.y, p_tolerance.y),
					MathF.IsNearlyGreaterEqual(p_lhs.z, p_rhs.z, p_tolerance.z),
					MathF.IsNearlyGreaterEqual(p_lhs.w, p_rhs.w, p_tolerance.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyLess (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return MathF.IsNearlyLess(p_lhs.x, p_rhs.x, p_tolerance) && MathF.IsNearlyLess(p_lhs.y, p_rhs.y, p_tolerance) && MathF.IsNearlyLess(p_lhs.z, p_rhs.z, p_tolerance) && MathF.IsNearlyLess(p_lhs.w, p_rhs.w, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyLess4D (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return new Vector4b
				(
					MathF.IsNearlyLess(p_lhs.x, p_rhs.x, p_tolerance),
					MathF.IsNearlyLess(p_lhs.y, p_rhs.y, p_tolerance),
					MathF.IsNearlyLess(p_lhs.z, p_rhs.z, p_tolerance),
					MathF.IsNearlyLess(p_lhs.w, p_rhs.w, p_tolerance)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyLess (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return MathF.IsNearlyLess(p_lhs.x, p_rhs.x, p_tolerance.x) && MathF.IsNearlyLess(p_lhs.y, p_rhs.y, p_tolerance.y) && MathF.IsNearlyLess(p_lhs.z, p_rhs.z, p_tolerance.z) && MathF.IsNearlyLess(p_lhs.w, p_rhs.w, p_tolerance.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyLess4D (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return new Vector4b
				(
					MathF.IsNearlyLess(p_lhs.x, p_rhs.x, p_tolerance.x),
					MathF.IsNearlyLess(p_lhs.y, p_rhs.y, p_tolerance.y),
					MathF.IsNearlyLess(p_lhs.z, p_rhs.z, p_tolerance.z),
					MathF.IsNearlyLess(p_lhs.w, p_rhs.w, p_tolerance.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyLessEqual (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return MathF.IsNearlyLessEqual(p_lhs.x, p_rhs.x, p_tolerance) && MathF.IsNearlyLessEqual(p_lhs.y, p_rhs.y, p_tolerance) && MathF.IsNearlyLessEqual(p_lhs.z, p_rhs.z, p_tolerance) && MathF.IsNearlyLessEqual(p_lhs.w, p_rhs.w, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyLessEqual4D (Vector4 p_lhs, Vector4 p_rhs, float p_tolerance = float.Epsilon)
			{
				return new Vector4b
				(
					MathF.IsNearlyLessEqual(p_lhs.x, p_rhs.x, p_tolerance),
					MathF.IsNearlyLessEqual(p_lhs.y, p_rhs.y, p_tolerance),
					MathF.IsNearlyLessEqual(p_lhs.z, p_rhs.z, p_tolerance),
					MathF.IsNearlyLessEqual(p_lhs.w, p_rhs.w, p_tolerance)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyLessEqual (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return MathF.IsNearlyLessEqual(p_lhs.x, p_rhs.x, p_tolerance.x) && MathF.IsNearlyLessEqual(p_lhs.y, p_rhs.y, p_tolerance.y) && MathF.IsNearlyLessEqual(p_lhs.z, p_rhs.z, p_tolerance.z) && MathF.IsNearlyLessEqual(p_lhs.w, p_rhs.w, p_tolerance.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyLessEqual4D (Vector4 p_lhs, Vector4 p_rhs, Vector4 p_tolerance)
			{
				return new Vector4b
				(
					MathF.IsNearlyLessEqual(p_lhs.x, p_rhs.x, p_tolerance.x),
					MathF.IsNearlyLessEqual(p_lhs.y, p_rhs.y, p_tolerance.y),
					MathF.IsNearlyLessEqual(p_lhs.z, p_rhs.z, p_tolerance.z),
					MathF.IsNearlyLessEqual(p_lhs.w, p_rhs.w, p_tolerance.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this Vector4 p_this, float p_tolerance = float.Epsilon)
			{
				return MathF.IsNearlyZero(p_this.x, p_tolerance) && MathF.IsNearlyZero(p_this.y, p_tolerance) && MathF.IsNearlyZero(p_this.z, p_tolerance) && MathF.IsNearlyZero(p_this.w, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyZero4D (this Vector4 p_value, float p_tolerance = float.Epsilon)
			{
				return new Vector4b
				(
					MathF.IsNearlyZero(p_value.x, p_tolerance),
					MathF.IsNearlyZero(p_value.y, p_tolerance),
					MathF.IsNearlyZero(p_value.z, p_tolerance),
					MathF.IsNearlyZero(p_value.w, p_tolerance)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this Vector4 p_this, Vector4 p_tolerance)
			{
				return MathF.IsNearlyZero(p_this.x, p_tolerance.x) && MathF.IsNearlyZero(p_this.y, p_tolerance.y) && MathF.IsNearlyZero(p_this.z, p_tolerance.z) && MathF.IsNearlyZero(p_this.w, p_tolerance.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNearlyZero4D (this Vector4 p_value, Vector4 p_tolerance)
			{
				return new Vector4b
				(
					MathF.IsNearlyZero(p_value.x, p_tolerance.x),
					MathF.IsNearlyZero(p_value.y, p_tolerance.y),
					MathF.IsNearlyZero(p_value.z, p_tolerance.z),
					MathF.IsNearlyZero(p_value.w, p_tolerance.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegative (this Vector4 p_this)
			{
				return MathF.IsNegative(p_this.x) && MathF.IsNegative(p_this.y) && MathF.IsNegative(p_this.z) && MathF.IsNegative(p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNegative4D (this Vector4 p_value)
			{
				return new Vector4b
				(
					MathF.IsNegative(p_value.x),
					MathF.IsNegative(p_value.y),
					MathF.IsNegative(p_value.z),
					MathF.IsNegative(p_value.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegativeOrZero (this Vector4 p_this)
			{
				return MathF.IsNegativeOrZero(p_this.x) && MathF.IsNegativeOrZero(p_this.y) && MathF.IsNegativeOrZero(p_this.z) && MathF.IsNegativeOrZero(p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsNegativeOrZero4D (this Vector4 p_value)
			{
				return new Vector4b
				(
					MathF.IsNegativeOrZero(p_value.x),
					MathF.IsNegativeOrZero(p_value.y),
					MathF.IsNegativeOrZero(p_value.z),
					MathF.IsNegativeOrZero(p_value.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositive (this Vector4 p_this)
			{
				return MathF.IsPositive(p_this.x) && MathF.IsPositive(p_this.y) && MathF.IsPositive(p_this.z) && MathF.IsPositive(p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsPositive4D (this Vector4 p_this)
			{
				return new Vector4b
				(
					MathF.IsPositive(p_this.x),
					MathF.IsPositive(p_this.y),
					MathF.IsPositive(p_this.z),
					MathF.IsPositive(p_this.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositiveOrZero (this Vector4 p_this)
			{
				return MathF.IsPositiveOrZero(p_this.x) && MathF.IsPositiveOrZero(p_this.y) && MathF.IsPositiveOrZero(p_this.z) && MathF.IsPositiveOrZero(p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsPositiveOrZero4D (this Vector4 p_this)
			{
				return new Vector4b
				(
					MathF.IsPositiveOrZero(p_this.x),
					MathF.IsPositiveOrZero(p_this.y),
					MathF.IsPositiveOrZero(p_this.z),
					MathF.IsPositiveOrZero(p_this.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (this Vector4 p_this)
			{
				return MathF.IsZero(p_this.x) && MathF.IsZero(p_this.y) && MathF.IsZero(p_this.z) && MathF.IsZero(p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsZero4D (this Vector4 p_value)
			{
				return new Vector4b
				(
					MathF.IsZero(p_value.x),
					MathF.IsZero(p_value.y),
					MathF.IsZero(p_value.z),
					MathF.IsZero(p_value.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Lerp (Vector4 p_a, Vector4 p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Lerp (Vector4 p_a, Vector4 p_b, Vector4 p_t)
			{
				return new Vector4(MathF.Lerp(p_a.x, p_b.x, p_t.x), MathF.Lerp(p_a.y, p_b.y, p_t.y), MathF.Lerp(p_a.z, p_b.z, p_t.z), MathF.Lerp(p_a.w, p_b.w, p_t.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 LerpClamped (Vector4 p_a, Vector4 p_b, float p_t)
			{
				return LerpClamped(p_a, p_b, new Vector4(p_t, p_t, p_t, p_t));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 LerpClamped (Vector4 p_a, Vector4 p_b, Vector4 p_t)
			{
				return new Vector4(MathF.LerpClamped(p_a.x, p_b.x, p_t.x), MathF.LerpClamped(p_a.y, p_b.y, p_t.y), MathF.LerpClamped(p_a.z, p_b.z, p_t.z), MathF.LerpClamped(p_a.w, p_b.w, p_t.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (Vector4 p_vector)
			{
				return MathF.Max(p_vector.x, p_vector.y, p_vector.z, p_vector.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(MathF.Max(p_lhs.x, p_rhs.x), MathF.Max(p_lhs.y, p_rhs.y), MathF.Max(p_lhs.z, p_rhs.z), MathF.Max(p_lhs.w, p_rhs.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return Max(Max(Max(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (params Vector4[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (Vector4 p_vector)
			{
				return MathF.Min(p_vector.x, p_vector.y, p_vector.z, p_vector.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(MathF.Min(p_lhs.x, p_rhs.x), MathF.Min(p_lhs.y, p_rhs.y), MathF.Min(p_lhs.z, p_rhs.z), MathF.Min(p_lhs.w, p_rhs.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return Min(Min(Min(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (params Vector4[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(p_lhs.x * p_rhs.x, p_lhs.y * p_rhs.y, p_lhs.z * p_rhs.z, p_lhs.w * p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (ref Vector4 p_lhs, Vector4 p_rhs)
			{
				p_lhs = Mul(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (Vector4 p_lhs, float p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (ref Vector4 p_lhs, float p_rhs)
			{
				p_lhs *= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (float p_lhs, Vector4 p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Normalize (ref Vector4 p_vector)
			{
				p_vector = p_vector.Normalized();
				return p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Normalize (ref Vector4 p_vector, out float p_magnitude)
			{
				p_vector = p_vector.Normalized(out p_magnitude);
				return p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Normalized (this Vector4 p_this)
			{
				return p_this / p_this.magnitude;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Normalized (this Vector4 p_this, out float p_magnitude)
			{
				p_magnitude = p_this.magnitude;
				return p_this / p_magnitude;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Normalized (this Vector4 p_this, out Vector4 p_direction, out float p_magnitude)
			{
				p_direction = p_this.Normalized(out p_magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizedSafe (this Vector4 p_this, float p_defaultValue = 0.0f)
			{
				return NormalizedSafe(p_this, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizedSafe (this Vector4 p_this, Vector4 p_defaultValue)
			{
				return p_this.IsZero() ? p_defaultValue : Normalized(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizedSafe (this Vector4 p_this, out float p_magnitude, float p_defaultValue = 0.0f)
			{
				p_magnitude = p_this.magnitude;
				return DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizedSafe (this Vector4 p_this, out float p_magnitude, Vector4 p_defaultValue)
			{
				p_magnitude = p_this.magnitude;
				return DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void NormalizedSafe (this Vector4 p_this, out Vector4 p_direction, out float p_magnitude, float p_defaultValue = 0.0f)
			{
				p_magnitude = p_this.magnitude;
				p_direction = DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void NormalizedSafe (this Vector4 p_this, out Vector4 p_direction, out float p_magnitude, Vector4 p_defaultValue)
			{
				p_magnitude = p_this.magnitude;
				p_direction = DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizeSafe (ref Vector4 p_vector, float p_defaultValue = 0.0f)
			{
				p_vector = p_vector.NormalizedSafe(p_defaultValue);
				return p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizeSafe (ref Vector4 p_vector, Vector4 p_defaultValue)
			{
				p_vector = p_vector.NormalizedSafe(p_defaultValue);
				return p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizeSafe (ref Vector4 p_vector, out float p_magnitude, float p_defaultValue = 0.0f)
			{
				p_vector = p_vector.NormalizedSafe(out p_magnitude, p_defaultValue);
				return p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizeSafe (ref Vector4 p_vector, out float p_magnitude, Vector4 p_defaultValue)
			{
				p_vector = p_vector.NormalizedSafe(out p_magnitude, p_defaultValue);
				return p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Replicate (float p_value)
			{
				return new Vector4(p_value, p_value, p_value, p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Round (Vector4 p_vector)
			{
				return new Vector4(MathF.Round(p_vector.x), MathF.Round(p_vector.y), MathF.Round(p_vector.z), MathF.Round(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sign (Vector4 p_value)
			{
				return new Vector4(MathF.Sign(p_value.x), MathF.Sign(p_value.y), MathF.Sign(p_value.z), MathF.Sign(p_value.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sign (Vector4 p_value, float p_tolerance)
			{
				return new Vector4(MathF.Sign(p_value.x, p_tolerance), MathF.Sign(p_value.y, p_tolerance), MathF.Sign(p_value.z, p_tolerance), MathF.Sign(p_value.w, p_tolerance));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sign (Vector4 p_value, Vector4 p_tolerance)
			{
				return new Vector4(MathF.Sign(p_value.x, p_tolerance.x), MathF.Sign(p_value.y, p_tolerance.y), MathF.Sign(p_value.z, p_tolerance.z), MathF.Sign(p_value.w, p_tolerance.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 SignPos (Vector4 p_value)
			{
				return new Vector4(MathF.SignPos(p_value.x), MathF.SignPos(p_value.y), MathF.SignPos(p_value.z), MathF.SignPos(p_value.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sqrt (Vector4 p_vector)
			{
				return new Vector4(MathF.Sqrt(p_vector.x), MathF.Sqrt(p_vector.y), MathF.Sqrt(p_vector.z), MathF.Sqrt(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (ref Vector4 p_lhs, Vector4 p_rhs)
			{
				p_lhs -= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (Vector4 p_lhs, float p_rhs)
			{
				return p_lhs - Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (ref Vector4 p_lhs, float p_rhs)
			{
				p_lhs -= Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (float p_lhs, Vector4 p_rhs)
			{
				return Replicate(p_lhs) - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 To (this Vector4 p_this, Vector4 p_target)
			{
				return FromTo(p_this, p_target);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (Vector2 p_weight, Vector4 p_a, Vector4 p_b)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (float p_weightA, float p_weightB, Vector4 p_a, Vector4 p_b)
			{
				return p_a * p_weightA + p_b * p_weightB;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (Vector3 p_weight, Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_weight.z, p_a, p_b, p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (float p_weightA, float p_weightB, float p_weightC, Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return p_a * p_weightA + p_b * p_weightB + p_c * p_weightC;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (Vector4 p_weight, Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_weight.z, p_weight.w, p_a, p_b, p_c, p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (float p_weightA, float p_weightB, float p_weightC, float p_weightD, Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return p_a * p_weightA + p_b * p_weightB + p_c * p_weightC + p_d * p_weightD;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WithMagnitude (this Vector4 p_this, float p_magnitude)
			{
				return p_this.normalized * p_magnitude;
			}

		#endregion
	}
}
