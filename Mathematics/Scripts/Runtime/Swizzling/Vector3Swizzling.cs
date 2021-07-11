using UnityEngine;

namespace ZkTools.Mathematics.Swizzling
{
	public static class Vector3Swizzling
	{
		#region ==============================[Methods]==============================

			public static Vector4 GetIJKX (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.x);
			}

			public static Vector4 GetIJKX (this Vector3 p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKX(p_ij.x, p_ij.y, p_k);
			}

			public static Vector4 GetIJKX (this Vector3 p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKX(p_i, p_jk.x, p_jk.y);
			}

			public static Vector4 GetIJKX (this Vector3 p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKX(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			public static Vector4 GetIJKY (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.y);
			}

			public static Vector4 GetIJKY (this Vector3 p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKY(p_ij.x, p_ij.y, p_k);
			}

			public static Vector4 GetIJKY (this Vector3 p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKY(p_i, p_jk.x, p_jk.y);
			}

			public static Vector4 GetIJKY (this Vector3 p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKY(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			public static Vector4 GetIJKZ (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.z);
			}

			public static Vector4 GetIJKZ (this Vector3 p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKZ(p_ij.x, p_ij.y, p_k);
			}

			public static Vector4 GetIJKZ (this Vector3 p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKZ(p_i, p_jk.x, p_jk.y);
			}

			public static Vector4 GetIJKZ (this Vector3 p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKZ(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			public static Vector3 GetIJX (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.x);
			}

			public static Vector3 GetIJX (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJX(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJXL (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_l);
			}

			public static Vector4 GetIJXL (this Vector3 p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJXL(p_ij.x, p_ij.y, p_l);
			}

			public static Vector4 GetIJXL (this Vector3 p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJXL(p_i, p_jl.x, p_jl.y);
			}

			public static Vector4 GetIJXL (this Vector3 p_this, Vector3 p_ijl)
			{
				return p_this.GetIJXL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			public static Vector4 GetIJXX (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetIJXX (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJXX(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJXY (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetIJXY (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJXY(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJXZ (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.z);
			}

			public static Vector4 GetIJXZ (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJXZ(p_ij.x, p_ij.y);
			}

			public static Vector3 GetIJY (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.y);
			}

			public static Vector3 GetIJY (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJY(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJYL (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_l);
			}

			public static Vector4 GetIJYL (this Vector3 p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJYL(p_ij.x, p_ij.y, p_l);
			}

			public static Vector4 GetIJYL (this Vector3 p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJYL(p_i, p_jl.x, p_jl.y);
			}

			public static Vector4 GetIJYL (this Vector3 p_this, Vector3 p_ijl)
			{
				return p_this.GetIJYL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			public static Vector4 GetIJYX (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetIJYX (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJYX(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJYY (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetIJYY (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJYY(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJYZ (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.z);
			}

			public static Vector4 GetIJYZ (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJYZ(p_ij.x, p_ij.y);
			}

			public static Vector3 GetIJZ (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.z);
			}

			public static Vector3 GetIJZ (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJZ(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJZL (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_l);
			}

			public static Vector4 GetIJZL (this Vector3 p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJZL(p_ij.x, p_ij.y, p_l);
			}

			public static Vector4 GetIJZL (this Vector3 p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJZL(p_i, p_jl.x, p_jl.y);
			}

			public static Vector4 GetIJZL (this Vector3 p_this, Vector3 p_ijl)
			{
				return p_this.GetIJZL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			public static Vector4 GetIJZX (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetIJZX (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJZX(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJZY (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetIJZY (this Vector3 p_this, Vector2 p_ij)
			{
				return p_this.GetIJZY(p_ij.x, p_ij.y);
			}

			public static Vector4 GetIJZZ (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.z);
			}

			public static Vector4 GetIJZZ (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIJZZ(p_ik.x, p_ik.y);
			}

			public static Vector2 GetIX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.x);
			}

			public static Vector3 GetIXK (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_k);
			}

			public static Vector3 GetIXK (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIXK(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIXKL (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_l);
			}

			public static Vector4 GetIXKL (this Vector3 p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIXKL(p_ik.x, p_ik.y, p_l);
			}

			public static Vector4 GetIXKL (this Vector3 p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIXKL(p_i, p_kl.x, p_kl.y);
			}

			public static Vector4 GetIXKL (this Vector3 p_this, Vector3 p_ikl)
			{
				return p_this.GetIXKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			public static Vector4 GetIXKX (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetIXKX (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIXKX(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIXKY (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetIXKY (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIXKY(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIXKZ (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.z);
			}

			public static Vector4 GetIXKZ (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIXKZ(p_ik.x, p_ik.y);
			}

			public static Vector3 GetIXX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.x);
			}

			public static Vector4 GetIXXL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetIXXL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIXXL(p_il.x, p_il.y);
			}

			public static Vector4 GetIXXX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetIXXY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetIXXZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetIXY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.y);
			}

			public static Vector4 GetIXYL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetIXYL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIXYL(p_il.x, p_il.y);
			}

			public static Vector4 GetIXYX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetIXYY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetIXYZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetIXZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.z);
			}

			public static Vector4 GetIXZL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetIXZL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIXZL(p_il.x, p_il.y);
			}

			public static Vector4 GetIXZX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetIXZY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetIXZZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetIY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.y);
			}

			public static Vector3 GetIYK (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_k);
			}

			public static Vector3 GetIYK (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIYK(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIYKL (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_l);
			}

			public static Vector4 GetIYKL (this Vector3 p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIYKL(p_ik.x, p_ik.y, p_l);
			}

			public static Vector4 GetIYKL (this Vector3 p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIYKL(p_i, p_kl.x, p_kl.y);
			}

			public static Vector4 GetIYKL (this Vector3 p_this, Vector3 p_ikl)
			{
				return p_this.GetIYKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			public static Vector4 GetIYKX (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetIYKX (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIYKX(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIYKY (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetIYKY (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIYKY(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIYKZ (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.z);
			}

			public static Vector4 GetIYKZ (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIYKZ(p_il.x, p_il.y);
			}

			public static Vector3 GetIYX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.x);
			}

			public static Vector4 GetIYXL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetIYXL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIYXL(p_il.x, p_il.y);
			}

			public static Vector4 GetIYXX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetIYXY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetIYXZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetIYY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.y);
			}

			public static Vector4 GetIYYL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetIYYL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIYYL(p_il.x, p_il.y);
			}

			public static Vector4 GetIYYX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetIYYY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetIYYZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetIYZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.z);
			}

			public static Vector4 GetIYZL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetIYZL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIYZL(p_il.x, p_il.y);
			}

			public static Vector4 GetIYZX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetIYZY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetIYZZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetIZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.z);
			}

			public static Vector3 GetIZK (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_k);
			}

			public static Vector3 GetIZK (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIZK(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIZKL (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_l);
			}

			public static Vector4 GetIZKL (this Vector3 p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIZKL(p_ik.x, p_ik.y, p_l);
			}

			public static Vector4 GetIZKL (this Vector3 p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIZKL(p_i, p_kl.x, p_kl.y);
			}

			public static Vector4 GetIZKL (this Vector3 p_this, Vector3 p_ikl)
			{
				return p_this.GetIZKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			public static Vector4 GetIZKX (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetIZKX (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIZKX(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIZKY (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetIZKY (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIZKY(p_ik.x, p_ik.y);
			}

			public static Vector4 GetIZKZ (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.z);
			}

			public static Vector4 GetIZKZ (this Vector3 p_this, Vector2 p_ik)
			{
				return p_this.GetIZKZ(p_ik.x, p_ik.y);
			}

			public static Vector3 GetIZX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.x);
			}

			public static Vector4 GetIZXL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetIZXL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIZXL(p_il.x, p_il.y);
			}

			public static Vector4 GetIZXX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetIZXY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetIZXZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetIZY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.y);
			}

			public static Vector4 GetIZYL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetIZYL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIZYL(p_il.x, p_il.y);
			}

			public static Vector4 GetIZYX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetIZYY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetIZYZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetIZZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.z);
			}

			public static Vector4 GetIZZL (this Vector3 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetIZZL (this Vector3 p_this, Vector2 p_il)
			{
				return p_this.GetIZZL(p_il.x, p_il.y);
			}

			public static Vector4 GetIZZX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetIZZY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetIZZZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetXJKX (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.x);
			}

			public static Vector4 GetXJKX (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetXJKX(p_jk.x, p_jk.y);
			}

			public static Vector4 GetXJKY (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.y);
			}

			public static Vector4 GetXJKY (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetXJKY(p_jk.x, p_jk.y);
			}

			public static Vector4 GetXJKZ (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.z);
			}

			public static Vector4 GetXJKZ (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetXJKZ(p_jk.x, p_jk.y);
			}

			public static Vector3 GetXJX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.x);
			}

			public static Vector4 GetXJXL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_l);
			}

			public static Vector4 GetXJXL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetXJXL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetXJXX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetXJXY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetXJXZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.z);
			}

			public static Vector3 GetXJY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.y);
			}

			public static Vector4 GetXJYL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_l);
			}

			public static Vector4 GetXJYL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetXJYL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetXJYX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetXJYY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetXJYZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.z);
			}

			public static Vector3 GetXJZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.z);
			}

			public static Vector4 GetXJZL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_l);
			}

			public static Vector4 GetXJZL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetXJZL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetXJZX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetXJZY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetXJZZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.z);
			}

			public static Vector2 GetXX (this Vector3 p_this)
			{
				return new Vector2(p_this.x, p_this.x);
			}

			public static Vector3 GetXXK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_k);
			}

			public static Vector4 GetXXKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_l);
			}

			public static Vector4 GetXXKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetXXKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetXXKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetXXKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetXXKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.z);
			}

			public static Vector3 GetXXX (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetXXXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetXXXX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetXXXY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetXXXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetXXY (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetXXYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetXXYX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetXXYY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetXXYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetXXZ (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.z);
			}

			public static Vector4 GetXXZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetXXZX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetXXZY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetXXZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetXY (this Vector3 p_this)
			{
				return new Vector2(p_this.x, p_this.y);
			}

			public static Vector3 GetXYK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_k);
			}

			public static Vector4 GetXYKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_l);
			}

			public static Vector4 GetXYKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetXYKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetXYKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetXYKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetXYKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.z);
			}

			public static Vector3 GetXYX (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetXYXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetXYXX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetXYXY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetXYXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetXYY (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetXYYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetXYYX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetXYYY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetXYYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetXYZ (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.z);
			}

			public static Vector4 GetXYZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetXYZX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetXYZY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetXYZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetXZ (this Vector3 p_this)
			{
				return new Vector2(p_this.x, p_this.z);
			}

			public static Vector3 GetXZK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.z, p_k);
			}

			public static Vector4 GetXZKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_l);
			}

			public static Vector4 GetXZKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetXZKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetXZKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetXZKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetXZKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.z);
			}

			public static Vector3 GetXZX (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetXZXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetXZXX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetXZXY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetXZXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetXZY (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetXZYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetXZYX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetXZYY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetXZYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetXZZ (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.z);
			}

			public static Vector4 GetXZZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetXZZX (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetXZZY (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetXZZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetYJKX (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.x);
			}

			public static Vector4 GetYJKX (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetYJKX(p_jk.x, p_jk.y);
			}

			public static Vector4 GetYJKY (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.y);
			}

			public static Vector4 GetYJKY (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetYJKY(p_jk.x, p_jk.y);
			}

			public static Vector4 GetYJKZ (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.z);
			}

			public static Vector4 GetYJKZ (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetYJKZ(p_jk.x, p_jk.y);
			}

			public static Vector3 GetYJX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.x);
			}

			public static Vector4 GetYJXL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_l);
			}

			public static Vector4 GetYJXL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetYJXL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetYJXX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetYJXY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetYJXZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.z);
			}

			public static Vector3 GetYJY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.y);
			}

			public static Vector4 GetYJYL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_l);
			}

			public static Vector4 GetYJYL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetYJYL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetYJYX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetYJYY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetYJYZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.z);
			}

			public static Vector3 GetYJZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.z);
			}

			public static Vector4 GetYJZL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_l);
			}

			public static Vector4 GetYJZL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetYJZL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetYJZX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetYJZY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetYJZZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.z);
			}

			public static Vector2 GetYX (this Vector3 p_this)
			{
				return new Vector2(p_this.y, p_this.x);
			}

			public static Vector3 GetYXK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_k);
			}

			public static Vector4 GetYXKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_l);
			}

			public static Vector4 GetYXKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetYXKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetYXKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetYXKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetYXKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.z);
			}

			public static Vector3 GetYXX (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetYXXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetYXXX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetYXXY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetYXXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetYXY (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetYXYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetYXYX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetYXYY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetYXYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetYXZ (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.z);
			}

			public static Vector4 GetYXZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetYXZX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetYXZY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetYXZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetYY (this Vector3 p_this)
			{
				return new Vector2(p_this.y, p_this.y);
			}

			public static Vector3 GetYYK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_k);
			}

			public static Vector4 GetYYKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_l);
			}

			public static Vector4 GetYYKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetYYKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetYYKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetYYKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetYYKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.z);
			}

			public static Vector3 GetYYX (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetYYXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetYYXX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetYYXY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetYYXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetYYY (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetYYYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetYYYX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetYYYY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetYYYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetYYZ (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.z);
			}

			public static Vector4 GetYYZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetYYZX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetYYZY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetYYZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetYZ (this Vector3 p_this)
			{
				return new Vector2(p_this.y, p_this.z);
			}

			public static Vector3 GetYZK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.z, p_k);
			}

			public static Vector4 GetYZKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_l);
			}

			public static Vector4 GetYZKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetYZKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetYZKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetYZKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetYZKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.z);
			}

			public static Vector3 GetYZX (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetYZXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetYZXX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetYZXY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetYZXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetYZY (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetYZYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetYZYX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetYZYY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetYZYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetYZZ (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.z);
			}

			public static Vector4 GetYZZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetYZZX (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetYZZY (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetYZZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetZJKX (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.x);
			}

			public static Vector4 GetZJKX (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetZJKX(p_jk.x, p_jk.y);
			}

			public static Vector4 GetZJKY (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.y);
			}

			public static Vector4 GetZJKY (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetZJKY(p_jk.x, p_jk.y);
			}

			public static Vector4 GetZJKZ (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.z);
			}

			public static Vector4 GetZJKZ (this Vector3 p_this, Vector2 p_jk)
			{
				return p_this.GetZJKZ(p_jk.x, p_jk.y);
			}

			public static Vector3 GetZJX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.x);
			}

			public static Vector4 GetZJXL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_l);
			}

			public static Vector4 GetZJXL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetZJXL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetZJXX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.x);
			}

			public static Vector4 GetZJXY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.y);
			}

			public static Vector4 GetZJXZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.z);
			}

			public static Vector3 GetZJY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.y);
			}

			public static Vector4 GetZJYL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_l);
			}

			public static Vector4 GetZJYL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetZJYL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetZJYX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.x);
			}

			public static Vector4 GetZJYY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.y);
			}

			public static Vector4 GetZJYZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.z);
			}

			public static Vector3 GetZJZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.z);
			}

			public static Vector4 GetZJZL (this Vector3 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_l);
			}

			public static Vector4 GetZJZL (this Vector3 p_this, Vector2 p_jl)
			{
				return p_this.GetZJZL(p_jl.x, p_jl.y);
			}

			public static Vector4 GetZJZX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.x);
			}

			public static Vector4 GetZJZY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.y);
			}

			public static Vector4 GetZJZZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.z);
			}

			public static Vector2 GetZX (this Vector3 p_this)
			{
				return new Vector2(p_this.z, p_this.x);
			}

			public static Vector3 GetZXK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.x, p_k);
			}

			public static Vector4 GetZXKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_l);
			}

			public static Vector4 GetZXKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetZXKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetZXKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.x);
			}

			public static Vector4 GetZXKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.y);
			}

			public static Vector4 GetZXKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.z);
			}

			public static Vector3 GetZXX (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetZXXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_l);
			}

			public static Vector4 GetZXXX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.x);
			}

			public static Vector4 GetZXXY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.y);
			}

			public static Vector4 GetZXXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.z);
			}

			public static Vector3 GetZXY (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetZXYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_l);
			}

			public static Vector4 GetZXYX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.x);
			}

			public static Vector4 GetZXYY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.y);
			}

			public static Vector4 GetZXYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.z);
			}

			public static Vector3 GetZXZ (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.z);
			}

			public static Vector4 GetZXZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_l);
			}

			public static Vector4 GetZXZX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.x);
			}

			public static Vector4 GetZXZY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.y);
			}

			public static Vector4 GetZXZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.z);
			}

			public static Vector2 GetZY (this Vector3 p_this)
			{
				return new Vector2(p_this.z, p_this.y);
			}

			public static Vector3 GetZYK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.y, p_k);
			}

			public static Vector4 GetZYKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_l);
			}

			public static Vector4 GetZYKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetZYKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetZYKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.x);
			}

			public static Vector4 GetZYKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.y);
			}

			public static Vector4 GetZYKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.z);
			}

			public static Vector3 GetZYX (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetZYXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_l);
			}

			public static Vector4 GetZYXX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.x);
			}

			public static Vector4 GetZYXY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.y);
			}

			public static Vector4 GetZYXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.z);
			}

			public static Vector3 GetZYY (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetZYYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_l);
			}

			public static Vector4 GetZYYX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.x);
			}

			public static Vector4 GetZYYY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.y);
			}

			public static Vector4 GetZYYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.z);
			}

			public static Vector3 GetZYZ (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.z);
			}

			public static Vector4 GetZYZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_l);
			}

			public static Vector4 GetZYZX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.x);
			}

			public static Vector4 GetZYZY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.y);
			}

			public static Vector4 GetZYZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.z);
			}

			public static Vector2 GetZZ (this Vector3 p_this)
			{
				return new Vector2(p_this.z, p_this.z);
			}

			public static Vector3 GetZZK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.z, p_k);
			}

			public static Vector4 GetZZKL (this Vector3 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_l);
			}

			public static Vector4 GetZZKL (this Vector3 p_this, Vector2 p_kl)
			{
				return p_this.GetZZKL(p_kl.x, p_kl.y);
			}

			public static Vector4 GetZZKX (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.x);
			}

			public static Vector4 GetZZKY (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.y);
			}

			public static Vector4 GetZZKZ (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.z);
			}

			public static Vector3 GetZZX (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetZZXL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_l);
			}

			public static Vector4 GetZZXX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.x);
			}

			public static Vector4 GetZZXY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.y);
			}

			public static Vector4 GetZZXZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.z);
			}

			public static Vector3 GetZZY (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetZZYL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_l);
			}

			public static Vector4 GetZZYX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.x);
			}

			public static Vector4 GetZZYY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.y);
			}

			public static Vector4 GetZZYZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.z);
			}

			public static Vector3 GetZZZ (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.z);
			}

			public static Vector4 GetZZZL (this Vector3 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_l);
			}

			public static Vector4 GetZZZX (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.x);
			}

			public static Vector4 GetZZZY (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.y);
			}

			public static Vector4 GetZZZZ (this Vector3 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.z);
			}

		#endregion
	}
}