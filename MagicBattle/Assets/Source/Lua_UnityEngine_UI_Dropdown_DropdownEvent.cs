using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200181D RID: 6173
[Preserve]
public class Lua_UnityEngine_UI_Dropdown_DropdownEvent : LuaObject
{
	// Token: 0x0602401F RID: 147487 RVA: 0x00CA395C File Offset: 0x00CA1B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Dropdown.DropdownEvent o = new Dropdown.DropdownEvent();
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

	// Token: 0x06024020 RID: 147488 RVA: 0x00CA39A4 File Offset: 0x00CA1BA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_int.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.UI.Dropdown.DropdownEvent");
		if (Lua_UnityEngine_UI_Dropdown_DropdownEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Dropdown_DropdownEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_DropdownEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_Dropdown_DropdownEvent.<>f__mg$cache0, typeof(Dropdown.DropdownEvent), typeof(LuaUnityEvent_int));
	}

	// Token: 0x04019C43 RID: 105539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
