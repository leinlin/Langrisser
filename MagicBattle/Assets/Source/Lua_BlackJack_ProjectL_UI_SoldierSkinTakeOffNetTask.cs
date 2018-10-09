using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001582 RID: 5506
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SoldierSkinTakeOffNetTask : LuaObject
{
	// Token: 0x06021231 RID: 135729 RVA: 0x00B28168 File Offset: 0x00B26368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			bool isSetToAllSoldier;
			LuaObject.checkType(l, 4, out isSetToAllSoldier);
			SoldierSkinTakeOffNetTask o = new SoldierSkinTakeOffNetTask(heroId, soldierId, isSetToAllSoldier);
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

	// Token: 0x06021232 RID: 135730 RVA: 0x00B281D8 File Offset: 0x00B263D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SoldierSkinTakeOffNetTask");
		if (Lua_BlackJack_ProjectL_UI_SoldierSkinTakeOffNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierSkinTakeOffNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierSkinTakeOffNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_SoldierSkinTakeOffNetTask.<>f__mg$cache0, typeof(SoldierSkinTakeOffNetTask), typeof(UINetTask));
	}

	// Token: 0x0401710F RID: 94479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
