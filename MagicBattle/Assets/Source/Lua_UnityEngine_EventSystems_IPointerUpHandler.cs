using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B5 RID: 5813
[Preserve]
public class Lua_UnityEngine_EventSystems_IPointerUpHandler : LuaObject
{
	// Token: 0x06023184 RID: 143748 RVA: 0x00C27EA0 File Offset: 0x00C260A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			IPointerUpHandler pointerUpHandler = (IPointerUpHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointerUpHandler.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023185 RID: 143749 RVA: 0x00C27EF8 File Offset: 0x00C260F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IPointerUpHandler");
		if (Lua_UnityEngine_EventSystems_IPointerUpHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IPointerUpHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IPointerUpHandler.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IPointerUpHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IPointerUpHandler));
	}

	// Token: 0x04019078 RID: 102520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
