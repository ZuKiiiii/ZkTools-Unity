using System;
using System.Collections.Generic;

namespace ZkTools
{
	public struct Pair<T1, T2> 
		where T1 : IEquatable<T1>
		where T2 : IEquatable<T2>
	{
		#region ==============================[Constructor + Destructor]==============================

			public T1 first;

			public T2 second;

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Pair (T1 p_first, T2 p_second)
			{
				first = p_first;
				second = p_second;
			}

			public Pair (Pair<T1, T2> p_copy)
			{
				first = p_copy.first;
				second = p_copy.second;
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public bool Equals (Pair<T1, T2> p_other)
			{
				return EqualityComparer<T1>.Default.Equals(first, p_other.first) && EqualityComparer<T2>.Default.Equals(second, p_other.second);
			}


			public override bool Equals (object p_obj)
			{
				return p_obj is Pair<T1, T2> other && Equals(other);
			}

			public override int GetHashCode ()
			{
				unchecked
				{
					return (EqualityComparer<T1>.Default.GetHashCode(first) * 397) ^ EqualityComparer<T2>.Default.GetHashCode(second);
				}
			}

		#endregion

		#region ==============================[Operators]==============================

			public static bool operator== (Pair<T1, T2> p_lhs, Pair<T1, T2> p_rhs)
			{
				return p_lhs.first.Equals(p_rhs.first) && p_lhs.second.Equals(p_rhs.second);
			}

			public static bool operator!= (Pair<T1, T2> p_lhs, Pair<T1, T2> p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

		#endregion
	}
}