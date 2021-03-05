using System;

namespace ZkTool.Extentions
{
	public class DrawCoordinateSystem : DrawMonoBehaviour
	{
		public float scale = 1.0f;

		protected void Update ()
		{
			ZkDebug.DrawCoordinateSystem(Position, Rotation, scale, 0.0f, depthTest);
		}
	}
}