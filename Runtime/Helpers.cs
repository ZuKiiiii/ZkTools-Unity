using System;
using System.Runtime.CompilerServices;

namespace ZkTools
{
	public static class Helpers
	{
		#region // ==============================[Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Notify (Action p_method, Action p_delegate)
			{
				p_method?.Invoke();
				p_delegate?.Invoke();
			}
		
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Notify<T> (Action<T> p_method, Action<T> p_delegate, T p_arg)
			{
				p_method?.Invoke(p_arg);
				p_delegate?.Invoke(p_arg);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Notify<T1,T2> (Action<T1,T2> p_method, Action<T1,T2> p_delegate, T1 p_arg1, T2 p_arg2)
			{
				p_method?.Invoke(p_arg1, p_arg2);
				p_delegate?.Invoke(p_arg1, p_arg2);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Notify<T1,T2,T3> (Action<T1,T2,T3> p_method, Action<T1,T2,T3> p_delegate, T1 p_arg1, T2 p_arg2, T3 p_arg3)
			{
				p_method?.Invoke(p_arg1, p_arg2, p_arg3);
				p_delegate?.Invoke(p_arg1, p_arg2, p_arg3);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Notify<T1,T2,T3,T4> (Action<T1,T2,T3,T4> p_method, Action<T1,T2,T3,T4> p_delegate, T1 p_arg1, T2 p_arg2, T3 p_arg3, T4 p_arg4)
			{
				p_method?.Invoke(p_arg1, p_arg2, p_arg3, p_arg4);
				p_delegate?.Invoke(p_arg1, p_arg2, p_arg3, p_arg4);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Swap<T> (ref T p_lhs, ref T p_rhs)
			{
				T tmp = p_lhs;
				p_lhs = p_rhs;
				p_rhs = tmp;
			}
		
		#endregion
	}
}