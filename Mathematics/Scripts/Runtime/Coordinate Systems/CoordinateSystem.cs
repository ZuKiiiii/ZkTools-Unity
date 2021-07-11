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
		#region ==============================[Static Methods]==============================

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
				CartesianToCylindrical(p_x, p_y, p_z, out p_cylindricalCoord.radius, out p_cylindricalCoord.angle, out p_cylindricalCoord.height);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToCylindrical (Vector3 p_vector3, out CylindricalCoord p_cylindricalCoord)
			{
				CartesianToCylindrical(p_vector3.x, p_vector3.y, p_vector3.z, out p_cylindricalCoord.radius, out p_cylindricalCoord.angle, out p_cylindricalCoord.height);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToCylindrical (float p_x, float p_y, float p_z, out float p_cylRadius, out Radian p_cylAngle, out float p_cylHeight)
			{
				p_cylRadius = MathF.Sqrt(MathF.Square(p_x) + MathF.Square(p_z));
				p_cylAngle = Trigo.Atan2(p_z, p_x);
				p_cylHeight = p_y;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToCylindrical (Vector3 p_vector3, out float p_cylRadius, out Radian p_cylAngle, out float p_cylHeight)
			{
				CartesianToCylindrical(p_vector3.x, p_vector3.y, p_vector3.z, out p_cylRadius, out p_cylAngle, out p_cylHeight);
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
				p_sphereRadius = MathF.Sqrt(MathF.Square(p_x) + MathF.Square(p_y) + MathF.Square(p_z));
				p_sphereTheta = Trigo.Atan2(p_z, p_x);
				p_spherePhi = Trigo.Atan2(MathF.Sqrt(MathF.Square(p_x) + MathF.Square(p_z)), p_y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CartesianToSpherical (Vector3 p_vector3, out float p_sphereRadius, out Radian p_sphereTheta, out Radian p_spherePhi)
			{
				CartesianToSpherical(p_vector3.x, p_vector3.y, p_vector3.z, out p_sphereRadius, out p_sphereTheta, out p_spherePhi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 CylindricalToCartesian (float p_cylRadius, Radian p_cylAngle, float p_cylHeight)
			{
				CylindricalToCartesian(p_cylRadius, p_cylAngle, p_cylHeight, out Vector3 vector3);
				return vector3;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 CylindricalToCartesian (CylindricalCoord p_cylindricalCoord)
			{
				CylindricalToCartesian(p_cylindricalCoord.radius, p_cylindricalCoord.angle, p_cylindricalCoord.height, out Vector3 Vector3);
				return Vector3;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToCartesian (float p_cylRadius, Radian p_cylAngle, float p_cylHeight, out Vector3 p_vector3)
			{
				CylindricalToCartesian(p_cylRadius, p_cylAngle, p_cylHeight, out p_vector3.x, out p_vector3.y, out p_vector3.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToCartesian (CylindricalCoord p_cylindricalCoord, out Vector3 p_vector3)
			{
				CylindricalToCartesian(p_cylindricalCoord.radius, p_cylindricalCoord.angle, p_cylindricalCoord.height, out p_vector3.x, out p_vector3.y, out p_vector3.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToCartesian (float p_cylRadius, Radian p_cylAngle, float p_cylHeight, out float p_x, out float p_y, out float p_z)
			{
				p_x = p_cylRadius * Trigo.Cos(p_cylAngle);
				p_y = p_cylHeight;
				p_z = p_cylRadius * Trigo.Sin(p_cylAngle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToCartesian (CylindricalCoord p_cylindricalCoord, out float p_x, out float p_y, out float p_z)
			{
				CylindricalToCartesian(p_cylindricalCoord.radius, p_cylindricalCoord.angle, p_cylindricalCoord.height, out p_x, out p_y, out p_z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static SphericalCoord CylindricalToSpherical (float p_cylRadius, Radian p_cylAngle, float p_cylHeight)
			{
				CylindricalToSpherical(p_cylRadius, p_cylAngle, p_cylHeight, out SphericalCoord sphericalCoord);
				return sphericalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static SphericalCoord CylindricalToSpherical (CylindricalCoord p_cylindricalCoord)
			{
				CylindricalToSpherical(p_cylindricalCoord.radius, p_cylindricalCoord.angle, p_cylindricalCoord.height, out SphericalCoord sphericalCoord);
				return sphericalCoord;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (float p_cylRadius, Radian p_cylAngle, float p_cylHeight, out SphericalCoord p_sphericalCoord)
			{
				CylindricalToSpherical(p_cylRadius, p_cylAngle, p_cylHeight, out p_sphericalCoord.radius, out p_sphericalCoord.theta, out p_sphericalCoord.phi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (CylindricalCoord p_cylindricalCoord, out SphericalCoord p_sphericalCoord)
			{
				CylindricalToSpherical(p_cylindricalCoord.radius, p_cylindricalCoord.angle, p_cylindricalCoord.height, out p_sphericalCoord.radius, out p_sphericalCoord.theta, out p_sphericalCoord.phi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (float p_cylRadius, Radian p_cylAngle, float p_cylHeight, out float p_sphereRadius, out Radian p_sphereTheta, out Radian p_spherePhi)
			{
				p_sphereRadius = MathF.Sqrt(MathF.Square(p_cylRadius) + MathF.Square(p_cylHeight));
				p_sphereTheta = p_cylAngle;
				p_spherePhi = Trigo.Atan2(p_cylRadius, p_cylHeight);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (CylindricalCoord p_cylindricalCoord, out float p_sphereRadius, out Radian p_sphereTheta, out Radian p_spherePhi)
			{
				CylindricalToSpherical(p_cylindricalCoord.radius, p_cylindricalCoord.angle, p_cylindricalCoord.height, out p_sphereRadius, out p_sphereTheta, out p_spherePhi);
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
				p_x = p_sphereRadius * Trigo.Cos(p_sphereTheta) * Trigo.Sin(p_spherePhi);
				p_y = p_sphereRadius * Trigo.Cos(p_spherePhi);
				p_z = p_sphereRadius * Trigo.Sin(p_sphereTheta) * Trigo.Sin(p_spherePhi);
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
				SphericalToCylindrical(p_sphereRadius, p_sphereTheta, p_spherePhi, out p_cylindricalCoord.radius, out p_cylindricalCoord.angle, out p_cylindricalCoord.height);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCylindrical (SphericalCoord p_sphericalCoord, out CylindricalCoord p_cylindricalCoord)
			{
				SphericalToCylindrical(p_sphericalCoord.radius, p_sphericalCoord.theta, p_sphericalCoord.phi, out p_cylindricalCoord.radius, out p_cylindricalCoord.angle, out p_cylindricalCoord.height);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCylindrical (float p_sphereRadius, Radian p_sphereTheta, Radian p_spherePhi, out float p_cylRadius, out Radian p_cylAngle, out float p_cylHeight)
			{
				p_cylRadius = p_sphereRadius * Trigo.Sin(p_spherePhi);
				p_cylAngle = p_sphereTheta;
				p_cylHeight = p_sphereRadius * Trigo.Cos(p_spherePhi);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCylindrical (SphericalCoord p_sphericalCoord, out float p_cylRadius, out Radian p_cylAngle, out float p_cylHeight)
			{
				SphericalToCylindrical(p_sphericalCoord.radius, p_sphericalCoord.theta, p_sphericalCoord.phi, out p_cylRadius, out p_cylAngle, out p_cylHeight);
			}

		#endregion
	}
}