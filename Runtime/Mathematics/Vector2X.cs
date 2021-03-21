using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	public static class Vector2X
	{
		#region // ==============================[Static Methods]============================== //
		
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Center (Vector2 p_lhs, Vector2 p_rhs)
			{
				return (p_lhs + p_rhs) * 0.5f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Direction (Vector2 p_from, Vector2 p_to)
			{
				return FromTo(p_from, p_to).normalized;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 FromTo (Vector2 p_from, Vector2 p_to)
			{
				return p_to - p_from;
			}
			
		#endregion
	}
}
