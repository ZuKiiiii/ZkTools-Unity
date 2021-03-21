using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	public static class MathF
	{
		#region // ==============================[Static Variables]============================== //

			public const float Cos_One = 5.403023058681397174009366074429766037e-01f;

			public const float Cbrt_Pi = 1.464591887561523263020142527263790391e+00f;
		
			public const float Degree2Gradian = 1.11111111111111111111111111111111111e+00f;

			public const float Degree2Radian = 1.11111111111111111111111111111111111e+00f;
			
			public const float Degree2Turn = 0.00277777777777777777777777777777778e+00f;

			public const float E = 2.718281828459045235360287471352662497e+00f;

			public const float E_Pow_Pi = 2.314069263277926900572908636794854738e+01f;

			public const float E_Pow_Minus_Half = 6.065306597126334236037995349911804534e-01f;

			public const float E_Pow_Minus_One = 3.678794411714423215955237701614608674e-01f;

			public const float Five_Pi_Div_Six = 5.0f * Pi / 6.0f;

			public const float Four_Pi_Div_Three = 4.188790204786390984616857844373f;

			public const float Gradian2Degree = 0.90f;

			public const float Gradian2Radian = 0.015707963267948966192313216916e+00f;

			public const float Gradian2Turn = 0.0025f;

			public const float Half = 5e-01f;

			public const float One_Div_E = E_Pow_Minus_One;
			
			public const float One_Div_Pi = 0.318309886183790671537767526745f;

			public const float One_Div_Sqrt_Pi = 5.641895835477562869480794515607725858e-01f;

			public const float One_Div_Sqrt_Tau = 3.989422804014326779399460599343818684e-01f;
			
			public const float One_Div_Root_Two = 7.071067811865475244008443621048490392e-01f;
			
			public const float Pi = 3.141592653589793238462643383279502884e+00f;

			public const float Pi_Div_Four = 0.78539816339744830961566084582e+00f;

			public const float Pi_Div_Six = 0.5235987755982989e+00f;

			public const float Pi_Div_Three = 1.0471975511965977e+00f;

			public const float Pi_Div_Two = 1.570796326794896619231321691639751442e+00f;

			public const float Pi_Sqr = 9.869604401089358618834490999876151135e+00f;
			
			public const float Radian2Degree = 57.29577951308232286464772187173366546e+00f;

			public const float Radian2Gradian = 63.661977236758134307553505349006e+00f;

			public const float Radian2Turn = 0.159154943091895335768883763373e+00f;

			public const float Sqrt_E = 1.648721270700128146848650787814163571e+00f;

			public const float Sqrt_Pi = 1.772453850905516027298167483341145182e+00f;

			public const float Sqrt_Pi_Div_Two = 1.253314137315500251207882642405522626e+00f;

			public const float Sqrt_Tau = 2.5066282746310002e+00f;

			public const float Sqrt_Three = 1.732050807568877293527446341506e+00f;

			public const float Sqrt_Three_Div_Two = 0.8660254037844386e+00f;

			public const float Sqrt_Two = 1.414213562373095048801688724209698078e+00f;

			public const float Sqrt_Two_Div_Two = 0.7071067811865475e+00f;
			
			public const float Tau = 6.283185307179586476925286766559e+00f;

			public const float Third = 3.333333333333333333333333333333333333e-01f;

			public const float Three_Pi_Div_Four = 2.356194490192344928846982537459627163e+00f;

			public const float Three_Div_Four = 7.500000000000000000000000000000000000e-01f;

			public const float Turn2Degree = 360.0f;

			public const float Turn2Gradian = 400.0f;

			public const float Turn2Radian = Tau;

			public const float Two_Pi_Div_Three = 2.094395102393195492308428922186335256e+00f;

		#endregion

		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Abs (float p_value)
			{
				return Math.Abs(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Acos (float p_value)
			{
				return (float)Math.Acos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcosH (float p_value)
			{
				return Ln(p_value + Sqrt(Square(p_value) - 1.0f));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcotH (float p_value)
			{
				return 0.5f * Ln((1 + p_value) / (p_value - 1));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcscH (float p_value)
			{
				return Ln((1.0f + Sqrt(1.0f + Square(p_value))) / p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AsecH (float p_value)
			{
				return Ln((1.0f + Sqrt(1.0f - Square(p_value))) / p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Asin (float p_value)
			{
				return (float)Math.Asin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AsinH (float p_value)
			{
				return Ln(p_value + Sqrt(Square(p_value) + 1.0f));
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
				return 0.5f * Ln((1.0f + p_value) / (1.0f - p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cbrt (float p_value)
			{
				return Root(p_value, 3);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ceil (float p_value)
			{
				return (float)Math.Ceiling(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int CeilToInt (float p_value)
			{
				return (int)Ceil(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Clamp (float p_value, float p_min = 0.0f, float p_max = 1.0f)
			{
				return Min(Max(p_value, p_min), p_max);
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
			public static float CscH (float p_value)
			{
				return 1.0f / SinH(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cube (float p_value)
			{
				return Square(p_value) * p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void CylindricalToSpherical (float p_cylRho, float p_cylPhi, float p_cylZ, out float p_sphereRadius, out float p_sphereTheta, out float p_spherePhi)
			{
				p_sphereRadius = Sqrt(Square(p_cylRho) + Square(p_cylZ));
				p_sphereTheta = Atan2(p_cylRho, p_cylZ);
				p_spherePhi = p_cylPhi;
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

			// public static float DeltaAngle (float p_current, float p_target;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Exp (float p_value)
			{
				return (float)Math.Exp(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Floor (float p_value)
			{
				return (float)Math.Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int FloorToInt (float p_value)
			{
				return (int)Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Frac (float p_value)
			{
				return p_value - Floor(p_value);
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
			public static float Inv (float p_value)
			{
				return 1.0f / p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerp (float p_a, float p_b, float p_value)
			{
				return (p_value - p_a) / (p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerpClamped (float p_a, float p_b, float p_value, float p_min = 0.0f, float p_max = 1.0f)
			{
				return Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InvSqrt (float p_value)
			{
				return 1.0f / Sqrt(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInside (float p_value, float p_min, float p_max, ERangeType p_type)
			{
				bool result = false;
				switch (p_type)
				{
					case ERangeType.Ex : result = IsInsideEx(p_value, p_min, p_max); break;
					case ERangeType.ExIn : result = IsInsideExIn(p_value, p_min, p_max); break;
					case ERangeType.In : result = IsInsideIn(p_value, p_min, p_max); break;
					case ERangeType.InEx : result = IsInsideInEx(p_value, p_min, p_max); break;
				}
				return result;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInsideIn (float p_value, float p_minInclusiveValue, float p_maxInclusiveValue)
			{
				return p_minInclusiveValue <= p_value && p_value <= p_maxInclusiveValue;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInsideInEx (float p_value, float p_minInclusiveValue, float p_maxExclusiveValue)
			{
				return p_minInclusiveValue <= p_value && p_value < p_maxExclusiveValue;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInsideEx (float p_value, float p_minExclusiveValue, float p_maxExclusiveValue)
			{
				return p_minExclusiveValue < p_value && p_value < p_maxExclusiveValue;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsInsideExIn (float p_value, float p_minExclusiveValue, float p_maxInclusiveValue)
			{
				return p_minExclusiveValue < p_value && p_value <= p_maxInclusiveValue;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (float p_lhs, float p_rhs, float p_tolerance = float.Epsilon)
			{
				return IsNearlyZero(p_lhs - p_rhs, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (float p_value,  float p_tolerance = float.Epsilon)
			{
				return Abs(p_value) <= p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutside (float p_value, float p_min, float p_max, ERangeType p_type)
			{
				bool result = false;
				switch (p_type)
				{
					case ERangeType.Ex : result = IsOutsideEx(p_value, p_min, p_max); break;
					case ERangeType.ExIn : result = IsOutsideExIn(p_value, p_min, p_max); break;
					case ERangeType.In : result = IsOutsideIn(p_value, p_min, p_max); break;
					case ERangeType.InEx : result = IsOutsideInEx(p_value, p_min, p_max); break;
				}
				return result;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutsideEx (float p_value, float p_minExclusiveValue, float p_maxExclusiveValue)
			{
				return p_value < p_minExclusiveValue || p_maxExclusiveValue < p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutsideExIn (float p_value, float p_minExclusiveValue, float p_maxInclusiveValue)
			{
				return p_value < p_minExclusiveValue || p_maxInclusiveValue <= p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutsideIn (float p_value, float p_minInclusiveValue, float p_maxInclusiveValue)
			{
				return p_value <= p_minInclusiveValue || p_maxInclusiveValue <= p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOutsideInEx (float p_value, float p_minInclusiveValue, float p_maxExclusiveValue)
			{
				return p_value <= p_minInclusiveValue || p_maxExclusiveValue < p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (float p_value)
			{
				return p_value == 0.0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Lerp (float p_a, float p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			// public static float LerpAngle () (Unity)

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float LerpClamped (float p_a, float p_b, float p_t)
			{
				return Lerp(p_a, p_b, Clamp(p_t));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ln (float p_value)
			{
				return LogE(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log (float p_value, float p_base)
			{
				return (float)Math.Log(p_value, p_base);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log2 (float p_value)
			{
				return Log(p_value, 2.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log10 (float p_value)
			{
				return (float)Math.Log10(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float LogE (float p_value)
			{
				return (float)Math.Log(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (float p_a, float p_b)
			{
				return Math.Max(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (float p_a, float p_b, float p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (params float[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (float p_a, float p_b)
			{
				return Math.Min(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (float p_a, float p_b, float p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (params float[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Modf (float p_value, out float p_intPart)
			{
				Modf(p_value, out p_intPart, out float fractPart);
				return fractPart;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Modf (float p_value, out int p_intPart)
			{
				Modf(p_value, out p_intPart, out float fractPart);
				return fractPart;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Modf (float p_value, out float p_intPart, out float p_fracPart)
			{
				p_intPart = Floor(p_value);
				p_fracPart = p_value - p_intPart;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Modf (float p_value, out int p_intPart, out float p_fracPart)
			{
				p_intPart = FloorToInt(p_value);
				p_fracPart = p_value - p_intPart;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float MoveTowards (float p_current, float p_target, float p_maxDelta)
			{
				return Abs(p_target - p_current) <=  p_maxDelta ? p_target : p_current + SignPos(p_target - p_current) * p_maxDelta;
			}

			// MoveTowardsAngle

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float PingPong (float p_value, float p_length)
			{
				return p_length - Mathf.Abs(Repeat(p_value, p_length * 2f) - p_length);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Pow (float p_base, float p_exponent)
			{
				return (float)Math.Pow(p_base, p_exponent);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuadraticDelta (float p_a, float p_b, float p_c)
			{
				return Square(p_b) - 4 * p_a * p_c;
			}

			public static float[]  QuadraticEquation (float p_a, float p_b, float p_c)
			{
				float delta = QuadraticDelta(p_a, p_b, p_c);
				switch (Sign(delta))
				{
					case 0 : return new float[] {-p_b / (2 * p_a)};
					case 1:
					{
						float sqrtDelta = Sqrt(delta);
						float a2 = 2 * p_a;
						return new float[] {-p_b -  sqrtDelta / a2, -p_b + sqrtDelta / a2};
					}
				}
				return new float[] {};
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToDegree (float p_radian)
			{
				return p_radian * Radian2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToGradian (float p_radian)
			{
				return p_radian * Radian2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToTurn (float p_radian)
			{
				return p_radian * Radian2Turn;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Remainder (float p_a, float p_b)
			{
				return (float)Math.IEEERemainder(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Remap (float p_value, float p_inMin, float p_inMax, float p_outMin, float p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerp(p_inMin, p_inMax, p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RemapClamped (float p_value, float p_inMin, float p_inMax, float p_outMin, float p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerpClamped(p_inMin, p_inMax, p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Repeat (float p_value, float p_length)
			{
				return Clamp(p_value - Mathf.Floor(p_value / p_length) * p_length, 0.0f, p_length);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Round (float p_value)
			{
				return (float)Math.Round(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int RoundToInt (float p_value)
			{
				return (int)Round(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Root (float p_value, float p_rootExponent)
			{
				return Pow(p_value, 1.0f / p_rootExponent);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Root (float p_value, int p_rootExponent)
			{
				return Pow(p_value, 1.0f / p_rootExponent);
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
			public static int Sign (float p_value)
			{
				return Math.Sign(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SignPos (float p_value)
			{
				return p_value >= 0.0 ? 1f : -1f;
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

			public static float SmoothDamp (float p_current, float p_target, ref float p_currentVelocity, float p_smoothTime, float p_deltaTime, float p_maxSpeed = float.PositiveInfinity)
			{
				p_smoothTime = Max(0.0001F, p_smoothTime);
				float omega = 2F / p_smoothTime;

				float x = omega * p_deltaTime;
				float exp = 1F / (1F + x + 0.479999989271164f * Square(x) + 0.234999999403954f * Cube(x));
				float change = p_current - p_target;
				float originalTo = p_target;

				// Clamp maximum speed
				float maxChange = p_maxSpeed * p_smoothTime;
				change = Clamp(change, -maxChange, maxChange);
				p_target = p_current - change;

				float temp = (p_currentVelocity + omega * change) * p_deltaTime;
				p_currentVelocity = (p_currentVelocity - omega * temp) * exp;
				float output = p_target + ( change + temp ) * exp;

				// Prevent overshooting
				if (originalTo - p_current > 0.0F == output > originalTo) 
				{
					output = originalTo;
					p_currentVelocity = (output - originalTo) / p_deltaTime;
				}

				return output;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void SphericalToCylindrical(float p_sphereRadius, float p_sphereTheta, float p_spherePhi, out float p_cylRho, out float p_cylPhi, out float p_cylZ)
			{
				p_cylRho = p_sphereRadius * Sin(p_sphereTheta);
				p_cylPhi = p_spherePhi;
				p_cylZ = p_sphereRadius * Cos(p_sphereTheta);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sqrt (float p_value)
			{
				return (float)Math.Sqrt(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Square (float p_value)
			{
				return p_value * p_value;
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
			public static float Trunc (float p_value)
			{
				return (float)Math.Truncate(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TruncToInt (float p_value)
			{
				return (int)Trunc(p_value);
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

		#endregion
	}
}