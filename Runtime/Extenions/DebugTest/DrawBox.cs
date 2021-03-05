using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawBox : DrawMonoBehaviour
	{
		[System.Serializable]
		public enum EVersion
		{
			NoRotation,
			WithQuaternionRotation,
			WithEulerRotation
		}
		
		public Vector3 extent = Vector3.one;
		public EVersion version = EVersion.NoRotation; 
		
		protected void Update ()
		{
			switch (version)
			{
				case EVersion.NoRotation: ZkDebug.DrawCube(Position, extent, color, 0.0f,  depthTest); break;
				case EVersion.WithQuaternionRotation : ZkDebug.DrawCube(Position, extent, Rotation, color, 0.0f, depthTest); break;
				case EVersion.WithEulerRotation : ZkDebug.DrawCube(Position, extent, Rotation.eulerAngles, color,0.0f, depthTest); break;
			}
		}
	}
}

