using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013B9 RID: 5049
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomHeroBanNetTask : LuaObject
{
	// Token: 0x0601BEED RID: 114413 RVA: 0x008913A0 File Offset: 0x0088F5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int position;
			LuaObject.checkType(l, 2, out position);
			BattleRoomHeroBanNetTask o = new BattleRoomHeroBanNetTask(position);
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

	// Token: 0x0601BEEE RID: 114414 RVA: 0x008913F4 File Offset: 0x0088F5F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomHeroBanNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomHeroBanNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomHeroBanNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomHeroBanNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomHeroBanNetTask.<>f__mg$cache0, typeof(BattleRoomHeroBanNetTask), typeof(UINetTask));
	}

	// Token: 0x0401215D RID: 74077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
