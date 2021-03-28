using System;
using ZkTools.Mathematics.Extensions;

namespace ZkTools.Mathematics.Ranges
{
	[System.Serializable]
	public struct Range : IEquatable<Range>, IFormattable
	{
		#region // ==============================[Variables]============================== //

			public float max;

			public float min;

		#endregion

		#region // ==============================[Properties]============================== //

			public bool IsValid => (max - min).IsPositiveOrZero();

			public float Length
			{
				get => max - min;
				set => max = min + value;
			}

		#endregion

		#region // ==============================[Properties]============================== //

			public Range (float p_min, float p_max)
			{
				max = p_max;
				min = p_min;
			}

			public Range (Range p_copy)
			{
				max = p_copy.max;
				min = p_copy.min;
			}

		#endregion

		#region // ==============================[Static Methods]============================== //

			public static bool IsInside (float p_value, float p_min, float p_max, ERange p_range)
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

			public static bool IsInside (float p_value, float p_min, float p_max, ERangeSide p_minSide, ERangeSide p_maxSide)
			{
				return IsInside(p_value, p_min, p_max, ERangeX.Convert(p_minSide, p_maxSide));
			}

			public static bool IsInsideEx (float p_value, float p_minExclusiveValue, float p_maxExclusiveValue)
			{
				return p_minExclusiveValue < p_value && p_value < p_maxExclusiveValue;
			}

			public static bool IsInsideExIn (float p_value, float p_minExclusiveValue, float p_maxInclusiveValue)
			{
				return p_minExclusiveValue < p_value && p_value <= p_maxInclusiveValue;
			}

			public static bool IsInsideIn (float p_value, float p_minInclusiveValue, float p_maxInclusiveValue)
			{
				return p_minInclusiveValue <= p_value && p_value <= p_maxInclusiveValue;
			}

			public static bool IsInsideInEx (float p_value, float p_minInclusiveValue, float p_maxExclusiveValue)
			{
				return p_minInclusiveValue <= p_value && p_value < p_maxExclusiveValue;
			}

			public static bool IsOutside (float p_value, float p_min, float p_max, ERange p_range)
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

			public static bool IsOutside (float p_value, float p_min, float p_max, ERangeSide p_minSide, ERangeSide p_maxSide)
			{
				return IsOutside(p_value, p_min, p_max, ERangeX.Convert(p_minSide, p_maxSide));
			}

			public static bool IsOutsideEx (float p_value, float p_minExclusiveValue, float p_maxExclusiveValue)
			{
				return p_value < p_minExclusiveValue || p_maxExclusiveValue < p_value;
			}

			public static bool IsOutsideExIn (float p_value, float p_minExclusiveValue, float p_maxInclusiveValue)
			{
				return p_value < p_minExclusiveValue || p_maxInclusiveValue <= p_value;
			}

			public static bool IsOutsideIn (float p_value, float p_minInclusiveValue, float p_maxInclusiveValue)
			{
				return p_value <= p_minInclusiveValue || p_maxInclusiveValue <= p_value;
			}

			public static bool IsOutsideInEx (float p_value, float p_minInclusiveValue, float p_maxExclusiveValue)
			{
				return p_value <= p_minInclusiveValue || p_maxExclusiveValue < p_value;
			}

		#endregion

		#region // ==============================[Methods]============================== //

			public bool IsInside (float p_value, ERange p_range)
			{
				return IsInside(p_value, min, max, p_range);
			}

			public bool IsInside (float p_value, ERangeSide p_minSide, ERangeSide p_maxSide)
			{
				return IsInside(p_value, min, max, p_minSide, p_maxSide);
			}

			public bool IsInsideEx (float p_value)
			{
				return IsInsideEx(p_value, min, max);
			}

			public bool IsInsideExIn (float p_value)
			{
				return IsInsideExIn(p_value, min, max);
			}

			public bool IsInsideIn (float p_value)
			{
				return IsInsideIn(p_value, min, max);
			}

			public bool IsInsideInEx (float p_value)
			{
				return IsInsideInEx(p_value, min, max);
			}

			public bool IsOutside (float p_value, ERange p_range)
			{
				return IsOutside(p_value, min, max, p_range);
			}

			public bool IsOutside (float p_value, ERangeSide p_minSide, ERangeSide p_maxSide)
			{
				return IsOutside(p_value, min, max, p_minSide, p_maxSide);
			}

			public bool IsOutsideEx (float p_value)
			{
				return IsOutsideEx(p_value, min, max);
			}

			public bool IsOutsideExIn (float p_value)
			{
				return IsOutsideExIn(p_value, min, max);
			}

			public bool IsOutsideIn (float p_value)
			{
				return IsOutsideIn(p_value, min, max);
			}

			public bool IsOutsideInEx (float p_value)
			{
				return IsOutsideInEx(p_value, min, max);
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public override bool Equals (object obj)
			{
				return obj is Range other && Equals(other);
			}

			public bool Equals (Range p_other)
			{
				return this == p_other;
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

			public static bool operator== (Range p_lhs, Range p_rhs)
			{
				return p_lhs.min == p_rhs.min && p_lhs.max == p_rhs.max;
			}

			public static bool operator!= (Range p_lhs, Range p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

		#endregion
	}
}
