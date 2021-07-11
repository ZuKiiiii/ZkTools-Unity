using NUnit.Framework;
using UnityEngine;
using ZkTools.Mathematics.Swizzling;

namespace ZkTools.Mathematics.UnitTests.Editor.Swizzling
{
	internal class UTVector4Swizzling
	{
		#region //,============================[Static Variables]==============================

			private static readonly float F1 = -1.0f;
			private static readonly float F2 = -2.0f;
			private static readonly float F3 = -3.0f;
			private static readonly Vector2 V2 = new Vector2(1.0f, 2.0f);
			private static readonly Vector3 V3 = new Vector3(3.0f, 4.0f, 5.0f);
			private static readonly Vector4 V4 = new Vector4(6.0f, 7.0f, 8.0f, 9.0f);

		#endregion

		#region //,============================[Methods]==============================

			[Test]
			public static void GetIJKW ()
			{
				Assert.AreEqual(new Vector4(F1, F2, F3, V4.w), V4.GetIJKW(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V4.w), V4.GetIJKW(V2, F1));
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V4.w), V4.GetIJKW(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V4.w), V4.GetIJKW(V3));
			}

			[Test]
			public static void GetIJKX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, F3, V4.x), V4.GetIJKX(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V4.x), V4.GetIJKX(V2, F1));
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V4.x), V4.GetIJKX(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V4.x), V4.GetIJKX(V3));
			}

			[Test]
			public static void GetIJKY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, F3, V4.y), V4.GetIJKY(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V4.y), V4.GetIJKY(V2, F1));
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V4.y), V4.GetIJKY(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V4.y), V4.GetIJKY(V3));
			}

			[Test]
			public static void GetIJKZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, F3, V4.z), V4.GetIJKZ(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V4.z), V4.GetIJKZ(V2, F1));
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V4.z), V4.GetIJKZ(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V4.z), V4.GetIJKZ(V3));
			}

			[Test]
			public static void GetIJW ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V4.w), V4.GetIJW(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V4.w), V4.GetIJW(V2));
			}

			[Test]
			public static void GetIJWL ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.w, F3), V4.GetIJWL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.w, F3), V4.GetIJWL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V2.x, V4.w, V2.y), V4.GetIJWL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V4.w, V3.z), V4.GetIJWL(V3));
			}

			[Test]
			public static void GetIJWW ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.w, V4.w), V4.GetIJWW(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.w, V4.w), V4.GetIJWW(V2));
			}

			[Test]
			public static void GetIJWX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.w, V4.x), V4.GetIJWX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.w, V4.x), V4.GetIJWX(V2));
			}

			[Test]
			public static void GetIJWY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.w, V4.y), V4.GetIJWY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.w, V4.y), V4.GetIJWY(V2));
			}

			[Test]
			public static void GetIJWZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.w, V4.z), V4.GetIJWZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.w, V4.z), V4.GetIJWZ(V2));
			}

			[Test]
			public static void GetIJX ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V4.x), V4.GetIJX(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V4.x), V4.GetIJX(V2));
			}

			[Test]
			public static void GetIJXL ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.x, F3), V4.GetIJXL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.x, F3), V4.GetIJXL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V2.x, V4.x, V2.y), V4.GetIJXL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V4.x, V3.z), V4.GetIJXL(V3));
			}

			[Test]
			public static void GetIJXW ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.x, V4.w), V4.GetIJXW(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.x, V4.w), V4.GetIJXW(V2));
			}

			[Test]
			public static void GetIJXX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.x, V4.x), V4.GetIJXX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.x, V4.x), V4.GetIJXX(V2));
			}

			[Test]
			public static void GetIJXY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.x, V4.y), V4.GetIJXY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.x, V4.y), V4.GetIJXY(V2));
			}

			[Test]
			public static void GetIJXZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.x, V4.z), V4.GetIJXZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.x, V4.z), V4.GetIJXZ(V2));
			}

			[Test]
			public static void GetIJY ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V4.y), V4.GetIJY(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V4.y), V4.GetIJY(V2));
			}

			[Test]
			public static void GetIJYL ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.y, F3), V4.GetIJYL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.y, F3), V4.GetIJYL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V2.x, V4.y, V2.y), V4.GetIJYL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V4.y, V3.z), V4.GetIJYL(V3));
			}

			[Test]
			public static void GetIJYW ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.y, V4.w), V4.GetIJYW(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.y, V4.w), V4.GetIJYW(V2));
			}

			[Test]
			public static void GetIJYX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.y, V4.x), V4.GetIJYX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.y, V4.x), V4.GetIJYX(V2));
			}

			[Test]
			public static void GetIJYY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.y, V4.y), V4.GetIJYY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.y, V4.y), V4.GetIJYY(V2));
			}

			[Test]
			public static void GetIJYZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.y, V4.z), V4.GetIJYZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.y, V4.z), V4.GetIJYZ(V2));
			}

			[Test]
			public static void GetIJZ ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V4.z), V4.GetIJZ(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V4.z), V4.GetIJZ(V2));
			}

			[Test]
			public static void GetIJZL ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.z, F3), V4.GetIJZL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.z, F3), V4.GetIJZL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V2.x, V4.z, V2.y), V4.GetIJZL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V4.z, V3.z), V4.GetIJZL(V3));
			}

			[Test]
			public static void GetIJZW ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.z, V4.w), V4.GetIJZW(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.z, V4.w), V4.GetIJZW(V2));
			}

			[Test]
			public static void GetIJZX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.z, V4.x), V4.GetIJZX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.z, V4.x), V4.GetIJZX(V2));
			}

			[Test]
			public static void GetIJZY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.z, V4.y), V4.GetIJZY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.z, V4.y), V4.GetIJZY(V2));
			}

			[Test]
			public static void GetIJZZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V4.z, V4.z), V4.GetIJZZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V4.z, V4.z), V4.GetIJZZ(V2));
			}

			[Test]
			public static void GetIW ()
			{
				Assert.AreEqual(new Vector2(F1, V4.w), V4.GetIW(F1));
			}

			[Test]
			public static void GetIWK ()
			{
				Assert.AreEqual(new Vector3(F1, V4.w, F2), V4.GetIWK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V4.w,V2.y), V4.GetIWK(V2));
			}

			[Test]
			public static void GetIWKL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, F2, F3), V4.GetIWKL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V2.y, F3), V4.GetIWKL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V4.w, V2.x, V2.y), V4.GetIWKL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V4.w, V3.y, V3.z), V4.GetIWKL(V3));
			}

			[Test]
			public static void GetIWKW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, F2, V4.w), V4.GetIWKW(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V2.y, V4.w), V4.GetIWKW(V2));
			}

			[Test]
			public static void GetIWKX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, F2, V4.x), V4.GetIWKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V2.y, V4.x), V4.GetIWKX(V2));
			}

			[Test]
			public static void GetIWKY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, F2, V4.y), V4.GetIWKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V2.y, V4.y), V4.GetIWKY(V2));
			}

			[Test]
			public static void GetIWKZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, F2, V4.z), V4.GetIWKZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V2.y, V4.z), V4.GetIWKZ(V2));
			}

			[Test]
			public static void GetIWW ()
			{
				Assert.AreEqual(new Vector3(F1, V4.w, V4.w), V4.GetIWW(F1));
			}

			[Test]
			public static void GetIWWL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, F2), V4.GetIWWL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V4.w, V2.y), V4.GetIWWL(V2));
			}

			[Test]
			public static void GetIWWW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, V4.w), V4.GetIWWW(F1));
			}

			[Test]
			public static void GetIWWX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, V4.x), V4.GetIWWX(F1));
			}

			[Test]
			public static void GetIWWY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, V4.y), V4.GetIWWY(F1));
			}

			[Test]
			public static void GetIWWZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, V4.z), V4.GetIWWZ(F1));
			}

			[Test]
			public static void GetIWX ()
			{
				Assert.AreEqual(new Vector3(F1, V4.w, V4.x), V4.GetIWX(F1));
			}

			[Test]
			public static void GetIWXL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.x, F2), V4.GetIWXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V4.x, V2.y), V4.GetIWXL(V2));
			}

			[Test]
			public static void GetIWXW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, V4.w), V4.GetIWXW(F1));
			}

			[Test]
			public static void GetIWXX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, V4.x), V4.GetIWXX(F1));
			}

			[Test]
			public static void GetIWXY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, V4.y), V4.GetIWXY(F1));
			}

			[Test]
			public static void GetIWXZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.w, V4.z), V4.GetIWXZ(F1));
			}

			[Test]
			public static void GetIWY ()
			{
				Assert.AreEqual(new Vector3(F1, V4.w, V4.y), V4.GetIWY(F1));
			}

			[Test]
			public static void GetIWYL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.y, F2), V4.GetIWYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V4.y, V2.y), V4.GetIWYL(V2));
			}

			[Test]
			public static void GetIWYW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.y, V4.w), V4.GetIWYW(F1));
			}

			[Test]
			public static void GetIWYX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.y, V4.x), V4.GetIWYX(F1));
			}

			[Test]
			public static void GetIWYY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.y, V4.y), V4.GetIWYY(F1));
			}

			[Test]
			public static void GetIWYZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.y, V4.z), V4.GetIWYZ(F1));
			}

			[Test]
			public static void GetIWZ ()
			{
				Assert.AreEqual(new Vector3(F1, V4.w, V4.z), V4.GetIWZ(F1));
			}

			[Test]
			public static void GetIWZL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.z, F2), V4.GetIWZL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.w, V4.z, V2.y), V4.GetIWZL(V2));
			}

			[Test]
			public static void GetIWZW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.z, V4.w), V4.GetIWZW(F1));
			}

			[Test]
			public static void GetIWZX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.z, V4.x), V4.GetIWZX(F1));
			}

			[Test]
			public static void GetIWZY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.z, V4.y), V4.GetIWZY(F1));
			}

			[Test]
			public static void GetIWZZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.w, V4.z, V4.z), V4.GetIWZZ(F1));
			}

			[Test]
			public static void GetIX ()
			{
				Assert.AreEqual(new Vector2(F1, V4.x), V4.GetIX(F1));
			}

			[Test]
			public static void GetIXK ()
			{
				Assert.AreEqual(new Vector3(F1, V4.x, F2), V4.GetIXK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V4.x,V2.y), V4.GetIXK(V2));
			}

			[Test]
			public static void GetIXKL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, F2, F3), V4.GetIXKL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V2.y, F3), V4.GetIXKL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V4.x, V2.x, V2.y), V4.GetIXKL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V4.x, V3.y, V3.z), V4.GetIXKL(V3));
			}

			[Test]
			public static void GetIXKW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, F2, V4.w), V4.GetIXKW(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V2.y, V4.w), V4.GetIXKW(V2));
			}

			[Test]
			public static void GetIXKX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, F2, V4.x), V4.GetIXKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V2.y, V4.x), V4.GetIXKX(V2));
			}

			[Test]
			public static void GetIXKY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, F2, V4.y), V4.GetIXKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V2.y, V4.y), V4.GetIXKY(V2));
			}

			[Test]
			public static void GetIXKZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, F2, V4.z), V4.GetIXKZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V2.y, V4.z), V4.GetIXKZ(V2));
			}

			[Test]
			public static void GetIXW ()
			{
				Assert.AreEqual(new Vector3(F1, V4.x, V4.w), V4.GetIXW(F1));
			}

			[Test]
			public static void GetIXWL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.w, F2), V4.GetIXWL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V4.w, V2.y), V4.GetIXWL(V2));
			}

			[Test]
			public static void GetIXWW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.w, V4.w), V4.GetIXWW(F1));
			}

			[Test]
			public static void GetIXWX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.w, V4.x), V4.GetIXWX(F1));
			}

			[Test]
			public static void GetIXWY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.w, V4.y), V4.GetIXWY(F1));
			}

			[Test]
			public static void GetIXWZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.w, V4.z), V4.GetIXWZ(F1));
			}

			[Test]
			public static void GetIXX ()
			{
				Assert.AreEqual(new Vector3(F1, V4.x, V4.x), V4.GetIXX(F1));
			}

			[Test]
			public static void GetIXXL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.x, F2), V4.GetIXXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V4.x, V2.y), V4.GetIXXL(V2));
			}

			[Test]
			public static void GetIXXW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.x, V4.w), V4.GetIXXW(F1));
			}

			[Test]
			public static void GetIXXX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.x, V4.x), V4.GetIXXX(F1));
			}

			[Test]
			public static void GetIXXY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.x, V4.y), V4.GetIXXY(F1));
			}

			[Test]
			public static void GetIXXZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.x, V4.z), V4.GetIXXZ(F1));
			}

			[Test]
			public static void GetIXY ()
			{
				Assert.AreEqual(new Vector3(F1, V4.x, V4.y), V4.GetIXY(F1));
			}

			[Test]
			public static void GetIXYL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.y, F2), V4.GetIXYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V4.y, V2.y), V4.GetIXYL(V2));
			}

			[Test]
			public static void GetIXYW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.y, V4.w), V4.GetIXYW(F1));
			}

			[Test]
			public static void GetIXYX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.y, V4.x), V4.GetIXYX(F1));
			}

			[Test]
			public static void GetIXYY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.y, V4.y), V4.GetIXYY(F1));
			}

			[Test]
			public static void GetIXYZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.y, V4.z), V4.GetIXYZ(F1));
			}

			[Test]
			public static void GetIXZ ()
			{
				Assert.AreEqual(new Vector3(F1, V4.x, V4.z), V4.GetIXZ(F1));
			}

			[Test]
			public static void GetIXZL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.z, F2), V4.GetIXZL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.x, V4.z, V2.y), V4.GetIXZL(V2));
			}

			[Test]
			public static void GetIXZW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.z, V4.w), V4.GetIXZW(F1));
			}

			[Test]
			public static void GetIXZX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.z, V4.x), V4.GetIXZX(F1));
			}

			[Test]
			public static void GetIXZY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.z, V4.y), V4.GetIXZY(F1));
			}

			[Test]
			public static void GetIXZZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.x, V4.z, V4.z), V4.GetIXZZ(F1));
			}

			[Test]
			public static void GetIY ()
			{
				Assert.AreEqual(new Vector2(F1, V4.y), V4.GetIY(F1));
			}

			[Test]
			public static void GetIYK ()
			{
				Assert.AreEqual(new Vector3(F1, V4.y, F2), V4.GetIYK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V4.y,V2.y), V4.GetIYK(V2));
			}

			[Test]
			public static void GetIYKL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, F2, F3), V4.GetIYKL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V2.y, F3), V4.GetIYKL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V4.y, V2.x, V2.y), V4.GetIYKL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V4.y, V3.y, V3.z), V4.GetIYKL(V3));
			}

			[Test]
			public static void GetIYKW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, F2, V4.w), V4.GetIYKW(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V2.y, V4.w), V4.GetIYKW(V2));
			}

			[Test]
			public static void GetIYKX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, F2, V4.x), V4.GetIYKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V2.y, V4.x), V4.GetIYKX(V2));
			}

			[Test]
			public static void GetIYKY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, F2, V4.y), V4.GetIYKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V2.y, V4.y), V4.GetIYKY(V2));
			}

			[Test]
			public static void GetIYKZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, F2, V4.z), V4.GetIYKZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V2.y, V4.z), V4.GetIYKZ(V2));
			}

			[Test]
			public static void GetIYW ()
			{
				Assert.AreEqual(new Vector3(F1, V4.y, V4.w), V4.GetIYW(F1));
			}

			[Test]
			public static void GetIYWL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.w, F2), V4.GetIYWL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V4.w, V2.y), V4.GetIYWL(V2));
			}

			[Test]
			public static void GetIYWW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.w, V4.w), V4.GetIYWW(F1));
			}

			[Test]
			public static void GetIYWX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.w, V4.x), V4.GetIYWX(F1));
			}

			[Test]
			public static void GetIYWY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.w, V4.y), V4.GetIYWY(F1));
			}

			[Test]
			public static void GetIYWZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.w, V4.z), V4.GetIYWZ(F1));
			}

			[Test]
			public static void GetIYX ()
			{
				Assert.AreEqual(new Vector3(F1, V4.y, V4.x), V4.GetIYX(F1));
			}

			[Test]
			public static void GetIYXL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.x, F2), V4.GetIYXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V4.x, V2.y), V4.GetIYXL(V2));
			}

			[Test]
			public static void GetIYXW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.x, V4.w), V4.GetIYXW(F1));
			}

			[Test]
			public static void GetIYXX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.x, V4.x), V4.GetIYXX(F1));
			}

			[Test]
			public static void GetIYXY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.x, V4.y), V4.GetIYXY(F1));
			}

			[Test]
			public static void GetIYXZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.x, V4.z), V4.GetIYXZ(F1));
			}

			[Test]
			public static void GetIYY ()
			{
				Assert.AreEqual(new Vector3(F1, V4.y, V4.y), V4.GetIYY(F1));
			}

			[Test]
			public static void GetIYYL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.y, F2), V4.GetIYYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V4.y, V2.y), V4.GetIYYL(V2));
			}

			[Test]
			public static void GetIYYW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.y, V4.w), V4.GetIYYW(F1));
			}

			[Test]
			public static void GetIYYX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.y, V4.x), V4.GetIYYX(F1));
			}

			[Test]
			public static void GetIYYY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.y, V4.y), V4.GetIYYY(F1));
			}

			[Test]
			public static void GetIYYZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.y, V4.z), V4.GetIYYZ(F1));
			}

			[Test]
			public static void GetIYZ ()
			{
				Assert.AreEqual(new Vector3(F1, V4.y, V4.z), V4.GetIYZ(F1));
			}

			[Test]
			public static void GetIYZL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.z, F2), V4.GetIYZL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.y, V4.z, V2.y), V4.GetIYZL(V2));
			}

			[Test]
			public static void GetIYZW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.z, V4.w), V4.GetIYZW(F1));
			}

			[Test]
			public static void GetIYZX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.z, V4.x), V4.GetIYZX(F1));
			}

			[Test]
			public static void GetIYZY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.z, V4.y), V4.GetIYZY(F1));
			}

			[Test]
			public static void GetIYZZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.y, V4.z, V4.z), V4.GetIYZZ(F1));
			}

			[Test]
			public static void GetIZ ()
			{
				Assert.AreEqual(new Vector2(F1, V4.z), V4.GetIZ(F1));
			}

			[Test]
			public static void GetIZK ()
			{
				Assert.AreEqual(new Vector3(F1, V4.z, F2), V4.GetIZK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V4.z,V2.y), V4.GetIZK(V2));
			}

			[Test]
			public static void GetIZKL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, F2, F3), V4.GetIZKL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V2.y, F3), V4.GetIZKL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V4.z, V2.x, V2.y), V4.GetIZKL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V4.z, V3.y, V3.z), V4.GetIZKL(V3));
			}

			[Test]
			public static void GetIZKW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, F2, V4.w), V4.GetIZKW(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V2.y, V4.w), V4.GetIZKW(V2));
			}

			[Test]
			public static void GetIZKX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, F2, V4.x), V4.GetIZKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V2.y, V4.x), V4.GetIZKX(V2));
			}

			[Test]
			public static void GetIZKY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, F2, V4.y), V4.GetIZKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V2.y, V4.y), V4.GetIZKY(V2));
			}

			[Test]
			public static void GetIZKZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, F2, V4.z), V4.GetIZKZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V2.y, V4.z), V4.GetIZKZ(V2));
			}

			[Test]
			public static void GetIZW ()
			{
				Assert.AreEqual(new Vector3(F1, V4.z, V4.w), V4.GetIZW(F1));
			}

			[Test]
			public static void GetIZWL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.w, F2), V4.GetIZWL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V4.w, V2.y), V4.GetIZWL(V2));
			}

			[Test]
			public static void GetIZWW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.w, V4.w), V4.GetIZWW(F1));
			}

			[Test]
			public static void GetIZWX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.w, V4.x), V4.GetIZWX(F1));
			}

			[Test]
			public static void GetIZWY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.w, V4.y), V4.GetIZWY(F1));
			}

			[Test]
			public static void GetIZWZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.w, V4.z), V4.GetIZWZ(F1));
			}

			[Test]
			public static void GetIZX ()
			{
				Assert.AreEqual(new Vector3(F1, V4.z, V4.x), V4.GetIZX(F1));
			}

			[Test]
			public static void GetIZXL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.x, F2), V4.GetIZXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V4.x, V2.y), V4.GetIZXL(V2));
			}

			[Test]
			public static void GetIZXW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.x, V4.w), V4.GetIZXW(F1));
			}

			[Test]
			public static void GetIZXX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.x, V4.x), V4.GetIZXX(F1));
			}

			[Test]
			public static void GetIZXY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.x, V4.y), V4.GetIZXY(F1));
			}

			[Test]
			public static void GetIZXZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.x, V4.z), V4.GetIZXZ(F1));
			}

			[Test]
			public static void GetIZY ()
			{
				Assert.AreEqual(new Vector3(F1, V4.z, V4.y), V4.GetIZY(F1));
			}

			[Test]
			public static void GetIZYL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.y, F2), V4.GetIZYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V4.y, V2.y), V4.GetIZYL(V2));
			}

			[Test]
			public static void GetIZYW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.y, V4.w), V4.GetIZYW(F1));
			}

			[Test]
			public static void GetIZYX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.y, V4.x), V4.GetIZYX(F1));
			}

			[Test]
			public static void GetIZYY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.y, V4.y), V4.GetIZYY(F1));
			}

			[Test]
			public static void GetIZYZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.y, V4.z), V4.GetIZYZ(F1));
			}

			[Test]
			public static void GetIZZ ()
			{
				Assert.AreEqual(new Vector3(F1, V4.z, V4.z), V4.GetIZZ(F1));
			}

			[Test]
			public static void GetIZZL ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.z, F2), V4.GetIZZL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V4.z, V4.z, V2.y), V4.GetIZZL(V2));
			}

			[Test]
			public static void GetIZZW ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.z, V4.w), V4.GetIZZW(F1));
			}

			[Test]
			public static void GetIZZX ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.z, V4.x), V4.GetIZZX(F1));
			}

			[Test]
			public static void GetIZZY ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.z, V4.y), V4.GetIZZY(F1));
			}

			[Test]
			public static void GetIZZZ ()
			{
				Assert.AreEqual(new Vector4(F1, V4.z, V4.z, V4.z), V4.GetIZZZ(F1));
			}

			[Test]
			public static void GetWJKW ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, F2, V4.w), V4.GetWJKW(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V2.x, V2.y, V4.w), V4.GetWJKW(V2));
			}

			[Test]
			public static void GetWJKX ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, F2, V4.x), V4.GetWJKX(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V2.x, V2.y, V4.x), V4.GetWJKX(V2));
			}

			[Test]
			public static void GetWJKY ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, F2, V4.y), V4.GetWJKY(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V2.x, V2.y, V4.y), V4.GetWJKY(V2));
			}

			[Test]
			public static void GetWJKZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, F2, V4.z), V4.GetWJKZ(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V2.x, V2.y, V4.z), V4.GetWJKZ(V2));
			}

			[Test]
			public static void GetWJW ()
			{
				Assert.AreEqual(new Vector3(V4.w, F1, V4.w), V4.GetWJW(F1));
			}

			[Test]
			public static void GetWJWL ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.w, F2), V4.GetWJWL(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V2.x, V4.w, V2.y), V4.GetWJWL(V2));
			}

			[Test]
			public static void GetWJWW ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.w, V4.w), V4.GetWJWW(F1));
			}

			[Test]
			public static void GetWJWX ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.w, V4.x), V4.GetWJWX(F1));
			}

			[Test]
			public static void GetWJWY ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.w, V4.y), V4.GetWJWY(F1));
			}

			[Test]
			public static void GetWJWZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.w, V4.z), V4.GetWJWZ(F1));
			}

			[Test]
			public static void GetWJX ()
			{
				Assert.AreEqual(new Vector3(V4.w, F1, V4.x), V4.GetWJX(F1));
			}

			[Test]
			public static void GetWJXL ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.x, F2), V4.GetWJXL(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V2.x, V4.x, V2.y), V4.GetWJXL(V2));
			}

			[Test]
			public static void GetWJXW ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.x, V4.w), V4.GetWJXW(F1));
			}

			[Test]
			public static void GetWJXX ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.x, V4.x), V4.GetWJXX(F1));
			}

			[Test]
			public static void GetWJXY ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.x, V4.y), V4.GetWJXY(F1));
			}

			[Test]
			public static void GetWJXZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.x, V4.z), V4.GetWJXZ(F1));
			}

			[Test]
			public static void GetWJY ()
			{
				Assert.AreEqual(new Vector3(V4.w, F1, V4.y), V4.GetWJY(F1));
			}

			[Test]
			public static void GetWJYL ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.y, F2), V4.GetWJYL(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V2.x, V4.y, V2.y), V4.GetWJYL(V2));
			}

			[Test]
			public static void GetWJYW ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.y, V4.w), V4.GetWJYW(F1));
			}

			[Test]
			public static void GetWJYX ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.y, V4.x), V4.GetWJYX(F1));
			}

			[Test]
			public static void GetWJYY ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.y, V4.y), V4.GetWJYY(F1));
			}

			[Test]
			public static void GetWJYZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.y, V4.z), V4.GetWJYZ(F1));
			}

			[Test]
			public static void GetWJZ ()
			{
				Assert.AreEqual(new Vector3(V4.w, F1, V4.z), V4.GetWJZ(F1));
			}

			[Test]
			public static void GetWJZL ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.z, F2), V4.GetWJZL(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V2.x, V4.z, V2.y), V4.GetWJZL(V2));
			}

			[Test]
			public static void GetWJZW ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.z, V4.w), V4.GetWJZW(F1));
			}

			[Test]
			public static void GetWJZX ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.z, V4.x), V4.GetWJZX(F1));
			}

			[Test]
			public static void GetWJZY ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.z, V4.y), V4.GetWJZY(F1));
			}

			[Test]
			public static void GetWJZZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, F1, V4.z, V4.z), V4.GetWJZZ(F1));
			}

			[Test]
			public static void GetWW ()
			{
				Assert.AreEqual(new Vector2(V4.w, V4.w), V4.GetWW());
			}

			[Test]
			public static void GetWWK ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.w, F1), V4.GetWWK(F1));
			}

			[Test]
			public static void GetWWKL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, F1, F2), V4.GetWWKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V4.w, V2.x, V2.y), V4.GetWWKL(V2));
			}

			[Test]
			public static void GetWWKW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, F1, V4.w), V4.GetWWKW(F1));
			}

			[Test]
			public static void GetWWKX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, F1, V4.x), V4.GetWWKX(F1));
			}

			[Test]
			public static void GetWWKY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, F1, V4.y), V4.GetWWKY(F1));
			}

			[Test]
			public static void GetWWKZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, F1, V4.z), V4.GetWWKZ(F1));
			}

			[Test]
			public static void GetWWW ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.w, V4.w), V4.GetWWW());
			}

			[Test]
			public static void GetWWWL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.w, F1), V4.GetWWWL(F1));
			}

			[Test]
			public static void GetWWWW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.w, V4.w), V4.GetWWWW());
			}

			[Test]
			public static void GetWWWX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.w, V4.x), V4.GetWWWX());
			}

			[Test]
			public static void GetWWWY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.w, V4.y), V4.GetWWWY());
			}

			[Test]
			public static void GetWWWZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.w, V4.z), V4.GetWWWZ());
			}

			[Test]
			public static void GetWWX ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.w, V4.x), V4.GetWWX());
			}

			[Test]
			public static void GetWWXL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.x, F1), V4.GetWWXL(F1));
			}

			[Test]
			public static void GetWWXW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.x, V4.w), V4.GetWWXW());
			}

			[Test]
			public static void GetWWXX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.x, V4.x), V4.GetWWXX());
			}

			[Test]
			public static void GetWWXY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.x, V4.y), V4.GetWWXY());
			}

			[Test]
			public static void GetWWXZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.x, V4.z), V4.GetWWXZ());
			}

			[Test]
			public static void GetWWY ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.w, V4.y), V4.GetWWY());
			}

			[Test]
			public static void GetWWYL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.y, F1), V4.GetWWYL(F1));
			}

			[Test]
			public static void GetWWYW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.y, V4.w), V4.GetWWYW());
			}

			[Test]
			public static void GetWWYX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.y, V4.x), V4.GetWWYX());
			}

			[Test]
			public static void GetWWYY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.y, V4.y), V4.GetWWYY());
			}

			[Test]
			public static void GetWWYZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.y, V4.z), V4.GetWWYZ());
			}

			[Test]
			public static void GetWWZ ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.w, V4.z), V4.GetWWZ());
			}

			[Test]
			public static void GetWWZL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.z, F1), V4.GetWWZL(F1));
			}

			[Test]
			public static void GetWWZW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.z, V4.w), V4.GetWWZW());
			}

			[Test]
			public static void GetWWZX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.z, V4.x), V4.GetWWZX());
			}

			[Test]
			public static void GetWWZY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.z, V4.y), V4.GetWWZY());
			}

			[Test]
			public static void GetWWZZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.w, V4.z, V4.z), V4.GetWWZZ());
			}

			[Test]
			public static void GetWXW ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.x, V4.w), V4.GetWXW());
			}

			[Test]
			public static void GetWXWL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.w, F1), V4.GetWXWL(F1));
			}

			[Test]
			public static void GetWXWW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.w, V4.w), V4.GetWXWW());
			}

			[Test]
			public static void GetWXWX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.w, V4.x), V4.GetWXWX());
			}

			[Test]
			public static void GetWXWY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.w, V4.y), V4.GetWXWY());
			}

			[Test]
			public static void GetWXWZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.w, V4.z), V4.GetWXWZ());
			}

			[Test]
			public static void GetWX ()
			{
				Assert.AreEqual(new Vector2(V4.w, V4.x), V4.GetWX());
			}

			[Test]
			public static void GetWXK ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.x, F1), V4.GetWXK(F1));
			}

			[Test]
			public static void GetWXKL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, F1, F2), V4.GetWXKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V4.x, V2.x, V2.y), V4.GetWXKL(V2));
			}

			[Test]
			public static void GetWXKW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, F1, V4.w), V4.GetWXKW(F1));
			}

			[Test]
			public static void GetWXKX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, F1, V4.x), V4.GetWXKX(F1));
			}

			[Test]
			public static void GetWXKY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, F1, V4.y), V4.GetWXKY(F1));
			}

			[Test]
			public static void GetWXKZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, F1, V4.z), V4.GetWXKZ(F1));
			}

			[Test]
			public static void GetWXX ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.x, V4.x), V4.GetWXX());
			}

			[Test]
			public static void GetWXXL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.x, F1), V4.GetWXXL(F1));
			}

			[Test]
			public static void GetWXXW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.x, V4.w), V4.GetWXXW());
			}

			[Test]
			public static void GetWXXX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.x, V4.x), V4.GetWXXX());
			}

			[Test]
			public static void GetWXXY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.x, V4.y), V4.GetWXXY());
			}

			[Test]
			public static void GetWXXZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.x, V4.z), V4.GetWXXZ());
			}

			[Test]
			public static void GetWXY ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.x, V4.y), V4.GetWXY());
			}

			[Test]
			public static void GetWXYL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.y, F1), V4.GetWXYL(F1));
			}

			[Test]
			public static void GetWXYW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.y, V4.w), V4.GetWXYW());
			}

			[Test]
			public static void GetWXYX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.y, V4.x), V4.GetWXYX());
			}

			[Test]
			public static void GetWXYY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.y, V4.y), V4.GetWXYY());
			}

			[Test]
			public static void GetWXYZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.y, V4.z), V4.GetWXYZ());
			}

			[Test]
			public static void GetWXZ ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.x, V4.z), V4.GetWXZ());
			}

			[Test]
			public static void GetWXZL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.z, F1), V4.GetWXZL(F1));
			}

			[Test]
			public static void GetWXZW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.z, V4.w), V4.GetWXZW());
			}

			[Test]
			public static void GetWXZX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.z, V4.x), V4.GetWXZX());
			}

			[Test]
			public static void GetWXZY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.z, V4.y), V4.GetWXZY());
			}

			[Test]
			public static void GetWXZZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.x, V4.z, V4.z), V4.GetWXZZ());
			}

			[Test]
			public static void GetWY ()
			{
				Assert.AreEqual(new Vector2(V4.w, V4.y), V4.GetWY());
			}

			[Test]
			public static void GetWYK ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.y, F1), V4.GetWYK(F1));
			}

			[Test]
			public static void GetWYKL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, F1, F2), V4.GetWYKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V4.y, V2.x, V2.y), V4.GetWYKL(V2));
			}

			[Test]
			public static void GetWYKW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, F1, V4.w), V4.GetWYKW(F1));
			}

			[Test]
			public static void GetWYKX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, F1, V4.x), V4.GetWYKX(F1));
			}

			[Test]
			public static void GetWYKY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, F1, V4.y), V4.GetWYKY(F1));
			}

			[Test]
			public static void GetWYKZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, F1, V4.z), V4.GetWYKZ(F1));
			}

			[Test]
			public static void GetWYW ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.y, V4.w), V4.GetWYW());
			}

			[Test]
			public static void GetWYWL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.w, F1), V4.GetWYWL(F1));
			}

			[Test]
			public static void GetWYWW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.w, V4.w), V4.GetWYWW());
			}

			[Test]
			public static void GetWYWX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.w, V4.x), V4.GetWYWX());
			}

			[Test]
			public static void GetWYWY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.w, V4.y), V4.GetWYWY());
			}

			[Test]
			public static void GetWYWZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.w, V4.z), V4.GetWYWZ());
			}

			[Test]
			public static void GetWYX ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.y, V4.x), V4.GetWYX());
			}

			[Test]
			public static void GetWYXL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.x, F1), V4.GetWYXL(F1));
			}

			[Test]
			public static void GetWYXW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.x, V4.w), V4.GetWYXW());
			}

			[Test]
			public static void GetWYXX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.x, V4.x), V4.GetWYXX());
			}

			[Test]
			public static void GetWYXY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.x, V4.y), V4.GetWYXY());
			}

			[Test]
			public static void GetWYXZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.x, V4.z), V4.GetWYXZ());
			}

			[Test]
			public static void GetWYY ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.y, V4.y), V4.GetWYY());
			}

			[Test]
			public static void GetWYYL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.y, F1), V4.GetWYYL(F1));
			}

			[Test]
			public static void GetWYYW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.y, V4.w), V4.GetWYYW());
			}

			[Test]
			public static void GetWYYX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.y, V4.x), V4.GetWYYX());
			}

			[Test]
			public static void GetWYYY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.y, V4.y), V4.GetWYYY());
			}

			[Test]
			public static void GetWYYZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.y, V4.z), V4.GetWYYZ());
			}

			[Test]
			public static void GetWYZ ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.y, V4.z), V4.GetWYZ());
			}

			[Test]
			public static void GetWYZL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.z, F1), V4.GetWYZL(F1));
			}

			[Test]
			public static void GetWYZW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.z, V4.w), V4.GetWYZW());
			}

			[Test]
			public static void GetWYZX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.z, V4.x), V4.GetWYZX());
			}

			[Test]
			public static void GetWYZY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.z, V4.y), V4.GetWYZY());
			}

			[Test]
			public static void GetWYZZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.y, V4.z, V4.z), V4.GetWYZZ());
			}

			[Test]
			public static void GetWZ ()
			{
				Assert.AreEqual(new Vector2(V4.w, V4.z), V4.GetWZ());
			}

			[Test]
			public static void GetWZK ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.z, F1), V4.GetWZK(F1));
			}

			[Test]
			public static void GetWZKL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, F1, F2), V4.GetWZKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.w, V4.z, V2.x, V2.y), V4.GetWZKL(V2));
			}

			[Test]
			public static void GetWZKW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, F1, V4.w), V4.GetWZKW(F1));
			}

			[Test]
			public static void GetWZKX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, F1, V4.x), V4.GetWZKX(F1));
			}

			[Test]
			public static void GetWZKY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, F1, V4.y), V4.GetWZKY(F1));
			}

			[Test]
			public static void GetWZKZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, F1, V4.z), V4.GetWZKZ(F1));
			}

			[Test]
			public static void GetWZW ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.z, V4.w), V4.GetWZW());
			}

			[Test]
			public static void GetWZWL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.w, F1), V4.GetWZWL(F1));
			}

			[Test]
			public static void GetWZWW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.w, V4.w), V4.GetWZWW());
			}

			[Test]
			public static void GetWZWX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.w, V4.x), V4.GetWZWX());
			}

			[Test]
			public static void GetWZWY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.w, V4.y), V4.GetWZWY());
			}

			[Test]
			public static void GetWZWZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.w, V4.z), V4.GetWZWZ());
			}

			[Test]
			public static void GetWZX ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.z, V4.x), V4.GetWZX());
			}

			[Test]
			public static void GetWZXL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.x, F1), V4.GetWZXL(F1));
			}

			[Test]
			public static void GetWZXW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.x, V4.w), V4.GetWZXW());
			}

			[Test]
			public static void GetWZXX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.x, V4.x), V4.GetWZXX());
			}

			[Test]
			public static void GetWZXY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.x, V4.y), V4.GetWZXY());
			}

			[Test]
			public static void GetWZXZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.x, V4.z), V4.GetWZXZ());
			}

			[Test]
			public static void GetWZY ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.z, V4.y), V4.GetWZY());
			}

			[Test]
			public static void GetWZYL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.y, F1), V4.GetWZYL(F1));
			}

			[Test]
			public static void GetWZYW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.y, V4.w), V4.GetWZYW());
			}

			[Test]
			public static void GetWZYX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.y, V4.x), V4.GetWZYX());
			}

			[Test]
			public static void GetWZYY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.y, V4.y), V4.GetWZYY());
			}

			[Test]
			public static void GetWZYZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.y, V4.z), V4.GetWZYZ());
			}

			[Test]
			public static void GetWZZ ()
			{
				Assert.AreEqual(new Vector3(V4.w, V4.z, V4.z), V4.GetWZZ());
			}

			[Test]
			public static void GetWZZL ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.z, F1), V4.GetWZZL(F1));
			}

			[Test]
			public static void GetWZZW ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.z, V4.w), V4.GetWZZW());
			}

			[Test]
			public static void GetWZZX ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.z, V4.x), V4.GetWZZX());
			}

			[Test]
			public static void GetWZZY ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.z, V4.y), V4.GetWZZY());
			}

			[Test]
			public static void GetWZZZ ()
			{
				Assert.AreEqual(new Vector4(V4.w, V4.z, V4.z, V4.z), V4.GetWZZZ());
			}

			[Test]
			public static void GetXJKW ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, F2, V4.w), V4.GetXJKW(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V2.x, V2.y, V4.w), V4.GetXJKW(V2));
			}

			[Test]
			public static void GetXJKX ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, F2, V4.x), V4.GetXJKX(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V2.x, V2.y, V4.x), V4.GetXJKX(V2));
			}

			[Test]
			public static void GetXJKY ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, F2, V4.y), V4.GetXJKY(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V2.x, V2.y, V4.y), V4.GetXJKY(V2));
			}

			[Test]
			public static void GetXJKZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, F2, V4.z), V4.GetXJKZ(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V2.x, V2.y, V4.z), V4.GetXJKZ(V2));
			}

			[Test]
			public static void GetXJW ()
			{
				Assert.AreEqual(new Vector3(V4.x, F1, V4.w), V4.GetXJW(F1));
			}

			[Test]
			public static void GetXJWL ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.w, F2), V4.GetXJWL(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V2.x, V4.w, V2.y), V4.GetXJWL(V2));
			}

			[Test]
			public static void GetXJWW ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.w, V4.w), V4.GetXJWW(F1));
			}

			[Test]
			public static void GetXJWX ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.w, V4.x), V4.GetXJWX(F1));
			}

			[Test]
			public static void GetXJWY ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.w, V4.y), V4.GetXJWY(F1));
			}

			[Test]
			public static void GetXJWZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.w, V4.z), V4.GetXJWZ(F1));
			}

			[Test]
			public static void GetXJX ()
			{
				Assert.AreEqual(new Vector3(V4.x, F1, V4.x), V4.GetXJX(F1));
			}

			[Test]
			public static void GetXJXL ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.x, F2), V4.GetXJXL(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V2.x, V4.x, V2.y), V4.GetXJXL(V2));
			}

			[Test]
			public static void GetXJXW ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.x, V4.w), V4.GetXJXW(F1));
			}

			[Test]
			public static void GetXJXX ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.x, V4.x), V4.GetXJXX(F1));
			}

			[Test]
			public static void GetXJXY ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.x, V4.y), V4.GetXJXY(F1));
			}

			[Test]
			public static void GetXJXZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.x, V4.z), V4.GetXJXZ(F1));
			}

			[Test]
			public static void GetXJY ()
			{
				Assert.AreEqual(new Vector3(V4.x, F1, V4.y), V4.GetXJY(F1));
			}

			[Test]
			public static void GetXJYL ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.y, F2), V4.GetXJYL(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V2.x, V4.y, V2.y), V4.GetXJYL(V2));
			}

			[Test]
			public static void GetXJYW ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.y, V4.w), V4.GetXJYW(F1));
			}

			[Test]
			public static void GetXJYX ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.y, V4.x), V4.GetXJYX(F1));
			}

			[Test]
			public static void GetXJYY ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.y, V4.y), V4.GetXJYY(F1));
			}

			[Test]
			public static void GetXJYZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.y, V4.z), V4.GetXJYZ(F1));
			}

			[Test]
			public static void GetXJZ ()
			{
				Assert.AreEqual(new Vector3(V4.x, F1, V4.z), V4.GetXJZ(F1));
			}

			[Test]
			public static void GetXJZL ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.z, F2), V4.GetXJZL(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V2.x, V4.z, V2.y), V4.GetXJZL(V2));
			}

			[Test]
			public static void GetXJZW ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.z, V4.w), V4.GetXJZW(F1));
			}

			[Test]
			public static void GetXJZX ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.z, V4.x), V4.GetXJZX(F1));
			}

			[Test]
			public static void GetXJZY ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.z, V4.y), V4.GetXJZY(F1));
			}

			[Test]
			public static void GetXJZZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, F1, V4.z, V4.z), V4.GetXJZZ(F1));
			}

			[Test]
			public static void GetXW ()
			{
				Assert.AreEqual(new Vector2(V4.x, V4.w), V4.GetXW());
			}

			[Test]
			public static void GetXWK ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.w, F1), V4.GetXWK(F1));
			}

			[Test]
			public static void GetXWKL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, F1, F2), V4.GetXWKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V4.w, V2.x, V2.y), V4.GetXWKL(V2));
			}

			[Test]
			public static void GetXWKW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, F1, V4.w), V4.GetXWKW(F1));
			}

			[Test]
			public static void GetXWKX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, F1, V4.x), V4.GetXWKX(F1));
			}

			[Test]
			public static void GetXWKY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, F1, V4.y), V4.GetXWKY(F1));
			}

			[Test]
			public static void GetXWKZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, F1, V4.z), V4.GetXWKZ(F1));
			}

			[Test]
			public static void GetXWW ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.w, V4.w), V4.GetXWW());
			}

			[Test]
			public static void GetXWWL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.w, F1), V4.GetXWWL(F1));
			}

			[Test]
			public static void GetXWWW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.w, V4.w), V4.GetXWWW());
			}

			[Test]
			public static void GetXWWX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.w, V4.x), V4.GetXWWX());
			}

			[Test]
			public static void GetXWWY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.w, V4.y), V4.GetXWWY());
			}

			[Test]
			public static void GetXWWZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.w, V4.z), V4.GetXWWZ());
			}

			[Test]
			public static void GetXWX ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.w, V4.x), V4.GetXWX());
			}

			[Test]
			public static void GetXWXL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.x, F1), V4.GetXWXL(F1));
			}

			[Test]
			public static void GetXWXW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.x, V4.w), V4.GetXWXW());
			}

			[Test]
			public static void GetXWXX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.x, V4.x), V4.GetXWXX());
			}

			[Test]
			public static void GetXWXY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.x, V4.y), V4.GetXWXY());
			}

			[Test]
			public static void GetXWXZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.x, V4.z), V4.GetXWXZ());
			}

			[Test]
			public static void GetXWY ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.w, V4.y), V4.GetXWY());
			}

			[Test]
			public static void GetXWYL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.y, F1), V4.GetXWYL(F1));
			}

			[Test]
			public static void GetXWYW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.y, V4.w), V4.GetXWYW());
			}

			[Test]
			public static void GetXWYX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.y, V4.x), V4.GetXWYX());
			}

			[Test]
			public static void GetXWYY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.y, V4.y), V4.GetXWYY());
			}

			[Test]
			public static void GetXWYZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.y, V4.z), V4.GetXWYZ());
			}

			[Test]
			public static void GetXWZ ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.w, V4.z), V4.GetXWZ());
			}

			[Test]
			public static void GetXWZL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.z, F1), V4.GetXWZL(F1));
			}

			[Test]
			public static void GetXWZW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.z, V4.w), V4.GetXWZW());
			}

			[Test]
			public static void GetXWZX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.z, V4.x), V4.GetXWZX());
			}

			[Test]
			public static void GetXWZY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.z, V4.y), V4.GetXWZY());
			}

			[Test]
			public static void GetXWZZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.w, V4.z, V4.z), V4.GetXWZZ());
			}

			[Test]
			public static void GetXXW ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.x, V4.w), V4.GetXXW());
			}

			[Test]
			public static void GetXXWL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.w, F1), V4.GetXXWL(F1));
			}

			[Test]
			public static void GetXXWW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.w, V4.w), V4.GetXXWW());
			}

			[Test]
			public static void GetXXWX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.w, V4.x), V4.GetXXWX());
			}

			[Test]
			public static void GetXXWY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.w, V4.y), V4.GetXXWY());
			}

			[Test]
			public static void GetXXWZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.w, V4.z), V4.GetXXWZ());
			}

			[Test]
			public static void GetXX ()
			{
				Assert.AreEqual(new Vector2(V4.x, V4.x), V4.GetXX());
			}

			[Test]
			public static void GetXXK ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.x, F1), V4.GetXXK(F1));
			}

			[Test]
			public static void GetXXKL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, F1, F2), V4.GetXXKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V4.x, V2.x, V2.y), V4.GetXXKL(V2));
			}

			[Test]
			public static void GetXXKW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, F1, V4.w), V4.GetXXKW(F1));
			}

			[Test]
			public static void GetXXKX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, F1, V4.x), V4.GetXXKX(F1));
			}

			[Test]
			public static void GetXXKY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, F1, V4.y), V4.GetXXKY(F1));
			}

			[Test]
			public static void GetXXKZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, F1, V4.z), V4.GetXXKZ(F1));
			}

			[Test]
			public static void GetXXX ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.x, V4.x), V4.GetXXX());
			}

			[Test]
			public static void GetXXXL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.x, F1), V4.GetXXXL(F1));
			}

			[Test]
			public static void GetXXXW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.x, V4.w), V4.GetXXXW());
			}

			[Test]
			public static void GetXXXX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.x, V4.x), V4.GetXXXX());
			}

			[Test]
			public static void GetXXXY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.x, V4.y), V4.GetXXXY());
			}

			[Test]
			public static void GetXXXZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.x, V4.z), V4.GetXXXZ());
			}

			[Test]
			public static void GetXXY ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.x, V4.y), V4.GetXXY());
			}

			[Test]
			public static void GetXXYL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.y, F1), V4.GetXXYL(F1));
			}

			[Test]
			public static void GetXXYW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.y, V4.w), V4.GetXXYW());
			}

			[Test]
			public static void GetXXYX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.y, V4.x), V4.GetXXYX());
			}

			[Test]
			public static void GetXXYY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.y, V4.y), V4.GetXXYY());
			}

			[Test]
			public static void GetXXYZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.y, V4.z), V4.GetXXYZ());
			}

			[Test]
			public static void GetXXZ ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.x, V4.z), V4.GetXXZ());
			}

			[Test]
			public static void GetXXZL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.z, F1), V4.GetXXZL(F1));
			}

			[Test]
			public static void GetXXZW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.z, V4.w), V4.GetXXZW());
			}

			[Test]
			public static void GetXXZX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.z, V4.x), V4.GetXXZX());
			}

			[Test]
			public static void GetXXZY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.z, V4.y), V4.GetXXZY());
			}

			[Test]
			public static void GetXXZZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.x, V4.z, V4.z), V4.GetXXZZ());
			}

			[Test]
			public static void GetXY ()
			{
				Assert.AreEqual(new Vector2(V4.x, V4.y), V4.GetXY());
			}

			[Test]
			public static void GetXYK ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.y, F1), V4.GetXYK(F1));
			}

			[Test]
			public static void GetXYKL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, F1, F2), V4.GetXYKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V4.y, V2.x, V2.y), V4.GetXYKL(V2));
			}

			[Test]
			public static void GetXYKW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, F1, V4.w), V4.GetXYKW(F1));
			}

			[Test]
			public static void GetXYKX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, F1, V4.x), V4.GetXYKX(F1));
			}

			[Test]
			public static void GetXYKY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, F1, V4.y), V4.GetXYKY(F1));
			}

			[Test]
			public static void GetXYKZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, F1, V4.z), V4.GetXYKZ(F1));
			}

			[Test]
			public static void GetXYW ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.y, V4.w), V4.GetXYW());
			}

			[Test]
			public static void GetXYWL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.w, F1), V4.GetXYWL(F1));
			}

			[Test]
			public static void GetXYWW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.w, V4.w), V4.GetXYWW());
			}

			[Test]
			public static void GetXYWX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.w, V4.x), V4.GetXYWX());
			}

			[Test]
			public static void GetXYWY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.w, V4.y), V4.GetXYWY());
			}

			[Test]
			public static void GetXYWZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.w, V4.z), V4.GetXYWZ());
			}

			[Test]
			public static void GetXYX ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.y, V4.x), V4.GetXYX());
			}

			[Test]
			public static void GetXYXL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.x, F1), V4.GetXYXL(F1));
			}

			[Test]
			public static void GetXYXW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.x, V4.w), V4.GetXYXW());
			}

			[Test]
			public static void GetXYXX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.x, V4.x), V4.GetXYXX());
			}

			[Test]
			public static void GetXYXY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.x, V4.y), V4.GetXYXY());
			}

			[Test]
			public static void GetXYXZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.x, V4.z), V4.GetXYXZ());
			}

			[Test]
			public static void GetXYY ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.y, V4.y), V4.GetXYY());
			}

			[Test]
			public static void GetXYYL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.y, F1), V4.GetXYYL(F1));
			}

			[Test]
			public static void GetXYYW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.y, V4.w), V4.GetXYYW());
			}

			[Test]
			public static void GetXYYX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.y, V4.x), V4.GetXYYX());
			}

			[Test]
			public static void GetXYYY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.y, V4.y), V4.GetXYYY());
			}

			[Test]
			public static void GetXYYZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.y, V4.z), V4.GetXYYZ());
			}

			[Test]
			public static void GetXYZ ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.y, V4.z), V4.GetXYZ());
			}

			[Test]
			public static void GetXYZL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.z, F1), V4.GetXYZL(F1));
			}

			[Test]
			public static void GetXYZW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.z, V4.w), V4.GetXYZW());
			}

			[Test]
			public static void GetXYZX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.z, V4.x), V4.GetXYZX());
			}

			[Test]
			public static void GetXYZY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.z, V4.y), V4.GetXYZY());
			}

			[Test]
			public static void GetXYZZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.y, V4.z, V4.z), V4.GetXYZZ());
			}

			[Test]
			public static void GetXZ ()
			{
				Assert.AreEqual(new Vector2(V4.x, V4.z), V4.GetXZ());
			}

			[Test]
			public static void GetXZK ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.z, F1), V4.GetXZK(F1));
			}

			[Test]
			public static void GetXZKL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, F1, F2), V4.GetXZKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.x, V4.z, V2.x, V2.y), V4.GetXZKL(V2));
			}

			[Test]
			public static void GetXZKW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, F1, V4.w), V4.GetXZKW(F1));
			}

			[Test]
			public static void GetXZKX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, F1, V4.x), V4.GetXZKX(F1));
			}

			[Test]
			public static void GetXZKY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, F1, V4.y), V4.GetXZKY(F1));
			}

			[Test]
			public static void GetXZKZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, F1, V4.z), V4.GetXZKZ(F1));
			}

			[Test]
			public static void GetXZW ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.z, V4.w), V4.GetXZW());
			}

			[Test]
			public static void GetXZWL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.w, F1), V4.GetXZWL(F1));
			}

			[Test]
			public static void GetXZWW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.w, V4.w), V4.GetXZWW());
			}

			[Test]
			public static void GetXZWX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.w, V4.x), V4.GetXZWX());
			}

			[Test]
			public static void GetXZWY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.w, V4.y), V4.GetXZWY());
			}

			[Test]
			public static void GetXZWZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.w, V4.z), V4.GetXZWZ());
			}

			[Test]
			public static void GetXZX ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.z, V4.x), V4.GetXZX());
			}

			[Test]
			public static void GetXZXL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.x, F1), V4.GetXZXL(F1));
			}

			[Test]
			public static void GetXZXW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.x, V4.w), V4.GetXZXW());
			}

			[Test]
			public static void GetXZXX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.x, V4.x), V4.GetXZXX());
			}

			[Test]
			public static void GetXZXY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.x, V4.y), V4.GetXZXY());
			}

			[Test]
			public static void GetXZXZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.x, V4.z), V4.GetXZXZ());
			}

			[Test]
			public static void GetXZY ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.z, V4.y), V4.GetXZY());
			}

			[Test]
			public static void GetXZYL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.y, F1), V4.GetXZYL(F1));
			}

			[Test]
			public static void GetXZYW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.y, V4.w), V4.GetXZYW());
			}

			[Test]
			public static void GetXZYX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.y, V4.x), V4.GetXZYX());
			}

			[Test]
			public static void GetXZYY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.y, V4.y), V4.GetXZYY());
			}

			[Test]
			public static void GetXZYZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.y, V4.z), V4.GetXZYZ());
			}

			[Test]
			public static void GetXZZ ()
			{
				Assert.AreEqual(new Vector3(V4.x, V4.z, V4.z), V4.GetXZZ());
			}

			[Test]
			public static void GetXZZL ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.z, F1), V4.GetXZZL(F1));
			}

			[Test]
			public static void GetXZZW ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.z, V4.w), V4.GetXZZW());
			}

			[Test]
			public static void GetXZZX ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.z, V4.x), V4.GetXZZX());
			}

			[Test]
			public static void GetXZZY ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.z, V4.y), V4.GetXZZY());
			}

			[Test]
			public static void GetXZZZ ()
			{
				Assert.AreEqual(new Vector4(V4.x, V4.z, V4.z, V4.z), V4.GetXZZZ());
			}

			[Test]
			public static void GetYJKW ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, F2, V4.w), V4.GetYJKW(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V2.x, V2.y, V4.w), V4.GetYJKW(V2));
			}

			[Test]
			public static void GetYJKX ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, F2, V4.x), V4.GetYJKX(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V2.x, V2.y, V4.x), V4.GetYJKX(V2));
			}

			[Test]
			public static void GetYJKY ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, F2, V4.y), V4.GetYJKY(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V2.x, V2.y, V4.y), V4.GetYJKY(V2));
			}

			[Test]
			public static void GetYJKZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, F2, V4.z), V4.GetYJKZ(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V2.x, V2.y, V4.z), V4.GetYJKZ(V2));
			}

			[Test]
			public static void GetYJW ()
			{
				Assert.AreEqual(new Vector3(V4.y, F1, V4.w), V4.GetYJW(F1));
			}

			[Test]
			public static void GetYJWL ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.w, F2), V4.GetYJWL(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V2.x, V4.w, V2.y), V4.GetYJWL(V2));
			}

			[Test]
			public static void GetYJWW ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.w, V4.w), V4.GetYJWW(F1));
			}

			[Test]
			public static void GetYJWX ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.w, V4.x), V4.GetYJWX(F1));
			}

			[Test]
			public static void GetYJWY ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.w, V4.y), V4.GetYJWY(F1));
			}

			[Test]
			public static void GetYJWZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.w, V4.z), V4.GetYJWZ(F1));
			}

			[Test]
			public static void GetYJX ()
			{
				Assert.AreEqual(new Vector3(V4.y, F1, V4.x), V4.GetYJX(F1));
			}

			[Test]
			public static void GetYJXL ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.x, F2), V4.GetYJXL(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V2.x, V4.x, V2.y), V4.GetYJXL(V2));
			}

			[Test]
			public static void GetYJXW ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.x, V4.w), V4.GetYJXW(F1));
			}

			[Test]
			public static void GetYJXX ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.x, V4.x), V4.GetYJXX(F1));
			}

			[Test]
			public static void GetYJXY ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.x, V4.y), V4.GetYJXY(F1));
			}

			[Test]
			public static void GetYJXZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.x, V4.z), V4.GetYJXZ(F1));
			}

			[Test]
			public static void GetYJY ()
			{
				Assert.AreEqual(new Vector3(V4.y, F1, V4.y), V4.GetYJY(F1));
			}

			[Test]
			public static void GetYJYL ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.y, F2), V4.GetYJYL(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V2.x, V4.y, V2.y), V4.GetYJYL(V2));
			}

			[Test]
			public static void GetYJYW ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.y, V4.w), V4.GetYJYW(F1));
			}

			[Test]
			public static void GetYJYX ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.y, V4.x), V4.GetYJYX(F1));
			}

			[Test]
			public static void GetYJYY ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.y, V4.y), V4.GetYJYY(F1));
			}

			[Test]
			public static void GetYJYZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.y, V4.z), V4.GetYJYZ(F1));
			}

			[Test]
			public static void GetYJZ ()
			{
				Assert.AreEqual(new Vector3(V4.y, F1, V4.z), V4.GetYJZ(F1));
			}

			[Test]
			public static void GetYJZL ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.z, F2), V4.GetYJZL(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V2.x, V4.z, V2.y), V4.GetYJZL(V2));
			}

			[Test]
			public static void GetYJZW ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.z, V4.w), V4.GetYJZW(F1));
			}

			[Test]
			public static void GetYJZX ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.z, V4.x), V4.GetYJZX(F1));
			}

			[Test]
			public static void GetYJZY ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.z, V4.y), V4.GetYJZY(F1));
			}

			[Test]
			public static void GetYJZZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, F1, V4.z, V4.z), V4.GetYJZZ(F1));
			}

			[Test]
			public static void GetYW ()
			{
				Assert.AreEqual(new Vector2(V4.y, V4.w), V4.GetYW());
			}

			[Test]
			public static void GetYWK ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.w, F1), V4.GetYWK(F1));
			}

			[Test]
			public static void GetYWKL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, F1, F2), V4.GetYWKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V4.w, V2.x, V2.y), V4.GetYWKL(V2));
			}

			[Test]
			public static void GetYWKW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, F1, V4.w), V4.GetYWKW(F1));
			}

			[Test]
			public static void GetYWKX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, F1, V4.x), V4.GetYWKX(F1));
			}

			[Test]
			public static void GetYWKY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, F1, V4.y), V4.GetYWKY(F1));
			}

			[Test]
			public static void GetYWKZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, F1, V4.z), V4.GetYWKZ(F1));
			}

			[Test]
			public static void GetYWW ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.w, V4.w), V4.GetYWW());
			}

			[Test]
			public static void GetYWWL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.w, F1), V4.GetYWWL(F1));
			}

			[Test]
			public static void GetYWWW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.w, V4.w), V4.GetYWWW());
			}

			[Test]
			public static void GetYWWX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.w, V4.x), V4.GetYWWX());
			}

			[Test]
			public static void GetYWWY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.w, V4.y), V4.GetYWWY());
			}

			[Test]
			public static void GetYWWZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.w, V4.z), V4.GetYWWZ());
			}

			[Test]
			public static void GetYWX ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.w, V4.x), V4.GetYWX());
			}

			[Test]
			public static void GetYWXL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.x, F1), V4.GetYWXL(F1));
			}

			[Test]
			public static void GetYWXW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.x, V4.w), V4.GetYWXW());
			}

			[Test]
			public static void GetYWXX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.x, V4.x), V4.GetYWXX());
			}

			[Test]
			public static void GetYWXY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.x, V4.y), V4.GetYWXY());
			}

			[Test]
			public static void GetYWXZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.x, V4.z), V4.GetYWXZ());
			}

			[Test]
			public static void GetYWY ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.w, V4.y), V4.GetYWY());
			}

			[Test]
			public static void GetYWYL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.y, F1), V4.GetYWYL(F1));
			}

			[Test]
			public static void GetYWYW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.y, V4.w), V4.GetYWYW());
			}

			[Test]
			public static void GetYWYX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.y, V4.x), V4.GetYWYX());
			}

			[Test]
			public static void GetYWYY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.y, V4.y), V4.GetYWYY());
			}

			[Test]
			public static void GetYWYZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.y, V4.z), V4.GetYWYZ());
			}

			[Test]
			public static void GetYWZ ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.w, V4.z), V4.GetYWZ());
			}

			[Test]
			public static void GetYWZL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.z, F1), V4.GetYWZL(F1));
			}

			[Test]
			public static void GetYWZW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.z, V4.w), V4.GetYWZW());
			}

			[Test]
			public static void GetYWZX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.z, V4.x), V4.GetYWZX());
			}

			[Test]
			public static void GetYWZY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.z, V4.y), V4.GetYWZY());
			}

			[Test]
			public static void GetYWZZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.w, V4.z, V4.z), V4.GetYWZZ());
			}

			[Test]
			public static void GetYXW ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.x, V4.w), V4.GetYXW());
			}

			[Test]
			public static void GetYXWL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.w, F1), V4.GetYXWL(F1));
			}

			[Test]
			public static void GetYXWW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.w, V4.w), V4.GetYXWW());
			}

			[Test]
			public static void GetYXWX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.w, V4.x), V4.GetYXWX());
			}

			[Test]
			public static void GetYXWY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.w, V4.y), V4.GetYXWY());
			}

			[Test]
			public static void GetYXWZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.w, V4.z), V4.GetYXWZ());
			}

			[Test]
			public static void GetYX ()
			{
				Assert.AreEqual(new Vector2(V4.y, V4.x), V4.GetYX());
			}

			[Test]
			public static void GetYXK ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.x, F1), V4.GetYXK(F1));
			}

			[Test]
			public static void GetYXKL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, F1, F2), V4.GetYXKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V4.x, V2.x, V2.y), V4.GetYXKL(V2));
			}

			[Test]
			public static void GetYXKW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, F1, V4.w), V4.GetYXKW(F1));
			}

			[Test]
			public static void GetYXKX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, F1, V4.x), V4.GetYXKX(F1));
			}

			[Test]
			public static void GetYXKY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, F1, V4.y), V4.GetYXKY(F1));
			}

			[Test]
			public static void GetYXKZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, F1, V4.z), V4.GetYXKZ(F1));
			}

			[Test]
			public static void GetYXX ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.x, V4.x), V4.GetYXX());
			}

			[Test]
			public static void GetYXXL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.x, F1), V4.GetYXXL(F1));
			}

			[Test]
			public static void GetYXXW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.x, V4.w), V4.GetYXXW());
			}

			[Test]
			public static void GetYXXX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.x, V4.x), V4.GetYXXX());
			}

			[Test]
			public static void GetYXXY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.x, V4.y), V4.GetYXXY());
			}

			[Test]
			public static void GetYXXZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.x, V4.z), V4.GetYXXZ());
			}

			[Test]
			public static void GetYXY ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.x, V4.y), V4.GetYXY());
			}

			[Test]
			public static void GetYXYL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.y, F1), V4.GetYXYL(F1));
			}

			[Test]
			public static void GetYXYW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.y, V4.w), V4.GetYXYW());
			}

			[Test]
			public static void GetYXYX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.y, V4.x), V4.GetYXYX());
			}

			[Test]
			public static void GetYXYY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.y, V4.y), V4.GetYXYY());
			}

			[Test]
			public static void GetYXYZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.y, V4.z), V4.GetYXYZ());
			}

			[Test]
			public static void GetYXZ ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.x, V4.z), V4.GetYXZ());
			}

			[Test]
			public static void GetYXZL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.z, F1), V4.GetYXZL(F1));
			}

			[Test]
			public static void GetYXZW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.z, V4.w), V4.GetYXZW());
			}

			[Test]
			public static void GetYXZX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.z, V4.x), V4.GetYXZX());
			}

			[Test]
			public static void GetYXZY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.z, V4.y), V4.GetYXZY());
			}

			[Test]
			public static void GetYXZZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.x, V4.z, V4.z), V4.GetYXZZ());
			}

			[Test]
			public static void GetYY ()
			{
				Assert.AreEqual(new Vector2(V4.y, V4.y), V4.GetYY());
			}

			[Test]
			public static void GetYYK ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.y, F1), V4.GetYYK(F1));
			}

			[Test]
			public static void GetYYKL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, F1, F2), V4.GetYYKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V4.y, V2.x, V2.y), V4.GetYYKL(V2));
			}

			[Test]
			public static void GetYYKW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, F1, V4.w), V4.GetYYKW(F1));
			}

			[Test]
			public static void GetYYKX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, F1, V4.x), V4.GetYYKX(F1));
			}

			[Test]
			public static void GetYYKY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, F1, V4.y), V4.GetYYKY(F1));
			}

			[Test]
			public static void GetYYKZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, F1, V4.z), V4.GetYYKZ(F1));
			}

			[Test]
			public static void GetYYW ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.y, V4.w), V4.GetYYW());
			}

			[Test]
			public static void GetYYWL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.w, F1), V4.GetYYWL(F1));
			}

			[Test]
			public static void GetYYWW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.w, V4.w), V4.GetYYWW());
			}

			[Test]
			public static void GetYYWX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.w, V4.x), V4.GetYYWX());
			}

			[Test]
			public static void GetYYWY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.w, V4.y), V4.GetYYWY());
			}

			[Test]
			public static void GetYYWZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.w, V4.z), V4.GetYYWZ());
			}

			[Test]
			public static void GetYYX ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.y, V4.x), V4.GetYYX());
			}

			[Test]
			public static void GetYYXL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.x, F1), V4.GetYYXL(F1));
			}

			[Test]
			public static void GetYYXW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.x, V4.w), V4.GetYYXW());
			}

			[Test]
			public static void GetYYXX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.x, V4.x), V4.GetYYXX());
			}

			[Test]
			public static void GetYYXY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.x, V4.y), V4.GetYYXY());
			}

			[Test]
			public static void GetYYXZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.x, V4.z), V4.GetYYXZ());
			}

			[Test]
			public static void GetYYY ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.y, V4.y), V4.GetYYY());
			}

			[Test]
			public static void GetYYYL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.y, F1), V4.GetYYYL(F1));
			}

			[Test]
			public static void GetYYYW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.y, V4.w), V4.GetYYYW());
			}

			[Test]
			public static void GetYYYX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.y, V4.x), V4.GetYYYX());
			}

			[Test]
			public static void GetYYYY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.y, V4.y), V4.GetYYYY());
			}

			[Test]
			public static void GetYYYZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.y, V4.z), V4.GetYYYZ());
			}

			[Test]
			public static void GetYYZ ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.y, V4.z), V4.GetYYZ());
			}

			[Test]
			public static void GetYYZL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.z, F1), V4.GetYYZL(F1));
			}

			[Test]
			public static void GetYYZW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.z, V4.w), V4.GetYYZW());
			}

			[Test]
			public static void GetYYZX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.z, V4.x), V4.GetYYZX());
			}

			[Test]
			public static void GetYYZY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.z, V4.y), V4.GetYYZY());
			}

			[Test]
			public static void GetYYZZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.y, V4.z, V4.z), V4.GetYYZZ());
			}

			[Test]
			public static void GetYZ ()
			{
				Assert.AreEqual(new Vector2(V4.y, V4.z), V4.GetYZ());
			}

			[Test]
			public static void GetYZK ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.z, F1), V4.GetYZK(F1));
			}

			[Test]
			public static void GetYZKL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, F1, F2), V4.GetYZKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.y, V4.z, V2.x, V2.y), V4.GetYZKL(V2));
			}

			[Test]
			public static void GetYZKW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, F1, V4.w), V4.GetYZKW(F1));
			}

			[Test]
			public static void GetYZKX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, F1, V4.x), V4.GetYZKX(F1));
			}

			[Test]
			public static void GetYZKY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, F1, V4.y), V4.GetYZKY(F1));
			}

			[Test]
			public static void GetYZKZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, F1, V4.z), V4.GetYZKZ(F1));
			}

			[Test]
			public static void GetYZW ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.z, V4.w), V4.GetYZW());
			}

			[Test]
			public static void GetYZWL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.w, F1), V4.GetYZWL(F1));
			}

			[Test]
			public static void GetYZWW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.w, V4.w), V4.GetYZWW());
			}

			[Test]
			public static void GetYZWX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.w, V4.x), V4.GetYZWX());
			}

			[Test]
			public static void GetYZWY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.w, V4.y), V4.GetYZWY());
			}

			[Test]
			public static void GetYZWZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.w, V4.z), V4.GetYZWZ());
			}

			[Test]
			public static void GetYZX ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.z, V4.x), V4.GetYZX());
			}

			[Test]
			public static void GetYZXL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.x, F1), V4.GetYZXL(F1));
			}

			[Test]
			public static void GetYZXW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.x, V4.w), V4.GetYZXW());
			}

			[Test]
			public static void GetYZXX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.x, V4.x), V4.GetYZXX());
			}

			[Test]
			public static void GetYZXY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.x, V4.y), V4.GetYZXY());
			}

			[Test]
			public static void GetYZXZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.x, V4.z), V4.GetYZXZ());
			}

			[Test]
			public static void GetYZY ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.z, V4.y), V4.GetYZY());
			}

			[Test]
			public static void GetYZYL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.y, F1), V4.GetYZYL(F1));
			}

			[Test]
			public static void GetYZYW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.y, V4.w), V4.GetYZYW());
			}

			[Test]
			public static void GetYZYX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.y, V4.x), V4.GetYZYX());
			}

			[Test]
			public static void GetYZYY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.y, V4.y), V4.GetYZYY());
			}

			[Test]
			public static void GetYZYZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.y, V4.z), V4.GetYZYZ());
			}

			[Test]
			public static void GetYZZ ()
			{
				Assert.AreEqual(new Vector3(V4.y, V4.z, V4.z), V4.GetYZZ());
			}

			[Test]
			public static void GetYZZL ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.z, F1), V4.GetYZZL(F1));
			}

			[Test]
			public static void GetYZZW ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.z, V4.w), V4.GetYZZW());
			}

			[Test]
			public static void GetYZZX ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.z, V4.x), V4.GetYZZX());
			}

			[Test]
			public static void GetYZZY ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.z, V4.y), V4.GetYZZY());
			}

			[Test]
			public static void GetYZZZ ()
			{
				Assert.AreEqual(new Vector4(V4.y, V4.z, V4.z, V4.z), V4.GetYZZZ());
			}

			[Test]
			public static void GetZJKW ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, F2, V4.w), V4.GetZJKW(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V2.x, V2.y, V4.w), V4.GetZJKW(V2));
			}

			[Test]
			public static void GetZJKX ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, F2, V4.x), V4.GetZJKX(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V2.x, V2.y, V4.x), V4.GetZJKX(V2));
			}

			[Test]
			public static void GetZJKY ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, F2, V4.y), V4.GetZJKY(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V2.x, V2.y, V4.y), V4.GetZJKY(V2));
			}

			[Test]
			public static void GetZJKZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, F2, V4.z), V4.GetZJKZ(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V2.x, V2.y, V4.z), V4.GetZJKZ(V2));
			}

			[Test]
			public static void GetZJW ()
			{
				Assert.AreEqual(new Vector3(V4.z, F1, V4.w), V4.GetZJW(F1));
			}

			[Test]
			public static void GetZJWL ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.w, F2), V4.GetZJWL(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V2.x, V4.w, V2.y), V4.GetZJWL(V2));
			}

			[Test]
			public static void GetZJWW ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.w, V4.w), V4.GetZJWW(F1));
			}

			[Test]
			public static void GetZJWX ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.w, V4.x), V4.GetZJWX(F1));
			}

			[Test]
			public static void GetZJWY ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.w, V4.y), V4.GetZJWY(F1));
			}

			[Test]
			public static void GetZJWZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.w, V4.z), V4.GetZJWZ(F1));
			}

			[Test]
			public static void GetZJX ()
			{
				Assert.AreEqual(new Vector3(V4.z, F1, V4.x), V4.GetZJX(F1));
			}

			[Test]
			public static void GetZJXL ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.x, F2), V4.GetZJXL(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V2.x, V4.x, V2.y), V4.GetZJXL(V2));
			}

			[Test]
			public static void GetZJXW ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.x, V4.w), V4.GetZJXW(F1));
			}

			[Test]
			public static void GetZJXX ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.x, V4.x), V4.GetZJXX(F1));
			}

			[Test]
			public static void GetZJXY ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.x, V4.y), V4.GetZJXY(F1));
			}

			[Test]
			public static void GetZJXZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.x, V4.z), V4.GetZJXZ(F1));
			}

			[Test]
			public static void GetZJY ()
			{
				Assert.AreEqual(new Vector3(V4.z, F1, V4.y), V4.GetZJY(F1));
			}

			[Test]
			public static void GetZJYL ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.y, F2), V4.GetZJYL(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V2.x, V4.y, V2.y), V4.GetZJYL(V2));
			}

			[Test]
			public static void GetZJYW ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.y, V4.w), V4.GetZJYW(F1));
			}

			[Test]
			public static void GetZJYX ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.y, V4.x), V4.GetZJYX(F1));
			}

			[Test]
			public static void GetZJYY ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.y, V4.y), V4.GetZJYY(F1));
			}

			[Test]
			public static void GetZJYZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.y, V4.z), V4.GetZJYZ(F1));
			}

			[Test]
			public static void GetZJZ ()
			{
				Assert.AreEqual(new Vector3(V4.z, F1, V4.z), V4.GetZJZ(F1));
			}

			[Test]
			public static void GetZJZL ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.z, F2), V4.GetZJZL(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V2.x, V4.z, V2.y), V4.GetZJZL(V2));
			}

			[Test]
			public static void GetZJZW ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.z, V4.w), V4.GetZJZW(F1));
			}

			[Test]
			public static void GetZJZX ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.z, V4.x), V4.GetZJZX(F1));
			}

			[Test]
			public static void GetZJZY ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.z, V4.y), V4.GetZJZY(F1));
			}

			[Test]
			public static void GetZJZZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, F1, V4.z, V4.z), V4.GetZJZZ(F1));
			}

			[Test]
			public static void GetZW ()
			{
				Assert.AreEqual(new Vector2(V4.z, V4.w), V4.GetZW());
			}

			[Test]
			public static void GetZWK ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.w, F1), V4.GetZWK(F1));
			}

			[Test]
			public static void GetZWKL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, F1, F2), V4.GetZWKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V4.w, V2.x, V2.y), V4.GetZWKL(V2));
			}

			[Test]
			public static void GetZWKW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, F1, V4.w), V4.GetZWKW(F1));
			}

			[Test]
			public static void GetZWKX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, F1, V4.x), V4.GetZWKX(F1));
			}

			[Test]
			public static void GetZWKY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, F1, V4.y), V4.GetZWKY(F1));
			}

			[Test]
			public static void GetZWKZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, F1, V4.z), V4.GetZWKZ(F1));
			}

			[Test]
			public static void GetZWW ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.w, V4.w), V4.GetZWW());
			}

			[Test]
			public static void GetZWWL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.w, F1), V4.GetZWWL(F1));
			}

			[Test]
			public static void GetZWWW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.w, V4.w), V4.GetZWWW());
			}

			[Test]
			public static void GetZWWX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.w, V4.x), V4.GetZWWX());
			}

			[Test]
			public static void GetZWWY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.w, V4.y), V4.GetZWWY());
			}

			[Test]
			public static void GetZWWZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.w, V4.z), V4.GetZWWZ());
			}

			[Test]
			public static void GetZWX ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.w, V4.x), V4.GetZWX());
			}

			[Test]
			public static void GetZWXL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.x, F1), V4.GetZWXL(F1));
			}

			[Test]
			public static void GetZWXW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.x, V4.w), V4.GetZWXW());
			}

			[Test]
			public static void GetZWXX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.x, V4.x), V4.GetZWXX());
			}

			[Test]
			public static void GetZWXY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.x, V4.y), V4.GetZWXY());
			}

			[Test]
			public static void GetZWXZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.x, V4.z), V4.GetZWXZ());
			}

			[Test]
			public static void GetZWY ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.w, V4.y), V4.GetZWY());
			}

			[Test]
			public static void GetZWYL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.y, F1), V4.GetZWYL(F1));
			}

			[Test]
			public static void GetZWYW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.y, V4.w), V4.GetZWYW());
			}

			[Test]
			public static void GetZWYX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.y, V4.x), V4.GetZWYX());
			}

			[Test]
			public static void GetZWYY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.y, V4.y), V4.GetZWYY());
			}

			[Test]
			public static void GetZWYZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.y, V4.z), V4.GetZWYZ());
			}

			[Test]
			public static void GetZWZ ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.w, V4.z), V4.GetZWZ());
			}

			[Test]
			public static void GetZWZL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.z, F1), V4.GetZWZL(F1));
			}

			[Test]
			public static void GetZWZW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.z, V4.w), V4.GetZWZW());
			}

			[Test]
			public static void GetZWZX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.z, V4.x), V4.GetZWZX());
			}

			[Test]
			public static void GetZWZY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.z, V4.y), V4.GetZWZY());
			}

			[Test]
			public static void GetZWZZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.w, V4.z, V4.z), V4.GetZWZZ());
			}

			[Test]
			public static void GetZXW ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.x, V4.w), V4.GetZXW());
			}

			[Test]
			public static void GetZXWL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.w, F1), V4.GetZXWL(F1));
			}

			[Test]
			public static void GetZXWW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.w, V4.w), V4.GetZXWW());
			}

			[Test]
			public static void GetZXWX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.w, V4.x), V4.GetZXWX());
			}

			[Test]
			public static void GetZXWY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.w, V4.y), V4.GetZXWY());
			}

			[Test]
			public static void GetZXWZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.w, V4.z), V4.GetZXWZ());
			}

			[Test]
			public static void GetZX ()
			{
				Assert.AreEqual(new Vector2(V4.z, V4.x), V4.GetZX());
			}

			[Test]
			public static void GetZXK ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.x, F1), V4.GetZXK(F1));
			}

			[Test]
			public static void GetZXKL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, F1, F2), V4.GetZXKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V4.x, V2.x, V2.y), V4.GetZXKL(V2));
			}

			[Test]
			public static void GetZXKW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, F1, V4.w), V4.GetZXKW(F1));
			}

			[Test]
			public static void GetZXKX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, F1, V4.x), V4.GetZXKX(F1));
			}

			[Test]
			public static void GetZXKY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, F1, V4.y), V4.GetZXKY(F1));
			}

			[Test]
			public static void GetZXKZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, F1, V4.z), V4.GetZXKZ(F1));
			}

			[Test]
			public static void GetZXX ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.x, V4.x), V4.GetZXX());
			}

			[Test]
			public static void GetZXXL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.x, F1), V4.GetZXXL(F1));
			}

			[Test]
			public static void GetZXXW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.x, V4.w), V4.GetZXXW());
			}

			[Test]
			public static void GetZXXX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.x, V4.x), V4.GetZXXX());
			}

			[Test]
			public static void GetZXXY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.x, V4.y), V4.GetZXXY());
			}

			[Test]
			public static void GetZXXZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.x, V4.z), V4.GetZXXZ());
			}

			[Test]
			public static void GetZXY ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.x, V4.y), V4.GetZXY());
			}

			[Test]
			public static void GetZXYL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.y, F1), V4.GetZXYL(F1));
			}

			[Test]
			public static void GetZXYW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.y, V4.w), V4.GetZXYW());
			}

			[Test]
			public static void GetZXYX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.y, V4.x), V4.GetZXYX());
			}

			[Test]
			public static void GetZXYY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.y, V4.y), V4.GetZXYY());
			}

			[Test]
			public static void GetZXYZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.y, V4.z), V4.GetZXYZ());
			}

			[Test]
			public static void GetZXZ ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.x, V4.z), V4.GetZXZ());
			}

			[Test]
			public static void GetZXZL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.z, F1), V4.GetZXZL(F1));
			}

			[Test]
			public static void GetZXZW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.z, V4.w), V4.GetZXZW());
			}

			[Test]
			public static void GetZXZX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.z, V4.x), V4.GetZXZX());
			}

			[Test]
			public static void GetZXZY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.z, V4.y), V4.GetZXZY());
			}

			[Test]
			public static void GetZXZZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.x, V4.z, V4.z), V4.GetZXZZ());
			}

			[Test]
			public static void GetZY ()
			{
				Assert.AreEqual(new Vector2(V4.z, V4.y), V4.GetZY());
			}

			[Test]
			public static void GetZYK ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.y, F1), V4.GetZYK(F1));
			}

			[Test]
			public static void GetZYKL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, F1, F2), V4.GetZYKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V4.y, V2.x, V2.y), V4.GetZYKL(V2));
			}

			[Test]
			public static void GetZYKW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, F1, V4.w), V4.GetZYKW(F1));
			}

			[Test]
			public static void GetZYKX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, F1, V4.x), V4.GetZYKX(F1));
			}

			[Test]
			public static void GetZYKY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, F1, V4.y), V4.GetZYKY(F1));
			}

			[Test]
			public static void GetZYKZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, F1, V4.z), V4.GetZYKZ(F1));
			}

			[Test]
			public static void GetZYW ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.y, V4.w), V4.GetZYW());
			}

			[Test]
			public static void GetZYWL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.w, F1), V4.GetZYWL(F1));
			}

			[Test]
			public static void GetZYWW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.w, V4.w), V4.GetZYWW());
			}

			[Test]
			public static void GetZYWX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.w, V4.x), V4.GetZYWX());
			}

			[Test]
			public static void GetZYWY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.w, V4.y), V4.GetZYWY());
			}

			[Test]
			public static void GetZYWZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.w, V4.z), V4.GetZYWZ());
			}

			[Test]
			public static void GetZYX ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.y, V4.x), V4.GetZYX());
			}

			[Test]
			public static void GetZYXL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.x, F1), V4.GetZYXL(F1));
			}

			[Test]
			public static void GetZYXW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.x, V4.w), V4.GetZYXW());
			}

			[Test]
			public static void GetZYXX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.x, V4.x), V4.GetZYXX());
			}

			[Test]
			public static void GetZYXY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.x, V4.y), V4.GetZYXY());
			}

			[Test]
			public static void GetZYXZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.x, V4.z), V4.GetZYXZ());
			}

			[Test]
			public static void GetZYY ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.y, V4.y), V4.GetZYY());
			}

			[Test]
			public static void GetZYYL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.y, F1), V4.GetZYYL(F1));
			}

			[Test]
			public static void GetZYYW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.y, V4.w), V4.GetZYYW());
			}

			[Test]
			public static void GetZYYX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.y, V4.x), V4.GetZYYX());
			}

			[Test]
			public static void GetZYYY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.y, V4.y), V4.GetZYYY());
			}

			[Test]
			public static void GetZYYZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.y, V4.z), V4.GetZYYZ());
			}

			[Test]
			public static void GetZYZ ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.y, V4.z), V4.GetZYZ());
			}

			[Test]
			public static void GetZYZL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.z, F1), V4.GetZYZL(F1));
			}

			[Test]
			public static void GetZYZW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.z, V4.w), V4.GetZYZW());
			}

			[Test]
			public static void GetZYZX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.z, V4.x), V4.GetZYZX());
			}

			[Test]
			public static void GetZYZY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.z, V4.y), V4.GetZYZY());
			}

			[Test]
			public static void GetZYZZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.y, V4.z, V4.z), V4.GetZYZZ());
			}

			[Test]
			public static void GetZZ ()
			{
				Assert.AreEqual(new Vector2(V4.z, V4.z), V4.GetZZ());
			}

			[Test]
			public static void GetZZK ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.z, F1), V4.GetZZK(F1));
			}

			[Test]
			public static void GetZZKL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, F1, F2), V4.GetZZKL(F1, F2));
				Assert.AreEqual(new Vector4(V4.z, V4.z, V2.x, V2.y), V4.GetZZKL(V2));
			}

			[Test]
			public static void GetZZKW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, F1, V4.w), V4.GetZZKW(F1));
			}

			[Test]
			public static void GetZZKX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, F1, V4.x), V4.GetZZKX(F1));
			}

			[Test]
			public static void GetZZKY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, F1, V4.y), V4.GetZZKY(F1));
			}

			[Test]
			public static void GetZZKZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, F1, V4.z), V4.GetZZKZ(F1));
			}

			[Test]
			public static void GetZZW ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.z, V4.w), V4.GetZZW());
			}

			[Test]
			public static void GetZZWL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.w, F1), V4.GetZZWL(F1));
			}

			[Test]
			public static void GetZZWW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.w, V4.w), V4.GetZZWW());
			}

			[Test]
			public static void GetZZWX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.w, V4.x), V4.GetZZWX());
			}

			[Test]
			public static void GetZZWY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.w, V4.y), V4.GetZZWY());
			}

			[Test]
			public static void GetZZWZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.w, V4.z), V4.GetZZWZ());
			}

			[Test]
			public static void GetZZX ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.z, V4.x), V4.GetZZX());
			}

			[Test]
			public static void GetZZXL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.x, F1), V4.GetZZXL(F1));
			}

			[Test]
			public static void GetZZXW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.x, V4.w), V4.GetZZXW());
			}

			[Test]
			public static void GetZZXX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.x, V4.x), V4.GetZZXX());
			}

			[Test]
			public static void GetZZXY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.x, V4.y), V4.GetZZXY());
			}

			[Test]
			public static void GetZZXZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.x, V4.z), V4.GetZZXZ());
			}

			[Test]
			public static void GetZZY ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.z, V4.y), V4.GetZZY());
			}

			[Test]
			public static void GetZZYL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.y, F1), V4.GetZZYL(F1));
			}

			[Test]
			public static void GetZZYW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.y, V4.w), V4.GetZZYW());
			}

			[Test]
			public static void GetZZYX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.y, V4.x), V4.GetZZYX());
			}

			[Test]
			public static void GetZZYY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.y, V4.y), V4.GetZZYY());
			}

			[Test]
			public static void GetZZYZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.y, V4.z), V4.GetZZYZ());
			}

			[Test]
			public static void GetZZZ ()
			{
				Assert.AreEqual(new Vector3(V4.z, V4.z, V4.z), V4.GetZZZ());
			}

			[Test]
			public static void GetZZZL ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.z, F1), V4.GetZZZL(F1));
			}

			[Test]
			public static void GetZZZW ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.z, V4.w), V4.GetZZZW());
			}

			[Test]
			public static void GetZZZX ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.z, V4.x), V4.GetZZZX());
			}

			[Test]
			public static void GetZZZY ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.z, V4.y), V4.GetZZZY());
			}

			[Test]
			public static void GetZZZZ ()
			{
				Assert.AreEqual(new Vector4(V4.z, V4.z, V4.z, V4.z), V4.GetZZZZ());
			}

		#endregion
	}
}