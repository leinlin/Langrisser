using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020017AD RID: 6061
[Preserve]
public class Lua_UnityEngine_RenderTexture : LuaObject
{
	// Token: 0x06023B82 RID: 146306 RVA: 0x00C80478 File Offset: 0x00C7E678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 6)
			{
				int width;
				LuaObject.checkType(l, 2, out width);
				int height;
				LuaObject.checkType(l, 3, out height);
				int depth;
				LuaObject.checkType(l, 4, out depth);
				RenderTextureFormat format;
				LuaObject.checkEnum<RenderTextureFormat>(l, 5, out format);
				RenderTextureReadWrite readWrite;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 6, out readWrite);
				RenderTexture o = new RenderTexture(width, height, depth, format, readWrite);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 5)
			{
				int width2;
				LuaObject.checkType(l, 2, out width2);
				int height2;
				LuaObject.checkType(l, 3, out height2);
				int depth2;
				LuaObject.checkType(l, 4, out depth2);
				RenderTextureFormat format2;
				LuaObject.checkEnum<RenderTextureFormat>(l, 5, out format2);
				RenderTexture o = new RenderTexture(width2, height2, depth2, format2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				int width3;
				LuaObject.checkType(l, 2, out width3);
				int height3;
				LuaObject.checkType(l, 3, out height3);
				int depth3;
				LuaObject.checkType(l, 4, out depth3);
				RenderTexture o = new RenderTexture(width3, height3, depth3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTextureDescriptor)))
			{
				RenderTextureDescriptor desc;
				LuaObject.checkValueType<RenderTextureDescriptor>(l, 2, out desc);
				RenderTexture o = new RenderTexture(desc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTexture)))
			{
				RenderTexture textureToCopy;
				LuaObject.checkType<RenderTexture>(l, 2, out textureToCopy);
				RenderTexture o = new RenderTexture(textureToCopy);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
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

	// Token: 0x06023B83 RID: 146307 RVA: 0x00C80644 File Offset: 0x00C7E844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResolveAntiAliasedSurface(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
				renderTexture.ResolveAntiAliasedSurface();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				RenderTexture renderTexture2 = (RenderTexture)LuaObject.checkSelf(l);
				RenderTexture target;
				LuaObject.checkType<RenderTexture>(l, 2, out target);
				renderTexture2.ResolveAntiAliasedSurface(target);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ResolveAntiAliasedSurface to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B84 RID: 146308 RVA: 0x00C806EC File Offset: 0x00C7E8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			bool b = renderTexture.Create();
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

	// Token: 0x06023B85 RID: 146309 RVA: 0x00C80740 File Offset: 0x00C7E940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Release(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			renderTexture.Release();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B86 RID: 146310 RVA: 0x00C8078C File Offset: 0x00C7E98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCreated(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			bool b = renderTexture.IsCreated();
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

	// Token: 0x06023B87 RID: 146311 RVA: 0x00C807E0 File Offset: 0x00C7E9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DiscardContents(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
				renderTexture.DiscardContents();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				RenderTexture renderTexture2 = (RenderTexture)LuaObject.checkSelf(l);
				bool discardColor;
				LuaObject.checkType(l, 2, out discardColor);
				bool discardDepth;
				LuaObject.checkType(l, 3, out discardDepth);
				renderTexture2.DiscardContents(discardColor, discardDepth);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DiscardContents to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B88 RID: 146312 RVA: 0x00C80894 File Offset: 0x00C7EA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MarkRestoreExpected(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			renderTexture.MarkRestoreExpected();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B89 RID: 146313 RVA: 0x00C808E0 File Offset: 0x00C7EAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateMips(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			renderTexture.GenerateMips();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B8A RID: 146314 RVA: 0x00C8092C File Offset: 0x00C7EB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNativeDepthBufferPtr(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			IntPtr nativeDepthBufferPtr = renderTexture.GetNativeDepthBufferPtr();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nativeDepthBufferPtr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B8B RID: 146315 RVA: 0x00C80988 File Offset: 0x00C7EB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalShaderProperty(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			string globalShaderProperty;
			LuaObject.checkType(l, 2, out globalShaderProperty);
			renderTexture.SetGlobalShaderProperty(globalShaderProperty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B8C RID: 146316 RVA: 0x00C809E0 File Offset: 0x00C7EBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTemporary_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				RenderTextureDescriptor desc;
				LuaObject.checkValueType<RenderTextureDescriptor>(l, 1, out desc);
				RenderTexture temporary = RenderTexture.GetTemporary(desc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary);
				result = 2;
			}
			else if (num == 2)
			{
				int width;
				LuaObject.checkType(l, 1, out width);
				int height;
				LuaObject.checkType(l, 2, out height);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary2);
				result = 2;
			}
			else if (num == 3)
			{
				int width2;
				LuaObject.checkType(l, 1, out width2);
				int height2;
				LuaObject.checkType(l, 2, out height2);
				int depthBuffer;
				LuaObject.checkType(l, 3, out depthBuffer);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, depthBuffer);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary3);
				result = 2;
			}
			else if (num == 4)
			{
				int width3;
				LuaObject.checkType(l, 1, out width3);
				int height3;
				LuaObject.checkType(l, 2, out height3);
				int depthBuffer2;
				LuaObject.checkType(l, 3, out depthBuffer2);
				RenderTextureFormat format;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out format);
				RenderTexture temporary4 = RenderTexture.GetTemporary(width3, height3, depthBuffer2, format);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary4);
				result = 2;
			}
			else if (num == 5)
			{
				int width4;
				LuaObject.checkType(l, 1, out width4);
				int height4;
				LuaObject.checkType(l, 2, out height4);
				int depthBuffer3;
				LuaObject.checkType(l, 3, out depthBuffer3);
				RenderTextureFormat format2;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out format2);
				RenderTextureReadWrite readWrite;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 5, out readWrite);
				RenderTexture temporary5 = RenderTexture.GetTemporary(width4, height4, depthBuffer3, format2, readWrite);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary5);
				result = 2;
			}
			else if (num == 6)
			{
				int width5;
				LuaObject.checkType(l, 1, out width5);
				int height5;
				LuaObject.checkType(l, 2, out height5);
				int depthBuffer4;
				LuaObject.checkType(l, 3, out depthBuffer4);
				RenderTextureFormat format3;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out format3);
				RenderTextureReadWrite readWrite2;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 5, out readWrite2);
				int antiAliasing;
				LuaObject.checkType(l, 6, out antiAliasing);
				RenderTexture temporary6 = RenderTexture.GetTemporary(width5, height5, depthBuffer4, format3, readWrite2, antiAliasing);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary6);
				result = 2;
			}
			else if (num == 7)
			{
				int width6;
				LuaObject.checkType(l, 1, out width6);
				int height6;
				LuaObject.checkType(l, 2, out height6);
				int depthBuffer5;
				LuaObject.checkType(l, 3, out depthBuffer5);
				RenderTextureFormat format4;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out format4);
				RenderTextureReadWrite readWrite3;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 5, out readWrite3);
				int antiAliasing2;
				LuaObject.checkType(l, 6, out antiAliasing2);
				RenderTextureMemoryless memorylessMode;
				LuaObject.checkEnum<RenderTextureMemoryless>(l, 7, out memorylessMode);
				RenderTexture temporary7 = RenderTexture.GetTemporary(width6, height6, depthBuffer5, format4, readWrite3, antiAliasing2, memorylessMode);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary7);
				result = 2;
			}
			else if (num == 8)
			{
				int width7;
				LuaObject.checkType(l, 1, out width7);
				int height7;
				LuaObject.checkType(l, 2, out height7);
				int depthBuffer6;
				LuaObject.checkType(l, 3, out depthBuffer6);
				RenderTextureFormat format5;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out format5);
				RenderTextureReadWrite readWrite4;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 5, out readWrite4);
				int antiAliasing3;
				LuaObject.checkType(l, 6, out antiAliasing3);
				RenderTextureMemoryless memorylessMode2;
				LuaObject.checkEnum<RenderTextureMemoryless>(l, 7, out memorylessMode2);
				VRTextureUsage vrUsage;
				LuaObject.checkEnum<VRTextureUsage>(l, 8, out vrUsage);
				RenderTexture temporary8 = RenderTexture.GetTemporary(width7, height7, depthBuffer6, format5, readWrite4, antiAliasing3, memorylessMode2, vrUsage);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary8);
				result = 2;
			}
			else if (num == 9)
			{
				int width8;
				LuaObject.checkType(l, 1, out width8);
				int height8;
				LuaObject.checkType(l, 2, out height8);
				int depthBuffer7;
				LuaObject.checkType(l, 3, out depthBuffer7);
				RenderTextureFormat format6;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out format6);
				RenderTextureReadWrite readWrite5;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 5, out readWrite5);
				int antiAliasing4;
				LuaObject.checkType(l, 6, out antiAliasing4);
				RenderTextureMemoryless memorylessMode3;
				LuaObject.checkEnum<RenderTextureMemoryless>(l, 7, out memorylessMode3);
				VRTextureUsage vrUsage2;
				LuaObject.checkEnum<VRTextureUsage>(l, 8, out vrUsage2);
				bool useDynamicScale;
				LuaObject.checkType(l, 9, out useDynamicScale);
				RenderTexture temporary9 = RenderTexture.GetTemporary(width8, height8, depthBuffer7, format6, readWrite5, antiAliasing4, memorylessMode3, vrUsage2, useDynamicScale);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, temporary9);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTemporary to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B8D RID: 146317 RVA: 0x00C80D9C File Offset: 0x00C7EF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReleaseTemporary_s(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture temp;
			LuaObject.checkType<RenderTexture>(l, 1, out temp);
			RenderTexture.ReleaseTemporary(temp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B8E RID: 146318 RVA: 0x00C80DE8 File Offset: 0x00C7EFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SupportsStencil_s(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture rt;
			LuaObject.checkType<RenderTexture>(l, 1, out rt);
			bool b = RenderTexture.SupportsStencil(rt);
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

	// Token: 0x06023B8F RID: 146319 RVA: 0x00C80E3C File Offset: 0x00C7F03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_width(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B90 RID: 146320 RVA: 0x00C80E90 File Offset: 0x00C7F090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_width(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			int width;
			LuaObject.checkType(l, 2, out width);
			renderTexture.width = width;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B91 RID: 146321 RVA: 0x00C80EE8 File Offset: 0x00C7F0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B92 RID: 146322 RVA: 0x00C80F3C File Offset: 0x00C7F13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			int height;
			LuaObject.checkType(l, 2, out height);
			renderTexture.height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B93 RID: 146323 RVA: 0x00C80F94 File Offset: 0x00C7F194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vrUsage(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTexture.vrUsage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B94 RID: 146324 RVA: 0x00C80FE8 File Offset: 0x00C7F1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_vrUsage(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			VRTextureUsage vrUsage;
			LuaObject.checkEnum<VRTextureUsage>(l, 2, out vrUsage);
			renderTexture.vrUsage = vrUsage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B95 RID: 146325 RVA: 0x00C81040 File Offset: 0x00C7F240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depth(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.depth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B96 RID: 146326 RVA: 0x00C81094 File Offset: 0x00C7F294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depth(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			int depth;
			LuaObject.checkType(l, 2, out depth);
			renderTexture.depth = depth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B97 RID: 146327 RVA: 0x00C810EC File Offset: 0x00C7F2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isPowerOfTwo(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.isPowerOfTwo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B98 RID: 146328 RVA: 0x00C81140 File Offset: 0x00C7F340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_isPowerOfTwo(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			bool isPowerOfTwo;
			LuaObject.checkType(l, 2, out isPowerOfTwo);
			renderTexture.isPowerOfTwo = isPowerOfTwo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B99 RID: 146329 RVA: 0x00C81198 File Offset: 0x00C7F398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sRGB(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.sRGB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B9A RID: 146330 RVA: 0x00C811EC File Offset: 0x00C7F3EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_format(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTexture.format);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B9B RID: 146331 RVA: 0x00C81240 File Offset: 0x00C7F440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_format(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			RenderTextureFormat format;
			LuaObject.checkEnum<RenderTextureFormat>(l, 2, out format);
			renderTexture.format = format;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B9C RID: 146332 RVA: 0x00C81298 File Offset: 0x00C7F498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useMipMap(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.useMipMap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B9D RID: 146333 RVA: 0x00C812EC File Offset: 0x00C7F4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useMipMap(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			bool useMipMap;
			LuaObject.checkType(l, 2, out useMipMap);
			renderTexture.useMipMap = useMipMap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B9E RID: 146334 RVA: 0x00C81344 File Offset: 0x00C7F544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoGenerateMips(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.autoGenerateMips);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B9F RID: 146335 RVA: 0x00C81398 File Offset: 0x00C7F598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoGenerateMips(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			bool autoGenerateMips;
			LuaObject.checkType(l, 2, out autoGenerateMips);
			renderTexture.autoGenerateMips = autoGenerateMips;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA0 RID: 146336 RVA: 0x00C813F0 File Offset: 0x00C7F5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dimension(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTexture.dimension);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA1 RID: 146337 RVA: 0x00C81444 File Offset: 0x00C7F644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dimension(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			TextureDimension dimension;
			LuaObject.checkEnum<TextureDimension>(l, 2, out dimension);
			renderTexture.dimension = dimension;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA2 RID: 146338 RVA: 0x00C8149C File Offset: 0x00C7F69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_volumeDepth(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.volumeDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA3 RID: 146339 RVA: 0x00C814F0 File Offset: 0x00C7F6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_volumeDepth(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			int volumeDepth;
			LuaObject.checkType(l, 2, out volumeDepth);
			renderTexture.volumeDepth = volumeDepth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA4 RID: 146340 RVA: 0x00C81548 File Offset: 0x00C7F748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_memorylessMode(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTexture.memorylessMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA5 RID: 146341 RVA: 0x00C8159C File Offset: 0x00C7F79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_memorylessMode(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			RenderTextureMemoryless memorylessMode;
			LuaObject.checkEnum<RenderTextureMemoryless>(l, 2, out memorylessMode);
			renderTexture.memorylessMode = memorylessMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA6 RID: 146342 RVA: 0x00C815F4 File Offset: 0x00C7F7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_antiAliasing(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.antiAliasing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA7 RID: 146343 RVA: 0x00C81648 File Offset: 0x00C7F848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_antiAliasing(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			int antiAliasing;
			LuaObject.checkType(l, 2, out antiAliasing);
			renderTexture.antiAliasing = antiAliasing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA8 RID: 146344 RVA: 0x00C816A0 File Offset: 0x00C7F8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bindTextureMS(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.bindTextureMS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BA9 RID: 146345 RVA: 0x00C816F4 File Offset: 0x00C7F8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bindTextureMS(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			bool bindTextureMS;
			LuaObject.checkType(l, 2, out bindTextureMS);
			renderTexture.bindTextureMS = bindTextureMS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BAA RID: 146346 RVA: 0x00C8174C File Offset: 0x00C7F94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enableRandomWrite(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.enableRandomWrite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BAB RID: 146347 RVA: 0x00C817A0 File Offset: 0x00C7F9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enableRandomWrite(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			bool enableRandomWrite;
			LuaObject.checkType(l, 2, out enableRandomWrite);
			renderTexture.enableRandomWrite = enableRandomWrite;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BAC RID: 146348 RVA: 0x00C817F8 File Offset: 0x00C7F9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useDynamicScale(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.useDynamicScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BAD RID: 146349 RVA: 0x00C8184C File Offset: 0x00C7FA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useDynamicScale(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			bool useDynamicScale;
			LuaObject.checkType(l, 2, out useDynamicScale);
			renderTexture.useDynamicScale = useDynamicScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BAE RID: 146350 RVA: 0x00C818A4 File Offset: 0x00C7FAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colorBuffer(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.colorBuffer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BAF RID: 146351 RVA: 0x00C818FC File Offset: 0x00C7FAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depthBuffer(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.depthBuffer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BB0 RID: 146352 RVA: 0x00C81954 File Offset: 0x00C7FB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_active(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderTexture.active);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BB1 RID: 146353 RVA: 0x00C8199C File Offset: 0x00C7FB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_active(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture active;
			LuaObject.checkType<RenderTexture>(l, 2, out active);
			RenderTexture.active = active;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BB2 RID: 146354 RVA: 0x00C819E8 File Offset: 0x00C7FBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_descriptor(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTexture.descriptor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BB3 RID: 146355 RVA: 0x00C81A40 File Offset: 0x00C7FC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_descriptor(IntPtr l)
	{
		int result;
		try
		{
			RenderTexture renderTexture = (RenderTexture)LuaObject.checkSelf(l);
			RenderTextureDescriptor descriptor;
			LuaObject.checkValueType<RenderTextureDescriptor>(l, 2, out descriptor);
			renderTexture.descriptor = descriptor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BB4 RID: 146356 RVA: 0x00C81A98 File Offset: 0x00C7FC98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RenderTexture");
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.ResolveAntiAliasedSurface);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache0);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.Create);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache1);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.Release);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache2);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.IsCreated);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache3);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.DiscardContents);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache4);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.MarkRestoreExpected);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache5);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.GenerateMips);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache6);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.GetNativeDepthBufferPtr);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache7);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.SetGlobalShaderProperty);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache8);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.GetTemporary_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache9);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RenderTexture.ReleaseTemporary_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cacheA);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RenderTexture.SupportsStencil_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderTexture.<>f__mg$cacheB);
		string name = "width";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_width);
		}
		LuaCSFunction get = Lua_UnityEngine_RenderTexture.<>f__mg$cacheC;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_width);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RenderTexture.<>f__mg$cacheD, true);
		string name2 = "height";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_height);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RenderTexture.<>f__mg$cacheE;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_height);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RenderTexture.<>f__mg$cacheF, true);
		string name3 = "vrUsage";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_vrUsage);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RenderTexture.<>f__mg$cache10;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_vrUsage);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_RenderTexture.<>f__mg$cache11, true);
		string name4 = "depth";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_depth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RenderTexture.<>f__mg$cache12;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_depth);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_RenderTexture.<>f__mg$cache13, true);
		string name5 = "isPowerOfTwo";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_isPowerOfTwo);
		}
		LuaCSFunction get5 = Lua_UnityEngine_RenderTexture.<>f__mg$cache14;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_isPowerOfTwo);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_RenderTexture.<>f__mg$cache15, true);
		string name6 = "sRGB";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_sRGB);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_RenderTexture.<>f__mg$cache16, null, true);
		string name7 = "format";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_format);
		}
		LuaCSFunction get6 = Lua_UnityEngine_RenderTexture.<>f__mg$cache17;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_format);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_RenderTexture.<>f__mg$cache18, true);
		string name8 = "useMipMap";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_useMipMap);
		}
		LuaCSFunction get7 = Lua_UnityEngine_RenderTexture.<>f__mg$cache19;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_useMipMap);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_RenderTexture.<>f__mg$cache1A, true);
		string name9 = "autoGenerateMips";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_autoGenerateMips);
		}
		LuaCSFunction get8 = Lua_UnityEngine_RenderTexture.<>f__mg$cache1B;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_autoGenerateMips);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_RenderTexture.<>f__mg$cache1C, true);
		string name10 = "dimension";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_dimension);
		}
		LuaCSFunction get9 = Lua_UnityEngine_RenderTexture.<>f__mg$cache1D;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_dimension);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_RenderTexture.<>f__mg$cache1E, true);
		string name11 = "volumeDepth";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_volumeDepth);
		}
		LuaCSFunction get10 = Lua_UnityEngine_RenderTexture.<>f__mg$cache1F;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_volumeDepth);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_RenderTexture.<>f__mg$cache20, true);
		string name12 = "memorylessMode";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_memorylessMode);
		}
		LuaCSFunction get11 = Lua_UnityEngine_RenderTexture.<>f__mg$cache21;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_memorylessMode);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_RenderTexture.<>f__mg$cache22, true);
		string name13 = "antiAliasing";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_antiAliasing);
		}
		LuaCSFunction get12 = Lua_UnityEngine_RenderTexture.<>f__mg$cache23;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_antiAliasing);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_RenderTexture.<>f__mg$cache24, true);
		string name14 = "bindTextureMS";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_bindTextureMS);
		}
		LuaCSFunction get13 = Lua_UnityEngine_RenderTexture.<>f__mg$cache25;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_bindTextureMS);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_RenderTexture.<>f__mg$cache26, true);
		string name15 = "enableRandomWrite";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_enableRandomWrite);
		}
		LuaCSFunction get14 = Lua_UnityEngine_RenderTexture.<>f__mg$cache27;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_enableRandomWrite);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_RenderTexture.<>f__mg$cache28, true);
		string name16 = "useDynamicScale";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_useDynamicScale);
		}
		LuaCSFunction get15 = Lua_UnityEngine_RenderTexture.<>f__mg$cache29;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_useDynamicScale);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_RenderTexture.<>f__mg$cache2A, true);
		string name17 = "colorBuffer";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_colorBuffer);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_RenderTexture.<>f__mg$cache2B, null, true);
		string name18 = "depthBuffer";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_depthBuffer);
		}
		LuaObject.addMember(l, name18, Lua_UnityEngine_RenderTexture.<>f__mg$cache2C, null, true);
		string name19 = "active";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_active);
		}
		LuaCSFunction get16 = Lua_UnityEngine_RenderTexture.<>f__mg$cache2D;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_active);
		}
		LuaObject.addMember(l, name19, get16, Lua_UnityEngine_RenderTexture.<>f__mg$cache2E, false);
		string name20 = "descriptor";
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_RenderTexture.get_descriptor);
		}
		LuaCSFunction get17 = Lua_UnityEngine_RenderTexture.<>f__mg$cache2F;
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.set_descriptor);
		}
		LuaObject.addMember(l, name20, get17, Lua_UnityEngine_RenderTexture.<>f__mg$cache30, true);
		if (Lua_UnityEngine_RenderTexture.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_RenderTexture.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_RenderTexture.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RenderTexture.<>f__mg$cache31, typeof(RenderTexture), typeof(Texture));
	}

	// Token: 0x04019886 RID: 104582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019887 RID: 104583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019888 RID: 104584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019889 RID: 104585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401988A RID: 104586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401988B RID: 104587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401988C RID: 104588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401988D RID: 104589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401988E RID: 104590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401988F RID: 104591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019890 RID: 104592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019891 RID: 104593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019892 RID: 104594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019893 RID: 104595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019894 RID: 104596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019895 RID: 104597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019896 RID: 104598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019897 RID: 104599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019898 RID: 104600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019899 RID: 104601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401989A RID: 104602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401989B RID: 104603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401989C RID: 104604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401989D RID: 104605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401989E RID: 104606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401989F RID: 104607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040198A0 RID: 104608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040198A1 RID: 104609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040198A2 RID: 104610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040198A3 RID: 104611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040198A4 RID: 104612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040198A5 RID: 104613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040198A6 RID: 104614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040198A7 RID: 104615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040198A8 RID: 104616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040198A9 RID: 104617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040198AA RID: 104618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040198AB RID: 104619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040198AC RID: 104620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040198AD RID: 104621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040198AE RID: 104622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040198AF RID: 104623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040198B0 RID: 104624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040198B1 RID: 104625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040198B2 RID: 104626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040198B3 RID: 104627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040198B4 RID: 104628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040198B5 RID: 104629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040198B6 RID: 104630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040198B7 RID: 104631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;
}
