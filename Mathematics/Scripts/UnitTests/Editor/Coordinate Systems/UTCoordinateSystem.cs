using NUnit.Framework;
using UnityEngine;
using ZkTools.Mathematics.Angles;
using ZkTools.Mathematics.CoordinateSystems;

namespace ZkTools.Mathematics.UnitTests.Editor.CoordinateSystems
{
	internal class UTCoordinateSystem
	{
		#region // ==============================[Static Variables]============================== //

			private const float delta = 1e-5f;

		#endregion

		#region // ==============================[Methods]============================== //

			[Test]
			public void CartesianToCylindrical ()
			{
				Vector3 Vec1 = new Vector3(-2.0f, -2.0f, 2.0f * MathF.Sqrt(3.0f));
				CylindricalCoord expected1 =  new CylindricalCoord(4.0f, Trigo.TwoPiDivThree, -2.0f);
				CylindricalCoord result1 = CoordinateSystem.CartesianToCylindrical(Vec1);
				AssertX.AreEqual(expected1, result1, delta);

				Vector3 Vec2 = new Vector3(-3.809651922f, 4.0f, -1.219242484f);
				CylindricalCoord expected2 = new CylindricalCoord(4.0f, -2.8318530719191f, 4.0f);
				CylindricalCoord result2 = CoordinateSystem.CartesianToCylindrical(Vec2.x, Vec2.y, Vec2.z);
				AssertX.AreEqual(expected2, result2, delta);

				Vector3 Vec3 = new Vector3(4.999804132f, 6.0f, 0.04425654645f);
				CylindricalCoord expected3 = new CylindricalCoord(5.0f, 0.0088519979751438f, 6.0f);
				CoordinateSystem.CartesianToCylindrical(Vec3, out CylindricalCoord result3);
				AssertX.AreEqual(expected3, result3, delta);

				Vector3 Vec4 = new Vector3(4.999804132f, 6.0f, 0.04425654645f);
				CylindricalCoord expected4 = new CylindricalCoord(5.0f, 0.0088519979751438f, 6.0f);
				CoordinateSystem.CartesianToCylindrical(Vec4, out float cylRho4, out Radian cylPhi4, out float cylZ4);
				CylindricalCoord result4 = new CylindricalCoord(cylRho4, cylPhi4, cylZ4);
				AssertX.AreEqual(expected4, result4, delta);

				Debug.Log(CoordinateSystem.SphericalToCartesian(1.0f, Trigo.DegreeToRadian(0.0f), Trigo.DegreeToRadian(45.0f)).ToString("F6"));
				Debug.Log(CoordinateSystem.CartesianToSpherical(1.0f, 0.0f, 0.0f).ToString("F6"));
			}

			[Test]
			public void CartesianToPolar ()
			{
				Vector2 Vec1 = new Vector2(-2.0f, 2.0f);
				PolarCoord expected1 = new PolarCoord(2.8284271247462f, 2.3561944901923f);
				PolarCoord result1 = CoordinateSystem.CartesianToPolar(Vec1);
				AssertX.AreEqual(expected1, result1, delta);

				Vector2 Vec2 = new Vector2(-3.809651922f, -1.219242484f);
				PolarCoord expected2 = new PolarCoord(4.0f, -2.8318530719191f);
				PolarCoord result2 = CoordinateSystem.CartesianToPolar(Vec2.x, Vec2.y);
				AssertX.AreEqual(expected2, result2, delta);

				Vector2 Vec3 = new Vector2(5.0f, 0.04425654645f);
				PolarCoord expected3 = new PolarCoord(5.0001958603542f, 0.0088510781469283f);
				CoordinateSystem.CartesianToPolar(Vec3, out PolarCoord result3);
				AssertX.AreEqual(expected3, result3, delta);

				Vector2 Vec4 = new Vector2(5.0f, 0.04425654645f);
				PolarCoord expected4 = new PolarCoord(5.0001958603542f, 0.0088510781469283f);
				CoordinateSystem.CartesianToPolar(Vec4, out float radius4, out Radian angle4);
				PolarCoord result4 = new PolarCoord(radius4, angle4);
				AssertX.AreEqual(expected4, result4, delta);
			}

			[Test]
			public void CartesianToSpherical ()
			{
				Vector3 Vec1 = new Vector3(-2.0f, 5.0f, -2.0f);
				SphericalCoord expected1 =  new SphericalCoord(5.744562646538f, 1.9513027039073f, 1.9263989097754f);
				SphericalCoord result1 = CoordinateSystem.CartesianToSpherical(Vec1);
				AssertX.AreEqual(expected1, result1, delta);

				Vector3 Vec2 = new Vector3(-3.809651922f, -1.219242484f, 4.0f);
				SphericalCoord expected2 = new SphericalCoord(5.6568542496328f, -2.8318530719191f, 0.78539816342227f);
				SphericalCoord result2 = CoordinateSystem.CartesianToSpherical(Vec2.x, Vec2.y, Vec2.z);
				AssertX.AreEqual(expected2, result2, delta);

				Vector3 Vec3 = new Vector3(4.999804132f, 0.04425654645f, 6.0f);
				SphericalCoord expected3 = new SphericalCoord(7.8102496759238f, 0.008851424870996f, 0.69473827619934f);
				CoordinateSystem.CartesianToSpherical(Vec3, out SphericalCoord result3);
				AssertX.AreEqual(expected3, result3, delta);

				Vector3 Vec4 = new Vector3(4.999804132f, 0.04425654645f, 6.0f);
				SphericalCoord expected4 = new SphericalCoord(7.8102496759238f, 0.008851424870996f, 0.69473827619934f);
				CoordinateSystem.CartesianToSpherical(Vec4, out float sphereRho4, out Radian spherePhi4, out Radian sphereZ4);
				SphericalCoord result4 = new SphericalCoord(sphereRho4, spherePhi4, sphereZ4);
				AssertX.AreEqual(expected4, result4, delta);
			}

			[Test]
			public void CylindricalToCartesian ()
			{
				CylindricalCoord cyl1 = new CylindricalCoord(4.0f, Trigo.TwoPiDivThree, -2.0f);
				Vector3 expected1 = new Vector3(-2.0f, -2.0f, 2.0f * MathF.Sqrt(3.0f));
				Vector3 result1 = CoordinateSystem.CylindricalToCartesian(cyl1);
				AssertX.AreEqual(expected1, result1, delta);

				CylindricalCoord cyl2 = new CylindricalCoord(4.0f, 60.0f, 4.0f);
				Vector3 expected2 = new Vector3(-3.809651922f, 4.0f, -1.219242484f);
				Vector3 result2 = CoordinateSystem.CylindricalToCartesian(cyl2.radius, cyl2.angle, cyl2.height);
				AssertX.AreEqual(expected2, result2, delta);

				CylindricalCoord cyl3 = new CylindricalCoord(-5.0f, 22.0f, 6.0f);
				Vector3 expected3 = new Vector3(4.999804132f, 6.0f, 0.04425654645f);
				CoordinateSystem.CylindricalToCartesian(cyl3, out Vector3 result3);
				AssertX.AreEqual(expected3, result3, delta);

				CylindricalCoord cyl4 = new CylindricalCoord(-5.0f, 22.0f, 6.0f);
				Vector3 expected4 = new Vector3(4.999804132f, 6.0f, 0.04425654645f);
				CoordinateSystem.CylindricalToCartesian(cyl4, out float x4, out float y4, out float z4);
				Vector3 result4 = new Vector3(x4, y4, z4);
				AssertX.AreEqual(expected4, result4, delta);
			}

			[Test]
			public void CylindricalToSpherical ()
			{
				CylindricalCoord cyl1 = new CylindricalCoord(3.0f, 60, 4.0f);
				SphericalCoord expected1 = new SphericalCoord(5.0f, 0.6435011088f, 60.0f);
				SphericalCoord result1 = CoordinateSystem.CylindricalToSpherical(cyl1);
				AssertX.AreEqual(expected1, result1, delta);

				CylindricalCoord cyl2 = new CylindricalCoord(-6.0f, 20.0f, 52.0f);
				SphericalCoord expected2 = new SphericalCoord(52.34500931f, -0.1148766054f, 20.0f);
				SphericalCoord result2 = CoordinateSystem.CylindricalToSpherical(cyl2.radius, cyl2.angle, cyl2.height);
				AssertX.AreEqual(expected2, result2, delta);

				CylindricalCoord cyl3 = new CylindricalCoord(23.0f, -52.0f, 3.0f);
				SphericalCoord expected3 = new SphericalCoord(23.19482701f, 1.44109379f, -52f);
				CoordinateSystem.CylindricalToSpherical(cyl3, out SphericalCoord result3);
				AssertX.AreEqual(expected3, result3, delta);

				CylindricalCoord cyl4 = new CylindricalCoord(-32.0f, -52.0f, -3.0f);
				SphericalCoord expected4 = new SphericalCoord(32.14031736f, -1.664273108f, -52f);
				CoordinateSystem.CylindricalToSpherical(cyl4, out float radius4, out Radian theta4, out Radian phi4);
				SphericalCoord result4 = new SphericalCoord(radius4, theta4, phi4);
				AssertX.AreEqual(expected4, result4, delta);
			}

			[Test]
			public void PolarToCartesian ()
			{
				PolarCoord polar1 = new PolarCoord(4.0f, Trigo.TwoPiDivThree);
				Vector2 expected1 = new Vector2(-2.0f, 2.0f * MathF.Sqrt(3.0f));
				Vector2 result1 = CoordinateSystem.PolarToCartesian(polar1);
				AssertX.AreEqual(expected1, result1, delta);

				PolarCoord polar2 = new PolarCoord(4.0f, 60.0f);
				Vector2 expected2 = new Vector2(-3.809651922f, -1.219242484f);
				Vector2 result2 = CoordinateSystem.PolarToCartesian(polar2.radius, polar2.angle);
				AssertX.AreEqual(expected2, result2, delta);

				PolarCoord polar3 = new PolarCoord(-5.0f, 22.0f);
				Vector2 expected3 = new Vector2(4.999804132f, 0.04425654645f);
				CoordinateSystem.PolarToCartesian(polar3, out Vector2 result3);
				AssertX.AreEqual(expected3, result3, delta);

				PolarCoord polar4 = new PolarCoord(-5.0f, 22.0f);
				Vector2 expected4 = new Vector2(4.999804132f, 0.04425654645f);
				CoordinateSystem.PolarToCartesian(polar4, out float x4, out float y4);
				Vector2 result4 = new Vector2(x4, y4);
				AssertX.AreEqual(expected4, result4, delta);
			}

			[Test]
			public void SphericalToCartesian ()
			{
				SphericalCoord sphere1 = new SphericalCoord(5.744562646538f, 0.69073f, 1.9263989097754f);
				Vector3 expected1 =  new Vector3(4.150783455f, 3.430888618f, -2.0f);
				Vector3 result1 = CoordinateSystem.SphericalToCartesian(sphere1);
				AssertX.AreEqual(expected1, result1, delta);

				SphericalCoord sphere2 = new SphericalCoord(5.6568542496328f, -2.8318530719191f, 0.78539816342227f);
				Vector3 expected2 = new Vector3(-3.809651922f, -1.219242484f, 4.0f);
				Vector3 result2 = CoordinateSystem.SphericalToCartesian(sphere2.radius, sphere2.theta, sphere2.phi);
				AssertX.AreEqual(expected2, result2, delta);

				SphericalCoord sphere3 = new SphericalCoord(7.8102496759238f, 0.008851424870996f, 0.69473827619934f);
				Vector3 expected3 = new Vector3(4.999804132f, 0.04425654645f, 6.0f);
				CoordinateSystem.SphericalToCartesian(sphere3, out Vector3 result3);
				AssertX.AreEqual(expected3, result3, delta);

				SphericalCoord sphere4 = new SphericalCoord(7.8102496759238f, 0.008851424870996f, 0.69473827619934f);
				Vector3 expected4 = new Vector3(4.999804132f, 0.04425654645f, 6.0f);
				CoordinateSystem.SphericalToCartesian(sphere4, out float x4, out float y4, out float z4);
				Vector3 result4 = new Vector3(x4, y4, z4);
				AssertX.AreEqual(expected4, result4, delta);
			}

			[Test]
			public void SphericalToCylindrical ()
			{
				SphericalCoord sphere1 = new SphericalCoord(5.0f, 0.6435011088f, 60.0f);
				CylindricalCoord expected1 = new CylindricalCoord(3.0f, 60, 4.0f);
				CylindricalCoord result1 = CoordinateSystem.SphericalToCylindrical(sphere1);
				AssertX.AreEqual(expected1, result1, delta);

				SphericalCoord sphere2 = new SphericalCoord(52.34500931f, -0.1148766054f, 20.0f);
				CylindricalCoord expected2 = new CylindricalCoord(-6.0f, 20.0f, 52.0f);
				CylindricalCoord result2 = CoordinateSystem.SphericalToCylindrical(sphere2.radius, sphere2.theta, sphere2.phi);
				AssertX.AreEqual(expected2, result2, delta);

				SphericalCoord sphere3 = new SphericalCoord(23.19482701f, 1.44109379f, -52f);
				CylindricalCoord expected3 = new CylindricalCoord(23.0f, -52.0f, 3.0f);
				CoordinateSystem.SphericalToCylindrical(sphere3, out CylindricalCoord result3);
				AssertX.AreEqual(expected3, result3, delta);

				SphericalCoord sphere4 = new SphericalCoord(32.14031736f, -1.664273108f, -52f);
				CylindricalCoord expected4 = new CylindricalCoord(-32.0f, -52.0f, -3.0f);
				CoordinateSystem.SphericalToCylindrical(sphere4, out float rho4, out Radian phi4, out float z4);
				CylindricalCoord result4 = new CylindricalCoord(rho4, phi4, z4);
				AssertX.AreEqual(expected4, result4, delta);
			}

		#endregion
	}
}

