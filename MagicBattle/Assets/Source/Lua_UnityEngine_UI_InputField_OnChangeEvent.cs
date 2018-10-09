using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001844 RID: 6212
[Preserve]
public class Lua_UnityEngine_UI_InputField_OnChangeEvent : LuaObject
{
	// Token: 0x0602416A RID: 147818 RVA: 0x00CABC58 File Offset: 0x00CA9E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			InputField.OnChangeEvent o = new InputField.OnChangeEvent();
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

	// Token: 0x0602416B RID: 147819 RVA: 0x00CABCA0 File Offset: 0x00CA9EA0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_string.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.UI.InputField.OnChangeEvent");
		if (Lua_UnityEngine_UI_InputField_OnChangeEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_InputField_OnChangeEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_InputField_OnChangeEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_InputField_OnChangeEvent.<>f__mg$cache0, typeof(InputField.OnChangeEvent), typeof(LuaUnityEvent_string));
	}

	// Token: 0x04019D40 RID: 105792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
