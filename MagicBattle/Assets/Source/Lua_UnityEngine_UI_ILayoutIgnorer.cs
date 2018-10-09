using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001832 RID: 6194
[Preserve]
public class Lua_UnityEngine_UI_ILayoutIgnorer : LuaObject
{
	// Token: 0x060240D0 RID: 147664 RVA: 0x00CA7EF0 File Offset: 0x00CA60F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ignoreLayout(IntPtr l)
	{
		int result;
		try
		{
			ILayoutIgnorer layoutIgnorer = (ILayoutIgnorer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutIgnorer.ignoreLayout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240D1 RID: 147665 RVA: 0x00CA7F44 File Offset: 0x00CA6144
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ILayoutIgnorer");
		string name = "ignoreLayout";
		if (Lua_UnityEngine_UI_ILayoutIgnorer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ILayoutIgnorer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutIgnorer.get_ignoreLayout);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_ILayoutIgnorer.<>f__mg$cache0, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(ILayoutIgnorer));
	}

	// Token: 0x04019CCA RID: 105674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
