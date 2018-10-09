using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020017AF RID: 6063
[Preserve]
public class Lua_UnityEngine_RenderTextureDescriptor : LuaObject
{
	// Token: 0x06023BB8 RID: 146360 RVA: 0x00C8225C File Offset: 0x00C8045C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				int width;
				LuaObject.checkType(l, 2, out width);
				int height;
				LuaObject.checkType(l, 3, out height);
				RenderTextureDescriptor renderTextureDescriptor = new RenderTextureDescriptor(width, height);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTextureDescriptor);
				result = 2;
			}
			else if (num == 4)
			{
				int width2;
				LuaObject.checkType(l, 2, out width2);
				int height2;
				LuaObject.checkType(l, 3, out height2);
				RenderTextureFormat colorFormat;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out colorFormat);
				RenderTextureDescriptor renderTextureDescriptor = new RenderTextureDescriptor(width2, height2, colorFormat);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTextureDescriptor);
				result = 2;
			}
			else if (num == 5)
			{
				int width3;
				LuaObject.checkType(l, 2, out width3);
				int height3;
				LuaObject.checkType(l, 3, out height3);
				RenderTextureFormat colorFormat2;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out colorFormat2);
				int depthBufferBits;
				LuaObject.checkType(l, 5, out depthBufferBits);
				RenderTextureDescriptor renderTextureDescriptor = new RenderTextureDescriptor(width3, height3, colorFormat2, depthBufferBits);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTextureDescriptor);
				result = 2;
			}
			else if (num == 0)
			{
				RenderTextureDescriptor renderTextureDescriptor = default(RenderTextureDescriptor);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, renderTextureDescriptor);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BB9 RID: 146361 RVA: 0x00C823C0 File Offset: 0x00C805C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_width(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BBA RID: 146362 RVA: 0x00C82414 File Offset: 0x00C80614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_width(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			int width;
			LuaObject.checkType(l, 2, out width);
			renderTextureDescriptor.width = width;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BBB RID: 146363 RVA: 0x00C82478 File Offset: 0x00C80678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BBC RID: 146364 RVA: 0x00C824CC File Offset: 0x00C806CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			int height;
			LuaObject.checkType(l, 2, out height);
			renderTextureDescriptor.height = height;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BBD RID: 146365 RVA: 0x00C82530 File Offset: 0x00C80730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_msaaSamples(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.msaaSamples);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BBE RID: 146366 RVA: 0x00C82584 File Offset: 0x00C80784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_msaaSamples(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			int msaaSamples;
			LuaObject.checkType(l, 2, out msaaSamples);
			renderTextureDescriptor.msaaSamples = msaaSamples;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BBF RID: 146367 RVA: 0x00C825E8 File Offset: 0x00C807E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_volumeDepth(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.volumeDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC0 RID: 146368 RVA: 0x00C8263C File Offset: 0x00C8083C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_volumeDepth(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			int volumeDepth;
			LuaObject.checkType(l, 2, out volumeDepth);
			renderTextureDescriptor.volumeDepth = volumeDepth;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC1 RID: 146369 RVA: 0x00C826A0 File Offset: 0x00C808A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bindMS(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.bindMS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC2 RID: 146370 RVA: 0x00C826F4 File Offset: 0x00C808F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bindMS(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			bool bindMS;
			LuaObject.checkType(l, 2, out bindMS);
			renderTextureDescriptor.bindMS = bindMS;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC3 RID: 146371 RVA: 0x00C82758 File Offset: 0x00C80958
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_colorFormat(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTextureDescriptor.colorFormat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC4 RID: 146372 RVA: 0x00C827AC File Offset: 0x00C809AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_colorFormat(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			RenderTextureFormat colorFormat;
			LuaObject.checkEnum<RenderTextureFormat>(l, 2, out colorFormat);
			renderTextureDescriptor.colorFormat = colorFormat;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC5 RID: 146373 RVA: 0x00C82810 File Offset: 0x00C80A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depthBufferBits(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.depthBufferBits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC6 RID: 146374 RVA: 0x00C82864 File Offset: 0x00C80A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depthBufferBits(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			int depthBufferBits;
			LuaObject.checkType(l, 2, out depthBufferBits);
			renderTextureDescriptor.depthBufferBits = depthBufferBits;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC7 RID: 146375 RVA: 0x00C828C8 File Offset: 0x00C80AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dimension(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTextureDescriptor.dimension);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC8 RID: 146376 RVA: 0x00C8291C File Offset: 0x00C80B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dimension(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			TextureDimension dimension;
			LuaObject.checkEnum<TextureDimension>(l, 2, out dimension);
			renderTextureDescriptor.dimension = dimension;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BC9 RID: 146377 RVA: 0x00C82980 File Offset: 0x00C80B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowSamplingMode(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTextureDescriptor.shadowSamplingMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BCA RID: 146378 RVA: 0x00C829D4 File Offset: 0x00C80BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowSamplingMode(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			ShadowSamplingMode shadowSamplingMode;
			LuaObject.checkEnum<ShadowSamplingMode>(l, 2, out shadowSamplingMode);
			renderTextureDescriptor.shadowSamplingMode = shadowSamplingMode;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BCB RID: 146379 RVA: 0x00C82A38 File Offset: 0x00C80C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vrUsage(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTextureDescriptor.vrUsage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BCC RID: 146380 RVA: 0x00C82A8C File Offset: 0x00C80C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_vrUsage(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			VRTextureUsage vrUsage;
			LuaObject.checkEnum<VRTextureUsage>(l, 2, out vrUsage);
			renderTextureDescriptor.vrUsage = vrUsage;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BCD RID: 146381 RVA: 0x00C82AF0 File Offset: 0x00C80CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flags(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTextureDescriptor.flags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BCE RID: 146382 RVA: 0x00C82B44 File Offset: 0x00C80D44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_memoryless(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTextureDescriptor.memoryless);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BCF RID: 146383 RVA: 0x00C82B98 File Offset: 0x00C80D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_memoryless(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			RenderTextureMemoryless memoryless;
			LuaObject.checkEnum<RenderTextureMemoryless>(l, 2, out memoryless);
			renderTextureDescriptor.memoryless = memoryless;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD0 RID: 146384 RVA: 0x00C82BFC File Offset: 0x00C80DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sRGB(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.sRGB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD1 RID: 146385 RVA: 0x00C82C50 File Offset: 0x00C80E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sRGB(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			bool sRGB;
			LuaObject.checkType(l, 2, out sRGB);
			renderTextureDescriptor.sRGB = sRGB;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD2 RID: 146386 RVA: 0x00C82CB4 File Offset: 0x00C80EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useMipMap(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.useMipMap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD3 RID: 146387 RVA: 0x00C82D08 File Offset: 0x00C80F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useMipMap(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			bool useMipMap;
			LuaObject.checkType(l, 2, out useMipMap);
			renderTextureDescriptor.useMipMap = useMipMap;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD4 RID: 146388 RVA: 0x00C82D6C File Offset: 0x00C80F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoGenerateMips(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.autoGenerateMips);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD5 RID: 146389 RVA: 0x00C82DC0 File Offset: 0x00C80FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoGenerateMips(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			bool autoGenerateMips;
			LuaObject.checkType(l, 2, out autoGenerateMips);
			renderTextureDescriptor.autoGenerateMips = autoGenerateMips;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD6 RID: 146390 RVA: 0x00C82E24 File Offset: 0x00C81024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enableRandomWrite(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTextureDescriptor.enableRandomWrite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD7 RID: 146391 RVA: 0x00C82E78 File Offset: 0x00C81078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enableRandomWrite(IntPtr l)
	{
		int result;
		try
		{
			RenderTextureDescriptor renderTextureDescriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out renderTextureDescriptor);
			bool enableRandomWrite;
			LuaObject.checkType(l, 2, out enableRandomWrite);
			renderTextureDescriptor.enableRandomWrite = enableRandomWrite;
			LuaObject.setBack(l, renderTextureDescriptor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BD8 RID: 146392 RVA: 0x00C82EDC File Offset: 0x00C810DC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RenderTextureDescriptor");
		string name = "width";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_width);
		}
		LuaCSFunction get = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache0;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_width);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1, true);
		string name2 = "height";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_height);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache2;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_height);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache3, true);
		string name3 = "msaaSamples";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_msaaSamples);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache4;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_msaaSamples);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache5, true);
		string name4 = "volumeDepth";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_volumeDepth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache6;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_volumeDepth);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache7, true);
		string name5 = "bindMS";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_bindMS);
		}
		LuaCSFunction get5 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache8;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_bindMS);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache9, true);
		string name6 = "colorFormat";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_colorFormat);
		}
		LuaCSFunction get6 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheA;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_colorFormat);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheB, true);
		string name7 = "depthBufferBits";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_depthBufferBits);
		}
		LuaCSFunction get7 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheC;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_depthBufferBits);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheD, true);
		string name8 = "dimension";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_dimension);
		}
		LuaCSFunction get8 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheE;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_dimension);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cacheF, true);
		string name9 = "shadowSamplingMode";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_shadowSamplingMode);
		}
		LuaCSFunction get9 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache10;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_shadowSamplingMode);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache11, true);
		string name10 = "vrUsage";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_vrUsage);
		}
		LuaCSFunction get10 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache12;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_vrUsage);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache13, true);
		string name11 = "flags";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_flags);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache14, null, true);
		string name12 = "memoryless";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_memoryless);
		}
		LuaCSFunction get11 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache15;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_memoryless);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache16, true);
		string name13 = "sRGB";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_sRGB);
		}
		LuaCSFunction get12 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache17;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_sRGB);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache18, true);
		string name14 = "useMipMap";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_useMipMap);
		}
		LuaCSFunction get13 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache19;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_useMipMap);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1A, true);
		string name15 = "autoGenerateMips";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_autoGenerateMips);
		}
		LuaCSFunction get14 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1B;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_autoGenerateMips);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1C, true);
		string name16 = "enableRandomWrite";
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.get_enableRandomWrite);
		}
		LuaCSFunction get15 = Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1D;
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.set_enableRandomWrite);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1E, true);
		if (Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_RenderTextureDescriptor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RenderTextureDescriptor.<>f__mg$cache1F, typeof(RenderTextureDescriptor), typeof(ValueType));
	}

	// Token: 0x040198B8 RID: 104632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040198B9 RID: 104633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040198BA RID: 104634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040198BB RID: 104635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040198BC RID: 104636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040198BD RID: 104637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040198BE RID: 104638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040198BF RID: 104639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040198C0 RID: 104640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040198C1 RID: 104641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040198C2 RID: 104642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040198C3 RID: 104643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040198C4 RID: 104644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040198C5 RID: 104645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040198C6 RID: 104646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040198C7 RID: 104647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040198C8 RID: 104648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040198C9 RID: 104649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040198CA RID: 104650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040198CB RID: 104651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040198CC RID: 104652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040198CD RID: 104653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040198CE RID: 104654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040198CF RID: 104655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040198D0 RID: 104656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040198D1 RID: 104657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040198D2 RID: 104658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040198D3 RID: 104659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040198D4 RID: 104660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040198D5 RID: 104661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040198D6 RID: 104662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040198D7 RID: 104663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
