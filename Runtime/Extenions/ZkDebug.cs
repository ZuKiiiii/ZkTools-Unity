using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTool.Extentions
{
	public static class ZkDebug
	{
		
		#region // ==============================[Static Methods]============================== //
		
		/*	public void DrawArc () {}
			public void Drawp_extent () {}
			public void DrawBo2 () {}
			public void Drawp_extentOverlap () {}
			public void Drawp_extentSweeps() {}
			public void DrawCapsuleOverlap () {}
			public void DrawCapsuleSweeps() {}
			public void DrawCircle() {}
			public void DrawCircle2() {}
			public void DrawCone() {}
			public void DrawConnectedArrow () {}
			public void DrawCoordinateSystem () {}
			public void DrawCoordinateSystem2 () {}
			public void DrawCylinder () {}
			public void DrawCylinder2 () {}
			public void DrawCylinder3 () {}
			public void DrawDashedLine () {}
			public void DrawDebug2DDonut () {}
			public void DrawDebugAltCone () {}
			public void DrawDebugCamera () {}
			public void DrawDebugCanvas2Dp_extent () {}
			public void DrawDebugCanvas2DCircle () {}
			public void DrawDebugCanvas2DLine () {}
			public void DrawDebugCanvas2DLine2 () {}
			public void DrawDebugCanvas2DCircle () {}
			public void DrawDebugCanvasLine () {}
			public void DrawDebugCanvasLine () {}
			public void DrawDebugCanvasWireCone () {}
			public void DrawDebugCanvasWireSphere () {}
			public void DrawDebugCapsule () {}
			public void DrawDebugCircle () {}
			public void DrawDebugCone () {}
			public void DrawDebugCrossHairs () {}
			public void DrawDebugCylinder () {}
			public void DrawDebugFloatHistory () {}
			public void DrawDebugFloatHistory2 () {}
			public void DrawDebugFrustum () {}
			public void DrawDebugMesh () {}
			public void DrawDebugPoint () {}
			public void DrawDebugSolidp_extent () {}
			public void DrawDebugSolidp_extent2 () {}
			public void DrawDebugSolidPlane () {}
			public void DrawDebugSolidPlane2 () {}
			public void DrawDebugSphere () {}
			public void DrawDebugString () {}
			public void DrawDirectionalArrow () {}
			public void DrawDisc () {}
			public void DrawFlatArrow () {}
			public void DrawLineTraces () {}
			public void DrawOrientedWirep_extent () {}
			public void DrawPlane10x10 () {}
			public void DrawSphere () {}
			public void DrawSphereOverlap () {}
			public void DrawSphereSweeps () {}
			public void DrawStatsHUD () {}
			public void DrawTriangle () {}
			public void DrawUVs () {}
			public void DrawWirep_extent () {}
			public void DrawWireCapsule () {}
			public void DrawWireChoppedCone () {}
			public void DrawWireCone () {}
			public void DrawWireCylinder () {}
			public void DrawWireDiamond () {}
			public void DrawWireSphere () {}
			public void DrawWireSphereAutoSides () {}
			public void DrawWireSphereCappedCone () {}
			public void DrawWireStar () {}
		*/

			public static void DrawArrow (Vector3 p_start, Vector3 p_end, Color p_color, float p_arrowSize = 0.10f, float p_duration = 0.0f, bool p_depthTest = true)
			{
				if (p_arrowSize <= 0.0f)
					p_arrowSize = 0.10f;

				Vector3 direction = (p_end - p_start).normalized;
				Vector3 up = Vector3.up;
				Vector3 right = Vector3.Cross(direction, up);

				Matrix4x4 matrix = new Matrix4x4(right, up, direction, Vector3.zero);
				float arrowSqrt = Mathf.Sqrt(p_arrowSize);
				
				DrawLine(p_start, p_end, p_color, p_duration, p_depthTest);
				DrawLine(p_end, p_end + matrix.MultiplyPoint3x4(new Vector3(arrowSqrt,0.0f, -p_arrowSize)), p_color, p_duration, p_depthTest);
				DrawLine(p_end, p_end + matrix.MultiplyPoint3x4(new Vector3(-arrowSqrt, 0.0f, -p_arrowSize)), p_color, p_duration, p_depthTest);
			}

			public static void DrawCircle (Vector3 p_center, float p_radius, Vector3 p_xAxis, Vector3 p_yAxis, Color p_color, int p_segments = 12, float p_duration = 0.0f, bool p_depthTest = true)
			{
				p_segments = Mathf.Max(p_segments, 4);
				float deltaAngle = Tau / p_segments;
				
				Vector3 start = p_center + p_radius * p_xAxis;
				
				for (float angle = 0.0f; angle < Tau; angle += deltaAngle)
				{
					float nextAngle = angle + deltaAngle;
					Vector3 end = p_center + p_radius * (p_xAxis * Mathf.Cos(nextAngle) + p_yAxis * Mathf.Sin(nextAngle));
					DrawLine(start, end, p_color, p_duration, p_depthTest);
					start = end;
				}
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawCircle (Vector3 p_center, float p_radius, Vector3 p_normal, Color p_color, int p_segments = 12, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Vector3 xAxis = Vector3.right;
				Vector3 yAxis = Vector3.Cross(xAxis, p_normal);
				DrawCircle(p_center, p_radius, xAxis, yAxis, p_color,p_segments, p_duration, p_depthTest);
			}
			
			public static void DrawCone (Vector3 p_origin, Vector3 p_direction, float p_length, Color p_color, float p_angleWidthRad = Mathf.PI / 4.0f, float p_angleHeightRad = Mathf.PI / 4.0f, int p_sideCount = 12, float p_duration = 0.0f, bool p_depthTest = true)
			{
				p_sideCount = Mathf.Max(p_sideCount, 4);
				
				float angle1 = Mathf.Clamp(p_angleHeightRad, Mathf.Epsilon, Mathf.PI - Mathf.Epsilon);
				float angle2 = Mathf.Clamp(p_angleWidthRad, Mathf.Epsilon, Mathf.PI - Mathf.Epsilon);

				float sinX_2 = Mathf.Sin(0.5f * angle1);
				float sinY_2 = Mathf.Sin(0.5f * angle2);

				float sinSqX_2 = Square(sinX_2);
				float sinSqY_2 = Square(sinY_2);

				float tanX_2 = Mathf.Tan(0.5f * angle1);
				float tanY_2 = Mathf.Tan(0.5f * angle2);

				List<Vector3> coneVertices = new List<Vector3>(p_sideCount);
				for (int index = 0; index < p_sideCount; ++index)
				{
					float fraction = (float)index/(float)(p_sideCount);
					float thi = 2.0f * Mathf.PI * fraction;
					float phi = Mathf.Atan2(Mathf.Sin(thi) * sinY_2, Mathf.Cos(thi) * sinX_2);
					float sinPhi = Mathf.Sin(phi);
					float cosPhi = Mathf.Cos(phi);
					float sinSqPhi = Square(sinPhi);
					float cosSqPhi = Square(cosPhi);

					float rSq = sinSqX_2 * sinSqY_2 / (sinSqX_2 * sinSqPhi + sinSqY_2 * cosSqPhi);
					float r = Mathf.Sqrt(rSq);
					float sqr = Mathf.Sqrt(1-rSq);
					float alpha	= r * cosPhi;
					float beta = r * sinPhi;

					Vector3 vertex = new Vector3(1.0f - 2.0f * rSq, 2.0f * sqr * alpha, 2.0f * sqr * beta);
					coneVertices.Add(vertex);
				}
				
				p_direction.Normalize();
				GetUV(p_direction, out 	Vector3 xAxis, out Vector3 yAxis);
				Matrix4x4 coneToWorld = new Matrix4x4(p_direction * p_length, xAxis, yAxis, p_origin);
				
				Vector3 currentPoint = Vector3.zero;
				Vector3 prevPoint = Vector3.zero;
				Vector3 firstPoint = Vector3.zero;
				for(int index = 0; index < p_sideCount; index++)
				{
					currentPoint = coneToWorld.MultiplyPoint3x4(coneVertices[index]);
					DrawLine(p_origin, currentPoint, p_color, p_duration, p_depthTest);

					if (index > 0)
						DrawLine(prevPoint, currentPoint, p_color, p_duration, p_depthTest);
					else
						firstPoint = currentPoint;

					prevPoint = currentPoint;
				}
				DrawLine(currentPoint, firstPoint, p_color, p_duration, p_depthTest);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawConeDegree (Vector3 p_origin, Vector3 p_direction, float p_length, Color p_color, float p_angleWidthDeg = 45.0f, float p_angleHeightDeg = 45.0f, int p_sideCount = 12, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawCone(p_origin, p_direction, p_length, p_color, DegreeToRadian(p_angleWidthDeg), DegreeToRadian(p_angleHeightDeg), p_sideCount, p_duration, p_depthTest);
			}
			
			public static void DrawCoordinateSystem (Vector3 p_position, Quaternion p_rotation, float p_scale, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Vector3 right = p_rotation * Vector3.right;
				Vector3 up = p_rotation * Vector3.up;
				Vector3 forward = p_rotation * Vector3.forward;
				
				DrawRay(p_position, right * p_scale, Color.red, p_duration, p_depthTest);
				DrawRay(p_position, up * p_scale, Color.green, p_duration, p_depthTest);
				DrawRay(p_position, forward * p_scale, Color.blue, p_duration, p_depthTest);
			}

			public static void DrawCylinder (Vector3 p_start, Vector3 p_end, float p_radius = 0.5f, Color p_color = new Color(), int p_segments = 12, float p_duration = 0.0f, bool p_depthTest = true)
			{
				p_segments = Mathf.Max(p_segments, 4);
				
				Vector3 axis = (p_end - p_start).normalized;
				float deltaAngle = 360.0f / p_segments;
				float angle = deltaAngle;
				
				GetUV(axis, out Vector3 perpendicular, out Vector3 dummy);
				Vector3 segment = Quaternion.AngleAxis(0.0f, axis) * perpendicular * p_radius;
				Vector3 p1 = segment + p_start;
				Vector3 p3 = segment + p_end;
				
				for (int index = 0; index < p_segments; ++index)
				{
					segment = Quaternion.AngleAxis(angle, axis) * perpendicular * p_radius;
					Vector3 p2 = segment + p_start;
					Vector3 p4 = segment + p_end;
					
					DrawLine(p2, p4, p_color, p_duration, p_depthTest);
					DrawLine(p1, p2, p_color, p_duration, p_depthTest);
					DrawLine(p3, p4, p_color, p_duration, p_depthTest);
					
					p1 = p2;
					p3 = p4;
					angle += deltaAngle;
				}
			}

	
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawCoordinateSystem (Vector3 p_position, Vector3 p_rotation, float p_scale, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawCoordinateSystem(p_position, Quaternion.Euler(p_rotation), p_scale, p_duration, p_depthTest);
			}
			
			public static void DrawCube (Vector3 p_center, Vector3 p_extent, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawLine(p_center + new Vector3( p_extent.x,  p_extent.y,  p_extent.z), p_center + new Vector3( p_extent.x, -p_extent.y, p_extent.z),  p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3( p_extent.x, -p_extent.y,  p_extent.z), p_center + new Vector3(-p_extent.x, -p_extent.y, p_extent.z),  p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3(-p_extent.x, -p_extent.y,  p_extent.z), p_center + new Vector3(-p_extent.x,  p_extent.y, p_extent.z),  p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3(-p_extent.x,  p_extent.y,  p_extent.z), p_center + new Vector3( p_extent.x,  p_extent.y, p_extent.z),  p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3( p_extent.x,  p_extent.y, -p_extent.z), p_center + new Vector3( p_extent.x, -p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3( p_extent.x, -p_extent.y, -p_extent.z), p_center + new Vector3(-p_extent.x, -p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3(-p_extent.x, -p_extent.y, -p_extent.z), p_center + new Vector3(-p_extent.x,  p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3(-p_extent.x,  p_extent.y, -p_extent.z), p_center + new Vector3( p_extent.x,  p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3( p_extent.x,  p_extent.y,  p_extent.z), p_center + new Vector3( p_extent.x,  p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3( p_extent.x, -p_extent.y,  p_extent.z), p_center + new Vector3( p_extent.x, -p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3(-p_extent.x, -p_extent.y,  p_extent.z), p_center + new Vector3(-p_extent.x, -p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawLine(p_center + new Vector3(-p_extent.x,  p_extent.y,  p_extent.z), p_center + new Vector3(-p_extent.x,  p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
			}
			
			public static void DrawCube (Vector3 p_center, Vector3 p_extent, Quaternion p_rotation, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Vector3 start = p_rotation * new Vector3(p_extent.x,  p_extent.y,  p_extent.z);
				Vector3 end = p_rotation * new Vector3(p_extent.x, -p_extent.y, p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);
			
				
				start = p_rotation * new Vector3(p_extent.x, -p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x, -p_extent.y, p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x, -p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x,  p_extent.y, p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x,  p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3( p_extent.x,  p_extent.y, p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3( p_extent.x,  p_extent.y, -p_extent.z);
				end = p_rotation * new Vector3( p_extent.x, -p_extent.y, -p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3( p_extent.x, -p_extent.y, -p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x, -p_extent.y, -p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x, -p_extent.y, -p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x,  p_extent.y, -p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x,  p_extent.y, -p_extent.z);
				end = p_rotation * new Vector3( p_extent.x,  p_extent.y, -p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3( p_extent.x,  p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3( p_extent.x,  p_extent.y, -p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3( p_extent.x, -p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3( p_extent.x, -p_extent.y, -p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x, -p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x, -p_extent.y, -p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x,  p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x,  p_extent.y, -p_extent.z);
				DrawLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);
				
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawCube (Vector3 p_center, Vector3 p_extent, Vector3 p_rotation, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawCube(p_center, p_extent, Quaternion.Euler(p_rotation), p_color, p_duration, p_depthTest);
			}

		/*	[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawFrustum (FrustumPlanes p_frustrumPlane, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawFrustum(Matrix4x4.Frustum(p_frustrumPlane), p_color, p_duration, p_depthTest);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawFrustum (Vector3 p_position, Quaternion p_rotation, Vector3 p_scale, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawFrustum(Matrix4x4.TRS(p_position, p_rotation, p_scale), p_color, p_duration, p_depthTest);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawFrustum (Vector3 p_position, Vector3 p_rotation, Vector3 p_scale, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawFrustum(Matrix4x4.TRS(p_position, Quaternion.Euler(p_rotation), p_scale), p_color, p_duration, p_depthTest);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawFrustum (float p_left, float p_right, float p_bottom, float p_top, float p_zNear, float p_zFar, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawFrustum(Matrix4x4.Frustum(p_left, p_right, p_bottom, p_top, p_zNear, p_zFar), p_color, p_duration, p_depthTest);
			}
			
			public static void DrawFrustum (float p_fov, float p_aspect, float p_zNear, float p_zFar, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawFrustum(Matrix4x4.Perspective(p_fov, p_aspect, p_zNear, p_zFar), p_color, p_duration, p_depthTest);
			}
			
			public static void DrawFrustum (Matrix4x4 p_frustrum, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				p_frustrum = p_frustrum.inverse;
				Vector3[,,] vertices = new Vector3[2,2,2];
				for (int x = 0; x < 2; ++x)
				{
					for (int y = 0; y < 2; ++y)
					{
						for (int z = 0; z < 2; ++z)
						{
							Vector4 unprojectedVertex = p_frustrum * new Vector4(x != 0 ? -1.0f : 1.0f, y != 0 ? -1.0f : 1.0f, z != 0 ? 0.0f : 1.0f, 1.0f);
							vertices[x, y, z] = unprojectedVertex / -unprojectedVertex.w;
						}
					}
				}
					
				DrawLine(vertices[0,0,0], vertices[0,0,1], p_color, p_duration, p_depthTest);
				DrawLine(vertices[1,0,0], vertices[1,0,1], p_color, p_duration, p_depthTest);
				DrawLine(vertices[0,1,0], vertices[0,1,1], p_color, p_duration, p_depthTest);
				DrawLine(vertices[1,1,0], vertices[1,1,1], p_color, p_duration, p_depthTest);
				
				DrawLine(vertices[0,0,0], vertices[0,1,0], p_color, p_duration, p_depthTest);
				DrawLine(vertices[1,0,0], vertices[1,1,0], p_color, p_duration, p_depthTest);
				DrawLine(vertices[0,0,1], vertices[0,1,1], p_color, p_duration, p_depthTest);
				DrawLine(vertices[1,0,1], vertices[1,1,1], p_color, p_duration, p_depthTest);
				
				DrawLine(vertices[0,0,0], vertices[1,0,0], p_color, p_duration, p_depthTest);
				DrawLine(vertices[0,1,0], vertices[1,1,0], p_color, p_duration, p_depthTest);
				DrawLine(vertices[0,0,1], vertices[1,0,1], p_color, p_duration, p_depthTest);
				DrawLine(vertices[0,1,1], vertices[1,1,1], p_color, p_duration, p_depthTest);
			}*/
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawLine (Vector3 p_start, Vector3 p_end, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Debug.DrawLine(p_start, p_end, p_color, p_duration, p_depthTest);
			}
			
			public static void DrawLine (Vector3[] p_points, bool p_loop, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				if (p_points.Length < (p_loop ? 2 : 1))
					return;
					
				for (int index = 0; index < p_points.Length - 1; ++index)
						Debug.DrawLine(p_points[index], p_points[index+1], p_color, p_duration, p_depthTest);
				
				if (p_loop)
					Debug.DrawLine(p_points.Last(), p_points.First(), p_color, p_duration, p_depthTest);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawRay (Vector3 p_start, Vector3 p_direction, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Debug.DrawLine(p_start, p_start + p_direction, p_color, p_duration, p_depthTest);
			}

			public static void DrawSphere (Vector3 p_center, float p_radius, Color p_color, int p_segments = 12, float p_duration = 0.0f, bool p_depthTest = true)
			{
				p_segments = Mathf.Max(p_segments, 4);
				float cosY1 = 1.0f;
				float sinY1 = 0.0f;
				float deltaAngle = Tau / p_segments;
				float yAngle = deltaAngle;

				for (int y = 0; y < p_segments; ++y)
				{
					float cosY2 = Mathf.Cos(yAngle);
					float sinY2 = Mathf.Sin(yAngle);
					float xAngle = deltaAngle;

					Vector3 p1 = p_center + p_radius * new Vector3(sinY1, cosY1,0.0f);
					Vector3 p3 = p_center + p_radius * new Vector3(sinY2, cosY2,0.0f);
				
					for (int x = 0; x < p_segments; ++x)
					{
						float cosX = Mathf.Cos(xAngle);
						float sinX = Mathf.Sin(xAngle);
			
						Vector3 p2 = p_center + p_radius * new Vector3(cosX * sinY1, cosY1,sinX * sinY1);
						Vector3 p4 = p_center + p_radius * new Vector3(cosX * sinY2, cosY2,sinX * sinY2);
					
						DrawLine(p1, p2, p_color, p_duration, p_depthTest);
						DrawLine(p1, p3, p_color, p_duration, p_depthTest);
			
						p1 = p2;
						p3 = p4;
						xAngle += deltaAngle;
					}
					yAngle += deltaAngle;
					sinY1 = sinY2;
					cosY1 = cosY2;
				}
			}
			
		#endregion
		
		#region // ==============================[Mathematics]============================== //
		
			public const float Tau = 6.283185307179586476925286766559e+00f;
		
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsEven (int p_value)
			{
				return p_value % 2 == 0;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOdd (int p_value)
			{
				return p_value % 2 != 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Square (float p_value)
			{
				return p_value * p_value;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cube (float p_value)
			{
				return p_value * p_value * p_value;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static Vector3 SphericalToCartesian (float p_radius, float p_theta, float p_phi)
			{
				float sinTheta = Mathf.Sin(p_theta);
				return new Vector3
				(
					p_radius * sinTheta * Mathf.Cos(p_phi),
					p_radius * Mathf.Cos(p_theta),
					p_radius * sinTheta * Mathf.Sin(p_phi)

				); ;
			}

			/** a fix */
			public static void GetUV (Vector3 p_normal, out Vector3 p_u, out Vector3 p_v)
			{
				float x = Math.Abs(p_normal.x);
				float y = Math.Abs(p_normal.y);
				float z = Math.Abs(p_normal.x);

				if (y > z && y > x)
					p_u = Vector3.forward;
				else
					p_u = Vector3.up;

				p_u = (p_u - p_normal * Vector3.Dot(p_u, p_normal)).normalized;
				p_v = Vector3.Cross(p_u, p_normal);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DegreeToRadian (float p_degree)
			{
				return Mathf.Deg2Rad * p_degree;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static Vector4 GetIJKL (this Vector3 p_this, float p_l = 1.0f)
			{
				return new Vector4(p_this.x, p_this.y, p_this.z, p_l);
			}
			
		#endregion
	}
}

