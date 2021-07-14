using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Swizzling
{
	public static class Vector4Swizzling
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKW (this Vector4 p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKW(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKW (this Vector4 p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKW(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKW (this Vector4 p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKW(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKX (this Vector4 p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKX(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKX (this Vector4 p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKX(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKX (this Vector4 p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKX(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKY (this Vector4 p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKY(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKY (this Vector4 p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKY(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKY (this Vector4 p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKY(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKZ (this Vector4 p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKZ(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKZ (this Vector4 p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKZ(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJKZ (this Vector4 p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKZ(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJW (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWL (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWL (this Vector4 p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJWL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWL (this Vector4 p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJWL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWL (this Vector4 p_this, Vector3 p_ijl)
			{
				return p_this.GetIJWL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWW (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJWW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWX (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJWX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWY (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJWY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJWZ (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJWZ(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJX (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXL (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXL (this Vector4 p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJXL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXL (this Vector4 p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJXL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXL (this Vector4 p_this, Vector3 p_ijl)
			{
				return p_this.GetIJXL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXW (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJXW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXX (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJXX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXY (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJXY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJXZ (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJXZ(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJY (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYL (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYL (this Vector4 p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJYL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYL (this Vector4 p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJYL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYL (this Vector4 p_this, Vector3 p_ijl)
			{
				return p_this.GetIJYL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYW (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJYW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYX (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJYX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYY (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJYY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJYZ (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJYZ(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJZ (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJZ(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZL (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZL (this Vector4 p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJZL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZL (this Vector4 p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJZL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZL (this Vector4 p_this, Vector3 p_ijl)
			{
				return p_this.GetIJZL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZW (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZW (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJZW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZX (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZX (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJZX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZY (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZY (this Vector4 p_this, Vector2 p_ij)
			{
				return p_this.GetIJZY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZZ (this Vector4 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIJZZ (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIJZZ(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetIW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIWK (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIWK (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIWK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKL (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKL (this Vector4 p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIWKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKL (this Vector4 p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIWKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKL (this Vector4 p_this, Vector3 p_ikl)
			{
				return p_this.GetIWKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKW (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKW (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIWKW(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKX (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKX (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIWKX(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKY (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKY (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIWKY(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKZ (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWKZ (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIWKZ(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWWL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWWL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIWWL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWWZ (this Vector4 p_this,float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWXL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWXL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIWXL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWXZ (this Vector4 p_this,float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWYL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWYL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIWYL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWZL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWZL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIWZL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIWZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetIX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIXK (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIXK (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIXK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKL (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKL (this Vector4 p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIXKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKL (this Vector4 p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIXKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKL (this Vector4 p_this, Vector3 p_ikl)
			{
				return p_this.GetIXKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKW (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKW (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIXKW(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKX (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKX (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIXKX(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKY (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKY (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIXKY(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKZ (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXKZ (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIXKZ(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXWL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXWL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIXWL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXWZ (this Vector4 p_this,float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXXL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXXL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIXXL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXYL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXYL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIXYL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXZL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXZL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIXZL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIXZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetIY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYWL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYWL (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIYWL(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIYK (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIYK (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIYK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKL (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKL (this Vector4 p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIYKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKL (this Vector4 p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIYKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKL (this Vector4 p_this, Vector3 p_ikl)
			{
				return p_this.GetIYKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKW (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKW (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIYKW(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKX (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKX (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIYKX(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKY (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKY (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIYKY(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKZ (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYKZ (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIYKZ(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYXL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYXL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIYXL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYYL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYYL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIYYL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYZL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYZL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIYZL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIYZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetIZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZWL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZWL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIZWL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZWW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZWX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZWY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZWZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIZK (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIZK (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIZK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKL (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKL (this Vector4 p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIZKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKL (this Vector4 p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIZKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKL (this Vector4 p_this, Vector3 p_ikl)
			{
				return p_this.GetIZKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKW (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKW (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIZKW(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKX (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKX (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIZKX(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKY (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKY (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIZKY(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKZ (this Vector4 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZKZ (this Vector4 p_this, Vector2 p_ik)
			{
				return p_this.GetIZKZ(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZXL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZXL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIZXL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZXW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZXX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZXY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZXZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZYL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZYL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIZYL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZYW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZYX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZYY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZYZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZZL (this Vector4 p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZZL (this Vector4 p_this, Vector2 p_il)
			{
				return p_this.GetIZZL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZZW (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZZX (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZZY (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetIZZZ (this Vector4 p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJKW (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJKW (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetWJKW(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJKX (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJKX (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetWJKX(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJKY (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJKY (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetWJKY(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJKZ (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJKZ (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetWJKZ(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWJW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.w, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJWL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJWL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetWJWL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJWW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJWX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJWY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJWZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWJX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.w, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJXL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJXL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetWJXL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJXW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJXX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJXY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJXZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWJY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.w, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJYL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJYL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetWJYL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJYW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJYX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJYY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJYZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWJZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.w, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJZL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJZL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetWJZL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJZW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJZX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJZY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWJZZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.w, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetWW (this Vector4 p_this)
			{
				return new Vector2(p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWWK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.w, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetWWKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWWW (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWWW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWWX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWWY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWWX (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWXW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWXX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWXY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWWY (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWYW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWYX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWYY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWWZ (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWZW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWZX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWZY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWWZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetWX (this Vector4 p_this)
			{
				return new Vector2(p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWXK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.w, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetWXKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWXW (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXWW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXWX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXWY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWXX (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXXW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXXX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXXY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWXY (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXYW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXYX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXYY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWXZ (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXZW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXZX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXZY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWXZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetWY (this Vector4 p_this)
			{
				return new Vector2(p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWYW (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYWW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYWX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYWY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWYK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.w, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetWYKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWYX (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYXW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYXX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYXY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWYY (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYYW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYYX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYYY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWYZ (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYZW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYZX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYZY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWYZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetWZ (this Vector4 p_this)
			{
				return new Vector2(p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWZW (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZWW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZWX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZWY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWZK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.w, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetWZKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWZX (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZXW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZXX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZXY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWZY (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZYW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZYX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZYY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetWZZ (this Vector4 p_this)
			{
				return new Vector3(p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZZW (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZZX (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZZY (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetWZZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.w, p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJKW (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJKW (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetXJKW(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJKX (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJKX (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetXJKX(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJKY (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJKY (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetXJKY(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJKZ (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJKZ (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetXJKZ(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXJW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJWL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJWL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetXJWL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJWW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJWX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJWY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJWZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXJX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJXL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJXL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetXJXL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJXW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJXX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJXY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJXZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXJY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJYL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJYL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetXJYL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJYW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJYX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJYY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJYZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXJZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJZL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJZL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetXJZL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJZW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJZX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJZY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXJZZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.x, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetXW (this Vector4 p_this)
			{
				return new Vector2(p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXWK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetXWKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXWW (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWWW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWWX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWWY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXWX (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWXW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWXX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWXY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXWY (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWYW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWYX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWYY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXWZ (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWZW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWZX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWZY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXWZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetXX (this Vector4 p_this)
			{
				return new Vector2(p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXXK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetXXKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXXW (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXWW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXWX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXWY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXXX (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXXW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXXX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXXY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXXY (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXYW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXYX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXYY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXXZ (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXZW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXZX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXZY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXXZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetXY (this Vector4 p_this)
			{
				return new Vector2(p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXYW (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYWW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYWX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYWY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXYK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetXYKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXYX (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYXW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYXX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYXY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXYY (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYYW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYYX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYYY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXYZ (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYZW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYZX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYZY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXYZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetXZ (this Vector4 p_this)
			{
				return new Vector2(p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXZW (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZWW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZWX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZWY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXZK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetXZKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXZX (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZXW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZXX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZXY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXZY (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZYW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZYX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZYY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetXZZ (this Vector4 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZZW (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZZX (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZZY (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetXZZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.x, p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJKW (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJKW (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetYJKW(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJKX (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJKX (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetYJKX(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJKY (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJKY (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetYJKY(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJKZ (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJKZ (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetYJKZ(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYJW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJWL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJWL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetYJWL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJWW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJWX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJWY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJWZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYJX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJXL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJXL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetYJXL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJXW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJXX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJXY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJXZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYJY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJYL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJYL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetYJYL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJYW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJYX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJYY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJYZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYJZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJZL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJZL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetYJZL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJZW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJZX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJZY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYJZZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.y, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetYW (this Vector4 p_this)
			{
				return new Vector2(p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYWK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetYWKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYWW (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWWW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWWX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWWY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYWX (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWXW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWXX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWXY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYWY (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWYW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWYX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWYY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYWZ (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWZW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWZX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWZY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYWZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetYX (this Vector4 p_this)
			{
				return new Vector2(p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYXK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetYXKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYXW (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXWW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXWX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXWY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYXX (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXXW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXXX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXXY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYXY (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXYW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXYX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXYY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYXZ (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXZW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXZX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXZY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYXZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetYY (this Vector4 p_this)
			{
				return new Vector2(p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYYW (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYWW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYWX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYWY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYYK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetYYKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYYX (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYXW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYXX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYXY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYYY (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYYW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYYX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYYY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYYZ (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYZW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYZX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYZY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYYZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetYZ (this Vector4 p_this)
			{
				return new Vector2(p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYZW (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZWW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZWX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZWY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYZK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetYZKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYZX (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZXW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZXX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZXY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYZY (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZYW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZYX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZYY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetYZZ (this Vector4 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZZW (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZZX (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZZY (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetYZZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.y, p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJKW (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJKW (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetZJKW(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJKX (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJKX (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetZJKX(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJKY (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJKY (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetZJKY(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJKZ (this Vector4 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJKZ (this Vector4 p_this, Vector2 p_jk)
			{
				return p_this.GetZJKZ(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZJW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJWL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJWL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetZJWL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJWW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJWX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJWY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJWZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZJX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJXL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJXL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetZJXL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJXW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJXX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJXY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJXZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZJY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJYL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJYL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetZJYL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJYW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJYX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJYY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJYZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZJZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJZL (this Vector4 p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJZL (this Vector4 p_this, Vector2 p_jl)
			{
				return p_this.GetZJZL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJZW (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJZX (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJZY (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZJZZ (this Vector4 p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.z, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetZW (this Vector4 p_this)
			{
				return new Vector2(p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZWW (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWWW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWWX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWWY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZWK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetZWKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZWX (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWXW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWXX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWXY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZWY (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWYW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWYX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWYY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZWZ (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWZW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWZX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWZY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZWZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetZX (this Vector4 p_this)
			{
				return new Vector2(p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZXK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetZXKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZXW (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXWW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXWX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXWY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZXX (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXXW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXXX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXXY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZXY (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXYW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXYX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXYY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZXZ (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXZW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXZX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXZY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZXZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetZY (this Vector4 p_this)
			{
				return new Vector2(p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZYW (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYWW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYWX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYWY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZYK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetZYKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZYX (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYXW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYXX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYXY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZYY (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYYW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYYX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYYY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZYZ (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYZW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYZX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYZY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZYZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetZZ (this Vector4 p_this)
			{
				return new Vector2(p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZZW (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZWL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZWW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZWX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZWY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZWZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZZK (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZKL (this Vector4 p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZKL (this Vector4 p_this, Vector2 p_kl)
			{
				return p_this.GetZZKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZKW (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZKX (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZKY (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZKZ (this Vector4 p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZZX (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZXL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZXW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZXX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZXY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZXZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZZY (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZYL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZYW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZYX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZYY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZYZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetZZZ (this Vector4 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZZL (this Vector4 p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZZW (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZZX (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZZY (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetZZZZ (this Vector4 p_this)
			{
				return new Vector4(p_this.z, p_this.z, p_this.z, p_this.z);
			}

		#endregion
	}
}