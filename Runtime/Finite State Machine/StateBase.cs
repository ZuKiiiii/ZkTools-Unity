using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ZkTools.FSM
{
	public abstract class StateBase : Node
	{
		#region // ==============================[Variables]============================== //

			public bool alwayUpdate = true;
		
			protected bool isStateEnding = false;

		#endregion
		
		#region // ==============================[Properties]============================== //

			public abstract bool IsStateMachine {get;} 

		//	public StateInfo StateInfo {get;} 
			
		#endregion
		
		#region // ==============================[Delegates]============================== //

			/** ... */
			public event Action OnEnterDelegate = null;

			/** ... */
			public event Action OnExitDelegate = null;
				
			/** ... */
			public event Action OnRootStateMachineStartDelegate = null;

			/** ... */
			public event Action OnRootStateMachineStopDelegate = null;
			
			/** ... */
			public event Action<float> OnUpdateDelegate = null;

		#endregion
		
		#region // ==============================[Constructor + Destructor]============================== //

			public StateBase ()
			{
				
			}
		
		#endregion
		
		#region // ==============================[Methods]============================== //

			public bool IsEndState ()
			{
				throw new NotImplementedException();
			}

			protected void AddOutgoingTransition (Transition p_transition)
			{
				
			}

			protected void AddIncomingTransition (Transition p_transition)
			{
				
			}

			protected void InitializeTransitions () {}
			
			protected void ShutDownTransitions () {}
			
			//========= USMStateInstance
			
			public List<Transition> GetIncomingTransitions (bool p_excludeAlwaysFalse = true)
			{
				throw new NotImplementedException();
			}

			public List<Transition> GetOutGoingTransitions (bool p_excludeAlwaysFalse = true)
			{
				throw new NotImplementedException();
			}

			public Transition GetTransitionToTake ()
			{
				throw new System.NotImplementedException();
			}
			
			public Transition GetTransition (int p_transitionIndex) {throw new System.NotImplementedException();}

			public Transition GetNextStateByTansitionIndex (int p_transitionIndex)
			{
				throw new System.NotImplementedException();
			}
			
			protected internal virtual void OnEnter () {}

			protected internal virtual void OnExit () {}
			
			protected internal virtual void OnRootStateMachineStart () {}

			protected internal virtual void OnRootStateMachineStop () {}

			protected internal virtual void OnUpdate (float p_deltaTime) {}
			
			// ===== Zktool =====
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void InternalOnEnter ()
			{
				Helpers.Notify(OnEnter, OnEnterDelegate);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void InternalOnExit ()
			{
				Helpers.Notify(OnExit, OnExitDelegate);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void InternalOnRootStateMachineStart ()
			{
				Helpers.Notify(OnRootStateMachineStart, OnRootStateMachineStartDelegate);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void InternalOnRootStateMachineStop ()
			{
				Helpers.Notify(OnRootStateMachineStop, OnRootStateMachineStopDelegate);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void InternalOnUpdate (float p_deltaTime)
			{
				Helpers.Notify(OnUpdate, OnUpdateDelegate, p_deltaTime);
			}
			
		#endregion
	}
}