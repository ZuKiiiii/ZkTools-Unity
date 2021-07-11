using System.Runtime.CompilerServices;
using UnityEngine;
using ZkTools.Mathematics.Swizzling;

namespace ZkTools.Mathematics.CoordinateSystems
{
	public static partial class Vector2X
	{
		#region ==============================[Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static CylindricalCoord ToCylindrical (this Vector2 p_this, float p_z = 0.0f)
			{
				return CoordinateSystem.CartesianToCylindrical(p_this.GetXYK(p_z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static PolarCoord ToPolar (this Vector2 p_this)
			{
				return CoordinateSystem.CartesianToPolar(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static SphericalCoord ToSpherical (this Vector2 p_this, float p_z = 0.0f)
			{
				return CoordinateSystem.CartesianToSpherical(p_this.GetXYK(p_z));
			}

		#endregion
	}
}