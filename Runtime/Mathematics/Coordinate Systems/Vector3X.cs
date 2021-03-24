using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.CoordinateSystems
{
	public static partial class Vector2X
	{
		#region // ==============================[Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static CylindricalCoord ToCylindrical (this Vector3 p_this)
			{
				return CoordinateSystem.CartesianToCylindrical(p_this);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static SphericalCoord ToSpherical (this Vector3 p_this)
			{
				return CoordinateSystem.CartesianToSpherical(p_this);
			}
		
		#endregion
	}
}