using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x02001774 RID: 6004
[Preserve]
public class Lua_UnityEngine_ReflectionProbe : LuaObject
{
	// Token: 0x060239F3 RID: 145907 RVA: 0x00C72EB4 File Offset: 0x00C710B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RenderProbe(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
				RenderTexture targetTexture;
				LuaObject.checkType<RenderTexture>(l, 2, out targetTexture);
				int i = reflectionProbe.RenderProbe(targetTexture);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 1)
			{
				ReflectionProbe reflectionProbe2 = (ReflectionProbe)LuaObject.checkSelf(l);
				int i2 = reflectionProbe2.RenderProbe();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RenderProbe to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239F4 RID: 145908 RVA: 0x00C72F74 File Offset: 0x00C71174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFinishedRendering(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			int renderId;
			LuaObject.checkType(l, 2, out renderId);
			bool b = reflectionProbe.IsFinishedRendering(renderId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239F5 RID: 145909 RVA: 0x00C72FD8 File Offset: 0x00C711D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BlendCubemap_s(IntPtr l)
	{
		int result;
		try
		{
			Texture src;
			LuaObject.checkType<Texture>(l, 1, out src);
			Texture dst;
			LuaObject.checkType<Texture>(l, 2, out dst);
			float blend;
			LuaObject.checkType(l, 3, out blend);
			RenderTexture target;
			LuaObject.checkType<RenderTexture>(l, 4, out target);
			bool b = ReflectionProbe.BlendCubemap(src, dst, blend, target);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239F6 RID: 145910 RVA: 0x00C73054 File Offset: 0x00C71254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hdr(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.hdr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239F7 RID: 145911 RVA: 0x00C730A8 File Offset: 0x00C712A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hdr(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			bool hdr;
			LuaObject.checkType(l, 2, out hdr);
			reflectionProbe.hdr = hdr;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239F8 RID: 145912 RVA: 0x00C73100 File Offset: 0x00C71300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239F9 RID: 145913 RVA: 0x00C73154 File Offset: 0x00C71354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			Vector3 size;
			LuaObject.checkType(l, 2, out size);
			reflectionProbe.size = size;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239FA RID: 145914 RVA: 0x00C731AC File Offset: 0x00C713AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239FB RID: 145915 RVA: 0x00C73200 File Offset: 0x00C71400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			reflectionProbe.center = center;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239FC RID: 145916 RVA: 0x00C73258 File Offset: 0x00C71458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_nearClipPlane(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.nearClipPlane);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239FD RID: 145917 RVA: 0x00C732AC File Offset: 0x00C714AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_nearClipPlane(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			float nearClipPlane;
			LuaObject.checkType(l, 2, out nearClipPlane);
			reflectionProbe.nearClipPlane = nearClipPlane;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239FE RID: 145918 RVA: 0x00C73304 File Offset: 0x00C71504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_farClipPlane(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.farClipPlane);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239FF RID: 145919 RVA: 0x00C73358 File Offset: 0x00C71558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_farClipPlane(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			float farClipPlane;
			LuaObject.checkType(l, 2, out farClipPlane);
			reflectionProbe.farClipPlane = farClipPlane;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A00 RID: 145920 RVA: 0x00C733B0 File Offset: 0x00C715B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowDistance(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.shadowDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A01 RID: 145921 RVA: 0x00C73404 File Offset: 0x00C71604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowDistance(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			float shadowDistance;
			LuaObject.checkType(l, 2, out shadowDistance);
			reflectionProbe.shadowDistance = shadowDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A02 RID: 145922 RVA: 0x00C7345C File Offset: 0x00C7165C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resolution(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.resolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A03 RID: 145923 RVA: 0x00C734B0 File Offset: 0x00C716B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resolution(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			int resolution;
			LuaObject.checkType(l, 2, out resolution);
			reflectionProbe.resolution = resolution;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A04 RID: 145924 RVA: 0x00C73508 File Offset: 0x00C71708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cullingMask(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.cullingMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A05 RID: 145925 RVA: 0x00C7355C File Offset: 0x00C7175C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cullingMask(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			int cullingMask;
			LuaObject.checkType(l, 2, out cullingMask);
			reflectionProbe.cullingMask = cullingMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A06 RID: 145926 RVA: 0x00C735B4 File Offset: 0x00C717B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clearFlags(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)reflectionProbe.clearFlags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A07 RID: 145927 RVA: 0x00C73608 File Offset: 0x00C71808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_clearFlags(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			ReflectionProbeClearFlags clearFlags;
			LuaObject.checkEnum<ReflectionProbeClearFlags>(l, 2, out clearFlags);
			reflectionProbe.clearFlags = clearFlags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A08 RID: 145928 RVA: 0x00C73660 File Offset: 0x00C71860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_backgroundColor(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.backgroundColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A09 RID: 145929 RVA: 0x00C736B4 File Offset: 0x00C718B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_backgroundColor(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			Color backgroundColor;
			LuaObject.checkType(l, 2, out backgroundColor);
			reflectionProbe.backgroundColor = backgroundColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A0A RID: 145930 RVA: 0x00C7370C File Offset: 0x00C7190C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_intensity(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.intensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A0B RID: 145931 RVA: 0x00C73760 File Offset: 0x00C71960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_intensity(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			float intensity;
			LuaObject.checkType(l, 2, out intensity);
			reflectionProbe.intensity = intensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A0C RID: 145932 RVA: 0x00C737B8 File Offset: 0x00C719B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_blendDistance(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.blendDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A0D RID: 145933 RVA: 0x00C7380C File Offset: 0x00C71A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_blendDistance(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			float blendDistance;
			LuaObject.checkType(l, 2, out blendDistance);
			reflectionProbe.blendDistance = blendDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A0E RID: 145934 RVA: 0x00C73864 File Offset: 0x00C71A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_boxProjection(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.boxProjection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A0F RID: 145935 RVA: 0x00C738B8 File Offset: 0x00C71AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_boxProjection(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			bool boxProjection;
			LuaObject.checkType(l, 2, out boxProjection);
			reflectionProbe.boxProjection = boxProjection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A10 RID: 145936 RVA: 0x00C73910 File Offset: 0x00C71B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounds(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.bounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A11 RID: 145937 RVA: 0x00C73968 File Offset: 0x00C71B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mode(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)reflectionProbe.mode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A12 RID: 145938 RVA: 0x00C739BC File Offset: 0x00C71BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mode(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			ReflectionProbeMode mode;
			LuaObject.checkEnum<ReflectionProbeMode>(l, 2, out mode);
			reflectionProbe.mode = mode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A13 RID: 145939 RVA: 0x00C73A14 File Offset: 0x00C71C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_importance(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.importance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A14 RID: 145940 RVA: 0x00C73A68 File Offset: 0x00C71C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_importance(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			int importance;
			LuaObject.checkType(l, 2, out importance);
			reflectionProbe.importance = importance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A15 RID: 145941 RVA: 0x00C73AC0 File Offset: 0x00C71CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_refreshMode(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)reflectionProbe.refreshMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A16 RID: 145942 RVA: 0x00C73B14 File Offset: 0x00C71D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_refreshMode(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			ReflectionProbeRefreshMode refreshMode;
			LuaObject.checkEnum<ReflectionProbeRefreshMode>(l, 2, out refreshMode);
			reflectionProbe.refreshMode = refreshMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A17 RID: 145943 RVA: 0x00C73B6C File Offset: 0x00C71D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_timeSlicingMode(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)reflectionProbe.timeSlicingMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A18 RID: 145944 RVA: 0x00C73BC0 File Offset: 0x00C71DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_timeSlicingMode(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			ReflectionProbeTimeSlicingMode timeSlicingMode;
			LuaObject.checkEnum<ReflectionProbeTimeSlicingMode>(l, 2, out timeSlicingMode);
			reflectionProbe.timeSlicingMode = timeSlicingMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A19 RID: 145945 RVA: 0x00C73C18 File Offset: 0x00C71E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bakedTexture(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.bakedTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A1A RID: 145946 RVA: 0x00C73C6C File Offset: 0x00C71E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bakedTexture(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			Texture bakedTexture;
			LuaObject.checkType<Texture>(l, 2, out bakedTexture);
			reflectionProbe.bakedTexture = bakedTexture;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A1B RID: 145947 RVA: 0x00C73CC4 File Offset: 0x00C71EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_customBakedTexture(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.customBakedTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A1C RID: 145948 RVA: 0x00C73D18 File Offset: 0x00C71F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_customBakedTexture(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			Texture customBakedTexture;
			LuaObject.checkType<Texture>(l, 2, out customBakedTexture);
			reflectionProbe.customBakedTexture = customBakedTexture;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A1D RID: 145949 RVA: 0x00C73D70 File Offset: 0x00C71F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_texture(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.texture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A1E RID: 145950 RVA: 0x00C73DC4 File Offset: 0x00C71FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_textureHDRDecodeValues(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbe reflectionProbe = (ReflectionProbe)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbe.textureHDRDecodeValues);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A1F RID: 145951 RVA: 0x00C73E18 File Offset: 0x00C72018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minBakedCubemapResolution(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ReflectionProbe.minBakedCubemapResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A20 RID: 145952 RVA: 0x00C73E60 File Offset: 0x00C72060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxBakedCubemapResolution(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ReflectionProbe.maxBakedCubemapResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A21 RID: 145953 RVA: 0x00C73EA8 File Offset: 0x00C720A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultTextureHDRDecodeValues(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ReflectionProbe.defaultTextureHDRDecodeValues);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A22 RID: 145954 RVA: 0x00C73EF0 File Offset: 0x00C720F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultTexture(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ReflectionProbe.defaultTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A23 RID: 145955 RVA: 0x00C73F38 File Offset: 0x00C72138
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ReflectionProbe");
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.RenderProbe);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache0);
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.IsFinishedRendering);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1);
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.BlendCubemap_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2);
		string name = "hdr";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_hdr);
		}
		LuaCSFunction get = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache3;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_hdr);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache4, true);
		string name2 = "size";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_size);
		}
		LuaCSFunction get2 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache5;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_size);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache6, true);
		string name3 = "center";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_center);
		}
		LuaCSFunction get3 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache7;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_center);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache8, true);
		string name4 = "nearClipPlane";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_nearClipPlane);
		}
		LuaCSFunction get4 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache9;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_nearClipPlane);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheA, true);
		string name5 = "farClipPlane";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_farClipPlane);
		}
		LuaCSFunction get5 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheB;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_farClipPlane);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheC, true);
		string name6 = "shadowDistance";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_shadowDistance);
		}
		LuaCSFunction get6 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheD;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_shadowDistance);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheE, true);
		string name7 = "resolution";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_resolution);
		}
		LuaCSFunction get7 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cacheF;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_resolution);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache10, true);
		string name8 = "cullingMask";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_cullingMask);
		}
		LuaCSFunction get8 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache11;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_cullingMask);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache12, true);
		string name9 = "clearFlags";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_clearFlags);
		}
		LuaCSFunction get9 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache13;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_clearFlags);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache14, true);
		string name10 = "backgroundColor";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_backgroundColor);
		}
		LuaCSFunction get10 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache15;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_backgroundColor);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache16, true);
		string name11 = "intensity";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_intensity);
		}
		LuaCSFunction get11 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache17;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_intensity);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache18, true);
		string name12 = "blendDistance";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_blendDistance);
		}
		LuaCSFunction get12 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache19;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_blendDistance);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1A, true);
		string name13 = "boxProjection";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_boxProjection);
		}
		LuaCSFunction get13 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1B;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_boxProjection);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1C, true);
		string name14 = "bounds";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_bounds);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1D, null, true);
		string name15 = "mode";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_mode);
		}
		LuaCSFunction get14 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1E;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_mode);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache1F, true);
		string name16 = "importance";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_importance);
		}
		LuaCSFunction get15 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache20;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_importance);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache21, true);
		string name17 = "refreshMode";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_refreshMode);
		}
		LuaCSFunction get16 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache22;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_refreshMode);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache23, true);
		string name18 = "timeSlicingMode";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_timeSlicingMode);
		}
		LuaCSFunction get17 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache24;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_timeSlicingMode);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache25, true);
		string name19 = "bakedTexture";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_bakedTexture);
		}
		LuaCSFunction get18 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache26;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_bakedTexture);
		}
		LuaObject.addMember(l, name19, get18, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache27, true);
		string name20 = "customBakedTexture";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_customBakedTexture);
		}
		LuaCSFunction get19 = Lua_UnityEngine_ReflectionProbe.<>f__mg$cache28;
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.set_customBakedTexture);
		}
		LuaObject.addMember(l, name20, get19, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache29, true);
		string name21 = "texture";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_texture);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2A, null, true);
		string name22 = "textureHDRDecodeValues";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_textureHDRDecodeValues);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2B, null, true);
		string name23 = "minBakedCubemapResolution";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_minBakedCubemapResolution);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2C, null, false);
		string name24 = "maxBakedCubemapResolution";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_maxBakedCubemapResolution);
		}
		LuaObject.addMember(l, name24, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2D, null, false);
		string name25 = "defaultTextureHDRDecodeValues";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_defaultTextureHDRDecodeValues);
		}
		LuaObject.addMember(l, name25, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2E, null, false);
		string name26 = "defaultTexture";
		if (Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_ReflectionProbe.get_defaultTexture);
		}
		LuaObject.addMember(l, name26, Lua_UnityEngine_ReflectionProbe.<>f__mg$cache2F, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(ReflectionProbe), typeof(Behaviour));
	}

	// Token: 0x04019769 RID: 104297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401976A RID: 104298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401976B RID: 104299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401976C RID: 104300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401976D RID: 104301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401976E RID: 104302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401976F RID: 104303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019770 RID: 104304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019771 RID: 104305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019772 RID: 104306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019773 RID: 104307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019774 RID: 104308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019775 RID: 104309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019776 RID: 104310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019777 RID: 104311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019778 RID: 104312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019779 RID: 104313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401977A RID: 104314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401977B RID: 104315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401977C RID: 104316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401977D RID: 104317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401977E RID: 104318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401977F RID: 104319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019780 RID: 104320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019781 RID: 104321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019782 RID: 104322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019783 RID: 104323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019784 RID: 104324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019785 RID: 104325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019786 RID: 104326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019787 RID: 104327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019788 RID: 104328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019789 RID: 104329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401978A RID: 104330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401978B RID: 104331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401978C RID: 104332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401978D RID: 104333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401978E RID: 104334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401978F RID: 104335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019790 RID: 104336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019791 RID: 104337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019792 RID: 104338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019793 RID: 104339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019794 RID: 104340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019795 RID: 104341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019796 RID: 104342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019797 RID: 104343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019798 RID: 104344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
