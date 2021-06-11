using System;

namespace ZkTools.Mathematics.Angles
{
	public struct Turn : IAngle<Turn>
	{
		#region // ==============================[Constants]============================== //

			// 0 //
			public const float Zero = 0.0f;

			// 30 //
			public const float Twelfth = 30f * Trigo.Degree2Turn;

			// 45 //
			public const float Eighth = 45f * Trigo.Degree2Turn;

			// 60 //
			public const float Sixth = 60f * Trigo.Degree2Turn;

			// 90 //
			public const float Quarter = 90f * Trigo.Degree2Turn;

			// 120 //
			public const float Third = 120f * Trigo.Degree2Turn;

			// 135 //
			public const float ThreeEighth = 135f * Trigo.Degree2Turn;

			// 150 //
			public const float FiveTwelfth = 150f * Trigo.Degree2Turn;

			// 180 //
			public const float Half = 180f * Trigo.Degree2Turn;

			// 210 //
			public const float SevenTwelfth = 210f * Trigo.Degree2Turn;

			// 225 //
			public const float FiveEighth = 225f * Trigo.Degree2Turn;

			// 240 //
			public const float TwoThird = 240f * Trigo.Degree2Turn;

			// 270 //
			public const float ThreeQuarter = 270f * Trigo.Degree2Turn;

			// 300 //
			public const float FiveSixth = 300f * Trigo.Degree2Turn;

			// 315 //
			public const float SevenEighth = 315f * Trigo.Degree2Turn;

			// 330 //
			public const float ElevenTwelfth = 330f * Trigo.Degree2Turn;

			// 360 //
			public const float One = 360f * Trigo.Degree2Turn;

		#endregion

		#region // ==============================[Variables]============================== //

			public float turn;

		#endregion

		#region // ==============================[Properties]============================== //

			public Degree ToDegree {get => Trigo.TurnToDegree(turn); set => turn = Trigo.DegreeToTurn(value.degree);}

			public Gradian ToGradian {get => Trigo.TurnToGradian(turn); set => turn = Trigo.GradianToTurn(value.gradian);}

			public Radian ToRadian {get => Trigo.TurnToRadian(turn); set => turn = Trigo.RadianToTurn(value.radian);}

			public Turn ToTurn {get => this; set => this = value;}

			public Turn Unwinded => CalcUnwind(turn);

			public float Value {get => turn; set => turn = value;}

		#endregion

		#region // ==============================[Constructor + Destructor]============================== //

			public Turn (float p_turn)
			{
				turn = p_turn;
			}

			public Turn (Turn p_turn)
			{
				turn = p_turn.turn;
			}

		#endregion

		#region // ==============================[Static Methods]============================== //

			public static Turn CalcUnwind (Turn p_turn)
			{
				while(p_turn > Half)
					p_turn -= One;

				while(p_turn < Half)
					p_turn += One;

				return p_turn;
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public int CompareTo (Turn p_other)
			{
				return turn.CompareTo(p_other.turn);
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is Turn other && Equals(other);
			}

			public bool Equals (Turn p_other)
			{
				return this == p_other;
			}

			public override int GetHashCode ()
			{
				return turn.GetHashCode();
			}

			public override string ToString ()
			{
				return $"{turn} grad";
			}

			public string ToString (string p_format)
			{
				return $"{turn.ToString(p_format)} grad";

			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return $"{turn.ToString(p_format, p_formatProvider)} grad";
			}

			public void Unwind ()
			{
				turn = Unwinded;
			}

		#endregion

		#region // ==============================[Operators]============================== //

			public static bool operator== (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn == p_rhs.turn;
			}

			public static bool operator!= (Turn p_lhs, Turn p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static bool operator< (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn < p_rhs.turn;
			}

			public static bool operator<= (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn <= p_rhs.turn;
			}

			public static bool operator> (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn > p_rhs.turn;
			}

			public static bool operator>= (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn >= p_rhs.turn;
			}

			public static implicit operator float (Turn p_this)
			{
				return p_this.turn;
			}

			public static implicit operator double (Turn p_this)
			{
				return p_this.turn;
			}

			public static implicit operator Turn (float p_turn)
			{
				return new Turn(p_turn);
			}

			public static implicit operator Turn (double p_turn)
			{
				return new Turn(p_turn);
			}

			public static implicit operator Degree (Turn p_this)
			{
				return p_this.ToDegree;
			}

			public static implicit operator Gradian (Turn p_this)
			{
				return p_this.ToGradian;
			}

			public static implicit operator Radian (Turn p_this)
			{
				return p_this.ToRadian;
			}

			public static Turn operator+ (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn + p_rhs.turn;
			}

			public static Turn operator- (Turn p_this)
			{
				return p_this.turn;
			}

			public static Turn operator- (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn - p_rhs.turn;
			}

			public static Turn operator* (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn * p_rhs.turn;
			}

			public static Turn operator/ (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn / p_rhs.turn;
			}

			public static Turn operator% (Turn p_lhs, Turn p_rhs)
			{
				return p_lhs.turn % p_rhs.turn;
			}

		#endregion
	}
}