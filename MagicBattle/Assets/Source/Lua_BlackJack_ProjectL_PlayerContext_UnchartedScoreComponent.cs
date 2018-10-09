using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E8 RID: 4840
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent : LuaObject
{
	// Token: 0x0601A101 RID: 106753 RVA: 0x007A7628 File Offset: 0x007A5828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent o = new UnchartedScoreComponent();
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

	// Token: 0x0601A102 RID: 106754 RVA: 0x007A7670 File Offset: 0x007A5870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			unchartedScoreComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A103 RID: 106755 RVA: 0x007A76BC File Offset: 0x007A58BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			unchartedScoreComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A104 RID: 106756 RVA: 0x007A7708 File Offset: 0x007A5908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			ushort dsversion = unchartedScoreComponent.GetDSVersion();
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

	// Token: 0x0601A105 RID: 106757 RVA: 0x007A775C File Offset: 0x007A595C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			DSUnchartedScoreNtf msg;
			LuaObject.checkType<DSUnchartedScoreNtf>(l, 2, out msg);
			unchartedScoreComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A106 RID: 106758 RVA: 0x007A77B4 File Offset: 0x007A59B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUnchartedScoreOpened(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			bool b = unchartedScoreComponent.IsUnchartedScoreOpened(unchartedScoreId);
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

	// Token: 0x0601A107 RID: 106759 RVA: 0x007A7818 File Offset: 0x007A5A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUnchartedScoreOpenTime(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			DateTime dateTime;
			DateTime dateTime2;
			unchartedScoreComponent.GetUnchartedScoreOpenTime(unchartedScoreId, out dateTime, out dateTime2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			LuaObject.pushValue(l, dateTime2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A108 RID: 106760 RVA: 0x007A7890 File Offset: 0x007A5A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUnchartedScoreDisplay(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			bool b = unchartedScoreComponent.IsUnchartedScoreDisplay(unchartedScoreId);
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

	// Token: 0x0601A109 RID: 106761 RVA: 0x007A78F4 File Offset: 0x007A5AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUnchartedScoreLevelTimeUnlock(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i = unchartedScoreComponent.IsUnchartedScoreLevelTimeUnlock(unchartedScoreId, levelId);
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

	// Token: 0x0601A10A RID: 106762 RVA: 0x007A7964 File Offset: 0x007A5B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChallengeLevelTimeUnlockDay(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int challengeLevelTimeUnlockDay = unchartedScoreComponent.GetChallengeLevelTimeUnlockDay(unchartedScoreId, levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, challengeLevelTimeUnlockDay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A10B RID: 106763 RVA: 0x007A79D4 File Offset: 0x007A5BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsScoreLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.IsScoreLevelComplete(unchartedScoreId, levelId);
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

	// Token: 0x0601A10C RID: 106764 RVA: 0x007A7A44 File Offset: 0x007A5C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChallengeLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.IsChallengeLevelComplete(unchartedScoreId, levelId);
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

	// Token: 0x0601A10D RID: 106765 RVA: 0x007A7AB4 File Offset: 0x007A5CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChallengePrevLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.IsChallengePrevLevelComplete(unchartedScoreId, levelId);
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

	// Token: 0x0601A10E RID: 106766 RVA: 0x007A7B24 File Offset: 0x007A5D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRewardGot(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int unchartedScoreRewardGroupId;
			LuaObject.checkType(l, 3, out unchartedScoreRewardGroupId);
			bool b = unchartedScoreComponent.IsRewardGot(unchartedScoreId, unchartedScoreRewardGroupId);
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

	// Token: 0x0601A10F RID: 106767 RVA: 0x007A7B94 File Offset: 0x007A5D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int score = unchartedScoreComponent.GetScore(unchartedScoreId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, score);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A110 RID: 106768 RVA: 0x007A7BF8 File Offset: 0x007A5DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDailyRewardRestCount(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int dailyRewardRestCount = unchartedScoreComponent.GetDailyRewardRestCount(unchartedScoreId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dailyRewardRestCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A111 RID: 106769 RVA: 0x007A7C5C File Offset: 0x007A5E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool isWin;
			LuaObject.checkType(l, 4, out isWin);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			int i = unchartedScoreComponent.FinishedChallengeLevel(unchartedScoreId, levelId, isWin, battleTreasures);
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

	// Token: 0x0601A112 RID: 106770 RVA: 0x007A7CE4 File Offset: 0x007A5EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool isWin;
			LuaObject.checkType(l, 4, out isWin);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			int i = unchartedScoreComponent.FinishedScoreLevel(unchartedScoreId, levelId, isWin, battleTreasures);
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

	// Token: 0x0601A113 RID: 106771 RVA: 0x007A7D6C File Offset: 0x007A5F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessChallengeLevelLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 3, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 5, out heroes);
			bool isTeamBattle;
			LuaObject.checkType(l, 6, out isTeamBattle);
			unchartedScoreComponent.SetSuccessChallengeLevelLevel(unchartedScoreId, levelInfo, battleTreasures, heroes, isTeamBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A114 RID: 106772 RVA: 0x007A7DF8 File Offset: 0x007A5FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessScoreLevelLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 3, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 5, out heroes);
			List<int> allHeroes;
			LuaObject.checkType<List<int>>(l, 6, out allHeroes);
			bool isTeamBattle;
			LuaObject.checkType(l, 7, out isTeamBattle);
			unchartedScoreComponent.SetSuccessScoreLevelLevel(unchartedScoreId, levelInfo, battleTreasures, heroes, allHeroes, isTeamBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A115 RID: 106773 RVA: 0x007A7E90 File Offset: 0x007A6090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			string s = unchartedScoreComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601A116 RID: 106774 RVA: 0x007A7EEC File Offset: 0x007A60EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			unchartedScoreComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A117 RID: 106775 RVA: 0x007A7F40 File Offset: 0x007A6140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			unchartedScoreComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A118 RID: 106776 RVA: 0x007A7F94 File Offset: 0x007A6194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			unchartedScoreComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A119 RID: 106777 RVA: 0x007A7FE8 File Offset: 0x007A61E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			unchartedScoreComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A11A RID: 106778 RVA: 0x007A8044 File Offset: 0x007A6244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			unchartedScoreComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A11B RID: 106779 RVA: 0x007A8098 File Offset: 0x007A6298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsUnchartedScoreOnActivityTime(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_IsUnchartedScoreOnActivityTime(unchartedScoreId);
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

	// Token: 0x0601A11C RID: 106780 RVA: 0x007A8100 File Offset: 0x007A6300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllOpenActivityUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			List<int> o = unchartedScoreComponent.m_luaExportHelper.__callBase_GetAllOpenActivityUnchartedScore();
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

	// Token: 0x0601A11D RID: 106781 RVA: 0x007A815C File Offset: 0x007A635C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindOperationalActivityByUnchartedScoreId(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			OperationalActivityBase o = unchartedScoreComponent.m_luaExportHelper.__callBase_FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
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

	// Token: 0x0601A11E RID: 106782 RVA: 0x007A81C4 File Offset: 0x007A63C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsChallengeLevelContains(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsChallengeLevelContains(unchartedScore, levelId);
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

	// Token: 0x0601A11F RID: 106783 RVA: 0x007A8238 File Offset: 0x007A6438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsChallengeLevelExist(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsChallengeLevelExist(unchartedScore, levelId);
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

	// Token: 0x0601A120 RID: 106784 RVA: 0x007A82AC File Offset: 0x007A64AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsChallengeLevelTimeUnlock(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 3, out levelInfo);
			DateTime curDateTime;
			LuaObject.checkValueType<DateTime>(l, 4, out curDateTime);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsChallengeLevelTimeUnlock(operationalActivity, levelInfo, curDateTime);
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

	// Token: 0x0601A121 RID: 106785 RVA: 0x007A8330 File Offset: 0x007A6530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsChallengePrevLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 3, out levelInfo);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsChallengePrevLevelComplete(unchartedScore, levelInfo);
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

	// Token: 0x0601A122 RID: 106786 RVA: 0x007A83A4 File Offset: 0x007A65A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsScoreLevelContains(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsScoreLevelContains(unchartedScore, levelId);
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

	// Token: 0x0601A123 RID: 106787 RVA: 0x007A8418 File Offset: 0x007A6618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsScoreLevelExist(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsScoreLevelExist(unchartedScore, levelId);
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

	// Token: 0x0601A124 RID: 106788 RVA: 0x007A848C File Offset: 0x007A668C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsScoreLevelTimeUnlock(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 3, out levelInfo);
			DateTime curDateTime;
			LuaObject.checkValueType<DateTime>(l, 4, out curDateTime);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsScoreLevelTimeUnlock(operationalActivity, levelInfo, curDateTime);
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

	// Token: 0x0601A125 RID: 106789 RVA: 0x007A8510 File Offset: 0x007A6710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPlayerLevelVaild(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out levelInfo);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsPlayerLevelVaild(levelInfo);
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

	// Token: 0x0601A126 RID: 106790 RVA: 0x007A8578 File Offset: 0x007A6778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CalcScoreLevelScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 3, out levelInfo);
			List<int> heroIdList;
			LuaObject.checkType<List<int>>(l, 4, out heroIdList);
			bool levelBonus;
			LuaObject.checkType(l, 5, out levelBonus);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_CalcScoreLevelScore(unchartedScore, levelInfo, heroIdList, levelBonus);
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

	// Token: 0x0601A127 RID: 106791 RVA: 0x007A8608 File Offset: 0x007A6808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CalcChallengeLevelScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 3, out levelInfo);
			List<int> heroIdList;
			LuaObject.checkType<List<int>>(l, 4, out heroIdList);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_CalcChallengeLevelScore(unchartedScore, levelInfo, heroIdList);
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

	// Token: 0x0601A128 RID: 106792 RVA: 0x007A868C File Offset: 0x007A688C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CalcAllHeroBonus(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			List<int> heroIdList;
			LuaObject.checkType<List<int>>(l, 3, out heroIdList);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_CalcAllHeroBonus(unchartedScore, heroIdList);
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

	// Token: 0x0601A129 RID: 106793 RVA: 0x007A8700 File Offset: 0x007A6900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsChallengeLevelUnlock(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			DateTime curDateTime;
			LuaObject.checkValueType<DateTime>(l, 4, out curDateTime);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsChallengeLevelUnlock(unchartedScore, levelId, curDateTime);
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

	// Token: 0x0601A12A RID: 106794 RVA: 0x007A8784 File Offset: 0x007A6984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsScoreLevelUnlock(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
				int levelId;
				LuaObject.checkType(l, 2, out levelId);
				bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsScoreLevelUnlock(levelId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 4)
			{
				UnchartedScoreComponent unchartedScoreComponent2 = (UnchartedScoreComponent)LuaObject.checkSelf(l);
				UnchartedScore unchartedScore;
				LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
				int levelId2;
				LuaObject.checkType(l, 3, out levelId2);
				DateTime curDateTime;
				LuaObject.checkValueType<DateTime>(l, 4, out curDateTime);
				bool b2 = unchartedScoreComponent2.m_luaExportHelper.__callBase_IsScoreLevelUnlock(unchartedScore, levelId2, curDateTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_IsScoreLevelUnlock to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A12B RID: 106795 RVA: 0x007A8874 File Offset: 0x007A6A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllUnlockedScoreLevels(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			List<int> o = unchartedScoreComponent.m_luaExportHelper.__callBase_GetAllUnlockedScoreLevels();
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

	// Token: 0x0601A12C RID: 106796 RVA: 0x007A88D0 File Offset: 0x007A6AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsChallengeLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsChallengeLevelComplete(unchartedScore, levelId);
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

	// Token: 0x0601A12D RID: 106797 RVA: 0x007A8944 File Offset: 0x007A6B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsScoreLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponent.m_luaExportHelper.__callBase_IsScoreLevelComplete(unchartedScore, levelId);
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

	// Token: 0x0601A12E RID: 106798 RVA: 0x007A89B8 File Offset: 0x007A6BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsUnchartedScoreExist(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_IsUnchartedScoreExist(unchartedScoreId);
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

	// Token: 0x0601A12F RID: 106799 RVA: 0x007A8A20 File Offset: 0x007A6C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetReward(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int score;
			LuaObject.checkType(l, 3, out score);
			List<Goods> o = unchartedScoreComponent.m_luaExportHelper.__callBase_GetReward(unchartedScoreId, score);
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

	// Token: 0x0601A130 RID: 106800 RVA: 0x007A8A94 File Offset: 0x007A6C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanRewardGain(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int score;
			LuaObject.checkType(l, 3, out score);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_CanRewardGain(unchartedScoreId, score);
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

	// Token: 0x0601A131 RID: 106801 RVA: 0x007A8B08 File Offset: 0x007A6D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			unchartedScoreComponent.m_luaExportHelper.__callBase_RemoveUnchartedScore(unchartedScoreId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A132 RID: 106802 RVA: 0x007A8B64 File Offset: 0x007A6D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckChallengeLevelEnergy(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out levelInfo);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_CheckChallengeLevelEnergy(levelInfo);
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

	// Token: 0x0601A133 RID: 106803 RVA: 0x007A8BCC File Offset: 0x007A6DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckScoreLevelEnergy(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out levelInfo);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_CheckScoreLevelEnergy(levelInfo, isTeamBattle);
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

	// Token: 0x0601A134 RID: 106804 RVA: 0x007A8C40 File Offset: 0x007A6E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_CanAttackChallengeLevel(unchartedScoreId, levelId);
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

	// Token: 0x0601A135 RID: 106805 RVA: 0x007A8CB4 File Offset: 0x007A6EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_AttackChallengeLevel(unchartedScoreId, levelId);
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

	// Token: 0x0601A136 RID: 106806 RVA: 0x007A8D28 File Offset: 0x007A6F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCommonSuccessChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 3, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 5, out heroes);
			int energyCost;
			LuaObject.checkType(l, 6, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 7, out isBattleTeam);
			unchartedScoreComponent.m_luaExportHelper.__callBase_SetCommonSuccessChallengeLevel(unchartedScore, levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A137 RID: 106807 RVA: 0x007A8DC4 File Offset: 0x007A6FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCommonSuccessScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 3, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 5, out heroes);
			List<int> allHeroes;
			LuaObject.checkType<List<int>>(l, 6, out allHeroes);
			int energyCost;
			LuaObject.checkType(l, 7, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 8, out isBattleTeam);
			unchartedScoreComponent.m_luaExportHelper.__callBase_SetCommonSuccessScoreLevel(unchartedScore, levelInfo, battleTreasures, heroes, allHeroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A138 RID: 106808 RVA: 0x007A8E6C File Offset: 0x007A706C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 4, out isTeamBattle);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_CanAttackScoreLevel(unchartedScoreId, levelId, isTeamBattle);
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

	// Token: 0x0601A139 RID: 106809 RVA: 0x007A8EF0 File Offset: 0x007A70F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i = unchartedScoreComponent.m_luaExportHelper.__callBase_AttackScoreLevel(unchartedScoreId, levelId);
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

	// Token: 0x0601A13A RID: 106810 RVA: 0x007A8F64 File Offset: 0x007A7164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckScoreReward(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			unchartedScoreComponent.m_luaExportHelper.__callBase_CheckScoreReward(unchartedScore);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A13B RID: 106811 RVA: 0x007A8FC0 File Offset: 0x007A71C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FlushBounsCount(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			unchartedScoreComponent.m_luaExportHelper.__callBase_FlushBounsCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A13C RID: 106812 RVA: 0x007A9014 File Offset: 0x007A7214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetScoreRewardGain(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int score;
			LuaObject.checkType(l, 3, out score);
			unchartedScoreComponent.m_luaExportHelper.__callBase_SetScoreRewardGain(unchartedScore, score);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A13D RID: 106813 RVA: 0x007A9080 File Offset: 0x007A7280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponent unchartedScoreComponent = (UnchartedScoreComponent)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			UnchartedScore o = unchartedScoreComponent.m_luaExportHelper.__callBase_GetUnchartedScore(id);
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

	// Token: 0x0601A13E RID: 106814 RVA: 0x007A90E8 File Offset: 0x007A72E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.UnchartedScoreComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.IsUnchartedScoreOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.GetUnchartedScoreOpenTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.IsUnchartedScoreDisplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.IsUnchartedScoreLevelTimeUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.GetChallengeLevelTimeUnlockDay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.IsScoreLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.IsChallengeLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.IsChallengePrevLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.IsRewardGot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.GetScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.GetDailyRewardRestCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.FinishedChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.FinishedScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.SetSuccessChallengeLevelLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.SetSuccessScoreLevelLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsUnchartedScoreOnActivityTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_GetAllOpenActivityUnchartedScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_FindOperationalActivityByUnchartedScoreId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsChallengeLevelContains);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsChallengeLevelExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsChallengeLevelTimeUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsChallengePrevLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsScoreLevelContains);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsScoreLevelExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsScoreLevelTimeUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsPlayerLevelVaild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CalcScoreLevelScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CalcChallengeLevelScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CalcAllHeroBonus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsChallengeLevelUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsScoreLevelUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_GetAllUnlockedScoreLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsChallengeLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsScoreLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_IsUnchartedScoreExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_GetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CanRewardGain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_RemoveUnchartedScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CheckChallengeLevelEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CheckScoreLevelEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CanAttackChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_AttackChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_SetCommonSuccessChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_SetCommonSuccessScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CanAttackScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_AttackScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_CheckScoreReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_FlushBounsCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_SetScoreRewardGain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.__callBase_GetUnchartedScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.<>f__mg$cache3C, typeof(UnchartedScoreComponent), typeof(UnchartedScoreComponentCommon));
	}

	// Token: 0x04010513 RID: 66835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010514 RID: 66836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010515 RID: 66837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010516 RID: 66838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010517 RID: 66839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010518 RID: 66840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010519 RID: 66841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401051A RID: 66842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401051B RID: 66843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401051C RID: 66844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401051D RID: 66845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401051E RID: 66846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401051F RID: 66847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010520 RID: 66848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010521 RID: 66849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010522 RID: 66850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010523 RID: 66851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010524 RID: 66852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010525 RID: 66853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010526 RID: 66854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010527 RID: 66855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010528 RID: 66856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010529 RID: 66857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401052A RID: 66858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401052B RID: 66859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401052C RID: 66860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401052D RID: 66861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401052E RID: 66862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401052F RID: 66863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010530 RID: 66864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010531 RID: 66865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010532 RID: 66866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010533 RID: 66867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010534 RID: 66868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010535 RID: 66869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010536 RID: 66870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010537 RID: 66871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010538 RID: 66872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010539 RID: 66873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401053A RID: 66874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401053B RID: 66875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401053C RID: 66876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401053D RID: 66877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401053E RID: 66878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401053F RID: 66879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010540 RID: 66880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010541 RID: 66881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010542 RID: 66882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010543 RID: 66883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010544 RID: 66884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010545 RID: 66885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010546 RID: 66886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010547 RID: 66887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010548 RID: 66888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010549 RID: 66889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401054A RID: 66890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401054B RID: 66891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401054C RID: 66892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401054D RID: 66893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401054E RID: 66894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401054F RID: 66895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;
}
