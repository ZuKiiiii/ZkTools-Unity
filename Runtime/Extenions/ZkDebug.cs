﻿using System.Runtime.CompilerServices;
using Shapes;
using TMPro;
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

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawCircle (Vector3 p_center, float p_radius, Color p_color)
			{
				DrawCircle(p_center, p_radius, p_color, Vector3.forward);
			}
			
			public static void DrawCircle (Vector3 p_center, float p_radius, Color p_color, Vector3 p_normal, int p_segments = 12, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Vector3 right = Vector3.right;
				Vector3 up = Vector3.Cross(right, p_normal);

				float deltaAngle = (Mathf.PI * 2.0f) / p_segments;
				float max = (Mathf.PI * 2.0f);
				for (float angle = 0.0f; angle < max; angle += deltaAngle)
				{
					float nextAngle = angle + deltaAngle;
					Vector3 start = p_center + p_radius * (right * Mathf.Cos(angle) + up * Mathf.Sin(angle));
					Vector3 end = p_center + p_radius * (right * Mathf.Cos(nextAngle) + up * Mathf.Sin(nextAngle));
					DrawLine(start, end, p_color, p_duration, p_depthTest);
				}
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

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawRay (Vector3 p_start, Vector3 p_direction, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Debug.DrawLine(p_start, p_start + p_direction, p_color, p_duration, p_depthTest);
			}
			
		#endregion
	}	
}

