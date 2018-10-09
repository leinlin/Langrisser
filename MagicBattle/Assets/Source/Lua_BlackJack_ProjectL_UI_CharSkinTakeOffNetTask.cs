using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013E5 RID: 5093
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CharSkinTakeOffNetTask : LuaObject
{
	// Token: 0x0601C8E4 RID: 116964 RVA: 0x008E08C0 File Offset: 0x008DEAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			CharSkinTakeOffNetTask o = new CharSkinTakeOffNetTask(heroId);
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

	// Token: 0x0601C8E5 RID: 116965 RVA: 0x008E0914 File Offset: 0x008DEB14
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CharSkinTakeOffNetTask");
		if (Lua_BlackJack_ProjectL_UI_CharSkinTakeOffNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CharSkinTakeOffNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CharSkinTakeOffNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_CharSkinTakeOffNetTask.<>f__mg$cache0, typeof(CharSkinTakeOffNetTask), typeof(UINetTask));
	}

	// Token: 0x04012AFC RID: 76540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
