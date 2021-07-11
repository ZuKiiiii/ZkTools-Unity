using NUnit.Framework;
using UnityEditor.VersionControl;
using UnityEngine;

namespace ZkTools.Mathematics.UnitTests.Editor
{
	internal class UTMathInt
	{
		#region ==============================[Methods]==============================

			[Test]
			public void Abs ()
			{
				Assert.AreEqual(5, MathInt.Abs(5));
				Assert.AreEqual(5, MathInt.Abs(-5));
				Assert.AreEqual(0, MathInt.Abs(-0));
				Assert.AreEqual(0, MathInt.Abs(0));
				Assert.AreEqual(int.MaxValue, MathInt.Abs(int.MaxValue));
			}

			[Test]
			public void Add ()
			{
				Assert.AreEqual(6 + 5, MathInt.Add(6, 5));
				Assert.AreEqual(2 + 5, MathInt.Add(2, 5));
				Assert.AreEqual(6 + 2, MathInt.Add(6, 2));
				Assert.AreEqual(2 + 2, MathInt.Add(2, 2));

				int a = 6;
				int b = 2;
				int c = 6;
				int d = 2;
				Assert.AreEqual(6 + 5, MathInt.Add(ref a, 5));
				Assert.AreEqual(2 + 5, MathInt.Add(ref b, 5));
				Assert.AreEqual(6 + 2, MathInt.Add(ref c, 2));
				Assert.AreEqual(2 + 2, MathInt.Add(ref d, 2));
			}

			[Test]
			public void Clamp ()
			{
				Assert.AreEqual(0, MathInt.Clamp(-5, 0, 10));
				Assert.AreEqual(0, MathInt.Clamp(0, 0, 10));
				Assert.AreEqual(5, MathInt.Clamp(5, 0, 10));
				Assert.AreEqual(10, MathInt.Clamp(10, 0, 10));
				Assert.AreEqual(10, MathInt.Clamp(15, 0, 10));
			}

			[Test]
			public void ClosestPowerOfTwo ()
			{

				Assert.AreEqual(1, MathInt.ClosestPowerOfTwo(1));
				Assert.AreEqual(4, MathInt.ClosestPowerOfTwo(3));
				Assert.AreEqual(4, MathInt.ClosestPowerOfTwo(4));
				Assert.AreEqual(4, MathInt.ClosestPowerOfTwo(5));
				Assert.AreEqual(8, MathInt.ClosestPowerOfTwo(8));
				Assert.AreEqual(16, MathInt.ClosestPowerOfTwo(13));
			}

			[Test]
			public void CopySign ()
			{
				Assert.AreEqual(-5, MathInt.CopySign(5, -10));
				Assert.AreEqual(-5, MathInt.CopySign(-5, -10));
				Assert.AreEqual(5, MathInt.CopySign(5, 10));
				Assert.AreEqual(5, MathInt.CopySign(-5, 10));
			}

			[Test]
			public void Cube ()
			{
				Assert.AreEqual(125, MathInt.Cube(5));
				Assert.AreEqual(-125, MathInt.Cube(-5));
				Assert.AreEqual(0, MathInt.Cube(0));
				Assert.AreEqual(1, MathInt.Cube(1));
				Assert.AreEqual(-1, MathInt.Cube(-1));
				Assert.AreEqual(8, MathInt.Cube(2));
				Assert.AreEqual(-8, MathInt.Cube(-2));
			}

			[Test]
			public void Distance ()
			{
				Assert.AreEqual(5, MathInt.Distance(10, 5));
				Assert.AreEqual(5, MathInt.Distance(5, 10));

				Assert.AreEqual(5, MathInt.Distance(-10, -5));
				Assert.AreEqual(5, MathInt.Distance(-5, -10));

				Assert.AreEqual(15, MathInt.Distance(-10, 5));
				Assert.AreEqual(15, MathInt.Distance(5, -10));

				Assert.AreEqual(15, MathInt.Distance(10, -5));
				Assert.AreEqual(15, MathInt.Distance(-5, 10));
			}

			[Test]
			public void DistanceSqr ()
			{
				Assert.AreEqual(25, MathInt.DistanceSqr(10, 5));
				Assert.AreEqual(25, MathInt.DistanceSqr(5, 10));

				Assert.AreEqual(25, MathInt.DistanceSqr(-10, -5));
				Assert.AreEqual(25, MathInt.DistanceSqr(-5, -10));

				Assert.AreEqual(225, MathInt.DistanceSqr(-10, 5));
				Assert.AreEqual(225, MathInt.DistanceSqr(5, -10));

				Assert.AreEqual(225, MathInt.DistanceSqr(10, -5));
				Assert.AreEqual(225, MathInt.DistanceSqr(-5, 10));
			}

			[Test]
			public void Div ()
			{
				Assert.AreEqual(6 / 5, MathInt.Div(6, 5));
				Assert.AreEqual(2 / 5, MathInt.Div(2, 5));
				Assert.AreEqual(6 / 2, MathInt.Div(6, 2));
				Assert.AreEqual(2 / 2, MathInt.Div(2, 2));

				int a = 6;
				int b = 2;
				int c = 6;
				int d = 2;
				Assert.AreEqual(6 / 5, MathInt.Div(ref a, 5));
				Assert.AreEqual(2 / 5, MathInt.Div(ref b, 5));
				Assert.AreEqual(6 / 2, MathInt.Div(ref c, 2));
				Assert.AreEqual(2 / 2, MathInt.Div(ref d, 2));
			}

			[Test]
			public void DivRem ()
			{
				// Assert 01
				DivRemResult r1Result = MathInt.DivRem(5, 2);
				DivRemResult r1Expected = new DivRemResult(2,1);
				Assert.AreEqual(r1Expected.result, r1Result.result);
				Assert.AreEqual(r1Expected.remainder, r1Result.remainder);

				// Assert 02
				DivRemResult r2Result = MathInt.DivRem(14, 4);
				DivRemResult r2Expected = new DivRemResult(3,2);
				Assert.AreEqual(r2Expected.result, r2Result.result);
				Assert.AreEqual(r2Expected.remainder, r2Result.remainder);

				// Assert 02
				DivRemResult r3Result = MathInt.DivRem(25, 4);
				DivRemResult r3Expected = new DivRemResult(6,1);
				Assert.AreEqual(r3Expected.result, r3Result.result);
				Assert.AreEqual(r3Expected.remainder, r3Result.remainder);
			}

			[Test]
			public void DivSafe ()
			{
				Assert.AreEqual(5 / 2, MathInt.DivSafe(5, 2));
				Assert.AreEqual(0, MathInt.DivSafe(5, 0));
				Assert.AreEqual(2, MathInt.DivSafe(5, 0, 2));
				Assert.AreEqual(-5 / 2, MathInt.DivSafe(-5, 2));
				Assert.AreEqual(5 / -2, MathInt.DivSafe(5, -2));
			}

			[Test]
			public void GreatestCommonDivisor ()
			{
				Assert.AreEqual(4, MathInt.GreatestCommonDivisor(8,12));
				Assert.AreEqual(4, MathInt.GreatestCommonDivisor(12,8));
				Assert.AreEqual(12, MathInt.GreatestCommonDivisor(60,36));
				Assert.AreEqual(12, MathInt.GreatestCommonDivisor(36, 60));
				Assert.AreEqual(2, MathInt.GreatestCommonDivisor(85214852, 352542));
			}

			public void InverseLerp ()
			{
			}

			public void InverseLerpClamped ()
			{
			}

			[Test]
			public void IsGreater ()
			{
				Assert.AreEqual(1 > 2, MathInt.IsGreater(1, 2));
				Assert.AreEqual(1 > 1, MathInt.IsGreater(1, 1));
				Assert.AreEqual(2 > 1, MathInt.IsGreater(2, 1));
			}

			[Test]
			public void IsGreaterEqual ()
			{
				Assert.AreEqual(1 >= 2, MathInt.IsGreaterEqual(1, 2));
				Assert.AreEqual(1 >= 1, MathInt.IsGreaterEqual(1, 1));
				Assert.AreEqual(2 >= 1, MathInt.IsGreaterEqual(2, 1));
			}

			[Test]
			public void IsLess ()
			{
				Assert.AreEqual(1 < 2, MathInt.IsLess(1, 2));
				Assert.AreEqual(1 < 1, MathInt.IsLess(1, 1));
				Assert.AreEqual(2 < 1, MathInt.IsLess(2, 1));
			}

			[Test]
			public void IsLessEqual ()
			{
				Assert.AreEqual(1 <= 2, MathInt.IsLessEqual(1, 2));
				Assert.AreEqual(1 <= 1, MathInt.IsLessEqual(1, 1));
				Assert.AreEqual(2 <= 1, MathInt.IsLessEqual(2, 1));
			}

			[Test]
			public void IsNearlyEqual ()
			{
				Assert.AreEqual(true, MathInt.IsNearlyEqual(5, 5));
				Assert.AreEqual(true, MathInt.IsNearlyEqual(5, 5, 0));
				Assert.AreEqual(true, MathInt.IsNearlyEqual(5, 5, 3));
				Assert.AreEqual(false, MathInt.IsNearlyEqual(5, 5, -1));

				Assert.AreEqual(false, MathInt.IsNearlyEqual(7, 5));
				Assert.AreEqual(false, MathInt.IsNearlyEqual(7, 5, 0));
				Assert.AreEqual(false, MathInt.IsNearlyEqual(7, 5, 1));
				Assert.AreEqual(true, MathInt.IsNearlyEqual(7, 5, 2));
				Assert.AreEqual(false, MathInt.IsNearlyEqual(5, 5, -1));
				Assert.AreEqual(false, MathInt.IsNearlyEqual(5, 5, -2));

			}

[Test]
			public void IsNearlyGreater ()
			{
				Assert.AreEqual(false, MathInt.IsNearlyGreater(1, 2));
				Assert.AreEqual(false, MathInt.IsNearlyGreater(1, 2, 0));
				Assert.AreEqual(false, MathInt.IsNearlyGreater(1, 2, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreater(1, 2, 2));
				Assert.AreEqual(false, MathInt.IsNearlyGreater(1, 1));
				Assert.AreEqual(false, MathInt.IsNearlyGreater(1, 1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyGreater(1, 1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreater(1, 1, 2));
				Assert.AreEqual(true, MathInt.IsNearlyGreater(2, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreater(2, 1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyGreater(2, 1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreater(2, 1, 2));
			}

			[Test]
			public void IsNearlyGreaterEqual ()
			{
				Assert.AreEqual(false, MathInt.IsNearlyGreaterEqual(1, 2));
				Assert.AreEqual(false, MathInt.IsNearlyGreaterEqual(1, 2, 0));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(1, 2, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(1, 2, 2));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(1, 1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(1, 1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(1, 1, 2));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(2, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(2, 1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(2, 1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyGreaterEqual(2, 1, 2));
			}

			[Test]
			public void IsNearlyLess ()
			{
				Assert.AreEqual(true, MathInt.IsNearlyLess(1, 2));
				Assert.AreEqual(true, MathInt.IsNearlyLess(1, 2, 0));
				Assert.AreEqual(true, MathInt.IsNearlyLess(1, 2, 1));
				Assert.AreEqual(true, MathInt.IsNearlyLess(1, 2, 2));
				Assert.AreEqual(false, MathInt.IsNearlyLess(1, 1));
				Assert.AreEqual(false, MathInt.IsNearlyLess(1, 1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyLess(1, 1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyLess(1, 1, 2));
				Assert.AreEqual(false, MathInt.IsNearlyLess(2, 1));
				Assert.AreEqual(false, MathInt.IsNearlyLess(2, 1, 0));
				Assert.AreEqual(false, MathInt.IsNearlyLess(2, 1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyLess(2, 1, 2));
			}

			[Test]
			public void IsNearlyLessEqual ()
			{
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(1, 2));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(1, 2, 0));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(1, 2, 1));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(1, 2, 2));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(1, 1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(1, 1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(1, 1, 2));
				Assert.AreEqual(false, MathInt.IsNearlyLessEqual(2, 1));
				Assert.AreEqual(false, MathInt.IsNearlyLessEqual(2, 1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(2, 1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyLessEqual(2, 1, 2));
			}

			[Test]
			public void IsNearlyZero ()
			{
				Assert.AreEqual(false, MathInt.IsNearlyZero(1));
				Assert.AreEqual(false, MathInt.IsNearlyZero(1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyZero(1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyZero(1, 2));
				Assert.AreEqual(false, MathInt.IsNearlyZero(1, -1));
				Assert.AreEqual(false, MathInt.IsNearlyZero(1, -2));


				Assert.AreEqual(true, MathInt.IsNearlyZero(0));
				Assert.AreEqual(true, MathInt.IsNearlyZero(0, 0));
				Assert.AreEqual(true, MathInt.IsNearlyZero(0, 1));
				Assert.AreEqual(false, MathInt.IsNearlyZero(0, -1));

				Assert.AreEqual(false, MathInt.IsNearlyZero(-1));
				Assert.AreEqual(false, MathInt.IsNearlyZero(-1, 0));
				Assert.AreEqual(true, MathInt.IsNearlyZero(-1, 1));
				Assert.AreEqual(true, MathInt.IsNearlyZero(-1, 2));
				Assert.AreEqual(false, MathInt.IsNearlyZero(-1, -1));
				Assert.AreEqual(false, MathInt.IsNearlyZero(-1, -2));
			}

			[Test]
			public void IsNegative ()
			{
				Assert.AreEqual(false, MathInt.IsNegative(1));
				Assert.AreEqual(false, MathInt.IsNegative(0));
				Assert.AreEqual(false, MathInt.IsNegative(-0));
				Assert.AreEqual(true, MathInt.IsNegative(-1));
			}

			[Test]
			public void IsNegativeOrZero ()
			{
				Assert.AreEqual(false, MathInt.IsNegativeOrZero(1));
				Assert.AreEqual(true, MathInt.IsNegativeOrZero(0));
				Assert.AreEqual(true, MathInt.IsNegativeOrZero(-0));
				Assert.AreEqual(true, MathInt.IsNegativeOrZero(-1));
			}

			[Test]
			public void IsPositive ()
			{
				Assert.AreEqual(true, MathInt.IsPositive(1));
				Assert.AreEqual(false, MathInt.IsPositive(0));
				Assert.AreEqual(false, MathInt.IsPositive(-0));
				Assert.AreEqual(false, MathInt.IsPositive(-1));
			}

			[Test]
			public void IsPositiveOrZero ()
			{
				Assert.AreEqual(true, MathInt.IsPositiveOrZero(1));
				Assert.AreEqual(true, MathInt.IsPositiveOrZero(0));
				Assert.AreEqual(true, MathInt.IsPositiveOrZero(-0));
				Assert.AreEqual(false, MathInt.IsPositiveOrZero(-1));
			}

			[Test]
			public void IsPowerOfTwo ()
			{
				Assert.AreEqual(true ,MathInt.IsPowerOfTwo(1));
				Assert.AreEqual(true ,MathInt.IsPowerOfTwo(2));
				Assert.AreEqual(true ,MathInt.IsPowerOfTwo(4));
				Assert.AreEqual(true ,MathInt.IsPowerOfTwo(8));
				Assert.AreEqual(true ,MathInt.IsPowerOfTwo(16));
				Assert.AreEqual(false ,MathInt.IsPowerOfTwo(3));
				Assert.AreEqual(false ,MathInt.IsPowerOfTwo(7));
				Assert.AreEqual(false ,MathInt.IsPowerOfTwo(15));
			}

			[Test]
			public void IsZero ()
			{
				Assert.AreEqual(false, MathInt.IsZero(1));
				Assert.AreEqual(true, MathInt.IsZero(0));
				Assert.AreEqual(true, MathInt.IsZero(-0));
				Assert.AreEqual(false, MathInt.IsZero(-1));
			}

			[Test]
			public void Max ()
			{
				Assert.AreEqual(1, MathInt.Max(0, 1));
				Assert.AreEqual(2, MathInt.Max(0, 1, 2));
				Assert.AreEqual(4, MathInt.Max(new int[] {0, 1, 2, 3, 4}));
			}

			[Test]
			public void Min ()
			{
				Assert.AreEqual(0, MathInt.Min(0, 1));
				Assert.AreEqual(0, MathInt.Min(0, 1, 2));
				Assert.AreEqual(0, MathInt.Min(new int[] {0, 1, 2, 3, 4}));
			}

			[Test]
			public void Mul ()
			{
				Assert.AreEqual(6 * 5, MathInt.Mul(6, 5));
				Assert.AreEqual(2 * 5, MathInt.Mul(2, 5));
				Assert.AreEqual(6 * 2, MathInt.Mul(6, 2));
				Assert.AreEqual(2 * 2, MathInt.Mul(2, 2));

				int a = 6;
				int b = 2;
				int c = 6;
				int d = 2;
				Assert.AreEqual(6 * 5, MathInt.Mul(ref a, 5));
				Assert.AreEqual(2 * 5, MathInt.Mul(ref b, 5));
				Assert.AreEqual(6 * 2, MathInt.Mul(ref c, 2));
				Assert.AreEqual(2 * 2, MathInt.Mul(ref d, 2));
			}
			[Test]
			public void Negate ()
			{
				Assert.AreEqual(-6, MathInt.Negate(6));
				Assert.AreEqual(-0, MathInt.Negate(0));
				Assert.AreEqual(6, MathInt.Negate(-6));
			}

			[Test]
			public void NextPowerOfTwo ()
			{
				Assert.AreEqual(2 ,MathInt.NextPowerOfTwo(2));
				Assert.AreEqual(4 ,MathInt.NextPowerOfTwo(3));
				Assert.AreEqual(8 ,MathInt.NextPowerOfTwo(7));
				Assert.AreEqual(16 ,MathInt.NextPowerOfTwo(12));
			}

			[Test]
			public void PingPong ()
			{
				Assert.AreEqual(7, MathInt.PingPong(-7, 10));
				Assert.AreEqual(2, MathInt.PingPong(-2, 10));
				Assert.AreEqual(0, MathInt.PingPong(0, 10));
				Assert.AreEqual(5, MathInt.PingPong(5, 10));
				Assert.AreEqual(10, MathInt.PingPong(10, 10));
				Assert.AreEqual(8, MathInt.PingPong(12, 10));
				Assert.AreEqual(3, MathInt.PingPong(17, 10));
				Assert.AreEqual(0, MathInt.PingPong(20, 10));
			}

			[Test]
			public void Repeat ()
			{
				Assert.AreEqual(2, MathInt.Repeat(2, 5));
				Assert.AreEqual(3, MathInt.Repeat(3, 5));
				Assert.AreEqual(4, MathInt.Repeat(4, 5));
				Assert.AreEqual(0, MathInt.Repeat(5, 5));
				Assert.AreEqual(2, MathInt.Repeat(7, 5));
				Assert.AreEqual(1, MathInt.Repeat(-4, 5));
				Assert.AreEqual(3, MathInt.Repeat(-7, 5));
			}

			[Test]
			public void Sign ()
			{
				Assert.AreEqual(1, MathInt.Sign(1));
				Assert.AreEqual(0, MathInt.Sign(0));
				Assert.AreEqual(-1, MathInt.Sign(-21));
			}

			[Test]
			public void SignPos ()
			{
				Assert.AreEqual(1, MathInt.SignPos(1));
				Assert.AreEqual(1, MathInt.SignPos(0));
				Assert.AreEqual(-1, MathInt.SignPos(-21));
				Assert.AreEqual(-1, MathInt.SignPos(int.MinValue));
				Assert.AreEqual(1, MathInt.SignPos(int.MaxValue));
			}

			[Test]
			public void Square ()
			{
				Assert.AreEqual(4, MathInt.Square(2));
				Assert.AreEqual(4, MathInt.Square(-2));
				Assert.AreEqual(16, MathInt.Square(4));
				Assert.AreEqual(16, MathInt.Square(-4));
				Assert.AreEqual(64, MathInt.Square(8));
				Assert.AreEqual(64, MathInt.Square(-8));
			}

		#endregion
	}
}
