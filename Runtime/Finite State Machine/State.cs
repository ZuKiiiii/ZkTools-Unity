using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ZkTools.FSM
{
	public class State : StateBase
	{
		#region // ==============================[Properties]============================== //

			public sealed override bool IsStateMachine => true;

		#endregion

		#region // ==============================[Delegates]============================== //

			/** ... */
			public event Action OnStateInitializedDelegate = null;

			/** ... */
			public event Action OnStateShutdownDelegate = null;
				
		#endregion
		
		#region // ==============================[Constructor + Destructor]============================== //
		
			public State () : base ()
			{}
		
		#endregion
		
		#region // ==============================[Methods]============================== //

			//  ===== USMStateInstance

			public List<State> GetAllStateStack ()
			{
				throw new NotImplementedException();
			}

			public State GetStateInStack (int p_stateIndex)
			{
				throw new NotImplementedException();
			}

			public TState GetStateInStack<TState> (bool p_includeChildren = false) where TState : State
			{
				throw new NotImplementedException();
			}
			
			protected internal virtual void OnStateInitialized () {}
			
			protected internal virtual void OnStateShutdown () {}

			//  ===== ZkTool

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void InternalOnStateInitialized ()
			{
				Helpers.Notify(OnStateInitialized, OnStateInitializedDelegate);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void InternalOnStateShutdown ()
			{
				Helpers.Notify(OnStateShutdown, OnStateShutdownDelegate);
			}
			
		#endregion
		
	}
}
