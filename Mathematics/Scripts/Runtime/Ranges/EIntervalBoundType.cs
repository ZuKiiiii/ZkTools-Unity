using System.Diagnostics;
using ZkTools;

namespace ZkTools.Mathematics.Ranges
{
	public enum EIntervalBoundType : byte
	{
		Exclusive,
		Inclusive
	}

	public enum EIntervalBoundSide : byte
	{
		Ex,
		ExIn,
		In,
		InEx,
	}

	public static class ERangeX
	{
		#region ==============================[Static Methods]==============================

			public static EIntervalBoundSide Convert (EIntervalBoundType p_start, EIntervalBoundType p_end)
			{
				return p_start == EIntervalBoundType.Exclusive
					? (p_end == EIntervalBoundType.Exclusive)? EIntervalBoundSide.Ex : EIntervalBoundSide.ExIn
					: p_end == EIntervalBoundType.Exclusive ? EIntervalBoundSide.In :  EIntervalBoundSide.InEx;
			}
			
			public static void Convert (EIntervalBoundSide p_range, out EIntervalBoundType p_start, out EIntervalBoundType p_end)
			{
				switch (p_range)
				{
					case EIntervalBoundSide.Ex : p_start = EIntervalBoundType.Exclusive; p_end = EIntervalBoundType.Exclusive; break;
					case EIntervalBoundSide.ExIn : p_start = EIntervalBoundType.Exclusive; p_end = EIntervalBoundType.Inclusive; break;
					case EIntervalBoundSide.In : p_start = EIntervalBoundType.Inclusive; p_end = EIntervalBoundType.Inclusive; break;
					case EIntervalBoundSide.InEx : p_start = EIntervalBoundType.Inclusive; p_end = EIntervalBoundType.Exclusive; break;
					default : throw new System.ArgumentOutOfRangeException();
				}
			}
		
		#endregion
	}
}