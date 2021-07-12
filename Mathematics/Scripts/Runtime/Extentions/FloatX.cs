using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Extensions
{
	public static class FloatX
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Inv (this float p_this)
			{
				return MathF.Inv(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (this float p_this, float p_other, float p_tolerance = float.Epsilon)
			{
				return MathF.IsNearlyEqual(p_this, p_other, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this float p_this,  float p_tolerance = float.Epsilon)
			{
				return MathF.IsNearlyZero(p_this, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegative (this float p_this)
			{
				return MathF.IsNegative(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegativeOrZero (this float p_this)
			{
				return MathF.IsNegativeOrZero(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositive (this float p_this)
			{
				return MathF.IsPositive(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositiveOrZero (this float p_this)
			{
				return MathF.IsPositiveOrZero(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (this float p_this)
			{
				return MathF.IsZero(p_this);
			}

		#endregion

	}
}
