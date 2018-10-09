using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D0 RID: 4560
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleReportLog : LuaObject
{
	// Token: 0x06017A84 RID: 96900 RVA: 0x0067F64C File Offset: 0x0067D84C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog o = new BattleReportLog();
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

	// Token: 0x06017A85 RID: 96901 RVA: 0x0067F694 File Offset: 0x0067D894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A86 RID: 96902 RVA: 0x0067F6E8 File Offset: 0x0067D8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			battleReportLog.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A87 RID: 96903 RVA: 0x0067F740 File Offset: 0x0067D940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerName(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.PlayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A88 RID: 96904 RVA: 0x0067F794 File Offset: 0x0067D994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerName(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			string playerName;
			LuaObject.checkType(l, 2, out playerName);
			battleReportLog.PlayerName = playerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A89 RID: 96905 RVA: 0x0067F7EC File Offset: 0x0067D9EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleReportLog.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A8A RID: 96906 RVA: 0x0067F840 File Offset: 0x0067DA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			BattleType type;
			LuaObject.checkEnum<BattleType>(l, 2, out type);
			battleReportLog.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A8B RID: 96907 RVA: 0x0067F898 File Offset: 0x0067DA98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.BattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A8C RID: 96908 RVA: 0x0067F8EC File Offset: 0x0067DAEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			battleReportLog.BattleId = battleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A8D RID: 96909 RVA: 0x0067F944 File Offset: 0x0067DB44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomNumberSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.RandomNumberSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A8E RID: 96910 RVA: 0x0067F998 File Offset: 0x0067DB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RandomNumberSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			int randomNumberSeed;
			LuaObject.checkType(l, 2, out randomNumberSeed);
			battleReportLog.RandomNumberSeed = randomNumberSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A8F RID: 96911 RVA: 0x0067F9F0 File Offset: 0x0067DBF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArmyRandomNumberSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.ArmyRandomNumberSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A90 RID: 96912 RVA: 0x0067FA44 File Offset: 0x0067DC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArmyRandomNumberSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			int armyRandomNumberSeed;
			LuaObject.checkType(l, 2, out armyRandomNumberSeed);
			battleReportLog.ArmyRandomNumberSeed = armyRandomNumberSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A91 RID: 96913 RVA: 0x0067FA9C File Offset: 0x0067DC9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MineTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.MineTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A92 RID: 96914 RVA: 0x0067FAF0 File Offset: 0x0067DCF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MineTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			List<BattleActorSetup> mineTeam;
			LuaObject.checkType<List<BattleActorSetup>>(l, 2, out mineTeam);
			battleReportLog.MineTeam = mineTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A93 RID: 96915 RVA: 0x0067FB48 File Offset: 0x0067DD48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpponentTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.OpponentTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A94 RID: 96916 RVA: 0x0067FB9C File Offset: 0x0067DD9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpponentTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			List<BattleActorSetup> opponentTeam;
			LuaObject.checkType<List<BattleActorSetup>>(l, 2, out opponentTeam);
			battleReportLog.OpponentTeam = opponentTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A95 RID: 96917 RVA: 0x0067FBF4 File Offset: 0x0067DDF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Players(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.Players);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A96 RID: 96918 RVA: 0x0067FC48 File Offset: 0x0067DE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Players(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			List<BattlePlayer> players;
			LuaObject.checkType<List<BattlePlayer>>(l, 2, out players);
			battleReportLog.Players = players;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A97 RID: 96919 RVA: 0x0067FCA0 File Offset: 0x0067DEA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MineCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.MineCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A98 RID: 96920 RVA: 0x0067FCF4 File Offset: 0x0067DEF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MineCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			List<BattleCommand> mineCommands;
			LuaObject.checkType<List<BattleCommand>>(l, 2, out mineCommands);
			battleReportLog.MineCommands = mineCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A99 RID: 96921 RVA: 0x0067FD4C File Offset: 0x0067DF4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpponentCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.OpponentCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A9A RID: 96922 RVA: 0x0067FDA0 File Offset: 0x0067DFA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpponentCommands(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			List<BattleCommand> opponentCommands;
			LuaObject.checkType<List<BattleCommand>>(l, 2, out opponentCommands);
			battleReportLog.OpponentCommands = opponentCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A9B RID: 96923 RVA: 0x0067FDF8 File Offset: 0x0067DFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CheckSums(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportLog.CheckSums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A9C RID: 96924 RVA: 0x0067FE4C File Offset: 0x0067E04C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CheckSums(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog battleReportLog = (BattleReportLog)LuaObject.checkSelf(l);
			List<int> checkSums;
			LuaObject.checkType<List<int>>(l, 2, out checkSums);
			battleReportLog.CheckSums = checkSums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A9D RID: 96925 RVA: 0x0067FEA4 File Offset: 0x0067E0A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleReportLog");
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache1, true);
		string name2 = "PlayerName";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_PlayerName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_PlayerName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache3, true);
		string name3 = "Type";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_Type);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_Type);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache5, true);
		string name4 = "BattleId";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_BattleId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_BattleId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache7, true);
		string name5 = "RandomNumberSeed";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_RandomNumberSeed);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_RandomNumberSeed);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache9, true);
		string name6 = "ArmyRandomNumberSeed";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_ArmyRandomNumberSeed);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_ArmyRandomNumberSeed);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheB, true);
		string name7 = "MineTeam";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_MineTeam);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_MineTeam);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheD, true);
		string name8 = "OpponentTeam";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_OpponentTeam);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_OpponentTeam);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cacheF, true);
		string name9 = "Players";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_Players);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_Players);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache11, true);
		string name10 = "MineCommands";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_MineCommands);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_MineCommands);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache13, true);
		string name11 = "OpponentCommands";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_OpponentCommands);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_OpponentCommands);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache15, true);
		string name12 = "CheckSums";
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.get_CheckSums);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.set_CheckSums);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache17, true);
		if (Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReportLog.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleReportLog.<>f__mg$cache18, typeof(BattleReportLog));
	}

	// Token: 0x0400E0C6 RID: 57542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E0C7 RID: 57543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E0C8 RID: 57544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E0C9 RID: 57545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E0CA RID: 57546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E0CB RID: 57547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E0CC RID: 57548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E0CD RID: 57549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E0CE RID: 57550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E0CF RID: 57551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E0D0 RID: 57552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E0D1 RID: 57553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E0D2 RID: 57554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E0D3 RID: 57555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E0D4 RID: 57556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E0D5 RID: 57557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E0D6 RID: 57558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E0D7 RID: 57559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E0D8 RID: 57560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E0D9 RID: 57561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E0DA RID: 57562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E0DB RID: 57563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E0DC RID: 57564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E0DD RID: 57565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E0DE RID: 57566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
