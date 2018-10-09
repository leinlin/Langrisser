using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B7 RID: 5815
[Preserve]
public class Lua_UnityEngine_EventSystems_ISelectHandler : LuaObject
{
	// Token: 0x0602318A RID: 143754 RVA: 0x00C27FF8 File Offset: 0x00C261F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelect(IntPtr l)
	{
		int result;
		try
		{
			ISelectHandler selectHandler = (ISelectHandler)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			selectHandler.OnSelect(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602318B RID: 143755 RVA: 0x00C28050 File Offset: 0x00C26250
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.ISelectHandler");
		if (Lua_UnityEngine_EventSystems_ISelectHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_ISelectHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_ISelectHandler.OnSelect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_ISelectHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(ISelectHandler));
	}

	// Token: 0x0401907A RID: 102522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
