using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016AA RID: 5802
[Preserve]
public class Lua_UnityEngine_EventSystems_IDeselectHandler : LuaObject
{
	// Token: 0x06023164 RID: 143716 RVA: 0x00C277C0 File Offset: 0x00C259C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeselect(IntPtr l)
	{
		int result;
		try
		{
			IDeselectHandler deselectHandler = (IDeselectHandler)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			deselectHandler.OnDeselect(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023165 RID: 143717 RVA: 0x00C27818 File Offset: 0x00C25A18
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IDeselectHandler");
		if (Lua_UnityEngine_EventSystems_IDeselectHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IDeselectHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IDeselectHandler.OnDeselect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IDeselectHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IDeselectHandler));
	}

	// Token: 0x0401906E RID: 102510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
