using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawSphere : DrawMonoBehaviour
	{
		public float radius = 1.0f;
		[Min(0)]
		public int segmentcount = 12;
		
		private void Update ()
		{
			Vector3 forward = transform.forward;
			ZkDebug.DrawSphere(Position, radius, color, segmentcount, 0.0f, depthTest);
		}
	}
}