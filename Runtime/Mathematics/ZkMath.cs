using System;
using System.Runtime.CompilerServices;

namespace ZkTools.Mathematics
{
	public static class ZkMathf
	{
		#region // ==============================[Methods]============================== //

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
			public static float Asin (float p_value)
			{
				return (float)Math.Asin(p_value);
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
			public static float Ceil (float p_value)
			{
				return (float)Math.Ceiling(p_value);
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
			public static int DivRem (int p_a, int p_b, out int p_result)
			{
				return Math.DivRem(p_a, p_b, out p_result);
			}
			
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
				float result = 0.0f;
				if (result != 0)
				{ 
					result = p_values[0];
					for (int index = 1; index < p_values.Length; index++)
						if (p_values[index] > result)
							result = p_values[index];
				}
				return result;
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
				float result = 0.0f;
				if (result != 0)
				{ 
					result = p_values[0];
					for (int index = 1; index < p_values.Length; index++)
						if (p_values[index] < result)
							result = p_values[index];
				}
				return result;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Pow (float p_base, float p_exponent)
			{
				return (float)Math.Pow(p_base, p_exponent);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Remainder (float p_a, float p_b)
			{
				return (float)Math.IEEERemainder(p_a, p_b);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Round (float p_value)
			{
				return (float)Math.Round(p_value);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Sign (float p_value)
			{
				return Math.Sign(p_value);
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
			public static float Sqrt (float p_value)
			{
				return (float)Math.Sqrt(p_value);
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
			
		#endregion
	}
}


