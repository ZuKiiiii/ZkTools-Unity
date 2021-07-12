using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Extensions
{
	public static class ColorX
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Add (Color p_lhs, Color p_rhs)
			{
				return p_lhs + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Add (ref Color p_lhs, Color p_rhs)
			{
				p_lhs += p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Add (Color p_lhs, float p_rhs)
			{
				return p_lhs + Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Add (ref Color p_lhs, float p_rhs)
			{
				p_lhs += Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Add (float p_lhs, Color p_rhs)
			{
				return Replicate(p_lhs) + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Div (Color p_lhs, Color p_rhs)
			{
				return new Color(p_lhs.r / p_rhs.r, p_lhs.g / p_rhs.g, p_lhs.b / p_rhs.b, p_lhs.a / p_rhs.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Div (ref Color p_lhs, Color p_rhs)
			{
				p_lhs = Div(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Div (Color p_lhs, float p_rhs)
			{
				return p_lhs / p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Div (ref Color p_lhs, float p_rhs)
			{
				p_lhs /= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivA (Color p_lhs, float p_rhs)
			{
				return new Color(p_lhs.r, p_lhs.g, p_lhs.b, p_lhs.a / p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivA (ref Color p_lhs, float p_rhs)
			{
				p_lhs.a /= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivA (float p_lhs, Color p_rhs)
			{
				return new Color(p_rhs.r, p_rhs.g, p_rhs.b, p_rhs.a / p_lhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivRGB (Color p_lhs, float p_rhs)
			{
				return new Color(p_lhs.r / p_rhs, p_lhs.g / p_rhs, p_lhs.b / p_rhs, p_lhs.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivRGB (Color p_lhs, Color p_rhs)
			{
				return new Color(p_lhs.r / p_rhs.r, p_lhs.g / p_rhs.g, p_lhs.b / p_rhs.b, p_lhs.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivRGB (ref Color p_lhs, float p_rhs)
			{
				p_lhs.r /= p_rhs;
				p_lhs.g /= p_rhs;
				p_lhs.b /= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivRGB (ref Color p_lhs, Color p_rhs)
			{
				p_lhs.r /= p_rhs.r;
				p_lhs.g /= p_rhs.g;
				p_lhs.b /= p_rhs.b;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivRGB (float p_lhs, Color p_rhs)
			{
				return DivRGB(p_rhs, p_lhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafe (Color p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafe (ref Color p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafe (Color p_dividend, float p_divisor, Color p_defaultValue)
			{
				return p_divisor.IsZero() ? p_defaultValue : p_dividend / p_divisor;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafe (ref Color p_dividend, float p_divisor, Color p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafe (Color p_dividend, Color p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafe (ref Color p_dividend, Color p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafe (Color p_dividend, Color p_divisor, Color p_defaultValue)
			{
				return new Color
				(
					MathF.DivSafe(p_dividend.r, p_divisor.r, p_defaultValue.r),
					MathF.DivSafe(p_dividend.g, p_divisor.g, p_defaultValue.g),
					MathF.DivSafe(p_dividend.b, p_divisor.b, p_defaultValue.b),
					MathF.DivSafe(p_dividend.a, p_divisor.a, p_defaultValue.a)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafe (ref Color p_dividend, Color p_divisor, Color p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafeA (Color p_lhs, float p_rhs)
			{
				return new Color(p_lhs.r, p_lhs.g, p_lhs.b, MathF.DivSafe(p_lhs.a, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafeA (ref Color p_lhs, float p_rhs)
			{
				p_lhs.a = MathF.DivSafe(p_lhs.a, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafeA (float p_lhs, Color p_rhs)
			{
				return DivSafeA(p_rhs, p_lhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafeRGB (Color p_lhs, float p_rhs)
			{
				return new Color(MathF.DivSafe(p_lhs.r, p_rhs), MathF.DivSafe(p_lhs.g, p_rhs), MathF.DivSafe(p_lhs.b, p_rhs), p_lhs.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafeRGB (Color p_lhs, Color p_rhs)
			{
				return new Color(MathF.DivSafe(p_lhs.r, p_rhs.r), MathF.DivSafe(p_lhs.g, p_rhs.g), MathF.DivSafe(p_lhs.b, p_rhs.b), p_lhs.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafeRGB (ref Color p_lhs, float p_rhs)
			{
				p_lhs.r = MathF.DivSafe(p_lhs.r, p_rhs);
				p_lhs.g = MathF.DivSafe(p_lhs.g, p_rhs);
				p_lhs.b = MathF.DivSafe(p_lhs.b, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafeRGB (ref Color p_lhs, Color p_rhs)
			{
				p_lhs.r = MathF.DivSafe(p_lhs.r, p_rhs.r);
				p_lhs.g = MathF.DivSafe(p_lhs.g, p_rhs.g);
				p_lhs.b = MathF.DivSafe(p_lhs.b, p_rhs.b);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color DivSafeRGB (float p_lhs, Color p_rhs)
			{
				return DivSafeRGB(p_rhs, p_lhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Floor (Color p_vector)
			{
				return new Color(MathF.Floor(p_vector.r), MathF.Floor(p_vector.g), MathF.Floor(p_vector.b), MathF.Floor(p_vector.a));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Frac (Color p_value)
			{
				return p_value - Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color InverseLerp (Color p_a, Color p_b, Color p_value)
			{
				return Div(p_value - p_a, p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Lerp (Color p_a, Color p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Lerp (Color p_a, Color p_b, Color p_t)
			{
				return new Color(MathF.Lerp(p_a.r, p_b.r, p_t.r), MathF.Lerp(p_a.g, p_b.g, p_t.g), MathF.Lerp(p_a.b, p_b.b, p_t.b), MathF.Lerp(p_a.a, p_b.a, p_t.a));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (Color p_vector)
			{
				return MathF.Max(p_vector.r, p_vector.g, p_vector.b, p_vector.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Max (Color p_lhs, Color p_rhs)
			{
				return new Color(MathF.Max(p_lhs.r, p_rhs.r), MathF.Max(p_lhs.g, p_rhs.g), MathF.Max(p_lhs.b, p_rhs.b), MathF.Max(p_lhs.a, p_rhs.a));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Max (Color p_a, Color p_b, Color p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Max (Color p_a, Color p_b, Color p_c, Color p_d)
			{
				return Max(Max(Max(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Max (params Color[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (Color p_vector)
			{
				return MathF.Min(p_vector.r, p_vector.g, p_vector.b, p_vector.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Min (Color p_lhs, Color p_rhs)
			{
				return new Color(MathF.Min(p_lhs.r, p_rhs.r), MathF.Min(p_lhs.g, p_rhs.g), MathF.Min(p_lhs.b, p_rhs.b), MathF.Min(p_lhs.a, p_rhs.a));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Min (Color p_a, Color p_b, Color p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Min (Color p_a, Color p_b, Color p_c, Color p_d)
			{
				return Min(Min(Min(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Min (params Color[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Mul (Color p_lhs, Color p_rhs)
			{
				return new Color(p_lhs.r * p_rhs.r, p_lhs.g * p_rhs.g, p_lhs.b * p_rhs.b, p_lhs.a * p_rhs.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Mul (ref Color p_lhs, Color p_rhs)
			{
				p_lhs = Mul(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Mul (Color p_lhs, float p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Mul (ref Color p_lhs, float p_rhs)
			{
				p_lhs *= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Mul (float p_lhs, Color p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color MulA (Color p_lhs, float p_rhs)
			{
				return new Color(p_lhs.r, p_lhs.g, p_lhs.b, p_lhs.a * p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color MulA (ref Color p_lhs, float p_rhs)
			{
				p_lhs.a *= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color MulA (float p_lhs, Color p_rhs)
			{
				return new Color(p_rhs.r, p_rhs.g, p_rhs.b, p_rhs.a * p_lhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color MulRGB (Color p_lhs, float p_rhs)
			{
				return new Color(p_lhs.r * p_rhs, p_lhs.g * p_rhs, p_lhs.b * p_rhs, p_lhs.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color MulRGB (Color p_lhs, Color p_rhs)
			{
				return new Color(p_lhs.r * p_rhs.r, p_lhs.g * p_rhs.g, p_lhs.b * p_rhs.b, p_lhs.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color MulRGB (ref Color p_lhs, float p_rhs)
			{
				p_lhs.r *= p_rhs;
				p_lhs.g *= p_rhs;
				p_lhs.b *= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color MulRGB (ref Color p_lhs, Color p_rhs)
			{
				p_lhs.r *= p_rhs.r;
				p_lhs.g *= p_rhs.g;
				p_lhs.b *= p_rhs.b;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color MulRGB (float p_lhs, Color p_rhs)
			{
				return MulRGB(p_rhs, p_lhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Replicate (float p_value)
			{
				return new Color(p_value, p_value, p_value, p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Sub (Color p_lhs, Color p_rhs)
			{
				return p_lhs - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Sub (ref Color p_lhs, Color p_rhs)
			{
				p_lhs -= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Sub (Color p_lhs, float p_rhs)
			{
				return p_lhs - Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Sub (ref Color p_lhs, float p_rhs)
			{
				p_lhs -= Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color Sub (float p_lhs, Color p_rhs)
			{
				return Replicate(p_lhs) - p_rhs;
			}

		#endregion
	}
}