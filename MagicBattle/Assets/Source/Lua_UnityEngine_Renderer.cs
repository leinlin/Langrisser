using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x02001777 RID: 6007
[Preserve]
public class Lua_UnityEngine_Renderer : LuaObject
{
	// Token: 0x06023A38 RID: 145976 RVA: 0x00C74DC0 File Offset: 0x00C72FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPropertyBlock(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			MaterialPropertyBlock propertyBlock;
			LuaObject.checkType<MaterialPropertyBlock>(l, 2, out propertyBlock);
			renderer.SetPropertyBlock(propertyBlock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A39 RID: 145977 RVA: 0x00C74E18 File Offset: 0x00C73018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPropertyBlock(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			MaterialPropertyBlock dest;
			LuaObject.checkType<MaterialPropertyBlock>(l, 2, out dest);
			renderer.GetPropertyBlock(dest);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A3A RID: 145978 RVA: 0x00C74E70 File Offset: 0x00C73070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClosestReflectionProbes(IntPtr l)
	{
		int result2;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			List<ReflectionProbeBlendInfo> result;
			LuaObject.checkType<List<ReflectionProbeBlendInfo>>(l, 2, out result);
			renderer.GetClosestReflectionProbes(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06023A3B RID: 145979 RVA: 0x00C74EC8 File Offset: 0x00C730C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounds(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.bounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A3C RID: 145980 RVA: 0x00C74F20 File Offset: 0x00C73120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A3D RID: 145981 RVA: 0x00C74F74 File Offset: 0x00C73174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			renderer.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A3E RID: 145982 RVA: 0x00C74FCC File Offset: 0x00C731CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isVisible(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A3F RID: 145983 RVA: 0x00C75020 File Offset: 0x00C73220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowCastingMode(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderer.shadowCastingMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A40 RID: 145984 RVA: 0x00C75074 File Offset: 0x00C73274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowCastingMode(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			ShadowCastingMode shadowCastingMode;
			LuaObject.checkEnum<ShadowCastingMode>(l, 2, out shadowCastingMode);
			renderer.shadowCastingMode = shadowCastingMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A41 RID: 145985 RVA: 0x00C750CC File Offset: 0x00C732CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_receiveShadows(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.receiveShadows);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A42 RID: 145986 RVA: 0x00C75120 File Offset: 0x00C73320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_receiveShadows(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			bool receiveShadows;
			LuaObject.checkType(l, 2, out receiveShadows);
			renderer.receiveShadows = receiveShadows;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A43 RID: 145987 RVA: 0x00C75178 File Offset: 0x00C73378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_motionVectorGenerationMode(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderer.motionVectorGenerationMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A44 RID: 145988 RVA: 0x00C751CC File Offset: 0x00C733CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_motionVectorGenerationMode(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			MotionVectorGenerationMode motionVectorGenerationMode;
			LuaObject.checkEnum<MotionVectorGenerationMode>(l, 2, out motionVectorGenerationMode);
			renderer.motionVectorGenerationMode = motionVectorGenerationMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A45 RID: 145989 RVA: 0x00C75224 File Offset: 0x00C73424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightProbeUsage(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderer.lightProbeUsage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A46 RID: 145990 RVA: 0x00C75278 File Offset: 0x00C73478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightProbeUsage(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LightProbeUsage lightProbeUsage;
			LuaObject.checkEnum<LightProbeUsage>(l, 2, out lightProbeUsage);
			renderer.lightProbeUsage = lightProbeUsage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A47 RID: 145991 RVA: 0x00C752D0 File Offset: 0x00C734D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_reflectionProbeUsage(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderer.reflectionProbeUsage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A48 RID: 145992 RVA: 0x00C75324 File Offset: 0x00C73524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_reflectionProbeUsage(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			ReflectionProbeUsage reflectionProbeUsage;
			LuaObject.checkEnum<ReflectionProbeUsage>(l, 2, out reflectionProbeUsage);
			renderer.reflectionProbeUsage = reflectionProbeUsage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A49 RID: 145993 RVA: 0x00C7537C File Offset: 0x00C7357C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingLayerName(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.sortingLayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A4A RID: 145994 RVA: 0x00C753D0 File Offset: 0x00C735D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingLayerName(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			string sortingLayerName;
			LuaObject.checkType(l, 2, out sortingLayerName);
			renderer.sortingLayerName = sortingLayerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A4B RID: 145995 RVA: 0x00C75428 File Offset: 0x00C73628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingLayerID(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.sortingLayerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A4C RID: 145996 RVA: 0x00C7547C File Offset: 0x00C7367C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingLayerID(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			int sortingLayerID;
			LuaObject.checkType(l, 2, out sortingLayerID);
			renderer.sortingLayerID = sortingLayerID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A4D RID: 145997 RVA: 0x00C754D4 File Offset: 0x00C736D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingOrder(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.sortingOrder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A4E RID: 145998 RVA: 0x00C75528 File Offset: 0x00C73728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingOrder(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			int sortingOrder;
			LuaObject.checkType(l, 2, out sortingOrder);
			renderer.sortingOrder = sortingOrder;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A4F RID: 145999 RVA: 0x00C75580 File Offset: 0x00C73780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allowOcclusionWhenDynamic(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.allowOcclusionWhenDynamic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A50 RID: 146000 RVA: 0x00C755D4 File Offset: 0x00C737D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_allowOcclusionWhenDynamic(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			bool allowOcclusionWhenDynamic;
			LuaObject.checkType(l, 2, out allowOcclusionWhenDynamic);
			renderer.allowOcclusionWhenDynamic = allowOcclusionWhenDynamic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A51 RID: 146001 RVA: 0x00C7562C File Offset: 0x00C7382C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isPartOfStaticBatch(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.isPartOfStaticBatch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A52 RID: 146002 RVA: 0x00C75680 File Offset: 0x00C73880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_worldToLocalMatrix(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.worldToLocalMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A53 RID: 146003 RVA: 0x00C756D8 File Offset: 0x00C738D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_localToWorldMatrix(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.localToWorldMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A54 RID: 146004 RVA: 0x00C75730 File Offset: 0x00C73930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightProbeProxyVolumeOverride(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.lightProbeProxyVolumeOverride);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A55 RID: 146005 RVA: 0x00C75784 File Offset: 0x00C73984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightProbeProxyVolumeOverride(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			GameObject lightProbeProxyVolumeOverride;
			LuaObject.checkType<GameObject>(l, 2, out lightProbeProxyVolumeOverride);
			renderer.lightProbeProxyVolumeOverride = lightProbeProxyVolumeOverride;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A56 RID: 146006 RVA: 0x00C757DC File Offset: 0x00C739DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_probeAnchor(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.probeAnchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A57 RID: 146007 RVA: 0x00C75830 File Offset: 0x00C73A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_probeAnchor(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			Transform probeAnchor;
			LuaObject.checkType<Transform>(l, 2, out probeAnchor);
			renderer.probeAnchor = probeAnchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A58 RID: 146008 RVA: 0x00C75888 File Offset: 0x00C73A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightmapIndex(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.lightmapIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A59 RID: 146009 RVA: 0x00C758DC File Offset: 0x00C73ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightmapIndex(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			int lightmapIndex;
			LuaObject.checkType(l, 2, out lightmapIndex);
			renderer.lightmapIndex = lightmapIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A5A RID: 146010 RVA: 0x00C75934 File Offset: 0x00C73B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_realtimeLightmapIndex(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.realtimeLightmapIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A5B RID: 146011 RVA: 0x00C75988 File Offset: 0x00C73B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_realtimeLightmapIndex(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			int realtimeLightmapIndex;
			LuaObject.checkType(l, 2, out realtimeLightmapIndex);
			renderer.realtimeLightmapIndex = realtimeLightmapIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A5C RID: 146012 RVA: 0x00C759E0 File Offset: 0x00C73BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightmapScaleOffset(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.lightmapScaleOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A5D RID: 146013 RVA: 0x00C75A34 File Offset: 0x00C73C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightmapScaleOffset(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			Vector4 lightmapScaleOffset;
			LuaObject.checkType(l, 2, out lightmapScaleOffset);
			renderer.lightmapScaleOffset = lightmapScaleOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A5E RID: 146014 RVA: 0x00C75A8C File Offset: 0x00C73C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_realtimeLightmapScaleOffset(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.realtimeLightmapScaleOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A5F RID: 146015 RVA: 0x00C75AE0 File Offset: 0x00C73CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_realtimeLightmapScaleOffset(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			Vector4 realtimeLightmapScaleOffset;
			LuaObject.checkType(l, 2, out realtimeLightmapScaleOffset);
			renderer.realtimeLightmapScaleOffset = realtimeLightmapScaleOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A60 RID: 146016 RVA: 0x00C75B38 File Offset: 0x00C73D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A61 RID: 146017 RVA: 0x00C75B8C File Offset: 0x00C73D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			renderer.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A62 RID: 146018 RVA: 0x00C75BE4 File Offset: 0x00C73DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sharedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.sharedMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A63 RID: 146019 RVA: 0x00C75C38 File Offset: 0x00C73E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sharedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			Material sharedMaterial;
			LuaObject.checkType<Material>(l, 2, out sharedMaterial);
			renderer.sharedMaterial = sharedMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A64 RID: 146020 RVA: 0x00C75C90 File Offset: 0x00C73E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_materials(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.materials);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A65 RID: 146021 RVA: 0x00C75CE4 File Offset: 0x00C73EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_materials(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			Material[] materials;
			LuaObject.checkArray<Material>(l, 2, out materials);
			renderer.materials = materials;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A66 RID: 146022 RVA: 0x00C75D3C File Offset: 0x00C73F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sharedMaterials(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderer.sharedMaterials);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A67 RID: 146023 RVA: 0x00C75D90 File Offset: 0x00C73F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sharedMaterials(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer = (Renderer)LuaObject.checkSelf(l);
			Material[] sharedMaterials;
			LuaObject.checkArray<Material>(l, 2, out sharedMaterials);
			renderer.sharedMaterials = sharedMaterials;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A68 RID: 146024 RVA: 0x00C75DE8 File Offset: 0x00C73FE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Renderer");
		if (Lua_UnityEngine_Renderer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Renderer.SetPropertyBlock);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Renderer.<>f__mg$cache0);
		if (Lua_UnityEngine_Renderer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Renderer.GetPropertyBlock);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Renderer.<>f__mg$cache1);
		if (Lua_UnityEngine_Renderer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Renderer.GetClosestReflectionProbes);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Renderer.<>f__mg$cache2);
		string name = "bounds";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_bounds);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Renderer.<>f__mg$cache3, null, true);
		string name2 = "enabled";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_enabled);
		}
		LuaCSFunction get = Lua_UnityEngine_Renderer.<>f__mg$cache4;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_enabled);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Renderer.<>f__mg$cache5, true);
		string name3 = "isVisible";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_isVisible);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Renderer.<>f__mg$cache6, null, true);
		string name4 = "shadowCastingMode";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_shadowCastingMode);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Renderer.<>f__mg$cache7;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_shadowCastingMode);
		}
		LuaObject.addMember(l, name4, get2, Lua_UnityEngine_Renderer.<>f__mg$cache8, true);
		string name5 = "receiveShadows";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_receiveShadows);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Renderer.<>f__mg$cache9;
		if (Lua_UnityEngine_Renderer.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Renderer.set_receiveShadows);
		}
		LuaObject.addMember(l, name5, get3, Lua_UnityEngine_Renderer.<>f__mg$cacheA, true);
		string name6 = "motionVectorGenerationMode";
		if (Lua_UnityEngine_Renderer.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Renderer.get_motionVectorGenerationMode);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Renderer.<>f__mg$cacheB;
		if (Lua_UnityEngine_Renderer.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Renderer.set_motionVectorGenerationMode);
		}
		LuaObject.addMember(l, name6, get4, Lua_UnityEngine_Renderer.<>f__mg$cacheC, true);
		string name7 = "lightProbeUsage";
		if (Lua_UnityEngine_Renderer.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Renderer.get_lightProbeUsage);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Renderer.<>f__mg$cacheD;
		if (Lua_UnityEngine_Renderer.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Renderer.set_lightProbeUsage);
		}
		LuaObject.addMember(l, name7, get5, Lua_UnityEngine_Renderer.<>f__mg$cacheE, true);
		string name8 = "reflectionProbeUsage";
		if (Lua_UnityEngine_Renderer.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Renderer.get_reflectionProbeUsage);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Renderer.<>f__mg$cacheF;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_reflectionProbeUsage);
		}
		LuaObject.addMember(l, name8, get6, Lua_UnityEngine_Renderer.<>f__mg$cache10, true);
		string name9 = "sortingLayerName";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_sortingLayerName);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Renderer.<>f__mg$cache11;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_sortingLayerName);
		}
		LuaObject.addMember(l, name9, get7, Lua_UnityEngine_Renderer.<>f__mg$cache12, true);
		string name10 = "sortingLayerID";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_sortingLayerID);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Renderer.<>f__mg$cache13;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_sortingLayerID);
		}
		LuaObject.addMember(l, name10, get8, Lua_UnityEngine_Renderer.<>f__mg$cache14, true);
		string name11 = "sortingOrder";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_sortingOrder);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Renderer.<>f__mg$cache15;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_sortingOrder);
		}
		LuaObject.addMember(l, name11, get9, Lua_UnityEngine_Renderer.<>f__mg$cache16, true);
		string name12 = "allowOcclusionWhenDynamic";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_allowOcclusionWhenDynamic);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Renderer.<>f__mg$cache17;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_allowOcclusionWhenDynamic);
		}
		LuaObject.addMember(l, name12, get10, Lua_UnityEngine_Renderer.<>f__mg$cache18, true);
		string name13 = "isPartOfStaticBatch";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_isPartOfStaticBatch);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Renderer.<>f__mg$cache19, null, true);
		string name14 = "worldToLocalMatrix";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Renderer.get_worldToLocalMatrix);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Renderer.<>f__mg$cache1A, null, true);
		string name15 = "localToWorldMatrix";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Renderer.get_localToWorldMatrix);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Renderer.<>f__mg$cache1B, null, true);
		string name16 = "lightProbeProxyVolumeOverride";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Renderer.get_lightProbeProxyVolumeOverride);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Renderer.<>f__mg$cache1C;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Renderer.set_lightProbeProxyVolumeOverride);
		}
		LuaObject.addMember(l, name16, get11, Lua_UnityEngine_Renderer.<>f__mg$cache1D, true);
		string name17 = "probeAnchor";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Renderer.get_probeAnchor);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Renderer.<>f__mg$cache1E;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Renderer.set_probeAnchor);
		}
		LuaObject.addMember(l, name17, get12, Lua_UnityEngine_Renderer.<>f__mg$cache1F, true);
		string name18 = "lightmapIndex";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_lightmapIndex);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Renderer.<>f__mg$cache20;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_lightmapIndex);
		}
		LuaObject.addMember(l, name18, get13, Lua_UnityEngine_Renderer.<>f__mg$cache21, true);
		string name19 = "realtimeLightmapIndex";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_realtimeLightmapIndex);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Renderer.<>f__mg$cache22;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_realtimeLightmapIndex);
		}
		LuaObject.addMember(l, name19, get14, Lua_UnityEngine_Renderer.<>f__mg$cache23, true);
		string name20 = "lightmapScaleOffset";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_lightmapScaleOffset);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Renderer.<>f__mg$cache24;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_lightmapScaleOffset);
		}
		LuaObject.addMember(l, name20, get15, Lua_UnityEngine_Renderer.<>f__mg$cache25, true);
		string name21 = "realtimeLightmapScaleOffset";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_realtimeLightmapScaleOffset);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Renderer.<>f__mg$cache26;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_realtimeLightmapScaleOffset);
		}
		LuaObject.addMember(l, name21, get16, Lua_UnityEngine_Renderer.<>f__mg$cache27, true);
		string name22 = "material";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Renderer.get_material);
		}
		LuaCSFunction get17 = Lua_UnityEngine_Renderer.<>f__mg$cache28;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Renderer.set_material);
		}
		LuaObject.addMember(l, name22, get17, Lua_UnityEngine_Renderer.<>f__mg$cache29, true);
		string name23 = "sharedMaterial";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Renderer.get_sharedMaterial);
		}
		LuaCSFunction get18 = Lua_UnityEngine_Renderer.<>f__mg$cache2A;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Renderer.set_sharedMaterial);
		}
		LuaObject.addMember(l, name23, get18, Lua_UnityEngine_Renderer.<>f__mg$cache2B, true);
		string name24 = "materials";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Renderer.get_materials);
		}
		LuaCSFunction get19 = Lua_UnityEngine_Renderer.<>f__mg$cache2C;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Renderer.set_materials);
		}
		LuaObject.addMember(l, name24, get19, Lua_UnityEngine_Renderer.<>f__mg$cache2D, true);
		string name25 = "sharedMaterials";
		if (Lua_UnityEngine_Renderer.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Renderer.get_sharedMaterials);
		}
		LuaCSFunction get20 = Lua_UnityEngine_Renderer.<>f__mg$cache2E;
		if (Lua_UnityEngine_Renderer.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Renderer.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Renderer.set_sharedMaterials);
		}
		LuaObject.addMember(l, name25, get20, Lua_UnityEngine_Renderer.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(Renderer), typeof(Component));
	}

	// Token: 0x040197A8 RID: 104360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040197A9 RID: 104361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040197AA RID: 104362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040197AB RID: 104363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040197AC RID: 104364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040197AD RID: 104365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040197AE RID: 104366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040197AF RID: 104367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040197B0 RID: 104368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040197B1 RID: 104369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040197B2 RID: 104370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040197B3 RID: 104371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040197B4 RID: 104372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040197B5 RID: 104373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040197B6 RID: 104374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040197B7 RID: 104375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040197B8 RID: 104376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040197B9 RID: 104377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040197BA RID: 104378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040197BB RID: 104379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040197BC RID: 104380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040197BD RID: 104381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040197BE RID: 104382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040197BF RID: 104383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040197C0 RID: 104384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040197C1 RID: 104385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040197C2 RID: 104386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040197C3 RID: 104387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040197C4 RID: 104388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040197C5 RID: 104389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040197C6 RID: 104390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040197C7 RID: 104391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040197C8 RID: 104392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040197C9 RID: 104393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040197CA RID: 104394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040197CB RID: 104395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040197CC RID: 104396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040197CD RID: 104397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040197CE RID: 104398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040197CF RID: 104399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040197D0 RID: 104400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040197D1 RID: 104401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040197D2 RID: 104402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040197D3 RID: 104403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040197D4 RID: 104404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040197D5 RID: 104405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040197D6 RID: 104406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040197D7 RID: 104407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
