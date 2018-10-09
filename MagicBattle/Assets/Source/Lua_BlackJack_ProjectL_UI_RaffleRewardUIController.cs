using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001542 RID: 5442
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RaffleRewardUIController : LuaObject
{
	// Token: 0x060207E9 RID: 133097 RVA: 0x00AD5D24 File Offset: 0x00AD3F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRaffleRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			RafflePool rafflePool;
			LuaObject.checkType<RafflePool>(l, 2, out rafflePool);
			bool refreshAll;
			LuaObject.checkType(l, 3, out refreshAll);
			raffleRewardUIController.UpdateRaffleRewardPanel(rafflePool, refreshAll);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207EA RID: 133098 RVA: 0x00AD5D88 File Offset: 0x00AD3F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRaffleRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			raffleRewardUIController.ShowRaffleRewardPanel(isShow, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207EB RID: 133099 RVA: 0x00AD5DEC File Offset: 0x00AD3FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRaffleRewardPanelShow(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			bool b = raffleRewardUIController.IsRaffleRewardPanelShow();
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

	// Token: 0x060207EC RID: 133100 RVA: 0x00AD5E40 File Offset: 0x00AD4040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			raffleRewardUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207ED RID: 133101 RVA: 0x00AD5E94 File Offset: 0x00AD4094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRaffleRewardItemPool(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			raffleRewardUIController.m_luaExportHelper.InitRaffleRewardItemPool();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207EE RID: 133102 RVA: 0x00AD5EE8 File Offset: 0x00AD40E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GainRaffleRewardLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			RafflePool rafflePool;
			LuaObject.checkType<RafflePool>(l, 2, out rafflePool);
			raffleRewardUIController.m_luaExportHelper.GainRaffleRewardLevelInfo(rafflePool);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207EF RID: 133103 RVA: 0x00AD5F44 File Offset: 0x00AD4144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocRewardItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			raffleRewardUIController.m_luaExportHelper.AllocRewardItemCtrl(count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207F0 RID: 133104 RVA: 0x00AD5FA0 File Offset: 0x00AD41A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			raffleRewardUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207F1 RID: 133105 RVA: 0x00AD5FF4 File Offset: 0x00AD41F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			raffleRewardUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207F2 RID: 133106 RVA: 0x00AD6060 File Offset: 0x00AD4260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			raffleRewardUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207F3 RID: 133107 RVA: 0x00AD60B4 File Offset: 0x00AD42B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			raffleRewardUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207F4 RID: 133108 RVA: 0x00AD6108 File Offset: 0x00AD4308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = raffleRewardUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060207F5 RID: 133109 RVA: 0x00AD61B0 File Offset: 0x00AD43B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			raffleRewardUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207F6 RID: 133110 RVA: 0x00AD6204 File Offset: 0x00AD4404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			raffleRewardUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207F7 RID: 133111 RVA: 0x00AD6270 File Offset: 0x00AD4470
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
				RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				raffleRewardUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RaffleRewardUIController raffleRewardUIController2 = (RaffleRewardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				raffleRewardUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060207F8 RID: 133112 RVA: 0x00AD6380 File Offset: 0x00AD4580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleRewardUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207F9 RID: 133113 RVA: 0x00AD63EC File Offset: 0x00AD45EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleRewardUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207FA RID: 133114 RVA: 0x00AD6458 File Offset: 0x00AD4658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleRewardUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207FB RID: 133115 RVA: 0x00AD64C4 File Offset: 0x00AD46C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleRewardUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207FC RID: 133116 RVA: 0x00AD6530 File Offset: 0x00AD4730
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
				RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				raffleRewardUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RaffleRewardUIController raffleRewardUIController2 = (RaffleRewardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				raffleRewardUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060207FD RID: 133117 RVA: 0x00AD6640 File Offset: 0x00AD4840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			string s = raffleRewardUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060207FE RID: 133118 RVA: 0x00AD669C File Offset: 0x00AD489C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raffleRewardLevelInfoDict(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.m_luaExportHelper.m_raffleRewardLevelInfoDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207FF RID: 133119 RVA: 0x00AD66F4 File Offset: 0x00AD48F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raffleRewardLevelInfoDict(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			Dictionary<int, List<RaffleItem>> raffleRewardLevelInfoDict;
			LuaObject.checkType<Dictionary<int, List<RaffleItem>>>(l, 2, out raffleRewardLevelInfoDict);
			raffleRewardUIController.m_luaExportHelper.m_raffleRewardLevelInfoDict = raffleRewardLevelInfoDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020800 RID: 133120 RVA: 0x00AD6750 File Offset: 0x00AD4950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.m_luaExportHelper.m_rewardItemCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020801 RID: 133121 RVA: 0x00AD67A8 File Offset: 0x00AD49A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			List<RaffleRewardItemUIController> rewardItemCtrlList;
			LuaObject.checkType<List<RaffleRewardItemUIController>>(l, 2, out rewardItemCtrlList);
			raffleRewardUIController.m_luaExportHelper.m_rewardItemCtrlList = rewardItemCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020802 RID: 133122 RVA: 0x00AD6804 File Offset: 0x00AD4A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				raffleRewardUIController.EventOnCloseButtonClick = action;
			}
			else if (num == 1)
			{
				RaffleRewardUIController raffleRewardUIController2 = raffleRewardUIController;
				raffleRewardUIController2.EventOnCloseButtonClick = (Action)Delegate.Combine(raffleRewardUIController2.EventOnCloseButtonClick, action);
			}
			else if (num == 2)
			{
				RaffleRewardUIController raffleRewardUIController3 = raffleRewardUIController;
				raffleRewardUIController3.EventOnCloseButtonClick = (Action)Delegate.Remove(raffleRewardUIController3.EventOnCloseButtonClick, action);
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

	// Token: 0x06020803 RID: 133123 RVA: 0x00AD68AC File Offset: 0x00AD4AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShow(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.m_luaExportHelper.m_isShow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020804 RID: 133124 RVA: 0x00AD6904 File Offset: 0x00AD4B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShow(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			raffleRewardUIController.m_luaExportHelper.m_isShow = isShow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020805 RID: 133125 RVA: 0x00AD6960 File Offset: 0x00AD4B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.UIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020806 RID: 133126 RVA: 0x00AD69B4 File Offset: 0x00AD4BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			CommonUIStateController uistateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uistateCtrl);
			raffleRewardUIController.UIStateCtrl = uistateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020807 RID: 133127 RVA: 0x00AD6A0C File Offset: 0x00AD4C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PrefabRoot(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.PrefabRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020808 RID: 133128 RVA: 0x00AD6A60 File Offset: 0x00AD4C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PrefabRoot(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			Transform prefabRoot;
			LuaObject.checkType<Transform>(l, 2, out prefabRoot);
			raffleRewardUIController.PrefabRoot = prefabRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020809 RID: 133129 RVA: 0x00AD6AB8 File Offset: 0x00AD4CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EasyPool(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.EasyPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602080A RID: 133130 RVA: 0x00AD6B0C File Offset: 0x00AD4D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EasyPool(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			EasyObjectPool easyPool;
			LuaObject.checkType<EasyObjectPool>(l, 2, out easyPool);
			raffleRewardUIController.EasyPool = easyPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602080B RID: 133131 RVA: 0x00AD6B64 File Offset: 0x00AD4D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardItemRoot(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.RewardItemRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602080C RID: 133132 RVA: 0x00AD6BB8 File Offset: 0x00AD4DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RewardItemRoot(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			Transform rewardItemRoot;
			LuaObject.checkType<Transform>(l, 2, out rewardItemRoot);
			raffleRewardUIController.RewardItemRoot = rewardItemRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602080D RID: 133133 RVA: 0x00AD6C10 File Offset: 0x00AD4E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CloseButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.CloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602080E RID: 133134 RVA: 0x00AD6C64 File Offset: 0x00AD4E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CloseButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			raffleRewardUIController.CloseButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602080F RID: 133135 RVA: 0x00AD6CBC File Offset: 0x00AD4EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardScrollRect(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.RewardScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020810 RID: 133136 RVA: 0x00AD6D10 File Offset: 0x00AD4F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RewardScrollRect(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			ScrollRect rewardScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out rewardScrollRect);
			raffleRewardUIController.RewardScrollRect = rewardScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020811 RID: 133137 RVA: 0x00AD6D68 File Offset: 0x00AD4F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BgButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardUIController.BgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020812 RID: 133138 RVA: 0x00AD6DBC File Offset: 0x00AD4FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BgButton(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardUIController raffleRewardUIController = (RaffleRewardUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			raffleRewardUIController.BgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020813 RID: 133139 RVA: 0x00AD6E14 File Offset: 0x00AD5014
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RaffleRewardUIController");
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.UpdateRaffleRewardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.ShowRaffleRewardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.IsRaffleRewardPanelShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.InitRaffleRewardItemPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.GainRaffleRewardLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.AllocRewardItemCtrl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache14);
		string name = "m_raffleRewardLevelInfoDict";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_m_raffleRewardLevelInfoDict);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_m_raffleRewardLevelInfoDict);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache16, true);
		string name2 = "m_rewardItemCtrlList";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_m_rewardItemCtrlList);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_m_rewardItemCtrlList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache18, true);
		string name3 = "EventOnCloseButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache19, true);
		string name4 = "m_isShow";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_m_isShow);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_m_isShow);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1B, true);
		string name5 = "UIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_UIStateCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_UIStateCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1D, true);
		string name6 = "PrefabRoot";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_PrefabRoot);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_PrefabRoot);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache1F, true);
		string name7 = "EasyPool";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_EasyPool);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_EasyPool);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache21, true);
		string name8 = "RewardItemRoot";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_RewardItemRoot);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_RewardItemRoot);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache23, true);
		string name9 = "CloseButton";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_CloseButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_CloseButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache25, true);
		string name10 = "RewardScrollRect";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_RewardScrollRect);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_RewardScrollRect);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache27, true);
		string name11 = "BgButton";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.get_BgButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.set_BgButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.<>f__mg$cache29, true);
		LuaObject.createTypeMetatable(l, null, typeof(RaffleRewardUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016747 RID: 91975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016748 RID: 91976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016749 RID: 91977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401674A RID: 91978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401674B RID: 91979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401674C RID: 91980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401674D RID: 91981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401674E RID: 91982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401674F RID: 91983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016750 RID: 91984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016751 RID: 91985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016752 RID: 91986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016753 RID: 91987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016754 RID: 91988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016755 RID: 91989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016756 RID: 91990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016757 RID: 91991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016758 RID: 91992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016759 RID: 91993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401675A RID: 91994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401675B RID: 91995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401675C RID: 91996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401675D RID: 91997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401675E RID: 91998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401675F RID: 91999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016760 RID: 92000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016761 RID: 92001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016762 RID: 92002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016763 RID: 92003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016764 RID: 92004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016765 RID: 92005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016766 RID: 92006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016767 RID: 92007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016768 RID: 92008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016769 RID: 92009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401676A RID: 92010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401676B RID: 92011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401676C RID: 92012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401676D RID: 92013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401676E RID: 92014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401676F RID: 92015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016770 RID: 92016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
