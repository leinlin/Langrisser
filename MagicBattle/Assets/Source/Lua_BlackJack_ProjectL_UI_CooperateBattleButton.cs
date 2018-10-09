using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001406 RID: 5126
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CooperateBattleButton : LuaObject
{
	// Token: 0x0601CEE2 RID: 118498 RVA: 0x0090FE64 File Offset: 0x0090E064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCooperateBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleInfo cooperateBattleInfo;
			LuaObject.checkType<ConfigDataCooperateBattleInfo>(l, 2, out cooperateBattleInfo);
			cooperateBattleButton.SetCooperateBattleInfo(cooperateBattleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEE3 RID: 118499 RVA: 0x0090FEBC File Offset: 0x0090E0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCooperateBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleInfo cooperateBattleInfo = cooperateBattleButton.GetCooperateBattleInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEE4 RID: 118500 RVA: 0x0090FF10 File Offset: 0x0090E110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			cooperateBattleButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEE5 RID: 118501 RVA: 0x0090FF64 File Offset: 0x0090E164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			cooperateBattleButton.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEE6 RID: 118502 RVA: 0x0090FFB8 File Offset: 0x0090E1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			cooperateBattleButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEE7 RID: 118503 RVA: 0x00910024 File Offset: 0x0090E224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			cooperateBattleButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEE8 RID: 118504 RVA: 0x00910078 File Offset: 0x0090E278
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			cooperateBattleButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEE9 RID: 118505 RVA: 0x009100CC File Offset: 0x0090E2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = cooperateBattleButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CEEA RID: 118506 RVA: 0x00910174 File Offset: 0x0090E374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			cooperateBattleButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEEB RID: 118507 RVA: 0x009101C8 File Offset: 0x0090E3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			cooperateBattleButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEEC RID: 118508 RVA: 0x00910234 File Offset: 0x0090E434
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
				CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				cooperateBattleButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CooperateBattleButton cooperateBattleButton2 = (CooperateBattleButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				cooperateBattleButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CEED RID: 118509 RVA: 0x00910344 File Offset: 0x0090E544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEEE RID: 118510 RVA: 0x009103B0 File Offset: 0x0090E5B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEEF RID: 118511 RVA: 0x0091041C File Offset: 0x0090E61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEF0 RID: 118512 RVA: 0x00910488 File Offset: 0x0090E688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEF1 RID: 118513 RVA: 0x009104F4 File Offset: 0x0090E6F4
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
				CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				cooperateBattleButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CooperateBattleButton cooperateBattleButton2 = (CooperateBattleButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				cooperateBattleButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CEF2 RID: 118514 RVA: 0x00910604 File Offset: 0x0090E804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			string s = cooperateBattleButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CEF3 RID: 118515 RVA: 0x00910660 File Offset: 0x0090E860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			CooperateBattleButton obj;
			LuaObject.checkType<CooperateBattleButton>(l, 2, out obj);
			cooperateBattleButton.m_luaExportHelper.__callDele_EventOnStartCooperateBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEF4 RID: 118516 RVA: 0x009106BC File Offset: 0x0090E8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			CooperateBattleButton obj;
			LuaObject.checkType<CooperateBattleButton>(l, 2, out obj);
			cooperateBattleButton.m_luaExportHelper.__clearDele_EventOnStartCooperateBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEF5 RID: 118517 RVA: 0x00910718 File Offset: 0x0090E918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEF6 RID: 118518 RVA: 0x00910770 File Offset: 0x0090E970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			cooperateBattleButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEF7 RID: 118519 RVA: 0x009107CC File Offset: 0x0090E9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleButton.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEF8 RID: 118520 RVA: 0x00910824 File Offset: 0x0090EA24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			cooperateBattleButton.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEF9 RID: 118521 RVA: 0x00910880 File Offset: 0x0090EA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgImage(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleButton.m_luaExportHelper.m_bgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEFA RID: 118522 RVA: 0x009108D8 File Offset: 0x0090EAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgImage(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			Image bgImage;
			LuaObject.checkType<Image>(l, 2, out bgImage);
			cooperateBattleButton.m_luaExportHelper.m_bgImage = bgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEFB RID: 118523 RVA: 0x00910934 File Offset: 0x0090EB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgGreyImage(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleButton.m_luaExportHelper.m_bgGreyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEFC RID: 118524 RVA: 0x0091098C File Offset: 0x0090EB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgGreyImage(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			Image bgGreyImage;
			LuaObject.checkType<Image>(l, 2, out bgGreyImage);
			cooperateBattleButton.m_luaExportHelper.m_bgGreyImage = bgGreyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEFD RID: 118525 RVA: 0x009109E8 File Offset: 0x0090EBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleButton.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEFE RID: 118526 RVA: 0x00910A40 File Offset: 0x0090EC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			cooperateBattleButton.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CEFF RID: 118527 RVA: 0x00910A9C File Offset: 0x0090EC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeGreyText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleButton.m_luaExportHelper.m_timeGreyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF00 RID: 118528 RVA: 0x00910AF4 File Offset: 0x0090ECF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeGreyText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			Text timeGreyText;
			LuaObject.checkType<Text>(l, 2, out timeGreyText);
			cooperateBattleButton.m_luaExportHelper.m_timeGreyText = timeGreyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF01 RID: 118529 RVA: 0x00910B50 File Offset: 0x0090ED50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_numberText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleButton.m_luaExportHelper.m_numberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF02 RID: 118530 RVA: 0x00910BA8 File Offset: 0x0090EDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_numberText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			Text numberText;
			LuaObject.checkType<Text>(l, 2, out numberText);
			cooperateBattleButton.m_luaExportHelper.m_numberText = numberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF03 RID: 118531 RVA: 0x00910C04 File Offset: 0x0090EE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			Action<CooperateBattleButton> value;
			int num = LuaObject.checkDelegate<Action<CooperateBattleButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					cooperateBattleButton.EventOnStartCooperateBattle += value;
				}
				else if (num == 2)
				{
					cooperateBattleButton.EventOnStartCooperateBattle -= value;
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

	// Token: 0x0601CF04 RID: 118532 RVA: 0x00910C84 File Offset: 0x0090EE84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_cooperateBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleButton.m_luaExportHelper.m_cooperateBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF05 RID: 118533 RVA: 0x00910CDC File Offset: 0x0090EEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cooperateBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleButton cooperateBattleButton = (CooperateBattleButton)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleInfo cooperateBattleInfo;
			LuaObject.checkType<ConfigDataCooperateBattleInfo>(l, 2, out cooperateBattleInfo);
			cooperateBattleButton.m_luaExportHelper.m_cooperateBattleInfo = cooperateBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF06 RID: 118534 RVA: 0x00910D38 File Offset: 0x0090EF38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CooperateBattleButton");
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.SetCooperateBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.GetCooperateBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__callDele_EventOnStartCooperateBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.__clearDele_EventOnStartCooperateBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache12);
		string name = "m_button";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.get_m_button);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_m_button);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache14, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache16, true);
		string name3 = "m_bgImage";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.get_m_bgImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_m_bgImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache18, true);
		string name4 = "m_bgGreyImage";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.get_m_bgGreyImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_m_bgGreyImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1A, true);
		string name5 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.get_m_timeText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_m_timeText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1C, true);
		string name6 = "m_timeGreyText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.get_m_timeGreyText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_m_timeGreyText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1E, true);
		string name7 = "m_numberText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.get_m_numberText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_m_numberText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache20, true);
		string name8 = "EventOnStartCooperateBattle";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_EventOnStartCooperateBattle);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache21, true);
		string name9 = "m_cooperateBattleInfo";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.get_m_cooperateBattleInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.set_m_cooperateBattleInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CooperateBattleButton.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(CooperateBattleButton), typeof(UIControllerBase));
	}

	// Token: 0x040130B8 RID: 78008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040130B9 RID: 78009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040130BA RID: 78010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040130BB RID: 78011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040130BC RID: 78012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040130BD RID: 78013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040130BE RID: 78014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040130BF RID: 78015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040130C0 RID: 78016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040130C1 RID: 78017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040130C2 RID: 78018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040130C3 RID: 78019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040130C4 RID: 78020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040130C5 RID: 78021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040130C6 RID: 78022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040130C7 RID: 78023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040130C8 RID: 78024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040130C9 RID: 78025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040130CA RID: 78026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040130CB RID: 78027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040130CC RID: 78028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040130CD RID: 78029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040130CE RID: 78030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040130CF RID: 78031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040130D0 RID: 78032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040130D1 RID: 78033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040130D2 RID: 78034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040130D3 RID: 78035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040130D4 RID: 78036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040130D5 RID: 78037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040130D6 RID: 78038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040130D7 RID: 78039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040130D8 RID: 78040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040130D9 RID: 78041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040130DA RID: 78042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040130DB RID: 78043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
