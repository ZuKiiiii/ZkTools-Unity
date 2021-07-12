using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Extensions
{
	public static class Vector4X
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Abs (Vector4 p_vector)
			{
				return new Vector4(MathF.Abs(p_vector.x), MathF.Abs(p_vector.y), MathF.Abs(p_vector.z), MathF.Abs(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Ceil (Vector4 p_vector)
			{
				return new Vector4(MathF.Ceil(p_vector.x), MathF.Ceil(p_vector.y), MathF.Ceil(p_vector.z), MathF.Ceil(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, Vector4 p_min, Vector4 p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min.x, p_max.x), MathF.Clamp(p_vector.y, p_min.y, p_max.y), MathF.Clamp(p_vector.z, p_min.z, p_max.z), MathF.Clamp(p_vector.w, p_min.w, p_max.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, float p_min, Vector4 p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min, p_max.x), MathF.Clamp(p_vector.y, p_min, p_max.y), MathF.Clamp(p_vector.z, p_min, p_max.z), MathF.Clamp(p_vector.w, p_min, p_max.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, Vector4 p_min, float p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min.x, p_max), MathF.Clamp(p_vector.y, p_min.y, p_max), MathF.Clamp(p_vector.z, p_min.z, p_max), MathF.Clamp(p_vector.w, p_min.w, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, float p_min = 0.0f, float p_max = 1.0f)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min, p_max), MathF.Clamp(p_vector.y, p_min, p_max), MathF.Clamp(p_vector.z, p_min, p_max), MathF.Clamp(p_vector.w, p_min, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (Vector4 p_lhs, Vector4 p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (Vector4 p_lhs, Vector4 p_rhs)
			{
				return MathF.Square(p_rhs.x - p_lhs.x) + MathF.Square(p_rhs.y - p_lhs.y) + MathF.Square(p_rhs.z - p_lhs.z) + MathF.Square(p_rhs.w - p_lhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Floor (Vector4 p_vector)
			{
				return new Vector4(MathF.Floor(p_vector.x), MathF.Floor(p_vector.y), MathF.Floor(p_vector.z), MathF.Floor(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Frac (Vector4 p_value)
			{
				return p_value - Floor(p_value);
			}

			public static Vector4 Lerp (Vector4 p_a, Vector4 p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			public static Vector4 Lerp (Vector4 p_a, Vector4 p_b, Vector4 p_t)
			{
				return new Vector4(MathF.Lerp(p_a.x, p_b.x, p_t.x), MathF.Lerp(p_a.y, p_b.y, p_t.y), MathF.Lerp(p_a.z, p_b.z, p_t.z), MathF.Lerp(p_a.w, p_b.w, p_t.w));
			}

			public static Vector4 LerpClamped (Vector4 p_a, Vector4 p_b, float p_t)
			{
				return LerpClamped(p_a, p_b, new Vector4(p_t, p_t, p_t, p_t));
			}

			public static Vector4 LerpClamped (Vector4 p_a, Vector4 p_b, Vector4 p_t)
			{
				return new Vector4(MathF.LerpClamped(p_a.x, p_b.x, p_t.x), MathF.LerpClamped(p_a.y, p_b.y, p_t.y), MathF.LerpClamped(p_a.z, p_b.z, p_t.z), MathF.LerpClamped(p_a.w, p_b.w, p_t.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(MathF.Max(p_lhs.x, p_rhs.x), MathF.Max(p_lhs.y, p_rhs.y), MathF.Max(p_lhs.z, p_rhs.z), MathF.Max(p_lhs.w, p_rhs.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return Max(Max(Max(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (params Vector4[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(MathF.Min(p_lhs.x, p_rhs.x), MathF.Min(p_lhs.y, p_rhs.y), MathF.Min(p_lhs.z, p_rhs.z), MathF.Min(p_lhs.w, p_rhs.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return Min(Min(Min(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (params Vector4[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Round (Vector4 p_vector)
			{
				return new Vector4(MathF.Round(p_vector.x), MathF.Round(p_vector.y), MathF.Round(p_vector.z), MathF.Round(p_vector.w));
			}

		#endregion
	}
}
