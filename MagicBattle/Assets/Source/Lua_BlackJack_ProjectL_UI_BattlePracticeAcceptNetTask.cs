using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013A8 RID: 5032
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePracticeAcceptNetTask : LuaObject
{
	// Token: 0x0601BAC9 RID: 113353 RVA: 0x0087077C File Offset: 0x0086E97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			BattlePracticeAcceptNetTask o = new BattlePracticeAcceptNetTask(targetUserId);
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

	// Token: 0x0601BACA RID: 113354 RVA: 0x008707D0 File Offset: 0x0086E9D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePracticeAcceptNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattlePracticeAcceptNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePracticeAcceptNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePracticeAcceptNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattlePracticeAcceptNetTask.<>f__mg$cache0, typeof(BattlePracticeAcceptNetTask), typeof(UINetTask));
	}

	// Token: 0x04011D5B RID: 73051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
