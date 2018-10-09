using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C9 RID: 4809
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_Happening : LuaObject
{
	// Token: 0x060194EF RID: 103663 RVA: 0x00742760 File Offset: 0x00740960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Happening o = new Happening();
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

	// Token: 0x060194F0 RID: 103664 RVA: 0x007427A8 File Offset: 0x007409A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBattleAndDialog(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 3, out battleInfo);
			int monsterLevel;
			LuaObject.checkType(l, 4, out monsterLevel);
			ConfigDataDialogInfo dialogBefore;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 5, out dialogBefore);
			ConfigDataDialogInfo dialogAfter;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 6, out dialogAfter);
			happening.InitBattleAndDialog(battleType, battleInfo, monsterLevel, dialogBefore, dialogAfter);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194F1 RID: 103665 RVA: 0x00742834 File Offset: 0x00740A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextStep(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			happening.NextStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194F2 RID: 103666 RVA: 0x00742880 File Offset: 0x00740A80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			happening.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194F3 RID: 103667 RVA: 0x007428CC File Offset: 0x00740ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGameFunctionTypeAndLocationId(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			int i;
			bool gameFunctionTypeAndLocationId = happening.GetGameFunctionTypeAndLocationId(out gameFunctionType, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameFunctionTypeAndLocationId);
			LuaObject.pushValue(l, gameFunctionType);
			LuaObject.pushValue(l, i);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194F4 RID: 103668 RVA: 0x0074293C File Offset: 0x00740B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetStrategy(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			string strategy = happening.GetStrategy();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194F5 RID: 103669 RVA: 0x00742990 File Offset: 0x00740B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStarCondition(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			int i;
			int i2;
			bool starCondition = happening.GetStarCondition(out i, out i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, starCondition);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194F6 RID: 103670 RVA: 0x007429FC File Offset: 0x00740BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleLevelAchievements(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			BattleLevelAchievement[] battleLevelAchievements = happening.GetBattleLevelAchievements();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelAchievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194F7 RID: 103671 RVA: 0x00742A50 File Offset: 0x00740C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelInfoNull(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			bool b = happening.m_luaExportHelper.IsLevelInfoNull();
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

	// Token: 0x060194F8 RID: 103672 RVA: 0x00742AAC File Offset: 0x00740CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Step(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)happening.Step);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194F9 RID: 103673 RVA: 0x00742B00 File Offset: 0x00740D00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Step(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			HappeningStep step;
			LuaObject.checkEnum<HappeningStep>(l, 2, out step);
			happening.Step = step;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194FA RID: 103674 RVA: 0x00742B58 File Offset: 0x00740D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.ScenarioInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194FB RID: 103675 RVA: 0x00742BAC File Offset: 0x00740DAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			happening.ScenarioInfo = scenarioInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194FC RID: 103676 RVA: 0x00742C04 File Offset: 0x00740E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.EventInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194FD RID: 103677 RVA: 0x00742C58 File Offset: 0x00740E58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			happening.EventInfo = eventInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194FE RID: 103678 RVA: 0x00742CB0 File Offset: 0x00740EB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RiftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.RiftLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194FF RID: 103679 RVA: 0x00742D04 File Offset: 0x00740F04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RiftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			happening.RiftLevelInfo = riftLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019500 RID: 103680 RVA: 0x00742D5C File Offset: 0x00740F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroDungeonLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.HeroDungeonLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019501 RID: 103681 RVA: 0x00742DB0 File Offset: 0x00740FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroDungeonLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out heroDungeonLevelInfo);
			happening.HeroDungeonLevelInfo = heroDungeonLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019502 RID: 103682 RVA: 0x00742E08 File Offset: 0x00741008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroPhantomLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.HeroPhantomLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019503 RID: 103683 RVA: 0x00742E5C File Offset: 0x0074105C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroPhantomLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out heroPhantomLevelInfo);
			happening.HeroPhantomLevelInfo = heroPhantomLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019504 RID: 103684 RVA: 0x00742EB4 File Offset: 0x007410B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AnikiLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.AnikiLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019505 RID: 103685 RVA: 0x00742F08 File Offset: 0x00741108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AnikiLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo anikiLevelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out anikiLevelInfo);
			happening.AnikiLevelInfo = anikiLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019506 RID: 103686 RVA: 0x00742F60 File Offset: 0x00741160
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ThearchyLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.ThearchyLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019507 RID: 103687 RVA: 0x00742FB4 File Offset: 0x007411B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThearchyLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo thearchyLevelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out thearchyLevelInfo);
			happening.ThearchyLevelInfo = thearchyLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019508 RID: 103688 RVA: 0x0074300C File Offset: 0x0074120C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TreasureLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.TreasureLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019509 RID: 103689 RVA: 0x00743060 File Offset: 0x00741260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TreasureLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo treasureLevelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out treasureLevelInfo);
			happening.TreasureLevelInfo = treasureLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601950A RID: 103690 RVA: 0x007430B8 File Offset: 0x007412B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MemoryCorridorLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.MemoryCorridorLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601950B RID: 103691 RVA: 0x0074310C File Offset: 0x0074130C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MemoryCorridorLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo memoryCorridorLevelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out memoryCorridorLevelInfo);
			happening.MemoryCorridorLevelInfo = memoryCorridorLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601950C RID: 103692 RVA: 0x00743164 File Offset: 0x00741364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroTrainningLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.HeroTrainningLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601950D RID: 103693 RVA: 0x007431B8 File Offset: 0x007413B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroTrainningLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo heroTrainningLevelInfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out heroTrainningLevelInfo);
			happening.HeroTrainningLevelInfo = heroTrainningLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601950E RID: 103694 RVA: 0x00743210 File Offset: 0x00741410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CooperateBattleLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.CooperateBattleLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601950F RID: 103695 RVA: 0x00743264 File Offset: 0x00741464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CooperateBattleLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo cooperateBattleLevelInfo;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out cooperateBattleLevelInfo);
			happening.CooperateBattleLevelInfo = cooperateBattleLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019510 RID: 103696 RVA: 0x007432BC File Offset: 0x007414BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ScoreLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.ScoreLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019511 RID: 103697 RVA: 0x00743310 File Offset: 0x00741510
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ScoreLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo scoreLevelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out scoreLevelInfo);
			happening.ScoreLevelInfo = scoreLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019512 RID: 103698 RVA: 0x00743368 File Offset: 0x00741568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChallengeLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.ChallengeLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019513 RID: 103699 RVA: 0x007433BC File Offset: 0x007415BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChallengeLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo challengeLevelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out challengeLevelInfo);
			happening.ChallengeLevelInfo = challengeLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019514 RID: 103700 RVA: 0x00743414 File Offset: 0x00741614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TowerFloorInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.TowerFloorInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019515 RID: 103701 RVA: 0x00743468 File Offset: 0x00741668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TowerFloorInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo towerFloorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out towerFloorInfo);
			happening.TowerFloorInfo = towerFloorInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019516 RID: 103702 RVA: 0x007434C0 File Offset: 0x007416C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildMassiveCombatLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.GuildMassiveCombatLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019517 RID: 103703 RVA: 0x00743514 File Offset: 0x00741714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuildMassiveCombatLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatLevelInfo guildMassiveCombatLevelInfo;
			LuaObject.checkType<ConfigDataGuildMassiveCombatLevelInfo>(l, 2, out guildMassiveCombatLevelInfo);
			happening.GuildMassiveCombatLevelInfo = guildMassiveCombatLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019518 RID: 103704 RVA: 0x0074356C File Offset: 0x0074176C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.WaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019519 RID: 103705 RVA: 0x007435C0 File Offset: 0x007417C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			happening.WaypointInfo = waypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601951A RID: 103706 RVA: 0x00743618 File Offset: 0x00741818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PrevWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.PrevWaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601951B RID: 103707 RVA: 0x0074366C File Offset: 0x0074186C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PrevWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo prevWaypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out prevWaypointInfo);
			happening.PrevWaypointInfo = prevWaypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601951C RID: 103708 RVA: 0x007436C4 File Offset: 0x007418C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.DialogInfoBefore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601951D RID: 103709 RVA: 0x00743718 File Offset: 0x00741918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoBefore;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoBefore);
			happening.DialogInfoBefore = dialogInfoBefore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601951E RID: 103710 RVA: 0x00743770 File Offset: 0x00741970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.DialogInfoAfter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601951F RID: 103711 RVA: 0x007437C4 File Offset: 0x007419C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoAfter;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoAfter);
			happening.DialogInfoAfter = dialogInfoAfter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019520 RID: 103712 RVA: 0x0074381C File Offset: 0x00741A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.BattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019521 RID: 103713 RVA: 0x00743870 File Offset: 0x00741A70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			happening.BattleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019522 RID: 103714 RVA: 0x007438C8 File Offset: 0x00741AC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, happening.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019523 RID: 103715 RVA: 0x0074391C File Offset: 0x00741B1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			happening.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019524 RID: 103716 RVA: 0x00743974 File Offset: 0x00741B74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleType(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)happening.BattleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019525 RID: 103717 RVA: 0x007439C8 File Offset: 0x00741BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleType(IntPtr l)
	{
		int result;
		try
		{
			Happening happening = (Happening)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			happening.BattleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019526 RID: 103718 RVA: 0x00743A20 File Offset: 0x00741C20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.Happening");
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.InitBattleAndDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.NextStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.GetGameFunctionTypeAndLocationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.GetStrategy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.GetStarCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.GetBattleLevelAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.IsLevelInfoNull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache7);
		string name = "Step";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_Step);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_Step);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache9, true);
		string name2 = "ScenarioInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_ScenarioInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_ScenarioInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheB, true);
		string name3 = "EventInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_EventInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_EventInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheD, true);
		string name4 = "RiftLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_RiftLevelInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_RiftLevelInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cacheF, true);
		string name5 = "HeroDungeonLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_HeroDungeonLevelInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_HeroDungeonLevelInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache11, true);
		string name6 = "HeroPhantomLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_HeroPhantomLevelInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_HeroPhantomLevelInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache13, true);
		string name7 = "AnikiLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_AnikiLevelInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_AnikiLevelInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache15, true);
		string name8 = "ThearchyLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_ThearchyLevelInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_ThearchyLevelInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache17, true);
		string name9 = "TreasureLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_TreasureLevelInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_TreasureLevelInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache19, true);
		string name10 = "MemoryCorridorLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_MemoryCorridorLevelInfo);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_MemoryCorridorLevelInfo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1B, true);
		string name11 = "HeroTrainningLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_HeroTrainningLevelInfo);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_HeroTrainningLevelInfo);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1D, true);
		string name12 = "CooperateBattleLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_CooperateBattleLevelInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_CooperateBattleLevelInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache1F, true);
		string name13 = "ScoreLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_ScoreLevelInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_ScoreLevelInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache21, true);
		string name14 = "ChallengeLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_ChallengeLevelInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_ChallengeLevelInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache23, true);
		string name15 = "TowerFloorInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_TowerFloorInfo);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_TowerFloorInfo);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache25, true);
		string name16 = "GuildMassiveCombatLevelInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_GuildMassiveCombatLevelInfo);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_GuildMassiveCombatLevelInfo);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache27, true);
		string name17 = "WaypointInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_WaypointInfo);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_WaypointInfo);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache29, true);
		string name18 = "PrevWaypointInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_PrevWaypointInfo);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_PrevWaypointInfo);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2B, true);
		string name19 = "DialogInfoBefore";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_DialogInfoBefore);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_DialogInfoBefore);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2D, true);
		string name20 = "DialogInfoAfter";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_DialogInfoAfter);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_DialogInfoAfter);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache2F, true);
		string name21 = "BattleInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_BattleInfo);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_BattleInfo);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache31, true);
		string name22 = "MonsterLevel";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_MonsterLevel);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_MonsterLevel);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache33, true);
		string name23 = "BattleType";
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.get_BattleType);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.set_BattleType);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache35, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_Happening.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_Happening.<>f__mg$cache36, typeof(Happening));
	}

	// Token: 0x0400F93F RID: 63807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F940 RID: 63808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F941 RID: 63809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F942 RID: 63810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F943 RID: 63811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F944 RID: 63812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F945 RID: 63813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F946 RID: 63814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F947 RID: 63815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F948 RID: 63816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F949 RID: 63817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F94A RID: 63818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F94B RID: 63819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F94C RID: 63820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F94D RID: 63821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F94E RID: 63822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F94F RID: 63823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F950 RID: 63824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F951 RID: 63825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F952 RID: 63826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F953 RID: 63827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F954 RID: 63828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F955 RID: 63829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F956 RID: 63830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F957 RID: 63831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F958 RID: 63832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F959 RID: 63833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F95A RID: 63834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F95B RID: 63835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F95C RID: 63836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F95D RID: 63837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F95E RID: 63838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F95F RID: 63839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F960 RID: 63840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F961 RID: 63841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F962 RID: 63842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F963 RID: 63843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F964 RID: 63844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F965 RID: 63845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F966 RID: 63846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F967 RID: 63847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F968 RID: 63848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F969 RID: 63849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F96A RID: 63850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F96B RID: 63851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F96C RID: 63852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F96D RID: 63853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F96E RID: 63854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F96F RID: 63855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F970 RID: 63856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F971 RID: 63857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F972 RID: 63858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F973 RID: 63859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F974 RID: 63860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F975 RID: 63861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
