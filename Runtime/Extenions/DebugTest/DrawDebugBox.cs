using BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion;
using UnityEngine;
using UnityEditor;

namespace ZkTool.Extentions
{
	public class DrawDebugBox : MonoBehaviour
	{
		[System.Serializable]
		public enum EVersion
		{
			NoRotation,
			WithQuaternionRotation,
			WithEulerRotation
		}
		
		public Vector3 extent = Vector3.one;
		public Color color = Color.white;
		public bool depthTest = true;
		public EVersion version = EVersion.NoRotation; 
		
		protected void Update ()
		{
			Vector3 center = transform.position;
			Quaternion quaternion = transform.rotation;
			
			switch (version)
			{
				case EVersion.NoRotation: ZkDebug.DrawDebugBox(center, extent, color, 0.0f,  depthTest); break;
				case EVersion.WithQuaternionRotation : ZkDebug.DrawDebugBox(center, extent, quaternion, color, 0.0f, depthTest); break;
				case EVersion.WithEulerRotation : ZkDebug.DrawDebugBox(center, extent, quaternion.eulerAngles, color,0.0f, depthTest); break;
			}
		}
	}
}

