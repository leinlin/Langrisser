using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013FA RID: 5114
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController : LuaObject
{
	// Token: 0x0601CBC7 RID: 117703 RVA: 0x008F70E4 File Offset: 0x008F52E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRaidResult(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 2, out reward);
			climbTowerRaidUIController.ShowRaidResult(reward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBC8 RID: 117704 RVA: 0x008F713C File Offset: 0x008F533C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			climbTowerRaidUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBC9 RID: 117705 RVA: 0x008F7190 File Offset: 0x008F5390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowRaidResult(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 2, out reward);
			IEnumerator o = climbTowerRaidUIController.m_luaExportHelper.Co_ShowRaidResult(reward);
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

	// Token: 0x0601CBCA RID: 117706 RVA: 0x008F71F8 File Offset: 0x008F53F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			IEnumerator o = climbTowerRaidUIController.m_luaExportHelper.Co_WaitClick();
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

	// Token: 0x0601CBCB RID: 117707 RVA: 0x008F7254 File Offset: 0x008F5454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetAndWaitUIState(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out ctrl);
			string state;
			LuaObject.checkType(l, 3, out state);
			IEnumerator o = climbTowerRaidUIController.m_luaExportHelper.Co_SetAndWaitUIState(ctrl, state);
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

	// Token: 0x0601CBCC RID: 117708 RVA: 0x008F72C8 File Offset: 0x008F54C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowPlayerLevelUp(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			int oldLevel;
			LuaObject.checkType(l, 2, out oldLevel);
			int newLevel;
			LuaObject.checkType(l, 3, out newLevel);
			IEnumerator o = climbTowerRaidUIController.m_luaExportHelper.Co_ShowPlayerLevelUp(oldLevel, newLevel);
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

	// Token: 0x0601CBCD RID: 117709 RVA: 0x008F733C File Offset: 0x008F553C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			climbTowerRaidUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBCE RID: 117710 RVA: 0x008F7390 File Offset: 0x008F5590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerLevelUpUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			climbTowerRaidUIController.m_luaExportHelper.PlayerLevelUpUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBCF RID: 117711 RVA: 0x008F73E4 File Offset: 0x008F55E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBD0 RID: 117712 RVA: 0x008F7450 File Offset: 0x008F5650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBD1 RID: 117713 RVA: 0x008F74A4 File Offset: 0x008F56A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBD2 RID: 117714 RVA: 0x008F74F8 File Offset: 0x008F56F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = climbTowerRaidUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CBD3 RID: 117715 RVA: 0x008F75A0 File Offset: 0x008F57A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBD4 RID: 117716 RVA: 0x008F75F4 File Offset: 0x008F57F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBD5 RID: 117717 RVA: 0x008F7660 File Offset: 0x008F5860
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
				ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				climbTowerRaidUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ClimbTowerRaidUIController climbTowerRaidUIController2 = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				climbTowerRaidUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CBD6 RID: 117718 RVA: 0x008F7770 File Offset: 0x008F5970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBD7 RID: 117719 RVA: 0x008F77DC File Offset: 0x008F59DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBD8 RID: 117720 RVA: 0x008F7848 File Offset: 0x008F5A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBD9 RID: 117721 RVA: 0x008F78B4 File Offset: 0x008F5AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerRaidUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBDA RID: 117722 RVA: 0x008F7920 File Offset: 0x008F5B20
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
				ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				climbTowerRaidUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ClimbTowerRaidUIController climbTowerRaidUIController2 = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				climbTowerRaidUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CBDB RID: 117723 RVA: 0x008F7A30 File Offset: 0x008F5C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			string s = climbTowerRaidUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CBDC RID: 117724 RVA: 0x008F7A8C File Offset: 0x008F5C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			climbTowerRaidUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBDD RID: 117725 RVA: 0x008F7AE0 File Offset: 0x008F5CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			climbTowerRaidUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBDE RID: 117726 RVA: 0x008F7B34 File Offset: 0x008F5D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerRaidUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					climbTowerRaidUIController.EventOnClose -= value;
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

	// Token: 0x0601CBDF RID: 117727 RVA: 0x008F7BB4 File Offset: 0x008F5DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE0 RID: 117728 RVA: 0x008F7C0C File Offset: 0x008F5E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			climbTowerRaidUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE1 RID: 117729 RVA: 0x008F7C68 File Offset: 0x008F5E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE2 RID: 117730 RVA: 0x008F7CC0 File Offset: 0x008F5EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			climbTowerRaidUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE3 RID: 117731 RVA: 0x008F7D1C File Offset: 0x008F5F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_costEnergyText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_costEnergyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE4 RID: 117732 RVA: 0x008F7D74 File Offset: 0x008F5F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_costEnergyText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			Text costEnergyText;
			LuaObject.checkType<Text>(l, 2, out costEnergyText);
			climbTowerRaidUIController.m_luaExportHelper.m_costEnergyText = costEnergyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE5 RID: 117733 RVA: 0x008F7DD0 File Offset: 0x008F5FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_floorNameText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_floorNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE6 RID: 117734 RVA: 0x008F7E28 File Offset: 0x008F6028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_floorNameText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			Text floorNameText;
			LuaObject.checkType<Text>(l, 2, out floorNameText);
			climbTowerRaidUIController.m_luaExportHelper.m_floorNameText = floorNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE7 RID: 117735 RVA: 0x008F7E84 File Offset: 0x008F6084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE8 RID: 117736 RVA: 0x008F7EDC File Offset: 0x008F60DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			climbTowerRaidUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBE9 RID: 117737 RVA: 0x008F7F38 File Offset: 0x008F6138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerExpText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_playerExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBEA RID: 117738 RVA: 0x008F7F90 File Offset: 0x008F6190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			Text playerExpText;
			LuaObject.checkType<Text>(l, 2, out playerExpText);
			climbTowerRaidUIController.m_luaExportHelper.m_playerExpText = playerExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBEB RID: 117739 RVA: 0x008F7FEC File Offset: 0x008F61EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerExpImage(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_playerExpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBEC RID: 117740 RVA: 0x008F8044 File Offset: 0x008F6244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpImage(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			Image playerExpImage;
			LuaObject.checkType<Image>(l, 2, out playerExpImage);
			climbTowerRaidUIController.m_luaExportHelper.m_playerExpImage = playerExpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBED RID: 117741 RVA: 0x008F80A0 File Offset: 0x008F62A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardScollRect(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_rewardScollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBEE RID: 117742 RVA: 0x008F80F8 File Offset: 0x008F62F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardScollRect(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			ScrollRect rewardScollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out rewardScollRect);
			climbTowerRaidUIController.m_luaExportHelper.m_rewardScollRect = rewardScollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBEF RID: 117743 RVA: 0x008F8154 File Offset: 0x008F6354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_isClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBF0 RID: 117744 RVA: 0x008F81AC File Offset: 0x008F63AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			bool isClick;
			LuaObject.checkType(l, 2, out isClick);
			climbTowerRaidUIController.m_luaExportHelper.m_isClick = isClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBF1 RID: 117745 RVA: 0x008F8208 File Offset: 0x008F6408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelUpUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidUIController.m_luaExportHelper.m_playerLevelUpUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBF2 RID: 117746 RVA: 0x008F8260 File Offset: 0x008F6460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelUpUITask(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidUIController climbTowerRaidUIController = (ClimbTowerRaidUIController)LuaObject.checkSelf(l);
			PlayerLevelUpUITask playerLevelUpUITask;
			LuaObject.checkType<PlayerLevelUpUITask>(l, 2, out playerLevelUpUITask);
			climbTowerRaidUIController.m_luaExportHelper.m_playerLevelUpUITask = playerLevelUpUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBF3 RID: 117747 RVA: 0x008F82BC File Offset: 0x008F64BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerRaidUIController");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.ShowRaidResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.Co_ShowRaidResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.Co_WaitClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.Co_SetAndWaitUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.Co_ShowPlayerLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.PlayerLevelUpUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache16);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache17, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache19, true);
		string name3 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_backgroundButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1B, true);
		string name4 = "m_costEnergyText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_costEnergyText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_costEnergyText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1D, true);
		string name5 = "m_floorNameText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_floorNameText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_floorNameText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache1F, true);
		string name6 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_playerLevelText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache21, true);
		string name7 = "m_playerExpText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_playerExpText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_playerExpText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache23, true);
		string name8 = "m_playerExpImage";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_playerExpImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_playerExpImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache25, true);
		string name9 = "m_rewardScollRect";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_rewardScollRect);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_rewardScollRect);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache27, true);
		string name10 = "m_isClick";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_isClick);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_isClick);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache29, true);
		string name11 = "m_playerLevelUpUITask";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.get_m_playerLevelUpUITask);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.set_m_playerLevelUpUITask);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.<>f__mg$cache2B, true);
		LuaObject.createTypeMetatable(l, null, typeof(ClimbTowerRaidUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012DB5 RID: 77237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012DB6 RID: 77238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012DB7 RID: 77239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012DB8 RID: 77240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012DB9 RID: 77241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012DBA RID: 77242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012DBB RID: 77243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012DBC RID: 77244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012DBD RID: 77245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012DBE RID: 77246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012DBF RID: 77247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012DC0 RID: 77248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012DC1 RID: 77249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012DC2 RID: 77250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012DC3 RID: 77251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012DC4 RID: 77252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012DC5 RID: 77253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012DC6 RID: 77254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012DC7 RID: 77255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012DC8 RID: 77256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012DC9 RID: 77257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012DCA RID: 77258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012DCB RID: 77259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012DCC RID: 77260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012DCD RID: 77261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012DCE RID: 77262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012DCF RID: 77263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012DD0 RID: 77264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012DD1 RID: 77265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012DD2 RID: 77266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012DD3 RID: 77267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012DD4 RID: 77268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012DD5 RID: 77269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012DD6 RID: 77270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012DD7 RID: 77271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012DD8 RID: 77272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012DD9 RID: 77273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012DDA RID: 77274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012DDB RID: 77275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012DDC RID: 77276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012DDD RID: 77277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012DDE RID: 77278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012DDF RID: 77279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012DE0 RID: 77280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
