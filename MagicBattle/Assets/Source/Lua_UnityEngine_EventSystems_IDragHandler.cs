using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016AB RID: 5803
[Preserve]
public class Lua_UnityEngine_EventSystems_IDragHandler : LuaObject
{
	// Token: 0x06023167 RID: 143719 RVA: 0x00C2786C File Offset: 0x00C25A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			IDragHandler dragHandler = (IDragHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			dragHandler.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023168 RID: 143720 RVA: 0x00C278C4 File Offset: 0x00C25AC4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IDragHandler");
		if (Lua_UnityEngine_EventSystems_IDragHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IDragHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IDragHandler.OnDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IDragHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IDragHandler));
	}

	// Token: 0x0401906F RID: 102511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
