using Shapes;
using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawCircle : DrawMonoBehaviour
	{
		public float radius = 1.0f;
		[Min(4)]
		public int segmentcount = 12;
		
		private void Update ()
		{
			Vector3 forward = transform.forward;
			ZkDebug.DrawCircle(Position, radius, forward, color, segmentcount, 0.0f, depthTest);
		}

	}
}