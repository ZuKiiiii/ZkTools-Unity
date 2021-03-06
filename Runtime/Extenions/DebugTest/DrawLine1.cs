using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawLine1 : DrawMonoBehaviour
	{
		public Transform p1;
		public Transform p2;

		private void Update ()
		{
			if (p1 && p2 )
				ZkDebug.DrawLine(p1.position, p2.position, color, 0.0f, depthTest);
		}
	}
}