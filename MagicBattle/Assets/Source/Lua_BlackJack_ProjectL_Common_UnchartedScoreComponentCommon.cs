using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001291 RID: 4753
[Preserve]
public class Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon : LuaObject
{
	// Token: 0x06018C4A RID: 101450 RVA: 0x00702404 File Offset: 0x00700604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon o = new UnchartedScoreComponentCommon();
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

	// Token: 0x06018C4B RID: 101451 RVA: 0x0070244C File Offset: 0x0070064C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			string name = unchartedScoreComponentCommon.GetName();
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

	// Token: 0x06018C4C RID: 101452 RVA: 0x007024A0 File Offset: 0x007006A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			unchartedScoreComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C4D RID: 101453 RVA: 0x007024EC File Offset: 0x007006EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			unchartedScoreComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C4E RID: 101454 RVA: 0x00702538 File Offset: 0x00700738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			unchartedScoreComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C4F RID: 101455 RVA: 0x00702584 File Offset: 0x00700784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			unchartedScoreComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C50 RID: 101456 RVA: 0x007025DC File Offset: 0x007007DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			unchartedScoreComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C51 RID: 101457 RVA: 0x00702628 File Offset: 0x00700828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUnchartedScoreOnActivityTime(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int i = unchartedScoreComponentCommon.IsUnchartedScoreOnActivityTime(unchartedScoreId);
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

	// Token: 0x06018C52 RID: 101458 RVA: 0x0070268C File Offset: 0x0070088C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllOpenActivityUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			List<int> allOpenActivityUnchartedScore = unchartedScoreComponentCommon.GetAllOpenActivityUnchartedScore();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allOpenActivityUnchartedScore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C53 RID: 101459 RVA: 0x007026E0 File Offset: 0x007008E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindOperationalActivityByUnchartedScoreId(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			OperationalActivityBase o = unchartedScoreComponentCommon.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
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

	// Token: 0x06018C54 RID: 101460 RVA: 0x00702744 File Offset: 0x00700944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChallengeLevelContains(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponentCommon.IsChallengeLevelContains(unchartedScore, levelId);
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

	// Token: 0x06018C55 RID: 101461 RVA: 0x007027B4 File Offset: 0x007009B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChallengeLevelExist(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponentCommon.IsChallengeLevelExist(unchartedScore, levelId);
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

	// Token: 0x06018C56 RID: 101462 RVA: 0x00702824 File Offset: 0x00700A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChallengeLevelTimeUnlock(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 3, out levelInfo);
			DateTime curDateTime;
			LuaObject.checkValueType<DateTime>(l, 4, out curDateTime);
			bool b = unchartedScoreComponentCommon.IsChallengeLevelTimeUnlock(operationalActivity, levelInfo, curDateTime);
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

	// Token: 0x06018C57 RID: 101463 RVA: 0x007028A0 File Offset: 0x00700AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChallengePrevLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 3, out levelInfo);
			bool b = unchartedScoreComponentCommon.IsChallengePrevLevelComplete(unchartedScore, levelInfo);
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

	// Token: 0x06018C58 RID: 101464 RVA: 0x00702910 File Offset: 0x00700B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsScoreLevelContains(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponentCommon.IsScoreLevelContains(unchartedScore, levelId);
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

	// Token: 0x06018C59 RID: 101465 RVA: 0x00702980 File Offset: 0x00700B80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsScoreLevelExist(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponentCommon.IsScoreLevelExist(unchartedScore, levelId);
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

	// Token: 0x06018C5A RID: 101466 RVA: 0x007029F0 File Offset: 0x00700BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsScoreLevelTimeUnlock(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 3, out levelInfo);
			DateTime curDateTime;
			LuaObject.checkValueType<DateTime>(l, 4, out curDateTime);
			bool b = unchartedScoreComponentCommon.IsScoreLevelTimeUnlock(operationalActivity, levelInfo, curDateTime);
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

	// Token: 0x06018C5B RID: 101467 RVA: 0x00702A6C File Offset: 0x00700C6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsPlayerLevelVaild(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out levelInfo);
			bool b = unchartedScoreComponentCommon.IsPlayerLevelVaild(levelInfo);
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

	// Token: 0x06018C5C RID: 101468 RVA: 0x00702AD0 File Offset: 0x00700CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcScoreLevelScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 3, out levelInfo);
			List<int> heroIdList;
			LuaObject.checkType<List<int>>(l, 4, out heroIdList);
			bool levelBonus;
			LuaObject.checkType(l, 5, out levelBonus);
			int i = unchartedScoreComponentCommon.CalcScoreLevelScore(unchartedScore, levelInfo, heroIdList, levelBonus);
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

	// Token: 0x06018C5D RID: 101469 RVA: 0x00702B58 File Offset: 0x00700D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcChallengeLevelScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 3, out levelInfo);
			List<int> heroIdList;
			LuaObject.checkType<List<int>>(l, 4, out heroIdList);
			int i = unchartedScoreComponentCommon.CalcChallengeLevelScore(unchartedScore, levelInfo, heroIdList);
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

	// Token: 0x06018C5E RID: 101470 RVA: 0x00702BD4 File Offset: 0x00700DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcAllHeroBonus(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			List<int> heroIdList;
			LuaObject.checkType<List<int>>(l, 3, out heroIdList);
			int i = unchartedScoreComponentCommon.CalcAllHeroBonus(unchartedScore, heroIdList);
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

	// Token: 0x06018C5F RID: 101471 RVA: 0x00702C44 File Offset: 0x00700E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsChallengeLevelUnlock(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			DateTime curDateTime;
			LuaObject.checkValueType<DateTime>(l, 4, out curDateTime);
			bool b = unchartedScoreComponentCommon.IsChallengeLevelUnlock(unchartedScore, levelId, curDateTime);
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

	// Token: 0x06018C60 RID: 101472 RVA: 0x00702CC0 File Offset: 0x00700EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsScoreLevelUnlock(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
				int levelId;
				LuaObject.checkType(l, 2, out levelId);
				bool b = unchartedScoreComponentCommon.IsScoreLevelUnlock(levelId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 4)
			{
				UnchartedScoreComponentCommon unchartedScoreComponentCommon2 = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
				UnchartedScore unchartedScore;
				LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
				int levelId2;
				LuaObject.checkType(l, 3, out levelId2);
				DateTime curDateTime;
				LuaObject.checkValueType<DateTime>(l, 4, out curDateTime);
				bool b2 = unchartedScoreComponentCommon2.IsScoreLevelUnlock(unchartedScore, levelId2, curDateTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsScoreLevelUnlock to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C61 RID: 101473 RVA: 0x00702DA4 File Offset: 0x00700FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllUnlockedScoreLevels(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			List<int> allUnlockedScoreLevels = unchartedScoreComponentCommon.GetAllUnlockedScoreLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allUnlockedScoreLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C62 RID: 101474 RVA: 0x00702DF8 File Offset: 0x00700FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChallengeLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponentCommon.IsChallengeLevelComplete(unchartedScore, levelId);
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

	// Token: 0x06018C63 RID: 101475 RVA: 0x00702E68 File Offset: 0x00701068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsScoreLevelComplete(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool b = unchartedScoreComponentCommon.IsScoreLevelComplete(unchartedScore, levelId);
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

	// Token: 0x06018C64 RID: 101476 RVA: 0x00702ED8 File Offset: 0x007010D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsUnchartedScoreExist(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int i = unchartedScoreComponentCommon.IsUnchartedScoreExist(unchartedScoreId);
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

	// Token: 0x06018C65 RID: 101477 RVA: 0x00702F3C File Offset: 0x0070113C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetReward(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int score;
			LuaObject.checkType(l, 3, out score);
			List<Goods> reward = unchartedScoreComponentCommon.GetReward(unchartedScoreId, score);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C66 RID: 101478 RVA: 0x00702FAC File Offset: 0x007011AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			unchartedScoreComponentCommon.RemoveUnchartedScore(unchartedScoreId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C67 RID: 101479 RVA: 0x00703004 File Offset: 0x00701204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckChallengeLevelEnergy(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out levelInfo);
			int i = unchartedScoreComponentCommon.CheckChallengeLevelEnergy(levelInfo);
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

	// Token: 0x06018C68 RID: 101480 RVA: 0x00703068 File Offset: 0x00701268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckScoreLevelEnergy(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out levelInfo);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = unchartedScoreComponentCommon.CheckScoreLevelEnergy(levelInfo, isTeamBattle);
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

	// Token: 0x06018C69 RID: 101481 RVA: 0x007030D8 File Offset: 0x007012D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i = unchartedScoreComponentCommon.CanAttackChallengeLevel(unchartedScoreId, levelId);
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

	// Token: 0x06018C6A RID: 101482 RVA: 0x00703148 File Offset: 0x00701348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i = unchartedScoreComponentCommon.AttackChallengeLevel(unchartedScoreId, levelId);
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

	// Token: 0x06018C6B RID: 101483 RVA: 0x007031B8 File Offset: 0x007013B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCommonSuccessChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
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
			unchartedScoreComponentCommon.SetCommonSuccessChallengeLevel(unchartedScore, levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C6C RID: 101484 RVA: 0x00703250 File Offset: 0x00701450
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCommonSuccessScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
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
			unchartedScoreComponentCommon.SetCommonSuccessScoreLevel(unchartedScore, levelInfo, battleTreasures, heroes, allHeroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C6D RID: 101485 RVA: 0x007032F4 File Offset: 0x007014F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 4, out isTeamBattle);
			int i = unchartedScoreComponentCommon.CanAttackScoreLevel(unchartedScoreId, levelId, isTeamBattle);
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

	// Token: 0x06018C6E RID: 101486 RVA: 0x00703370 File Offset: 0x00701570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i = unchartedScoreComponentCommon.AttackScoreLevel(unchartedScoreId, levelId);
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

	// Token: 0x06018C6F RID: 101487 RVA: 0x007033E0 File Offset: 0x007015E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckScoreReward(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			unchartedScoreComponentCommon.CheckScoreReward(unchartedScore);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C70 RID: 101488 RVA: 0x00703438 File Offset: 0x00701638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushBounsCount(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			unchartedScoreComponentCommon.FlushBounsCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C71 RID: 101489 RVA: 0x00703484 File Offset: 0x00701684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetScoreRewardGain(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			UnchartedScore unchartedScore;
			LuaObject.checkType<UnchartedScore>(l, 2, out unchartedScore);
			int score;
			LuaObject.checkType(l, 3, out score);
			unchartedScoreComponentCommon.SetScoreRewardGain(unchartedScore, score);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C72 RID: 101490 RVA: 0x007034E8 File Offset: 0x007016E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			UnchartedScore unchartedScore = unchartedScoreComponentCommon.GetUnchartedScore(id);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C73 RID: 101491 RVA: 0x0070354C File Offset: 0x0070174C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanRewardGain(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int score;
			LuaObject.checkType(l, 3, out score);
			int i = unchartedScoreComponentCommon.m_luaExportHelper.CanRewardGain(unchartedScoreId, score);
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

	// Token: 0x06018C74 RID: 101492 RVA: 0x007035C0 File Offset: 0x007017C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C75 RID: 101493 RVA: 0x00703618 File Offset: 0x00701818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			unchartedScoreComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C76 RID: 101494 RVA: 0x00703674 File Offset: 0x00701874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C77 RID: 101495 RVA: 0x007036CC File Offset: 0x007018CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			unchartedScoreComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C78 RID: 101496 RVA: 0x00703728 File Offset: 0x00701928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C79 RID: 101497 RVA: 0x00703780 File Offset: 0x00701980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			unchartedScoreComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C7A RID: 101498 RVA: 0x007037DC File Offset: 0x007019DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C7B RID: 101499 RVA: 0x00703834 File Offset: 0x00701A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			unchartedScoreComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C7C RID: 101500 RVA: 0x00703890 File Offset: 0x00701A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C7D RID: 101501 RVA: 0x007038E8 File Offset: 0x00701AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			unchartedScoreComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C7E RID: 101502 RVA: 0x00703944 File Offset: 0x00701B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_operationalActivity(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreComponentCommon.m_luaExportHelper.m_operationalActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C7F RID: 101503 RVA: 0x0070399C File Offset: 0x00701B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_operationalActivity(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			OperationalActivityCompomentCommon operationalActivity;
			LuaObject.checkType<OperationalActivityCompomentCommon>(l, 2, out operationalActivity);
			unchartedScoreComponentCommon.m_luaExportHelper.m_operationalActivity = operationalActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C80 RID: 101504 RVA: 0x007039F8 File Offset: 0x00701BF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_UnchartedScoreDS(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreComponentCommon.m_luaExportHelper.m_UnchartedScoreDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C81 RID: 101505 RVA: 0x00703A50 File Offset: 0x00701C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_UnchartedScoreDS(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			DataSectionUnchartedScore unchartedScoreDS;
			LuaObject.checkType<DataSectionUnchartedScore>(l, 2, out unchartedScoreDS);
			unchartedScoreComponentCommon.m_luaExportHelper.m_UnchartedScoreDS = unchartedScoreDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C82 RID: 101506 RVA: 0x00703AAC File Offset: 0x00701CAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C83 RID: 101507 RVA: 0x00703B00 File Offset: 0x00701D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreComponentCommon unchartedScoreComponentCommon = (UnchartedScoreComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			unchartedScoreComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C84 RID: 101508 RVA: 0x00703B58 File Offset: 0x00701D58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.UnchartedScoreComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsUnchartedScoreOnActivityTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.GetAllOpenActivityUnchartedScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.FindOperationalActivityByUnchartedScoreId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsChallengeLevelContains);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsChallengeLevelExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsChallengeLevelTimeUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsChallengePrevLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsScoreLevelContains);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsScoreLevelExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsScoreLevelTimeUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsPlayerLevelVaild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CalcScoreLevelScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CalcChallengeLevelScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CalcAllHeroBonus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsChallengeLevelUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsScoreLevelUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.GetAllUnlockedScoreLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsChallengeLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsScoreLevelComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.IsUnchartedScoreExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.GetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.RemoveUnchartedScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CheckChallengeLevelEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CheckScoreLevelEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CanAttackChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.AttackChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.SetCommonSuccessChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.SetCommonSuccessScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CanAttackScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.AttackScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CheckScoreReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.FlushBounsCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.SetScoreRewardGain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.GetUnchartedScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.CanRewardGain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache28);
		string name = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2A, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2C, true);
		string name3 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.get_m_battle);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2E, true);
		string name4 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.get_m_bag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache30, true);
		string name5 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.get_m_hero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache32, true);
		string name6 = "m_operationalActivity";
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.get_m_operationalActivity);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.set_m_operationalActivity);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache34, true);
		string name7 = "m_UnchartedScoreDS";
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.get_m_UnchartedScoreDS);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.set_m_UnchartedScoreDS);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache36, true);
		string name8 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.get_Owner);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache38, true);
		if (Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.<>f__mg$cache39, typeof(UnchartedScoreComponentCommon));
	}

	// Token: 0x0400F10A RID: 61706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F10B RID: 61707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F10C RID: 61708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F10D RID: 61709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F10E RID: 61710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F10F RID: 61711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F110 RID: 61712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F111 RID: 61713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F112 RID: 61714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F113 RID: 61715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F114 RID: 61716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F115 RID: 61717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F116 RID: 61718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F117 RID: 61719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F118 RID: 61720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F119 RID: 61721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F11A RID: 61722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F11B RID: 61723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F11C RID: 61724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F11D RID: 61725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F11E RID: 61726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F11F RID: 61727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F120 RID: 61728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F121 RID: 61729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F122 RID: 61730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F123 RID: 61731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F124 RID: 61732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F125 RID: 61733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F126 RID: 61734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F127 RID: 61735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F128 RID: 61736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F129 RID: 61737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F12A RID: 61738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F12B RID: 61739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F12C RID: 61740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F12D RID: 61741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F12E RID: 61742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F12F RID: 61743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F130 RID: 61744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F131 RID: 61745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F132 RID: 61746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F133 RID: 61747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F134 RID: 61748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F135 RID: 61749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F136 RID: 61750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F137 RID: 61751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F138 RID: 61752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F139 RID: 61753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F13A RID: 61754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F13B RID: 61755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F13C RID: 61756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F13D RID: 61757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F13E RID: 61758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F13F RID: 61759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F140 RID: 61760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F141 RID: 61761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F142 RID: 61762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F143 RID: 61763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;
}
