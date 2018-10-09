using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200151A RID: 5402
[Preserve]
public class Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask : LuaObject
{
	// Token: 0x060200BD RID: 131261 RVA: 0x00A9C568 File Offset: 0x00A9A768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int slot;
			LuaObject.checkType(l, 2, out slot);
			NoviceClaimRewardReqNetTask o = new NoviceClaimRewardReqNetTask(slot);
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

	// Token: 0x060200BE RID: 131262 RVA: 0x00A9C5BC File Offset: 0x00A9A7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			NoviceClaimRewardReqNetTask noviceClaimRewardReqNetTask = (NoviceClaimRewardReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noviceClaimRewardReqNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200BF RID: 131263 RVA: 0x00A9C610 File Offset: 0x00A9A810
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.NoviceClaimRewardReqNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.get_Rewards);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.<>f__mg$cache1, typeof(NoviceClaimRewardReqNetTask), typeof(UINetTask));
	}

	// Token: 0x0401606B RID: 90219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401606C RID: 90220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
