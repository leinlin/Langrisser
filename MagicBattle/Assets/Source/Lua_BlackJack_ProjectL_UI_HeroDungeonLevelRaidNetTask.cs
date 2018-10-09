using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014BD RID: 5309
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask : LuaObject
{
	// Token: 0x0601F05F RID: 127071 RVA: 0x00A1A44C File Offset: 0x00A1864C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroDungeonLevelID;
			LuaObject.checkType(l, 2, out heroDungeonLevelID);
			int count;
			LuaObject.checkType(l, 3, out count);
			HeroDungeonLevelRaidNetTask o = new HeroDungeonLevelRaidNetTask(heroDungeonLevelID, count);
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

	// Token: 0x0601F060 RID: 127072 RVA: 0x00A1A4AC File Offset: 0x00A186AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelRaidNetTask heroDungeonLevelRaidNetTask = (HeroDungeonLevelRaidNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelRaidNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F061 RID: 127073 RVA: 0x00A1A500 File Offset: 0x00A18700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExtraReward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelRaidNetTask heroDungeonLevelRaidNetTask = (HeroDungeonLevelRaidNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelRaidNetTask.ExtraReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F062 RID: 127074 RVA: 0x00A1A554 File Offset: 0x00A18754
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDungeonLevelRaidNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache0, null, true);
		string name2 = "ExtraReward";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.get_ExtraReward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.<>f__mg$cache2, typeof(HeroDungeonLevelRaidNetTask), typeof(UINetTask));
	}

	// Token: 0x040150C7 RID: 86215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040150C8 RID: 86216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040150C9 RID: 86217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
