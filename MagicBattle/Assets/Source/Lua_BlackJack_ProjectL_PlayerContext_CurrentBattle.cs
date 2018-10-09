using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012BF RID: 4799
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle : LuaObject
{
	// Token: 0x060193D4 RID: 103380 RVA: 0x0073A358 File Offset: 0x00738558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle o = new CurrentBattle();
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

	// Token: 0x060193D5 RID: 103381 RVA: 0x0073A3A0 File Offset: 0x007385A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			currentBattle.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193D6 RID: 103382 RVA: 0x0073A3EC File Offset: 0x007385EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleType(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)currentBattle.BattleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193D7 RID: 103383 RVA: 0x0073A440 File Offset: 0x00738640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleType(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			currentBattle.BattleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193D8 RID: 103384 RVA: 0x0073A498 File Offset: 0x00738698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.BattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193D9 RID: 103385 RVA: 0x0073A4EC File Offset: 0x007386EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			currentBattle.BattleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193DA RID: 103386 RVA: 0x0073A544 File Offset: 0x00738744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PVPBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.PVPBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193DB RID: 103387 RVA: 0x0073A598 File Offset: 0x00738798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PVPBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			ConfigDataPVPBattleInfo pvpbattleInfo;
			LuaObject.checkType<ConfigDataPVPBattleInfo>(l, 2, out pvpbattleInfo);
			currentBattle.PVPBattleInfo = pvpbattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193DC RID: 103388 RVA: 0x0073A5F0 File Offset: 0x007387F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealTimePVPBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.RealTimePVPBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193DD RID: 103389 RVA: 0x0073A644 File Offset: 0x00738844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RealTimePVPBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			ConfigDataRealTimePVPBattleInfo realTimePVPBattleInfo;
			LuaObject.checkType<ConfigDataRealTimePVPBattleInfo>(l, 2, out realTimePVPBattleInfo);
			currentBattle.RealTimePVPBattleInfo = realTimePVPBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193DE RID: 103390 RVA: 0x0073A69C File Offset: 0x0073889C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RealTimePVPBattleReport(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.RealTimePVPBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193DF RID: 103391 RVA: 0x0073A6F0 File Offset: 0x007388F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RealTimePVPBattleReport(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			RealTimePVPBattleReport realTimePVPBattleReport;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out realTimePVPBattleReport);
			currentBattle.RealTimePVPBattleReport = realTimePVPBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E0 RID: 103392 RVA: 0x0073A748 File Offset: 0x00738948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.ArenaBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E1 RID: 103393 RVA: 0x0073A79C File Offset: 0x0073899C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo arenaBattleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out arenaBattleInfo);
			currentBattle.ArenaBattleInfo = arenaBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E2 RID: 103394 RVA: 0x0073A7F4 File Offset: 0x007389F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaDefendRuleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.ArenaDefendRuleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E3 RID: 103395 RVA: 0x0073A848 File Offset: 0x00738A48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArenaDefendRuleInfo(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			ConfigDataArenaDefendRuleInfo arenaDefendRuleInfo;
			LuaObject.checkType<ConfigDataArenaDefendRuleInfo>(l, 2, out arenaDefendRuleInfo);
			currentBattle.ArenaDefendRuleInfo = arenaDefendRuleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E4 RID: 103396 RVA: 0x0073A8A0 File Offset: 0x00738AA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaDefenderPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.ArenaDefenderPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E5 RID: 103397 RVA: 0x0073A8F4 File Offset: 0x00738AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaDefenderPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			int arenaDefenderPlayerLevel;
			LuaObject.checkType(l, 2, out arenaDefenderPlayerLevel);
			currentBattle.ArenaDefenderPlayerLevel = arenaDefenderPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E6 RID: 103398 RVA: 0x0073A94C File Offset: 0x00738B4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaDefenderHeros(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.ArenaDefenderHeros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E7 RID: 103399 RVA: 0x0073A9A0 File Offset: 0x00738BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaDefenderHeros(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			List<BattleHero> arenaDefenderHeros;
			LuaObject.checkType<List<BattleHero>>(l, 2, out arenaDefenderHeros);
			currentBattle.ArenaDefenderHeros = arenaDefenderHeros;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E8 RID: 103400 RVA: 0x0073A9F8 File Offset: 0x00738BF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaDefenderTrainTechs(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.ArenaDefenderTrainTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193E9 RID: 103401 RVA: 0x0073AA4C File Offset: 0x00738C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaDefenderTrainTechs(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			List<TrainingTech> arenaDefenderTrainTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out arenaDefenderTrainTechs);
			currentBattle.ArenaDefenderTrainTechs = arenaDefenderTrainTechs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193EA RID: 103402 RVA: 0x0073AAA4 File Offset: 0x00738CA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.ArenaBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193EB RID: 103403 RVA: 0x0073AAF8 File Offset: 0x00738CF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			ArenaBattleReport arenaBattleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out arenaBattleReport);
			currentBattle.ArenaBattleReport = arenaBattleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193EC RID: 103404 RVA: 0x0073AB50 File Offset: 0x00738D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsArenaRevenge(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentBattle.IsArenaRevenge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193ED RID: 103405 RVA: 0x0073ABA4 File Offset: 0x00738DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsArenaRevenge(IntPtr l)
	{
		int result;
		try
		{
			CurrentBattle currentBattle = (CurrentBattle)LuaObject.checkSelf(l);
			bool isArenaRevenge;
			LuaObject.checkType(l, 2, out isArenaRevenge);
			currentBattle.IsArenaRevenge = isArenaRevenge;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193EE RID: 103406 RVA: 0x0073ABFC File Offset: 0x00738DFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.CurrentBattle");
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache0);
		string name = "BattleType";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_BattleType);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_BattleType);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache2, true);
		string name2 = "BattleInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_BattleInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_BattleInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache4, true);
		string name3 = "PVPBattleInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_PVPBattleInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_PVPBattleInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache6, true);
		string name4 = "RealTimePVPBattleInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_RealTimePVPBattleInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_RealTimePVPBattleInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache8, true);
		string name5 = "RealTimePVPBattleReport";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_RealTimePVPBattleReport);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_RealTimePVPBattleReport);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheA, true);
		string name6 = "ArenaBattleInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_ArenaBattleInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_ArenaBattleInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheC, true);
		string name7 = "ArenaDefendRuleInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_ArenaDefendRuleInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_ArenaDefendRuleInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheE, true);
		string name8 = "ArenaDefenderPlayerLevel";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_ArenaDefenderPlayerLevel);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_ArenaDefenderPlayerLevel);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache10, true);
		string name9 = "ArenaDefenderHeros";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_ArenaDefenderHeros);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_ArenaDefenderHeros);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache12, true);
		string name10 = "ArenaDefenderTrainTechs";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_ArenaDefenderTrainTechs);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_ArenaDefenderTrainTechs);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache14, true);
		string name11 = "ArenaBattleReport";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_ArenaBattleReport);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_ArenaBattleReport);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache16, true);
		string name12 = "IsArenaRevenge";
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.get_IsArenaRevenge);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.set_IsArenaRevenge);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache18, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.<>f__mg$cache19, typeof(CurrentBattle));
	}

	// Token: 0x0400F838 RID: 63544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F839 RID: 63545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F83A RID: 63546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F83B RID: 63547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F83C RID: 63548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F83D RID: 63549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F83E RID: 63550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F83F RID: 63551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F840 RID: 63552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F841 RID: 63553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F842 RID: 63554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F843 RID: 63555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F844 RID: 63556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F845 RID: 63557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F846 RID: 63558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F847 RID: 63559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F848 RID: 63560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F849 RID: 63561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F84A RID: 63562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F84B RID: 63563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F84C RID: 63564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F84D RID: 63565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F84E RID: 63566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F84F RID: 63567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F850 RID: 63568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F851 RID: 63569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
