using System;
using UnityEngine;

namespace ZkTools.Mathematics.Angles
{
	[System.Serializable]
	public struct Radian : IAngle<Radian>
	{
		#region ==============================[Constants]==============================

			// 0 //
			public const float Zero = 0.0f;

			// 30 //
			public const float Twelfth = 30f * Trigo.Degree2Radian;

			// 45 //
			public const float Eighth = 45f * Trigo.Degree2Radian;

			// 60 //
			public const float Sixth = 60f * Trigo.Degree2Radian;

			// 90 //
			public const float Quarter = 90f * Trigo.Degree2Radian;

			// 120 //
			public const float Third = 120f * Trigo.Degree2Radian;

			// 135 //
			public const float ThreeEighth = 135f * Trigo.Degree2Radian;

			// 150 //
			public const float FiveTwelfth = 150f * Trigo.Degree2Radian;

			// 180 //
			public const float Half = 180f * Trigo.Degree2Radian;

			// 210 //
			public const float SevenTwelfth = 210f * Trigo.Degree2Radian;

			// 225 //
			public const float FiveEighth = 225f * Trigo.Degree2Radian;

			// 240 //
			public const float TwoThird = 240f * Trigo.Degree2Radian;

			// 270 //
			public const float ThreeQuarter = 270f * Trigo.Degree2Radian;

			// 300 //
			public const float FiveSixth = 300f * Trigo.Degree2Radian;

			// 315 //
			public const float SevenEighth = 315f * Trigo.Degree2Radian;

			// 330 //
			public const float ElevenTwelfth = 330f * Trigo.Degree2Radian;

			// 360 //
			public const float One = 360f * Trigo.Degree2Radian;

		#endregion

		#region ==============================[Variables]==============================

			public float radian;

		#endregion

		#region ==============================[Properties]==============================

			public Degree ToDegree {get => Trigo.RadianToDegree(radian); set => radian = Trigo.DegreeToRadian(value.degree);}

			public Gradian ToGradian {get => Trigo.RadianToGradian(radian); set => radian = Trigo.GradianToRadian(value.gradian);}

			public Radian ToRadian {get => this; set => this = value;}

			public Turn ToTurn {get => Trigo.RadianToTurn(radian); set => radian = Trigo.TurnToRadian(value.turn);}

			public Radian Unwinded => CalcUnwind(radian);

			public float Value {get => radian; set => radian = value;}

			#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Radian (float p_radian)
			{
				radian = p_radian;
			}

			public Radian (Radian p_radian)
			{
				radian = p_radian.radian;
			}

		#endregion

		#region ==============================[Static Methods]==============================

			public static Radian CalcUnwind (Radian p_radian)
			{
				while(p_radian > Half)
					p_radian -= One;

				while(p_radian < Half)
					p_radian += One;

				return p_radian;
			}

			public static Radian Delta (Radian p_lhs, Radian p_rhs)
			{
				return MathF.Repeat(p_rhs - p_lhs + Half, One) - Half;
			}

			public static float InverseLerp (Radian p_a, Radian p_b, Radian p_value)
			{
				float angle = Delta(p_a, p_b);
				float h = p_a + angle * 0.5f;

				p_b = p_a + angle;
				p_value = h + Delta (h, p_value);

				return MathF.InverseLerpClamped(p_a, p_b, p_value);
			}

			public static Radian Lerp (Radian p_from, Radian p_to, float p_t)
			{
				float delta = MathF.Repeat(p_to - p_from, One);
				if (delta > Half)
					delta -= One;
				return p_from + delta * MathF.Clamp(p_t);
			}

			public static Radian MoveTowards (Radian p_current, Radian p_target, Radian p_maxDelta)
			{
				float deltaAngle = Delta(p_current, p_target);

				if (-p_maxDelta < deltaAngle && deltaAngle < p_maxDelta)
					return p_target;

				p_target = p_current + deltaAngle;
				return MathF.MoveTowards(p_current, p_target, p_maxDelta);
			}

			public static Radian SmoothDampAngle (Radian p_current, Radian p_target, ref Radian p_currentVelocity, float p_smoothTime)
			{
				return SmoothDampAngle(p_current, p_target, ref p_currentVelocity, p_smoothTime, Time.deltaTime, MathF.Infinity);
			}

			public static Radian SmoothDampAngle (Radian p_current, Radian p_target, ref Radian p_currentVelocity, float p_smoothTime, Radian p_maxSpeed)
			{
				return SmoothDampAngle(p_current, p_target, ref p_currentVelocity, p_smoothTime, Time.deltaTime);
			}

			public static Radian SmoothDampAngle (Radian p_current, Radian p_target, ref Radian p_currentVelocity, float p_smoothTime, float p_deltaTime)
			{
				return SmoothDampAngle(p_current, p_target, ref p_currentVelocity, p_smoothTime, Time.deltaTime, MathF.Infinity);
			}

			public static Radian SmoothDampAngle (Radian p_current, Radian p_target, ref Radian p_currentVelocity, float p_smoothTime, float p_deltaTime, Radian p_maxSpeed)
			{
				p_target = p_current + Delta(p_current, p_target);
				return MathF.SmoothDamp(p_current, p_target, ref p_currentVelocity.radian, p_smoothTime, p_deltaTime, p_maxSpeed);
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public int CompareTo (Radian p_other)
			{
				return radian.CompareTo(p_other.radian);
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is Radian other && Equals(other);
			}

			public bool Equals (Radian p_other)
			{
				return this == p_other;
			}

			public override int GetHashCode ()
			{
				return radian.GetHashCode();
			}

			public override string ToString ()
			{
				return $"{radian} rad";
			}

			public string ToString (string p_format)
			{
				return $"{radian.ToString(p_format)} rad";

			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return $"{radian.ToString(p_format, p_formatProvider)} rad";
			}

			public void Unwind ()
			{
				radian = Unwinded;
			}

		#endregion

		#region ==============================[Operators]==============================

			public static bool operator== (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian == p_rhs.radian;
			}

			public static bool operator!= (Radian p_lhs, Radian p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static bool operator< (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian < p_rhs.radian;
			}

			public static bool operator<= (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian <= p_rhs.radian;
			}

			public static bool operator> (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian > p_rhs.radian;
			}

			public static bool operator>= (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian >= p_rhs.radian;
			}

			public static implicit operator float (Radian p_this)
			{
				return p_this.radian;
			}

			public static implicit operator double (Radian p_this)
			{
				return p_this.radian;
			}

			public static implicit operator Radian (float p_radian)
			{
				return new Radian(p_radian);
			}

			public static implicit operator Radian (double p_radian)
			{
				return new Radian(p_radian);
			}

			public static implicit operator Degree (Radian p_this)
			{
				return p_this.ToDegree;
			}

			public static implicit operator Gradian (Radian p_this)
			{
				return p_this.ToGradian;
			}

			public static implicit operator Turn (Radian p_this)
			{
				return p_this.ToTurn;
			}

			public static Radian operator+ (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian + p_rhs.radian;
			}

			public static Radian operator- (Radian p_this)
			{
				return p_this.radian;
			}

			public static Radian operator- (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian - p_rhs.radian;
			}

			public static Radian operator* (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian * p_rhs.radian;
			}

			public static Radian operator/ (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian / p_rhs.radian;
			}

			public static Radian operator% (Radian p_lhs, Radian p_rhs)
			{
				return p_lhs.radian % p_rhs.radian;
			}

		#endregion
	}
}