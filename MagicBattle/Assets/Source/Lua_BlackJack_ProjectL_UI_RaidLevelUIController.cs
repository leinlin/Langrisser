using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001545 RID: 5445
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RaidLevelUIController : LuaObject
{
	// Token: 0x060208AF RID: 133295 RVA: 0x00ADC14C File Offset: 0x00ADA34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowReward(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 2, out reward);
			List<Goods> extraReward;
			LuaObject.checkType<List<Goods>>(l, 3, out extraReward);
			raidLevelUIController.ShowReward(reward, extraReward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208B0 RID: 133296 RVA: 0x00ADC1B0 File Offset: 0x00ADA3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRaidTicketCount(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			int raidTicketCount;
			LuaObject.checkType(l, 2, out raidTicketCount);
			raidLevelUIController.SetRaidTicketCount(raidTicketCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208B1 RID: 133297 RVA: 0x00ADC208 File Offset: 0x00ADA408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNeedGoods(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 2, out needGoods);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 3, out battleReward);
			List<Goods> extraReward;
			LuaObject.checkType<List<Goods>>(l, 4, out extraReward);
			raidLevelUIController.SetNeedGoods(needGoods, battleReward, extraReward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208B2 RID: 133298 RVA: 0x00ADC27C File Offset: 0x00ADA47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208B3 RID: 133299 RVA: 0x00ADC2D0 File Offset: 0x00ADA4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowReward(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 2, out reward);
			List<Goods> extraReward;
			LuaObject.checkType<List<Goods>>(l, 3, out extraReward);
			IEnumerator o = raidLevelUIController.m_luaExportHelper.Co_ShowReward(reward, extraReward);
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

	// Token: 0x060208B4 RID: 133300 RVA: 0x00ADC344 File Offset: 0x00ADA544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitClick(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			IEnumerator o = raidLevelUIController.m_luaExportHelper.Co_WaitClick();
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

	// Token: 0x060208B5 RID: 133301 RVA: 0x00ADC3A0 File Offset: 0x00ADA5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetAndWaitUIState(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out ctrl);
			string state;
			LuaObject.checkType(l, 3, out state);
			IEnumerator o = raidLevelUIController.m_luaExportHelper.Co_SetAndWaitUIState(ctrl, state);
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

	// Token: 0x060208B6 RID: 133302 RVA: 0x00ADC414 File Offset: 0x00ADA614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowPlayerLevelUp(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			int oldLevel;
			LuaObject.checkType(l, 2, out oldLevel);
			int newLevel;
			LuaObject.checkType(l, 3, out newLevel);
			IEnumerator o = raidLevelUIController.m_luaExportHelper.Co_ShowPlayerLevelUp(oldLevel, newLevel);
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

	// Token: 0x060208B7 RID: 133303 RVA: 0x00ADC488 File Offset: 0x00ADA688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRewardGoods(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.ClearRewardGoods();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208B8 RID: 133304 RVA: 0x00ADC4DC File Offset: 0x00ADA6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208B9 RID: 133305 RVA: 0x00ADC530 File Offset: 0x00ADA730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRaidAgainButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.OnRaidAgainButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208BA RID: 133306 RVA: 0x00ADC584 File Offset: 0x00ADA784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerLevelUpUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.PlayerLevelUpUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208BB RID: 133307 RVA: 0x00ADC5D8 File Offset: 0x00ADA7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			raidLevelUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208BC RID: 133308 RVA: 0x00ADC644 File Offset: 0x00ADA844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208BD RID: 133309 RVA: 0x00ADC698 File Offset: 0x00ADA898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208BE RID: 133310 RVA: 0x00ADC6EC File Offset: 0x00ADA8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = raidLevelUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060208BF RID: 133311 RVA: 0x00ADC794 File Offset: 0x00ADA994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208C0 RID: 133312 RVA: 0x00ADC7E8 File Offset: 0x00ADA9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			raidLevelUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208C1 RID: 133313 RVA: 0x00ADC854 File Offset: 0x00ADAA54
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
				RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				raidLevelUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RaidLevelUIController raidLevelUIController2 = (RaidLevelUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				raidLevelUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060208C2 RID: 133314 RVA: 0x00ADC964 File Offset: 0x00ADAB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raidLevelUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208C3 RID: 133315 RVA: 0x00ADC9D0 File Offset: 0x00ADABD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raidLevelUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208C4 RID: 133316 RVA: 0x00ADCA3C File Offset: 0x00ADAC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raidLevelUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208C5 RID: 133317 RVA: 0x00ADCAA8 File Offset: 0x00ADACA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raidLevelUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208C6 RID: 133318 RVA: 0x00ADCB14 File Offset: 0x00ADAD14
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
				RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				raidLevelUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RaidLevelUIController raidLevelUIController2 = (RaidLevelUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				raidLevelUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060208C7 RID: 133319 RVA: 0x00ADCC24 File Offset: 0x00ADAE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			string s = raidLevelUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060208C8 RID: 133320 RVA: 0x00ADCC80 File Offset: 0x00ADAE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208C9 RID: 133321 RVA: 0x00ADCCD4 File Offset: 0x00ADAED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208CA RID: 133322 RVA: 0x00ADCD28 File Offset: 0x00ADAF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRaidAgain(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.__callDele_EventOnRaidAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208CB RID: 133323 RVA: 0x00ADCD7C File Offset: 0x00ADAF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRaidAgain(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			raidLevelUIController.m_luaExportHelper.__clearDele_EventOnRaidAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208CC RID: 133324 RVA: 0x00ADCDD0 File Offset: 0x00ADAFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					raidLevelUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					raidLevelUIController.EventOnClose -= value;
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

	// Token: 0x060208CD RID: 133325 RVA: 0x00ADCE50 File Offset: 0x00ADB050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRaidAgain(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					raidLevelUIController.EventOnRaidAgain += value;
				}
				else if (num == 2)
				{
					raidLevelUIController.EventOnRaidAgain -= value;
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

	// Token: 0x060208CE RID: 133326 RVA: 0x00ADCED0 File Offset: 0x00ADB0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208CF RID: 133327 RVA: 0x00ADCF28 File Offset: 0x00ADB128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			raidLevelUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D0 RID: 133328 RVA: 0x00ADCF84 File Offset: 0x00ADB184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelUpEffectObj(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_levelUpEffectObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D1 RID: 133329 RVA: 0x00ADCFDC File Offset: 0x00ADB1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelUpEffectObj(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			GameObject levelUpEffectObj;
			LuaObject.checkType<GameObject>(l, 2, out levelUpEffectObj);
			raidLevelUIController.m_luaExportHelper.m_levelUpEffectObj = levelUpEffectObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D2 RID: 133330 RVA: 0x00ADD038 File Offset: 0x00ADB238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D3 RID: 133331 RVA: 0x00ADD090 File Offset: 0x00ADB290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			raidLevelUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D4 RID: 133332 RVA: 0x00ADD0EC File Offset: 0x00ADB2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidAgainButton(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_raidAgainButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D5 RID: 133333 RVA: 0x00ADD144 File Offset: 0x00ADB344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidAgainButton(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Button raidAgainButton;
			LuaObject.checkType<Button>(l, 2, out raidAgainButton);
			raidLevelUIController.m_luaExportHelper.m_raidAgainButton = raidAgainButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D6 RID: 133334 RVA: 0x00ADD1A0 File Offset: 0x00ADB3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cannelButton(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_cannelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D7 RID: 133335 RVA: 0x00ADD1F8 File Offset: 0x00ADB3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cannelButton(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Button cannelButton;
			LuaObject.checkType<Button>(l, 2, out cannelButton);
			raidLevelUIController.m_luaExportHelper.m_cannelButton = cannelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D8 RID: 133336 RVA: 0x00ADD254 File Offset: 0x00ADB454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208D9 RID: 133337 RVA: 0x00ADD2AC File Offset: 0x00ADB4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			raidLevelUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208DA RID: 133338 RVA: 0x00ADD308 File Offset: 0x00ADB508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerExpText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_playerExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208DB RID: 133339 RVA: 0x00ADD360 File Offset: 0x00ADB560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Text playerExpText;
			LuaObject.checkType<Text>(l, 2, out playerExpText);
			raidLevelUIController.m_luaExportHelper.m_playerExpText = playerExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208DC RID: 133340 RVA: 0x00ADD3BC File Offset: 0x00ADB5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerExpImage(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_playerExpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208DD RID: 133341 RVA: 0x00ADD414 File Offset: 0x00ADB614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpImage(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Image playerExpImage;
			LuaObject.checkType<Image>(l, 2, out playerExpImage);
			raidLevelUIController.m_luaExportHelper.m_playerExpImage = playerExpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208DE RID: 133342 RVA: 0x00ADD470 File Offset: 0x00ADB670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_goldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208DF RID: 133343 RVA: 0x00ADD4C8 File Offset: 0x00ADB6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Text goldText;
			LuaObject.checkType<Text>(l, 2, out goldText);
			raidLevelUIController.m_luaExportHelper.m_goldText = goldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E0 RID: 133344 RVA: 0x00ADD524 File Offset: 0x00ADB724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoodsGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_rewardGoodsGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E1 RID: 133345 RVA: 0x00ADD57C File Offset: 0x00ADB77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoodsGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			GameObject rewardGoodsGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGoodsGroupGameObject);
			raidLevelUIController.m_luaExportHelper.m_rewardGoodsGroupGameObject = rewardGoodsGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E2 RID: 133346 RVA: 0x00ADD5D8 File Offset: 0x00ADB7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraRewardGoodsGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_extraRewardGoodsGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E3 RID: 133347 RVA: 0x00ADD630 File Offset: 0x00ADB830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraRewardGoodsGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			GameObject extraRewardGoodsGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out extraRewardGoodsGroupGameObject);
			raidLevelUIController.m_luaExportHelper.m_extraRewardGoodsGroupGameObject = extraRewardGoodsGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E4 RID: 133348 RVA: 0x00ADD68C File Offset: 0x00ADB88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidTicketText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_raidTicketText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E5 RID: 133349 RVA: 0x00ADD6E4 File Offset: 0x00ADB8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidTicketText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Text raidTicketText;
			LuaObject.checkType<Text>(l, 2, out raidTicketText);
			raidLevelUIController.m_luaExportHelper.m_raidTicketText = raidTicketText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E6 RID: 133350 RVA: 0x00ADD740 File Offset: 0x00ADB940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoodsPanelCommonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_needGoodsPanelCommonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E7 RID: 133351 RVA: 0x00ADD798 File Offset: 0x00ADB998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoodsPanelCommonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			CommonUIStateController needGoodsPanelCommonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out needGoodsPanelCommonUIStateCtrl);
			raidLevelUIController.m_luaExportHelper.m_needGoodsPanelCommonUIStateCtrl = needGoodsPanelCommonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E8 RID: 133352 RVA: 0x00ADD7F4 File Offset: 0x00ADB9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoodsPanel(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_needGoodsPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208E9 RID: 133353 RVA: 0x00ADD84C File Offset: 0x00ADBA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoodsPanel(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			GameObject needGoodsPanel;
			LuaObject.checkType<GameObject>(l, 2, out needGoodsPanel);
			raidLevelUIController.m_luaExportHelper.m_needGoodsPanel = needGoodsPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208EA RID: 133354 RVA: 0x00ADD8A8 File Offset: 0x00ADBAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoodsIconImage(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_needGoodsIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208EB RID: 133355 RVA: 0x00ADD900 File Offset: 0x00ADBB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoodsIconImage(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Image needGoodsIconImage;
			LuaObject.checkType<Image>(l, 2, out needGoodsIconImage);
			raidLevelUIController.m_luaExportHelper.m_needGoodsIconImage = needGoodsIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208EC RID: 133356 RVA: 0x00ADD95C File Offset: 0x00ADBB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoodsNameText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_needGoodsNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208ED RID: 133357 RVA: 0x00ADD9B4 File Offset: 0x00ADBBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoodsNameText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Text needGoodsNameText;
			LuaObject.checkType<Text>(l, 2, out needGoodsNameText);
			raidLevelUIController.m_luaExportHelper.m_needGoodsNameText = needGoodsNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208EE RID: 133358 RVA: 0x00ADDA10 File Offset: 0x00ADBC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lackBGImageGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_lackBGImageGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208EF RID: 133359 RVA: 0x00ADDA68 File Offset: 0x00ADBC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lackBGImageGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			GameObject lackBGImageGameObject;
			LuaObject.checkType<GameObject>(l, 2, out lackBGImageGameObject);
			raidLevelUIController.m_luaExportHelper.m_lackBGImageGameObject = lackBGImageGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F0 RID: 133360 RVA: 0x00ADDAC4 File Offset: 0x00ADBCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lackTitleGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_lackTitleGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F1 RID: 133361 RVA: 0x00ADDB1C File Offset: 0x00ADBD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lackTitleGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			GameObject lackTitleGameObject;
			LuaObject.checkType<GameObject>(l, 2, out lackTitleGameObject);
			raidLevelUIController.m_luaExportHelper.m_lackTitleGameObject = lackTitleGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F2 RID: 133362 RVA: 0x00ADDB78 File Offset: 0x00ADBD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoodsLackText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_needGoodsLackText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F3 RID: 133363 RVA: 0x00ADDBD0 File Offset: 0x00ADBDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoodsLackText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Text needGoodsLackText;
			LuaObject.checkType<Text>(l, 2, out needGoodsLackText);
			raidLevelUIController.m_luaExportHelper.m_needGoodsLackText = needGoodsLackText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F4 RID: 133364 RVA: 0x00ADDC2C File Offset: 0x00ADBE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoodsEnoughGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_needGoodsEnoughGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F5 RID: 133365 RVA: 0x00ADDC84 File Offset: 0x00ADBE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoodsEnoughGameObject(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			GameObject needGoodsEnoughGameObject;
			LuaObject.checkType<GameObject>(l, 2, out needGoodsEnoughGameObject);
			raidLevelUIController.m_luaExportHelper.m_needGoodsEnoughGameObject = needGoodsEnoughGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F6 RID: 133366 RVA: 0x00ADDCE0 File Offset: 0x00ADBEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needGoodsGainText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_needGoodsGainText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F7 RID: 133367 RVA: 0x00ADDD38 File Offset: 0x00ADBF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needGoodsGainText(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			Text needGoodsGainText;
			LuaObject.checkType<Text>(l, 2, out needGoodsGainText);
			raidLevelUIController.m_luaExportHelper.m_needGoodsGainText = needGoodsGainText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F8 RID: 133368 RVA: 0x00ADDD94 File Offset: 0x00ADBF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoods(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_rewardGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208F9 RID: 133369 RVA: 0x00ADDDEC File Offset: 0x00ADBFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoods(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			List<RewardGoodsUIController> rewardGoods;
			LuaObject.checkType<List<RewardGoodsUIController>>(l, 2, out rewardGoods);
			raidLevelUIController.m_luaExportHelper.m_rewardGoods = rewardGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208FA RID: 133370 RVA: 0x00ADDE48 File Offset: 0x00ADC048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_isClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208FB RID: 133371 RVA: 0x00ADDEA0 File Offset: 0x00ADC0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			bool isClick;
			LuaObject.checkType(l, 2, out isClick);
			raidLevelUIController.m_luaExportHelper.m_isClick = isClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208FC RID: 133372 RVA: 0x00ADDEFC File Offset: 0x00ADC0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelUpUITask(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_playerLevelUpUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208FD RID: 133373 RVA: 0x00ADDF54 File Offset: 0x00ADC154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelUpUITask(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			PlayerLevelUpUITask playerLevelUpUITask;
			LuaObject.checkType<PlayerLevelUpUITask>(l, 2, out playerLevelUpUITask);
			raidLevelUIController.m_luaExportHelper.m_playerLevelUpUITask = playerLevelUpUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208FE RID: 133374 RVA: 0x00ADDFB0 File Offset: 0x00ADC1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gainNeedGoodsCount(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_gainNeedGoodsCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060208FF RID: 133375 RVA: 0x00ADE008 File Offset: 0x00ADC208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gainNeedGoodsCount(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			int gainNeedGoodsCount;
			LuaObject.checkType(l, 2, out gainNeedGoodsCount);
			raidLevelUIController.m_luaExportHelper.m_gainNeedGoodsCount = gainNeedGoodsCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020900 RID: 133376 RVA: 0x00ADE064 File Offset: 0x00ADC264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raidLevelUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020901 RID: 133377 RVA: 0x00ADE0BC File Offset: 0x00ADC2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			RaidLevelUIController raidLevelUIController = (RaidLevelUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			raidLevelUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020902 RID: 133378 RVA: 0x00ADE118 File Offset: 0x00ADC318
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RaidLevelUIController");
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.ShowReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.SetRaidTicketCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.SetNeedGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.Co_ShowReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.Co_WaitClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.Co_SetAndWaitUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.Co_ShowPlayerLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.ClearRewardGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.OnRaidAgainButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.PlayerLevelUpUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__callDele_EventOnRaidAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.__clearDele_EventOnRaidAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1C);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1D, true);
		string name2 = "EventOnRaidAgain";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_EventOnRaidAgain);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1E, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache20, true);
		string name4 = "m_levelUpEffectObj";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_levelUpEffectObj);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_levelUpEffectObj);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache22, true);
		string name5 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_backgroundButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache24, true);
		string name6 = "m_raidAgainButton";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_raidAgainButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_raidAgainButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache26, true);
		string name7 = "m_cannelButton";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_cannelButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_cannelButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache28, true);
		string name8 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_playerLevelText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2A, true);
		string name9 = "m_playerExpText";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_playerExpText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_playerExpText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2C, true);
		string name10 = "m_playerExpImage";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_playerExpImage);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_playerExpImage);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2E, true);
		string name11 = "m_goldText";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_goldText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_goldText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache30, true);
		string name12 = "m_rewardGoodsGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_rewardGoodsGroupGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_rewardGoodsGroupGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache32, true);
		string name13 = "m_extraRewardGoodsGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_extraRewardGoodsGroupGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_extraRewardGoodsGroupGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache34, true);
		string name14 = "m_raidTicketText";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_raidTicketText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_raidTicketText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache36, true);
		string name15 = "m_needGoodsPanelCommonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_needGoodsPanelCommonUIStateCtrl);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_needGoodsPanelCommonUIStateCtrl);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache38, true);
		string name16 = "m_needGoodsPanel";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_needGoodsPanel);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_needGoodsPanel);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3A, true);
		string name17 = "m_needGoodsIconImage";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_needGoodsIconImage);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_needGoodsIconImage);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3C, true);
		string name18 = "m_needGoodsNameText";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_needGoodsNameText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_needGoodsNameText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3E, true);
		string name19 = "m_lackBGImageGameObject";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_lackBGImageGameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_lackBGImageGameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache40, true);
		string name20 = "m_lackTitleGameObject";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_lackTitleGameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_lackTitleGameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache42, true);
		string name21 = "m_needGoodsLackText";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_needGoodsLackText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_needGoodsLackText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache44, true);
		string name22 = "m_needGoodsEnoughGameObject";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_needGoodsEnoughGameObject);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_needGoodsEnoughGameObject);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache46, true);
		string name23 = "m_needGoodsGainText";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_needGoodsGainText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_needGoodsGainText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache48, true);
		string name24 = "m_rewardGoods";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_rewardGoods);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_rewardGoods);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4A, true);
		string name25 = "m_isClick";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_isClick);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_isClick);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4C, true);
		string name26 = "m_playerLevelUpUITask";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_playerLevelUpUITask);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_playerLevelUpUITask);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4E, true);
		string name27 = "m_gainNeedGoodsCount";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_gainNeedGoodsCount);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_gainNeedGoodsCount);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache50, true);
		string name28 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.get_m_playerContext);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_RaidLevelUIController.<>f__mg$cache52, true);
		LuaObject.createTypeMetatable(l, null, typeof(RaidLevelUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016807 RID: 92167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016808 RID: 92168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016809 RID: 92169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401680A RID: 92170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401680B RID: 92171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401680C RID: 92172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401680D RID: 92173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401680E RID: 92174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401680F RID: 92175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016810 RID: 92176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016811 RID: 92177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016812 RID: 92178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016813 RID: 92179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016814 RID: 92180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016815 RID: 92181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016816 RID: 92182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016817 RID: 92183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016818 RID: 92184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016819 RID: 92185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401681A RID: 92186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401681B RID: 92187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401681C RID: 92188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401681D RID: 92189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401681E RID: 92190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401681F RID: 92191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016820 RID: 92192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016821 RID: 92193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016822 RID: 92194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016823 RID: 92195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016824 RID: 92196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016825 RID: 92197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016826 RID: 92198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016827 RID: 92199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016828 RID: 92200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016829 RID: 92201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401682A RID: 92202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401682B RID: 92203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401682C RID: 92204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401682D RID: 92205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401682E RID: 92206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401682F RID: 92207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016830 RID: 92208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016831 RID: 92209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016832 RID: 92210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016833 RID: 92211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016834 RID: 92212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016835 RID: 92213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016836 RID: 92214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016837 RID: 92215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016838 RID: 92216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016839 RID: 92217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401683A RID: 92218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401683B RID: 92219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401683C RID: 92220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401683D RID: 92221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401683E RID: 92222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401683F RID: 92223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016840 RID: 92224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016841 RID: 92225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016842 RID: 92226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016843 RID: 92227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016844 RID: 92228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016845 RID: 92229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016846 RID: 92230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016847 RID: 92231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016848 RID: 92232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016849 RID: 92233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401684A RID: 92234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401684B RID: 92235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401684C RID: 92236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401684D RID: 92237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401684E RID: 92238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401684F RID: 92239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04016850 RID: 92240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04016851 RID: 92241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04016852 RID: 92242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04016853 RID: 92243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04016854 RID: 92244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016855 RID: 92245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016856 RID: 92246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016857 RID: 92247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016858 RID: 92248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016859 RID: 92249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;
}
