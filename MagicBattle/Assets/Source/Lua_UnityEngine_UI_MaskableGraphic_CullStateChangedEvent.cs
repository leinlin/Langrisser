using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200184C RID: 6220
[Preserve]
public class Lua_UnityEngine_UI_MaskableGraphic_CullStateChangedEvent : LuaObject
{
	// Token: 0x060241BF RID: 147903 RVA: 0x00CADF4C File Offset: 0x00CAC14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic.CullStateChangedEvent o = new MaskableGraphic.CullStateChangedEvent();
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

	// Token: 0x060241C0 RID: 147904 RVA: 0x00CADF94 File Offset: 0x00CAC194
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_bool.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.UI.MaskableGraphic.CullStateChangedEvent");
		if (Lua_UnityEngine_UI_MaskableGraphic_CullStateChangedEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic_CullStateChangedEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic_CullStateChangedEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_MaskableGraphic_CullStateChangedEvent.<>f__mg$cache0, typeof(MaskableGraphic.CullStateChangedEvent), typeof(LuaUnityEvent_bool));
	}

	// Token: 0x04019D85 RID: 105861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
