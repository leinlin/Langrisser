using System;
using System.Runtime.CompilerServices;

namespace SLua
{
	// Token: 0x02001608 RID: 5640
	[LuaBinder(0)]
	public class BindUnity
	{
		// Token: 0x060229DC RID: 141788 RVA: 0x00BE6AB4 File Offset: 0x00BE4CB4
		public static Action<IntPtr>[] GetBindList()
		{
			Action<IntPtr>[] array = new Action<IntPtr>[636];
			int num = 0;
			if (BindUnity.<>f__mg$cache0 == null)
			{
				BindUnity.<>f__mg$cache0 = new Action<IntPtr>(Lua_UnityEngine_Application.reg);
			}
			array[num] = BindUnity.<>f__mg$cache0;
			int num2 = 1;
			if (BindUnity.<>f__mg$cache1 == null)
			{
				BindUnity.<>f__mg$cache1 = new Action<IntPtr>(Lua_UnityEngine_UserAuthorization.reg);
			}
			array[num2] = BindUnity.<>f__mg$cache1;
			int num3 = 2;
			if (BindUnity.<>f__mg$cache2 == null)
			{
				BindUnity.<>f__mg$cache2 = new Action<IntPtr>(Lua_UnityEngine_ApplicationInstallMode.reg);
			}
			array[num3] = BindUnity.<>f__mg$cache2;
			int num4 = 3;
			if (BindUnity.<>f__mg$cache3 == null)
			{
				BindUnity.<>f__mg$cache3 = new Action<IntPtr>(Lua_UnityEngine_ApplicationSandboxType.reg);
			}
			array[num4] = BindUnity.<>f__mg$cache3;
			int num5 = 4;
			if (BindUnity.<>f__mg$cache4 == null)
			{
				BindUnity.<>f__mg$cache4 = new Action<IntPtr>(Lua_UnityEngine_AsyncOperation.reg);
			}
			array[num5] = BindUnity.<>f__mg$cache4;
			int num6 = 5;
			if (BindUnity.<>f__mg$cache5 == null)
			{
				BindUnity.<>f__mg$cache5 = new Action<IntPtr>(Lua_UnityEngine_AssetBundleCreateRequest.reg);
			}
			array[num6] = BindUnity.<>f__mg$cache5;
			int num7 = 6;
			if (BindUnity.<>f__mg$cache6 == null)
			{
				BindUnity.<>f__mg$cache6 = new Action<IntPtr>(Lua_UnityEngine_AssetBundleRequest.reg);
			}
			array[num7] = BindUnity.<>f__mg$cache6;
			int num8 = 7;
			if (BindUnity.<>f__mg$cache7 == null)
			{
				BindUnity.<>f__mg$cache7 = new Action<IntPtr>(Lua_UnityEngine_Object.reg);
			}
			array[num8] = BindUnity.<>f__mg$cache7;
			int num9 = 8;
			if (BindUnity.<>f__mg$cache8 == null)
			{
				BindUnity.<>f__mg$cache8 = new Action<IntPtr>(Lua_UnityEngine_AssetBundle.reg);
			}
			array[num9] = BindUnity.<>f__mg$cache8;
			int num10 = 9;
			if (BindUnity.<>f__mg$cache9 == null)
			{
				BindUnity.<>f__mg$cache9 = new Action<IntPtr>(Lua_UnityEngine_AssetBundleManifest.reg);
			}
			array[num10] = BindUnity.<>f__mg$cache9;
			int num11 = 10;
			if (BindUnity.<>f__mg$cacheA == null)
			{
				BindUnity.<>f__mg$cacheA = new Action<IntPtr>(Lua_UnityEngine_SystemInfo.reg);
			}
			array[num11] = BindUnity.<>f__mg$cacheA;
			int num12 = 11;
			if (BindUnity.<>f__mg$cacheB == null)
			{
				BindUnity.<>f__mg$cacheB = new Action<IntPtr>(Lua_UnityEngine_WaitForSeconds.reg);
			}
			array[num12] = BindUnity.<>f__mg$cacheB;
			int num13 = 12;
			if (BindUnity.<>f__mg$cacheC == null)
			{
				BindUnity.<>f__mg$cacheC = new Action<IntPtr>(Lua_UnityEngine_WaitForFixedUpdate.reg);
			}
			array[num13] = BindUnity.<>f__mg$cacheC;
			int num14 = 13;
			if (BindUnity.<>f__mg$cacheD == null)
			{
				BindUnity.<>f__mg$cacheD = new Action<IntPtr>(Lua_UnityEngine_WaitForEndOfFrame.reg);
			}
			array[num14] = BindUnity.<>f__mg$cacheD;
			int num15 = 14;
			if (BindUnity.<>f__mg$cacheE == null)
			{
				BindUnity.<>f__mg$cacheE = new Action<IntPtr>(Lua_UnityEngine_CustomYieldInstruction.reg);
			}
			array[num15] = BindUnity.<>f__mg$cacheE;
			int num16 = 15;
			if (BindUnity.<>f__mg$cacheF == null)
			{
				BindUnity.<>f__mg$cacheF = new Action<IntPtr>(Lua_UnityEngine_WaitWhile.reg);
			}
			array[num16] = BindUnity.<>f__mg$cacheF;
			int num17 = 16;
			if (BindUnity.<>f__mg$cache10 == null)
			{
				BindUnity.<>f__mg$cache10 = new Action<IntPtr>(Lua_UnityEngine_WaitUntil.reg);
			}
			array[num17] = BindUnity.<>f__mg$cache10;
			int num18 = 17;
			if (BindUnity.<>f__mg$cache11 == null)
			{
				BindUnity.<>f__mg$cache11 = new Action<IntPtr>(Lua_UnityEngine_ScriptableObject.reg);
			}
			array[num18] = BindUnity.<>f__mg$cache11;
			int num19 = 18;
			if (BindUnity.<>f__mg$cache12 == null)
			{
				BindUnity.<>f__mg$cache12 = new Action<IntPtr>(Lua_UnityEngine_Component.reg);
			}
			array[num19] = BindUnity.<>f__mg$cache12;
			int num20 = 19;
			if (BindUnity.<>f__mg$cache13 == null)
			{
				BindUnity.<>f__mg$cache13 = new Action<IntPtr>(Lua_UnityEngine_Behaviour.reg);
			}
			array[num20] = BindUnity.<>f__mg$cache13;
			int num21 = 20;
			if (BindUnity.<>f__mg$cache14 == null)
			{
				BindUnity.<>f__mg$cache14 = new Action<IntPtr>(Lua_UnityEngine_BillboardAsset.reg);
			}
			array[num21] = BindUnity.<>f__mg$cache14;
			int num22 = 21;
			if (BindUnity.<>f__mg$cache15 == null)
			{
				BindUnity.<>f__mg$cache15 = new Action<IntPtr>(Lua_UnityEngine_Renderer.reg);
			}
			array[num22] = BindUnity.<>f__mg$cache15;
			int num23 = 22;
			if (BindUnity.<>f__mg$cache16 == null)
			{
				BindUnity.<>f__mg$cache16 = new Action<IntPtr>(Lua_UnityEngine_BillboardRenderer.reg);
			}
			array[num23] = BindUnity.<>f__mg$cache16;
			int num24 = 23;
			if (BindUnity.<>f__mg$cache17 == null)
			{
				BindUnity.<>f__mg$cache17 = new Action<IntPtr>(Lua_UnityEngine_Caching.reg);
			}
			array[num24] = BindUnity.<>f__mg$cache17;
			int num25 = 24;
			if (BindUnity.<>f__mg$cache18 == null)
			{
				BindUnity.<>f__mg$cache18 = new Action<IntPtr>(Lua_UnityEngine_Camera.reg);
			}
			array[num25] = BindUnity.<>f__mg$cache18;
			int num26 = 25;
			if (BindUnity.<>f__mg$cache19 == null)
			{
				BindUnity.<>f__mg$cache19 = new Action<IntPtr>(Lua_UnityEngine_Camera_StereoscopicEye.reg);
			}
			array[num26] = BindUnity.<>f__mg$cache19;
			int num27 = 26;
			if (BindUnity.<>f__mg$cache1A == null)
			{
				BindUnity.<>f__mg$cache1A = new Action<IntPtr>(Lua_UnityEngine_Camera_MonoOrStereoscopicEye.reg);
			}
			array[num27] = BindUnity.<>f__mg$cache1A;
			int num28 = 27;
			if (BindUnity.<>f__mg$cache1B == null)
			{
				BindUnity.<>f__mg$cache1B = new Action<IntPtr>(Lua_UnityEngine_ColorUtility.reg);
			}
			array[num28] = BindUnity.<>f__mg$cache1B;
			int num29 = 28;
			if (BindUnity.<>f__mg$cache1C == null)
			{
				BindUnity.<>f__mg$cache1C = new Action<IntPtr>(Lua_UnityEngine_ComputeShader.reg);
			}
			array[num29] = BindUnity.<>f__mg$cache1C;
			int num30 = 29;
			if (BindUnity.<>f__mg$cache1D == null)
			{
				BindUnity.<>f__mg$cache1D = new Action<IntPtr>(Lua_UnityEngine_ComputeBuffer.reg);
			}
			array[num30] = BindUnity.<>f__mg$cache1D;
			int num31 = 30;
			if (BindUnity.<>f__mg$cache1E == null)
			{
				BindUnity.<>f__mg$cache1E = new Action<IntPtr>(Lua_UnityEngine_CrashReport.reg);
			}
			array[num31] = BindUnity.<>f__mg$cache1E;
			int num32 = 31;
			if (BindUnity.<>f__mg$cache1F == null)
			{
				BindUnity.<>f__mg$cache1F = new Action<IntPtr>(Lua_UnityEngine_BoundingSphere.reg);
			}
			array[num32] = BindUnity.<>f__mg$cache1F;
			int num33 = 32;
			if (BindUnity.<>f__mg$cache20 == null)
			{
				BindUnity.<>f__mg$cache20 = new Action<IntPtr>(Lua_UnityEngine_CullingGroupEvent.reg);
			}
			array[num33] = BindUnity.<>f__mg$cache20;
			int num34 = 33;
			if (BindUnity.<>f__mg$cache21 == null)
			{
				BindUnity.<>f__mg$cache21 = new Action<IntPtr>(Lua_UnityEngine_CullingGroup.reg);
			}
			array[num34] = BindUnity.<>f__mg$cache21;
			int num35 = 34;
			if (BindUnity.<>f__mg$cache22 == null)
			{
				BindUnity.<>f__mg$cache22 = new Action<IntPtr>(Lua_UnityEngine_Debug.reg);
			}
			array[num35] = BindUnity.<>f__mg$cache22;
			int num36 = 35;
			if (BindUnity.<>f__mg$cache23 == null)
			{
				BindUnity.<>f__mg$cache23 = new Action<IntPtr>(Lua_UnityEngine_Display.reg);
			}
			array[num36] = BindUnity.<>f__mg$cache23;
			int num37 = 36;
			if (BindUnity.<>f__mg$cache24 == null)
			{
				BindUnity.<>f__mg$cache24 = new Action<IntPtr>(Lua_UnityEngine_ExposedPropertyResolver.reg);
			}
			array[num37] = BindUnity.<>f__mg$cache24;
			int num38 = 37;
			if (BindUnity.<>f__mg$cache25 == null)
			{
				BindUnity.<>f__mg$cache25 = new Action<IntPtr>(Lua_UnityEngine_FlareLayer.reg);
			}
			array[num38] = BindUnity.<>f__mg$cache25;
			int num39 = 38;
			if (BindUnity.<>f__mg$cache26 == null)
			{
				BindUnity.<>f__mg$cache26 = new Action<IntPtr>(Lua_UnityEngine_GameObject.reg);
			}
			array[num39] = BindUnity.<>f__mg$cache26;
			int num40 = 39;
			if (BindUnity.<>f__mg$cache27 == null)
			{
				BindUnity.<>f__mg$cache27 = new Action<IntPtr>(Lua_UnityEngine_Rendering_SynchronisationStage.reg);
			}
			array[num40] = BindUnity.<>f__mg$cache27;
			int num41 = 40;
			if (BindUnity.<>f__mg$cache28 == null)
			{
				BindUnity.<>f__mg$cache28 = new Action<IntPtr>(Lua_UnityEngine_Rendering_GPUFence.reg);
			}
			array[num41] = BindUnity.<>f__mg$cache28;
			int num42 = 41;
			if (BindUnity.<>f__mg$cache29 == null)
			{
				BindUnity.<>f__mg$cache29 = new Action<IntPtr>(Lua_UnityEngine_GradientColorKey.reg);
			}
			array[num42] = BindUnity.<>f__mg$cache29;
			int num43 = 42;
			if (BindUnity.<>f__mg$cache2A == null)
			{
				BindUnity.<>f__mg$cache2A = new Action<IntPtr>(Lua_UnityEngine_GradientAlphaKey.reg);
			}
			array[num43] = BindUnity.<>f__mg$cache2A;
			int num44 = 43;
			if (BindUnity.<>f__mg$cache2B == null)
			{
				BindUnity.<>f__mg$cache2B = new Action<IntPtr>(Lua_UnityEngine_GradientMode.reg);
			}
			array[num44] = BindUnity.<>f__mg$cache2B;
			int num45 = 44;
			if (BindUnity.<>f__mg$cache2C == null)
			{
				BindUnity.<>f__mg$cache2C = new Action<IntPtr>(Lua_UnityEngine_Gradient.reg);
			}
			array[num45] = BindUnity.<>f__mg$cache2C;
			int num46 = 45;
			if (BindUnity.<>f__mg$cache2D == null)
			{
				BindUnity.<>f__mg$cache2D = new Action<IntPtr>(Lua_UnityEngine_RenderSettings.reg);
			}
			array[num46] = BindUnity.<>f__mg$cache2D;
			int num47 = 46;
			if (BindUnity.<>f__mg$cache2E == null)
			{
				BindUnity.<>f__mg$cache2E = new Action<IntPtr>(Lua_UnityEngine_QualitySettings.reg);
			}
			array[num47] = BindUnity.<>f__mg$cache2E;
			int num48 = 47;
			if (BindUnity.<>f__mg$cache2F == null)
			{
				BindUnity.<>f__mg$cache2F = new Action<IntPtr>(Lua_UnityEngine_SkinnedMeshRenderer.reg);
			}
			array[num48] = BindUnity.<>f__mg$cache2F;
			int num49 = 48;
			if (BindUnity.<>f__mg$cache30 == null)
			{
				BindUnity.<>f__mg$cache30 = new Action<IntPtr>(Lua_UnityEngine_RendererExtensions.reg);
			}
			array[num49] = BindUnity.<>f__mg$cache30;
			int num50 = 49;
			if (BindUnity.<>f__mg$cache31 == null)
			{
				BindUnity.<>f__mg$cache31 = new Action<IntPtr>(Lua_UnityEngine_TrailRenderer.reg);
			}
			array[num50] = BindUnity.<>f__mg$cache31;
			int num51 = 50;
			if (BindUnity.<>f__mg$cache32 == null)
			{
				BindUnity.<>f__mg$cache32 = new Action<IntPtr>(Lua_UnityEngine_LineRenderer.reg);
			}
			array[num51] = BindUnity.<>f__mg$cache32;
			int num52 = 51;
			if (BindUnity.<>f__mg$cache33 == null)
			{
				BindUnity.<>f__mg$cache33 = new Action<IntPtr>(Lua_UnityEngine_MaterialPropertyBlock.reg);
			}
			array[num52] = BindUnity.<>f__mg$cache33;
			int num53 = 52;
			if (BindUnity.<>f__mg$cache34 == null)
			{
				BindUnity.<>f__mg$cache34 = new Action<IntPtr>(Lua_UnityEngine_Graphics.reg);
			}
			array[num53] = BindUnity.<>f__mg$cache34;
			int num54 = 53;
			if (BindUnity.<>f__mg$cache35 == null)
			{
				BindUnity.<>f__mg$cache35 = new Action<IntPtr>(Lua_UnityEngine_LightProbes.reg);
			}
			array[num54] = BindUnity.<>f__mg$cache35;
			int num55 = 54;
			if (BindUnity.<>f__mg$cache36 == null)
			{
				BindUnity.<>f__mg$cache36 = new Action<IntPtr>(Lua_UnityEngine_LightmapSettings.reg);
			}
			array[num55] = BindUnity.<>f__mg$cache36;
			int num56 = 55;
			if (BindUnity.<>f__mg$cache37 == null)
			{
				BindUnity.<>f__mg$cache37 = new Action<IntPtr>(Lua_UnityEngine_Screen.reg);
			}
			array[num56] = BindUnity.<>f__mg$cache37;
			int num57 = 56;
			if (BindUnity.<>f__mg$cache38 == null)
			{
				BindUnity.<>f__mg$cache38 = new Action<IntPtr>(Lua_UnityEngine_RectOffset.reg);
			}
			array[num57] = BindUnity.<>f__mg$cache38;
			int num58 = 57;
			if (BindUnity.<>f__mg$cache39 == null)
			{
				BindUnity.<>f__mg$cache39 = new Action<IntPtr>(Lua_UnityEngine_TouchPhase.reg);
			}
			array[num58] = BindUnity.<>f__mg$cache39;
			int num59 = 58;
			if (BindUnity.<>f__mg$cache3A == null)
			{
				BindUnity.<>f__mg$cache3A = new Action<IntPtr>(Lua_UnityEngine_IMECompositionMode.reg);
			}
			array[num59] = BindUnity.<>f__mg$cache3A;
			int num60 = 59;
			if (BindUnity.<>f__mg$cache3B == null)
			{
				BindUnity.<>f__mg$cache3B = new Action<IntPtr>(Lua_UnityEngine_TouchType.reg);
			}
			array[num60] = BindUnity.<>f__mg$cache3B;
			int num61 = 60;
			if (BindUnity.<>f__mg$cache3C == null)
			{
				BindUnity.<>f__mg$cache3C = new Action<IntPtr>(Lua_UnityEngine_Touch.reg);
			}
			array[num61] = BindUnity.<>f__mg$cache3C;
			int num62 = 61;
			if (BindUnity.<>f__mg$cache3D == null)
			{
				BindUnity.<>f__mg$cache3D = new Action<IntPtr>(Lua_UnityEngine_DeviceOrientation.reg);
			}
			array[num62] = BindUnity.<>f__mg$cache3D;
			int num63 = 62;
			if (BindUnity.<>f__mg$cache3E == null)
			{
				BindUnity.<>f__mg$cache3E = new Action<IntPtr>(Lua_UnityEngine_AccelerationEvent.reg);
			}
			array[num63] = BindUnity.<>f__mg$cache3E;
			int num64 = 63;
			if (BindUnity.<>f__mg$cache3F == null)
			{
				BindUnity.<>f__mg$cache3F = new Action<IntPtr>(Lua_UnityEngine_Gyroscope.reg);
			}
			array[num64] = BindUnity.<>f__mg$cache3F;
			int num65 = 64;
			if (BindUnity.<>f__mg$cache40 == null)
			{
				BindUnity.<>f__mg$cache40 = new Action<IntPtr>(Lua_UnityEngine_LocationInfo.reg);
			}
			array[num65] = BindUnity.<>f__mg$cache40;
			int num66 = 65;
			if (BindUnity.<>f__mg$cache41 == null)
			{
				BindUnity.<>f__mg$cache41 = new Action<IntPtr>(Lua_UnityEngine_LocationServiceStatus.reg);
			}
			array[num66] = BindUnity.<>f__mg$cache41;
			int num67 = 66;
			if (BindUnity.<>f__mg$cache42 == null)
			{
				BindUnity.<>f__mg$cache42 = new Action<IntPtr>(Lua_UnityEngine_LocationService.reg);
			}
			array[num67] = BindUnity.<>f__mg$cache42;
			int num68 = 67;
			if (BindUnity.<>f__mg$cache43 == null)
			{
				BindUnity.<>f__mg$cache43 = new Action<IntPtr>(Lua_UnityEngine_Compass.reg);
			}
			array[num68] = BindUnity.<>f__mg$cache43;
			int num69 = 68;
			if (BindUnity.<>f__mg$cache44 == null)
			{
				BindUnity.<>f__mg$cache44 = new Action<IntPtr>(Lua_UnityEngine_Input.reg);
			}
			array[num69] = BindUnity.<>f__mg$cache44;
			int num70 = 69;
			if (BindUnity.<>f__mg$cache45 == null)
			{
				BindUnity.<>f__mg$cache45 = new Action<IntPtr>(Lua_UnityEngine_LayerMask.reg);
			}
			array[num70] = BindUnity.<>f__mg$cache45;
			int num71 = 70;
			if (BindUnity.<>f__mg$cache46 == null)
			{
				BindUnity.<>f__mg$cache46 = new Action<IntPtr>(Lua_UnityEngine_Light.reg);
			}
			array[num71] = BindUnity.<>f__mg$cache46;
			int num72 = 71;
			if (BindUnity.<>f__mg$cache47 == null)
			{
				BindUnity.<>f__mg$cache47 = new Action<IntPtr>(Lua_UnityEngine_LightProbeGroup.reg);
			}
			array[num72] = BindUnity.<>f__mg$cache47;
			int num73 = 72;
			if (BindUnity.<>f__mg$cache48 == null)
			{
				BindUnity.<>f__mg$cache48 = new Action<IntPtr>(Lua_UnityEngine_LightProbeProxyVolume.reg);
			}
			array[num73] = BindUnity.<>f__mg$cache48;
			int num74 = 73;
			if (BindUnity.<>f__mg$cache49 == null)
			{
				BindUnity.<>f__mg$cache49 = new Action<IntPtr>(Lua_UnityEngine_LightProbeProxyVolume_ResolutionMode.reg);
			}
			array[num74] = BindUnity.<>f__mg$cache49;
			int num75 = 74;
			if (BindUnity.<>f__mg$cache4A == null)
			{
				BindUnity.<>f__mg$cache4A = new Action<IntPtr>(Lua_UnityEngine_LightProbeProxyVolume_BoundingBoxMode.reg);
			}
			array[num75] = BindUnity.<>f__mg$cache4A;
			int num76 = 75;
			if (BindUnity.<>f__mg$cache4B == null)
			{
				BindUnity.<>f__mg$cache4B = new Action<IntPtr>(Lua_UnityEngine_LightProbeProxyVolume_ProbePositionMode.reg);
			}
			array[num76] = BindUnity.<>f__mg$cache4B;
			int num77 = 76;
			if (BindUnity.<>f__mg$cache4C == null)
			{
				BindUnity.<>f__mg$cache4C = new Action<IntPtr>(Lua_UnityEngine_LightProbeProxyVolume_RefreshMode.reg);
			}
			array[num77] = BindUnity.<>f__mg$cache4C;
			int num78 = 77;
			if (BindUnity.<>f__mg$cache4D == null)
			{
				BindUnity.<>f__mg$cache4D = new Action<IntPtr>(Lua_UnityEngine_LineUtility.reg);
			}
			array[num78] = BindUnity.<>f__mg$cache4D;
			int num79 = 78;
			if (BindUnity.<>f__mg$cache4E == null)
			{
				BindUnity.<>f__mg$cache4E = new Action<IntPtr>(Lua_UnityEngine_LODFadeMode.reg);
			}
			array[num79] = BindUnity.<>f__mg$cache4E;
			int num80 = 79;
			if (BindUnity.<>f__mg$cache4F == null)
			{
				BindUnity.<>f__mg$cache4F = new Action<IntPtr>(Lua_UnityEngine_LOD.reg);
			}
			array[num80] = BindUnity.<>f__mg$cache4F;
			int num81 = 80;
			if (BindUnity.<>f__mg$cache50 == null)
			{
				BindUnity.<>f__mg$cache50 = new Action<IntPtr>(Lua_UnityEngine_LODGroup.reg);
			}
			array[num81] = BindUnity.<>f__mg$cache50;
			int num82 = 81;
			if (BindUnity.<>f__mg$cache51 == null)
			{
				BindUnity.<>f__mg$cache51 = new Action<IntPtr>(Lua_UnityEngine_Vector3.reg);
			}
			array[num82] = BindUnity.<>f__mg$cache51;
			int num83 = 82;
			if (BindUnity.<>f__mg$cache52 == null)
			{
				BindUnity.<>f__mg$cache52 = new Action<IntPtr>(Lua_UnityEngine_Quaternion.reg);
			}
			array[num83] = BindUnity.<>f__mg$cache52;
			int num84 = 83;
			if (BindUnity.<>f__mg$cache53 == null)
			{
				BindUnity.<>f__mg$cache53 = new Action<IntPtr>(Lua_UnityEngine_FrustumPlanes.reg);
			}
			array[num84] = BindUnity.<>f__mg$cache53;
			int num85 = 84;
			if (BindUnity.<>f__mg$cache54 == null)
			{
				BindUnity.<>f__mg$cache54 = new Action<IntPtr>(Lua_UnityEngine_Matrix4x4.reg);
			}
			array[num85] = BindUnity.<>f__mg$cache54;
			int num86 = 85;
			if (BindUnity.<>f__mg$cache55 == null)
			{
				BindUnity.<>f__mg$cache55 = new Action<IntPtr>(Lua_UnityEngine_Bounds.reg);
			}
			array[num86] = BindUnity.<>f__mg$cache55;
			int num87 = 86;
			if (BindUnity.<>f__mg$cache56 == null)
			{
				BindUnity.<>f__mg$cache56 = new Action<IntPtr>(Lua_UnityEngine_Mathf.reg);
			}
			array[num87] = BindUnity.<>f__mg$cache56;
			int num88 = 87;
			if (BindUnity.<>f__mg$cache57 == null)
			{
				BindUnity.<>f__mg$cache57 = new Action<IntPtr>(Lua_UnityEngine_Keyframe.reg);
			}
			array[num88] = BindUnity.<>f__mg$cache57;
			int num89 = 88;
			if (BindUnity.<>f__mg$cache58 == null)
			{
				BindUnity.<>f__mg$cache58 = new Action<IntPtr>(Lua_UnityEngine_WrapMode.reg);
			}
			array[num89] = BindUnity.<>f__mg$cache58;
			int num90 = 89;
			if (BindUnity.<>f__mg$cache59 == null)
			{
				BindUnity.<>f__mg$cache59 = new Action<IntPtr>(Lua_UnityEngine_AnimationCurve.reg);
			}
			array[num90] = BindUnity.<>f__mg$cache59;
			int num91 = 90;
			if (BindUnity.<>f__mg$cache5A == null)
			{
				BindUnity.<>f__mg$cache5A = new Action<IntPtr>(Lua_UnityEngine_MonoBehaviour.reg);
			}
			array[num91] = BindUnity.<>f__mg$cache5A;
			int num92 = 91;
			if (BindUnity.<>f__mg$cache5B == null)
			{
				BindUnity.<>f__mg$cache5B = new Action<IntPtr>(Lua_UnityEngine_Diagnostics_PlayerConnection.reg);
			}
			array[num92] = BindUnity.<>f__mg$cache5B;
			int num93 = 92;
			if (BindUnity.<>f__mg$cache5C == null)
			{
				BindUnity.<>f__mg$cache5C = new Action<IntPtr>(Lua_UnityEngine_PlayerPrefsException.reg);
			}
			array[num93] = BindUnity.<>f__mg$cache5C;
			int num94 = 93;
			if (BindUnity.<>f__mg$cache5D == null)
			{
				BindUnity.<>f__mg$cache5D = new Action<IntPtr>(Lua_UnityEngine_PlayerPrefs.reg);
			}
			array[num94] = BindUnity.<>f__mg$cache5D;
			int num95 = 94;
			if (BindUnity.<>f__mg$cache5E == null)
			{
				BindUnity.<>f__mg$cache5E = new Action<IntPtr>(Lua_UnityEngine_Random.reg);
			}
			array[num95] = BindUnity.<>f__mg$cache5E;
			int num96 = 95;
			if (BindUnity.<>f__mg$cache5F == null)
			{
				BindUnity.<>f__mg$cache5F = new Action<IntPtr>(Lua_UnityEngine_Random_State.reg);
			}
			array[num96] = BindUnity.<>f__mg$cache5F;
			int num97 = 96;
			if (BindUnity.<>f__mg$cache60 == null)
			{
				BindUnity.<>f__mg$cache60 = new Action<IntPtr>(Lua_UnityEngine_ReflectionProbe.reg);
			}
			array[num97] = BindUnity.<>f__mg$cache60;
			int num98 = 97;
			if (BindUnity.<>f__mg$cache61 == null)
			{
				BindUnity.<>f__mg$cache61 = new Action<IntPtr>(Lua_UnityEngine_Rendering_GraphicsSettings.reg);
			}
			array[num98] = BindUnity.<>f__mg$cache61;
			int num99 = 98;
			if (BindUnity.<>f__mg$cache62 == null)
			{
				BindUnity.<>f__mg$cache62 = new Action<IntPtr>(Lua_UnityEngine_Rendering_ComputeQueueType.reg);
			}
			array[num99] = BindUnity.<>f__mg$cache62;
			int num100 = 99;
			if (BindUnity.<>f__mg$cache63 == null)
			{
				BindUnity.<>f__mg$cache63 = new Action<IntPtr>(Lua_UnityEngine_Rendering_CommandBuffer.reg);
			}
			array[num100] = BindUnity.<>f__mg$cache63;
			int num101 = 100;
			if (BindUnity.<>f__mg$cache64 == null)
			{
				BindUnity.<>f__mg$cache64 = new Action<IntPtr>(Lua_UnityEngine_ResourceRequest.reg);
			}
			array[num101] = BindUnity.<>f__mg$cache64;
			int num102 = 101;
			if (BindUnity.<>f__mg$cache65 == null)
			{
				BindUnity.<>f__mg$cache65 = new Action<IntPtr>(Lua_UnityEngine_Resources.reg);
			}
			array[num102] = BindUnity.<>f__mg$cache65;
			int num103 = 102;
			if (BindUnity.<>f__mg$cache66 == null)
			{
				BindUnity.<>f__mg$cache66 = new Action<IntPtr>(Lua_UnityEngine_Security.reg);
			}
			array[num103] = BindUnity.<>f__mg$cache66;
			int num104 = 103;
			if (BindUnity.<>f__mg$cache67 == null)
			{
				BindUnity.<>f__mg$cache67 = new Action<IntPtr>(Lua_UnityEngine_Shader.reg);
			}
			array[num104] = BindUnity.<>f__mg$cache67;
			int num105 = 104;
			if (BindUnity.<>f__mg$cache68 == null)
			{
				BindUnity.<>f__mg$cache68 = new Action<IntPtr>(Lua_UnityEngine_Material.reg);
			}
			array[num105] = BindUnity.<>f__mg$cache68;
			int num106 = 105;
			if (BindUnity.<>f__mg$cache69 == null)
			{
				BindUnity.<>f__mg$cache69 = new Action<IntPtr>(Lua_UnityEngine_SortingLayer.reg);
			}
			array[num106] = BindUnity.<>f__mg$cache69;
			int num107 = 106;
			if (BindUnity.<>f__mg$cache6A == null)
			{
				BindUnity.<>f__mg$cache6A = new Action<IntPtr>(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.reg);
			}
			array[num107] = BindUnity.<>f__mg$cache6A;
			int num108 = 107;
			if (BindUnity.<>f__mg$cache6B == null)
			{
				BindUnity.<>f__mg$cache6B = new Action<IntPtr>(Lua_UnityEngine_Rendering_SplashScreen.reg);
			}
			array[num108] = BindUnity.<>f__mg$cache6B;
			int num109 = 108;
			if (BindUnity.<>f__mg$cache6C == null)
			{
				BindUnity.<>f__mg$cache6C = new Action<IntPtr>(Lua_UnityEngine_SpriteAlignment.reg);
			}
			array[num109] = BindUnity.<>f__mg$cache6C;
			int num110 = 109;
			if (BindUnity.<>f__mg$cache6D == null)
			{
				BindUnity.<>f__mg$cache6D = new Action<IntPtr>(Lua_UnityEngine_SpritePackingMode.reg);
			}
			array[num110] = BindUnity.<>f__mg$cache6D;
			int num111 = 110;
			if (BindUnity.<>f__mg$cache6E == null)
			{
				BindUnity.<>f__mg$cache6E = new Action<IntPtr>(Lua_UnityEngine_SpritePackingRotation.reg);
			}
			array[num111] = BindUnity.<>f__mg$cache6E;
			int num112 = 111;
			if (BindUnity.<>f__mg$cache6F == null)
			{
				BindUnity.<>f__mg$cache6F = new Action<IntPtr>(Lua_UnityEngine_SpriteMeshType.reg);
			}
			array[num112] = BindUnity.<>f__mg$cache6F;
			int num113 = 112;
			if (BindUnity.<>f__mg$cache70 == null)
			{
				BindUnity.<>f__mg$cache70 = new Action<IntPtr>(Lua_UnityEngine_SpriteDrawMode.reg);
			}
			array[num113] = BindUnity.<>f__mg$cache70;
			int num114 = 113;
			if (BindUnity.<>f__mg$cache71 == null)
			{
				BindUnity.<>f__mg$cache71 = new Action<IntPtr>(Lua_UnityEngine_SpriteTileMode.reg);
			}
			array[num114] = BindUnity.<>f__mg$cache71;
			int num115 = 114;
			if (BindUnity.<>f__mg$cache72 == null)
			{
				BindUnity.<>f__mg$cache72 = new Action<IntPtr>(Lua_UnityEngine_SpriteMaskInteraction.reg);
			}
			array[num115] = BindUnity.<>f__mg$cache72;
			int num116 = 115;
			if (BindUnity.<>f__mg$cache73 == null)
			{
				BindUnity.<>f__mg$cache73 = new Action<IntPtr>(Lua_UnityEngine_Sprite.reg);
			}
			array[num116] = BindUnity.<>f__mg$cache73;
			int num117 = 116;
			if (BindUnity.<>f__mg$cache74 == null)
			{
				BindUnity.<>f__mg$cache74 = new Action<IntPtr>(Lua_UnityEngine_SpriteRenderer.reg);
			}
			array[num117] = BindUnity.<>f__mg$cache74;
			int num118 = 117;
			if (BindUnity.<>f__mg$cache75 == null)
			{
				BindUnity.<>f__mg$cache75 = new Action<IntPtr>(Lua_UnityEngine_Sprites_DataUtility.reg);
			}
			array[num118] = BindUnity.<>f__mg$cache75;
			int num119 = 118;
			if (BindUnity.<>f__mg$cache76 == null)
			{
				BindUnity.<>f__mg$cache76 = new Action<IntPtr>(Lua_UnityEngine_TextAsset.reg);
			}
			array[num119] = BindUnity.<>f__mg$cache76;
			int num120 = 119;
			if (BindUnity.<>f__mg$cache77 == null)
			{
				BindUnity.<>f__mg$cache77 = new Action<IntPtr>(Lua_UnityEngine_Texture.reg);
			}
			array[num120] = BindUnity.<>f__mg$cache77;
			int num121 = 120;
			if (BindUnity.<>f__mg$cache78 == null)
			{
				BindUnity.<>f__mg$cache78 = new Action<IntPtr>(Lua_UnityEngine_Texture2D.reg);
			}
			array[num121] = BindUnity.<>f__mg$cache78;
			int num122 = 121;
			if (BindUnity.<>f__mg$cache79 == null)
			{
				BindUnity.<>f__mg$cache79 = new Action<IntPtr>(Lua_UnityEngine_Texture2D_EXRFlags.reg);
			}
			array[num122] = BindUnity.<>f__mg$cache79;
			int num123 = 122;
			if (BindUnity.<>f__mg$cache7A == null)
			{
				BindUnity.<>f__mg$cache7A = new Action<IntPtr>(Lua_UnityEngine_Cubemap.reg);
			}
			array[num123] = BindUnity.<>f__mg$cache7A;
			int num124 = 123;
			if (BindUnity.<>f__mg$cache7B == null)
			{
				BindUnity.<>f__mg$cache7B = new Action<IntPtr>(Lua_UnityEngine_Texture3D.reg);
			}
			array[num124] = BindUnity.<>f__mg$cache7B;
			int num125 = 124;
			if (BindUnity.<>f__mg$cache7C == null)
			{
				BindUnity.<>f__mg$cache7C = new Action<IntPtr>(Lua_UnityEngine_Texture2DArray.reg);
			}
			array[num125] = BindUnity.<>f__mg$cache7C;
			int num126 = 125;
			if (BindUnity.<>f__mg$cache7D == null)
			{
				BindUnity.<>f__mg$cache7D = new Action<IntPtr>(Lua_UnityEngine_CubemapArray.reg);
			}
			array[num126] = BindUnity.<>f__mg$cache7D;
			int num127 = 126;
			if (BindUnity.<>f__mg$cache7E == null)
			{
				BindUnity.<>f__mg$cache7E = new Action<IntPtr>(Lua_UnityEngine_SparseTexture.reg);
			}
			array[num127] = BindUnity.<>f__mg$cache7E;
			int num128 = 127;
			if (BindUnity.<>f__mg$cache7F == null)
			{
				BindUnity.<>f__mg$cache7F = new Action<IntPtr>(Lua_UnityEngine_RenderTexture.reg);
			}
			array[num128] = BindUnity.<>f__mg$cache7F;
			int num129 = 128;
			if (BindUnity.<>f__mg$cache80 == null)
			{
				BindUnity.<>f__mg$cache80 = new Action<IntPtr>(Lua_UnityEngine_CustomRenderTextureUpdateZone.reg);
			}
			array[num129] = BindUnity.<>f__mg$cache80;
			int num130 = 129;
			if (BindUnity.<>f__mg$cache81 == null)
			{
				BindUnity.<>f__mg$cache81 = new Action<IntPtr>(Lua_UnityEngine_CustomRenderTexture.reg);
			}
			array[num130] = BindUnity.<>f__mg$cache81;
			int num131 = 130;
			if (BindUnity.<>f__mg$cache82 == null)
			{
				BindUnity.<>f__mg$cache82 = new Action<IntPtr>(Lua_UnityEngine_Time.reg);
			}
			array[num131] = BindUnity.<>f__mg$cache82;
			int num132 = 131;
			if (BindUnity.<>f__mg$cache83 == null)
			{
				BindUnity.<>f__mg$cache83 = new Action<IntPtr>(Lua_UnityEngine_HideFlags.reg);
			}
			array[num132] = BindUnity.<>f__mg$cache83;
			int num133 = 132;
			if (BindUnity.<>f__mg$cache84 == null)
			{
				BindUnity.<>f__mg$cache84 = new Action<IntPtr>(Lua_UnityEngine_Hash128.reg);
			}
			array[num133] = BindUnity.<>f__mg$cache84;
			int num134 = 133;
			if (BindUnity.<>f__mg$cache85 == null)
			{
				BindUnity.<>f__mg$cache85 = new Action<IntPtr>(Lua_UnityEngine_AudioType.reg);
			}
			array[num134] = BindUnity.<>f__mg$cache85;
			int num135 = 134;
			if (BindUnity.<>f__mg$cache86 == null)
			{
				BindUnity.<>f__mg$cache86 = new Action<IntPtr>(Lua_UnityEngine_UnityEventQueueSystem.reg);
			}
			array[num135] = BindUnity.<>f__mg$cache86;
			int num136 = 135;
			if (BindUnity.<>f__mg$cache87 == null)
			{
				BindUnity.<>f__mg$cache87 = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableOutputHandle.reg);
			}
			array[num136] = BindUnity.<>f__mg$cache87;
			int num137 = 136;
			if (BindUnity.<>f__mg$cache88 == null)
			{
				BindUnity.<>f__mg$cache88 = new Action<IntPtr>(Lua_UnityEngine_DynamicGI.reg);
			}
			array[num137] = BindUnity.<>f__mg$cache88;
			int num138 = 137;
			if (BindUnity.<>f__mg$cache89 == null)
			{
				BindUnity.<>f__mg$cache89 = new Action<IntPtr>(Lua_UnityEngine_SceneManagement_Scene.reg);
			}
			array[num138] = BindUnity.<>f__mg$cache89;
			int num139 = 138;
			if (BindUnity.<>f__mg$cache8A == null)
			{
				BindUnity.<>f__mg$cache8A = new Action<IntPtr>(Lua_UnityEngine_SceneManagement_LoadSceneMode.reg);
			}
			array[num139] = BindUnity.<>f__mg$cache8A;
			int num140 = 139;
			if (BindUnity.<>f__mg$cache8B == null)
			{
				BindUnity.<>f__mg$cache8B = new Action<IntPtr>(Lua_UnityEngine_SceneManagement_SceneManager.reg);
			}
			array[num140] = BindUnity.<>f__mg$cache8B;
			int num141 = 140;
			if (BindUnity.<>f__mg$cache8C == null)
			{
				BindUnity.<>f__mg$cache8C = new Action<IntPtr>(Lua_UnityEngine_SceneManagement_SceneUtility.reg);
			}
			array[num141] = BindUnity.<>f__mg$cache8C;
			int num142 = 141;
			if (BindUnity.<>f__mg$cache8D == null)
			{
				BindUnity.<>f__mg$cache8D = new Action<IntPtr>(Lua_UnityEngine_Profiling_Profiler.reg);
			}
			array[num142] = BindUnity.<>f__mg$cache8D;
			int num143 = 142;
			if (BindUnity.<>f__mg$cache8E == null)
			{
				BindUnity.<>f__mg$cache8E = new Action<IntPtr>(Lua_UnityEngine_Profiling_Recorder.reg);
			}
			array[num143] = BindUnity.<>f__mg$cache8E;
			int num144 = 143;
			if (BindUnity.<>f__mg$cache8F == null)
			{
				BindUnity.<>f__mg$cache8F = new Action<IntPtr>(Lua_UnityEngine_Profiling_Sampler.reg);
			}
			array[num144] = BindUnity.<>f__mg$cache8F;
			int num145 = 144;
			if (BindUnity.<>f__mg$cache90 == null)
			{
				BindUnity.<>f__mg$cache90 = new Action<IntPtr>(Lua_UnityEngine_Profiling_CustomSampler.reg);
			}
			array[num145] = BindUnity.<>f__mg$cache90;
			int num146 = 145;
			if (BindUnity.<>f__mg$cache91 == null)
			{
				BindUnity.<>f__mg$cache91 = new Action<IntPtr>(Lua_UnityEngine_Transform.reg);
			}
			array[num146] = BindUnity.<>f__mg$cache91;
			int num147 = 146;
			if (BindUnity.<>f__mg$cache92 == null)
			{
				BindUnity.<>f__mg$cache92 = new Action<IntPtr>(Lua_UnityEngine_DrivenTransformProperties.reg);
			}
			array[num147] = BindUnity.<>f__mg$cache92;
			int num148 = 147;
			if (BindUnity.<>f__mg$cache93 == null)
			{
				BindUnity.<>f__mg$cache93 = new Action<IntPtr>(Lua_UnityEngine_DrivenRectTransformTracker.reg);
			}
			array[num148] = BindUnity.<>f__mg$cache93;
			int num149 = 148;
			if (BindUnity.<>f__mg$cache94 == null)
			{
				BindUnity.<>f__mg$cache94 = new Action<IntPtr>(Lua_UnityEngine_RectTransform.reg);
			}
			array[num149] = BindUnity.<>f__mg$cache94;
			int num150 = 149;
			if (BindUnity.<>f__mg$cache95 == null)
			{
				BindUnity.<>f__mg$cache95 = new Action<IntPtr>(Lua_UnityEngine_RectTransform_Edge.reg);
			}
			array[num150] = BindUnity.<>f__mg$cache95;
			int num151 = 150;
			if (BindUnity.<>f__mg$cache96 == null)
			{
				BindUnity.<>f__mg$cache96 = new Action<IntPtr>(Lua_UnityEngine_RectTransform_Axis.reg);
			}
			array[num151] = BindUnity.<>f__mg$cache96;
			int num152 = 151;
			if (BindUnity.<>f__mg$cache97 == null)
			{
				BindUnity.<>f__mg$cache97 = new Action<IntPtr>(Lua_UnityEngine_U2D_SpriteAtlasManager.reg);
			}
			array[num152] = BindUnity.<>f__mg$cache97;
			int num153 = 152;
			if (BindUnity.<>f__mg$cache98 == null)
			{
				BindUnity.<>f__mg$cache98 = new Action<IntPtr>(Lua_UnityEngine_U2D_SpriteAtlas.reg);
			}
			array[num153] = BindUnity.<>f__mg$cache98;
			int num154 = 153;
			if (BindUnity.<>f__mg$cache99 == null)
			{
				BindUnity.<>f__mg$cache99 = new Action<IntPtr>(Lua_UnityEngine_Rendering_SortingGroup.reg);
			}
			array[num154] = BindUnity.<>f__mg$cache99;
			int num155 = 154;
			if (BindUnity.<>f__mg$cache9A == null)
			{
				BindUnity.<>f__mg$cache9A = new Action<IntPtr>(Lua_UnityEngine_StackTraceLogType.reg);
			}
			array[num155] = BindUnity.<>f__mg$cache9A;
			int num156 = 155;
			if (BindUnity.<>f__mg$cache9B == null)
			{
				BindUnity.<>f__mg$cache9B = new Action<IntPtr>(Lua_UnityEngine_DefaultExecutionOrder.reg);
			}
			array[num156] = BindUnity.<>f__mg$cache9B;
			int num157 = 156;
			if (BindUnity.<>f__mg$cache9C == null)
			{
				BindUnity.<>f__mg$cache9C = new Action<IntPtr>(Lua_UnityEngine_SendMessageOptions.reg);
			}
			array[num157] = BindUnity.<>f__mg$cache9C;
			int num158 = 157;
			if (BindUnity.<>f__mg$cache9D == null)
			{
				BindUnity.<>f__mg$cache9D = new Action<IntPtr>(Lua_UnityEngine_PrimitiveType.reg);
			}
			array[num158] = BindUnity.<>f__mg$cache9D;
			int num159 = 158;
			if (BindUnity.<>f__mg$cache9E == null)
			{
				BindUnity.<>f__mg$cache9E = new Action<IntPtr>(Lua_UnityEngine_Space.reg);
			}
			array[num159] = BindUnity.<>f__mg$cache9E;
			int num160 = 159;
			if (BindUnity.<>f__mg$cache9F == null)
			{
				BindUnity.<>f__mg$cache9F = new Action<IntPtr>(Lua_UnityEngine_RuntimePlatform.reg);
			}
			array[num160] = BindUnity.<>f__mg$cache9F;
			int num161 = 160;
			if (BindUnity.<>f__mg$cacheA0 == null)
			{
				BindUnity.<>f__mg$cacheA0 = new Action<IntPtr>(Lua_UnityEngine_OperatingSystemFamily.reg);
			}
			array[num161] = BindUnity.<>f__mg$cacheA0;
			int num162 = 161;
			if (BindUnity.<>f__mg$cacheA1 == null)
			{
				BindUnity.<>f__mg$cacheA1 = new Action<IntPtr>(Lua_UnityEngine_SystemLanguage.reg);
			}
			array[num162] = BindUnity.<>f__mg$cacheA1;
			int num163 = 162;
			if (BindUnity.<>f__mg$cacheA2 == null)
			{
				BindUnity.<>f__mg$cacheA2 = new Action<IntPtr>(Lua_UnityEngine_LogType.reg);
			}
			array[num163] = BindUnity.<>f__mg$cacheA2;
			int num164 = 163;
			if (BindUnity.<>f__mg$cacheA3 == null)
			{
				BindUnity.<>f__mg$cacheA3 = new Action<IntPtr>(Lua_UnityEngine_DeviceType.reg);
			}
			array[num164] = BindUnity.<>f__mg$cacheA3;
			int num165 = 164;
			if (BindUnity.<>f__mg$cacheA4 == null)
			{
				BindUnity.<>f__mg$cacheA4 = new Action<IntPtr>(Lua_UnityEngine_BatteryStatus.reg);
			}
			array[num165] = BindUnity.<>f__mg$cacheA4;
			int num166 = 165;
			if (BindUnity.<>f__mg$cacheA5 == null)
			{
				BindUnity.<>f__mg$cacheA5 = new Action<IntPtr>(Lua_UnityEngine_ThreadPriority.reg);
			}
			array[num166] = BindUnity.<>f__mg$cacheA5;
			int num167 = 166;
			if (BindUnity.<>f__mg$cacheA6 == null)
			{
				BindUnity.<>f__mg$cacheA6 = new Action<IntPtr>(Lua_UnityEngine_BoundsInt.reg);
			}
			array[num167] = BindUnity.<>f__mg$cacheA6;
			int num168 = 167;
			if (BindUnity.<>f__mg$cacheA7 == null)
			{
				BindUnity.<>f__mg$cacheA7 = new Action<IntPtr>(Lua_UnityEngine_CachedAssetBundle.reg);
			}
			array[num168] = BindUnity.<>f__mg$cacheA7;
			int num169 = 168;
			if (BindUnity.<>f__mg$cacheA8 == null)
			{
				BindUnity.<>f__mg$cacheA8 = new Action<IntPtr>(Lua_UnityEngine_Cache.reg);
			}
			array[num169] = BindUnity.<>f__mg$cacheA8;
			int num170 = 169;
			if (BindUnity.<>f__mg$cacheA9 == null)
			{
				BindUnity.<>f__mg$cacheA9 = new Action<IntPtr>(Lua_UnityEngine_Color.reg);
			}
			array[num170] = BindUnity.<>f__mg$cacheA9;
			int num171 = 170;
			if (BindUnity.<>f__mg$cacheAA == null)
			{
				BindUnity.<>f__mg$cacheAA = new Action<IntPtr>(Lua_UnityEngine_Color32.reg);
			}
			array[num171] = BindUnity.<>f__mg$cacheAA;
			int num172 = 171;
			if (BindUnity.<>f__mg$cacheAB == null)
			{
				BindUnity.<>f__mg$cacheAB = new Action<IntPtr>(Lua_UnityEngine_GeometryUtility.reg);
			}
			array[num172] = BindUnity.<>f__mg$cacheAB;
			int num173 = 172;
			if (BindUnity.<>f__mg$cacheAC == null)
			{
				BindUnity.<>f__mg$cacheAC = new Action<IntPtr>(Lua_UnityEngine_SleepTimeout.reg);
			}
			array[num173] = BindUnity.<>f__mg$cacheAC;
			int num174 = 173;
			if (BindUnity.<>f__mg$cacheAD == null)
			{
				BindUnity.<>f__mg$cacheAD = new Action<IntPtr>(Lua_UnityEngine_GL.reg);
			}
			array[num174] = BindUnity.<>f__mg$cacheAD;
			int num175 = 174;
			if (BindUnity.<>f__mg$cacheAE == null)
			{
				BindUnity.<>f__mg$cacheAE = new Action<IntPtr>(Lua_UnityEngine_ScalableBufferManager.reg);
			}
			array[num175] = BindUnity.<>f__mg$cacheAE;
			int num176 = 175;
			if (BindUnity.<>f__mg$cacheAF == null)
			{
				BindUnity.<>f__mg$cacheAF = new Action<IntPtr>(Lua_UnityEngine_FrameTiming.reg);
			}
			array[num176] = BindUnity.<>f__mg$cacheAF;
			int num177 = 176;
			if (BindUnity.<>f__mg$cacheB0 == null)
			{
				BindUnity.<>f__mg$cacheB0 = new Action<IntPtr>(Lua_UnityEngine_FrameTimingManager.reg);
			}
			array[num177] = BindUnity.<>f__mg$cacheB0;
			int num178 = 177;
			if (BindUnity.<>f__mg$cacheB1 == null)
			{
				BindUnity.<>f__mg$cacheB1 = new Action<IntPtr>(Lua_UnityEngine_Resolution.reg);
			}
			array[num178] = BindUnity.<>f__mg$cacheB1;
			int num179 = 178;
			if (BindUnity.<>f__mg$cacheB2 == null)
			{
				BindUnity.<>f__mg$cacheB2 = new Action<IntPtr>(Lua_UnityEngine_LightmapData.reg);
			}
			array[num179] = BindUnity.<>f__mg$cacheB2;
			int num180 = 179;
			if (BindUnity.<>f__mg$cacheB3 == null)
			{
				BindUnity.<>f__mg$cacheB3 = new Action<IntPtr>(Lua_UnityEngine_RenderBuffer.reg);
			}
			array[num180] = BindUnity.<>f__mg$cacheB3;
			int num181 = 180;
			if (BindUnity.<>f__mg$cacheB4 == null)
			{
				BindUnity.<>f__mg$cacheB4 = new Action<IntPtr>(Lua_UnityEngine_RenderTargetSetup.reg);
			}
			array[num181] = BindUnity.<>f__mg$cacheB4;
			int num182 = 181;
			if (BindUnity.<>f__mg$cacheB5 == null)
			{
				BindUnity.<>f__mg$cacheB5 = new Action<IntPtr>(Lua_UnityEngine_ImageEffectTransformsToLDR.reg);
			}
			array[num182] = BindUnity.<>f__mg$cacheB5;
			int num183 = 182;
			if (BindUnity.<>f__mg$cacheB6 == null)
			{
				BindUnity.<>f__mg$cacheB6 = new Action<IntPtr>(Lua_UnityEngine_ImageEffectAllowedInSceneView.reg);
			}
			array[num183] = BindUnity.<>f__mg$cacheB6;
			int num184 = 183;
			if (BindUnity.<>f__mg$cacheB7 == null)
			{
				BindUnity.<>f__mg$cacheB7 = new Action<IntPtr>(Lua_UnityEngine_ImageEffectOpaque.reg);
			}
			array[num184] = BindUnity.<>f__mg$cacheB7;
			int num185 = 184;
			if (BindUnity.<>f__mg$cacheB8 == null)
			{
				BindUnity.<>f__mg$cacheB8 = new Action<IntPtr>(Lua_UnityEngine_ImageEffectAfterScale.reg);
			}
			array[num185] = BindUnity.<>f__mg$cacheB8;
			int num186 = 185;
			if (BindUnity.<>f__mg$cacheB9 == null)
			{
				BindUnity.<>f__mg$cacheB9 = new Action<IntPtr>(Lua_UnityEngine_Mesh.reg);
			}
			array[num186] = BindUnity.<>f__mg$cacheB9;
			int num187 = 186;
			if (BindUnity.<>f__mg$cacheBA == null)
			{
				BindUnity.<>f__mg$cacheBA = new Action<IntPtr>(Lua_UnityEngine_Projector.reg);
			}
			array[num187] = BindUnity.<>f__mg$cacheBA;
			int num188 = 187;
			if (BindUnity.<>f__mg$cacheBB == null)
			{
				BindUnity.<>f__mg$cacheBB = new Action<IntPtr>(Lua_UnityEngine_LightmapsModeLegacy.reg);
			}
			array[num188] = BindUnity.<>f__mg$cacheBB;
			int num189 = 188;
			if (BindUnity.<>f__mg$cacheBC == null)
			{
				BindUnity.<>f__mg$cacheBC = new Action<IntPtr>(Lua_UnityEngine_OcclusionPortal.reg);
			}
			array[num189] = BindUnity.<>f__mg$cacheBC;
			int num190 = 189;
			if (BindUnity.<>f__mg$cacheBD == null)
			{
				BindUnity.<>f__mg$cacheBD = new Action<IntPtr>(Lua_UnityEngine_OcclusionArea.reg);
			}
			array[num190] = BindUnity.<>f__mg$cacheBD;
			int num191 = 190;
			if (BindUnity.<>f__mg$cacheBE == null)
			{
				BindUnity.<>f__mg$cacheBE = new Action<IntPtr>(Lua_UnityEngine_Flare.reg);
			}
			array[num191] = BindUnity.<>f__mg$cacheBE;
			int num192 = 191;
			if (BindUnity.<>f__mg$cacheBF == null)
			{
				BindUnity.<>f__mg$cacheBF = new Action<IntPtr>(Lua_UnityEngine_LensFlare.reg);
			}
			array[num192] = BindUnity.<>f__mg$cacheBF;
			int num193 = 192;
			if (BindUnity.<>f__mg$cacheC0 == null)
			{
				BindUnity.<>f__mg$cacheC0 = new Action<IntPtr>(Lua_UnityEngine_LightBakingOutput.reg);
			}
			array[num193] = BindUnity.<>f__mg$cacheC0;
			int num194 = 193;
			if (BindUnity.<>f__mg$cacheC1 == null)
			{
				BindUnity.<>f__mg$cacheC1 = new Action<IntPtr>(Lua_UnityEngine_Skybox.reg);
			}
			array[num194] = BindUnity.<>f__mg$cacheC1;
			int num195 = 194;
			if (BindUnity.<>f__mg$cacheC2 == null)
			{
				BindUnity.<>f__mg$cacheC2 = new Action<IntPtr>(Lua_UnityEngine_MeshFilter.reg);
			}
			array[num195] = BindUnity.<>f__mg$cacheC2;
			int num196 = 195;
			if (BindUnity.<>f__mg$cacheC3 == null)
			{
				BindUnity.<>f__mg$cacheC3 = new Action<IntPtr>(Lua_UnityEngine_RenderingPath.reg);
			}
			array[num196] = BindUnity.<>f__mg$cacheC3;
			int num197 = 196;
			if (BindUnity.<>f__mg$cacheC4 == null)
			{
				BindUnity.<>f__mg$cacheC4 = new Action<IntPtr>(Lua_UnityEngine_TransparencySortMode.reg);
			}
			array[num197] = BindUnity.<>f__mg$cacheC4;
			int num198 = 197;
			if (BindUnity.<>f__mg$cacheC5 == null)
			{
				BindUnity.<>f__mg$cacheC5 = new Action<IntPtr>(Lua_UnityEngine_StereoTargetEyeMask.reg);
			}
			array[num198] = BindUnity.<>f__mg$cacheC5;
			int num199 = 198;
			if (BindUnity.<>f__mg$cacheC6 == null)
			{
				BindUnity.<>f__mg$cacheC6 = new Action<IntPtr>(Lua_UnityEngine_CameraType.reg);
			}
			array[num199] = BindUnity.<>f__mg$cacheC6;
			int num200 = 199;
			if (BindUnity.<>f__mg$cacheC7 == null)
			{
				BindUnity.<>f__mg$cacheC7 = new Action<IntPtr>(Lua_UnityEngine_ComputeBufferType.reg);
			}
			array[num200] = BindUnity.<>f__mg$cacheC7;
			int num201 = 200;
			if (BindUnity.<>f__mg$cacheC8 == null)
			{
				BindUnity.<>f__mg$cacheC8 = new Action<IntPtr>(Lua_UnityEngine_LightType.reg);
			}
			array[num201] = BindUnity.<>f__mg$cacheC8;
			int num202 = 201;
			if (BindUnity.<>f__mg$cacheC9 == null)
			{
				BindUnity.<>f__mg$cacheC9 = new Action<IntPtr>(Lua_UnityEngine_LightRenderMode.reg);
			}
			array[num202] = BindUnity.<>f__mg$cacheC9;
			int num203 = 202;
			if (BindUnity.<>f__mg$cacheCA == null)
			{
				BindUnity.<>f__mg$cacheCA = new Action<IntPtr>(Lua_UnityEngine_LightShadows.reg);
			}
			array[num203] = BindUnity.<>f__mg$cacheCA;
			int num204 = 203;
			if (BindUnity.<>f__mg$cacheCB == null)
			{
				BindUnity.<>f__mg$cacheCB = new Action<IntPtr>(Lua_UnityEngine_FogMode.reg);
			}
			array[num204] = BindUnity.<>f__mg$cacheCB;
			int num205 = 204;
			if (BindUnity.<>f__mg$cacheCC == null)
			{
				BindUnity.<>f__mg$cacheCC = new Action<IntPtr>(Lua_UnityEngine_LightmapBakeType.reg);
			}
			array[num205] = BindUnity.<>f__mg$cacheCC;
			int num206 = 205;
			if (BindUnity.<>f__mg$cacheCD == null)
			{
				BindUnity.<>f__mg$cacheCD = new Action<IntPtr>(Lua_UnityEngine_MixedLightingMode.reg);
			}
			array[num206] = BindUnity.<>f__mg$cacheCD;
			int num207 = 206;
			if (BindUnity.<>f__mg$cacheCE == null)
			{
				BindUnity.<>f__mg$cacheCE = new Action<IntPtr>(Lua_UnityEngine_ShadowProjection.reg);
			}
			array[num207] = BindUnity.<>f__mg$cacheCE;
			int num208 = 207;
			if (BindUnity.<>f__mg$cacheCF == null)
			{
				BindUnity.<>f__mg$cacheCF = new Action<IntPtr>(Lua_UnityEngine_ShadowQuality.reg);
			}
			array[num208] = BindUnity.<>f__mg$cacheCF;
			int num209 = 208;
			if (BindUnity.<>f__mg$cacheD0 == null)
			{
				BindUnity.<>f__mg$cacheD0 = new Action<IntPtr>(Lua_UnityEngine_ShadowResolution.reg);
			}
			array[num209] = BindUnity.<>f__mg$cacheD0;
			int num210 = 209;
			if (BindUnity.<>f__mg$cacheD1 == null)
			{
				BindUnity.<>f__mg$cacheD1 = new Action<IntPtr>(Lua_UnityEngine_ShadowmaskMode.reg);
			}
			array[num210] = BindUnity.<>f__mg$cacheD1;
			int num211 = 210;
			if (BindUnity.<>f__mg$cacheD2 == null)
			{
				BindUnity.<>f__mg$cacheD2 = new Action<IntPtr>(Lua_UnityEngine_CameraClearFlags.reg);
			}
			array[num211] = BindUnity.<>f__mg$cacheD2;
			int num212 = 211;
			if (BindUnity.<>f__mg$cacheD3 == null)
			{
				BindUnity.<>f__mg$cacheD3 = new Action<IntPtr>(Lua_UnityEngine_DepthTextureMode.reg);
			}
			array[num212] = BindUnity.<>f__mg$cacheD3;
			int num213 = 212;
			if (BindUnity.<>f__mg$cacheD4 == null)
			{
				BindUnity.<>f__mg$cacheD4 = new Action<IntPtr>(Lua_UnityEngine_TexGenMode.reg);
			}
			array[num213] = BindUnity.<>f__mg$cacheD4;
			int num214 = 213;
			if (BindUnity.<>f__mg$cacheD5 == null)
			{
				BindUnity.<>f__mg$cacheD5 = new Action<IntPtr>(Lua_UnityEngine_AnisotropicFiltering.reg);
			}
			array[num214] = BindUnity.<>f__mg$cacheD5;
			int num215 = 214;
			if (BindUnity.<>f__mg$cacheD6 == null)
			{
				BindUnity.<>f__mg$cacheD6 = new Action<IntPtr>(Lua_UnityEngine_BlendWeights.reg);
			}
			array[num215] = BindUnity.<>f__mg$cacheD6;
			int num216 = 215;
			if (BindUnity.<>f__mg$cacheD7 == null)
			{
				BindUnity.<>f__mg$cacheD7 = new Action<IntPtr>(Lua_UnityEngine_MeshTopology.reg);
			}
			array[num216] = BindUnity.<>f__mg$cacheD7;
			int num217 = 216;
			if (BindUnity.<>f__mg$cacheD8 == null)
			{
				BindUnity.<>f__mg$cacheD8 = new Action<IntPtr>(Lua_UnityEngine_SkinQuality.reg);
			}
			array[num217] = BindUnity.<>f__mg$cacheD8;
			int num218 = 217;
			if (BindUnity.<>f__mg$cacheD9 == null)
			{
				BindUnity.<>f__mg$cacheD9 = new Action<IntPtr>(Lua_UnityEngine_ColorSpace.reg);
			}
			array[num218] = BindUnity.<>f__mg$cacheD9;
			int num219 = 218;
			if (BindUnity.<>f__mg$cacheDA == null)
			{
				BindUnity.<>f__mg$cacheDA = new Action<IntPtr>(Lua_UnityEngine_ColorGamut.reg);
			}
			array[num219] = BindUnity.<>f__mg$cacheDA;
			int num220 = 219;
			if (BindUnity.<>f__mg$cacheDB == null)
			{
				BindUnity.<>f__mg$cacheDB = new Action<IntPtr>(Lua_UnityEngine_ScreenOrientation.reg);
			}
			array[num220] = BindUnity.<>f__mg$cacheDB;
			int num221 = 220;
			if (BindUnity.<>f__mg$cacheDC == null)
			{
				BindUnity.<>f__mg$cacheDC = new Action<IntPtr>(Lua_UnityEngine_FilterMode.reg);
			}
			array[num221] = BindUnity.<>f__mg$cacheDC;
			int num222 = 221;
			if (BindUnity.<>f__mg$cacheDD == null)
			{
				BindUnity.<>f__mg$cacheDD = new Action<IntPtr>(Lua_UnityEngine_TextureWrapMode.reg);
			}
			array[num222] = BindUnity.<>f__mg$cacheDD;
			int num223 = 222;
			if (BindUnity.<>f__mg$cacheDE == null)
			{
				BindUnity.<>f__mg$cacheDE = new Action<IntPtr>(Lua_UnityEngine_NPOTSupport.reg);
			}
			array[num223] = BindUnity.<>f__mg$cacheDE;
			int num224 = 223;
			if (BindUnity.<>f__mg$cacheDF == null)
			{
				BindUnity.<>f__mg$cacheDF = new Action<IntPtr>(Lua_UnityEngine_TextureFormat.reg);
			}
			array[num224] = BindUnity.<>f__mg$cacheDF;
			int num225 = 224;
			if (BindUnity.<>f__mg$cacheE0 == null)
			{
				BindUnity.<>f__mg$cacheE0 = new Action<IntPtr>(Lua_UnityEngine_CubemapFace.reg);
			}
			array[num225] = BindUnity.<>f__mg$cacheE0;
			int num226 = 225;
			if (BindUnity.<>f__mg$cacheE1 == null)
			{
				BindUnity.<>f__mg$cacheE1 = new Action<IntPtr>(Lua_UnityEngine_RenderTextureFormat.reg);
			}
			array[num226] = BindUnity.<>f__mg$cacheE1;
			int num227 = 226;
			if (BindUnity.<>f__mg$cacheE2 == null)
			{
				BindUnity.<>f__mg$cacheE2 = new Action<IntPtr>(Lua_UnityEngine_VRTextureUsage.reg);
			}
			array[num227] = BindUnity.<>f__mg$cacheE2;
			int num228 = 227;
			if (BindUnity.<>f__mg$cacheE3 == null)
			{
				BindUnity.<>f__mg$cacheE3 = new Action<IntPtr>(Lua_UnityEngine_RenderTextureCreationFlags.reg);
			}
			array[num228] = BindUnity.<>f__mg$cacheE3;
			int num229 = 228;
			if (BindUnity.<>f__mg$cacheE4 == null)
			{
				BindUnity.<>f__mg$cacheE4 = new Action<IntPtr>(Lua_UnityEngine_RenderTextureReadWrite.reg);
			}
			array[num229] = BindUnity.<>f__mg$cacheE4;
			int num230 = 229;
			if (BindUnity.<>f__mg$cacheE5 == null)
			{
				BindUnity.<>f__mg$cacheE5 = new Action<IntPtr>(Lua_UnityEngine_RenderTextureMemoryless.reg);
			}
			array[num230] = BindUnity.<>f__mg$cacheE5;
			int num231 = 230;
			if (BindUnity.<>f__mg$cacheE6 == null)
			{
				BindUnity.<>f__mg$cacheE6 = new Action<IntPtr>(Lua_UnityEngine_LightmapsMode.reg);
			}
			array[num231] = BindUnity.<>f__mg$cacheE6;
			int num232 = 231;
			if (BindUnity.<>f__mg$cacheE7 == null)
			{
				BindUnity.<>f__mg$cacheE7 = new Action<IntPtr>(Lua_UnityEngine_MaterialGlobalIlluminationFlags.reg);
			}
			array[num232] = BindUnity.<>f__mg$cacheE7;
			int num233 = 232;
			if (BindUnity.<>f__mg$cacheE8 == null)
			{
				BindUnity.<>f__mg$cacheE8 = new Action<IntPtr>(Lua_UnityEngine_CustomRenderTextureInitializationSource.reg);
			}
			array[num233] = BindUnity.<>f__mg$cacheE8;
			int num234 = 233;
			if (BindUnity.<>f__mg$cacheE9 == null)
			{
				BindUnity.<>f__mg$cacheE9 = new Action<IntPtr>(Lua_UnityEngine_CustomRenderTextureUpdateMode.reg);
			}
			array[num234] = BindUnity.<>f__mg$cacheE9;
			int num235 = 234;
			if (BindUnity.<>f__mg$cacheEA == null)
			{
				BindUnity.<>f__mg$cacheEA = new Action<IntPtr>(Lua_UnityEngine_CustomRenderTextureUpdateZoneSpace.reg);
			}
			array[num235] = BindUnity.<>f__mg$cacheEA;
			int num236 = 235;
			if (BindUnity.<>f__mg$cacheEB == null)
			{
				BindUnity.<>f__mg$cacheEB = new Action<IntPtr>(Lua_UnityEngine_LineTextureMode.reg);
			}
			array[num236] = BindUnity.<>f__mg$cacheEB;
			int num237 = 236;
			if (BindUnity.<>f__mg$cacheEC == null)
			{
				BindUnity.<>f__mg$cacheEC = new Action<IntPtr>(Lua_UnityEngine_LineAlignment.reg);
			}
			array[num237] = BindUnity.<>f__mg$cacheEC;
			int num238 = 237;
			if (BindUnity.<>f__mg$cacheED == null)
			{
				BindUnity.<>f__mg$cacheED = new Action<IntPtr>(Lua_UnityEngine_Rendering_IndexFormat.reg);
			}
			array[num238] = BindUnity.<>f__mg$cacheED;
			int num239 = 238;
			if (BindUnity.<>f__mg$cacheEE == null)
			{
				BindUnity.<>f__mg$cacheEE = new Action<IntPtr>(Lua_UnityEngine_Rendering_OpaqueSortMode.reg);
			}
			array[num239] = BindUnity.<>f__mg$cacheEE;
			int num240 = 239;
			if (BindUnity.<>f__mg$cacheEF == null)
			{
				BindUnity.<>f__mg$cacheEF = new Action<IntPtr>(Lua_UnityEngine_Rendering_RenderQueue.reg);
			}
			array[num240] = BindUnity.<>f__mg$cacheEF;
			int num241 = 240;
			if (BindUnity.<>f__mg$cacheF0 == null)
			{
				BindUnity.<>f__mg$cacheF0 = new Action<IntPtr>(Lua_UnityEngine_Rendering_RenderBufferLoadAction.reg);
			}
			array[num241] = BindUnity.<>f__mg$cacheF0;
			int num242 = 241;
			if (BindUnity.<>f__mg$cacheF1 == null)
			{
				BindUnity.<>f__mg$cacheF1 = new Action<IntPtr>(Lua_UnityEngine_Rendering_RenderBufferStoreAction.reg);
			}
			array[num242] = BindUnity.<>f__mg$cacheF1;
			int num243 = 242;
			if (BindUnity.<>f__mg$cacheF2 == null)
			{
				BindUnity.<>f__mg$cacheF2 = new Action<IntPtr>(Lua_UnityEngine_Rendering_BlendMode.reg);
			}
			array[num243] = BindUnity.<>f__mg$cacheF2;
			int num244 = 243;
			if (BindUnity.<>f__mg$cacheF3 == null)
			{
				BindUnity.<>f__mg$cacheF3 = new Action<IntPtr>(Lua_UnityEngine_Rendering_BlendOp.reg);
			}
			array[num244] = BindUnity.<>f__mg$cacheF3;
			int num245 = 244;
			if (BindUnity.<>f__mg$cacheF4 == null)
			{
				BindUnity.<>f__mg$cacheF4 = new Action<IntPtr>(Lua_UnityEngine_Rendering_CompareFunction.reg);
			}
			array[num245] = BindUnity.<>f__mg$cacheF4;
			int num246 = 245;
			if (BindUnity.<>f__mg$cacheF5 == null)
			{
				BindUnity.<>f__mg$cacheF5 = new Action<IntPtr>(Lua_UnityEngine_Rendering_CullMode.reg);
			}
			array[num246] = BindUnity.<>f__mg$cacheF5;
			int num247 = 246;
			if (BindUnity.<>f__mg$cacheF6 == null)
			{
				BindUnity.<>f__mg$cacheF6 = new Action<IntPtr>(Lua_UnityEngine_Rendering_ColorWriteMask.reg);
			}
			array[num247] = BindUnity.<>f__mg$cacheF6;
			int num248 = 247;
			if (BindUnity.<>f__mg$cacheF7 == null)
			{
				BindUnity.<>f__mg$cacheF7 = new Action<IntPtr>(Lua_UnityEngine_Rendering_StencilOp.reg);
			}
			array[num248] = BindUnity.<>f__mg$cacheF7;
			int num249 = 248;
			if (BindUnity.<>f__mg$cacheF8 == null)
			{
				BindUnity.<>f__mg$cacheF8 = new Action<IntPtr>(Lua_UnityEngine_Rendering_AmbientMode.reg);
			}
			array[num249] = BindUnity.<>f__mg$cacheF8;
			int num250 = 249;
			if (BindUnity.<>f__mg$cacheF9 == null)
			{
				BindUnity.<>f__mg$cacheF9 = new Action<IntPtr>(Lua_UnityEngine_Rendering_DefaultReflectionMode.reg);
			}
			array[num250] = BindUnity.<>f__mg$cacheF9;
			int num251 = 250;
			if (BindUnity.<>f__mg$cacheFA == null)
			{
				BindUnity.<>f__mg$cacheFA = new Action<IntPtr>(Lua_UnityEngine_Rendering_ReflectionCubemapCompression.reg);
			}
			array[num251] = BindUnity.<>f__mg$cacheFA;
			int num252 = 251;
			if (BindUnity.<>f__mg$cacheFB == null)
			{
				BindUnity.<>f__mg$cacheFB = new Action<IntPtr>(Lua_UnityEngine_Rendering_CameraEvent.reg);
			}
			array[num252] = BindUnity.<>f__mg$cacheFB;
			int num253 = 252;
			if (BindUnity.<>f__mg$cacheFC == null)
			{
				BindUnity.<>f__mg$cacheFC = new Action<IntPtr>(Lua_UnityEngine_Rendering_LightEvent.reg);
			}
			array[num253] = BindUnity.<>f__mg$cacheFC;
			int num254 = 253;
			if (BindUnity.<>f__mg$cacheFD == null)
			{
				BindUnity.<>f__mg$cacheFD = new Action<IntPtr>(Lua_UnityEngine_Rendering_ShadowMapPass.reg);
			}
			array[num254] = BindUnity.<>f__mg$cacheFD;
			int num255 = 254;
			if (BindUnity.<>f__mg$cacheFE == null)
			{
				BindUnity.<>f__mg$cacheFE = new Action<IntPtr>(Lua_UnityEngine_Rendering_BuiltinRenderTextureType.reg);
			}
			array[num255] = BindUnity.<>f__mg$cacheFE;
			int num256 = 255;
			if (BindUnity.<>f__mg$cacheFF == null)
			{
				BindUnity.<>f__mg$cacheFF = new Action<IntPtr>(Lua_UnityEngine_Rendering_PassType.reg);
			}
			array[num256] = BindUnity.<>f__mg$cacheFF;
			int num257 = 256;
			if (BindUnity.<>f__mg$cache100 == null)
			{
				BindUnity.<>f__mg$cache100 = new Action<IntPtr>(Lua_UnityEngine_Rendering_ShadowCastingMode.reg);
			}
			array[num257] = BindUnity.<>f__mg$cache100;
			int num258 = 257;
			if (BindUnity.<>f__mg$cache101 == null)
			{
				BindUnity.<>f__mg$cache101 = new Action<IntPtr>(Lua_UnityEngine_Rendering_LightShadowResolution.reg);
			}
			array[num258] = BindUnity.<>f__mg$cache101;
			int num259 = 258;
			if (BindUnity.<>f__mg$cache102 == null)
			{
				BindUnity.<>f__mg$cache102 = new Action<IntPtr>(Lua_UnityEngine_Rendering_GraphicsDeviceType.reg);
			}
			array[num259] = BindUnity.<>f__mg$cache102;
			int num260 = 259;
			if (BindUnity.<>f__mg$cache103 == null)
			{
				BindUnity.<>f__mg$cache103 = new Action<IntPtr>(Lua_UnityEngine_Rendering_GraphicsTier.reg);
			}
			array[num260] = BindUnity.<>f__mg$cache103;
			int num261 = 260;
			if (BindUnity.<>f__mg$cache104 == null)
			{
				BindUnity.<>f__mg$cache104 = new Action<IntPtr>(Lua_UnityEngine_Rendering_RenderTargetIdentifier.reg);
			}
			array[num261] = BindUnity.<>f__mg$cache104;
			int num262 = 261;
			if (BindUnity.<>f__mg$cache105 == null)
			{
				BindUnity.<>f__mg$cache105 = new Action<IntPtr>(Lua_UnityEngine_Rendering_ReflectionProbeUsage.reg);
			}
			array[num262] = BindUnity.<>f__mg$cache105;
			int num263 = 262;
			if (BindUnity.<>f__mg$cache106 == null)
			{
				BindUnity.<>f__mg$cache106 = new Action<IntPtr>(Lua_UnityEngine_Rendering_ReflectionProbeType.reg);
			}
			array[num263] = BindUnity.<>f__mg$cache106;
			int num264 = 263;
			if (BindUnity.<>f__mg$cache107 == null)
			{
				BindUnity.<>f__mg$cache107 = new Action<IntPtr>(Lua_UnityEngine_Rendering_ReflectionProbeClearFlags.reg);
			}
			array[num264] = BindUnity.<>f__mg$cache107;
			int num265 = 264;
			if (BindUnity.<>f__mg$cache108 == null)
			{
				BindUnity.<>f__mg$cache108 = new Action<IntPtr>(Lua_UnityEngine_Rendering_ReflectionProbeMode.reg);
			}
			array[num265] = BindUnity.<>f__mg$cache108;
			int num266 = 265;
			if (BindUnity.<>f__mg$cache109 == null)
			{
				BindUnity.<>f__mg$cache109 = new Action<IntPtr>(Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.reg);
			}
			array[num266] = BindUnity.<>f__mg$cache109;
			int num267 = 266;
			if (BindUnity.<>f__mg$cache10A == null)
			{
				BindUnity.<>f__mg$cache10A = new Action<IntPtr>(Lua_UnityEngine_Rendering_ReflectionProbeRefreshMode.reg);
			}
			array[num267] = BindUnity.<>f__mg$cache10A;
			int num268 = 267;
			if (BindUnity.<>f__mg$cache10B == null)
			{
				BindUnity.<>f__mg$cache10B = new Action<IntPtr>(Lua_UnityEngine_Rendering_ReflectionProbeTimeSlicingMode.reg);
			}
			array[num268] = BindUnity.<>f__mg$cache10B;
			int num269 = 268;
			if (BindUnity.<>f__mg$cache10C == null)
			{
				BindUnity.<>f__mg$cache10C = new Action<IntPtr>(Lua_UnityEngine_Rendering_ShadowSamplingMode.reg);
			}
			array[num269] = BindUnity.<>f__mg$cache10C;
			int num270 = 269;
			if (BindUnity.<>f__mg$cache10D == null)
			{
				BindUnity.<>f__mg$cache10D = new Action<IntPtr>(Lua_UnityEngine_Rendering_LightProbeUsage.reg);
			}
			array[num270] = BindUnity.<>f__mg$cache10D;
			int num271 = 270;
			if (BindUnity.<>f__mg$cache10E == null)
			{
				BindUnity.<>f__mg$cache10E = new Action<IntPtr>(Lua_UnityEngine_Rendering_BuiltinShaderType.reg);
			}
			array[num271] = BindUnity.<>f__mg$cache10E;
			int num272 = 271;
			if (BindUnity.<>f__mg$cache10F == null)
			{
				BindUnity.<>f__mg$cache10F = new Action<IntPtr>(Lua_UnityEngine_Rendering_BuiltinShaderMode.reg);
			}
			array[num272] = BindUnity.<>f__mg$cache10F;
			int num273 = 272;
			if (BindUnity.<>f__mg$cache110 == null)
			{
				BindUnity.<>f__mg$cache110 = new Action<IntPtr>(Lua_UnityEngine_Rendering_BuiltinShaderDefine.reg);
			}
			array[num273] = BindUnity.<>f__mg$cache110;
			int num274 = 273;
			if (BindUnity.<>f__mg$cache111 == null)
			{
				BindUnity.<>f__mg$cache111 = new Action<IntPtr>(Lua_UnityEngine_Rendering_TextureDimension.reg);
			}
			array[num274] = BindUnity.<>f__mg$cache111;
			int num275 = 274;
			if (BindUnity.<>f__mg$cache112 == null)
			{
				BindUnity.<>f__mg$cache112 = new Action<IntPtr>(Lua_UnityEngine_Rendering_CopyTextureSupport.reg);
			}
			array[num275] = BindUnity.<>f__mg$cache112;
			int num276 = 275;
			if (BindUnity.<>f__mg$cache113 == null)
			{
				BindUnity.<>f__mg$cache113 = new Action<IntPtr>(Lua_UnityEngine_Rendering_CameraHDRMode.reg);
			}
			array[num276] = BindUnity.<>f__mg$cache113;
			int num277 = 276;
			if (BindUnity.<>f__mg$cache114 == null)
			{
				BindUnity.<>f__mg$cache114 = new Action<IntPtr>(Lua_UnityEngine_Rendering_RealtimeGICPUUsage.reg);
			}
			array[num277] = BindUnity.<>f__mg$cache114;
			int num278 = 277;
			if (BindUnity.<>f__mg$cache115 == null)
			{
				BindUnity.<>f__mg$cache115 = new Action<IntPtr>(Lua_UnityEngine_MeshRenderer.reg);
			}
			array[num278] = BindUnity.<>f__mg$cache115;
			int num279 = 278;
			if (BindUnity.<>f__mg$cache116 == null)
			{
				BindUnity.<>f__mg$cache116 = new Action<IntPtr>(Lua_UnityEngine_IExposedPropertyTable.reg);
			}
			array[num279] = BindUnity.<>f__mg$cache116;
			int num280 = 279;
			if (BindUnity.<>f__mg$cache117 == null)
			{
				BindUnity.<>f__mg$cache117 = new Action<IntPtr>(Lua_JetBrains_Annotations_ImplicitUseKindFlags.reg);
			}
			array[num280] = BindUnity.<>f__mg$cache117;
			int num281 = 280;
			if (BindUnity.<>f__mg$cache118 == null)
			{
				BindUnity.<>f__mg$cache118 = new Action<IntPtr>(Lua_JetBrains_Annotations_ImplicitUseTargetFlags.reg);
			}
			array[num281] = BindUnity.<>f__mg$cache118;
			int num282 = 281;
			if (BindUnity.<>f__mg$cache119 == null)
			{
				BindUnity.<>f__mg$cache119 = new Action<IntPtr>(Lua_UnityEngine_KeyCode.reg);
			}
			array[num282] = BindUnity.<>f__mg$cache119;
			int num283 = 282;
			if (BindUnity.<>f__mg$cache11A == null)
			{
				BindUnity.<>f__mg$cache11A = new Action<IntPtr>(Lua_UnityEngine_BoneWeight.reg);
			}
			array[num283] = BindUnity.<>f__mg$cache11A;
			int num284 = 283;
			if (BindUnity.<>f__mg$cache11B == null)
			{
				BindUnity.<>f__mg$cache11B = new Action<IntPtr>(Lua_UnityEngine_CombineInstance.reg);
			}
			array[num284] = BindUnity.<>f__mg$cache11B;
			int num285 = 284;
			if (BindUnity.<>f__mg$cache11C == null)
			{
				BindUnity.<>f__mg$cache11C = new Action<IntPtr>(Lua_UnityEngine_Plane.reg);
			}
			array[num285] = BindUnity.<>f__mg$cache11C;
			int num286 = 285;
			if (BindUnity.<>f__mg$cache11D == null)
			{
				BindUnity.<>f__mg$cache11D = new Action<IntPtr>(Lua_UnityEngine_Pose.reg);
			}
			array[num286] = BindUnity.<>f__mg$cache11D;
			int num287 = 286;
			if (BindUnity.<>f__mg$cache11E == null)
			{
				BindUnity.<>f__mg$cache11E = new Action<IntPtr>(Lua_UnityEngine_PropertyName.reg);
			}
			array[num287] = BindUnity.<>f__mg$cache11E;
			int num288 = 287;
			if (BindUnity.<>f__mg$cache11F == null)
			{
				BindUnity.<>f__mg$cache11F = new Action<IntPtr>(Lua_UnityEngine_RangeInt.reg);
			}
			array[num288] = BindUnity.<>f__mg$cache11F;
			int num289 = 288;
			if (BindUnity.<>f__mg$cache120 == null)
			{
				BindUnity.<>f__mg$cache120 = new Action<IntPtr>(Lua_UnityEngine_Ray.reg);
			}
			array[num289] = BindUnity.<>f__mg$cache120;
			int num290 = 289;
			if (BindUnity.<>f__mg$cache121 == null)
			{
				BindUnity.<>f__mg$cache121 = new Action<IntPtr>(Lua_UnityEngine_Ray2D.reg);
			}
			array[num290] = BindUnity.<>f__mg$cache121;
			int num291 = 290;
			if (BindUnity.<>f__mg$cache122 == null)
			{
				BindUnity.<>f__mg$cache122 = new Action<IntPtr>(Lua_UnityEngine_Rect.reg);
			}
			array[num291] = BindUnity.<>f__mg$cache122;
			int num292 = 291;
			if (BindUnity.<>f__mg$cache123 == null)
			{
				BindUnity.<>f__mg$cache123 = new Action<IntPtr>(Lua_UnityEngine_RectInt.reg);
			}
			array[num292] = BindUnity.<>f__mg$cache123;
			int num293 = 292;
			if (BindUnity.<>f__mg$cache124 == null)
			{
				BindUnity.<>f__mg$cache124 = new Action<IntPtr>(Lua_UnityEngine_RuntimeInitializeLoadType.reg);
			}
			array[num293] = BindUnity.<>f__mg$cache124;
			int num294 = 293;
			if (BindUnity.<>f__mg$cache125 == null)
			{
				BindUnity.<>f__mg$cache125 = new Action<IntPtr>(Lua_UnityEngine_PreferBinarySerialization.reg);
			}
			array[num294] = BindUnity.<>f__mg$cache125;
			int num295 = 294;
			if (BindUnity.<>f__mg$cache126 == null)
			{
				BindUnity.<>f__mg$cache126 = new Action<IntPtr>(Lua_UnityEngine_ISerializationCallbackReceiver.reg);
			}
			array[num295] = BindUnity.<>f__mg$cache126;
			int num296 = 295;
			if (BindUnity.<>f__mg$cache127 == null)
			{
				BindUnity.<>f__mg$cache127 = new Action<IntPtr>(Lua_UnityEngine_StackTraceUtility.reg);
			}
			array[num296] = BindUnity.<>f__mg$cache127;
			int num297 = 296;
			if (BindUnity.<>f__mg$cache128 == null)
			{
				BindUnity.<>f__mg$cache128 = new Action<IntPtr>(Lua_UnityEngine_UnityException.reg);
			}
			array[num297] = BindUnity.<>f__mg$cache128;
			int num298 = 297;
			if (BindUnity.<>f__mg$cache129 == null)
			{
				BindUnity.<>f__mg$cache129 = new Action<IntPtr>(Lua_UnityEngine_MissingComponentException.reg);
			}
			array[num298] = BindUnity.<>f__mg$cache129;
			int num299 = 298;
			if (BindUnity.<>f__mg$cache12A == null)
			{
				BindUnity.<>f__mg$cache12A = new Action<IntPtr>(Lua_UnityEngine_UnassignedReferenceException.reg);
			}
			array[num299] = BindUnity.<>f__mg$cache12A;
			int num300 = 299;
			if (BindUnity.<>f__mg$cache12B == null)
			{
				BindUnity.<>f__mg$cache12B = new Action<IntPtr>(Lua_UnityEngine_MissingReferenceException.reg);
			}
			array[num300] = BindUnity.<>f__mg$cache12B;
			int num301 = 300;
			if (BindUnity.<>f__mg$cache12C == null)
			{
				BindUnity.<>f__mg$cache12C = new Action<IntPtr>(Lua_UnityEngine_RenderTextureDescriptor.reg);
			}
			array[num301] = BindUnity.<>f__mg$cache12C;
			int num302 = 301;
			if (BindUnity.<>f__mg$cache12D == null)
			{
				BindUnity.<>f__mg$cache12D = new Action<IntPtr>(Lua_UnityEngine_Events_PersistentListenerMode.reg);
			}
			array[num302] = BindUnity.<>f__mg$cache12D;
			int num303 = 302;
			if (BindUnity.<>f__mg$cache12E == null)
			{
				BindUnity.<>f__mg$cache12E = new Action<IntPtr>(Lua_UnityEngine_Events_UnityEventCallState.reg);
			}
			array[num303] = BindUnity.<>f__mg$cache12E;
			int num304 = 303;
			if (BindUnity.<>f__mg$cache12F == null)
			{
				BindUnity.<>f__mg$cache12F = new Action<IntPtr>(Lua_UnityEngine_Events_UnityEventBase.reg);
			}
			array[num304] = BindUnity.<>f__mg$cache12F;
			int num305 = 304;
			if (BindUnity.<>f__mg$cache130 == null)
			{
				BindUnity.<>f__mg$cache130 = new Action<IntPtr>(Lua_UnityEngine_Events_UnityEvent.reg);
			}
			array[num305] = BindUnity.<>f__mg$cache130;
			int num306 = 305;
			if (BindUnity.<>f__mg$cache131 == null)
			{
				BindUnity.<>f__mg$cache131 = new Action<IntPtr>(Lua_UnityEngine_Vector2.reg);
			}
			array[num306] = BindUnity.<>f__mg$cache131;
			int num307 = 306;
			if (BindUnity.<>f__mg$cache132 == null)
			{
				BindUnity.<>f__mg$cache132 = new Action<IntPtr>(Lua_UnityEngine_Vector2Int.reg);
			}
			array[num307] = BindUnity.<>f__mg$cache132;
			int num308 = 307;
			if (BindUnity.<>f__mg$cache133 == null)
			{
				BindUnity.<>f__mg$cache133 = new Action<IntPtr>(Lua_UnityEngine_Vector3Int.reg);
			}
			array[num308] = BindUnity.<>f__mg$cache133;
			int num309 = 308;
			if (BindUnity.<>f__mg$cache134 == null)
			{
				BindUnity.<>f__mg$cache134 = new Action<IntPtr>(Lua_UnityEngine_Vector4.reg);
			}
			array[num309] = BindUnity.<>f__mg$cache134;
			int num310 = 309;
			if (BindUnity.<>f__mg$cache135 == null)
			{
				BindUnity.<>f__mg$cache135 = new Action<IntPtr>(Lua_UnityEngine_WaitForSecondsRealtime.reg);
			}
			array[num310] = BindUnity.<>f__mg$cache135;
			int num311 = 310;
			if (BindUnity.<>f__mg$cache136 == null)
			{
				BindUnity.<>f__mg$cache136 = new Action<IntPtr>(Lua_UnityEngine_Assertions_Assert.reg);
			}
			array[num311] = BindUnity.<>f__mg$cache136;
			int num312 = 311;
			if (BindUnity.<>f__mg$cache137 == null)
			{
				BindUnity.<>f__mg$cache137 = new Action<IntPtr>(Lua_UnityEngine_Assertions_AssertionException.reg);
			}
			array[num312] = BindUnity.<>f__mg$cache137;
			int num313 = 312;
			if (BindUnity.<>f__mg$cache138 == null)
			{
				BindUnity.<>f__mg$cache138 = new Action<IntPtr>(Lua_UnityEngine_Assertions_Comparers_FloatComparer.reg);
			}
			array[num313] = BindUnity.<>f__mg$cache138;
			int num314 = 313;
			if (BindUnity.<>f__mg$cache139 == null)
			{
				BindUnity.<>f__mg$cache139 = new Action<IntPtr>(Lua_UnityEngine_Collections_Allocator.reg);
			}
			array[num314] = BindUnity.<>f__mg$cache139;
			int num315 = 314;
			if (BindUnity.<>f__mg$cache13A == null)
			{
				BindUnity.<>f__mg$cache13A = new Action<IntPtr>(Lua_UnityEngine_Playables_FrameData.reg);
			}
			array[num315] = BindUnity.<>f__mg$cache13A;
			int num316 = 315;
			if (BindUnity.<>f__mg$cache13B == null)
			{
				BindUnity.<>f__mg$cache13B = new Action<IntPtr>(Lua_UnityEngine_Playables_FrameData_EvaluationType.reg);
			}
			array[num316] = BindUnity.<>f__mg$cache13B;
			int num317 = 316;
			if (BindUnity.<>f__mg$cache13C == null)
			{
				BindUnity.<>f__mg$cache13C = new Action<IntPtr>(Lua_UnityEngine_Playables_IPlayable.reg);
			}
			array[num317] = BindUnity.<>f__mg$cache13C;
			int num318 = 317;
			if (BindUnity.<>f__mg$cache13D == null)
			{
				BindUnity.<>f__mg$cache13D = new Action<IntPtr>(Lua_UnityEngine_Playables_IPlayableBehaviour.reg);
			}
			array[num318] = BindUnity.<>f__mg$cache13D;
			int num319 = 318;
			if (BindUnity.<>f__mg$cache13E == null)
			{
				BindUnity.<>f__mg$cache13E = new Action<IntPtr>(Lua_UnityEngine_Playables_IPlayableOutput.reg);
			}
			array[num319] = BindUnity.<>f__mg$cache13E;
			int num320 = 319;
			if (BindUnity.<>f__mg$cache13F == null)
			{
				BindUnity.<>f__mg$cache13F = new Action<IntPtr>(Lua_UnityEngine_Playables_Playable.reg);
			}
			array[num320] = BindUnity.<>f__mg$cache13F;
			int num321 = 320;
			if (BindUnity.<>f__mg$cache140 == null)
			{
				BindUnity.<>f__mg$cache140 = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableBinding.reg);
			}
			array[num321] = BindUnity.<>f__mg$cache140;
			int num322 = 321;
			if (BindUnity.<>f__mg$cache141 == null)
			{
				BindUnity.<>f__mg$cache141 = new Action<IntPtr>(Lua_UnityEngine_Playables_IPlayableAsset.reg);
			}
			array[num322] = BindUnity.<>f__mg$cache141;
			int num323 = 322;
			if (BindUnity.<>f__mg$cache142 == null)
			{
				BindUnity.<>f__mg$cache142 = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableAsset.reg);
			}
			array[num323] = BindUnity.<>f__mg$cache142;
			int num324 = 323;
			if (BindUnity.<>f__mg$cache143 == null)
			{
				BindUnity.<>f__mg$cache143 = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableBehaviour.reg);
			}
			array[num324] = BindUnity.<>f__mg$cache143;
			int num325 = 324;
			if (BindUnity.<>f__mg$cache144 == null)
			{
				BindUnity.<>f__mg$cache144 = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableExtensions.reg);
			}
			array[num325] = BindUnity.<>f__mg$cache144;
			int num326 = 325;
			if (BindUnity.<>f__mg$cache145 == null)
			{
				BindUnity.<>f__mg$cache145 = new Action<IntPtr>(Lua_UnityEngine_Playables_DirectorUpdateMode.reg);
			}
			array[num326] = BindUnity.<>f__mg$cache145;
			int num327 = 326;
			if (BindUnity.<>f__mg$cache146 == null)
			{
				BindUnity.<>f__mg$cache146 = new Action<IntPtr>(Lua_UnityEngine_Playables_DataStreamType.reg);
			}
			array[num327] = BindUnity.<>f__mg$cache146;
			int num328 = 327;
			if (BindUnity.<>f__mg$cache147 == null)
			{
				BindUnity.<>f__mg$cache147 = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableGraph.reg);
			}
			array[num328] = BindUnity.<>f__mg$cache147;
			int num329 = 328;
			if (BindUnity.<>f__mg$cache148 == null)
			{
				BindUnity.<>f__mg$cache148 = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayState.reg);
			}
			array[num329] = BindUnity.<>f__mg$cache148;
			int num330 = 329;
			if (BindUnity.<>f__mg$cache149 == null)
			{
				BindUnity.<>f__mg$cache149 = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableHandle.reg);
			}
			array[num330] = BindUnity.<>f__mg$cache149;
			int num331 = 330;
			if (BindUnity.<>f__mg$cache14A == null)
			{
				BindUnity.<>f__mg$cache14A = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableOutput.reg);
			}
			array[num331] = BindUnity.<>f__mg$cache14A;
			int num332 = 331;
			if (BindUnity.<>f__mg$cache14B == null)
			{
				BindUnity.<>f__mg$cache14B = new Action<IntPtr>(Lua_UnityEngine_Playables_PlayableOutputExtensions.reg);
			}
			array[num332] = BindUnity.<>f__mg$cache14B;
			int num333 = 332;
			if (BindUnity.<>f__mg$cache14C == null)
			{
				BindUnity.<>f__mg$cache14C = new Action<IntPtr>(Lua_UnityEngine_Playables_ScriptPlayableOutput.reg);
			}
			array[num333] = BindUnity.<>f__mg$cache14C;
			int num334 = 333;
			if (BindUnity.<>f__mg$cache14D == null)
			{
				BindUnity.<>f__mg$cache14D = new Action<IntPtr>(Lua_UnityEngine_ILogger.reg);
			}
			array[num334] = BindUnity.<>f__mg$cache14D;
			int num335 = 334;
			if (BindUnity.<>f__mg$cache14E == null)
			{
				BindUnity.<>f__mg$cache14E = new Action<IntPtr>(Lua_UnityEngine_ILogHandler.reg);
			}
			array[num335] = BindUnity.<>f__mg$cache14E;
			int num336 = 335;
			if (BindUnity.<>f__mg$cache14F == null)
			{
				BindUnity.<>f__mg$cache14F = new Action<IntPtr>(Lua_UnityEngine_Logger.reg);
			}
			array[num336] = BindUnity.<>f__mg$cache14F;
			int num337 = 336;
			if (BindUnity.<>f__mg$cache150 == null)
			{
				BindUnity.<>f__mg$cache150 = new Action<IntPtr>(Lua_UnityEngine_Collections_NativeSliceExtensions.reg);
			}
			array[num337] = BindUnity.<>f__mg$cache150;
			int num338 = 337;
			if (BindUnity.<>f__mg$cache151 == null)
			{
				BindUnity.<>f__mg$cache151 = new Action<IntPtr>(Lua_UnityEngine_StaticBatchingUtility.reg);
			}
			array[num338] = BindUnity.<>f__mg$cache151;
			int num339 = 338;
			if (BindUnity.<>f__mg$cache152 == null)
			{
				BindUnity.<>f__mg$cache152 = new Action<IntPtr>(Lua_UnityEngine_RenderMode.reg);
			}
			array[num339] = BindUnity.<>f__mg$cache152;
			int num340 = 339;
			if (BindUnity.<>f__mg$cache153 == null)
			{
				BindUnity.<>f__mg$cache153 = new Action<IntPtr>(Lua_UnityEngine_AdditionalCanvasShaderChannels.reg);
			}
			array[num340] = BindUnity.<>f__mg$cache153;
			int num341 = 340;
			if (BindUnity.<>f__mg$cache154 == null)
			{
				BindUnity.<>f__mg$cache154 = new Action<IntPtr>(Lua_UnityEngine_Canvas.reg);
			}
			array[num341] = BindUnity.<>f__mg$cache154;
			int num342 = 341;
			if (BindUnity.<>f__mg$cache155 == null)
			{
				BindUnity.<>f__mg$cache155 = new Action<IntPtr>(Lua_UnityEngine_UISystemProfilerApi.reg);
			}
			array[num342] = BindUnity.<>f__mg$cache155;
			int num343 = 342;
			if (BindUnity.<>f__mg$cache156 == null)
			{
				BindUnity.<>f__mg$cache156 = new Action<IntPtr>(Lua_UnityEngine_UISystemProfilerApi_SampleType.reg);
			}
			array[num343] = BindUnity.<>f__mg$cache156;
			int num344 = 343;
			if (BindUnity.<>f__mg$cache157 == null)
			{
				BindUnity.<>f__mg$cache157 = new Action<IntPtr>(Lua_UnityEngine_ICanvasRaycastFilter.reg);
			}
			array[num344] = BindUnity.<>f__mg$cache157;
			int num345 = 344;
			if (BindUnity.<>f__mg$cache158 == null)
			{
				BindUnity.<>f__mg$cache158 = new Action<IntPtr>(Lua_UnityEngine_CanvasGroup.reg);
			}
			array[num345] = BindUnity.<>f__mg$cache158;
			int num346 = 345;
			if (BindUnity.<>f__mg$cache159 == null)
			{
				BindUnity.<>f__mg$cache159 = new Action<IntPtr>(Lua_UnityEngine_CanvasRenderer.reg);
			}
			array[num346] = BindUnity.<>f__mg$cache159;
			int num347 = 346;
			if (BindUnity.<>f__mg$cache15A == null)
			{
				BindUnity.<>f__mg$cache15A = new Action<IntPtr>(Lua_UnityEngine_RectTransformUtility.reg);
			}
			array[num347] = BindUnity.<>f__mg$cache15A;
			int num348 = 347;
			if (BindUnity.<>f__mg$cache15B == null)
			{
				BindUnity.<>f__mg$cache15B = new Action<IntPtr>(Lua_UnityEngine_TextAnchor.reg);
			}
			array[num348] = BindUnity.<>f__mg$cache15B;
			int num349 = 348;
			if (BindUnity.<>f__mg$cache15C == null)
			{
				BindUnity.<>f__mg$cache15C = new Action<IntPtr>(Lua_UnityEngine_HorizontalWrapMode.reg);
			}
			array[num349] = BindUnity.<>f__mg$cache15C;
			int num350 = 349;
			if (BindUnity.<>f__mg$cache15D == null)
			{
				BindUnity.<>f__mg$cache15D = new Action<IntPtr>(Lua_UnityEngine_VerticalWrapMode.reg);
			}
			array[num350] = BindUnity.<>f__mg$cache15D;
			int num351 = 350;
			if (BindUnity.<>f__mg$cache15E == null)
			{
				BindUnity.<>f__mg$cache15E = new Action<IntPtr>(Lua_UnityEngine_TextMesh.reg);
			}
			array[num351] = BindUnity.<>f__mg$cache15E;
			int num352 = 351;
			if (BindUnity.<>f__mg$cache15F == null)
			{
				BindUnity.<>f__mg$cache15F = new Action<IntPtr>(Lua_UnityEngine_CharacterInfo.reg);
			}
			array[num352] = BindUnity.<>f__mg$cache15F;
			int num353 = 352;
			if (BindUnity.<>f__mg$cache160 == null)
			{
				BindUnity.<>f__mg$cache160 = new Action<IntPtr>(Lua_UnityEngine_Font.reg);
			}
			array[num353] = BindUnity.<>f__mg$cache160;
			int num354 = 353;
			if (BindUnity.<>f__mg$cache161 == null)
			{
				BindUnity.<>f__mg$cache161 = new Action<IntPtr>(Lua_UnityEngine_UICharInfo.reg);
			}
			array[num354] = BindUnity.<>f__mg$cache161;
			int num355 = 354;
			if (BindUnity.<>f__mg$cache162 == null)
			{
				BindUnity.<>f__mg$cache162 = new Action<IntPtr>(Lua_UnityEngine_UILineInfo.reg);
			}
			array[num355] = BindUnity.<>f__mg$cache162;
			int num356 = 355;
			if (BindUnity.<>f__mg$cache163 == null)
			{
				BindUnity.<>f__mg$cache163 = new Action<IntPtr>(Lua_UnityEngine_UIVertex.reg);
			}
			array[num356] = BindUnity.<>f__mg$cache163;
			int num357 = 356;
			if (BindUnity.<>f__mg$cache164 == null)
			{
				BindUnity.<>f__mg$cache164 = new Action<IntPtr>(Lua_UnityEngine_TextGenerationSettings.reg);
			}
			array[num357] = BindUnity.<>f__mg$cache164;
			int num358 = 357;
			if (BindUnity.<>f__mg$cache165 == null)
			{
				BindUnity.<>f__mg$cache165 = new Action<IntPtr>(Lua_UnityEngine_WWW.reg);
			}
			array[num358] = BindUnity.<>f__mg$cache165;
			int num359 = 358;
			if (BindUnity.<>f__mg$cache166 == null)
			{
				BindUnity.<>f__mg$cache166 = new Action<IntPtr>(Lua_UnityEngine_Physics2D.reg);
			}
			array[num359] = BindUnity.<>f__mg$cache166;
			int num360 = 359;
			if (BindUnity.<>f__mg$cache167 == null)
			{
				BindUnity.<>f__mg$cache167 = new Action<IntPtr>(Lua_UnityEngine_Rigidbody2D.reg);
			}
			array[num360] = BindUnity.<>f__mg$cache167;
			int num361 = 360;
			if (BindUnity.<>f__mg$cache168 == null)
			{
				BindUnity.<>f__mg$cache168 = new Action<IntPtr>(Lua_UnityEngine_Collider2D.reg);
			}
			array[num361] = BindUnity.<>f__mg$cache168;
			int num362 = 361;
			if (BindUnity.<>f__mg$cache169 == null)
			{
				BindUnity.<>f__mg$cache169 = new Action<IntPtr>(Lua_UnityEngine_EdgeCollider2D.reg);
			}
			array[num362] = BindUnity.<>f__mg$cache169;
			int num363 = 362;
			if (BindUnity.<>f__mg$cache16A == null)
			{
				BindUnity.<>f__mg$cache16A = new Action<IntPtr>(Lua_UnityEngine_CompositeCollider2D.reg);
			}
			array[num363] = BindUnity.<>f__mg$cache16A;
			int num364 = 363;
			if (BindUnity.<>f__mg$cache16B == null)
			{
				BindUnity.<>f__mg$cache16B = new Action<IntPtr>(Lua_UnityEngine_CompositeCollider2D_GeometryType.reg);
			}
			array[num364] = BindUnity.<>f__mg$cache16B;
			int num365 = 364;
			if (BindUnity.<>f__mg$cache16C == null)
			{
				BindUnity.<>f__mg$cache16C = new Action<IntPtr>(Lua_UnityEngine_CompositeCollider2D_GenerationType.reg);
			}
			array[num365] = BindUnity.<>f__mg$cache16C;
			int num366 = 365;
			if (BindUnity.<>f__mg$cache16D == null)
			{
				BindUnity.<>f__mg$cache16D = new Action<IntPtr>(Lua_UnityEngine_PolygonCollider2D.reg);
			}
			array[num366] = BindUnity.<>f__mg$cache16D;
			int num367 = 366;
			if (BindUnity.<>f__mg$cache16E == null)
			{
				BindUnity.<>f__mg$cache16E = new Action<IntPtr>(Lua_UnityEngine_Collision2D.reg);
			}
			array[num367] = BindUnity.<>f__mg$cache16E;
			int num368 = 367;
			if (BindUnity.<>f__mg$cache16F == null)
			{
				BindUnity.<>f__mg$cache16F = new Action<IntPtr>(Lua_UnityEngine_CapsuleDirection2D.reg);
			}
			array[num368] = BindUnity.<>f__mg$cache16F;
			int num369 = 368;
			if (BindUnity.<>f__mg$cache170 == null)
			{
				BindUnity.<>f__mg$cache170 = new Action<IntPtr>(Lua_UnityEngine_RigidbodyConstraints2D.reg);
			}
			array[num369] = BindUnity.<>f__mg$cache170;
			int num370 = 369;
			if (BindUnity.<>f__mg$cache171 == null)
			{
				BindUnity.<>f__mg$cache171 = new Action<IntPtr>(Lua_UnityEngine_RigidbodyInterpolation2D.reg);
			}
			array[num370] = BindUnity.<>f__mg$cache171;
			int num371 = 370;
			if (BindUnity.<>f__mg$cache172 == null)
			{
				BindUnity.<>f__mg$cache172 = new Action<IntPtr>(Lua_UnityEngine_RigidbodySleepMode2D.reg);
			}
			array[num371] = BindUnity.<>f__mg$cache172;
			int num372 = 371;
			if (BindUnity.<>f__mg$cache173 == null)
			{
				BindUnity.<>f__mg$cache173 = new Action<IntPtr>(Lua_UnityEngine_CollisionDetectionMode2D.reg);
			}
			array[num372] = BindUnity.<>f__mg$cache173;
			int num373 = 372;
			if (BindUnity.<>f__mg$cache174 == null)
			{
				BindUnity.<>f__mg$cache174 = new Action<IntPtr>(Lua_UnityEngine_RigidbodyType2D.reg);
			}
			array[num373] = BindUnity.<>f__mg$cache174;
			int num374 = 373;
			if (BindUnity.<>f__mg$cache175 == null)
			{
				BindUnity.<>f__mg$cache175 = new Action<IntPtr>(Lua_UnityEngine_ForceMode2D.reg);
			}
			array[num374] = BindUnity.<>f__mg$cache175;
			int num375 = 374;
			if (BindUnity.<>f__mg$cache176 == null)
			{
				BindUnity.<>f__mg$cache176 = new Action<IntPtr>(Lua_UnityEngine_JointLimitState2D.reg);
			}
			array[num375] = BindUnity.<>f__mg$cache176;
			int num376 = 375;
			if (BindUnity.<>f__mg$cache177 == null)
			{
				BindUnity.<>f__mg$cache177 = new Action<IntPtr>(Lua_UnityEngine_EffectorSelection2D.reg);
			}
			array[num376] = BindUnity.<>f__mg$cache177;
			int num377 = 376;
			if (BindUnity.<>f__mg$cache178 == null)
			{
				BindUnity.<>f__mg$cache178 = new Action<IntPtr>(Lua_UnityEngine_EffectorForceMode2D.reg);
			}
			array[num377] = BindUnity.<>f__mg$cache178;
			int num378 = 377;
			if (BindUnity.<>f__mg$cache179 == null)
			{
				BindUnity.<>f__mg$cache179 = new Action<IntPtr>(Lua_UnityEngine_ColliderDistance2D.reg);
			}
			array[num378] = BindUnity.<>f__mg$cache179;
			int num379 = 378;
			if (BindUnity.<>f__mg$cache17A == null)
			{
				BindUnity.<>f__mg$cache17A = new Action<IntPtr>(Lua_UnityEngine_ContactFilter2D.reg);
			}
			array[num379] = BindUnity.<>f__mg$cache17A;
			int num380 = 379;
			if (BindUnity.<>f__mg$cache17B == null)
			{
				BindUnity.<>f__mg$cache17B = new Action<IntPtr>(Lua_UnityEngine_ContactPoint2D.reg);
			}
			array[num380] = BindUnity.<>f__mg$cache17B;
			int num381 = 380;
			if (BindUnity.<>f__mg$cache17C == null)
			{
				BindUnity.<>f__mg$cache17C = new Action<IntPtr>(Lua_UnityEngine_JointAngleLimits2D.reg);
			}
			array[num381] = BindUnity.<>f__mg$cache17C;
			int num382 = 381;
			if (BindUnity.<>f__mg$cache17D == null)
			{
				BindUnity.<>f__mg$cache17D = new Action<IntPtr>(Lua_UnityEngine_JointTranslationLimits2D.reg);
			}
			array[num382] = BindUnity.<>f__mg$cache17D;
			int num383 = 382;
			if (BindUnity.<>f__mg$cache17E == null)
			{
				BindUnity.<>f__mg$cache17E = new Action<IntPtr>(Lua_UnityEngine_JointMotor2D.reg);
			}
			array[num383] = BindUnity.<>f__mg$cache17E;
			int num384 = 383;
			if (BindUnity.<>f__mg$cache17F == null)
			{
				BindUnity.<>f__mg$cache17F = new Action<IntPtr>(Lua_UnityEngine_JointSuspension2D.reg);
			}
			array[num384] = BindUnity.<>f__mg$cache17F;
			int num385 = 384;
			if (BindUnity.<>f__mg$cache180 == null)
			{
				BindUnity.<>f__mg$cache180 = new Action<IntPtr>(Lua_UnityEngine_RaycastHit2D.reg);
			}
			array[num385] = BindUnity.<>f__mg$cache180;
			int num386 = 385;
			if (BindUnity.<>f__mg$cache181 == null)
			{
				BindUnity.<>f__mg$cache181 = new Action<IntPtr>(Lua_UnityEngine_CircleCollider2D.reg);
			}
			array[num386] = BindUnity.<>f__mg$cache181;
			int num387 = 386;
			if (BindUnity.<>f__mg$cache182 == null)
			{
				BindUnity.<>f__mg$cache182 = new Action<IntPtr>(Lua_UnityEngine_CapsuleCollider2D.reg);
			}
			array[num387] = BindUnity.<>f__mg$cache182;
			int num388 = 387;
			if (BindUnity.<>f__mg$cache183 == null)
			{
				BindUnity.<>f__mg$cache183 = new Action<IntPtr>(Lua_UnityEngine_BoxCollider2D.reg);
			}
			array[num388] = BindUnity.<>f__mg$cache183;
			int num389 = 388;
			if (BindUnity.<>f__mg$cache184 == null)
			{
				BindUnity.<>f__mg$cache184 = new Action<IntPtr>(Lua_UnityEngine_Joint2D.reg);
			}
			array[num389] = BindUnity.<>f__mg$cache184;
			int num390 = 389;
			if (BindUnity.<>f__mg$cache185 == null)
			{
				BindUnity.<>f__mg$cache185 = new Action<IntPtr>(Lua_UnityEngine_AnchoredJoint2D.reg);
			}
			array[num390] = BindUnity.<>f__mg$cache185;
			int num391 = 390;
			if (BindUnity.<>f__mg$cache186 == null)
			{
				BindUnity.<>f__mg$cache186 = new Action<IntPtr>(Lua_UnityEngine_SpringJoint2D.reg);
			}
			array[num391] = BindUnity.<>f__mg$cache186;
			int num392 = 391;
			if (BindUnity.<>f__mg$cache187 == null)
			{
				BindUnity.<>f__mg$cache187 = new Action<IntPtr>(Lua_UnityEngine_DistanceJoint2D.reg);
			}
			array[num392] = BindUnity.<>f__mg$cache187;
			int num393 = 392;
			if (BindUnity.<>f__mg$cache188 == null)
			{
				BindUnity.<>f__mg$cache188 = new Action<IntPtr>(Lua_UnityEngine_FrictionJoint2D.reg);
			}
			array[num393] = BindUnity.<>f__mg$cache188;
			int num394 = 393;
			if (BindUnity.<>f__mg$cache189 == null)
			{
				BindUnity.<>f__mg$cache189 = new Action<IntPtr>(Lua_UnityEngine_HingeJoint2D.reg);
			}
			array[num394] = BindUnity.<>f__mg$cache189;
			int num395 = 394;
			if (BindUnity.<>f__mg$cache18A == null)
			{
				BindUnity.<>f__mg$cache18A = new Action<IntPtr>(Lua_UnityEngine_RelativeJoint2D.reg);
			}
			array[num395] = BindUnity.<>f__mg$cache18A;
			int num396 = 395;
			if (BindUnity.<>f__mg$cache18B == null)
			{
				BindUnity.<>f__mg$cache18B = new Action<IntPtr>(Lua_UnityEngine_SliderJoint2D.reg);
			}
			array[num396] = BindUnity.<>f__mg$cache18B;
			int num397 = 396;
			if (BindUnity.<>f__mg$cache18C == null)
			{
				BindUnity.<>f__mg$cache18C = new Action<IntPtr>(Lua_UnityEngine_TargetJoint2D.reg);
			}
			array[num397] = BindUnity.<>f__mg$cache18C;
			int num398 = 397;
			if (BindUnity.<>f__mg$cache18D == null)
			{
				BindUnity.<>f__mg$cache18D = new Action<IntPtr>(Lua_UnityEngine_FixedJoint2D.reg);
			}
			array[num398] = BindUnity.<>f__mg$cache18D;
			int num399 = 398;
			if (BindUnity.<>f__mg$cache18E == null)
			{
				BindUnity.<>f__mg$cache18E = new Action<IntPtr>(Lua_UnityEngine_WheelJoint2D.reg);
			}
			array[num399] = BindUnity.<>f__mg$cache18E;
			int num400 = 399;
			if (BindUnity.<>f__mg$cache18F == null)
			{
				BindUnity.<>f__mg$cache18F = new Action<IntPtr>(Lua_UnityEngine_Effector2D.reg);
			}
			array[num400] = BindUnity.<>f__mg$cache18F;
			int num401 = 400;
			if (BindUnity.<>f__mg$cache190 == null)
			{
				BindUnity.<>f__mg$cache190 = new Action<IntPtr>(Lua_UnityEngine_AreaEffector2D.reg);
			}
			array[num401] = BindUnity.<>f__mg$cache190;
			int num402 = 401;
			if (BindUnity.<>f__mg$cache191 == null)
			{
				BindUnity.<>f__mg$cache191 = new Action<IntPtr>(Lua_UnityEngine_BuoyancyEffector2D.reg);
			}
			array[num402] = BindUnity.<>f__mg$cache191;
			int num403 = 402;
			if (BindUnity.<>f__mg$cache192 == null)
			{
				BindUnity.<>f__mg$cache192 = new Action<IntPtr>(Lua_UnityEngine_PointEffector2D.reg);
			}
			array[num403] = BindUnity.<>f__mg$cache192;
			int num404 = 403;
			if (BindUnity.<>f__mg$cache193 == null)
			{
				BindUnity.<>f__mg$cache193 = new Action<IntPtr>(Lua_UnityEngine_PlatformEffector2D.reg);
			}
			array[num404] = BindUnity.<>f__mg$cache193;
			int num405 = 404;
			if (BindUnity.<>f__mg$cache194 == null)
			{
				BindUnity.<>f__mg$cache194 = new Action<IntPtr>(Lua_UnityEngine_SurfaceEffector2D.reg);
			}
			array[num405] = BindUnity.<>f__mg$cache194;
			int num406 = 405;
			if (BindUnity.<>f__mg$cache195 == null)
			{
				BindUnity.<>f__mg$cache195 = new Action<IntPtr>(Lua_UnityEngine_PhysicsUpdateBehaviour2D.reg);
			}
			array[num406] = BindUnity.<>f__mg$cache195;
			int num407 = 406;
			if (BindUnity.<>f__mg$cache196 == null)
			{
				BindUnity.<>f__mg$cache196 = new Action<IntPtr>(Lua_UnityEngine_ConstantForce2D.reg);
			}
			array[num407] = BindUnity.<>f__mg$cache196;
			int num408 = 407;
			if (BindUnity.<>f__mg$cache197 == null)
			{
				BindUnity.<>f__mg$cache197 = new Action<IntPtr>(Lua_UnityEngine_PhysicsMaterial2D.reg);
			}
			array[num408] = BindUnity.<>f__mg$cache197;
			int num409 = 408;
			if (BindUnity.<>f__mg$cache198 == null)
			{
				BindUnity.<>f__mg$cache198 = new Action<IntPtr>(Lua_UnityEngine_AnimationEvent.reg);
			}
			array[num409] = BindUnity.<>f__mg$cache198;
			int num410 = 409;
			if (BindUnity.<>f__mg$cache199 == null)
			{
				BindUnity.<>f__mg$cache199 = new Action<IntPtr>(Lua_UnityEngine_AnimationClip.reg);
			}
			array[num410] = BindUnity.<>f__mg$cache199;
			int num411 = 410;
			if (BindUnity.<>f__mg$cache19A == null)
			{
				BindUnity.<>f__mg$cache19A = new Action<IntPtr>(Lua_UnityEngine_PlayMode.reg);
			}
			array[num411] = BindUnity.<>f__mg$cache19A;
			int num412 = 411;
			if (BindUnity.<>f__mg$cache19B == null)
			{
				BindUnity.<>f__mg$cache19B = new Action<IntPtr>(Lua_UnityEngine_QueueMode.reg);
			}
			array[num412] = BindUnity.<>f__mg$cache19B;
			int num413 = 412;
			if (BindUnity.<>f__mg$cache19C == null)
			{
				BindUnity.<>f__mg$cache19C = new Action<IntPtr>(Lua_UnityEngine_AnimationBlendMode.reg);
			}
			array[num413] = BindUnity.<>f__mg$cache19C;
			int num414 = 413;
			if (BindUnity.<>f__mg$cache19D == null)
			{
				BindUnity.<>f__mg$cache19D = new Action<IntPtr>(Lua_UnityEngine_AnimationPlayMode.reg);
			}
			array[num414] = BindUnity.<>f__mg$cache19D;
			int num415 = 414;
			if (BindUnity.<>f__mg$cache19E == null)
			{
				BindUnity.<>f__mg$cache19E = new Action<IntPtr>(Lua_UnityEngine_AnimationCullingType.reg);
			}
			array[num415] = BindUnity.<>f__mg$cache19E;
			int num416 = 415;
			if (BindUnity.<>f__mg$cache19F == null)
			{
				BindUnity.<>f__mg$cache19F = new Action<IntPtr>(Lua_UnityEngine_Animation.reg);
			}
			array[num416] = BindUnity.<>f__mg$cache19F;
			int num417 = 416;
			if (BindUnity.<>f__mg$cache1A0 == null)
			{
				BindUnity.<>f__mg$cache1A0 = new Action<IntPtr>(Lua_UnityEngine_AnimationState.reg);
			}
			array[num417] = BindUnity.<>f__mg$cache1A0;
			int num418 = 417;
			if (BindUnity.<>f__mg$cache1A1 == null)
			{
				BindUnity.<>f__mg$cache1A1 = new Action<IntPtr>(Lua_UnityEngine_AvatarTarget.reg);
			}
			array[num418] = BindUnity.<>f__mg$cache1A1;
			int num419 = 418;
			if (BindUnity.<>f__mg$cache1A2 == null)
			{
				BindUnity.<>f__mg$cache1A2 = new Action<IntPtr>(Lua_UnityEngine_AvatarIKGoal.reg);
			}
			array[num419] = BindUnity.<>f__mg$cache1A2;
			int num420 = 419;
			if (BindUnity.<>f__mg$cache1A3 == null)
			{
				BindUnity.<>f__mg$cache1A3 = new Action<IntPtr>(Lua_UnityEngine_AvatarIKHint.reg);
			}
			array[num420] = BindUnity.<>f__mg$cache1A3;
			int num421 = 420;
			if (BindUnity.<>f__mg$cache1A4 == null)
			{
				BindUnity.<>f__mg$cache1A4 = new Action<IntPtr>(Lua_UnityEngine_AnimatorControllerParameterType.reg);
			}
			array[num421] = BindUnity.<>f__mg$cache1A4;
			int num422 = 421;
			if (BindUnity.<>f__mg$cache1A5 == null)
			{
				BindUnity.<>f__mg$cache1A5 = new Action<IntPtr>(Lua_UnityEngine_AnimatorRecorderMode.reg);
			}
			array[num422] = BindUnity.<>f__mg$cache1A5;
			int num423 = 422;
			if (BindUnity.<>f__mg$cache1A6 == null)
			{
				BindUnity.<>f__mg$cache1A6 = new Action<IntPtr>(Lua_UnityEngine_AnimatorClipInfo.reg);
			}
			array[num423] = BindUnity.<>f__mg$cache1A6;
			int num424 = 423;
			if (BindUnity.<>f__mg$cache1A7 == null)
			{
				BindUnity.<>f__mg$cache1A7 = new Action<IntPtr>(Lua_UnityEngine_AnimatorCullingMode.reg);
			}
			array[num424] = BindUnity.<>f__mg$cache1A7;
			int num425 = 424;
			if (BindUnity.<>f__mg$cache1A8 == null)
			{
				BindUnity.<>f__mg$cache1A8 = new Action<IntPtr>(Lua_UnityEngine_AnimatorUpdateMode.reg);
			}
			array[num425] = BindUnity.<>f__mg$cache1A8;
			int num426 = 425;
			if (BindUnity.<>f__mg$cache1A9 == null)
			{
				BindUnity.<>f__mg$cache1A9 = new Action<IntPtr>(Lua_UnityEngine_AnimatorStateInfo.reg);
			}
			array[num426] = BindUnity.<>f__mg$cache1A9;
			int num427 = 426;
			if (BindUnity.<>f__mg$cache1AA == null)
			{
				BindUnity.<>f__mg$cache1AA = new Action<IntPtr>(Lua_UnityEngine_DurationUnit.reg);
			}
			array[num427] = BindUnity.<>f__mg$cache1AA;
			int num428 = 427;
			if (BindUnity.<>f__mg$cache1AB == null)
			{
				BindUnity.<>f__mg$cache1AB = new Action<IntPtr>(Lua_UnityEngine_AnimatorTransitionInfo.reg);
			}
			array[num428] = BindUnity.<>f__mg$cache1AB;
			int num429 = 428;
			if (BindUnity.<>f__mg$cache1AC == null)
			{
				BindUnity.<>f__mg$cache1AC = new Action<IntPtr>(Lua_UnityEngine_MatchTargetWeightMask.reg);
			}
			array[num429] = BindUnity.<>f__mg$cache1AC;
			int num430 = 429;
			if (BindUnity.<>f__mg$cache1AD == null)
			{
				BindUnity.<>f__mg$cache1AD = new Action<IntPtr>(Lua_UnityEngine_Animator.reg);
			}
			array[num430] = BindUnity.<>f__mg$cache1AD;
			int num431 = 430;
			if (BindUnity.<>f__mg$cache1AE == null)
			{
				BindUnity.<>f__mg$cache1AE = new Action<IntPtr>(Lua_UnityEngine_AnimatorControllerParameter.reg);
			}
			array[num431] = BindUnity.<>f__mg$cache1AE;
			int num432 = 431;
			if (BindUnity.<>f__mg$cache1AF == null)
			{
				BindUnity.<>f__mg$cache1AF = new Action<IntPtr>(Lua_UnityEngine_Animations_AnimatorControllerPlayable.reg);
			}
			array[num432] = BindUnity.<>f__mg$cache1AF;
			int num433 = 432;
			if (BindUnity.<>f__mg$cache1B0 == null)
			{
				BindUnity.<>f__mg$cache1B0 = new Action<IntPtr>(Lua_UnityEngine_RuntimeAnimatorController.reg);
			}
			array[num433] = BindUnity.<>f__mg$cache1B0;
			int num434 = 433;
			if (BindUnity.<>f__mg$cache1B1 == null)
			{
				BindUnity.<>f__mg$cache1B1 = new Action<IntPtr>(Lua_UnityEngine_AnimatorOverrideController.reg);
			}
			array[num434] = BindUnity.<>f__mg$cache1B1;
			int num435 = 434;
			if (BindUnity.<>f__mg$cache1B2 == null)
			{
				BindUnity.<>f__mg$cache1B2 = new Action<IntPtr>(Lua_UnityEngine_AnimatorUtility.reg);
			}
			array[num435] = BindUnity.<>f__mg$cache1B2;
			int num436 = 435;
			if (BindUnity.<>f__mg$cache1B3 == null)
			{
				BindUnity.<>f__mg$cache1B3 = new Action<IntPtr>(Lua_UnityEngine_HumanBodyBones.reg);
			}
			array[num436] = BindUnity.<>f__mg$cache1B3;
			int num437 = 436;
			if (BindUnity.<>f__mg$cache1B4 == null)
			{
				BindUnity.<>f__mg$cache1B4 = new Action<IntPtr>(Lua_UnityEngine_Avatar.reg);
			}
			array[num437] = BindUnity.<>f__mg$cache1B4;
			int num438 = 437;
			if (BindUnity.<>f__mg$cache1B5 == null)
			{
				BindUnity.<>f__mg$cache1B5 = new Action<IntPtr>(Lua_UnityEngine_HumanTrait.reg);
			}
			array[num438] = BindUnity.<>f__mg$cache1B5;
			int num439 = 438;
			if (BindUnity.<>f__mg$cache1B6 == null)
			{
				BindUnity.<>f__mg$cache1B6 = new Action<IntPtr>(Lua_UnityEngine_SkeletonBone.reg);
			}
			array[num439] = BindUnity.<>f__mg$cache1B6;
			int num440 = 439;
			if (BindUnity.<>f__mg$cache1B7 == null)
			{
				BindUnity.<>f__mg$cache1B7 = new Action<IntPtr>(Lua_UnityEngine_HumanLimit.reg);
			}
			array[num440] = BindUnity.<>f__mg$cache1B7;
			int num441 = 440;
			if (BindUnity.<>f__mg$cache1B8 == null)
			{
				BindUnity.<>f__mg$cache1B8 = new Action<IntPtr>(Lua_UnityEngine_HumanBone.reg);
			}
			array[num441] = BindUnity.<>f__mg$cache1B8;
			int num442 = 441;
			if (BindUnity.<>f__mg$cache1B9 == null)
			{
				BindUnity.<>f__mg$cache1B9 = new Action<IntPtr>(Lua_UnityEngine_HumanDescription.reg);
			}
			array[num442] = BindUnity.<>f__mg$cache1B9;
			int num443 = 442;
			if (BindUnity.<>f__mg$cache1BA == null)
			{
				BindUnity.<>f__mg$cache1BA = new Action<IntPtr>(Lua_UnityEngine_AvatarBuilder.reg);
			}
			array[num443] = BindUnity.<>f__mg$cache1BA;
			int num444 = 443;
			if (BindUnity.<>f__mg$cache1BB == null)
			{
				BindUnity.<>f__mg$cache1BB = new Action<IntPtr>(Lua_UnityEngine_AvatarMaskBodyPart.reg);
			}
			array[num444] = BindUnity.<>f__mg$cache1BB;
			int num445 = 444;
			if (BindUnity.<>f__mg$cache1BC == null)
			{
				BindUnity.<>f__mg$cache1BC = new Action<IntPtr>(Lua_UnityEngine_AvatarMask.reg);
			}
			array[num445] = BindUnity.<>f__mg$cache1BC;
			int num446 = 445;
			if (BindUnity.<>f__mg$cache1BD == null)
			{
				BindUnity.<>f__mg$cache1BD = new Action<IntPtr>(Lua_UnityEngine_HumanPose.reg);
			}
			array[num446] = BindUnity.<>f__mg$cache1BD;
			int num447 = 446;
			if (BindUnity.<>f__mg$cache1BE == null)
			{
				BindUnity.<>f__mg$cache1BE = new Action<IntPtr>(Lua_UnityEngine_HumanPoseHandler.reg);
			}
			array[num447] = BindUnity.<>f__mg$cache1BE;
			int num448 = 447;
			if (BindUnity.<>f__mg$cache1BF == null)
			{
				BindUnity.<>f__mg$cache1BF = new Action<IntPtr>(Lua_UnityEngine_Playables_AnimationPlayableUtilities.reg);
			}
			array[num448] = BindUnity.<>f__mg$cache1BF;
			int num449 = 448;
			if (BindUnity.<>f__mg$cache1C0 == null)
			{
				BindUnity.<>f__mg$cache1C0 = new Action<IntPtr>(Lua_UnityEngine_StateMachineBehaviour.reg);
			}
			array[num449] = BindUnity.<>f__mg$cache1C0;
			int num450 = 449;
			if (BindUnity.<>f__mg$cache1C1 == null)
			{
				BindUnity.<>f__mg$cache1C1 = new Action<IntPtr>(Lua_UnityEngine_Animations_AnimationClipPlayable.reg);
			}
			array[num450] = BindUnity.<>f__mg$cache1C1;
			int num451 = 450;
			if (BindUnity.<>f__mg$cache1C2 == null)
			{
				BindUnity.<>f__mg$cache1C2 = new Action<IntPtr>(Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.reg);
			}
			array[num451] = BindUnity.<>f__mg$cache1C2;
			int num452 = 451;
			if (BindUnity.<>f__mg$cache1C3 == null)
			{
				BindUnity.<>f__mg$cache1C3 = new Action<IntPtr>(Lua_UnityEngine_Animations_AnimationMixerPlayable.reg);
			}
			array[num452] = BindUnity.<>f__mg$cache1C3;
			int num453 = 452;
			if (BindUnity.<>f__mg$cache1C4 == null)
			{
				BindUnity.<>f__mg$cache1C4 = new Action<IntPtr>(Lua_UnityEngine_Animations_AnimationPlayableExtensions.reg);
			}
			array[num453] = BindUnity.<>f__mg$cache1C4;
			int num454 = 453;
			if (BindUnity.<>f__mg$cache1C5 == null)
			{
				BindUnity.<>f__mg$cache1C5 = new Action<IntPtr>(Lua_UnityEngine_Animations_AnimationPlayableOutput.reg);
			}
			array[num454] = BindUnity.<>f__mg$cache1C5;
			int num455 = 454;
			if (BindUnity.<>f__mg$cache1C6 == null)
			{
				BindUnity.<>f__mg$cache1C6 = new Action<IntPtr>(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.reg);
			}
			array[num455] = BindUnity.<>f__mg$cache1C6;
			int num456 = 455;
			if (BindUnity.<>f__mg$cache1C7 == null)
			{
				BindUnity.<>f__mg$cache1C7 = new Action<IntPtr>(Lua_UnityEngine_Event.reg);
			}
			array[num456] = BindUnity.<>f__mg$cache1C7;
			int num457 = 456;
			if (BindUnity.<>f__mg$cache1C8 == null)
			{
				BindUnity.<>f__mg$cache1C8 = new Action<IntPtr>(Lua_UnityEngine_ScaleMode.reg);
			}
			array[num457] = BindUnity.<>f__mg$cache1C8;
			int num458 = 457;
			if (BindUnity.<>f__mg$cache1C9 == null)
			{
				BindUnity.<>f__mg$cache1C9 = new Action<IntPtr>(Lua_UnityEngine_FocusType.reg);
			}
			array[num458] = BindUnity.<>f__mg$cache1C9;
			int num459 = 458;
			if (BindUnity.<>f__mg$cache1CA == null)
			{
				BindUnity.<>f__mg$cache1CA = new Action<IntPtr>(Lua_UnityEngine_ImagePosition.reg);
			}
			array[num459] = BindUnity.<>f__mg$cache1CA;
			int num460 = 459;
			if (BindUnity.<>f__mg$cache1CB == null)
			{
				BindUnity.<>f__mg$cache1CB = new Action<IntPtr>(Lua_UnityEngine_WWWForm.reg);
			}
			array[num460] = BindUnity.<>f__mg$cache1CB;
			int num461 = 460;
			if (BindUnity.<>f__mg$cache1CC == null)
			{
				BindUnity.<>f__mg$cache1CC = new Action<IntPtr>(Lua_UnityEngine_Physics.reg);
			}
			array[num461] = BindUnity.<>f__mg$cache1CC;
			int num462 = 461;
			if (BindUnity.<>f__mg$cache1CD == null)
			{
				BindUnity.<>f__mg$cache1CD = new Action<IntPtr>(Lua_UnityEngine_ContactPoint.reg);
			}
			array[num462] = BindUnity.<>f__mg$cache1CD;
			int num463 = 462;
			if (BindUnity.<>f__mg$cache1CE == null)
			{
				BindUnity.<>f__mg$cache1CE = new Action<IntPtr>(Lua_UnityEngine_Rigidbody.reg);
			}
			array[num463] = BindUnity.<>f__mg$cache1CE;
			int num464 = 463;
			if (BindUnity.<>f__mg$cache1CF == null)
			{
				BindUnity.<>f__mg$cache1CF = new Action<IntPtr>(Lua_UnityEngine_Joint.reg);
			}
			array[num464] = BindUnity.<>f__mg$cache1CF;
			int num465 = 464;
			if (BindUnity.<>f__mg$cache1D0 == null)
			{
				BindUnity.<>f__mg$cache1D0 = new Action<IntPtr>(Lua_UnityEngine_HingeJoint.reg);
			}
			array[num465] = BindUnity.<>f__mg$cache1D0;
			int num466 = 465;
			if (BindUnity.<>f__mg$cache1D1 == null)
			{
				BindUnity.<>f__mg$cache1D1 = new Action<IntPtr>(Lua_UnityEngine_SpringJoint.reg);
			}
			array[num466] = BindUnity.<>f__mg$cache1D1;
			int num467 = 466;
			if (BindUnity.<>f__mg$cache1D2 == null)
			{
				BindUnity.<>f__mg$cache1D2 = new Action<IntPtr>(Lua_UnityEngine_FixedJoint.reg);
			}
			array[num467] = BindUnity.<>f__mg$cache1D2;
			int num468 = 467;
			if (BindUnity.<>f__mg$cache1D3 == null)
			{
				BindUnity.<>f__mg$cache1D3 = new Action<IntPtr>(Lua_UnityEngine_CharacterJoint.reg);
			}
			array[num468] = BindUnity.<>f__mg$cache1D3;
			int num469 = 468;
			if (BindUnity.<>f__mg$cache1D4 == null)
			{
				BindUnity.<>f__mg$cache1D4 = new Action<IntPtr>(Lua_UnityEngine_RotationDriveMode.reg);
			}
			array[num469] = BindUnity.<>f__mg$cache1D4;
			int num470 = 469;
			if (BindUnity.<>f__mg$cache1D5 == null)
			{
				BindUnity.<>f__mg$cache1D5 = new Action<IntPtr>(Lua_UnityEngine_ConfigurableJoint.reg);
			}
			array[num470] = BindUnity.<>f__mg$cache1D5;
			int num471 = 470;
			if (BindUnity.<>f__mg$cache1D6 == null)
			{
				BindUnity.<>f__mg$cache1D6 = new Action<IntPtr>(Lua_UnityEngine_ConstantForce.reg);
			}
			array[num471] = BindUnity.<>f__mg$cache1D6;
			int num472 = 471;
			if (BindUnity.<>f__mg$cache1D7 == null)
			{
				BindUnity.<>f__mg$cache1D7 = new Action<IntPtr>(Lua_UnityEngine_CollisionDetectionMode.reg);
			}
			array[num472] = BindUnity.<>f__mg$cache1D7;
			int num473 = 472;
			if (BindUnity.<>f__mg$cache1D8 == null)
			{
				BindUnity.<>f__mg$cache1D8 = new Action<IntPtr>(Lua_UnityEngine_Collider.reg);
			}
			array[num473] = BindUnity.<>f__mg$cache1D8;
			int num474 = 473;
			if (BindUnity.<>f__mg$cache1D9 == null)
			{
				BindUnity.<>f__mg$cache1D9 = new Action<IntPtr>(Lua_UnityEngine_BoxCollider.reg);
			}
			array[num474] = BindUnity.<>f__mg$cache1D9;
			int num475 = 474;
			if (BindUnity.<>f__mg$cache1DA == null)
			{
				BindUnity.<>f__mg$cache1DA = new Action<IntPtr>(Lua_UnityEngine_SphereCollider.reg);
			}
			array[num475] = BindUnity.<>f__mg$cache1DA;
			int num476 = 475;
			if (BindUnity.<>f__mg$cache1DB == null)
			{
				BindUnity.<>f__mg$cache1DB = new Action<IntPtr>(Lua_UnityEngine_MeshCollider.reg);
			}
			array[num476] = BindUnity.<>f__mg$cache1DB;
			int num477 = 476;
			if (BindUnity.<>f__mg$cache1DC == null)
			{
				BindUnity.<>f__mg$cache1DC = new Action<IntPtr>(Lua_UnityEngine_CapsuleCollider.reg);
			}
			array[num477] = BindUnity.<>f__mg$cache1DC;
			int num478 = 477;
			if (BindUnity.<>f__mg$cache1DD == null)
			{
				BindUnity.<>f__mg$cache1DD = new Action<IntPtr>(Lua_UnityEngine_RaycastHit.reg);
			}
			array[num478] = BindUnity.<>f__mg$cache1DD;
			int num479 = 478;
			if (BindUnity.<>f__mg$cache1DE == null)
			{
				BindUnity.<>f__mg$cache1DE = new Action<IntPtr>(Lua_UnityEngine_PhysicMaterial.reg);
			}
			array[num479] = BindUnity.<>f__mg$cache1DE;
			int num480 = 479;
			if (BindUnity.<>f__mg$cache1DF == null)
			{
				BindUnity.<>f__mg$cache1DF = new Action<IntPtr>(Lua_UnityEngine_CharacterController.reg);
			}
			array[num480] = BindUnity.<>f__mg$cache1DF;
			int num481 = 480;
			if (BindUnity.<>f__mg$cache1E0 == null)
			{
				BindUnity.<>f__mg$cache1E0 = new Action<IntPtr>(Lua_UnityEngine_RigidbodyConstraints.reg);
			}
			array[num481] = BindUnity.<>f__mg$cache1E0;
			int num482 = 481;
			if (BindUnity.<>f__mg$cache1E1 == null)
			{
				BindUnity.<>f__mg$cache1E1 = new Action<IntPtr>(Lua_UnityEngine_ForceMode.reg);
			}
			array[num482] = BindUnity.<>f__mg$cache1E1;
			int num483 = 482;
			if (BindUnity.<>f__mg$cache1E2 == null)
			{
				BindUnity.<>f__mg$cache1E2 = new Action<IntPtr>(Lua_UnityEngine_JointProjectionMode.reg);
			}
			array[num483] = BindUnity.<>f__mg$cache1E2;
			int num484 = 483;
			if (BindUnity.<>f__mg$cache1E3 == null)
			{
				BindUnity.<>f__mg$cache1E3 = new Action<IntPtr>(Lua_UnityEngine_MeshColliderCookingOptions.reg);
			}
			array[num484] = BindUnity.<>f__mg$cache1E3;
			int num485 = 484;
			if (BindUnity.<>f__mg$cache1E4 == null)
			{
				BindUnity.<>f__mg$cache1E4 = new Action<IntPtr>(Lua_UnityEngine_WheelFrictionCurve.reg);
			}
			array[num485] = BindUnity.<>f__mg$cache1E4;
			int num486 = 485;
			if (BindUnity.<>f__mg$cache1E5 == null)
			{
				BindUnity.<>f__mg$cache1E5 = new Action<IntPtr>(Lua_UnityEngine_SoftJointLimit.reg);
			}
			array[num486] = BindUnity.<>f__mg$cache1E5;
			int num487 = 486;
			if (BindUnity.<>f__mg$cache1E6 == null)
			{
				BindUnity.<>f__mg$cache1E6 = new Action<IntPtr>(Lua_UnityEngine_SoftJointLimitSpring.reg);
			}
			array[num487] = BindUnity.<>f__mg$cache1E6;
			int num488 = 487;
			if (BindUnity.<>f__mg$cache1E7 == null)
			{
				BindUnity.<>f__mg$cache1E7 = new Action<IntPtr>(Lua_UnityEngine_JointDrive.reg);
			}
			array[num488] = BindUnity.<>f__mg$cache1E7;
			int num489 = 488;
			if (BindUnity.<>f__mg$cache1E8 == null)
			{
				BindUnity.<>f__mg$cache1E8 = new Action<IntPtr>(Lua_UnityEngine_RigidbodyInterpolation.reg);
			}
			array[num489] = BindUnity.<>f__mg$cache1E8;
			int num490 = 489;
			if (BindUnity.<>f__mg$cache1E9 == null)
			{
				BindUnity.<>f__mg$cache1E9 = new Action<IntPtr>(Lua_UnityEngine_JointMotor.reg);
			}
			array[num490] = BindUnity.<>f__mg$cache1E9;
			int num491 = 490;
			if (BindUnity.<>f__mg$cache1EA == null)
			{
				BindUnity.<>f__mg$cache1EA = new Action<IntPtr>(Lua_UnityEngine_JointSpring.reg);
			}
			array[num491] = BindUnity.<>f__mg$cache1EA;
			int num492 = 491;
			if (BindUnity.<>f__mg$cache1EB == null)
			{
				BindUnity.<>f__mg$cache1EB = new Action<IntPtr>(Lua_UnityEngine_JointLimits.reg);
			}
			array[num492] = BindUnity.<>f__mg$cache1EB;
			int num493 = 492;
			if (BindUnity.<>f__mg$cache1EC == null)
			{
				BindUnity.<>f__mg$cache1EC = new Action<IntPtr>(Lua_UnityEngine_ControllerColliderHit.reg);
			}
			array[num493] = BindUnity.<>f__mg$cache1EC;
			int num494 = 493;
			if (BindUnity.<>f__mg$cache1ED == null)
			{
				BindUnity.<>f__mg$cache1ED = new Action<IntPtr>(Lua_UnityEngine_PhysicMaterialCombine.reg);
			}
			array[num494] = BindUnity.<>f__mg$cache1ED;
			int num495 = 494;
			if (BindUnity.<>f__mg$cache1EE == null)
			{
				BindUnity.<>f__mg$cache1EE = new Action<IntPtr>(Lua_UnityEngine_Collision.reg);
			}
			array[num495] = BindUnity.<>f__mg$cache1EE;
			int num496 = 495;
			if (BindUnity.<>f__mg$cache1EF == null)
			{
				BindUnity.<>f__mg$cache1EF = new Action<IntPtr>(Lua_UnityEngine_CollisionFlags.reg);
			}
			array[num496] = BindUnity.<>f__mg$cache1EF;
			int num497 = 496;
			if (BindUnity.<>f__mg$cache1F0 == null)
			{
				BindUnity.<>f__mg$cache1F0 = new Action<IntPtr>(Lua_UnityEngine_QueryTriggerInteraction.reg);
			}
			array[num497] = BindUnity.<>f__mg$cache1F0;
			int num498 = 497;
			if (BindUnity.<>f__mg$cache1F1 == null)
			{
				BindUnity.<>f__mg$cache1F1 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_EventHandle.reg);
			}
			array[num498] = BindUnity.<>f__mg$cache1F1;
			int num499 = 498;
			if (BindUnity.<>f__mg$cache1F2 == null)
			{
				BindUnity.<>f__mg$cache1F2 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IEventSystemHandler.reg);
			}
			array[num499] = BindUnity.<>f__mg$cache1F2;
			int num500 = 499;
			if (BindUnity.<>f__mg$cache1F3 == null)
			{
				BindUnity.<>f__mg$cache1F3 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IPointerEnterHandler.reg);
			}
			array[num500] = BindUnity.<>f__mg$cache1F3;
			int num501 = 500;
			if (BindUnity.<>f__mg$cache1F4 == null)
			{
				BindUnity.<>f__mg$cache1F4 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IPointerExitHandler.reg);
			}
			array[num501] = BindUnity.<>f__mg$cache1F4;
			int num502 = 501;
			if (BindUnity.<>f__mg$cache1F5 == null)
			{
				BindUnity.<>f__mg$cache1F5 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IPointerDownHandler.reg);
			}
			array[num502] = BindUnity.<>f__mg$cache1F5;
			int num503 = 502;
			if (BindUnity.<>f__mg$cache1F6 == null)
			{
				BindUnity.<>f__mg$cache1F6 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IPointerUpHandler.reg);
			}
			array[num503] = BindUnity.<>f__mg$cache1F6;
			int num504 = 503;
			if (BindUnity.<>f__mg$cache1F7 == null)
			{
				BindUnity.<>f__mg$cache1F7 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IPointerClickHandler.reg);
			}
			array[num504] = BindUnity.<>f__mg$cache1F7;
			int num505 = 504;
			if (BindUnity.<>f__mg$cache1F8 == null)
			{
				BindUnity.<>f__mg$cache1F8 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IBeginDragHandler.reg);
			}
			array[num505] = BindUnity.<>f__mg$cache1F8;
			int num506 = 505;
			if (BindUnity.<>f__mg$cache1F9 == null)
			{
				BindUnity.<>f__mg$cache1F9 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IInitializePotentialDragHandler.reg);
			}
			array[num506] = BindUnity.<>f__mg$cache1F9;
			int num507 = 506;
			if (BindUnity.<>f__mg$cache1FA == null)
			{
				BindUnity.<>f__mg$cache1FA = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IDragHandler.reg);
			}
			array[num507] = BindUnity.<>f__mg$cache1FA;
			int num508 = 507;
			if (BindUnity.<>f__mg$cache1FB == null)
			{
				BindUnity.<>f__mg$cache1FB = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IEndDragHandler.reg);
			}
			array[num508] = BindUnity.<>f__mg$cache1FB;
			int num509 = 508;
			if (BindUnity.<>f__mg$cache1FC == null)
			{
				BindUnity.<>f__mg$cache1FC = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IDropHandler.reg);
			}
			array[num509] = BindUnity.<>f__mg$cache1FC;
			int num510 = 509;
			if (BindUnity.<>f__mg$cache1FD == null)
			{
				BindUnity.<>f__mg$cache1FD = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IScrollHandler.reg);
			}
			array[num510] = BindUnity.<>f__mg$cache1FD;
			int num511 = 510;
			if (BindUnity.<>f__mg$cache1FE == null)
			{
				BindUnity.<>f__mg$cache1FE = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IUpdateSelectedHandler.reg);
			}
			array[num511] = BindUnity.<>f__mg$cache1FE;
			int num512 = 511;
			if (BindUnity.<>f__mg$cache1FF == null)
			{
				BindUnity.<>f__mg$cache1FF = new Action<IntPtr>(Lua_UnityEngine_EventSystems_ISelectHandler.reg);
			}
			array[num512] = BindUnity.<>f__mg$cache1FF;
			int num513 = 512;
			if (BindUnity.<>f__mg$cache200 == null)
			{
				BindUnity.<>f__mg$cache200 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IDeselectHandler.reg);
			}
			array[num513] = BindUnity.<>f__mg$cache200;
			int num514 = 513;
			if (BindUnity.<>f__mg$cache201 == null)
			{
				BindUnity.<>f__mg$cache201 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_IMoveHandler.reg);
			}
			array[num514] = BindUnity.<>f__mg$cache201;
			int num515 = 514;
			if (BindUnity.<>f__mg$cache202 == null)
			{
				BindUnity.<>f__mg$cache202 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_ISubmitHandler.reg);
			}
			array[num515] = BindUnity.<>f__mg$cache202;
			int num516 = 515;
			if (BindUnity.<>f__mg$cache203 == null)
			{
				BindUnity.<>f__mg$cache203 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_ICancelHandler.reg);
			}
			array[num516] = BindUnity.<>f__mg$cache203;
			int num517 = 516;
			if (BindUnity.<>f__mg$cache204 == null)
			{
				BindUnity.<>f__mg$cache204 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_UIBehaviour.reg);
			}
			array[num517] = BindUnity.<>f__mg$cache204;
			int num518 = 517;
			if (BindUnity.<>f__mg$cache205 == null)
			{
				BindUnity.<>f__mg$cache205 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_EventSystem.reg);
			}
			array[num518] = BindUnity.<>f__mg$cache205;
			int num519 = 518;
			if (BindUnity.<>f__mg$cache206 == null)
			{
				BindUnity.<>f__mg$cache206 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_EventTrigger.reg);
			}
			array[num519] = BindUnity.<>f__mg$cache206;
			int num520 = 519;
			if (BindUnity.<>f__mg$cache207 == null)
			{
				BindUnity.<>f__mg$cache207 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent.reg);
			}
			array[num520] = BindUnity.<>f__mg$cache207;
			int num521 = 520;
			if (BindUnity.<>f__mg$cache208 == null)
			{
				BindUnity.<>f__mg$cache208 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_EventTrigger_Entry.reg);
			}
			array[num521] = BindUnity.<>f__mg$cache208;
			int num522 = 521;
			if (BindUnity.<>f__mg$cache209 == null)
			{
				BindUnity.<>f__mg$cache209 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_EventTriggerType.reg);
			}
			array[num522] = BindUnity.<>f__mg$cache209;
			int num523 = 522;
			if (BindUnity.<>f__mg$cache20A == null)
			{
				BindUnity.<>f__mg$cache20A = new Action<IntPtr>(Lua_UnityEngine_EventSystems_ExecuteEvents.reg);
			}
			array[num523] = BindUnity.<>f__mg$cache20A;
			int num524 = 523;
			if (BindUnity.<>f__mg$cache20B == null)
			{
				BindUnity.<>f__mg$cache20B = new Action<IntPtr>(Lua_UnityEngine_EventSystems_MoveDirection.reg);
			}
			array[num524] = BindUnity.<>f__mg$cache20B;
			int num525 = 524;
			if (BindUnity.<>f__mg$cache20C == null)
			{
				BindUnity.<>f__mg$cache20C = new Action<IntPtr>(Lua_UnityEngine_EventSystems_RaycastResult.reg);
			}
			array[num525] = BindUnity.<>f__mg$cache20C;
			int num526 = 525;
			if (BindUnity.<>f__mg$cache20D == null)
			{
				BindUnity.<>f__mg$cache20D = new Action<IntPtr>(Lua_UnityEngine_EventSystems_AbstractEventData.reg);
			}
			array[num526] = BindUnity.<>f__mg$cache20D;
			int num527 = 526;
			if (BindUnity.<>f__mg$cache20E == null)
			{
				BindUnity.<>f__mg$cache20E = new Action<IntPtr>(Lua_UnityEngine_EventSystems_BaseEventData.reg);
			}
			array[num527] = BindUnity.<>f__mg$cache20E;
			int num528 = 527;
			if (BindUnity.<>f__mg$cache20F == null)
			{
				BindUnity.<>f__mg$cache20F = new Action<IntPtr>(Lua_UnityEngine_EventSystems_AxisEventData.reg);
			}
			array[num528] = BindUnity.<>f__mg$cache20F;
			int num529 = 528;
			if (BindUnity.<>f__mg$cache210 == null)
			{
				BindUnity.<>f__mg$cache210 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_PointerEventData.reg);
			}
			array[num529] = BindUnity.<>f__mg$cache210;
			int num530 = 529;
			if (BindUnity.<>f__mg$cache211 == null)
			{
				BindUnity.<>f__mg$cache211 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_PointerEventData_InputButton.reg);
			}
			array[num530] = BindUnity.<>f__mg$cache211;
			int num531 = 530;
			if (BindUnity.<>f__mg$cache212 == null)
			{
				BindUnity.<>f__mg$cache212 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_PointerEventData_FramePressState.reg);
			}
			array[num531] = BindUnity.<>f__mg$cache212;
			int num532 = 531;
			if (BindUnity.<>f__mg$cache213 == null)
			{
				BindUnity.<>f__mg$cache213 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_BaseInput.reg);
			}
			array[num532] = BindUnity.<>f__mg$cache213;
			int num533 = 532;
			if (BindUnity.<>f__mg$cache214 == null)
			{
				BindUnity.<>f__mg$cache214 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_BaseInputModule.reg);
			}
			array[num533] = BindUnity.<>f__mg$cache214;
			int num534 = 533;
			if (BindUnity.<>f__mg$cache215 == null)
			{
				BindUnity.<>f__mg$cache215 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_PointerInputModule.reg);
			}
			array[num534] = BindUnity.<>f__mg$cache215;
			int num535 = 534;
			if (BindUnity.<>f__mg$cache216 == null)
			{
				BindUnity.<>f__mg$cache216 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.reg);
			}
			array[num535] = BindUnity.<>f__mg$cache216;
			int num536 = 535;
			if (BindUnity.<>f__mg$cache217 == null)
			{
				BindUnity.<>f__mg$cache217 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_StandaloneInputModule.reg);
			}
			array[num536] = BindUnity.<>f__mg$cache217;
			int num537 = 536;
			if (BindUnity.<>f__mg$cache218 == null)
			{
				BindUnity.<>f__mg$cache218 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_BaseRaycaster.reg);
			}
			array[num537] = BindUnity.<>f__mg$cache218;
			int num538 = 537;
			if (BindUnity.<>f__mg$cache219 == null)
			{
				BindUnity.<>f__mg$cache219 = new Action<IntPtr>(Lua_UnityEngine_EventSystems_PhysicsRaycaster.reg);
			}
			array[num538] = BindUnity.<>f__mg$cache219;
			int num539 = 538;
			if (BindUnity.<>f__mg$cache21A == null)
			{
				BindUnity.<>f__mg$cache21A = new Action<IntPtr>(Lua_UnityEngine_EventSystems_Physics2DRaycaster.reg);
			}
			array[num539] = BindUnity.<>f__mg$cache21A;
			int num540 = 539;
			if (BindUnity.<>f__mg$cache21B == null)
			{
				BindUnity.<>f__mg$cache21B = new Action<IntPtr>(Lua_UnityEngine_UI_AnimationTriggers.reg);
			}
			array[num540] = BindUnity.<>f__mg$cache21B;
			int num541 = 540;
			if (BindUnity.<>f__mg$cache21C == null)
			{
				BindUnity.<>f__mg$cache21C = new Action<IntPtr>(Lua_UnityEngine_UI_Selectable.reg);
			}
			array[num541] = BindUnity.<>f__mg$cache21C;
			int num542 = 541;
			if (BindUnity.<>f__mg$cache21D == null)
			{
				BindUnity.<>f__mg$cache21D = new Action<IntPtr>(Lua_UnityEngine_UI_Button.reg);
			}
			array[num542] = BindUnity.<>f__mg$cache21D;
			int num543 = 542;
			if (BindUnity.<>f__mg$cache21E == null)
			{
				BindUnity.<>f__mg$cache21E = new Action<IntPtr>(Lua_UnityEngine_UI_Button_ButtonClickedEvent.reg);
			}
			array[num543] = BindUnity.<>f__mg$cache21E;
			int num544 = 543;
			if (BindUnity.<>f__mg$cache21F == null)
			{
				BindUnity.<>f__mg$cache21F = new Action<IntPtr>(Lua_UnityEngine_UI_CanvasUpdate.reg);
			}
			array[num544] = BindUnity.<>f__mg$cache21F;
			int num545 = 544;
			if (BindUnity.<>f__mg$cache220 == null)
			{
				BindUnity.<>f__mg$cache220 = new Action<IntPtr>(Lua_UnityEngine_UI_ICanvasElement.reg);
			}
			array[num545] = BindUnity.<>f__mg$cache220;
			int num546 = 545;
			if (BindUnity.<>f__mg$cache221 == null)
			{
				BindUnity.<>f__mg$cache221 = new Action<IntPtr>(Lua_UnityEngine_UI_CanvasUpdateRegistry.reg);
			}
			array[num546] = BindUnity.<>f__mg$cache221;
			int num547 = 546;
			if (BindUnity.<>f__mg$cache222 == null)
			{
				BindUnity.<>f__mg$cache222 = new Action<IntPtr>(Lua_UnityEngine_UI_ColorBlock.reg);
			}
			array[num547] = BindUnity.<>f__mg$cache222;
			int num548 = 547;
			if (BindUnity.<>f__mg$cache223 == null)
			{
				BindUnity.<>f__mg$cache223 = new Action<IntPtr>(Lua_UnityEngine_UI_DefaultControls.reg);
			}
			array[num548] = BindUnity.<>f__mg$cache223;
			int num549 = 548;
			if (BindUnity.<>f__mg$cache224 == null)
			{
				BindUnity.<>f__mg$cache224 = new Action<IntPtr>(Lua_UnityEngine_UI_DefaultControls_Resources.reg);
			}
			array[num549] = BindUnity.<>f__mg$cache224;
			int num550 = 549;
			if (BindUnity.<>f__mg$cache225 == null)
			{
				BindUnity.<>f__mg$cache225 = new Action<IntPtr>(Lua_UnityEngine_UI_Dropdown.reg);
			}
			array[num550] = BindUnity.<>f__mg$cache225;
			int num551 = 550;
			if (BindUnity.<>f__mg$cache226 == null)
			{
				BindUnity.<>f__mg$cache226 = new Action<IntPtr>(Lua_UnityEngine_UI_Dropdown_OptionData.reg);
			}
			array[num551] = BindUnity.<>f__mg$cache226;
			int num552 = 551;
			if (BindUnity.<>f__mg$cache227 == null)
			{
				BindUnity.<>f__mg$cache227 = new Action<IntPtr>(Lua_UnityEngine_UI_Dropdown_OptionDataList.reg);
			}
			array[num552] = BindUnity.<>f__mg$cache227;
			int num553 = 552;
			if (BindUnity.<>f__mg$cache228 == null)
			{
				BindUnity.<>f__mg$cache228 = new Action<IntPtr>(Lua_UnityEngine_UI_Dropdown_DropdownEvent.reg);
			}
			array[num553] = BindUnity.<>f__mg$cache228;
			int num554 = 553;
			if (BindUnity.<>f__mg$cache229 == null)
			{
				BindUnity.<>f__mg$cache229 = new Action<IntPtr>(Lua_UnityEngine_UI_FontData.reg);
			}
			array[num554] = BindUnity.<>f__mg$cache229;
			int num555 = 554;
			if (BindUnity.<>f__mg$cache22A == null)
			{
				BindUnity.<>f__mg$cache22A = new Action<IntPtr>(Lua_UnityEngine_UI_FontUpdateTracker.reg);
			}
			array[num555] = BindUnity.<>f__mg$cache22A;
			int num556 = 555;
			if (BindUnity.<>f__mg$cache22B == null)
			{
				BindUnity.<>f__mg$cache22B = new Action<IntPtr>(Lua_UnityEngine_UI_Graphic.reg);
			}
			array[num556] = BindUnity.<>f__mg$cache22B;
			int num557 = 556;
			if (BindUnity.<>f__mg$cache22C == null)
			{
				BindUnity.<>f__mg$cache22C = new Action<IntPtr>(Lua_UnityEngine_UI_GraphicRaycaster.reg);
			}
			array[num557] = BindUnity.<>f__mg$cache22C;
			int num558 = 557;
			if (BindUnity.<>f__mg$cache22D == null)
			{
				BindUnity.<>f__mg$cache22D = new Action<IntPtr>(Lua_UnityEngine_UI_GraphicRaycaster_BlockingObjects.reg);
			}
			array[num558] = BindUnity.<>f__mg$cache22D;
			int num559 = 558;
			if (BindUnity.<>f__mg$cache22E == null)
			{
				BindUnity.<>f__mg$cache22E = new Action<IntPtr>(Lua_UnityEngine_UI_GraphicRegistry.reg);
			}
			array[num559] = BindUnity.<>f__mg$cache22E;
			int num560 = 559;
			if (BindUnity.<>f__mg$cache22F == null)
			{
				BindUnity.<>f__mg$cache22F = new Action<IntPtr>(Lua_UnityEngine_UI_MaskableGraphic.reg);
			}
			array[num560] = BindUnity.<>f__mg$cache22F;
			int num561 = 560;
			if (BindUnity.<>f__mg$cache230 == null)
			{
				BindUnity.<>f__mg$cache230 = new Action<IntPtr>(Lua_UnityEngine_UI_Image.reg);
			}
			array[num561] = BindUnity.<>f__mg$cache230;
			int num562 = 561;
			if (BindUnity.<>f__mg$cache231 == null)
			{
				BindUnity.<>f__mg$cache231 = new Action<IntPtr>(Lua_UnityEngine_UI_Image_Type.reg);
			}
			array[num562] = BindUnity.<>f__mg$cache231;
			int num563 = 562;
			if (BindUnity.<>f__mg$cache232 == null)
			{
				BindUnity.<>f__mg$cache232 = new Action<IntPtr>(Lua_UnityEngine_UI_Image_FillMethod.reg);
			}
			array[num563] = BindUnity.<>f__mg$cache232;
			int num564 = 563;
			if (BindUnity.<>f__mg$cache233 == null)
			{
				BindUnity.<>f__mg$cache233 = new Action<IntPtr>(Lua_UnityEngine_UI_Image_OriginHorizontal.reg);
			}
			array[num564] = BindUnity.<>f__mg$cache233;
			int num565 = 564;
			if (BindUnity.<>f__mg$cache234 == null)
			{
				BindUnity.<>f__mg$cache234 = new Action<IntPtr>(Lua_UnityEngine_UI_Image_OriginVertical.reg);
			}
			array[num565] = BindUnity.<>f__mg$cache234;
			int num566 = 565;
			if (BindUnity.<>f__mg$cache235 == null)
			{
				BindUnity.<>f__mg$cache235 = new Action<IntPtr>(Lua_UnityEngine_UI_Image_Origin90.reg);
			}
			array[num566] = BindUnity.<>f__mg$cache235;
			int num567 = 566;
			if (BindUnity.<>f__mg$cache236 == null)
			{
				BindUnity.<>f__mg$cache236 = new Action<IntPtr>(Lua_UnityEngine_UI_Image_Origin180.reg);
			}
			array[num567] = BindUnity.<>f__mg$cache236;
			int num568 = 567;
			if (BindUnity.<>f__mg$cache237 == null)
			{
				BindUnity.<>f__mg$cache237 = new Action<IntPtr>(Lua_UnityEngine_UI_Image_Origin360.reg);
			}
			array[num568] = BindUnity.<>f__mg$cache237;
			int num569 = 568;
			if (BindUnity.<>f__mg$cache238 == null)
			{
				BindUnity.<>f__mg$cache238 = new Action<IntPtr>(Lua_UnityEngine_UI_IMaskable.reg);
			}
			array[num569] = BindUnity.<>f__mg$cache238;
			int num570 = 569;
			if (BindUnity.<>f__mg$cache239 == null)
			{
				BindUnity.<>f__mg$cache239 = new Action<IntPtr>(Lua_UnityEngine_UI_InputField.reg);
			}
			array[num570] = BindUnity.<>f__mg$cache239;
			int num571 = 570;
			if (BindUnity.<>f__mg$cache23A == null)
			{
				BindUnity.<>f__mg$cache23A = new Action<IntPtr>(Lua_UnityEngine_UI_InputField_ContentType.reg);
			}
			array[num571] = BindUnity.<>f__mg$cache23A;
			int num572 = 571;
			if (BindUnity.<>f__mg$cache23B == null)
			{
				BindUnity.<>f__mg$cache23B = new Action<IntPtr>(Lua_UnityEngine_UI_InputField_InputType.reg);
			}
			array[num572] = BindUnity.<>f__mg$cache23B;
			int num573 = 572;
			if (BindUnity.<>f__mg$cache23C == null)
			{
				BindUnity.<>f__mg$cache23C = new Action<IntPtr>(Lua_UnityEngine_UI_InputField_CharacterValidation.reg);
			}
			array[num573] = BindUnity.<>f__mg$cache23C;
			int num574 = 573;
			if (BindUnity.<>f__mg$cache23D == null)
			{
				BindUnity.<>f__mg$cache23D = new Action<IntPtr>(Lua_UnityEngine_UI_InputField_LineType.reg);
			}
			array[num574] = BindUnity.<>f__mg$cache23D;
			int num575 = 574;
			if (BindUnity.<>f__mg$cache23E == null)
			{
				BindUnity.<>f__mg$cache23E = new Action<IntPtr>(Lua_UnityEngine_UI_InputField_SubmitEvent.reg);
			}
			array[num575] = BindUnity.<>f__mg$cache23E;
			int num576 = 575;
			if (BindUnity.<>f__mg$cache23F == null)
			{
				BindUnity.<>f__mg$cache23F = new Action<IntPtr>(Lua_UnityEngine_UI_InputField_OnChangeEvent.reg);
			}
			array[num576] = BindUnity.<>f__mg$cache23F;
			int num577 = 576;
			if (BindUnity.<>f__mg$cache240 == null)
			{
				BindUnity.<>f__mg$cache240 = new Action<IntPtr>(Lua_UnityEngine_UI_Mask.reg);
			}
			array[num577] = BindUnity.<>f__mg$cache240;
			int num578 = 577;
			if (BindUnity.<>f__mg$cache241 == null)
			{
				BindUnity.<>f__mg$cache241 = new Action<IntPtr>(Lua_UnityEngine_UI_MaskableGraphic_CullStateChangedEvent.reg);
			}
			array[num578] = BindUnity.<>f__mg$cache241;
			int num579 = 578;
			if (BindUnity.<>f__mg$cache242 == null)
			{
				BindUnity.<>f__mg$cache242 = new Action<IntPtr>(Lua_UnityEngine_UI_MaskUtilities.reg);
			}
			array[num579] = BindUnity.<>f__mg$cache242;
			int num580 = 579;
			if (BindUnity.<>f__mg$cache243 == null)
			{
				BindUnity.<>f__mg$cache243 = new Action<IntPtr>(Lua_UnityEngine_UI_Navigation.reg);
			}
			array[num580] = BindUnity.<>f__mg$cache243;
			int num581 = 580;
			if (BindUnity.<>f__mg$cache244 == null)
			{
				BindUnity.<>f__mg$cache244 = new Action<IntPtr>(Lua_UnityEngine_UI_Navigation_Mode.reg);
			}
			array[num581] = BindUnity.<>f__mg$cache244;
			int num582 = 581;
			if (BindUnity.<>f__mg$cache245 == null)
			{
				BindUnity.<>f__mg$cache245 = new Action<IntPtr>(Lua_UnityEngine_UI_RawImage.reg);
			}
			array[num582] = BindUnity.<>f__mg$cache245;
			int num583 = 582;
			if (BindUnity.<>f__mg$cache246 == null)
			{
				BindUnity.<>f__mg$cache246 = new Action<IntPtr>(Lua_UnityEngine_UI_RectMask2D.reg);
			}
			array[num583] = BindUnity.<>f__mg$cache246;
			int num584 = 583;
			if (BindUnity.<>f__mg$cache247 == null)
			{
				BindUnity.<>f__mg$cache247 = new Action<IntPtr>(Lua_UnityEngine_UI_Scrollbar.reg);
			}
			array[num584] = BindUnity.<>f__mg$cache247;
			int num585 = 584;
			if (BindUnity.<>f__mg$cache248 == null)
			{
				BindUnity.<>f__mg$cache248 = new Action<IntPtr>(Lua_UnityEngine_UI_Scrollbar_Direction.reg);
			}
			array[num585] = BindUnity.<>f__mg$cache248;
			int num586 = 585;
			if (BindUnity.<>f__mg$cache249 == null)
			{
				BindUnity.<>f__mg$cache249 = new Action<IntPtr>(Lua_UnityEngine_UI_Scrollbar_ScrollEvent.reg);
			}
			array[num586] = BindUnity.<>f__mg$cache249;
			int num587 = 586;
			if (BindUnity.<>f__mg$cache24A == null)
			{
				BindUnity.<>f__mg$cache24A = new Action<IntPtr>(Lua_UnityEngine_UI_ScrollRect.reg);
			}
			array[num587] = BindUnity.<>f__mg$cache24A;
			int num588 = 587;
			if (BindUnity.<>f__mg$cache24B == null)
			{
				BindUnity.<>f__mg$cache24B = new Action<IntPtr>(Lua_UnityEngine_UI_ScrollRect_MovementType.reg);
			}
			array[num588] = BindUnity.<>f__mg$cache24B;
			int num589 = 588;
			if (BindUnity.<>f__mg$cache24C == null)
			{
				BindUnity.<>f__mg$cache24C = new Action<IntPtr>(Lua_UnityEngine_UI_ScrollRect_ScrollbarVisibility.reg);
			}
			array[num589] = BindUnity.<>f__mg$cache24C;
			int num590 = 589;
			if (BindUnity.<>f__mg$cache24D == null)
			{
				BindUnity.<>f__mg$cache24D = new Action<IntPtr>(Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent.reg);
			}
			array[num590] = BindUnity.<>f__mg$cache24D;
			int num591 = 590;
			if (BindUnity.<>f__mg$cache24E == null)
			{
				BindUnity.<>f__mg$cache24E = new Action<IntPtr>(Lua_UnityEngine_UI_Selectable_Transition.reg);
			}
			array[num591] = BindUnity.<>f__mg$cache24E;
			int num592 = 591;
			if (BindUnity.<>f__mg$cache24F == null)
			{
				BindUnity.<>f__mg$cache24F = new Action<IntPtr>(Lua_UnityEngine_UI_Slider.reg);
			}
			array[num592] = BindUnity.<>f__mg$cache24F;
			int num593 = 592;
			if (BindUnity.<>f__mg$cache250 == null)
			{
				BindUnity.<>f__mg$cache250 = new Action<IntPtr>(Lua_UnityEngine_UI_Slider_Direction.reg);
			}
			array[num593] = BindUnity.<>f__mg$cache250;
			int num594 = 593;
			if (BindUnity.<>f__mg$cache251 == null)
			{
				BindUnity.<>f__mg$cache251 = new Action<IntPtr>(Lua_UnityEngine_UI_Slider_SliderEvent.reg);
			}
			array[num594] = BindUnity.<>f__mg$cache251;
			int num595 = 594;
			if (BindUnity.<>f__mg$cache252 == null)
			{
				BindUnity.<>f__mg$cache252 = new Action<IntPtr>(Lua_UnityEngine_UI_SpriteState.reg);
			}
			array[num595] = BindUnity.<>f__mg$cache252;
			int num596 = 595;
			if (BindUnity.<>f__mg$cache253 == null)
			{
				BindUnity.<>f__mg$cache253 = new Action<IntPtr>(Lua_UnityEngine_UI_StencilMaterial.reg);
			}
			array[num596] = BindUnity.<>f__mg$cache253;
			int num597 = 596;
			if (BindUnity.<>f__mg$cache254 == null)
			{
				BindUnity.<>f__mg$cache254 = new Action<IntPtr>(Lua_UnityEngine_UI_Text.reg);
			}
			array[num597] = BindUnity.<>f__mg$cache254;
			int num598 = 597;
			if (BindUnity.<>f__mg$cache255 == null)
			{
				BindUnity.<>f__mg$cache255 = new Action<IntPtr>(Lua_UnityEngine_UI_Toggle.reg);
			}
			array[num598] = BindUnity.<>f__mg$cache255;
			int num599 = 598;
			if (BindUnity.<>f__mg$cache256 == null)
			{
				BindUnity.<>f__mg$cache256 = new Action<IntPtr>(Lua_UnityEngine_UI_Toggle_ToggleTransition.reg);
			}
			array[num599] = BindUnity.<>f__mg$cache256;
			int num600 = 599;
			if (BindUnity.<>f__mg$cache257 == null)
			{
				BindUnity.<>f__mg$cache257 = new Action<IntPtr>(Lua_UnityEngine_UI_Toggle_ToggleEvent.reg);
			}
			array[num600] = BindUnity.<>f__mg$cache257;
			int num601 = 600;
			if (BindUnity.<>f__mg$cache258 == null)
			{
				BindUnity.<>f__mg$cache258 = new Action<IntPtr>(Lua_UnityEngine_UI_ToggleGroup.reg);
			}
			array[num601] = BindUnity.<>f__mg$cache258;
			int num602 = 601;
			if (BindUnity.<>f__mg$cache259 == null)
			{
				BindUnity.<>f__mg$cache259 = new Action<IntPtr>(Lua_UnityEngine_UI_ClipperRegistry.reg);
			}
			array[num602] = BindUnity.<>f__mg$cache259;
			int num603 = 602;
			if (BindUnity.<>f__mg$cache25A == null)
			{
				BindUnity.<>f__mg$cache25A = new Action<IntPtr>(Lua_UnityEngine_UI_Clipping.reg);
			}
			array[num603] = BindUnity.<>f__mg$cache25A;
			int num604 = 603;
			if (BindUnity.<>f__mg$cache25B == null)
			{
				BindUnity.<>f__mg$cache25B = new Action<IntPtr>(Lua_UnityEngine_UI_IClipper.reg);
			}
			array[num604] = BindUnity.<>f__mg$cache25B;
			int num605 = 604;
			if (BindUnity.<>f__mg$cache25C == null)
			{
				BindUnity.<>f__mg$cache25C = new Action<IntPtr>(Lua_UnityEngine_UI_IClippable.reg);
			}
			array[num605] = BindUnity.<>f__mg$cache25C;
			int num606 = 605;
			if (BindUnity.<>f__mg$cache25D == null)
			{
				BindUnity.<>f__mg$cache25D = new Action<IntPtr>(Lua_UnityEngine_UI_AspectRatioFitter.reg);
			}
			array[num606] = BindUnity.<>f__mg$cache25D;
			int num607 = 606;
			if (BindUnity.<>f__mg$cache25E == null)
			{
				BindUnity.<>f__mg$cache25E = new Action<IntPtr>(Lua_UnityEngine_UI_AspectRatioFitter_AspectMode.reg);
			}
			array[num607] = BindUnity.<>f__mg$cache25E;
			int num608 = 607;
			if (BindUnity.<>f__mg$cache25F == null)
			{
				BindUnity.<>f__mg$cache25F = new Action<IntPtr>(Lua_UnityEngine_UI_CanvasScaler.reg);
			}
			array[num608] = BindUnity.<>f__mg$cache25F;
			int num609 = 608;
			if (BindUnity.<>f__mg$cache260 == null)
			{
				BindUnity.<>f__mg$cache260 = new Action<IntPtr>(Lua_UnityEngine_UI_CanvasScaler_ScaleMode.reg);
			}
			array[num609] = BindUnity.<>f__mg$cache260;
			int num610 = 609;
			if (BindUnity.<>f__mg$cache261 == null)
			{
				BindUnity.<>f__mg$cache261 = new Action<IntPtr>(Lua_UnityEngine_UI_CanvasScaler_ScreenMatchMode.reg);
			}
			array[num610] = BindUnity.<>f__mg$cache261;
			int num611 = 610;
			if (BindUnity.<>f__mg$cache262 == null)
			{
				BindUnity.<>f__mg$cache262 = new Action<IntPtr>(Lua_UnityEngine_UI_CanvasScaler_Unit.reg);
			}
			array[num611] = BindUnity.<>f__mg$cache262;
			int num612 = 611;
			if (BindUnity.<>f__mg$cache263 == null)
			{
				BindUnity.<>f__mg$cache263 = new Action<IntPtr>(Lua_UnityEngine_UI_ContentSizeFitter.reg);
			}
			array[num612] = BindUnity.<>f__mg$cache263;
			int num613 = 612;
			if (BindUnity.<>f__mg$cache264 == null)
			{
				BindUnity.<>f__mg$cache264 = new Action<IntPtr>(Lua_UnityEngine_UI_ContentSizeFitter_FitMode.reg);
			}
			array[num613] = BindUnity.<>f__mg$cache264;
			int num614 = 613;
			if (BindUnity.<>f__mg$cache265 == null)
			{
				BindUnity.<>f__mg$cache265 = new Action<IntPtr>(Lua_UnityEngine_UI_LayoutGroup.reg);
			}
			array[num614] = BindUnity.<>f__mg$cache265;
			int num615 = 614;
			if (BindUnity.<>f__mg$cache266 == null)
			{
				BindUnity.<>f__mg$cache266 = new Action<IntPtr>(Lua_UnityEngine_UI_GridLayoutGroup.reg);
			}
			array[num615] = BindUnity.<>f__mg$cache266;
			int num616 = 615;
			if (BindUnity.<>f__mg$cache267 == null)
			{
				BindUnity.<>f__mg$cache267 = new Action<IntPtr>(Lua_UnityEngine_UI_GridLayoutGroup_Corner.reg);
			}
			array[num616] = BindUnity.<>f__mg$cache267;
			int num617 = 616;
			if (BindUnity.<>f__mg$cache268 == null)
			{
				BindUnity.<>f__mg$cache268 = new Action<IntPtr>(Lua_UnityEngine_UI_GridLayoutGroup_Axis.reg);
			}
			array[num617] = BindUnity.<>f__mg$cache268;
			int num618 = 617;
			if (BindUnity.<>f__mg$cache269 == null)
			{
				BindUnity.<>f__mg$cache269 = new Action<IntPtr>(Lua_UnityEngine_UI_GridLayoutGroup_Constraint.reg);
			}
			array[num618] = BindUnity.<>f__mg$cache269;
			int num619 = 618;
			if (BindUnity.<>f__mg$cache26A == null)
			{
				BindUnity.<>f__mg$cache26A = new Action<IntPtr>(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.reg);
			}
			array[num619] = BindUnity.<>f__mg$cache26A;
			int num620 = 619;
			if (BindUnity.<>f__mg$cache26B == null)
			{
				BindUnity.<>f__mg$cache26B = new Action<IntPtr>(Lua_UnityEngine_UI_HorizontalLayoutGroup.reg);
			}
			array[num620] = BindUnity.<>f__mg$cache26B;
			int num621 = 620;
			if (BindUnity.<>f__mg$cache26C == null)
			{
				BindUnity.<>f__mg$cache26C = new Action<IntPtr>(Lua_UnityEngine_UI_ILayoutElement.reg);
			}
			array[num621] = BindUnity.<>f__mg$cache26C;
			int num622 = 621;
			if (BindUnity.<>f__mg$cache26D == null)
			{
				BindUnity.<>f__mg$cache26D = new Action<IntPtr>(Lua_UnityEngine_UI_ILayoutController.reg);
			}
			array[num622] = BindUnity.<>f__mg$cache26D;
			int num623 = 622;
			if (BindUnity.<>f__mg$cache26E == null)
			{
				BindUnity.<>f__mg$cache26E = new Action<IntPtr>(Lua_UnityEngine_UI_ILayoutGroup.reg);
			}
			array[num623] = BindUnity.<>f__mg$cache26E;
			int num624 = 623;
			if (BindUnity.<>f__mg$cache26F == null)
			{
				BindUnity.<>f__mg$cache26F = new Action<IntPtr>(Lua_UnityEngine_UI_ILayoutSelfController.reg);
			}
			array[num624] = BindUnity.<>f__mg$cache26F;
			int num625 = 624;
			if (BindUnity.<>f__mg$cache270 == null)
			{
				BindUnity.<>f__mg$cache270 = new Action<IntPtr>(Lua_UnityEngine_UI_ILayoutIgnorer.reg);
			}
			array[num625] = BindUnity.<>f__mg$cache270;
			int num626 = 625;
			if (BindUnity.<>f__mg$cache271 == null)
			{
				BindUnity.<>f__mg$cache271 = new Action<IntPtr>(Lua_UnityEngine_UI_LayoutElement.reg);
			}
			array[num626] = BindUnity.<>f__mg$cache271;
			int num627 = 626;
			if (BindUnity.<>f__mg$cache272 == null)
			{
				BindUnity.<>f__mg$cache272 = new Action<IntPtr>(Lua_UnityEngine_UI_LayoutRebuilder.reg);
			}
			array[num627] = BindUnity.<>f__mg$cache272;
			int num628 = 627;
			if (BindUnity.<>f__mg$cache273 == null)
			{
				BindUnity.<>f__mg$cache273 = new Action<IntPtr>(Lua_UnityEngine_UI_LayoutUtility.reg);
			}
			array[num628] = BindUnity.<>f__mg$cache273;
			int num629 = 628;
			if (BindUnity.<>f__mg$cache274 == null)
			{
				BindUnity.<>f__mg$cache274 = new Action<IntPtr>(Lua_UnityEngine_UI_VerticalLayoutGroup.reg);
			}
			array[num629] = BindUnity.<>f__mg$cache274;
			int num630 = 629;
			if (BindUnity.<>f__mg$cache275 == null)
			{
				BindUnity.<>f__mg$cache275 = new Action<IntPtr>(Lua_UnityEngine_UI_IMaterialModifier.reg);
			}
			array[num630] = BindUnity.<>f__mg$cache275;
			int num631 = 630;
			if (BindUnity.<>f__mg$cache276 == null)
			{
				BindUnity.<>f__mg$cache276 = new Action<IntPtr>(Lua_UnityEngine_UI_VertexHelper.reg);
			}
			array[num631] = BindUnity.<>f__mg$cache276;
			int num632 = 631;
			if (BindUnity.<>f__mg$cache277 == null)
			{
				BindUnity.<>f__mg$cache277 = new Action<IntPtr>(Lua_UnityEngine_UI_BaseMeshEffect.reg);
			}
			array[num632] = BindUnity.<>f__mg$cache277;
			int num633 = 632;
			if (BindUnity.<>f__mg$cache278 == null)
			{
				BindUnity.<>f__mg$cache278 = new Action<IntPtr>(Lua_UnityEngine_UI_IMeshModifier.reg);
			}
			array[num633] = BindUnity.<>f__mg$cache278;
			int num634 = 633;
			if (BindUnity.<>f__mg$cache279 == null)
			{
				BindUnity.<>f__mg$cache279 = new Action<IntPtr>(Lua_UnityEngine_UI_Shadow.reg);
			}
			array[num634] = BindUnity.<>f__mg$cache279;
			int num635 = 634;
			if (BindUnity.<>f__mg$cache27A == null)
			{
				BindUnity.<>f__mg$cache27A = new Action<IntPtr>(Lua_UnityEngine_UI_Outline.reg);
			}
			array[num635] = BindUnity.<>f__mg$cache27A;
			int num636 = 635;
			if (BindUnity.<>f__mg$cache27B == null)
			{
				BindUnity.<>f__mg$cache27B = new Action<IntPtr>(Lua_UnityEngine_UI_PositionAsUV1.reg);
			}
			array[num636] = BindUnity.<>f__mg$cache27B;
			return array;
		}

		// Token: 0x040187AE RID: 100270
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache0;

		// Token: 0x040187AF RID: 100271
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1;

		// Token: 0x040187B0 RID: 100272
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2;

		// Token: 0x040187B1 RID: 100273
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3;

		// Token: 0x040187B2 RID: 100274
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4;

		// Token: 0x040187B3 RID: 100275
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5;

		// Token: 0x040187B4 RID: 100276
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6;

		// Token: 0x040187B5 RID: 100277
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7;

		// Token: 0x040187B6 RID: 100278
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8;

		// Token: 0x040187B7 RID: 100279
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9;

		// Token: 0x040187B8 RID: 100280
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA;

		// Token: 0x040187B9 RID: 100281
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB;

		// Token: 0x040187BA RID: 100282
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC;

		// Token: 0x040187BB RID: 100283
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD;

		// Token: 0x040187BC RID: 100284
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE;

		// Token: 0x040187BD RID: 100285
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF;

		// Token: 0x040187BE RID: 100286
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10;

		// Token: 0x040187BF RID: 100287
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11;

		// Token: 0x040187C0 RID: 100288
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12;

		// Token: 0x040187C1 RID: 100289
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13;

		// Token: 0x040187C2 RID: 100290
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14;

		// Token: 0x040187C3 RID: 100291
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15;

		// Token: 0x040187C4 RID: 100292
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16;

		// Token: 0x040187C5 RID: 100293
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17;

		// Token: 0x040187C6 RID: 100294
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18;

		// Token: 0x040187C7 RID: 100295
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19;

		// Token: 0x040187C8 RID: 100296
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A;

		// Token: 0x040187C9 RID: 100297
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B;

		// Token: 0x040187CA RID: 100298
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C;

		// Token: 0x040187CB RID: 100299
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D;

		// Token: 0x040187CC RID: 100300
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E;

		// Token: 0x040187CD RID: 100301
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F;

		// Token: 0x040187CE RID: 100302
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20;

		// Token: 0x040187CF RID: 100303
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21;

		// Token: 0x040187D0 RID: 100304
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22;

		// Token: 0x040187D1 RID: 100305
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23;

		// Token: 0x040187D2 RID: 100306
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24;

		// Token: 0x040187D3 RID: 100307
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25;

		// Token: 0x040187D4 RID: 100308
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26;

		// Token: 0x040187D5 RID: 100309
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27;

		// Token: 0x040187D6 RID: 100310
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache28;

		// Token: 0x040187D7 RID: 100311
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache29;

		// Token: 0x040187D8 RID: 100312
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A;

		// Token: 0x040187D9 RID: 100313
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B;

		// Token: 0x040187DA RID: 100314
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C;

		// Token: 0x040187DB RID: 100315
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D;

		// Token: 0x040187DC RID: 100316
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E;

		// Token: 0x040187DD RID: 100317
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F;

		// Token: 0x040187DE RID: 100318
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache30;

		// Token: 0x040187DF RID: 100319
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache31;

		// Token: 0x040187E0 RID: 100320
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache32;

		// Token: 0x040187E1 RID: 100321
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache33;

		// Token: 0x040187E2 RID: 100322
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache34;

		// Token: 0x040187E3 RID: 100323
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache35;

		// Token: 0x040187E4 RID: 100324
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache36;

		// Token: 0x040187E5 RID: 100325
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache37;

		// Token: 0x040187E6 RID: 100326
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache38;

		// Token: 0x040187E7 RID: 100327
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache39;

		// Token: 0x040187E8 RID: 100328
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A;

		// Token: 0x040187E9 RID: 100329
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B;

		// Token: 0x040187EA RID: 100330
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C;

		// Token: 0x040187EB RID: 100331
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D;

		// Token: 0x040187EC RID: 100332
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E;

		// Token: 0x040187ED RID: 100333
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F;

		// Token: 0x040187EE RID: 100334
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache40;

		// Token: 0x040187EF RID: 100335
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache41;

		// Token: 0x040187F0 RID: 100336
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache42;

		// Token: 0x040187F1 RID: 100337
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache43;

		// Token: 0x040187F2 RID: 100338
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache44;

		// Token: 0x040187F3 RID: 100339
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache45;

		// Token: 0x040187F4 RID: 100340
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache46;

		// Token: 0x040187F5 RID: 100341
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache47;

		// Token: 0x040187F6 RID: 100342
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache48;

		// Token: 0x040187F7 RID: 100343
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache49;

		// Token: 0x040187F8 RID: 100344
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A;

		// Token: 0x040187F9 RID: 100345
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B;

		// Token: 0x040187FA RID: 100346
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C;

		// Token: 0x040187FB RID: 100347
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D;

		// Token: 0x040187FC RID: 100348
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E;

		// Token: 0x040187FD RID: 100349
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F;

		// Token: 0x040187FE RID: 100350
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache50;

		// Token: 0x040187FF RID: 100351
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache51;

		// Token: 0x04018800 RID: 100352
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache52;

		// Token: 0x04018801 RID: 100353
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache53;

		// Token: 0x04018802 RID: 100354
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache54;

		// Token: 0x04018803 RID: 100355
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache55;

		// Token: 0x04018804 RID: 100356
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache56;

		// Token: 0x04018805 RID: 100357
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache57;

		// Token: 0x04018806 RID: 100358
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache58;

		// Token: 0x04018807 RID: 100359
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache59;

		// Token: 0x04018808 RID: 100360
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5A;

		// Token: 0x04018809 RID: 100361
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5B;

		// Token: 0x0401880A RID: 100362
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5C;

		// Token: 0x0401880B RID: 100363
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5D;

		// Token: 0x0401880C RID: 100364
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5E;

		// Token: 0x0401880D RID: 100365
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5F;

		// Token: 0x0401880E RID: 100366
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache60;

		// Token: 0x0401880F RID: 100367
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache61;

		// Token: 0x04018810 RID: 100368
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache62;

		// Token: 0x04018811 RID: 100369
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache63;

		// Token: 0x04018812 RID: 100370
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache64;

		// Token: 0x04018813 RID: 100371
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache65;

		// Token: 0x04018814 RID: 100372
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache66;

		// Token: 0x04018815 RID: 100373
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache67;

		// Token: 0x04018816 RID: 100374
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache68;

		// Token: 0x04018817 RID: 100375
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache69;

		// Token: 0x04018818 RID: 100376
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6A;

		// Token: 0x04018819 RID: 100377
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6B;

		// Token: 0x0401881A RID: 100378
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6C;

		// Token: 0x0401881B RID: 100379
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6D;

		// Token: 0x0401881C RID: 100380
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6E;

		// Token: 0x0401881D RID: 100381
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6F;

		// Token: 0x0401881E RID: 100382
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache70;

		// Token: 0x0401881F RID: 100383
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache71;

		// Token: 0x04018820 RID: 100384
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache72;

		// Token: 0x04018821 RID: 100385
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache73;

		// Token: 0x04018822 RID: 100386
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache74;

		// Token: 0x04018823 RID: 100387
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache75;

		// Token: 0x04018824 RID: 100388
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache76;

		// Token: 0x04018825 RID: 100389
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache77;

		// Token: 0x04018826 RID: 100390
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache78;

		// Token: 0x04018827 RID: 100391
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache79;

		// Token: 0x04018828 RID: 100392
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7A;

		// Token: 0x04018829 RID: 100393
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7B;

		// Token: 0x0401882A RID: 100394
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7C;

		// Token: 0x0401882B RID: 100395
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7D;

		// Token: 0x0401882C RID: 100396
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7E;

		// Token: 0x0401882D RID: 100397
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7F;

		// Token: 0x0401882E RID: 100398
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache80;

		// Token: 0x0401882F RID: 100399
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache81;

		// Token: 0x04018830 RID: 100400
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache82;

		// Token: 0x04018831 RID: 100401
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache83;

		// Token: 0x04018832 RID: 100402
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache84;

		// Token: 0x04018833 RID: 100403
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache85;

		// Token: 0x04018834 RID: 100404
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache86;

		// Token: 0x04018835 RID: 100405
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache87;

		// Token: 0x04018836 RID: 100406
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache88;

		// Token: 0x04018837 RID: 100407
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache89;

		// Token: 0x04018838 RID: 100408
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8A;

		// Token: 0x04018839 RID: 100409
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8B;

		// Token: 0x0401883A RID: 100410
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8C;

		// Token: 0x0401883B RID: 100411
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8D;

		// Token: 0x0401883C RID: 100412
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8E;

		// Token: 0x0401883D RID: 100413
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8F;

		// Token: 0x0401883E RID: 100414
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache90;

		// Token: 0x0401883F RID: 100415
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache91;

		// Token: 0x04018840 RID: 100416
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache92;

		// Token: 0x04018841 RID: 100417
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache93;

		// Token: 0x04018842 RID: 100418
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache94;

		// Token: 0x04018843 RID: 100419
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache95;

		// Token: 0x04018844 RID: 100420
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache96;

		// Token: 0x04018845 RID: 100421
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache97;

		// Token: 0x04018846 RID: 100422
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache98;

		// Token: 0x04018847 RID: 100423
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache99;

		// Token: 0x04018848 RID: 100424
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9A;

		// Token: 0x04018849 RID: 100425
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9B;

		// Token: 0x0401884A RID: 100426
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9C;

		// Token: 0x0401884B RID: 100427
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9D;

		// Token: 0x0401884C RID: 100428
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9E;

		// Token: 0x0401884D RID: 100429
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9F;

		// Token: 0x0401884E RID: 100430
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA0;

		// Token: 0x0401884F RID: 100431
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA1;

		// Token: 0x04018850 RID: 100432
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA2;

		// Token: 0x04018851 RID: 100433
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA3;

		// Token: 0x04018852 RID: 100434
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA4;

		// Token: 0x04018853 RID: 100435
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA5;

		// Token: 0x04018854 RID: 100436
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA6;

		// Token: 0x04018855 RID: 100437
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA7;

		// Token: 0x04018856 RID: 100438
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA8;

		// Token: 0x04018857 RID: 100439
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA9;

		// Token: 0x04018858 RID: 100440
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAA;

		// Token: 0x04018859 RID: 100441
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAB;

		// Token: 0x0401885A RID: 100442
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAC;

		// Token: 0x0401885B RID: 100443
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAD;

		// Token: 0x0401885C RID: 100444
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAE;

		// Token: 0x0401885D RID: 100445
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAF;

		// Token: 0x0401885E RID: 100446
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB0;

		// Token: 0x0401885F RID: 100447
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB1;

		// Token: 0x04018860 RID: 100448
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB2;

		// Token: 0x04018861 RID: 100449
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB3;

		// Token: 0x04018862 RID: 100450
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB4;

		// Token: 0x04018863 RID: 100451
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB5;

		// Token: 0x04018864 RID: 100452
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB6;

		// Token: 0x04018865 RID: 100453
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB7;

		// Token: 0x04018866 RID: 100454
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB8;

		// Token: 0x04018867 RID: 100455
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB9;

		// Token: 0x04018868 RID: 100456
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBA;

		// Token: 0x04018869 RID: 100457
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBB;

		// Token: 0x0401886A RID: 100458
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBC;

		// Token: 0x0401886B RID: 100459
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBD;

		// Token: 0x0401886C RID: 100460
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBE;

		// Token: 0x0401886D RID: 100461
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBF;

		// Token: 0x0401886E RID: 100462
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC0;

		// Token: 0x0401886F RID: 100463
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC1;

		// Token: 0x04018870 RID: 100464
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC2;

		// Token: 0x04018871 RID: 100465
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC3;

		// Token: 0x04018872 RID: 100466
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC4;

		// Token: 0x04018873 RID: 100467
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC5;

		// Token: 0x04018874 RID: 100468
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC6;

		// Token: 0x04018875 RID: 100469
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC7;

		// Token: 0x04018876 RID: 100470
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC8;

		// Token: 0x04018877 RID: 100471
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC9;

		// Token: 0x04018878 RID: 100472
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCA;

		// Token: 0x04018879 RID: 100473
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCB;

		// Token: 0x0401887A RID: 100474
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCC;

		// Token: 0x0401887B RID: 100475
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCD;

		// Token: 0x0401887C RID: 100476
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCE;

		// Token: 0x0401887D RID: 100477
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCF;

		// Token: 0x0401887E RID: 100478
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD0;

		// Token: 0x0401887F RID: 100479
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD1;

		// Token: 0x04018880 RID: 100480
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD2;

		// Token: 0x04018881 RID: 100481
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD3;

		// Token: 0x04018882 RID: 100482
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD4;

		// Token: 0x04018883 RID: 100483
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD5;

		// Token: 0x04018884 RID: 100484
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD6;

		// Token: 0x04018885 RID: 100485
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD7;

		// Token: 0x04018886 RID: 100486
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD8;

		// Token: 0x04018887 RID: 100487
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD9;

		// Token: 0x04018888 RID: 100488
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDA;

		// Token: 0x04018889 RID: 100489
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDB;

		// Token: 0x0401888A RID: 100490
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDC;

		// Token: 0x0401888B RID: 100491
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDD;

		// Token: 0x0401888C RID: 100492
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDE;

		// Token: 0x0401888D RID: 100493
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDF;

		// Token: 0x0401888E RID: 100494
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE0;

		// Token: 0x0401888F RID: 100495
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE1;

		// Token: 0x04018890 RID: 100496
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE2;

		// Token: 0x04018891 RID: 100497
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE3;

		// Token: 0x04018892 RID: 100498
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE4;

		// Token: 0x04018893 RID: 100499
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE5;

		// Token: 0x04018894 RID: 100500
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE6;

		// Token: 0x04018895 RID: 100501
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE7;

		// Token: 0x04018896 RID: 100502
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE8;

		// Token: 0x04018897 RID: 100503
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE9;

		// Token: 0x04018898 RID: 100504
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEA;

		// Token: 0x04018899 RID: 100505
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEB;

		// Token: 0x0401889A RID: 100506
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEC;

		// Token: 0x0401889B RID: 100507
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheED;

		// Token: 0x0401889C RID: 100508
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEE;

		// Token: 0x0401889D RID: 100509
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEF;

		// Token: 0x0401889E RID: 100510
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF0;

		// Token: 0x0401889F RID: 100511
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF1;

		// Token: 0x040188A0 RID: 100512
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF2;

		// Token: 0x040188A1 RID: 100513
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF3;

		// Token: 0x040188A2 RID: 100514
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF4;

		// Token: 0x040188A3 RID: 100515
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF5;

		// Token: 0x040188A4 RID: 100516
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF6;

		// Token: 0x040188A5 RID: 100517
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF7;

		// Token: 0x040188A6 RID: 100518
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF8;

		// Token: 0x040188A7 RID: 100519
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF9;

		// Token: 0x040188A8 RID: 100520
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFA;

		// Token: 0x040188A9 RID: 100521
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFB;

		// Token: 0x040188AA RID: 100522
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFC;

		// Token: 0x040188AB RID: 100523
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFD;

		// Token: 0x040188AC RID: 100524
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFE;

		// Token: 0x040188AD RID: 100525
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFF;

		// Token: 0x040188AE RID: 100526
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache100;

		// Token: 0x040188AF RID: 100527
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache101;

		// Token: 0x040188B0 RID: 100528
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache102;

		// Token: 0x040188B1 RID: 100529
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache103;

		// Token: 0x040188B2 RID: 100530
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache104;

		// Token: 0x040188B3 RID: 100531
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache105;

		// Token: 0x040188B4 RID: 100532
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache106;

		// Token: 0x040188B5 RID: 100533
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache107;

		// Token: 0x040188B6 RID: 100534
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache108;

		// Token: 0x040188B7 RID: 100535
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache109;

		// Token: 0x040188B8 RID: 100536
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10A;

		// Token: 0x040188B9 RID: 100537
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10B;

		// Token: 0x040188BA RID: 100538
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10C;

		// Token: 0x040188BB RID: 100539
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10D;

		// Token: 0x040188BC RID: 100540
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10E;

		// Token: 0x040188BD RID: 100541
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10F;

		// Token: 0x040188BE RID: 100542
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache110;

		// Token: 0x040188BF RID: 100543
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache111;

		// Token: 0x040188C0 RID: 100544
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache112;

		// Token: 0x040188C1 RID: 100545
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache113;

		// Token: 0x040188C2 RID: 100546
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache114;

		// Token: 0x040188C3 RID: 100547
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache115;

		// Token: 0x040188C4 RID: 100548
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache116;

		// Token: 0x040188C5 RID: 100549
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache117;

		// Token: 0x040188C6 RID: 100550
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache118;

		// Token: 0x040188C7 RID: 100551
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache119;

		// Token: 0x040188C8 RID: 100552
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11A;

		// Token: 0x040188C9 RID: 100553
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11B;

		// Token: 0x040188CA RID: 100554
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11C;

		// Token: 0x040188CB RID: 100555
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11D;

		// Token: 0x040188CC RID: 100556
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11E;

		// Token: 0x040188CD RID: 100557
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11F;

		// Token: 0x040188CE RID: 100558
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache120;

		// Token: 0x040188CF RID: 100559
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache121;

		// Token: 0x040188D0 RID: 100560
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache122;

		// Token: 0x040188D1 RID: 100561
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache123;

		// Token: 0x040188D2 RID: 100562
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache124;

		// Token: 0x040188D3 RID: 100563
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache125;

		// Token: 0x040188D4 RID: 100564
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache126;

		// Token: 0x040188D5 RID: 100565
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache127;

		// Token: 0x040188D6 RID: 100566
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache128;

		// Token: 0x040188D7 RID: 100567
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache129;

		// Token: 0x040188D8 RID: 100568
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12A;

		// Token: 0x040188D9 RID: 100569
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12B;

		// Token: 0x040188DA RID: 100570
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12C;

		// Token: 0x040188DB RID: 100571
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12D;

		// Token: 0x040188DC RID: 100572
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12E;

		// Token: 0x040188DD RID: 100573
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12F;

		// Token: 0x040188DE RID: 100574
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache130;

		// Token: 0x040188DF RID: 100575
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache131;

		// Token: 0x040188E0 RID: 100576
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache132;

		// Token: 0x040188E1 RID: 100577
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache133;

		// Token: 0x040188E2 RID: 100578
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache134;

		// Token: 0x040188E3 RID: 100579
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache135;

		// Token: 0x040188E4 RID: 100580
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache136;

		// Token: 0x040188E5 RID: 100581
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache137;

		// Token: 0x040188E6 RID: 100582
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache138;

		// Token: 0x040188E7 RID: 100583
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache139;

		// Token: 0x040188E8 RID: 100584
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13A;

		// Token: 0x040188E9 RID: 100585
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13B;

		// Token: 0x040188EA RID: 100586
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13C;

		// Token: 0x040188EB RID: 100587
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13D;

		// Token: 0x040188EC RID: 100588
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13E;

		// Token: 0x040188ED RID: 100589
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13F;

		// Token: 0x040188EE RID: 100590
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache140;

		// Token: 0x040188EF RID: 100591
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache141;

		// Token: 0x040188F0 RID: 100592
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache142;

		// Token: 0x040188F1 RID: 100593
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache143;

		// Token: 0x040188F2 RID: 100594
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache144;

		// Token: 0x040188F3 RID: 100595
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache145;

		// Token: 0x040188F4 RID: 100596
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache146;

		// Token: 0x040188F5 RID: 100597
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache147;

		// Token: 0x040188F6 RID: 100598
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache148;

		// Token: 0x040188F7 RID: 100599
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache149;

		// Token: 0x040188F8 RID: 100600
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14A;

		// Token: 0x040188F9 RID: 100601
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14B;

		// Token: 0x040188FA RID: 100602
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14C;

		// Token: 0x040188FB RID: 100603
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14D;

		// Token: 0x040188FC RID: 100604
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14E;

		// Token: 0x040188FD RID: 100605
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14F;

		// Token: 0x040188FE RID: 100606
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache150;

		// Token: 0x040188FF RID: 100607
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache151;

		// Token: 0x04018900 RID: 100608
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache152;

		// Token: 0x04018901 RID: 100609
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache153;

		// Token: 0x04018902 RID: 100610
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache154;

		// Token: 0x04018903 RID: 100611
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache155;

		// Token: 0x04018904 RID: 100612
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache156;

		// Token: 0x04018905 RID: 100613
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache157;

		// Token: 0x04018906 RID: 100614
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache158;

		// Token: 0x04018907 RID: 100615
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache159;

		// Token: 0x04018908 RID: 100616
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15A;

		// Token: 0x04018909 RID: 100617
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15B;

		// Token: 0x0401890A RID: 100618
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15C;

		// Token: 0x0401890B RID: 100619
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15D;

		// Token: 0x0401890C RID: 100620
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15E;

		// Token: 0x0401890D RID: 100621
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15F;

		// Token: 0x0401890E RID: 100622
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache160;

		// Token: 0x0401890F RID: 100623
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache161;

		// Token: 0x04018910 RID: 100624
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache162;

		// Token: 0x04018911 RID: 100625
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache163;

		// Token: 0x04018912 RID: 100626
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache164;

		// Token: 0x04018913 RID: 100627
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache165;

		// Token: 0x04018914 RID: 100628
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache166;

		// Token: 0x04018915 RID: 100629
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache167;

		// Token: 0x04018916 RID: 100630
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache168;

		// Token: 0x04018917 RID: 100631
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache169;

		// Token: 0x04018918 RID: 100632
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16A;

		// Token: 0x04018919 RID: 100633
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16B;

		// Token: 0x0401891A RID: 100634
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16C;

		// Token: 0x0401891B RID: 100635
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16D;

		// Token: 0x0401891C RID: 100636
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16E;

		// Token: 0x0401891D RID: 100637
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16F;

		// Token: 0x0401891E RID: 100638
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache170;

		// Token: 0x0401891F RID: 100639
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache171;

		// Token: 0x04018920 RID: 100640
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache172;

		// Token: 0x04018921 RID: 100641
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache173;

		// Token: 0x04018922 RID: 100642
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache174;

		// Token: 0x04018923 RID: 100643
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache175;

		// Token: 0x04018924 RID: 100644
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache176;

		// Token: 0x04018925 RID: 100645
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache177;

		// Token: 0x04018926 RID: 100646
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache178;

		// Token: 0x04018927 RID: 100647
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache179;

		// Token: 0x04018928 RID: 100648
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17A;

		// Token: 0x04018929 RID: 100649
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17B;

		// Token: 0x0401892A RID: 100650
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17C;

		// Token: 0x0401892B RID: 100651
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17D;

		// Token: 0x0401892C RID: 100652
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17E;

		// Token: 0x0401892D RID: 100653
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17F;

		// Token: 0x0401892E RID: 100654
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache180;

		// Token: 0x0401892F RID: 100655
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache181;

		// Token: 0x04018930 RID: 100656
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache182;

		// Token: 0x04018931 RID: 100657
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache183;

		// Token: 0x04018932 RID: 100658
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache184;

		// Token: 0x04018933 RID: 100659
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache185;

		// Token: 0x04018934 RID: 100660
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache186;

		// Token: 0x04018935 RID: 100661
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache187;

		// Token: 0x04018936 RID: 100662
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache188;

		// Token: 0x04018937 RID: 100663
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache189;

		// Token: 0x04018938 RID: 100664
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18A;

		// Token: 0x04018939 RID: 100665
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18B;

		// Token: 0x0401893A RID: 100666
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18C;

		// Token: 0x0401893B RID: 100667
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18D;

		// Token: 0x0401893C RID: 100668
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18E;

		// Token: 0x0401893D RID: 100669
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18F;

		// Token: 0x0401893E RID: 100670
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache190;

		// Token: 0x0401893F RID: 100671
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache191;

		// Token: 0x04018940 RID: 100672
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache192;

		// Token: 0x04018941 RID: 100673
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache193;

		// Token: 0x04018942 RID: 100674
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache194;

		// Token: 0x04018943 RID: 100675
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache195;

		// Token: 0x04018944 RID: 100676
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache196;

		// Token: 0x04018945 RID: 100677
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache197;

		// Token: 0x04018946 RID: 100678
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache198;

		// Token: 0x04018947 RID: 100679
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache199;

		// Token: 0x04018948 RID: 100680
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19A;

		// Token: 0x04018949 RID: 100681
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19B;

		// Token: 0x0401894A RID: 100682
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19C;

		// Token: 0x0401894B RID: 100683
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19D;

		// Token: 0x0401894C RID: 100684
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19E;

		// Token: 0x0401894D RID: 100685
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19F;

		// Token: 0x0401894E RID: 100686
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A0;

		// Token: 0x0401894F RID: 100687
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A1;

		// Token: 0x04018950 RID: 100688
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A2;

		// Token: 0x04018951 RID: 100689
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A3;

		// Token: 0x04018952 RID: 100690
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A4;

		// Token: 0x04018953 RID: 100691
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A5;

		// Token: 0x04018954 RID: 100692
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A6;

		// Token: 0x04018955 RID: 100693
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A7;

		// Token: 0x04018956 RID: 100694
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A8;

		// Token: 0x04018957 RID: 100695
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A9;

		// Token: 0x04018958 RID: 100696
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AA;

		// Token: 0x04018959 RID: 100697
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AB;

		// Token: 0x0401895A RID: 100698
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AC;

		// Token: 0x0401895B RID: 100699
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AD;

		// Token: 0x0401895C RID: 100700
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AE;

		// Token: 0x0401895D RID: 100701
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AF;

		// Token: 0x0401895E RID: 100702
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B0;

		// Token: 0x0401895F RID: 100703
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B1;

		// Token: 0x04018960 RID: 100704
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B2;

		// Token: 0x04018961 RID: 100705
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B3;

		// Token: 0x04018962 RID: 100706
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B4;

		// Token: 0x04018963 RID: 100707
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B5;

		// Token: 0x04018964 RID: 100708
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B6;

		// Token: 0x04018965 RID: 100709
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B7;

		// Token: 0x04018966 RID: 100710
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B8;

		// Token: 0x04018967 RID: 100711
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B9;

		// Token: 0x04018968 RID: 100712
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BA;

		// Token: 0x04018969 RID: 100713
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BB;

		// Token: 0x0401896A RID: 100714
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BC;

		// Token: 0x0401896B RID: 100715
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BD;

		// Token: 0x0401896C RID: 100716
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BE;

		// Token: 0x0401896D RID: 100717
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BF;

		// Token: 0x0401896E RID: 100718
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C0;

		// Token: 0x0401896F RID: 100719
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C1;

		// Token: 0x04018970 RID: 100720
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C2;

		// Token: 0x04018971 RID: 100721
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C3;

		// Token: 0x04018972 RID: 100722
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C4;

		// Token: 0x04018973 RID: 100723
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C5;

		// Token: 0x04018974 RID: 100724
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C6;

		// Token: 0x04018975 RID: 100725
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C7;

		// Token: 0x04018976 RID: 100726
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C8;

		// Token: 0x04018977 RID: 100727
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C9;

		// Token: 0x04018978 RID: 100728
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CA;

		// Token: 0x04018979 RID: 100729
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CB;

		// Token: 0x0401897A RID: 100730
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CC;

		// Token: 0x0401897B RID: 100731
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CD;

		// Token: 0x0401897C RID: 100732
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CE;

		// Token: 0x0401897D RID: 100733
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CF;

		// Token: 0x0401897E RID: 100734
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D0;

		// Token: 0x0401897F RID: 100735
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D1;

		// Token: 0x04018980 RID: 100736
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D2;

		// Token: 0x04018981 RID: 100737
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D3;

		// Token: 0x04018982 RID: 100738
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D4;

		// Token: 0x04018983 RID: 100739
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D5;

		// Token: 0x04018984 RID: 100740
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D6;

		// Token: 0x04018985 RID: 100741
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D7;

		// Token: 0x04018986 RID: 100742
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D8;

		// Token: 0x04018987 RID: 100743
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D9;

		// Token: 0x04018988 RID: 100744
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DA;

		// Token: 0x04018989 RID: 100745
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DB;

		// Token: 0x0401898A RID: 100746
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DC;

		// Token: 0x0401898B RID: 100747
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DD;

		// Token: 0x0401898C RID: 100748
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DE;

		// Token: 0x0401898D RID: 100749
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DF;

		// Token: 0x0401898E RID: 100750
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E0;

		// Token: 0x0401898F RID: 100751
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E1;

		// Token: 0x04018990 RID: 100752
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E2;

		// Token: 0x04018991 RID: 100753
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E3;

		// Token: 0x04018992 RID: 100754
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E4;

		// Token: 0x04018993 RID: 100755
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E5;

		// Token: 0x04018994 RID: 100756
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E6;

		// Token: 0x04018995 RID: 100757
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E7;

		// Token: 0x04018996 RID: 100758
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E8;

		// Token: 0x04018997 RID: 100759
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E9;

		// Token: 0x04018998 RID: 100760
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EA;

		// Token: 0x04018999 RID: 100761
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EB;

		// Token: 0x0401899A RID: 100762
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EC;

		// Token: 0x0401899B RID: 100763
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1ED;

		// Token: 0x0401899C RID: 100764
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EE;

		// Token: 0x0401899D RID: 100765
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EF;

		// Token: 0x0401899E RID: 100766
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F0;

		// Token: 0x0401899F RID: 100767
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F1;

		// Token: 0x040189A0 RID: 100768
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F2;

		// Token: 0x040189A1 RID: 100769
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F3;

		// Token: 0x040189A2 RID: 100770
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F4;

		// Token: 0x040189A3 RID: 100771
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F5;

		// Token: 0x040189A4 RID: 100772
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F6;

		// Token: 0x040189A5 RID: 100773
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F7;

		// Token: 0x040189A6 RID: 100774
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F8;

		// Token: 0x040189A7 RID: 100775
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F9;

		// Token: 0x040189A8 RID: 100776
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FA;

		// Token: 0x040189A9 RID: 100777
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FB;

		// Token: 0x040189AA RID: 100778
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FC;

		// Token: 0x040189AB RID: 100779
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FD;

		// Token: 0x040189AC RID: 100780
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FE;

		// Token: 0x040189AD RID: 100781
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FF;

		// Token: 0x040189AE RID: 100782
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache200;

		// Token: 0x040189AF RID: 100783
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache201;

		// Token: 0x040189B0 RID: 100784
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache202;

		// Token: 0x040189B1 RID: 100785
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache203;

		// Token: 0x040189B2 RID: 100786
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache204;

		// Token: 0x040189B3 RID: 100787
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache205;

		// Token: 0x040189B4 RID: 100788
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache206;

		// Token: 0x040189B5 RID: 100789
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache207;

		// Token: 0x040189B6 RID: 100790
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache208;

		// Token: 0x040189B7 RID: 100791
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache209;

		// Token: 0x040189B8 RID: 100792
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20A;

		// Token: 0x040189B9 RID: 100793
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20B;

		// Token: 0x040189BA RID: 100794
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20C;

		// Token: 0x040189BB RID: 100795
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20D;

		// Token: 0x040189BC RID: 100796
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20E;

		// Token: 0x040189BD RID: 100797
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20F;

		// Token: 0x040189BE RID: 100798
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache210;

		// Token: 0x040189BF RID: 100799
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache211;

		// Token: 0x040189C0 RID: 100800
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache212;

		// Token: 0x040189C1 RID: 100801
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache213;

		// Token: 0x040189C2 RID: 100802
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache214;

		// Token: 0x040189C3 RID: 100803
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache215;

		// Token: 0x040189C4 RID: 100804
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache216;

		// Token: 0x040189C5 RID: 100805
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache217;

		// Token: 0x040189C6 RID: 100806
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache218;

		// Token: 0x040189C7 RID: 100807
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache219;

		// Token: 0x040189C8 RID: 100808
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21A;

		// Token: 0x040189C9 RID: 100809
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21B;

		// Token: 0x040189CA RID: 100810
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21C;

		// Token: 0x040189CB RID: 100811
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21D;

		// Token: 0x040189CC RID: 100812
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21E;

		// Token: 0x040189CD RID: 100813
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21F;

		// Token: 0x040189CE RID: 100814
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache220;

		// Token: 0x040189CF RID: 100815
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache221;

		// Token: 0x040189D0 RID: 100816
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache222;

		// Token: 0x040189D1 RID: 100817
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache223;

		// Token: 0x040189D2 RID: 100818
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache224;

		// Token: 0x040189D3 RID: 100819
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache225;

		// Token: 0x040189D4 RID: 100820
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache226;

		// Token: 0x040189D5 RID: 100821
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache227;

		// Token: 0x040189D6 RID: 100822
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache228;

		// Token: 0x040189D7 RID: 100823
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache229;

		// Token: 0x040189D8 RID: 100824
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22A;

		// Token: 0x040189D9 RID: 100825
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22B;

		// Token: 0x040189DA RID: 100826
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22C;

		// Token: 0x040189DB RID: 100827
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22D;

		// Token: 0x040189DC RID: 100828
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22E;

		// Token: 0x040189DD RID: 100829
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22F;

		// Token: 0x040189DE RID: 100830
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache230;

		// Token: 0x040189DF RID: 100831
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache231;

		// Token: 0x040189E0 RID: 100832
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache232;

		// Token: 0x040189E1 RID: 100833
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache233;

		// Token: 0x040189E2 RID: 100834
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache234;

		// Token: 0x040189E3 RID: 100835
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache235;

		// Token: 0x040189E4 RID: 100836
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache236;

		// Token: 0x040189E5 RID: 100837
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache237;

		// Token: 0x040189E6 RID: 100838
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache238;

		// Token: 0x040189E7 RID: 100839
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache239;

		// Token: 0x040189E8 RID: 100840
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23A;

		// Token: 0x040189E9 RID: 100841
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23B;

		// Token: 0x040189EA RID: 100842
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23C;

		// Token: 0x040189EB RID: 100843
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23D;

		// Token: 0x040189EC RID: 100844
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23E;

		// Token: 0x040189ED RID: 100845
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23F;

		// Token: 0x040189EE RID: 100846
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache240;

		// Token: 0x040189EF RID: 100847
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache241;

		// Token: 0x040189F0 RID: 100848
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache242;

		// Token: 0x040189F1 RID: 100849
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache243;

		// Token: 0x040189F2 RID: 100850
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache244;

		// Token: 0x040189F3 RID: 100851
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache245;

		// Token: 0x040189F4 RID: 100852
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache246;

		// Token: 0x040189F5 RID: 100853
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache247;

		// Token: 0x040189F6 RID: 100854
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache248;

		// Token: 0x040189F7 RID: 100855
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache249;

		// Token: 0x040189F8 RID: 100856
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24A;

		// Token: 0x040189F9 RID: 100857
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24B;

		// Token: 0x040189FA RID: 100858
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24C;

		// Token: 0x040189FB RID: 100859
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24D;

		// Token: 0x040189FC RID: 100860
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24E;

		// Token: 0x040189FD RID: 100861
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24F;

		// Token: 0x040189FE RID: 100862
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache250;

		// Token: 0x040189FF RID: 100863
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache251;

		// Token: 0x04018A00 RID: 100864
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache252;

		// Token: 0x04018A01 RID: 100865
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache253;

		// Token: 0x04018A02 RID: 100866
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache254;

		// Token: 0x04018A03 RID: 100867
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache255;

		// Token: 0x04018A04 RID: 100868
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache256;

		// Token: 0x04018A05 RID: 100869
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache257;

		// Token: 0x04018A06 RID: 100870
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache258;

		// Token: 0x04018A07 RID: 100871
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache259;

		// Token: 0x04018A08 RID: 100872
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25A;

		// Token: 0x04018A09 RID: 100873
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25B;

		// Token: 0x04018A0A RID: 100874
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25C;

		// Token: 0x04018A0B RID: 100875
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25D;

		// Token: 0x04018A0C RID: 100876
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25E;

		// Token: 0x04018A0D RID: 100877
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25F;

		// Token: 0x04018A0E RID: 100878
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache260;

		// Token: 0x04018A0F RID: 100879
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache261;

		// Token: 0x04018A10 RID: 100880
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache262;

		// Token: 0x04018A11 RID: 100881
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache263;

		// Token: 0x04018A12 RID: 100882
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache264;

		// Token: 0x04018A13 RID: 100883
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache265;

		// Token: 0x04018A14 RID: 100884
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache266;

		// Token: 0x04018A15 RID: 100885
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache267;

		// Token: 0x04018A16 RID: 100886
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache268;

		// Token: 0x04018A17 RID: 100887
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache269;

		// Token: 0x04018A18 RID: 100888
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26A;

		// Token: 0x04018A19 RID: 100889
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26B;

		// Token: 0x04018A1A RID: 100890
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26C;

		// Token: 0x04018A1B RID: 100891
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26D;

		// Token: 0x04018A1C RID: 100892
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26E;

		// Token: 0x04018A1D RID: 100893
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26F;

		// Token: 0x04018A1E RID: 100894
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache270;

		// Token: 0x04018A1F RID: 100895
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache271;

		// Token: 0x04018A20 RID: 100896
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache272;

		// Token: 0x04018A21 RID: 100897
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache273;

		// Token: 0x04018A22 RID: 100898
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache274;

		// Token: 0x04018A23 RID: 100899
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache275;

		// Token: 0x04018A24 RID: 100900
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache276;

		// Token: 0x04018A25 RID: 100901
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache277;

		// Token: 0x04018A26 RID: 100902
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache278;

		// Token: 0x04018A27 RID: 100903
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache279;

		// Token: 0x04018A28 RID: 100904
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27A;

		// Token: 0x04018A29 RID: 100905
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27B;
	}
}
