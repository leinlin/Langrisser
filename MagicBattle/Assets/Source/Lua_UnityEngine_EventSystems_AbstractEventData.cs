using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x0200169B RID: 5787
[Preserve]
public class Lua_UnityEngine_EventSystems_AbstractEventData : LuaObject
{
	// Token: 0x060230EF RID: 143599 RVA: 0x00C2492C File Offset: 0x00C22B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Reset(IntPtr l)
	{
		int result;
		try
		{
			AbstractEventData abstractEventData = (AbstractEventData)LuaObject.checkSelf(l);
			abstractEventData.Reset();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230F0 RID: 143600 RVA: 0x00C24978 File Offset: 0x00C22B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Use(IntPtr l)
	{
		int result;
		try
		{
			AbstractEventData abstractEventData = (AbstractEventData)LuaObject.checkSelf(l);
			abstractEventData.Use();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230F1 RID: 143601 RVA: 0x00C249C4 File Offset: 0x00C22BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_used(IntPtr l)
	{
		int result;
		try
		{
			AbstractEventData abstractEventData = (AbstractEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, abstractEventData.used);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230F2 RID: 143602 RVA: 0x00C24A18 File Offset: 0x00C22C18
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.AbstractEventData");
		if (Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_AbstractEventData.Reset);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_AbstractEventData.Use);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache1);
		string name = "used";
		if (Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_AbstractEventData.get_used);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_EventSystems_AbstractEventData.<>f__mg$cache2, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(AbstractEventData));
	}

	// Token: 0x04019017 RID: 102423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019018 RID: 102424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019019 RID: 102425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
