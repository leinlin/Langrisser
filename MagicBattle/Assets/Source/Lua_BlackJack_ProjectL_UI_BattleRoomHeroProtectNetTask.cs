using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013BA RID: 5050
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomHeroProtectNetTask : LuaObject
{
	// Token: 0x0601BEF0 RID: 114416 RVA: 0x0089144C File Offset: 0x0088F64C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int position;
			LuaObject.checkType(l, 2, out position);
			BattleRoomHeroProtectNetTask o = new BattleRoomHeroProtectNetTask(position);
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

	// Token: 0x0601BEF1 RID: 114417 RVA: 0x008914A0 File Offset: 0x0088F6A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomHeroProtectNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomHeroProtectNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomHeroProtectNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomHeroProtectNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomHeroProtectNetTask.<>f__mg$cache0, typeof(BattleRoomHeroProtectNetTask), typeof(UINetTask));
	}

	// Token: 0x0401215E RID: 74078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
