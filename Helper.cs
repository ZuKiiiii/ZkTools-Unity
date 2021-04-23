using UnityEngine;

namespace ZkTools
{
	public class Helper
	{
		#region // ==============================[Methods]============================== //

			public static T Consume<T> (ref T p_value) where T : new()
			{
				T result = p_value;
				p_value = new T();
				return result;
			}

			public static T ConsumeClass<T> (ref T p_class) where T : class
			{
				T result = p_class;
				p_class = null;
				return result;
			}

			public static void Swap<T> (ref T p_lhs, ref T p_rhs)
			{
				T tmp = p_lhs;
				p_lhs = p_rhs;
				p_rhs = tmp;
			}

		#endregion
	}
}