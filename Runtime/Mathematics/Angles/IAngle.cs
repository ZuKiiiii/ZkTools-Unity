using System;

namespace ZkTools.Mathematics.Angles
{
	public enum EAngle
	{
		Degree,
		Gradian,
		Radian,
		Turn
	}

	public interface IAngle<T> : IEquatable<T>, IComparable<T>, IFormattable
	{
		#region // ==============================[Properties]============================== //

			public Degree ToDegree {get; set;}

			public Gradian ToGradian {get; set;}

			public Radian ToRadian {get; set;}

			public Turn ToTurn {get; set;}

			public T Unwinded {get;}
			
			public float Value {get; set;}

		#endregion

		#region // ==============================[Methods]============================== //

			public void Unwind ();
		
			public string ToString (string p_format);

		#endregion
	}
}