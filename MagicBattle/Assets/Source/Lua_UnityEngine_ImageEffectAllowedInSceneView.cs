using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016EE RID: 5870
[Preserve]
public class Lua_UnityEngine_ImageEffectAllowedInSceneView : LuaObject
{
	// Token: 0x06023393 RID: 144275 RVA: 0x00C39470 File Offset: 0x00C37670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ImageEffectAllowedInSceneView o = new ImageEffectAllowedInSceneView();
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

	// Token: 0x06023394 RID: 144276 RVA: 0x00C394B8 File Offset: 0x00C376B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ImageEffectAllowedInSceneView");
		if (Lua_UnityEngine_ImageEffectAllowedInSceneView.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ImageEffectAllowedInSceneView.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ImageEffectAllowedInSceneView.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ImageEffectAllowedInSceneView.<>f__mg$cache0, typeof(ImageEffectAllowedInSceneView), typeof(Attribute));
	}

	// Token: 0x04019215 RID: 102933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
