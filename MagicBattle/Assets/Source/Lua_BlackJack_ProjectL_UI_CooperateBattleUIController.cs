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

// Token: 0x02001408 RID: 5128
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CooperateBattleUIController : LuaObject
{
	// Token: 0x0601CF30 RID: 118576 RVA: 0x0091275C File Offset: 0x0091095C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF31 RID: 118577 RVA: 0x009127A8 File Offset: 0x009109A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleInfo cooperateBattle;
			LuaObject.checkType<ConfigDataCooperateBattleInfo>(l, 2, out cooperateBattle);
			cooperateBattleUIController.SetCooperateBattle(cooperateBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF32 RID: 118578 RVA: 0x00912800 File Offset: 0x00910A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAllCooperateBattleLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			List<ConfigDataCooperateBattleLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataCooperateBattleLevelInfo>>(l, 2, out levelInfos);
			cooperateBattleUIController.AddAllCooperateBattleLevelListItems(levelInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF33 RID: 118579 RVA: 0x00912858 File Offset: 0x00910A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearCooperateBattleLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.ClearCooperateBattleLevelListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF34 RID: 118580 RVA: 0x009128A4 File Offset: 0x00910AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDailyRewardCount(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			int restCount;
			LuaObject.checkType(l, 2, out restCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			cooperateBattleUIController.SetDailyRewardCount(restCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF35 RID: 118581 RVA: 0x00912908 File Offset: 0x00910B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF36 RID: 118582 RVA: 0x0091295C File Offset: 0x00910B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCooperateBattleLevelListItem(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo levelnfo;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out levelnfo);
			bool opened;
			LuaObject.checkType(l, 3, out opened);
			cooperateBattleUIController.m_luaExportHelper.AddCooperateBattleLevelListItem(levelnfo, opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF37 RID: 118583 RVA: 0x009129C8 File Offset: 0x00910BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF38 RID: 118584 RVA: 0x00912A1C File Offset: 0x00910C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF39 RID: 118585 RVA: 0x00912A70 File Offset: 0x00910C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.OnAddTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF3A RID: 118586 RVA: 0x00912AC4 File Offset: 0x00910CC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.OnTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF3B RID: 118587 RVA: 0x00912B18 File Offset: 0x00910D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CooperateBattleLevelListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			CooperateBattleLevelListItemUIController b;
			LuaObject.checkType<CooperateBattleLevelListItemUIController>(l, 2, out b);
			cooperateBattleUIController.m_luaExportHelper.CooperateBattleLevelListItem_OnStartButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF3C RID: 118588 RVA: 0x00912B74 File Offset: 0x00910D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			cooperateBattleUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF3D RID: 118589 RVA: 0x00912BE0 File Offset: 0x00910DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF3E RID: 118590 RVA: 0x00912C34 File Offset: 0x00910E34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF3F RID: 118591 RVA: 0x00912C88 File Offset: 0x00910E88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = cooperateBattleUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CF40 RID: 118592 RVA: 0x00912D30 File Offset: 0x00910F30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF41 RID: 118593 RVA: 0x00912D84 File Offset: 0x00910F84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			cooperateBattleUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF42 RID: 118594 RVA: 0x00912DF0 File Offset: 0x00910FF0
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
				CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				cooperateBattleUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CooperateBattleUIController cooperateBattleUIController2 = (CooperateBattleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				cooperateBattleUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CF43 RID: 118595 RVA: 0x00912F00 File Offset: 0x00911100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF44 RID: 118596 RVA: 0x00912F6C File Offset: 0x0091116C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF45 RID: 118597 RVA: 0x00912FD8 File Offset: 0x009111D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF46 RID: 118598 RVA: 0x00913044 File Offset: 0x00911244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF47 RID: 118599 RVA: 0x009130B0 File Offset: 0x009112B0
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
				CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				cooperateBattleUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CooperateBattleUIController cooperateBattleUIController2 = (CooperateBattleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				cooperateBattleUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CF48 RID: 118600 RVA: 0x009131C0 File Offset: 0x009113C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			string s = cooperateBattleUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CF49 RID: 118601 RVA: 0x0091321C File Offset: 0x0091141C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF4A RID: 118602 RVA: 0x00913270 File Offset: 0x00911470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF4B RID: 118603 RVA: 0x009132C4 File Offset: 0x009114C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF4C RID: 118604 RVA: 0x00913318 File Offset: 0x00911518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF4D RID: 118605 RVA: 0x0091336C File Offset: 0x0091156C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__callDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF4E RID: 118606 RVA: 0x009133C0 File Offset: 0x009115C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__clearDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF4F RID: 118607 RVA: 0x00913414 File Offset: 0x00911614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__callDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF50 RID: 118608 RVA: 0x00913468 File Offset: 0x00911668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			cooperateBattleUIController.m_luaExportHelper.__clearDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF51 RID: 118609 RVA: 0x009134BC File Offset: 0x009116BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo obj;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out obj);
			cooperateBattleUIController.m_luaExportHelper.__callDele_EventOnStartCooperateBattleLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF52 RID: 118610 RVA: 0x00913518 File Offset: 0x00911718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo obj;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out obj);
			cooperateBattleUIController.m_luaExportHelper.__clearDele_EventOnStartCooperateBattleLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF53 RID: 118611 RVA: 0x00913574 File Offset: 0x00911774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					cooperateBattleUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					cooperateBattleUIController.EventOnReturn -= value;
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

	// Token: 0x0601CF54 RID: 118612 RVA: 0x009135F4 File Offset: 0x009117F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					cooperateBattleUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					cooperateBattleUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601CF55 RID: 118613 RVA: 0x00913674 File Offset: 0x00911874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					cooperateBattleUIController.EventOnAddTicket += value;
				}
				else if (num == 2)
				{
					cooperateBattleUIController.EventOnAddTicket -= value;
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

	// Token: 0x0601CF56 RID: 118614 RVA: 0x009136F4 File Offset: 0x009118F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					cooperateBattleUIController.EventOnShowTeam += value;
				}
				else if (num == 2)
				{
					cooperateBattleUIController.EventOnShowTeam -= value;
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

	// Token: 0x0601CF57 RID: 118615 RVA: 0x00913774 File Offset: 0x00911974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Action<ConfigDataCooperateBattleLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataCooperateBattleLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					cooperateBattleUIController.EventOnStartCooperateBattleLevel += value;
				}
				else if (num == 2)
				{
					cooperateBattleUIController.EventOnStartCooperateBattleLevel -= value;
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

	// Token: 0x0601CF58 RID: 118616 RVA: 0x009137F4 File Offset: 0x009119F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF59 RID: 118617 RVA: 0x0091384C File Offset: 0x00911A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			cooperateBattleUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF5A RID: 118618 RVA: 0x009138A8 File Offset: 0x00911AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF5B RID: 118619 RVA: 0x00913900 File Offset: 0x00911B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			cooperateBattleUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF5C RID: 118620 RVA: 0x0091395C File Offset: 0x00911B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF5D RID: 118621 RVA: 0x009139B4 File Offset: 0x00911BB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			cooperateBattleUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF5E RID: 118622 RVA: 0x00913A10 File Offset: 0x00911C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_teamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF5F RID: 118623 RVA: 0x00913A68 File Offset: 0x00911C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Button teamButton;
			LuaObject.checkType<Button>(l, 2, out teamButton);
			cooperateBattleUIController.m_luaExportHelper.m_teamButton = teamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF60 RID: 118624 RVA: 0x00913AC4 File Offset: 0x00911CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_dailyRewardCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF61 RID: 118625 RVA: 0x00913B1C File Offset: 0x00911D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Text dailyRewardCountText;
			LuaObject.checkType<Text>(l, 2, out dailyRewardCountText);
			cooperateBattleUIController.m_luaExportHelper.m_dailyRewardCountText = dailyRewardCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF62 RID: 118626 RVA: 0x00913B78 File Offset: 0x00911D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterNameText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_chapterNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF63 RID: 118627 RVA: 0x00913BD0 File Offset: 0x00911DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chapterNameText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Text chapterNameText;
			LuaObject.checkType<Text>(l, 2, out chapterNameText);
			cooperateBattleUIController.m_luaExportHelper.m_chapterNameText = chapterNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF64 RID: 118628 RVA: 0x00913C2C File Offset: 0x00911E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterDescText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_chapterDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF65 RID: 118629 RVA: 0x00913C84 File Offset: 0x00911E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chapterDescText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Text chapterDescText;
			LuaObject.checkType<Text>(l, 2, out chapterDescText);
			cooperateBattleUIController.m_luaExportHelper.m_chapterDescText = chapterDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF66 RID: 118630 RVA: 0x00913CE0 File Offset: 0x00911EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterImage(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_chapterImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF67 RID: 118631 RVA: 0x00913D38 File Offset: 0x00911F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chapterImage(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			Image chapterImage;
			LuaObject.checkType<Image>(l, 2, out chapterImage);
			cooperateBattleUIController.m_luaExportHelper.m_chapterImage = chapterImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF68 RID: 118632 RVA: 0x00913D94 File Offset: 0x00911F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_levelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF69 RID: 118633 RVA: 0x00913DEC File Offset: 0x00911FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			ScrollRect levelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelListScrollRect);
			cooperateBattleUIController.m_luaExportHelper.m_levelListScrollRect = levelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF6A RID: 118634 RVA: 0x00913E48 File Offset: 0x00912048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF6B RID: 118635 RVA: 0x00913EA0 File Offset: 0x009120A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			cooperateBattleUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF6C RID: 118636 RVA: 0x00913EFC File Offset: 0x009120FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_CooperateBattleLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_CooperateBattleLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF6D RID: 118637 RVA: 0x00913F54 File Offset: 0x00912154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_CooperateBattleLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			GameObject cooperateBattleLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out cooperateBattleLevelListItemPrefab);
			cooperateBattleUIController.m_luaExportHelper.m_CooperateBattleLevelListItemPrefab = cooperateBattleLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF6E RID: 118638 RVA: 0x00913FB0 File Offset: 0x009121B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_CooperateBattleLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleUIController.m_luaExportHelper.m_CooperateBattleLevelListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF6F RID: 118639 RVA: 0x00914008 File Offset: 0x00912208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_CooperateBattleLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleUIController cooperateBattleUIController = (CooperateBattleUIController)LuaObject.checkSelf(l);
			List<CooperateBattleLevelListItemUIController> cooperateBattleLevelListItems;
			LuaObject.checkType<List<CooperateBattleLevelListItemUIController>>(l, 2, out cooperateBattleLevelListItems);
			cooperateBattleUIController.m_luaExportHelper.m_CooperateBattleLevelListItems = cooperateBattleLevelListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF70 RID: 118640 RVA: 0x00914064 File Offset: 0x00912264
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CooperateBattleUIController");
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.SetCooperateBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.AddAllCooperateBattleLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.ClearCooperateBattleLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.SetDailyRewardCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.AddCooperateBattleLevelListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.OnAddTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.OnTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.CooperateBattleLevelListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__clearDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__clearDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__callDele_EventOnStartCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.__clearDele_EventOnStartCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache22);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache23, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache24, true);
		string name3 = "EventOnAddTicket";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_EventOnAddTicket);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache25, true);
		string name4 = "EventOnShowTeam";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_EventOnShowTeam);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache26, true);
		string name5 = "EventOnStartCooperateBattleLevel";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_EventOnStartCooperateBattleLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache27, true);
		string name6 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_uiStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache29, true);
		string name7 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_returnButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2B, true);
		string name8 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_helpButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2D, true);
		string name9 = "m_teamButton";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_teamButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_teamButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache2F, true);
		string name10 = "m_dailyRewardCountText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_dailyRewardCountText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_dailyRewardCountText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache31, true);
		string name11 = "m_chapterNameText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_chapterNameText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_chapterNameText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache33, true);
		string name12 = "m_chapterDescText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_chapterDescText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_chapterDescText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache35, true);
		string name13 = "m_chapterImage";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_chapterImage);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_chapterImage);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache37, true);
		string name14 = "m_levelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_levelListScrollRect);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_levelListScrollRect);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache39, true);
		string name15 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3B, true);
		string name16 = "m_CooperateBattleLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_CooperateBattleLevelListItemPrefab);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_CooperateBattleLevelListItemPrefab);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3D, true);
		string name17 = "m_CooperateBattleLevelListItems";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.get_m_CooperateBattleLevelListItems);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.set_m_CooperateBattleLevelListItems);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.<>f__mg$cache3F, true);
		LuaObject.createTypeMetatable(l, null, typeof(CooperateBattleUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013102 RID: 78082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013103 RID: 78083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013104 RID: 78084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013105 RID: 78085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013106 RID: 78086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013107 RID: 78087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013108 RID: 78088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013109 RID: 78089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401310A RID: 78090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401310B RID: 78091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401310C RID: 78092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401310D RID: 78093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401310E RID: 78094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401310F RID: 78095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013110 RID: 78096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013111 RID: 78097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013112 RID: 78098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013113 RID: 78099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013114 RID: 78100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013115 RID: 78101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013116 RID: 78102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013117 RID: 78103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013118 RID: 78104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013119 RID: 78105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401311A RID: 78106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401311B RID: 78107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401311C RID: 78108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401311D RID: 78109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401311E RID: 78110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401311F RID: 78111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013120 RID: 78112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013121 RID: 78113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013122 RID: 78114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013123 RID: 78115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013124 RID: 78116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013125 RID: 78117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013126 RID: 78118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013127 RID: 78119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013128 RID: 78120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013129 RID: 78121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401312A RID: 78122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401312B RID: 78123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401312C RID: 78124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401312D RID: 78125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401312E RID: 78126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401312F RID: 78127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013130 RID: 78128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013131 RID: 78129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013132 RID: 78130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013133 RID: 78131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013134 RID: 78132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013135 RID: 78133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013136 RID: 78134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013137 RID: 78135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013138 RID: 78136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013139 RID: 78137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401313A RID: 78138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401313B RID: 78139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401313C RID: 78140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401313D RID: 78141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401313E RID: 78142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401313F RID: 78143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013140 RID: 78144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013141 RID: 78145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;
}
