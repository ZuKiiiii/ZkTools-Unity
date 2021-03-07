using System;
using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawCylinder : DrawMonoBehaviour
	{
		public float radius = 1.0f;
		public float height = 1.0f;
		
		
		private void Update ()
		{
			Vector3 start = transform.position - transform.up * height * 0.5f; 
			Vector3 end = transform.position + transform.up * height * 0.5f; 
			ZkDebug.DrawCylinder(start, end, radius, color);
		}
	}
}