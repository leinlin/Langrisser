using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014A2 RID: 5282
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask : LuaObject
{
	// Token: 0x0601E92C RID: 125228 RVA: 0x009E0868 File Offset: 0x009DEA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int taskIndex;
			LuaObject.checkType(l, 2, out taskIndex);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			HeroAssistantClaimRewardNetTask o = new HeroAssistantClaimRewardNetTask(taskIndex, slot);
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

	// Token: 0x0601E92D RID: 125229 RVA: 0x009E08C8 File Offset: 0x009DEAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantClaimRewardNetTask heroAssistantClaimRewardNetTask = (HeroAssistantClaimRewardNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantClaimRewardNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E92E RID: 125230 RVA: 0x009E091C File Offset: 0x009DEB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Rewards(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantClaimRewardNetTask heroAssistantClaimRewardNetTask = (HeroAssistantClaimRewardNetTask)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			heroAssistantClaimRewardNetTask.Rewards = rewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E92F RID: 125231 RVA: 0x009E0974 File Offset: 0x009DEB74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroAssistantClaimRewardNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.get_Rewards);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.set_Rewards);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.<>f__mg$cache2, typeof(HeroAssistantClaimRewardNetTask), typeof(UINetTask));
	}

	// Token: 0x040149CA RID: 84426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040149CB RID: 84427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040149CC RID: 84428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
