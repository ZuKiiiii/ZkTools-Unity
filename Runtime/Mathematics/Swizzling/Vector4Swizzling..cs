using UnityEngine;

namespace ZkTools.Mathematics.Swizzling
{
	public static class Vector4Swizzling
	{
		#region // ==============================[Methods]============================== //

			public static Vector4 GetIJKX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.x);
			}

			public static Vector4 GetIJKY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.y);
			}

			public static Vector4 GetIJKZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.z);
			}

			public static Vector3 GetIJW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.w);
			}

			public static Vector4 GetIJWL (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_l);
			}

			public static Vector4 GetIJWX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_this.x);
			}

			public static Vector4 GetIJWY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_this.y);
			}

			public static Vector4 GetIJWZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_this.z);
			}

			public static Vector3 GetIJX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.x);
			}

			public static Vector4 GetIJXL (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_l);
			}

			public static Vector4 GetIJXW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.w);
			}

			public static Vector4 GetIJXX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetIJXY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetIJXZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.z);
			}

			public static Vector3 GetIJY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.y);
			}

			public static Vector4 GetIJYL (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_l);
			}

			public static Vector4 GetIJYW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.w);
			}

			public static Vector4 GetIJYX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetIJYY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetIJYZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.z);
			}

			public static Vector3 GetIJZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.z);
			}

			public static Vector4 GetIJZL (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_l);
			}

			public static Vector4 GetIJZW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.w);
			}

			public static Vector4 GetIJZX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetIJZY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetIJZZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.z);
			}

			public static Vector2 GetIX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.x);
			}

			public static Vector3 GetIXK (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_k);
			}

			public static Vector4 GetIXKL (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_l);
			}

			public static Vector4 GetIXKW (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.w);
			}

			public static Vector4 GetIXKX (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetIXKY (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetIXKZ (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.z);
			}

			public static Vector3 GetIXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.w, p_this.x);
			}

			public static Vector4 GetIXWL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.x, p_l);
			}

			public static Vector4 GetIXWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_this.w);
			}

			public static Vector4 GetIXWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_this.x);
			}

			public static Vector4 GetIXWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_this.y);
			}

			public static Vector4 GetIXWZ (this Vector4 p_this,float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_this.z);
			}

			public static Vector3 GetIXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.x);
			}

			public static Vector4 GetIXXL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetIXXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.w);
			}

			public static Vector4 GetIXXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetIXXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetIXXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetIXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.y);
			}

			public static Vector4 GetIXYL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetIXYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.w);
			}

			public static Vector4 GetIXYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetIXYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetIXYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetIXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.z);
			}

			public static Vector4 GetIXZL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetIXZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.w);
			}

			public static Vector4 GetIXZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetIXZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetIXZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetIY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.y);
			}

			public static Vector3 GetIYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.w);
			}

			public static Vector4 GetIYWL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetIYWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_this.w);
			}

			public static Vector4 GetIYWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_this.x);
			}

			public static Vector4 GetIYWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_this.y);
			}

			public static Vector4 GetIYWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_this.z);
			}

			public static Vector3 GetIYK (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_k);
			}

			public static Vector4 GetIYKL (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_l);
			}

			public static Vector4 GetIYKW (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.w);
			}

			public static Vector4 GetIYKX (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetIYKY (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetIYKZ (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.z);
			}

			public static Vector3 GetIYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.x);
			}

			public static Vector4 GetIYXL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetIYXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.w);
			}

			public static Vector4 GetIYXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetIYXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetIYXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetIYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.y);
			}

			public static Vector4 GetIYYL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetIYYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.w);
			}

			public static Vector4 GetIYYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetIYYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetIYYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetIYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.z);
			}

			public static Vector4 GetIYZL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetIYZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.w);
			}

			public static Vector4 GetIYZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetIYZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetIYZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetIZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.z);
			}

			public static Vector3 GetIZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.w);
			}

			public static Vector4 GetIZWL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetIZWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_this.w);
			}

			public static Vector4 GetIZWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_this.x);
			}

			public static Vector4 GetIZWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_this.y);
			}

			public static Vector4 GetIZWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_this.z);
			}

			public static Vector3 GetIZK (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_k);
			}

			public static Vector4 GetIZKL (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_l);
			}

			public static Vector4 GetIZKW (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.w);
			}

			public static Vector4 GetIZKX (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetIZKY (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetIZKZ (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.z);
			}

			public static Vector3 GetIZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.x);
			}

			public static Vector4 GetIZXL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetIZXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.w);
			}

			public static Vector4 GetIZXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetIZXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetIZXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetIZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.y);
			}

			public static Vector4 GetIZYL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetIZYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.w);
			}

			public static Vector4 GetIZYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetIZYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetIZYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetIZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.z);
			}

			public static Vector4 GetIZZL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetIZZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.w);
			}

			public static Vector4 GetIZZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetIZZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetIZZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetWJKX (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_k, p_this.x);
			}

			public static Vector4 GetWJKY (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_k, p_this.y);
			}

			public static Vector4 GetWJKZ (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_k, p_this.z);
			}

			public static Vector3 GetWJW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.w, p_j, p_this.w);
			}

			public static Vector4 GetWJWL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_l);
			}

			public static Vector4 GetWJWX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_this.x);
			}

			public static Vector4 GetWJWY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_this.y);
			}

			public static Vector4 GetWJWZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_this.z);
			}

			public static Vector3 GetWJX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.w, p_j, p_this.x);
			}

			public static Vector4 GetWJXL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_l);
			}

			public static Vector4 GetWJXW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_this.w);
			}

			public static Vector4 GetWJXX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetWJXY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetWJXZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_this.z);
			}

			public static Vector3 GetWJY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.w, p_j, p_this.y);
			}

			public static Vector4 GetWJYL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_l);
			}

			public static Vector4 GetWJYW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_this.w);
			}

			public static Vector4 GetWJYX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetWJYY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetWJYZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_this.z);
			}

			public static Vector3 GetWJZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.w, p_j, p_this.z);
			}

			public static Vector4 GetWJZL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_l);
			}

			public static Vector4 GetWJZW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_this.w);
			}

			public static Vector4 GetWJZX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetWJZY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetWJZZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_this.z);
			}

			public static Vector2 GetWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.w, p_this.x);
			}

			public static Vector3 GetWXK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.w, p_this.x, p_k);
			}

			public static Vector4 GetWXKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_l);
			}

			public static Vector4 GetWXKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_this.w);
			}

			public static Vector4 GetWXKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetWXKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetWXKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_this.z);
			}

			public static Vector3 GetWXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.w, p_this.x);
			}

			public static Vector4 GetWXWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_this.x, p_l);
			}

			public static Vector4 GetWXWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_this.w);
			}

			public static Vector4 GetWXWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_this.x);
			}

			public static Vector4 GetWXWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_this.y);
			}

			public static Vector4 GetWXWZ (this Vector4 p_this,float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_this.z);
			}

			public static Vector3 GetWXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.x, p_this.x);
			}

			public static Vector4 GetWXXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetWXXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_this.w);
			}

			public static Vector4 GetWXXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetWXXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetWXXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetWXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.x, p_this.y);
			}

			public static Vector4 GetWXYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetWXYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_this.w);
			}

			public static Vector4 GetWXYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetWXYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetWXYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetWXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.x, p_this.z);
			}

			public static Vector4 GetWXZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetWXZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_this.w);
			}

			public static Vector4 GetWXZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetWXZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetWXZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.w, p_this.y);
			}

			public static Vector3 GetWYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.y, p_this.w);
			}

			public static Vector4 GetWYWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetWYWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_this.w);
			}

			public static Vector4 GetWYWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_this.x);
			}

			public static Vector4 GetWYWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_this.y);
			}

			public static Vector4 GetWYWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_this.z);
			}

			public static Vector3 GetWYK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.w, p_this.y, p_k);
			}

			public static Vector4 GetWYKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_l);
			}

			public static Vector4 GetWYKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_this.w);
			}

			public static Vector4 GetWYKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetWYKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetWYKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_this.z);
			}

			public static Vector3 GetWYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.y, p_this.x);
			}

			public static Vector4 GetWYXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetWYXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_this.w);
			}

			public static Vector4 GetWYXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetWYXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetWYXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetWYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.y, p_this.y);
			}

			public static Vector4 GetWYYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetWYYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_this.w);
			}

			public static Vector4 GetWYYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetWYYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetWYYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetWYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.y, p_this.z);
			}

			public static Vector4 GetWYZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetWYZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_this.w);
			}

			public static Vector4 GetWYZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetWYZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetWYZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.w, p_this.z);
			}

			public static Vector3 GetWZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.z, p_this.w);
			}

			public static Vector4 GetWZWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetWZWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_this.w);
			}

			public static Vector4 GetWZWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_this.x);
			}

			public static Vector4 GetWZWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_this.y);
			}

			public static Vector4 GetWZWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_this.z);
			}

			public static Vector3 GetWZK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.w, p_this.z, p_k);
			}

			public static Vector4 GetWZKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_l);
			}

			public static Vector4 GetWZKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_this.w);
			}

			public static Vector4 GetWZKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetWZKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetWZKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_this.z);
			}

			public static Vector3 GetWZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.z, p_this.x);
			}

			public static Vector4 GetWZXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetWZXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_this.w);
			}

			public static Vector4 GetWZXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetWZXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetWZXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetWZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.z, p_this.y);
			}

			public static Vector4 GetWZYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetWZYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_this.w);
			}

			public static Vector4 GetWZYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetWZYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetWZYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetWZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.w, p_this.z, p_this.z);
			}

			public static Vector4 GetWZZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetWZZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_this.w);
			}

			public static Vector4 GetWZZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetWZZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetWZZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetXJKX (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.x);
			}

			public static Vector4 GetXJKY (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.y);
			}

			public static Vector4 GetXJKZ (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.z);
			}

			public static Vector3 GetXJW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.w);
			}

			public static Vector4 GetXJWL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_l);
			}

			public static Vector4 GetXJWX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_this.x);
			}

			public static Vector4 GetXJWY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_this.y);
			}

			public static Vector4 GetXJWZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_this.z);
			}

			public static Vector3 GetXJX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.x);
			}

			public static Vector4 GetXJXL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_l);
			}

			public static Vector4 GetXJXW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.w);
			}

			public static Vector4 GetXJXX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetXJXY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetXJXZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.z);
			}

			public static Vector3 GetXJY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.y);
			}

			public static Vector4 GetXJYL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_l);
			}

			public static Vector4 GetXJYW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.w);
			}

			public static Vector4 GetXJYX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetXJYY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetXJYZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.z);
			}

			public static Vector3 GetXJZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.z);
			}

			public static Vector4 GetXJZL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_l);
			}

			public static Vector4 GetXJZW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.w);
			}

			public static Vector4 GetXJZX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetXJZY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetXJZZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.z);
			}

			public static Vector2 GetXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.x, p_this.x);
			}

			public static Vector3 GetXXK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_k);
			}

			public static Vector4 GetXXKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_l);
			}

			public static Vector4 GetXXKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.w);
			}

			public static Vector4 GetXXKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetXXKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetXXKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.z);
			}

			public static Vector3 GetXXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.w, p_this.x);
			}

			public static Vector4 GetXXWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_this.x, p_l);
			}

			public static Vector4 GetXXWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_this.w);
			}

			public static Vector4 GetXXWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_this.x);
			}

			public static Vector4 GetXXWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_this.y);
			}

			public static Vector4 GetXXWZ (this Vector4 p_this,float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_this.z);
			}

			public static Vector3 GetXXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetXXXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetXXXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.w);
			}

			public static Vector4 GetXXXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetXXXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetXXXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetXXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetXXYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetXXYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.w);
			}

			public static Vector4 GetXXYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetXXYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetXXYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetXXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_this.z);
			}

			public static Vector4 GetXXZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetXXZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.w);
			}

			public static Vector4 GetXXZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetXXZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetXXZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.x, p_this.y);
			}

			public static Vector3 GetXYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_this.w);
			}

			public static Vector4 GetXYWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetXYWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_this.w);
			}

			public static Vector4 GetXYWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_this.x);
			}

			public static Vector4 GetXYWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_this.y);
			}

			public static Vector4 GetXYWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_this.z);
			}

			public static Vector3 GetXYK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_k);
			}

			public static Vector4 GetXYKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_l);
			}

			public static Vector4 GetXYKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.w);
			}

			public static Vector4 GetXYKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetXYKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetXYKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.z);
			}

			public static Vector3 GetXYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetXYXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetXYXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.w);
			}

			public static Vector4 GetXYXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetXYXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetXYXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetXYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetXYYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetXYYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.w);
			}

			public static Vector4 GetXYYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetXYYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetXYYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetXYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_this.z);
			}

			public static Vector4 GetXYZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetXYZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.w);
			}

			public static Vector4 GetXYZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetXYZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetXYZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.x, p_this.z);
			}

			public static Vector3 GetXZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.z, p_this.w);
			}

			public static Vector4 GetXZWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetXZWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_this.w);
			}

			public static Vector4 GetXZWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_this.x);
			}

			public static Vector4 GetXZWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_this.y);
			}

			public static Vector4 GetXZWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_this.z);
			}

			public static Vector3 GetXZK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.z, p_k);
			}

			public static Vector4 GetXZKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_l);
			}

			public static Vector4 GetXZKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.w);
			}

			public static Vector4 GetXZKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetXZKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetXZKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.z);
			}

			public static Vector3 GetXZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetXZXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetXZXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.w);
			}

			public static Vector4 GetXZXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetXZXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetXZXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetXZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetXZYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetXZYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.w);
			}

			public static Vector4 GetXZYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetXZYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetXZYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetXZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.x, p_this.z, p_this.z);
			}

			public static Vector4 GetXZZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetXZZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.w);
			}

			public static Vector4 GetXZZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetXZZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetXZZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetYJKX (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.x);
			}

			public static Vector4 GetYJKY (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.y);
			}

			public static Vector4 GetYJKZ (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.z);
			}

			public static Vector3 GetYJW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.w);
			}

			public static Vector4 GetYJWL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_l);
			}

			public static Vector4 GetYJWX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_this.x);
			}

			public static Vector4 GetYJWY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_this.y);
			}

			public static Vector4 GetYJWZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_this.z);
			}

			public static Vector3 GetYJX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.x);
			}

			public static Vector4 GetYJXL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_l);
			}

			public static Vector4 GetYJXW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.w);
			}

			public static Vector4 GetYJXX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetYJXY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetYJXZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.z);
			}

			public static Vector3 GetYJY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.y);
			}

			public static Vector4 GetYJYL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_l);
			}

			public static Vector4 GetYJYW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.w);
			}

			public static Vector4 GetYJYX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetYJYY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetYJYZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.z);
			}

			public static Vector3 GetYJZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.z);
			}

			public static Vector4 GetYJZL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_l);
			}

			public static Vector4 GetYJZW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.w);
			}

			public static Vector4 GetYJZX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetYJZY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetYJZZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.z);
			}

			public static Vector2 GetYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.y, p_this.x);
			}

			public static Vector3 GetYXK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_k);
			}

			public static Vector4 GetYXKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_l);
			}

			public static Vector4 GetYXKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.w);
			}

			public static Vector4 GetYXKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetYXKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetYXKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.z);
			}

			public static Vector3 GetYXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.w, p_this.x);
			}

			public static Vector4 GetYXWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_this.x, p_l);
			}

			public static Vector4 GetYXWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_this.w);
			}

			public static Vector4 GetYXWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_this.x);
			}

			public static Vector4 GetYXWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_this.y);
			}

			public static Vector4 GetYXWZ (this Vector4 p_this,float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_this.z);
			}

			public static Vector3 GetYXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetYXXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetYXXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.w);
			}

			public static Vector4 GetYXXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetYXXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetYXXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetYXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetYXYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetYXYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.w);
			}

			public static Vector4 GetYXYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetYXYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetYXYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetYXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_this.z);
			}

			public static Vector4 GetYXZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetYXZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.w);
			}

			public static Vector4 GetYXZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetYXZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetYXZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.y, p_this.y);
			}

			public static Vector3 GetYYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_this.w);
			}

			public static Vector4 GetYYWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetYYWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_this.w);
			}

			public static Vector4 GetYYWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_this.x);
			}

			public static Vector4 GetYYWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_this.y);
			}

			public static Vector4 GetYYWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_this.z);
			}

			public static Vector3 GetYYK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_k);
			}

			public static Vector4 GetYYKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_l);
			}

			public static Vector4 GetYYKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.w);
			}

			public static Vector4 GetYYKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetYYKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetYYKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.z);
			}

			public static Vector3 GetYYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetYYXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetYYXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.w);
			}

			public static Vector4 GetYYXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetYYXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetYYXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetYYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetYYYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetYYYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.w);
			}

			public static Vector4 GetYYYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetYYYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetYYYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetYYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_this.z);
			}

			public static Vector4 GetYYZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetYYZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.w);
			}

			public static Vector4 GetYYZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetYYZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetYYZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.y, p_this.z);
			}

			public static Vector3 GetYZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.z, p_this.w);
			}

			public static Vector4 GetYZWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetYZWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_this.w);
			}

			public static Vector4 GetYZWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_this.x);
			}

			public static Vector4 GetYZWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_this.y);
			}

			public static Vector4 GetYZWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_this.z);
			}

			public static Vector3 GetYZK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.z, p_k);
			}

			public static Vector4 GetYZKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_l);
			}

			public static Vector4 GetYZKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.w);
			}

			public static Vector4 GetYZKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetYZKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetYZKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.z);
			}

			public static Vector3 GetYZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetYZXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetYZXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.w);
			}

			public static Vector4 GetYZXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetYZXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetYZXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetYZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetYZYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetYZYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.w);
			}

			public static Vector4 GetYZYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetYZYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetYZYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetYZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.y, p_this.z, p_this.z);
			}

			public static Vector4 GetYZZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetYZZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.w);
			}

			public static Vector4 GetYZZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetYZZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetYZZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetZJKX (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.x);
			}

			public static Vector4 GetZJKY (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.y);
			}

			public static Vector4 GetZJKZ (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.z);
			}

			public static Vector3 GetZJW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.w);
			}

			public static Vector4 GetZJWL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_l);
			}

			public static Vector4 GetZJWX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_this.x);
			}

			public static Vector4 GetZJWY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_this.y);
			}

			public static Vector4 GetZJWZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_this.z);
			}

			public static Vector3 GetZJX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.x);
			}

			public static Vector4 GetZJXL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_l);
			}

			public static Vector4 GetZJXW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.w);
			}

			public static Vector4 GetZJXX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetZJXY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetZJXZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.z);
			}

			public static Vector3 GetZJY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.y);
			}

			public static Vector4 GetZJYL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_l);
			}

			public static Vector4 GetZJYW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.w);
			}

			public static Vector4 GetZJYX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetZJYY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetZJYZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.z);
			}

			public static Vector3 GetZJZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.z);
			}

			public static Vector4 GetZJZL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_l);
			}

			public static Vector4 GetZJZW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.w);
			}

			public static Vector4 GetZJZX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetZJZY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetZJZZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.z);
			}

			public static Vector2 GetZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.z, p_this.x);
			}

			public static Vector3 GetZXK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.x, p_k);
			}

			public static Vector4 GetZXKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_l);
			}

			public static Vector4 GetZXKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.w);
			}

			public static Vector4 GetZXKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetZXKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetZXKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.z);
			}

			public static Vector3 GetZXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.w, p_this.x);
			}

			public static Vector4 GetZXWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_this.x, p_l);
			}

			public static Vector4 GetZXWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_this.w);
			}

			public static Vector4 GetZXWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_this.x);
			}

			public static Vector4 GetZXWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_this.y);
			}

			public static Vector4 GetZXWZ (this Vector4 p_this,float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_this.z);
			}

			public static Vector3 GetZXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetZXXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetZXXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.w);
			}

			public static Vector4 GetZXXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetZXXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetZXXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetZXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetZXYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetZXYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.w);
			}

			public static Vector4 GetZXYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetZXYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetZXYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetZXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.x, p_this.z);
			}

			public static Vector4 GetZXZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetZXZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.w);
			}

			public static Vector4 GetZXZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetZXZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetZXZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.z, p_this.y);
			}

			public static Vector3 GetZYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.y, p_this.w);
			}

			public static Vector4 GetZYWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetZYWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_this.w);
			}

			public static Vector4 GetZYWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_this.x);
			}

			public static Vector4 GetZYWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_this.y);
			}

			public static Vector4 GetZYWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_this.z);
			}

			public static Vector3 GetZYK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.y, p_k);
			}

			public static Vector4 GetZYKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_l);
			}

			public static Vector4 GetZYKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.w);
			}

			public static Vector4 GetZYKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetZYKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetZYKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.z);
			}

			public static Vector3 GetZYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetZYXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetZYXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.w);
			}

			public static Vector4 GetZYXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetZYXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetZYXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetZYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetZYYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetZYYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.w);
			}

			public static Vector4 GetZYYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetZYYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetZYYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetZYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.y, p_this.z);
			}

			public static Vector4 GetZYZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetZYZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.w);
			}

			public static Vector4 GetZYZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetZYZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetZYZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_this.z, p_this.z);
			}

			public static Vector3 GetZZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.z, p_this.w);
			}

			public static Vector4 GetZZWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetZZWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_this.w);
			}

			public static Vector4 GetZZWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_this.x);
			}

			public static Vector4 GetZZWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_this.y);
			}

			public static Vector4 GetZZWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_this.z);
			}

			public static Vector3 GetZZK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.z, p_k);
			}

			public static Vector4 GetZZKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_l);
			}

			public static Vector4 GetZZKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.w);
			}

			public static Vector4 GetZZKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetZZKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetZZKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.z);
			}

			public static Vector3 GetZZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetZZXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetZZXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.w);
			}

			public static Vector4 GetZZXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetZZXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetZZXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetZZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetZZYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetZZYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.w);
			}

			public static Vector4 GetZZYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetZZYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetZZYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetZZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetZZZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetZZZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.w);
			}

			public static Vector4 GetZZZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetZZZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetZZZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.z);
			}

		#endregion
	}
}