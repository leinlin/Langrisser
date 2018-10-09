using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016A5 RID: 5797
[Preserve]
public class Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent : LuaObject
{
	// Token: 0x06023153 RID: 143699 RVA: 0x00C2727C File Offset: 0x00C2547C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger.TriggerEvent o = new EventTrigger.TriggerEvent();
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

	// Token: 0x06023154 RID: 143700 RVA: 0x00C272C4 File Offset: 0x00C254C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.EventTrigger.TriggerEvent");
		if (Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent.<>f__mg$cache0, typeof(EventTrigger.TriggerEvent), typeof(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData));
	}

	// Token: 0x04019067 RID: 102503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
