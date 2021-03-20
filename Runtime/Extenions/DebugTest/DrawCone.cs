using System;
using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawCone : DrawMonoBehaviour
	{
		public float length = 1.0f;

		[Range(0.0f, 180.0f)]
		public float angleWidth = 45.0f; 
		
		
		[Range(0.0f, 180.0f)]
		public float angleHeight = 45.0f;

		public int sideCount = 12;
		
		private void Update ()
		{
			Vector3 origin = transform.position;
			Vector3 direction = transform.forward;
			
			ZkDebug.DrawConeDegree(origin, direction, length, color, angleWidth, angleHeight, sideCount, 0.0f, depthTest);
		}
		
	}
}