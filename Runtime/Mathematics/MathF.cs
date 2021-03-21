using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	public static class MathF
	{
		#region // ==============================[Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Abs (float p_value)
			{
				return Math.Abs(p_value);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Acos (float p_value)
			{
				return (float)Math.Acos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Asin (float p_value)
			{
				return (float)Math.Asin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan (float p_value)
			{
				return (float)Math.Atan(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan2 (float p_y, float p_x)
			{
				return (float)Math.Atan2(p_y, p_x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ceil (float p_value)
			{
				return (float)Math.Ceiling(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int CeilToInt (float p_value)
			{
				return (int)Ceil(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Clamp (float p_value, float p_min = 0.0f, float p_max = 1.0f)
			{
				return Min(Max(p_value, p_min), p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cos (float p_value)
			{
				return (float)Math.Cos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CosH (float p_value)
			{
				return (float)Math.Cosh(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cube (float p_value)
			{
				return Square(p_value) * p_value;
			}

			// public static float DeltaAngle (float p_current, float p_target;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Exp (float p_value)
			{
				return (float)Math.Exp(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Floor (float p_value)
			{
				return (float)Math.Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FloorToInt (float p_value)
			{
				return (int)Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerp (float p_a, float p_b, float p_value)
			{
				return (p_value - p_a) / (p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerpClamped (float p_a, float p_b, float p_value, float p_min = 0.0f, float p_max = 1.0f)
			{
				return Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (float p_lhs, float p_rhs, float p_tolerance = float.Epsilon)
			{
				return IsNearlyZero(p_lhs - p_rhs, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (float p_value,  float p_tolerance = float.Epsilon)
			{
				return Abs(p_value) <= p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Lerp (float p_a, float p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			// public static float LerpAngle () (Unity)

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float LerpClamped (float p_a, float p_b, float p_t)
			{
				return Lerp(p_a, p_b, Clamp(p_t));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ln (float p_value)
			{
				return LogE(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log (float p_value, float p_base)
			{
				return (float)Math.Log(p_value, p_base);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log2 (float p_value)
			{
				return Log(p_value, 2.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log10 (float p_value)
			{
				return (float)Math.Log10(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float LogE (float p_value)
			{
				return (float)Math.Log(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (float p_a, float p_b)
			{
				return Math.Max(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (float p_a, float p_b, float p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (params float[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (float p_a, float p_b)
			{
				return Math.Min(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (float p_a, float p_b, float p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (params float[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float MoveTowards (float p_current, float p_target, float p_maxDelta)
			{
				return Abs(p_target - p_current) <=  p_maxDelta ? p_target : p_current + SignPos(p_target - p_current) * p_maxDelta;
			}

			// MoveTowardsAngle

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float PingPong (float p_value, float p_length)
			{
				return p_length - Mathf.Abs(Repeat(p_value, p_length * 2f) - p_length);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Pow (float p_base, float p_exponent)
			{
				return (float)Math.Pow(p_base, p_exponent);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Remainder (float p_a, float p_b)
			{
				return (float)Math.IEEERemainder(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Repeat (float p_value, float p_length)
			{
				return Clamp(p_value - Mathf.Floor(p_value / p_length) * p_length, 0.0f, p_length);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Round (float p_value)
			{
				return (float)Math.Round(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int RoundToInt (float p_value)
			{
				return (int)Round(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Sign (float p_value)
			{
				return Math.Sign(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SignPos (float p_value)
			{
				return p_value >= 0.0 ? 1f : -1f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sin (float p_value)
			{
				return (float)Math.Sin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SinH (float p_value)
			{
				return (float)Math.Sinh(p_value);
			}

			public static float SmoothDamp (float p_current, float p_target, ref float p_currentVelocity, float p_smoothTime, float p_deltaTime, float p_maxSpeed = float.PositiveInfinity)
			{
				p_smoothTime = Max(0.0001F, p_smoothTime);
				float omega = 2F / p_smoothTime;

				float x = omega * p_deltaTime;
				float exp = 1F / (1F + x + 0.479999989271164f * Square(x) + 0.234999999403954f * Cube(x));
				float change = p_current - p_target;
				float originalTo = p_target;

				// Clamp maximum speed
				float maxChange = p_maxSpeed * p_smoothTime;
				change = Clamp(change, -maxChange, maxChange);
				p_target = p_current - change;

				float temp = (p_currentVelocity + omega * change) * p_deltaTime;
				p_currentVelocity = (p_currentVelocity - omega * temp) * exp;
				float output = p_target + ( change + temp ) * exp;

				// Prevent overshooting
				if (originalTo - p_current > 0.0F == output > originalTo) 
				{
					output = originalTo;
					p_currentVelocity = (output - originalTo) / p_deltaTime;
				}

				return output;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sqrt (float p_value)
			{
				return (float)Math.Sqrt(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Square (float p_value)
			{
				return p_value * p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Tan (float p_value)
			{
				return (float)Math.Tan(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TanH (float p_value)
			{
				return (float)Math.Tanh(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Trunc (float p_value)
			{
				return (float)Math.Truncate(p_value);
			}

		#endregion
	}
}


