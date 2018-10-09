using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200171D RID: 5917
[Preserve]
public class Lua_UnityEngine_LOD : LuaObject
{
	// Token: 0x06023534 RID: 144692 RVA: 0x00C4501C File Offset: 0x00C4321C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			float screenRelativeTransitionHeight;
			LuaObject.checkType(l, 2, out screenRelativeTransitionHeight);
			Renderer[] renderers;
			LuaObject.checkArray<Renderer>(l, 3, out renderers);
			LOD lod = new LOD(screenRelativeTransitionHeight, renderers);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lod);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023535 RID: 144693 RVA: 0x00C45084 File Offset: 0x00C43284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_screenRelativeTransitionHeight(IntPtr l)
	{
		int result;
		try
		{
			LOD lod;
			LuaObject.checkValueType<LOD>(l, 1, out lod);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lod.screenRelativeTransitionHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023536 RID: 144694 RVA: 0x00C450D8 File Offset: 0x00C432D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_screenRelativeTransitionHeight(IntPtr l)
	{
		int result;
		try
		{
			LOD lod;
			LuaObject.checkValueType<LOD>(l, 1, out lod);
			float screenRelativeTransitionHeight;
			LuaObject.checkType(l, 2, out screenRelativeTransitionHeight);
			lod.screenRelativeTransitionHeight = screenRelativeTransitionHeight;
			LuaObject.setBack(l, lod);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023537 RID: 144695 RVA: 0x00C4513C File Offset: 0x00C4333C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_fadeTransitionWidth(IntPtr l)
	{
		int result;
		try
		{
			LOD lod;
			LuaObject.checkValueType<LOD>(l, 1, out lod);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lod.fadeTransitionWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023538 RID: 144696 RVA: 0x00C45190 File Offset: 0x00C43390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_fadeTransitionWidth(IntPtr l)
	{
		int result;
		try
		{
			LOD lod;
			LuaObject.checkValueType<LOD>(l, 1, out lod);
			float fadeTransitionWidth;
			LuaObject.checkType(l, 2, out fadeTransitionWidth);
			lod.fadeTransitionWidth = fadeTransitionWidth;
			LuaObject.setBack(l, lod);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023539 RID: 144697 RVA: 0x00C451F4 File Offset: 0x00C433F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_renderers(IntPtr l)
	{
		int result;
		try
		{
			LOD lod;
			LuaObject.checkValueType<LOD>(l, 1, out lod);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lod.renderers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602353A RID: 144698 RVA: 0x00C45248 File Offset: 0x00C43448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_renderers(IntPtr l)
	{
		int result;
		try
		{
			LOD lod;
			LuaObject.checkValueType<LOD>(l, 1, out lod);
			Renderer[] renderers;
			LuaObject.checkArray<Renderer>(l, 2, out renderers);
			lod.renderers = renderers;
			LuaObject.setBack(l, lod);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602353B RID: 144699 RVA: 0x00C452AC File Offset: 0x00C434AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LOD");
		string name = "screenRelativeTransitionHeight";
		if (Lua_UnityEngine_LOD.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LOD.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LOD.get_screenRelativeTransitionHeight);
		}
		LuaCSFunction get = Lua_UnityEngine_LOD.<>f__mg$cache0;
		if (Lua_UnityEngine_LOD.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LOD.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LOD.set_screenRelativeTransitionHeight);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LOD.<>f__mg$cache1, true);
		string name2 = "fadeTransitionWidth";
		if (Lua_UnityEngine_LOD.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LOD.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LOD.get_fadeTransitionWidth);
		}
		LuaCSFunction get2 = Lua_UnityEngine_LOD.<>f__mg$cache2;
		if (Lua_UnityEngine_LOD.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LOD.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LOD.set_fadeTransitionWidth);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_LOD.<>f__mg$cache3, true);
		string name3 = "renderers";
		if (Lua_UnityEngine_LOD.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LOD.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LOD.get_renderers);
		}
		LuaCSFunction get3 = Lua_UnityEngine_LOD.<>f__mg$cache4;
		if (Lua_UnityEngine_LOD.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LOD.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LOD.set_renderers);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_LOD.<>f__mg$cache5, true);
		if (Lua_UnityEngine_LOD.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LOD.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LOD.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LOD.<>f__mg$cache6, typeof(LOD), typeof(ValueType));
	}

	// Token: 0x04019358 RID: 103256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019359 RID: 103257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401935A RID: 103258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401935B RID: 103259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401935C RID: 103260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401935D RID: 103261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401935E RID: 103262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
