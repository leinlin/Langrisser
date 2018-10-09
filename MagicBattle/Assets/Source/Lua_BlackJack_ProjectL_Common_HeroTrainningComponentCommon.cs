using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001247 RID: 4679
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon : LuaObject
{
	// Token: 0x06018510 RID: 99600 RVA: 0x006CC8CC File Offset: 0x006CAACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon o = new HeroTrainningComponentCommon();
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

	// Token: 0x06018511 RID: 99601 RVA: 0x006CC914 File Offset: 0x006CAB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			string name = heroTrainningComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018512 RID: 99602 RVA: 0x006CC968 File Offset: 0x006CAB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			heroTrainningComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018513 RID: 99603 RVA: 0x006CC9B4 File Offset: 0x006CABB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			heroTrainningComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018514 RID: 99604 RVA: 0x006CCA00 File Offset: 0x006CAC00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			heroTrainningComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018515 RID: 99605 RVA: 0x006CCA4C File Offset: 0x006CAC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroTrainningComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018516 RID: 99606 RVA: 0x006CCAA4 File Offset: 0x006CACA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			heroTrainningComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018517 RID: 99607 RVA: 0x006CCAF0 File Offset: 0x006CACF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroTrainningComponentCommon.AttackHeroTrainningLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018518 RID: 99608 RVA: 0x006CCB54 File Offset: 0x006CAD54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = heroTrainningComponentCommon.CanAttackHeroTrainningLevel(levelId, isTeamBattle);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018519 RID: 99609 RVA: 0x006CCBC4 File Offset: 0x006CADC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroTrainningComponentCommon.IsLevelFinished(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601851A RID: 99610 RVA: 0x006CCC28 File Offset: 0x006CAE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = heroTrainningComponentCommon.GetAllFinishedLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allFinishedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601851B RID: 99611 RVA: 0x006CCC7C File Offset: 0x006CAE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDailyChallenge(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			bool b = heroTrainningComponentCommon.IsDailyChallenge();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601851C RID: 99612 RVA: 0x006CCCD0 File Offset: 0x006CAED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDailyChallengNums(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			int dailyChallengNums = heroTrainningComponentCommon.GetDailyChallengNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dailyChallengNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601851D RID: 99613 RVA: 0x006CCD24 File Offset: 0x006CAF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			List<int> allUnlockedLevels = heroTrainningComponentCommon.GetAllUnlockedLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allUnlockedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601851E RID: 99614 RVA: 0x006CCD78 File Offset: 0x006CAF78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroTrainningComponentCommon.IsLevelUnlocked(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601851F RID: 99615 RVA: 0x006CCDDC File Offset: 0x006CAFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			bool b = heroTrainningComponentCommon.m_luaExportHelper.IsGameFunctionOpened();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018520 RID: 99616 RVA: 0x006CCE38 File Offset: 0x006CB038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanOpenLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroTrainningComponentCommon.m_luaExportHelper.CanOpenLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018521 RID: 99617 RVA: 0x006CCEA0 File Offset: 0x006CB0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out levelInfo);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = heroTrainningComponentCommon.m_luaExportHelper.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018522 RID: 99618 RVA: 0x006CCF14 File Offset: 0x006CB114
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCommonSuccessHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 6, out isBattleTeam);
			heroTrainningComponentCommon.m_luaExportHelper.SetCommonSuccessHeroTrainningLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018523 RID: 99619 RVA: 0x006CCFA4 File Offset: 0x006CB1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushChallengNums(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			heroTrainningComponentCommon.m_luaExportHelper.FlushChallengNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018524 RID: 99620 RVA: 0x006CCFF8 File Offset: 0x006CB1F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			heroTrainningComponentCommon.m_luaExportHelper.AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018525 RID: 99621 RVA: 0x006CD054 File Offset: 0x006CB254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_CompleteHeroTrainningMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			heroTrainningComponentCommon.m_luaExportHelper.__callDele_CompleteHeroTrainningMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018526 RID: 99622 RVA: 0x006CD0CC File Offset: 0x006CB2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_CompleteHeroTrainningMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			heroTrainningComponentCommon.m_luaExportHelper.__clearDele_CompleteHeroTrainningMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018527 RID: 99623 RVA: 0x006CD144 File Offset: 0x006CB344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018528 RID: 99624 RVA: 0x006CD19C File Offset: 0x006CB39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroTrainningComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018529 RID: 99625 RVA: 0x006CD1F8 File Offset: 0x006CB3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTrainningDS(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.m_luaExportHelper.m_heroTrainningDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601852A RID: 99626 RVA: 0x006CD250 File Offset: 0x006CB450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTrainningDS(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			DataSectionHeroTrainning heroTrainningDS;
			LuaObject.checkType<DataSectionHeroTrainning>(l, 2, out heroTrainningDS);
			heroTrainningComponentCommon.m_luaExportHelper.m_heroTrainningDS = heroTrainningDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601852B RID: 99627 RVA: 0x006CD2AC File Offset: 0x006CB4AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601852C RID: 99628 RVA: 0x006CD304 File Offset: 0x006CB504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			heroTrainningComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601852D RID: 99629 RVA: 0x006CD360 File Offset: 0x006CB560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601852E RID: 99630 RVA: 0x006CD3B8 File Offset: 0x006CB5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			heroTrainningComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601852F RID: 99631 RVA: 0x006CD414 File Offset: 0x006CB614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018530 RID: 99632 RVA: 0x006CD46C File Offset: 0x006CB66C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			heroTrainningComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018531 RID: 99633 RVA: 0x006CD4C8 File Offset: 0x006CB6C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018532 RID: 99634 RVA: 0x006CD520 File Offset: 0x006CB720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			heroTrainningComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018533 RID: 99635 RVA: 0x006CD57C File Offset: 0x006CB77C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018534 RID: 99636 RVA: 0x006CD5D4 File Offset: 0x006CB7D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			heroTrainningComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018535 RID: 99637 RVA: 0x006CD630 File Offset: 0x006CB830
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CompleteHeroTrainningMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroTrainningComponentCommon.CompleteHeroTrainningMissionEvent += value;
				}
				else if (num == 2)
				{
					heroTrainningComponentCommon.CompleteHeroTrainningMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018536 RID: 99638 RVA: 0x006CD6B0 File Offset: 0x006CB8B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018537 RID: 99639 RVA: 0x006CD704 File Offset: 0x006CB904
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			heroTrainningComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018538 RID: 99640 RVA: 0x006CD75C File Offset: 0x006CB95C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningComponentCommon.HasRewardAddRelativeOperationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018539 RID: 99641 RVA: 0x006CD7B0 File Offset: 0x006CB9B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HasRewardAddRelativeOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponentCommon heroTrainningComponentCommon = (HeroTrainningComponentCommon)LuaObject.checkSelf(l);
			bool hasRewardAddRelativeOperationalActivity;
			LuaObject.checkType(l, 2, out hasRewardAddRelativeOperationalActivity);
			heroTrainningComponentCommon.HasRewardAddRelativeOperationalActivity = hasRewardAddRelativeOperationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601853A RID: 99642 RVA: 0x006CD808 File Offset: 0x006CBA08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroTrainningComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.AttackHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.CanAttackHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.IsDailyChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.GetDailyChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.CanOpenLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.SetCommonSuccessHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.FlushChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.__callDele_CompleteHeroTrainningMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.__clearDele_CompleteHeroTrainningMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache15);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache17, true);
		string name2 = "m_heroTrainningDS";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_m_heroTrainningDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_m_heroTrainningDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache19, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1B, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1D, true);
		string name5 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_m_rift);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache1F, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache21, true);
		string name7 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_m_bag);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache23, true);
		string name8 = "CompleteHeroTrainningMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_CompleteHeroTrainningMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache24, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache26, true);
		string name10 = "HasRewardAddRelativeOperationalActivity";
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.get_HasRewardAddRelativeOperationalActivity);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.set_HasRewardAddRelativeOperationalActivity);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache28, true);
		if (Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.<>f__mg$cache29, typeof(HeroTrainningComponentCommon));
	}

	// Token: 0x0400EA64 RID: 60004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EA65 RID: 60005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EA66 RID: 60006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EA67 RID: 60007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EA68 RID: 60008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EA69 RID: 60009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EA6A RID: 60010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EA6B RID: 60011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EA6C RID: 60012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EA6D RID: 60013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EA6E RID: 60014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EA6F RID: 60015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EA70 RID: 60016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EA71 RID: 60017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EA72 RID: 60018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EA73 RID: 60019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EA74 RID: 60020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EA75 RID: 60021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EA76 RID: 60022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EA77 RID: 60023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EA78 RID: 60024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EA79 RID: 60025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EA7A RID: 60026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EA7B RID: 60027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EA7C RID: 60028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EA7D RID: 60029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EA7E RID: 60030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EA7F RID: 60031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EA80 RID: 60032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EA81 RID: 60033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EA82 RID: 60034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EA83 RID: 60035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EA84 RID: 60036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EA85 RID: 60037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EA86 RID: 60038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EA87 RID: 60039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EA88 RID: 60040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EA89 RID: 60041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EA8A RID: 60042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EA8B RID: 60043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EA8C RID: 60044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EA8D RID: 60045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
