using System;
using System.Runtime.CompilerServices;
using ZkTools.Mathematics.Angles;

namespace ZkTools.Mathematics
{
	/// <summary>
	///
	/// </summary>
	public static class Trigo
	{
		#region // ==============================[Static Variables]============================== //

			public const float CosOne = 5.403023058681397174009366074429766037e-01f;

			public const float CbrtPi = 1.464591887561523263020142527263790391e+00f;

			public const float Degree2Gradian = 200.0f / 180.0f;

			public const float Degree2Radian = Pi /180;

			public const float Degree2Turn = 1.0f / 360f;

			public const float EPowPi = 2.314069263277926900572908636794854738e+01f;

			public const float ElevenPiDivSix =  11.0f * Pi / 6.0f;

			public const float FivePiDivFour = 5.0f * Pi / 4.0f;

			public const float FivePiDivSix = 5.0f * Pi / 6.0f;

			public const float FivePiDivThree = 5.0f * Pi / 3.0f;

			public const float FourPiDivThree = 4.0f * Pi / 3.0f;

			public const float Gradian2Degree = 180f / 200f;

			public const float Gradian2Radian = Pi / 200f;

			public const float Gradian2Turn = 1f / 400f;

			public const float OneDivPi = 1 / Pi;

			public const float OneDivSqrtPi = 5.641895835477562869480794515607725858e-01f;

			public const float OneDivSqrtTau = 3.989422804014326779399460599343818684e-01f;

			public const float Pi = 3.141592653589793238462643383279502884e+00f;

			public const float PiDivFour = Pi / 4.0f;

			public const float PiDivSix = Pi / 6.0f;

			public const float PiDivThree = Pi / 3.0f;

			public const float PiDivTwo = Pi / 2.0f;

			public const float PiSqr = 9.869604401089358618834490999876151135e+00f;

			public const float Radian2Degree = 180f / Pi;

			public const float Radian2Gradian = 200f / Pi;

			public const float Radian2Turn = 1f / Tau;

			public const float SevenPivDivFour = 7f * Pi / 4f;

			public const float SevenPiDivSix = 7f * Pi / 6;

			public const float SqrtPi = 1.772453850905516027298167483341145182e+00f;

			public const float SqrtPiDivTwo = 1.253314137315500251207882642405522626e+00f;

			public const float SqrtTau = 2.5066282746310002e+00f;

			public const float SqrtThreeDivTwo = 0.8660254037844386e+00f;

			public const float SqrtTwoDivTwo = 0.7071067811865475e+00f;

			public const float Tau = 2f * Pi;

			public const float ThreePiDivTwo = 3f * Pi / 2f;

			public const float ThreePiDivFour = 3f * Pi / 4f;

			public const float Turn2Degree = 360.0f;

			public const float Turn2Gradian = 400.0f;

			public const float Turn2Radian = Tau;

			public const float TwoPiDivThree = 2f * Pi / 3f;

		#endregion

		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Acos (float p_value)
			{
				return (float)Math.Acos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcosH (float p_value)
			{
				return MathF.Ln(p_value + MathF.Sqrt(MathF.Square(p_value) - 1.0f));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcotH (float p_value)
			{
				return 0.5f * MathF.Ln((1 + p_value) / (p_value - 1));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcscH (float p_value)
			{
				return MathF.Ln((1.0f + MathF.Sqrt(1.0f + MathF.Square(p_value))) / p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AdjacentFromAngleOpposite (Radian p_angle, float p_opposite)
			{
				return p_opposite / Trigo.Tan(p_angle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AdjacentFromAngleHypotenuse (Radian p_angle, float p_hypotenuse)
			{
				return Trigo.Cos(p_angle) * p_hypotenuse;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AdjacentFromOppositeHypotenuse (float p_opposite, float p_hypotenuse)
			{
				return MathF.Sqrt(MathF.Square(p_hypotenuse) - MathF.Square(p_opposite));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian AngleFromAdjacentHypotenuse (float p_adjacent, float p_hypotenuse)
			{
				return Trigo.Acos(p_adjacent / p_hypotenuse);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian AngleFromAdjacentOpposite (float p_adjacent, float p_opposite)
			{
				return Trigo.Atan(p_opposite / p_adjacent);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian AngleFromOppositeHypotenuse (float p_opposite, float p_hypotenuse)
			{
				return Trigo.Asin(p_opposite / p_hypotenuse);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AsecH (float p_value)
			{
				return MathF.Ln((1.0f + MathF.Sqrt(1.0f - MathF.Square(p_value))) / p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Asin (float p_value)
			{
				return (float)Math.Asin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AsinH (float p_value)
			{
				return MathF.Ln(p_value + MathF.Sqrt(MathF.Square(p_value) + 1.0f));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan (float p_value)
			{
				return (float)Math.Atan(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan2 (float p_y, float p_x)
			{
				return (float)Math.Atan2(p_y, p_x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AtanH (float p_value)
			{
				return 0.5f * MathF.Ln((1.0f + p_value) / (1.0f - p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cos (float p_value)
			{
				return (float)Math.Cos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CosH (float p_value)
			{
				return (float)Math.Cosh(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cot (float p_value)
			{
				return 1.0f / Tan(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CotH (float p_value)
			{
				return 1.0f / TanH(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Csc (float p_value)
			{
				return 1.0f / Sin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cvs (float p_value)
			{
				return 1.0f - Sin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CscH (float p_value)
			{
				return 1.0f / SinH(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DegreeToRadian (float p_degree)
			{
				return p_degree * Degree2Radian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DegreeToGradian (float p_degree)
			{
				return p_degree * Degree2Gradian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DegreeToTurn (float p_degree)
			{
				return p_degree * Degree2Turn;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GradianToDegree (float p_gradian)
			{
				return p_gradian * Gradian2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GradianToRadian (float p_gradian)
			{
				return p_gradian * Gradian2Radian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GradianToTurn (float p_gradian)
			{
				return p_gradian * Gradian2Turn;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float HypotenuseFromAngleAdjacent (Radian p_angle, float p_adjacent)
			{
				return p_adjacent / Trigo.Cos(p_angle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float HypotenuseFromAngleOpposite (Radian p_angle, float p_opposite)
			{
				return p_opposite / Trigo.Sin(p_angle);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float HypotenuseFromOppositeAdjacent (float p_opposite, float p_adjacent)
			{
				return MathF.Sqrt(MathF.Square(p_adjacent) + MathF.Square(p_opposite));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float OppositeFromAdjacentHypotenuse (float p_adjacent, float p_hypotenuse)
			{
				return MathF.Sqrt(MathF.Square(p_hypotenuse) - MathF.Square(p_adjacent));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float OppositeFromAngleAdjacent (Radian p_angle, float p_adjacent)
			{
				return Trigo.Tan(p_angle) * p_adjacent;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float OppositeFromAngleHypotenuse (Radian p_angle, float p_hypotenuse)
			{
				return Trigo.Sin(p_angle) * p_hypotenuse;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToDegree (float p_radian)
			{
				return p_radian * Radian2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToGradian (float p_radian)
			{
				return p_radian * Radian2Gradian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToTurn (float p_radian)
			{
				return p_radian * Radian2Turn;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sec (float p_value)
			{
				return 1.0f / Cos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SecH (float p_value)
			{
				return 1.0f / CosH(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sin (float p_value)
			{
				return (float)Math.Sin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SinH (float p_value)
			{
				return (float)Math.Sinh(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Tan (float p_value)
			{
				return (float)Math.Tan(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TanH (float p_value)
			{
				return (float)Math.Tanh(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TurnToDegree(float p_radian)
			{
				return p_radian * Turn2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TurnToGradian (float p_turn)
			{
				return p_turn * Turn2Gradian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TurnToRadian(float p_radian)
			{
				return p_radian * Turn2Radian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ver (float p_value)
			{
				return 1.0f - Cos(p_value);
			}

		#endregion
	}
}