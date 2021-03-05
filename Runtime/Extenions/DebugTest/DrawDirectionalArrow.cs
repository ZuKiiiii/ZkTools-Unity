using System;
using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawDirectionalArrow : DrawMonoBehaviour
	{
		public float lenght = 1.0f;
		public float arrowSize = 0.10f;
		
		protected void Update ()
		{
			ZkDebug.DrawDirectionalArrow(Position, Position + transform.forward * lenght, color, arrowSize, 0.0f, depthTest);
		}
	}
}