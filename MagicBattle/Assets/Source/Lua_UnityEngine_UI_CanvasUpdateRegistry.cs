using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001814 RID: 6164
[Preserve]
public class Lua_UnityEngine_UI_CanvasUpdateRegistry : LuaObject
{
	// Token: 0x06023FB8 RID: 147384 RVA: 0x00CA0E84 File Offset: 0x00C9F084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterCanvasElementForLayoutRebuild_s(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement element;
			LuaObject.checkType<ICanvasElement>(l, 1, out element);
			CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(element);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FB9 RID: 147385 RVA: 0x00CA0ED0 File Offset: 0x00C9F0D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TryRegisterCanvasElementForLayoutRebuild_s(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement element;
			LuaObject.checkType<ICanvasElement>(l, 1, out element);
			bool b = CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild(element);
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

	// Token: 0x06023FBA RID: 147386 RVA: 0x00CA0F24 File Offset: 0x00C9F124
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterCanvasElementForGraphicRebuild_s(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement element;
			LuaObject.checkType<ICanvasElement>(l, 1, out element);
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(element);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FBB RID: 147387 RVA: 0x00CA0F70 File Offset: 0x00C9F170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryRegisterCanvasElementForGraphicRebuild_s(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement element;
			LuaObject.checkType<ICanvasElement>(l, 1, out element);
			bool b = CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild(element);
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

	// Token: 0x06023FBC RID: 147388 RVA: 0x00CA0FC4 File Offset: 0x00C9F1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnRegisterCanvasElementForRebuild_s(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement element;
			LuaObject.checkType<ICanvasElement>(l, 1, out element);
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(element);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FBD RID: 147389 RVA: 0x00CA1010 File Offset: 0x00C9F210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRebuildingLayout_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = CanvasUpdateRegistry.IsRebuildingLayout();
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

	// Token: 0x06023FBE RID: 147390 RVA: 0x00CA1058 File Offset: 0x00C9F258
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRebuildingGraphics_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = CanvasUpdateRegistry.IsRebuildingGraphics();
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

	// Token: 0x06023FBF RID: 147391 RVA: 0x00CA10A0 File Offset: 0x00C9F2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CanvasUpdateRegistry.instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FC0 RID: 147392 RVA: 0x00CA10E8 File Offset: 0x00C9F2E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.CanvasUpdateRegistry");
		if (Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasUpdateRegistry.IsRebuildingLayout_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasUpdateRegistry.IsRebuildingGraphics_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache6);
		string name = "instance";
		if (Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasUpdateRegistry.get_instance);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_CanvasUpdateRegistry.<>f__mg$cache7, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(CanvasUpdateRegistry));
	}

	// Token: 0x04019BEE RID: 105454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019BEF RID: 105455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019BF0 RID: 105456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019BF1 RID: 105457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019BF2 RID: 105458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019BF3 RID: 105459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019BF4 RID: 105460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019BF5 RID: 105461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
