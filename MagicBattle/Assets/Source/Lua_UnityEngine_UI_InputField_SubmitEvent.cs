using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001845 RID: 6213
[Preserve]
public class Lua_UnityEngine_UI_InputField_SubmitEvent : LuaObject
{
	// Token: 0x0602416D RID: 147821 RVA: 0x00CABD00 File Offset: 0x00CA9F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			InputField.SubmitEvent o = new InputField.SubmitEvent();
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

	// Token: 0x0602416E RID: 147822 RVA: 0x00CABD48 File Offset: 0x00CA9F48
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_string.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.UI.InputField.SubmitEvent");
		if (Lua_UnityEngine_UI_InputField_SubmitEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_InputField_SubmitEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_InputField_SubmitEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_InputField_SubmitEvent.<>f__mg$cache0, typeof(InputField.SubmitEvent), typeof(LuaUnityEvent_string));
	}

	// Token: 0x04019D41 RID: 105793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
