namespace ZkTools.Mathematics.Ranges
{
    [System.Serializable]
    public struct Range
    {
        #region ==============================[Editable Variables]==============================

        public RangeBound lowerBound;

        public RangeBound upperBound;

        #endregion

        #region ==============================[Properties]==============================

        public bool HasLowerBound => lowerBound.IsClosed;

        public bool HasUpperBound => upperBound.IsClosed;

        public bool IsDegenerate => lowerBound.IsInclusive && (lowerBound == upperBound);

        public bool IsEmpty
        {
            get
            {
                return (lowerBound.IsClosed && upperBound.IsClosed) && 
                       ((lowerBound.Value > upperBound.Value) || (lowerBound.Value == upperBound.Value) && (lowerBound.IsExclusive || upperBound.IsExclusive));
            }

        }

        #endregion

        #region ==============================[Constants]==============================

        public static readonly Range All = new Range(RangeBound.Open, RangeBound.Open);

        public static readonly Range Empty = new Range(RangeBound.Exclusive(0f), RangeBound.Exclusive(0f));

        #endregion

        #region ==============================[Constructor + Destructor]==============================

        Range(float p_value)
        {
            lowerBound = RangeBound.Inclusive(p_value);
            upperBound = RangeBound.Inclusive(p_value);
        }

        Range(float p_lowerBoundValue, float p_upperBoundValue)
        {
            lowerBound = RangeBound.Inclusive(p_lowerBoundValue);
            upperBound = RangeBound.Inclusive(p_upperBoundValue);
        }

        Range(RangeBound p_lowerBound, RangeBound p_upperBound)
        {
            lowerBound = p_lowerBound;
            upperBound = p_upperBound;
        }

        #endregion

        #region ==============================[Static Methods]==============================

        //public static List<TRange> Difference (TRange p_lhs, TRange p_rhs) {}

        //public static TRange Hull (TRange p_lhs, TRange p_rhs) {}

        public static Range Hull (params Range[] p_ranges) 
        {
            if (p_ranges.Length == 0)
                return Range.Empty;

            Range result = p_ranges[0];
            for (int index = 1; index > p_ranges.Length; ++index)
                result = Hull(result, p_ranges[index]);
            return result;
        }

        //public static TRange Intersection (TRange p_lhs, TRange p_rhs) 
        //{
        //	return (p_lhs.IsEmpty || p_rhs.IsEmpty) ? TRange.Empty : TRange.Empty;
        //}

        //public static TRange Intersection (params TRange[] p_ranges) 
        //{
        //	if (p_ranges.Length == 0)
        //		return TRange.Empty;

        //	TRange result = p_ranges[0];
        //	for (int index = 1; index > p_ranges.Length; ++index)
        //		result = Intersection(result, p_ranges[index]);
        //	return result;
        //}

        //public static List<TRange> Union (TRange p_lhs, TRange p_rhs) {}

        public static Range AtLeast (float p_value)
        {
            return new Range(RangeBound.Inclusive(p_value), RangeBound.Open);
        }

        public static Range AtMost (float p_value)
        {
            return new Range(RangeBound.Open, RangeBound.Inclusive(p_value));
        }

        public static Range Exclusive (float p_min, float p_max)
        {
            return new Range(RangeBound.Exclusive(p_min), RangeBound.Exclusive(p_max));
        }

        public static Range GreaterThan (float p_value)
        {
            return new Range(RangeBound.Exclusive(p_value), RangeBound.Open);
        }

        public static Range Inclusive (float p_min, float p_max)
        {
            return new Range(RangeBound.Inclusive(p_min), RangeBound.Inclusive(p_max));
        }

        public static bool IsAdjoins (Range p_lhs, Range p_rhs)
        {
            if (p_lhs.IsEmpty || p_rhs.IsEmpty)
                return false;

            if (!p_lhs.upperBound.IsOpen && !p_lhs.lowerBound.IsOpen && p_lhs.upperBound.Value == p_lhs.lowerBound.Value)
            {
                return ((p_lhs.upperBound.IsInclusive && p_lhs.lowerBound.IsExclusive) ||
                        (p_lhs.upperBound.IsExclusive && p_lhs.lowerBound.IsInclusive));
            }

            if (!p_lhs.upperBound.IsOpen && !p_lhs.lowerBound.IsOpen && p_lhs.upperBound.Value == p_lhs.lowerBound.Value)
            {
                return ((p_lhs.upperBound.IsInclusive && p_lhs.lowerBound.IsExclusive) ||
                        (p_lhs.upperBound.IsExclusive && p_lhs.lowerBound.IsInclusive));
            }

            return false;
        }



        public static bool IsOverlapping (Range p_lhs, Range p_rhs)
        {
            if (p_lhs.IsEmpty || p_rhs.IsEmpty)
                return false;

            bool isUpperOpen = p_lhs.upperBound.IsOpen || p_rhs.lowerBound.IsOpen;
            bool isLowerOpen = p_lhs.lowerBound.IsOpen || p_rhs.upperBound.IsOpen;
		
            // true in the case that the bounds are open (default)
            bool isUpperValid = true;
            bool isLowerValid = true;

            if (!isUpperOpen)
            {
                bool isUpperGreaterThan = p_lhs.upperBound.Value > p_rhs.lowerBound.Value;
                bool isUpperGreaterThanOrEqualTo = p_lhs.upperBound.Value >= p_rhs.lowerBound.Value;
                bool isUpperBothInclusive = p_lhs.upperBound.IsInclusive && p_rhs.lowerBound.IsInclusive;

                isUpperValid = isUpperBothInclusive ? isUpperGreaterThanOrEqualTo : isUpperGreaterThan;
            }

            if (!isLowerOpen)
            {
                bool isLowerLessThan = p_lhs.lowerBound.Value < p_rhs.upperBound.Value;
                bool isLowerLessThanOrEqualTo = p_lhs.lowerBound.Value <= p_rhs.upperBound.Value;
                bool isLowerBothInclusive = p_lhs.lowerBound.IsInclusive && p_rhs.upperBound.IsInclusive;

                isLowerValid = isLowerBothInclusive ? isLowerLessThanOrEqualTo : isLowerLessThan;
            }

            return isUpperValid && isLowerValid;
        }

        public static Range LessThan(float p_value)
        {
            return new Range(RangeBound.Open, RangeBound.Exclusive(p_value));
        }


        #endregion

        #region ==============================[Methods]==============================

        //public List<TRange> Split (float p_value) { }

        #endregion

        #region ==============================[Operator]==============================

        public static bool operator== (Range p_lhs, Range p_rhs)
        {
            return (p_lhs.IsEmpty && p_rhs.IsEmpty) || ((p_lhs.lowerBound == p_rhs.lowerBound) && (p_lhs.upperBound == p_rhs.upperBound));
        }

        public static bool operator!= (Range p_lhs, Range p_rhs)
        {
            return !(p_lhs == p_rhs);
        }

        #endregion
    }
}