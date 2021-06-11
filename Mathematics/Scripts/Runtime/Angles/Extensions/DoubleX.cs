using System.Runtime.CompilerServices;

namespace ZkTools.Mathematics.Angles.Extensions
{
	public static class DoubleX
	{
		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Degree ToDegree (this double p_this)
			{
				return p_this;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Gradian ToGradian (this double p_this)
			{
				return p_this;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian ToRadian (this double p_this)
			{
				return p_this;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Turn ToTurn (this double p_this)
			{
				return p_this;
			}

		#endregion
	}
}