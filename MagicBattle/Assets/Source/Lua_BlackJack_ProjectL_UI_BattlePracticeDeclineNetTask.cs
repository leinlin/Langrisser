using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013AA RID: 5034
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePracticeDeclineNetTask : LuaObject
{
	// Token: 0x0601BACF RID: 113359 RVA: 0x008708C8 File Offset: 0x0086EAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			BattlePracticeDeclineNetTask o = new BattlePracticeDeclineNetTask(targetUserId);
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

	// Token: 0x0601BAD0 RID: 113360 RVA: 0x0087091C File Offset: 0x0086EB1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePracticeDeclineNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattlePracticeDeclineNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePracticeDeclineNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePracticeDeclineNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattlePracticeDeclineNetTask.<>f__mg$cache0, typeof(BattlePracticeDeclineNetTask), typeof(UINetTask));
	}

	// Token: 0x04011D5D RID: 73053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
