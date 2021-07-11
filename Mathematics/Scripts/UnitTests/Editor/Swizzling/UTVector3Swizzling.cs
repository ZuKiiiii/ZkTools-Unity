using NUnit.Framework;
using UnityEngine;
using ZkTools.Mathematics.Swizzling;

namespace ZkTools.Mathematics.UnitTests.Editor.Swizzling
{
	internal class UTVector3Swizzling
	{
		#region //,============================[Static Variables]==============================

			private static readonly float F1 = -1.0f;
			private static readonly float F2 = -2.0f;
			private static readonly float F3 = -3.0f;
			private static readonly Vector2 V2 = new Vector2(1.0f, 2.0f);
			private static readonly Vector3 V3 = new Vector3(3.0f, 4.0f, 5.0f);

		#endregion

		#region //,============================[Methods]==============================

			[Test]
			public static void GetIJKX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, F3, V3.x), V3.GetIJKX(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V3.x), V3.GetIJKX(V2, F1));
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V3.x), V3.GetIJKX(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V3.x), V3.GetIJKX(V3));
			}

			[Test]
			public static void GetIJKY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, F3, V3.y), V3.GetIJKY(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V3.y), V3.GetIJKY(V2, F1));
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V3.y), V3.GetIJKY(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V3.y), V3.GetIJKY(V3));
			}

			[Test]
			public static void GetIJKZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, F3, V3.z), V3.GetIJKZ(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V3.z), V3.GetIJKZ(V2, F1));
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V3.z), V3.GetIJKZ(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V3.z), V3.GetIJKZ(V3));
			}

			[Test]
			public static void GetIJX ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V3.x), V3.GetIJX(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V3.x), V3.GetIJX(V2));
			}

			[Test]
			public static void GetIJXL ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.x, F3), V3.GetIJXL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.x, F3), V3.GetIJXL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V2.x, V3.x, V2.y), V3.GetIJXL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.x, V3.z), V3.GetIJXL(V3));
			}

			[Test]
			public static void GetIJXX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.x, V3.x), V3.GetIJXX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.x, V3.x), V3.GetIJXX(V2));
			}

			[Test]
			public static void GetIJXY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.x, V3.y), V3.GetIJXY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.x, V3.y), V3.GetIJXY(V2));
			}

			[Test]
			public static void GetIJXZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.x, V3.z), V3.GetIJXZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.x, V3.z), V3.GetIJXZ(V2));
			}

			[Test]
			public static void GetIJY ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V3.y), V3.GetIJY(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V3.y), V3.GetIJY(V2));
			}

			[Test]
			public static void GetIJYL ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.y, F3), V3.GetIJYL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.y, F3), V3.GetIJYL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V2.x, V3.y, V2.y), V3.GetIJYL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.y, V3.z), V3.GetIJYL(V3));
			}

			[Test]
			public static void GetIJYX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.y, V3.x), V3.GetIJYX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.y, V3.x), V3.GetIJYX(V2));
			}

			[Test]
			public static void GetIJYY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.y, V3.y), V3.GetIJYY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.y, V3.y), V3.GetIJYY(V2));
			}

			[Test]
			public static void GetIJYZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.y, V3.z), V3.GetIJYZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.y, V3.z), V3.GetIJYZ(V2));
			}

			[Test]
			public static void GetIJZ ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V3.z), V3.GetIJZ(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V3.z), V3.GetIJZ(V2));
			}

			[Test]
			public static void GetIJZL ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.z, F3), V3.GetIJZL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.z, F3), V3.GetIJZL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V2.x, V3.z, V2.y), V3.GetIJZL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V3.z), V3.GetIJZL(V3));
			}

			[Test]
			public static void GetIJZX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.z, V3.x), V3.GetIJZX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.z, V3.x), V3.GetIJZX(V2));
			}

			[Test]
			public static void GetIJZY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.z, V3.y), V3.GetIJZY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.z, V3.y), V3.GetIJZY(V2));
			}

			[Test]
			public static void GetIJZZ ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V3.z, V3.z), V3.GetIJZZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V3.z, V3.z), V3.GetIJZZ(V2));
			}

			[Test]
			public static void GetIX ()
			{
				Assert.AreEqual(new Vector2(F1, V3.x), V3.GetIX(F1));
			}

			[Test]
			public static void GetIXK ()
			{
				Assert.AreEqual(new Vector3(F1, V3.x, F2), V3.GetIXK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V3.x,V2.y), V3.GetIXK(V2));
			}

			[Test]
			public static void GetIXKL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, F2, F3), V3.GetIXKL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V3.x, V2.y, F3), V3.GetIXKL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V3.x, V2.x, V2.y), V3.GetIXKL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.y, V3.z), V3.GetIXKL(V3));
			}

			[Test]
			public static void GetIXKX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, F2, V3.x), V3.GetIXKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.x, V2.y, V3.x), V3.GetIXKX(V2));
			}

			[Test]
			public static void GetIXKY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, F2, V3.y), V3.GetIXKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.x, V2.y, V3.y), V3.GetIXKY(V2));
			}

			[Test]
			public static void GetIXKZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, F2, V3.z), V3.GetIXKZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.x, V2.y, V3.z), V3.GetIXKZ(V2));
			}

			[Test]
			public static void GetIXX ()
			{
				Assert.AreEqual(new Vector3(F1, V3.x, V3.x), V3.GetIXX(F1));
			}

			[Test]
			public static void GetIXXL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.x, F2), V3.GetIXXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.x, V3.x, V2.y), V3.GetIXXL(V2));
			}

			[Test]
			public static void GetIXXX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.x, V3.x), V3.GetIXXX(F1));
			}

			[Test]
			public static void GetIXXY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.x, V3.y), V3.GetIXXY(F1));
			}

			[Test]
			public static void GetIXXZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.x, V3.z), V3.GetIXXZ(F1));
			}

			[Test]
			public static void GetIXY ()
			{
				Assert.AreEqual(new Vector3(F1, V3.x, V3.y), V3.GetIXY(F1));
			}

			[Test]
			public static void GetIXYL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.y, F2), V3.GetIXYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.x, V3.y, V2.y), V3.GetIXYL(V2));
			}

			[Test]
			public static void GetIXYX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.y, V3.x), V3.GetIXYX(F1));
			}

			[Test]
			public static void GetIXYY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.y, V3.y), V3.GetIXYY(F1));
			}

			[Test]
			public static void GetIXYZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.y, V3.z), V3.GetIXYZ(F1));
			}

			[Test]
			public static void GetIXZ ()
			{
				Assert.AreEqual(new Vector3(F1, V3.x, V3.z), V3.GetIXZ(F1));
			}

			[Test]
			public static void GetIXZL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.z, F2), V3.GetIXZL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.x, V3.z, V2.y), V3.GetIXZL(V2));
			}

			[Test]
			public static void GetIXZX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.z, V3.x), V3.GetIXZX(F1));
			}

			[Test]
			public static void GetIXZY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.z, V3.y), V3.GetIXZY(F1));
			}

			[Test]
			public static void GetIXZZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.x, V3.z, V3.z), V3.GetIXZZ(F1));
			}

			[Test]
			public static void GetIY ()
			{
				Assert.AreEqual(new Vector2(F1, V3.y), V3.GetIY(F1));
			}

			[Test]
			public static void GetIYK ()
			{
				Assert.AreEqual(new Vector3(F1, V3.y, F2), V3.GetIYK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V3.y,V2.y), V3.GetIYK(V2));
			}

			[Test]
			public static void GetIYKL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, F2, F3), V3.GetIYKL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V3.y, V2.y, F3), V3.GetIYKL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V3.y, V2.x, V2.y), V3.GetIYKL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.y, V3.z), V3.GetIYKL(V3));
			}

			[Test]
			public static void GetIYKX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, F2, V3.x), V3.GetIYKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.y, V2.y, V3.x), V3.GetIYKX(V2));
			}

			[Test]
			public static void GetIYKY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, F2, V3.y), V3.GetIYKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.y, V2.y, V3.y), V3.GetIYKY(V2));
			}

			[Test]
			public static void GetIYKZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, F2, V3.z), V3.GetIYKZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.y, V2.y, V3.z), V3.GetIYKZ(V2));
			}

			[Test]
			public static void GetIYX ()
			{
				Assert.AreEqual(new Vector3(F1, V3.y, V3.x), V3.GetIYX(F1));
			}

			[Test]
			public static void GetIYXL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.x, F2), V3.GetIYXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.y, V3.x, V2.y), V3.GetIYXL(V2));
			}

			[Test]
			public static void GetIYXX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.x, V3.x), V3.GetIYXX(F1));
			}

			[Test]
			public static void GetIYXY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.x, V3.y), V3.GetIYXY(F1));
			}

			[Test]
			public static void GetIYXZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.x, V3.z), V3.GetIYXZ(F1));
			}

			[Test]
			public static void GetIYY ()
			{
				Assert.AreEqual(new Vector3(F1, V3.y, V3.y), V3.GetIYY(F1));
			}

			[Test]
			public static void GetIYYL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.y, F2), V3.GetIYYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.y, V3.y, V2.y), V3.GetIYYL(V2));
			}

			[Test]
			public static void GetIYYX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.y, V3.x), V3.GetIYYX(F1));
			}

			[Test]
			public static void GetIYYY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.y, V3.y), V3.GetIYYY(F1));
			}

			[Test]
			public static void GetIYYZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.y, V3.z), V3.GetIYYZ(F1));
			}

			[Test]
			public static void GetIYZ ()
			{
				Assert.AreEqual(new Vector3(F1, V3.y, V3.z), V3.GetIYZ(F1));
			}

			[Test]
			public static void GetIYZL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.z, F2), V3.GetIYZL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.y, V3.z, V2.y), V3.GetIYZL(V2));
			}

			[Test]
			public static void GetIYZX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.z, V3.x), V3.GetIYZX(F1));
			}

			[Test]
			public static void GetIYZY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.z, V3.y), V3.GetIYZY(F1));
			}

			[Test]
			public static void GetIYZZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.y, V3.z, V3.z), V3.GetIYZZ(F1));
			}

			[Test]
			public static void GetIZ ()
			{
				Assert.AreEqual(new Vector2(F1, V3.z), V3.GetIZ(F1));
			}

			[Test]
			public static void GetIZK ()
			{
				Assert.AreEqual(new Vector3(F1, V3.z, F2), V3.GetIZK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V3.z,V2.y), V3.GetIZK(V2));
			}

			[Test]
			public static void GetIZKL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, F2, F3), V3.GetIZKL(F1, F2, F3));
				Assert.AreEqual(new Vector4(V2.x, V3.z, V2.y, F3), V3.GetIZKL(V2, F3));
				Assert.AreEqual(new Vector4(F1, V3.z, V2.x, V2.y), V3.GetIZKL(F1, V2));
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.y, V3.z), V3.GetIZKL(V3));
			}

			[Test]
			public static void GetIZKX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, F2, V3.x), V3.GetIZKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.z, V2.y, V3.x), V3.GetIZKX(V2));
			}

			[Test]
			public static void GetIZKY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, F2, V3.y), V3.GetIZKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.z, V2.y, V3.y), V3.GetIZKY(V2));
			}

			[Test]
			public static void GetIZKZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, F2, V3.z), V3.GetIZKZ(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.z, V2.y, V3.z), V3.GetIZKZ(V2));
			}

			[Test]
			public static void GetIZX ()
			{
				Assert.AreEqual(new Vector3(F1, V3.z, V3.x), V3.GetIZX(F1));
			}

			[Test]
			public static void GetIZXL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.x, F2), V3.GetIZXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.z, V3.x, V2.y), V3.GetIZXL(V2));
			}

			[Test]
			public static void GetIZXX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.x, V3.x), V3.GetIZXX(F1));
			}

			[Test]
			public static void GetIZXY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.x, V3.y), V3.GetIZXY(F1));
			}

			[Test]
			public static void GetIZXZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.x, V3.z), V3.GetIZXZ(F1));
			}

			[Test]
			public static void GetIZY ()
			{
				Assert.AreEqual(new Vector3(F1, V3.z, V3.y), V3.GetIZY(F1));
			}

			[Test]
			public static void GetIZYL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.y, F2), V3.GetIZYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.z, V3.y, V2.y), V3.GetIZYL(V2));
			}

			[Test]
			public static void GetIZYX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.y, V3.x), V3.GetIZYX(F1));
			}

			[Test]
			public static void GetIZYY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.y, V3.y), V3.GetIZYY(F1));
			}

			[Test]
			public static void GetIZYZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.y, V3.z), V3.GetIZYZ(F1));
			}

			[Test]
			public static void GetIZZ ()
			{
				Assert.AreEqual(new Vector3(F1, V3.z, V3.z), V3.GetIZZ(F1));
			}

			[Test]
			public static void GetIZZL ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.z, F2), V3.GetIZZL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V3.z, V3.z, V2.y), V3.GetIZZL(V2));
			}

			[Test]
			public static void GetIZZX ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.z, V3.x), V3.GetIZZX(F1));
			}

			[Test]
			public static void GetIZZY ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.z, V3.y), V3.GetIZZY(F1));
			}

			[Test]
			public static void GetIZZZ ()
			{
				Assert.AreEqual(new Vector4(F1, V3.z, V3.z, V3.z), V3.GetIZZZ(F1));
			}

			[Test]
			public static void GetXJKX ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, F2, V3.x), V3.GetXJKX(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V2.x, V2.y, V3.x), V3.GetXJKX(V2));
			}

			[Test]
			public static void GetXJKY ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, F2, V3.y), V3.GetXJKY(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V2.x, V2.y, V3.y), V3.GetXJKY(V2));
			}

			[Test]
			public static void GetXJKZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, F2, V3.z), V3.GetXJKZ(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V2.x, V2.y, V3.z), V3.GetXJKZ(V2));
			}

			[Test]
			public static void GetXJX ()
			{
				Assert.AreEqual(new Vector3(V3.x, F1, V3.x), V3.GetXJX(F1));
			}

			[Test]
			public static void GetXJXL ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.x, F2), V3.GetXJXL(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V2.x, V3.x, V2.y), V3.GetXJXL(V2));
			}

			[Test]
			public static void GetXJXX ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.x, V3.x), V3.GetXJXX(F1));
			}

			[Test]
			public static void GetXJXY ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.x, V3.y), V3.GetXJXY(F1));
			}

			[Test]
			public static void GetXJXZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.x, V3.z), V3.GetXJXZ(F1));
			}

			[Test]
			public static void GetXJY ()
			{
				Assert.AreEqual(new Vector3(V3.x, F1, V3.y), V3.GetXJY(F1));
			}

			[Test]
			public static void GetXJYL ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.y, F2), V3.GetXJYL(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V2.x, V3.y, V2.y), V3.GetXJYL(V2));
			}

			[Test]
			public static void GetXJYX ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.y, V3.x), V3.GetXJYX(F1));
			}

			[Test]
			public static void GetXJYY ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.y, V3.y), V3.GetXJYY(F1));
			}

			[Test]
			public static void GetXJYZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.y, V3.z), V3.GetXJYZ(F1));
			}

			[Test]
			public static void GetXJZ ()
			{
				Assert.AreEqual(new Vector3(V3.x, F1, V3.z), V3.GetXJZ(F1));
			}

			[Test]
			public static void GetXJZL ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.z, F2), V3.GetXJZL(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V2.x, V3.z, V2.y), V3.GetXJZL(V2));
			}

			[Test]
			public static void GetXJZX ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.z, V3.x), V3.GetXJZX(F1));
			}

			[Test]
			public static void GetXJZY ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.z, V3.y), V3.GetXJZY(F1));
			}

			[Test]
			public static void GetXJZZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, F1, V3.z, V3.z), V3.GetXJZZ(F1));
			}

			[Test]
			public static void GetXX ()
			{
				Assert.AreEqual(new Vector2(V3.x, V3.x), V3.GetXX());
			}

			[Test]
			public static void GetXXK ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.x, F1), V3.GetXXK(F1));
			}

			[Test]
			public static void GetXXKL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, F1, F2), V3.GetXXKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V3.x, V2.x, V2.y), V3.GetXXKL(V2));
			}

			[Test]
			public static void GetXXKX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, F1, V3.x), V3.GetXXKX(F1));
			}

			[Test]
			public static void GetXXKY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, F1, V3.y), V3.GetXXKY(F1));
			}

			[Test]
			public static void GetXXKZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, F1, V3.z), V3.GetXXKZ(F1));
			}

			[Test]
			public static void GetXXX ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.x, V3.x), V3.GetXXX());
			}

			[Test]
			public static void GetXXXL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.x, F1), V3.GetXXXL(F1));
			}

			[Test]
			public static void GetXXXX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.x, V3.x), V3.GetXXXX());
			}

			[Test]
			public static void GetXXXY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.x, V3.y), V3.GetXXXY());
			}

			[Test]
			public static void GetXXXZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.x, V3.z), V3.GetXXXZ());
			}

			[Test]
			public static void GetXXY ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.x, V3.y), V3.GetXXY());
			}

			[Test]
			public static void GetXXYL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.y, F1), V3.GetXXYL(F1));
			}

			[Test]
			public static void GetXXYX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.y, V3.x), V3.GetXXYX());
			}

			[Test]
			public static void GetXXYY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.y, V3.y), V3.GetXXYY());
			}

			[Test]
			public static void GetXXYZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.y, V3.z), V3.GetXXYZ());
			}

			[Test]
			public static void GetXXZ ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.x, V3.z), V3.GetXXZ());
			}

			[Test]
			public static void GetXXZL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.z, F1), V3.GetXXZL(F1));
			}

			[Test]
			public static void GetXXZX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.z, V3.x), V3.GetXXZX());
			}

			[Test]
			public static void GetXXZY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.z, V3.y), V3.GetXXZY());
			}

			[Test]
			public static void GetXXZZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.x, V3.z, V3.z), V3.GetXXZZ());
			}

			[Test]
			public static void GetXY ()
			{
				Assert.AreEqual(new Vector2(V3.x, V3.y), V3.GetXY());
			}

			[Test]
			public static void GetXYK ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.y, F1), V3.GetXYK(F1));
			}

			[Test]
			public static void GetXYKL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, F1, F2), V3.GetXYKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V3.y, V2.x, V2.y), V3.GetXYKL(V2));
			}

			[Test]
			public static void GetXYKX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, F1, V3.x), V3.GetXYKX(F1));
			}

			[Test]
			public static void GetXYKY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, F1, V3.y), V3.GetXYKY(F1));
			}

			[Test]
			public static void GetXYKZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, F1, V3.z), V3.GetXYKZ(F1));
			}

			[Test]
			public static void GetXYX ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.y, V3.x), V3.GetXYX());
			}

			[Test]
			public static void GetXYXL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.x, F1), V3.GetXYXL(F1));
			}

			[Test]
			public static void GetXYXX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.x, V3.x), V3.GetXYXX());
			}

			[Test]
			public static void GetXYXY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.x, V3.y), V3.GetXYXY());
			}

			[Test]
			public static void GetXYXZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.x, V3.z), V3.GetXYXZ());
			}

			[Test]
			public static void GetXYY ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.y, V3.y), V3.GetXYY());
			}

			[Test]
			public static void GetXYYL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.y, F1), V3.GetXYYL(F1));
			}

			[Test]
			public static void GetXYYX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.y, V3.x), V3.GetXYYX());
			}

			[Test]
			public static void GetXYYY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.y, V3.y), V3.GetXYYY());
			}

			[Test]
			public static void GetXYYZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.y, V3.z), V3.GetXYYZ());
			}

			[Test]
			public static void GetXYZ ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.y, V3.z), V3.GetXYZ());
			}

			[Test]
			public static void GetXYZL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, F1), V3.GetXYZL(F1));
			}

			[Test]
			public static void GetXYZX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V3.x), V3.GetXYZX());
			}

			[Test]
			public static void GetXYZY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V3.y), V3.GetXYZY());
			}

			[Test]
			public static void GetXYZZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.y, V3.z, V3.z), V3.GetXYZZ());
			}

			[Test]
			public static void GetXZ ()
			{
				Assert.AreEqual(new Vector2(V3.x, V3.z), V3.GetXZ());
			}

			[Test]
			public static void GetXZK ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.z, F1), V3.GetXZK(F1));
			}

			[Test]
			public static void GetXZKL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, F1, F2), V3.GetXZKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.x, V3.z, V2.x, V2.y), V3.GetXZKL(V2));
			}

			[Test]
			public static void GetXZKX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, F1, V3.x), V3.GetXZKX(F1));
			}

			[Test]
			public static void GetXZKY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, F1, V3.y), V3.GetXZKY(F1));
			}

			[Test]
			public static void GetXZKZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, F1, V3.z), V3.GetXZKZ(F1));
			}

			[Test]
			public static void GetXZX ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.z, V3.x), V3.GetXZX());
			}

			[Test]
			public static void GetXZXL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.x, F1), V3.GetXZXL(F1));
			}

			[Test]
			public static void GetXZXX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.x, V3.x), V3.GetXZXX());
			}

			[Test]
			public static void GetXZXY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.x, V3.y), V3.GetXZXY());
			}

			[Test]
			public static void GetXZXZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.x, V3.z), V3.GetXZXZ());
			}

			[Test]
			public static void GetXZY ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.z, V3.y), V3.GetXZY());
			}

			[Test]
			public static void GetXZYL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.y, F1), V3.GetXZYL(F1));
			}

			[Test]
			public static void GetXZYX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.y, V3.x), V3.GetXZYX());
			}

			[Test]
			public static void GetXZYY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.y, V3.y), V3.GetXZYY());
			}

			[Test]
			public static void GetXZYZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.y, V3.z), V3.GetXZYZ());
			}

			[Test]
			public static void GetXZZ ()
			{
				Assert.AreEqual(new Vector3(V3.x, V3.z, V3.z), V3.GetXZZ());
			}

			[Test]
			public static void GetXZZL ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.z, F1), V3.GetXZZL(F1));
			}

			[Test]
			public static void GetXZZX ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.z, V3.x), V3.GetXZZX());
			}

			[Test]
			public static void GetXZZY ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.z, V3.y), V3.GetXZZY());
			}

			[Test]
			public static void GetXZZZ ()
			{
				Assert.AreEqual(new Vector4(V3.x, V3.z, V3.z, V3.z), V3.GetXZZZ());
			}

			[Test]
			public static void GetYJKX ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, F2, V3.x), V3.GetYJKX(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V2.x, V2.y, V3.x), V3.GetYJKX(V2));
			}

			[Test]
			public static void GetYJKY ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, F2, V3.y), V3.GetYJKY(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V2.x, V2.y, V3.y), V3.GetYJKY(V2));
			}

			[Test]
			public static void GetYJKZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, F2, V3.z), V3.GetYJKZ(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V2.x, V2.y, V3.z), V3.GetYJKZ(V2));
			}

			[Test]
			public static void GetYJX ()
			{
				Assert.AreEqual(new Vector3(V3.y, F1, V3.x), V3.GetYJX(F1));
			}

			[Test]
			public static void GetYJXL ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.x, F2), V3.GetYJXL(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V2.x, V3.x, V2.y), V3.GetYJXL(V2));
			}

			[Test]
			public static void GetYJXX ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.x, V3.x), V3.GetYJXX(F1));
			}

			[Test]
			public static void GetYJXY ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.x, V3.y), V3.GetYJXY(F1));
			}

			[Test]
			public static void GetYJXZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.x, V3.z), V3.GetYJXZ(F1));
			}

			[Test]
			public static void GetYJY ()
			{
				Assert.AreEqual(new Vector3(V3.y, F1, V3.y), V3.GetYJY(F1));
			}

			[Test]
			public static void GetYJYL ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.y, F2), V3.GetYJYL(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V2.x, V3.y, V2.y), V3.GetYJYL(V2));
			}

			[Test]
			public static void GetYJYX ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.y, V3.x), V3.GetYJYX(F1));
			}

			[Test]
			public static void GetYJYY ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.y, V3.y), V3.GetYJYY(F1));
			}

			[Test]
			public static void GetYJYZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.y, V3.z), V3.GetYJYZ(F1));
			}

			[Test]
			public static void GetYJZ ()
			{
				Assert.AreEqual(new Vector3(V3.y, F1, V3.z), V3.GetYJZ(F1));
			}

			[Test]
			public static void GetYJZL ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.z, F2), V3.GetYJZL(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V2.x, V3.z, V2.y), V3.GetYJZL(V2));
			}

			[Test]
			public static void GetYJZX ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.z, V3.x), V3.GetYJZX(F1));
			}

			[Test]
			public static void GetYJZY ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.z, V3.y), V3.GetYJZY(F1));
			}

			[Test]
			public static void GetYJZZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, F1, V3.z, V3.z), V3.GetYJZZ(F1));
			}

			[Test]
			public static void GetYX ()
			{
				Assert.AreEqual(new Vector2(V3.y, V3.x), V3.GetYX());
			}

			[Test]
			public static void GetYXK ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.x, F1), V3.GetYXK(F1));
			}

			[Test]
			public static void GetYXKL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, F1, F2), V3.GetYXKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V3.x, V2.x, V2.y), V3.GetYXKL(V2));
			}

			[Test]
			public static void GetYXKX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, F1, V3.x), V3.GetYXKX(F1));
			}

			[Test]
			public static void GetYXKY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, F1, V3.y), V3.GetYXKY(F1));
			}

			[Test]
			public static void GetYXKZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, F1, V3.z), V3.GetYXKZ(F1));
			}

			[Test]
			public static void GetYXX ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.x, V3.x), V3.GetYXX());
			}

			[Test]
			public static void GetYXXL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.x, F1), V3.GetYXXL(F1));
			}

			[Test]
			public static void GetYXXX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.x, V3.x), V3.GetYXXX());
			}

			[Test]
			public static void GetYXXY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.x, V3.y), V3.GetYXXY());
			}

			[Test]
			public static void GetYXXZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.x, V3.z), V3.GetYXXZ());
			}

			[Test]
			public static void GetYXY ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.x, V3.y), V3.GetYXY());
			}

			[Test]
			public static void GetYXYL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.y, F1), V3.GetYXYL(F1));
			}

			[Test]
			public static void GetYXYX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.y, V3.x), V3.GetYXYX());
			}

			[Test]
			public static void GetYXYY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.y, V3.y), V3.GetYXYY());
			}

			[Test]
			public static void GetYXYZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.y, V3.z), V3.GetYXYZ());
			}

			[Test]
			public static void GetYXZ ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.x, V3.z), V3.GetYXZ());
			}

			[Test]
			public static void GetYXZL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.z, F1), V3.GetYXZL(F1));
			}

			[Test]
			public static void GetYXZX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.z, V3.x), V3.GetYXZX());
			}

			[Test]
			public static void GetYXZY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.z, V3.y), V3.GetYXZY());
			}

			[Test]
			public static void GetYXZZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.x, V3.z, V3.z), V3.GetYXZZ());
			}

			[Test]
			public static void GetYY ()
			{
				Assert.AreEqual(new Vector2(V3.y, V3.y), V3.GetYY());
			}

			[Test]
			public static void GetYYK ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.y, F1), V3.GetYYK(F1));
			}

			[Test]
			public static void GetYYKL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, F1, F2), V3.GetYYKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V3.y, V2.x, V2.y), V3.GetYYKL(V2));
			}

			[Test]
			public static void GetYYKX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, F1, V3.x), V3.GetYYKX(F1));
			}

			[Test]
			public static void GetYYKY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, F1, V3.y), V3.GetYYKY(F1));
			}

			[Test]
			public static void GetYYKZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, F1, V3.z), V3.GetYYKZ(F1));
			}

			[Test]
			public static void GetYYX ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.y, V3.x), V3.GetYYX());
			}

			[Test]
			public static void GetYYXL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.x, F1), V3.GetYYXL(F1));
			}

			[Test]
			public static void GetYYXX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.x, V3.x), V3.GetYYXX());
			}

			[Test]
			public static void GetYYXY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.x, V3.y), V3.GetYYXY());
			}

			[Test]
			public static void GetYYXZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.x, V3.z), V3.GetYYXZ());
			}

			[Test]
			public static void GetYYY ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.y, V3.y), V3.GetYYY());
			}

			[Test]
			public static void GetYYYL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.y, F1), V3.GetYYYL(F1));
			}

			[Test]
			public static void GetYYYX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.y, V3.x), V3.GetYYYX());
			}

			[Test]
			public static void GetYYYY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.y, V3.y), V3.GetYYYY());
			}

			[Test]
			public static void GetYYYZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.y, V3.z), V3.GetYYYZ());
			}

			[Test]
			public static void GetYYZ ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.y, V3.z), V3.GetYYZ());
			}

			[Test]
			public static void GetYYZL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.z, F1), V3.GetYYZL(F1));
			}

			[Test]
			public static void GetYYZX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.z, V3.x), V3.GetYYZX());
			}

			[Test]
			public static void GetYYZY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.z, V3.y), V3.GetYYZY());
			}

			[Test]
			public static void GetYYZZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.y, V3.z, V3.z), V3.GetYYZZ());
			}

			[Test]
			public static void GetYZ ()
			{
				Assert.AreEqual(new Vector2(V3.y, V3.z), V3.GetYZ());
			}

			[Test]
			public static void GetYZK ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.z, F1), V3.GetYZK(F1));
			}

			[Test]
			public static void GetYZKL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, F1, F2), V3.GetYZKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.y, V3.z, V2.x, V2.y), V3.GetYZKL(V2));
			}

			[Test]
			public static void GetYZKX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, F1, V3.x), V3.GetYZKX(F1));
			}

			[Test]
			public static void GetYZKY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, F1, V3.y), V3.GetYZKY(F1));
			}

			[Test]
			public static void GetYZKZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, F1, V3.z), V3.GetYZKZ(F1));
			}

			[Test]
			public static void GetYZX ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.z, V3.x), V3.GetYZX());
			}

			[Test]
			public static void GetYZXL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.x, F1), V3.GetYZXL(F1));
			}

			[Test]
			public static void GetYZXX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.x, V3.x), V3.GetYZXX());
			}

			[Test]
			public static void GetYZXY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.x, V3.y), V3.GetYZXY());
			}

			[Test]
			public static void GetYZXZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.x, V3.z), V3.GetYZXZ());
			}

			[Test]
			public static void GetYZY ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.z, V3.y), V3.GetYZY());
			}

			[Test]
			public static void GetYZYL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.y, F1), V3.GetYZYL(F1));
			}

			[Test]
			public static void GetYZYX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.y, V3.x), V3.GetYZYX());
			}

			[Test]
			public static void GetYZYY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.y, V3.y), V3.GetYZYY());
			}

			[Test]
			public static void GetYZYZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.y, V3.z), V3.GetYZYZ());
			}

			[Test]
			public static void GetYZZ ()
			{
				Assert.AreEqual(new Vector3(V3.y, V3.z, V3.z), V3.GetYZZ());
			}

			[Test]
			public static void GetYZZL ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.z, F1), V3.GetYZZL(F1));
			}

			[Test]
			public static void GetYZZX ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.z, V3.x), V3.GetYZZX());
			}

			[Test]
			public static void GetYZZY ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.z, V3.y), V3.GetYZZY());
			}

			[Test]
			public static void GetYZZZ ()
			{
				Assert.AreEqual(new Vector4(V3.y, V3.z, V3.z, V3.z), V3.GetYZZZ());
			}

			[Test]
			public static void GetZJKX ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, F2, V3.x), V3.GetZJKX(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V2.x, V2.y, V3.x), V3.GetZJKX(V2));
			}

			[Test]
			public static void GetZJKY ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, F2, V3.y), V3.GetZJKY(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V2.x, V2.y, V3.y), V3.GetZJKY(V2));
			}

			[Test]
			public static void GetZJKZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, F2, V3.z), V3.GetZJKZ(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V2.x, V2.y, V3.z), V3.GetZJKZ(V2));
			}

			[Test]
			public static void GetZJX ()
			{
				Assert.AreEqual(new Vector3(V3.z, F1, V3.x), V3.GetZJX(F1));
			}

			[Test]
			public static void GetZJXL ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.x, F2), V3.GetZJXL(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V2.x, V3.x, V2.y), V3.GetZJXL(V2));
			}

			[Test]
			public static void GetZJXX ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.x, V3.x), V3.GetZJXX(F1));
			}

			[Test]
			public static void GetZJXY ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.x, V3.y), V3.GetZJXY(F1));
			}

			[Test]
			public static void GetZJXZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.x, V3.z), V3.GetZJXZ(F1));
			}

			[Test]
			public static void GetZJY ()
			{
				Assert.AreEqual(new Vector3(V3.z, F1, V3.y), V3.GetZJY(F1));
			}

			[Test]
			public static void GetZJYL ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.y, F2), V3.GetZJYL(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V2.x, V3.y, V2.y), V3.GetZJYL(V2));
			}

			[Test]
			public static void GetZJYX ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.y, V3.x), V3.GetZJYX(F1));
			}

			[Test]
			public static void GetZJYY ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.y, V3.y), V3.GetZJYY(F1));
			}

			[Test]
			public static void GetZJYZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.y, V3.z), V3.GetZJYZ(F1));
			}

			[Test]
			public static void GetZJZ ()
			{
				Assert.AreEqual(new Vector3(V3.z, F1, V3.z), V3.GetZJZ(F1));
			}

			[Test]
			public static void GetZJZL ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.z, F2), V3.GetZJZL(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V2.x, V3.z, V2.y), V3.GetZJZL(V2));
			}

			[Test]
			public static void GetZJZX ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.z, V3.x), V3.GetZJZX(F1));
			}

			[Test]
			public static void GetZJZY ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.z, V3.y), V3.GetZJZY(F1));
			}

			[Test]
			public static void GetZJZZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, F1, V3.z, V3.z), V3.GetZJZZ(F1));
			}



			[Test]
			public static void GetZX ()
			{
				Assert.AreEqual(new Vector2(V3.z, V3.x), V3.GetZX());
			}

			[Test]
			public static void GetZXK ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.x, F1), V3.GetZXK(F1));
			}

			[Test]
			public static void GetZXKL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, F1, F2), V3.GetZXKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V3.x, V2.x, V2.y), V3.GetZXKL(V2));
			}

			[Test]
			public static void GetZXKX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, F1, V3.x), V3.GetZXKX(F1));
			}

			[Test]
			public static void GetZXKY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, F1, V3.y), V3.GetZXKY(F1));
			}

			[Test]
			public static void GetZXKZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, F1, V3.z), V3.GetZXKZ(F1));
			}

			[Test]
			public static void GetZXX ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.x, V3.x), V3.GetZXX());
			}

			[Test]
			public static void GetZXXL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.x, F1), V3.GetZXXL(F1));
			}

			[Test]
			public static void GetZXXX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.x, V3.x), V3.GetZXXX());
			}

			[Test]
			public static void GetZXXY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.x, V3.y), V3.GetZXXY());
			}

			[Test]
			public static void GetZXXZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.x, V3.z), V3.GetZXXZ());
			}

			[Test]
			public static void GetZXY ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.x, V3.y), V3.GetZXY());
			}

			[Test]
			public static void GetZXYL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.y, F1), V3.GetZXYL(F1));
			}

			[Test]
			public static void GetZXYX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.y, V3.x), V3.GetZXYX());
			}

			[Test]
			public static void GetZXYY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.y, V3.y), V3.GetZXYY());
			}

			[Test]
			public static void GetZXYZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.y, V3.z), V3.GetZXYZ());
			}

			[Test]
			public static void GetZXZ ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.x, V3.z), V3.GetZXZ());
			}

			[Test]
			public static void GetZXZL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.z, F1), V3.GetZXZL(F1));
			}

			[Test]
			public static void GetZXZX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.z, V3.x), V3.GetZXZX());
			}

			[Test]
			public static void GetZXZY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.z, V3.y), V3.GetZXZY());
			}

			[Test]
			public static void GetZXZZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.x, V3.z, V3.z), V3.GetZXZZ());
			}

			[Test]
			public static void GetZY ()
			{
				Assert.AreEqual(new Vector2(V3.z, V3.y), V3.GetZY());
			}

			[Test]
			public static void GetZYK ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.y, F1), V3.GetZYK(F1));
			}

			[Test]
			public static void GetZYKL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, F1, F2), V3.GetZYKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V3.y, V2.x, V2.y), V3.GetZYKL(V2));
			}

			[Test]
			public static void GetZYKX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, F1, V3.x), V3.GetZYKX(F1));
			}

			[Test]
			public static void GetZYKY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, F1, V3.y), V3.GetZYKY(F1));
			}

			[Test]
			public static void GetZYKZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, F1, V3.z), V3.GetZYKZ(F1));
			}

			[Test]
			public static void GetZYX ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.y, V3.x), V3.GetZYX());
			}

			[Test]
			public static void GetZYXL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.x, F1), V3.GetZYXL(F1));
			}

			[Test]
			public static void GetZYXX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.x, V3.x), V3.GetZYXX());
			}

			[Test]
			public static void GetZYXY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.x, V3.y), V3.GetZYXY());
			}

			[Test]
			public static void GetZYXZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.x, V3.z), V3.GetZYXZ());
			}

			[Test]
			public static void GetZYY ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.y, V3.y), V3.GetZYY());
			}

			[Test]
			public static void GetZYYL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.y, F1), V3.GetZYYL(F1));
			}

			[Test]
			public static void GetZYYX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.y, V3.x), V3.GetZYYX());
			}

			[Test]
			public static void GetZYYY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.y, V3.y), V3.GetZYYY());
			}

			[Test]
			public static void GetZYYZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.y, V3.z), V3.GetZYYZ());
			}

			[Test]
			public static void GetZYZ ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.y, V3.z), V3.GetZYZ());
			}

			[Test]
			public static void GetZYZL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.z, F1), V3.GetZYZL(F1));
			}

			[Test]
			public static void GetZYZX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.z, V3.x), V3.GetZYZX());
			}

			[Test]
			public static void GetZYZY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.z, V3.y), V3.GetZYZY());
			}

			[Test]
			public static void GetZYZZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.y, V3.z, V3.z), V3.GetZYZZ());
			}

			[Test]
			public static void GetZZ ()
			{
				Assert.AreEqual(new Vector2(V3.z, V3.z), V3.GetZZ());
			}

			[Test]
			public static void GetZZK ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.z, F1), V3.GetZZK(F1));
			}

			[Test]
			public static void GetZZKL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, F1, F2), V3.GetZZKL(F1, F2));
				Assert.AreEqual(new Vector4(V3.z, V3.z, V2.x, V2.y), V3.GetZZKL(V2));
			}

			[Test]
			public static void GetZZKX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, F1, V3.x), V3.GetZZKX(F1));
			}

			[Test]
			public static void GetZZKY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, F1, V3.y), V3.GetZZKY(F1));
			}

			[Test]
			public static void GetZZKZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, F1, V3.z), V3.GetZZKZ(F1));
			}

			[Test]
			public static void GetZZX ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.z, V3.x), V3.GetZZX());
			}

			[Test]
			public static void GetZZXL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.x, F1), V3.GetZZXL(F1));
			}

			[Test]
			public static void GetZZXX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.x, V3.x), V3.GetZZXX());
			}

			[Test]
			public static void GetZZXY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.x, V3.y), V3.GetZZXY());
			}

			[Test]
			public static void GetZZXZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.x, V3.z), V3.GetZZXZ());
			}

			[Test]
			public static void GetZZY ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.z, V3.y), V3.GetZZY());
			}

			[Test]
			public static void GetZZYL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.y, F1), V3.GetZZYL(F1));
			}

			[Test]
			public static void GetZZYX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.y, V3.x), V3.GetZZYX());
			}

			[Test]
			public static void GetZZYY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.y, V3.y), V3.GetZZYY());
			}

			[Test]
			public static void GetZZYZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.y, V3.z), V3.GetZZYZ());
			}

			[Test]
			public static void GetZZZ ()
			{
				Assert.AreEqual(new Vector3(V3.z, V3.z, V3.z), V3.GetZZZ());
			}

			[Test]
			public static void GetZZZL ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.z, F1), V3.GetZZZL(F1));
			}

			[Test]
			public static void GetZZZX ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.z, V3.x), V3.GetZZZX());
			}

			[Test]
			public static void GetZZZY ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.z, V3.y), V3.GetZZZY());
			}

			[Test]
			public static void GetZZZZ ()
			{
				Assert.AreEqual(new Vector4(V3.z, V3.z, V3.z, V3.z), V3.GetZZZZ());
			}

		#endregion
	}
}