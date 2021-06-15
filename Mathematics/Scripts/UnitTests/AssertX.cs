using UnityEngine;
using NUnit.Framework;
using ZkTools.Mathematics.CoordinateSystems;

namespace ZkTools.Mathematics.UnitTests
{
	public static class AssertX
	{
		#region // ==============================[Static Methods]============================== //

			public static void AreEqual (Vector2 p_expected, Vector2 p_actual)
			{
				Assert.AreEqual(p_expected.x, p_actual.x);
				Assert.AreEqual(p_expected.y, p_actual.y);
			}

			public static void AreEqual (Vector2 p_expected, Vector2 p_actual, float p_delta)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_delta);
				Assert.AreEqual(p_expected.y, p_actual.y, p_delta);
			}

			public static void AreEqual (Vector2 p_expected, Vector2 p_actual, float p_delta, string p_message)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_delta, p_message);
				Assert.AreEqual(p_expected.y, p_actual.y, p_delta, p_message);
			}

			public static void AreEqual (Vector2 p_expected, Vector2 p_actual, float p_delta, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_delta, p_message, p_args);
				Assert.AreEqual(p_expected.y, p_actual.y, p_delta, p_message, p_args);
			}

			public static void AreEqual (Vector2 p_expected, Vector2 p_actual, string p_message)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_message);
				Assert.AreEqual(p_expected.y, p_actual.y, p_message);
			}

			public static void AreEqual (Vector2 p_expected, Vector2 p_actual, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_message, p_args);
				Assert.AreEqual(p_expected.y, p_actual.y, p_message, p_args);
			}

			public static void AreEqual (Vector3 p_expected, Vector3 p_actual)
			{
				Assert.AreEqual(p_expected.x, p_actual.x);
				Assert.AreEqual(p_expected.y, p_actual.y);
				Assert.AreEqual(p_expected.z, p_actual.z);
			}

			public static void AreEqual (Vector3 p_expected, Vector3 p_actual, float p_delta)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_delta);
				Assert.AreEqual(p_expected.y, p_actual.y, p_delta);
				Assert.AreEqual(p_expected.z, p_actual.z, p_delta);
			}

			public static void AreEqual (Vector3 p_expected, Vector3 p_actual, float p_delta, string p_message)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_delta, p_message);
				Assert.AreEqual(p_expected.y, p_actual.y, p_delta, p_message);
				Assert.AreEqual(p_expected.z, p_actual.z, p_delta, p_message);
			}

			public static void AreEqual (Vector3 p_expected, Vector3 p_actual, float p_delta, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_delta, p_message, p_args);
				Assert.AreEqual(p_expected.y, p_actual.y, p_delta, p_message, p_args);
				Assert.AreEqual(p_expected.z, p_actual.z, p_delta, p_message, p_args);
			}

			public static void AreEqual (Vector3 p_expected, Vector3 p_actual, string p_message)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_message);
				Assert.AreEqual(p_expected.y, p_actual.y, p_message);
				Assert.AreEqual(p_expected.z, p_actual.z, p_message);
			}

			public static void AreEqual (Vector3 p_expected, Vector3 p_actual, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.x, p_actual.x, p_message, p_args);
				Assert.AreEqual(p_expected.y, p_actual.y, p_message, p_args);
				Assert.AreEqual(p_expected.z, p_actual.z, p_message, p_args);
			}

			public static void AreEqual (CylindricalCoord p_expected, CylindricalCoord p_actual)
			{
				Assert.AreEqual(p_expected.rho, p_actual.rho);
				Assert.AreEqual(p_expected.theta, p_actual.theta);
				Assert.AreEqual(p_expected.z, p_actual.z);
			}

			public static void AreEqual (CylindricalCoord p_expected, CylindricalCoord p_actual, float p_delta)
			{
				Assert.AreEqual(p_expected.rho, p_actual.rho, p_delta);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_delta);
				Assert.AreEqual(p_expected.z, p_actual.z, p_delta);
			}

			public static void AreEqual (CylindricalCoord p_expected, CylindricalCoord p_actual, float p_delta, string p_message)
			{
				Assert.AreEqual(p_expected.rho, p_actual.rho, p_delta, p_message);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_delta, p_message);
				Assert.AreEqual(p_expected.z, p_actual.z, p_delta, p_message);
			}

			public static void AreEqual (CylindricalCoord p_expected, CylindricalCoord p_actual, float p_delta, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.rho, p_actual.rho, p_delta, p_message, p_args);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_delta, p_message, p_args);
				Assert.AreEqual(p_expected.z, p_actual.z, p_delta, p_message, p_args);
			}

			public static void AreEqual (CylindricalCoord p_expected, CylindricalCoord p_actual, string p_message)
			{
				Assert.AreEqual(p_expected.rho, p_actual.rho, p_message);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_message);
				Assert.AreEqual(p_expected.z, p_actual.z, p_message);
			}

			public static void AreEqual (CylindricalCoord p_expected, CylindricalCoord p_actual, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.rho, p_actual.rho, p_message, p_args);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_message, p_args);
				Assert.AreEqual(p_expected.z, p_actual.z, p_message, p_args);
			}

			public static void AreEqual (SphericalCoord p_expected, SphericalCoord p_actual)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius);
				Assert.AreEqual(p_expected.theta, p_actual.theta);
				Assert.AreEqual(p_expected.phi, p_actual.phi);
			}

			public static void AreEqual (SphericalCoord p_expected, SphericalCoord p_actual, float p_delta)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_delta);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_delta);
				Assert.AreEqual(p_expected.phi, p_actual.phi, p_delta);
			}

			public static void AreEqual (SphericalCoord p_expected, SphericalCoord p_actual, float p_delta, string p_message)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_delta, p_message);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_delta, p_message);
				Assert.AreEqual(p_expected.phi, p_actual.phi, p_delta, p_message);
			}

			public static void AreEqual (SphericalCoord p_expected, SphericalCoord p_actual, float p_delta, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_delta, p_message, p_args);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_delta, p_message, p_args);
				Assert.AreEqual(p_expected.phi, p_actual.phi, p_delta, p_message, p_args);
			}

			public static void AreEqual (SphericalCoord p_expected, SphericalCoord p_actual, string p_message)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_message);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_message);
				Assert.AreEqual(p_expected.phi, p_actual.phi, p_message);
			}

			public static void AreEqual (SphericalCoord p_expected, SphericalCoord p_actual, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_message, p_args);
				Assert.AreEqual(p_expected.theta, p_actual.theta, p_message, p_args);
				Assert.AreEqual(p_expected.phi, p_actual.phi, p_message, p_args);
			}

			public static void AreEqual (PolarCoord p_expected, PolarCoord p_actual)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius);
				Assert.AreEqual(p_expected.angle, p_actual.angle);
			}

			public static void AreEqual (PolarCoord p_expected, PolarCoord p_actual, float p_delta)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_delta);
				Assert.AreEqual(p_expected.angle, p_actual.angle, p_delta);
			}

			public static void AreEqual (PolarCoord p_expected, PolarCoord p_actual, float p_delta, string p_message)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_delta, p_message);
				Assert.AreEqual(p_expected.angle, p_actual.angle, p_delta, p_message);
			}

			public static void AreEqual (PolarCoord p_expected, PolarCoord p_actual, float p_delta, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_delta, p_message, p_args);
				Assert.AreEqual(p_expected.angle, p_actual.angle, p_delta, p_message, p_args);
			}

			public static void AreEqual (PolarCoord p_expected, PolarCoord p_actual, string p_message)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_message);
				Assert.AreEqual(p_expected.angle, p_actual.angle, p_message);
			}

			public static void AreEqual (PolarCoord p_expected, PolarCoord p_actual, string p_message, params object[] p_args)
			{
				Assert.AreEqual(p_expected.radius, p_actual.radius, p_message, p_args);
				Assert.AreEqual(p_expected.angle, p_actual.angle, p_message, p_args);
			}

		#endregion
	}
}
