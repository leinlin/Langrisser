using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013BC RID: 5052
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomHeroSetupNetTask : LuaObject
{
	// Token: 0x0601BEF6 RID: 114422 RVA: 0x008915A4 File Offset: 0x0088F7A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int position;
			LuaObject.checkType(l, 3, out position);
			BattleRoomHeroSetupNetTask o = new BattleRoomHeroSetupNetTask(heroId, position);
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

	// Token: 0x0601BEF7 RID: 114423 RVA: 0x00891604 File Offset: 0x0088F804
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomHeroSetupNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomHeroSetupNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomHeroSetupNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomHeroSetupNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomHeroSetupNetTask.<>f__mg$cache0, typeof(BattleRoomHeroSetupNetTask), typeof(UINetTask));
	}

	// Token: 0x04012160 RID: 74080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
