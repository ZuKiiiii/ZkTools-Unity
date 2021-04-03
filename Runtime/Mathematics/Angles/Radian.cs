using System;

namespace ZkTools.Mathematics.Angles
{
	public struct Radian : IAngle<Radian>
	{
		#region // ==============================[Constants]============================== //

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

		#region // ==============================[Variables]============================== //

			public float radian;

		#endregion 

		#region // ==============================[Properties]============================== //

			public Degree ToDegree {get => Trigo.RadianToDegree(radian); set => radian = Trigo.DegreeToRadian(value.degree);}

			public Gradian ToGradian {get => Trigo.RadianToGradian(radian); set => radian = Trigo.GradianToRadian(value.gradian);}

			public Radian ToRadian {get => this; set => this = value;}

			public Turn ToTurn {get => Trigo.RadianToTurn(radian); set => radian = Trigo.TurnToRadian(value.turn);}

			public float Value {get => radian; set => radian = value;}

			#endregion

		#region // ==============================[Constructor + Destructor]============================== //

			public Radian (float p_radian)
			{
				radian = p_radian;
			}

			public Radian (Radian p_radian)
			{
				radian = p_radian.radian;
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

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

		#endregion

		#region // ==============================[Operators]============================== //

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

			public static implicit operator Radian (float p_radian)
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