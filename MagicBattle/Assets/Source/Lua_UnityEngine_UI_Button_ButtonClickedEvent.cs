using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Events;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200180E RID: 6158
[Preserve]
public class Lua_UnityEngine_UI_Button_ButtonClickedEvent : LuaObject
{
	// Token: 0x06023F97 RID: 147351 RVA: 0x00CA02E0 File Offset: 0x00C9E4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Button.ButtonClickedEvent o = new Button.ButtonClickedEvent();
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

	// Token: 0x06023F98 RID: 147352 RVA: 0x00CA0328 File Offset: 0x00C9E528
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Button.ButtonClickedEvent");
		if (Lua_UnityEngine_UI_Button_ButtonClickedEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Button_ButtonClickedEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Button_ButtonClickedEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_Button_ButtonClickedEvent.<>f__mg$cache0, typeof(Button.ButtonClickedEvent), typeof(UnityEvent));
	}

	// Token: 0x04019BD9 RID: 105433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
