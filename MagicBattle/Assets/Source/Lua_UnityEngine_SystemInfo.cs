using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017F0 RID: 6128
[Preserve]
public class Lua_UnityEngine_SystemInfo : LuaObject
{
	// Token: 0x06023DF2 RID: 146930 RVA: 0x00C93220 File Offset: 0x00C91420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SystemInfo o = new SystemInfo();
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

	// Token: 0x06023DF3 RID: 146931 RVA: 0x00C93268 File Offset: 0x00C91468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SupportsRenderTextureFormat_s(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureFormat format;
			LuaObject.checkEnum<RenderTextureFormat>(l, 1, out format);
			bool b = SystemInfo.SupportsRenderTextureFormat(format);
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

	// Token: 0x06023DF4 RID: 146932 RVA: 0x00C932BC File Offset: 0x00C914BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SupportsBlendingOnRenderTextureFormat_s(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureFormat format;
			LuaObject.checkEnum<RenderTextureFormat>(l, 1, out format);
			bool b = SystemInfo.SupportsBlendingOnRenderTextureFormat(format);
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

	// Token: 0x06023DF5 RID: 146933 RVA: 0x00C93310 File Offset: 0x00C91510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SupportsTextureFormat_s(IntPtr l)
	{
		int result;
		try
		{
			TextureFormat format;
			LuaObject.checkEnum<TextureFormat>(l, 1, out format);
			bool b = SystemInfo.SupportsTextureFormat(format);
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

	// Token: 0x06023DF6 RID: 146934 RVA: 0x00C93364 File Offset: 0x00C91564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_unsupportedIdentifier(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "n/a");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DF7 RID: 146935 RVA: 0x00C933AC File Offset: 0x00C915AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_batteryLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.batteryLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DF8 RID: 146936 RVA: 0x00C933F4 File Offset: 0x00C915F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_batteryStatus(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)SystemInfo.batteryStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DF9 RID: 146937 RVA: 0x00C9343C File Offset: 0x00C9163C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_operatingSystem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.operatingSystem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DFA RID: 146938 RVA: 0x00C93484 File Offset: 0x00C91684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_operatingSystemFamily(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)SystemInfo.operatingSystemFamily);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DFB RID: 146939 RVA: 0x00C934CC File Offset: 0x00C916CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_processorType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.processorType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DFC RID: 146940 RVA: 0x00C93514 File Offset: 0x00C91714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_processorFrequency(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.processorFrequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DFD RID: 146941 RVA: 0x00C9355C File Offset: 0x00C9175C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_processorCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.processorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DFE RID: 146942 RVA: 0x00C935A4 File Offset: 0x00C917A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_systemMemorySize(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.systemMemorySize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DFF RID: 146943 RVA: 0x00C935EC File Offset: 0x00C917EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsMemorySize(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsMemorySize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E00 RID: 146944 RVA: 0x00C93634 File Offset: 0x00C91834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsDeviceName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsDeviceName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E01 RID: 146945 RVA: 0x00C9367C File Offset: 0x00C9187C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsDeviceVendor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsDeviceVendor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E02 RID: 146946 RVA: 0x00C936C4 File Offset: 0x00C918C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsDeviceID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsDeviceID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E03 RID: 146947 RVA: 0x00C9370C File Offset: 0x00C9190C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsDeviceVendorID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsDeviceVendorID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E04 RID: 146948 RVA: 0x00C93754 File Offset: 0x00C91954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsDeviceType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)SystemInfo.graphicsDeviceType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E05 RID: 146949 RVA: 0x00C9379C File Offset: 0x00C9199C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsUVStartsAtTop(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsUVStartsAtTop);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E06 RID: 146950 RVA: 0x00C937E4 File Offset: 0x00C919E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsDeviceVersion(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsDeviceVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E07 RID: 146951 RVA: 0x00C9382C File Offset: 0x00C91A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsShaderLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsShaderLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E08 RID: 146952 RVA: 0x00C93874 File Offset: 0x00C91A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphicsMultiThreaded(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.graphicsMultiThreaded);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E09 RID: 146953 RVA: 0x00C938BC File Offset: 0x00C91ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsShadows(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsShadows);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E0A RID: 146954 RVA: 0x00C93904 File Offset: 0x00C91B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsRawShadowDepthSampling(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsRawShadowDepthSampling);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E0B RID: 146955 RVA: 0x00C9394C File Offset: 0x00C91B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsMotionVectors(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsMotionVectors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E0C RID: 146956 RVA: 0x00C93994 File Offset: 0x00C91B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsRenderToCubemap(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsRenderToCubemap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E0D RID: 146957 RVA: 0x00C939DC File Offset: 0x00C91BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsImageEffects(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsImageEffects);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E0E RID: 146958 RVA: 0x00C93A24 File Offset: 0x00C91C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supports3DTextures(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supports3DTextures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E0F RID: 146959 RVA: 0x00C93A6C File Offset: 0x00C91C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supports2DArrayTextures(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supports2DArrayTextures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E10 RID: 146960 RVA: 0x00C93AB4 File Offset: 0x00C91CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supports3DRenderTextures(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supports3DRenderTextures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E11 RID: 146961 RVA: 0x00C93AFC File Offset: 0x00C91CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsCubemapArrayTextures(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsCubemapArrayTextures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E12 RID: 146962 RVA: 0x00C93B44 File Offset: 0x00C91D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_copyTextureSupport(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)SystemInfo.copyTextureSupport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E13 RID: 146963 RVA: 0x00C93B8C File Offset: 0x00C91D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsComputeShaders(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsComputeShaders);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E14 RID: 146964 RVA: 0x00C93BD4 File Offset: 0x00C91DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsInstancing(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsInstancing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E15 RID: 146965 RVA: 0x00C93C1C File Offset: 0x00C91E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsSparseTextures(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsSparseTextures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E16 RID: 146966 RVA: 0x00C93C64 File Offset: 0x00C91E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportedRenderTargetCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportedRenderTargetCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E17 RID: 146967 RVA: 0x00C93CAC File Offset: 0x00C91EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsMultisampledTextures(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsMultisampledTextures);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E18 RID: 146968 RVA: 0x00C93CF4 File Offset: 0x00C91EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsTextureWrapMirrorOnce(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsTextureWrapMirrorOnce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E19 RID: 146969 RVA: 0x00C93D3C File Offset: 0x00C91F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_usesReversedZBuffer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.usesReversedZBuffer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E1A RID: 146970 RVA: 0x00C93D84 File Offset: 0x00C91F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_npotSupport(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)SystemInfo.npotSupport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E1B RID: 146971 RVA: 0x00C93DCC File Offset: 0x00C91FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deviceUniqueIdentifier(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.deviceUniqueIdentifier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E1C RID: 146972 RVA: 0x00C93E14 File Offset: 0x00C92014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deviceName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.deviceName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E1D RID: 146973 RVA: 0x00C93E5C File Offset: 0x00C9205C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deviceModel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.deviceModel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E1E RID: 146974 RVA: 0x00C93EA4 File Offset: 0x00C920A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsAccelerometer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsAccelerometer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E1F RID: 146975 RVA: 0x00C93EEC File Offset: 0x00C920EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsGyroscope(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsGyroscope);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E20 RID: 146976 RVA: 0x00C93F34 File Offset: 0x00C92134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsLocationService(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsLocationService);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E21 RID: 146977 RVA: 0x00C93F7C File Offset: 0x00C9217C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsVibration(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsVibration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E22 RID: 146978 RVA: 0x00C93FC4 File Offset: 0x00C921C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsAudio(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsAudio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E23 RID: 146979 RVA: 0x00C9400C File Offset: 0x00C9220C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deviceType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)SystemInfo.deviceType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E24 RID: 146980 RVA: 0x00C94054 File Offset: 0x00C92254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxTextureSize(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.maxTextureSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E25 RID: 146981 RVA: 0x00C9409C File Offset: 0x00C9229C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxCubemapSize(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.maxCubemapSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E26 RID: 146982 RVA: 0x00C940E4 File Offset: 0x00C922E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsAsyncCompute(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsAsyncCompute);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E27 RID: 146983 RVA: 0x00C9412C File Offset: 0x00C9232C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_supportsGPUFence(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemInfo.supportsGPUFence);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E28 RID: 146984 RVA: 0x00C94174 File Offset: 0x00C92374
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SystemInfo");
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.SupportsRenderTextureFormat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SystemInfo.<>f__mg$cache0);
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.SupportsBlendingOnRenderTextureFormat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SystemInfo.<>f__mg$cache1);
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.SupportsTextureFormat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SystemInfo.<>f__mg$cache2);
		string name = "unsupportedIdentifier";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_unsupportedIdentifier);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_SystemInfo.<>f__mg$cache3, null, false);
		string name2 = "batteryLevel";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_batteryLevel);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_SystemInfo.<>f__mg$cache4, null, false);
		string name3 = "batteryStatus";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_batteryStatus);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_SystemInfo.<>f__mg$cache5, null, false);
		string name4 = "operatingSystem";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_operatingSystem);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_SystemInfo.<>f__mg$cache6, null, false);
		string name5 = "operatingSystemFamily";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_operatingSystemFamily);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_SystemInfo.<>f__mg$cache7, null, false);
		string name6 = "processorType";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_processorType);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_SystemInfo.<>f__mg$cache8, null, false);
		string name7 = "processorFrequency";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_processorFrequency);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_SystemInfo.<>f__mg$cache9, null, false);
		string name8 = "processorCount";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_processorCount);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_SystemInfo.<>f__mg$cacheA, null, false);
		string name9 = "systemMemorySize";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_systemMemorySize);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_SystemInfo.<>f__mg$cacheB, null, false);
		string name10 = "graphicsMemorySize";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsMemorySize);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_SystemInfo.<>f__mg$cacheC, null, false);
		string name11 = "graphicsDeviceName";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsDeviceName);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_SystemInfo.<>f__mg$cacheD, null, false);
		string name12 = "graphicsDeviceVendor";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsDeviceVendor);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_SystemInfo.<>f__mg$cacheE, null, false);
		string name13 = "graphicsDeviceID";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsDeviceID);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_SystemInfo.<>f__mg$cacheF, null, false);
		string name14 = "graphicsDeviceVendorID";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsDeviceVendorID);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_SystemInfo.<>f__mg$cache10, null, false);
		string name15 = "graphicsDeviceType";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsDeviceType);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_SystemInfo.<>f__mg$cache11, null, false);
		string name16 = "graphicsUVStartsAtTop";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsUVStartsAtTop);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_SystemInfo.<>f__mg$cache12, null, false);
		string name17 = "graphicsDeviceVersion";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsDeviceVersion);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_SystemInfo.<>f__mg$cache13, null, false);
		string name18 = "graphicsShaderLevel";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsShaderLevel);
		}
		LuaObject.addMember(l, name18, Lua_UnityEngine_SystemInfo.<>f__mg$cache14, null, false);
		string name19 = "graphicsMultiThreaded";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_graphicsMultiThreaded);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_SystemInfo.<>f__mg$cache15, null, false);
		string name20 = "supportsShadows";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsShadows);
		}
		LuaObject.addMember(l, name20, Lua_UnityEngine_SystemInfo.<>f__mg$cache16, null, false);
		string name21 = "supportsRawShadowDepthSampling";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsRawShadowDepthSampling);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_SystemInfo.<>f__mg$cache17, null, false);
		string name22 = "supportsMotionVectors";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsMotionVectors);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_SystemInfo.<>f__mg$cache18, null, false);
		string name23 = "supportsRenderToCubemap";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsRenderToCubemap);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_SystemInfo.<>f__mg$cache19, null, false);
		string name24 = "supportsImageEffects";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsImageEffects);
		}
		LuaObject.addMember(l, name24, Lua_UnityEngine_SystemInfo.<>f__mg$cache1A, null, false);
		string name25 = "supports3DTextures";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supports3DTextures);
		}
		LuaObject.addMember(l, name25, Lua_UnityEngine_SystemInfo.<>f__mg$cache1B, null, false);
		string name26 = "supports2DArrayTextures";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supports2DArrayTextures);
		}
		LuaObject.addMember(l, name26, Lua_UnityEngine_SystemInfo.<>f__mg$cache1C, null, false);
		string name27 = "supports3DRenderTextures";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supports3DRenderTextures);
		}
		LuaObject.addMember(l, name27, Lua_UnityEngine_SystemInfo.<>f__mg$cache1D, null, false);
		string name28 = "supportsCubemapArrayTextures";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsCubemapArrayTextures);
		}
		LuaObject.addMember(l, name28, Lua_UnityEngine_SystemInfo.<>f__mg$cache1E, null, false);
		string name29 = "copyTextureSupport";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_copyTextureSupport);
		}
		LuaObject.addMember(l, name29, Lua_UnityEngine_SystemInfo.<>f__mg$cache1F, null, false);
		string name30 = "supportsComputeShaders";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsComputeShaders);
		}
		LuaObject.addMember(l, name30, Lua_UnityEngine_SystemInfo.<>f__mg$cache20, null, false);
		string name31 = "supportsInstancing";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsInstancing);
		}
		LuaObject.addMember(l, name31, Lua_UnityEngine_SystemInfo.<>f__mg$cache21, null, false);
		string name32 = "supportsSparseTextures";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsSparseTextures);
		}
		LuaObject.addMember(l, name32, Lua_UnityEngine_SystemInfo.<>f__mg$cache22, null, false);
		string name33 = "supportedRenderTargetCount";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportedRenderTargetCount);
		}
		LuaObject.addMember(l, name33, Lua_UnityEngine_SystemInfo.<>f__mg$cache23, null, false);
		string name34 = "supportsMultisampledTextures";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsMultisampledTextures);
		}
		LuaObject.addMember(l, name34, Lua_UnityEngine_SystemInfo.<>f__mg$cache24, null, false);
		string name35 = "supportsTextureWrapMirrorOnce";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsTextureWrapMirrorOnce);
		}
		LuaObject.addMember(l, name35, Lua_UnityEngine_SystemInfo.<>f__mg$cache25, null, false);
		string name36 = "usesReversedZBuffer";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_usesReversedZBuffer);
		}
		LuaObject.addMember(l, name36, Lua_UnityEngine_SystemInfo.<>f__mg$cache26, null, false);
		string name37 = "npotSupport";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_npotSupport);
		}
		LuaObject.addMember(l, name37, Lua_UnityEngine_SystemInfo.<>f__mg$cache27, null, false);
		string name38 = "deviceUniqueIdentifier";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_deviceUniqueIdentifier);
		}
		LuaObject.addMember(l, name38, Lua_UnityEngine_SystemInfo.<>f__mg$cache28, null, false);
		string name39 = "deviceName";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_deviceName);
		}
		LuaObject.addMember(l, name39, Lua_UnityEngine_SystemInfo.<>f__mg$cache29, null, false);
		string name40 = "deviceModel";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_deviceModel);
		}
		LuaObject.addMember(l, name40, Lua_UnityEngine_SystemInfo.<>f__mg$cache2A, null, false);
		string name41 = "supportsAccelerometer";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsAccelerometer);
		}
		LuaObject.addMember(l, name41, Lua_UnityEngine_SystemInfo.<>f__mg$cache2B, null, false);
		string name42 = "supportsGyroscope";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsGyroscope);
		}
		LuaObject.addMember(l, name42, Lua_UnityEngine_SystemInfo.<>f__mg$cache2C, null, false);
		string name43 = "supportsLocationService";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsLocationService);
		}
		LuaObject.addMember(l, name43, Lua_UnityEngine_SystemInfo.<>f__mg$cache2D, null, false);
		string name44 = "supportsVibration";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsVibration);
		}
		LuaObject.addMember(l, name44, Lua_UnityEngine_SystemInfo.<>f__mg$cache2E, null, false);
		string name45 = "supportsAudio";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsAudio);
		}
		LuaObject.addMember(l, name45, Lua_UnityEngine_SystemInfo.<>f__mg$cache2F, null, false);
		string name46 = "deviceType";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_deviceType);
		}
		LuaObject.addMember(l, name46, Lua_UnityEngine_SystemInfo.<>f__mg$cache30, null, false);
		string name47 = "maxTextureSize";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_maxTextureSize);
		}
		LuaObject.addMember(l, name47, Lua_UnityEngine_SystemInfo.<>f__mg$cache31, null, false);
		string name48 = "maxCubemapSize";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_maxCubemapSize);
		}
		LuaObject.addMember(l, name48, Lua_UnityEngine_SystemInfo.<>f__mg$cache32, null, false);
		string name49 = "supportsAsyncCompute";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsAsyncCompute);
		}
		LuaObject.addMember(l, name49, Lua_UnityEngine_SystemInfo.<>f__mg$cache33, null, false);
		string name50 = "supportsGPUFence";
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.get_supportsGPUFence);
		}
		LuaObject.addMember(l, name50, Lua_UnityEngine_SystemInfo.<>f__mg$cache34, null, false);
		if (Lua_UnityEngine_SystemInfo.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_SystemInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_SystemInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SystemInfo.<>f__mg$cache35, typeof(SystemInfo));
	}

	// Token: 0x04019A70 RID: 105072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A71 RID: 105073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A72 RID: 105074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A73 RID: 105075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A74 RID: 105076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A75 RID: 105077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A76 RID: 105078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019A77 RID: 105079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019A78 RID: 105080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019A79 RID: 105081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019A7A RID: 105082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019A7B RID: 105083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019A7C RID: 105084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019A7D RID: 105085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019A7E RID: 105086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019A7F RID: 105087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019A80 RID: 105088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019A81 RID: 105089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019A82 RID: 105090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019A83 RID: 105091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019A84 RID: 105092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019A85 RID: 105093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019A86 RID: 105094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019A87 RID: 105095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019A88 RID: 105096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019A89 RID: 105097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019A8A RID: 105098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019A8B RID: 105099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019A8C RID: 105100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019A8D RID: 105101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019A8E RID: 105102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019A8F RID: 105103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019A90 RID: 105104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019A91 RID: 105105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019A92 RID: 105106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019A93 RID: 105107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019A94 RID: 105108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019A95 RID: 105109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019A96 RID: 105110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019A97 RID: 105111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019A98 RID: 105112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019A99 RID: 105113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019A9A RID: 105114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019A9B RID: 105115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019A9C RID: 105116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019A9D RID: 105117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019A9E RID: 105118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019A9F RID: 105119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019AA0 RID: 105120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04019AA1 RID: 105121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04019AA2 RID: 105122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04019AA3 RID: 105123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04019AA4 RID: 105124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04019AA5 RID: 105125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;
}
