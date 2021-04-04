using UnityEngine;

namespace ZkTools.Mathematics.Swizzling
{
	public static class Vector2Swizzling
	{
		#region // ==============================[Methods]============================== //

			public static Vector4 GetIJKX (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.x);
			}

			public static Vector4 GetIJKY (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.y);
			}

			public static Vector3 GetIJX (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.x);
			}

			public static Vector4 GetIJXL (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_l);
			}

			public static Vector4 GetIJXX (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetIJXY (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.y);
			}

			public static Vector3 GetIJY (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.y);
			}

			public static Vector4 GetIJYL (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_l);
			}

			public static Vector4 GetIJYX (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetIJYY (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.y);
			}

			public static Vector2 GetIX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.x);
			}

			public static Vector3 GetIXK (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_k);
			}

			public static Vector4 GetIXKL (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_l);
			}

			public static Vector4 GetIXKX (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetIXKY (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.y);
			}

			public static Vector3 GetIXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.x);
			}

			public static Vector4 GetIXXL (this Vector2 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetIXXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetIXXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.y);
			}

			public static Vector3 GetIXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.y);
			}

			public static Vector4 GetIXYL (this Vector2 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetIXYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetIXYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.y);
			}

			public static Vector2 GetIY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.y);
			}

			public static Vector4 GetIYWL (this Vector2 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_l);
			}

			public static Vector3 GetIYK (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_k);
			}

			public static Vector4 GetIYKL (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_l);
			}

			public static Vector4 GetIYKX (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetIYKY (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.y);
			}

			public static Vector3 GetIYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.x);
			}

			public static Vector4 GetIYXL (this Vector2 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetIYXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetIYXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.y);
			}

			public static Vector3 GetIYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.y);
			}

			public static Vector4 GetIYYL (this Vector2 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetIYYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetIYYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetXJKX (this Vector2 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.x);
			}

			public static Vector4 GetXJKY (this Vector2 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.y);
			}

			public static Vector3 GetXJX (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.x);
			}

			public static Vector4 GetXJXL (this Vector2 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_l);
			}

			public static Vector4 GetXJXX (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetXJXY (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.y);
			}

			public static Vector3 GetXJY (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.y);
			}

			public static Vector4 GetXJYL (this Vector2 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_l);
			}

			public static Vector4 GetXJYX (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetXJYY (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.y);
			}

			public static Vector2 GetXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.x, p_this.x);
			}

			public static Vector3 GetXXK (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_k);
			}

			public static Vector4 GetXXKL (this Vector2 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_l);
			}

			public static Vector4 GetXXKX (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetXXKY (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.y);
			}

			public static Vector3 GetXXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetXXXL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetXXXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetXXXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.y);
			}

			public static Vector3 GetXXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetXXYL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetXXYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetXXYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.y);
			}

			public static Vector2 GetXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.x, p_this.y);
			}

			public static Vector4 GetXYWL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_l);
			}

			public static Vector3 GetXYK (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_k);
			}

			public static Vector4 GetXYKL (this Vector2 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_l);
			}

			public static Vector4 GetXYKX (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetXYKY (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.y);
			}

			public static Vector3 GetXYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetXYXL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetXYXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetXYXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.y);
			}

			public static Vector3 GetXYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetXYYL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetXYYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetXYYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetYJKX (this Vector2 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.x);
			}

			public static Vector4 GetYJKY (this Vector2 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.y);
			}

			public static Vector3 GetYJX (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.x);
			}

			public static Vector4 GetYJXL (this Vector2 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_l);
			}

			public static Vector4 GetYJXX (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetYJXY (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.y);
			}

			public static Vector3 GetYJY (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.y);
			}

			public static Vector4 GetYJYL (this Vector2 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_l);
			}

			public static Vector4 GetYJYX (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetYJYY (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.y);
			}

			public static Vector2 GetYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.y, p_this.x);
			}

			public static Vector3 GetYXK (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_k);
			}

			public static Vector4 GetYXKL (this Vector2 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_l);
			}

			public static Vector4 GetYXKX (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetYXKY (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.y);
			}

			public static Vector3 GetYXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetYXXL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetYXXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetYXXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.y);
			}

			public static Vector3 GetYXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetYXYL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetYXYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetYXYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.y);
			}

			public static Vector2 GetYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.y, p_this.y);
			}

			public static Vector4 GetYYWL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_l);
			}

			public static Vector3 GetYYK (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_k);
			}

			public static Vector4 GetYYKL (this Vector2 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_l);
			}

			public static Vector4 GetYYKX (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetYYKY (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.y);
			}

			public static Vector3 GetYYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetYYXL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetYYXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetYYXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.y);
			}

			public static Vector3 GetYYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetYYYL (this Vector2 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetYYYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetYYYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.y);
			}

		#endregion
	}
}