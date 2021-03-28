using System;
using ZkTools.Mathematics.Extensions;

namespace ZkTools.Mathematics.Ranges
{
	[System.Serializable]
	public struct RangeInt : IEquatable<RangeInt>, IFormattable
	{
		#region // ==============================[Variables]============================== //

			public int max;

			public int min;

		#endregion

		#region // ==============================[Properties]============================== //

			public bool IsValid => (max - min).IsPositiveOrZero();

			public int Length
			{
				get => max - min;
				set => max = min + value;
			}

		#endregion

		#region // ==============================[Properties]============================== //

			public RangeInt (int p_min, int p_max)
			{
				max = p_max;
				min = p_min;
			}

			public RangeInt (RangeInt p_copy)
			{
				max = p_copy.max;
				min = p_copy.min;
			}

		#endregion

		#region // ==============================[Static Methods]============================== //

			public static bool IsInside (int p_value, int p_min, int p_max, ERange p_range)
			{
				switch (p_range)
				{
					case ERange.Ex : return IsInsideEx(p_value, p_min, p_max);
					case ERange.ExIn : return IsInsideExIn(p_value, p_min, p_max);
					case ERange.In : return IsInsideIn(p_value, p_min, p_max);
					case ERange.InEx : return IsInsideInEx(p_value, p_min, p_max);
					default : throw new System.ArgumentOutOfRangeException();
				}
			}

			public static bool IsInside (int p_value, int p_min, int p_max, ERangeSide p_minSide, ERangeSide p_maxSide)
			{
				return IsInside(p_value, p_min, p_max, ERangeX.Convert(p_minSide, p_maxSide));
			}

			public static bool IsInsideEx (int p_value, int p_minExclusiveValue, int p_maxExclusiveValue)
			{
				return p_minExclusiveValue < p_value && p_value < p_maxExclusiveValue;
			}

			public static bool IsInsideExIn (int p_value, int p_minExclusiveValue, int p_maxInclusiveValue)
			{
				return p_minExclusiveValue < p_value && p_value <= p_maxInclusiveValue;
			}

			public static bool IsInsideIn (int p_value, int p_minInclusiveValue, int p_maxInclusiveValue)
			{
				return p_minInclusiveValue <= p_value && p_value <= p_maxInclusiveValue;
			}

			public static bool IsInsideInEx (int p_value, int p_minInclusiveValue, int p_maxExclusiveValue)
			{
				return p_minInclusiveValue <= p_value && p_value < p_maxExclusiveValue;
			}

			public static bool IsOutside (int p_value, int p_min, int p_max, ERange p_range)
			{
				switch (p_range)
				{
					case ERange.Ex : return IsOutsideEx(p_value, p_min, p_max);
					case ERange.ExIn : return IsOutsideExIn(p_value, p_min, p_max);
					case ERange.In : return IsOutsideIn(p_value, p_min, p_max);
					case ERange.InEx : return IsOutsideInEx(p_value, p_min, p_max);
					default : throw new System.ArgumentOutOfRangeException();
				}
			}

			public static bool IsOutside (int p_value, int p_min, int p_max, ERangeSide p_minSide, ERangeSide p_maxSide)
			{
				return IsOutside(p_value, p_min, p_max, ERangeX.Convert(p_minSide, p_maxSide));
			}

			public static bool IsOutsideEx (int p_value, int p_minExclusiveValue, int p_maxExclusiveValue)
			{
				return p_value < p_minExclusiveValue || p_maxExclusiveValue < p_value;
			}

			public static bool IsOutsideExIn (int p_value, int p_minExclusiveValue, int p_maxInclusiveValue)
			{
				return p_value < p_minExclusiveValue || p_maxInclusiveValue <= p_value;
			}

			public static bool IsOutsideIn (int p_value, int p_minInclusiveValue, int p_maxInclusiveValue)
			{
				return p_value <= p_minInclusiveValue || p_maxInclusiveValue <= p_value;
			}

			public static bool IsOutsideInEx (int p_value, int p_minInclusiveValue, int p_maxExclusiveValue)
			{
				return p_value <= p_minInclusiveValue || p_maxExclusiveValue < p_value;
			}

		#endregion

		#region // ==============================[Methods]============================== //

			public bool IsInside (int p_value, ERange p_range)
			{
				return IsInside(p_value, min, max, p_range);
			}

			public bool IsInside (int p_value, ERangeSide p_minSide, ERangeSide p_maxSide)
			{
				return IsInside(p_value, min, max, p_minSide, p_maxSide);
			}

			public bool IsInsideEx (int p_value)
			{
				return IsInsideEx(p_value, min, max);
			}

			public bool IsInsideExIn (int p_value)
			{
				return IsInsideExIn(p_value, min, max);
			}

			public bool IsInsideIn (int p_value)
			{
				return IsInsideIn(p_value, min, max);
			}

			public bool IsInsideInEx (int p_value)
			{
				return IsInsideInEx(p_value, min, max);
			}

			public bool IsOutside (int p_value, ERange p_range)
			{
				return IsOutside(p_value, min, max, p_range);
			}

			public bool IsOutside (int p_value, ERangeSide p_minSide, ERangeSide p_maxSide)
			{
				return IsOutside(p_value, min, max, p_minSide, p_maxSide);
			}

			public bool IsOutsideEx (int p_value)
			{
				return IsOutsideEx(p_value, min, max);
			}

			public bool IsOutsideExIn (int p_value)
			{
				return IsOutsideExIn(p_value, min, max);
			}

			public bool IsOutsideIn (int p_value)
			{
				return IsOutsideIn(p_value, min, max);
			}

			public bool IsOutsideInEx (int p_value)
			{
				return IsOutsideInEx(p_value, min, max);
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public override bool Equals (object obj)
			{
				return obj is Range other && Equals(other);
			}

			public bool Equals (RangeInt p_other)
			{
				throw new NotImplementedException();
			}

			public override int GetHashCode ()
			{
				unchecked
				{
					return (max.GetHashCode() * 397) ^ min.GetHashCode();
				}
			}

			public override string ToString ()
			{
				return $"[{min},{max}]";
			}
			
			public string ToString (string p_format)
			{
				return $"[{min.ToString(p_format)},{max.ToString(p_format)}]";
			}
			
			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return $"[{min.ToString(p_format, p_formatProvider)},{max.ToString(p_format, p_formatProvider)}]";
			}

		#endregion

		#region // ==============================[Operators]============================== //

			public static bool operator== (RangeInt p_lhs, RangeInt p_rhs)
			{
				return p_lhs.min == p_rhs.min && p_lhs.max == p_rhs.max;
			}

			public static bool operator!= (RangeInt p_lhs, RangeInt p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

		#endregion
	}
}
