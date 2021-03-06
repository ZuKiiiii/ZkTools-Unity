using System.Collections.Generic;
using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawLine2 : DrawMonoBehaviour
	{
		public bool loop = false;
		public Transform[] transforms;

		private void Update ()
		{
			List<Vector3> points = new List<Vector3>();
			foreach (Transform tr in transforms)
				if (tr)
					points.Add(tr.position);
			
				ZkDebug.DrawLine(points.ToArray(), loop, color, 0.0f, depthTest);
		}
	}
}