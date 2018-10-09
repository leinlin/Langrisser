using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B9 RID: 5817
[Preserve]
public class Lua_UnityEngine_EventSystems_IUpdateSelectedHandler : LuaObject
{
	// Token: 0x06023190 RID: 143760 RVA: 0x00C28150 File Offset: 0x00C26350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUpdateSelected(IntPtr l)
	{
		int result;
		try
		{
			IUpdateSelectedHandler updateSelectedHandler = (IUpdateSelectedHandler)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			updateSelectedHandler.OnUpdateSelected(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023191 RID: 143761 RVA: 0x00C281A8 File Offset: 0x00C263A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IUpdateSelectedHandler");
		if (Lua_UnityEngine_EventSystems_IUpdateSelectedHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IUpdateSelectedHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IUpdateSelectedHandler.OnUpdateSelected);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IUpdateSelectedHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IUpdateSelectedHandler));
	}

	// Token: 0x0401907C RID: 102524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
