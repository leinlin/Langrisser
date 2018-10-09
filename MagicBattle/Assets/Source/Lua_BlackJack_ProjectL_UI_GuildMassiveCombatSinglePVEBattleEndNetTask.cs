using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200148B RID: 5259
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask : LuaObject
{
	// Token: 0x0601E6FA RID: 124666 RVA: 0x009CFA24 File Offset: 0x009CDC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			ProBattleReport report;
			LuaObject.checkType<ProBattleReport>(l, 3, out report);
			GuildMassiveCombatSinglePVEBattleEndNetTask o = new GuildMassiveCombatSinglePVEBattleEndNetTask(levelId, report);
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

	// Token: 0x0601E6FB RID: 124667 RVA: 0x009CFA84 File Offset: 0x009CDC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatSinglePVEBattleEndNetTask guildMassiveCombatSinglePVEBattleEndNetTask = (GuildMassiveCombatSinglePVEBattleEndNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatSinglePVEBattleEndNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6FC RID: 124668 RVA: 0x009CFAD8 File Offset: 0x009CDCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatSinglePVEBattleEndNetTask guildMassiveCombatSinglePVEBattleEndNetTask = (GuildMassiveCombatSinglePVEBattleEndNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatSinglePVEBattleEndNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6FD RID: 124669 RVA: 0x009CFB2C File Offset: 0x009CDD2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMassiveCombatSinglePVEBattleEndNetTask");
		string name = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache0, null, true);
		string name2 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.get_Reward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.<>f__mg$cache2, typeof(GuildMassiveCombatSinglePVEBattleEndNetTask), typeof(UINetTask));
	}

	// Token: 0x040147C6 RID: 83910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040147C7 RID: 83911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040147C8 RID: 83912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
