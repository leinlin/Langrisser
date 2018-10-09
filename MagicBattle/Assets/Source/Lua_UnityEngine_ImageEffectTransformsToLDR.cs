using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016F0 RID: 5872
[Preserve]
public class Lua_UnityEngine_ImageEffectTransformsToLDR : LuaObject
{
	// Token: 0x06023399 RID: 144281 RVA: 0x00C395B0 File Offset: 0x00C377B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ImageEffectTransformsToLDR o = new ImageEffectTransformsToLDR();
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

	// Token: 0x0602339A RID: 144282 RVA: 0x00C395F8 File Offset: 0x00C377F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ImageEffectTransformsToLDR");
		if (Lua_UnityEngine_ImageEffectTransformsToLDR.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ImageEffectTransformsToLDR.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ImageEffectTransformsToLDR.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ImageEffectTransformsToLDR.<>f__mg$cache0, typeof(ImageEffectTransformsToLDR), typeof(Attribute));
	}

	// Token: 0x04019217 RID: 102935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
