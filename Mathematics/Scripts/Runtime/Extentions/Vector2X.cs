using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;
using ZkTools.Mathematics.Angles;
using ZkTools.Mathematics.Ranges;

namespace ZkTools.Mathematics.Extensions
{
	public static class Vector2X
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Abs (Vector2 p_vector)
			{
				return new Vector2(MathF.Abs(p_vector.x), MathF.Abs(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Add (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Add (ref Vector2 p_lhs, Vector2 p_rhs)
			{
				p_lhs += p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Add (Vector2 p_lhs, float p_rhs)
			{
				return p_lhs + Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Add (ref Vector2 p_lhs, float p_rhs)
			{
				p_lhs += Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Add (float p_lhs, Vector2 p_rhs)
			{
				return Replicate(p_lhs) + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian Angle (Vector2 p_direction)
			{
				return Trigo.Atan2(p_direction.y, p_direction.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian Angle (Vector2 p_from, Vector2 p_to)
			{
				return Trigo.Acos(Dot(p_from, p_to) / MathF.Sqrt(p_from.sqrMagnitude * p_to.sqrMagnitude));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian AngleCCW (Vector2 p_from, Vector2 p_to)
			{
				return Det(p_from, p_to) > 0 ? Angle(p_from, p_to) : Radian.One - Angle(p_from, p_to);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian AngleCW (Vector2 p_from, Vector2 p_to)
			{
				return Det(p_from, p_to) < 0 ? Angle(p_from, p_to) : Radian.One - Angle(p_from, p_to);
			}

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
			public static Vector2 Clamp (Vector2 p_vector, float p_min = 0.0f, float p_max = 1.0f)
			{
				return new Vector2(MathF.Clamp(p_vector.x, p_min, p_max), MathF.Clamp(p_vector.y, p_min, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 ClampMagnitude (Vector2 p_vector, float p_minMagnitude, float p_maxMagnitude)
			{
				float thisMagnitude = p_vector.magnitude;
				return thisMagnitude < p_minMagnitude ? (p_vector / thisMagnitude) * p_minMagnitude :
						thisMagnitude > p_maxMagnitude ? (p_vector / thisMagnitude) * p_maxMagnitude : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 ClampMaxMagnitude (Vector2 p_vector, float p_maxMagnitude)
			{
				float magnitudeSquared = p_vector.magnitude;
				return magnitudeSquared > MathF.Square(p_maxMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_maxMagnitude) : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 ClampMinMagnitude (Vector2 p_vector, float p_minMagnitude)
			{
				float magnitudeSquared = p_vector.sqrMagnitude;
				return magnitudeSquared < MathF.Square(p_minMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_minMagnitude) : p_vector;
			}

			//  determinant
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Det (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs.x * p_rhs.y - p_lhs.y * p_rhs.x;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Direction (Radian p_angle)
			{
				return new Vector2(Trigo.Cos(p_angle), Trigo.Sin(p_angle));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Direction (Vector2 p_from, Vector2 p_to)
			{
				return FromTo(p_from, p_to).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DirectionTo (this Vector2 p_this, Vector2 p_to)
			{
				return Direction(p_this, p_to);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (Vector2 p_lhs, Vector2 p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (Vector2 p_lhs, Vector2 p_rhs)
			{
				return MathF.Square(p_rhs.x - p_lhs.x) + MathF.Square(p_rhs.y - p_lhs.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Div (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs / p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Div (ref Vector2 p_lhs, Vector2 p_rhs)
			{
				p_lhs = Div(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Div (Vector2 p_lhs, float p_rhs)
			{
				return p_lhs / p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Div (ref Vector2 p_lhs, float p_rhs)
			{
				p_lhs /= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DivSafe (Vector2 p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DivSafe (ref Vector2 p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DivSafe (Vector2 p_dividend, float p_divisor, Vector2 p_defaultValue)
			{
				return p_divisor.IsZero() ? p_defaultValue : p_dividend / p_divisor;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DivSafe (ref Vector2 p_dividend, float p_divisor, Vector2 p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DivSafe (Vector2 p_dividend, Vector2 p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DivSafe (ref Vector2 p_dividend, Vector2 p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DivSafe (Vector2 p_dividend, Vector2 p_divisor, Vector2 p_defaultValue)
			{
				return new Vector2
				(
					MathF.DivSafe(p_dividend.x, p_divisor.x, p_defaultValue.x),
					MathF.DivSafe(p_dividend.y, p_divisor.y, p_defaultValue.y)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 DivSafe (ref Vector2 p_dividend, Vector2 p_divisor, Vector2 p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Dot (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs.x * p_rhs.x + p_lhs.y * p_rhs.y;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Down (float p_scale = 1.0f)
			{
				return new Vector2(0.0f, p_scale);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Exec (ref Vector2 p_vector, Func<float, float> p_action)
			{
				p_vector.x = p_action?.Invoke(p_vector.x) ?? p_vector.x;
				p_vector.y = p_action?.Invoke(p_vector.y) ?? p_vector.y;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Exec (ref Vector2 p_vector, Func<float, float> p_xAction, Func<float, float> p_yAction)
			{
				p_vector.x = p_xAction?.Invoke(p_vector.x) ?? p_vector.x;
				p_vector.y = p_yAction?.Invoke(p_vector.y) ?? p_vector.y;
			}

			// p_direction must be normalized !!!;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 ExtractDotVector (Vector2 p_vector, Vector2 p_direction)
			{
				return p_direction * Vector2.Dot(p_vector, p_direction);
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
			public static Vector2 Frac (Vector2 p_value)
			{
				return p_value - Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 FromTo (Vector2 p_from, Vector2 p_to)
			{
				return p_to - p_from;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetAbs (this Vector2 p_this)
			{
				return Abs(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAbsMax (this Vector2 p_this)
			{
				return Max(Abs(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAbsMin (this Vector2 p_this)
			{
				return Min(Abs(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitude (this Vector2 p_this, out Vector2 p_direction, out float p_magnitude)
			{
				p_magnitude = p_this.magnitude;
				p_direction = p_this / p_magnitude;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector2 p_direction, float p_magnitude) GetDirectionAndMagnitude (this Vector2 p_this)
			{
				float magnitude = p_this.magnitude;
				Vector2 direction = p_this / magnitude;
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitudeSafe (this Vector2 p_this, out Vector2 p_direction, out float p_magnitude, float p_defaultValue = 0.0f)
			{
				p_magnitude = p_this.magnitude;
				p_direction = DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitudeSafe (this Vector2 p_this, out Vector2 p_direction, out float p_magnitude, Vector2 p_defaultValue)
			{
				p_magnitude = p_this.magnitude;
				p_direction = DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector2 p_direction, float p_magnitude) GetDirectionAndMagnitudeSafe (this Vector2 p_this, float p_defaultValue = 0.0f)
			{
				float magnitude = p_this.magnitude;
				Vector2 direction = DivSafe(p_this, magnitude, p_defaultValue);
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector2 p_direction, float p_magnitude) GetDirectionAndMagnitudeSafe (this Vector2 p_this, Vector2 p_defaultValue)
			{
				float magnitude = p_this.magnitude;
				Vector2 direction = DivSafe(p_this, magnitude, p_defaultValue);
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMax (this Vector2 p_this)
			{
				return Max(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMaxAbs (this Vector2 p_this)
			{
				return MathF.Abs(Max(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMin (this Vector2 p_this)
			{
				return Min(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMinAbs (this Vector2 p_this)
			{
				return MathF.Abs(Min(p_this));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsCollinear (Vector2 p_lhs, Vector2 p_rhs)
			{
				return Det(p_lhs, p_rhs).IsZero();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNormalized (this Vector2 p_this)
			{
				return p_this.sqrMagnitude == 1.0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsUnit (this Vector2 p_this, float p_epsilon = float.Epsilon)
			{
				return p_this.sqrMagnitude == 1.0f;
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

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Left (float p_scale = 1.0f)
			{
				return new Vector2(p_scale, 0.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Lerp (Vector2 p_a, Vector2 p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Lerp (Vector2 p_a, Vector2 p_b, Vector2 p_t)
			{
				return new Vector2(MathF.Lerp(p_a.x, p_b.x, p_t.x), MathF.Lerp(p_a.y, p_b.y, p_t.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 LerpClamped (Vector2 p_a, Vector2 p_b, float p_t)
			{
				return p_a + (p_b - p_a) * MathF.Clamp(p_t);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 LerpClamped (Vector2 p_a, Vector2 p_b, Vector2 p_t)
			{
				return new Vector2(MathF.LerpClamped(p_a.x, p_b.x, p_t.x), MathF.LerpClamped(p_a.y, p_b.y, p_t.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (Vector2 p_vector)
			{
				return MathF.Max(p_vector.x, p_vector.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Max (Vector2 p_lhs, Vector2 p_rhs)
			{
				return new Vector2(MathF.Max(p_lhs.x, p_rhs.x), MathF.Max(p_lhs.y, p_rhs.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Max (Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Max (Vector2 p_a, Vector2 p_b, Vector2 p_c, Vector2 p_d)
			{
				return Max(Max(Max(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Max (params Vector2[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (Vector2 p_vector)
			{
				return MathF.Min(p_vector.x, p_vector.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Min (Vector2 p_lhs, Vector2 p_rhs)
			{
				return new Vector2(MathF.Min(p_lhs.x, p_rhs.x), MathF.Min(p_lhs.y, p_rhs.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Min (Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Min (Vector2 p_a, Vector2 p_b, Vector2 p_c, Vector2 p_d)
			{
				return Min(Min(Min(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Min (params Vector2[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Mul (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Mul (ref Vector2 p_lhs, Vector2 p_rhs)
			{
				p_lhs = Mul(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Mul (Vector2 p_lhs, float p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Mul (ref Vector2 p_lhs, float p_rhs)
			{
				p_lhs *= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Mul (float p_lhs, Vector2 p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Normalized (this Vector2 p_vector)
			{
				return p_vector / p_vector.magnitude;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 NormalizedSafe(this Vector2 p_vector, float p_defaultValue = 0.0f)
			{
				return NormalizedSafe(p_vector, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 NormalizedSafe(this Vector2 p_vector, Vector2 p_defaultValue)
			{
				return p_vector.IsZero() ? p_defaultValue : Normalized(p_vector);
			}

			// Counter Clock Wise !!!
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Perpendicular (this Vector2 p_this)
			{
				return Rotate90CCW(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 PerpendicularInv (this Vector2 p_this)
			{
				return Rotate90CW(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Remap (Vector2 p_value, Vector2 p_inMin, Vector2 p_inMax, Vector2 p_outMin, Vector2 p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerp(p_inMin, p_inMax, p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Remap (Vector2 p_value, Rect p_in, Rect p_out)
			{
				return Remap(p_value, p_in.min, p_in.max, p_out.min, p_out.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 RemapClamped (Vector2 p_value, Vector2 p_inMin, Vector2 p_inMax, Vector2 p_outMin, Vector2 p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerpClamped(p_inMin, p_inMax, p_value, Vector2.zero, Vector2.one));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 RemapClamped (Vector2 p_value, Rect p_in, Rect p_out)
			{
				return RemapClamped(p_value, p_in.min, p_in.max, p_out.min, p_out.max);
			}

			public static Vector2 RemoveDotVector (Vector2 p_vector, Vector2 p_direction)
			{
				return p_vector - ExtractDotVector(p_vector, p_direction);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Replicate (float p_value)
			{
				return new Vector2(p_value, p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Right (float p_scale = 1.0f)
			{
				return new Vector2(p_scale, 0.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Rotate (Vector2 p_vector, Radian p_angle)
			{
				float cos = Trigo.Cos(p_angle);
				float sin = Trigo.Sin(p_angle);
				return new Vector2(cos * p_vector.x - sin * p_vector.y, sin * p_vector.x + cos * p_vector.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Rotate90CW (Vector2 p_vector)
			{
				return new Vector2(p_vector.y, -p_vector.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Rotate90CCW (Vector2 p_vector)
			{
				return new Vector2(-p_vector.y, p_vector.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 RotateAround (Vector2 p_vector, Vector2 p_pivot, Radian p_angle)
			{
				return Rotate(p_vector - p_pivot, p_angle) + p_pivot;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Round (Vector2 p_vector)
			{
				return new Vector2(MathF.Round(p_vector.x), MathF.Round(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Round (Vector2 p_value, float p_snapInterval)
			{
				return Round(p_value / p_snapInterval) * p_snapInterval;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Round (Vector2 p_value, Vector2 p_snapInterval)
			{
				return Round(p_value / p_snapInterval) * p_snapInterval;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2Int RoundToInt (Vector2 p_vector)
			{
				return new Vector2Int(MathF.RoundToInt(p_vector.x), MathF.RoundToInt(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool SameDirection (Vector2 p_lhs, Vector2 p_rhs)
			{
				return Dot(p_lhs, p_rhs) > 0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sign (Vector2 p_value)
			{
				return new Vector2(MathF.Sign(p_value.x), MathF.Sign(p_value.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sign (Vector2 p_value, float p_tolerance)
			{
				return new Vector2(MathF.Sign(p_value.x, p_tolerance), MathF.Sign(p_value.y, p_tolerance));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sign (Vector2 p_value, Vector2 p_tolerance)
			{
				return new Vector2(MathF.Sign(p_value.x, p_tolerance.x), MathF.Sign(p_value.y, p_tolerance.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2Int SignAsInt (Vector2 p_value)
			{
				return new Vector2Int(MathF.SignAsInt(p_value.x), MathF.SignAsInt(p_value.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2Int SignAsInt (Vector2 p_value, float p_tolerance)
			{
				return new Vector2Int(MathF.SignAsInt(p_value.x, p_tolerance), MathF.SignAsInt(p_value.y, p_tolerance));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2Int SignAsInt (Vector2 p_value, Vector2 p_tolerance)
			{
				return new Vector2Int(MathF.SignAsInt(p_value.x, p_tolerance.x), MathF.SignAsInt(p_value.y, p_tolerance.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian SignedAngle (Vector2 p_from, Vector2 p_to)
			{
				return Angle(p_from, p_to) * MathF.SignPos(Det(p_from, p_to));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 SignPos (Vector2 p_value)
			{
				return new Vector2(MathF.SignPos(p_value.x), MathF.SignPos(p_value.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2Int SignPosAsInt (Vector2 p_value)
			{
				return new Vector2Int(MathF.SignPosAsInt(p_value.x), MathF.SignPosAsInt(p_value.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sqrt (Vector2 p_vector)
			{
				return new Vector2(MathF.Sqrt(p_vector.x), MathF.Sqrt(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sub (Vector2 p_lhs, Vector2 p_rhs)
			{
				return p_lhs - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sub (ref Vector2 p_lhs, Vector2 p_rhs)
			{
				p_lhs -= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sub (Vector2 p_lhs, float p_rhs)
			{
				return p_lhs - Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sub (ref Vector2 p_lhs, float p_rhs)
			{
				p_lhs -= Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Sub (float p_lhs, Vector2 p_rhs)
			{
				return Replicate(p_lhs) - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 To (this Vector2 p_this, Vector2 p_target)
			{
				return FromTo(p_this, p_target);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Up (float p_scale = 1.0f)
			{
				return new Vector2(0.0f, p_scale);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 WeightedSum (Vector2 p_weight, Vector2 p_a, Vector2 p_b)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 WeightedSum (float p_weightA, float p_weightB, Vector2 p_a, Vector2 p_b)
			{
				return p_a * p_weightA + p_b * p_weightB;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 WeightedSum (Vector3 p_weight, Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_weight.z, p_a, p_b, p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 WeightedSum (float p_weightA, float p_weightB, float p_weightC, Vector2 p_a, Vector2 p_b, Vector2 p_c)
			{
				return p_a * p_weightA + p_b * p_weightB + p_c * p_weightC;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 WeightedSum (Vector4 p_weight, Vector2 p_a, Vector2 p_b, Vector2 p_c, Vector2 p_d)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_weight.z, p_weight.w, p_a, p_b, p_c, p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 WeightedSum (float p_weightA, float p_weightB, float p_weightC, float p_weightD, Vector2 p_a, Vector2 p_b, Vector2 p_c, Vector2 p_d)
			{
				return p_a * p_weightA + p_b * p_weightB + p_c * p_weightC + p_d * p_weightD;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 WithMagnitude (this Vector2 p_this, float p_magnitude)
			{
				return p_this.normalized * p_magnitude;
			}

		#endregion
	}
}
