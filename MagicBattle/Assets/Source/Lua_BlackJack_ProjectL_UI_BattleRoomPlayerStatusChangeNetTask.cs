using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013BF RID: 5055
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomPlayerStatusChangeNetTask : LuaObject
{
	// Token: 0x0601BEFF RID: 114431 RVA: 0x008917B4 File Offset: 0x0088F9B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayerBattleStatus status;
			LuaObject.checkEnum<PlayerBattleStatus>(l, 2, out status);
			BattleRoomPlayerStatusChangeNetTask o = new BattleRoomPlayerStatusChangeNetTask(status);
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

	// Token: 0x0601BF00 RID: 114432 RVA: 0x00891808 File Offset: 0x0088FA08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomPlayerStatusChangeNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomPlayerStatusChangeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomPlayerStatusChangeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomPlayerStatusChangeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomPlayerStatusChangeNetTask.<>f__mg$cache0, typeof(BattleRoomPlayerStatusChangeNetTask), typeof(UINetTask));
	}

	// Token: 0x04012163 RID: 74083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
