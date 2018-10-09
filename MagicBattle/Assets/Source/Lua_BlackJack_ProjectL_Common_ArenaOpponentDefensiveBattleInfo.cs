using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011BD RID: 4541
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo : LuaObject
{
	// Token: 0x0601786D RID: 96365 RVA: 0x0066FAB8 File Offset: 0x0066DCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo o = new ArenaOpponentDefensiveBattleInfo();
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

	// Token: 0x0601786E RID: 96366 RVA: 0x0066FB00 File Offset: 0x0066DD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBDefensiveBattleInfoToDefensiveBattleInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ProArenaDefensiveBattleInfo pbDefensiveBattleInfo;
			LuaObject.checkType<ProArenaDefensiveBattleInfo>(l, 1, out pbDefensiveBattleInfo);
			ArenaOpponentDefensiveBattleInfo o = ArenaOpponentDefensiveBattleInfo.PBDefensiveBattleInfoToDefensiveBattleInfo(pbDefensiveBattleInfo);
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

	// Token: 0x0601786F RID: 96367 RVA: 0x0066FB54 File Offset: 0x0066DD54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DefensiveBattleInfoToPBDefensiveBattleInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo defensiveBattleInfo;
			LuaObject.checkType<ArenaOpponentDefensiveBattleInfo>(l, 1, out defensiveBattleInfo);
			ProArenaDefensiveBattleInfo o = ArenaOpponentDefensiveBattleInfo.DefensiveBattleInfoToPBDefensiveBattleInfo(defensiveBattleInfo);
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

	// Token: 0x06017870 RID: 96368 RVA: 0x0066FBA8 File Offset: 0x0066DDA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleTeamSnapshot(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017871 RID: 96369 RVA: 0x0066FBFC File Offset: 0x0066DDFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleTeamSnapshot(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			ArenaPlayerDefensiveTeamSnapshot battleTeamSnapshot;
			LuaObject.checkType<ArenaPlayerDefensiveTeamSnapshot>(l, 2, out battleTeamSnapshot);
			arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot = battleTeamSnapshot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017872 RID: 96370 RVA: 0x0066FC54 File Offset: 0x0066DE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Status(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arenaOpponentDefensiveBattleInfo.Status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017873 RID: 96371 RVA: 0x0066FCA8 File Offset: 0x0066DEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Status(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			ArenaBattleReportStatus status;
			LuaObject.checkEnum<ArenaBattleReportStatus>(l, 2, out status);
			arenaOpponentDefensiveBattleInfo.Status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017874 RID: 96372 RVA: 0x0066FD00 File Offset: 0x0066DF00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpponentUserId(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentDefensiveBattleInfo.OpponentUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017875 RID: 96373 RVA: 0x0066FD54 File Offset: 0x0066DF54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpponentUserId(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			string opponentUserId;
			LuaObject.checkType(l, 2, out opponentUserId);
			arenaOpponentDefensiveBattleInfo.OpponentUserId = opponentUserId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017876 RID: 96374 RVA: 0x0066FDAC File Offset: 0x0066DFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentDefensiveBattleInfo.BattleRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017877 RID: 96375 RVA: 0x0066FE00 File Offset: 0x0066E000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			int battleRandomSeed;
			LuaObject.checkType(l, 2, out battleRandomSeed);
			arenaOpponentDefensiveBattleInfo.BattleRandomSeed = battleRandomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017878 RID: 96376 RVA: 0x0066FE58 File Offset: 0x0066E058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentDefensiveBattleInfo.BattleExpiredTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017879 RID: 96377 RVA: 0x0066FEAC File Offset: 0x0066E0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			long battleExpiredTime;
			LuaObject.checkType(l, 2, out battleExpiredTime);
			arenaOpponentDefensiveBattleInfo.BattleExpiredTime = battleExpiredTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601787A RID: 96378 RVA: 0x0066FF04 File Offset: 0x0066E104
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaOpponentPointZoneId(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentDefensiveBattleInfo.ArenaOpponentPointZoneId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601787B RID: 96379 RVA: 0x0066FF58 File Offset: 0x0066E158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArenaOpponentPointZoneId(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = (ArenaOpponentDefensiveBattleInfo)LuaObject.checkSelf(l);
			int arenaOpponentPointZoneId;
			LuaObject.checkType(l, 2, out arenaOpponentPointZoneId);
			arenaOpponentDefensiveBattleInfo.ArenaOpponentPointZoneId = arenaOpponentPointZoneId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601787C RID: 96380 RVA: 0x0066FFB0 File Offset: 0x0066E1B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaOpponentDefensiveBattleInfo");
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.PBDefensiveBattleInfoToDefensiveBattleInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.DefensiveBattleInfoToPBDefensiveBattleInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache1);
		string name = "BattleTeamSnapshot";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.get_BattleTeamSnapshot);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.set_BattleTeamSnapshot);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache3, true);
		string name2 = "Status";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.get_Status);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.set_Status);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache5, true);
		string name3 = "OpponentUserId";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.get_OpponentUserId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.set_OpponentUserId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache7, true);
		string name4 = "BattleRandomSeed";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.get_BattleRandomSeed);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.set_BattleRandomSeed);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cache9, true);
		string name5 = "BattleExpiredTime";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.get_BattleExpiredTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.set_BattleExpiredTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheB, true);
		string name6 = "ArenaOpponentPointZoneId";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.get_ArenaOpponentPointZoneId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.set_ArenaOpponentPointZoneId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.<>f__mg$cacheE, typeof(ArenaOpponentDefensiveBattleInfo));
	}

	// Token: 0x0400DED5 RID: 57045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DED6 RID: 57046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DED7 RID: 57047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DED8 RID: 57048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DED9 RID: 57049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DEDA RID: 57050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DEDB RID: 57051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DEDC RID: 57052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DEDD RID: 57053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DEDE RID: 57054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DEDF RID: 57055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DEE0 RID: 57056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DEE1 RID: 57057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DEE2 RID: 57058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DEE3 RID: 57059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
