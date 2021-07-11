using System.Diagnostics;
using ZkTools;

namespace ZkTools.Mathematics.Ranges
{
	public enum ERangeSide : byte
	{
		Exclusive,
		Inclusive
	}

	public enum ERange : byte
	{
		Ex,
		ExIn,
		In,
		InEx,
	}

	public static class ERangeX
	{
		#region ==============================[Static Methods]==============================

			public static ERange Convert (ERangeSide p_start, ERangeSide p_end)
			{
				return p_start == ERangeSide.Exclusive
					? (p_end == ERangeSide.Exclusive)? ERange.Ex : ERange.ExIn
					: p_end == ERangeSide.Exclusive ? ERange.In :  ERange.InEx;
			}
			
			public static void Convert (ERange p_range, out ERangeSide p_start, out ERangeSide p_end)
			{
				switch (p_range)
				{
					case ERange.Ex : p_start = ERangeSide.Exclusive; p_end = ERangeSide.Exclusive; break;
					case ERange.ExIn : p_start = ERangeSide.Exclusive; p_end = ERangeSide.Inclusive; break;
					case ERange.In : p_start = ERangeSide.Inclusive; p_end = ERangeSide.Inclusive; break;
					case ERange.InEx : p_start = ERangeSide.Inclusive; p_end = ERangeSide.Exclusive; break;
					default : throw new System.ArgumentOutOfRangeException();
				}
			}
		
		#endregion
	}
}