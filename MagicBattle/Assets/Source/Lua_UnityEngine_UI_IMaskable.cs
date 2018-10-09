using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200183C RID: 6204
[Preserve]
public class Lua_UnityEngine_UI_IMaskable : LuaObject
{
	// Token: 0x0602410C RID: 147724 RVA: 0x00CA94B4 File Offset: 0x00CA76B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RecalculateMasking(IntPtr l)
	{
		int result;
		try
		{
			IMaskable maskable = (IMaskable)LuaObject.checkSelf(l);
			maskable.RecalculateMasking();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602410D RID: 147725 RVA: 0x00CA9500 File Offset: 0x00CA7700
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.IMaskable");
		if (Lua_UnityEngine_UI_IMaskable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_IMaskable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_IMaskable.RecalculateMasking);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_IMaskable.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IMaskable));
	}

	// Token: 0x04019CF2 RID: 105714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
