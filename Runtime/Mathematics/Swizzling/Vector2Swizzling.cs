using UnityEngine;

namespace ZkTools.Mathematics.Swizzling
{
	public static class Vector2Swizzling
	{
		#region // ==============================[Methods]============================== //
		
			/// <summary>
			///	Compute the Vector3 as Vector3(I,J,X).
			/// </summary>
			public static Vector3 GetIJX (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,J,Y).
			/// </summary>
			public static Vector3 GetIJY (this Vector2 p_this, float p_i = 0.0f, float p_j = 0.0f)
			{
				return new Vector3(p_i, p_j, p_this.y);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(I,X).
			/// </summary>
			public static Vector2 GetIX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,X,K).
			/// </summary>
			public static Vector3 GetIXK (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,X,X).
			/// </summary>
			public static Vector3 GetIXX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,X,Y).
			/// </summary>
			public static Vector3 GetIXY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.x, p_this.y);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(I,Y).
			/// </summary>
			public static Vector2 GetIY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector2(p_i, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Y,K).
			/// </summary>
			public static Vector3 GetIYK (this Vector2 p_this, float p_i = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Y,X).
			/// </summary>
			public static Vector3 GetIYX (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(I,Y,Y).
			/// </summary>
			public static Vector3 GetIYY (this Vector2 p_this, float p_i = 0.0f)
			{
				return new Vector3(p_i, p_this.y, p_this.y);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(X,J).
			/// </summary>
			public static Vector2 GetXJ (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector2(p_this.x, p_j);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,J,K).
			/// </summary>
			public static Vector3 GetXJK (this Vector2 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,J,K).
			/// </summary>
			public static Vector3 GetXJX (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,J,Y).
			/// </summary>
			public static Vector3 GetXJY (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.x, p_j, p_this.y);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(X,X).
			/// </summary>
			public static Vector2 GetXX (this Vector2 p_this)
			{
				return new Vector2(p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,X,K).
			/// </summary>
			public static Vector3 GetXXK (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.x, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,X,X).
			/// </summary>
			public static Vector3 GetXXX (this Vector2 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,X,Y).
			/// </summary>
			public static Vector3 GetXXY (this Vector2 p_this)
			{
				return new Vector3(p_this.x, p_this.x, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Y,K).
			/// </summary>
			public static Vector3 GetXYK (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.x, p_this.y, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Y,X).
			/// </summary>
			public static Vector3 GetXYX (this Vector2 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(X,Y,Y).
			/// </summary>
			public static Vector3 GetXYY (this Vector2 p_this)
			{
				return new Vector3(p_this.x, p_this.y, p_this.y);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Y,J).
			/// </summary>
			public static Vector2 GetYJ (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector2(p_this.y, p_j);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,J,K).
			/// </summary>
			public static Vector3 GetYJK (this Vector2 p_this, float p_j = 0.0f, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,J,X).
			/// </summary>
			public static Vector3 GetYJX (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,J,Y).
			/// </summary>
			public static Vector3 GetYJY (this Vector2 p_this, float p_j = 0.0f)
			{
				return new Vector3(p_this.y, p_j, p_this.y);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Y,X).
			/// </summary>
			public static Vector2 GetYX (this Vector2 p_this)
			{
				return new Vector2(p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,X,K).
			/// </summary>
			public static Vector3 GetYXK (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.x, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,X,X).
			/// </summary>
			public static Vector3 GetYXX (this Vector2 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,X,Y).
			/// </summary>
			public static Vector3 GetYXY (this Vector2 p_this)
			{
				return new Vector3(p_this.y, p_this.x, p_this.y);
			}

			/// <summary>
			///	Compute the Vector2 as Vector2(Y,Y).
			/// </summary>
			public static Vector2 GetYY (this Vector2 p_this)
			{
				return new Vector2(p_this.y, p_this.y);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Y,K).
			/// </summary>
			public static Vector3 GetYYK (this Vector2 p_this, float p_k = 0.0f)
			{
				return new Vector3(p_this.y, p_this.y, p_k);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Y,X).
			/// </summary>
			public static Vector3 GetYYX (this Vector2 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.x);
			}

			/// <summary>
			///	Compute the Vector3 as Vector3(Y,Y,Y).
			/// </summary>
			public static Vector3 GetYYY (this Vector2 p_this)
			{
				return new Vector3(p_this.y, p_this.y, p_this.y);
			}
			
		#endregion endregion
	}
}