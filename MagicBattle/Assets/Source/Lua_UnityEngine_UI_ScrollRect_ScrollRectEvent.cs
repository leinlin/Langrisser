using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200185A RID: 6234
[Preserve]
public class Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent : LuaObject
{
	// Token: 0x06024256 RID: 148054 RVA: 0x00CB1D04 File Offset: 0x00CAFF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect.ScrollRectEvent o = new ScrollRect.ScrollRectEvent();
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

	// Token: 0x06024257 RID: 148055 RVA: 0x00CB1D4C File Offset: 0x00CAFF4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaUnityEvent_UnityEngine_Vector2.reg(l);
		LuaObject.getTypeTable(l, "UnityEngine.UI.ScrollRect.ScrollRectEvent");
		if (Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent.<>f__mg$cache0, typeof(ScrollRect.ScrollRectEvent), typeof(LuaUnityEvent_UnityEngine_Vector2));
	}

	// Token: 0x04019E00 RID: 105984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
