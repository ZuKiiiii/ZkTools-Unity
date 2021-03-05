using Shapes;
using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawCircle : DrawMonoBehaviour
	{
		public float radius = 1.0f;
		public int segmentcount = 12;
		
		private void Update ()
		{
			Vector3 forward = transform.forward;
			ZkDebug.DrawCircle(Position, radius, color, forward, segmentcount, 0.0f, depthTest);
		}

	}
}