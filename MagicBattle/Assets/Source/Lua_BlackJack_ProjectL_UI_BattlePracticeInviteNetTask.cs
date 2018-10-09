using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013AB RID: 5035
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePracticeInviteNetTask : LuaObject
{
	// Token: 0x0601BAD2 RID: 113362 RVA: 0x00870974 File Offset: 0x0086EB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			BattlePracticeInviteNetTask o = new BattlePracticeInviteNetTask(targetUserId);
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

	// Token: 0x0601BAD3 RID: 113363 RVA: 0x008709C8 File Offset: 0x0086EBC8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePracticeInviteNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattlePracticeInviteNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePracticeInviteNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePracticeInviteNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattlePracticeInviteNetTask.<>f__mg$cache0, typeof(BattlePracticeInviteNetTask), typeof(UINetTask));
	}

	// Token: 0x04011D5E RID: 73054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
