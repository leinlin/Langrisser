using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013E4 RID: 5092
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChangePlayerNameNetTask : LuaObject
{
	// Token: 0x0601C8E1 RID: 116961 RVA: 0x008E0814 File Offset: 0x008DEA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string playerNewName;
			LuaObject.checkType(l, 2, out playerNewName);
			ChangePlayerNameNetTask o = new ChangePlayerNameNetTask(playerNewName);
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

	// Token: 0x0601C8E2 RID: 116962 RVA: 0x008E0868 File Offset: 0x008DEA68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChangePlayerNameNetTask");
		if (Lua_BlackJack_ProjectL_UI_ChangePlayerNameNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChangePlayerNameNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChangePlayerNameNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChangePlayerNameNetTask.<>f__mg$cache0, typeof(ChangePlayerNameNetTask), typeof(UINetTask));
	}

	// Token: 0x04012AFB RID: 76539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
