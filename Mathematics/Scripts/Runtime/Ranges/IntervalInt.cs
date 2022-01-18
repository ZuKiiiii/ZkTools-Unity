using System;
using ZkTools.Mathematics.Extensions;

namespace ZkTools.Mathematics.Ranges
{
	[System.Serializable]
	public struct IntervalInt : IEquatable<IntervalInt>, IFormattable
	{
		#region ==============================[Constant]==============================

			public static readonly IntervalInt Empty = new IntervalInt(0, 0);

			public static readonly IntervalInt Whole = new IntervalInt(int.MinValue, int.MaxValue);

		#endregion
		
		#region ==============================[Variables]==============================

			public int min;

			public int max;

		#endregion

		#region ==============================[Properties]==============================

			public bool IsValid => min <= max;

			public int Length => max - min;

			public float Middle => (max + min) * 0.5f; 

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public IntervalInt (int p_min, int p_max)
			{
				max = p_max;
				min = p_min;
			}

			public IntervalInt (int p_value)
			{
				max = p_value;
				min = p_value;
			}

			public IntervalInt (IntervalInt p_copy)
			{
				max = p_copy.max;
				min = p_copy.min;
			}

		#endregion

		#region ==============================[Static Methods]==============================

			public static IntervalInt Intersection (int p_lhsMin, int p_lhsMax, int p_rhsMin, int p_rhsMax)
			{
				return new IntervalInt(MathInt.Max(p_lhsMin, p_rhsMin), MathInt.Min(p_lhsMax, p_rhsMax));
			}

			public static IntervalInt Intersection (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return Intersection(p_lhs.min, p_lhs.max, p_rhs.min, p_rhs.max);
			}

			public static bool IsInside (int p_value, int p_min, int p_max, EIntervalBoundSide p_range)
			{
				switch (p_range)
				{
					case EIntervalBoundSide.Ex : return IsInsideEx(p_value, p_min, p_max);
					case EIntervalBoundSide.ExIn : return IsInsideExIn(p_value, p_min, p_max);
					case EIntervalBoundSide.In : return IsInsideIn(p_value, p_min, p_max);
					case EIntervalBoundSide.InEx : return IsInsideInEx(p_value, p_min, p_max);
					default : throw new System.ArgumentOutOfRangeException();
				}
			}

			public static bool IsInside (int p_value, int p_min, int p_max, EIntervalBoundType p_minBoundType, EIntervalBoundType p_maxBoundType)
			{
				return IsInside(p_value, p_min, p_max, ERangeX.Convert(p_minBoundType, p_maxBoundType));
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

			public static bool IsOutside (int p_value, int p_min, int p_max, EIntervalBoundSide p_range)
			{
				switch (p_range)
				{
					case EIntervalBoundSide.Ex : return IsOutsideEx(p_value, p_min, p_max);
					case EIntervalBoundSide.ExIn : return IsOutsideExIn(p_value, p_min, p_max);
					case EIntervalBoundSide.In : return IsOutsideIn(p_value, p_min, p_max);
					case EIntervalBoundSide.InEx : return IsOutsideInEx(p_value, p_min, p_max);
					default : throw new System.ArgumentOutOfRangeException();
				}
			}

			public static bool IsOutside (int p_value, int p_min, int p_max, EIntervalBoundType p_minBoundType, EIntervalBoundType p_maxBoundType)
			{
				return IsOutside(p_value, p_min, p_max, ERangeX.Convert(p_minBoundType, p_maxBoundType));
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

			public static bool IsOverlapping (int p_lhsMin, int p_lhsMax, int p_rhsMin, int p_rhsMax)
			{
				return (p_lhsMin <= p_rhsMin && p_rhsMin <= p_lhsMax) || (p_rhsMin <= p_lhsMin && p_lhsMin <= p_rhsMax);
			}

			public static bool IsOverlapping (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return IsOverlapping(p_lhs.min, p_lhs.max, p_rhs.min, p_rhs.max);
			}

			public static IntervalInt Union (int p_lhsMin, int p_lhsMax, int p_rhsMin, int p_rhsMax)
			{
				return new IntervalInt(MathInt.Min(p_lhsMin, p_rhsMin), MathInt.Max(p_lhsMax, p_rhsMax));
			}

			public static IntervalInt Union (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return Union(p_lhs.min, p_lhs.max, p_rhs.min, p_rhs.max);
			}

		#endregion

		#region ==============================[Methods]==============================

			public IntervalInt GetExpanded (int p_expandAmout)
			{
				return new IntervalInt(min - p_expandAmout, max + p_expandAmout);
			}

			public IntervalInt GetIncluded (int p_value)
			{
				return new IntervalInt(p_value < min ? p_value : min, p_value > max ? p_value : max);
			}

			public void Expand (int p_expandAmount)
			{
				min -= p_expandAmount;
				max += p_expandAmount;
			}

			public void Include (int p_value)
			{
				if (p_value < min)
					min = p_value;
				
				if (p_value > max)
					max = p_value;
			}

			public float Lerp (float p_alpha)
			{
				return MathF.Lerp(min, max, p_alpha);		
			}

			public float LerpClamped (float p_alpha)
			{
				return MathF.LerpClamped(min, max, p_alpha);		
			}

			public IntervalInt Intersection (int p_min, int p_max)
			{
				return Intersection(this.min, this.max, p_min, p_max);
			}

			public IntervalInt Intersection (IntervalInt p_other)
			{
				return Intersection(this, p_other);
			}

			public bool IsInside (int p_value, EIntervalBoundSide p_range)
			{
				return IsInside(p_value, min, max, p_range);
			}

			public bool IsInside (int p_value, EIntervalBoundType p_minBoundType, EIntervalBoundType p_maxBoundType)
			{
				return IsInside(p_value, min, max, p_minBoundType, p_maxBoundType);
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

			public bool IsOutside (int p_value, EIntervalBoundSide p_range)
			{
				return IsOutside(p_value, min, max, p_range);
			}

			public bool IsOutside (int p_value, EIntervalBoundType p_minBoundType, EIntervalBoundType p_maxBoundType)
			{
				return IsOutside(p_value, min, max, p_minBoundType, p_maxBoundType);
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

			public bool IsOverlapping (IntervalInt p_other)
			{
				return IsOverlapping(this, p_other);
			}

			public void Set (int p_min, int p_max)
			{
				min = p_min;
				max = p_max;
			}

			public void SetEmpty ()
			{
				min = 0;
				max = 0;
			}

			public void SetWhole ()
			{
				min = int.MinValue;
				max = int.MaxValue;
			}

			public IntervalInt Union (int p_min, int p_max)
			{
				return Union(this.min, this.max, p_min, p_max);
			}

			public IntervalInt Union (IntervalInt p_other)
			{
				return Union(this, p_other);
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public override bool Equals (object obj)
			{
				return obj is IntervalInt other && Equals(other);
			}

			public bool Equals (IntervalInt p_other)
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

		#region ==============================[Operators]==============================

			public static bool operator== (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return p_lhs.min == p_rhs.min && p_lhs.max == p_rhs.max;
			}

			public static bool operator!= (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static bool operator< (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return p_lhs.max < p_rhs.min;
			}

			public static bool operator< (IntervalInt p_lhs, int p_rhs)
			{
				return p_lhs.max < p_rhs;
			}
			
			public static bool operator< (int p_lhs, IntervalInt p_rhs)
			{
				return p_rhs > p_lhs;
			}

			public static bool operator<= (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return p_lhs.max <= p_rhs.min;
			}

			public static bool operator<= (IntervalInt p_lhs, int p_rhs)
			{
				return p_lhs.max <= p_rhs;
			}
			
			public static bool operator<= (int p_lhs, IntervalInt p_rhs)
			{
				return p_rhs >= p_lhs;
			}

			public static bool operator> (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return p_lhs.min > p_rhs.max;
			}

			public static bool operator> (IntervalInt p_lhs, int p_rhs)
			{
				return p_lhs.min > p_rhs;
			}

			public static bool operator> (int p_lhs, IntervalInt p_rhs)
			{
				return p_rhs < p_lhs;
			}

			public static bool operator>= (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return p_lhs.min >= p_rhs.max;
			}

			public static bool operator>= (IntervalInt p_lhs, int p_rhs)
			{
				return p_lhs.min >= p_rhs;
			}

			public static bool operator>= (int p_lhs, IntervalInt p_rhs)
			{
				return p_rhs <= p_lhs;
			}

			public static IntervalInt operator+ (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return new IntervalInt(p_lhs.min + p_rhs.min, p_lhs.max + p_rhs.max);
			}

			public static IntervalInt operator+ (IntervalInt p_lhs, int p_rhs)
			{
				return new IntervalInt(p_lhs.min + p_rhs, p_lhs.max + p_rhs);
			}

			public static IntervalInt operator+ (int p_lhs, IntervalInt p_rhs)
			{
				return new IntervalInt(p_lhs + p_rhs.min, p_lhs + p_rhs.max);
			}

			public static IntervalInt operator- (IntervalInt p_this)
			{
				return new IntervalInt(-p_this.max, -p_this.min);
			}
			
			public static IntervalInt operator- (IntervalInt p_lhs, IntervalInt p_rhs)
			{
				return new IntervalInt(p_lhs.min - p_rhs.min, p_lhs.max - p_rhs.max);
			}

			public static IntervalInt operator- (IntervalInt p_lhs, int p_rhs)
			{
				return new IntervalInt(p_lhs.min - p_rhs, p_lhs.max - p_rhs);
			}

		#endregion
	}
}
