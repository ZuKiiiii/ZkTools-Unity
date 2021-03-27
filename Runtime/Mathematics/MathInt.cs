using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	public enum ERangeType : byte
	{
		Ex,
		ExIn,
		In,
		InEx
	}
	
	public static class MathInt
	{
		#region // ==============================[Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Abs (int p_value)
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
			public static int Cube (int p_value)
			{
				return Square(p_value) * p_value;
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
			public static bool IsInside (int p_value, int p_min, int p_max, ERangeType p_type)
			{
				bool result = false;
				switch (p_type)
				{
					case ERangeType.Ex : result = IsInsideEx(p_value, p_min, p_max); break;
					case ERangeType.ExIn : result = IsInsideExIn(p_value, p_min, p_max); break;
					case ERangeType.In : result = IsInsideIn(p_value, p_min, p_max); break;
					case ERangeType.InEx : result = IsInsideInEx(p_value, p_min, p_max); break;
				}
				return result;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInsideIn (int p_value, int p_minInclusiveValue, int p_maxInclusiveValue)
			{
				return p_minInclusiveValue <= p_value && p_value <= p_maxInclusiveValue;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInsideInEx (int p_value, int p_minInclusiveValue, int p_maxExclusiveValue)
			{
				return p_minInclusiveValue <= p_value && p_value < p_maxExclusiveValue;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInsideEx (int p_value, int p_minExclusiveValue, int p_maxExclusiveValue)
			{
				return p_minExclusiveValue < p_value && p_value < p_maxExclusiveValue;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInsideExIn (int p_value, int p_minExclusiveValue, int p_maxInclusiveValue)
			{
				return p_minExclusiveValue < p_value && p_value <= p_maxInclusiveValue;
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
			public static bool IsOutside (int p_value, int p_min, int p_max, ERangeType p_type)
			{
				bool result = false;
				switch (p_type)
				{
					case ERangeType.Ex : result = IsOutsideEx(p_value, p_min, p_max); break;
					case ERangeType.ExIn : result = IsOutsideExIn(p_value, p_min, p_max); break;
					case ERangeType.In : result = IsOutsideIn(p_value, p_min, p_max); break;
					case ERangeType.InEx : result = IsOutsideInEx(p_value, p_min, p_max); break;
				}
				return result;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutsideEx (int p_value, int p_minExclusiveValue, int p_maxExclusiveValue)
			{
				return p_value < p_minExclusiveValue || p_maxExclusiveValue < p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutsideExIn (int p_value, int p_minExclusiveValue, int p_maxInclusiveValue)
			{
				return p_value < p_minExclusiveValue || p_maxInclusiveValue <= p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutsideIn (int p_value, int p_minInclusiveValue, int p_maxInclusiveValue)
			{
				return p_value <= p_minInclusiveValue || p_maxInclusiveValue <= p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutsideInEx (int p_value, int p_minInclusiveValue, int p_maxExclusiveValue)
			{
				return p_value <= p_minInclusiveValue || p_maxExclusiveValue < p_value;
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