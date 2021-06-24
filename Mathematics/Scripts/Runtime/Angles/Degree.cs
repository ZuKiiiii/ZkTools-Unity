using System;

namespace ZkTools.Mathematics.Angles
{
	[System.Serializable]
	public struct Degree : IAngle<Degree>
	{
		#region // ==============================[Constants]============================== //

			// 0 //
			public const float Zero = 0f;

			// 30 //
			public const float Twelfth = 30f;

			// 45 //
			public const float Eighth = 45f;

			// 60 //
			public const float Sixth = 60f;

			// 90 //
			public const float Quarter = 90f;

			// 120 //
			public const float Third = 120f;

			// 135 //
			public const float ThreeEighth = 135f;

			// 150 //
			public const float FiveTwelfth = 150f;

			// 180 //
			public const float Half = 180f;

			// 210 //
			public const float SevenTwelfth = 210f;

			// 225 //
			public const float FiveEighth = 225f;

			// 240 //
			public const float TwoThird = 240f;

			// 270 //
			public const float ThreeQuarter = 270f;

			// 300 //
			public const float FiveSixth = 300f;

			// 315 //
			public const float SevenEighth = 315f;

			// 330 //
			public const float ElevenTwelfth = 330f;

			// 360 //
			public const float One = 360f;

		#endregion

		#region // ==============================[Variables]============================== //

			public float degree;

		#endregion

		#region // ==============================[Properties]============================== //

			public Degree ToDegree {get => this; set => this = value;}

			public Gradian ToGradian {get => Trigo.DegreeToGradian(degree); set => degree =Trigo.GradianToDegree(value.gradian);}

			public Radian ToRadian {get => Trigo.DegreeToRadian(degree); set => degree =Trigo.RadianToDegree(value.radian);}

			public Turn ToTurn {get => Trigo.DegreeToGradian(degree); set => degree =Trigo.TurnToDegree(value.turn);}

			public Degree Unwinded => CalcUnwind(degree);

			public float Value {get => degree; set => degree = value;}

		#endregion

		#region // ==============================[Constructor + Destructor]============================== //

			public Degree (float p_degree)
			{
				degree = p_degree;
			}

			public Degree (Degree p_degree)
			{
				degree = p_degree.degree;
			}

		#endregion

		#region // ==============================[Static Methods]============================== //

			public static Degree CalcUnwind (Degree p_degree)
			{
				while(p_degree > Half)
					p_degree -= One;

				while(p_degree < Half)
					p_degree += One;

				return p_degree;
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public int CompareTo (Degree p_other)
			{
				return degree.CompareTo(p_other.degree);
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is Degree other && Equals(other);
			}

			public bool Equals (Degree p_other)
			{
				return this == p_other;
			}

			public override int GetHashCode ()
			{
				return degree.GetHashCode();
			}

			public override string ToString ()
			{
				return $"{degree}°";
			}

			public string ToString (string p_format)
			{
				return $"{degree.ToString(p_format)}°";

			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return $"{degree.ToString(p_format, p_formatProvider)}°";
			}

			public void Unwind ()
			{
				degree = Unwinded;
			}

		#endregion

		#region // ==============================[Operators]============================== //

			public static bool operator== (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree == p_rhs.degree;
			}

			public static bool operator!= (Degree p_lhs, Degree p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static bool operator< (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree < p_rhs.degree;
			}

			public static bool operator<= (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree <= p_rhs.degree;
			}

			public static bool operator> (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree > p_rhs.degree;
			}

			public static bool operator>= (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree >= p_rhs.degree;
			}

			public static implicit operator float (Degree p_this)
			{
				return p_this.degree;
			}

			public static implicit operator double (Degree p_this)
			{
				return p_this.degree;
			}

			public static implicit operator Degree (float p_degree)
			{
				return new Degree(p_degree);
			}

			public static implicit operator Degree (double p_degree)
			{
				return new Degree(p_degree);
			}

			public static implicit operator Radian (Degree p_this)
			{
				return p_this.ToRadian;
			}

			public static implicit operator Gradian (Degree p_this)
			{
				return p_this.ToGradian;
			}

			public static implicit operator Turn (Degree p_this)
			{
				return p_this.ToTurn;
			}

			public static Degree operator+ (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree + p_rhs.degree;
			}

			public static Degree operator- (Degree p_this)
			{
				return p_this.degree;
			}

			public static Degree operator- (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree - p_rhs.degree;
			}

			public static Degree operator* (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree * p_rhs.degree;
			}

			public static Degree operator/ (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree / p_rhs.degree;
			}

			public static Degree operator% (Degree p_lhs, Degree p_rhs)
			{
				return p_lhs.degree % p_rhs.degree;
			}

		#endregion
	}
}