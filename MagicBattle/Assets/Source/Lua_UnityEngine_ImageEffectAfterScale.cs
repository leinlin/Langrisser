using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016ED RID: 5869
[Preserve]
public class Lua_UnityEngine_ImageEffectAfterScale : LuaObject
{
	// Token: 0x06023390 RID: 144272 RVA: 0x00C393D0 File Offset: 0x00C375D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ImageEffectAfterScale o = new ImageEffectAfterScale();
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

	// Token: 0x06023391 RID: 144273 RVA: 0x00C39418 File Offset: 0x00C37618
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ImageEffectAfterScale");
		if (Lua_UnityEngine_ImageEffectAfterScale.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ImageEffectAfterScale.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ImageEffectAfterScale.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ImageEffectAfterScale.<>f__mg$cache0, typeof(ImageEffectAfterScale), typeof(Attribute));
	}

	// Token: 0x04019214 RID: 102932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
