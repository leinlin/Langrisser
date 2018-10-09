using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001856 RID: 6230
[Preserve]
public class Lua_UnityEngine_UI_Scrollbar_ScrollEvent : LuaObject
{
	// Token: 0x06024210 RID: 147984 RVA: 0x00CAFEE4 File Offset: 0x00CAE0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Scrollbar.ScrollEvent o = new Scrollbar.ScrollEvent();
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

	// Token: 0x06024211 RID: 147985 RVA: 0x00CAFF2C File Offset: 0x00CAE12C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_float.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.UI.Scrollbar.ScrollEvent");
		if (Lua_UnityEngine_UI_Scrollbar_ScrollEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Scrollbar_ScrollEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Scrollbar_ScrollEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_Scrollbar_ScrollEvent.<>f__mg$cache0, typeof(Scrollbar.ScrollEvent), typeof(LuaUnityEvent_float));
	}

	// Token: 0x04019DC2 RID: 105922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
