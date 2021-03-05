using System;
using UnityEngine;

namespace ZkTool.Extentions
{
	public class DrawMonoBehaviour : MonoBehaviour
	{
		public Color color = Color.white;
		public bool depthTest = true;

		protected Vector3 Position {get => transform.position;}
		protected Quaternion Rotation {get => transform.rotation;}
	}
}