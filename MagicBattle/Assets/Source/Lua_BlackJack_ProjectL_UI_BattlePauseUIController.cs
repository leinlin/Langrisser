using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013A7 RID: 5031
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePauseUIController : LuaObject
{
	// Token: 0x0601BA43 RID: 113219 RVA: 0x0086C40C File Offset: 0x0086A60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA44 RID: 113220 RVA: 0x0086C458 File Offset: 0x0086A658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			bool b = battlePauseUIController.IsOpened();
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

	// Token: 0x0601BA45 RID: 113221 RVA: 0x0086C4AC File Offset: 0x0086A6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA46 RID: 113222 RVA: 0x0086C4F8 File Offset: 0x0086A6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStrategyButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battlePauseUIController.ShowStrategyButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA47 RID: 113223 RVA: 0x0086C550 File Offset: 0x0086A750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWinLoseConditions(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			string winDesc;
			LuaObject.checkType(l, 2, out winDesc);
			string loseDesc;
			LuaObject.checkType(l, 3, out loseDesc);
			battlePauseUIController.SetWinLoseConditions(winDesc, loseDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA48 RID: 113224 RVA: 0x0086C5B4 File Offset: 0x0086A7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStarCondition(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int starTurnMax;
			LuaObject.checkType(l, 3, out starTurnMax);
			int starDeadMax;
			LuaObject.checkType(l, 4, out starDeadMax);
			battlePauseUIController.SetStarCondition(battleType, starTurnMax, starDeadMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA49 RID: 113225 RVA: 0x0086C628 File Offset: 0x0086A828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 2, out achievements);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 3, out battleType);
			battlePauseUIController.SetAchievement(achievements, battleType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA4A RID: 113226 RVA: 0x0086C68C File Offset: 0x0086A88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAchievementCount(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			int countMax;
			LuaObject.checkType(l, 3, out countMax);
			battlePauseUIController.SetAchievementCount(count, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA4B RID: 113227 RVA: 0x0086C6F0 File Offset: 0x0086A8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTurn(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			int turnMax;
			LuaObject.checkType(l, 3, out turnMax);
			battlePauseUIController.SetTurn(turn, turnMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA4C RID: 113228 RVA: 0x0086C754 File Offset: 0x0086A954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMap(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			BattleMap map;
			LuaObject.checkType<BattleMap>(l, 2, out map);
			battlePauseUIController.SetMap(map);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA4D RID: 113229 RVA: 0x0086C7AC File Offset: 0x0086A9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMapActors(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			List<GridPosition> team;
			LuaObject.checkType<List<GridPosition>>(l, 2, out team);
			List<GridPosition> team2;
			LuaObject.checkType<List<GridPosition>>(l, 3, out team2);
			List<GridPosition> teamNpc;
			LuaObject.checkType<List<GridPosition>>(l, 4, out teamNpc);
			battlePauseUIController.SetMapActors(team, team2, teamNpc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA4E RID: 113230 RVA: 0x0086C820 File Offset: 0x0086AA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMapReachRegion(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			List<GridPosition> mapReachRegion;
			LuaObject.checkType<List<GridPosition>>(l, 2, out mapReachRegion);
			battlePauseUIController.SetMapReachRegion(mapReachRegion);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA4F RID: 113231 RVA: 0x0086C878 File Offset: 0x0086AA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMapAll(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.ClearMapAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA50 RID: 113232 RVA: 0x0086C8C4 File Offset: 0x0086AAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA51 RID: 113233 RVA: 0x0086C918 File Offset: 0x0086AB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 2, out parent);
			string conditionStrs;
			LuaObject.checkType(l, 3, out conditionStrs);
			battlePauseUIController.m_luaExportHelper.SetConditionInfo(parent, conditionStrs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA52 RID: 113234 RVA: 0x0086C984 File Offset: 0x0086AB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCondition(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 2, out parent);
			string str;
			LuaObject.checkType(l, 3, out str);
			battlePauseUIController.m_luaExportHelper.AddCondition(parent, str);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA53 RID: 113235 RVA: 0x0086C9F0 File Offset: 0x0086ABF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.ShowAchievement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA54 RID: 113236 RVA: 0x0086CA44 File Offset: 0x0086AC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.HideAchievement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA55 RID: 113237 RVA: 0x0086CA98 File Offset: 0x0086AC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAchievementItem(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			ConfigDataBattleAchievementInfo achievementInfo;
			LuaObject.checkType<ConfigDataBattleAchievementInfo>(l, 2, out achievementInfo);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 3, out rewards);
			GameObject prefab;
			LuaObject.checkType<GameObject>(l, 4, out prefab);
			bool complete;
			LuaObject.checkType(l, 5, out complete);
			battlePauseUIController.m_luaExportHelper.AddAchievementItem(achievementInfo, rewards, prefab, complete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA56 RID: 113238 RVA: 0x0086CB1C File Offset: 0x0086AD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAchievementItems(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.ClearAchievementItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA57 RID: 113239 RVA: 0x0086CB70 File Offset: 0x0086AD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMap(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.ClearMap();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA58 RID: 113240 RVA: 0x0086CBC4 File Offset: 0x0086ADC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMapActors(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			List<GridPosition> positions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out positions);
			GameObject prefab;
			LuaObject.checkType<GameObject>(l, 3, out prefab);
			battlePauseUIController.m_luaExportHelper.CreateMapActors(positions, prefab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA59 RID: 113241 RVA: 0x0086CC30 File Offset: 0x0086AE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMapActors(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.ClearMapActors();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA5A RID: 113242 RVA: 0x0086CC84 File Offset: 0x0086AE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMapReachRegion(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.ClearMapReachRegion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA5B RID: 113243 RVA: 0x0086CCD8 File Offset: 0x0086AED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GridPositionToMapPosition(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			int x;
			LuaObject.checkType(l, 2, out x);
			int y;
			LuaObject.checkType(l, 3, out y);
			Vector2 o = battlePauseUIController.m_luaExportHelper.GridPositionToMapPosition(x, y);
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

	// Token: 0x0601BA5C RID: 113244 RVA: 0x0086CD4C File Offset: 0x0086AF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExitButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.OnExitButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA5D RID: 113245 RVA: 0x0086CDA0 File Offset: 0x0086AFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAchievementButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.OnAchievementButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA5E RID: 113246 RVA: 0x0086CDF4 File Offset: 0x0086AFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStrategyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.OnStrategyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA5F RID: 113247 RVA: 0x0086CE48 File Offset: 0x0086B048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStrategyPanel(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.UpdateStrategyPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA60 RID: 113248 RVA: 0x0086CE9C File Offset: 0x0086B09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_StartDanmakuItemsTweenPos(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			IEnumerator o = battlePauseUIController.m_luaExportHelper.Co_StartDanmakuItemsTweenPos();
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

	// Token: 0x0601BA61 RID: 113249 RVA: 0x0086CEF8 File Offset: 0x0086B0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStrategyBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.OnStrategyBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA62 RID: 113250 RVA: 0x0086CF4C File Offset: 0x0086B14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.OnSetButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA63 RID: 113251 RVA: 0x0086CFA0 File Offset: 0x0086B1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA64 RID: 113252 RVA: 0x0086CFF4 File Offset: 0x0086B1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAchievementBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.OnAchievementBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA65 RID: 113253 RVA: 0x0086D048 File Offset: 0x0086B248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battlePauseUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA66 RID: 113254 RVA: 0x0086D0B4 File Offset: 0x0086B2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA67 RID: 113255 RVA: 0x0086D108 File Offset: 0x0086B308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA68 RID: 113256 RVA: 0x0086D15C File Offset: 0x0086B35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = battlePauseUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601BA69 RID: 113257 RVA: 0x0086D204 File Offset: 0x0086B404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA6A RID: 113258 RVA: 0x0086D258 File Offset: 0x0086B458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battlePauseUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA6B RID: 113259 RVA: 0x0086D2C4 File Offset: 0x0086B4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battlePauseUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattlePauseUIController battlePauseUIController2 = (BattlePauseUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battlePauseUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA6C RID: 113260 RVA: 0x0086D3D4 File Offset: 0x0086B5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePauseUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA6D RID: 113261 RVA: 0x0086D440 File Offset: 0x0086B640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePauseUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA6E RID: 113262 RVA: 0x0086D4AC File Offset: 0x0086B6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePauseUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA6F RID: 113263 RVA: 0x0086D518 File Offset: 0x0086B718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battlePauseUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA70 RID: 113264 RVA: 0x0086D584 File Offset: 0x0086B784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battlePauseUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattlePauseUIController battlePauseUIController2 = (BattlePauseUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battlePauseUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA71 RID: 113265 RVA: 0x0086D694 File Offset: 0x0086B894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			string s = battlePauseUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601BA72 RID: 113266 RVA: 0x0086D6F0 File Offset: 0x0086B8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExit(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__callDele_EventOnExit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA73 RID: 113267 RVA: 0x0086D744 File Offset: 0x0086B944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExit(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__clearDele_EventOnExit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA74 RID: 113268 RVA: 0x0086D798 File Offset: 0x0086B998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA75 RID: 113269 RVA: 0x0086D7EC File Offset: 0x0086B9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA76 RID: 113270 RVA: 0x0086D840 File Offset: 0x0086BA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowPlayerSetting(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__callDele_EventOnShowPlayerSetting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA77 RID: 113271 RVA: 0x0086D894 File Offset: 0x0086BA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowPlayerSetting(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			battlePauseUIController.m_luaExportHelper.__clearDele_EventOnShowPlayerSetting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA78 RID: 113272 RVA: 0x0086D8E8 File Offset: 0x0086BAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExit(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePauseUIController.EventOnExit += value;
				}
				else if (num == 2)
				{
					battlePauseUIController.EventOnExit -= value;
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

	// Token: 0x0601BA79 RID: 113273 RVA: 0x0086D968 File Offset: 0x0086BB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePauseUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					battlePauseUIController.EventOnClose -= value;
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

	// Token: 0x0601BA7A RID: 113274 RVA: 0x0086D9E8 File Offset: 0x0086BBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowPlayerSetting(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battlePauseUIController.EventOnShowPlayerSetting += value;
				}
				else if (num == 2)
				{
					battlePauseUIController.EventOnShowPlayerSetting -= value;
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

	// Token: 0x0601BA7B RID: 113275 RVA: 0x0086DA68 File Offset: 0x0086BC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA7C RID: 113276 RVA: 0x0086DAC0 File Offset: 0x0086BCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			battlePauseUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA7D RID: 113277 RVA: 0x0086DB1C File Offset: 0x0086BD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA7E RID: 113278 RVA: 0x0086DB74 File Offset: 0x0086BD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			battlePauseUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA7F RID: 113279 RVA: 0x0086DBD0 File Offset: 0x0086BDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_closeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA80 RID: 113280 RVA: 0x0086DC28 File Offset: 0x0086BE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			battlePauseUIController.m_luaExportHelper.m_closeButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA81 RID: 113281 RVA: 0x0086DC84 File Offset: 0x0086BE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_exitButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_exitButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA82 RID: 113282 RVA: 0x0086DCDC File Offset: 0x0086BEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_exitButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button exitButton;
			LuaObject.checkType<Button>(l, 2, out exitButton);
			battlePauseUIController.m_luaExportHelper.m_exitButton = exitButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA83 RID: 113283 RVA: 0x0086DD38 File Offset: 0x0086BF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_achievementButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA84 RID: 113284 RVA: 0x0086DD90 File Offset: 0x0086BF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button achievementButton;
			LuaObject.checkType<Button>(l, 2, out achievementButton);
			battlePauseUIController.m_luaExportHelper.m_achievementButton = achievementButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA85 RID: 113285 RVA: 0x0086DDEC File Offset: 0x0086BFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_settingButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_settingButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA86 RID: 113286 RVA: 0x0086DE44 File Offset: 0x0086C044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_settingButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button settingButton;
			LuaObject.checkType<Button>(l, 2, out settingButton);
			battlePauseUIController.m_luaExportHelper.m_settingButton = settingButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA87 RID: 113287 RVA: 0x0086DEA0 File Offset: 0x0086C0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_strategyButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_strategyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA88 RID: 113288 RVA: 0x0086DEF8 File Offset: 0x0086C0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_strategyButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button strategyButton;
			LuaObject.checkType<Button>(l, 2, out strategyButton);
			battlePauseUIController.m_luaExportHelper.m_strategyButton = strategyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA89 RID: 113289 RVA: 0x0086DF54 File Offset: 0x0086C154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementButtonText(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_achievementButtonText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA8A RID: 113290 RVA: 0x0086DFAC File Offset: 0x0086C1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementButtonText(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Text achievementButtonText;
			LuaObject.checkType<Text>(l, 2, out achievementButtonText);
			battlePauseUIController.m_luaExportHelper.m_achievementButtonText = achievementButtonText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA8B RID: 113291 RVA: 0x0086E008 File Offset: 0x0086C208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_turnGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA8C RID: 113292 RVA: 0x0086E060 File Offset: 0x0086C260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject turnGameObject;
			LuaObject.checkType<GameObject>(l, 2, out turnGameObject);
			battlePauseUIController.m_luaExportHelper.m_turnGameObject = turnGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA8D RID: 113293 RVA: 0x0086E0BC File Offset: 0x0086C2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnText(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_turnText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA8E RID: 113294 RVA: 0x0086E114 File Offset: 0x0086C314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnText(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Text turnText;
			LuaObject.checkType<Text>(l, 2, out turnText);
			battlePauseUIController.m_luaExportHelper.m_turnText = turnText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA8F RID: 113295 RVA: 0x0086E170 File Offset: 0x0086C370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_winConditionGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA90 RID: 113296 RVA: 0x0086E1C8 File Offset: 0x0086C3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject winConditionGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out winConditionGroupGameObject);
			battlePauseUIController.m_luaExportHelper.m_winConditionGroupGameObject = winConditionGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA91 RID: 113297 RVA: 0x0086E224 File Offset: 0x0086C424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loseConditionGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_loseConditionGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA92 RID: 113298 RVA: 0x0086E27C File Offset: 0x0086C47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loseConditionGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject loseConditionGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out loseConditionGroupGameObject);
			battlePauseUIController.m_luaExportHelper.m_loseConditionGroupGameObject = loseConditionGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA93 RID: 113299 RVA: 0x0086E2D8 File Offset: 0x0086C4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starConditionGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_starConditionGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA94 RID: 113300 RVA: 0x0086E330 File Offset: 0x0086C530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starConditionGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject starConditionGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out starConditionGroupGameObject);
			battlePauseUIController.m_luaExportHelper.m_starConditionGroupGameObject = starConditionGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA95 RID: 113301 RVA: 0x0086E38C File Offset: 0x0086C58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapTerrainGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapTerrainGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA96 RID: 113302 RVA: 0x0086E3E4 File Offset: 0x0086C5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapTerrainGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject mapTerrainGameObject;
			LuaObject.checkType<GameObject>(l, 2, out mapTerrainGameObject);
			battlePauseUIController.m_luaExportHelper.m_mapTerrainGameObject = mapTerrainGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA97 RID: 113303 RVA: 0x0086E440 File Offset: 0x0086C640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapRegionGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapRegionGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA98 RID: 113304 RVA: 0x0086E498 File Offset: 0x0086C698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapRegionGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject mapRegionGameObject;
			LuaObject.checkType<GameObject>(l, 2, out mapRegionGameObject);
			battlePauseUIController.m_luaExportHelper.m_mapRegionGameObject = mapRegionGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA99 RID: 113305 RVA: 0x0086E4F4 File Offset: 0x0086C6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapActorGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapActorGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA9A RID: 113306 RVA: 0x0086E54C File Offset: 0x0086C74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapActorGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject mapActorGameObject;
			LuaObject.checkType<GameObject>(l, 2, out mapActorGameObject);
			battlePauseUIController.m_luaExportHelper.m_mapActorGameObject = mapActorGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA9B RID: 113307 RVA: 0x0086E5A8 File Offset: 0x0086C7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_achievementUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA9C RID: 113308 RVA: 0x0086E600 File Offset: 0x0086C800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			CommonUIStateController achievementUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out achievementUIStateController);
			battlePauseUIController.m_luaExportHelper.m_achievementUIStateController = achievementUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA9D RID: 113309 RVA: 0x0086E65C File Offset: 0x0086C85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_achievementScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA9E RID: 113310 RVA: 0x0086E6B4 File Offset: 0x0086C8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			ScrollRect achievementScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out achievementScrollRect);
			battlePauseUIController.m_luaExportHelper.m_achievementScrollRect = achievementScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA9F RID: 113311 RVA: 0x0086E710 File Offset: 0x0086C910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_achievementBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA0 RID: 113312 RVA: 0x0086E768 File Offset: 0x0086C968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button achievementBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out achievementBackgroundButton);
			battlePauseUIController.m_luaExportHelper.m_achievementBackgroundButton = achievementBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA1 RID: 113313 RVA: 0x0086E7C4 File Offset: 0x0086C9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_strategyUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_strategyUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA2 RID: 113314 RVA: 0x0086E81C File Offset: 0x0086CA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_strategyUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			CommonUIStateController strategyUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out strategyUIStateController);
			battlePauseUIController.m_luaExportHelper.m_strategyUIStateController = strategyUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA3 RID: 113315 RVA: 0x0086E878 File Offset: 0x0086CA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_strategyBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_strategyBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA4 RID: 113316 RVA: 0x0086E8D0 File Offset: 0x0086CAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_strategyBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Button strategyBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out strategyBackgroundButton);
			battlePauseUIController.m_luaExportHelper.m_strategyBackgroundButton = strategyBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA5 RID: 113317 RVA: 0x0086E92C File Offset: 0x0086CB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_strategyContentText(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_strategyContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA6 RID: 113318 RVA: 0x0086E984 File Offset: 0x0086CB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_strategyContentText(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Text strategyContentText;
			LuaObject.checkType<Text>(l, 2, out strategyContentText);
			battlePauseUIController.m_luaExportHelper.m_strategyContentText = strategyContentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA7 RID: 113319 RVA: 0x0086E9E0 File Offset: 0x0086CBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuContent(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_danmakuContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA8 RID: 113320 RVA: 0x0086EA38 File Offset: 0x0086CC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuContent(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject danmakuContent;
			LuaObject.checkType<GameObject>(l, 2, out danmakuContent);
			battlePauseUIController.m_luaExportHelper.m_danmakuContent = danmakuContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAA9 RID: 113321 RVA: 0x0086EA94 File Offset: 0x0086CC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAAA RID: 113322 RVA: 0x0086EAEC File Offset: 0x0086CCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battlePauseUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAAB RID: 113323 RVA: 0x0086EB48 File Offset: 0x0086CD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapTerrainPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapTerrainPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAAC RID: 113324 RVA: 0x0086EBA0 File Offset: 0x0086CDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapTerrainPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject mapTerrainPrefab;
			LuaObject.checkType<GameObject>(l, 2, out mapTerrainPrefab);
			battlePauseUIController.m_luaExportHelper.m_mapTerrainPrefab = mapTerrainPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAAD RID: 113325 RVA: 0x0086EBFC File Offset: 0x0086CDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapActor0Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapActor0Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAAE RID: 113326 RVA: 0x0086EC54 File Offset: 0x0086CE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapActor0Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject mapActor0Prefab;
			LuaObject.checkType<GameObject>(l, 2, out mapActor0Prefab);
			battlePauseUIController.m_luaExportHelper.m_mapActor0Prefab = mapActor0Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAAF RID: 113327 RVA: 0x0086ECB0 File Offset: 0x0086CEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapActor1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapActor1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB0 RID: 113328 RVA: 0x0086ED08 File Offset: 0x0086CF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapActor1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject mapActor1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out mapActor1Prefab);
			battlePauseUIController.m_luaExportHelper.m_mapActor1Prefab = mapActor1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB1 RID: 113329 RVA: 0x0086ED64 File Offset: 0x0086CF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapActor2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapActor2Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB2 RID: 113330 RVA: 0x0086EDBC File Offset: 0x0086CFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapActor2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject mapActor2Prefab;
			LuaObject.checkType<GameObject>(l, 2, out mapActor2Prefab);
			battlePauseUIController.m_luaExportHelper.m_mapActor2Prefab = mapActor2Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB3 RID: 113331 RVA: 0x0086EE18 File Offset: 0x0086D018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapReachPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapReachPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB4 RID: 113332 RVA: 0x0086EE70 File Offset: 0x0086D070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapReachPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject mapReachPrefab;
			LuaObject.checkType<GameObject>(l, 2, out mapReachPrefab);
			battlePauseUIController.m_luaExportHelper.m_mapReachPrefab = mapReachPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB5 RID: 113333 RVA: 0x0086EECC File Offset: 0x0086D0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_conditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_conditionPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB6 RID: 113334 RVA: 0x0086EF24 File Offset: 0x0086D124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_conditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject conditionPrefab;
			LuaObject.checkType<GameObject>(l, 2, out conditionPrefab);
			battlePauseUIController.m_luaExportHelper.m_conditionPrefab = conditionPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB7 RID: 113335 RVA: 0x0086EF80 File Offset: 0x0086D180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_danmakuItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB8 RID: 113336 RVA: 0x0086EFD8 File Offset: 0x0086D1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			GameObject danmakuItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out danmakuItemPrefab);
			battlePauseUIController.m_luaExportHelper.m_danmakuItemPrefab = danmakuItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAB9 RID: 113337 RVA: 0x0086F034 File Offset: 0x0086D234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuItemUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_danmakuItemUICtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BABA RID: 113338 RVA: 0x0086F08C File Offset: 0x0086D28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuItemUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			List<DanmakuItemUIController> danmakuItemUICtrlList;
			LuaObject.checkType<List<DanmakuItemUIController>>(l, 2, out danmakuItemUICtrlList);
			battlePauseUIController.m_luaExportHelper.m_danmakuItemUICtrlList = danmakuItemUICtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BABB RID: 113339 RVA: 0x0086F0E8 File Offset: 0x0086D2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementItems(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_achievementItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BABC RID: 113340 RVA: 0x0086F140 File Offset: 0x0086D340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementItems(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			List<BattleAchievementItemUIController> achievementItems;
			LuaObject.checkType<List<BattleAchievementItemUIController>>(l, 2, out achievementItems);
			battlePauseUIController.m_luaExportHelper.m_achievementItems = achievementItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BABD RID: 113341 RVA: 0x0086F19C File Offset: 0x0086D39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_achievementCountMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BABE RID: 113342 RVA: 0x0086F1F4 File Offset: 0x0086D3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementCountMax(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			int achievementCountMax;
			LuaObject.checkType(l, 2, out achievementCountMax);
			battlePauseUIController.m_luaExportHelper.m_achievementCountMax = achievementCountMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BABF RID: 113343 RVA: 0x0086F250 File Offset: 0x0086D450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapWidth(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAC0 RID: 113344 RVA: 0x0086F2A8 File Offset: 0x0086D4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapWidth(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			int mapWidth;
			LuaObject.checkType(l, 2, out mapWidth);
			battlePauseUIController.m_luaExportHelper.m_mapWidth = mapWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAC1 RID: 113345 RVA: 0x0086F304 File Offset: 0x0086D504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapHeight(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAC2 RID: 113346 RVA: 0x0086F35C File Offset: 0x0086D55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapHeight(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			int mapHeight;
			LuaObject.checkType(l, 2, out mapHeight);
			battlePauseUIController.m_luaExportHelper.m_mapHeight = mapHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAC3 RID: 113347 RVA: 0x0086F3B8 File Offset: 0x0086D5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapTileSize(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_mapTileSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAC4 RID: 113348 RVA: 0x0086F410 File Offset: 0x0086D610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapTileSize(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			Vector2 mapTileSize;
			LuaObject.checkType(l, 2, out mapTileSize);
			battlePauseUIController.m_luaExportHelper.m_mapTileSize = mapTileSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAC5 RID: 113349 RVA: 0x0086F46C File Offset: 0x0086D66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePauseUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAC6 RID: 113350 RVA: 0x0086F4C4 File Offset: 0x0086D6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePauseUIController battlePauseUIController = (BattlePauseUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			battlePauseUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BAC7 RID: 113351 RVA: 0x0086F520 File Offset: 0x0086D720
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePauseUIController");
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.ShowStrategyButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetWinLoseConditions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetStarCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetAchievementCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetMapActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetMapReachRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.ClearMapAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.SetConditionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.AddCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.ShowAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.HideAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.AddAchievementItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.ClearAchievementItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.ClearMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.CreateMapActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.ClearMapActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.ClearMapReachRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.GridPositionToMapPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.OnExitButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.OnAchievementButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.OnStrategyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.UpdateStrategyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.Co_StartDanmakuItemsTweenPos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.OnStrategyBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.OnSetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.OnAchievementBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callDele_EventOnExit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__clearDele_EventOnExit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__callDele_EventOnShowPlayerSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.__clearDele_EventOnShowPlayerSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache34);
		string name = "EventOnExit";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_EventOnExit);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache35, true);
		string name2 = "EventOnClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache36, true);
		string name3 = "EventOnShowPlayerSetting";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_EventOnShowPlayerSetting);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache37, true);
		string name4 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_uiStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache39, true);
		string name5 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_backgroundButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3B, true);
		string name6 = "m_closeButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_closeButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_closeButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3D, true);
		string name7 = "m_exitButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_exitButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_exitButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache3F, true);
		string name8 = "m_achievementButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_achievementButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_achievementButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache41, true);
		string name9 = "m_settingButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_settingButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_settingButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache43, true);
		string name10 = "m_strategyButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_strategyButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_strategyButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache45, true);
		string name11 = "m_achievementButtonText";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_achievementButtonText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_achievementButtonText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache47, true);
		string name12 = "m_turnGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_turnGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_turnGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache49, true);
		string name13 = "m_turnText";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_turnText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_turnText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4B, true);
		string name14 = "m_winConditionGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_winConditionGroupGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_winConditionGroupGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4D, true);
		string name15 = "m_loseConditionGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_loseConditionGroupGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_loseConditionGroupGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache4F, true);
		string name16 = "m_starConditionGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_starConditionGroupGameObject);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_starConditionGroupGameObject);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache51, true);
		string name17 = "m_mapTerrainGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapTerrainGameObject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapTerrainGameObject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache53, true);
		string name18 = "m_mapRegionGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapRegionGameObject);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapRegionGameObject);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache55, true);
		string name19 = "m_mapActorGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapActorGameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapActorGameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache57, true);
		string name20 = "m_achievementUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_achievementUIStateController);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_achievementUIStateController);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache59, true);
		string name21 = "m_achievementScrollRect";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_achievementScrollRect);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_achievementScrollRect);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5B, true);
		string name22 = "m_achievementBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_achievementBackgroundButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_achievementBackgroundButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5D, true);
		string name23 = "m_strategyUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_strategyUIStateController);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_strategyUIStateController);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache5F, true);
		string name24 = "m_strategyBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_strategyBackgroundButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_strategyBackgroundButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache61, true);
		string name25 = "m_strategyContentText";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_strategyContentText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_strategyContentText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache63, true);
		string name26 = "m_danmakuContent";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_danmakuContent);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_danmakuContent);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache65, true);
		string name27 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache67, true);
		string name28 = "m_mapTerrainPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapTerrainPrefab);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapTerrainPrefab);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache69, true);
		string name29 = "m_mapActor0Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapActor0Prefab);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapActor0Prefab);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6B, true);
		string name30 = "m_mapActor1Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapActor1Prefab);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapActor1Prefab);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6D, true);
		string name31 = "m_mapActor2Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapActor2Prefab);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapActor2Prefab);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache6F, true);
		string name32 = "m_mapReachPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapReachPrefab);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapReachPrefab);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache71, true);
		string name33 = "m_conditionPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_conditionPrefab);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_conditionPrefab);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache73, true);
		string name34 = "m_danmakuItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_danmakuItemPrefab);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_danmakuItemPrefab);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache75, true);
		string name35 = "m_danmakuItemUICtrlList";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_danmakuItemUICtrlList);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_danmakuItemUICtrlList);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache77, true);
		string name36 = "m_achievementItems";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_achievementItems);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_achievementItems);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache79, true);
		string name37 = "m_achievementCountMax";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_achievementCountMax);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_achievementCountMax);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7B, true);
		string name38 = "m_mapWidth";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapWidth);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapWidth);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7D, true);
		string name39 = "m_mapHeight";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapHeight);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapHeight);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache7F, true);
		string name40 = "m_mapTileSize";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_mapTileSize);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_mapTileSize);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache81, true);
		string name41 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.get_m_isOpened);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BattlePauseUIController.<>f__mg$cache83, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattlePauseUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011CD7 RID: 72919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011CD8 RID: 72920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011CD9 RID: 72921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011CDA RID: 72922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011CDB RID: 72923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011CDC RID: 72924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011CDD RID: 72925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011CDE RID: 72926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011CDF RID: 72927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011CE0 RID: 72928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011CE1 RID: 72929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011CE2 RID: 72930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011CE3 RID: 72931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011CE4 RID: 72932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011CE5 RID: 72933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011CE6 RID: 72934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011CE7 RID: 72935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011CE8 RID: 72936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011CE9 RID: 72937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011CEA RID: 72938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011CEB RID: 72939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011CEC RID: 72940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011CED RID: 72941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011CEE RID: 72942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011CEF RID: 72943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011CF0 RID: 72944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011CF1 RID: 72945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011CF2 RID: 72946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011CF3 RID: 72947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011CF4 RID: 72948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011CF5 RID: 72949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011CF6 RID: 72950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011CF7 RID: 72951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011CF8 RID: 72952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011CF9 RID: 72953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011CFA RID: 72954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011CFB RID: 72955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011CFC RID: 72956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011CFD RID: 72957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011CFE RID: 72958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011CFF RID: 72959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011D00 RID: 72960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011D01 RID: 72961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011D02 RID: 72962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011D03 RID: 72963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011D04 RID: 72964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011D05 RID: 72965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011D06 RID: 72966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011D07 RID: 72967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011D08 RID: 72968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011D09 RID: 72969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011D0A RID: 72970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011D0B RID: 72971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011D0C RID: 72972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011D0D RID: 72973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011D0E RID: 72974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011D0F RID: 72975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011D10 RID: 72976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011D11 RID: 72977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011D12 RID: 72978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011D13 RID: 72979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011D14 RID: 72980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011D15 RID: 72981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011D16 RID: 72982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011D17 RID: 72983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011D18 RID: 72984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011D19 RID: 72985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04011D1A RID: 72986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04011D1B RID: 72987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04011D1C RID: 72988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011D1D RID: 72989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011D1E RID: 72990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011D1F RID: 72991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011D20 RID: 72992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011D21 RID: 72993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011D22 RID: 72994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011D23 RID: 72995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011D24 RID: 72996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011D25 RID: 72997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04011D26 RID: 72998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04011D27 RID: 72999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04011D28 RID: 73000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04011D29 RID: 73001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04011D2A RID: 73002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04011D2B RID: 73003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04011D2C RID: 73004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04011D2D RID: 73005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04011D2E RID: 73006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04011D2F RID: 73007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011D30 RID: 73008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011D31 RID: 73009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011D32 RID: 73010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011D33 RID: 73011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011D34 RID: 73012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011D35 RID: 73013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04011D36 RID: 73014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04011D37 RID: 73015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04011D38 RID: 73016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04011D39 RID: 73017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04011D3A RID: 73018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04011D3B RID: 73019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04011D3C RID: 73020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04011D3D RID: 73021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04011D3E RID: 73022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04011D3F RID: 73023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011D40 RID: 73024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04011D41 RID: 73025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04011D42 RID: 73026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04011D43 RID: 73027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04011D44 RID: 73028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04011D45 RID: 73029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04011D46 RID: 73030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04011D47 RID: 73031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04011D48 RID: 73032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04011D49 RID: 73033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04011D4A RID: 73034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04011D4B RID: 73035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04011D4C RID: 73036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04011D4D RID: 73037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04011D4E RID: 73038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04011D4F RID: 73039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04011D50 RID: 73040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04011D51 RID: 73041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04011D52 RID: 73042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04011D53 RID: 73043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04011D54 RID: 73044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04011D55 RID: 73045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04011D56 RID: 73046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04011D57 RID: 73047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04011D58 RID: 73048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04011D59 RID: 73049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04011D5A RID: 73050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;
}
