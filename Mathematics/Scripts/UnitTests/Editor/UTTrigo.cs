using NUnit.Framework;
using ZkTools.Mathematics.Angles.Extensions;

namespace ZkTools.Mathematics.UnitTests.Editor
{
	internal class UTTrigo
	{
		#region ==============================[Static Variables]==============================

			private const float delta = 1e-4f;

		#endregion

		#region ==============================[Methods]==============================

			[Test]
			public void Acos ()
			{
				Assert.AreEqual(float.NaN, Trigo.Acos(-2.0f), delta);
				Assert.AreEqual(float.NaN, Trigo.Acos(-1.5f), delta);
				Assert.AreEqual(2.094395102393f, Trigo.Acos(-0.5f), delta);
				Assert.AreEqual(1.570796326795f, Trigo.Acos(0.0f), delta);
				Assert.AreEqual(1.047197551197f, Trigo.Acos(0.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.Acos(1.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.Acos(2.0f), delta);
			}

			[Test]
			public void AcosH ()
			{
				Assert.AreEqual(float.NaN, Trigo.AcosH(0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.AcosH(1.0f), delta);
				Assert.AreEqual(0.962423650119f, Trigo.AcosH(1.5f), delta);
				Assert.AreEqual(1.316957896925f, Trigo.AcosH(2.0f), delta);
				Assert.AreEqual(1.566799236972f, Trigo.AcosH(2.5f), delta);
				Assert.AreEqual(1.762747174039f, Trigo.AcosH(3.0f), delta);
			}

			[Test]
			public void AcotH ()
			{
				Assert.AreEqual(-0.549306144334f, Trigo.AcotH(-2.0f), delta);
				Assert.AreEqual(-0.804718956217f, Trigo.AcotH(-1.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.AcotH(-0.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.AcotH(0.0f), delta);
				Assert.AreEqual(float.NaN, Trigo.AcotH(0.5f), delta);
				Assert.AreEqual(0.804718956217f, Trigo.AcotH(1.5f), delta);
				Assert.AreEqual(0.549306144334f, Trigo.AcotH(2.0f), delta);
			}

			[Test]
			public void AcscH ()
			{
				Assert.AreEqual(-0.48121182506f, Trigo.AcscH(-2.0f), delta);
				Assert.AreEqual(-0.62514511725f, Trigo.AcscH(-1.5f), delta);
				Assert.AreEqual(-1.443635475179f, Trigo.AcscH(-0.5f), delta);
				Assert.AreEqual(float.PositiveInfinity, Trigo.AcscH(0.0f), delta);
				Assert.AreEqual(1.443635475179f, Trigo.AcscH(0.5f), delta);
				Assert.AreEqual(0.62514511725f, Trigo.AcscH(1.5f), delta);
				Assert.AreEqual(0.48121182506f, Trigo.AcscH(2.0f), delta);
			}

			[Test]
			public void AdjacentFromAngleOpposite ()
			{
				Assert.AreEqual(5.0f, Trigo.AdjacentFromAngleOpposite(38.6598082541f.ToDegree(), 4.0f), delta);
				Assert.AreEqual(4.0f, Trigo.AdjacentFromAngleOpposite(51.3401917459f.ToDegree(), 5.0f), delta);
			}

			[Test]
			public void AdjacentFromAngleHypotenuse ()
			{
				Assert.AreEqual(5.0f, Trigo.AdjacentFromAngleHypotenuse(38.6598082541f.ToDegree(), 6.4031242374f), delta);
				Assert.AreEqual(4.0f, Trigo.AdjacentFromAngleHypotenuse(51.3401917459f.ToDegree(), 6.4031242374f), delta);
			}

			[Test]
			public void AdjacentFromOppositeHypotenuse ()
			{
				Assert.AreEqual(5.0f, Trigo.AdjacentFromOppositeHypotenuse(4.0f, 6.4031242374f), delta);
				Assert.AreEqual(4.0f, Trigo.AdjacentFromOppositeHypotenuse(5.0f.ToDegree(), 6.4031242374f), delta);
			}

			[Test]
			public void AngleFromAdjacentHypotenuse ()
			{
				Assert.AreEqual(Trigo.DegreeToRadian(38.6598082541f), Trigo.AngleFromAdjacentHypotenuse(5.0f, 6.4031242374f), delta);
				Assert.AreEqual(Trigo.DegreeToRadian(51.3401917459f), Trigo.AngleFromAdjacentHypotenuse(4.0f, 6.4031242374f), delta);
			}

			[Test]
			public void AngleFromAdjacentOpposite ()
			{
				Assert.AreEqual(Trigo.DegreeToRadian(38.6598082541f), Trigo.AngleFromAdjacentOpposite(5.0f, 4.0f), delta);
				Assert.AreEqual(Trigo.DegreeToRadian(51.3401917459f), Trigo.AngleFromAdjacentOpposite(4.0f, 5.0f), delta);
			}

			[Test]
			public void AngleFromOppositeHypotenuse ()
			{
				Assert.AreEqual(Trigo.DegreeToRadian(38.6598082541f), Trigo.AngleFromOppositeHypotenuse(4.0f, 6.4031242374f), delta);
				Assert.AreEqual(Trigo.DegreeToRadian(51.3401917459f), Trigo.AngleFromOppositeHypotenuse(5.0f, 6.4031242374f), delta);
			}

			[Test]
			public void AsecH ()
			{
				Assert.AreEqual(float.NaN, Trigo.AsecH(-2.0f), delta);
				Assert.AreEqual(float.NaN, Trigo.AsecH(-1.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.AsecH(-0.5f), delta);
				Assert.AreEqual(float.PositiveInfinity, Trigo.AsecH(0.0f), delta);
				Assert.AreEqual(1.316957896925f, Trigo.AsecH(0.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.AsecH(1.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.AsecH(2.0f), delta);
			}

			[Test]
			public void Asin ()
			{
				Assert.AreEqual(float.NaN, Trigo.Asin(-2.0f), delta);
				Assert.AreEqual(float.NaN, Trigo.Asin(-1.5f), delta);
				Assert.AreEqual(-0.523598775598f, Trigo.Asin(-0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.Asin(0.0f), delta);
				Assert.AreEqual(0.523598775598f, Trigo.Asin(0.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.Asin(1.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.Asin(2.0f), delta);
			}

			[Test]
			public void AsinH ()
			{
				Assert.AreEqual(-1.443635475179f, Trigo.AsinH(-2.0f), delta);
				Assert.AreEqual(-1.194763217287f, Trigo.AsinH(-1.5f), delta);
				Assert.AreEqual(-0.48121182506f, Trigo.AsinH(-0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.AsinH(0.0f), delta);
				Assert.AreEqual(0.48121182506f, Trigo.AsinH(0.5f), delta);
				Assert.AreEqual(1.194763217287f, Trigo.AsinH(1.5f), delta);
				Assert.AreEqual(1.443635475179f, Trigo.AsinH(2.0f), delta);
			}

			[Test]
			public void Atan ()
			{
				Assert.AreEqual(-1.107148717794, Trigo.Atan(-2.0f), delta);
				Assert.AreEqual(-0.982793723247f, Trigo.Atan(-1.5f), delta);
				Assert.AreEqual(-0.463647609001f, Trigo.Atan(-0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.Atan(0.0f), delta);
				Assert.AreEqual(0.463647609001f, Trigo.Atan(0.5f), delta);
				Assert.AreEqual(0.982793723247f, Trigo.Atan(1.5f), delta);
				Assert.AreEqual(1.107148717794f, Trigo.Atan(2.0f), delta);
			}

			[Test]
			public void Atan2 ()
			{
				Assert.AreEqual(2.6779450445889870f,Trigo.Atan2(1.0f, -2.0f), delta);
				Assert.AreEqual(2.0344439357957027f,Trigo.Atan2(1.0f, -0.5f), delta);
				Assert.AreEqual(1.5707963267948966f,Trigo.Atan2(1.0f, 0.0f), delta);
				Assert.AreEqual(1.1071487177940904f,Trigo.Atan2(1.0f, 0.5f), delta);
				Assert.AreEqual(0.4636476090008061f,Trigo.Atan2(1.0f, 2.0f), delta);

				Assert.AreEqual(Trigo.Pi,Trigo.Atan2(0.0f, -1.0f), delta);
				Assert.AreEqual(0.0f,Trigo.Atan2(0.0f, 0.0f), delta);
				Assert.AreEqual(0.0f,Trigo.Atan2(0.0f, 1.0f), delta);

			}

			[Test]
			public void AtanH ()
			{
				Assert.AreEqual(float.NaN, Trigo.AtanH(-2.0f), delta);
				Assert.AreEqual(float.NaN, Trigo.AtanH(-1.5f), delta);
				Assert.AreEqual(-0.549306144334f, Trigo.AtanH(-0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.AtanH(0.0f), delta);
				Assert.AreEqual(0.549306144334f, Trigo.AtanH(0.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.AtanH(1.5f), delta);
				Assert.AreEqual(float.NaN, Trigo.AtanH(2.0f), delta);
			}

			[Test]
			public void Constant ()
			{
				Assert.AreEqual(Trigo.Cos(1.0f), Trigo.CosOne, delta);
				Assert.AreEqual(MathF.Cbrt(Trigo.Pi), Trigo.CbrtPi, delta);
				Assert.AreEqual(200f / 180.0f, Trigo.Degree2Gradian, delta);
				Assert.AreEqual(Trigo.Pi / 180.0f, Trigo.Degree2Radian, delta);
				Assert.AreEqual(1.0f / 360.0f, Trigo.Degree2Turn, delta);
				Assert.AreEqual(MathF.Pow(MathF.E, Trigo.Pi), Trigo.EPowPi, delta);
				Assert.AreEqual(11.0f * Trigo.Pi / 6.0f, Trigo.ElevenPiDivSix, delta);
				Assert.AreEqual(5.0f * Trigo.Pi / 4.0f, Trigo.FivePiDivFour, delta);
				Assert.AreEqual(5.0f * Trigo.Pi / 6.0f, Trigo.FivePiDivSix, delta);;
				Assert.AreEqual(5.0f * Trigo.Pi / 3.0f, Trigo.FivePiDivThree, delta);
				Assert.AreEqual(4.0f * Trigo.Pi / 3.0f, Trigo.FourPiDivThree, delta);
				Assert.AreEqual(180f / 200f, Trigo.Gradian2Degree, delta);
				Assert.AreEqual(Trigo.Pi / 200f, Trigo.Gradian2Radian, delta);
				Assert.AreEqual(1f / 400f, Trigo.Gradian2Turn, delta);
				Assert.AreEqual(1.0f / Trigo.Pi, Trigo.OneDivPi, delta);
				Assert.AreEqual(1.0f / MathF.Sqrt(Trigo.Pi), Trigo.OneDivSqrtPi, delta);
				Assert.AreEqual(1.0f / MathF.Sqrt(Trigo.Tau), Trigo.OneDivSqrtTau, delta);
				Assert.AreEqual(Trigo.Tau / 2f, Trigo.Pi, delta);
				Assert.AreEqual(Trigo.Pi / 4.0f, Trigo.PiDivFour, delta);
				Assert.AreEqual(Trigo.Pi / 6.0f, Trigo.PiDivSix, delta);
				Assert.AreEqual(Trigo.Pi / 3.0f, Trigo.PiDivThree, delta);
				Assert.AreEqual(Trigo.Pi / 2.0f, Trigo.PiDivTwo, delta);
				Assert.AreEqual(MathF.Square(Trigo.Pi), Trigo.PiSqr, delta);
				Assert.AreEqual(180f / Trigo.Pi, Trigo.Radian2Degree, delta);
				Assert.AreEqual(200f / Trigo.Pi, Trigo.Radian2Gradian, delta);
				Assert.AreEqual(1.0f / Trigo.Tau, Trigo.Radian2Turn, delta);
				Assert.AreEqual(7.0f * Trigo.Pi / 4.0f, Trigo.SevenPivDivFour, delta);
				Assert.AreEqual(7.0f * Trigo.Pi / 6.0f, Trigo.SevenPiDivSix, delta);
				Assert.AreEqual(MathF.Sqrt(Trigo.Pi), Trigo.SqrtPi, delta);
				Assert.AreEqual(MathF.Sqrt(Trigo.Pi / 2.0f), Trigo.SqrtPiDivTwo, delta);
				Assert.AreEqual(MathF.Sqrt(Trigo.Tau), Trigo.SqrtTau, delta);
				Assert.AreEqual(MathF.Sqrt(3.0f) / 2.0f, Trigo.SqrtThreeDivTwo, delta);
				Assert.AreEqual(MathF.Sqrt(2.0f) / 2.0f, Trigo.SqrtTwoDivTwo, delta);
				Assert.AreEqual(Trigo.Pi * 2.0f, Trigo.Tau, delta);
				Assert.AreEqual(3.0 * Trigo.Pi / 2.0f, Trigo.ThreePiDivTwo, delta);
				Assert.AreEqual(3.0 * Trigo.Pi / 4.0f, Trigo.ThreePiDivFour, delta);
				Assert.AreEqual(360.0f, Trigo.Turn2Degree, delta);
				Assert.AreEqual(400.0f, Trigo.Turn2Gradian, delta);
				Assert.AreEqual(Trigo.Tau, Trigo.Turn2Radian, delta);
				Assert.AreEqual(2.0f * Trigo.Pi / 3.0f, Trigo.TwoPiDivThree, delta);
			}

			[Test]
			public void Cos ()
			{
				Assert.AreEqual(-0.416146836547f, Trigo.Cos(-2.0f), delta);
				Assert.AreEqual(0.070737201668, Trigo.Cos(-1.5f), delta);
				Assert.AreEqual(0.87758256189, Trigo.Cos(-0.5f), delta);
				Assert.AreEqual(1.0f, Trigo.Cos(0.0f), delta);
				Assert.AreEqual(0.87758256189, Trigo.Cos(0.5f), delta);
				Assert.AreEqual(0.070737201668f, Trigo.Cos(1.5f), delta);
				Assert.AreEqual(-.416146836547f, Trigo.Cos(2.0f), delta);
			}

			[Test]
			public void CosH ()
			{
				Assert.AreEqual(3.762195691084f, Trigo.CosH(-2.0f), delta);
				Assert.AreEqual(2.352409615243f, Trigo.CosH(-1.5f), delta);
				Assert.AreEqual(1.127625965206f, Trigo.CosH(-0.5f), delta);
				Assert.AreEqual(1.0f, Trigo.CosH(0.0f), delta);
				Assert.AreEqual(1.127625965206f, Trigo.CosH(0.5f), delta);
				Assert.AreEqual(2.352409615243f, Trigo.CosH(1.5f), delta);
				Assert.AreEqual(3.762195691084f, Trigo.CosH(2.0f), delta);
			}

			[Test]
			public void Cot ()
			{
				Assert.AreEqual(0.45765755436f, Trigo.Cot(-2.0f), delta);
				Assert.AreEqual(-0.070914844303f, Trigo.Cot(-1.5f), delta);
				Assert.AreEqual(-1.830487721712f, Trigo.Cot(-0.5f), delta);
				Assert.AreEqual(float.PositiveInfinity, Trigo.Cot(0.0f), delta);
				Assert.AreEqual(1.830487721712f, Trigo.Cot(0.5f), delta);
				Assert.AreEqual(0.070914844303f, Trigo.Cot(1.5f), delta);
				Assert.AreEqual(-0.45765755436f, Trigo.Cot(2.0f), delta);
			}

			[Test]
			public void CotH ()
			{
				Assert.AreEqual(-1.037314720728f, Trigo.CotH(-2.0f), delta);
				Assert.AreEqual(-1.104791392983f, Trigo.CotH(-1.5f), delta);
				Assert.AreEqual(-2.163953413739f, Trigo.CotH(-0.5f), delta);
				Assert.AreEqual(float.PositiveInfinity, Trigo.CotH(0.0f), delta);
				Assert.AreEqual(2.163953413739f, Trigo.CotH(0.5f), delta);
				Assert.AreEqual(1.104791392983f, Trigo.CotH(1.5f), delta);
				Assert.AreEqual(1.037314720728f, Trigo.CotH(2.0f), delta);
			}

			[Test]
			public void Csc ()
			{
				Assert.AreEqual(-1.099750170295, Trigo.Csc(-2.0f), delta);
				Assert.AreEqual(-1.002511304247, Trigo.Csc(-1.5f), delta);
				Assert.AreEqual(-2.085829642933f, Trigo.Csc(-0.5f), delta);
				Assert.AreEqual(float.PositiveInfinity, Trigo.Csc(0.0f), delta);
				Assert.AreEqual(2.085829642933f, Trigo.Csc(0.5f), delta);
				Assert.AreEqual(1.002511304247, Trigo.Csc(1.5f), delta);
				Assert.AreEqual(1.099750170295, Trigo.Csc(2.0f), delta);
			}

			[Test]
			public void Cvs ()
			{
				Assert.AreEqual(1.0f - Trigo.Sin(-2.0f), Trigo.Cvs(-2.0f), delta);
				Assert.AreEqual(1.0f - Trigo.Sin(-1.5f), Trigo.Cvs(-1.5f), delta);
				Assert.AreEqual(1.0f - Trigo.Sin(-0.5f), Trigo.Cvs(-0.5f), delta);
				Assert.AreEqual(1.0f - Trigo.Sin(0.0f), Trigo.Cvs(0.0f), delta);
				Assert.AreEqual(1.0f - Trigo.Sin(0.5f), Trigo.Cvs(0.5f), delta);
				Assert.AreEqual(1.0f - Trigo.Sin(1.5f), Trigo.Cvs(1.5f), delta);
				Assert.AreEqual(1.0f - Trigo.Sin(2.0f), Trigo.Cvs(2.0f), delta);
			}

			[Test]
			public void CscH ()
			{
				Assert.AreEqual(-0.275720564772f, Trigo.CscH(-2.0f), delta);
				Assert.AreEqual(-0.469642440595f, Trigo.CscH(-1.5f), delta);
				Assert.AreEqual(-1.919034751335f, Trigo.CscH(-0.5f), delta);
				Assert.AreEqual(float.PositiveInfinity, Trigo.CscH(0.0f), delta);
				Assert.AreEqual(1.919034751335f, Trigo.CscH(0.5f), delta);
				Assert.AreEqual(0.469642440595f, Trigo.CscH(1.5f), delta);
				Assert.AreEqual(0.275720564772f, Trigo.CscH(2.0f), delta);
			}

			[Test]
			public void DegreeToRadian ()
			{
				Assert.AreEqual(1.0f, Trigo.DegreeToRadian(57.295779516f),  delta);
				Assert.AreEqual(12.0f, Trigo.DegreeToRadian(687.5493541766f), delta);
				Assert.AreEqual(1.5893f, Trigo.DegreeToRadian(91.0601823827f), delta);
			}

			[Test]
			public void DegreeToGradian ()
			{
				Assert.AreEqual(63.66197724f, Trigo.DegreeToGradian(57.295779516f),  delta);
				Assert.AreEqual(763.9437268629f, Trigo.DegreeToGradian(687.5493541766f), delta);
				Assert.AreEqual(101.1779804252f, Trigo.DegreeToGradian(91.0601823827f), delta);
			}

			[Test]
			public void DegreeToTurn ()
			{
				Assert.AreEqual(0.1591549431f, Trigo.DegreeToTurn(57.295779516f),  delta);
				Assert.AreEqual(1.9098593172f, Trigo.DegreeToTurn(687.5493541766f), delta);
				Assert.AreEqual(0.2529449511f, Trigo.DegreeToTurn(91.0601823827f), delta);
			}

			[Test]
			public void GradianToDegree ()
			{
				Assert.AreEqual(57.295779516f, Trigo.GradianToDegree(63.66197724f),  delta);
				Assert.AreEqual(687.5493541766f, Trigo.GradianToDegree(763.9437268629f), delta);
				Assert.AreEqual(91.0601823827f, Trigo.GradianToDegree(101.1779804252f), delta);
			}

			[Test]
			public void GradianToRadian ()
			{
				Assert.AreEqual(1.0f, Trigo.GradianToRadian(63.66197724f),  delta);
				Assert.AreEqual(12.0f, Trigo.GradianToRadian(763.9437268629f), delta);
				Assert.AreEqual(1.5893f, Trigo.GradianToRadian(101.1779804252f), delta);
			}

			[Test]
			public void GradianToTurn ()
			{
				Assert.AreEqual(0.1591549431f, Trigo.GradianToTurn(63.66197724f),  delta);
				Assert.AreEqual(1.9098593172f, Trigo.GradianToTurn(763.9437268629f), delta);
				Assert.AreEqual(0.2529449511f, Trigo.GradianToTurn(101.1779804252f), delta);
			}

			[Test]
			public void HypotenuseFromAngleAdjacent ()
			{
				Assert.AreEqual(6.4031242374f, Trigo.HypotenuseFromAngleAdjacent(38.6598082541f.ToDegree(), 5.0f), delta);
				Assert.AreEqual(6.4031242374f, Trigo.HypotenuseFromAngleAdjacent(51.3401917459f.ToDegree(), 4.0f), delta);
			}

			[Test]
			public void HypotenuseFromAngleOpposite ()
			{
				Assert.AreEqual(6.4031242374f, Trigo.HypotenuseFromAngleOpposite(51.3401917459f.ToDegree(), 5.0f), delta);
				Assert.AreEqual(6.4031242374f, Trigo.HypotenuseFromAngleOpposite(38.6598082541f.ToDegree(), 4.0f), delta);

			}

			[Test]
			public void HypotenuseFromOppositeAdjacent ()
			{
				Assert.AreEqual(6.4031242374f, Trigo.HypotenuseFromOppositeAdjacent(5.0f, 4.0f), delta);
				Assert.AreEqual(6.4031242374f, Trigo.HypotenuseFromOppositeAdjacent(4.0f, 5.0f), delta);
			}

			[Test]
			public void OppositeFromAdjacentHypotenuse ()
			{
				Assert.AreEqual(5.0f, Trigo.OppositeFromAdjacentHypotenuse(4.0f, 6.4031242374f), delta);
				Assert.AreEqual(4.0f, Trigo.OppositeFromAdjacentHypotenuse(5.0f, 6.4031242374f), delta);
			}

			[Test]
			public void OppositeFromAngleAdjacent ()
			{
				Assert.AreEqual(5.0f, Trigo.OppositeFromAngleAdjacent(51.3401917459f.ToDegree(), 4.0f), delta);
				Assert.AreEqual(4.0f, Trigo.OppositeFromAngleAdjacent(38.6598082541f.ToDegree(), 5.0f), delta);
			}

			[Test]
			public void OppositeFromAngleHypotenuse ()
			{
				Assert.AreEqual(5.0f, Trigo.OppositeFromAngleHypotenuse(51.3401917459f.ToDegree(), 6.4031242374f), delta);
				Assert.AreEqual(4.0f, Trigo.OppositeFromAngleHypotenuse(38.6598082541f.ToDegree(), 6.4031242374f), delta);
			}

			[Test]
			public void RadianToDegree ()
			{
				Assert.AreEqual(57.295779516f, Trigo.RadianToDegree(1.0f), delta);
				Assert.AreEqual(687.5493541766f, Trigo.RadianToDegree(12f), delta);
				Assert.AreEqual(91.0601823827f, Trigo.RadianToDegree(1.5893f), delta);
			}

			[Test]
			public void RadianToGradian ()
			{
				Assert.AreEqual(63.66197724f, Trigo.RadianToGradian(1.0f), delta);
				Assert.AreEqual(763.9437268629f, Trigo.RadianToGradian(12f), delta);
				Assert.AreEqual(101.1779804252f, Trigo.RadianToGradian(1.5893f), delta);
			}

			[Test]
			public void RadianToTurn ()
			{
				Assert.AreEqual(0.1591549431f, Trigo.RadianToTurn(1.0f), delta);
				Assert.AreEqual(1.9098593172f, Trigo.RadianToTurn(12f), delta);
				Assert.AreEqual(0.2529449511f, Trigo.RadianToTurn(1.5893f), delta);
			}

			[Test]
			public void Sec ()
			{
				Assert.AreEqual(-2.402997961722f, Trigo.Sec(-2.0f), delta);
				Assert.AreEqual(14.13683290297, Trigo.Sec(-1.5f), delta);
				Assert.AreEqual(1.139493927325, Trigo.Sec(-0.5f), delta);
				Assert.AreEqual(1, Trigo.Sec(0.0f), delta);
				Assert.AreEqual(1.139493927325, Trigo.Sec(0.5f), delta);
				Assert.AreEqual(14.13683290297, Trigo.Sec(1.5f), delta);
				Assert.AreEqual(-2.402997961722f, Trigo.Sec(2.0f), delta);
			}

			[Test]
			public void SecH ()
			{
				Assert.AreEqual(0.265802228834f, Trigo.SecH(-2.0f), delta);
				Assert.AreEqual(0.425096034942, Trigo.SecH(-1.5f), delta);
				Assert.AreEqual(0.88681888397f, Trigo.SecH(-0.5f), delta);
				Assert.AreEqual(1.0f, Trigo.SecH(0.0f), delta);
				Assert.AreEqual(0.88681888397, Trigo.SecH(0.5f), delta);
				Assert.AreEqual(0.425096034942f, Trigo.SecH(1.5f), delta);
				Assert.AreEqual(0.265802228834f, Trigo.SecH(2.0f), delta);
			}

			[Test]
			public void Sin ()
			{
				Assert.AreEqual(-0.909297426826f, Trigo.Sin(-2.0f), delta);
				Assert.AreEqual(-0.997494986604f, Trigo.Sin(-1.5f), delta);
				Assert.AreEqual(-0.479425538604f, Trigo.Sin(-0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.Sin(0.0f), delta);
				Assert.AreEqual(0.479425538604f, Trigo.Sin(0.5f), delta);
				Assert.AreEqual(0.997494986604f, Trigo.Sin(1.5f), delta);
				Assert.AreEqual(0.909297426826f, Trigo.Sin(2.0f), delta);
			}

			[Test]
			public void SinH ()
			{
				Assert.AreEqual(-3.626860407847f, Trigo.SinH(-2.0f), delta);
				Assert.AreEqual(-2.129279455095f, Trigo.SinH(-1.5f), delta);
				Assert.AreEqual(-0.521095305494f, Trigo.SinH(-0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.SinH(0.0f), delta);
				Assert.AreEqual(0.521095305494f, Trigo.SinH(0.5f), delta);
				Assert.AreEqual(2.129279455095f, Trigo.SinH(1.5f), delta);
				Assert.AreEqual(3.626860407847f, Trigo.SinH(2.0f), delta);
			}

			[Test]
			public void Tan ()
			{
				Assert.AreEqual(2.185039863262f, Trigo.Tan(-2.0f), delta);
				Assert.AreEqual(-14.101419947172f, Trigo.Tan(-1.5f), delta);
				Assert.AreEqual(-0.546302489844f, Trigo.Tan(-0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.Tan(0.0f), delta);
				Assert.AreEqual(0.546302489844f, Trigo.Tan(0.5f), delta);
				Assert.AreEqual(14.101419947172f, Trigo.Tan(1.5f), delta);
				Assert.AreEqual(-2.185039863262f, Trigo.Tan(2.0f), delta);
			}

			[Test]
			public void TanH ()
			{
				Assert.AreEqual(-0.964027580076f, Trigo.TanH(-2.0f), delta);
				Assert.AreEqual(-0.905148253645f, Trigo.TanH(-1.5f), delta);
				Assert.AreEqual(-0.46211715726f, Trigo.TanH(-0.5f), delta);
				Assert.AreEqual(0.0f, Trigo.SinH(0.0f), delta);
				Assert.AreEqual(0.46211715726f, Trigo.TanH(0.5f), delta);
				Assert.AreEqual(0.905148253645f, Trigo.TanH(1.5f), delta);
				Assert.AreEqual(0.964027580076f, Trigo.TanH(2.0f), delta);
			}

			[Test]
			public void TurnToDegree ()
			{
				Assert.AreEqual(57.295779516f, Trigo.TurnToDegree(0.1591549431f), delta);
				Assert.AreEqual(687.5493541766f, Trigo.TurnToDegree(1.9098593172f), delta);
				Assert.AreEqual(91.0601823827f, Trigo.TurnToDegree(0.2529449511f), delta);
			}

			[Test]
			public void TurnToGradian ()
			{
				Assert.AreEqual(63.66197724f, Trigo.TurnToGradian(0.1591549431f), delta);
				Assert.AreEqual(763.9437268629f, Trigo.TurnToGradian(1.9098593172f), delta);
				Assert.AreEqual(101.1779804252f, Trigo.TurnToGradian(0.2529449511f), delta);
			}

			[Test]
			public void TurnToRadian ()
			{
				Assert.AreEqual(1.0f, Trigo.TurnToRadian(0.1591549431f), delta);
				Assert.AreEqual(12.0f, Trigo.TurnToRadian(1.9098593172f), delta);
				Assert.AreEqual(1.5893f, Trigo.TurnToRadian(0.2529449511f), delta);
			}

			[Test]
			public void Ver ()
			{
				Assert.AreEqual(1.0f - Trigo.Cos(-2.0f), Trigo.Ver(-2.0f), delta);
				Assert.AreEqual(1.0f - Trigo.Cos(-1.5f), Trigo.Ver(-1.5f), delta);
				Assert.AreEqual(1.0f - Trigo.Cos(-0.5f), Trigo.Ver(-0.5f), delta);
				Assert.AreEqual(1.0f - Trigo.Cos(0.0f), Trigo.Ver(0.0f), delta);
				Assert.AreEqual(1.0f - Trigo.Cos(0.5f), Trigo.Ver(0.5f), delta);
				Assert.AreEqual(1.0f - Trigo.Cos(1.5f), Trigo.Ver(1.5f), delta);
				Assert.AreEqual(1.0f - Trigo.Cos(2.0f), Trigo.Ver(2.0f), delta);
			}

		#endregion
	}
}