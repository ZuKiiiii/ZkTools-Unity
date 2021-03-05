using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawDebugBox : DrawDebugMonoBehaviour
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
				case EVersion.NoRotation: ZkDebug.DrawDebugBox(Position, extent, color, 0.0f,  depthTest); break;
				case EVersion.WithQuaternionRotation : ZkDebug.DrawDebugBox(Position, extent, Rotation, color, 0.0f, depthTest); break;
				case EVersion.WithEulerRotation : ZkDebug.DrawDebugBox(Position, extent, Rotation.eulerAngles, color,0.0f, depthTest); break;
			}
		}
	}
}

