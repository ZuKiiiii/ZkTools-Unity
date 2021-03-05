using System.Runtime.CompilerServices;
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
			public void DrawDebugCoordinateSystem () {}
			public void DrawDebugCrossHairs () {}
			public void DrawDebugCylinder () {}
			public void DrawDebugDirectionalArrow () {}
			public void DrawDebugFloatHistory () {}
			public void DrawDebugFloatHistory2 () {}
			public void DrawDebugFrustum () {}
			public void DrawDebugLine () {}
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
		
			public static void DrawDebugBox (Vector3 p_center, Vector3 p_extent, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				DrawDebugLine(p_center + new Vector3( p_extent.x,  p_extent.y,  p_extent.z), p_center + new Vector3( p_extent.x, -p_extent.y, p_extent.z),  p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3( p_extent.x, -p_extent.y,  p_extent.z), p_center + new Vector3(-p_extent.x, -p_extent.y, p_extent.z),  p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3(-p_extent.x, -p_extent.y,  p_extent.z), p_center + new Vector3(-p_extent.x,  p_extent.y, p_extent.z),  p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3(-p_extent.x,  p_extent.y,  p_extent.z), p_center + new Vector3( p_extent.x,  p_extent.y, p_extent.z),  p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3( p_extent.x,  p_extent.y, -p_extent.z), p_center + new Vector3( p_extent.x, -p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3( p_extent.x, -p_extent.y, -p_extent.z), p_center + new Vector3(-p_extent.x, -p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3(-p_extent.x, -p_extent.y, -p_extent.z), p_center + new Vector3(-p_extent.x,  p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3(-p_extent.x,  p_extent.y, -p_extent.z), p_center + new Vector3( p_extent.x,  p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3( p_extent.x,  p_extent.y,  p_extent.z), p_center + new Vector3( p_extent.x,  p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3( p_extent.x, -p_extent.y,  p_extent.z), p_center + new Vector3( p_extent.x, -p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3(-p_extent.x, -p_extent.y,  p_extent.z), p_center + new Vector3(-p_extent.x, -p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
				DrawDebugLine(p_center + new Vector3(-p_extent.x,  p_extent.y,  p_extent.z), p_center + new Vector3(-p_extent.x,  p_extent.y, -p_extent.z), p_color, p_duration, p_depthTest);
			}
			
			public static void DrawDebugBox (Vector3 p_center, Vector3 p_extent, Quaternion p_rotation, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Vector3 start = p_rotation * new Vector3(p_extent.x,  p_extent.y,  p_extent.z);
				Vector3 end = p_rotation * new Vector3(p_extent.x, -p_extent.y, p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);
			
				
				start = p_rotation * new Vector3(p_extent.x, -p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x, -p_extent.y, p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x, -p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x,  p_extent.y, p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x,  p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3( p_extent.x,  p_extent.y, p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3( p_extent.x,  p_extent.y, -p_extent.z);
				end = p_rotation * new Vector3( p_extent.x, -p_extent.y, -p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3( p_extent.x, -p_extent.y, -p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x, -p_extent.y, -p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x, -p_extent.y, -p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x,  p_extent.y, -p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x,  p_extent.y, -p_extent.z);
				end = p_rotation * new Vector3( p_extent.x,  p_extent.y, -p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3( p_extent.x,  p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3( p_extent.x,  p_extent.y, -p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3( p_extent.x, -p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3( p_extent.x, -p_extent.y, -p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x, -p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x, -p_extent.y, -p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);

				start = p_rotation * new Vector3(-p_extent.x,  p_extent.y,  p_extent.z);
				end = p_rotation * new Vector3(-p_extent.x,  p_extent.y, -p_extent.z);
				DrawDebugLine(p_center + start, p_center + end, p_color, p_duration, p_depthTest);
				
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawDebugBox (Vector3 p_center, Vector3 p_extent, Vector3 p_rotation, Color p_color, float p_time = 0.0f, bool p_depthTest = true)
			{
				DrawDebugBox(p_center, p_extent, Quaternion.Euler(p_rotation), p_color, p_time, p_depthTest);
			}
		
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void DrawDebugLine (Vector3 p_start, Vector3 p_end, Color p_color, float p_duration = 0.0f, bool p_depthTest = true)
			{
				Debug.DrawLine(p_start, p_end, p_color, p_duration, p_depthTest);
			}
		
		#endregion
	}	
}

