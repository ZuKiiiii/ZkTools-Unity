using System.Runtime.CompilerServices;
using UnityEngine;
using ZkTools.Mathematics.Angles;

namespace ZkTools.Mathematics.CoordinateSystems
{
	public enum ECoordinateSystem : byte
	{
		Cartesian2D,
		Cartesian3D,
		Cylindrical,
		Polar,
		Spherical,
	}

	public enum ECoordinateSystem2D : byte
	{
		Cartesian,
		Polar
	}

	public enum ECoordinateSystem3D : byte
	{
		Cartesian,
		Cylindrical,
		Spherical,
	}

	public static class CoordinateSystem
	{
		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static CylindricalCoord CartesianToCylindrical (float p_x, float p_y, float p_z)
			{
				CartesianToCylindrical(p_x, p_y, p_z, out CylindricalCoord p_cylindricalCoord);
				return p_cylindricalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static CylindricalCoord CartesianToCylindrical (Vector3 p_vector3)
			{
				CartesianToCylindrical(p_vector3.x, p_vector3.y, p_vector3.z, out CylindricalCoord p_cylindricalCoord);
				return p_cylindricalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToCylindrical (float p_x, float p_y, float p_z, out CylindricalCoord p_cylindricalCoord)
			{
				CartesianToCylindrical(p_x, p_y, p_z,out p_cylindricalCoord.rho, out p_cylindricalCoord.phi, out p_cylindricalCoord.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToCylindrical (Vector3 p_vector3, out CylindricalCoord p_cylindricalCoord)
			{
				CartesianToCylindrical(p_vector3.x, p_vector3.y, p_vector3.z, out p_cylindricalCoord.rho, out p_cylindricalCoord.phi, out p_cylindricalCoord.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToCylindrical (float p_x, float p_y, float p_z, out float p_cylRho, out Radian p_cylPhi, out float p_cylZ)
			{
				p_cylRho = MathF.Sqrt(MathF.Square(p_x) + MathF.Square(p_y));
				p_cylPhi = Trigo.Atan2(p_y, p_x);
				p_cylZ = p_z;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToCylindrical (Vector3 p_vector3, out float p_cylRho, out Radian p_cylPhi, out float p_cylZ)
			{
				CartesianToCylindrical(p_vector3.x, p_vector3.y, p_vector3.z, out p_cylRho, out p_cylPhi, out p_cylZ);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static PolarCoord CartesianToPolar (float p_x, float p_y)
			{
				CartesianToPolar(p_x, p_y, out PolarCoord polarCoord);
				return polarCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static PolarCoord CartesianToPolar (Vector2 p_vector2)
			{
				CartesianToPolar(p_vector2.x, p_vector2.y, out PolarCoord polarCoord);
				return polarCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToPolar (float p_x, float p_y, out PolarCoord p_polarCoord)
			{
				CartesianToPolar(p_x, p_y, out p_polarCoord.radius, out p_polarCoord.angle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToPolar (Vector2 p_vector2, out PolarCoord p_polarCoord)
			{
				CartesianToPolar(p_vector2.x, p_vector2.y, out p_polarCoord.radius, out p_polarCoord.angle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToPolar (float p_x, float p_y, out float p_polarRadius, out Radian p_polarAngle)
			{
				p_polarRadius = MathF.Sqrt(MathF.Square(p_x) + MathF.Square(p_y));
				p_polarAngle = Trigo.Atan2(p_y, p_x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToPolar (Vector2 p_vector2, out float p_polarRadius, out Radian p_polarAngle)
			{
				CartesianToPolar(p_vector2.x, p_vector2.y, out p_polarRadius, out p_polarAngle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static SphericalCoord CartesianToSpherical (float p_x, float p_y, float p_z)
			{
				CartesianToSpherical(p_x, p_y, p_z, out SphericalCoord p_sphericalCoord);
				return p_sphericalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static SphericalCoord CartesianToSpherical (Vector3 p_vector3)
			{
				CartesianToSpherical(p_vector3.x, p_vector3.y, p_vector3.z, out SphericalCoord p_sphericalCoord);
				return p_sphericalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToSpherical (float p_x, float p_y, float p_z,  out SphericalCoord p_sphericalCoord)
			{
				CartesianToSpherical(p_x, p_y, p_z, out p_sphericalCoord.radius, out p_sphericalCoord.theta, out p_sphericalCoord.phi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToSpherical (Vector3 p_vector3, out SphericalCoord p_sphericalCoord)
			{
				CartesianToSpherical(p_vector3.x, p_vector3.y, p_vector3.z, out p_sphericalCoord.radius, out p_sphericalCoord.theta, out p_sphericalCoord.phi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToSpherical (float p_x, float p_y, float p_z, out float p_sphereRadius, out Radian p_sphereTheta, out Radian p_spherePhi)
			{
				p_sphereRadius = MathF.Sqrt(MathF.Square(p_x) + MathF.Square(p_y));
				p_sphereTheta = Trigo.Atan2(p_y, p_x);
				p_spherePhi = p_z;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToSpherical (Vector3 p_vector3, out float p_sphereRadius, out Radian p_sphereTheta, out Radian p_spherePhi)
			{
				CartesianToSpherical(p_vector3.x, p_vector3.y, p_vector3.z, out p_sphereRadius, out p_sphereTheta, out p_spherePhi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 CylindricalToCartesian (float p_cylRho, Radian p_cylPhi, float p_cylZ)
			{
				CylindricalToCartesian(p_cylRho, p_cylPhi, p_cylZ, out Vector3 vector3);
				return vector3;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 CylindricalToCartesian (CylindricalCoord p_cylindricalCoord)
			{
				CylindricalToCartesian(p_cylindricalCoord.rho, p_cylindricalCoord.phi, p_cylindricalCoord.z, out Vector3 Vector3);
				return Vector3;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToCartesian (float p_cylRho, Radian p_cylPhi, float p_cylZ, out Vector3 p_vector3)
			{
				CylindricalToCartesian(p_cylRho, p_cylPhi, p_cylZ, out p_vector3.x, out p_vector3.y, out p_vector3.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToCartesian (CylindricalCoord p_cylindricalCoord, out Vector3 p_vector3)
			{
				CylindricalToCartesian(p_cylindricalCoord.rho, p_cylindricalCoord.phi, p_cylindricalCoord.z, out p_vector3.x, out p_vector3.y, out p_vector3.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToCartesian (float p_cylRho, Radian p_cylPhi, float p_cylZ, out float p_x, out float p_y, out float p_z)
			{
				p_x = p_cylRho * Trigo.Cos(p_cylPhi);
				p_y = p_cylRho * Trigo.Sin(p_cylPhi);
				p_z = p_cylZ;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToCartesian (CylindricalCoord p_cylindricalCoord, out float p_x, out float p_y, out float p_z)
			{
				CylindricalToCartesian(p_cylindricalCoord.rho, p_cylindricalCoord.phi, p_cylindricalCoord.z, out p_x, out p_y, out p_z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static SphericalCoord CylindricalToSpherical (float p_cylRho, Radian p_cylPhi, float p_cylZ)
			{
				CylindricalToSpherical(p_cylRho, p_cylPhi, p_cylZ, out SphericalCoord sphericalCoord);
				return sphericalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static SphericalCoord CylindricalToSpherical (CylindricalCoord p_cylindricalCoord)
			{
				CylindricalToSpherical(p_cylindricalCoord.rho, p_cylindricalCoord.phi, p_cylindricalCoord.z, out SphericalCoord sphericalCoord);
				return sphericalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (float p_cylRho, Radian p_cylPhi, float p_cylZ, out SphericalCoord p_sphericalCoord)
			{
				CylindricalToSpherical(p_cylRho, p_cylPhi, p_cylZ, out p_sphericalCoord.radius, out p_sphericalCoord.theta, out p_sphericalCoord.phi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (CylindricalCoord p_cylindricalCoord, out SphericalCoord p_sphericalCoord)
			{
				CylindricalToSpherical(p_cylindricalCoord.rho, p_cylindricalCoord.phi, p_cylindricalCoord.z, out p_sphericalCoord.radius, out p_sphericalCoord.theta, out p_sphericalCoord.phi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (float p_cylRho, Radian p_cylPhi, float p_cylZ, out float p_sphereRadius, out Radian p_sphereTheta, out Radian p_spherePhi)
			{
				p_sphereRadius = MathF.Sqrt(MathF.Square(p_cylRho) + MathF.Square(p_cylZ));
				p_sphereTheta = Trigo.Atan2(p_cylRho, p_cylZ);
				p_spherePhi = p_cylPhi;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (CylindricalCoord p_cylindricalCoord, out float p_sphereRadius, out Radian p_sphereTheta, out Radian p_spherePhi)
			{
				CylindricalToSpherical(p_cylindricalCoord.rho, p_cylindricalCoord.phi, p_cylindricalCoord.z, out p_sphereRadius, out p_sphereTheta, out p_spherePhi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 PolarToCartesian (float p_polarRadius, Radian p_polarAngle)
			{
				PolarToCartesian(p_polarRadius, p_polarAngle, out Vector2 vector2);
				return vector2;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 PolarToCartesian (PolarCoord p_polarCoord)
			{
				PolarToCartesian(p_polarCoord.radius, p_polarCoord.angle, out Vector2 vector2);
				return vector2;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void PolarToCartesian (PolarCoord p_polarCoord, out float p_x, out float p_y)
			{
				PolarToCartesian(p_polarCoord.radius, p_polarCoord.angle, out p_x, out p_y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void PolarToCartesian (PolarCoord p_polarCoord, out Vector2 p_vector2)
			{
				PolarToCartesian(p_polarCoord.radius, p_polarCoord.angle, out p_vector2.x, out p_vector2.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void PolarToCartesian (float p_polarRadius, Radian p_polarAngle,  out float p_x, out float p_y)
			{
				p_x = p_polarRadius * Trigo.Cos(p_polarAngle);
				p_y = p_polarRadius * Trigo.Sin(p_polarAngle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void PolarToCartesian (float p_polarRadius, Radian p_polarAngle, out Vector2 p_vector2)
			{
				PolarToCartesian(p_polarRadius, p_polarAngle, out p_vector2.x, out p_vector2.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 SphericalToCartesian (float p_sphereRadius, Radian p_sphereTheta, Radian p_spherePhi)
			{
				SphericalToCartesian(p_sphereRadius, p_sphereTheta, p_spherePhi, out Vector3 p_vector3);
				return p_vector3;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 SphericalToCartesian (SphericalCoord p_sphericalCoord)
			{
				SphericalToCartesian(p_sphericalCoord.radius, p_sphericalCoord.theta, p_sphericalCoord.phi, out Vector3 p_vector3);
				return p_vector3;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCartesian (float p_sphereRadius, Radian p_sphereTheta, Radian p_spherePhi, out Vector3 p_vector3)
			{
				SphericalToCartesian(p_sphereRadius, p_sphereTheta, p_spherePhi, out p_vector3.x, out p_vector3.y, out p_vector3.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCartesian (SphericalCoord p_sphericalCoord, out Vector3 p_vector3)
			{
				SphericalToCartesian(p_sphericalCoord.radius, p_sphericalCoord.theta, p_sphericalCoord.phi, out p_vector3.x, out p_vector3.y, out p_vector3.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCartesian (float p_sphereRadius, Radian p_sphereTheta, Radian p_spherePhi, out float p_x, out float p_y, out float p_z)
			{
				float sinTheta = Trigo.Sin(p_sphereTheta);
				p_x = p_sphereRadius * sinTheta * Trigo.Cos(p_spherePhi);
				p_y = p_sphereRadius * sinTheta * Trigo.Sin(p_spherePhi);
				p_z = Trigo.Cos(p_sphereTheta);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCartesian (SphericalCoord p_sphericalCoord, out float p_x, out float p_y, out float p_z)
			{
				SphericalToCartesian(p_sphericalCoord.radius, p_sphericalCoord.theta, p_sphericalCoord.phi, out p_x, out p_y, out p_z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static CylindricalCoord SphericalToCylindrical (float p_sphereRadius, Radian p_sphereTheta, Radian p_spherePhi)
			{
				SphericalToCylindrical(p_sphereRadius, p_sphereTheta, p_spherePhi, out CylindricalCoord cylindricalCoord);
				return cylindricalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static CylindricalCoord SphericalToCylindrical (SphericalCoord p_sphericalCoord)
			{
				SphericalToCylindrical(p_sphericalCoord.radius, p_sphericalCoord.theta, p_sphericalCoord.phi, out CylindricalCoord cylindricalCoord);
				return cylindricalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCylindrical (float p_sphereRadius, Radian p_sphereTheta, Radian p_spherePhi, out CylindricalCoord p_cylindricalCoord)
			{
				SphericalToCylindrical(p_sphereRadius, p_sphereTheta, p_spherePhi, out p_cylindricalCoord.rho, out p_cylindricalCoord.phi, out p_cylindricalCoord.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCylindrical (SphericalCoord p_sphericalCoord, out CylindricalCoord p_cylindricalCoord)
			{
				SphericalToCylindrical(p_sphericalCoord.radius, p_sphericalCoord.theta, p_sphericalCoord.phi, out p_cylindricalCoord.rho, out p_cylindricalCoord.phi, out p_cylindricalCoord.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCylindrical (float p_sphereRadius, Radian p_sphereTheta, Radian p_spherePhi, out float p_cylRho, out Radian p_cylPhi, out float p_cylZ)
			{
				p_cylRho = p_sphereRadius * Trigo.Sin(p_sphereTheta);
				p_cylPhi = p_spherePhi;
				p_cylZ = p_sphereRadius * Trigo.Cos(p_sphereTheta);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCylindrical (SphericalCoord p_sphericalCoord, out float p_cylRho, out Radian p_cylPhi, out float p_cylZ)
			{
				SphericalToCylindrical(p_sphericalCoord.radius, p_sphericalCoord.theta, p_sphericalCoord.phi, out p_cylRho, out p_cylPhi, out p_cylZ);
			}

		#endregion
	}
}