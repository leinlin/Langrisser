using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200154B RID: 5451
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RankingNetTask : LuaObject
{
	// Token: 0x060209A3 RID: 133539 RVA: 0x00AE3B34 File Offset: 0x00AE1D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RankingListType type;
			LuaObject.checkEnum<RankingListType>(l, 2, out type);
			int heroId;
			LuaObject.checkType(l, 3, out heroId);
			RankingNetTask o = new RankingNetTask(type, heroId);
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

	// Token: 0x060209A4 RID: 133540 RVA: 0x00AE3B94 File Offset: 0x00AE1D94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RankingNetTask");
		if (Lua_BlackJack_ProjectL_UI_RankingNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RankingNetTask.<>f__mg$cache0, typeof(RankingNetTask), typeof(UINetTask));
	}

	// Token: 0x040168EF RID: 92399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
