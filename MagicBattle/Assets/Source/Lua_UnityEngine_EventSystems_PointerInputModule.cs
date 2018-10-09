using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016C0 RID: 5824
[Preserve]
public class Lua_UnityEngine_EventSystems_PointerInputModule : LuaObject
{
	// Token: 0x060231D2 RID: 143826 RVA: 0x00C29C00 File Offset: 0x00C27E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPointerOverGameObject(IntPtr l)
	{
		int result;
		try
		{
			PointerInputModule pointerInputModule = (PointerInputModule)LuaObject.checkSelf(l);
			int pointerId;
			LuaObject.checkType(l, 2, out pointerId);
			bool b = pointerInputModule.IsPointerOverGameObject(pointerId);
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

	// Token: 0x060231D3 RID: 143827 RVA: 0x00C29C64 File Offset: 0x00C27E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_kMouseLeftId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231D4 RID: 143828 RVA: 0x00C29CA8 File Offset: 0x00C27EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_kMouseRightId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231D5 RID: 143829 RVA: 0x00C29CEC File Offset: 0x00C27EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_kMouseMiddleId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231D6 RID: 143830 RVA: 0x00C29D30 File Offset: 0x00C27F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_kFakeTouchesId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231D7 RID: 143831 RVA: 0x00C29D74 File Offset: 0x00C27F74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.PointerInputModule");
		if (Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule.IsPointerOverGameObject);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache0);
		string name = "kMouseLeftId";
		if (Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule.get_kMouseLeftId);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache1, null, false);
		string name2 = "kMouseRightId";
		if (Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule.get_kMouseRightId);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache2, null, false);
		string name3 = "kMouseMiddleId";
		if (Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule.get_kMouseMiddleId);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache3, null, false);
		string name4 = "kFakeTouchesId";
		if (Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule.get_kFakeTouchesId);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_EventSystems_PointerInputModule.<>f__mg$cache4, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(PointerInputModule), typeof(BaseInputModule));
	}

	// Token: 0x040190B0 RID: 102576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040190B1 RID: 102577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040190B2 RID: 102578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040190B3 RID: 102579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040190B4 RID: 102580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
