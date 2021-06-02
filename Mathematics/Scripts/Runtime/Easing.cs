using System;
using UnityEngine;

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

			// Back
			public static float BackIn (float p_t)
			{
				return p_t * p_t * (C3 * p_t - C1);
			}

			public static float BackIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * BackIn(p_t);
			}

			public static float BackInOut (float p_t)
			{
				return p_t < 0.5f
						? MathF.Square(2.0f * p_t) * ((C2 + 1) * 2.0f * p_t - C2) * 0.5f
						: MathF.Square(2.0f * p_t - 2.0f)  *((C2 + 1) * (p_t * 2.0f - 2.0f) + 2) * 0.5f;
			}

			public static float BackInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * BackInOut(p_t);
			}

			public static float BackOut (float p_t)
			{
				return 1 + C3 * MathF.Cube(p_t - 1.0f) + C1 * MathF.Square(p_t - 1.0f);
			}

			public static float BackOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * BackOut(p_t);
			}

			// Bounce
			public static float BounceIn (float p_t)
			{
				return 1.0f - BounceOut(1.0f - p_t);
			}

			public static float BounceIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * BounceIn(p_t);
			}

			public static float BounceInOut (float p_t)
			{
				return p_t < 0.5f
					? (1 - BounceOut(1 - 2 * p_t)) * 0.5f
					: (1 + BounceOut(2 * p_t - 1)) * 0.5f;
			}

			public static float BounceInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * BounceInOut(p_t);
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

			public static float BounceOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * BounceOut(p_t);
			}

			public static float BounceOutIn (float p_t)
			{
				return (p_t < 0.5f) ? BounceOut(p_t * 2.0f) * 0.5f : BounceIn(p_t * 2.0f) * 0.5f;
			}

			public static float BounceOutIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * BounceOutIn(p_t);
			}

			// Circular //
			public static float CircularIn (float p_t)
			{
				return 1.0f - MathF.Sqrt(1.0f - MathF.Square(p_t));
			}

			public static float CircularIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * CircularIn(p_t);
			}

			public static float CircularInOut (float p_t)
			{
				return p_t < 0.5
					? (1 - MathF.Sqrt(1 - MathF.Square(2 * p_t))) * 0.5f
					: (MathF.Sqrt(1 - MathF.Square(-2 * p_t + 2)) + 1) * 0.5f;
			}

			public static float CircularInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * CircularInOut(p_t);
			}

			public static float CircularOut (float p_t)
			{
				return MathF.Sqrt(1.0f - MathF.Square(p_t - 1.0f));
			}

			public static float CircularOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * CircularOut(p_t);
			}

			public static float CircularOutIn (float p_t)
			{
				return (p_t < 0.5f)
					? 0.5f * MathF.Sqrt(1.0f - MathF.Square(p_t * 2.0f - 1.0f))
					: -0.5f * (MathF.Sqrt(1.0f - MathF.Square(p_t * 2.0f - 1.0f) - 1.0f) - 1.0f);
			}

			public static float CircularOutIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * CircularOut(p_t);
			}

			// cubic 
			public static float CubicIn (float p_t)
			{
				return MathF.Cube(p_t);
			}

			public static float CubicIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * CubicIn(p_t);
			}

			public static float CubicInOut (float p_t)
			{
				return p_t < 0.5f
					? 4 * MathF.Cube(p_t)
					: 1 - MathF.Cube(-2 * p_t + 2) * 0.5f;
			}

			public static float CubicInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * CubicInOut(p_t);
			}

			public static float CubicOut (float p_t)
			{
				return 1.0f - MathF.Cube(1.0f - p_t);
			}

			public static float CubicOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * CubicOut(p_t);
			}

			public static float CubicOutIn (float p_t)
			{
				return 0.5f * MathF.Cube(p_t * 2.0f - 1.0f) + 1.0f;
			}

			public static float CubicOutIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * CubicOutIn(p_t);
			}

			// Ease
			public static Func<float, float> Ease (EEase p_type)
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
					case EEase.Linear : return Linear;
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

			public static float Ease (EEase p_type, float p_t)
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
					case EEase.Linear : return Linear(p_t);
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

			public static float Ease (EEase p_type, float p_from, float p_to, float p_t)
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
					case EEase.Linear : return Linear(p_from, p_to, p_t);
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

			public static Func<float, float, float, float> EaseInt (EEase p_type)
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
					case EEase.Linear : return Linear;
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

			public static float ElasticIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * ElasticIn(p_t);
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

			public static float ElasticInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * ElasticInOut(p_t);
			}

			public static float ElasticOut (float p_t)
			{
				return p_t == 0
					? 0
					: p_t == 1
						? 1
						: Mathf.Pow(2, -10f * p_t) * Trigo.Sin((p_t * 10f - 0.75f) * C4) + 1f;
			}

			public static float ElasticOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * ElasticOut(p_t);
			}

			// Exponential
			public static float ExponentialIn (float p_t)
			{
				return p_t == 0 ? 0 : MathF.Pow(2, 10 * p_t - 10);
			}

			public static float ExponentialIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * ExponentialIn(p_t);
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

			public static float ExponentialInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * ExponentialInOut(p_t);
			}

			public static float ExponentialOut (float p_t)
			{
				return p_t == 1f ? 1f : 1f - MathF.Pow(2, -10 * p_t);
			}

			public static float ExponentialOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * ExponentialOut(p_t);
			}

			public static float ExponentialOutIn (float p_t)
			{
				return p_t == 1f ? 1f : 1f - MathF.Pow(2, -10 * p_t);
			}

			public static float ExponentialOutIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * ExponentialOutIn(p_t);
			}

			// Linear
			public static float Linear (float p_t)
			{
				return p_t;
			}
			
			public static float Linear (float p_from, float p_to, float p_t)
			{
				return MathF.Lerp(p_from, p_to, p_t);
			}

			// Quadratic
			public static float QuadraticIn (float p_t)
			{
				return MathF.Square(p_t);
			}

			public static float QuadraticIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuadraticIn(p_t);
			}

			public static float QuadraticInOut (float p_t)
			{
				return p_t < 0.5 ? 2 * MathF.Square(p_t) : 1f - MathF.Square(-2 * p_t + 2) * 0.5f;
			}

			public static float QuadraticInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuadraticInOut(p_t);
			}

			public static float QuadraticOut (float p_t)
			{
				return 1.0f - MathF.Square(1.0f - p_t);
			}

			public static float QuadraticOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuadraticOut(p_t);
			}

			public static float QuadraticOutIn (float p_t)
			{
				return (p_t < 0.5f) ? QuadraticOut(p_t * 2.0f) * 0.5f : QuadraticIn(p_t * 2.0f) * 0.5f;
			}

			public static float QuadraticOutIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuadraticOutIn(p_t);
			}

			// Quartic
			public static float QuarticIn (float p_t)
			{
				return MathF.Quartic(p_t);
			}

			public static float QuarticIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuarticIn(p_t);
			}

			public static float QuarticInOut (float p_t)
			{
				return p_t < 0.5f ? 8 * MathF.Quartic(p_t) : 1 - MathF.Quartic(-2 * p_t + 2) * 0.5f;
			}

			public static float QuarticInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuarticInOut(p_t);
			}

			public static float QuarticOut (float p_t)
			{
				return 1f - MathF.Quartic(1f - p_t);
			}

			public static float QuarticOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuarticOut(p_t);
			}

			public static float QuarticOutIn (float p_t)
			{
				return (p_t < 0.5f) 
					? -0.5f * MathF.Quartic(p_t * 2.0f - 1.0f) + 0.5f
					: 0.5f * MathF.Quartic(p_t * 2.0f - 1.0f) + 0.5f;
			}

			public static float QuarticOutIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuarticOutIn(p_t);
			}

			// Quintic
			public static float QuinticIn (float p_t)
			{
				return MathF.Quintic(p_t);
			}

			public static float QuinticIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuinticIn(p_t);
			}

			public static float QuinticInOut (float p_t)
			{
				return p_t < 0.5f ? 16 * MathF.Quintic(p_t) : 1 - MathF.Quintic(-2 * p_t + 2) * 0.5f;
			}

			public static float QuinticInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuinticInOut(p_t);
			}

			public static float QuinticOut (float p_t)
			{
				return 1f - MathF.Quintic(1f - p_t);
			}

			public static float QuinticOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuinticOut(p_t);
			}

			public static float QuinticOutIn (float p_t)
			{
				return 0.5f * MathF.Quintic(p_t * 2.0f - 1.0f) + 1.0f;
			}

			public static float QuinticOutIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * QuinticOutIn(p_t);
			}

			// Sinusoidal
			public static float SinusoidalIn (float p_t)
			{
				return 1f - Trigo.Cos(p_t * Trigo.PiDivTwo);
			}

			public static float SinusoidalIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * SinusoidalIn(p_t);
			}

			public static float SinusoidalInOut (float p_t)
			{
				return -(Trigo.Cos(Trigo.Pi * p_t) - 1) * 0.5f;
			}

			public static float SinusoidalInOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * SinusoidalInOut(p_t);
			}

			public static float SinusoidalOut (float p_t)
			{
				return Trigo.Sin(p_t * Trigo.PiDivTwo);
			}

			public static float SinusoidalOut (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * SinusoidalOut(p_t);
			}

			public static float SinusoidalOutIn (float p_t)
			{
				return (p_t < 0.5f) 
						? 0.5f * Trigo.Sin(p_t * Trigo.Pi) 
						: -0.5f *  Trigo.Cos((p_t * 2.0f - 1.0f) * Trigo.PiDivTwo) + 1.0f;
			}

			public static float SinusoidalOutIn (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * SinusoidalOutIn(p_t);
			}

			// SmoothStep
			public static float SmoothStep (float p_t)
			{
				return MathF.Square(p_t) * (3f - 2f * p_t);
			}

			public static float SmoothStep (float p_from, float p_to, float p_t)
			{
				return p_from + (p_from - p_to) * SmoothStep(p_t);
			}

			// Step
			public static float Step (float p_value, float p_step)
			{
				return MathF.Floor(p_value * p_step) / p_step;
			}

		#endregion
		
		/// Add Easing With Vector
		/// Add Inverse Easing (float, Vector2, Vector3, Vector4)
		/// Add Clamped
	}
}
