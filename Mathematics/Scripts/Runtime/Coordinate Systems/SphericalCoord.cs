using System;
using UnityEngine;
using ZkTools.Mathematics.Angles;
using ZkTools.Mathematics.Swizzling;

namespace ZkTools.Mathematics.CoordinateSystems
{
	[System.Serializable]
	public struct SphericalCoord : IEquatable<SphericalCoord>, IFormattable
	{
		#region ==============================[Editable Variables]==============================

			/** The radius or radial distance is the Euclidean distance from the origin O to P. */
			public float radius;

			/** The azimuth (or azimuthal angle) is the signed angle measured from the azimuth reference direction to the orthogonal projection of the line segment OP on the reference plane. */
			public Radian theta;

			/** The inclination (or polar angle) is the angle between the zenith direction and the line segment OP.*/
			public Radian phi;

		#endregion

		#region ==============================[Properties]==============================

			public CylindricalCoord Cylindrical => CoordinateSystem.SphericalToCylindrical(this);

			public SphericalCoord Spherical => this;

			public Vector2 Vector2 => CoordinateSystem.SphericalToCartesian(this);

			public Vector3 Vector3 => CoordinateSystem.SphericalToCartesian(this);

		#endregion

		#region ==============================[Constructor + Destructor]==============================

			public SphericalCoord (float p_radius, float p_theta, float p_phi)
			{
				radius = p_radius;
				theta = p_theta;
				phi = p_phi;
			}

			public SphericalCoord (SphericalCoord p_copy)
			{
				radius = p_copy.radius;
				theta = p_copy.theta;
				phi = p_copy.phi;
			}

			public SphericalCoord (CylindricalCoord p_cylindricalCoord)
			{
				CoordinateSystem.CartesianToSpherical(p_cylindricalCoord, out radius, out theta, out phi);
			}

			public SphericalCoord (Vector2 p_vector2, float p_z = 0.0f)
			{
				CoordinateSystem.CartesianToSpherical(p_vector2.GetXYK(p_z), out radius, out theta, out phi);
			}

			public SphericalCoord (Vector3 p_vector3)
			{
				CoordinateSystem.CartesianToSpherical(p_vector3, out radius, out theta, out phi);
			}

		#endregion

		#region ==============================[Inherited Methods]==============================

			public bool Equals (SphericalCoord p_other)
			{
				return radius.Equals(p_other.radius) && theta.Equals(p_other.theta) && phi.Equals(p_other.phi);
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is SphericalCoord other && Equals(other);
			}

			public override int GetHashCode ()
			{
				unchecked
				{
					var hashCode = radius.GetHashCode();
					hashCode = (hashCode * 397) ^ theta.GetHashCode();
					hashCode = (hashCode * 397) ^ phi.GetHashCode();
					return hashCode;
				}
			}

			public override string ToString ()
			{
				return "SphericalCoord (" + radius + "," + theta + "," + phi + ")";
			}

			public string ToString (string p_format)
			{
				return "SphericalCoord (" + radius.ToString(p_format) + "," + theta.ToString(p_format) + "," + phi.ToString(p_format) + ")";
			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return "SphericalCoord (" + radius.ToString(p_format, p_formatProvider) + "," + theta.ToString(p_format, p_formatProvider) + "," + phi.ToString(p_format, p_formatProvider) + ")";
			}

		#endregion

		#region ==============================[Operators]==============================

			public static bool operator== (SphericalCoord p_lhs, SphericalCoord p_rhs)
			{
				return p_lhs.radius == p_rhs.radius && p_lhs.theta == p_rhs.theta && p_lhs.phi == p_rhs.phi;
			}

			public static bool operator!= (SphericalCoord p_lhs, SphericalCoord p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static implicit operator SphericalCoord (Vector2 p_vector2)
			{
				return p_vector2.ToSpherical();
			}

			public static implicit operator SphericalCoord (Vector3 p_vector3)
			{
				return p_vector3.ToSpherical();
			}

			public static implicit operator CylindricalCoord (SphericalCoord p_this)
			{
				return p_this.Cylindrical;
			}

			public static implicit operator Vector2 (SphericalCoord p_this)
			{
				return p_this.Vector2;
			}

			public static implicit operator Vector3 (SphericalCoord p_this)
			{
				return p_this.Vector3;
			}

		#endregion
	}
}