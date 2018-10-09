using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001762 RID: 5986
[Preserve]
public class Lua_UnityEngine_QualitySettings : LuaObject
{
	// Token: 0x060238C3 RID: 145603 RVA: 0x00C6A018 File Offset: 0x00C68218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			QualitySettings o = new QualitySettings();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238C4 RID: 145604 RVA: 0x00C6A060 File Offset: 0x00C68260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetQualityLevel_s(IntPtr l)
	{
		int result;
		try
		{
			int qualityLevel = QualitySettings.GetQualityLevel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, qualityLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238C5 RID: 145605 RVA: 0x00C6A0A8 File Offset: 0x00C682A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetQualityLevel_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				int qualityLevel;
				LuaObject.checkType(l, 1, out qualityLevel);
				QualitySettings.SetQualityLevel(qualityLevel);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				int index;
				LuaObject.checkType(l, 1, out index);
				bool applyExpensiveChanges;
				LuaObject.checkType(l, 2, out applyExpensiveChanges);
				QualitySettings.SetQualityLevel(index, applyExpensiveChanges);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetQualityLevel to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238C6 RID: 145606 RVA: 0x00C6A14C File Offset: 0x00C6834C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IncreaseLevel_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				bool applyExpensiveChanges;
				LuaObject.checkType(l, 1, out applyExpensiveChanges);
				QualitySettings.IncreaseLevel(applyExpensiveChanges);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 0)
			{
				QualitySettings.IncreaseLevel();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IncreaseLevel to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238C7 RID: 145607 RVA: 0x00C6A1D8 File Offset: 0x00C683D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DecreaseLevel_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				bool applyExpensiveChanges;
				LuaObject.checkType(l, 1, out applyExpensiveChanges);
				QualitySettings.DecreaseLevel(applyExpensiveChanges);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 0)
			{
				QualitySettings.DecreaseLevel();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DecreaseLevel to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238C8 RID: 145608 RVA: 0x00C6A264 File Offset: 0x00C68464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_names(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.names);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238C9 RID: 145609 RVA: 0x00C6A2AC File Offset: 0x00C684AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowCascade4Split(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.shadowCascade4Split);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238CA RID: 145610 RVA: 0x00C6A2F4 File Offset: 0x00C684F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowCascade4Split(IntPtr l)
	{
		int result;
		try
		{
			Vector3 shadowCascade4Split;
			LuaObject.checkType(l, 2, out shadowCascade4Split);
			QualitySettings.shadowCascade4Split = shadowCascade4Split;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238CB RID: 145611 RVA: 0x00C6A340 File Offset: 0x00C68540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_anisotropicFiltering(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)QualitySettings.anisotropicFiltering);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238CC RID: 145612 RVA: 0x00C6A388 File Offset: 0x00C68588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_anisotropicFiltering(IntPtr l)
	{
		int result;
		try
		{
			AnisotropicFiltering anisotropicFiltering;
			LuaObject.checkEnum<AnisotropicFiltering>(l, 2, out anisotropicFiltering);
			QualitySettings.anisotropicFiltering = anisotropicFiltering;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238CD RID: 145613 RVA: 0x00C6A3D4 File Offset: 0x00C685D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxQueuedFrames(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.maxQueuedFrames);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238CE RID: 145614 RVA: 0x00C6A41C File Offset: 0x00C6861C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxQueuedFrames(IntPtr l)
	{
		int result;
		try
		{
			int maxQueuedFrames;
			LuaObject.checkType(l, 2, out maxQueuedFrames);
			QualitySettings.maxQueuedFrames = maxQueuedFrames;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238CF RID: 145615 RVA: 0x00C6A468 File Offset: 0x00C68668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_blendWeights(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)QualitySettings.blendWeights);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D0 RID: 145616 RVA: 0x00C6A4B0 File Offset: 0x00C686B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_blendWeights(IntPtr l)
	{
		int result;
		try
		{
			BlendWeights blendWeights;
			LuaObject.checkEnum<BlendWeights>(l, 2, out blendWeights);
			QualitySettings.blendWeights = blendWeights;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D1 RID: 145617 RVA: 0x00C6A4FC File Offset: 0x00C686FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelLightCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.pixelLightCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D2 RID: 145618 RVA: 0x00C6A544 File Offset: 0x00C68744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pixelLightCount(IntPtr l)
	{
		int result;
		try
		{
			int pixelLightCount;
			LuaObject.checkType(l, 2, out pixelLightCount);
			QualitySettings.pixelLightCount = pixelLightCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D3 RID: 145619 RVA: 0x00C6A590 File Offset: 0x00C68790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadows(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)QualitySettings.shadows);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D4 RID: 145620 RVA: 0x00C6A5D8 File Offset: 0x00C687D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_shadows(IntPtr l)
	{
		int result;
		try
		{
			ShadowQuality shadows;
			LuaObject.checkEnum<ShadowQuality>(l, 2, out shadows);
			QualitySettings.shadows = shadows;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D5 RID: 145621 RVA: 0x00C6A624 File Offset: 0x00C68824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_shadowProjection(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)QualitySettings.shadowProjection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D6 RID: 145622 RVA: 0x00C6A66C File Offset: 0x00C6886C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowProjection(IntPtr l)
	{
		int result;
		try
		{
			ShadowProjection shadowProjection;
			LuaObject.checkEnum<ShadowProjection>(l, 2, out shadowProjection);
			QualitySettings.shadowProjection = shadowProjection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D7 RID: 145623 RVA: 0x00C6A6B8 File Offset: 0x00C688B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowCascades(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.shadowCascades);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D8 RID: 145624 RVA: 0x00C6A700 File Offset: 0x00C68900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_shadowCascades(IntPtr l)
	{
		int result;
		try
		{
			int shadowCascades;
			LuaObject.checkType(l, 2, out shadowCascades);
			QualitySettings.shadowCascades = shadowCascades;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238D9 RID: 145625 RVA: 0x00C6A74C File Offset: 0x00C6894C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowDistance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.shadowDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238DA RID: 145626 RVA: 0x00C6A794 File Offset: 0x00C68994
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_shadowDistance(IntPtr l)
	{
		int result;
		try
		{
			float shadowDistance;
			LuaObject.checkType(l, 2, out shadowDistance);
			QualitySettings.shadowDistance = shadowDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238DB RID: 145627 RVA: 0x00C6A7E0 File Offset: 0x00C689E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowResolution(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)QualitySettings.shadowResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238DC RID: 145628 RVA: 0x00C6A828 File Offset: 0x00C68A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowResolution(IntPtr l)
	{
		int result;
		try
		{
			ShadowResolution shadowResolution;
			LuaObject.checkEnum<ShadowResolution>(l, 2, out shadowResolution);
			QualitySettings.shadowResolution = shadowResolution;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238DD RID: 145629 RVA: 0x00C6A874 File Offset: 0x00C68A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowmaskMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)QualitySettings.shadowmaskMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238DE RID: 145630 RVA: 0x00C6A8BC File Offset: 0x00C68ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowmaskMode(IntPtr l)
	{
		int result;
		try
		{
			ShadowmaskMode shadowmaskMode;
			LuaObject.checkEnum<ShadowmaskMode>(l, 2, out shadowmaskMode);
			QualitySettings.shadowmaskMode = shadowmaskMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238DF RID: 145631 RVA: 0x00C6A908 File Offset: 0x00C68B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowNearPlaneOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.shadowNearPlaneOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E0 RID: 145632 RVA: 0x00C6A950 File Offset: 0x00C68B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowNearPlaneOffset(IntPtr l)
	{
		int result;
		try
		{
			float shadowNearPlaneOffset;
			LuaObject.checkType(l, 2, out shadowNearPlaneOffset);
			QualitySettings.shadowNearPlaneOffset = shadowNearPlaneOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E1 RID: 145633 RVA: 0x00C6A99C File Offset: 0x00C68B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowCascade2Split(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.shadowCascade2Split);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E2 RID: 145634 RVA: 0x00C6A9E4 File Offset: 0x00C68BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowCascade2Split(IntPtr l)
	{
		int result;
		try
		{
			float shadowCascade2Split;
			LuaObject.checkType(l, 2, out shadowCascade2Split);
			QualitySettings.shadowCascade2Split = shadowCascade2Split;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E3 RID: 145635 RVA: 0x00C6AA30 File Offset: 0x00C68C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lodBias(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.lodBias);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E4 RID: 145636 RVA: 0x00C6AA78 File Offset: 0x00C68C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lodBias(IntPtr l)
	{
		int result;
		try
		{
			float lodBias;
			LuaObject.checkType(l, 2, out lodBias);
			QualitySettings.lodBias = lodBias;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E5 RID: 145637 RVA: 0x00C6AAC4 File Offset: 0x00C68CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_masterTextureLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.masterTextureLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E6 RID: 145638 RVA: 0x00C6AB0C File Offset: 0x00C68D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_masterTextureLimit(IntPtr l)
	{
		int result;
		try
		{
			int masterTextureLimit;
			LuaObject.checkType(l, 2, out masterTextureLimit);
			QualitySettings.masterTextureLimit = masterTextureLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E7 RID: 145639 RVA: 0x00C6AB58 File Offset: 0x00C68D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maximumLODLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.maximumLODLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E8 RID: 145640 RVA: 0x00C6ABA0 File Offset: 0x00C68DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maximumLODLevel(IntPtr l)
	{
		int result;
		try
		{
			int maximumLODLevel;
			LuaObject.checkType(l, 2, out maximumLODLevel);
			QualitySettings.maximumLODLevel = maximumLODLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238E9 RID: 145641 RVA: 0x00C6ABEC File Offset: 0x00C68DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_particleRaycastBudget(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.particleRaycastBudget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238EA RID: 145642 RVA: 0x00C6AC34 File Offset: 0x00C68E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_particleRaycastBudget(IntPtr l)
	{
		int result;
		try
		{
			int particleRaycastBudget;
			LuaObject.checkType(l, 2, out particleRaycastBudget);
			QualitySettings.particleRaycastBudget = particleRaycastBudget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238EB RID: 145643 RVA: 0x00C6AC80 File Offset: 0x00C68E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_softParticles(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.softParticles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238EC RID: 145644 RVA: 0x00C6ACC8 File Offset: 0x00C68EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_softParticles(IntPtr l)
	{
		int result;
		try
		{
			bool softParticles;
			LuaObject.checkType(l, 2, out softParticles);
			QualitySettings.softParticles = softParticles;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238ED RID: 145645 RVA: 0x00C6AD14 File Offset: 0x00C68F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_softVegetation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.softVegetation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238EE RID: 145646 RVA: 0x00C6AD5C File Offset: 0x00C68F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_softVegetation(IntPtr l)
	{
		int result;
		try
		{
			bool softVegetation;
			LuaObject.checkType(l, 2, out softVegetation);
			QualitySettings.softVegetation = softVegetation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238EF RID: 145647 RVA: 0x00C6ADA8 File Offset: 0x00C68FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vSyncCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.vSyncCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F0 RID: 145648 RVA: 0x00C6ADF0 File Offset: 0x00C68FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_vSyncCount(IntPtr l)
	{
		int result;
		try
		{
			int vSyncCount;
			LuaObject.checkType(l, 2, out vSyncCount);
			QualitySettings.vSyncCount = vSyncCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F1 RID: 145649 RVA: 0x00C6AE3C File Offset: 0x00C6903C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_antiAliasing(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.antiAliasing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F2 RID: 145650 RVA: 0x00C6AE84 File Offset: 0x00C69084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_antiAliasing(IntPtr l)
	{
		int result;
		try
		{
			int antiAliasing;
			LuaObject.checkType(l, 2, out antiAliasing);
			QualitySettings.antiAliasing = antiAliasing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F3 RID: 145651 RVA: 0x00C6AED0 File Offset: 0x00C690D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_asyncUploadTimeSlice(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.asyncUploadTimeSlice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F4 RID: 145652 RVA: 0x00C6AF18 File Offset: 0x00C69118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_asyncUploadTimeSlice(IntPtr l)
	{
		int result;
		try
		{
			int asyncUploadTimeSlice;
			LuaObject.checkType(l, 2, out asyncUploadTimeSlice);
			QualitySettings.asyncUploadTimeSlice = asyncUploadTimeSlice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F5 RID: 145653 RVA: 0x00C6AF64 File Offset: 0x00C69164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_asyncUploadBufferSize(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.asyncUploadBufferSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F6 RID: 145654 RVA: 0x00C6AFAC File Offset: 0x00C691AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_asyncUploadBufferSize(IntPtr l)
	{
		int result;
		try
		{
			int asyncUploadBufferSize;
			LuaObject.checkType(l, 2, out asyncUploadBufferSize);
			QualitySettings.asyncUploadBufferSize = asyncUploadBufferSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F7 RID: 145655 RVA: 0x00C6AFF8 File Offset: 0x00C691F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_realtimeReflectionProbes(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.realtimeReflectionProbes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F8 RID: 145656 RVA: 0x00C6B040 File Offset: 0x00C69240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_realtimeReflectionProbes(IntPtr l)
	{
		int result;
		try
		{
			bool realtimeReflectionProbes;
			LuaObject.checkType(l, 2, out realtimeReflectionProbes);
			QualitySettings.realtimeReflectionProbes = realtimeReflectionProbes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238F9 RID: 145657 RVA: 0x00C6B08C File Offset: 0x00C6928C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_billboardsFaceCameraPosition(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.billboardsFaceCameraPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238FA RID: 145658 RVA: 0x00C6B0D4 File Offset: 0x00C692D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_billboardsFaceCameraPosition(IntPtr l)
	{
		int result;
		try
		{
			bool billboardsFaceCameraPosition;
			LuaObject.checkType(l, 2, out billboardsFaceCameraPosition);
			QualitySettings.billboardsFaceCameraPosition = billboardsFaceCameraPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238FB RID: 145659 RVA: 0x00C6B120 File Offset: 0x00C69320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resolutionScalingFixedDPIFactor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, QualitySettings.resolutionScalingFixedDPIFactor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238FC RID: 145660 RVA: 0x00C6B168 File Offset: 0x00C69368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resolutionScalingFixedDPIFactor(IntPtr l)
	{
		int result;
		try
		{
			float resolutionScalingFixedDPIFactor;
			LuaObject.checkType(l, 2, out resolutionScalingFixedDPIFactor);
			QualitySettings.resolutionScalingFixedDPIFactor = resolutionScalingFixedDPIFactor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238FD RID: 145661 RVA: 0x00C6B1B4 File Offset: 0x00C693B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_desiredColorSpace(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)QualitySettings.desiredColorSpace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238FE RID: 145662 RVA: 0x00C6B1FC File Offset: 0x00C693FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_activeColorSpace(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)QualitySettings.activeColorSpace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238FF RID: 145663 RVA: 0x00C6B244 File Offset: 0x00C69444
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.QualitySettings");
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.GetQualityLevel_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_QualitySettings.<>f__mg$cache0);
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.SetQualityLevel_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_QualitySettings.<>f__mg$cache1);
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.IncreaseLevel_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_QualitySettings.<>f__mg$cache2);
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.DecreaseLevel_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_QualitySettings.<>f__mg$cache3);
		string name = "names";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_names);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_QualitySettings.<>f__mg$cache4, null, false);
		string name2 = "shadowCascade4Split";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadowCascade4Split);
		}
		LuaCSFunction get = Lua_UnityEngine_QualitySettings.<>f__mg$cache5;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadowCascade4Split);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_QualitySettings.<>f__mg$cache6, false);
		string name3 = "anisotropicFiltering";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_anisotropicFiltering);
		}
		LuaCSFunction get2 = Lua_UnityEngine_QualitySettings.<>f__mg$cache7;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_anisotropicFiltering);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_QualitySettings.<>f__mg$cache8, false);
		string name4 = "maxQueuedFrames";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_maxQueuedFrames);
		}
		LuaCSFunction get3 = Lua_UnityEngine_QualitySettings.<>f__mg$cache9;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_maxQueuedFrames);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_QualitySettings.<>f__mg$cacheA, false);
		string name5 = "blendWeights";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_blendWeights);
		}
		LuaCSFunction get4 = Lua_UnityEngine_QualitySettings.<>f__mg$cacheB;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_blendWeights);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_QualitySettings.<>f__mg$cacheC, false);
		string name6 = "pixelLightCount";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_pixelLightCount);
		}
		LuaCSFunction get5 = Lua_UnityEngine_QualitySettings.<>f__mg$cacheD;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_pixelLightCount);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_QualitySettings.<>f__mg$cacheE, false);
		string name7 = "shadows";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadows);
		}
		LuaCSFunction get6 = Lua_UnityEngine_QualitySettings.<>f__mg$cacheF;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadows);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_QualitySettings.<>f__mg$cache10, false);
		string name8 = "shadowProjection";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadowProjection);
		}
		LuaCSFunction get7 = Lua_UnityEngine_QualitySettings.<>f__mg$cache11;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadowProjection);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_QualitySettings.<>f__mg$cache12, false);
		string name9 = "shadowCascades";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadowCascades);
		}
		LuaCSFunction get8 = Lua_UnityEngine_QualitySettings.<>f__mg$cache13;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadowCascades);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_QualitySettings.<>f__mg$cache14, false);
		string name10 = "shadowDistance";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadowDistance);
		}
		LuaCSFunction get9 = Lua_UnityEngine_QualitySettings.<>f__mg$cache15;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadowDistance);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_QualitySettings.<>f__mg$cache16, false);
		string name11 = "shadowResolution";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadowResolution);
		}
		LuaCSFunction get10 = Lua_UnityEngine_QualitySettings.<>f__mg$cache17;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadowResolution);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_QualitySettings.<>f__mg$cache18, false);
		string name12 = "shadowmaskMode";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadowmaskMode);
		}
		LuaCSFunction get11 = Lua_UnityEngine_QualitySettings.<>f__mg$cache19;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadowmaskMode);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_QualitySettings.<>f__mg$cache1A, false);
		string name13 = "shadowNearPlaneOffset";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadowNearPlaneOffset);
		}
		LuaCSFunction get12 = Lua_UnityEngine_QualitySettings.<>f__mg$cache1B;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadowNearPlaneOffset);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_QualitySettings.<>f__mg$cache1C, false);
		string name14 = "shadowCascade2Split";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_shadowCascade2Split);
		}
		LuaCSFunction get13 = Lua_UnityEngine_QualitySettings.<>f__mg$cache1D;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_shadowCascade2Split);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_QualitySettings.<>f__mg$cache1E, false);
		string name15 = "lodBias";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_lodBias);
		}
		LuaCSFunction get14 = Lua_UnityEngine_QualitySettings.<>f__mg$cache1F;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_lodBias);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_QualitySettings.<>f__mg$cache20, false);
		string name16 = "masterTextureLimit";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_masterTextureLimit);
		}
		LuaCSFunction get15 = Lua_UnityEngine_QualitySettings.<>f__mg$cache21;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_masterTextureLimit);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_QualitySettings.<>f__mg$cache22, false);
		string name17 = "maximumLODLevel";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_maximumLODLevel);
		}
		LuaCSFunction get16 = Lua_UnityEngine_QualitySettings.<>f__mg$cache23;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_maximumLODLevel);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_QualitySettings.<>f__mg$cache24, false);
		string name18 = "particleRaycastBudget";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_particleRaycastBudget);
		}
		LuaCSFunction get17 = Lua_UnityEngine_QualitySettings.<>f__mg$cache25;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_particleRaycastBudget);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_QualitySettings.<>f__mg$cache26, false);
		string name19 = "softParticles";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_softParticles);
		}
		LuaCSFunction get18 = Lua_UnityEngine_QualitySettings.<>f__mg$cache27;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_softParticles);
		}
		LuaObject.addMember(l, name19, get18, Lua_UnityEngine_QualitySettings.<>f__mg$cache28, false);
		string name20 = "softVegetation";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_softVegetation);
		}
		LuaCSFunction get19 = Lua_UnityEngine_QualitySettings.<>f__mg$cache29;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_softVegetation);
		}
		LuaObject.addMember(l, name20, get19, Lua_UnityEngine_QualitySettings.<>f__mg$cache2A, false);
		string name21 = "vSyncCount";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_vSyncCount);
		}
		LuaCSFunction get20 = Lua_UnityEngine_QualitySettings.<>f__mg$cache2B;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_vSyncCount);
		}
		LuaObject.addMember(l, name21, get20, Lua_UnityEngine_QualitySettings.<>f__mg$cache2C, false);
		string name22 = "antiAliasing";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_antiAliasing);
		}
		LuaCSFunction get21 = Lua_UnityEngine_QualitySettings.<>f__mg$cache2D;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_antiAliasing);
		}
		LuaObject.addMember(l, name22, get21, Lua_UnityEngine_QualitySettings.<>f__mg$cache2E, false);
		string name23 = "asyncUploadTimeSlice";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_asyncUploadTimeSlice);
		}
		LuaCSFunction get22 = Lua_UnityEngine_QualitySettings.<>f__mg$cache2F;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_asyncUploadTimeSlice);
		}
		LuaObject.addMember(l, name23, get22, Lua_UnityEngine_QualitySettings.<>f__mg$cache30, false);
		string name24 = "asyncUploadBufferSize";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_asyncUploadBufferSize);
		}
		LuaCSFunction get23 = Lua_UnityEngine_QualitySettings.<>f__mg$cache31;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_asyncUploadBufferSize);
		}
		LuaObject.addMember(l, name24, get23, Lua_UnityEngine_QualitySettings.<>f__mg$cache32, false);
		string name25 = "realtimeReflectionProbes";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_realtimeReflectionProbes);
		}
		LuaCSFunction get24 = Lua_UnityEngine_QualitySettings.<>f__mg$cache33;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_realtimeReflectionProbes);
		}
		LuaObject.addMember(l, name25, get24, Lua_UnityEngine_QualitySettings.<>f__mg$cache34, false);
		string name26 = "billboardsFaceCameraPosition";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_billboardsFaceCameraPosition);
		}
		LuaCSFunction get25 = Lua_UnityEngine_QualitySettings.<>f__mg$cache35;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_billboardsFaceCameraPosition);
		}
		LuaObject.addMember(l, name26, get25, Lua_UnityEngine_QualitySettings.<>f__mg$cache36, false);
		string name27 = "resolutionScalingFixedDPIFactor";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_resolutionScalingFixedDPIFactor);
		}
		LuaCSFunction get26 = Lua_UnityEngine_QualitySettings.<>f__mg$cache37;
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.set_resolutionScalingFixedDPIFactor);
		}
		LuaObject.addMember(l, name27, get26, Lua_UnityEngine_QualitySettings.<>f__mg$cache38, false);
		string name28 = "desiredColorSpace";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_desiredColorSpace);
		}
		LuaObject.addMember(l, name28, Lua_UnityEngine_QualitySettings.<>f__mg$cache39, null, false);
		string name29 = "activeColorSpace";
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_QualitySettings.get_activeColorSpace);
		}
		LuaObject.addMember(l, name29, Lua_UnityEngine_QualitySettings.<>f__mg$cache3A, null, false);
		if (Lua_UnityEngine_QualitySettings.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_QualitySettings.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_QualitySettings.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_QualitySettings.<>f__mg$cache3B, typeof(QualitySettings), typeof(UnityEngine.Object));
	}

	// Token: 0x0401965D RID: 104029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401965E RID: 104030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401965F RID: 104031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019660 RID: 104032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019661 RID: 104033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019662 RID: 104034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019663 RID: 104035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019664 RID: 104036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019665 RID: 104037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019666 RID: 104038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019667 RID: 104039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019668 RID: 104040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019669 RID: 104041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401966A RID: 104042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401966B RID: 104043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401966C RID: 104044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401966D RID: 104045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401966E RID: 104046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401966F RID: 104047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019670 RID: 104048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019671 RID: 104049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019672 RID: 104050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019673 RID: 104051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019674 RID: 104052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019675 RID: 104053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019676 RID: 104054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019677 RID: 104055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019678 RID: 104056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019679 RID: 104057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401967A RID: 104058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401967B RID: 104059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401967C RID: 104060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401967D RID: 104061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401967E RID: 104062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401967F RID: 104063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019680 RID: 104064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019681 RID: 104065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019682 RID: 104066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019683 RID: 104067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019684 RID: 104068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019685 RID: 104069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019686 RID: 104070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019687 RID: 104071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019688 RID: 104072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019689 RID: 104073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401968A RID: 104074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401968B RID: 104075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401968C RID: 104076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401968D RID: 104077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401968E RID: 104078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401968F RID: 104079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04019690 RID: 104080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04019691 RID: 104081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04019692 RID: 104082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04019693 RID: 104083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019694 RID: 104084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019695 RID: 104085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019696 RID: 104086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019697 RID: 104087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019698 RID: 104088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
