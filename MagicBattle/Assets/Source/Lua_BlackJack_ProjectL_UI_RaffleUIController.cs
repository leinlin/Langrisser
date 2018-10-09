using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001543 RID: 5443
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RaffleUIController : LuaObject
{
	// Token: 0x06020815 RID: 133141 RVA: 0x00AD7414 File Offset: 0x00AD5614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRafflePanel(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			RafflePool rafflePool;
			LuaObject.checkType<RafflePool>(l, 2, out rafflePool);
			raffleUIController.UpdateRafflePanel(rafflePool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020816 RID: 133142 RVA: 0x00AD746C File Offset: 0x00AD566C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Get3DViewRectTransfrom(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			RectTransform o = raffleUIController.Get3DViewRectTransfrom();
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

	// Token: 0x06020817 RID: 133143 RVA: 0x00AD74C0 File Offset: 0x00AD56C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDrawRewardLevelEffect(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			int rewardLevel;
			LuaObject.checkType(l, 2, out rewardLevel);
			bool isShow;
			LuaObject.checkType(l, 3, out isShow);
			raffleUIController.ShowDrawRewardLevelEffect(rewardLevel, isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020818 RID: 133144 RVA: 0x00AD7524 File Offset: 0x00AD5724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020819 RID: 133145 RVA: 0x00AD7578 File Offset: 0x00AD5778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLevelEffectNameByLevel(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			int rewardLevel;
			LuaObject.checkType(l, 2, out rewardLevel);
			string levelEffectNameByLevel = raffleUIController.m_luaExportHelper.GetLevelEffectNameByLevel(rewardLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelEffectNameByLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602081A RID: 133146 RVA: 0x00AD75E0 File Offset: 0x00AD57E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLevelEffectStateCtrlByLevel(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			int rewardLevel;
			LuaObject.checkType(l, 2, out rewardLevel);
			CommonUIStateController levelEffectStateCtrlByLevel = raffleUIController.m_luaExportHelper.GetLevelEffectStateCtrlByLevel(rewardLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelEffectStateCtrlByLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602081B RID: 133147 RVA: 0x00AD7648 File Offset: 0x00AD5848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateCostPanelState(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			RafflePool rafflePool;
			LuaObject.checkType<RafflePool>(l, 2, out rafflePool);
			raffleUIController.m_luaExportHelper.UpdateCostPanelState(rafflePool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602081C RID: 133148 RVA: 0x00AD76A4 File Offset: 0x00AD58A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.OnBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602081D RID: 133149 RVA: 0x00AD76F8 File Offset: 0x00AD58F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.OnShowHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602081E RID: 133150 RVA: 0x00AD774C File Offset: 0x00AD594C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRewardPanelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.OnRewardPanelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602081F RID: 133151 RVA: 0x00AD77A0 File Offset: 0x00AD59A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDoRaffleButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.OnDoRaffleButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020820 RID: 133152 RVA: 0x00AD77F4 File Offset: 0x00AD59F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelEffectBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.OnLevelEffectBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020821 RID: 133153 RVA: 0x00AD7848 File Offset: 0x00AD5A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			raffleUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020822 RID: 133154 RVA: 0x00AD78B4 File Offset: 0x00AD5AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020823 RID: 133155 RVA: 0x00AD7908 File Offset: 0x00AD5B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020824 RID: 133156 RVA: 0x00AD795C File Offset: 0x00AD5B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = raffleUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020825 RID: 133157 RVA: 0x00AD7A04 File Offset: 0x00AD5C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			raffleUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020826 RID: 133158 RVA: 0x00AD7A58 File Offset: 0x00AD5C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			raffleUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020827 RID: 133159 RVA: 0x00AD7AC4 File Offset: 0x00AD5CC4
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
				RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				raffleUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RaffleUIController raffleUIController2 = (RaffleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				raffleUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020828 RID: 133160 RVA: 0x00AD7BD4 File Offset: 0x00AD5DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020829 RID: 133161 RVA: 0x00AD7C40 File Offset: 0x00AD5E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602082A RID: 133162 RVA: 0x00AD7CAC File Offset: 0x00AD5EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602082B RID: 133163 RVA: 0x00AD7D18 File Offset: 0x00AD5F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602082C RID: 133164 RVA: 0x00AD7D84 File Offset: 0x00AD5F84
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
				RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				raffleUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RaffleUIController raffleUIController2 = (RaffleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				raffleUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602082D RID: 133165 RVA: 0x00AD7E94 File Offset: 0x00AD6094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			string s = raffleUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602082E RID: 133166 RVA: 0x00AD7EF0 File Offset: 0x00AD60F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				raffleUIController.EventOnShowHelpButtonClick = action;
			}
			else if (num == 1)
			{
				RaffleUIController raffleUIController2 = raffleUIController;
				raffleUIController2.EventOnShowHelpButtonClick = (Action)Delegate.Combine(raffleUIController2.EventOnShowHelpButtonClick, action);
			}
			else if (num == 2)
			{
				RaffleUIController raffleUIController3 = raffleUIController;
				raffleUIController3.EventOnShowHelpButtonClick = (Action)Delegate.Remove(raffleUIController3.EventOnShowHelpButtonClick, action);
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

	// Token: 0x0602082F RID: 133167 RVA: 0x00AD7F98 File Offset: 0x00AD6198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EvetnOnRewardPanelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				raffleUIController.EvetnOnRewardPanelButtonClick = action;
			}
			else if (num == 1)
			{
				RaffleUIController raffleUIController2 = raffleUIController;
				raffleUIController2.EvetnOnRewardPanelButtonClick = (Action)Delegate.Combine(raffleUIController2.EvetnOnRewardPanelButtonClick, action);
			}
			else if (num == 2)
			{
				RaffleUIController raffleUIController3 = raffleUIController;
				raffleUIController3.EvetnOnRewardPanelButtonClick = (Action)Delegate.Remove(raffleUIController3.EvetnOnRewardPanelButtonClick, action);
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

	// Token: 0x06020830 RID: 133168 RVA: 0x00AD8040 File Offset: 0x00AD6240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDoRaffleButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				raffleUIController.EventOnDoRaffleButtonClick = action;
			}
			else if (num == 1)
			{
				RaffleUIController raffleUIController2 = raffleUIController;
				raffleUIController2.EventOnDoRaffleButtonClick = (Action)Delegate.Combine(raffleUIController2.EventOnDoRaffleButtonClick, action);
			}
			else if (num == 2)
			{
				RaffleUIController raffleUIController3 = raffleUIController;
				raffleUIController3.EventOnDoRaffleButtonClick = (Action)Delegate.Remove(raffleUIController3.EventOnDoRaffleButtonClick, action);
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

	// Token: 0x06020831 RID: 133169 RVA: 0x00AD80E8 File Offset: 0x00AD62E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				raffleUIController.EventOnBgButtonClick = action;
			}
			else if (num == 1)
			{
				RaffleUIController raffleUIController2 = raffleUIController;
				raffleUIController2.EventOnBgButtonClick = (Action)Delegate.Combine(raffleUIController2.EventOnBgButtonClick, action);
			}
			else if (num == 2)
			{
				RaffleUIController raffleUIController3 = raffleUIController;
				raffleUIController3.EventOnBgButtonClick = (Action)Delegate.Remove(raffleUIController3.EventOnBgButtonClick, action);
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

	// Token: 0x06020832 RID: 133170 RVA: 0x00AD8190 File Offset: 0x00AD6390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLevelEffectBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				raffleUIController.EventOnLevelEffectBgButtonClick = action;
			}
			else if (num == 1)
			{
				RaffleUIController raffleUIController2 = raffleUIController;
				raffleUIController2.EventOnLevelEffectBgButtonClick = (Action)Delegate.Combine(raffleUIController2.EventOnLevelEffectBgButtonClick, action);
			}
			else if (num == 2)
			{
				RaffleUIController raffleUIController3 = raffleUIController;
				raffleUIController3.EventOnLevelEffectBgButtonClick = (Action)Delegate.Remove(raffleUIController3.EventOnLevelEffectBgButtonClick, action);
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

	// Token: 0x06020833 RID: 133171 RVA: 0x00AD8238 File Offset: 0x00AD6438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.UIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020834 RID: 133172 RVA: 0x00AD828C File Offset: 0x00AD648C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			CommonUIStateController uistateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uistateCtrl);
			raffleUIController.UIStateCtrl = uistateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020835 RID: 133173 RVA: 0x00AD82E4 File Offset: 0x00AD64E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BgButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.BgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020836 RID: 133174 RVA: 0x00AD8338 File Offset: 0x00AD6538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BgButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			raffleUIController.BgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020837 RID: 133175 RVA: 0x00AD8390 File Offset: 0x00AD6590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardPanelButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.RewardPanelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020838 RID: 133176 RVA: 0x00AD83E4 File Offset: 0x00AD65E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RewardPanelButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Button rewardPanelButton;
			LuaObject.checkType<Button>(l, 2, out rewardPanelButton);
			raffleUIController.RewardPanelButton = rewardPanelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020839 RID: 133177 RVA: 0x00AD843C File Offset: 0x00AD663C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShowHelpButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.ShowHelpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602083A RID: 133178 RVA: 0x00AD8490 File Offset: 0x00AD6690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ShowHelpButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Button showHelpButton;
			LuaObject.checkType<Button>(l, 2, out showHelpButton);
			raffleUIController.ShowHelpButton = showHelpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602083B RID: 133179 RVA: 0x00AD84E8 File Offset: 0x00AD66E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DoRaffleButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.DoRaffleButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602083C RID: 133180 RVA: 0x00AD853C File Offset: 0x00AD673C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DoRaffleButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Button doRaffleButton;
			LuaObject.checkType<Button>(l, 2, out doRaffleButton);
			raffleUIController.DoRaffleButton = doRaffleButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602083D RID: 133181 RVA: 0x00AD8594 File Offset: 0x00AD6794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CostPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.CostPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602083E RID: 133182 RVA: 0x00AD85E8 File Offset: 0x00AD67E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CostPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			CommonUIStateController costPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out costPanelStateCtrl);
			raffleUIController.CostPanelStateCtrl = costPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602083F RID: 133183 RVA: 0x00AD8640 File Offset: 0x00AD6840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FreeCountValueText(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.FreeCountValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020840 RID: 133184 RVA: 0x00AD8694 File Offset: 0x00AD6894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FreeCountValueText(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Text freeCountValueText;
			LuaObject.checkType<Text>(l, 2, out freeCountValueText);
			raffleUIController.FreeCountValueText = freeCountValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020841 RID: 133185 RVA: 0x00AD86EC File Offset: 0x00AD68EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CostImage(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.CostImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020842 RID: 133186 RVA: 0x00AD8740 File Offset: 0x00AD6940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CostImage(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Image costImage;
			LuaObject.checkType<Image>(l, 2, out costImage);
			raffleUIController.CostImage = costImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020843 RID: 133187 RVA: 0x00AD8798 File Offset: 0x00AD6998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CostTileText(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.CostTileText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020844 RID: 133188 RVA: 0x00AD87EC File Offset: 0x00AD69EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CostTileText(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Text costTileText;
			LuaObject.checkType<Text>(l, 2, out costTileText);
			raffleUIController.CostTileText = costTileText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020845 RID: 133189 RVA: 0x00AD8844 File Offset: 0x00AD6A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CostValueText(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.CostValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020846 RID: 133190 RVA: 0x00AD8898 File Offset: 0x00AD6A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CostValueText(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Text costValueText;
			LuaObject.checkType<Text>(l, 2, out costValueText);
			raffleUIController.CostValueText = costValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020847 RID: 133191 RVA: 0x00AD88F0 File Offset: 0x00AD6AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HaveMoneyValueText(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.HaveMoneyValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020848 RID: 133192 RVA: 0x00AD8944 File Offset: 0x00AD6B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HaveMoneyValueText(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Text haveMoneyValueText;
			LuaObject.checkType<Text>(l, 2, out haveMoneyValueText);
			raffleUIController.HaveMoneyValueText = haveMoneyValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020849 RID: 133193 RVA: 0x00AD899C File Offset: 0x00AD6B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ThreeDViewRect(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.ThreeDViewRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602084A RID: 133194 RVA: 0x00AD89F0 File Offset: 0x00AD6BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThreeDViewRect(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			RectTransform threeDViewRect;
			LuaObject.checkType<RectTransform>(l, 2, out threeDViewRect);
			raffleUIController.ThreeDViewRect = threeDViewRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602084B RID: 133195 RVA: 0x00AD8A48 File Offset: 0x00AD6C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.LevelEffectStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602084C RID: 133196 RVA: 0x00AD8A9C File Offset: 0x00AD6C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			CommonUIStateController levelEffectStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out levelEffectStateCtrl);
			raffleUIController.LevelEffectStateCtrl = levelEffectStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602084D RID: 133197 RVA: 0x00AD8AF4 File Offset: 0x00AD6CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SpecialLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.SpecialLevelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602084E RID: 133198 RVA: 0x00AD8B48 File Offset: 0x00AD6D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SpecialLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			CommonUIStateController specialLevelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out specialLevelStateCtrl);
			raffleUIController.SpecialLevelStateCtrl = specialLevelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602084F RID: 133199 RVA: 0x00AD8BA0 File Offset: 0x00AD6DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FirstLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.FirstLevelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020850 RID: 133200 RVA: 0x00AD8BF4 File Offset: 0x00AD6DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FirstLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			CommonUIStateController firstLevelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out firstLevelStateCtrl);
			raffleUIController.FirstLevelStateCtrl = firstLevelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020851 RID: 133201 RVA: 0x00AD8C4C File Offset: 0x00AD6E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SecondLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.SecondLevelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020852 RID: 133202 RVA: 0x00AD8CA0 File Offset: 0x00AD6EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SecondLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			CommonUIStateController secondLevelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out secondLevelStateCtrl);
			raffleUIController.SecondLevelStateCtrl = secondLevelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020853 RID: 133203 RVA: 0x00AD8CF8 File Offset: 0x00AD6EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ThirdLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.ThirdLevelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020854 RID: 133204 RVA: 0x00AD8D4C File Offset: 0x00AD6F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThirdLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			CommonUIStateController thirdLevelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out thirdLevelStateCtrl);
			raffleUIController.ThirdLevelStateCtrl = thirdLevelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020855 RID: 133205 RVA: 0x00AD8DA4 File Offset: 0x00AD6FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelEffectBgButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.LevelEffectBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020856 RID: 133206 RVA: 0x00AD8DF8 File Offset: 0x00AD6FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelEffectBgButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			Button levelEffectBgButton;
			LuaObject.checkType<Button>(l, 2, out levelEffectBgButton);
			raffleUIController.LevelEffectBgButton = levelEffectBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020857 RID: 133207 RVA: 0x00AD8E50 File Offset: 0x00AD7050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RaffleUIController raffleUIController = (RaffleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleUIController.m_luaExportHelper.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020858 RID: 133208 RVA: 0x00AD8EA8 File Offset: 0x00AD70A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RaffleUIController");
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.UpdateRafflePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.Get3DViewRectTransfrom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.ShowDrawRewardLevelEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.GetLevelEffectNameByLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.GetLevelEffectStateCtrlByLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.UpdateCostPanelState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.OnBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.OnShowHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.OnRewardPanelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.OnDoRaffleButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.OnLevelEffectBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache18);
		string name = "EventOnShowHelpButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_EventOnShowHelpButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache19, true);
		string name2 = "EvetnOnRewardPanelButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_EvetnOnRewardPanelButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1A, true);
		string name3 = "EventOnDoRaffleButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_EventOnDoRaffleButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1B, true);
		string name4 = "EventOnBgButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_EventOnBgButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1C, true);
		string name5 = "EventOnLevelEffectBgButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_EventOnLevelEffectBgButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1D, true);
		string name6 = "UIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_UIStateCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_UIStateCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache1F, true);
		string name7 = "BgButton";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_BgButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_BgButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache21, true);
		string name8 = "RewardPanelButton";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_RewardPanelButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_RewardPanelButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache23, true);
		string name9 = "ShowHelpButton";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_ShowHelpButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_ShowHelpButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache25, true);
		string name10 = "DoRaffleButton";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_DoRaffleButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_DoRaffleButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache27, true);
		string name11 = "CostPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_CostPanelStateCtrl);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_CostPanelStateCtrl);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache29, true);
		string name12 = "FreeCountValueText";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_FreeCountValueText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_FreeCountValueText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2B, true);
		string name13 = "CostImage";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_CostImage);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_CostImage);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2D, true);
		string name14 = "CostTileText";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_CostTileText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_CostTileText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache2F, true);
		string name15 = "CostValueText";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_CostValueText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_CostValueText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache31, true);
		string name16 = "HaveMoneyValueText";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_HaveMoneyValueText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_HaveMoneyValueText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache33, true);
		string name17 = "ThreeDViewRect";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_ThreeDViewRect);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_ThreeDViewRect);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache35, true);
		string name18 = "LevelEffectStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_LevelEffectStateCtrl);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_LevelEffectStateCtrl);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache37, true);
		string name19 = "SpecialLevelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_SpecialLevelStateCtrl);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_SpecialLevelStateCtrl);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache39, true);
		string name20 = "FirstLevelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_FirstLevelStateCtrl);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_FirstLevelStateCtrl);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3B, true);
		string name21 = "SecondLevelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_SecondLevelStateCtrl);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_SecondLevelStateCtrl);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3D, true);
		string name22 = "ThirdLevelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_ThirdLevelStateCtrl);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_ThirdLevelStateCtrl);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache3F, true);
		string name23 = "LevelEffectBgButton";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_LevelEffectBgButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.set_LevelEffectBgButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache41, true);
		string name24 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleUIController.get_ConfigDataLoader);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_UI_RaffleUIController.<>f__mg$cache42, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(RaffleUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016771 RID: 92017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016772 RID: 92018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016773 RID: 92019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016774 RID: 92020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016775 RID: 92021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016776 RID: 92022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016777 RID: 92023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016778 RID: 92024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016779 RID: 92025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401677A RID: 92026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401677B RID: 92027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401677C RID: 92028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401677D RID: 92029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401677E RID: 92030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401677F RID: 92031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016780 RID: 92032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016781 RID: 92033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016782 RID: 92034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016783 RID: 92035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016784 RID: 92036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016785 RID: 92037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016786 RID: 92038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016787 RID: 92039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016788 RID: 92040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016789 RID: 92041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401678A RID: 92042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401678B RID: 92043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401678C RID: 92044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401678D RID: 92045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401678E RID: 92046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401678F RID: 92047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016790 RID: 92048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016791 RID: 92049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016792 RID: 92050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016793 RID: 92051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016794 RID: 92052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016795 RID: 92053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016796 RID: 92054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016797 RID: 92055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016798 RID: 92056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016799 RID: 92057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401679A RID: 92058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401679B RID: 92059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401679C RID: 92060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401679D RID: 92061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401679E RID: 92062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401679F RID: 92063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040167A0 RID: 92064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040167A1 RID: 92065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040167A2 RID: 92066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040167A3 RID: 92067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040167A4 RID: 92068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040167A5 RID: 92069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040167A6 RID: 92070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040167A7 RID: 92071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040167A8 RID: 92072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040167A9 RID: 92073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040167AA RID: 92074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040167AB RID: 92075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040167AC RID: 92076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040167AD RID: 92077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040167AE RID: 92078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040167AF RID: 92079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040167B0 RID: 92080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040167B1 RID: 92081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040167B2 RID: 92082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040167B3 RID: 92083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;
}
