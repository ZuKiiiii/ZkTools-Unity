using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Swizzling
{
	public static class Vector4bSwizzling
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKW (this Vector4b p_this, bool p_i = false, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKW (this Vector4b p_this, Vector2b p_ij, bool p_k = false)
			{
				return p_this.GetIJKW(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKW (this Vector4b p_this, bool p_i, Vector2b p_jk)
			{
				return p_this.GetIJKW(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKW (this Vector4b p_this, Vector3b p_ijk)
			{
				return p_this.GetIJKW(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKX (this Vector4b p_this, bool p_i = false, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKX (this Vector4b p_this, Vector2b p_ij, bool p_k = false)
			{
				return p_this.GetIJKX(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKX (this Vector4b p_this, bool p_i, Vector2b p_jk)
			{
				return p_this.GetIJKX(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKX (this Vector4b p_this, Vector3b p_ijk)
			{
				return p_this.GetIJKX(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKY (this Vector4b p_this, bool p_i = false, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKY (this Vector4b p_this, Vector2b p_ij, bool p_k = false)
			{
				return p_this.GetIJKY(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKY (this Vector4b p_this, bool p_i, Vector2b p_jk)
			{
				return p_this.GetIJKY(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKY (this Vector4b p_this, Vector3b p_ijk)
			{
				return p_this.GetIJKY(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKZ (this Vector4b p_this, bool p_i = false, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKZ (this Vector4b p_this, Vector2b p_ij, bool p_k = false)
			{
				return p_this.GetIJKZ(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKZ (this Vector4b p_this, bool p_i, Vector2b p_jk)
			{
				return p_this.GetIJKZ(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJKZ (this Vector4b p_this, Vector3b p_ijk)
			{
				return p_this.GetIJKZ(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIJW (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector3b(p_i, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIJW (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWL (this Vector4b p_this, bool p_i = false, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWL (this Vector4b p_this, Vector2b p_ij, bool p_l = false)
			{
				return p_this.GetIJWL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWL (this Vector4b p_this, bool p_i, Vector2b p_jl)
			{
				return p_this.GetIJWL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWL (this Vector4b p_this, Vector3b p_ijl)
			{
				return p_this.GetIJWL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWW (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWW (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJWW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWX (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWX (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJWX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWY (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWY (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJWY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWZ (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJWZ (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJWZ(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIJX (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector3b(p_i, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIJX (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXL (this Vector4b p_this, bool p_i = false, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXL (this Vector4b p_this, Vector2b p_ij, bool p_l = false)
			{
				return p_this.GetIJXL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXL (this Vector4b p_this, bool p_i, Vector2b p_jl)
			{
				return p_this.GetIJXL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXL (this Vector4b p_this, Vector3b p_ijl)
			{
				return p_this.GetIJXL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXW (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXW (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJXW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXX (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXX (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJXX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXY (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXY (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJXY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXZ (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJXZ (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJXZ(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIJY (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector3b(p_i, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIJY (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYL (this Vector4b p_this, bool p_i = false, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYL (this Vector4b p_this, Vector2b p_ij, bool p_l = false)
			{
				return p_this.GetIJYL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYL (this Vector4b p_this, bool p_i, Vector2b p_jl)
			{
				return p_this.GetIJYL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYL (this Vector4b p_this, Vector3b p_ijl)
			{
				return p_this.GetIJYL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYW (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYW (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJYW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYX (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYX (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJYX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYY (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYY (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJYY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYZ (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJYZ (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJYZ(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIJZ (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector3b(p_i, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIJZ (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJZ(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZL (this Vector4b p_this, bool p_i = false, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZL (this Vector4b p_this, Vector2b p_ij, bool p_l = false)
			{
				return p_this.GetIJZL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZL (this Vector4b p_this, bool p_i, Vector2b p_jl)
			{
				return p_this.GetIJZL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZL (this Vector4b p_this, Vector3b p_ijl)
			{
				return p_this.GetIJZL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZW (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZW (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJZW(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZX (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZX (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJZX(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZY (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZY (this Vector4b p_this, Vector2b p_ij)
			{
				return p_this.GetIJZY(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZZ (this Vector4b p_this, bool p_i = false, bool p_j = false)
			{
				return new Vector4b(p_i, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIJZZ (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIJZZ(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetIW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector2b(p_i, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIWK (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector3b(p_i, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIWK (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIWK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKL (this Vector4b p_this, bool p_i = false, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKL (this Vector4b p_this, Vector2b p_ik, bool p_l = false)
			{
				return p_this.GetIWKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKL (this Vector4b p_this, bool p_i, Vector2b p_kl)
			{
				return p_this.GetIWKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKL (this Vector4b p_this, Vector3b p_ikl)
			{
				return p_this.GetIWKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKW (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKW (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIWKW(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKX (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKX (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIWKX(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKY (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKY (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIWKY(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKZ (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWKZ (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIWKZ(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIWW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWWL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWWL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIWWL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWWW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWWX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWWY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWWZ (this Vector4b p_this,bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIWX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWXL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWXL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIWXL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWXW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWXX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWXY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWXZ (this Vector4b p_this,bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIWY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWYL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWYL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIWYL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWYW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWYX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWYY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWYZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIWZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWZL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWZL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIWZL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWZW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWZX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWZY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIWZZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetIX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector2b(p_i, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIXK (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector3b(p_i, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIXK (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIXK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKL (this Vector4b p_this, bool p_i = false, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKL (this Vector4b p_this, Vector2b p_ik, bool p_l = false)
			{
				return p_this.GetIXKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKL (this Vector4b p_this, bool p_i, Vector2b p_kl)
			{
				return p_this.GetIXKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKL (this Vector4b p_this, Vector3b p_ikl)
			{
				return p_this.GetIXKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKW (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKW (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIXKW(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKX (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKX (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIXKX(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKY (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKY (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIXKY(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKZ (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXKZ (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIXKZ(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIXW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXWL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXWL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIXWL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXWW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXWX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXWY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXWZ (this Vector4b p_this,bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIXX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXXL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXXL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIXXL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXXW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXXX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXXY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXXZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIXY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXYL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXYL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIXYL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXYW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXYX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXYY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXYZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIXZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXZL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXZL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIXZL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXZW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXZX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXZY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIXZZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetIY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector2b(p_i, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIYW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYWL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYWL (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIYWL(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYWW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYWX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYWY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYWZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIYK (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector3b(p_i, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIYK (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIYK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKL (this Vector4b p_this, bool p_i = false, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKL (this Vector4b p_this, Vector2b p_ik, bool p_l = false)
			{
				return p_this.GetIYKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKL (this Vector4b p_this, bool p_i, Vector2b p_kl)
			{
				return p_this.GetIYKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKL (this Vector4b p_this, Vector3b p_ikl)
			{
				return p_this.GetIYKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKW (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKW (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIYKW(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKX (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKX (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIYKX(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKY (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKY (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIYKY(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKZ (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYKZ (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIYKZ(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIYX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYXL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYXL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIYXL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYXW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYXX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYXY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYXZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIYY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYYL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYYL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIYYL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYYW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYYX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYYY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYYZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIYZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYZL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYZL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIYZL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYZW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYZX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYZY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIYZZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetIZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector2b(p_i, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIZW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZWL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZWL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIZWL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZWW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZWX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZWY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZWZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIZK (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector3b(p_i, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIZK (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIZK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKL (this Vector4b p_this, bool p_i = false, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKL (this Vector4b p_this, Vector2b p_ik, bool p_l = false)
			{
				return p_this.GetIZKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKL (this Vector4b p_this, bool p_i, Vector2b p_kl)
			{
				return p_this.GetIZKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKL (this Vector4b p_this, Vector3b p_ikl)
			{
				return p_this.GetIZKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKW (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKW (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIZKW(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKX (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKX (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIZKX(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKY (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKY (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIZKY(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKZ (this Vector4b p_this, bool p_i = false, bool p_k = false)
			{
				return new Vector4b(p_i, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZKZ (this Vector4b p_this, Vector2b p_ik)
			{
				return p_this.GetIZKZ(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIZX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZXL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZXL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIZXL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZXW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZXX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZXY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZXZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIZY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZYL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZYL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIZYL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZYW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZYX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZYY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZYZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetIZZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector3b(p_i, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZZL (this Vector4b p_this, bool p_i = false, bool p_l = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZZL (this Vector4b p_this, Vector2b p_il)
			{
				return p_this.GetIZZL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZZW (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZZX (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZZY (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetIZZZ (this Vector4b p_this, bool p_i = false)
			{
				return new Vector4b(p_i, p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJKW (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJKW (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetWJKW(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJKX (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJKX (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetWJKX(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJKY (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJKY (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetWJKY(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJKZ (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJKZ (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetWJKZ(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWJW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.w, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJWL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJWL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetWJWL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJWW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJWX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJWY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJWZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWJX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.w, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJXL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJXL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetWJXL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJXW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJXX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJXY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJXZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWJY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.w, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJYL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJYL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetWJYL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJYW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJYX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJYY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJYZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWJZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.w, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJZL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJZL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetWJZL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJZW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJZX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJZY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWJZZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.w, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetWW (this Vector4b p_this)
			{
				return new Vector2b(p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWWK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.w, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetWWKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWWW (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWWX (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWWY (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWWZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWWZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetWX (this Vector4b p_this)
			{
				return new Vector2b(p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWXK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.w, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetWXKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWXW (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWXX (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWXY (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWXZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWXZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetWY (this Vector4b p_this)
			{
				return new Vector2b(p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWYW (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWYK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.w, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetWYKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWYX (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWYY (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWYZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWYZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetWZ (this Vector4b p_this)
			{
				return new Vector2b(p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWZW (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWZK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.w, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetWZKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWZX (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWZY (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetWZZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetWZZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.w, p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJKW (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJKW (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetXJKW(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJKX (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJKX (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetXJKX(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJKY (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJKY (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetXJKY(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJKZ (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJKZ (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetXJKZ(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXJW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.x, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJWL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJWL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetXJWL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJWW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJWX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJWY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJWZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXJX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.x, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJXL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJXL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetXJXL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJXW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJXX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJXY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJXZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXJY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.x, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJYL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJYL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetXJYL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJYW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJYX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJYY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJYZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXJZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.x, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJZL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJZL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetXJZL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJZW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJZX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJZY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXJZZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.x, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetXW (this Vector4b p_this)
			{
				return new Vector2b(p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXWK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.x, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetXWKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXWW (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXWX (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXWY (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXWZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXWZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetXX (this Vector4b p_this)
			{
				return new Vector2b(p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXXK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.x, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetXXKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXXW (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXXX (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXXY (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXXZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXXZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetXY (this Vector4b p_this)
			{
				return new Vector2b(p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXYW (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXYK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.x, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetXYKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXYX (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXYY (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXYZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXYZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetXZ (this Vector4b p_this)
			{
				return new Vector2b(p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXZW (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXZK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.x, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetXZKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXZX (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXZY (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetXZZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetXZZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.x, p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJKW (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJKW (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetYJKW(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJKX (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJKX (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetYJKX(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJKY (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJKY (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetYJKY(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJKZ (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJKZ (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetYJKZ(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYJW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.y, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJWL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJWL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetYJWL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJWW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJWX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJWY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJWZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYJX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.y, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJXL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJXL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetYJXL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJXW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJXX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJXY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJXZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYJY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.y, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJYL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJYL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetYJYL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJYW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJYX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJYY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJYZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYJZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.y, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJZL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJZL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetYJZL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJZW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJZX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJZY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYJZZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.y, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetYW (this Vector4b p_this)
			{
				return new Vector2b(p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYWK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.y, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetYWKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYWW (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYWX (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYWY (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYWZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYWZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetYX (this Vector4b p_this)
			{
				return new Vector2b(p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYXK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.y, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetYXKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYXW (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYXX (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYXY (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYXZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYXZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetYY (this Vector4b p_this)
			{
				return new Vector2b(p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYYW (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYYK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.y, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetYYKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYYX (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYYY (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYYZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYYZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetYZ (this Vector4b p_this)
			{
				return new Vector2b(p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYZW (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYZK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.y, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetYZKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYZX (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYZY (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetYZZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetYZZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.y, p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJKW (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_j, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJKW (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetZJKW(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJKX (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_j, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJKX (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetZJKX(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJKY (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_j, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJKY (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetZJKY(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJKZ (this Vector4b p_this, bool p_j = false, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_j, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJKZ (this Vector4b p_this, Vector2b p_jk)
			{
				return p_this.GetZJKZ(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZJW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.z, p_j, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJWL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJWL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetZJWL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJWW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJWX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJWY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJWZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZJX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.z, p_j, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJXL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJXL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetZJXL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJXW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJXX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJXY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJXZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZJY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.z, p_j, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJYL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJYL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetZJYL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJYW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJYX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJYY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJYZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZJZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector3b(p_this.z, p_j, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJZL (this Vector4b p_this, bool p_j = false, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJZL (this Vector4b p_this, Vector2b p_jl)
			{
				return p_this.GetZJZL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJZW (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJZX (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJZY (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZJZZ (this Vector4b p_this, bool p_j = false)
			{
				return new Vector4b(p_this.z, p_j, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetZW (this Vector4b p_this)
			{
				return new Vector2b(p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZWW (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZWK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.z, p_this.w, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetZWKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZWX (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZWY (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZWZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZWZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.w, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetZX (this Vector4b p_this)
			{
				return new Vector2b(p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZXK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.z, p_this.x, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetZXKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZXW (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZXX (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZXY (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZXZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZXZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.x, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetZY (this Vector4b p_this)
			{
				return new Vector2b(p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZYW (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZYK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.z, p_this.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetZYKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZYX (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZYY (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZYZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZYZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.y, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2b GetZZ (this Vector4b p_this)
			{
				return new Vector2b(p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZZW (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZWL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.w, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZWW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.w, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZWX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.w, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZWY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.w, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZWZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.w, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZZK (this Vector4b p_this, bool p_k = false)
			{
				return new Vector3b(p_this.z, p_this.z, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZKL (this Vector4b p_this, bool p_k = false, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZKL (this Vector4b p_this, Vector2b p_kl)
			{
				return p_this.GetZZKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZKW (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_k, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZKX (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_k, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZKY (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_k, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZKZ (this Vector4b p_this, bool p_k = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_k, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZZX (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZXL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.x, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZXW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.x, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZXX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.x, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZXY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.x, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZXZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.x, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZZY (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZYL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZYW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.y, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZYX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.y, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZYY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.y, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZYZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.y, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3b GetZZZ (this Vector4b p_this)
			{
				return new Vector3b(p_this.z, p_this.z, p_this.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZZL (this Vector4b p_this, bool p_l = false)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.z, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZZW (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.z, p_this.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZZX (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.z, p_this.x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZZY (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.z, p_this.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b GetZZZZ (this Vector4b p_this)
			{
				return new Vector4b(p_this.z, p_this.z, p_this.z, p_this.z);
			}

		#endregion
	}
}