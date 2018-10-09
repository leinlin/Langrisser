using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001583 RID: 5507
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SoldierSkinWearNetTask : LuaObject
{
	// Token: 0x06021234 RID: 135732 RVA: 0x00B28230 File Offset: 0x00B26430
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
			int soldierSkinId;
			LuaObject.checkType(l, 4, out soldierSkinId);
			bool isSetToAllSoldier;
			LuaObject.checkType(l, 5, out isSetToAllSoldier);
			SoldierSkinWearNetTask o = new SoldierSkinWearNetTask(heroId, soldierId, soldierSkinId, isSetToAllSoldier);
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

	// Token: 0x06021235 RID: 135733 RVA: 0x00B282AC File Offset: 0x00B264AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SoldierSkinWearNetTask");
		if (Lua_BlackJack_ProjectL_UI_SoldierSkinWearNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierSkinWearNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierSkinWearNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_SoldierSkinWearNetTask.<>f__mg$cache0, typeof(SoldierSkinWearNetTask), typeof(UINetTask));
	}

	// Token: 0x04017110 RID: 94480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
