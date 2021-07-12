using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	public static class MathInt
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Abs (int p_value)
			{
				return Math.Abs(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Add (int p_lhs, int p_rhs)
			{
				return p_lhs + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Add (ref int p_lhs, int p_rhs)
			{
				p_lhs += p_rhs;
				return p_lhs;
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
				return (int)MathF.CopySign(p_value, p_sign);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Cube (int p_value)
			{
				return Square(p_value) * p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Distance (int p_lhs, int p_rhs)
			{
				return Abs(SignedDistance(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int DistanceSqr (int p_lhs, int p_rhs)
			{
				return Square(SignedDistance(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Div (int p_dividend, int p_divisor)
			{
				return p_dividend / p_divisor;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Div (ref int p_dividend, int p_divisor)
			{
				p_dividend /= p_divisor;
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int DivRem (int p_dividend, int p_divisor, out int p_remainder)
			{
				return Math.DivRem(p_dividend, p_divisor, out p_remainder);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static DivRemResult DivRem (int p_dividend, int p_divisor)
			{
				DivRemResult result = new DivRemResult();
				result.result = DivRem(p_dividend, p_divisor, out result.remainder);
				return result;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int DivSafe (int p_dividend, int p_divisor, int p_defaultValue = 0)
			{
				return IsZero(p_divisor) ? p_defaultValue : p_dividend / p_divisor;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int DivSafe (ref int p_dividend, int p_divisor, int p_defaultValue = 0)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			public static int GreatestCommonDivisor (int p_a, int p_b)
			{
				int remainder = 0;
				while (p_b != 0)
				{
					remainder = p_a % p_b;
					p_a = p_b;
					p_b = remainder;
				}
				return p_a;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsGreater (int p_lhs, int p_rhs)
			{
				return p_lhs > p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsGreaterEqual (int p_lhs, int p_rhs)
			{
				return p_lhs >= p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsLess (int p_lhs, int p_rhs)
			{
				return p_lhs < p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsLessEqual (int p_lhs, int p_rhs)
			{
				return p_lhs <= p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (int p_lhs, int p_rhs, int p_tolerance = 0)
			{
				return Abs(p_lhs - p_rhs) <= p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyGreater (int p_lhs, int p_rhs, int p_tolerance = 0)
			{
				return p_lhs > p_rhs - p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyGreaterEqual (int p_lhs, int p_rhs, int p_tolerance = 0)
			{
				return p_lhs >= p_rhs - p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyLess (int p_lhs, int p_rhs, int p_tolerance = 0)
			{
				return p_lhs < p_rhs + p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyLessEqual (int p_lhs, int p_rhs, int p_tolerance = 0)
			{
				return p_lhs <= p_rhs + p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (int p_value,  int p_tolerance = 0)
			{
				return Abs(p_value) <= p_tolerance;
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
			public static int Max (int p_a, int p_b, int p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Max (int p_a, int p_b, int p_c, int p_d)
			{
				return Max(Max(Max(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Max (params int[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Min (int p_a, int p_b)
			{
				return Math.Min(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Min (int p_a, int p_b, int p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Min (int p_a, int p_b, int p_c, int p_d)
			{
				return Min(Min(Min(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Min (params int[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Mod (int p_value, int p_length)
			{
				return (p_value % p_length + p_length) % p_length;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Mul (int p_lhs, int p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Mul (ref int p_lhs, int p_rhs)
			{
				return p_lhs *= p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Negate (int p_value)
			{
				return -p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int NextPowerOfTwo (int p_value)
			{
				return Mathf.NextPowerOfTwo(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int PingPong (int p_value, int p_length)
			{
				return p_length - Abs(Repeat(p_value, p_length * 2) - p_length);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Repeat (int p_value, int p_length)
			{
				return Clamp(p_value - MathF.FloorToInt(p_value / (float)p_length) * p_length, 0, p_length);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Sign (int p_value)
			{
				return Math.Sign(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int SignedDistance (int p_from, int p_to)
			{
				return p_to - p_from;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int SignPos (int p_value)
			{
				return p_value >= 0 ? 1 : -1;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Square (int p_value)
			{
				return p_value * p_value;
			}

		#endregion
	}

	public struct DivRemResult
	{
		#region ==============================[Variables]==============================

			public int remainder;

			public int result;

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public DivRemResult (int p_result, int p_remainder)
			{
				remainder = p_remainder;
				result = p_result;
			}

		#endregion
	}
}