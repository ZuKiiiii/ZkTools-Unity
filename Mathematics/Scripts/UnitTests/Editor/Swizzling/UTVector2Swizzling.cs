using NUnit.Framework;
using UnityEngine;
using ZkTools.Mathematics.Swizzling;

namespace ZkTools.Mathematics.UnitTests.Editor.Swizzling
{
	internal class UTVector2Swizzling
	{
		#region //,============================[Static Variables]==============================

			private static readonly float F1 = -1.0f;
			private static readonly float F2 = -2.0f;
			private static readonly Vector2 V2 = new Vector2(1.0f, 2.0f);

		#endregion

		#region //,============================[Methods]==============================

			[Test]
			public static void GetIJX ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V2.x), V2.GetIJX(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V2.x), V2.GetIJX(V2));
			}

			[Test]
			public static void GetIJXX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V2.x, V2.x), V2.GetIJXX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.x, V2.x), V2.GetIJXX(V2));
			}

			[Test]
			public static void GetIJXY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V2.x, V2.y), V2.GetIJXY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.x, V2.y), V2.GetIJXY(V2));
			}

			[Test]
			public static void GetIJY ()
			{
				Assert.AreEqual(new Vector3(F1, F2, V2.y), V2.GetIJY(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y, V2.y), V2.GetIJY(V2));
			}

			[Test]
			public static void GetIJYX ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V2.y, V2.x), V2.GetIJYX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.y, V2.x), V2.GetIJYX(V2));
			}

			[Test]
			public static void GetIJYY ()
			{
				Assert.AreEqual(new Vector4(F1, F2, V2.y, V2.y), V2.GetIJYY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.y, V2.y), V2.GetIJYY(V2));
			}

			[Test]
			public static void GetIX ()
			{
				Assert.AreEqual(new Vector2(F1, V2.x), V2.GetIX(F1));
			}

			[Test]
			public static void GetIXK ()
			{
				Assert.AreEqual(new Vector3(F1, V2.x, F2), V2.GetIXK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.x,V2.y), V2.GetIXK(V2));
			}

			[Test]
			public static void GetIXKX ()
			{
				Assert.AreEqual(new Vector4(F1, V2.x, F2, V2.x), V2.GetIXKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, V2.x), V2.GetIXKX(V2));
			}

			[Test]
			public static void GetIXKY ()
			{
				Assert.AreEqual(new Vector4(F1, V2.x, F2, V2.y), V2.GetIXKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, V2.y), V2.GetIXKY(V2));
			}

			[Test]
			public static void GetIXX ()
			{
				Assert.AreEqual(new Vector3(F1, V2.x, V2.x), V2.GetIXX(F1));
			}

			[Test]
			public static void GetIXXL ()
			{
				Assert.AreEqual(new Vector4(F1, V2.x, V2.x, F2), V2.GetIXXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.x, V2.y), V2.GetIXXL(V2));
			}

			[Test]
			public static void GetIXXX ()
			{
				Assert.AreEqual(new Vector4(F1, V2.x, V2.x, V2.x), V2.GetIXXX(F1));
			}

			[Test]
			public static void GetIXXY ()
			{
				Assert.AreEqual(new Vector4(F1, V2.x, V2.x, V2.y), V2.GetIXXY(F1));
			}

			[Test]
			public static void GetIXY ()
			{
				Assert.AreEqual(new Vector3(F1, V2.x, V2.y), V2.GetIXY(F1));
			}

			[Test]
			public static void GetIXYL ()
			{
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, F2), V2.GetIXYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, V2.y), V2.GetIXYL(V2));
			}

			[Test]
			public static void GetIXYX ()
			{
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V2.x), V2.GetIXYX(F1));
			}

			[Test]
			public static void GetIXYY ()
			{
				Assert.AreEqual(new Vector4(F1, V2.x, V2.y, V2.y), V2.GetIXYY(F1));
			}

			[Test]
			public static void GetIY ()
			{
				Assert.AreEqual(new Vector2(F1, V2.y), V2.GetIY(F1));
			}

			[Test]
			public static void GetIYK ()
			{
				Assert.AreEqual(new Vector3(F1, V2.y, F2), V2.GetIYK(F1, F2));
				Assert.AreEqual(new Vector3(V2.x, V2.y,V2.y), V2.GetIYK(V2));
			}

			[Test]
			public static void GetIYKX ()
			{
				Assert.AreEqual(new Vector4(F1, V2.y, F2, V2.x), V2.GetIYKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.y, V2.x), V2.GetIYKX(V2));
			}

			[Test]
			public static void GetIYKY ()
			{
				Assert.AreEqual(new Vector4(F1, V2.y, F2, V2.y), V2.GetIYKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.y, V2.y), V2.GetIYKY(V2));
			}

			[Test]
			public static void GetIYX ()
			{
				Assert.AreEqual(new Vector3(F1, V2.y, V2.x), V2.GetIYX(F1));
			}

			[Test]
			public static void GetIYXL ()
			{
				Assert.AreEqual(new Vector4(F1, V2.y, V2.x, F2), V2.GetIYXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.x, V2.y), V2.GetIYXL(V2));
			}

			[Test]
			public static void GetIYXX ()
			{
				Assert.AreEqual(new Vector4(F1, V2.y, V2.x, V2.x), V2.GetIYXX(F1));
			}

			[Test]
			public static void GetIYXY ()
			{
				Assert.AreEqual(new Vector4(F1, V2.y, V2.x, V2.y), V2.GetIYXY(F1));
			}

			[Test]
			public static void GetIYY ()
			{
				Assert.AreEqual(new Vector3(F1, V2.y, V2.y), V2.GetIYY(F1));
			}

			[Test]
			public static void GetIYYL ()
			{
				Assert.AreEqual(new Vector4(F1, V2.y, V2.y, F2), V2.GetIYYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.y, V2.y), V2.GetIYYL(V2));
			}

			[Test]
			public static void GetIYYX ()
			{
				Assert.AreEqual(new Vector4(F1, V2.y, V2.y, V2.x), V2.GetIYYX(F1));
			}

			[Test]
			public static void GetIYYY ()
			{
				Assert.AreEqual(new Vector4(F1, V2.y, V2.y, V2.y), V2.GetIYYY(F1));
			}

			[Test]
			public static void GetXJKX ()
			{
				Assert.AreEqual(new Vector4(V2.x, F1, F2, V2.x), V2.GetXJKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, V2.x), V2.GetXJKX(V2));
			}

			[Test]
			public static void GetXJKY ()
			{
				Assert.AreEqual(new Vector4(V2.x, F1, F2, V2.y), V2.GetXJKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, V2.y), V2.GetXJKY(V2));
			}

			[Test]
			public static void GetXJX ()
			{
				Assert.AreEqual(new Vector3(V2.x, F1, V2.x), V2.GetXJX(F1));
			}

			[Test]
			public static void GetXJXL ()
			{
				Assert.AreEqual(new Vector4(V2.x, F1, V2.x, F2), V2.GetXJXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.x, V2.y), V2.GetXJXL(V2));
			}

			[Test]
			public static void GetXJXX ()
			{
				Assert.AreEqual(new Vector4(V2.x, F1, V2.x, V2.x), V2.GetXJXX(F1));
			}

			[Test]
			public static void GetXJXY ()
			{
				Assert.AreEqual(new Vector4(V2.x, F1, V2.x, V2.y), V2.GetXJXY(F1));
			}

			[Test]
			public static void GetXJY ()
			{
				Assert.AreEqual(new Vector3(V2.x, F1, V2.y), V2.GetXJY(F1));
			}

			[Test]
			public static void GetXJYL ()
			{
				Assert.AreEqual(new Vector4(V2.x, F1, V2.y, F2), V2.GetXJYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, V2.y), V2.GetXJYL(V2));
			}

			[Test]
			public static void GetXJYX ()
			{
				Assert.AreEqual(new Vector4(V2.x, F1, V2.y, V2.x), V2.GetXJYX(F1));
			}

			[Test]
			public static void GetXJYY ()
			{
				Assert.AreEqual(new Vector4(V2.x, F1, V2.y, V2.y), V2.GetXJYY(F1));
			}

			[Test]
			public static void GetXX ()
			{
				Assert.AreEqual(new Vector2(V2.x, V2.x), V2.GetXX());
			}

			[Test]
			public static void GetXXK ()
			{
				Assert.AreEqual(new Vector3(V2.x, V2.x, F1), V2.GetXXK(F1));
			}

			[Test]
			public static void GetXXKL ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, F1, F2), V2.GetXXKL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.x, V2.y), V2.GetXXKL(V2));
			}

			[Test]
			public static void GetXXKX ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, F1, V2.x), V2.GetXXKX(F1));
			}

			[Test]
			public static void GetXXKY ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, F1, V2.y), V2.GetXXKY(F1));
			}

			[Test]
			public static void GetXXX ()
			{
				Assert.AreEqual(new Vector3(V2.x, V2.x, V2.x), V2.GetXXX());
			}

			[Test]
			public static void GetXXXL ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.x, F1), V2.GetXXXL(F1));
			}

			[Test]
			public static void GetXXXX ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.x, V2.x), V2.GetXXXX());
			}

			[Test]
			public static void GetXXXY ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.x, V2.y), V2.GetXXXY());
			}

			[Test]
			public static void GetXXY ()
			{
				Assert.AreEqual(new Vector3(V2.x, V2.x, V2.y), V2.GetXXY());
			}

			[Test]
			public static void GetXXYL ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, F1), V2.GetXXYL(F1));
			}

			[Test]
			public static void GetXXYX ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, V2.x), V2.GetXXYX());
			}

			[Test]
			public static void GetXXYY ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.x, V2.y, V2.y), V2.GetXXYY());
			}

			[Test]
			public static void GetXY ()
			{
				Assert.AreEqual(new Vector2(V2.x, V2.y), V2.GetXY());
			}

			[Test]
			public static void GetXYK ()
			{
				Assert.AreEqual(new Vector3(V2.x, V2.y, F1), V2.GetXYK(F1));
			}

			[Test]
			public static void GetXYKL ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, F2), V2.GetXYKL(F1, F2));
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.x, V2.y), V2.GetXYKL(V2));
			}

			[Test]
			public static void GetXYKX ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V2.x), V2.GetXYKX(F1));
			}

			[Test]
			public static void GetXYKY ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, F1, V2.y), V2.GetXYKY(F1));
			}

			[Test]
			public static void GetXYX ()
			{
				Assert.AreEqual(new Vector3(V2.x, V2.y, V2.x), V2.GetXYX());
			}

			[Test]
			public static void GetXYXL ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.x, F1), V2.GetXYXL(F1));
			}

			[Test]
			public static void GetXYXX ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.x, V2.x), V2.GetXYXX());
			}

			[Test]
			public static void GetXYXY ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.x, V2.y), V2.GetXYXY());
			}

			[Test]
			public static void GetXYY ()
			{
				Assert.AreEqual(new Vector3(V2.x, V2.y, V2.y), V2.GetXYY());
			}

			[Test]
			public static void GetXYYL ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.y, F1), V2.GetXYYL(F1));
			}

			[Test]
			public static void GetXYYX ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.y, V2.x), V2.GetXYYX());
			}

			[Test]
			public static void GetXYYY ()
			{
				Assert.AreEqual(new Vector4(V2.x, V2.y, V2.y, V2.y), V2.GetXYYY());
			}

			[Test]
			public static void GetYJKX ()
			{
				Assert.AreEqual(new Vector4(V2.y, F1, F2, V2.x), V2.GetYJKX(F1, F2));
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.y, V2.x), V2.GetYJKX(V2));
			}

			[Test]
			public static void GetYJKY ()
			{
				Assert.AreEqual(new Vector4(V2.y, F1, F2, V2.y), V2.GetYJKY(F1, F2));
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.y, V2.y), V2.GetYJKY(V2));
			}

			[Test]
			public static void GetYJX ()
			{
				Assert.AreEqual(new Vector3(V2.y, F1, V2.x), V2.GetYJX(F1));
			}

			[Test]
			public static void GetYJXL ()
			{
				Assert.AreEqual(new Vector4(V2.y, F1, V2.x, F2), V2.GetYJXL(F1, F2));
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.x, V2.y), V2.GetYJXL(V2));
			}

			[Test]
			public static void GetYJXX ()
			{
				Assert.AreEqual(new Vector4(V2.y, F1, V2.x, V2.x), V2.GetYJXX(F1));
			}

			[Test]
			public static void GetYJXY ()
			{
				Assert.AreEqual(new Vector4(V2.y, F1, V2.x, V2.y), V2.GetYJXY(F1));
			}

			[Test]
			public static void GetYJY ()
			{
				Assert.AreEqual(new Vector3(V2.y, F1, V2.y), V2.GetYJY(F1));
			}

			[Test]
			public static void GetYJYL ()
			{
				Assert.AreEqual(new Vector4(V2.y, F1, V2.y, F2), V2.GetYJYL(F1, F2));
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.y, V2.y), V2.GetYJYL(V2));
			}

			[Test]
			public static void GetYJYX ()
			{
				Assert.AreEqual(new Vector4(V2.y, F1, V2.y, V2.x), V2.GetYJYX(F1));
			}

			[Test]
			public static void GetYJYY ()
			{
				Assert.AreEqual(new Vector4(V2.y, F1, V2.y, V2.y), V2.GetYJYY(F1));
			}

			[Test]
			public static void GetYX ()
			{
				Assert.AreEqual(new Vector2(V2.y, V2.x), V2.GetYX());
			}

			[Test]
			public static void GetYXK ()
			{
				Assert.AreEqual(new Vector3(V2.y, V2.x, F1), V2.GetYXK(F1));
			}

			[Test]
			public static void GetYXKL ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, F1, F2), V2.GetYXKL(F1, F2));
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.x, V2.y), V2.GetYXKL(V2));
			}

			[Test]
			public static void GetYXKX ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, F1, V2.x), V2.GetYXKX(F1));
			}

			[Test]
			public static void GetYXKY ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, F1, V2.y), V2.GetYXKY(F1));
			}

			[Test]
			public static void GetYXX ()
			{
				Assert.AreEqual(new Vector3(V2.y, V2.x, V2.x), V2.GetYXX());
			}

			[Test]
			public static void GetYXXL ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.x, F1), V2.GetYXXL(F1));
			}

			[Test]
			public static void GetYXXX ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.x, V2.x), V2.GetYXXX());
			}

			[Test]
			public static void GetYXXY ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.x, V2.y), V2.GetYXXY());
			}

			[Test]
			public static void GetYXY ()
			{
				Assert.AreEqual(new Vector3(V2.y, V2.x, V2.y), V2.GetYXY());
			}

			[Test]
			public static void GetYXYL ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.y, F1), V2.GetYXYL(F1));
			}

			[Test]
			public static void GetYXYX ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.y, V2.x), V2.GetYXYX());
			}

			[Test]
			public static void GetYXYY ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.x, V2.y, V2.y), V2.GetYXYY());
			}

			[Test]
			public static void GetYY ()
			{
				Assert.AreEqual(new Vector2(V2.y, V2.y), V2.GetYY());
			}

			[Test]
			public static void GetYYK ()
			{
				Assert.AreEqual(new Vector3(V2.y, V2.y, F1), V2.GetYYK(F1));
			}

			[Test]
			public static void GetYYKL ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, F1, F2), V2.GetYYKL(F1, F2));
				Assert.AreEqual(new Vector4(V2.y, V2.y, V2.x, V2.y), V2.GetYYKL(V2));
			}

			[Test]
			public static void GetYYKX ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, F1, V2.x), V2.GetYYKX(F1));
			}

			[Test]
			public static void GetYYKY ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, F1, V2.y), V2.GetYYKY(F1));
			}

			[Test]
			public static void GetYYX ()
			{
				Assert.AreEqual(new Vector3(V2.y, V2.y, V2.x), V2.GetYYX());
			}

			[Test]
			public static void GetYYXL ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, V2.x, F1), V2.GetYYXL(F1));
			}

			[Test]
			public static void GetYYXX ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, V2.x, V2.x), V2.GetYYXX());
			}

			[Test]
			public static void GetYYXY ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, V2.x, V2.y), V2.GetYYXY());
			}

			[Test]
			public static void GetYYY ()
			{
				Assert.AreEqual(new Vector3(V2.y, V2.y, V2.y), V2.GetYYY());
			}

			[Test]
			public static void GetYYYL ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, V2.y, F1), V2.GetYYYL(F1));
			}

			[Test]
			public static void GetYYYX ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, V2.y, V2.x), V2.GetYYYX());
			}

			[Test]
			public static void GetYYYY ()
			{
				Assert.AreEqual(new Vector4(V2.y, V2.y, V2.y, V2.y), V2.GetYYYY());
			}

		#endregion
	}
}