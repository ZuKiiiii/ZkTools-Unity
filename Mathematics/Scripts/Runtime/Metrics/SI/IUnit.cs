namespace ZkTools.Mathematics.Metrics.SI
{
	public interface IUnit
	{
		#region ==============================[Methods]==============================

			public string GetBase10 ();

			public string GetName ();

			public string GetSymbole ();

			public float GetValue ();

		#endregion
	}
}