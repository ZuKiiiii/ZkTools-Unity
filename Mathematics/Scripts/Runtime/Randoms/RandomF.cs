using System.Runtime.CompilerServices;
using UnityEngine;
using ZkTools.Mathematics.Angles;
using ZkTools.Mathematics.Extensions;
using ZkTools.Mathematics.Geometry2D;
using ZkTools.Mathematics.Geometry3D;
using ZkTools.Mathematics.Ranges;

using URandom = UnityEngine.Random;

namespace ZkTools.Mathematics.Randoms
{
	public static class RandomF
	{
		#region ==============================[Static Properties]==============================

			public static Radian Angle {get => Radian.One * Value;}

			public static Vector3 Euler {get => new Vector3(Angle, Angle, Angle);}

			public static float Direction1D {get => Sign;}

			public static Vector2 Direction2D {get => OnUnitCircle;}

			public static Vector3 Direction3D {get => OnUnitSphere;}

			public static Vector4 Direction4D {get => new Vector4(Value, Value, Value, Value).normalized;}

			public static Vector2 InUnitCircle {get => URandom.insideUnitCircle;}

			public static Vector3 InUnitCube {get => new Vector3(Value, Value, Value);}

			public static Vector3 InUnitSphere {get => URandom.insideUnitSphere;}

			public static Vector2 InUnitSquare {get => new Vector2(Value, Value);}

			public static Vector2 OnUnitCircle {get => Vector2X.Direction(Angle);}

			public static Vector3 OnUnitCube {get => throw new System.NotImplementedException();}

			public static Vector2 OnUnitSphere {get => URandom.onUnitSphere;}

			public static Vector2 OnUnitSquare {get => throw new System.NotImplementedException();}

			public static Quaternion Rotation {get => URandom.rotationUniform;}

			public static float Sign {get => Value > 0.5f ? 1.0f : -1.0f;}

			public static Radian SignedAngle {get => Radian.Half * Sign;}

			public static Vector3 SignedEuler {get => new Vector3(SignedAngle, SignedAngle, SignedAngle);}

			public static float Value {get => URandom.value;}

		#endregion

		#region ==============================[Static Properties]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian GetAngle (Radian p_min, Radian p_max)
			{
				return Range1D(p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian GetAngle (Range p_range)
			{
				return GetAngle(p_range.min, p_range.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetDirection1D (float p_scale)
			{
				return GetSign(p_scale);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 GetDirection2D (float p_scale)
			{
				return OnSquare(p_scale);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 GetDirection3D (float p_scale)
			{
				return OnCube(p_scale);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 GetDirection4D (float p_scale)
			{
				return Direction4D * p_scale;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetSign (float p_scale)
			{
				return Sign * p_scale;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetValue (float p_scale)
			{
				return Value * p_scale;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InCircle (float p_radius)
			{
				return InUnitCircle * p_radius;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InCircle (float p_min, float p_max)
			{
				return OnCircle(Range1D(p_min, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InCircle (Range p_range)
			{
				return InCircle(p_range.min, p_range.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InCube (float p_extents)
			{
				return OnUnitCube * p_extents;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InCube (Vector3 p_extents)
			{
				return Vector3X.Mul(OnUnitCube, p_extents);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InCube (float p_minExtents, float p_maxExtents)
			{
				return InCube(Range1D(p_minExtents, p_maxExtents));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InCube (float p_minExtents, Vector3 p_maxExtents)
			{
				return Vector3X.Mul(OnUnitCube, Range3D(p_minExtents, p_maxExtents));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InCube (Vector3 p_minExtents, float p_maxExtents)
			{
				return Vector3X.Mul(OnUnitCube, Range3D(p_minExtents, p_maxExtents));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InCube (Vector3 p_minExtents, Vector3 p_maxExtents)
			{
				return Vector3X.Mul(OnUnitCube, Range3D(p_minExtents, p_maxExtents));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InCube (Bounds p_boundsExtents)
			{
				return InCube(p_boundsExtents.min, p_boundsExtents.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InCube (AABB3D p_aabb3DExtents)
			{
				return InCube(p_aabb3DExtents.min, p_aabb3DExtents.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSphere (float p_radius)
			{
				return InUnitSphere * p_radius;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSphere (float p_min, float p_max)
			{
				return OnSphere(Range1D(p_min, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSphere (Range p_range)
			{
				return InSphere(p_range.min, p_range.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSquare (float p_extents)
			{
				return OnUnitSquare * p_extents;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSquare (Vector2 p_extents)
			{
				return Vector2X.Mul(OnUnitSquare, p_extents);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSquare (float p_minExtents, float p_maxExtents)
			{
				return InSquare(Range1D(p_minExtents, p_maxExtents));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSquare (float p_minExtents, Vector2 p_maxExtents)
			{
				return Vector2X.Mul(OnUnitSquare, Range3D(p_minExtents, p_maxExtents));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSquare (Vector2 p_minExtents, float p_maxExtents)
			{
				return Vector2X.Mul(OnUnitSquare, Range3D(p_minExtents, p_maxExtents));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSquare (Vector2 p_minExtents, Vector2 p_maxExtents)
			{
				return Vector2X.Mul(OnUnitSquare, Range3D(p_minExtents, p_maxExtents));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSquare (Rect p_rectExtents)
			{
				return InSquare(p_rectExtents.min, p_rectExtents.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 InSquare (AABB2D p_aabb2DExtents)
			{
				return InSquare(p_aabb2DExtents.min, p_aabb2DExtents.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 OnCircle (float p_radius)
			{
				return OnUnitCircle * p_radius;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 OnCube (float p_extents)
			{
				return OnUnitCube * p_extents;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 OnCube (Vector3 p_extents)
			{
				return Vector3X.Mul(OnUnitCube, p_extents);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 OnSphere (float p_radius)
			{
				return OnUnitSphere * p_radius;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 OnSquare (float p_extents)
			{
				return OnUnitSquare * p_extents;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 OnSquare (Vector3 p_extents)
			{
				return Vector3X.Mul(OnUnitSquare, p_extents);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Range1D (float p_min, float p_max)
			{
				return URandom.Range(p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Range1D (Range p_range)
			{
				return URandom.Range(p_range.min, p_range.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Range2D (Vector2 p_min, Vector2 p_max)
			{
				return new Vector2
				(
					Range1D(p_min.x, p_max.x),
					Range1D(p_min.y, p_max.y)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Range2D (float p_min, Vector2 p_max)
			{
				return new Vector2
				(
					Range1D(p_min, p_max.x),
					Range1D(p_min, p_max.y)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Range2D (Vector2 p_min, float p_max)
			{
				return new Vector2
				(
					Range1D(p_min.x, p_max),
					Range1D(p_min.y, p_max)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Range2D (float p_min, float p_max)
			{
				return new Vector2
				(
					Range1D(p_min, p_max),
					Range1D(p_min, p_max)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Range2D (Rect p_rect)
			{
				return Range2D(p_rect.min, p_rect.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Range2D (AABB2D p_aabb)
			{
				return Range2D(p_aabb.min, p_aabb.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Range3D (Vector3 p_min, Vector3 p_max)
			{
				return new Vector3
				(
					Range1D(p_min.x, p_max.x),
					Range1D(p_min.y, p_max.y),
					Range1D(p_min.z, p_max.z)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Range3D (float p_min, Vector3 p_max)
			{
				return new Vector3
				(
					Range1D(p_min, p_max.x),
					Range1D(p_min, p_max.y),
					Range1D(p_min, p_max.z)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Range3D (Vector3 p_min, float p_max)
			{
				return new Vector3
				(
					Range1D(p_min.x, p_max),
					Range1D(p_min.y, p_max),
					Range1D(p_min.z, p_max)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Range3D (float p_min, float p_max)
			{
				return new Vector3
				(
					Range1D(p_min, p_max),
					Range1D(p_min, p_max),
					Range1D(p_min, p_max)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Range3D (Bounds p_bounds)
			{
				return Range3D(p_bounds.min, p_bounds.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Range3D (AABB3D p_aabb)
			{
				return Range3D(p_aabb.min, p_aabb.max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Range4D (Vector4 p_min, Vector4 p_max)
			{
				return new Vector4
				(
					Range1D(p_min.x, p_max.x),
					Range1D(p_min.y, p_max.y),
					Range1D(p_min.z, p_max.z),
					Range1D(p_min.w, p_max.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Range4D (float p_min, Vector4 p_max)
			{
				return new Vector4
				(
					Range1D(p_min, p_max.x),
					Range1D(p_min, p_max.y),
					Range1D(p_min, p_max.z),
					Range1D(p_min, p_max.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Range4D (Vector4 p_min, float p_max)
			{
				return new Vector4
				(
					Range1D(p_min.x, p_max),
					Range1D(p_min.y, p_max),
					Range1D(p_min.z, p_max),
					Range1D(p_min.w, p_max)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Range4D (float p_min, float p_max)
			{
				return new Vector4
				(
					Range1D(p_min, p_max),
					Range1D(p_min, p_max),
					Range1D(p_min, p_max),
					Range1D(p_min, p_max)
				);
			}

		#endregion
	}
}