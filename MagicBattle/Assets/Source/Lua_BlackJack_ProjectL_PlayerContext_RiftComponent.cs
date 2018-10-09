using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E1 RID: 4833
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_RiftComponent : LuaObject
{
	// Token: 0x0601A00B RID: 106507 RVA: 0x0079FD54 File Offset: 0x0079DF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent o = new RiftComponent();
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

	// Token: 0x0601A00C RID: 106508 RVA: 0x0079FD9C File Offset: 0x0079DF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			riftComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A00D RID: 106509 RVA: 0x0079FDE8 File Offset: 0x0079DFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			riftComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A00E RID: 106510 RVA: 0x0079FE34 File Offset: 0x0079E034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			riftComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A00F RID: 106511 RVA: 0x0079FE80 File Offset: 0x0079E080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			DSRiftNtf msg;
			LuaObject.checkType<DSRiftNtf>(l, 2, out msg);
			riftComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A010 RID: 106512 RVA: 0x0079FED8 File Offset: 0x0079E0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ushort dsversion = riftComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A011 RID: 106513 RVA: 0x0079FF2C File Offset: 0x0079E12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GainChapterReward(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			int i = riftComponent.GainChapterReward(chapterId, index);
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

	// Token: 0x0601A012 RID: 106514 RVA: 0x0079FF9C File Offset: 0x0079E19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			List<int> newAchievementIds;
			LuaObject.checkType<List<int>>(l, 3, out newAchievementIds);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			riftComponent.SetSuccessRiftLevel(riftLevelInfo, newAchievementIds, stars, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A013 RID: 106515 RVA: 0x007A001C File Offset: 0x0079E21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompleteAchievement(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int achievementRelationId;
			LuaObject.checkType(l, 2, out achievementRelationId);
			riftComponent.CompleteAchievement(achievementRelationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A014 RID: 106516 RVA: 0x007A0074 File Offset: 0x0079E274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUnlockChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int i = riftComponent.CanUnlockChapter(chapterId);
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

	// Token: 0x0601A015 RID: 106517 RVA: 0x007A00D8 File Offset: 0x0079E2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRiftLevelChallengeNum(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int riftLevelChallengeNum = riftComponent.GetRiftLevelChallengeNum(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelChallengeNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A016 RID: 106518 RVA: 0x007A013C File Offset: 0x0079E33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRiftLevelCanChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			int riftLevelCanChallengeNums = riftComponent.GetRiftLevelCanChallengeNums(levelInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelCanChallengeNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A017 RID: 106519 RVA: 0x007A01A0 File Offset: 0x0079E3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int riftlevelId;
			LuaObject.checkType(l, 2, out riftlevelId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			int i = riftComponent.RaidRiftLevel(riftlevelId, nums);
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

	// Token: 0x0601A018 RID: 106520 RVA: 0x007A0210 File Offset: 0x0079E410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRiftLevelChallenged(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = riftComponent.IsRiftLevelChallenged(levelId);
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

	// Token: 0x0601A019 RID: 106521 RVA: 0x007A0274 File Offset: 0x0079E474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRiftLevelStars(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int riftLevelStars = riftComponent.GetRiftLevelStars(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelStars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A01A RID: 106522 RVA: 0x007A02D8 File Offset: 0x0079E4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishBattleRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int riftLevelId;
			LuaObject.checkType(l, 2, out riftLevelId);
			List<int> gotAchievementIds;
			LuaObject.checkType<List<int>>(l, 3, out gotAchievementIds);
			int star;
			LuaObject.checkType(l, 4, out star);
			List<int> battleTreasureIds;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasureIds);
			int i = riftComponent.FinishBattleRiftLevel(riftLevelId, gotAchievementIds, star, battleTreasureIds);
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

	// Token: 0x0601A01B RID: 106523 RVA: 0x007A0360 File Offset: 0x0079E560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGainChapterStarReward(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			int i = riftComponent.CanGainChapterStarReward(chapterId, index);
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

	// Token: 0x0601A01C RID: 106524 RVA: 0x007A03D0 File Offset: 0x0079E5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRiftChapterUnlockConditionCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			RiftChapterUnlockConditionType condition;
			LuaObject.checkEnum<RiftChapterUnlockConditionType>(l, 3, out condition);
			int param;
			LuaObject.checkType(l, 4, out param);
			bool b = riftComponent.IsRiftChapterUnlockConditionCompleted(chapterId, condition, param);
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

	// Token: 0x0601A01D RID: 106525 RVA: 0x007A044C File Offset: 0x0079E64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRiftLevelUnlockConditionCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			RiftLevelUnlockConditionType condition;
			LuaObject.checkEnum<RiftLevelUnlockConditionType>(l, 3, out condition);
			int param;
			LuaObject.checkType(l, 4, out param);
			bool b = riftComponent.IsRiftLevelUnlockConditionCompleted(levelId, condition, param);
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

	// Token: 0x0601A01E RID: 106526 RVA: 0x007A04C8 File Offset: 0x0079E6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitChapterInfos(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			List<ProRiftChapter> proChapters;
			LuaObject.checkType<List<ProRiftChapter>>(l, 2, out proChapters);
			riftComponent.m_luaExportHelper.InitChapterInfos(proChapters);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A01F RID: 106527 RVA: 0x007A0524 File Offset: 0x0079E724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComplteRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int riftLevelId;
			LuaObject.checkType(l, 2, out riftLevelId);
			riftComponent.m_luaExportHelper.ComplteRiftLevel(riftLevelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A020 RID: 106528 RVA: 0x007A0580 File Offset: 0x0079E780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			string s = riftComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601A021 RID: 106529 RVA: 0x007A05DC File Offset: 0x0079E7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			riftComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A022 RID: 106530 RVA: 0x007A0630 File Offset: 0x0079E830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			riftComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A023 RID: 106531 RVA: 0x007A0684 File Offset: 0x0079E884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			riftComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A024 RID: 106532 RVA: 0x007A06D8 File Offset: 0x0079E8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			riftComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A025 RID: 106533 RVA: 0x007A0734 File Offset: 0x0079E934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			riftComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A026 RID: 106534 RVA: 0x007A0788 File Offset: 0x0079E988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			int num;
			LuaObject.checkType(l, 3, out num);
			riftComponent.m_luaExportHelper.__callBase_AddChallengeNums(levelInfo, num);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A027 RID: 106535 RVA: 0x007A07F4 File Offset: 0x0079E9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ResetLevelChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			riftComponent.m_luaExportHelper.__callBase_ResetLevelChallengeNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A028 RID: 106536 RVA: 0x007A0848 File Offset: 0x0079EA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllRiftLevelAchievements(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			HashSet<int> o = riftComponent.m_luaExportHelper.__callBase_GetAllRiftLevelAchievements();
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

	// Token: 0x0601A029 RID: 106537 RVA: 0x007A08A4 File Offset: 0x0079EAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = riftComponent.m_luaExportHelper.__callBase_AttackLevel(levelId);
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

	// Token: 0x0601A02A RID: 106538 RVA: 0x007A090C File Offset: 0x0079EB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			int stars;
			LuaObject.checkType(l, 5, out stars);
			bool needAddStar;
			LuaObject.checkType(l, 6, out needAddStar);
			riftComponent.m_luaExportHelper.__callBase_SetLevel(chapterId, levelId, nums, stars, needAddStar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A02B RID: 106539 RVA: 0x007A099C File Offset: 0x0079EB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = riftComponent.m_luaExportHelper.__callBase_CanAttackLevel(levelId);
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

	// Token: 0x0601A02C RID: 106540 RVA: 0x007A0A04 File Offset: 0x0079EC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsFirstPassLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = riftComponent.m_luaExportHelper.__callBase_IsFirstPassLevel(levelId);
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

	// Token: 0x0601A02D RID: 106541 RVA: 0x007A0A6C File Offset: 0x0079EC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = riftComponent.m_luaExportHelper.__callBase_IsLevelFinished(levelId);
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

	// Token: 0x0601A02E RID: 106542 RVA: 0x007A0AD4 File Offset: 0x0079ECD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAddRandomDropRewardExpectedSize(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int randomDropId;
			LuaObject.checkType(l, 2, out randomDropId);
			int i = riftComponent.m_luaExportHelper.__callBase_GetAddRandomDropRewardExpectedSize(randomDropId);
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

	// Token: 0x0601A02F RID: 106543 RVA: 0x007A0B3C File Offset: 0x0079ED3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanUnLockLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int riftLevelId;
			LuaObject.checkType(l, 2, out riftLevelId);
			int i = riftComponent.m_luaExportHelper.__callBase_CanUnLockLevel(riftLevelId);
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

	// Token: 0x0601A030 RID: 106544 RVA: 0x007A0BA4 File Offset: 0x0079EDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRiftLevelCanChallengeMaxNums(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			int i = riftComponent.m_luaExportHelper.__callBase_GetRiftLevelCanChallengeMaxNums(levelInfo);
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

	// Token: 0x0601A031 RID: 106545 RVA: 0x007A0C0C File Offset: 0x0079EE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanRaidLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			int i = riftComponent.m_luaExportHelper.__callBase_CanRaidLevel(levelInfo);
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

	// Token: 0x0601A032 RID: 106546 RVA: 0x007A0C74 File Offset: 0x0079EE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CompleteAchievement(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int achievementRelationId;
			LuaObject.checkType(l, 2, out achievementRelationId);
			riftComponent.m_luaExportHelper.__callBase_CompleteAchievement(achievementRelationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A033 RID: 106547 RVA: 0x007A0CD0 File Offset: 0x0079EED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddRiftLevelBasicRewards(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			bool isRaid;
			LuaObject.checkType(l, 3, out isRaid);
			riftComponent.m_luaExportHelper.__callBase_AddRiftLevelBasicRewards(riftLevelInfo, isRaid);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A034 RID: 106548 RVA: 0x007A0D3C File Offset: 0x0079EF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetSuccessRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			List<int> newAchievementIds;
			LuaObject.checkType<List<int>>(l, 3, out newAchievementIds);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			riftComponent.m_luaExportHelper.__callBase_SetSuccessRiftLevel(riftLevelInfo, newAchievementIds, stars, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A035 RID: 106549 RVA: 0x007A0DC0 File Offset: 0x0079EFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetRaidSuccessRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out levelInfo);
			riftComponent.m_luaExportHelper.__callBase_SetRaidSuccessRiftLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A036 RID: 106550 RVA: 0x007A0E1C File Offset: 0x0079F01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasGotAchievementRelationId(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int achievementId;
			LuaObject.checkType(l, 2, out achievementId);
			bool b = riftComponent.m_luaExportHelper.__callBase_HasGotAchievementRelationId(achievementId);
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

	// Token: 0x0601A037 RID: 106551 RVA: 0x007A0E84 File Offset: 0x0079F084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetChapterRewards(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			int index;
			LuaObject.checkType(l, 3, out index);
			List<Goods> o = riftComponent.m_luaExportHelper.__callBase_GetChapterRewards(chapterInfo, index);
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

	// Token: 0x0601A038 RID: 106552 RVA: 0x007A0EF8 File Offset: 0x0079F0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGainChapterReward(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			int index;
			LuaObject.checkType(l, 3, out index);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 4, out rewards);
			int i = riftComponent.m_luaExportHelper.__callBase_CanGainChapterReward(chapterInfo, index, rewards);
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

	// Token: 0x0601A039 RID: 106553 RVA: 0x007A0F7C File Offset: 0x0079F17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetChapterTotalStars(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int i = riftComponent.m_luaExportHelper.__callBase_GetChapterTotalStars(chapterId);
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

	// Token: 0x0601A03A RID: 106554 RVA: 0x007A0FE4 File Offset: 0x0079F1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllRiftLevelStars(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int i = riftComponent.m_luaExportHelper.__callBase_GetAllRiftLevelStars();
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

	// Token: 0x0601A03B RID: 106555 RVA: 0x007A1040 File Offset: 0x0079F240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ComplteRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int riftLevelId;
			LuaObject.checkType(l, 2, out riftLevelId);
			riftComponent.m_luaExportHelper.__callBase_ComplteRiftLevel(riftLevelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A03C RID: 106556 RVA: 0x007A109C File Offset: 0x0079F29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnAllRiftLevelStarAdd(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int addStar;
			LuaObject.checkType(l, 2, out addStar);
			riftComponent.m_luaExportHelper.__callBase_OnAllRiftLevelStarAdd(addStar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A03D RID: 106557 RVA: 0x007A10F8 File Offset: 0x0079F2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnRiftAchivementAdd(IntPtr l)
	{
		int result;
		try
		{
			RiftComponent riftComponent = (RiftComponent)LuaObject.checkSelf(l);
			int addAchivement;
			LuaObject.checkType(l, 2, out addAchivement);
			riftComponent.m_luaExportHelper.__callBase_OnRiftAchivementAdd(addAchivement);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A03E RID: 106558 RVA: 0x007A1154 File Offset: 0x0079F354
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.RiftComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.GainChapterReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.SetSuccessRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.CompleteAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.CanUnlockChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.GetRiftLevelChallengeNum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.GetRiftLevelCanChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.RaidRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.IsRiftLevelChallenged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.GetRiftLevelStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.FinishBattleRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.CanGainChapterStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.IsRiftChapterUnlockConditionCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.IsRiftLevelUnlockConditionCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.InitChapterInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.ComplteRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_AddChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_ResetLevelChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_GetAllRiftLevelAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_AttackLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_SetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_CanAttackLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_IsFirstPassLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_GetAddRandomDropRewardExpectedSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_CanUnLockLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_GetRiftLevelCanChallengeMaxNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_CanRaidLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_CompleteAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_AddRiftLevelBasicRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_SetSuccessRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_SetRaidSuccessRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_HasGotAchievementRelationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_GetChapterRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_CanGainChapterReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_GetChapterTotalStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_GetAllRiftLevelStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_ComplteRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_OnAllRiftLevelStarAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.__callBase_OnRiftAchivementAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.<>f__mg$cache32, typeof(RiftComponent), typeof(RiftComponentCommon));
	}

	// Token: 0x0401042B RID: 66603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401042C RID: 66604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401042D RID: 66605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401042E RID: 66606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401042F RID: 66607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010430 RID: 66608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010431 RID: 66609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010432 RID: 66610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010433 RID: 66611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010434 RID: 66612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010435 RID: 66613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010436 RID: 66614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010437 RID: 66615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010438 RID: 66616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010439 RID: 66617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401043A RID: 66618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401043B RID: 66619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401043C RID: 66620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401043D RID: 66621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401043E RID: 66622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401043F RID: 66623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010440 RID: 66624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010441 RID: 66625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010442 RID: 66626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010443 RID: 66627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010444 RID: 66628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010445 RID: 66629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010446 RID: 66630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010447 RID: 66631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010448 RID: 66632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010449 RID: 66633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401044A RID: 66634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401044B RID: 66635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401044C RID: 66636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401044D RID: 66637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401044E RID: 66638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401044F RID: 66639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010450 RID: 66640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010451 RID: 66641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010452 RID: 66642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010453 RID: 66643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010454 RID: 66644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010455 RID: 66645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010456 RID: 66646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010457 RID: 66647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010458 RID: 66648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010459 RID: 66649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401045A RID: 66650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401045B RID: 66651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401045C RID: 66652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401045D RID: 66653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
