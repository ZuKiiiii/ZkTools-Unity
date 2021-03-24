using UnityEngine;

namespace ZkTools.Mathematics.Swizzling
{
	public static class Vector3Swizzling
	{
		#region // ==============================[Methods]============================== //

			/// <summary>
			///	Compute the Vector3 as Vector3(I,J,X).
			/// </summary>
			public static Vector3 GetIJX (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,J,Y).
			/// </summary>
			public static Vector3 GetIJY (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.y);
			}
			
			/// <summary>
			///	Compute the Vector3 as Vector3(I,J,Z).
			/// </summary>
			public static Vector3 GetIJZ (this Vector3 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(I,Z).
			/// </summary>
			public static Vector2 GetIX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,X,K).
			/// </summary>
			public static Vector3 GetIXK (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,X,X).
			/// </summary>
			public static Vector3 GetIXX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,X,Y).
			/// </summary>
			public static Vector3 GetIXY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,X,Z).
			/// </summary>
			public static Vector3 GetIXZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.z);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,X,Y).
			/// </summary>
			public static Vector2 GetIY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Y,K).
			/// </summary>
			public static Vector3 GetIYK (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Y,X).
			/// </summary>
			public static Vector3 GetIYX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Y,Y).
			/// </summary>
			public static Vector3 GetIYY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Y,X).
			/// </summary>
			public static Vector3 GetIYZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.z);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Z,K).
			/// </summary>
			public static Vector3 GetIZK (this Vector3 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Z,X).
			/// </summary>
			public static Vector3 GetIZX (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Z,Y).
			/// </summary>
			public static Vector3 GetIZY (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Z,Z).
			/// </summary>
			public static Vector3 GetIZZ (this Vector3 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.z, p_this.z);
			}
			
			/// <summary>
			///	Compute the Vector2 as Vector2(X,J).
			/// </summary>
			public static Vector2 GetXJ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector2(p_this.x, p_j);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,J,K).
			/// </summary>
			public static Vector3 GetXJK (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,J,X).
			/// </summary>
			public static Vector3 GetXJX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,J,Y).
			/// </summary>
			public static Vector3 GetXJY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,J,Z).
			/// </summary>
			public static Vector3 GetXJZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(X,X).
			/// </summary>
			public static Vector2 GetXX (this Vector3 p_this)
			{
				return new Vector2(p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,X,K).
			/// </summary>
			public static Vector3 GetXXK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,X,X).
			/// </summary>
			public static Vector3 GetXXX (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,X,Y).
			/// </summary>
			public static Vector3 GetXXY (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,X,Z).
			/// </summary>
			public static Vector3 GetXXZ (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(X,Y).
			/// </summary>
			public static Vector2 GetXY (this Vector3 p_this)
			{
				return new Vector2(p_this.x, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Y,K).
			/// </summary>
			public static Vector3 GetXYK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Y,X).
			/// </summary>
			public static Vector3 GetXYX (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Y,Y).
			/// </summary>
			public static Vector3 GetXYY (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Z,K).
			/// </summary>
			public static Vector3 GetXZK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.z, p_k);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(X,Z).
			/// </summary>
			public static Vector2 GetXZ (this Vector3 p_this)
			{
				return new Vector2(p_this.x, p_this.z);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Z,X).
			/// </summary>
			public static Vector3 GetXZX (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Z,Y).
			/// </summary>
			public static Vector3 GetXZY (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Z,Z).
			/// </summary>
			public static Vector3 GetXZZ (this Vector3 p_this)
			{
				return new Vector3(p_this.x, p_this.z, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Y,J).
			/// </summary>
			public static Vector2 GetYJ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector2(p_this.y, p_j);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,J,K).
			/// </summary>
			public static Vector3 GetYJK (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,J,X).
			/// </summary>
			public static Vector3 GetYJX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,J,Y).
			/// </summary>
			public static Vector3 GetYJY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,J,Z).
			/// </summary>
			public static Vector3 GetYJZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Y,X).
			/// </summary>
			public static Vector2 GetYX (this Vector3 p_this)
			{
				return new Vector2(p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,X,K).
			/// </summary>
			public static Vector3 GetYXK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,X,X).
			/// </summary>
			public static Vector3 GetYXX (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,X,Y).
			/// </summary>
			public static Vector3 GetYXY (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,X,Z).
			/// </summary>
			public static Vector3 GetYXZ (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Y,Y).
			/// </summary>
			public static Vector2 GetYY (this Vector3 p_this)
			{
				return new Vector2(p_this.y, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Y,K).
			/// </summary>
			public static Vector3 GetYYK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Y,Y).
			/// </summary>
			public static Vector3 GetYYY (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Y,Z).
			/// </summary>
			public static Vector3 GetYYZ (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Y,Z).
			/// </summary>
			public static Vector2 GetYZ (this Vector3 p_this)
			{
				return new Vector2(p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Z,K).
			/// </summary>
			public static Vector3 GetYZK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.z, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Z,X).
			/// </summary>
			public static Vector3 GetYZX (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Z,Y).
			/// </summary>
			public static Vector3 GetYZY (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Z,Z).
			/// </summary>
			public static Vector3 GetYZZ (this Vector3 p_this)
			{
				return new Vector3(p_this.y, p_this.z, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Z,J).
			/// </summary>
			public static Vector2 GetZJ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector2(p_this.z, p_j);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,J,K).
			/// </summary>
			public static Vector3 GetZJK (this Vector3 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,J,X).
			/// </summary>
			public static Vector3 GetZJX (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,J,Y).
			/// </summary>
			public static Vector3 GetZJY (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,J,Z).
			/// </summary>
			public static Vector3 GetZJZ (this Vector3 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.z, p_j, p_this.z);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Z,X).
			/// </summary>
			public static Vector2 GetZX (this Vector3 p_this)
			{
				return new Vector2(p_this.z, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,X,K).
			/// </summary>
			public static Vector3 GetZXK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.x, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,X,X).
			/// </summary>
			public static Vector3 GetZXX (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,X,Y).
			/// </summary>
			public static Vector3 GetZXY (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,X,Z).
			/// </summary>
			public static Vector3 GetZXZ (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.x, p_this.z);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,Y,K).
			/// </summary>
			public static Vector3 GetZYK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.y, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,Y,X).
			/// </summary>
			public static Vector3 GetZYX (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,Y,Y).
			/// </summary>
			public static Vector3 GetZYY (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,Y,Z).
			/// </summary>
			public static Vector3 GetZYZ (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.y, p_this.z);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,Z,K).
			/// </summary>
			public static Vector3 GetZZK (this Vector3 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.z, p_this.z, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,Z,X).
			/// </summary>
			public static Vector3 GetZZX (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,Z,Y).
			/// </summary>
			public static Vector3 GetZZY (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Z,Z,Z).
			/// </summary>
			public static Vector3 GetZZZ (this Vector3 p_this)
			{
				return new Vector3(p_this.z, p_this.z, p_this.z);
			}
			
		#endregion
	}
}