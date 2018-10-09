using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E7 RID: 4583
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CommonReportLog : LuaObject
{
	// Token: 0x06017C11 RID: 97297 RVA: 0x0068A408 File Offset: 0x00688608
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CommonReportLog o = new CommonReportLog();
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

	// Token: 0x06017C12 RID: 97298 RVA: 0x0068A450 File Offset: 0x00688650
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RandomEventLevelZonesReportLog_s(IntPtr l)
	{
		int result;
		try
		{
			List<RandomEventLevelZone> zones;
			LuaObject.checkType<List<RandomEventLevelZone>>(l, 1, out zones);
			string logHeader;
			LuaObject.checkType(l, 2, out logHeader);
			string s = CommonReportLog.RandomEventLevelZonesReportLog(zones, logHeader);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C13 RID: 97299 RVA: 0x0068A4B0 File Offset: 0x006886B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RandomEventLevelZoneReportLog_s(IntPtr l)
	{
		int result;
		try
		{
			RandomEventLevelZone zone;
			LuaObject.checkType<RandomEventLevelZone>(l, 1, out zone);
			string zoneName;
			LuaObject.checkType(l, 2, out zoneName);
			string s = CommonReportLog.RandomEventLevelZoneReportLog(zone, zoneName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C14 RID: 97300 RVA: 0x0068A510 File Offset: 0x00688710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RandomEventsReportLog_s(IntPtr l)
	{
		int result;
		try
		{
			List<RandomEvent> randomEvents;
			LuaObject.checkType<List<RandomEvent>>(l, 1, out randomEvents);
			string optionType;
			LuaObject.checkType(l, 2, out optionType);
			string s = CommonReportLog.RandomEventsReportLog(randomEvents, optionType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C15 RID: 97301 RVA: 0x0068A570 File Offset: 0x00688770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RandomEventReportLog_s(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 1, out randomEvent);
			string optionType;
			LuaObject.checkType(l, 2, out optionType);
			string s = CommonReportLog.RandomEventReportLog(randomEvent, optionType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C16 RID: 97302 RVA: 0x0068A5D0 File Offset: 0x006887D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IntListReportLog_s(IntPtr l)
	{
		int result;
		try
		{
			List<int> list;
			LuaObject.checkType<List<int>>(l, 1, out list);
			string listName;
			LuaObject.checkType(l, 2, out listName);
			string s = CommonReportLog.IntListReportLog(list, listName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C17 RID: 97303 RVA: 0x0068A630 File Offset: 0x00688830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDictionary_s(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, int> dict;
			LuaObject.checkType<Dictionary<int, int>>(l, 1, out dict);
			string dictName;
			LuaObject.checkType(l, 2, out dictName);
			string s = CommonReportLog.InitDictionary(dict, dictName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C18 RID: 97304 RVA: 0x0068A690 File Offset: 0x00688890
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StringDictionaryReportLog_s(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<string, int> dict;
			LuaObject.checkType<Dictionary<string, int>>(l, 1, out dict);
			string s = CommonReportLog.StringDictionaryReportLog(dict);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C19 RID: 97305 RVA: 0x0068A6E4 File Offset: 0x006888E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WayPointReportLog_s(IntPtr l)
	{
		int result;
		try
		{
			List<ConfigDataWaypointInfo> wayPointInfos;
			LuaObject.checkType<List<ConfigDataWaypointInfo>>(l, 1, out wayPointInfos);
			Dictionary<int, WayPointStatus> wayPointStates;
			LuaObject.checkType<Dictionary<int, WayPointStatus>>(l, 2, out wayPointStates);
			string functionType;
			LuaObject.checkType(l, 3, out functionType);
			string optionType;
			LuaObject.checkType(l, 4, out optionType);
			string selectStandard;
			LuaObject.checkType(l, 5, out selectStandard);
			string s = CommonReportLog.WayPointReportLog(wayPointInfos, wayPointStates, functionType, optionType, selectStandard);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C1A RID: 97306 RVA: 0x0068A76C File Offset: 0x0068896C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleReport_s(IntPtr l)
	{
		int result;
		try
		{
			BattleReportLog report;
			LuaObject.checkType<BattleReportLog>(l, 1, out report);
			string owner;
			LuaObject.checkType(l, 2, out owner);
			string s = CommonReportLog.BattleReport(report, owner);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C1B RID: 97307 RVA: 0x0068A7CC File Offset: 0x006889CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Message_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(List<BattleCommand>), typeof(string)))
			{
				List<BattleCommand> commands;
				LuaObject.checkType<List<BattleCommand>>(l, 1, out commands);
				string ownerName;
				LuaObject.checkType(l, 2, out ownerName);
				string s = CommonReportLog.Message(commands, ownerName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(List<BattleActorSetup>), typeof(string)))
			{
				List<BattleActorSetup> team;
				LuaObject.checkType<List<BattleActorSetup>>(l, 1, out team);
				string teamName;
				LuaObject.checkType(l, 2, out teamName);
				string s2 = CommonReportLog.Message(team, teamName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Message to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C1C RID: 97308 RVA: 0x0068A8C8 File Offset: 0x00688AC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleRoomBattle_s(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog log;
			LuaObject.checkType<BattleRoomBattleLog>(l, 1, out log);
			string owner;
			LuaObject.checkType(l, 2, out owner);
			string s = CommonReportLog.BattleRoomBattle(log, owner);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C1D RID: 97309 RVA: 0x0068A928 File Offset: 0x00688B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoodsListReportLog_s(IntPtr l)
	{
		int result;
		try
		{
			List<Goods> goodsList;
			LuaObject.checkType<List<Goods>>(l, 1, out goodsList);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			string s = CommonReportLog.GoodsListReportLog(goodsList, desc);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C1E RID: 97310 RVA: 0x0068A988 File Offset: 0x00688B88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ProGoodsListReport_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProGoods> pbGoodsList;
			LuaObject.checkType<List<ProGoods>>(l, 1, out pbGoodsList);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			string s = CommonReportLog.ProGoodsListReport(pbGoodsList, desc);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C1F RID: 97311 RVA: 0x0068A9E8 File Offset: 0x00688BE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CommonReportLog");
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.RandomEventLevelZonesReportLog_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.RandomEventLevelZoneReportLog_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.RandomEventsReportLog_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.RandomEventReportLog_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.IntListReportLog_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.InitDictionary_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.StringDictionaryReportLog_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.WayPointReportLog_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.BattleReport_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.Message_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.BattleRoomBattle_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.GoodsListReportLog_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.ProGoodsListReport_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonReportLog.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CommonReportLog.<>f__mg$cacheD, typeof(CommonReportLog));
	}

	// Token: 0x0400E225 RID: 57893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E226 RID: 57894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E227 RID: 57895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E228 RID: 57896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E229 RID: 57897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E22A RID: 57898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E22B RID: 57899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E22C RID: 57900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E22D RID: 57901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E22E RID: 57902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E22F RID: 57903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E230 RID: 57904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E231 RID: 57905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E232 RID: 57906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
