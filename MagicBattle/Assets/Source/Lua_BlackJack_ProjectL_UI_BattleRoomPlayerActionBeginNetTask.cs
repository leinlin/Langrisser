using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013BE RID: 5054
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomPlayerActionBeginNetTask : LuaObject
{
	// Token: 0x0601BEFC RID: 114428 RVA: 0x00891714 File Offset: 0x0088F914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerActionBeginNetTask o = new BattleRoomPlayerActionBeginNetTask();
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

	// Token: 0x0601BEFD RID: 114429 RVA: 0x0089175C File Offset: 0x0088F95C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomPlayerActionBeginNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomPlayerActionBeginNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomPlayerActionBeginNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomPlayerActionBeginNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomPlayerActionBeginNetTask.<>f__mg$cache0, typeof(BattleRoomPlayerActionBeginNetTask), typeof(UINetTask));
	}

	// Token: 0x04012162 RID: 74082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
