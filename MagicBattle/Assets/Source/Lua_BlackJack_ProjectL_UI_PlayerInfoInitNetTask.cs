using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200152A RID: 5418
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask : LuaObject
{
	// Token: 0x060202EE RID: 131822 RVA: 0x00AAE120 File Offset: 0x00AAC320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoInitNetTask o = new PlayerInfoInitNetTask();
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

	// Token: 0x060202EF RID: 131823 RVA: 0x00AAE168 File Offset: 0x00AAC368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReqResultState(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoInitNetTask playerInfoInitNetTask = (PlayerInfoInitNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)playerInfoInitNetTask.ReqResultState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202F0 RID: 131824 RVA: 0x00AAE1BC File Offset: 0x00AAC3BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerInfoInitNetTask");
		string name = "ReqResultState";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.get_ReqResultState);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.<>f__mg$cache1, typeof(PlayerInfoInitNetTask), typeof(NetWorkTransactionTask));
	}

	// Token: 0x0401627C RID: 90748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401627D RID: 90749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
