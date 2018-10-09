using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.U2D;

// Token: 0x02001808 RID: 6152
[Preserve]
public class Lua_UnityEngine_U2D_SpriteAtlasManager : LuaObject
{
	// Token: 0x06023F76 RID: 147318 RVA: 0x00C9F734 File Offset: 0x00C9D934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SpriteAtlasManager o = new SpriteAtlasManager();
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

	// Token: 0x06023F77 RID: 147319 RVA: 0x00C9F77C File Offset: 0x00C9D97C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.U2D.SpriteAtlasManager");
		if (Lua_UnityEngine_U2D_SpriteAtlasManager.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_U2D_SpriteAtlasManager.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_U2D_SpriteAtlasManager.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_U2D_SpriteAtlasManager.<>f__mg$cache0, typeof(SpriteAtlasManager));
	}

	// Token: 0x04019BC4 RID: 105412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
