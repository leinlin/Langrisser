using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016A4 RID: 5796
[Preserve]
public class Lua_UnityEngine_EventSystems_EventTrigger_Entry : LuaObject
{
	// Token: 0x0602314C RID: 143692 RVA: 0x00C27000 File Offset: 0x00C25200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger.Entry o = new EventTrigger.Entry();
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

	// Token: 0x0602314D RID: 143693 RVA: 0x00C27048 File Offset: 0x00C25248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eventID(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger.Entry entry = (EventTrigger.Entry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)entry.eventID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602314E RID: 143694 RVA: 0x00C2709C File Offset: 0x00C2529C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_eventID(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger.Entry entry = (EventTrigger.Entry)LuaObject.checkSelf(l);
			EventTriggerType eventID;
			LuaObject.checkEnum<EventTriggerType>(l, 2, out eventID);
			entry.eventID = eventID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602314F RID: 143695 RVA: 0x00C270F4 File Offset: 0x00C252F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_callback(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger.Entry entry = (EventTrigger.Entry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, entry.callback);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023150 RID: 143696 RVA: 0x00C27148 File Offset: 0x00C25348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_callback(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger.Entry entry = (EventTrigger.Entry)LuaObject.checkSelf(l);
			EventTrigger.TriggerEvent callback;
			LuaObject.checkType<EventTrigger.TriggerEvent>(l, 2, out callback);
			entry.callback = callback;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023151 RID: 143697 RVA: 0x00C271A0 File Offset: 0x00C253A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.EventTrigger.Entry");
		string name = "eventID";
		if (Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger_Entry.get_eventID);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache0;
		if (Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger_Entry.set_eventID);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache1, true);
		string name2 = "callback";
		if (Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger_Entry.get_callback);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache2;
		if (Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger_Entry.set_callback);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache3, true);
		if (Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger_Entry.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_EventSystems_EventTrigger_Entry.<>f__mg$cache4, typeof(EventTrigger.Entry));
	}

	// Token: 0x04019062 RID: 102498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019063 RID: 102499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019064 RID: 102500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019065 RID: 102501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019066 RID: 102502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
