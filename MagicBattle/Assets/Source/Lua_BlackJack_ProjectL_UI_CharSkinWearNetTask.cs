using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013E6 RID: 5094
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CharSkinWearNetTask : LuaObject
{
	// Token: 0x0601C8E7 RID: 116967 RVA: 0x008E096C File Offset: 0x008DEB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int charSkinId;
			LuaObject.checkType(l, 3, out charSkinId);
			CharSkinWearNetTask o = new CharSkinWearNetTask(heroId, charSkinId);
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

	// Token: 0x0601C8E8 RID: 116968 RVA: 0x008E09CC File Offset: 0x008DEBCC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CharSkinWearNetTask");
		if (Lua_BlackJack_ProjectL_UI_CharSkinWearNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CharSkinWearNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CharSkinWearNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_CharSkinWearNetTask.<>f__mg$cache0, typeof(CharSkinWearNetTask), typeof(UINetTask));
	}

	// Token: 0x04012AFD RID: 76541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
