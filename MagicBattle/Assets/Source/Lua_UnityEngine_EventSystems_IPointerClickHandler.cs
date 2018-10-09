using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B1 RID: 5809
[Preserve]
public class Lua_UnityEngine_EventSystems_IPointerClickHandler : LuaObject
{
	// Token: 0x06023178 RID: 143736 RVA: 0x00C27BF0 File Offset: 0x00C25DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			IPointerClickHandler pointerClickHandler = (IPointerClickHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointerClickHandler.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023179 RID: 143737 RVA: 0x00C27C48 File Offset: 0x00C25E48
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IPointerClickHandler");
		if (Lua_UnityEngine_EventSystems_IPointerClickHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IPointerClickHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IPointerClickHandler.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IPointerClickHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IPointerClickHandler));
	}

	// Token: 0x04019074 RID: 102516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
