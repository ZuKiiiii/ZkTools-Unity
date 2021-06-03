using System;
using UnityEngine;
using ZkTools.Mathematics.Extensions;

namespace ZkTools.Mathematics
{
	public enum EEase
	{
		BackIn,
		BackInOut,
		BackOut,
		BounceIn,
		BounceInOut,
		BounceOut,
		BounceOutIn,
		CircularIn,
		CircularInOut,
		CircularOut,
		CircularOutInt,
		CubicIn,
		CubicInOut,
		CubicOut,
		CubicOutIn,
		ElasticIn,
		ElasticInOut,
		ElasticOut,
		ExponentialIn,
		ExponentialInOut,
		ExponentialOut,
		ExponentialOutIn,
		Linear,
		QuadraticIn,
		QuadraticInOut,
		QuadraticOut,
		QuadraticOutIn,
		QuarticIn,
		QuarticInOut,
		QuarticOut,
		QuarticOutIn,
		QuinticIn,
		QuinticInOut,
		QuinticOut,
		QuinticOutIn,
		SinusoidalIn,
		SinusoidalInOut,
		SinusoidalOut,
		SinusoidalOutIn,
		SmoothStep
	}

	public static class Easing
	{
		#region // ====================================[]==================================== //

			private const float C1 = 1.70158f;

			private const float C2 = C1 * 1.525f;

			private const float C3 = C1 + 1.0f;

			private const float C4 = Trigo.TwoPiDivThree;

			private const float C5 = Trigo.Tau / 4.5f;

		#endregion

		#region // ==============================[Static Methods]============================== //

			public static float Array (float p_t, params float[] p_array)
			{
				return p_array.Length == 0 ? 0.0f : p_array[MathInt.Clamp(MathF.FloorToInt(p_t * p_array.Length), 0, p_array.Length - 1)];
			}

			public static float BackIn (float p_t)
			{
				return p_t * p_t * (C3 * p_t - C1);
			}

			public static Vector2 BackIn (Vector2 p_t)
			{
				return new Vector2(BackIn(p_t.x), BackIn(p_t.y));
			}

			public static Vector3 BackIn (Vector3 p_t)
			{
				return new Vector3(BackIn(p_t.x), BackIn(p_t.y), BackIn(p_t.z));
			}

			public static Vector4 BackIn (Vector4 p_t)
			{
				return new Vector4(BackIn(p_t.x), BackIn(p_t.y), BackIn(p_t.z), BackIn(p_t.w));
			}

			public static float BackIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, BackIn(p_t));
			}

			public static Vector2 BackIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BackIn(p_t));
			}

			public static Vector2 BackIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BackIn(p_t));
			}

			public static Vector3 BackIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BackIn(p_t));
			}

			public static Vector3 BackIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BackIn(p_t));
			}

			public static Vector4 BackIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BackIn(p_t));
			}

			public static Vector4 BackIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BackIn(p_t));
			}

			public static float BackInOut (float p_t)
			{
				return p_t < 0.5f
						? MathF.Square(2.0f * p_t) * ((C2 + 1) * 2.0f * p_t - C2) * 0.5f
						: MathF.Square(2.0f * p_t - 2.0f)  *((C2 + 1) * (p_t * 2.0f - 2.0f) + 2) * 0.5f;
			}

			public static Vector2 BackInOut (Vector2 p_t)
			{
				return new Vector2(BackInOut(p_t.x), BackInOut(p_t.y));
			}

			public static Vector3 BackInOut (Vector3 p_t)
			{
				return new Vector3(BackInOut(p_t.x), BackInOut(p_t.y), BackInOut(p_t.z));
			}

			public static Vector4 BackInOut (Vector4 p_t)
			{
				return new Vector4(BackInOut(p_t.x), BackInOut(p_t.y), BackInOut(p_t.z), BackInOut(p_t.w));
			}

			public static float BackInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, BackInOut(p_t));
			}

			public static Vector2 BackInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BackInOut(p_t));
			}

			public static Vector2 BackInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BackInOut(p_t));
			}

			public static Vector3 BackInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BackInOut(p_t));
			}

			public static Vector3 BackInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BackInOut(p_t));
			}

			public static Vector4 BackInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BackInOut(p_t));
			}

			public static Vector4 BackInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BackInOut(p_t));
			}

			public static float BackOut (float p_t)
			{
				return 1 + C3 * MathF.Cube(p_t - 1.0f) + C1 * MathF.Square(p_t - 1.0f);
			}

			public static Vector2 BackOut (Vector2 p_t)
			{
				return new Vector2(BackOut(p_t.x), BackOut(p_t.y));
			}

			public static Vector3 BackOut (Vector3 p_t)
			{
				return new Vector3(BackOut(p_t.x), BackOut(p_t.y), BackOut(p_t.z));
			}

			public static Vector4 BackOut (Vector4 p_t)
			{
				return new Vector4(BackOut(p_t.x), BackOut(p_t.y), BackOut(p_t.z), BackOut(p_t.w));
			}

			public static float BackOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, BackOut(p_t));
			}

			public static Vector2 BackOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BackOut(p_t));
			}

			public static Vector2 BackOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BackOut(p_t));
			}

			public static Vector3 BackOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BackOut(p_t));
			}

			public static Vector3 BackOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BackOut(p_t));
			}

			public static Vector4 BackOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BackOut(p_t));
			}

			public static Vector4 BackOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BackOut(p_t));
			}

			// Bounce
			public static float BounceIn (float p_t)
			{
				return 1.0f - BounceOut(1.0f - p_t);
			}

			public static Vector2 BounceIn (Vector2 p_t)
			{
				return new Vector2(BounceIn(p_t.x), BounceIn(p_t.y));
			}

			public static Vector3 BounceIn (Vector3 p_t)
			{
				return new Vector3(BounceIn(p_t.x), BounceIn(p_t.y), BounceIn(p_t.z));
			}

			public static Vector4 BounceIn (Vector4 p_t)
			{
				return new Vector4(BounceIn(p_t.x), BounceIn(p_t.y), BounceIn(p_t.z), BounceIn(p_t.w));
			}

			public static float BounceIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, BounceIn(p_t));
			}

			public static Vector2 BounceIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BounceIn(p_t));
			}

			public static Vector2 BounceIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BounceIn(p_t));
			}

			public static Vector3 BounceIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BounceIn(p_t));
			}

			public static Vector3 BounceIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BounceIn(p_t));
			}

			public static Vector4 BounceIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BounceIn(p_t));
			}

			public static Vector4 BounceIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BounceIn(p_t));
			}

			public static float BounceInOut (float p_t)
			{
				return p_t < 0.5f
					? (1 - BounceOut(1 - 2 * p_t)) * 0.5f
					: (1 + BounceOut(2 * p_t - 1)) * 0.5f;
			}

			public static Vector2 BounceInOut (Vector2 p_t)
			{
				return new Vector2(BounceInOut(p_t.x), BounceInOut(p_t.y));
			}

			public static Vector3 BounceInOut (Vector3 p_t)
			{
				return new Vector3(BounceInOut(p_t.x), BounceInOut(p_t.y), BounceInOut(p_t.z));
			}

			public static Vector4 BounceInOut (Vector4 p_t)
			{
				return new Vector4(BounceInOut(p_t.x), BounceInOut(p_t.y), BounceInOut(p_t.z), BounceInOut(p_t.w));
			}

			public static float BounceInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, BounceInOut(p_t));
			}

			public static Vector2 BounceInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BounceInOut(p_t));
			}

			public static Vector2 BounceInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BounceInOut(p_t));
			}

			public static Vector3 BounceInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BounceInOut(p_t));
			}

			public static Vector3 BounceInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BounceInOut(p_t));
			}

			public static Vector4 BounceInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BounceInOut(p_t));
			}

			public static Vector4 BounceInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BounceInOut(p_t));
			}

			public static float BounceOut (float p_t)
			{
				float n1 = 7.5625f;
				float d1 = 2.75f;

				if (p_t < 1 / d1)
					return n1 * p_t * p_t;

				else if (p_t < 2 / d1)
					return n1 * (p_t -= 1.5f / d1) * p_t + 0.75f;

				else if (p_t < 2.5 / d1)
					return n1 * (p_t -= 2.25f / d1) * p_t + 0.9375f;

				else
					return n1 * (p_t -= 2.625f / d1) * p_t + 0.984375f;
			}

			public static Vector2 BounceOut (Vector2 p_t)
			{
				return new Vector2(BounceOut(p_t.x), BounceOut(p_t.y));
			}

			public static Vector3 BounceOut (Vector3 p_t)
			{
				return new Vector3(BounceOut(p_t.x), BounceOut(p_t.y), BounceOut(p_t.z));
			}

			public static Vector4 BounceOut (Vector4 p_t)
			{
				return new Vector4(BounceOut(p_t.x), BounceOut(p_t.y), BounceOut(p_t.z), BounceOut(p_t.w));
			}

			public static float BounceOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, BounceOut(p_t));
			}

			public static Vector2 BounceOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BounceOut(p_t));
			}

			public static Vector2 BounceOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BounceOut(p_t));
			}

			public static Vector3 BounceOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BounceOut(p_t));
			}

			public static Vector3 BounceOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BounceOut(p_t));
			}

			public static Vector4 BounceOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BounceOut(p_t));
			}

			public static Vector4 BounceOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BounceOut(p_t));
			}

			public static float BounceOutIn (float p_t)
			{
				return (p_t < 0.5f) ? BounceOut(p_t * 2.0f) * 0.5f : BounceIn(p_t * 2.0f) * 0.5f;
			}

			public static Vector2 BounceOutIn (Vector2 p_t)
			{
				return new Vector2(BounceOutIn(p_t.x), BounceOutIn(p_t.y));
			}

			public static Vector3 BounceOutIn (Vector3 p_t)
			{
				return new Vector3(BounceOutIn(p_t.x), BounceOutIn(p_t.y), BounceOutIn(p_t.z));
			}

			public static Vector4 BounceOutIn (Vector4 p_t)
			{
				return new Vector4(BounceOutIn(p_t.x), BounceOutIn(p_t.y), BounceOutIn(p_t.z), BounceOutIn(p_t.w));
			}

			public static float BounceOutIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, BounceOutIn(p_t));
			}

			public static Vector2 BounceOutIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BounceOutIn(p_t));
			}

			public static Vector2 BounceOutIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, BounceOutIn(p_t));
			}

			public static Vector3 BounceOutIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BounceOutIn(p_t));
			}

			public static Vector3 BounceOutIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, BounceOutIn(p_t));
			}

			public static Vector4 BounceOutIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BounceOutIn(p_t));
			}

			public static Vector4 BounceOutIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, BounceOutIn(p_t));
			}

			// Circular //
			public static float CircularIn (float p_t)
			{
				return 1.0f - MathF.Sqrt(1.0f - MathF.Square(p_t));
			}

			public static Vector2 CircularIn (Vector2 p_t)
			{
				return new Vector2(CircularIn(p_t.x), CircularIn(p_t.y));
			}

			public static Vector3 CircularIn (Vector3 p_t)
			{
				return new Vector3(CircularIn(p_t.x), CircularIn(p_t.y), CircularIn(p_t.z));
			}

			public static Vector4 CircularIn (Vector4 p_t)
			{
				return new Vector4(CircularIn(p_t.x), CircularIn(p_t.y), CircularIn(p_t.z), CircularIn(p_t.w));
			}

			public static float CircularIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, CircularIn(p_t));
			}

			public static Vector2 CircularIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CircularIn(p_t));
			}

			public static Vector2 CircularIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CircularIn(p_t));
			}

			public static Vector3 CircularIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CircularIn(p_t));
			}

			public static Vector3 CircularIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CircularIn(p_t));
			}

			public static Vector4 CircularIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CircularIn(p_t));
			}

			public static Vector4 CircularIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CircularIn(p_t));
			}

			public static float CircularInOut (float p_t)
			{
				return p_t < 0.5
					? (1 - MathF.Sqrt(1 - MathF.Square(2 * p_t))) * 0.5f
					: (MathF.Sqrt(1 - MathF.Square(-2 * p_t + 2)) + 1) * 0.5f;
			}

			public static Vector2 CircularInOut (Vector2 p_t)
			{
				return new Vector2(CircularInOut(p_t.x), CircularInOut(p_t.y));
			}

			public static Vector3 CircularInOut (Vector3 p_t)
			{
				return new Vector3(CircularInOut(p_t.x), CircularInOut(p_t.y), CircularInOut(p_t.z));
			}

			public static Vector4 CircularInOut (Vector4 p_t)
			{
				return new Vector4(CircularInOut(p_t.x), CircularInOut(p_t.y), CircularInOut(p_t.z), CircularInOut(p_t.w));
			}

			public static float CircularInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, CircularInOut(p_t));
			}

			public static Vector2 CircularInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CircularInOut(p_t));
			}

			public static Vector2 CircularInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CircularInOut(p_t));
			}

			public static Vector3 CircularInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CircularInOut(p_t));
			}

			public static Vector3 CircularInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CircularInOut(p_t));
			}

			public static Vector4 CircularInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CircularInOut(p_t));
			}

			public static Vector4 CircularInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CircularInOut(p_t));
			}

			public static float CircularOut (float p_t)
			{
				return MathF.Sqrt(1.0f - MathF.Square(p_t - 1.0f));
			}

			public static Vector2 CircularOut (Vector2 p_t)
			{
				return new Vector2(CircularOut(p_t.x), CircularOut(p_t.y));
			}

			public static Vector3 CircularOut (Vector3 p_t)
			{
				return new Vector3(CircularOut(p_t.x), CircularOut(p_t.y), CircularOut(p_t.z));
			}

			public static Vector4 CircularOut (Vector4 p_t)
			{
				return new Vector4(CircularOut(p_t.x), CircularOut(p_t.y), CircularOut(p_t.z), CircularOut(p_t.w));
			}

			public static float CircularOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, CircularOut(p_t));
			}

			public static Vector2 CircularOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CircularOut(p_t));
			}

			public static Vector2 CircularOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CircularOut(p_t));
			}

			public static Vector3 CircularOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CircularOut(p_t));
			}

			public static Vector3 CircularOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CircularOut(p_t));
			}

			public static Vector4 CircularOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CircularOut(p_t));
			}

			public static Vector4 CircularOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CircularOut(p_t));
			}

			public static float CircularOutIn (float p_t)
			{
				return (p_t < 0.5f)
					? 0.5f * MathF.Sqrt(1.0f - MathF.Square(p_t * 2.0f - 1.0f))
					: -0.5f * (MathF.Sqrt(1.0f - MathF.Square(p_t * 2.0f - 1.0f) - 1.0f) - 1.0f);
			}

			public static Vector2 CircularOutIn (Vector2 p_t)
			{
				return new Vector2(CircularOutIn(p_t.x), CircularOutIn(p_t.y));
			}

			public static Vector3 CircularOutIn (Vector3 p_t)
			{
				return new Vector3(CircularOutIn(p_t.x), CircularOutIn(p_t.y), CircularOutIn(p_t.z));
			}

			public static Vector4 CircularOutIn (Vector4 p_t)
			{
				return new Vector4(CircularOutIn(p_t.x), CircularOutIn(p_t.y), CircularOutIn(p_t.z), CircularOutIn(p_t.w));
			}

			public static float CircularOutIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, CircularOutIn(p_t));
			}

			public static Vector2 CircularOutIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CircularOutIn(p_t));
			}

			public static Vector2 CircularOutIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CircularOutIn(p_t));
			}

			public static Vector3 CircularOutIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CircularOutIn(p_t));
			}

			public static Vector3 CircularOutIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CircularOutIn(p_t));
			}

			public static Vector4 CircularOutIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CircularOutIn(p_t));
			}

			public static Vector4 CircularOutIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CircularOutIn(p_t));
			}

			// cubic
			public static float CubicIn (float p_t)
			{
				return MathF.Cube(p_t);
			}

			public static Vector2 CubicIn (Vector2 p_t)
			{
				return new Vector2(CubicIn(p_t.x), CubicIn(p_t.y));
			}

			public static Vector3 CubicIn (Vector3 p_t)
			{
				return new Vector3(CubicIn(p_t.x), CubicIn(p_t.y), CubicIn(p_t.z));
			}

			public static Vector4 CubicIn (Vector4 p_t)
			{
				return new Vector4(CubicIn(p_t.x), CubicIn(p_t.y), CubicIn(p_t.z), CubicIn(p_t.w));
			}

			public static float CubicIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, CubicIn(p_t));
			}

			public static Vector2 CubicIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CubicIn(p_t));
			}

			public static Vector2 CubicIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CubicIn(p_t));
			}

			public static Vector3 CubicIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CubicIn(p_t));
			}

			public static Vector3 CubicIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CubicIn(p_t));
			}

			public static Vector4 CubicIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CubicIn(p_t));
			}

			public static Vector4 CubicIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CubicIn(p_t));
			}

			public static float CubicInOut (float p_t)
			{
				return p_t < 0.5f
					? 4 * MathF.Cube(p_t)
					: 1 - MathF.Cube(-2 * p_t + 2) * 0.5f;
			}

			public static Vector2 CubicInOut (Vector2 p_t)
			{
				return new Vector2(CubicInOut(p_t.x), CubicInOut(p_t.y));
			}

			public static Vector3 CubicInOut (Vector3 p_t)
			{
				return new Vector3(CubicInOut(p_t.x), CubicInOut(p_t.y), CubicInOut(p_t.z));
			}

			public static Vector4 CubicInOut (Vector4 p_t)
			{
				return new Vector4(CubicInOut(p_t.x), CubicInOut(p_t.y), CubicInOut(p_t.z), CubicInOut(p_t.w));
			}

			public static float CubicInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, CubicInOut(p_t));
			}

			public static Vector2 CubicInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CubicInOut(p_t));
			}

			public static Vector2 CubicInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CubicInOut(p_t));
			}

			public static Vector3 CubicInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CubicInOut(p_t));
			}

			public static Vector3 CubicInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CubicInOut(p_t));
			}

			public static Vector4 CubicInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CubicInOut(p_t));
			}

			public static Vector4 CubicInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CubicInOut(p_t));
			}

			public static float CubicOut (float p_t)
			{
				return 1.0f - MathF.Cube(1.0f - p_t);
			}

			public static Vector2 CubicOut (Vector2 p_t)
			{
				return new Vector2(CubicOut(p_t.x), CubicOut(p_t.y));
			}

			public static Vector3 CubicOut (Vector3 p_t)
			{
				return new Vector3(CubicOut(p_t.x), CubicOut(p_t.y), CubicOut(p_t.z));
			}

			public static Vector4 CubicOut (Vector4 p_t)
			{
				return new Vector4(CubicOut(p_t.x), CubicOut(p_t.y), CubicOut(p_t.z), CubicOut(p_t.w));
			}

			public static float CubicOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, CubicOut(p_t));
			}

			public static Vector2 CubicOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CubicOut(p_t));
			}

			public static Vector2 CubicOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CubicOut(p_t));
			}

			public static Vector3 CubicOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CubicOut(p_t));
			}

			public static Vector3 CubicOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CubicOut(p_t));
			}

			public static Vector4 CubicOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CubicOut(p_t));
			}

			public static Vector4 CubicOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CubicOut(p_t));
			}

			public static float CubicOutIn (float p_t)
			{
				return 0.5f * MathF.Cube(p_t * 2.0f - 1.0f) + 1.0f;
			}

			public static Vector2 CubicOutIn (Vector2 p_t)
			{
				return new Vector2(CubicOutIn(p_t.x), CubicOutIn(p_t.y));
			}

			public static Vector3 CubicOutIn (Vector3 p_t)
			{
				return new Vector3(CubicOutIn(p_t.x), CubicOutIn(p_t.y), CubicOutIn(p_t.z));
			}

			public static Vector4 CubicOutIn (Vector4 p_t)
			{
				return new Vector4(CubicOutIn(p_t.x), CubicOutIn(p_t.y), CubicOutIn(p_t.z), CubicOutIn(p_t.w));
			}

			public static float CubicOutIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, CubicOutIn(p_t));
			}

			public static Vector2 CubicOutIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CubicOutIn(p_t));
			}

			public static Vector2 CubicOutIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, CubicOutIn(p_t));
			}

			public static Vector3 CubicOutIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CubicOutIn(p_t));
			}

			public static Vector3 CubicOutIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, CubicOutIn(p_t));
			}

			public static Vector4 CubicOutIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CubicOutIn(p_t));
			}

			public static Vector4 CubicOutIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, CubicOutIn(p_t));
			}

			// Ease
			public static float Ease1D (EEase p_type, float p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_t);
					case EEase.BackInOut :return BackInOut(p_t);
					case EEase.BackOut : return BackOut(p_t);
					case EEase.BounceIn : return BounceIn(p_t);
					case EEase.BounceInOut : return BounceInOut(p_t);
					case EEase.BounceOut : return BounceOut(p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_t);
					case EEase.CircularIn : return CircularIn(p_t);
					case EEase.CircularInOut : return CircularInOut(p_t);
					case EEase.CircularOut : return CircularOut(p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_t);
					case EEase.CubicIn : return CubicIn(p_t);
					case EEase.CubicInOut : return CubicInOut(p_t);
					case EEase.CubicOut : return CubicOut(p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_t);
					case EEase.ElasticIn : return ElasticIn(p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_t);
					case EEase.ElasticOut : return ElasticOut(p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_t);
					case EEase.Linear : return Lerp(p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_t);
					case EEase.QuarticIn : return QuarticIn(p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_t);
					case EEase.QuarticOut : return QuarticOut(p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_t);
					case EEase.QuinticIn : return QuinticIn(p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_t);
					case EEase.QuinticOut : return QuinticOut(p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_t);
					case EEase.SmoothStep : return SmoothStep(p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static float Ease1D (EEase p_type, float p_from, float p_to, float p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_from, p_to, p_t);
					case EEase.BackInOut :return BackInOut(p_from, p_to, p_t);
					case EEase.BackOut : return BackOut(p_from, p_to, p_t);
					case EEase.BounceIn : return BounceIn(p_from, p_to, p_t);
					case EEase.BounceInOut : return BounceInOut(p_from, p_to, p_t);
					case EEase.BounceOut : return BounceOut(p_from, p_to, p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_from, p_to, p_t);
					case EEase.CircularIn : return CircularIn(p_from, p_to, p_t);
					case EEase.CircularInOut : return CircularInOut(p_from, p_to, p_t);
					case EEase.CircularOut : return CircularOut(p_from, p_to, p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_from, p_to, p_t);
					case EEase.CubicIn : return CubicIn(p_from, p_to, p_t);
					case EEase.CubicInOut : return CubicInOut(p_from, p_to, p_t);
					case EEase.CubicOut : return CubicOut(p_from, p_to, p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_from, p_to, p_t);
					case EEase.ElasticIn : return ElasticIn(p_from, p_to, p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_from, p_to, p_t);
					case EEase.ElasticOut : return ElasticOut(p_from, p_to, p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_from, p_to, p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_from, p_to, p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_from, p_to, p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_from, p_to, p_t);
					case EEase.Linear : return Lerp(p_from, p_to, p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_from, p_to, p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_from, p_to, p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_from, p_to, p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_from, p_to, p_t);
					case EEase.QuarticIn : return QuarticIn(p_from, p_to, p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_from, p_to, p_t);
					case EEase.QuarticOut : return QuarticOut(p_from, p_to, p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_from, p_to, p_t);
					case EEase.QuinticIn : return QuinticIn(p_from, p_to, p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_from, p_to, p_t);
					case EEase.QuinticOut : return QuinticOut(p_from, p_to, p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_from, p_to, p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_from, p_to, p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_from, p_to, p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_from, p_to, p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_from, p_to, p_t);
					case EEase.SmoothStep : return SmoothStep(p_from, p_to, p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Func<float, float> Ease1D_01 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Func<float, float, float, float> Ease1D_02 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Vector2 Ease2D (EEase p_type, Vector2 p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_t);
					case EEase.BackInOut :return BackInOut(p_t);
					case EEase.BackOut : return BackOut(p_t);
					case EEase.BounceIn : return BounceIn(p_t);
					case EEase.BounceInOut : return BounceInOut(p_t);
					case EEase.BounceOut : return BounceOut(p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_t);
					case EEase.CircularIn : return CircularIn(p_t);
					case EEase.CircularInOut : return CircularInOut(p_t);
					case EEase.CircularOut : return CircularOut(p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_t);
					case EEase.CubicIn : return CubicIn(p_t);
					case EEase.CubicInOut : return CubicInOut(p_t);
					case EEase.CubicOut : return CubicOut(p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_t);
					case EEase.ElasticIn : return ElasticIn(p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_t);
					case EEase.ElasticOut : return ElasticOut(p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_t);
					case EEase.Linear : return Lerp(p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_t);
					case EEase.QuarticIn : return QuarticIn(p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_t);
					case EEase.QuarticOut : return QuarticOut(p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_t);
					case EEase.QuinticIn : return QuinticIn(p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_t);
					case EEase.QuinticOut : return QuinticOut(p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_t);
					case EEase.SmoothStep : return SmoothStep(p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Vector2 Ease2D (EEase p_type, Vector2 p_from, Vector2 p_to, float p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_from, p_to, p_t);
					case EEase.BackInOut :return BackInOut(p_from, p_to, p_t);
					case EEase.BackOut : return BackOut(p_from, p_to, p_t);
					case EEase.BounceIn : return BounceIn(p_from, p_to, p_t);
					case EEase.BounceInOut : return BounceInOut(p_from, p_to, p_t);
					case EEase.BounceOut : return BounceOut(p_from, p_to, p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_from, p_to, p_t);
					case EEase.CircularIn : return CircularIn(p_from, p_to, p_t);
					case EEase.CircularInOut : return CircularInOut(p_from, p_to, p_t);
					case EEase.CircularOut : return CircularOut(p_from, p_to, p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_from, p_to, p_t);
					case EEase.CubicIn : return CubicIn(p_from, p_to, p_t);
					case EEase.CubicInOut : return CubicInOut(p_from, p_to, p_t);
					case EEase.CubicOut : return CubicOut(p_from, p_to, p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_from, p_to, p_t);
					case EEase.ElasticIn : return ElasticIn(p_from, p_to, p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_from, p_to, p_t);
					case EEase.ElasticOut : return ElasticOut(p_from, p_to, p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_from, p_to, p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_from, p_to, p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_from, p_to, p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_from, p_to, p_t);
					case EEase.Linear : return Lerp(p_from, p_to, p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_from, p_to, p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_from, p_to, p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_from, p_to, p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_from, p_to, p_t);
					case EEase.QuarticIn : return QuarticIn(p_from, p_to, p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_from, p_to, p_t);
					case EEase.QuarticOut : return QuarticOut(p_from, p_to, p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_from, p_to, p_t);
					case EEase.QuinticIn : return QuinticIn(p_from, p_to, p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_from, p_to, p_t);
					case EEase.QuinticOut : return QuinticOut(p_from, p_to, p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_from, p_to, p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_from, p_to, p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_from, p_to, p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_from, p_to, p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_from, p_to, p_t);
					case EEase.SmoothStep : return SmoothStep(p_from, p_to, p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Vector2 Ease2D (EEase p_type, Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_from, p_to, p_t);
					case EEase.BackInOut :return BackInOut(p_from, p_to, p_t);
					case EEase.BackOut : return BackOut(p_from, p_to, p_t);
					case EEase.BounceIn : return BounceIn(p_from, p_to, p_t);
					case EEase.BounceInOut : return BounceInOut(p_from, p_to, p_t);
					case EEase.BounceOut : return BounceOut(p_from, p_to, p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_from, p_to, p_t);
					case EEase.CircularIn : return CircularIn(p_from, p_to, p_t);
					case EEase.CircularInOut : return CircularInOut(p_from, p_to, p_t);
					case EEase.CircularOut : return CircularOut(p_from, p_to, p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_from, p_to, p_t);
					case EEase.CubicIn : return CubicIn(p_from, p_to, p_t);
					case EEase.CubicInOut : return CubicInOut(p_from, p_to, p_t);
					case EEase.CubicOut : return CubicOut(p_from, p_to, p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_from, p_to, p_t);
					case EEase.ElasticIn : return ElasticIn(p_from, p_to, p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_from, p_to, p_t);
					case EEase.ElasticOut : return ElasticOut(p_from, p_to, p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_from, p_to, p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_from, p_to, p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_from, p_to, p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_from, p_to, p_t);
					case EEase.Linear : return Lerp(p_from, p_to, p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_from, p_to, p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_from, p_to, p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_from, p_to, p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_from, p_to, p_t);
					case EEase.QuarticIn : return QuarticIn(p_from, p_to, p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_from, p_to, p_t);
					case EEase.QuarticOut : return QuarticOut(p_from, p_to, p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_from, p_to, p_t);
					case EEase.QuinticIn : return QuinticIn(p_from, p_to, p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_from, p_to, p_t);
					case EEase.QuinticOut : return QuinticOut(p_from, p_to, p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_from, p_to, p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_from, p_to, p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_from, p_to, p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_from, p_to, p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_from, p_to, p_t);
					case EEase.SmoothStep : return SmoothStep(p_from, p_to, p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Func<Vector2, Vector2> Ease2D_01 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Func<Vector2, Vector2, float, Vector2> Ease2D_02 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Func<Vector2, Vector2, Vector2, Vector2> Ease2D_03 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Vector3 Ease3D (EEase p_type, Vector3 p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_t);
					case EEase.BackInOut :return BackInOut(p_t);
					case EEase.BackOut : return BackOut(p_t);
					case EEase.BounceIn : return BounceIn(p_t);
					case EEase.BounceInOut : return BounceInOut(p_t);
					case EEase.BounceOut : return BounceOut(p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_t);
					case EEase.CircularIn : return CircularIn(p_t);
					case EEase.CircularInOut : return CircularInOut(p_t);
					case EEase.CircularOut : return CircularOut(p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_t);
					case EEase.CubicIn : return CubicIn(p_t);
					case EEase.CubicInOut : return CubicInOut(p_t);
					case EEase.CubicOut : return CubicOut(p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_t);
					case EEase.ElasticIn : return ElasticIn(p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_t);
					case EEase.ElasticOut : return ElasticOut(p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_t);
					case EEase.Linear : return Lerp(p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_t);
					case EEase.QuarticIn : return QuarticIn(p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_t);
					case EEase.QuarticOut : return QuarticOut(p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_t);
					case EEase.QuinticIn : return QuinticIn(p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_t);
					case EEase.QuinticOut : return QuinticOut(p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_t);
					case EEase.SmoothStep : return SmoothStep(p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Vector3 Ease3D (EEase p_type, Vector3 p_from, Vector3 p_to, float p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_from, p_to, p_t);
					case EEase.BackInOut :return BackInOut(p_from, p_to, p_t);
					case EEase.BackOut : return BackOut(p_from, p_to, p_t);
					case EEase.BounceIn : return BounceIn(p_from, p_to, p_t);
					case EEase.BounceInOut : return BounceInOut(p_from, p_to, p_t);
					case EEase.BounceOut : return BounceOut(p_from, p_to, p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_from, p_to, p_t);
					case EEase.CircularIn : return CircularIn(p_from, p_to, p_t);
					case EEase.CircularInOut : return CircularInOut(p_from, p_to, p_t);
					case EEase.CircularOut : return CircularOut(p_from, p_to, p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_from, p_to, p_t);
					case EEase.CubicIn : return CubicIn(p_from, p_to, p_t);
					case EEase.CubicInOut : return CubicInOut(p_from, p_to, p_t);
					case EEase.CubicOut : return CubicOut(p_from, p_to, p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_from, p_to, p_t);
					case EEase.ElasticIn : return ElasticIn(p_from, p_to, p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_from, p_to, p_t);
					case EEase.ElasticOut : return ElasticOut(p_from, p_to, p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_from, p_to, p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_from, p_to, p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_from, p_to, p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_from, p_to, p_t);
					case EEase.Linear : return Lerp(p_from, p_to, p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_from, p_to, p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_from, p_to, p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_from, p_to, p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_from, p_to, p_t);
					case EEase.QuarticIn : return QuarticIn(p_from, p_to, p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_from, p_to, p_t);
					case EEase.QuarticOut : return QuarticOut(p_from, p_to, p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_from, p_to, p_t);
					case EEase.QuinticIn : return QuinticIn(p_from, p_to, p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_from, p_to, p_t);
					case EEase.QuinticOut : return QuinticOut(p_from, p_to, p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_from, p_to, p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_from, p_to, p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_from, p_to, p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_from, p_to, p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_from, p_to, p_t);
					case EEase.SmoothStep : return SmoothStep(p_from, p_to, p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Vector3 Ease3D (EEase p_type, Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_from, p_to, p_t);
					case EEase.BackInOut :return BackInOut(p_from, p_to, p_t);
					case EEase.BackOut : return BackOut(p_from, p_to, p_t);
					case EEase.BounceIn : return BounceIn(p_from, p_to, p_t);
					case EEase.BounceInOut : return BounceInOut(p_from, p_to, p_t);
					case EEase.BounceOut : return BounceOut(p_from, p_to, p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_from, p_to, p_t);
					case EEase.CircularIn : return CircularIn(p_from, p_to, p_t);
					case EEase.CircularInOut : return CircularInOut(p_from, p_to, p_t);
					case EEase.CircularOut : return CircularOut(p_from, p_to, p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_from, p_to, p_t);
					case EEase.CubicIn : return CubicIn(p_from, p_to, p_t);
					case EEase.CubicInOut : return CubicInOut(p_from, p_to, p_t);
					case EEase.CubicOut : return CubicOut(p_from, p_to, p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_from, p_to, p_t);
					case EEase.ElasticIn : return ElasticIn(p_from, p_to, p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_from, p_to, p_t);
					case EEase.ElasticOut : return ElasticOut(p_from, p_to, p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_from, p_to, p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_from, p_to, p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_from, p_to, p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_from, p_to, p_t);
					case EEase.Linear : return Lerp(p_from, p_to, p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_from, p_to, p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_from, p_to, p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_from, p_to, p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_from, p_to, p_t);
					case EEase.QuarticIn : return QuarticIn(p_from, p_to, p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_from, p_to, p_t);
					case EEase.QuarticOut : return QuarticOut(p_from, p_to, p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_from, p_to, p_t);
					case EEase.QuinticIn : return QuinticIn(p_from, p_to, p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_from, p_to, p_t);
					case EEase.QuinticOut : return QuinticOut(p_from, p_to, p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_from, p_to, p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_from, p_to, p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_from, p_to, p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_from, p_to, p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_from, p_to, p_t);
					case EEase.SmoothStep : return SmoothStep(p_from, p_to, p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Func<Vector3, Vector3> Ease3D_01 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Func<Vector3, Vector3, float, Vector3> Ease3D_02 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Func<Vector3, Vector3, Vector3, Vector3> Ease3D_03 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Vector4 Ease4D (EEase p_type, Vector4 p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_t);
					case EEase.BackInOut :return BackInOut(p_t);
					case EEase.BackOut : return BackOut(p_t);
					case EEase.BounceIn : return BounceIn(p_t);
					case EEase.BounceInOut : return BounceInOut(p_t);
					case EEase.BounceOut : return BounceOut(p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_t);
					case EEase.CircularIn : return CircularIn(p_t);
					case EEase.CircularInOut : return CircularInOut(p_t);
					case EEase.CircularOut : return CircularOut(p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_t);
					case EEase.CubicIn : return CubicIn(p_t);
					case EEase.CubicInOut : return CubicInOut(p_t);
					case EEase.CubicOut : return CubicOut(p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_t);
					case EEase.ElasticIn : return ElasticIn(p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_t);
					case EEase.ElasticOut : return ElasticOut(p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_t);
					case EEase.Linear : return Lerp(p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_t);
					case EEase.QuarticIn : return QuarticIn(p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_t);
					case EEase.QuarticOut : return QuarticOut(p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_t);
					case EEase.QuinticIn : return QuinticIn(p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_t);
					case EEase.QuinticOut : return QuinticOut(p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_t);
					case EEase.SmoothStep : return SmoothStep(p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Vector4 Ease4D (EEase p_type, Vector4 p_from, Vector4 p_to, float p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_from, p_to, p_t);
					case EEase.BackInOut :return BackInOut(p_from, p_to, p_t);
					case EEase.BackOut : return BackOut(p_from, p_to, p_t);
					case EEase.BounceIn : return BounceIn(p_from, p_to, p_t);
					case EEase.BounceInOut : return BounceInOut(p_from, p_to, p_t);
					case EEase.BounceOut : return BounceOut(p_from, p_to, p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_from, p_to, p_t);
					case EEase.CircularIn : return CircularIn(p_from, p_to, p_t);
					case EEase.CircularInOut : return CircularInOut(p_from, p_to, p_t);
					case EEase.CircularOut : return CircularOut(p_from, p_to, p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_from, p_to, p_t);
					case EEase.CubicIn : return CubicIn(p_from, p_to, p_t);
					case EEase.CubicInOut : return CubicInOut(p_from, p_to, p_t);
					case EEase.CubicOut : return CubicOut(p_from, p_to, p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_from, p_to, p_t);
					case EEase.ElasticIn : return ElasticIn(p_from, p_to, p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_from, p_to, p_t);
					case EEase.ElasticOut : return ElasticOut(p_from, p_to, p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_from, p_to, p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_from, p_to, p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_from, p_to, p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_from, p_to, p_t);
					case EEase.Linear : return Lerp(p_from, p_to, p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_from, p_to, p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_from, p_to, p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_from, p_to, p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_from, p_to, p_t);
					case EEase.QuarticIn : return QuarticIn(p_from, p_to, p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_from, p_to, p_t);
					case EEase.QuarticOut : return QuarticOut(p_from, p_to, p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_from, p_to, p_t);
					case EEase.QuinticIn : return QuinticIn(p_from, p_to, p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_from, p_to, p_t);
					case EEase.QuinticOut : return QuinticOut(p_from, p_to, p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_from, p_to, p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_from, p_to, p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_from, p_to, p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_from, p_to, p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_from, p_to, p_t);
					case EEase.SmoothStep : return SmoothStep(p_from, p_to, p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Vector4 Ease4D (EEase p_type, Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn(p_from, p_to, p_t);
					case EEase.BackInOut :return BackInOut(p_from, p_to, p_t);
					case EEase.BackOut : return BackOut(p_from, p_to, p_t);
					case EEase.BounceIn : return BounceIn(p_from, p_to, p_t);
					case EEase.BounceInOut : return BounceInOut(p_from, p_to, p_t);
					case EEase.BounceOut : return BounceOut(p_from, p_to, p_t);
					case EEase.BounceOutIn : return BounceOutIn(p_from, p_to, p_t);
					case EEase.CircularIn : return CircularIn(p_from, p_to, p_t);
					case EEase.CircularInOut : return CircularInOut(p_from, p_to, p_t);
					case EEase.CircularOut : return CircularOut(p_from, p_to, p_t);
					case EEase.CircularOutInt : return CircularOutIn(p_from, p_to, p_t);
					case EEase.CubicIn : return CubicIn(p_from, p_to, p_t);
					case EEase.CubicInOut : return CubicInOut(p_from, p_to, p_t);
					case EEase.CubicOut : return CubicOut(p_from, p_to, p_t);
					case EEase.CubicOutIn : return CubicOutIn(p_from, p_to, p_t);
					case EEase.ElasticIn : return ElasticIn(p_from, p_to, p_t);
					case EEase.ElasticInOut : return ElasticInOut(p_from, p_to, p_t);
					case EEase.ElasticOut : return ElasticOut(p_from, p_to, p_t);
					case EEase.ExponentialIn : return ExponentialIn(p_from, p_to, p_t);
					case EEase.ExponentialInOut : return ExponentialInOut(p_from, p_to, p_t);
					case EEase.ExponentialOut : return ExponentialOut(p_from, p_to, p_t);
					case EEase.ExponentialOutIn : return ExponentialOutIn(p_from, p_to, p_t);
					case EEase.Linear : return Lerp(p_from, p_to, p_t);
					case EEase.QuadraticIn : return QuadraticIn(p_from, p_to, p_t);
					case EEase.QuadraticInOut : return QuadraticInOut(p_from, p_to, p_t);
					case EEase.QuadraticOut : return QuadraticOut(p_from, p_to, p_t);
					case EEase.QuadraticOutIn : return QuadraticOutIn(p_from, p_to, p_t);
					case EEase.QuarticIn : return QuarticIn(p_from, p_to, p_t);
					case EEase.QuarticInOut : return QuarticInOut(p_from, p_to, p_t);
					case EEase.QuarticOut : return QuarticOut(p_from, p_to, p_t);
					case EEase.QuarticOutIn : return QuarticOutIn(p_from, p_to, p_t);
					case EEase.QuinticIn : return QuinticIn(p_from, p_to, p_t);
					case EEase.QuinticInOut : return QuinticInOut(p_from, p_to, p_t);
					case EEase.QuinticOut : return QuinticOut(p_from, p_to, p_t);
					case EEase.QuinticOutIn : return QuinticOutIn(p_from, p_to, p_t);
					case EEase.SinusoidalIn : return SinusoidalIn(p_from, p_to, p_t);
					case EEase.SinusoidalInOut : return SinusoidalInOut(p_from, p_to, p_t);
					case EEase.SinusoidalOut : return SinusoidalOut(p_from, p_to, p_t);
					case EEase.SinusoidalOutIn : return SinusoidalOutIn(p_from, p_to, p_t);
					case EEase.SmoothStep : return SmoothStep(p_from, p_to, p_t);
					default : throw new System.ArgumentOutOfRangeException("p_type");
				}
			}

			public static Func<Vector4, Vector4> Ease4D_01 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Func<Vector4, Vector4, float, Vector4> Ease4D_02 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			public static Func<Vector4, Vector4, Vector4, Vector4> Ease4D_03 (EEase p_type)
			{
				switch (p_type)
				{
					case EEase.BackIn : return BackIn;
					case EEase.BackInOut :return BackInOut;
					case EEase.BackOut : return BackOut;
					case EEase.BounceIn : return BounceIn;
					case EEase.BounceInOut : return BounceInOut;
					case EEase.BounceOut : return BounceOut;
					case EEase.BounceOutIn : return BounceOutIn;
					case EEase.CircularIn : return CircularIn;
					case EEase.CircularInOut : return CircularInOut;
					case EEase.CircularOut : return CircularOut;
					case EEase.CircularOutInt : return CircularOutIn;
					case EEase.CubicIn : return CubicIn;
					case EEase.CubicInOut : return CubicInOut;
					case EEase.CubicOut : return CubicOut;
					case EEase.CubicOutIn : return CubicOutIn;
					case EEase.ElasticIn : return ElasticIn;
					case EEase.ElasticInOut : return ElasticInOut;
					case EEase.ElasticOut : return ElasticOut;
					case EEase.ExponentialIn : return ExponentialIn;
					case EEase.ExponentialInOut : return ExponentialInOut;
					case EEase.ExponentialOut : return ExponentialOut;
					case EEase.ExponentialOutIn : return ExponentialOutIn;
					case EEase.Linear : return Lerp;
					case EEase.QuadraticIn : return QuadraticIn;
					case EEase.QuadraticInOut : return QuadraticInOut;
					case EEase.QuadraticOut : return QuadraticOut;
					case EEase.QuadraticOutIn : return QuadraticOutIn;
					case EEase.QuarticIn : return QuarticIn;
					case EEase.QuarticInOut : return QuarticInOut;
					case EEase.QuarticOut : return QuarticOut;
					case EEase.QuarticOutIn : return QuarticOutIn;
					case EEase.QuinticIn : return QuinticIn;
					case EEase.QuinticInOut : return QuinticInOut;
					case EEase.QuinticOut : return QuinticOut;
					case EEase.QuinticOutIn : return QuinticOutIn;
					case EEase.SinusoidalIn : return SinusoidalIn;
					case EEase.SinusoidalInOut : return SinusoidalInOut;
					case EEase.SinusoidalOut : return SinusoidalOut;
					case EEase.SinusoidalOutIn : return SinusoidalOutIn;
					case EEase.SmoothStep : return SmoothStep;
					default : return null;
				}
			}

			// Elastic
			public static float ElasticIn (float p_t)
			{
				return p_t == 0.0f
					? 0.0f
					: p_t == 1.0f
						? 1
						: -MathF.Pow(2, 10 * p_t - 10) * Trigo.Sin((p_t * 10.0f - 10.75f) * C4);
			}

			public static Vector2 ElasticIn (Vector2 p_t)
			{
				return new Vector2(ElasticIn(p_t.x), ElasticIn(p_t.y));
			}

			public static Vector3 ElasticIn (Vector3 p_t)
			{
				return new Vector3(ElasticIn(p_t.x), ElasticIn(p_t.y), ElasticIn(p_t.z));
			}

			public static Vector4 ElasticIn (Vector4 p_t)
			{
				return new Vector4(ElasticIn(p_t.x), ElasticIn(p_t.y), ElasticIn(p_t.z), ElasticIn(p_t.w));
			}

			public static float ElasticIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, ElasticIn(p_t));
			}

			public static Vector2 ElasticIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ElasticIn(p_t));
			}

			public static Vector2 ElasticIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ElasticIn(p_t));
			}

			public static Vector3 ElasticIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ElasticIn(p_t));
			}

			public static Vector3 ElasticIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ElasticIn(p_t));
			}

			public static Vector4 ElasticIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ElasticIn(p_t));
			}

			public static Vector4 ElasticIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ElasticIn(p_t));
			}

			public static float ElasticInOut (float p_t)
			{
				return p_t == 0
					? 0
					: p_t == 1
						? 1
						: p_t < 0.5f
							? -(MathF.Pow(2, 20 * p_t - 10) * Trigo.Sin((20 * p_t - 11.125f) * C5)) * 0.5f
							: (MathF.Pow(2, -20 * p_t + 10) * Trigo.Sin((20 * p_t - 11.125f) * C5)) * 0.5f + 1;
			}

			public static Vector2 ElasticInOut (Vector2 p_t)
			{
				return new Vector2(ElasticInOut(p_t.x), ElasticInOut(p_t.y));
			}

			public static Vector3 ElasticInOut (Vector3 p_t)
			{
				return new Vector3(ElasticInOut(p_t.x), ElasticInOut(p_t.y), ElasticInOut(p_t.z));
			}

			public static Vector4 ElasticInOut (Vector4 p_t)
			{
				return new Vector4(ElasticInOut(p_t.x), ElasticInOut(p_t.y), ElasticInOut(p_t.z), ElasticInOut(p_t.w));
			}

			public static float ElasticInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, ElasticInOut(p_t));
			}

			public static Vector2 ElasticInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ElasticInOut(p_t));
			}

			public static Vector2 ElasticInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ElasticInOut(p_t));
			}

			public static Vector3 ElasticInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ElasticInOut(p_t));
			}

			public static Vector3 ElasticInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ElasticInOut(p_t));
			}

			public static Vector4 ElasticInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ElasticInOut(p_t));
			}

			public static Vector4 ElasticInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ElasticInOut(p_t));
			}

			public static float ElasticOut (float p_t)
			{
				return p_t == 0
					? 0
					: p_t == 1
						? 1
						: Mathf.Pow(2, -10f * p_t) * Trigo.Sin((p_t * 10f - 0.75f) * C4) + 1f;
			}

			public static Vector2 ElasticOut (Vector2 p_t)
			{
				return new Vector2(ElasticOut(p_t.x), ElasticOut(p_t.y));
			}

			public static Vector3 ElasticOut (Vector3 p_t)
			{
				return new Vector3(ElasticOut(p_t.x), ElasticOut(p_t.y), ElasticOut(p_t.z));
			}

			public static Vector4 ElasticOut (Vector4 p_t)
			{
				return new Vector4(ElasticOut(p_t.x), ElasticOut(p_t.y), ElasticOut(p_t.z), ElasticOut(p_t.w));
			}

			public static float ElasticOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, ElasticOut(p_t));
			}

			public static Vector2 ElasticOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ElasticOut(p_t));
			}

			public static Vector2 ElasticOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ElasticOut(p_t));
			}

			public static Vector3 ElasticOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ElasticOut(p_t));
			}

			public static Vector3 ElasticOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ElasticOut(p_t));
			}

			public static Vector4 ElasticOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ElasticOut(p_t));
			}

			public static Vector4 ElasticOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ElasticOut(p_t));
			}

			// Exponential
			public static float ExponentialIn (float p_t)
			{
				return p_t == 0 ? 0 : MathF.Pow(2, 10 * p_t - 10);
			}

			public static Vector2 ExponentialIn (Vector2 p_t)
			{
				return new Vector2(ExponentialIn(p_t.x), ExponentialIn(p_t.y));
			}

			public static Vector3 ExponentialIn (Vector3 p_t)
			{
				return new Vector3(ExponentialIn(p_t.x), ExponentialIn(p_t.y), ExponentialIn(p_t.z));
			}

			public static Vector4 ExponentialIn (Vector4 p_t)
			{
				return new Vector4(ExponentialIn(p_t.x), ExponentialIn(p_t.y), ExponentialIn(p_t.z), ExponentialIn(p_t.w));
			}

			public static float ExponentialIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, ExponentialIn(p_t));
			}

			public static Vector2 ExponentialIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ExponentialIn(p_t));
			}

			public static Vector2 ExponentialIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ExponentialIn(p_t));
			}

			public static Vector3 ExponentialIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ExponentialIn(p_t));
			}

			public static Vector3 ExponentialIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ExponentialIn(p_t));
			}

			public static Vector4 ExponentialIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ExponentialIn(p_t));
			}

			public static Vector4 ExponentialIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ExponentialIn(p_t));
			}

			public static float ExponentialInOut (float p_t)
			{
				return p_t == 0
					? 0
					: p_t == 1f
						? 1
						: p_t < 0.5f
							? MathF.Pow(2, 20 * p_t - 10) * 0.5f
							: (2 - MathF.Pow(2, -20 * p_t + 10)) * 0.5f;
			}

			public static Vector2 ExponentialInOut (Vector2 p_t)
			{
				return new Vector2(ExponentialInOut(p_t.x), ExponentialInOut(p_t.y));
			}

			public static Vector3 ExponentialInOut (Vector3 p_t)
			{
				return new Vector3(ExponentialInOut(p_t.x), ExponentialInOut(p_t.y), ExponentialInOut(p_t.z));
			}

			public static Vector4 ExponentialInOut (Vector4 p_t)
			{
				return new Vector4(ExponentialInOut(p_t.x), ExponentialInOut(p_t.y), ExponentialInOut(p_t.z), ExponentialInOut(p_t.w));
			}

			public static float ExponentialInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, ExponentialInOut(p_t));
			}

			public static Vector2 ExponentialInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ExponentialInOut(p_t));
			}

			public static Vector2 ExponentialInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ExponentialInOut(p_t));
			}

			public static Vector3 ExponentialInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ExponentialInOut(p_t));
			}

			public static Vector3 ExponentialInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ExponentialInOut(p_t));
			}

			public static Vector4 ExponentialInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ExponentialInOut(p_t));
			}

			public static Vector4 ExponentialInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ExponentialInOut(p_t));
			}

			public static float ExponentialOut (float p_t)
			{
				return p_t == 1f ? 1f : 1f - MathF.Pow(2, -10 * p_t);
			}

			public static Vector2 ExponentialOut (Vector2 p_t)
			{
				return new Vector2(ExponentialOut(p_t.x), ExponentialOut(p_t.y));
			}

			public static Vector3 ExponentialOut (Vector3 p_t)
			{
				return new Vector3(ExponentialOut(p_t.x), ExponentialOut(p_t.y), ExponentialOut(p_t.z));
			}

			public static Vector4 ExponentialOut (Vector4 p_t)
			{
				return new Vector4(ExponentialOut(p_t.x), ExponentialOut(p_t.y), ExponentialOut(p_t.z), ExponentialOut(p_t.w));
			}

			public static float ExponentialOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, ExponentialOut(p_t));
			}

			public static Vector2 ExponentialOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ExponentialOut(p_t));
			}

			public static Vector2 ExponentialOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ExponentialOut(p_t));
			}

			public static Vector3 ExponentialOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ExponentialOut(p_t));
			}

			public static Vector3 ExponentialOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ExponentialOut(p_t));
			}

			public static Vector4 ExponentialOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ExponentialOut(p_t));
			}

			public static Vector4 ExponentialOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ExponentialOut(p_t));
			}

			public static float ExponentialOutIn (float p_t)
			{
				return p_t == 1f ? 1f : 1f - MathF.Pow(2, -10 * p_t);
			}

			public static Vector2 ExponentialOutIn (Vector2 p_t)
			{
				return new Vector2(ExponentialOutIn(p_t.x), ExponentialOutIn(p_t.y));
			}

			public static Vector3 ExponentialOutIn (Vector3 p_t)
			{
				return new Vector3(ExponentialOutIn(p_t.x), ExponentialOutIn(p_t.y), ExponentialOutIn(p_t.z));
			}

			public static Vector4 ExponentialOutIn (Vector4 p_t)
			{
				return new Vector4(ExponentialOutIn(p_t.x), ExponentialOutIn(p_t.y), ExponentialOutIn(p_t.z), ExponentialOutIn(p_t.w));
			}

			public static float ExponentialOutIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, ExponentialOutIn(p_t));
			}

			public static Vector2 ExponentialOutIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ExponentialOutIn(p_t));
			}

			public static Vector2 ExponentialOutIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, ExponentialOutIn(p_t));
			}

			public static Vector3 ExponentialOutIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ExponentialOutIn(p_t));
			}

			public static Vector3 ExponentialOutIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, ExponentialOutIn(p_t));
			}

			public static Vector4 ExponentialOutIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ExponentialOutIn(p_t));
			}

			public static Vector4 ExponentialOutIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, ExponentialOutIn(p_t));
			}

			// Linear
			public static float Lerp (float p_t)
			{
				return p_t;
			}

			public static Vector2 Lerp (Vector2 p_t)
			{
				return p_t;
			}

			public static Vector3 Lerp (Vector3 p_t)
			{
				return p_t;
			}

			public static Vector4 Lerp (Vector4 p_t)
			{
				return p_t;
			}

			public static float Lerp (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, p_t);
			}

			public static Vector2 Lerp (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, p_t);
			}

			public static Vector2 Lerp (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, p_t);
			}

			public static Vector3 Lerp (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, p_t);
			}

			public static Vector3 Lerp (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, p_t);
			}

			public static Vector4 Lerp (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, p_t);
			}

			public static Vector4 Lerp (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, p_t);
			}

			// Quadratic
			public static float QuadraticIn (float p_t)
			{
				return MathF.Square(p_t);
			}

			public static Vector2 QuadraticIn (Vector2 p_t)
			{
				return new Vector2(QuadraticIn(p_t.x), QuadraticIn(p_t.y));
			}

			public static Vector3 QuadraticIn (Vector3 p_t)
			{
				return new Vector3(QuadraticIn(p_t.x), QuadraticIn(p_t.y), QuadraticIn(p_t.z));
			}

			public static Vector4 QuadraticIn (Vector4 p_t)
			{
				return new Vector4(QuadraticIn(p_t.x), QuadraticIn(p_t.y), QuadraticIn(p_t.z), QuadraticIn(p_t.w));
			}

			public static float QuadraticIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuadraticIn(p_t));
			}

			public static Vector2 QuadraticIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuadraticIn(p_t));
			}

			public static Vector2 QuadraticIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuadraticIn(p_t));
			}

			public static Vector3 QuadraticIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuadraticIn(p_t));
			}

			public static Vector3 QuadraticIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuadraticIn(p_t));
			}

			public static Vector4 QuadraticIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuadraticIn(p_t));
			}

			public static Vector4 QuadraticIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuadraticIn(p_t));
			}

			public static float QuadraticInOut (float p_t)
			{
				return p_t < 0.5 ? 2 * MathF.Square(p_t) : 1f - MathF.Square(-2 * p_t + 2) * 0.5f;
			}

			public static Vector2 QuadraticInOut (Vector2 p_t)
			{
				return new Vector2(QuadraticInOut(p_t.x), QuadraticInOut(p_t.y));
			}

			public static Vector3 QuadraticInOut (Vector3 p_t)
			{
				return new Vector3(QuadraticInOut(p_t.x), QuadraticInOut(p_t.y), QuadraticInOut(p_t.z));
			}

			public static Vector4 QuadraticInOut (Vector4 p_t)
			{
				return new Vector4(QuadraticInOut(p_t.x), QuadraticInOut(p_t.y), QuadraticInOut(p_t.z), QuadraticInOut(p_t.w));
			}

			public static float QuadraticInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuadraticInOut(p_t));
			}

			public static Vector2 QuadraticInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuadraticInOut(p_t));
			}

			public static Vector2 QuadraticInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuadraticInOut(p_t));
			}

			public static Vector3 QuadraticInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuadraticInOut(p_t));
			}

			public static Vector3 QuadraticInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuadraticInOut(p_t));
			}

			public static Vector4 QuadraticInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuadraticInOut(p_t));
			}

			public static Vector4 QuadraticInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuadraticInOut(p_t));
			}

			public static float QuadraticOut (float p_t)
			{
				return 1.0f - MathF.Square(1.0f - p_t);
			}

			public static Vector2 QuadraticOut (Vector2 p_t)
			{
				return new Vector2(QuadraticOut(p_t.x), QuadraticOut(p_t.y));
			}

			public static Vector3 QuadraticOut (Vector3 p_t)
			{
				return new Vector3(QuadraticOut(p_t.x), QuadraticOut(p_t.y), QuadraticOut(p_t.z));
			}

			public static Vector4 QuadraticOut (Vector4 p_t)
			{
				return new Vector4(QuadraticOut(p_t.x), QuadraticOut(p_t.y), QuadraticOut(p_t.z), QuadraticOut(p_t.w));
			}

			public static float QuadraticOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuadraticOut(p_t));
			}

			public static Vector2 QuadraticOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuadraticOut(p_t));
			}

			public static Vector2 QuadraticOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuadraticOut(p_t));
			}

			public static Vector3 QuadraticOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuadraticOut(p_t));
			}

			public static Vector3 QuadraticOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuadraticOut(p_t));
			}

			public static Vector4 QuadraticOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuadraticOut(p_t));
			}

			public static Vector4 QuadraticOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuadraticOut(p_t));
			}

			public static float QuadraticOutIn (float p_t)
			{
				return (p_t < 0.5f) ? QuadraticOut(p_t * 2.0f) * 0.5f : QuadraticIn(p_t * 2.0f) * 0.5f;
			}

			public static Vector2 QuadraticOutIn (Vector2 p_t)
			{
				return new Vector2(QuadraticOutIn(p_t.x), QuadraticOutIn(p_t.y));
			}

			public static Vector3 QuadraticOutIn (Vector3 p_t)
			{
				return new Vector3(QuadraticOutIn(p_t.x), QuadraticOutIn(p_t.y), QuadraticOutIn(p_t.z));
			}

			public static Vector4 QuadraticOutIn (Vector4 p_t)
			{
				return new Vector4(QuadraticOutIn(p_t.x), QuadraticOutIn(p_t.y), QuadraticOutIn(p_t.z), QuadraticOutIn(p_t.w));
			}

			public static float QuadraticOutIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuadraticOutIn(p_t));
			}

			public static Vector2 QuadraticOutIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuadraticOutIn(p_t));
			}

			public static Vector2 QuadraticOutIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuadraticOutIn(p_t));
			}

			public static Vector3 QuadraticOutIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuadraticOutIn(p_t));
			}

			public static Vector3 QuadraticOutIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuadraticOutIn(p_t));
			}

			public static Vector4 QuadraticOutIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuadraticOutIn(p_t));
			}

			public static Vector4 QuadraticOutIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuadraticOutIn(p_t));
			}

			// Quartic
			public static float QuarticIn (float p_t)
			{
				return MathF.Quartic(p_t);
			}

			public static Vector2 QuarticIn (Vector2 p_t)
			{
				return new Vector2(QuarticIn(p_t.x), QuarticIn(p_t.y));
			}

			public static Vector3 QuarticIn (Vector3 p_t)
			{
				return new Vector3(QuarticIn(p_t.x), QuarticIn(p_t.y), QuarticIn(p_t.z));
			}

			public static Vector4 QuarticIn (Vector4 p_t)
			{
				return new Vector4(QuarticIn(p_t.x), QuarticIn(p_t.y), QuarticIn(p_t.z), QuarticIn(p_t.w));
			}

			public static float QuarticIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuarticIn(p_t));
			}

			public static Vector2 QuarticIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuarticIn(p_t));
			}

			public static Vector2 QuarticIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuarticIn(p_t));
			}

			public static Vector3 QuarticIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuarticIn(p_t));
			}

			public static Vector3 QuarticIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuarticIn(p_t));
			}

			public static Vector4 QuarticIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuarticIn(p_t));
			}

			public static Vector4 QuarticIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuarticIn(p_t));
			}

			public static float QuarticInOut (float p_t)
			{
				return p_t < 0.5f ? 8 * MathF.Quartic(p_t) : 1 - MathF.Quartic(-2 * p_t + 2) * 0.5f;
			}

			public static Vector2 QuarticInOut (Vector2 p_t)
			{
				return new Vector2(QuarticInOut(p_t.x), QuarticInOut(p_t.y));
			}

			public static Vector3 QuarticInOut (Vector3 p_t)
			{
				return new Vector3(QuarticInOut(p_t.x), QuarticInOut(p_t.y), QuarticInOut(p_t.z));
			}

			public static Vector4 QuarticInOut (Vector4 p_t)
			{
				return new Vector4(QuarticInOut(p_t.x), QuarticInOut(p_t.y), QuarticInOut(p_t.z), QuarticInOut(p_t.w));
			}

			public static float QuarticInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuarticInOut(p_t));
			}

			public static Vector2 QuarticInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuarticInOut(p_t));
			}

			public static Vector2 QuarticInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuarticInOut(p_t));
			}

			public static Vector3 QuarticInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuarticInOut(p_t));
			}

			public static Vector3 QuarticInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuarticInOut(p_t));
			}

			public static Vector4 QuarticInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuarticInOut(p_t));
			}

			public static Vector4 QuarticInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuarticInOut(p_t));
			}

			public static float QuarticOut (float p_t)
			{
				return 1f - MathF.Quartic(1f - p_t);
			}

			public static Vector2 QuarticOut (Vector2 p_t)
			{
				return new Vector2(QuarticOut(p_t.x), QuarticOut(p_t.y));
			}

			public static Vector3 QuarticOut (Vector3 p_t)
			{
				return new Vector3(QuarticOut(p_t.x), QuarticOut(p_t.y), QuarticOut(p_t.z));
			}

			public static Vector4 QuarticOut (Vector4 p_t)
			{
				return new Vector4(QuarticOut(p_t.x), QuarticOut(p_t.y), QuarticOut(p_t.z), QuarticOut(p_t.w));
			}

			public static float QuarticOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuarticOut(p_t));
			}

			public static Vector2 QuarticOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuarticOut(p_t));
			}

			public static Vector2 QuarticOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuarticOut(p_t));
			}

			public static Vector3 QuarticOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuarticOut(p_t));
			}

			public static Vector3 QuarticOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuarticOut(p_t));
			}

			public static Vector4 QuarticOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuarticOut(p_t));
			}

			public static Vector4 QuarticOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuarticOut(p_t));
			}

			public static float QuarticOutIn (float p_t)
			{
				return (p_t < 0.5f)
					? -0.5f * MathF.Quartic(p_t * 2.0f - 1.0f) + 0.5f
					: 0.5f * MathF.Quartic(p_t * 2.0f - 1.0f) + 0.5f;
			}

			public static Vector2 QuarticOutIn (Vector2 p_t)
			{
				return new Vector2(QuarticOutIn(p_t.x), QuarticOutIn(p_t.y));
			}

			public static Vector3 QuarticOutIn (Vector3 p_t)
			{
				return new Vector3(QuarticOutIn(p_t.x), QuarticOutIn(p_t.y), QuarticOutIn(p_t.z));
			}

			public static Vector4 QuarticOutIn (Vector4 p_t)
			{
				return new Vector4(QuarticOutIn(p_t.x), QuarticOutIn(p_t.y), QuarticOutIn(p_t.z), QuarticOutIn(p_t.w));
			}

			public static float QuarticOutIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuarticOutIn(p_t));
			}

			public static Vector2 QuarticOutIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuarticOutIn(p_t));
			}

			public static Vector2 QuarticOutIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuarticOutIn(p_t));
			}

			public static Vector3 QuarticOutIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuarticOutIn(p_t));
			}

			public static Vector3 QuarticOutIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuarticOutIn(p_t));
			}

			public static Vector4 QuarticOutIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuarticOutIn(p_t));
			}

			public static Vector4 QuarticOutIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuarticOutIn(p_t));
			}

			// Quintic
			public static float QuinticIn (float p_t)
			{
				return MathF.Quintic(p_t);
			}

			public static Vector2 QuinticIn (Vector2 p_t)
			{
				return new Vector2(QuinticIn(p_t.x), QuinticIn(p_t.y));
			}

			public static Vector3 QuinticIn (Vector3 p_t)
			{
				return new Vector3(QuinticIn(p_t.x), QuinticIn(p_t.y), QuinticIn(p_t.z));
			}

			public static Vector4 QuinticIn (Vector4 p_t)
			{
				return new Vector4(QuinticIn(p_t.x), QuinticIn(p_t.y), QuinticIn(p_t.z), QuinticIn(p_t.w));
			}

			public static float QuinticIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuinticIn(p_t));
			}

			public static Vector2 QuinticIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuinticIn(p_t));
			}

			public static Vector2 QuinticIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuinticIn(p_t));
			}

			public static Vector3 QuinticIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuinticIn(p_t));
			}

			public static Vector3 QuinticIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuinticIn(p_t));
			}

			public static Vector4 QuinticIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuinticIn(p_t));
			}

			public static Vector4 QuinticIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuinticIn(p_t));
			}

			public static float QuinticInOut (float p_t)
			{
				return p_t < 0.5f ? 16 * MathF.Quintic(p_t) : 1 - MathF.Quintic(-2 * p_t + 2) * 0.5f;
			}

			public static Vector2 QuinticInOut (Vector2 p_t)
			{
				return new Vector2(QuinticInOut(p_t.x), QuinticInOut(p_t.y));
			}

			public static Vector3 QuinticInOut (Vector3 p_t)
			{
				return new Vector3(QuinticInOut(p_t.x), QuinticInOut(p_t.y), QuinticInOut(p_t.z));
			}

			public static Vector4 QuinticInOut (Vector4 p_t)
			{
				return new Vector4(QuinticInOut(p_t.x), QuinticInOut(p_t.y), QuinticInOut(p_t.z), QuinticInOut(p_t.w));
			}

			public static float QuinticInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuinticInOut(p_t));
			}

			public static Vector2 QuinticInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuinticInOut(p_t));
			}

			public static Vector2 QuinticInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuinticInOut(p_t));
			}

			public static Vector3 QuinticInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuinticInOut(p_t));
			}

			public static Vector3 QuinticInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuinticInOut(p_t));
			}

			public static Vector4 QuinticInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuinticInOut(p_t));
			}

			public static Vector4 QuinticInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuinticInOut(p_t));
			}

			public static float QuinticOut (float p_t)
			{
				return 1f - MathF.Quintic(1f - p_t);
			}

			public static Vector2 QuinticOut (Vector2 p_t)
			{
				return new Vector2(QuinticOut(p_t.x), QuinticOut(p_t.y));
			}

			public static Vector3 QuinticOut (Vector3 p_t)
			{
				return new Vector3(QuinticOut(p_t.x), QuinticOut(p_t.y), QuinticOut(p_t.z));
			}

			public static Vector4 QuinticOut (Vector4 p_t)
			{
				return new Vector4(QuinticOut(p_t.x), QuinticOut(p_t.y), QuinticOut(p_t.z), QuinticOut(p_t.w));
			}

			public static float QuinticOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuinticOut(p_t));
			}

			public static Vector2 QuinticOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuinticOut(p_t));
			}

			public static Vector2 QuinticOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuinticOut(p_t));
			}

			public static Vector3 QuinticOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuinticOut(p_t));
			}

			public static Vector3 QuinticOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuinticOut(p_t));
			}

			public static Vector4 QuinticOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuinticOut(p_t));
			}

			public static Vector4 QuinticOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuinticOut(p_t));
			}

			public static float QuinticOutIn (float p_t)
			{
				return 0.5f * MathF.Quintic(p_t * 2.0f - 1.0f) + 1.0f;
			}

			public static Vector2 QuinticOutIn (Vector2 p_t)
			{
				return new Vector2(QuinticOutIn(p_t.x), QuinticOutIn(p_t.y));
			}

			public static Vector3 QuinticOutIn (Vector3 p_t)
			{
				return new Vector3(QuinticOutIn(p_t.x), QuinticOutIn(p_t.y), QuinticOutIn(p_t.z));
			}

			public static Vector4 QuinticOutIn (Vector4 p_t)
			{
				return new Vector4(QuinticOutIn(p_t.x), QuinticOutIn(p_t.y), QuinticOutIn(p_t.z), QuinticOutIn(p_t.w));
			}

			public static float QuinticOutIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, QuinticOutIn(p_t));
			}

			public static Vector2 QuinticOutIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuinticOutIn(p_t));
			}

			public static Vector2 QuinticOutIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, QuinticOutIn(p_t));
			}

			public static Vector3 QuinticOutIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuinticOutIn(p_t));
			}

			public static Vector3 QuinticOutIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, QuinticOutIn(p_t));
			}

			public static Vector4 QuinticOutIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuinticOutIn(p_t));
			}

			public static Vector4 QuinticOutIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, QuinticOutIn(p_t));
			}

			// Sinusoidal
			public static float SinusoidalIn (float p_t)
			{
				return 1f - Trigo.Cos(p_t * Trigo.PiDivTwo);
			}

			public static Vector2 SinusoidalIn (Vector2 p_t)
			{
				return new Vector2(SinusoidalIn(p_t.x), SinusoidalIn(p_t.y));
			}

			public static Vector3 SinusoidalIn (Vector3 p_t)
			{
				return new Vector3(SinusoidalIn(p_t.x), SinusoidalIn(p_t.y), SinusoidalIn(p_t.z));
			}

			public static Vector4 SinusoidalIn (Vector4 p_t)
			{
				return new Vector4(SinusoidalIn(p_t.x), SinusoidalIn(p_t.y), SinusoidalIn(p_t.z), SinusoidalIn(p_t.w));
			}

			public static float SinusoidalIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, SinusoidalIn(p_t));
			}

			public static Vector2 SinusoidalIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SinusoidalIn(p_t));
			}

			public static Vector2 SinusoidalIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SinusoidalIn(p_t));
			}

			public static Vector3 SinusoidalIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SinusoidalIn(p_t));
			}

			public static Vector3 SinusoidalIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SinusoidalIn(p_t));
			}

			public static Vector4 SinusoidalIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SinusoidalIn(p_t));
			}

			public static Vector4 SinusoidalIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SinusoidalIn(p_t));
			}

			public static float SinusoidalInOut (float p_t)
			{
				return -(Trigo.Cos(Trigo.Pi * p_t) - 1) * 0.5f;
			}

			public static Vector2 SinusoidalInOut (Vector2 p_t)
			{
				return new Vector2(SinusoidalInOut(p_t.x), SinusoidalInOut(p_t.y));
			}

			public static Vector3 SinusoidalInOut (Vector3 p_t)
			{
				return new Vector3(SinusoidalInOut(p_t.x), SinusoidalInOut(p_t.y), SinusoidalInOut(p_t.z));
			}

			public static Vector4 SinusoidalInOut (Vector4 p_t)
			{
				return new Vector4(SinusoidalInOut(p_t.x), SinusoidalInOut(p_t.y), SinusoidalInOut(p_t.z), SinusoidalInOut(p_t.w));
			}

			public static float SinusoidalInOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, SinusoidalInOut(p_t));
			}

			public static Vector2 SinusoidalInOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SinusoidalInOut(p_t));
			}

			public static Vector2 SinusoidalInOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SinusoidalInOut(p_t));
			}

			public static Vector3 SinusoidalInOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SinusoidalInOut(p_t));
			}

			public static Vector3 SinusoidalInOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SinusoidalInOut(p_t));
			}

			public static Vector4 SinusoidalInOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SinusoidalInOut(p_t));
			}

			public static Vector4 SinusoidalInOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SinusoidalInOut(p_t));
			}

			public static float SinusoidalOut (float p_t)
			{
				return Trigo.Sin(p_t * Trigo.PiDivTwo);
			}

			public static Vector2 SinusoidalOut (Vector2 p_t)
			{
				return new Vector2(SinusoidalOut(p_t.x), SinusoidalOut(p_t.y));
			}

			public static Vector3 SinusoidalOut (Vector3 p_t)
			{
				return new Vector3(SinusoidalOut(p_t.x), SinusoidalOut(p_t.y), SinusoidalOut(p_t.z));
			}

			public static Vector4 SinusoidalOut (Vector4 p_t)
			{
				return new Vector4(SinusoidalOut(p_t.x), SinusoidalOut(p_t.y), SinusoidalOut(p_t.z), SinusoidalOut(p_t.w));
			}

			public static float SinusoidalOut (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, SinusoidalOut(p_t));
			}

			public static Vector2 SinusoidalOut (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SinusoidalOut(p_t));
			}

			public static Vector2 SinusoidalOut (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SinusoidalOut(p_t));
			}

			public static Vector3 SinusoidalOut (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SinusoidalOut(p_t));
			}

			public static Vector3 SinusoidalOut (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SinusoidalOut(p_t));
			}

			public static Vector4 SinusoidalOut (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SinusoidalOut(p_t));
			}

			public static Vector4 SinusoidalOut (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SinusoidalOut(p_t));
			}

			public static float SinusoidalOutIn (float p_t)
			{
				return (p_t < 0.5f)
						? 0.5f * Trigo.Sin(p_t * Trigo.Pi)
						: -0.5f *  Trigo.Cos((p_t * 2.0f - 1.0f) * Trigo.PiDivTwo) + 1.0f;
			}

			public static Vector2 SinusoidalOutIn (Vector2 p_t)
			{
				return new Vector2(SinusoidalOutIn(p_t.x), SinusoidalOutIn(p_t.y));
			}

			public static Vector3 SinusoidalOutIn (Vector3 p_t)
			{
				return new Vector3(SinusoidalOutIn(p_t.x), SinusoidalOutIn(p_t.y), SinusoidalOutIn(p_t.z));
			}

			public static Vector4 SinusoidalOutIn (Vector4 p_t)
			{
				return new Vector4(SinusoidalOutIn(p_t.x), SinusoidalOutIn(p_t.y), SinusoidalOutIn(p_t.z), SinusoidalOutIn(p_t.w));
			}

			public static float SinusoidalOutIn (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, SinusoidalOutIn(p_t));
			}

			public static Vector2 SinusoidalOutIn (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SinusoidalOutIn(p_t));
			}

			public static Vector2 SinusoidalOutIn (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SinusoidalOutIn(p_t));
			}

			public static Vector3 SinusoidalOutIn (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SinusoidalOutIn(p_t));
			}

			public static Vector3 SinusoidalOutIn (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SinusoidalOutIn(p_t));
			}

			public static Vector4 SinusoidalOutIn (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SinusoidalOutIn(p_t));
			}

			public static Vector4 SinusoidalOutIn (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SinusoidalOutIn(p_t));
			}

			// SmoothStep
			public static float SmoothStep (float p_t)
			{
				return MathF.Square(p_t) * (3f - 2f * p_t);
			}

			public static Vector2 SmoothStep (Vector2 p_t)
			{
				return new Vector2(SmoothStep(p_t.x), SmoothStep(p_t.y));
			}

			public static Vector3 SmoothStep (Vector3 p_t)
			{
				return new Vector3(SmoothStep(p_t.x), SmoothStep(p_t.y), SmoothStep(p_t.z));
			}

			public static Vector4 SmoothStep (Vector4 p_t)
			{
				return new Vector4(SmoothStep(p_t.x), SmoothStep(p_t.y), SmoothStep(p_t.z), SmoothStep(p_t.w));
			}

			public static float SmoothStep (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, SmoothStep(p_t));
			}

			public static Vector2 SmoothStep (Vector2 p_from, Vector2 p_to, float p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SmoothStep(p_t));
			}

			public static Vector2 SmoothStep (Vector2 p_from, Vector2 p_to, Vector2 p_t)
			{
				return Vector2X.Lerp(p_from, p_to, SmoothStep(p_t));
			}

			public static Vector3 SmoothStep (Vector3 p_from, Vector3 p_to, float p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SmoothStep(p_t));
			}

			public static Vector3 SmoothStep (Vector3 p_from, Vector3 p_to, Vector3 p_t)
			{
				return Vector3X.Lerp(p_from, p_to, SmoothStep(p_t));
			}

			public static Vector4 SmoothStep (Vector4 p_from, Vector4 p_to, float p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SmoothStep(p_t));
			}

			public static Vector4 SmoothStep (Vector4 p_from, Vector4 p_to, Vector4 p_t)
			{
				return Vector4X.Lerp(p_from, p_to, SmoothStep(p_t));
			}

			// Step
			public static float Step (float p_value, float p_step)
			{
				return MathF.Floor(p_value * p_step) / p_step;
			}

			public static Vector2 Step (Vector2 p_value, float p_t)
			{
				return new Vector2(Step(p_value.x, p_t), Step(p_value.y, p_t));
			}

			public static Vector2 Step (Vector2 p_value, Vector2 p_t)
			{
				return new Vector2(Step(p_value.x, p_t.x), Step(p_value.y, p_t.y));
			}

			public static Vector3 Step (Vector3 p_value, float p_t)
			{
				return new Vector3(Step(p_value.x, p_t), Step(p_value.y, p_t), Step(p_value.z, p_t));
			}

			public static Vector4 Step (Vector3 p_value, Vector3 p_t)
			{
				return new Vector3(Step(p_value.x, p_t.x), Step(p_value.y, p_t.y), Step(p_value.z, p_t.z));
			}

			public static Vector4 Step (Vector4 p_value, float p_t)
			{
				return new Vector4(Step(p_value.x, p_t), Step(p_value.y, p_t), Step(p_value.z, p_t), Step(p_value.w, p_t));
			}

			public static Vector4 Step (Vector4 p_value, Vector4 p_t)
			{
				return new Vector4(Step(p_value.x, p_t.x), Step(p_value.y, p_t.y), Step(p_value.z, p_t.z), Step(p_value.w, p_t.w));
			}

		#endregion

		/// Add Inverse Easing (float, Vector2, Vector3, Vector4)
		/// Add Clamped
	}
}
