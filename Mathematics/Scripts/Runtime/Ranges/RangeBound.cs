using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZkTools.Mathematics
{
	[System.Serializable]
	public struct RangeBound
	{
		#region ==============================[Enumerator]==============================

			public enum EType : byte
			{
				Exclusive,

				Inclusive,

				Open
			}

		#endregion
			
		#region ==============================[Constants]==============================

			public static readonly RangeBound Open = new RangeBound();

		#endregion

		#region ==============================[Editable Variables]==============================

			private float boundValue;

			private RangeBound.EType boundType;

		#endregion

		#region ==============================[Properties]==============================

			public RangeBound Flip
			{
				get
				{
					return IsExclusive ? Inclusive(boundValue) :
							IsInclusive ? Exclusive(boundValue) : this;
				}
			}

			public bool IsClosed => boundType != EType.Open;

			public bool IsExclusive => boundType == EType.Exclusive;

			public bool IsInclusive => boundType == EType.Inclusive;

			public bool IsOpen => boundType == EType.Open;

			public float Value
			{
				get
				{
					if (!IsOpen)
						return boundValue;
					else
						return float.NaN;
				}
				set 
				{
					if (!IsOpen)
						boundValue = value;
				}
			}

			public RangeBound.EType Type
			{
				get => boundType;
				set => boundType = value;
			}

		#endregion
			
		#region ==============================[Constructor + Destructor]==============================

			public RangeBound (float p_boundValue)
			{
				boundType = EType.Inclusive;
				boundValue = p_boundValue;
			}

			public RangeBound (EType p_boundType)
			{
				boundType = p_boundType;
				boundValue = 0.0f;
			}

			public RangeBound (float p_boundValue, EType p_boundType)
			{
				boundType = p_boundType;
				boundValue = p_boundValue;
			}

		#endregion

		#region ==============================[Static Methods]==============================

			public static RangeBound Exclusive (float p_value)
			{
				return new RangeBound(p_value, EType.Exclusive);
			}
			public static RangeBound Inclusive (float p_value)
			{
				return new RangeBound(p_value, EType.Inclusive);
			}

			public static RangeBound MaxLower (RangeBound p_lhs, RangeBound p_rhs)
			{
				if (p_lhs.IsOpen)
					return p_rhs;
				if (p_rhs.IsOpen)
					return p_lhs;

				if (p_lhs.boundValue > p_rhs.boundValue)
					return p_lhs;
				if (p_rhs.boundValue > p_lhs.boundValue)
					return p_rhs;

				if (p_lhs.IsExclusive)
					return p_lhs;
				return p_rhs;
			}

			public static RangeBound MaxUpper (RangeBound p_lhs, RangeBound p_rhs)
			{
				if (p_lhs.IsOpen)
					return p_lhs;
				if (p_rhs.IsOpen)
					return p_rhs;

				if (p_lhs.boundValue > p_rhs.boundValue)
					return p_lhs;
				if (p_rhs.boundValue > p_lhs.boundValue)
					return p_rhs;

				if (p_lhs.IsInclusive)
					return p_lhs;
				return p_rhs;
			}

			public static RangeBound MinLower (RangeBound p_lhs, RangeBound p_rhs)
			{
				if (p_lhs.IsOpen)
					return p_lhs;
				if (p_rhs.IsOpen)
					return p_rhs;

				if (p_lhs.boundValue < p_rhs.boundValue)
					return p_lhs;
				if (p_rhs.boundValue < p_lhs.boundValue)
					return p_rhs;

				if (p_lhs.IsInclusive)
					return p_lhs;
				return p_rhs;
			}

			public static RangeBound MinUpper (RangeBound p_lhs, RangeBound p_rhs)
			{
				if (p_lhs.IsOpen)
					return p_rhs;
				if (p_rhs.IsOpen)
					return p_lhs;

				if (p_lhs.boundValue > p_rhs.boundValue)
					return p_lhs;
				if (p_rhs.boundValue > p_lhs.boundValue)
					return p_rhs;

				if (p_lhs.IsExclusive)
					return p_lhs;
				return p_rhs;
			}

		#endregion

		#region ==============================[Methods]==============================

		#endregion

		#region ==============================[Operators]==============================

			public static bool operator== (RangeBound p_lhs, RangeBound p_rhs)
			{
				return (p_lhs.boundType == p_rhs.boundType) && (p_lhs.IsOpen || (p_lhs.boundValue == p_rhs.boundValue));
			}

			public static bool operator!= (RangeBound p_lhs, RangeBound p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

		#endregion

	}
}
