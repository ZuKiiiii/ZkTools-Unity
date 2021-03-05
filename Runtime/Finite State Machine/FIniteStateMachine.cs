
namespace ZkTools.FSM
{
	public class FiniteStateMachine : StateBase
	{
		#region // ==============================[Properties]============================== //

			public bool waitForEndState = false;

			public bool reuseCurrentState = false;

			public bool reuseIfNotEndState = false;
				
		#endregion
		
		#region // ==============================[Properties]============================== //

			public State CurrentState {get; private set;} = null;

			public State PreviousState {get; private set;} = null;

			public sealed override bool IsStateMachine => true;

			#endregion

		#region // ==============================[Constructor + Destructor]============================== //
		
			public FiniteStateMachine ()
			{}
		
		#endregion
		
		#region // ==============================[Constructor + Destructor]============================== //
		
			protected virtual void OnStateMachineCompleted () {}
			
			protected virtual void OnStateMachineShutdown () {}
			
			protected virtual void OnStateMachineInitialized () {}
			
			protected virtual void OnEndStateReached () {}
			
		#endregion

	}


}
