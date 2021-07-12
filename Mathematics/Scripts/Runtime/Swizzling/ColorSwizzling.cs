using System.Runtime.CompilerServices;
using UnityEngine;

namespace BkTools.Mathematics.Swizzling
{
	public static class Vector4Swizzling
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKA (this Color p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKA (this Color p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKA(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKA (this Color p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKA(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKA (this Color p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKA(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKR (this Color p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKR (this Color p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKR(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKR (this Color p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKR(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKR (this Color p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKR(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKG (this Color p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKG (this Color p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKG(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKG (this Color p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKG(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKG (this Color p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKG(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKB (this Color p_this, float p_i = 0.0f, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_j, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKB (this Color p_this, Vector2 p_ij, float p_k = 0.0f)
			{
				return p_this.GetIJKB(p_ij.x, p_ij.y, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKB (this Color p_this, float p_i, Vector2 p_jk)
			{
				return p_this.GetIJKB(p_i, p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJKB (this Color p_this, Vector3 p_ijk)
			{
				return p_this.GetIJKB(p_ijk.x, p_ijk.y, p_ijk.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJA (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJA (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJA(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAL (this Color p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAL (this Color p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJAL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAL (this Color p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJAL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAL (this Color p_this, Vector3 p_ijl)
			{
				return p_this.GetIJAL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAA (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAA (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJAA(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAR (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAR (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJAR(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAG (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAG (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJAG(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAB (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJAB (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJAB(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJR (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJR (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJR(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRL (this Color p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRL (this Color p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJRL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRL (this Color p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJRL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRL (this Color p_this, Vector3 p_ijl)
			{
				return p_this.GetIJRL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRA (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRA (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJRA(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRR (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRR (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJRR(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRG (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRG (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJRG(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRB (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJRB (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJRB(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJG (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJG (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJG(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGL (this Color p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGL (this Color p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJGL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGL (this Color p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJGL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGL (this Color p_this, Vector3 p_ijl)
			{
				return p_this.GetIJGL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGA (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGA (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJGA(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGR (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGR (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJGR(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGG (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGG (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJGG(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGB (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJGB (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJGB(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJB (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIJB (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJB(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBL (this Color p_this, float p_i = 0.0f, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBL (this Color p_this, Vector2 p_ij, float p_l = 0.0f)
			{
				return p_this.GetIJBL(p_ij.x, p_ij.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBL (this Color p_this, float p_i, Vector2 p_jl)
			{
				return p_this.GetIJBL(p_i, p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBL (this Color p_this, Vector3 p_ijl)
			{
				return p_this.GetIJBL(p_ijl.x, p_ijl.y, p_ijl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBA (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBA (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJBA(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBR (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBR (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJBR(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBG (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBG (this Color p_this, Vector2 p_ij)
			{
				return p_this.GetIJBG(p_ij.x, p_ij.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBB (this Color p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector4(p_i, p_j, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIJBB (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIJBB(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetIA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIAK (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.a, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIAK (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIAK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKL (this Color p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKL (this Color p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIAKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKL (this Color p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIAKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKL (this Color p_this, Vector3 p_ikl)
			{
				return p_this.GetIAKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKA (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKA (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIAKA(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKR (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKR (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIAKR(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKG (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKG (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIAKG(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKB (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAKB (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIAKB(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIAA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAAL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAAL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIAAL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAAA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAAR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAAG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAAB (this Color p_this,float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIAR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIARL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIARL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIARL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIARA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIARR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIARG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIARB (this Color p_this,float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIAG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAGL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAGL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIAGL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAGA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAGR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAGG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIAGB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIAB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIABL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIABL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIABL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIABA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIABR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIABG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIABB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.a, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetIR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIRK (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.r, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIRK (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIRK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKL (this Color p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKL (this Color p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIRKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKL (this Color p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIRKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKL (this Color p_this, Vector3 p_ikl)
			{
				return p_this.GetIRKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKA (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKA (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIRKA(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKR (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKR (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIRKR(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKG (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKG (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIRKG(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKB (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRKB (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIRKB(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIRA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRAL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRAL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIRAL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRAA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRAR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRAG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRAB (this Color p_this,float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIRR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRRL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRRL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIRRL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRRA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRRR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRRG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRRB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIRG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRGL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRGL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIRGL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRGA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRGR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRGG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRGB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIRB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRBL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRBL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIRBL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRBA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRBR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRBG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIRBB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.r, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetIG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIGA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGAL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGAL (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIGAL(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGAA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGAR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGAG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGAB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIGK (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.g, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIGK (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIGK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKL (this Color p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKL (this Color p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIGKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKL (this Color p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIGKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKL (this Color p_this, Vector3 p_ikl)
			{
				return p_this.GetIGKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKA (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKA (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIGKA(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKR (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKR (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIGKR(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKG (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKG (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIGKG(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKB (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGKB (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIGKB(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIGR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGRL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGRL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIGRL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGRA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGRR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGRG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGRB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIGG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGGL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGGL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIGGL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGGA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGGR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGGG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGGB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIGB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGBL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGBL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIGBL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGBA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGBR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGBG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIGBB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.g, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetIB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIBA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBAL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBAL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIBAL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBAA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBAR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBAG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBAB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIBK (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.b, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIBK (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIBK(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKL (this Color p_this, float p_i = 0.0f, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKL (this Color p_this, Vector2 p_ik, float p_l = 0.0f)
			{
				return p_this.GetIBKL(p_ik.x, p_ik.y, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKL (this Color p_this, float p_i, Vector2 p_kl)
			{
				return p_this.GetIBKL(p_i, p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKL (this Color p_this, Vector3 p_ikl)
			{
				return p_this.GetIBKL(p_ikl.x, p_ikl.y, p_ikl.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKA (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKA (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIBKA(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKR (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKR (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIBKR(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKG (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKG (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIBKG(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKB (this Color p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBKB (this Color p_this, Vector2 p_ik)
			{
				return p_this.GetIBKB(p_ik.x, p_ik.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIBR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBRL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBRL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIBRL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBRA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBRR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBRG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBRB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIBG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBGL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBGL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIBGL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBGA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBGR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBGG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBGB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetIBB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBBL (this Color p_this, float p_i = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBBL (this Color p_this, Vector2 p_il)
			{
				return p_this.GetIBBL(p_il.x, p_il.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBBA (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBBR (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBBG (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetIBBB (this Color p_this, float p_i = 0.0f)
			{
				return new Vector4(p_i, p_this.b, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJKA (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJKA (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetAJKA(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJKR (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJKR (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetAJKR(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJKG (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJKG (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetAJKG(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJKB (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJKB (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetAJKB(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAJA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.a, p_j, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJAL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJAL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetAJAL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJAA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJAR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJAG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJAB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAJR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.a, p_j, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJRL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJRL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetAJRL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJRA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJRR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJRG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJRB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAJG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.a, p_j, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJGL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJGL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetAJGL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJGA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJGR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJGG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJGB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAJB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.a, p_j, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJBL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJBL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetAJBL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJBA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJBR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJBG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAJBB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.a, p_j, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetAA (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAAK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.a, p_this.a, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetAAKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAAA (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAAA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAAR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAAG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAAB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAAR (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAARL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAARA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAARR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAARG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAARB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAAG (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAGA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAGR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAGG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAAGB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAAB (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAABL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.a, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAABA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAABR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAABG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAABB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.a, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetAR (this Color p_this)
			{
				return new Vector2(p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetARK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.a, p_this.r, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetARKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetARA (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARAA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARAR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARAG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARAB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetARR (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARRA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARRR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARRG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARRB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetARG (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARGA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARGR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARGG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARGB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetARB (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.r, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARBA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARBR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARBG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetARBB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.r, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetAG (this Color p_this)
			{
				return new Vector2(p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAGA (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGAA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGAR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGAG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGAB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAGK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.a, p_this.g, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetAGKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAGR (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGRA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGRR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGRG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGRB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAGG (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGGA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGGR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGGG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGGB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetAGB (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.g, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGBA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGBR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGBG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetAGBB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.g, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetAB (this Color p_this)
			{
				return new Vector2(p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetABA (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABAA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABAR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABAG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABAB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetABK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.a, p_this.b, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetABKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetABR (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABRA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABRR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABRG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABRB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetABG (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABGA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABGR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABGG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABGB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetABB (this Color p_this)
			{
				return new Vector3(p_this.a, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.a, p_this.b, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABBA (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABBR (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABBG (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetABBB (this Color p_this)
			{
				return new Vector4(p_this.a, p_this.b, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJKA (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJKA (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetRJKA(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJKR (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJKR (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetRJKR(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJKG (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJKG (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetRJKG(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJKB (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJKB (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetRJKB(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRJA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.r, p_j, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJAL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJAL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetRJAL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJAA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJAR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJAG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJAB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRJR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.r, p_j, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJRL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJRL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetRJRL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJRA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJRR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJRG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJRB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRJG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.r, p_j, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJGL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJGL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetRJGL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJGA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJGR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJGG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJGB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRJB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.r, p_j, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJBL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJBL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetRJBL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJBA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJBR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJBG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRJBB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.r, p_j, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetRA (this Color p_this)
			{
				return new Vector2(p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRAK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.r, p_this.a, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetRAKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRAA (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAAA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAAR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAAG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAAB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRAR (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRARL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRARA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRARR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRARG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRARB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRAG (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAGA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAGR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAGG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRAGB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRAB (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRABL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.a, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRABA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRABR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRABG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRABB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.a, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetRR (this Color p_this)
			{
				return new Vector2(p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRRK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.r, p_this.r, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetRRKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRRA (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRAA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRAR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRAG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRAB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRRR (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRRA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRRR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRRG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRRB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRRG (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRGA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRGR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRGG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRGB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRRB (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.r, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRBA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRBR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRBG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRRBB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.r, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetRG (this Color p_this)
			{
				return new Vector2(p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRGA (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGAA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGAR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGAG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGAB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRGK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.r, p_this.g, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetRGKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRGR (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGRA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGRR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGRG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGRB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRGG (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGGA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGGR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGGG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGGB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRGB (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.g, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGBA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGBR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGBG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRGBB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.g, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetRB (this Color p_this)
			{
				return new Vector2(p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRBA (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBAA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBAR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBAG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBAB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRBK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.r, p_this.b, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetRBKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRBR (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBRA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBRR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBRG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBRB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRBG (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBGA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBGR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBGG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBGB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetRBB (this Color p_this)
			{
				return new Vector3(p_this.r, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.r, p_this.b, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBBA (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBBR (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBBG (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetRBBB (this Color p_this)
			{
				return new Vector4(p_this.r, p_this.b, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJKA (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJKA (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetGJKA(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJKR (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJKR (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetGJKR(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJKG (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJKG (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetGJKG(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJKB (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJKB (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetGJKB(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGJA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.g, p_j, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJAL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJAL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetGJAL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJAA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJAR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJAG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJAB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGJR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.g, p_j, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJRL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJRL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetGJRL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJRA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJRR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJRG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJRB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGJG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.g, p_j, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJGL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJGL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetGJGL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJGA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJGR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJGG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJGB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGJB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.g, p_j, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJBL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJBL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetGJBL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJBA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJBR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJBG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGJBB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.g, p_j, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetGA (this Color p_this)
			{
				return new Vector2(p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGAK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.g, p_this.a, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetGAKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGAA (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAAA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAAR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAAG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAAB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGAR (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGARL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGARA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGARR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGARG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGARB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGAG (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAGA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAGR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAGG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGAGB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGAB (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGABL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.a, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGABA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGABR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGABG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGABB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.a, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetGR (this Color p_this)
			{
				return new Vector2(p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGRK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.g, p_this.r, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetGRKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGRA (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRAA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRAR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRAG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRAB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGRR (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRRA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRRR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRRG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRRB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGRG (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRGA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRGR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRGG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRGB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGRB (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.r, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRBA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRBR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRBG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGRBB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.r, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetGG (this Color p_this)
			{
				return new Vector2(p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGGA (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGAA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGAR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGAG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGAB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGGK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.g, p_this.g, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetGGKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGGR (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGRA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGRR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGRG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGRB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGGG (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGGA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGGR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGGG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGGB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGGB (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.g, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGBA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGBR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGBG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGGBB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.g, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetGB (this Color p_this)
			{
				return new Vector2(p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGBA (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBAA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBAR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBAG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBAB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGBK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.g, p_this.b, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetGBKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGBR (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBRA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBRR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBRG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBRB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGBG (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBGA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBGR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBGG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBGB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetGBB (this Color p_this)
			{
				return new Vector3(p_this.g, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.g, p_this.b, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBBA (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBBR (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBBG (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetGBBB (this Color p_this)
			{
				return new Vector4(p_this.g, p_this.b, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJKA (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJKA (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetBJKA(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJKR (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJKR (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetBJKR(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJKG (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJKG (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetBJKG(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJKB (this Color p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJKB (this Color p_this, Vector2 p_jk)
			{
				return p_this.GetBJKB(p_jk.x, p_jk.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBJA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.b, p_j, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJAL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJAL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetBJAL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJAA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJAR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJAG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJAB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBJR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.b, p_j, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJRL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJRL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetBJRL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJRA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJRR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJRG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJRB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBJG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.b, p_j, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJGL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJGL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetBJGL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJGA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJGR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJGG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJGB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBJB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.b, p_j, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJBL (this Color p_this, float p_j = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJBL (this Color p_this, Vector2 p_jl)
			{
				return p_this.GetBJBL(p_jl.x, p_jl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJBA (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJBR (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJBG (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBJBB (this Color p_this, float p_j = 0.0f)
			{
				return new Vector4(p_this.b, p_j, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetBA (this Color p_this)
			{
				return new Vector2(p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBAA (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAAA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAAR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAAG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAAB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBAK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.b, p_this.a, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetBAKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBAR (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBARL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBARA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBARR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBARG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBARB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBAG (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAGA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAGR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAGG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBAGB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBAB (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBABL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.a, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBABA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBABR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBABG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBABB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.a, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetBR (this Color p_this)
			{
				return new Vector2(p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBRK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.b, p_this.r, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetBRKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBRA (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRAA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRAR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRAG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRAB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBRR (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRRA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRRR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRRG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRRB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBRG (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRGA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRGR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRGG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRGB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBRB (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.r, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRBA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRBR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRBG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBRBB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.r, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetBG (this Color p_this)
			{
				return new Vector2(p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBGA (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGAA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGAR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGAG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGAB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBGK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.b, p_this.g, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetBGKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBGR (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGRA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGRR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGRG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGRB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBGG (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGGA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGGR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGGG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGGB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBGB (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.g, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGBA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGBR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGBG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBGBB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.g, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetBB (this Color p_this)
			{
				return new Vector2(p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBBA (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBAL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_this.a, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBAA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.a, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBAR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.a, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBAG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.a, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBAB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.a, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBBK (this Color p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.b, p_this.b, p_k);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBKL (this Color p_this, float p_k = 0.0f, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_k, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBKL (this Color p_this, Vector2 p_kl)
			{
				return p_this.GetBBKL(p_kl.x, p_kl.y);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBKA (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_k, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBKR (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_k, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBKG (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_k, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBKB (this Color p_this, float p_k = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_k, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBBR (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBRL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_this.r, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBRA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.r, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBRR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.r, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBRG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.r, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBRB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.r, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBBG (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBGL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_this.g, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBGA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.g, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBGR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.g, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBGG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.g, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBGB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.g, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetBBB (this Color p_this)
			{
				return new Vector3(p_this.b, p_this.b, p_this.b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBBL (this Color p_this, float p_l = 0.0f)
			{
				return new Vector4(p_this.b, p_this.b, p_this.b, p_l);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBBA (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.b, p_this.a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBBR (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.b, p_this.r);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBBG (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.b, p_this.g);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color GetBBBB (this Color p_this)
			{
				return new Vector4(p_this.b, p_this.b, p_this.b, p_this.b);
			}

		#endregion
	}
}