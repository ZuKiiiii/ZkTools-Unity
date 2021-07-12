using System;
using UnityEngine;

namespace ZkTools.Mathematics.Angles
{
	[System.Serializable]
	public struct Gradian : IAngle<Gradian>
	{
		#region ==============================[Constants]==============================

			// 0 //
			public const float Zero = 0.0f;

			// 30 //
			public const float Twelfth = 30f * Trigo.Degree2Gradian;

			// 45 //
			public const float Eighth = 45f * Trigo.Degree2Gradian;

			// 60 //
			public const float Sixth = 60f * Trigo.Degree2Gradian;

			// 90 //
			public const float Quarter = 90f * Trigo.Degree2Gradian;

			// 120 //
			public const float Third = 120f * Trigo.Degree2Gradian;

			// 135 //
			public const float ThreeEighth = 135f * Trigo.Degree2Gradian;

			// 150 //
			public const float FiveTwelfth = 150f * Trigo.Degree2Gradian;

			// 180 //
			public const float Half = 180f * Trigo.Degree2Gradian;

			// 210 //
			public const float SevenTwelfth = 210f * Trigo.Degree2Gradian;

			// 225 //
			public const float FiveEighth = 225f * Trigo.Degree2Gradian;

			// 240 //
			public const float TwoThird = 240f * Trigo.Degree2Gradian;

			// 270 //
			public const float ThreeQuarter = 270f * Trigo.Degree2Gradian;

			// 300 //
			public const float FiveSixth = 300f * Trigo.Degree2Gradian;

			// 315 //
			public const float SevenEighth = 315f * Trigo.Degree2Gradian;

			// 330 //
			public const float ElevenTwelfth = 330f * Trigo.Degree2Gradian;

			// 360 //
			public const float One = 360f * Trigo.Degree2Gradian;

		#endregion

		#region ==============================[Variables]==============================

			public float gradian;

		#endregion

		#region ==============================[Properties]==============================

			public Degree ToDegree {get => Trigo.GradianToDegree(gradian); set => gradian = Trigo.DegreeToGradian(value.degree);}

			public Gradian ToGradian {get => this; set => this = value;}

			public Radian ToRadian {get => Trigo.GradianToRadian(gradian); set => gradian = Trigo.RadianToGradian(value.radian);}

			public Turn ToTurn {get => Trigo.GradianToTurn(gradian); set => gradian = Trigo.TurnToGradian(value.turn);}

			public Gradian Unwinded => CalcUnwind(gradian);

			public float Value {get => gradian; set => gradian = value;}

			#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Gradian (float p_gradian)
			{
				gradian = p_gradian;
			}

			public Gradian (Gradian p_gradian)
			{
				gradian = p_gradian.gradian;
			}

		#endregion

		#region ==============================[Static Methods]==============================

			public static Gradian CalcUnwind (Gradian p_gradian)
			{
				while(p_gradian > Half)
					p_gradian -= One;

				while(p_gradian < Half)
					p_gradian += One;

				return p_gradian;
			}

			public static Gradian Delta (Gradian p_lhs, Gradian p_rhs)
			{
				return MathF.Repeat(p_rhs - p_lhs + Half, One) - Half;
			}

			public static float InverseLerp (Gradian p_a, Gradian p_b, Gradian p_value)
			{
				float angle = Delta(p_a, p_b);
				float h = p_a + angle * 0.5f;

				p_b = p_a + angle;
				p_value = h + Delta (h, p_value);

				return MathF.InverseLerpClamped(p_a, p_b, p_value);
			}

			public static Gradian Lerp (Gradian p_from, Gradian p_to, float p_t)
			{
				float delta = MathF.Repeat(p_to - p_from, One);
				if (delta > Half)
					delta -= One;
				return p_from + delta * MathF.Clamp(p_t);
			}

			public static Gradian MoveTowards (Gradian p_current, Gradian p_target, Gradian p_maxDelta)
			{
				float deltaAngle = Delta(p_current, p_target);

				if (-p_maxDelta < deltaAngle && deltaAngle < p_maxDelta)
					return p_target;

				p_target = p_current + deltaAngle;
				return MathF.MoveTowards(p_current, p_target, p_maxDelta);
			}

			public static Gradian SmoothDampAngle (Gradian p_current, Gradian p_target, ref Gradian p_currentVelocity, float p_smoothTime)
			{
				return SmoothDampAngle(p_current, p_target, ref p_currentVelocity, p_smoothTime, Time.deltaTime, MathF.Infinity);
			}

			public static Gradian SmoothDampAngle (Gradian p_current, Gradian p_target, ref Gradian p_currentVelocity, float p_smoothTime, Gradian p_maxSpeed)
			{
				return SmoothDampAngle(p_current, p_target, ref p_currentVelocity, p_smoothTime, Time.deltaTime);
			}

			public static Gradian SmoothDampAngle (Gradian p_current, Gradian p_target, ref Gradian p_currentVelocity, float p_smoothTime, float p_deltaTime)
			{
				return SmoothDampAngle(p_current, p_target, ref p_currentVelocity, p_smoothTime, Time.deltaTime, MathF.Infinity);
			}

			public static Gradian SmoothDampAngle (Gradian p_current, Gradian p_target, ref Gradian p_currentVelocity, float p_smoothTime, float p_deltaTime, Gradian p_maxSpeed)
			{
				p_target = p_current + Delta(p_current, p_target);
				return MathF.SmoothDamp(p_current, p_target, ref p_currentVelocity.gradian, p_smoothTime, p_deltaTime, p_maxSpeed);
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public bool Equals (Gradian p_other)
			{
				return this == p_other;
			}

			public int CompareTo (Gradian p_other)
			{
				return gradian.CompareTo(p_other.gradian);
			}

			public override bool Equals (object obj)
			{
				return obj is Gradian other && Equals(other);
			}

			public override int GetHashCode ()
			{
				return gradian.GetHashCode();
			}

			public override string ToString ()
			{
				return $"{gradian} grad";
			}

			public string ToString (string p_format)
			{
				return $"{gradian.ToString(p_format)} grad";

			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return $"{gradian.ToString(p_format, p_formatProvider)} grad";
			}

			public void Unwind ()
			{
				gradian = Unwinded;
			}

		#endregion

		#region ==============================[Operators]==============================

			public static bool operator== (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian == p_rhs.gradian;
			}

			public static bool operator!= (Gradian p_lhs, Gradian p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static bool operator< (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian < p_rhs.gradian;
			}

			public static bool operator<= (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian <= p_rhs.gradian;
			}

			public static bool operator> (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian > p_rhs.gradian;
			}

			public static bool operator>= (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian >= p_rhs.gradian;
			}

			public static implicit operator float (Gradian p_this)
			{
				return p_this.gradian;
			}

			public static implicit operator double (Gradian p_this)
			{
				return p_this.gradian;
			}

			public static implicit operator Gradian (float p_gradian)
			{
				return new Gradian(p_gradian);
			}

			public static implicit operator Gradian (double p_gradian)
			{
				return new Gradian(p_gradian);
			}

			public static implicit operator Degree (Gradian p_this)
			{
				return p_this.ToDegree;
			}

			public static implicit operator Radian (Gradian p_this)
			{
				return p_this.ToRadian;
			}

			public static implicit operator Turn (Gradian p_this)
			{
				return p_this.ToTurn;
			}

			public static Gradian operator+ (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian + p_rhs.gradian;
			}

			public static Gradian operator- (Gradian p_this)
			{
				return p_this.gradian;
			}

			public static Gradian operator- (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian - p_rhs.gradian;
			}

			public static Gradian operator* (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian * p_rhs.gradian;
			}

			public static Gradian operator/ (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian / p_rhs.gradian;
			}

			public static Gradian operator% (Gradian p_lhs, Gradian p_rhs)
			{
				return p_lhs.gradian % p_rhs.gradian;
			}

		#endregion
	}
}