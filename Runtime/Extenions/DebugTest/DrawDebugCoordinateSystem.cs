using System;

namespace ZkTool.Extentions
{
	public class DrawDebugCoordinateSystem : DrawDebugMonoBehaviour
	{
		public float scale = 1.0f;

		protected void Update ()
		{
			ZkDebug.DrawDebugCoordinateSystem(Position, Rotation, scale, 0.0f, depthTest);
		}
	}
}