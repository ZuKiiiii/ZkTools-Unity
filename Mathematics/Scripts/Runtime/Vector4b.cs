using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	[Serializable]
	public struct Vector4b : IVectorb<Vector4b>
	{
		#region ==============================[Static Variables]==============================

			public static readonly Vector4b False = Replicate(false);

			public static readonly Vector4b True = Replicate(true);

		#endregion

		#region ==============================[Editable Variables]==============================

			public bool x;

			public bool y;

			public bool z;

			public bool w;

		#endregion

		#region ==============================[Properties]==============================

			public bool this [int p_index]
			{
				get
				{
					switch (p_index)
					{
						case 0 : return x;
						case 1 : return y;
						case 2 : return z;
						case 3 : return w;
						default : throw new ArgumentOutOfRangeException(nameof(p_index), $"Index has to be in the range [0,3] ! {p_index} is outside that range");
					}
				}

				set
				{
					switch (p_index)
					{
						case 0 : x = value; break;
						case 1 : y = value; break;
						case 2 : z = value; break;
						case 3 : w = value; break;
						default : throw new ArgumentOutOfRangeException(nameof(p_index), $"Index has to be in the range [0,3] ! {p_index} is outside that range");
					}
				}
			}

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public Vector4b (bool p_x = false, bool p_y = false, bool p_z = false, bool p_w = false)
			{
				x = p_x;
				y = p_y;
				z = p_z;
				w = p_w;
			}

			public Vector4b (bool p_x, bool p_y, Vector2b p_zw)
			{
				x = p_x;
				y = p_y;
				z = p_zw.x;
				w = p_zw.y;
			}

			public Vector4b (bool p_x, Vector3b p_yzw)
			{
				x = p_x;
				y = p_yzw.x;
				z = p_yzw.y;
				w = p_yzw.z;
			}

			public Vector4b (Vector2b p_xy, Vector2b p_zw)
			{
				x = p_xy.x;
				y = p_xy.y;
				z = p_zw.x;
				w = p_zw.y;
			}

			public Vector4b (Vector2b p_xy, bool p_z = false, bool p_w = false)
			{
				x = p_xy.x;
				y = p_xy.y;
				z = p_z;
				w = p_w;
			}

			public Vector4b (Vector3b p_xyz, bool p_w = false)
			{
				x = p_xyz.x;
				y = p_xyz.y;
				z = p_xyz.z;
				w = p_w;
			}

			public Vector4b (Vector4b p_vector4)
			{
				x = p_vector4.x;
				y = p_vector4.y;
				z = p_vector4.z;
				w = p_vector4.w;
			}

		#endregion

		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b And (Vector4b p_lhs, Vector4b p_rhs)
			{
				return new Vector4b
				(
					p_lhs.x & p_rhs.x,
					p_lhs.y & p_rhs.y,
					p_lhs.z & p_rhs.z,
					p_lhs.w & p_rhs.w
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b And (ref Vector4b p_lhs, Vector4b p_rhs)
			{
				p_lhs.x &= p_rhs.x;
				p_lhs.y &= p_rhs.y;
				p_lhs.z &= p_rhs.z;
				p_lhs.w &= p_rhs.w;

				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsDifferent (Vector4b p_lhs, Vector4b p_rhs)
			{
				return !IsEqual(p_lhs, p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsDifferent4D (Vector4b p_lhs, Vector4b p_rhs)
			{
				return !IsEqual4D(p_lhs, p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsEqual (Vector4b p_lhs, Vector4b p_rhs)
			{
				return p_lhs.x == p_rhs.x && p_lhs.y == p_rhs.y && p_lhs.z == p_rhs.z && p_lhs.w == p_rhs.w;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b IsEqual4D (Vector4b p_lhs, Vector4b p_rhs)
			{
				return new Vector4b(p_lhs.x == p_rhs.x, p_lhs.y == p_rhs.y, p_lhs.z == p_rhs.z, p_lhs.w == p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool LogicAnd (Vector4b p_lhs, Vector4b p_rhs)
			{
				return p_lhs.x && p_rhs.x && p_lhs.y && p_rhs.y && p_lhs.z && p_rhs.z && p_lhs.w && p_rhs.w;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b LogicAnd4D (Vector4b p_lhs, Vector4b p_rhs)
			{
				return new Vector4b(p_lhs.x && p_rhs.x, p_lhs.y && p_rhs.y, p_lhs.z && p_rhs.z, p_lhs.w && p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool LogicOr (Vector4b p_lhs, Vector4b p_rhs)
			{
				return (p_lhs.x || p_rhs.x) && (p_lhs.y || p_rhs.y) && (p_lhs.z || p_rhs.z) && (p_lhs.w || p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b LogicOr4D (Vector4b p_lhs, Vector4b p_rhs)
			{
				return new Vector4b(p_lhs.x || p_rhs.x, p_lhs.y || p_rhs.y, p_lhs.z || p_rhs.z, p_lhs.w || p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b Not (Vector4b p_vector)
			{
				return new Vector4b(!p_vector.x, !p_vector.y, !p_vector.z, !p_vector.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b Not (ref Vector4b p_vector)
			{
				p_vector.x = !p_vector.x;
				p_vector.y = !p_vector.y;
				p_vector.z = !p_vector.z;
				p_vector.w = !p_vector.w;

				return p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b Or (Vector4b p_lhs, Vector4b p_rhs)
			{
				return new Vector4b
				(
					p_lhs.x | p_rhs.x,
					p_lhs.y | p_rhs.y,
					p_lhs.z | p_rhs.z,
					p_lhs.w | p_rhs.w
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b Or (ref Vector4b p_lhs, Vector4b p_rhs)
			{
				p_lhs.x |= p_rhs.x;
				p_lhs.y |= p_rhs.y;
				p_lhs.z |= p_rhs.z;
				p_lhs.w |= p_rhs.w;

				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b Replicate (bool p_value)
			{
				return new Vector4b (p_value, p_value, p_value, p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b Xor (Vector4b p_lhs, Vector4b p_rhs)
			{
				return new Vector4b
				(
					p_lhs.x ^ p_rhs.x,
					p_lhs.y ^ p_rhs.y,
					p_lhs.z ^ p_rhs.z,
					p_lhs.w ^ p_rhs.w
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4b Xor (ref Vector4b p_lhs, Vector4b p_rhs)
			{
				p_lhs.x ^= p_rhs.x;
				p_lhs.y ^= p_rhs.y;
				p_lhs.z ^= p_rhs.z;
				p_lhs.w ^= p_rhs.w;

				return p_lhs;
			}

		#endregion

		#region ==============================[Methods]==============================

			public void Set (bool p_x = false, bool p_y = false, bool p_z = false, bool p_w = false)
			{
				x = p_x;
				y = p_y;
				z = p_z;
				w = p_w;
			}

			public void Set (bool p_x, bool p_y, Vector2b p_zw)
			{
				x = p_x;
				y = p_y;
				z = p_zw.x;
				w = p_zw.y;
			}

			public void Set (bool p_x, Vector3b p_yzw)
			{
				x = p_x;
				y = p_yzw.x;
				z = p_yzw.y;
				w = p_yzw.z;
			}

			public void Set (Vector2b p_xy, Vector2b p_zw)
			{
				x = p_xy.x;
				y = p_xy.y;
				z = p_zw.x;
				w = p_zw.y;
			}

			public void Set (Vector2b p_xy, bool p_z = false, bool p_w = false)
			{
				x = p_xy.x;
				y = p_xy.y;
				z = p_z;
				w = p_w;
			}

			public void Set (Vector3b p_xyz, bool p_w = false)
			{
				x = p_xyz.x;
				y = p_xyz.y;
				z = p_xyz.z;
				w = p_w;
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public int CompareTo (object p_obj)
			{
				throw new System.NotImplementedException();
			}

			public int CompareTo (Vector4b p_other)
			{
				throw new System.NotImplementedException();
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is Vector4b other && Equals(other);
			}

			public bool Equals (Vector4b p_other)
			{
				return this == p_other;
			}

			public override int GetHashCode ()
			{
				throw new System.NotImplementedException();
			}

			public override string ToString ()
			{
				throw new System.NotImplementedException();
			}

			public string ToString (string p_format)
			{
				throw new System.NotImplementedException();
			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				throw new System.NotImplementedException();
			}

		#endregion

		#region ==============================[Operators]==============================

			public static bool operator== (Vector4b p_lhs, Vector4b p_rhs)
			{
				return p_lhs.x == p_rhs.x && p_lhs.y == p_rhs.y && p_lhs.z == p_rhs.z && p_lhs.z == p_rhs.z;
			}

			public static bool operator!= (Vector4b p_lhs, Vector4b p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static implicit operator bool (Vector4b p_this)
			{
				return p_this.x && p_this.y && p_this.z && p_this.w;
			}

			public static implicit operator Vector4b (bool p_bool)
			{
				return Replicate(p_bool);
			}

			public static Vector4b operator! (Vector4b p_this)
			{
				return Not(p_this);
			}

			public static Vector4b operator& (Vector4b p_lhs, Vector4b p_rhs)
			{
				return And(p_lhs, p_rhs);
			}

			public static Vector4b operator| (Vector4b p_lhs, Vector4b p_rhs)
			{
				return Or(p_lhs, p_rhs);
			}

			public static Vector4b operator^ (Vector4b p_lhs, Vector4b p_rhs)
			{
				return Xor(p_lhs, p_rhs);
			}

		#endregion
	}

	public struct Vector3b : IVectorb<Vector3b>
	{
		#region ==============================[Editable Variables]==============================

			public bool x;

			public bool y;

			public bool z;

		#endregion

		public bool Equals (Vector4b other)
		{
			throw new NotImplementedException();
		}

		public int CompareTo (Vector4b other)
		{
			throw new NotImplementedException();
		}

		public string ToString (string format, IFormatProvider formatProvider)
		{
			throw new NotImplementedException();
		}

		public int CompareTo (object obj)
		{
			throw new NotImplementedException();
		}

		public Vector3b (bool p_x = false, bool p_y = false, bool p_z = false)
		{
			x = p_x;
			y = p_y;
			z = p_z;
		}

		public Vector3b (bool p_x, Vector2b p_yz)
		{
			x = p_x;
			y = p_yz.x;
			z = p_yz.y;
		}

		public Vector3b (Vector2b p_xy, bool p_z = false)
		{
			x = p_xy.x;
			y = p_xy.y;
			z = p_z;
		}

		public Vector3b (Vector3b p_xyz)
		{
			x = p_xyz.x;
			y = p_xyz.y;
			z = p_xyz.z;
		}

	}

	public struct Vector2b : IVectorb<Vector2b>
	{
		#region ==============================[Editable Variables]==============================

			public bool x;

			public bool y;

		#endregion

		public bool Equals (Vector4b other)
		{
			throw new NotImplementedException();
		}

		public int CompareTo (Vector4b other)
		{
			throw new NotImplementedException();
		}

		public string ToString (string format, IFormatProvider formatProvider)
		{
			throw new NotImplementedException();
		}

		public int CompareTo (object obj)
		{
			throw new NotImplementedException();
		}

		public Vector2b (bool p_x = false, bool p_y = false)
		{
			x = p_x;
			y = p_y;
		}

		public Vector2b (Vector2b p_xy)
		{
			x = p_xy.x;
			y = p_xy.y;
		}
	}

	public interface IVectorb<T> : IEquatable<Vector4b>, IComparable<Vector4b>, IVectorb
	{

	}

	public interface IVectorb : IFormattable, IComparable
	{

	}
}