using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200182E RID: 6190
[Preserve]
public class Lua_UnityEngine_UI_IClipper : LuaObject
{
	// Token: 0x060240BC RID: 147644 RVA: 0x00CA7894 File Offset: 0x00CA5A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PerformClipping(IntPtr l)
	{
		int result;
		try
		{
			IClipper clipper = (IClipper)LuaObject.checkSelf(l);
			clipper.PerformClipping();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240BD RID: 147645 RVA: 0x00CA78E0 File Offset: 0x00CA5AE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.IClipper");
		if (Lua_UnityEngine_UI_IClipper.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_IClipper.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_IClipper.PerformClipping);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_IClipper.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IClipper));
	}

	// Token: 0x04019CBE RID: 105662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
