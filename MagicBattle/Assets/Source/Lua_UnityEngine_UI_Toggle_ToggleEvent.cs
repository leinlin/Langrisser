using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001865 RID: 6245
[Preserve]
public class Lua_UnityEngine_UI_Toggle_ToggleEvent : LuaObject
{
	// Token: 0x060242F6 RID: 148214 RVA: 0x00CB61E0 File Offset: 0x00CB43E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Toggle.ToggleEvent o = new Toggle.ToggleEvent();
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

	// Token: 0x060242F7 RID: 148215 RVA: 0x00CB6228 File Offset: 0x00CB4428
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_bool.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.UI.Toggle.ToggleEvent");
		if (Lua_UnityEngine_UI_Toggle_ToggleEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Toggle_ToggleEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle_ToggleEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_Toggle_ToggleEvent.<>f__mg$cache0, typeof(Toggle.ToggleEvent), typeof(LuaUnityEvent_bool));
	}

	// Token: 0x04019E8A RID: 106122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
