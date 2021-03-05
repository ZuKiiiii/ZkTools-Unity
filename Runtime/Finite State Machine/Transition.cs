using System;
using System.Runtime.CompilerServices;

namespace ZkTools.FSM
{
	public class Transition
	{
		#region // ==============================[Delegates]============================== //
		
			/** ... */
			public event Action OnTransitionEnteredDelegate = null;

			/** ... */
			public event Action OnTransitionExitDelegate = null;
		
		#endregion

		#region // ==============================[Constructor + Destructor]============================== //
		
			public Transition ()
			{}
		
		#endregion
		
		#region // ==============================[Methods]============================== //
		
			public bool CanEvaluate () {throw new NotImplementedException();}

			public State GetPreviousState () {throw new NotImplementedException();}

			public State GetNextStateInstance () {throw new NotImplementedException();}
			
			protected internal virtual bool CanEnterTransition () {throw new NotImplementedException();}
			
			protected internal virtual void OnTransitionEntered () {}
			
			protected internal virtual void OnTransitionInitialized () {}
			
			protected internal virtual void OnTransitionExit () {}

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
			internal void InternalOnUpdate (float p_deltaTime)
			{
				Helpers.Notify(OnUpdate, OnUpdateDelegate, p_deltaTime);
			}
			
		#endregion
	}
}


