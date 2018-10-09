using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x0200169D RID: 5789
[Preserve]
public class Lua_UnityEngine_EventSystems_BaseEventData : LuaObject
{
	// Token: 0x060230FB RID: 143611 RVA: 0x00C24D4C File Offset: 0x00C22F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem;
			LuaObject.checkType<EventSystem>(l, 2, out eventSystem);
			BaseEventData o = new BaseEventData(eventSystem);
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

	// Token: 0x060230FC RID: 143612 RVA: 0x00C24DA0 File Offset: 0x00C22FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_currentInputModule(IntPtr l)
	{
		int result;
		try
		{
			BaseEventData baseEventData = (BaseEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseEventData.currentInputModule);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230FD RID: 143613 RVA: 0x00C24DF4 File Offset: 0x00C22FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectedObject(IntPtr l)
	{
		int result;
		try
		{
			BaseEventData baseEventData = (BaseEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseEventData.selectedObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230FE RID: 143614 RVA: 0x00C24E48 File Offset: 0x00C23048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_selectedObject(IntPtr l)
	{
		int result;
		try
		{
			BaseEventData baseEventData = (BaseEventData)LuaObject.checkSelf(l);
			GameObject selectedObject;
			LuaObject.checkType<GameObject>(l, 2, out selectedObject);
			baseEventData.selectedObject = selectedObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230FF RID: 143615 RVA: 0x00C24EA0 File Offset: 0x00C230A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.BaseEventData");
		string name = "currentInputModule";
		if (Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseEventData.get_currentInputModule);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache0, null, true);
		string name2 = "selectedObject";
		if (Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseEventData.get_selectedObject);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache1;
		if (Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseEventData.set_selectedObject);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache2, true);
		if (Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseEventData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache3, typeof(BaseEventData), typeof(AbstractEventData));
	}

	// Token: 0x0401901F RID: 102431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019020 RID: 102432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019021 RID: 102433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019022 RID: 102434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
