
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Extensions
{
	public static partial class IntX
	{
		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (this int p_this, int p_other, int p_tolerance)
			{
				return MathInt.IsNearlyEqual(p_this, p_other, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegative (this int p_this)
			{
				return MathInt.IsNegative(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegativeOrZero (this int p_this)
			{
				return MathInt.IsNegativeOrZero(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositive (this int p_this)
			{
				return MathInt.IsPositive(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositiveOrZero (this int p_this)
			{
				return MathInt.IsPositiveOrZero(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (this int p_this)
			{
				return MathInt.IsZero(p_this);
			}

		#endregion

	}
}
