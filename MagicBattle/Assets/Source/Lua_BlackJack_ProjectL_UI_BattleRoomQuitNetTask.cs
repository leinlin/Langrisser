using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013C0 RID: 5056
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomQuitNetTask : LuaObject
{
	// Token: 0x0601BF02 RID: 114434 RVA: 0x00891860 File Offset: 0x0088FA60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomQuitNetTask o = new BattleRoomQuitNetTask();
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

	// Token: 0x0601BF03 RID: 114435 RVA: 0x008918A8 File Offset: 0x0088FAA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomQuitNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomQuitNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomQuitNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomQuitNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomQuitNetTask.<>f__mg$cache0, typeof(BattleRoomQuitNetTask), typeof(UINetTask));
	}

	// Token: 0x04012164 RID: 74084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
