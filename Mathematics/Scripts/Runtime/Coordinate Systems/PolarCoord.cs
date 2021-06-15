using System;
using UnityEngine;
using ZkTools.Mathematics.Angles;
using ZkTools.Mathematics.Swizzling;

namespace ZkTools.Mathematics.CoordinateSystems
{
	[System.Serializable]
	public struct PolarCoord : IEquatable<PolarCoord>, IFormattable
	{
		#region // ==============================[Static Variables]============================== //

			public static readonly PolarCoord Down = Vector2.down.ToPolar();

			public static readonly PolarCoord Left = Vector2.left.ToPolar();

			public static readonly PolarCoord One = Vector2.one.ToPolar();

			public static readonly PolarCoord Right = Vector2.right.ToPolar();

			public static readonly PolarCoord Up = Vector2.up.ToPolar();

			public static readonly PolarCoord Zero = new PolarCoord(0.0f, 0.0f);

		#endregion

		#region // ==============================[Editable Variables]============================== //

			public float radius;

			public Radian angle;

		#endregion

		#region // ==============================[Properties]============================== //

			public Vector2 Vector2 => CoordinateSystem.PolarToCartesian(this);

			public Vector3 Vector3 => CoordinateSystem.PolarToCartesian(this);

		#endregion

		#region // ==============================[Constructor + Destructor]============================== //

			public PolarCoord (float p_radius, Radian p_angle)
			{
				radius = p_radius;
				angle = p_angle;
			}

			public PolarCoord (PolarCoord p_copy)
			{
				radius = p_copy.radius;
				angle = p_copy.angle;
			}

			public PolarCoord (Vector2 p_vector2)
			{
				CoordinateSystem.CartesianToPolar(p_vector2, out radius, out angle);
			}

			public PolarCoord (Vector3 p_vector3)
			{
				CoordinateSystem.CartesianToPolar(p_vector3, out radius, out angle);
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public bool Equals (PolarCoord p_other)
			{
				return radius.Equals(p_other.radius) && angle.Equals(p_other.angle);
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is PolarCoord other && Equals(other);
			}

			public override int GetHashCode ()
			{
				unchecked
				{
					return (radius.GetHashCode() * 397) ^ angle.GetHashCode();
				}
			}

			public override string ToString ()
			{
				return "PolarCoord (" + radius + "," + angle + ")";
			}

			public string ToString (string p_format)
			{
				return "SphericalCoord (" + radius.ToString(p_format) + "," + angle.ToString(p_format) + ")";
			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return "SphericalCoord (" + radius.ToString(p_format, p_formatProvider) + "," + angle.ToString(p_format, p_formatProvider) + ")";
			}

			public Vector3 ToVector3 (float p_z)
			{
				return Vector2.GetXYK(p_z);
			}

		#endregion

		#region // ==============================[Operators]============================== //

			public static bool operator== (PolarCoord p_lhs, PolarCoord p_rhs)
			{
				return p_lhs.radius == p_rhs.radius && p_lhs.angle == p_rhs.angle;
			}

			public static bool operator!= (PolarCoord p_lhs, PolarCoord p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static implicit operator PolarCoord (Vector2 p_vector2)
			{
				return p_vector2.ToPolar();
			}

			public static implicit operator Vector2 (PolarCoord p_this)
			{
				return p_this.Vector2;
			}

			public static implicit operator Vector3 (PolarCoord p_this)
			{
				return p_this.Vector2;
			}

		#endregion
	}
}