using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015BB RID: 5563
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TreasureLevelUINetTask : LuaObject
{
	// Token: 0x06021CFD RID: 138493 RVA: 0x00B7E640 File Offset: 0x00B7C840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelID;
			LuaObject.checkType(l, 2, out levelID);
			TreasureLevelUINetTask o = new TreasureLevelUINetTask(levelID);
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

	// Token: 0x06021CFE RID: 138494 RVA: 0x00B7E694 File Offset: 0x00B7C894
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TreasureLevelUINetTask");
		if (Lua_BlackJack_ProjectL_UI_TreasureLevelUINetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureLevelUINetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureLevelUINetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TreasureLevelUINetTask.<>f__mg$cache0, typeof(TreasureLevelUINetTask), typeof(UINetTask));
	}

	// Token: 0x04017B69 RID: 97129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
