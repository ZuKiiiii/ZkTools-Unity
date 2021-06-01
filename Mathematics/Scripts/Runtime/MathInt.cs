using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	public static class MathInt
	{
		#region // ==============================[Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Abs (int p_value)
			{
				return Math.Abs(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Clamp (int p_value, int p_min = 0, int p_max = 1)
			{
				return Min(Max(p_value, p_min), p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int ClosestPowerOfTwo (int p_value)
			{
				return Mathf.ClosestPowerOfTwo(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int CopySign (int p_value, int p_sign)
			{
				const int signMask = 1 << 31;

				// Remove sign from p_value and remove everything but keep the sign from p_sign.
				p_value &= ~signMask;
				p_sign &= signMask;

				return p_value | p_sign;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Cube (int p_value)
			{
				return Square(p_value) * p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Distance (int p_lhs, int p_rhs)
			{
				return Abs(p_lhs - p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int DistanceSqr (int p_lhs, int p_rhs)
			{
				return Square(p_lhs - p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int DivRem (int p_a, int p_b, out int p_result)
			{
				return Math.DivRem(p_a, p_b, out p_result);
			}

			public static int GreatestCommonDivisor (int p_dividend, int p_divisor)
			{
				int a = Max(p_dividend, p_divisor);
				int b = Min(p_dividend, p_divisor);
				int e = DivRem(a, b, out int r);
				if (r == 0)
					return b;
				else
					return GreatestCommonDivisor(b, r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerp (int p_a, int p_b, int p_value)
			{
				return (float)(p_value - p_a) / (float)(p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerpClamped (int p_a, int p_b, int p_value, float p_min = 0.0f, float p_max = 1.0f)
			{
				return MathF.Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (int p_lhs, int p_rhs, int p_tolerance = 0)
			{
				return Abs(p_lhs - p_rhs) <= p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegative (int p_value)
			{
				return p_value < 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegativeOrZero (int p_value)
			{
				return p_value <= 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositive (int p_value)
			{
				return p_value > 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositiveOrZero (int p_value)
			{
				return p_value >= 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPowerOfTwo (int p_value)
			{
				return (p_value & (p_value-1)) == 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (int p_value)
			{
				return p_value == 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Max (int p_a, int p_b)
			{
				return Math.Max(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (int p_a, int p_b, int p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (params int[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Min (int p_a, int p_b)
			{
				return Math.Min(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (int p_a, int p_b, int p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Min (params int[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Negate (int p_value)
			{
				return 1 - p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int NextPowerOfTwo (int p_value)
			{
				return Mathf.NextPowerOfTwo(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Sign (int p_value)
			{
				return Math.Sign(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SignPos (int p_value)
			{
				return p_value >= 0.0 ? 1f : -1f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Square (int p_value)
			{
				return p_value * p_value;
			}

		#endregion
	}
}