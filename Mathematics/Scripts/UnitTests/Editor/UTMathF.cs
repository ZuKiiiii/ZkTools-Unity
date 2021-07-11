using NUnit.Framework;

namespace ZkTools.Mathematics.UnitTests.Editor
{
	internal class UTMathF
	{
		#region // ==============================[Static Variables]============================== //

			private const float delta = 1e-6f;

		#endregion

		#region // ==============================[Methods]============================== //

			[Test]
			public void Abs ()
			{
				Assert.AreEqual(2.06585f, MathF.Abs(2.06585f));
				Assert.AreEqual(2.06585f, MathF.Abs(-2.06585f));
				Assert.AreNotEqual(-2.06585f, MathF.Abs(-2.06585f));
				Assert.AreNotEqual(-2.06585f, MathF.Abs(-2.06585f));

				Assert.AreEqual(551.51351f, MathF.Abs(551.51351f));
				Assert.AreEqual(551.51351f, MathF.Abs(-551.51351f));
				Assert.AreNotEqual(-551.51351f, MathF.Abs(551.51351f));
				Assert.AreNotEqual(-551.51351f, MathF.Abs(-551.51351f));
			}

			[Test]
			public void Add ()
			{
				Assert.AreEqual(6.0f + 5.0f, MathF.Add(6.0f, 5.0f));
				Assert.AreEqual(2.0f + 5.0f, MathF.Add(2.0f, 5.0f));
				Assert.AreEqual(6.0f + 2.0f, MathF.Add(6.0f, 2.0f));
				Assert.AreEqual(2.0f + 2.0f, MathF.Add(2.0f, 2.0f));

				float a = 6.0f;
				float b = 2.0f;
				float c = 6.0f;
				float d = 2.0f;
				Assert.AreEqual(6.0f + 5.0f, MathF.Add(ref a, 5.0f));
				Assert.AreEqual(2.0f + 5.0f, MathF.Add(ref b, 5.0f));
				Assert.AreEqual(6.0f + 2.0f, MathF.Add(ref c, 2.0f));
				Assert.AreEqual(2.0f + 2.0f, MathF.Add(ref d, 2.0f));
			}

			[Test]
			public void Cbrt ()
			{
				Assert.AreEqual(1.9879272712443317f, MathF.Cbrt(7.856f), delta);
				Assert.AreEqual(4.608234306069499f, MathF.Cbrt(97.85965f), delta);
				Assert.AreEqual(1f, MathF.Cbrt(1f), delta);
			}

			[Test]
			public void Ceil ()
			{
				Assert.AreEqual(3.0f, MathF.Ceil(2.3f));
				Assert.AreEqual(4.0f, MathF.Ceil(3.8f));
				Assert.AreEqual(6.0f, MathF.Ceil(5.5f));
				Assert.AreEqual(-2.0f, MathF.Ceil(-2.3f));
				Assert.AreEqual(-3.0f, MathF.Ceil(-3.8f));
				Assert.AreEqual(-5.0f, MathF.Ceil(-5.5f));
			}

			[Test]
			public void CeilToInt ()
			{
				Assert.AreEqual(3, MathF.CeilToInt(2.3f));
				Assert.AreEqual(4, MathF.CeilToInt(3.8f));
				Assert.AreEqual(6, MathF.CeilToInt(5.5f));
				Assert.AreEqual(-2, MathF.CeilToInt(-2.3f));
				Assert.AreEqual(-3, MathF.CeilToInt(-3.8f));
				Assert.AreEqual(-5, MathF.CeilToInt(-5.5f));
			}

			[Test]
			public void Clamp ()
			{
				Assert.AreEqual(10.0f, MathF.Clamp(-15.0f, 10.0f, 20.0f));
				Assert.AreEqual(15.0f, MathF.Clamp(15.0f, 10.0f, 20.0f));
				Assert.AreEqual(20.0f, MathF.Clamp(504525.0f, 10.0f, 20.0f));
			}

			[Test]
			public void CopySign ()
			{
				Assert.AreEqual(-5.0, MathF.CopySign(5.0f, -10.0f));
				Assert.AreEqual(-5.0f, MathF.CopySign(-5.0f, -10.0f));
				Assert.AreEqual(5.0f, MathF.CopySign(5.0f, 10.0f));
				Assert.AreEqual(5.0f, MathF.CopySign(-5.0f, 10.0f));
			}

			[Test]
			public void Cube ()
			{
				Assert.AreEqual(216f, MathF.Cube(6.0f), delta);
				Assert.AreEqual(-278445077f, MathF.Cube(-653f), delta);
			}

			[Test]
			public void Distance ()
			{
				Assert.AreEqual(5.0f, MathF.Distance(10.0f, 5.0f));
				Assert.AreEqual(5.0f, MathF.Distance(5.0f, 10.0f));

				Assert.AreEqual(5.0f, MathF.Distance(-10.0f, -5.0f));
				Assert.AreEqual(5.0f, MathF.Distance(-5.0f, -10.0f));

				Assert.AreEqual(15.0f, MathF.Distance(-10.0f, 5.0f));
				Assert.AreEqual(15.0f, MathF.Distance(5.0f, -10.0f));

				Assert.AreEqual(15.0f, MathF.Distance(10.0f, -5.0f));
				Assert.AreEqual(15.0f, MathF.Distance(-5.0f, 10.0f));
			}

			[Test]
			public void DistanceSqr ()
			{
				Assert.AreEqual(25.0f, MathF.DistanceSqr(10.0f, 5.0f));
				Assert.AreEqual(25.0f, MathF.DistanceSqr(5.0f, 10.0f));

				Assert.AreEqual(25.0f, MathF.DistanceSqr(-10.0f, -5.0f));
				Assert.AreEqual(25.0f, MathF.DistanceSqr(-5.0f, -10.0f));

				Assert.AreEqual(225.0f, MathF.DistanceSqr(-10.0f, 5.0f));
				Assert.AreEqual(225.0f, MathF.DistanceSqr(5.0f, -10.0f));

				Assert.AreEqual(225.0f, MathF.DistanceSqr(10.0f, -5.0f));
				Assert.AreEqual(225.0f, MathF.DistanceSqr(-5.0f, 10.0f));
			}

			[Test]
			public void Div ()
			{
				Assert.AreEqual(6.0f / 5.0f, MathF.Div(6.0f, 5.0f));
				Assert.AreEqual(2.0f / 5.0f, MathF.Div(2.0f, 5.0f));
				Assert.AreEqual(6.0f / 2.0f, MathF.Div(6.0f, 2.0f));
				Assert.AreEqual(2.0f / 2.0f, MathF.Div(2.0f, 2.0f));

				float a = 6.0f;
				float b = 2.0f;
				float c = 6.0f;
				float d = 2.0f;
				Assert.AreEqual(6.0f / 5.0f, MathF.Div(ref a, 5.0f));
				Assert.AreEqual(2.0f / 5.0f, MathF.Div(ref b, 5.0f));
				Assert.AreEqual(6.0f / 2.0f, MathF.Div(ref c, 2.0f));
				Assert.AreEqual(2.0f / 2.0f, MathF.Div(ref d, 2.0f));
			}

			[Test]
			public void DivSafe ()
			{
				Assert.AreEqual(5.0f / 2.0f, MathF.DivSafe(5.0f, 2.0f));
				Assert.AreEqual(0.0f, MathF.DivSafe(5.0f, 0.0f));
				Assert.AreEqual(2.0f, MathF.DivSafe(5.0f, 0.0f, 2.0f));
				Assert.AreEqual(-5.0f / 2.0f, MathF.DivSafe(-5.0f, 2.0f));
				Assert.AreEqual(5.0f / -2.0f, MathF.DivSafe(5.0f, -2.0f));
			}

			[Test]
			public void Exp ()
			{
				Assert.AreEqual(7.38905609893f, MathF.Exp(2.0f), delta);
				Assert.AreEqual(1.0f, MathF.Exp(0.0f), delta);
				Assert.AreEqual(1.0f / MathF.Exp(4.0f), MathF.Exp(-4.0f), delta);
			}

			[Test]
			public void Floor ()
			{
				Assert.AreEqual(2.0f, MathF.Floor(2.3f));
				Assert.AreEqual(3.0f, MathF.Floor(3.8f));
				Assert.AreEqual(5.0f, MathF.Floor(5.5f));
				Assert.AreEqual(-3.0f, MathF.Floor(-2.3f));
				Assert.AreEqual(-4.0f, MathF.Floor(-3.8f));
				Assert.AreEqual(-6.0f, MathF.Floor(-5.5f));
			}

			[Test]
			public void FloorToInt ()
			{
				Assert.AreEqual(2, MathF.FloorToInt(2.3f));
				Assert.AreEqual(3, MathF.FloorToInt(3.8f));
				Assert.AreEqual(5, MathF.FloorToInt(5.5f));
				Assert.AreEqual(-3, MathF.FloorToInt(-2.3f));
				Assert.AreEqual(-4, MathF.FloorToInt(-3.8f));
				Assert.AreEqual(-6, MathF.FloorToInt(-5.5f));
			}

			[Test]
			public void Frac ()
			{
				Assert.AreEqual(0.3f, MathF.Frac(2.3f), delta);
				Assert.AreEqual(0.8f, MathF.Frac(3.8f), delta);
				Assert.AreEqual(0.5f, MathF.Frac(5.5f), delta);
				Assert.AreEqual(0.7f, MathF.Frac(-2.3f), delta);
				Assert.AreEqual(0.2f, MathF.Frac(-3.8f), delta);
				Assert.AreEqual(0.5f, MathF.Frac(-5.5f), delta);
			}

			[Test]
			public void Fractional ()
			{
				Assert.AreEqual(0.3f, MathF.Fractional(2.3f), delta);
				Assert.AreEqual(0.8f, MathF.Fractional(3.8f), delta);
				Assert.AreEqual(0.5f, MathF.Fractional(5.5f), delta);
				Assert.AreEqual(-0.3f, MathF.Fractional(-2.3f), delta);
				Assert.AreEqual(-0.8f, MathF.Fractional(-3.8f), delta);
				Assert.AreEqual(-0.5f, MathF.Fractional(-5.5f), delta);
			}

			[Test]
			public void IEEERemainder ()
			{
				Assert.AreEqual(1.0f, MathF.IEEERemainder(5.0f, 2.0f));
				Assert.AreEqual(-1.0f, MathF.IEEERemainder(-5.0f, 2.0f));
				Assert.AreEqual(0.0f, MathF.IEEERemainder(4.0f, 2.0f));
				Assert.AreEqual(0.0f, MathF.IEEERemainder(4.0f, -2.0f));
				Assert.AreEqual(-1.0f, MathF.IEEERemainder(3.0f, 2.0f));
				Assert.AreEqual(1.0f, MathF.IEEERemainder(5.0f, 2.0f));
				Assert.AreEqual(0.0f, MathF.IEEERemainder(6.0f, 2.0f));
				Assert.AreEqual(-1.0f, MathF.IEEERemainder(7.0f, 2.0f));
			}

			[Test]
			public void Inv ()
			{
				Assert.AreEqual(1.0f / 2.0f, MathF.Inv(2.0f));
				Assert.AreEqual(1.0f / -2.0f, MathF.Inv(-2.0f));
				Assert.AreEqual(1.0f / -2.0f, -MathF.Inv(2.0f));
				Assert.AreEqual(1.0f / 2.0f, -MathF.Inv(-2.0f));
			}

			[Test]
			public void InverseLerp ()
			{
				Assert.AreEqual(-1.2f, MathF.InverseLerp(0.0f, 1.0f, -1.2f));
				Assert.AreEqual(-1.0f, MathF.InverseLerp(0.0f, 1.0f, -1.0f));
				Assert.AreEqual(-0.7f, MathF.InverseLerp(0.0f, 1.0f, -0.7f));
				Assert.AreEqual(-0.5f, MathF.InverseLerp(0.0f, 1.0f, -0.5f));
				Assert.AreEqual(-0.3f, MathF.InverseLerp(0.0f, 1.0f, -0.3f));
				Assert.AreEqual(0.0f, MathF.InverseLerp(0.0f, 1.0f, -0.0f));
				Assert.AreEqual(0.3f, MathF.InverseLerp(0.0f, 1.0f, 0.3f));
				Assert.AreEqual(0.5f, MathF.InverseLerp(0.0f, 1.0f, 0.5f));
				Assert.AreEqual(0.7f, MathF.InverseLerp(0.0f, 1.0f, 0.7f));
				Assert.AreEqual(1.0f, MathF.InverseLerp(0.0f, 1.0f, 1.0f));
				Assert.AreEqual(1.2f, MathF.InverseLerp(0.0f, 1.0f, 1.2f));

				Assert.AreEqual(2.2f, MathF.InverseLerp(1.0f, 0.0f, -1.2f));
				Assert.AreEqual(1.7f, MathF.InverseLerp(1.0f, 0.0f, -0.7f));
				Assert.AreEqual(1.5f, MathF.InverseLerp(1.0f, 0.0f, -0.5f));
				Assert.AreEqual(1.3f, MathF.InverseLerp(1.0f, 0.0f, -0.3f));
				Assert.AreEqual(0.0f, MathF.InverseLerp(0.0f, 1.0f, -0.0f));
				Assert.AreEqual(0.7f, MathF.InverseLerp(1.0f, 0.0f, 0.3f));
				Assert.AreEqual(0.5f, MathF.InverseLerp(1.0f, 0.0f, 0.5f));
				Assert.AreEqual(0.3f, MathF.InverseLerp(1.0f, 0.0f, 0.7f));
				Assert.AreEqual(0.0f, MathF.InverseLerp(1.0f, 0.0f, 1.0f));
				Assert.AreEqual(-0.2f, MathF.InverseLerp(1.0f, 0.0f, 1.2f), delta);
			}

			[Test]
			public void InverseLerpClamped ()
			{
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(0.0f, 1.0f, -1.2f));
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(0.0f, 1.0f, -1.0f));
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(0.0f, 1.0f, -0.7f));
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(0.0f, 1.0f, -0.5f));
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(0.0f, 1.0f, -0.3f));
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(0.0f, 1.0f, -0.0f));
				Assert.AreEqual(0.3f, MathF.InverseLerpClamped(0.0f, 1.0f, 0.3f));
				Assert.AreEqual(0.5f, MathF.InverseLerpClamped(0.0f, 1.0f, 0.5f));
				Assert.AreEqual(0.7f, MathF.InverseLerpClamped(0.0f, 1.0f, 0.7f));
				Assert.AreEqual(1.0f, MathF.InverseLerpClamped(0.0f, 1.0f, 1.0f));
				Assert.AreEqual(1.0f, MathF.InverseLerpClamped(0.0f, 1.0f, 1.2f));

				Assert.AreEqual(1.0f, MathF.InverseLerpClamped(1.0f, 0.0f, -1.2f));
				Assert.AreEqual(1.0f, MathF.InverseLerpClamped(1.0f, 0.0f, -0.7f));
				Assert.AreEqual(1.0f, MathF.InverseLerpClamped(1.0f, 0.0f, -0.5f));
				Assert.AreEqual(1.0f, MathF.InverseLerpClamped(1.0f, 0.0f, -0.3f));
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(0.0f, 1.0f, -0.0f));
				Assert.AreEqual(0.7f, MathF.InverseLerpClamped(1.0f, 0.0f, 0.3f));
				Assert.AreEqual(0.5f, MathF.InverseLerpClamped(1.0f, 0.0f, 0.5f));
				Assert.AreEqual(0.3f, MathF.InverseLerpClamped(1.0f, 0.0f, 0.7f));
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(1.0f, 0.0f, 1.0f));
				Assert.AreEqual(0.0f, MathF.InverseLerpClamped(1.0f, 0.0f, 1.2f));
			}

			[Test]
			public void InvSqrt ()
			{
				Assert.AreEqual(1.0f / MathF.Sqrt(2.0f), MathF.InvSqrt(2.0f));
				Assert.AreEqual(1.0f / MathF.Sqrt(8.0f), MathF.InvSqrt(8.0f));
				Assert.AreEqual(1.0f / MathF.Sqrt(13.0f), MathF.InvSqrt(13.0f));
				Assert.AreEqual(1.0f / MathF.Sqrt(32.0f), MathF.InvSqrt(32.0f));
			}

			[Test]
			public void IsGreater ()
			{
				Assert.AreEqual(1.0f > 2.0f, MathF.IsGreater(1.0f, 2.0f));
				Assert.AreEqual(1.0f > 1.0f, MathF.IsGreater(1.0f, 1.0f));
				Assert.AreEqual(2.0f > 1.0f, MathF.IsGreater(2.0f, 1.0f));
			}

			[Test]
			public void IsGreaterEqual ()
			{
				Assert.AreEqual(1.0f >= 2.0f, MathF.IsGreaterEqual(1.0f, 2.0f));
				Assert.AreEqual(1.0f >= 1.0f, MathF.IsGreaterEqual(1.0f, 1.0f));
				Assert.AreEqual(2.0f >= 1.0f, MathF.IsGreaterEqual(2.0f, 1.0f));
			}

			[Test]
			public void IsLess ()
			{
				Assert.AreEqual(1.0f < 2.0f, MathF.IsLess(1.0f, 2.0f));
				Assert.AreEqual(1.0f < 1.0f, MathF.IsLess(1.0f, 1.0f));
				Assert.AreEqual(2.0f < 1.0f, MathF.IsLess(2.0f, 1.0f));
			}

			[Test]
			public void IsLessEqual ()
			{
				Assert.AreEqual(1.0f <= 2.0f, MathF.IsLessEqual(1.0f, 2.0f));
				Assert.AreEqual(1.0f <= 1.0f, MathF.IsLessEqual(1.0f, 1.0f));
				Assert.AreEqual(2.0f <= 1.0f, MathF.IsLessEqual(2.0f, 1.0f));
			}

			[Test]
			public void IsNearlyEqual ()
			{
				Assert.AreEqual(true, MathF.IsNearlyEqual(1.0f, 1.0f));
				Assert.AreEqual(false, MathF.IsNearlyEqual(1.0f, 1.2f));
				Assert.AreEqual(false, MathF.IsNearlyEqual(1.0f, 1.2f, 0.1f));
				Assert.AreEqual(true, MathF.IsNearlyEqual(1.0f, 1.2f, 0.3f));
				Assert.AreEqual(false, MathF.IsNearlyEqual(1.0f, 1.2f, -0.3f));
			}

			[Test]
			public void IsNearlyGreater ()
			{
				Assert.AreEqual(false, MathF.IsNearlyGreater(1.0f, 2.0f));
				Assert.AreEqual(false, MathF.IsNearlyGreater(1.0f, 2.0f, 0.9f));
				Assert.AreEqual(false, MathF.IsNearlyGreater(1.0f, 2.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreater(1.0f, 2.0f, 1.1f));
				Assert.AreEqual(false, MathF.IsNearlyGreater(1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreater(1.0f, 1.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyGreater(1.0f, 1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreater(1.0f, 1.0f, 1.1f));
				Assert.AreEqual(true, MathF.IsNearlyGreater(2.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreater(2.0f, 1.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyGreater(2.0f, 1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreater(2.0f, 1.0f, 1.1f));
			}

			[Test]
			public void IsNearlyGreaterEqual ()
			{
				Assert.AreEqual(false, MathF.IsNearlyGreaterEqual(1.0f, 2.0f));
				Assert.AreEqual(false, MathF.IsNearlyGreaterEqual(1.0f, 2.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(1.0f, 2.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(1.0f, 2.0f, 1.1f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(1.0f, 1.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(1.0f, 1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(1.0f, 1.0f, 1.1f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(2.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(2.0f, 1.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(2.0f, 1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyGreaterEqual(2.0f, 1.0f, 1.1f));
			}

			[Test]
			public void IsNearlyLess ()
			{
				Assert.AreEqual(true, MathF.IsNearlyLess(1.0f, 2.0f));
				Assert.AreEqual(true, MathF.IsNearlyLess(1.0f, 2.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyLess(1.0f, 2.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyLess(1.0f, 2.0f, 1.1f));
				Assert.AreEqual(false, MathF.IsNearlyLess(1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyLess(1.0f, 1.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyLess(1.0f, 1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyLess(1.0f, 1.0f, 1.1f));
				Assert.AreEqual(false, MathF.IsNearlyLess(2.0f, 1.0f));
				Assert.AreEqual(false, MathF.IsNearlyLess(2.0f, 1.0f, 0.9f));
				Assert.AreEqual(false, MathF.IsNearlyLess(2.0f, 1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyLess(2.0f, 1.0f, 1.1f));
			}

			[Test]
			public void IsNearlyLessEqual ()
			{
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(1.0f, 2.0f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(1.0f, 2.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(1.0f, 2.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(1.0f, 2.0f, 1.1f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(1.0f, 1.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(1.0f, 1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(1.0f, 1.0f, 1.1f));
				Assert.AreEqual(false, MathF.IsNearlyLessEqual(2.0f, 1.0f));
				Assert.AreEqual(false, MathF.IsNearlyLessEqual(2.0f, 1.0f, 0.9f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(2.0f, 1.0f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyLessEqual(2.0f, 1.0f, 1.1f));
			}

			[Test]
			public void IsNearlyZero ()
			{
				Assert.AreEqual(false, MathF.IsNearlyZero(1.1f));
				Assert.AreEqual(false, MathF.IsNearlyZero(1.1f, 0.4f));
				Assert.AreEqual(false, MathF.IsNearlyZero(1.1f, 1.0f));
				Assert.AreEqual(true, MathF.IsNearlyZero(1.1f, 1.3f));
				Assert.AreEqual(false, MathF.IsNearlyZero(1.1f, -1.0f));


				Assert.AreEqual(false, MathF.IsNearlyZero(0.1f));
				Assert.AreEqual(false, MathF.IsNearlyZero(0.1f, 0.04f));
				Assert.AreEqual(true, MathF.IsNearlyZero(0.1f, 0.1f));
				Assert.AreEqual(true, MathF.IsNearlyZero(0.1f, 0.3f));
				Assert.AreEqual(false, MathF.IsNearlyZero(0.1f, -1.0f));


				Assert.AreEqual(true, MathF.IsNearlyZero(0.0f));
				Assert.AreEqual(true, MathF.IsNearlyZero(0.0f, 0.5f));
				Assert.AreEqual(false, MathF.IsNearlyZero(0.0f, -1.0f));

				Assert.AreEqual(true, MathF.IsNearlyZero(-0.0f));
				Assert.AreEqual(true, MathF.IsNearlyZero(-0.0f, 0.5f));
				Assert.AreEqual(false, MathF.IsNearlyZero(-0.0f, -1.0f));


				Assert.AreEqual(false, MathF.IsNearlyZero(-1.1f));
				Assert.AreEqual(false, MathF.IsNearlyZero(-1.1f, 0.4f));
				Assert.AreEqual(true, MathF.IsNearlyZero(-1.1f, 1.1f));
				Assert.AreEqual(true, MathF.IsNearlyZero(-1.1f, 1.3f));
				Assert.AreEqual(false, MathF.IsNearlyZero(-1.1f, -1.3f));

				Assert.AreEqual(false, MathF.IsNearlyZero(-0.1f));
				Assert.AreEqual(false, MathF.IsNearlyZero(-0.1f, 0.04f));
				Assert.AreEqual(true, MathF.IsNearlyZero(-0.1f, 0.1f));
				Assert.AreEqual(true, MathF.IsNearlyZero(-0.1f, 0.3f));
				Assert.AreEqual(false, MathF.IsNearlyZero(-0.1f, -0.3f));
			}

			[Test]
			public void IsNegative ()
			{
				Assert.AreEqual(false, MathF.IsNegative(1.1f));
				Assert.AreEqual(false, MathF.IsNegative(0.1f));
				Assert.AreEqual(false, MathF.IsNegative(0.0f));
				Assert.AreEqual(false, MathF.IsNegative(-0.0f));
				Assert.AreEqual(true, MathF.IsNegative(-0.1f));
				Assert.AreEqual(true, MathF.IsNegative(-1.1f));
			}

			[Test]
			public void IsNegativeOrZero ()
			{
				Assert.AreEqual(false, MathF.IsNegativeOrZero(1.1f));
				Assert.AreEqual(false, MathF.IsNegativeOrZero(0.1f));
				Assert.AreEqual(true, MathF.IsNegativeOrZero(0.0f));
				Assert.AreEqual(true, MathF.IsNegativeOrZero(-0.0f));
				Assert.AreEqual(true, MathF.IsNegativeOrZero(-0.1f));
				Assert.AreEqual(true, MathF.IsNegativeOrZero(-1.1f));
			}

			[Test]
			public void IsPositive ()
			{
				Assert.AreEqual(true, MathF.IsPositive(1.1f));
				Assert.AreEqual(true, MathF.IsPositive(0.1f));
				Assert.AreEqual(false, MathF.IsPositive(0.0f));
				Assert.AreEqual(false, MathF.IsPositive(-0.0f));
				Assert.AreEqual(false, MathF.IsPositive(-0.1f));
				Assert.AreEqual(false, MathF.IsPositive(-1.1f));
			}

			[Test]
			public void IsPositiveOrZero ()
			{
				Assert.AreEqual(true, MathF.IsPositiveOrZero(1.1f));
				Assert.AreEqual(true, MathF.IsPositiveOrZero(0.1f));
				Assert.AreEqual(true, MathF.IsPositiveOrZero(0.0f));
				Assert.AreEqual(true, MathF.IsPositiveOrZero(-0.0f));
				Assert.AreEqual(false, MathF.IsPositiveOrZero(-0.1f));
				Assert.AreEqual(false, MathF.IsPositiveOrZero(-1.1f));
			}

			[Test]
			public void IsZero ()
			{
				Assert.AreEqual(false, MathF.IsZero(1.1f));
				Assert.AreEqual(false, MathF.IsZero(0.1f));
				Assert.AreEqual(true, MathF.IsZero(0.0f));
				Assert.AreEqual(true, MathF.IsZero(-0.0f));
				Assert.AreEqual(false, MathF.IsZero(-0.1f));
				Assert.AreEqual(false, MathF.IsZero(-1.1f));
			}

			[Test]
			public void Lerp ()
			{
				Assert.AreEqual(-1.2f, MathF.Lerp(0.0f, 1.0f, -1.2f));
				Assert.AreEqual(-1.0f, MathF.Lerp(0.0f, 1.0f, -1.0f));
				Assert.AreEqual(-0.7f, MathF.Lerp(0.0f, 1.0f, -0.7f));
				Assert.AreEqual(-0.5f, MathF.Lerp(0.0f, 1.0f, -0.5f));
				Assert.AreEqual(-0.3f, MathF.Lerp(0.0f, 1.0f, -0.3f));
				Assert.AreEqual(0.0f, MathF.Lerp(0.0f, 1.0f, -0.0f));
				Assert.AreEqual(0.3f, MathF.Lerp(0.0f, 1.0f, 0.3f));
				Assert.AreEqual(0.5f, MathF.Lerp(0.0f, 1.0f, 0.5f));
				Assert.AreEqual(0.7f, MathF.Lerp(0.0f, 1.0f, 0.7f));
				Assert.AreEqual(1.0f, MathF.Lerp(0.0f, 1.0f, 1.0f));
				Assert.AreEqual(1.2f, MathF.Lerp(0.0f, 1.0f, 1.2f));

				Assert.AreEqual(-1.2f, MathF.Lerp(1.0f, 0.0f, 2.2f));
				Assert.AreEqual(-0.7f, MathF.Lerp(1.0f, 0.0f, 1.7f), delta);
				Assert.AreEqual(-0.5f, MathF.Lerp(1.0f, 0.0f, 1.5f), delta);
				Assert.AreEqual(-0.3f, MathF.Lerp(1.0f, 0.0f, 1.3f), delta);
				Assert.AreEqual(1.0f, MathF.Lerp(0.0f, 1.0f, 1.0f), delta);
				Assert.AreEqual(0.3f, MathF.Lerp(1.0f, 0.0f, 0.7f), delta);
				Assert.AreEqual(0.5f, MathF.Lerp(1.0f, 0.0f, 0.5f), delta);
				Assert.AreEqual(0.7f, MathF.Lerp(1.0f, 0.0f, 0.3f), delta);
				Assert.AreEqual(1.0f, MathF.Lerp(1.0f, 0.0f, 0.0f), delta);
				Assert.AreEqual(1.2f, MathF.Lerp(1.0f, 0.0f, -0.2f), delta);
			}

			[Test]
			public void LerpClamped ()
			{
				Assert.AreEqual(0.0f, MathF.LerpClamped(0.0f, 1.0f, -1.2f));
				Assert.AreEqual(0.0f, MathF.LerpClamped(0.0f, 1.0f, -1.0f));
				Assert.AreEqual(0.0f, MathF.LerpClamped(0.0f, 1.0f, -0.7f));
				Assert.AreEqual(0.0f, MathF.LerpClamped(0.0f, 1.0f, -0.5f));
				Assert.AreEqual(0.0f, MathF.LerpClamped(0.0f, 1.0f, -0.3f));
				Assert.AreEqual(0.0f, MathF.LerpClamped(0.0f, 1.0f, -0.0f));
				Assert.AreEqual(0.3f, MathF.LerpClamped(0.0f, 1.0f, 0.3f));
				Assert.AreEqual(0.5f, MathF.LerpClamped(0.0f, 1.0f, 0.5f));
				Assert.AreEqual(0.7f, MathF.LerpClamped(0.0f, 1.0f, 0.7f));
				Assert.AreEqual(1.0f, MathF.LerpClamped(0.0f, 1.0f, 1.0f));
				Assert.AreEqual(1.0f, MathF.LerpClamped(0.0f, 1.0f, 1.2f));

				Assert.AreEqual(0.0f, MathF.LerpClamped(1.0f, 0.0f, 2.2f));
				Assert.AreEqual(0.0f, MathF.LerpClamped(1.0f, 0.0f, 1.7f));
				Assert.AreEqual(0.0f, MathF.LerpClamped(1.0f, 0.0f, 1.5f));
				Assert.AreEqual(0.0f, MathF.LerpClamped(1.0f, 0.0f, 1.3f));
				Assert.AreEqual(1.0f, MathF.LerpClamped(0.0f, 1.0f, 1.0f));
				Assert.AreEqual(0.3f, MathF.LerpClamped(1.0f, 0.0f, 0.7f));
				Assert.AreEqual(0.5f, MathF.LerpClamped(1.0f, 0.0f, 0.5f));
				Assert.AreEqual(0.7f, MathF.LerpClamped(1.0f, 0.0f, 0.3f));
				Assert.AreEqual(1.0f, MathF.LerpClamped(1.0f, 0.0f, 0.0f));
				Assert.AreEqual(1.0f, MathF.LerpClamped(1.0f, 0.0f, -0.2f));
			}

			[Test]
			public void Ln ()
			{
				Assert.AreEqual(MathF.LogE(2.0f), MathF.Ln(2.0f));
				Assert.AreEqual(MathF.LogE(3.0f), MathF.Ln(3.0f));
				Assert.AreEqual(MathF.LogE(12.0f), MathF.Ln(12.0f));
			}

			[Test]
			public void Log ()
			{
				Assert.AreEqual(MathF.Log2(1.0f), MathF.Log(1.0f, 2.0f));
				Assert.AreEqual(MathF.Log2(2.0f), MathF.Log(2.0f, 2.0f));
				Assert.AreEqual(MathF.Log2(3.0f), MathF.Log(3.0f, 2.0f));

				Assert.AreEqual(MathF.Log10(1.0f), MathF.Log(1.0f, 10.0f));
				Assert.AreEqual(MathF.Log10(2.0f), MathF.Log(2.0f, 10.0f));
				Assert.AreEqual(MathF.Log10(3.0f), MathF.Log(3.0f, 10.0f));
				Assert.AreEqual(MathF.Log10(10.0f), MathF.Log(10.0f, 10.0f));

				Assert.AreEqual(MathF.LogE(1.0f), MathF.Log(1.0f, MathF.E));
				Assert.AreEqual(MathF.LogE(2.0f), MathF.Log(2.0f, MathF.E));
				Assert.AreEqual(MathF.LogE(3.0f), MathF.Log(3.0f, MathF.E));
				Assert.AreEqual(MathF.LogE(10.0f), MathF.Log(10.0f, MathF.E));

				Assert.AreEqual(0.0f, MathF.Log(1.0f, 5.0f));
				Assert.AreEqual(0.43067655807f, MathF.Log(2.0f, 5.0f));
				Assert.AreEqual(0.68260619449f, MathF.Log(3.0f, 5.0f));
				Assert.AreEqual(1.0f, MathF.Log(5.0f, 5.0f));
			}

			[Test]
			public void Log2 ()
			{
				Assert.AreEqual(0.0f, MathF.Log2(1.0f));
				Assert.AreEqual(1.0f, MathF.Log2(2.0f));
				Assert.AreEqual(3.3219280949f, MathF.Log2(10.0f));
				Assert.AreEqual(1.4426950409f, MathF.Log2(MathF.E));
			}

			[Test]
			public void Log10 ()
			{
				Assert.AreEqual(0.0f, MathF.Log10(1.0f));
				Assert.AreEqual(0.30102999566f, MathF.Log10(2.0f));
				Assert.AreEqual(1.0f, MathF.Log10(10.0f));
				Assert.AreEqual(0.4342944819f, MathF.Log10(MathF.E), delta);
			}

			[Test]
			public void LogE ()
			{
				Assert.AreEqual(0.0f, MathF.LogE(1.0f));
				Assert.AreEqual(0.69314718056f, MathF.LogE(2.0f));
				Assert.AreEqual(2.302585093f, MathF.LogE(10.0f));
				Assert.AreEqual(1.0f, MathF.LogE(MathF.E), delta);
			}

			[Test]
			public void Max ()
			{
				Assert.AreEqual(1.0f, MathF.Max(0.0f, 1.0f));
				Assert.AreEqual(2.0f, MathF.Max(0.0f, 1.0f, 2.0f));
				Assert.AreEqual(4.0f, MathF.Max(new float[] {0.0f, 1.0f, 2.0f, 3.0f, 4.0f}));
			}

			[Test]
			public void Min ()
			{
				Assert.AreEqual(0.0f, MathF.Min(0.0f, 1.0f));
				Assert.AreEqual(0.0f, MathF.Min(0.0f, 1.0f, 2.0f));
				Assert.AreEqual(0.0f, MathF.Min(new float[] {0.0f, 1.0f, 2.0f, 3.0f, 4.0f}));
			}

			[Test]
			public void Modf ()
			{
				// Assert 01
				MathF.Modf(3.14151617f, out float intPart1, out float fracPart1);
				Assert.AreEqual(3.0f, intPart1, delta);
				Assert.AreEqual(0.14151617f, fracPart1, delta);

				// Assert 02
				MathF.Modf(-3.14151617f, out float intPart2, out float fracPart2);
				Assert.AreEqual(-3.0f, intPart2, delta);
				Assert.AreEqual(-0.14151617f, fracPart2, delta);
			}

			[Test]
			public void Mul ()
			{
				Assert.AreEqual(6.0f * 5.0f, MathF.Mul(6.0f, 5.0f));
				Assert.AreEqual(2.0f * 5.0f, MathF.Mul(2.0f, 5.0f));
				Assert.AreEqual(6.0f * 2.0f, MathF.Mul(6.0f, 2.0f));
				Assert.AreEqual(2.0f * 2.0f, MathF.Mul(2.0f, 2.0f));

				float a = 6.0f;
				float b = 2.0f;
				float c = 6.0f;
				float d = 2.0f;
				Assert.AreEqual(6.0f * 5.0f, MathF.Mul(ref a, 5.0f));
				Assert.AreEqual(2.0f * 5.0f, MathF.Mul(ref b, 5.0f));
				Assert.AreEqual(6.0f * 2.0f, MathF.Mul(ref c, 2.0f));
				Assert.AreEqual(2.0f * 2.0f, MathF.Mul(ref d, 2.0f));
			}

			[Test]
			public void MoveTowards ()
			{
				Assert.AreEqual(-2.0f, MathF.MoveTowards(0.0f, 5.0f, -2.0f));
				Assert.AreEqual(2.0f, MathF.MoveTowards(0.0f, 5.0f, 2.0f));
				Assert.AreEqual(5.0f, MathF.MoveTowards(0.0f, 5.0f, 5.0f));
				Assert.AreEqual(5.0f, MathF.MoveTowards(0.0f, 5.0f, 7.0f));
			}

			[Test]
			public void Negate ()
			{
				Assert.AreEqual(-6.0f, MathF.Negate(6.0f));
				Assert.AreEqual(-0.0f, MathF.Negate(0.0f));
				Assert.AreEqual(6.0f, MathF.Negate(-6.0f));
			}

			[Test]
			public void PingPong ()
			{
				Assert.AreEqual(7.0f, MathF.PingPong(-7.0f, 10.0f));
				Assert.AreEqual(2.0f, MathF.PingPong(-2.0f, 10.0f));
				Assert.AreEqual(0.0f, MathF.PingPong(0.0f, 10.0f));
				Assert.AreEqual(5.0f, MathF.PingPong(5.0f, 10.0f));
				Assert.AreEqual(10.0f, MathF.PingPong(10.0f, 10.0f));
				Assert.AreEqual(8.0f, MathF.PingPong(12.0f, 10.0f));
				Assert.AreEqual(3.0f, MathF.PingPong(17.0f, 10.0f));
				Assert.AreEqual(0.0f, MathF.PingPong(20.0f, 10.0f));
			}

			[Test]
			public void Pow ()
			{
				Assert.AreEqual(4.0f, MathF.Pow(2.0f, 2.0f));
				Assert.AreEqual(8.0f, MathF.Pow(2.0f, 3.0f));
				Assert.AreEqual(0.25f, MathF.Pow(2.0f, -2.0f));
			}

			[Test]
			public void QuadraticDelta ()
			{
				Assert.AreEqual(49.0f, MathF.QuadraticDelta(2.0f, 7.0f, 0.0f));
				Assert.AreEqual(89.0f, MathF.QuadraticDelta(2.0f, 7.0f, -5.0f));
				Assert.AreEqual(89.0f, MathF.QuadraticDelta(2.0f, -7.0f, -5.0f));
				Assert.AreEqual(9.0f, MathF.QuadraticDelta(-2.0f, 7.0f, -5.0f));
			}

			[Test]
			public void QuadraticEquation ()
			{
				Assert.Fail("QuadraticEquation UnitTest not implemented");
			}

			[Test]
			public void Quartic ()
			{
				Assert.AreEqual(MathF.Pow(2, 4.0f), MathF.Quartic(2.0f));
				Assert.AreEqual(MathF.Pow(6, 4.0f), MathF.Quartic(6.0f));
				Assert.AreEqual(MathF.Pow(-7, 4.0f), MathF.Quartic(-7.0f));
			}

			[Test]
			public void Quintic ()
			{
				Assert.AreEqual(MathF.Pow(2, 5.0f), MathF.Quintic(2.0f));
				Assert.AreEqual(MathF.Pow(6, 5.0f), MathF.Quintic(6.0f));
				Assert.AreEqual(MathF.Pow(-7, 5.0f), MathF.Quintic(-7.0f));
			}

			[Test]
			public void Remainder ()
			{
				Assert.AreEqual(1.0f, MathF.Remainder(5.0f, 2.0f));
				Assert.AreEqual(-1.0f, MathF.Remainder(-5.0f, 2.0f));
				Assert.AreEqual(0.0f, MathF.Remainder(4.0f, 2.0f));
				Assert.AreEqual(0.0f, MathF.Remainder(4.0f, -2.0f));
				Assert.AreEqual(1.0f, MathF.Remainder(3.0f, 2.0f));
				Assert.AreEqual(1.0f, MathF.Remainder(3.0f, -2.0f));
				Assert.AreEqual(-1.0f, MathF.Remainder(-3.0f, -2.0f));
				Assert.AreEqual(1.0f, MathF.Remainder(5.0f, 2.0f));
				Assert.AreEqual(1.0f, MathF.Remainder(5.0f, -2.0f));
				Assert.AreEqual(-1.0f, MathF.Remainder(-5.0f, -2.0f));
			}

			[Test]
			public void Remap ()
			{
				Assert.AreEqual(0.0f, MathF.Remap(-1.0f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(5.0f, MathF.Remap(-0.5f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(10.0f, MathF.Remap(0.0f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(12.5f, MathF.Remap(0.25f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(15.0f, MathF.Remap(0.5f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(17.5f, MathF.Remap(0.75f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(20.0f, MathF.Remap(1.0f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(25.0f, MathF.Remap(1.5f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(30.0f, MathF.Remap(2.0f, 0.0f, 1.0f, 10.0f, 20.0f));
			}

			[Test]
			public void RemapClamped ()
			{
				Assert.AreEqual(10.0f, MathF.RemapClamped(-1.0f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(10.0f, MathF.RemapClamped(-0.5f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(10.0f, MathF.RemapClamped(0.0f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(12.5f, MathF.RemapClamped(0.25f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(15.0f, MathF.RemapClamped(0.5f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(17.5f, MathF.RemapClamped(0.75f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(20.0f, MathF.RemapClamped(1.0f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(20.0f, MathF.RemapClamped(1.5f, 0.0f, 1.0f, 10.0f, 20.0f));
				Assert.AreEqual(20.0f, MathF.RemapClamped(2.0f, 0.0f, 1.0f, 10.0f, 20.0f));
			}

			[Test]
			public void Repeat ()
			{
				Assert.AreEqual(2.0f, MathF.Repeat(2.0f, 5.0f));
				Assert.AreEqual(4.0f, MathF.Repeat(4.0f, 5.0f));
				Assert.AreEqual(0.0f, MathF.Repeat(5.0f, 5.0f));
				Assert.AreEqual(2.0f, MathF.Repeat(7.0f, 5.0f));
				Assert.AreEqual(1.0f, MathF.Repeat(-4.0f, 5.0f));
				Assert.AreEqual(3.0f, MathF.Repeat(-7.0f, 5.0f));
			}

			[Test]
			public void Round ()
			{
				Assert.AreEqual(2.0f, MathF.Round(2.3f));
				Assert.AreEqual(4.0f, MathF.Round(3.8f));
				Assert.AreEqual(6.0f, MathF.Round(5.5f));
				Assert.AreEqual(-2.0f, MathF.Round(-2.3f));
				Assert.AreEqual(-4.0f, MathF.Round(-3.8f));
				Assert.AreEqual(-6.0f, MathF.Round(-5.5f));
			}

			[Test]
			public void RoundToInt ()
			{
				Assert.AreEqual(2.0f, MathF.RoundToInt(2.3f));
				Assert.AreEqual(4.0f, MathF.RoundToInt(3.8f));
				Assert.AreEqual(6.0f, MathF.RoundToInt(5.5f));
				Assert.AreEqual(-2.0f, MathF.RoundToInt(-2.3f));
				Assert.AreEqual(-4.0f, MathF.RoundToInt(-3.8f));
				Assert.AreEqual(-6.0f, MathF.RoundToInt(-5.5f));
			}

			[Test]
			public void Root ()
			{
				Assert.AreEqual(MathF.Sqrt(5.0f), MathF.Root(5.0f, 2.0f), delta);
				Assert.AreEqual(1.7099759466767f, MathF.Root(5.0f, 3.0f), delta);
				Assert.AreEqual(1.4953487812212f, MathF.Root(5.0f, 4.0f), delta);
				Assert.AreEqual(1.3797296614612f, MathF.Root(5.0f, 5.0f), delta);
			}

			[Test]
			public void Sign ()
			{
				Assert.AreEqual(1.0f, MathF.Sign(1.0f));
				Assert.AreEqual(0.0f, MathF.Sign(0.0f));
				Assert.AreEqual(-1.0f, MathF.Sign(-21.0f));
			}

			[Test]
			public void SignedDistance ()
			{
				Assert.AreEqual(-5.0f, MathF.SignedDistance(10.0f, 5.0f));
				Assert.AreEqual(5.0f, MathF.SignedDistance(5.0f, 10.0f));

				Assert.AreEqual(5.0f, MathF.SignedDistance(-10.0f, -5.0f));
				Assert.AreEqual(-5.0f, MathF.SignedDistance(-5.0f, -10.0f));

				Assert.AreEqual(15.0f, MathF.SignedDistance(-10.0f, 5.0f));
				Assert.AreEqual(-15.0f, MathF.SignedDistance(5.0f, -10.0f));

				Assert.AreEqual(-15.0f, MathF.SignedDistance(10.0f, -5.0f));
				Assert.AreEqual(15.0f, MathF.SignedDistance(-5.0f, 10.0f));
			}

			[Test]
			public void SignPos ()
			{
				Assert.AreEqual(1.0f, MathF.SignPos(1.0f));
				Assert.AreEqual(1.0f, MathF.SignPos(0.0f));
				Assert.AreEqual(-1.0f, MathF.SignPos(-21.0f));
			}

			[Test]
			public void SmoothDamp ()
			{
				Assert.Fail("SmoothDamp UnitTest not implemented");
			}

			[Test]
			public void Sqrt ()
			{
				Assert.AreEqual(2.0f, MathF.Sqrt(4.0f));
				Assert.AreEqual(4.0f, MathF.Sqrt(16.0f));
				Assert.AreEqual(8.0f, MathF.Sqrt(64.0f));
			}

			[Test]
			public void Square ()
			{
				Assert.AreEqual(4.0f, MathF.Square(2.0f));
				Assert.AreEqual(4.0f, MathF.Square(-2.0f));
				Assert.AreEqual(16.0f, MathF.Square(4.0f));
				Assert.AreEqual(16.0f, MathF.Square(-4.0f));
				Assert.AreEqual(64.0f, MathF.Square(8.0f));
				Assert.AreEqual(64.0f, MathF.Square(-8.0f));
			}

			[Test]
			public void Sub ()
			{
				Assert.AreEqual(6.0f - 5.0f, MathF.Sub(6.0f, 5.0f));
				Assert.AreEqual(2.0f - 5.0f, MathF.Sub(2.0f, 5.0f));
				Assert.AreEqual(6.0f - 2.0f, MathF.Sub(6.0f, 2.0f));
				Assert.AreEqual(2.0f - 2.0f, MathF.Sub(2.0f, 2.0f));

				float a = 6.0f;
				float b = 2.0f;
				float c = 6.0f;
				float d = 2.0f;
				Assert.AreEqual(6.0f - 5.0f, MathF.Sub(ref a, 5.0f));
				Assert.AreEqual(2.0f - 5.0f, MathF.Sub(ref b, 5.0f));
				Assert.AreEqual(6.0f - 2.0f, MathF.Sub(ref c, 2.0f));
				Assert.AreEqual(2.0f - 2.0f, MathF.Sub(ref d, 2.0f));
			}

			[Test]
			public void Trunc ()
			{
				Assert.AreEqual(2.0f, MathF.Trunc(2.3f));
				Assert.AreEqual(3.0f, MathF.Trunc(3.8f));
				Assert.AreEqual(5.0f, MathF.Trunc(5.5f));
				Assert.AreEqual(-2.0f, MathF.Trunc(-2.3f));
				Assert.AreEqual(-3.0f, MathF.Trunc(-3.8f));
				Assert.AreEqual(-5.0f, MathF.Trunc(-5.5f));
			}

			[Test]
			public void TruncToInt ()
			{
				Assert.AreEqual(2.0f, MathF.TruncToInt(2.3f));
				Assert.AreEqual(3.0f, MathF.TruncToInt(3.8f));
				Assert.AreEqual(5.0f, MathF.TruncToInt(5.5f));
				Assert.AreEqual(-2.0f, MathF.TruncToInt(-2.3f));
				Assert.AreEqual(-3.0f, MathF.TruncToInt(-3.8f));
				Assert.AreEqual(-5.0f, MathF.TruncToInt(-5.5f));
			}

		#endregion
	}
}