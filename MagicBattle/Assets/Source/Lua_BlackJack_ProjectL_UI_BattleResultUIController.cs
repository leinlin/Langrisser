using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013B4 RID: 5044
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleResultUIController : LuaObject
{
	// Token: 0x0601BE13 RID: 114195 RVA: 0x0088A8D8 File Offset: 0x00888AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBattleResult(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			List<Hero> heros;
			LuaObject.checkType<List<Hero>>(l, 3, out heros);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			int starTurnMax;
			LuaObject.checkType(l, 5, out starTurnMax);
			int starDeadMax;
			LuaObject.checkType(l, 6, out starDeadMax);
			int turn;
			LuaObject.checkType(l, 7, out turn);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 8, out reward);
			List<int> gotAchievements;
			LuaObject.checkType<List<int>>(l, 9, out gotAchievements);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 10, out achievements);
			battleResultUIController.ShowBattleResult(battleType, heros, stars, starTurnMax, starDeadMax, turn, reward, gotAchievements, achievements);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE14 RID: 114196 RVA: 0x0088A994 File Offset: 0x00888B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE15 RID: 114197 RVA: 0x0088A9E8 File Offset: 0x00888BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowBattleResult(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			List<Hero> heros;
			LuaObject.checkType<List<Hero>>(l, 3, out heros);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			int starTurnMax;
			LuaObject.checkType(l, 5, out starTurnMax);
			int starDeadMax;
			LuaObject.checkType(l, 6, out starDeadMax);
			int turn;
			LuaObject.checkType(l, 7, out turn);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 8, out reward);
			List<int> gotAchievements;
			LuaObject.checkType<List<int>>(l, 9, out gotAchievements);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 10, out achievements);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_ShowBattleResult(battleType, heros, stars, starTurnMax, starDeadMax, turn, reward, gotAchievements, achievements);
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

	// Token: 0x0601BE16 RID: 114198 RVA: 0x0088AAB4 File Offset: 0x00888CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddPlayerExpBarWidth(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			IEnumerator o = battleResultUIController.m_luaExportHelper.AddPlayerExpBarWidth();
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

	// Token: 0x0601BE17 RID: 114199 RVA: 0x0088AB10 File Offset: 0x00888D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTextValue(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			float scale;
			LuaObject.checkType(l, 2, out scale);
			battleResultUIController.m_luaExportHelper.UpdateTextValue(scale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE18 RID: 114200 RVA: 0x0088AB6C File Offset: 0x00888D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowStars(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int stars;
			LuaObject.checkType(l, 3, out stars);
			int starTurnMax;
			LuaObject.checkType(l, 4, out starTurnMax);
			int starDeadMax;
			LuaObject.checkType(l, 5, out starDeadMax);
			int turn;
			LuaObject.checkType(l, 6, out turn);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_ShowStars(battleType, stars, starTurnMax, starDeadMax, turn);
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

	// Token: 0x0601BE19 RID: 114201 RVA: 0x0088AC08 File Offset: 0x00888E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 2, out reward);
			List<Hero> heros;
			LuaObject.checkType<List<Hero>>(l, 3, out heros);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_ShowHeros(reward, heros);
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

	// Token: 0x0601BE1A RID: 114202 RVA: 0x0088AC7C File Offset: 0x00888E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowEnemyBoomToGold(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_ShowEnemyBoomToGold();
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

	// Token: 0x0601BE1B RID: 114203 RVA: 0x0088ACD8 File Offset: 0x00888ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoMoveItemWhenOutOfScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			EnemyBoomToGoldUIController ctrl;
			LuaObject.checkType<EnemyBoomToGoldUIController>(l, 2, out ctrl);
			battleResultUIController.m_luaExportHelper.AutoMoveItemWhenOutOfScrollRect(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE1C RID: 114204 RVA: 0x0088AD34 File Offset: 0x00888F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowPlayerLevelUp(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			int oldLevel;
			LuaObject.checkType(l, 2, out oldLevel);
			int newLevel;
			LuaObject.checkType(l, 3, out newLevel);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_ShowPlayerLevelUp(oldLevel, newLevel);
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

	// Token: 0x0601BE1D RID: 114205 RVA: 0x0088ADA8 File Offset: 0x00888FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowAchievements(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			List<int> gotAchievements;
			LuaObject.checkType<List<int>>(l, 2, out gotAchievements);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 3, out achievements);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_ShowAchievements(gotAchievements, achievements);
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

	// Token: 0x0601BE1E RID: 114206 RVA: 0x0088AE1C File Offset: 0x0088901C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetGoldValueChanged(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			float changeValue;
			LuaObject.checkType(l, 2, out changeValue);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_SetGoldValueChanged(changeValue);
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

	// Token: 0x0601BE1F RID: 114207 RVA: 0x0088AE84 File Offset: 0x00889084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetAndWaitUIState(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out ctrl);
			string state;
			LuaObject.checkType(l, 3, out state);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_SetAndWaitUIState(ctrl, state);
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

	// Token: 0x0601BE20 RID: 114208 RVA: 0x0088AEF8 File Offset: 0x008890F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			IEnumerator o = battleResultUIController.m_luaExportHelper.Co_WaitClick();
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

	// Token: 0x0601BE21 RID: 114209 RVA: 0x0088AF54 File Offset: 0x00889154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerLevelUpUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.PlayerLevelUpUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE22 RID: 114210 RVA: 0x0088AFA8 File Offset: 0x008891A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearHeroItems(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.ClearHeroItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE23 RID: 114211 RVA: 0x0088AFFC File Offset: 0x008891FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE24 RID: 114212 RVA: 0x0088B050 File Offset: 0x00889250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleResultUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE25 RID: 114213 RVA: 0x0088B0BC File Offset: 0x008892BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE26 RID: 114214 RVA: 0x0088B110 File Offset: 0x00889310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE27 RID: 114215 RVA: 0x0088B164 File Offset: 0x00889364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleResultUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601BE28 RID: 114216 RVA: 0x0088B20C File Offset: 0x0088940C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE29 RID: 114217 RVA: 0x0088B260 File Offset: 0x00889460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleResultUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE2A RID: 114218 RVA: 0x0088B2CC File Offset: 0x008894CC
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
				BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleResultUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleResultUIController battleResultUIController2 = (BattleResultUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleResultUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601BE2B RID: 114219 RVA: 0x0088B3DC File Offset: 0x008895DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleResultUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE2C RID: 114220 RVA: 0x0088B448 File Offset: 0x00889648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleResultUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE2D RID: 114221 RVA: 0x0088B4B4 File Offset: 0x008896B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleResultUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE2E RID: 114222 RVA: 0x0088B520 File Offset: 0x00889720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleResultUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE2F RID: 114223 RVA: 0x0088B58C File Offset: 0x0088978C
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
				BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleResultUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleResultUIController battleResultUIController2 = (BattleResultUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleResultUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601BE30 RID: 114224 RVA: 0x0088B69C File Offset: 0x0088989C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			string s = battleResultUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601BE31 RID: 114225 RVA: 0x0088B6F8 File Offset: 0x008898F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE32 RID: 114226 RVA: 0x0088B74C File Offset: 0x0088994C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			battleResultUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE33 RID: 114227 RVA: 0x0088B7A0 File Offset: 0x008899A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleResultUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleResultUIController.EventOnClose -= value;
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

	// Token: 0x0601BE34 RID: 114228 RVA: 0x0088B820 File Offset: 0x00889A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE35 RID: 114229 RVA: 0x0088B878 File Offset: 0x00889A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			battleResultUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE36 RID: 114230 RVA: 0x0088B8D4 File Offset: 0x00889AD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_accountingPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_accountingPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE37 RID: 114231 RVA: 0x0088B92C File Offset: 0x00889B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_accountingPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			CommonUIStateController accountingPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out accountingPanelUIStateController);
			battleResultUIController.m_luaExportHelper.m_accountingPanelUIStateController = accountingPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE38 RID: 114232 RVA: 0x0088B988 File Offset: 0x00889B88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_starsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_starsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE39 RID: 114233 RVA: 0x0088B9E0 File Offset: 0x00889BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject starsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out starsGameObject);
			battleResultUIController.m_luaExportHelper.m_starsGameObject = starsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE3A RID: 114234 RVA: 0x0088BA3C File Offset: 0x00889C3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_star1UIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_star1UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE3B RID: 114235 RVA: 0x0088BA94 File Offset: 0x00889C94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_star1UIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			CommonUIStateController star1UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out star1UIStateController);
			battleResultUIController.m_luaExportHelper.m_star1UIStateController = star1UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE3C RID: 114236 RVA: 0x0088BAF0 File Offset: 0x00889CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star2UIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_star2UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE3D RID: 114237 RVA: 0x0088BB48 File Offset: 0x00889D48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_star2UIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			CommonUIStateController star2UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out star2UIStateController);
			battleResultUIController.m_luaExportHelper.m_star2UIStateController = star2UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE3E RID: 114238 RVA: 0x0088BBA4 File Offset: 0x00889DA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_star2Text(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_star2Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE3F RID: 114239 RVA: 0x0088BBFC File Offset: 0x00889DFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_star2Text(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text star2Text;
			LuaObject.checkType<Text>(l, 2, out star2Text);
			battleResultUIController.m_luaExportHelper.m_star2Text = star2Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE40 RID: 114240 RVA: 0x0088BC58 File Offset: 0x00889E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star3UIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_star3UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE41 RID: 114241 RVA: 0x0088BCB0 File Offset: 0x00889EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star3UIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			CommonUIStateController star3UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out star3UIStateController);
			battleResultUIController.m_luaExportHelper.m_star3UIStateController = star3UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE42 RID: 114242 RVA: 0x0088BD0C File Offset: 0x00889F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star3Text(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_star3Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE43 RID: 114243 RVA: 0x0088BD64 File Offset: 0x00889F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star3Text(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text star3Text;
			LuaObject.checkType<Text>(l, 2, out star3Text);
			battleResultUIController.m_luaExportHelper.m_star3Text = star3Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE44 RID: 114244 RVA: 0x0088BDC0 File Offset: 0x00889FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_arenaResultGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_arenaResultGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE45 RID: 114245 RVA: 0x0088BE18 File Offset: 0x0088A018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_arenaResultGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject arenaResultGameObject;
			LuaObject.checkType<GameObject>(l, 2, out arenaResultGameObject);
			battleResultUIController.m_luaExportHelper.m_arenaResultGameObject = arenaResultGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE46 RID: 114246 RVA: 0x0088BE74 File Offset: 0x0088A074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaPointText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_arenaPointText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE47 RID: 114247 RVA: 0x0088BECC File Offset: 0x0088A0CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_arenaPointText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text arenaPointText;
			LuaObject.checkType<Text>(l, 2, out arenaPointText);
			battleResultUIController.m_luaExportHelper.m_arenaPointText = arenaPointText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE48 RID: 114248 RVA: 0x0088BF28 File Offset: 0x0088A128
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_arenaVictoryPointText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_arenaVictoryPointText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE49 RID: 114249 RVA: 0x0088BF80 File Offset: 0x0088A180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaVictoryPointText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text arenaVictoryPointText;
			LuaObject.checkType<Text>(l, 2, out arenaVictoryPointText);
			battleResultUIController.m_luaExportHelper.m_arenaVictoryPointText = arenaVictoryPointText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE4A RID: 114250 RVA: 0x0088BFDC File Offset: 0x0088A1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaAutoFightGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_arenaAutoFightGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE4B RID: 114251 RVA: 0x0088C034 File Offset: 0x0088A234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_arenaAutoFightGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject arenaAutoFightGameObject;
			LuaObject.checkType<GameObject>(l, 2, out arenaAutoFightGameObject);
			battleResultUIController.m_luaExportHelper.m_arenaAutoFightGameObject = arenaAutoFightGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE4C RID: 114252 RVA: 0x0088C090 File Offset: 0x0088A290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realtimePVPResultGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_realtimePVPResultGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE4D RID: 114253 RVA: 0x0088C0E8 File Offset: 0x0088A2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realtimePVPResultGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject realtimePVPResultGameObject;
			LuaObject.checkType<GameObject>(l, 2, out realtimePVPResultGameObject);
			battleResultUIController.m_luaExportHelper.m_realtimePVPResultGameObject = realtimePVPResultGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE4E RID: 114254 RVA: 0x0088C144 File Offset: 0x0088A344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realtimePVPScoreText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_realtimePVPScoreText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE4F RID: 114255 RVA: 0x0088C19C File Offset: 0x0088A39C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_realtimePVPScoreText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text realtimePVPScoreText;
			LuaObject.checkType<Text>(l, 2, out realtimePVPScoreText);
			battleResultUIController.m_luaExportHelper.m_realtimePVPScoreText = realtimePVPScoreText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE50 RID: 114256 RVA: 0x0088C1F8 File Offset: 0x0088A3F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_realtimePVPWinText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_realtimePVPWinText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE51 RID: 114257 RVA: 0x0088C250 File Offset: 0x0088A450
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_realtimePVPWinText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text realtimePVPWinText;
			LuaObject.checkType<Text>(l, 2, out realtimePVPWinText);
			battleResultUIController.m_luaExportHelper.m_realtimePVPWinText = realtimePVPWinText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE52 RID: 114258 RVA: 0x0088C2AC File Offset: 0x0088A4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_realtimePVPWinBonusGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_realtimePVPWinBonusGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE53 RID: 114259 RVA: 0x0088C304 File Offset: 0x0088A504
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_realtimePVPWinBonusGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject realtimePVPWinBonusGameObject;
			LuaObject.checkType<GameObject>(l, 2, out realtimePVPWinBonusGameObject);
			battleResultUIController.m_luaExportHelper.m_realtimePVPWinBonusGameObject = realtimePVPWinBonusGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE54 RID: 114260 RVA: 0x0088C360 File Offset: 0x0088A560
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_realtimePVPWinBonusText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_realtimePVPWinBonusText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE55 RID: 114261 RVA: 0x0088C3B8 File Offset: 0x0088A5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_realtimePVPWinBonusText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text realtimePVPWinBonusText;
			LuaObject.checkType<Text>(l, 2, out realtimePVPWinBonusText);
			battleResultUIController.m_luaExportHelper.m_realtimePVPWinBonusText = realtimePVPWinBonusText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE56 RID: 114262 RVA: 0x0088C414 File Offset: 0x0088A614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_goldGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE57 RID: 114263 RVA: 0x0088C46C File Offset: 0x0088A66C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_goldGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject goldGameObject;
			LuaObject.checkType<GameObject>(l, 2, out goldGameObject);
			battleResultUIController.m_luaExportHelper.m_goldGameObject = goldGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE58 RID: 114264 RVA: 0x0088C4C8 File Offset: 0x0088A6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_expGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE59 RID: 114265 RVA: 0x0088C520 File Offset: 0x0088A720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject expGameObject;
			LuaObject.checkType<GameObject>(l, 2, out expGameObject);
			battleResultUIController.m_luaExportHelper.m_expGameObject = expGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE5A RID: 114266 RVA: 0x0088C57C File Offset: 0x0088A77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_goldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE5B RID: 114267 RVA: 0x0088C5D4 File Offset: 0x0088A7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text goldText;
			LuaObject.checkType<Text>(l, 2, out goldText);
			battleResultUIController.m_luaExportHelper.m_goldText = goldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE5C RID: 114268 RVA: 0x0088C630 File Offset: 0x0088A830
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerExpText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_playerExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE5D RID: 114269 RVA: 0x0088C688 File Offset: 0x0088A888
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerExpText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text playerExpText;
			LuaObject.checkType<Text>(l, 2, out playerExpText);
			battleResultUIController.m_luaExportHelper.m_playerExpText = playerExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE5E RID: 114270 RVA: 0x0088C6E4 File Offset: 0x0088A8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerGroupLvText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_playerGroupLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE5F RID: 114271 RVA: 0x0088C73C File Offset: 0x0088A93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerGroupLvText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text playerGroupLvText;
			LuaObject.checkType<Text>(l, 2, out playerGroupLvText);
			battleResultUIController.m_luaExportHelper.m_playerGroupLvText = playerGroupLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE60 RID: 114272 RVA: 0x0088C798 File Offset: 0x0088A998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerExpImage(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_playerExpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE61 RID: 114273 RVA: 0x0088C7F0 File Offset: 0x0088A9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpImage(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Image playerExpImage;
			LuaObject.checkType<Image>(l, 2, out playerExpImage);
			battleResultUIController.m_luaExportHelper.m_playerExpImage = playerExpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE62 RID: 114274 RVA: 0x0088C84C File Offset: 0x0088AA4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerLevelUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_playerLevelUpGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE63 RID: 114275 RVA: 0x0088C8A4 File Offset: 0x0088AAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject playerLevelUpGameObject;
			LuaObject.checkType<GameObject>(l, 2, out playerLevelUpGameObject);
			battleResultUIController.m_luaExportHelper.m_playerLevelUpGameObject = playerLevelUpGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE64 RID: 114276 RVA: 0x0088C900 File Offset: 0x0088AB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_heroGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE65 RID: 114277 RVA: 0x0088C958 File Offset: 0x0088AB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject heroGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out heroGroupGameObject);
			battleResultUIController.m_luaExportHelper.m_heroGroupGameObject = heroGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE66 RID: 114278 RVA: 0x0088C9B4 File Offset: 0x0088ABB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroExpGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_heroExpGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE67 RID: 114279 RVA: 0x0088CA0C File Offset: 0x0088AC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroExpGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject heroExpGameObject;
			LuaObject.checkType<GameObject>(l, 2, out heroExpGameObject);
			battleResultUIController.m_luaExportHelper.m_heroExpGameObject = heroExpGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE68 RID: 114280 RVA: 0x0088CA68 File Offset: 0x0088AC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enemyBoomToGoldText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_enemyBoomToGoldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE69 RID: 114281 RVA: 0x0088CAC0 File Offset: 0x0088ACC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enemyBoomToGoldText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			Text enemyBoomToGoldText;
			LuaObject.checkType<Text>(l, 2, out enemyBoomToGoldText);
			battleResultUIController.m_luaExportHelper.m_enemyBoomToGoldText = enemyBoomToGoldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE6A RID: 114282 RVA: 0x0088CB1C File Offset: 0x0088AD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enemyBoomToGoldGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_enemyBoomToGoldGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE6B RID: 114283 RVA: 0x0088CB74 File Offset: 0x0088AD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enemyBoomToGoldGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject enemyBoomToGoldGameObject;
			LuaObject.checkType<GameObject>(l, 2, out enemyBoomToGoldGameObject);
			battleResultUIController.m_luaExportHelper.m_enemyBoomToGoldGameObject = enemyBoomToGoldGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE6C RID: 114284 RVA: 0x0088CBD0 File Offset: 0x0088ADD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_treasureMapRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_treasureMapRewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE6D RID: 114285 RVA: 0x0088CC28 File Offset: 0x0088AE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureMapRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject treasureMapRewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out treasureMapRewardGroupGameObject);
			battleResultUIController.m_luaExportHelper.m_treasureMapRewardGroupGameObject = treasureMapRewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE6E RID: 114286 RVA: 0x0088CC84 File Offset: 0x0088AE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureMapRewardGroupScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_treasureMapRewardGroupScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE6F RID: 114287 RVA: 0x0088CCDC File Offset: 0x0088AEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureMapRewardGroupScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			ScrollRect treasureMapRewardGroupScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out treasureMapRewardGroupScrollRect);
			battleResultUIController.m_luaExportHelper.m_treasureMapRewardGroupScrollRect = treasureMapRewardGroupScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE70 RID: 114288 RVA: 0x0088CD38 File Offset: 0x0088AF38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_treasureMapRewardGroupGridLayputGroup(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_treasureMapRewardGroupGridLayputGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE71 RID: 114289 RVA: 0x0088CD90 File Offset: 0x0088AF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureMapRewardGroupGridLayputGroup(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GridLayoutGroup treasureMapRewardGroupGridLayputGroup;
			LuaObject.checkType<GridLayoutGroup>(l, 2, out treasureMapRewardGroupGridLayputGroup);
			battleResultUIController.m_luaExportHelper.m_treasureMapRewardGroupGridLayputGroup = treasureMapRewardGroupGridLayputGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE72 RID: 114290 RVA: 0x0088CDEC File Offset: 0x0088AFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_achievementPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE73 RID: 114291 RVA: 0x0088CE44 File Offset: 0x0088B044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			CommonUIStateController achievementPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out achievementPanelUIStateController);
			battleResultUIController.m_luaExportHelper.m_achievementPanelUIStateController = achievementPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE74 RID: 114292 RVA: 0x0088CEA0 File Offset: 0x0088B0A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_achievementGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_achievementGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE75 RID: 114293 RVA: 0x0088CEF8 File Offset: 0x0088B0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject achievementGameObject;
			LuaObject.checkType<GameObject>(l, 2, out achievementGameObject);
			battleResultUIController.m_luaExportHelper.m_achievementGameObject = achievementGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE76 RID: 114294 RVA: 0x0088CF54 File Offset: 0x0088B154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickScreenContinueGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_clickScreenContinueGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE77 RID: 114295 RVA: 0x0088CFAC File Offset: 0x0088B1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clickScreenContinueGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject clickScreenContinueGameObject;
			LuaObject.checkType<GameObject>(l, 2, out clickScreenContinueGameObject);
			battleResultUIController.m_luaExportHelper.m_clickScreenContinueGameObject = clickScreenContinueGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE78 RID: 114296 RVA: 0x0088D008 File Offset: 0x0088B208
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE79 RID: 114297 RVA: 0x0088D060 File Offset: 0x0088B260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battleResultUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE7A RID: 114298 RVA: 0x0088D0BC File Offset: 0x0088B2BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_heroItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE7B RID: 114299 RVA: 0x0088D114 File Offset: 0x0088B314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject heroItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroItemPrefab);
			battleResultUIController.m_luaExportHelper.m_heroItemPrefab = heroItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE7C RID: 114300 RVA: 0x0088D170 File Offset: 0x0088B370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enemyItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_enemyItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE7D RID: 114301 RVA: 0x0088D1C8 File Offset: 0x0088B3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enemyItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			GameObject enemyItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out enemyItemPrefab);
			battleResultUIController.m_luaExportHelper.m_enemyItemPrefab = enemyItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE7E RID: 114302 RVA: 0x0088D224 File Offset: 0x0088B424
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rewardHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_rewardHeros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE7F RID: 114303 RVA: 0x0088D27C File Offset: 0x0088B47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			List<RewardHeroUIController> rewardHeros;
			LuaObject.checkType<List<RewardHeroUIController>>(l, 2, out rewardHeros);
			battleResultUIController.m_luaExportHelper.m_rewardHeros = rewardHeros;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE80 RID: 114304 RVA: 0x0088D2D8 File Offset: 0x0088B4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementItemUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_achievementItemUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE81 RID: 114305 RVA: 0x0088D330 File Offset: 0x0088B530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementItemUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			BattleAchievementItemUIController achievementItemUIController;
			LuaObject.checkType<BattleAchievementItemUIController>(l, 2, out achievementItemUIController);
			battleResultUIController.m_luaExportHelper.m_achievementItemUIController = achievementItemUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE82 RID: 114306 RVA: 0x0088D38C File Offset: 0x0088B58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_isClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE83 RID: 114307 RVA: 0x0088D3E4 File Offset: 0x0088B5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			bool isClick;
			LuaObject.checkType(l, 2, out isClick);
			battleResultUIController.m_luaExportHelper.m_isClick = isClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE84 RID: 114308 RVA: 0x0088D440 File Offset: 0x0088B640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelUpUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_playerLevelUpUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE85 RID: 114309 RVA: 0x0088D498 File Offset: 0x0088B698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelUpUITask(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			PlayerLevelUpUITask playerLevelUpUITask;
			LuaObject.checkType<PlayerLevelUpUITask>(l, 2, out playerLevelUpUITask);
			battleResultUIController.m_luaExportHelper.m_playerLevelUpUITask = playerLevelUpUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE86 RID: 114310 RVA: 0x0088D4F4 File Offset: 0x0088B6F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerExpTotalWidth(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_playerExpTotalWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE87 RID: 114311 RVA: 0x0088D54C File Offset: 0x0088B74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpTotalWidth(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			float playerExpTotalWidth;
			LuaObject.checkType(l, 2, out playerExpTotalWidth);
			battleResultUIController.m_luaExportHelper.m_playerExpTotalWidth = playerExpTotalWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE88 RID: 114312 RVA: 0x0088D5A8 File Offset: 0x0088B7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_spineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE89 RID: 114313 RVA: 0x0088D600 File Offset: 0x0088B800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			UISpineGraphic spineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out spineGraphic);
			battleResultUIController.m_luaExportHelper.m_spineGraphic = spineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE8A RID: 114314 RVA: 0x0088D65C File Offset: 0x0088B85C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_singleAddExp(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_singleAddExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE8B RID: 114315 RVA: 0x0088D6B4 File Offset: 0x0088B8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleAddExp(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			float singleAddExp;
			LuaObject.checkType(l, 2, out singleAddExp);
			battleResultUIController.m_luaExportHelper.m_singleAddExp = singleAddExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE8C RID: 114316 RVA: 0x0088D710 File Offset: 0x0088B910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beforePlayerExp(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_beforePlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE8D RID: 114317 RVA: 0x0088D768 File Offset: 0x0088B968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beforePlayerExp(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			float beforePlayerExp;
			LuaObject.checkType(l, 2, out beforePlayerExp);
			battleResultUIController.m_luaExportHelper.m_beforePlayerExp = beforePlayerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE8E RID: 114318 RVA: 0x0088D7C4 File Offset: 0x0088B9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalPlayerExp(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_finalPlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE8F RID: 114319 RVA: 0x0088D81C File Offset: 0x0088BA1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_finalPlayerExp(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			int finalPlayerExp;
			LuaObject.checkType(l, 2, out finalPlayerExp);
			battleResultUIController.m_luaExportHelper.m_finalPlayerExp = finalPlayerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE90 RID: 114320 RVA: 0x0088D878 File Offset: 0x0088BA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleAddGold(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_singleAddGold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE91 RID: 114321 RVA: 0x0088D8D0 File Offset: 0x0088BAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleAddGold(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			float singleAddGold;
			LuaObject.checkType(l, 2, out singleAddGold);
			battleResultUIController.m_luaExportHelper.m_singleAddGold = singleAddGold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE92 RID: 114322 RVA: 0x0088D92C File Offset: 0x0088BB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beforePlayerGold(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_beforePlayerGold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE93 RID: 114323 RVA: 0x0088D984 File Offset: 0x0088BB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beforePlayerGold(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			float beforePlayerGold;
			LuaObject.checkType(l, 2, out beforePlayerGold);
			battleResultUIController.m_luaExportHelper.m_beforePlayerGold = beforePlayerGold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE94 RID: 114324 RVA: 0x0088D9E0 File Offset: 0x0088BBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalPlayerGold(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultUIController.m_luaExportHelper.m_finalPlayerGold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE95 RID: 114325 RVA: 0x0088DA38 File Offset: 0x0088BC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalPlayerGold(IntPtr l)
	{
		int result;
		try
		{
			BattleResultUIController battleResultUIController = (BattleResultUIController)LuaObject.checkSelf(l);
			int finalPlayerGold;
			LuaObject.checkType(l, 2, out finalPlayerGold);
			battleResultUIController.m_luaExportHelper.m_finalPlayerGold = finalPlayerGold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BE96 RID: 114326 RVA: 0x0088DA94 File Offset: 0x0088BC94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleResultUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.ShowBattleResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_ShowBattleResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.AddPlayerExpBarWidth);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.UpdateTextValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_ShowStars);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_ShowHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_ShowEnemyBoomToGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.AutoMoveItemWhenOutOfScrollRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_ShowPlayerLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_ShowAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_SetGoldValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_SetAndWaitUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.Co_WaitClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.PlayerLevelUpUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.ClearHeroItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache1F);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache20, true);
		string name2 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_backgroundButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache22, true);
		string name3 = "m_accountingPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_accountingPanelUIStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_accountingPanelUIStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache24, true);
		string name4 = "m_starsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_starsGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_starsGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache26, true);
		string name5 = "m_star1UIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_star1UIStateController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_star1UIStateController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache28, true);
		string name6 = "m_star2UIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_star2UIStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_star2UIStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2A, true);
		string name7 = "m_star2Text";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_star2Text);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_star2Text);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2C, true);
		string name8 = "m_star3UIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_star3UIStateController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_star3UIStateController);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2E, true);
		string name9 = "m_star3Text";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_star3Text);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_star3Text);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache30, true);
		string name10 = "m_arenaResultGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_arenaResultGameObject);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_arenaResultGameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache32, true);
		string name11 = "m_arenaPointText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_arenaPointText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_arenaPointText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache34, true);
		string name12 = "m_arenaVictoryPointText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_arenaVictoryPointText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_arenaVictoryPointText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache36, true);
		string name13 = "m_arenaAutoFightGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_arenaAutoFightGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_arenaAutoFightGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache38, true);
		string name14 = "m_realtimePVPResultGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_realtimePVPResultGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_realtimePVPResultGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3A, true);
		string name15 = "m_realtimePVPScoreText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_realtimePVPScoreText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_realtimePVPScoreText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3C, true);
		string name16 = "m_realtimePVPWinText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_realtimePVPWinText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_realtimePVPWinText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3E, true);
		string name17 = "m_realtimePVPWinBonusGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_realtimePVPWinBonusGameObject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_realtimePVPWinBonusGameObject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache40, true);
		string name18 = "m_realtimePVPWinBonusText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_realtimePVPWinBonusText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_realtimePVPWinBonusText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache42, true);
		string name19 = "m_goldGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_goldGameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_goldGameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache44, true);
		string name20 = "m_expGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_expGameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_expGameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache46, true);
		string name21 = "m_goldText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_goldText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_goldText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache48, true);
		string name22 = "m_playerExpText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_playerExpText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_playerExpText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4A, true);
		string name23 = "m_playerGroupLvText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_playerGroupLvText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_playerGroupLvText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4C, true);
		string name24 = "m_playerExpImage";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_playerExpImage);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_playerExpImage);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4E, true);
		string name25 = "m_playerLevelUpGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_playerLevelUpGameObject);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_playerLevelUpGameObject);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache50, true);
		string name26 = "m_heroGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_heroGroupGameObject);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_heroGroupGameObject);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache52, true);
		string name27 = "m_heroExpGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_heroExpGameObject);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_heroExpGameObject);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache54, true);
		string name28 = "m_enemyBoomToGoldText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_enemyBoomToGoldText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_enemyBoomToGoldText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache56, true);
		string name29 = "m_enemyBoomToGoldGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_enemyBoomToGoldGameObject);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_enemyBoomToGoldGameObject);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache58, true);
		string name30 = "m_treasureMapRewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_treasureMapRewardGroupGameObject);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_treasureMapRewardGroupGameObject);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5A, true);
		string name31 = "m_treasureMapRewardGroupScrollRect";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_treasureMapRewardGroupScrollRect);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_treasureMapRewardGroupScrollRect);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5C, true);
		string name32 = "m_treasureMapRewardGroupGridLayputGroup";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_treasureMapRewardGroupGridLayputGroup);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_treasureMapRewardGroupGridLayputGroup);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5E, true);
		string name33 = "m_achievementPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_achievementPanelUIStateController);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_achievementPanelUIStateController);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache60, true);
		string name34 = "m_achievementGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_achievementGameObject);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_achievementGameObject);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache62, true);
		string name35 = "m_clickScreenContinueGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_clickScreenContinueGameObject);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_clickScreenContinueGameObject);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache64, true);
		string name36 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache66, true);
		string name37 = "m_heroItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_heroItemPrefab);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_heroItemPrefab);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache68, true);
		string name38 = "m_enemyItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_enemyItemPrefab);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_enemyItemPrefab);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6A, true);
		string name39 = "m_rewardHeros";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_rewardHeros);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_rewardHeros);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6C, true);
		string name40 = "m_achievementItemUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_achievementItemUIController);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_achievementItemUIController);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6E, true);
		string name41 = "m_isClick";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_isClick);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_isClick);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache70, true);
		string name42 = "m_playerLevelUpUITask";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_playerLevelUpUITask);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_playerLevelUpUITask);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache72, true);
		string name43 = "m_playerExpTotalWidth";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_playerExpTotalWidth);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_playerExpTotalWidth);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache74, true);
		string name44 = "m_spineGraphic";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_spineGraphic);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_spineGraphic);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache76, true);
		string name45 = "m_singleAddExp";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_singleAddExp);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_singleAddExp);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache78, true);
		string name46 = "m_beforePlayerExp";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_beforePlayerExp);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_beforePlayerExp);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7A, true);
		string name47 = "m_finalPlayerExp";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_finalPlayerExp);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_finalPlayerExp);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7C, true);
		string name48 = "m_singleAddGold";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_singleAddGold);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_singleAddGold);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7E, true);
		string name49 = "m_beforePlayerGold";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_beforePlayerGold);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_beforePlayerGold);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache80, true);
		string name50 = "m_finalPlayerGold";
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.get_m_finalPlayerGold);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultUIController.set_m_finalPlayerGold);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_BattleResultUIController.<>f__mg$cache82, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleResultUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401208D RID: 73869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401208E RID: 73870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401208F RID: 73871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012090 RID: 73872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012091 RID: 73873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012092 RID: 73874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012093 RID: 73875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012094 RID: 73876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012095 RID: 73877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012096 RID: 73878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012097 RID: 73879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012098 RID: 73880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012099 RID: 73881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401209A RID: 73882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401209B RID: 73883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401209C RID: 73884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401209D RID: 73885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401209E RID: 73886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401209F RID: 73887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040120A0 RID: 73888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040120A1 RID: 73889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040120A2 RID: 73890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040120A3 RID: 73891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040120A4 RID: 73892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040120A5 RID: 73893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040120A6 RID: 73894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040120A7 RID: 73895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040120A8 RID: 73896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040120A9 RID: 73897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040120AA RID: 73898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040120AB RID: 73899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040120AC RID: 73900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040120AD RID: 73901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040120AE RID: 73902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040120AF RID: 73903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040120B0 RID: 73904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040120B1 RID: 73905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040120B2 RID: 73906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040120B3 RID: 73907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040120B4 RID: 73908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040120B5 RID: 73909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040120B6 RID: 73910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040120B7 RID: 73911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040120B8 RID: 73912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040120B9 RID: 73913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040120BA RID: 73914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040120BB RID: 73915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040120BC RID: 73916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040120BD RID: 73917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040120BE RID: 73918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040120BF RID: 73919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040120C0 RID: 73920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040120C1 RID: 73921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040120C2 RID: 73922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040120C3 RID: 73923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040120C4 RID: 73924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040120C5 RID: 73925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040120C6 RID: 73926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040120C7 RID: 73927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040120C8 RID: 73928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040120C9 RID: 73929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040120CA RID: 73930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040120CB RID: 73931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040120CC RID: 73932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040120CD RID: 73933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040120CE RID: 73934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040120CF RID: 73935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040120D0 RID: 73936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040120D1 RID: 73937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040120D2 RID: 73938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040120D3 RID: 73939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040120D4 RID: 73940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040120D5 RID: 73941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040120D6 RID: 73942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040120D7 RID: 73943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040120D8 RID: 73944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040120D9 RID: 73945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040120DA RID: 73946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040120DB RID: 73947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040120DC RID: 73948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040120DD RID: 73949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040120DE RID: 73950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040120DF RID: 73951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040120E0 RID: 73952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040120E1 RID: 73953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040120E2 RID: 73954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040120E3 RID: 73955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040120E4 RID: 73956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040120E5 RID: 73957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040120E6 RID: 73958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040120E7 RID: 73959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040120E8 RID: 73960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040120E9 RID: 73961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040120EA RID: 73962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040120EB RID: 73963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040120EC RID: 73964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040120ED RID: 73965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040120EE RID: 73966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040120EF RID: 73967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040120F0 RID: 73968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040120F1 RID: 73969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040120F2 RID: 73970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040120F3 RID: 73971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040120F4 RID: 73972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040120F5 RID: 73973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040120F6 RID: 73974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040120F7 RID: 73975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040120F8 RID: 73976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040120F9 RID: 73977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040120FA RID: 73978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040120FB RID: 73979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040120FC RID: 73980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040120FD RID: 73981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040120FE RID: 73982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040120FF RID: 73983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04012100 RID: 73984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04012101 RID: 73985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04012102 RID: 73986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04012103 RID: 73987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04012104 RID: 73988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04012105 RID: 73989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04012106 RID: 73990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04012107 RID: 73991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04012108 RID: 73992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04012109 RID: 73993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401210A RID: 73994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401210B RID: 73995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0401210C RID: 73996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0401210D RID: 73997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0401210E RID: 73998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0401210F RID: 73999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;
}
