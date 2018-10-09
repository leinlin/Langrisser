using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020017AC RID: 6060
[Preserve]
public class Lua_UnityEngine_RenderTargetSetup : LuaObject
{
	// Token: 0x06023B6D RID: 146285 RVA: 0x00C7F718 File Offset: 0x00C7D918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 9)
			{
				RenderBuffer[] color;
				LuaObject.checkArray<RenderBuffer>(l, 2, out color);
				RenderBuffer depth;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depth);
				int mip;
				LuaObject.checkType(l, 4, out mip);
				CubemapFace face;
				LuaObject.checkEnum<CubemapFace>(l, 5, out face);
				RenderBufferLoadAction[] colorLoad;
				LuaObject.checkArray<RenderBufferLoadAction>(l, 6, out colorLoad);
				RenderBufferStoreAction[] colorStore;
				LuaObject.checkArray<RenderBufferStoreAction>(l, 7, out colorStore);
				RenderBufferLoadAction depthLoad;
				LuaObject.checkEnum<RenderBufferLoadAction>(l, 8, out depthLoad);
				RenderBufferStoreAction depthStore;
				LuaObject.checkEnum<RenderBufferStoreAction>(l, 9, out depthStore);
				RenderTargetSetup renderTargetSetup = new RenderTargetSetup(color, depth, mip, face, colorLoad, colorStore, depthLoad, depthStore);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetSetup);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderBuffer), typeof(RenderBuffer)))
			{
				RenderBuffer color2;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out color2);
				RenderBuffer depth2;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depth2);
				RenderTargetSetup renderTargetSetup = new RenderTargetSetup(color2, depth2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetSetup);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderBuffer), typeof(RenderBuffer), typeof(int)))
			{
				RenderBuffer color3;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out color3);
				RenderBuffer depth3;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depth3);
				int mipLevel;
				LuaObject.checkType(l, 4, out mipLevel);
				RenderTargetSetup renderTargetSetup = new RenderTargetSetup(color3, depth3, mipLevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetSetup);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderBuffer), typeof(RenderBuffer), typeof(int), typeof(CubemapFace)))
			{
				RenderBuffer color4;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out color4);
				RenderBuffer depth4;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depth4);
				int mipLevel2;
				LuaObject.checkType(l, 4, out mipLevel2);
				CubemapFace face2;
				LuaObject.checkEnum<CubemapFace>(l, 5, out face2);
				RenderTargetSetup renderTargetSetup = new RenderTargetSetup(color4, depth4, mipLevel2, face2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetSetup);
				result = 2;
			}
			else if (num == 6)
			{
				RenderBuffer color5;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out color5);
				RenderBuffer depth5;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depth5);
				int mipLevel3;
				LuaObject.checkType(l, 4, out mipLevel3);
				CubemapFace face3;
				LuaObject.checkEnum<CubemapFace>(l, 5, out face3);
				int depthSlice;
				LuaObject.checkType(l, 6, out depthSlice);
				RenderTargetSetup renderTargetSetup = new RenderTargetSetup(color5, depth5, mipLevel3, face3, depthSlice);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetSetup);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderBuffer[]), typeof(RenderBuffer)))
			{
				RenderBuffer[] color6;
				LuaObject.checkArray<RenderBuffer>(l, 2, out color6);
				RenderBuffer depth6;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depth6);
				RenderTargetSetup renderTargetSetup = new RenderTargetSetup(color6, depth6);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetSetup);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderBuffer[]), typeof(RenderBuffer), typeof(int)))
			{
				RenderBuffer[] color7;
				LuaObject.checkArray<RenderBuffer>(l, 2, out color7);
				RenderBuffer depth7;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depth7);
				int mipLevel4;
				LuaObject.checkType(l, 4, out mipLevel4);
				RenderTargetSetup renderTargetSetup = new RenderTargetSetup(color7, depth7, mipLevel4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetSetup);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderBuffer[]), typeof(RenderBuffer), typeof(int), typeof(CubemapFace)))
			{
				RenderBuffer[] color8;
				LuaObject.checkArray<RenderBuffer>(l, 2, out color8);
				RenderBuffer depth8;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depth8);
				int mip2;
				LuaObject.checkType(l, 4, out mip2);
				CubemapFace face4;
				LuaObject.checkEnum<CubemapFace>(l, 5, out face4);
				RenderTargetSetup renderTargetSetup = new RenderTargetSetup(color8, depth8, mip2, face4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetSetup);
				result = 2;
			}
			else if (num == 0)
			{
				RenderTargetSetup renderTargetSetup = default(RenderTargetSetup);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, renderTargetSetup);
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

	// Token: 0x06023B6E RID: 146286 RVA: 0x00C7FB2C File Offset: 0x00C7DD2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTargetSetup.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B6F RID: 146287 RVA: 0x00C7FB80 File Offset: 0x00C7DD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			RenderBuffer[] color;
			LuaObject.checkArray<RenderBuffer>(l, 2, out color);
			renderTargetSetup.color = color;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B70 RID: 146288 RVA: 0x00C7FBE4 File Offset: 0x00C7DDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depth(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTargetSetup.depth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B71 RID: 146289 RVA: 0x00C7FC3C File Offset: 0x00C7DE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depth(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			RenderBuffer depth;
			LuaObject.checkValueType<RenderBuffer>(l, 2, out depth);
			renderTargetSetup.depth = depth;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B72 RID: 146290 RVA: 0x00C7FCA0 File Offset: 0x00C7DEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mipLevel(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTargetSetup.mipLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B73 RID: 146291 RVA: 0x00C7FCF4 File Offset: 0x00C7DEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mipLevel(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			int mipLevel;
			LuaObject.checkType(l, 2, out mipLevel);
			renderTargetSetup.mipLevel = mipLevel;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B74 RID: 146292 RVA: 0x00C7FD58 File Offset: 0x00C7DF58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_cubemapFace(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTargetSetup.cubemapFace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B75 RID: 146293 RVA: 0x00C7FDAC File Offset: 0x00C7DFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cubemapFace(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			CubemapFace cubemapFace;
			LuaObject.checkEnum<CubemapFace>(l, 2, out cubemapFace);
			renderTargetSetup.cubemapFace = cubemapFace;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B76 RID: 146294 RVA: 0x00C7FE10 File Offset: 0x00C7E010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_depthSlice(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTargetSetup.depthSlice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B77 RID: 146295 RVA: 0x00C7FE64 File Offset: 0x00C7E064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depthSlice(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			int depthSlice;
			LuaObject.checkType(l, 2, out depthSlice);
			renderTargetSetup.depthSlice = depthSlice;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B78 RID: 146296 RVA: 0x00C7FEC8 File Offset: 0x00C7E0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colorLoad(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTargetSetup.colorLoad);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B79 RID: 146297 RVA: 0x00C7FF1C File Offset: 0x00C7E11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colorLoad(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			RenderBufferLoadAction[] colorLoad;
			LuaObject.checkArray<RenderBufferLoadAction>(l, 2, out colorLoad);
			renderTargetSetup.colorLoad = colorLoad;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B7A RID: 146298 RVA: 0x00C7FF80 File Offset: 0x00C7E180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colorStore(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderTargetSetup.colorStore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B7B RID: 146299 RVA: 0x00C7FFD4 File Offset: 0x00C7E1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colorStore(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			RenderBufferStoreAction[] colorStore;
			LuaObject.checkArray<RenderBufferStoreAction>(l, 2, out colorStore);
			renderTargetSetup.colorStore = colorStore;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B7C RID: 146300 RVA: 0x00C80038 File Offset: 0x00C7E238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_depthLoad(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTargetSetup.depthLoad);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B7D RID: 146301 RVA: 0x00C8008C File Offset: 0x00C7E28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depthLoad(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			RenderBufferLoadAction depthLoad;
			LuaObject.checkEnum<RenderBufferLoadAction>(l, 2, out depthLoad);
			renderTargetSetup.depthLoad = depthLoad;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B7E RID: 146302 RVA: 0x00C800F0 File Offset: 0x00C7E2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depthStore(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)renderTargetSetup.depthStore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B7F RID: 146303 RVA: 0x00C80144 File Offset: 0x00C7E344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depthStore(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetSetup renderTargetSetup;
			LuaObject.checkValueType<RenderTargetSetup>(l, 1, out renderTargetSetup);
			RenderBufferStoreAction depthStore;
			LuaObject.checkEnum<RenderBufferStoreAction>(l, 2, out depthStore);
			renderTargetSetup.depthStore = depthStore;
			LuaObject.setBack(l, renderTargetSetup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B80 RID: 146304 RVA: 0x00C801A8 File Offset: 0x00C7E3A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RenderTargetSetup");
		string name = "color";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_color);
		}
		LuaCSFunction get = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache0;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_color);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache1, true);
		string name2 = "depth";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_depth);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache2;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_depth);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache3, true);
		string name3 = "mipLevel";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_mipLevel);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache4;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_mipLevel);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache5, true);
		string name4 = "cubemapFace";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_cubemapFace);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache6;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_cubemapFace);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache7, true);
		string name5 = "depthSlice";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_depthSlice);
		}
		LuaCSFunction get5 = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache8;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_depthSlice);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache9, true);
		string name6 = "colorLoad";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_colorLoad);
		}
		LuaCSFunction get6 = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheA;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_colorLoad);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheB, true);
		string name7 = "colorStore";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_colorStore);
		}
		LuaCSFunction get7 = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheC;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_colorStore);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheD, true);
		string name8 = "depthLoad";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_depthLoad);
		}
		LuaCSFunction get8 = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheE;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_depthLoad);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cacheF, true);
		string name9 = "depthStore";
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.get_depthStore);
		}
		LuaCSFunction get9 = Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache10;
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.set_depthStore);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache11, true);
		if (Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_RenderTargetSetup.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RenderTargetSetup.<>f__mg$cache12, typeof(RenderTargetSetup), typeof(ValueType));
	}

	// Token: 0x04019873 RID: 104563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019874 RID: 104564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019875 RID: 104565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019876 RID: 104566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019877 RID: 104567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019878 RID: 104568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019879 RID: 104569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401987A RID: 104570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401987B RID: 104571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401987C RID: 104572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401987D RID: 104573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401987E RID: 104574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401987F RID: 104575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019880 RID: 104576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019881 RID: 104577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019882 RID: 104578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019883 RID: 104579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019884 RID: 104580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019885 RID: 104581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
