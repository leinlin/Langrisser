using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016EF RID: 5871
[Preserve]
public class Lua_UnityEngine_ImageEffectOpaque : LuaObject
{
	// Token: 0x06023396 RID: 144278 RVA: 0x00C39510 File Offset: 0x00C37710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ImageEffectOpaque o = new ImageEffectOpaque();
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

	// Token: 0x06023397 RID: 144279 RVA: 0x00C39558 File Offset: 0x00C37758
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ImageEffectOpaque");
		if (Lua_UnityEngine_ImageEffectOpaque.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ImageEffectOpaque.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ImageEffectOpaque.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ImageEffectOpaque.<>f__mg$cache0, typeof(ImageEffectOpaque), typeof(Attribute));
	}

	// Token: 0x04019216 RID: 102934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
