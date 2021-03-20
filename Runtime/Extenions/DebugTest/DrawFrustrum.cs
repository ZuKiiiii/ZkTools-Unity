using System;
using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawFrustrum : DrawMonoBehaviour
	{
		public enum EType
		{
			TRS,
			Perspective,
			Ortho
		}


		[Header("Generale :")]
		public EType type = EType.Perspective;
		public float near = 0.3f;
		public float far = 100.0f;
		
		[Header("Perspective :")]
		public float fov = 60.0f;
		public float asppect = 16 / 9.0f;

		[Header("Ortho :")]
		public float left = -1.0f;
		public float right = 1.0f;
		public float bottom = -1.0f;
		public float top = 1.0f;

		
		protected void Update ()
		{
			Vector3 position = transform.position;
			
			// switch (type)
			// {
			// 	// case EType.Ortho : ZkDebug.DrawFrustum(left, right, bottom, top, near, far, color, 0.0f, depthTest); break;
			// 	// case EType.Perspective : ZkDebug.DrawFrustum(fov, asppect, near, far, color, 0.0f, depthTest); break;
			// 	// case EType.TRS : ZkDebug.DrawFrustum(transform.position, transform.rotation, transform.lossyScale, color); break;;
			// }
		}
	}
}