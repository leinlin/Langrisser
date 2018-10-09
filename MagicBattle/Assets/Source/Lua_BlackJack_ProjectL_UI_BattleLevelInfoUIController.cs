using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013A2 RID: 5026
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController : LuaObject
{
	// Token: 0x0601B893 RID: 112787 RVA: 0x0085ECE8 File Offset: 0x0085CEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevel;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevel);
			battleLevelInfoUIController.SetRiftLevel(riftLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B894 RID: 112788 RVA: 0x0085ED40 File Offset: 0x0085CF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo heroDungeonLevel;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out heroDungeonLevel);
			battleLevelInfoUIController.SetHeroDungeonLevel(heroDungeonLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B895 RID: 112789 RVA: 0x0085ED98 File Offset: 0x0085CF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStars(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			int stars;
			LuaObject.checkType(l, 2, out stars);
			battleLevelInfoUIController.SetStars(stars);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B896 RID: 112790 RVA: 0x0085EDF0 File Offset: 0x0085CFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCanChallengeCount(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			int canChallengeCount;
			LuaObject.checkType(l, 2, out canChallengeCount);
			battleLevelInfoUIController.SetCanChallengeCount(canChallengeCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B897 RID: 112791 RVA: 0x0085EE48 File Offset: 0x0085D048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleTreasureCount(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			int countMax;
			LuaObject.checkType(l, 3, out countMax);
			battleLevelInfoUIController.SetBattleTreasureCount(count, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B898 RID: 112792 RVA: 0x0085EEAC File Offset: 0x0085D0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAchievementCount(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			int countMax;
			LuaObject.checkType(l, 3, out countMax);
			battleLevelInfoUIController.SetAchievementCount(count, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B899 RID: 112793 RVA: 0x0085EF10 File Offset: 0x0085D110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRaidTicketCount(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			int raidTicketCount;
			LuaObject.checkType(l, 2, out raidTicketCount);
			battleLevelInfoUIController.SetRaidTicketCount(raidTicketCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B89A RID: 112794 RVA: 0x0085EF68 File Offset: 0x0085D168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReward(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			List<Goods> goodList;
			LuaObject.checkType<List<Goods>>(l, 2, out goodList);
			bool firstWin;
			LuaObject.checkType(l, 3, out firstWin);
			battleLevelInfoUIController.SetReward(goodList, firstWin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B89B RID: 112795 RVA: 0x0085EFCC File Offset: 0x0085D1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 2, out achievements);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 3, out battleType);
			battleLevelInfoUIController.ShowAchievement(achievements, battleType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B89C RID: 112796 RVA: 0x0085F030 File Offset: 0x0085D230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRiftLevelShowByType(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			RiftLevelType riftLevelShowByType;
			LuaObject.checkEnum<RiftLevelType>(l, 2, out riftLevelShowByType);
			battleLevelInfoUIController.SetRiftLevelShowByType(riftLevelShowByType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B89D RID: 112797 RVA: 0x0085F088 File Offset: 0x0085D288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LevelInfoOpenTween(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.LevelInfoOpenTween();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B89E RID: 112798 RVA: 0x0085F0D4 File Offset: 0x0085D2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EventLevelInfoOpenTween(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.EventLevelInfoOpenTween();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B89F RID: 112799 RVA: 0x0085F120 File Offset: 0x0085D320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A0 RID: 112800 RVA: 0x0085F174 File Offset: 0x0085D374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWinCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			string winCondition;
			LuaObject.checkType(l, 2, out winCondition);
			battleLevelInfoUIController.m_luaExportHelper.SetWinCondition(winCondition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A1 RID: 112801 RVA: 0x0085F1D0 File Offset: 0x0085D3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAchievementItem(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			ConfigDataBattleAchievementInfo achievementInfo;
			LuaObject.checkType<ConfigDataBattleAchievementInfo>(l, 2, out achievementInfo);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 3, out rewards);
			GameObject prefab;
			LuaObject.checkType<GameObject>(l, 4, out prefab);
			bool complete;
			LuaObject.checkType(l, 5, out complete);
			battleLevelInfoUIController.m_luaExportHelper.AddAchievementItem(achievementInfo, rewards, prefab, complete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A2 RID: 112802 RVA: 0x0085F254 File Offset: 0x0085D454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAchievementItems(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.ClearAchievementItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A3 RID: 112803 RVA: 0x0085F2A8 File Offset: 0x0085D4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A4 RID: 112804 RVA: 0x0085F2FC File Offset: 0x0085D4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A5 RID: 112805 RVA: 0x0085F350 File Offset: 0x0085D550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRaidButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.OnRaidButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A6 RID: 112806 RVA: 0x0085F3A4 File Offset: 0x0085D5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAchievementButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.OnAchievementButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A7 RID: 112807 RVA: 0x0085F3F8 File Offset: 0x0085D5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAchievementBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.OnAchievementBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A8 RID: 112808 RVA: 0x0085F44C File Offset: 0x0085D64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8A9 RID: 112809 RVA: 0x0085F4B8 File Offset: 0x0085D6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8AA RID: 112810 RVA: 0x0085F50C File Offset: 0x0085D70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8AB RID: 112811 RVA: 0x0085F560 File Offset: 0x0085D760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleLevelInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B8AC RID: 112812 RVA: 0x0085F608 File Offset: 0x0085D808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8AD RID: 112813 RVA: 0x0085F65C File Offset: 0x0085D85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8AE RID: 112814 RVA: 0x0085F6C8 File Offset: 0x0085D8C8
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
				BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleLevelInfoUIController battleLevelInfoUIController2 = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleLevelInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B8AF RID: 112815 RVA: 0x0085F7D8 File Offset: 0x0085D9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8B0 RID: 112816 RVA: 0x0085F844 File Offset: 0x0085DA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8B1 RID: 112817 RVA: 0x0085F8B0 File Offset: 0x0085DAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8B2 RID: 112818 RVA: 0x0085F91C File Offset: 0x0085DB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8B3 RID: 112819 RVA: 0x0085F988 File Offset: 0x0085DB88
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
				BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleLevelInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleLevelInfoUIController battleLevelInfoUIController2 = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleLevelInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B8B4 RID: 112820 RVA: 0x0085FA98 File Offset: 0x0085DC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			string s = battleLevelInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B8B5 RID: 112821 RVA: 0x0085FAF4 File Offset: 0x0085DCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__callDele_EventOnStartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8B6 RID: 112822 RVA: 0x0085FB48 File Offset: 0x0085DD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__clearDele_EventOnStartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8B7 RID: 112823 RVA: 0x0085FB9C File Offset: 0x0085DD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRaidBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleLevelInfoUIController.m_luaExportHelper.__callDele_EventOnRaidBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8B8 RID: 112824 RVA: 0x0085FBF8 File Offset: 0x0085DDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRaidBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			battleLevelInfoUIController.m_luaExportHelper.__clearDele_EventOnRaidBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8B9 RID: 112825 RVA: 0x0085FC54 File Offset: 0x0085DE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__callDele_EventOnShowAchievement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8BA RID: 112826 RVA: 0x0085FCA8 File Offset: 0x0085DEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__clearDele_EventOnShowAchievement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8BB RID: 112827 RVA: 0x0085FCFC File Offset: 0x0085DEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8BC RID: 112828 RVA: 0x0085FD50 File Offset: 0x0085DF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			battleLevelInfoUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8BD RID: 112829 RVA: 0x0085FDA4 File Offset: 0x0085DFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleLevelInfoUIController.EventOnStartBattle += value;
				}
				else if (num == 2)
				{
					battleLevelInfoUIController.EventOnStartBattle -= value;
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

	// Token: 0x0601B8BE RID: 112830 RVA: 0x0085FE24 File Offset: 0x0085E024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRaidBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleLevelInfoUIController.EventOnRaidBattle += value;
				}
				else if (num == 2)
				{
					battleLevelInfoUIController.EventOnRaidBattle -= value;
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

	// Token: 0x0601B8BF RID: 112831 RVA: 0x0085FEA4 File Offset: 0x0085E0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleLevelInfoUIController.EventOnShowAchievement += value;
				}
				else if (num == 2)
				{
					battleLevelInfoUIController.EventOnShowAchievement -= value;
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

	// Token: 0x0601B8C0 RID: 112832 RVA: 0x0085FF24 File Offset: 0x0085E124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleLevelInfoUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleLevelInfoUIController.EventOnClose -= value;
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

	// Token: 0x0601B8C1 RID: 112833 RVA: 0x0085FFA4 File Offset: 0x0085E1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8C2 RID: 112834 RVA: 0x0085FFFC File Offset: 0x0085E1FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			battleLevelInfoUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8C3 RID: 112835 RVA: 0x00860058 File Offset: 0x0085E258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_nameGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8C4 RID: 112836 RVA: 0x008600B0 File Offset: 0x0085E2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject nameGameObject;
			LuaObject.checkType<GameObject>(l, 2, out nameGameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_nameGameObject = nameGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8C5 RID: 112837 RVA: 0x0086010C File Offset: 0x0085E30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8C6 RID: 112838 RVA: 0x00860164 File Offset: 0x0085E364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			battleLevelInfoUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8C7 RID: 112839 RVA: 0x008601C0 File Offset: 0x0085E3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameNumberText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_nameNumberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8C8 RID: 112840 RVA: 0x00860218 File Offset: 0x0085E418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameNumberText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text nameNumberText;
			LuaObject.checkType<Text>(l, 2, out nameNumberText);
			battleLevelInfoUIController.m_luaExportHelper.m_nameNumberText = nameNumberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8C9 RID: 112841 RVA: 0x00860274 File Offset: 0x0085E474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8CA RID: 112842 RVA: 0x008602CC File Offset: 0x0085E4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			battleLevelInfoUIController.m_luaExportHelper.m_descText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8CB RID: 112843 RVA: 0x00860328 File Offset: 0x0085E528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hardText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_hardText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8CC RID: 112844 RVA: 0x00860380 File Offset: 0x0085E580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hardText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text hardText;
			LuaObject.checkType<Text>(l, 2, out hardText);
			battleLevelInfoUIController.m_luaExportHelper.m_hardText = hardText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8CD RID: 112845 RVA: 0x008603DC File Offset: 0x0085E5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionGroup(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_winConditionGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8CE RID: 112846 RVA: 0x00860434 File Offset: 0x0085E634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionGroup(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject winConditionGroup;
			LuaObject.checkType<GameObject>(l, 2, out winConditionGroup);
			battleLevelInfoUIController.m_luaExportHelper.m_winConditionGroup = winConditionGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8CF RID: 112847 RVA: 0x00860490 File Offset: 0x0085E690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_treasureGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D0 RID: 112848 RVA: 0x008604E8 File Offset: 0x0085E6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject treasureGameObject;
			LuaObject.checkType<GameObject>(l, 2, out treasureGameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_treasureGameObject = treasureGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D1 RID: 112849 RVA: 0x00860544 File Offset: 0x0085E744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_treasureCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D2 RID: 112850 RVA: 0x0086059C File Offset: 0x0085E79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text treasureCountText;
			LuaObject.checkType<Text>(l, 2, out treasureCountText);
			battleLevelInfoUIController.m_luaExportHelper.m_treasureCountText = treasureCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D3 RID: 112851 RVA: 0x008605F8 File Offset: 0x0085E7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allStarsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_allStarsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D4 RID: 112852 RVA: 0x00860650 File Offset: 0x0085E850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allStarsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject allStarsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out allStarsGameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_allStarsGameObject = allStarsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D5 RID: 112853 RVA: 0x008606AC File Offset: 0x0085E8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star1GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_star1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D6 RID: 112854 RVA: 0x00860704 File Offset: 0x0085E904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star1GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject star1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star1GameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_star1GameObject = star1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D7 RID: 112855 RVA: 0x00860760 File Offset: 0x0085E960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star2GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_star2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D8 RID: 112856 RVA: 0x008607B8 File Offset: 0x0085E9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star2GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject star2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star2GameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_star2GameObject = star2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8D9 RID: 112857 RVA: 0x00860814 File Offset: 0x0085EA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star3GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_star3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8DA RID: 112858 RVA: 0x0086086C File Offset: 0x0085EA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star3GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject star3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star3GameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_star3GameObject = star3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8DB RID: 112859 RVA: 0x008608C8 File Offset: 0x0085EAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8DC RID: 112860 RVA: 0x00860920 File Offset: 0x0085EB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			battleLevelInfoUIController.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8DD RID: 112861 RVA: 0x0086097C File Offset: 0x0085EB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardTitleGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_rewardTitleGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8DE RID: 112862 RVA: 0x008609D4 File Offset: 0x0085EBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardTitleGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject rewardTitleGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardTitleGameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_rewardTitleGameObject = rewardTitleGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8DF RID: 112863 RVA: 0x00860A30 File Offset: 0x0085EC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardTitle2GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_rewardTitle2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E0 RID: 112864 RVA: 0x00860A88 File Offset: 0x0085EC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardTitle2GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject rewardTitle2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardTitle2GameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_rewardTitle2GameObject = rewardTitle2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E1 RID: 112865 RVA: 0x00860AE4 File Offset: 0x0085ECE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E2 RID: 112866 RVA: 0x00860B3C File Offset: 0x0085ED3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E3 RID: 112867 RVA: 0x00860B98 File Offset: 0x0085ED98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_challengeGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E4 RID: 112868 RVA: 0x00860BF0 File Offset: 0x0085EDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject challengeGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out challengeGroupGameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_challengeGroupGameObject = challengeGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E5 RID: 112869 RVA: 0x00860C4C File Offset: 0x0085EE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_challengeCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E6 RID: 112870 RVA: 0x00860CA4 File Offset: 0x0085EEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeCountText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text challengeCountText;
			LuaObject.checkType<Text>(l, 2, out challengeCountText);
			battleLevelInfoUIController.m_luaExportHelper.m_challengeCountText = challengeCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E7 RID: 112871 RVA: 0x00860D00 File Offset: 0x0085EF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_achievementButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E8 RID: 112872 RVA: 0x00860D58 File Offset: 0x0085EF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Button achievementButton;
			LuaObject.checkType<Button>(l, 2, out achievementButton);
			battleLevelInfoUIController.m_luaExportHelper.m_achievementButton = achievementButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8E9 RID: 112873 RVA: 0x00860DB4 File Offset: 0x0085EFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementButtonText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_achievementButtonText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8EA RID: 112874 RVA: 0x00860E0C File Offset: 0x0085F00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementButtonText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text achievementButtonText;
			LuaObject.checkType<Text>(l, 2, out achievementButtonText);
			battleLevelInfoUIController.m_luaExportHelper.m_achievementButtonText = achievementButtonText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8EB RID: 112875 RVA: 0x00860E68 File Offset: 0x0085F068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8EC RID: 112876 RVA: 0x00860EC0 File Offset: 0x0085F0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			battleLevelInfoUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8ED RID: 112877 RVA: 0x00860F1C File Offset: 0x0085F11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8EE RID: 112878 RVA: 0x00860F74 File Offset: 0x0085F174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			battleLevelInfoUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8EF RID: 112879 RVA: 0x00860FD0 File Offset: 0x0085F1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidTicketText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_raidTicketText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F0 RID: 112880 RVA: 0x00861028 File Offset: 0x0085F228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidTicketText(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Text raidTicketText;
			LuaObject.checkType<Text>(l, 2, out raidTicketText);
			battleLevelInfoUIController.m_luaExportHelper.m_raidTicketText = raidTicketText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F1 RID: 112881 RVA: 0x00861084 File Offset: 0x0085F284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_raidButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F2 RID: 112882 RVA: 0x008610DC File Offset: 0x0085F2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Button raidButton;
			LuaObject.checkType<Button>(l, 2, out raidButton);
			battleLevelInfoUIController.m_luaExportHelper.m_raidButton = raidButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F3 RID: 112883 RVA: 0x00861138 File Offset: 0x0085F338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F4 RID: 112884 RVA: 0x00861190 File Offset: 0x0085F390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			battleLevelInfoUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F5 RID: 112885 RVA: 0x008611EC File Offset: 0x0085F3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_achievementUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F6 RID: 112886 RVA: 0x00861244 File Offset: 0x0085F444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController achievementUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out achievementUIStateController);
			battleLevelInfoUIController.m_luaExportHelper.m_achievementUIStateController = achievementUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F7 RID: 112887 RVA: 0x008612A0 File Offset: 0x0085F4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_achievementScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F8 RID: 112888 RVA: 0x008612F8 File Offset: 0x0085F4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			ScrollRect achievementScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out achievementScrollRect);
			battleLevelInfoUIController.m_luaExportHelper.m_achievementScrollRect = achievementScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8F9 RID: 112889 RVA: 0x00861354 File Offset: 0x0085F554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_achievementBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8FA RID: 112890 RVA: 0x008613AC File Offset: 0x0085F5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			Button achievementBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out achievementBackgroundButton);
			battleLevelInfoUIController.m_luaExportHelper.m_achievementBackgroundButton = achievementBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8FB RID: 112891 RVA: 0x00861408 File Offset: 0x0085F608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8FC RID: 112892 RVA: 0x00861460 File Offset: 0x0085F660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battleLevelInfoUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8FD RID: 112893 RVA: 0x008614BC File Offset: 0x0085F6BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_conditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_conditionPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8FE RID: 112894 RVA: 0x00861514 File Offset: 0x0085F714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_conditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject conditionPrefab;
			LuaObject.checkType<GameObject>(l, 2, out conditionPrefab);
			battleLevelInfoUIController.m_luaExportHelper.m_conditionPrefab = conditionPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B8FF RID: 112895 RVA: 0x00861570 File Offset: 0x0085F770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementItems(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelInfoUIController.m_luaExportHelper.m_achievementItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B900 RID: 112896 RVA: 0x008615C8 File Offset: 0x0085F7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementItems(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelInfoUIController battleLevelInfoUIController = (BattleLevelInfoUIController)LuaObject.checkSelf(l);
			List<BattleAchievementItemUIController> achievementItems;
			LuaObject.checkType<List<BattleAchievementItemUIController>>(l, 2, out achievementItems);
			battleLevelInfoUIController.m_luaExportHelper.m_achievementItems = achievementItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B901 RID: 112897 RVA: 0x00861624 File Offset: 0x0085F824
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleLevelInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetHeroDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetCanChallengeCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetBattleTreasureCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetAchievementCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetRaidTicketCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.ShowAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetRiftLevelShowByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.LevelInfoOpenTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.EventLevelInfoOpenTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.SetWinCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.AddAchievementItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.ClearAchievementItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.OnRaidButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.OnAchievementButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.OnAchievementBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callDele_EventOnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__clearDele_EventOnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callDele_EventOnRaidBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__clearDele_EventOnRaidBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callDele_EventOnShowAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__clearDele_EventOnShowAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache29);
		string name = "EventOnStartBattle";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_EventOnStartBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2A, true);
		string name2 = "EventOnRaidBattle";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_EventOnRaidBattle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2B, true);
		string name3 = "EventOnShowAchievement";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_EventOnShowAchievement);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2C, true);
		string name4 = "EventOnClose";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2D, true);
		string name5 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_uiStateController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache2F, true);
		string name6 = "m_nameGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_nameGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_nameGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache31, true);
		string name7 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_nameText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache33, true);
		string name8 = "m_nameNumberText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_nameNumberText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_nameNumberText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache35, true);
		string name9 = "m_descText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_descText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_descText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache37, true);
		string name10 = "m_hardText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_hardText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_hardText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache39, true);
		string name11 = "m_winConditionGroup";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_winConditionGroup);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_winConditionGroup);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3B, true);
		string name12 = "m_treasureGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_treasureGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_treasureGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3D, true);
		string name13 = "m_treasureCountText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_treasureCountText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_treasureCountText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache3F, true);
		string name14 = "m_allStarsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_allStarsGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_allStarsGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache41, true);
		string name15 = "m_star1GameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_star1GameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_star1GameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache43, true);
		string name16 = "m_star2GameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_star2GameObject);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_star2GameObject);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache45, true);
		string name17 = "m_star3GameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_star3GameObject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_star3GameObject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache47, true);
		string name18 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_image);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_image);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache49, true);
		string name19 = "m_rewardTitleGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_rewardTitleGameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_rewardTitleGameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4B, true);
		string name20 = "m_rewardTitle2GameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_rewardTitle2GameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_rewardTitle2GameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4D, true);
		string name21 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache4F, true);
		string name22 = "m_challengeGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_challengeGroupGameObject);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_challengeGroupGameObject);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache51, true);
		string name23 = "m_challengeCountText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_challengeCountText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_challengeCountText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache53, true);
		string name24 = "m_achievementButton";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_achievementButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_achievementButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache55, true);
		string name25 = "m_achievementButtonText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_achievementButtonText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_achievementButtonText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache57, true);
		string name26 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_startButton);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache59, true);
		string name27 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_energyText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5B, true);
		string name28 = "m_raidTicketText";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_raidTicketText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_raidTicketText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5D, true);
		string name29 = "m_raidButton";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_raidButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_raidButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache5F, true);
		string name30 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_backgroundButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache61, true);
		string name31 = "m_achievementUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_achievementUIStateController);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_achievementUIStateController);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache63, true);
		string name32 = "m_achievementScrollRect";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_achievementScrollRect);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_achievementScrollRect);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache65, true);
		string name33 = "m_achievementBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_achievementBackgroundButton);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_achievementBackgroundButton);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache67, true);
		string name34 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache69, true);
		string name35 = "m_conditionPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_conditionPrefab);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_conditionPrefab);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6B, true);
		string name36 = "m_achievementItems";
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.get_m_achievementItems);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.set_m_achievementItems);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.<>f__mg$cache6D, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleLevelInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011B31 RID: 72497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011B32 RID: 72498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011B33 RID: 72499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011B34 RID: 72500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011B35 RID: 72501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011B36 RID: 72502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011B37 RID: 72503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011B38 RID: 72504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011B39 RID: 72505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011B3A RID: 72506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011B3B RID: 72507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011B3C RID: 72508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011B3D RID: 72509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011B3E RID: 72510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011B3F RID: 72511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011B40 RID: 72512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011B41 RID: 72513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011B42 RID: 72514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011B43 RID: 72515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011B44 RID: 72516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011B45 RID: 72517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011B46 RID: 72518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011B47 RID: 72519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011B48 RID: 72520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011B49 RID: 72521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011B4A RID: 72522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011B4B RID: 72523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011B4C RID: 72524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011B4D RID: 72525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011B4E RID: 72526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011B4F RID: 72527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011B50 RID: 72528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011B51 RID: 72529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011B52 RID: 72530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011B53 RID: 72531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011B54 RID: 72532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011B55 RID: 72533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011B56 RID: 72534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011B57 RID: 72535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011B58 RID: 72536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011B59 RID: 72537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011B5A RID: 72538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011B5B RID: 72539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011B5C RID: 72540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011B5D RID: 72541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011B5E RID: 72542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011B5F RID: 72543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011B60 RID: 72544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011B61 RID: 72545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011B62 RID: 72546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011B63 RID: 72547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011B64 RID: 72548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011B65 RID: 72549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011B66 RID: 72550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011B67 RID: 72551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011B68 RID: 72552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011B69 RID: 72553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011B6A RID: 72554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011B6B RID: 72555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011B6C RID: 72556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011B6D RID: 72557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011B6E RID: 72558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011B6F RID: 72559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011B70 RID: 72560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011B71 RID: 72561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011B72 RID: 72562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011B73 RID: 72563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04011B74 RID: 72564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04011B75 RID: 72565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04011B76 RID: 72566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011B77 RID: 72567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011B78 RID: 72568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011B79 RID: 72569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011B7A RID: 72570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011B7B RID: 72571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011B7C RID: 72572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011B7D RID: 72573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011B7E RID: 72574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011B7F RID: 72575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04011B80 RID: 72576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04011B81 RID: 72577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04011B82 RID: 72578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04011B83 RID: 72579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04011B84 RID: 72580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04011B85 RID: 72581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04011B86 RID: 72582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04011B87 RID: 72583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04011B88 RID: 72584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04011B89 RID: 72585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011B8A RID: 72586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011B8B RID: 72587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011B8C RID: 72588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011B8D RID: 72589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011B8E RID: 72590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011B8F RID: 72591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04011B90 RID: 72592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04011B91 RID: 72593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04011B92 RID: 72594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04011B93 RID: 72595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04011B94 RID: 72596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04011B95 RID: 72597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04011B96 RID: 72598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04011B97 RID: 72599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04011B98 RID: 72600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04011B99 RID: 72601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011B9A RID: 72602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04011B9B RID: 72603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04011B9C RID: 72604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04011B9D RID: 72605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04011B9E RID: 72606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;
}
