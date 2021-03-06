using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

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

			// Rename Draw Arrow ?
			public static void DrawDirectionalArrow (Vector3 p_start, Vector3 p_end, Color p_color, float p_arrowSize = 0.10f, float p_duration = 0.0f, bool p_depthTest = true)
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
			
			public static void DrawCoordinateSystem (Vector3 p_position, Quaternion p_rotation, float p_scale, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Vector3 right = p_rotation * Vector3.right;
				Vector3 up = p_rotation * Vector3.up;
				Vector3 forward = p_rotation * Vector3.forward;
				
				DrawRay(p_position, right * p_scale, Color.red, p_duration, p_depthTest);
				DrawRay(p_position, up * p_scale, Color.green, p_duration, p_depthTest);
				DrawRay(p_position, forward * p_scale, Color.blue, p_duration, p_depthTest);
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

					Vector3 vertex1 = p_center + p_radius * new Vector3(sinY1, cosY1,0.0f);
					Vector3 vertex3 = p_center + p_radius * new Vector3(sinY2, cosY2,0.0f);
				
					for (int x = 0; x < p_segments; ++x)
					{
						float cosX = Mathf.Cos(xAngle);
						float sinX = Mathf.Sin(xAngle);
			
						Vector3 vertex2 = p_center + p_radius * new Vector3(cosX * sinY1, cosY1,sinX * sinY1);
						Vector3 vertex4 = p_center + p_radius * new Vector3(cosX * sinY2, cosY2,sinX * sinY2);
					
						DrawLine(vertex1, vertex2, p_color, p_duration, p_depthTest);
						DrawLine(vertex1, vertex3, p_color, p_duration, p_depthTest);
			
						vertex1 = vertex2;
						vertex3 = vertex4;
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
			
		#endregion
	}	
}

