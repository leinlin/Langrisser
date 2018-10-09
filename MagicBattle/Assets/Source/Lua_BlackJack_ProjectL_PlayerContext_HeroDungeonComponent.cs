using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012CC RID: 4812
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent : LuaObject
{
	// Token: 0x060195D5 RID: 103893 RVA: 0x0074A0A4 File Offset: 0x007482A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent o = new HeroDungeonComponent();
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

	// Token: 0x060195D6 RID: 103894 RVA: 0x0074A0EC File Offset: 0x007482EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			heroDungeonComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195D7 RID: 103895 RVA: 0x0074A138 File Offset: 0x00748338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			heroDungeonComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195D8 RID: 103896 RVA: 0x0074A184 File Offset: 0x00748384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			heroDungeonComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195D9 RID: 103897 RVA: 0x0074A1D0 File Offset: 0x007483D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			DSHeroDungeonNtf ntf;
			LuaObject.checkType<DSHeroDungeonNtf>(l, 2, out ntf);
			heroDungeonComponent.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195DA RID: 103898 RVA: 0x0074A228 File Offset: 0x00748428
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FinishBattleHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			List<int> gotAchievementIds;
			LuaObject.checkType<List<int>>(l, 3, out gotAchievementIds);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			int i = heroDungeonComponent.FinishBattleHeroDungeonLevel(levelId, gotAchievementIds, stars, battleTreasures);
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

	// Token: 0x060195DB RID: 103899 RVA: 0x0074A2B0 File Offset: 0x007484B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int leveld;
			LuaObject.checkType(l, 2, out leveld);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			int i = heroDungeonComponent.RaidHeroDungeonLevel(leveld, nums);
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

	// Token: 0x060195DC RID: 103900 RVA: 0x0074A320 File Offset: 0x00748520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelChallenged(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroDungeonComponent.IsLevelChallenged(levelId);
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

	// Token: 0x060195DD RID: 103901 RVA: 0x0074A384 File Offset: 0x00748584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			ushort dsversion = heroDungeonComponent.GetDSVersion();
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

	// Token: 0x060195DE RID: 103902 RVA: 0x0074A3D8 File Offset: 0x007485D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitChapters(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			List<ProHeroDungeonChapter> pbChapters;
			LuaObject.checkType<List<ProHeroDungeonChapter>>(l, 2, out pbChapters);
			heroDungeonComponent.m_luaExportHelper.InitChapters(pbChapters);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195DF RID: 103903 RVA: 0x0074A434 File Offset: 0x00748634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitChapter(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			ProHeroDungeonChapter pbChapter;
			LuaObject.checkType<ProHeroDungeonChapter>(l, 2, out pbChapter);
			heroDungeonComponent.m_luaExportHelper.InitChapter(pbChapter);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195E0 RID: 103904 RVA: 0x0074A490 File Offset: 0x00748690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSuccessHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			List<int> newGotAchievementRelationInds;
			LuaObject.checkType<List<int>>(l, 3, out newGotAchievementRelationInds);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			heroDungeonComponent.m_luaExportHelper.SetSuccessHeroDungeonLevel(levelInfo, newGotAchievementRelationInds, stars, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195E1 RID: 103905 RVA: 0x0074A514 File Offset: 0x00748714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			string s = heroDungeonComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x060195E2 RID: 103906 RVA: 0x0074A570 File Offset: 0x00748770
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			heroDungeonComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195E3 RID: 103907 RVA: 0x0074A5C4 File Offset: 0x007487C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			heroDungeonComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195E4 RID: 103908 RVA: 0x0074A618 File Offset: 0x00748818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			heroDungeonComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195E5 RID: 103909 RVA: 0x0074A66C File Offset: 0x0074886C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroDungeonComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195E6 RID: 103910 RVA: 0x0074A6C8 File Offset: 0x007488C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			heroDungeonComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195E7 RID: 103911 RVA: 0x0074A71C File Offset: 0x0074891C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasGotAchievementRelationId(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int achievementRelationId;
			LuaObject.checkType(l, 2, out achievementRelationId);
			bool b = heroDungeonComponent.m_luaExportHelper.__callBase_HasGotAchievementRelationId(achievementRelationId);
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

	// Token: 0x060195E8 RID: 103912 RVA: 0x0074A784 File Offset: 0x00748984
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLevelFirstPass(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroDungeonComponent.m_luaExportHelper.__callBase_IsLevelFirstPass(levelId);
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

	// Token: 0x060195E9 RID: 103913 RVA: 0x0074A7EC File Offset: 0x007489EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroDungeonComponent.m_luaExportHelper.__callBase_IsFinishedLevel(levelId);
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

	// Token: 0x060195EA RID: 103914 RVA: 0x0074A854 File Offset: 0x00748A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLevelCanChallengeMaxNums(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_GetLevelCanChallengeMaxNums(levelInfo);
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

	// Token: 0x060195EB RID: 103915 RVA: 0x0074A8BC File Offset: 0x00748ABC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetDailyChallengeMaxNums(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_GetDailyChallengeMaxNums();
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

	// Token: 0x060195EC RID: 103916 RVA: 0x0074A918 File Offset: 0x00748B18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_InitLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			int nums;
			LuaObject.checkType(l, 5, out nums);
			heroDungeonComponent.m_luaExportHelper.__callBase_InitLevel(chapterId, levelId, stars, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195ED RID: 103917 RVA: 0x0074A99C File Offset: 0x00748B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			int nums;
			LuaObject.checkType(l, 5, out nums);
			heroDungeonComponent.m_luaExportHelper.__callBase_SetLevel(chapterId, levelId, stars, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195EE RID: 103918 RVA: 0x0074AA20 File Offset: 0x00748C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			HeroDungeonLevel o = heroDungeonComponent.m_luaExportHelper.__callBase_FindLevel(chapterId, levelId);
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

	// Token: 0x060195EF RID: 103919 RVA: 0x0074AA94 File Offset: 0x00748C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_AttackHeroDungeonLevel(levelId);
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

	// Token: 0x060195F0 RID: 103920 RVA: 0x0074AAFC File Offset: 0x00748CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetSuccessHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			List<int> newGotAchievementRelationInds;
			LuaObject.checkType<List<int>>(l, 3, out newGotAchievementRelationInds);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			heroDungeonComponent.m_luaExportHelper.__callBase_SetSuccessHeroDungeonLevel(levelInfo, newGotAchievementRelationInds, stars, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195F1 RID: 103921 RVA: 0x0074AB80 File Offset: 0x00748D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetRaidSuccessHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			heroDungeonComponent.m_luaExportHelper.__callBase_SetRaidSuccessHeroDungeonLevel(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195F2 RID: 103922 RVA: 0x0074ABDC File Offset: 0x00748DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_CanAttackHeroDungeonLevel(levelId);
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

	// Token: 0x060195F3 RID: 103923 RVA: 0x0074AC44 File Offset: 0x00748E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanRaidHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_CanRaidHeroDungeonLevel(levelId);
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

	// Token: 0x060195F4 RID: 103924 RVA: 0x0074ACAC File Offset: 0x00748EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanUnlockHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_CanUnlockHeroDungeonLevel(levelId);
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

	// Token: 0x060195F5 RID: 103925 RVA: 0x0074AD14 File Offset: 0x00748F14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetHeroDungeonChapterStar(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_GetHeroDungeonChapterStar(chapterId);
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

	// Token: 0x060195F6 RID: 103926 RVA: 0x0074AD7C File Offset: 0x00748F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasGotChapterStarReward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			bool b = heroDungeonComponent.m_luaExportHelper.__callBase_HasGotChapterStarReward(chapterId, index);
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

	// Token: 0x060195F7 RID: 103927 RVA: 0x0074ADF0 File Offset: 0x00748FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGainHeroDungeonChapterStarRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_CanGainHeroDungeonChapterStarRewards(chapterId, index);
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

	// Token: 0x060195F8 RID: 103928 RVA: 0x0074AE64 File Offset: 0x00749064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetHeroDungeonChapterStarRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo chapterInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out chapterInfo);
			int index;
			LuaObject.checkType(l, 3, out index);
			List<Goods> o = heroDungeonComponent.m_luaExportHelper.__callBase_GetHeroDungeonChapterStarRewards(chapterInfo, index);
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

	// Token: 0x060195F9 RID: 103929 RVA: 0x0074AED8 File Offset: 0x007490D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GainHeroDungeonChapterStarRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			bool check;
			LuaObject.checkType(l, 4, out check);
			int i = heroDungeonComponent.m_luaExportHelper.__callBase_GainHeroDungeonChapterStarRewards(chapterId, index, check);
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

	// Token: 0x060195FA RID: 103930 RVA: 0x0074AF5C File Offset: 0x0074915C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GenerateHeroDungeonChapterStarRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonComponent heroDungeonComponent = (HeroDungeonComponent)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			heroDungeonComponent.m_luaExportHelper.__callBase_GenerateHeroDungeonChapterStarRewards(chapterId, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195FB RID: 103931 RVA: 0x0074AFC8 File Offset: 0x007491C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.HeroDungeonComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.FinishBattleHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.RaidHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.IsLevelChallenged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.InitChapters);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.InitChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.SetSuccessHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_HasGotAchievementRelationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_IsLevelFirstPass);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_IsFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_GetLevelCanChallengeMaxNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_GetDailyChallengeMaxNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_InitLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_SetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_FindLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_AttackHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_SetSuccessHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_SetRaidSuccessHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_CanAttackHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_CanRaidHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_CanUnlockHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_GetHeroDungeonChapterStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_HasGotChapterStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_CanGainHeroDungeonChapterStarRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_GetHeroDungeonChapterStarRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_GainHeroDungeonChapterStarRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.__callBase_GenerateHeroDungeonChapterStarRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.<>f__mg$cache25, typeof(HeroDungeonComponent), typeof(HeroDungeonComponentCommon));
	}

	// Token: 0x0400FA1F RID: 64031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FA20 RID: 64032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FA21 RID: 64033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FA22 RID: 64034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FA23 RID: 64035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FA24 RID: 64036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FA25 RID: 64037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FA26 RID: 64038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FA27 RID: 64039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FA28 RID: 64040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FA29 RID: 64041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FA2A RID: 64042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FA2B RID: 64043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FA2C RID: 64044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FA2D RID: 64045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FA2E RID: 64046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FA2F RID: 64047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FA30 RID: 64048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FA31 RID: 64049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FA32 RID: 64050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FA33 RID: 64051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FA34 RID: 64052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FA35 RID: 64053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FA36 RID: 64054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FA37 RID: 64055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FA38 RID: 64056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FA39 RID: 64057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400FA3A RID: 64058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400FA3B RID: 64059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400FA3C RID: 64060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400FA3D RID: 64061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400FA3E RID: 64062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400FA3F RID: 64063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400FA40 RID: 64064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400FA41 RID: 64065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400FA42 RID: 64066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400FA43 RID: 64067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400FA44 RID: 64068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
