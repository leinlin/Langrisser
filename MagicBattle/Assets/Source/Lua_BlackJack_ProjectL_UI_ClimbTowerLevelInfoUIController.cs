using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013F7 RID: 5111
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController : LuaObject
{
	// Token: 0x0601CB51 RID: 117585 RVA: 0x008F36B4 File Offset: 0x008F18B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			bool hasRecommendHero;
			LuaObject.checkType(l, 2, out hasRecommendHero);
			climbTowerLevelInfoUIController.Open(hasRecommendHero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB52 RID: 117586 RVA: 0x008F370C File Offset: 0x008F190C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			climbTowerLevelInfoUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB53 RID: 117587 RVA: 0x008F3764 File Offset: 0x008F1964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			ConfigDataTowerLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTowerLevelInfo>(l, 3, out levelInfo);
			ConfigDataTowerBattleRuleInfo ruleInfo;
			LuaObject.checkType<ConfigDataTowerBattleRuleInfo>(l, 4, out ruleInfo);
			ConfigDataTowerBonusHeroGroupInfo bonusHeroGroupInfo;
			LuaObject.checkType<ConfigDataTowerBonusHeroGroupInfo>(l, 5, out bonusHeroGroupInfo);
			climbTowerLevelInfoUIController.SetTowerLevel(floorInfo, levelInfo, ruleInfo, bonusHeroGroupInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB54 RID: 117588 RVA: 0x008F37E4 File Offset: 0x008F19E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB55 RID: 117589 RVA: 0x008F3838 File Offset: 0x008F1A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRecommendHeros(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			List<int> recommendHeros;
			LuaObject.checkType<List<int>>(l, 2, out recommendHeros);
			climbTowerLevelInfoUIController.m_luaExportHelper.SetRecommendHeros(recommendHeros);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB56 RID: 117590 RVA: 0x008F3894 File Offset: 0x008F1A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetConditions(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			string conditionStrs;
			LuaObject.checkType(l, 3, out conditionStrs);
			int stateType;
			LuaObject.checkType(l, 4, out stateType);
			climbTowerLevelInfoUIController.m_luaExportHelper.SetConditions(parent, conditionStrs, stateType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB57 RID: 117591 RVA: 0x008F390C File Offset: 0x008F1B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCondition(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			string str;
			LuaObject.checkType(l, 3, out str);
			int stateType;
			LuaObject.checkType(l, 4, out stateType);
			climbTowerLevelInfoUIController.m_luaExportHelper.AddCondition(parent, str, stateType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB58 RID: 117592 RVA: 0x008F3984 File Offset: 0x008F1B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB59 RID: 117593 RVA: 0x008F39D8 File Offset: 0x008F1BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB5A RID: 117594 RVA: 0x008F3A2C File Offset: 0x008F1C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB5B RID: 117595 RVA: 0x008F3A98 File Offset: 0x008F1C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB5C RID: 117596 RVA: 0x008F3AEC File Offset: 0x008F1CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB5D RID: 117597 RVA: 0x008F3B40 File Offset: 0x008F1D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CB5E RID: 117598 RVA: 0x008F3BE8 File Offset: 0x008F1DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB5F RID: 117599 RVA: 0x008F3C3C File Offset: 0x008F1E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB60 RID: 117600 RVA: 0x008F3CA8 File Offset: 0x008F1EA8
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
				ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController2 = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				climbTowerLevelInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CB61 RID: 117601 RVA: 0x008F3DB8 File Offset: 0x008F1FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB62 RID: 117602 RVA: 0x008F3E24 File Offset: 0x008F2024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB63 RID: 117603 RVA: 0x008F3E90 File Offset: 0x008F2090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB64 RID: 117604 RVA: 0x008F3EFC File Offset: 0x008F20FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB65 RID: 117605 RVA: 0x008F3F68 File Offset: 0x008F2168
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
				ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController2 = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				climbTowerLevelInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CB66 RID: 117606 RVA: 0x008F4078 File Offset: 0x008F2278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			string s = climbTowerLevelInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CB67 RID: 117607 RVA: 0x008F40D4 File Offset: 0x008F22D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callDele_EventOnStartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB68 RID: 117608 RVA: 0x008F4128 File Offset: 0x008F2328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.__clearDele_EventOnStartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB69 RID: 117609 RVA: 0x008F417C File Offset: 0x008F237C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB6A RID: 117610 RVA: 0x008F41D0 File Offset: 0x008F23D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			climbTowerLevelInfoUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB6B RID: 117611 RVA: 0x008F4224 File Offset: 0x008F2424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartBattle(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerLevelInfoUIController.EventOnStartBattle += value;
				}
				else if (num == 2)
				{
					climbTowerLevelInfoUIController.EventOnStartBattle -= value;
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

	// Token: 0x0601CB6C RID: 117612 RVA: 0x008F42A4 File Offset: 0x008F24A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerLevelInfoUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					climbTowerLevelInfoUIController.EventOnClose -= value;
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

	// Token: 0x0601CB6D RID: 117613 RVA: 0x008F4324 File Offset: 0x008F2524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB6E RID: 117614 RVA: 0x008F437C File Offset: 0x008F257C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB6F RID: 117615 RVA: 0x008F43D8 File Offset: 0x008F25D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB70 RID: 117616 RVA: 0x008F4430 File Offset: 0x008F2630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB71 RID: 117617 RVA: 0x008F448C File Offset: 0x008F268C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB72 RID: 117618 RVA: 0x008F44E4 File Offset: 0x008F26E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB73 RID: 117619 RVA: 0x008F4540 File Offset: 0x008F2740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hardText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_hardText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB74 RID: 117620 RVA: 0x008F4598 File Offset: 0x008F2798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hardText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Text hardText;
			LuaObject.checkType<Text>(l, 2, out hardText);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_hardText = hardText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB75 RID: 117621 RVA: 0x008F45F4 File Offset: 0x008F27F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_costEnergyText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_costEnergyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB76 RID: 117622 RVA: 0x008F464C File Offset: 0x008F284C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_costEnergyText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Text costEnergyText;
			LuaObject.checkType<Text>(l, 2, out costEnergyText);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_costEnergyText = costEnergyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB77 RID: 117623 RVA: 0x008F46A8 File Offset: 0x008F28A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_winConditionGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB78 RID: 117624 RVA: 0x008F4700 File Offset: 0x008F2900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Transform winConditionGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out winConditionGroupTransform);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_winConditionGroupTransform = winConditionGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB79 RID: 117625 RVA: 0x008F475C File Offset: 0x008F295C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_ruleConditionGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_ruleConditionGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB7A RID: 117626 RVA: 0x008F47B4 File Offset: 0x008F29B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ruleConditionGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Transform ruleConditionGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out ruleConditionGroupTransform);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_ruleConditionGroupTransform = ruleConditionGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB7B RID: 117627 RVA: 0x008F4810 File Offset: 0x008F2A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_rewardGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB7C RID: 117628 RVA: 0x008F4868 File Offset: 0x008F2A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Transform rewardGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out rewardGroupTransform);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_rewardGroupTransform = rewardGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB7D RID: 117629 RVA: 0x008F48C4 File Offset: 0x008F2AC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_recommendHeroGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_recommendHeroGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB7E RID: 117630 RVA: 0x008F491C File Offset: 0x008F2B1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_recommendHeroGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Transform recommendHeroGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out recommendHeroGroupTransform);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_recommendHeroGroupTransform = recommendHeroGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB7F RID: 117631 RVA: 0x008F4978 File Offset: 0x008F2B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendHeroDescText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_recommendHeroDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB80 RID: 117632 RVA: 0x008F49D0 File Offset: 0x008F2BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendHeroDescText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Text recommendHeroDescText;
			LuaObject.checkType<Text>(l, 2, out recommendHeroDescText);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_recommendHeroDescText = recommendHeroDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB81 RID: 117633 RVA: 0x008F4A2C File Offset: 0x008F2C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB82 RID: 117634 RVA: 0x008F4A84 File Offset: 0x008F2C84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB83 RID: 117635 RVA: 0x008F4AE0 File Offset: 0x008F2CE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB84 RID: 117636 RVA: 0x008F4B38 File Offset: 0x008F2D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB85 RID: 117637 RVA: 0x008F4B94 File Offset: 0x008F2D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB86 RID: 117638 RVA: 0x008F4BEC File Offset: 0x008F2DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB87 RID: 117639 RVA: 0x008F4C48 File Offset: 0x008F2E48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_conditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_conditionPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB88 RID: 117640 RVA: 0x008F4CA0 File Offset: 0x008F2EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_conditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject conditionPrefab;
			LuaObject.checkType<GameObject>(l, 2, out conditionPrefab);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_conditionPrefab = conditionPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB89 RID: 117641 RVA: 0x008F4CFC File Offset: 0x008F2EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendHeroItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelInfoUIController.m_luaExportHelper.m_recommendHeroItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB8A RID: 117642 RVA: 0x008F4D54 File Offset: 0x008F2F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendHeroItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelInfoUIController climbTowerLevelInfoUIController = (ClimbTowerLevelInfoUIController)LuaObject.checkSelf(l);
			GameObject recommendHeroItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out recommendHeroItemPrefab);
			climbTowerLevelInfoUIController.m_luaExportHelper.m_recommendHeroItemPrefab = recommendHeroItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB8B RID: 117643 RVA: 0x008F4DB0 File Offset: 0x008F2FB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerLevelInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.SetTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.SetRecommendHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.SetConditions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.AddCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callDele_EventOnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__clearDele_EventOnStartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache19);
		string name = "EventOnStartBattle";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_EventOnStartBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1A, true);
		string name2 = "EventOnClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1B, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1D, true);
		string name4 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_nameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache1F, true);
		string name5 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_image);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_image);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache21, true);
		string name6 = "m_hardText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_hardText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_hardText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache23, true);
		string name7 = "m_costEnergyText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_costEnergyText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_costEnergyText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache25, true);
		string name8 = "m_winConditionGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_winConditionGroupTransform);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_winConditionGroupTransform);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache27, true);
		string name9 = "m_ruleConditionGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_ruleConditionGroupTransform);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_ruleConditionGroupTransform);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache29, true);
		string name10 = "m_rewardGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_rewardGroupTransform);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_rewardGroupTransform);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2B, true);
		string name11 = "m_recommendHeroGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_recommendHeroGroupTransform);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_recommendHeroGroupTransform);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2D, true);
		string name12 = "m_recommendHeroDescText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_recommendHeroDescText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_recommendHeroDescText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache2F, true);
		string name13 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_startButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache31, true);
		string name14 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_backgroundButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache33, true);
		string name15 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache35, true);
		string name16 = "m_conditionPrefab";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_conditionPrefab);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_conditionPrefab);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache37, true);
		string name17 = "m_recommendHeroItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.get_m_recommendHeroItemPrefab);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.set_m_recommendHeroItemPrefab);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.<>f__mg$cache39, true);
		LuaObject.createTypeMetatable(l, null, typeof(ClimbTowerLevelInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012D45 RID: 77125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012D46 RID: 77126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012D47 RID: 77127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012D48 RID: 77128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012D49 RID: 77129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012D4A RID: 77130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012D4B RID: 77131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012D4C RID: 77132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012D4D RID: 77133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012D4E RID: 77134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012D4F RID: 77135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012D50 RID: 77136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012D51 RID: 77137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012D52 RID: 77138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012D53 RID: 77139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012D54 RID: 77140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012D55 RID: 77141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012D56 RID: 77142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012D57 RID: 77143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012D58 RID: 77144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012D59 RID: 77145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012D5A RID: 77146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012D5B RID: 77147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012D5C RID: 77148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012D5D RID: 77149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012D5E RID: 77150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012D5F RID: 77151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012D60 RID: 77152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012D61 RID: 77153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012D62 RID: 77154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012D63 RID: 77155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012D64 RID: 77156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012D65 RID: 77157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012D66 RID: 77158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012D67 RID: 77159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012D68 RID: 77160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012D69 RID: 77161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012D6A RID: 77162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012D6B RID: 77163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012D6C RID: 77164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012D6D RID: 77165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012D6E RID: 77166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012D6F RID: 77167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012D70 RID: 77168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012D71 RID: 77169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012D72 RID: 77170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012D73 RID: 77171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012D74 RID: 77172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012D75 RID: 77173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012D76 RID: 77174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012D77 RID: 77175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012D78 RID: 77176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012D79 RID: 77177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012D7A RID: 77178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012D7B RID: 77179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012D7C RID: 77180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012D7D RID: 77181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012D7E RID: 77182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;
}
