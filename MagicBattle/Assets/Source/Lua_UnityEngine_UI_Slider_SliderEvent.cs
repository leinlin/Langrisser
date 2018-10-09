using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001860 RID: 6240
[Preserve]
public class Lua_UnityEngine_UI_Slider_SliderEvent : LuaObject
{
	// Token: 0x060242A8 RID: 148136 RVA: 0x00CB3FC0 File Offset: 0x00CB21C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Slider.SliderEvent o = new Slider.SliderEvent();
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

	// Token: 0x060242A9 RID: 148137 RVA: 0x00CB4008 File Offset: 0x00CB2208
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_float.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.UI.Slider.SliderEvent");
		if (Lua_UnityEngine_UI_Slider_SliderEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Slider_SliderEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Slider_SliderEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_Slider_SliderEvent.<>f__mg$cache0, typeof(Slider.SliderEvent), typeof(LuaUnityEvent_float));
	}

	// Token: 0x04019E46 RID: 106054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
