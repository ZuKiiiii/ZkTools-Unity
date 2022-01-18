using System;
using ZkTools.Mathematics.Extensions;

namespace ZkTools.Mathematics.Ranges
{
	[System.Serializable]
	public struct Interval : IEquatable<Interval>, IFormattable
	{
		#region ==============================[Constant]==============================

			public static readonly Interval Empty = new Interval(0f, 0f);

			public static readonly Interval Whole = new Interval(float.NegativeInfinity, float.PositiveInfinity);

		#endregion
		
		#region ==============================[Variables]==============================

			public float min;

			public float max;

		#endregion

		#region ==============================[Properties]==============================

			public bool IsValid => min <= max;

			public float Length => max - min;

			public float Middle => (max + min) * 0.5f; 

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Interval (float p_min, float p_max)
			{
				max = p_max;
				min = p_min;
			}

			public Interval (float p_value)
			{
				max = p_value;
				min = p_value;
			}

			public Interval (Interval p_copy)
			{
				max = p_copy.max;
				min = p_copy.min;
			}

		#endregion

		#region ==============================[Static Methods]==============================

			public static Interval Intersection (float p_lhsMin, float p_lhsMax, float p_rhsMin, float p_rhsMax)
			{
				return new Interval(MathF.Max(p_lhsMin, p_rhsMin), MathF.Min(p_lhsMax, p_rhsMax));
			}

			public static Interval Intersection (Interval p_lhs, Interval p_rhs)
			{
				return Intersection(p_lhs.min, p_lhs.max, p_rhs.min, p_rhs.max);
			}

			public static bool IsInside (float p_value, float p_min, float p_max, EIntervalBoundSide p_range)
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

			public static bool IsInside (float p_value, float p_min, float p_max, EIntervalBoundType p_minBoundType, EIntervalBoundType p_maxBoundType)
			{
				return IsInside(p_value, p_min, p_max, ERangeX.Convert(p_minBoundType, p_maxBoundType));
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

			public static bool IsOutside (float p_value, float p_min, float p_max, EIntervalBoundSide p_range)
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

			public static bool IsOutside (float p_value, float p_min, float p_max, EIntervalBoundType p_minBoundType, EIntervalBoundType p_maxBoundType)
			{
				return IsOutside(p_value, p_min, p_max, ERangeX.Convert(p_minBoundType, p_maxBoundType));
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

			public static bool IsOverlapping (float p_lhsMin, float p_lhsMax, float p_rhsMin, float p_rhsMax)
			{
				return (p_lhsMin <= p_rhsMin && p_rhsMin <= p_lhsMax) || (p_rhsMin <= p_lhsMin && p_lhsMin <= p_rhsMax);
			}

			public static bool IsOverlapping (Interval p_lhs, Interval p_rhs)
			{
				return IsOverlapping(p_lhs.min, p_lhs.max, p_rhs.min, p_rhs.max);
			}

			public static Interval Union (float p_lhsMin, float p_lhsMax, float p_rhsMin, float p_rhsMax)
			{
				return new Interval(MathF.Min(p_lhsMin, p_rhsMin), MathF.Max(p_lhsMax, p_rhsMax));
			}

			public static Interval Union (Interval p_lhs, Interval p_rhs)
			{
				return Union(p_lhs.min, p_lhs.max, p_rhs.min, p_rhs.max);
			}

		#endregion

		#region ==============================[Methods]==============================

			public Interval GetExpanded (float p_expandAmout)
			{
				return new Interval(min - p_expandAmout, max + p_expandAmout);
			}

			public Interval GetIncluded (float p_value)
			{
				return new Interval(p_value < min ? p_value : min, p_value > max ? p_value : max);
			}

			public void Expand (float p_expandAmount)
			{
				min -= p_expandAmount;
				max += p_expandAmount;
			}

			public void Include (float p_value)
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

			public Interval Intersection (float p_min, float p_max)
			{
				return Intersection(this.min, this.max, p_min, p_max);
			}

			public Interval Intersection (Interval p_other)
			{
				return Intersection(this, p_other);
			}

			public bool IsInside (float p_value, EIntervalBoundSide p_range)
			{
				return IsInside(p_value, min, max, p_range);
			}

			public bool IsInside (float p_value, EIntervalBoundType p_minBoundType, EIntervalBoundType p_maxBoundType)
			{
				return IsInside(p_value, min, max, p_minBoundType, p_maxBoundType);
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

			public bool IsOutside (float p_value, EIntervalBoundSide p_range)
			{
				return IsOutside(p_value, min, max, p_range);
			}

			public bool IsOutside (float p_value, EIntervalBoundType p_minBoundType, EIntervalBoundType p_maxBoundType)
			{
				return IsOutside(p_value, min, max, p_minBoundType, p_maxBoundType);
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

			public bool IsOverlapping (Interval p_other)
			{
				return IsOverlapping(this, p_other);
			}

			public void Set (float p_min, float p_max)
			{
				min = p_min;
				max = p_max;
			}

			public void SetEmpty ()
			{
				min = 0.0f;
				max = 0.0f;
			}

			public void SetWhole ()
			{
				min = float.NegativeInfinity;
				max = float.PositiveInfinity;
			}

			public Interval Union (float p_min, float p_max)
			{
				return Union(this.min, this.max, p_min, p_max);
			}

			public Interval Union (Interval p_other)
			{
				return Union(this, p_other);
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public override bool Equals (object obj)
			{
				return obj is Interval other && Equals(other);
			}

			public bool Equals (Interval p_other)
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

			public static bool operator== (Interval p_lhs, Interval p_rhs)
			{
				return p_lhs.min == p_rhs.min && p_lhs.max == p_rhs.max;
			}

			public static bool operator!= (Interval p_lhs, Interval p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static bool operator< (Interval p_lhs, Interval p_rhs)
			{
				return p_lhs.max < p_rhs.min;
			}

			public static bool operator< (Interval p_lhs, float p_rhs)
			{
				return p_lhs.max < p_rhs;
			}
			
			public static bool operator< (float p_lhs, Interval p_rhs)
			{
				return p_rhs > p_lhs;
			}

			public static bool operator<= (Interval p_lhs, Interval p_rhs)
			{
				return p_lhs.max <= p_rhs.min;
			}

			public static bool operator<= (Interval p_lhs, float p_rhs)
			{
				return p_lhs.max <= p_rhs;
			}
			
			public static bool operator<= (float p_lhs, Interval p_rhs)
			{
				return p_rhs >= p_lhs;
			}

			public static bool operator> (Interval p_lhs, Interval p_rhs)
			{
				return p_lhs.min > p_rhs.max;
			}

			public static bool operator> (Interval p_lhs, float p_rhs)
			{
				return p_lhs.min > p_rhs;
			}

			public static bool operator> (float p_lhs, Interval p_rhs)
			{
				return p_rhs < p_lhs;
			}

			public static bool operator>= (Interval p_lhs, Interval p_rhs)
			{
				return p_lhs.min >= p_rhs.max;
			}

			public static bool operator>= (Interval p_lhs, float p_rhs)
			{
				return p_lhs.min >= p_rhs;
			}

			public static bool operator>= (float p_lhs, Interval p_rhs)
			{
				return p_rhs <= p_lhs;
			}

			public static Interval operator+ (Interval p_lhs, Interval p_rhs)
			{
				return new Interval(p_lhs.min + p_rhs.min, p_lhs.max + p_rhs.max);
			}

			public static Interval operator+ (Interval p_lhs, float p_rhs)
			{
				return new Interval(p_lhs.min + p_rhs, p_lhs.max + p_rhs);
			}

			public static Interval operator+ (float p_lhs, Interval p_rhs)
			{
				return new Interval(p_lhs + p_rhs.min, p_lhs + p_rhs.max);
			}

			public static Interval operator- (Interval p_this)
			{
				return new Interval(-p_this.max, -p_this.min);
			}
			
			public static Interval operator- (Interval p_lhs, Interval p_rhs)
			{
				return new Interval(p_lhs.min - p_rhs.min, p_lhs.max - p_rhs.max);
			}

			public static Interval operator- (Interval p_lhs, float p_rhs)
			{
				return new Interval(p_lhs.min - p_rhs, p_lhs.max - p_rhs);
			}

		#endregion
	}
}