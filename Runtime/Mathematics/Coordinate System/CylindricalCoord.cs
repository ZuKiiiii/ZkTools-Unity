using System;
using UnityEngine;
using ZkTools.Mathematics.Swizzling;

namespace ZkTools.Mathematics.CoordinateSystems
{
	[System.Serializable]
	public struct CylindricalCoord : IEquatable<CylindricalCoord>, IFormattable
	{
		#region // ==============================[Editable Variables]============================== //

			/** The axial distance or radial distance ρ is the Euclidean distance from the z-axis to the point P. **/
			public float rho;

			/** The azimuth φ is the angle between the reference direction on the chosen plane and the line from the origin to the projection of P on the plane. **/
			public float phi;
			
			/** The axial coordinate or height z is the signed distance from the chosen plane to the point P. **/
			public float z;

		#endregion

		#region // ==============================[Properties]============================== //

			public SphericalCoord Spherical => CoordinateSystem.CylindricalToSpherical(this);

			public Vector2 Vector2 => CoordinateSystem.CylindricalToCartesian(this);
			
			public Vector3 Vector3 => CoordinateSystem.CylindricalToCartesian(this);

		#endregion

		#region // ==============================[Constructor + Destructor]============================== //

			public CylindricalCoord (float p_rho, float p_phi, float p_z)
			{
				rho = p_rho;
				phi = p_phi;
				z = p_z;
			}

			public CylindricalCoord (CylindricalCoord p_copy)
			{
				rho = p_copy.rho;
				phi = p_copy.phi;
				z = p_copy.z;
			}

			public CylindricalCoord (SphericalCoord p_sphericalCoord)
			{
				CoordinateSystem.SphericalToCylindrical(p_sphericalCoord, out rho, out phi, out z);
			}

			public CylindricalCoord (Vector2 p_vector2, float p_z)
			{
				CoordinateSystem.CartesianToCylindrical(p_vector2.GetXYK(p_z), out rho, out phi, out z);
			}

			public CylindricalCoord (Vector3 p_vector3)
			{
				CoordinateSystem.CartesianToCylindrical(p_vector3, out rho, out phi, out z);
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public bool Equals (CylindricalCoord p_other)
			{
				return rho.Equals(p_other.rho) && phi.Equals(p_other.phi) && z.Equals(p_other.z);
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is CylindricalCoord other && Equals(other);
			}

			public override int GetHashCode ()
			{
				unchecked
				{
					var hashCode = rho.GetHashCode();
					hashCode = (hashCode * 397) ^ phi.GetHashCode();
					hashCode = (hashCode * 397) ^ z.GetHashCode();
					return hashCode;
				}
			}

			public override string ToString ()
			{
				return "CylindiralCoord (" + rho + "," + phi + "," + z + ")";
			}

			public string ToString (string p_format)
			{
				return "CylindiralCoord (" + rho.ToString(p_format) + "," + phi.ToString(p_format) + "," + z.ToString(p_format) + ")";
			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return "CylindiralCoord (" + rho.ToString(p_format, p_formatProvider) + "," + phi.ToString(p_format, p_formatProvider) + "," + z.ToString(p_format, p_formatProvider) + ")";
			}

		#endregion

		#region // ==============================[Operators]============================== //

			public static bool operator== (CylindricalCoord p_lhs, CylindricalCoord p_rhs)
			{
				return p_lhs.rho == p_rhs.rho && p_lhs.phi == p_rhs.phi && p_lhs.z == p_rhs.z;
			}

			public static bool operator!= (CylindricalCoord p_lhs, CylindricalCoord p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static implicit operator CylindricalCoord (Vector2 p_vector2)
			{
				return p_vector2.ToCylindrical();
			}

			public static implicit operator CylindricalCoord (Vector3 p_vector3)
			{
				return p_vector3.ToCylindrical();
			}

			public static implicit operator SphericalCoord (CylindricalCoord p_this)
			{
				return p_this.Spherical;
			}

			public static implicit operator Vector2 (CylindricalCoord p_this)
			{
				return p_this.Vector3;
			}

			public static implicit operator Vector3 (CylindricalCoord p_this)
			{
				return p_this.Vector3;
			}

		#endregion
	}
}