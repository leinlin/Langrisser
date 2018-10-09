using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Script.ProjectL.Runtime.UI.Activity;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001357 RID: 4951
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityUIController : LuaObject
{
	// Token: 0x0601A9CA RID: 109002 RVA: 0x007E9064 File Offset: 0x007E7264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9CB RID: 109003 RVA: 0x007E90B0 File Offset: 0x007E72B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.UpdateViewInActivity();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9CC RID: 109004 RVA: 0x007E90FC File Offset: 0x007E72FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenSpecificActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			activityUIController.OpenSpecificActivity(activityId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9CD RID: 109005 RVA: 0x007E9154 File Offset: 0x007E7354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			bool currentActivity;
			LuaObject.checkType(l, 2, out currentActivity);
			activityUIController.SetCurrentActivity(currentActivity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9CE RID: 109006 RVA: 0x007E91AC File Offset: 0x007E73AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9CF RID: 109007 RVA: 0x007E9200 File Offset: 0x007E7400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTab(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.SetTab();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9D0 RID: 109008 RVA: 0x007E9254 File Offset: 0x007E7454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsActivityInOperationPeriod(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			bool b = activityUIController.m_luaExportHelper.IsActivityInOperationPeriod(activity);
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

	// Token: 0x0601A9D1 RID: 109009 RVA: 0x007E92BC File Offset: 0x007E74BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Announcement currentAnnouncement;
			LuaObject.checkType<Announcement>(l, 2, out currentAnnouncement);
			activityUIController.m_luaExportHelper.SetCurrentAnnouncement(currentAnnouncement);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9D2 RID: 109010 RVA: 0x007E9318 File Offset: 0x007E7518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTabRedPoint(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.SetTabRedPoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9D3 RID: 109011 RVA: 0x007E936C File Offset: 0x007E756C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActivityRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activityRewardPanel;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activityRewardPanel);
			activityUIController.m_luaExportHelper.SetActivityRewardPanel(activityRewardPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9D4 RID: 109012 RVA: 0x007E93C8 File Offset: 0x007E75C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRewardListPanel(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase rewardListPanel;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out rewardListPanel);
			activityUIController.m_luaExportHelper.SetRewardListPanel(rewardListPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9D5 RID: 109013 RVA: 0x007E9424 File Offset: 0x007E7624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRaffleRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase raffleRewardPanel;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out raffleRewardPanel);
			activityUIController.m_luaExportHelper.SetRaffleRewardPanel(raffleRewardPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9D6 RID: 109014 RVA: 0x007E9480 File Offset: 0x007E7680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GainRaffleRewardLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			RafflePool rafflePool;
			LuaObject.checkType<RafflePool>(l, 2, out rafflePool);
			Dictionary<int, List<RaffleItem>> o = activityUIController.m_luaExportHelper.GainRaffleRewardLevelInfo(rafflePool);
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

	// Token: 0x0601A9D7 RID: 109015 RVA: 0x007E94E8 File Offset: 0x007E76E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRedeemContent(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string redeemContent = activityUIController.m_luaExportHelper.GetRedeemContent();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, redeemContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9D8 RID: 109016 RVA: 0x007E9544 File Offset: 0x007E7744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnnouncementComparer(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Announcement announcementA;
			LuaObject.checkType<Announcement>(l, 2, out announcementA);
			Announcement announcementB;
			LuaObject.checkType<Announcement>(l, 3, out announcementB);
			int i = activityUIController.m_luaExportHelper.AnnouncementComparer(announcementA, announcementB);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9D9 RID: 109017 RVA: 0x007E95B8 File Offset: 0x007E77B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivityComparer(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase activityA;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activityA);
			OperationalActivityBase activityB;
			LuaObject.checkType<OperationalActivityBase>(l, 3, out activityB);
			int i = activityUIController.m_luaExportHelper.ActivityComparer(activityA, activityB);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9DA RID: 109018 RVA: 0x007E962C File Offset: 0x007E782C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGainRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			ulong activityInstanceID;
			LuaObject.checkType(l, 2, out activityInstanceID);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			ActivityRewardUIController ctrl;
			LuaObject.checkType<ActivityRewardUIController>(l, 4, out ctrl);
			activityUIController.m_luaExportHelper.OnGainRewardButtonClick(activityInstanceID, rewardIndex, ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9DB RID: 109019 RVA: 0x007E96A4 File Offset: 0x007E78A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExchangeItemGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			ulong activityInstanceID;
			LuaObject.checkType(l, 2, out activityInstanceID);
			int itemGroupIndex;
			LuaObject.checkType(l, 3, out itemGroupIndex);
			ActivityRewardUIController ctrl;
			LuaObject.checkType<ActivityRewardUIController>(l, 4, out ctrl);
			activityUIController.m_luaExportHelper.OnExchangeItemGroupButtonClick(activityInstanceID, itemGroupIndex, ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9DC RID: 109020 RVA: 0x007E971C File Offset: 0x007E791C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExchangeItemGroupCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.OnExchangeItemGroupCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9DD RID: 109021 RVA: 0x007E9770 File Offset: 0x007E7970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9DE RID: 109022 RVA: 0x007E97C4 File Offset: 0x007E79C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddActivityButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.OnAddActivityButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9DF RID: 109023 RVA: 0x007E9818 File Offset: 0x007E7A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.OnGotoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9E0 RID: 109024 RVA: 0x007E986C File Offset: 0x007E7A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.OnGetRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9E1 RID: 109025 RVA: 0x007E98C0 File Offset: 0x007E7AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			activityUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9E2 RID: 109026 RVA: 0x007E992C File Offset: 0x007E7B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9E3 RID: 109027 RVA: 0x007E9980 File Offset: 0x007E7B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9E4 RID: 109028 RVA: 0x007E99D4 File Offset: 0x007E7BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = activityUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601A9E5 RID: 109029 RVA: 0x007E9A7C File Offset: 0x007E7C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9E6 RID: 109030 RVA: 0x007E9AD0 File Offset: 0x007E7CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			activityUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9E7 RID: 109031 RVA: 0x007E9B3C File Offset: 0x007E7D3C
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
				ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				activityUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ActivityUIController activityUIController2 = (ActivityUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				activityUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601A9E8 RID: 109032 RVA: 0x007E9C4C File Offset: 0x007E7E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9E9 RID: 109033 RVA: 0x007E9CB8 File Offset: 0x007E7EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9EA RID: 109034 RVA: 0x007E9D24 File Offset: 0x007E7F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9EB RID: 109035 RVA: 0x007E9D90 File Offset: 0x007E7F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9EC RID: 109036 RVA: 0x007E9DFC File Offset: 0x007E7FFC
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
				ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				activityUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ActivityUIController activityUIController2 = (ActivityUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				activityUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601A9ED RID: 109037 RVA: 0x007E9F0C File Offset: 0x007E810C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string s = activityUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601A9EE RID: 109038 RVA: 0x007E9F68 File Offset: 0x007E8168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9EF RID: 109039 RVA: 0x007E9FBC File Offset: 0x007E81BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F0 RID: 109040 RVA: 0x007EA010 File Offset: 0x007E8210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGainReward(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<Goods> arg3;
			LuaObject.checkType<List<Goods>>(l, 4, out arg3);
			activityUIController.m_luaExportHelper.__callDele_EventOnGainReward(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F1 RID: 109041 RVA: 0x007EA088 File Offset: 0x007E8288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGainReward(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<Goods> arg3;
			LuaObject.checkType<List<Goods>>(l, 4, out arg3);
			activityUIController.m_luaExportHelper.__clearDele_EventOnGainReward(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F2 RID: 109042 RVA: 0x007EA100 File Offset: 0x007E8300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExchangeItemGroup(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<Goods> arg3;
			LuaObject.checkType<List<Goods>>(l, 4, out arg3);
			activityUIController.m_luaExportHelper.__callDele_EventOnExchangeItemGroup(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F3 RID: 109043 RVA: 0x007EA178 File Offset: 0x007E8378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExchangeItemGroup(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<Goods> arg3;
			LuaObject.checkType<List<Goods>>(l, 4, out arg3);
			activityUIController.m_luaExportHelper.__clearDele_EventOnExchangeItemGroup(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F4 RID: 109044 RVA: 0x007EA1F0 File Offset: 0x007E83F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			activityUIController.m_luaExportHelper.__callDele_EventOnAddActivity(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F5 RID: 109045 RVA: 0x007EA24C File Offset: 0x007E844C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			activityUIController.m_luaExportHelper.__clearDele_EventOnAddActivity(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F6 RID: 109046 RVA: 0x007EA2A8 File Offset: 0x007E84A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase obj;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out obj);
			activityUIController.m_luaExportHelper.__callDele_EventOnGoToButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F7 RID: 109047 RVA: 0x007EA304 File Offset: 0x007E8504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase obj;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out obj);
			activityUIController.m_luaExportHelper.__clearDele_EventOnGoToButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F8 RID: 109048 RVA: 0x007EA360 File Offset: 0x007E8560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase obj;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out obj);
			activityUIController.m_luaExportHelper.__callDele_EventOnGetRewardButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9F9 RID: 109049 RVA: 0x007EA3BC File Offset: 0x007E85BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase obj;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out obj);
			activityUIController.m_luaExportHelper.__clearDele_EventOnGetRewardButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9FA RID: 109050 RVA: 0x007EA418 File Offset: 0x007E8618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.__callDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9FB RID: 109051 RVA: 0x007EA46C File Offset: 0x007E866C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			activityUIController.m_luaExportHelper.__clearDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A9FC RID: 109052 RVA: 0x007EA4C0 File Offset: 0x007E86C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					activityUIController.EventOnReturn -= value;
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

	// Token: 0x0601A9FD RID: 109053 RVA: 0x007EA540 File Offset: 0x007E8740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGainReward(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Action<ulong, int, List<Goods>> value;
			int num = LuaObject.checkDelegate<Action<ulong, int, List<Goods>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityUIController.EventOnGainReward += value;
				}
				else if (num == 2)
				{
					activityUIController.EventOnGainReward -= value;
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

	// Token: 0x0601A9FE RID: 109054 RVA: 0x007EA5C0 File Offset: 0x007E87C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExchangeItemGroup(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Action<ulong, int, List<Goods>> value;
			int num = LuaObject.checkDelegate<Action<ulong, int, List<Goods>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityUIController.EventOnExchangeItemGroup += value;
				}
				else if (num == 2)
				{
					activityUIController.EventOnExchangeItemGroup -= value;
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

	// Token: 0x0601A9FF RID: 109055 RVA: 0x007EA640 File Offset: 0x007E8840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityUIController.EventOnAddActivity += value;
				}
				else if (num == 2)
				{
					activityUIController.EventOnAddActivity -= value;
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

	// Token: 0x0601AA00 RID: 109056 RVA: 0x007EA6C0 File Offset: 0x007E88C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Action<OperationalActivityBase> value;
			int num = LuaObject.checkDelegate<Action<OperationalActivityBase>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityUIController.EventOnGoToButtonClick += value;
				}
				else if (num == 2)
				{
					activityUIController.EventOnGoToButtonClick -= value;
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

	// Token: 0x0601AA01 RID: 109057 RVA: 0x007EA740 File Offset: 0x007E8940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Action<OperationalActivityBase> value;
			int num = LuaObject.checkDelegate<Action<OperationalActivityBase>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityUIController.EventOnGetRewardButtonClick += value;
				}
				else if (num == 2)
				{
					activityUIController.EventOnGetRewardButtonClick -= value;
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

	// Token: 0x0601AA02 RID: 109058 RVA: 0x007EA7C0 File Offset: 0x007E89C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityUIController.EventOnCrystalNotEnough += value;
				}
				else if (num == 2)
				{
					activityUIController.EventOnCrystalNotEnough -= value;
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

	// Token: 0x0601AA03 RID: 109059 RVA: 0x007EA840 File Offset: 0x007E8A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA04 RID: 109060 RVA: 0x007EA898 File Offset: 0x007E8A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			CommonUIStateController activityStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out activityStateCtrl);
			activityUIController.m_luaExportHelper.m_activityStateCtrl = activityStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA05 RID: 109061 RVA: 0x007EA8F4 File Offset: 0x007E8AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggleItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_toggleItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA06 RID: 109062 RVA: 0x007EA94C File Offset: 0x007E8B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject toggleItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out toggleItemPrefab);
			activityUIController.m_luaExportHelper.m_toggleItemPrefab = toggleItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA07 RID: 109063 RVA: 0x007EA9A8 File Offset: 0x007E8BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityNameText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA08 RID: 109064 RVA: 0x007EAA00 File Offset: 0x007E8C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityNameText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Text activityNameText;
			LuaObject.checkType<Text>(l, 2, out activityNameText);
			activityUIController.m_luaExportHelper.m_activityNameText = activityNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA09 RID: 109065 RVA: 0x007EAA5C File Offset: 0x007E8C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityNameDarkText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityNameDarkText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA0A RID: 109066 RVA: 0x007EAAB4 File Offset: 0x007E8CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityNameDarkText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Text activityNameDarkText;
			LuaObject.checkType<Text>(l, 2, out activityNameDarkText);
			activityUIController.m_luaExportHelper.m_activityNameDarkText = activityNameDarkText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA0B RID: 109067 RVA: 0x007EAB10 File Offset: 0x007E8D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tabIcon(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_tabIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA0C RID: 109068 RVA: 0x007EAB68 File Offset: 0x007E8D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tabIcon(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Image tabIcon;
			LuaObject.checkType<Image>(l, 2, out tabIcon);
			activityUIController.m_luaExportHelper.m_tabIcon = tabIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA0D RID: 109069 RVA: 0x007EABC4 File Offset: 0x007E8DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tabNewLogo(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_tabNewLogo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA0E RID: 109070 RVA: 0x007EAC1C File Offset: 0x007E8E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tabNewLogo(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject tabNewLogo;
			LuaObject.checkType<GameObject>(l, 2, out tabNewLogo);
			activityUIController.m_luaExportHelper.m_tabNewLogo = tabNewLogo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA0F RID: 109071 RVA: 0x007EAC78 File Offset: 0x007E8E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tabRedPoint(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_tabRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA10 RID: 109072 RVA: 0x007EACD0 File Offset: 0x007E8ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tabRedPoint(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject tabRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out tabRedPoint);
			activityUIController.m_luaExportHelper.m_tabRedPoint = tabRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA11 RID: 109073 RVA: 0x007EAD2C File Offset: 0x007E8F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_leftSidebarScrollView(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_leftSidebarScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA12 RID: 109074 RVA: 0x007EAD84 File Offset: 0x007E8F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_leftSidebarScrollView(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject leftSidebarScrollView;
			LuaObject.checkType<GameObject>(l, 2, out leftSidebarScrollView);
			activityUIController.m_luaExportHelper.m_leftSidebarScrollView = leftSidebarScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA13 RID: 109075 RVA: 0x007EADE0 File Offset: 0x007E8FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_leftSidebarScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_leftSidebarScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA14 RID: 109076 RVA: 0x007EAE38 File Offset: 0x007E9038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_leftSidebarScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject leftSidebarScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out leftSidebarScrollViewContent);
			activityUIController.m_luaExportHelper.m_leftSidebarScrollViewContent = leftSidebarScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA15 RID: 109077 RVA: 0x007EAE94 File Offset: 0x007E9094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announcementPanelObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_announcementPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA16 RID: 109078 RVA: 0x007EAEEC File Offset: 0x007E90EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announcementPanelObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject announcementPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out announcementPanelObj);
			activityUIController.m_luaExportHelper.m_announcementPanelObj = announcementPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA17 RID: 109079 RVA: 0x007EAF48 File Offset: 0x007E9148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announcementContentText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_announcementContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA18 RID: 109080 RVA: 0x007EAFA0 File Offset: 0x007E91A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announcementContentText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Text announcementContentText;
			LuaObject.checkType<Text>(l, 2, out announcementContentText);
			activityUIController.m_luaExportHelper.m_announcementContentText = announcementContentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA19 RID: 109081 RVA: 0x007EAFFC File Offset: 0x007E91FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announcementScrollView(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_announcementScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA1A RID: 109082 RVA: 0x007EB054 File Offset: 0x007E9254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announcementScrollView(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject announcementScrollView;
			LuaObject.checkType<GameObject>(l, 2, out announcementScrollView);
			activityUIController.m_luaExportHelper.m_announcementScrollView = announcementScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA1B RID: 109083 RVA: 0x007EB0B0 File Offset: 0x007E92B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityPanelObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA1C RID: 109084 RVA: 0x007EB108 File Offset: 0x007E9308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityPanelObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject activityPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out activityPanelObj);
			activityUIController.m_luaExportHelper.m_activityPanelObj = activityPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA1D RID: 109085 RVA: 0x007EB164 File Offset: 0x007E9364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityScrollView(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA1E RID: 109086 RVA: 0x007EB1BC File Offset: 0x007E93BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityScrollView(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject activityScrollView;
			LuaObject.checkType<GameObject>(l, 2, out activityScrollView);
			activityUIController.m_luaExportHelper.m_activityScrollView = activityScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA1F RID: 109087 RVA: 0x007EB218 File Offset: 0x007E9418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityTimeText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA20 RID: 109088 RVA: 0x007EB270 File Offset: 0x007E9470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityTimeText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Text activityTimeText;
			LuaObject.checkType<Text>(l, 2, out activityTimeText);
			activityUIController.m_luaExportHelper.m_activityTimeText = activityTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA21 RID: 109089 RVA: 0x007EB2CC File Offset: 0x007E94CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityContentText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA22 RID: 109090 RVA: 0x007EB324 File Offset: 0x007E9524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityContentText(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Text activityContentText;
			LuaObject.checkType<Text>(l, 2, out activityContentText);
			activityUIController.m_luaExportHelper.m_activityContentText = activityContentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA23 RID: 109091 RVA: 0x007EB380 File Offset: 0x007E9580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA24 RID: 109092 RVA: 0x007EB3D8 File Offset: 0x007E95D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			CommonUIStateController activityPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out activityPanelStateCtrl);
			activityUIController.m_luaExportHelper.m_activityPanelStateCtrl = activityPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA25 RID: 109093 RVA: 0x007EB434 File Offset: 0x007E9634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityBillboardImage(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityBillboardImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA26 RID: 109094 RVA: 0x007EB48C File Offset: 0x007E968C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityBillboardImage(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Image activityBillboardImage;
			LuaObject.checkType<Image>(l, 2, out activityBillboardImage);
			activityUIController.m_luaExportHelper.m_activityBillboardImage = activityBillboardImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA27 RID: 109095 RVA: 0x007EB4E8 File Offset: 0x007E96E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityRewardTitleObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityRewardTitleObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA28 RID: 109096 RVA: 0x007EB540 File Offset: 0x007E9740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityRewardTitleObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject activityRewardTitleObj;
			LuaObject.checkType<GameObject>(l, 2, out activityRewardTitleObj);
			activityUIController.m_luaExportHelper.m_activityRewardTitleObj = activityRewardTitleObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA29 RID: 109097 RVA: 0x007EB59C File Offset: 0x007E979C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityRewardList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityRewardList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA2A RID: 109098 RVA: 0x007EB5F4 File Offset: 0x007E97F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityRewardList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject activityRewardList;
			LuaObject.checkType<GameObject>(l, 2, out activityRewardList);
			activityUIController.m_luaExportHelper.m_activityRewardList = activityRewardList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA2B RID: 109099 RVA: 0x007EB650 File Offset: 0x007E9850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityRewardPrefab(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityRewardPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA2C RID: 109100 RVA: 0x007EB6A8 File Offset: 0x007E98A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityRewardPrefab(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject activityRewardPrefab;
			LuaObject.checkType<GameObject>(l, 2, out activityRewardPrefab);
			activityUIController.m_luaExportHelper.m_activityRewardPrefab = activityRewardPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA2D RID: 109101 RVA: 0x007EB704 File Offset: 0x007E9904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_goButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA2E RID: 109102 RVA: 0x007EB75C File Offset: 0x007E995C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Button goButton;
			LuaObject.checkType<Button>(l, 2, out goButton);
			activityUIController.m_luaExportHelper.m_goButton = goButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA2F RID: 109103 RVA: 0x007EB7B8 File Offset: 0x007E99B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getRewardButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_getRewardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA30 RID: 109104 RVA: 0x007EB810 File Offset: 0x007E9A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getRewardButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Button getRewardButton;
			LuaObject.checkType<Button>(l, 2, out getRewardButton);
			activityUIController.m_luaExportHelper.m_getRewardButton = getRewardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA31 RID: 109105 RVA: 0x007EB86C File Offset: 0x007E9A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ReceivedRewardObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_ReceivedRewardObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA32 RID: 109106 RVA: 0x007EB8C4 File Offset: 0x007E9AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ReceivedRewardObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject receivedRewardObj;
			LuaObject.checkType<GameObject>(l, 2, out receivedRewardObj);
			activityUIController.m_luaExportHelper.m_ReceivedRewardObj = receivedRewardObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA33 RID: 109107 RVA: 0x007EB920 File Offset: 0x007E9B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_BigImage(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_BigImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA34 RID: 109108 RVA: 0x007EB978 File Offset: 0x007E9B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_BigImage(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Image bigImage;
			LuaObject.checkType<Image>(l, 2, out bigImage);
			activityUIController.m_luaExportHelper.m_BigImage = bigImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA35 RID: 109109 RVA: 0x007EB9D4 File Offset: 0x007E9BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA36 RID: 109110 RVA: 0x007EBA2C File Offset: 0x007E9C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			activityUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA37 RID: 109111 RVA: 0x007EBA88 File Offset: 0x007E9C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityGMObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityGMObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA38 RID: 109112 RVA: 0x007EBAE0 File Offset: 0x007E9CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityGMObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			GameObject activityGMObj;
			LuaObject.checkType<GameObject>(l, 2, out activityGMObj);
			activityUIController.m_luaExportHelper.m_activityGMObj = activityGMObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA39 RID: 109113 RVA: 0x007EBB3C File Offset: 0x007E9D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityInputField(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_activityInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA3A RID: 109114 RVA: 0x007EBB94 File Offset: 0x007E9D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityInputField(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			InputField activityInputField;
			LuaObject.checkType<InputField>(l, 2, out activityInputField);
			activityUIController.m_luaExportHelper.m_activityInputField = activityInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA3B RID: 109115 RVA: 0x007EBBF0 File Offset: 0x007E9DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addActivityButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_addActivityButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA3C RID: 109116 RVA: 0x007EBC48 File Offset: 0x007E9E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addActivityButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			Button addActivityButton;
			LuaObject.checkType<Button>(l, 2, out addActivityButton);
			activityUIController.m_luaExportHelper.m_addActivityButton = addActivityButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA3D RID: 109117 RVA: 0x007EBCA4 File Offset: 0x007E9EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityIsOn(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_activityIsOn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA3E RID: 109118 RVA: 0x007EBCF8 File Offset: 0x007E9EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityIsOn(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			bool activityIsOn;
			LuaObject.checkType(l, 2, out activityIsOn);
			activityUIController.m_activityIsOn = activityIsOn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA3F RID: 109119 RVA: 0x007EBD50 File Offset: 0x007E9F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_announceCount(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.announceCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA40 RID: 109120 RVA: 0x007EBDA8 File Offset: 0x007E9FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_announceCount(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			int announceCount;
			LuaObject.checkType(l, 2, out announceCount);
			activityUIController.m_luaExportHelper.announceCount = announceCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA41 RID: 109121 RVA: 0x007EBE04 File Offset: 0x007EA004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_currentActivity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA42 RID: 109122 RVA: 0x007EBE5C File Offset: 0x007EA05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentActivity(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			OperationalActivityBase currentActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out currentActivity);
			activityUIController.m_luaExportHelper.m_currentActivity = currentActivity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA43 RID: 109123 RVA: 0x007EBEB8 File Offset: 0x007EA0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tabList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_tabList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA44 RID: 109124 RVA: 0x007EBF10 File Offset: 0x007EA110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tabList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			List<GameObject> tabList;
			LuaObject.checkType<List<GameObject>>(l, 2, out tabList);
			activityUIController.m_luaExportHelper.m_tabList = tabList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA45 RID: 109125 RVA: 0x007EBF6C File Offset: 0x007EA16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_instanceIDList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_instanceIDList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA46 RID: 109126 RVA: 0x007EBFC4 File Offset: 0x007EA1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_instanceIDList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			List<ulong> instanceIDList;
			LuaObject.checkType<List<ulong>>(l, 2, out instanceIDList);
			activityUIController.m_luaExportHelper.m_instanceIDList = instanceIDList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA47 RID: 109127 RVA: 0x007EC020 File Offset: 0x007EA220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_readAnnounceActivityList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_readAnnounceActivityList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA48 RID: 109128 RVA: 0x007EC078 File Offset: 0x007EA278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_readAnnounceActivityList(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			List<ulong> readAnnounceActivityList;
			LuaObject.checkType<List<ulong>>(l, 2, out readAnnounceActivityList);
			activityUIController.m_luaExportHelper.m_readAnnounceActivityList = readAnnounceActivityList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA49 RID: 109129 RVA: 0x007EC0D4 File Offset: 0x007EA2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA4A RID: 109130 RVA: 0x007EC12C File Offset: 0x007EA32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			activityUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA4B RID: 109131 RVA: 0x007EC188 File Offset: 0x007EA388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA4C RID: 109132 RVA: 0x007EC1E0 File Offset: 0x007EA3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ActivityUIController activityUIController = (ActivityUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			activityUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA4D RID: 109133 RVA: 0x007EC23C File Offset: 0x007EA43C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityUIController");
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.UpdateViewInActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OpenSpecificActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.SetCurrentActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.SetTab);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.IsActivityInOperationPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.SetCurrentAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.SetTabRedPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.SetActivityRewardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.SetRewardListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.SetRaffleRewardPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.GainRaffleRewardLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.GetRedeemContent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.AnnouncementComparer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.ActivityComparer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OnGainRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OnExchangeItemGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OnExchangeItemGroupCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OnAddActivityButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.OnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callDele_EventOnGainReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__clearDele_EventOnGainReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callDele_EventOnExchangeItemGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__clearDele_EventOnExchangeItemGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callDele_EventOnAddActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__clearDele_EventOnAddActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callDele_EventOnGoToButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__clearDele_EventOnGoToButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callDele_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__clearDele_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__callDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.__clearDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache31);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache32, true);
		string name2 = "EventOnGainReward";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_EventOnGainReward);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache33, true);
		string name3 = "EventOnExchangeItemGroup";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_EventOnExchangeItemGroup);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache34, true);
		string name4 = "EventOnAddActivity";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_EventOnAddActivity);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache35, true);
		string name5 = "EventOnGoToButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_EventOnGoToButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache36, true);
		string name6 = "EventOnGetRewardButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache37, true);
		string name7 = "EventOnCrystalNotEnough";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache38, true);
		string name8 = "m_activityStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityStateCtrl);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityStateCtrl);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3A, true);
		string name9 = "m_toggleItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_toggleItemPrefab);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_toggleItemPrefab);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3C, true);
		string name10 = "m_activityNameText";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityNameText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityNameText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3E, true);
		string name11 = "m_activityNameDarkText";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityNameDarkText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityNameDarkText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache40, true);
		string name12 = "m_tabIcon";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_tabIcon);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_tabIcon);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache42, true);
		string name13 = "m_tabNewLogo";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_tabNewLogo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_tabNewLogo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache44, true);
		string name14 = "m_tabRedPoint";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_tabRedPoint);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_tabRedPoint);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache46, true);
		string name15 = "m_leftSidebarScrollView";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_leftSidebarScrollView);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_leftSidebarScrollView);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache48, true);
		string name16 = "m_leftSidebarScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_leftSidebarScrollViewContent);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_leftSidebarScrollViewContent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4A, true);
		string name17 = "m_announcementPanelObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_announcementPanelObj);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_announcementPanelObj);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4C, true);
		string name18 = "m_announcementContentText";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_announcementContentText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_announcementContentText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4E, true);
		string name19 = "m_announcementScrollView";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_announcementScrollView);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_announcementScrollView);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache50, true);
		string name20 = "m_activityPanelObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityPanelObj);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityPanelObj);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache52, true);
		string name21 = "m_activityScrollView";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityScrollView);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityScrollView);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache54, true);
		string name22 = "m_activityTimeText";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityTimeText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityTimeText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache56, true);
		string name23 = "m_activityContentText";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityContentText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityContentText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache58, true);
		string name24 = "m_activityPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityPanelStateCtrl);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityPanelStateCtrl);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5A, true);
		string name25 = "m_activityBillboardImage";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityBillboardImage);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityBillboardImage);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5C, true);
		string name26 = "m_activityRewardTitleObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityRewardTitleObj);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityRewardTitleObj);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5E, true);
		string name27 = "m_activityRewardList";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityRewardList);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityRewardList);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache60, true);
		string name28 = "m_activityRewardPrefab";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityRewardPrefab);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityRewardPrefab);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache62, true);
		string name29 = "m_goButton";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_goButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_goButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache64, true);
		string name30 = "m_getRewardButton";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_getRewardButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_getRewardButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache66, true);
		string name31 = "m_ReceivedRewardObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_ReceivedRewardObj);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_ReceivedRewardObj);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache68, true);
		string name32 = "m_BigImage";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_BigImage);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_BigImage);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6A, true);
		string name33 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_returnButton);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6C, true);
		string name34 = "m_activityGMObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityGMObj);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityGMObj);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6E, true);
		string name35 = "m_activityInputField";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityInputField);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityInputField);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache70, true);
		string name36 = "m_addActivityButton";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_addActivityButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_addActivityButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache72, true);
		string name37 = "m_activityIsOn";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_activityIsOn);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_activityIsOn);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache74, true);
		string name38 = "announceCount";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_announceCount);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_announceCount);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache76, true);
		string name39 = "m_currentActivity";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_currentActivity);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_currentActivity);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache78, true);
		string name40 = "m_tabList";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_tabList);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_tabList);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7A, true);
		string name41 = "m_instanceIDList";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_instanceIDList);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_instanceIDList);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7C, true);
		string name42 = "m_readAnnounceActivityList";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_readAnnounceActivityList);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_readAnnounceActivityList);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7E, true);
		string name43 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_playerContext);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache80, true);
		string name44 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.get_m_configDataLoader);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_ActivityUIController.<>f__mg$cache82, true);
		LuaObject.createTypeMetatable(l, null, typeof(ActivityUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010CFE RID: 68862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010CFF RID: 68863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010D00 RID: 68864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010D01 RID: 68865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010D02 RID: 68866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010D03 RID: 68867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010D04 RID: 68868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010D05 RID: 68869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010D06 RID: 68870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010D07 RID: 68871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010D08 RID: 68872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010D09 RID: 68873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010D0A RID: 68874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010D0B RID: 68875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010D0C RID: 68876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010D0D RID: 68877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010D0E RID: 68878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010D0F RID: 68879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010D10 RID: 68880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010D11 RID: 68881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010D12 RID: 68882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010D13 RID: 68883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010D14 RID: 68884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010D15 RID: 68885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010D16 RID: 68886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010D17 RID: 68887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010D18 RID: 68888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010D19 RID: 68889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010D1A RID: 68890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010D1B RID: 68891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010D1C RID: 68892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010D1D RID: 68893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010D1E RID: 68894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010D1F RID: 68895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010D20 RID: 68896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010D21 RID: 68897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010D22 RID: 68898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010D23 RID: 68899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010D24 RID: 68900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010D25 RID: 68901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010D26 RID: 68902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010D27 RID: 68903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010D28 RID: 68904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010D29 RID: 68905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010D2A RID: 68906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010D2B RID: 68907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010D2C RID: 68908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010D2D RID: 68909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010D2E RID: 68910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010D2F RID: 68911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010D30 RID: 68912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010D31 RID: 68913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010D32 RID: 68914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010D33 RID: 68915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010D34 RID: 68916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010D35 RID: 68917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010D36 RID: 68918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010D37 RID: 68919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04010D38 RID: 68920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04010D39 RID: 68921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04010D3A RID: 68922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04010D3B RID: 68923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04010D3C RID: 68924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04010D3D RID: 68925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04010D3E RID: 68926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04010D3F RID: 68927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04010D40 RID: 68928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04010D41 RID: 68929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04010D42 RID: 68930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04010D43 RID: 68931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04010D44 RID: 68932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04010D45 RID: 68933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04010D46 RID: 68934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04010D47 RID: 68935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04010D48 RID: 68936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04010D49 RID: 68937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04010D4A RID: 68938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04010D4B RID: 68939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04010D4C RID: 68940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04010D4D RID: 68941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04010D4E RID: 68942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04010D4F RID: 68943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04010D50 RID: 68944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04010D51 RID: 68945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04010D52 RID: 68946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04010D53 RID: 68947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04010D54 RID: 68948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04010D55 RID: 68949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04010D56 RID: 68950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04010D57 RID: 68951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04010D58 RID: 68952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04010D59 RID: 68953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04010D5A RID: 68954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04010D5B RID: 68955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04010D5C RID: 68956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04010D5D RID: 68957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04010D5E RID: 68958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04010D5F RID: 68959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04010D60 RID: 68960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04010D61 RID: 68961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04010D62 RID: 68962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04010D63 RID: 68963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04010D64 RID: 68964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04010D65 RID: 68965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04010D66 RID: 68966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04010D67 RID: 68967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04010D68 RID: 68968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04010D69 RID: 68969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04010D6A RID: 68970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04010D6B RID: 68971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04010D6C RID: 68972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04010D6D RID: 68973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04010D6E RID: 68974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04010D6F RID: 68975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04010D70 RID: 68976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04010D71 RID: 68977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04010D72 RID: 68978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04010D73 RID: 68979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04010D74 RID: 68980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04010D75 RID: 68981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04010D76 RID: 68982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04010D77 RID: 68983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04010D78 RID: 68984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04010D79 RID: 68985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04010D7A RID: 68986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04010D7B RID: 68987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04010D7C RID: 68988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04010D7D RID: 68989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04010D7E RID: 68990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04010D7F RID: 68991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04010D80 RID: 68992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;
}
