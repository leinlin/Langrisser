using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016A9 RID: 5801
[Preserve]
public class Lua_UnityEngine_EventSystems_ICancelHandler : LuaObject
{
	// Token: 0x06023161 RID: 143713 RVA: 0x00C27714 File Offset: 0x00C25914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancel(IntPtr l)
	{
		int result;
		try
		{
			ICancelHandler cancelHandler = (ICancelHandler)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			cancelHandler.OnCancel(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023162 RID: 143714 RVA: 0x00C2776C File Offset: 0x00C2596C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.ICancelHandler");
		if (Lua_UnityEngine_EventSystems_ICancelHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_ICancelHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_ICancelHandler.OnCancel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_ICancelHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(ICancelHandler));
	}

	// Token: 0x0401906D RID: 102509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
