using UnityEngine;

namespace ZkTools.Mathematics
{
	public static class Vector4X
	{
		#region ==============================[Static Methods]==============================

			public static Vector4 Lerp (Vector4 p_a, Vector4 p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			public static Vector4 Lerp (Vector4 p_a, Vector4 p_b, Vector4 p_t)
			{
				return new Vector4(MathF.Lerp(p_a.x, p_b.x, p_t.x), MathF.Lerp(p_a.y, p_b.y, p_t.y), MathF.Lerp(p_a.z, p_b.z, p_t.z), MathF.Lerp(p_a.w, p_b.w, p_t.w));
			}

			public static Vector4 LerpClamped (Vector4 p_a, Vector4 p_b, float p_t)
			{
				return LerpClamped(p_a, p_b, new Vector4(p_t, p_t, p_t, p_t));
			}

			public static Vector4 LerpClamped (Vector4 p_a, Vector4 p_b, Vector4 p_t)
			{
				return new Vector4(MathF.LerpClamped(p_a.x, p_b.x, p_t.x), MathF.LerpClamped(p_a.y, p_b.y, p_t.y), MathF.LerpClamped(p_a.z, p_b.z, p_t.z), MathF.LerpClamped(p_a.w, p_b.w, p_t.w));
			}

		#endregion
	}
}
