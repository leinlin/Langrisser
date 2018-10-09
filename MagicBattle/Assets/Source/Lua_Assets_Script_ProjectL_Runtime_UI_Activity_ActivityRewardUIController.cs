using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Script.ProjectL.Runtime.UI.Activity;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001104 RID: 4356
[Preserve]
public class Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController : LuaObject
{
	// Token: 0x06015A5F RID: 88671 RVA: 0x0058D9FC File Offset: 0x0058BBFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetActivityRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			int index;
			LuaObject.checkType(l, 3, out index);
			GameObject rewardGoodsItemPrefab;
			LuaObject.checkType<GameObject>(l, 4, out rewardGoodsItemPrefab);
			activityRewardUIController.SetActivityRewardPanel(activity, index, rewardGoodsItemPrefab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A60 RID: 88672 RVA: 0x0058DA70 File Offset: 0x0058BC70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			activityRewardUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A61 RID: 88673 RVA: 0x0058DAC4 File Offset: 0x0058BCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGoalState(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			int index;
			LuaObject.checkType(l, 3, out index);
			activityRewardUIController.m_luaExportHelper.SetGoalState(activity, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A62 RID: 88674 RVA: 0x0058DB30 File Offset: 0x0058BD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLevelUpActivityGoal(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			int index;
			LuaObject.checkType(l, 3, out index);
			activityRewardUIController.m_luaExportHelper.SetLevelUpActivityGoal(activity, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A63 RID: 88675 RVA: 0x0058DB9C File Offset: 0x0058BD9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAccumulateDaysLoginGoal(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			int index;
			LuaObject.checkType(l, 3, out index);
			activityRewardUIController.m_luaExportHelper.SetAccumulateDaysLoginGoal(activity, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A64 RID: 88676 RVA: 0x0058DC08 File Offset: 0x0058BE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSpecificDaysLoginActivityGoal(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			int index;
			LuaObject.checkType(l, 3, out index);
			activityRewardUIController.m_luaExportHelper.SetSpecificDaysLoginActivityGoal(activity, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A65 RID: 88677 RVA: 0x0058DC74 File Offset: 0x0058BE74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLimitedTimeExchangeActivityGoal(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			int index;
			LuaObject.checkType(l, 3, out index);
			activityRewardUIController.m_luaExportHelper.SetLimitedTimeExchangeActivityGoal(activity, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A66 RID: 88678 RVA: 0x0058DCE0 File Offset: 0x0058BEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAccumulateRechargeGoal(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			int index;
			LuaObject.checkType(l, 3, out index);
			activityRewardUIController.m_luaExportHelper.SetAccumulateRechargeGoal(activity, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A67 RID: 88679 RVA: 0x0058DD4C File Offset: 0x0058BF4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAccumulateConsumeCrystalGoal(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			int index;
			LuaObject.checkType(l, 3, out index);
			activityRewardUIController.m_luaExportHelper.SetAccumulateConsumeCrystalGoal(activity, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A68 RID: 88680 RVA: 0x0058DDB8 File Offset: 0x0058BFB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetOperator(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			List<Goods> exchangeGoodList;
			LuaObject.checkType<List<Goods>>(l, 2, out exchangeGoodList);
			List<Goods> gainGoodList;
			LuaObject.checkType<List<Goods>>(l, 3, out gainGoodList);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 4, out activity);
			int rewardIndex;
			LuaObject.checkType(l, 5, out rewardIndex);
			activityRewardUIController.m_luaExportHelper.SetOperator(exchangeGoodList, gainGoodList, activity, rewardIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A69 RID: 88681 RVA: 0x0058DE3C File Offset: 0x0058C03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GainRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			activityRewardUIController.m_luaExportHelper.GainRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A6A RID: 88682 RVA: 0x0058DE90 File Offset: 0x0058C090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExchangeItemGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			activityRewardUIController.m_luaExportHelper.ExchangeItemGroupButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A6B RID: 88683 RVA: 0x0058DEE4 File Offset: 0x0058C0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			activityRewardUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A6C RID: 88684 RVA: 0x0058DF50 File Offset: 0x0058C150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			activityRewardUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A6D RID: 88685 RVA: 0x0058DFA4 File Offset: 0x0058C1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			activityRewardUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A6E RID: 88686 RVA: 0x0058DFF8 File Offset: 0x0058C1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = activityRewardUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06015A6F RID: 88687 RVA: 0x0058E0A0 File Offset: 0x0058C2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			activityRewardUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A70 RID: 88688 RVA: 0x0058E0F4 File Offset: 0x0058C2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			activityRewardUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A71 RID: 88689 RVA: 0x0058E160 File Offset: 0x0058C360
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
				ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				activityRewardUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ActivityRewardUIController activityRewardUIController2 = (ActivityRewardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				activityRewardUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06015A72 RID: 88690 RVA: 0x0058E270 File Offset: 0x0058C470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityRewardUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A73 RID: 88691 RVA: 0x0058E2DC File Offset: 0x0058C4DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityRewardUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A74 RID: 88692 RVA: 0x0058E348 File Offset: 0x0058C548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityRewardUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A75 RID: 88693 RVA: 0x0058E3B4 File Offset: 0x0058C5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityRewardUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A76 RID: 88694 RVA: 0x0058E420 File Offset: 0x0058C620
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
				ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				activityRewardUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ActivityRewardUIController activityRewardUIController2 = (ActivityRewardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				activityRewardUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06015A77 RID: 88695 RVA: 0x0058E530 File Offset: 0x0058C730
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			string s = activityRewardUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06015A78 RID: 88696 RVA: 0x0058E58C File Offset: 0x0058C78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGainRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			ActivityRewardUIController arg3;
			LuaObject.checkType<ActivityRewardUIController>(l, 4, out arg3);
			activityRewardUIController.m_luaExportHelper.__callDele_EventOnGainRewardButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A79 RID: 88697 RVA: 0x0058E604 File Offset: 0x0058C804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGainRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			ActivityRewardUIController arg3;
			LuaObject.checkType<ActivityRewardUIController>(l, 4, out arg3);
			activityRewardUIController.m_luaExportHelper.__clearDele_EventOnGainRewardButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A7A RID: 88698 RVA: 0x0058E67C File Offset: 0x0058C87C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnExchangeItemGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			ActivityRewardUIController arg3;
			LuaObject.checkType<ActivityRewardUIController>(l, 4, out arg3);
			activityRewardUIController.m_luaExportHelper.__callDele_EventOnExchangeItemGroupButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A7B RID: 88699 RVA: 0x0058E6F4 File Offset: 0x0058C8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExchangeItemGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			ActivityRewardUIController arg3;
			LuaObject.checkType<ActivityRewardUIController>(l, 4, out arg3);
			activityRewardUIController.m_luaExportHelper.__clearDele_EventOnExchangeItemGroupButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A7C RID: 88700 RVA: 0x0058E76C File Offset: 0x0058C96C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			activityRewardUIController.m_luaExportHelper.__callDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A7D RID: 88701 RVA: 0x0058E7C0 File Offset: 0x0058C9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			activityRewardUIController.m_luaExportHelper.__clearDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A7E RID: 88702 RVA: 0x0058E814 File Offset: 0x0058CA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGainRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Action<ulong, int, ActivityRewardUIController> value;
			int num = LuaObject.checkDelegate<Action<ulong, int, ActivityRewardUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityRewardUIController.EventOnGainRewardButtonClick += value;
				}
				else if (num == 2)
				{
					activityRewardUIController.EventOnGainRewardButtonClick -= value;
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

	// Token: 0x06015A7F RID: 88703 RVA: 0x0058E894 File Offset: 0x0058CA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExchangeItemGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Action<ulong, int, ActivityRewardUIController> value;
			int num = LuaObject.checkDelegate<Action<ulong, int, ActivityRewardUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityRewardUIController.EventOnExchangeItemGroupButtonClick += value;
				}
				else if (num == 2)
				{
					activityRewardUIController.EventOnExchangeItemGroupButtonClick -= value;
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

	// Token: 0x06015A80 RID: 88704 RVA: 0x0058E914 File Offset: 0x0058CB14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityRewardUIController.EventOnCrystalNotEnough += value;
				}
				else if (num == 2)
				{
					activityRewardUIController.EventOnCrystalNotEnough -= value;
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

	// Token: 0x06015A81 RID: 88705 RVA: 0x0058E994 File Offset: 0x0058CB94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_activityInstanceID(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_activityInstanceID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A82 RID: 88706 RVA: 0x0058E9EC File Offset: 0x0058CBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityInstanceID(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			ulong activityInstanceID;
			LuaObject.checkType(l, 2, out activityInstanceID);
			activityRewardUIController.m_luaExportHelper.m_activityInstanceID = activityInstanceID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A83 RID: 88707 RVA: 0x0058EA48 File Offset: 0x0058CC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activity(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_activity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A84 RID: 88708 RVA: 0x0058EAA0 File Offset: 0x0058CCA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_activity(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			activityRewardUIController.m_luaExportHelper.m_activity = activity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A85 RID: 88709 RVA: 0x0058EAFC File Offset: 0x0058CCFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rewardIndex(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_rewardIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A86 RID: 88710 RVA: 0x0058EB54 File Offset: 0x0058CD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardIndex(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			int rewardIndex;
			LuaObject.checkType(l, 2, out rewardIndex);
			activityRewardUIController.m_luaExportHelper.m_rewardIndex = rewardIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A87 RID: 88711 RVA: 0x0058EBB0 File Offset: 0x0058CDB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rewardList(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_rewardList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A88 RID: 88712 RVA: 0x0058EC04 File Offset: 0x0058CE04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rewardList(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			List<Goods> rewardList;
			LuaObject.checkType<List<Goods>>(l, 2, out rewardList);
			activityRewardUIController.m_rewardList = rewardList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A89 RID: 88713 RVA: 0x0058EC5C File Offset: 0x0058CE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityRewardItemGroupObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_activityRewardItemGroupObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A8A RID: 88714 RVA: 0x0058ECB4 File Offset: 0x0058CEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityRewardItemGroupObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject activityRewardItemGroupObj;
			LuaObject.checkType<GameObject>(l, 2, out activityRewardItemGroupObj);
			activityRewardUIController.m_luaExportHelper.m_activityRewardItemGroupObj = activityRewardItemGroupObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A8B RID: 88715 RVA: 0x0058ED10 File Offset: 0x0058CF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_receiveButtonGroup(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_receiveButtonGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A8C RID: 88716 RVA: 0x0058ED68 File Offset: 0x0058CF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_receiveButtonGroup(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject receiveButtonGroup;
			LuaObject.checkType<GameObject>(l, 2, out receiveButtonGroup);
			activityRewardUIController.m_luaExportHelper.m_receiveButtonGroup = receiveButtonGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A8D RID: 88717 RVA: 0x0058EDC4 File Offset: 0x0058CFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canReceiveButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_canReceiveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A8E RID: 88718 RVA: 0x0058EE1C File Offset: 0x0058D01C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_canReceiveButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Button canReceiveButton;
			LuaObject.checkType<Button>(l, 2, out canReceiveButton);
			activityRewardUIController.m_luaExportHelper.m_canReceiveButton = canReceiveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A8F RID: 88719 RVA: 0x0058EE78 File Offset: 0x0058D078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canNotReceiveButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_canNotReceiveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A90 RID: 88720 RVA: 0x0058EED0 File Offset: 0x0058D0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canNotReceiveButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Button canNotReceiveButton;
			LuaObject.checkType<Button>(l, 2, out canNotReceiveButton);
			activityRewardUIController.m_luaExportHelper.m_canNotReceiveButton = canNotReceiveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A91 RID: 88721 RVA: 0x0058EF2C File Offset: 0x0058D12C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_exchangeButtonGroup(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_exchangeButtonGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A92 RID: 88722 RVA: 0x0058EF84 File Offset: 0x0058D184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_exchangeButtonGroup(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject exchangeButtonGroup;
			LuaObject.checkType<GameObject>(l, 2, out exchangeButtonGroup);
			activityRewardUIController.m_luaExportHelper.m_exchangeButtonGroup = exchangeButtonGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A93 RID: 88723 RVA: 0x0058EFE0 File Offset: 0x0058D1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_canExchangeButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_canExchangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A94 RID: 88724 RVA: 0x0058F038 File Offset: 0x0058D238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canExchangeButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Button canExchangeButton;
			LuaObject.checkType<Button>(l, 2, out canExchangeButton);
			activityRewardUIController.m_luaExportHelper.m_canExchangeButton = canExchangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A95 RID: 88725 RVA: 0x0058F094 File Offset: 0x0058D294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_canNotExchangeButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_canNotExchangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A96 RID: 88726 RVA: 0x0058F0EC File Offset: 0x0058D2EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_canNotExchangeButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Button canNotExchangeButton;
			LuaObject.checkType<Button>(l, 2, out canNotExchangeButton);
			activityRewardUIController.m_luaExportHelper.m_canNotExchangeButton = canNotExchangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A97 RID: 88727 RVA: 0x0058F148 File Offset: 0x0058D348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_alreadyReceivedObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_alreadyReceivedObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A98 RID: 88728 RVA: 0x0058F1A0 File Offset: 0x0058D3A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_alreadyReceivedObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject alreadyReceivedObj;
			LuaObject.checkType<GameObject>(l, 2, out alreadyReceivedObj);
			activityRewardUIController.m_luaExportHelper.m_alreadyReceivedObj = alreadyReceivedObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A99 RID: 88729 RVA: 0x0058F1FC File Offset: 0x0058D3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achieveGoalObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_achieveGoalObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A9A RID: 88730 RVA: 0x0058F254 File Offset: 0x0058D454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achieveGoalObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject achieveGoalObj;
			LuaObject.checkType<GameObject>(l, 2, out achieveGoalObj);
			activityRewardUIController.m_luaExportHelper.m_achieveGoalObj = achieveGoalObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A9B RID: 88731 RVA: 0x0058F2B0 File Offset: 0x0058D4B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_achieveGoalText(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_achieveGoalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A9C RID: 88732 RVA: 0x0058F308 File Offset: 0x0058D508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achieveGoalText(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Text achieveGoalText;
			LuaObject.checkType<Text>(l, 2, out achieveGoalText);
			activityRewardUIController.m_luaExportHelper.m_achieveGoalText = achieveGoalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A9D RID: 88733 RVA: 0x0058F364 File Offset: 0x0058D564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goalProgressText(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_goalProgressText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A9E RID: 88734 RVA: 0x0058F3BC File Offset: 0x0058D5BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_goalProgressText(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Text goalProgressText;
			LuaObject.checkType<Text>(l, 2, out goalProgressText);
			activityRewardUIController.m_luaExportHelper.m_goalProgressText = goalProgressText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015A9F RID: 88735 RVA: 0x0058F418 File Offset: 0x0058D618
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_allOperatorObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_allOperatorObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA0 RID: 88736 RVA: 0x0058F470 File Offset: 0x0058D670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_allOperatorObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject allOperatorObj;
			LuaObject.checkType<GameObject>(l, 2, out allOperatorObj);
			activityRewardUIController.m_luaExportHelper.m_allOperatorObj = allOperatorObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA1 RID: 88737 RVA: 0x0058F4CC File Offset: 0x0058D6CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_operatorImage1(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_operatorImage1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA2 RID: 88738 RVA: 0x0058F524 File Offset: 0x0058D724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_operatorImage1(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Image operatorImage;
			LuaObject.checkType<Image>(l, 2, out operatorImage);
			activityRewardUIController.m_luaExportHelper.m_operatorImage1 = operatorImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA3 RID: 88739 RVA: 0x0058F580 File Offset: 0x0058D780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_operatorImage2(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_operatorImage2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA4 RID: 88740 RVA: 0x0058F5D8 File Offset: 0x0058D7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_operatorImage2(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Image operatorImage;
			LuaObject.checkType<Image>(l, 2, out operatorImage);
			activityRewardUIController.m_luaExportHelper.m_operatorImage2 = operatorImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA5 RID: 88741 RVA: 0x0058F634 File Offset: 0x0058D834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_operatorImage3(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_operatorImage3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA6 RID: 88742 RVA: 0x0058F68C File Offset: 0x0058D88C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_operatorImage3(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Image operatorImage;
			LuaObject.checkType<Image>(l, 2, out operatorImage);
			activityRewardUIController.m_luaExportHelper.m_operatorImage3 = operatorImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA7 RID: 88743 RVA: 0x0058F6E8 File Offset: 0x0058D8E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_payGroupObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_payGroupObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA8 RID: 88744 RVA: 0x0058F740 File Offset: 0x0058D940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_payGroupObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject payGroupObj;
			LuaObject.checkType<GameObject>(l, 2, out payGroupObj);
			activityRewardUIController.m_luaExportHelper.m_payGroupObj = payGroupObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AA9 RID: 88745 RVA: 0x0058F79C File Offset: 0x0058D99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_payGroupRMBIconObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_payGroupRMBIconObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AAA RID: 88746 RVA: 0x0058F7F4 File Offset: 0x0058D9F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_payGroupRMBIconObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject payGroupRMBIconObj;
			LuaObject.checkType<GameObject>(l, 2, out payGroupRMBIconObj);
			activityRewardUIController.m_luaExportHelper.m_payGroupRMBIconObj = payGroupRMBIconObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AAB RID: 88747 RVA: 0x0058F850 File Offset: 0x0058DA50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_payGroupCrystalIconObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_payGroupCrystalIconObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AAC RID: 88748 RVA: 0x0058F8A8 File Offset: 0x0058DAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_payGroupCrystalIconObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			GameObject payGroupCrystalIconObj;
			LuaObject.checkType<GameObject>(l, 2, out payGroupCrystalIconObj);
			activityRewardUIController.m_luaExportHelper.m_payGroupCrystalIconObj = payGroupCrystalIconObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AAD RID: 88749 RVA: 0x0058F904 File Offset: 0x0058DB04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_payGroupTitleText(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_payGroupTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AAE RID: 88750 RVA: 0x0058F95C File Offset: 0x0058DB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_payGroupTitleText(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Text payGroupTitleText;
			LuaObject.checkType<Text>(l, 2, out payGroupTitleText);
			activityRewardUIController.m_luaExportHelper.m_payGroupTitleText = payGroupTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AAF RID: 88751 RVA: 0x0058F9B8 File Offset: 0x0058DBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_payGroupNumberText(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_payGroupNumberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AB0 RID: 88752 RVA: 0x0058FA10 File Offset: 0x0058DC10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_payGroupNumberText(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			Text payGroupNumberText;
			LuaObject.checkType<Text>(l, 2, out payGroupNumberText);
			activityRewardUIController.m_luaExportHelper.m_payGroupNumberText = payGroupNumberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AB1 RID: 88753 RVA: 0x0058FA6C File Offset: 0x0058DC6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AB2 RID: 88754 RVA: 0x0058FAC4 File Offset: 0x0058DCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			activityRewardUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AB3 RID: 88755 RVA: 0x0058FB20 File Offset: 0x0058DD20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityRewardUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AB4 RID: 88756 RVA: 0x0058FB78 File Offset: 0x0058DD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ActivityRewardUIController activityRewardUIController = (ActivityRewardUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			activityRewardUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015AB5 RID: 88757 RVA: 0x0058FBD4 File Offset: 0x0058DDD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "Assets.Script.ProjectL.Runtime.UI.Activity.ActivityRewardUIController");
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache0 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetActivityRewardPanel);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache0);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetGoalState);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetLevelUpActivityGoal);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetAccumulateDaysLoginGoal);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache5 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetSpecificDaysLoginActivityGoal);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache5);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache6 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetLimitedTimeExchangeActivityGoal);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache6);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache7 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetAccumulateRechargeGoal);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache7);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache8 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetAccumulateConsumeCrystalGoal);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache8);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache9 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.SetOperator);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache9);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheA == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.GainRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheA);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheB == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.ExchangeItemGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheB);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheC == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheC);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheD == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheD);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheE == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheE);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheF == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cacheF);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache10 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache10);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache11 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache11);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache12 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache12);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache13 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache13);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache14 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache14);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache15 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache15);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache16 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache16);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache17 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache17);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache18 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache18);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache19 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callDele_EventOnGainRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache19);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1A == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__clearDele_EventOnGainRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1A);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1B == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callDele_EventOnExchangeItemGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1B);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1C == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__clearDele_EventOnExchangeItemGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1C);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1D == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__callDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1D);
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1E == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.__clearDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1E);
		string name = "EventOnGainRewardButtonClick";
		LuaCSFunction get = null;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1F == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_EventOnGainRewardButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache1F, true);
		string name2 = "EventOnExchangeItemGroupButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache20 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_EventOnExchangeItemGroupButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache20, true);
		string name3 = "EventOnCrystalNotEnough";
		LuaCSFunction get3 = null;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache21 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, name3, get3, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache21, true);
		string name4 = "m_activityInstanceID";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache22 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_activityInstanceID);
		}
		LuaCSFunction get4 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache22;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache23 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_activityInstanceID);
		}
		LuaObject.addMember(l, name4, get4, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache23, true);
		string name5 = "m_activity";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache24 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_activity);
		}
		LuaCSFunction get5 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache24;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache25 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_activity);
		}
		LuaObject.addMember(l, name5, get5, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache25, true);
		string name6 = "m_rewardIndex";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache26 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_rewardIndex);
		}
		LuaCSFunction get6 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache26;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache27 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_rewardIndex);
		}
		LuaObject.addMember(l, name6, get6, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache27, true);
		string name7 = "m_rewardList";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache28 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_rewardList);
		}
		LuaCSFunction get7 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache28;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache29 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_rewardList);
		}
		LuaObject.addMember(l, name7, get7, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache29, true);
		string name8 = "m_activityRewardItemGroupObj";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2A == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_activityRewardItemGroupObj);
		}
		LuaCSFunction get8 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2A;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2B == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_activityRewardItemGroupObj);
		}
		LuaObject.addMember(l, name8, get8, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2B, true);
		string name9 = "m_receiveButtonGroup";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2C == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_receiveButtonGroup);
		}
		LuaCSFunction get9 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2C;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2D == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_receiveButtonGroup);
		}
		LuaObject.addMember(l, name9, get9, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2D, true);
		string name10 = "m_canReceiveButton";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2E == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_canReceiveButton);
		}
		LuaCSFunction get10 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2E;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2F == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_canReceiveButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache2F, true);
		string name11 = "m_canNotReceiveButton";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache30 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_canNotReceiveButton);
		}
		LuaCSFunction get11 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache30;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache31 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_canNotReceiveButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache31, true);
		string name12 = "m_exchangeButtonGroup";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache32 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_exchangeButtonGroup);
		}
		LuaCSFunction get12 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache32;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache33 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_exchangeButtonGroup);
		}
		LuaObject.addMember(l, name12, get12, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache33, true);
		string name13 = "m_canExchangeButton";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache34 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_canExchangeButton);
		}
		LuaCSFunction get13 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache34;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache35 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_canExchangeButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache35, true);
		string name14 = "m_canNotExchangeButton";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache36 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_canNotExchangeButton);
		}
		LuaCSFunction get14 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache36;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache37 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_canNotExchangeButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache37, true);
		string name15 = "m_alreadyReceivedObj";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache38 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_alreadyReceivedObj);
		}
		LuaCSFunction get15 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache38;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache39 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_alreadyReceivedObj);
		}
		LuaObject.addMember(l, name15, get15, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache39, true);
		string name16 = "m_achieveGoalObj";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3A == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_achieveGoalObj);
		}
		LuaCSFunction get16 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3A;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3B == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_achieveGoalObj);
		}
		LuaObject.addMember(l, name16, get16, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3B, true);
		string name17 = "m_achieveGoalText";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3C == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_achieveGoalText);
		}
		LuaCSFunction get17 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3C;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3D == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_achieveGoalText);
		}
		LuaObject.addMember(l, name17, get17, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3D, true);
		string name18 = "m_goalProgressText";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3E == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_goalProgressText);
		}
		LuaCSFunction get18 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3E;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3F == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_goalProgressText);
		}
		LuaObject.addMember(l, name18, get18, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache3F, true);
		string name19 = "m_allOperatorObj";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache40 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_allOperatorObj);
		}
		LuaCSFunction get19 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache40;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache41 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_allOperatorObj);
		}
		LuaObject.addMember(l, name19, get19, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache41, true);
		string name20 = "m_operatorImage1";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache42 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_operatorImage1);
		}
		LuaCSFunction get20 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache42;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache43 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_operatorImage1);
		}
		LuaObject.addMember(l, name20, get20, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache43, true);
		string name21 = "m_operatorImage2";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache44 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_operatorImage2);
		}
		LuaCSFunction get21 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache44;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache45 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_operatorImage2);
		}
		LuaObject.addMember(l, name21, get21, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache45, true);
		string name22 = "m_operatorImage3";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache46 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_operatorImage3);
		}
		LuaCSFunction get22 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache46;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache47 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_operatorImage3);
		}
		LuaObject.addMember(l, name22, get22, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache47, true);
		string name23 = "m_payGroupObj";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache48 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_payGroupObj);
		}
		LuaCSFunction get23 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache48;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache49 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_payGroupObj);
		}
		LuaObject.addMember(l, name23, get23, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache49, true);
		string name24 = "m_payGroupRMBIconObj";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4A == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_payGroupRMBIconObj);
		}
		LuaCSFunction get24 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4A;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4B == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_payGroupRMBIconObj);
		}
		LuaObject.addMember(l, name24, get24, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4B, true);
		string name25 = "m_payGroupCrystalIconObj";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4C == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_payGroupCrystalIconObj);
		}
		LuaCSFunction get25 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4C;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4D == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_payGroupCrystalIconObj);
		}
		LuaObject.addMember(l, name25, get25, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4D, true);
		string name26 = "m_payGroupTitleText";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4E == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_payGroupTitleText);
		}
		LuaCSFunction get26 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4E;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4F == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_payGroupTitleText);
		}
		LuaObject.addMember(l, name26, get26, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache4F, true);
		string name27 = "m_payGroupNumberText";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache50 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_payGroupNumberText);
		}
		LuaCSFunction get27 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache50;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache51 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_payGroupNumberText);
		}
		LuaObject.addMember(l, name27, get27, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache51, true);
		string name28 = "m_configDataLoader";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache52 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_configDataLoader);
		}
		LuaCSFunction get28 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache52;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache53 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name28, get28, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache53, true);
		string name29 = "m_playerContext";
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache54 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.get_m_playerContext);
		}
		LuaCSFunction get29 = Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache54;
		if (Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache55 == null)
		{
			Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name29, get29, Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.<>f__mg$cache55, true);
		LuaObject.createTypeMetatable(l, null, typeof(ActivityRewardUIController), typeof(UIControllerBase));
	}

	// Token: 0x0400C239 RID: 49721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C23A RID: 49722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C23B RID: 49723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C23C RID: 49724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C23D RID: 49725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C23E RID: 49726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C23F RID: 49727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C240 RID: 49728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C241 RID: 49729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C242 RID: 49730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C243 RID: 49731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C244 RID: 49732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C245 RID: 49733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C246 RID: 49734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C247 RID: 49735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C248 RID: 49736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C249 RID: 49737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C24A RID: 49738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C24B RID: 49739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C24C RID: 49740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C24D RID: 49741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C24E RID: 49742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C24F RID: 49743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C250 RID: 49744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C251 RID: 49745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C252 RID: 49746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C253 RID: 49747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C254 RID: 49748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C255 RID: 49749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C256 RID: 49750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C257 RID: 49751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C258 RID: 49752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C259 RID: 49753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C25A RID: 49754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C25B RID: 49755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C25C RID: 49756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C25D RID: 49757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C25E RID: 49758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C25F RID: 49759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C260 RID: 49760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C261 RID: 49761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C262 RID: 49762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C263 RID: 49763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C264 RID: 49764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400C265 RID: 49765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400C266 RID: 49766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400C267 RID: 49767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400C268 RID: 49768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400C269 RID: 49769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400C26A RID: 49770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400C26B RID: 49771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400C26C RID: 49772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400C26D RID: 49773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400C26E RID: 49774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400C26F RID: 49775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400C270 RID: 49776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400C271 RID: 49777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400C272 RID: 49778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400C273 RID: 49779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400C274 RID: 49780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400C275 RID: 49781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400C276 RID: 49782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400C277 RID: 49783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400C278 RID: 49784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400C279 RID: 49785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400C27A RID: 49786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400C27B RID: 49787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400C27C RID: 49788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400C27D RID: 49789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400C27E RID: 49790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400C27F RID: 49791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400C280 RID: 49792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400C281 RID: 49793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400C282 RID: 49794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400C283 RID: 49795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400C284 RID: 49796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400C285 RID: 49797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400C286 RID: 49798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400C287 RID: 49799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400C288 RID: 49800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400C289 RID: 49801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400C28A RID: 49802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400C28B RID: 49803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400C28C RID: 49804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400C28D RID: 49805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400C28E RID: 49806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;
}
