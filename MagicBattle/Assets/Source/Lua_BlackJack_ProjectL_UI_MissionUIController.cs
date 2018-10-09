using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

// Token: 0x02001511 RID: 5393
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MissionUIController : LuaObject
{
	// Token: 0x0601FF44 RID: 130884 RVA: 0x00A90CC8 File Offset: 0x00A8EEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMissionListByMissionColumnType(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.ShowMissionListByMissionColumnType();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF45 RID: 130885 RVA: 0x00A90D14 File Offset: 0x00A8EF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF46 RID: 130886 RVA: 0x00A90D68 File Offset: 0x00A8EF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowToggleTagNumText(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			bool day;
			LuaObject.checkType(l, 2, out day);
			bool challenge;
			LuaObject.checkType(l, 3, out challenge);
			bool achievement;
			LuaObject.checkType(l, 4, out achievement);
			missionUIController.m_luaExportHelper.ShowToggleTagNumText(day, challenge, achievement);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF47 RID: 130887 RVA: 0x00A90DE0 File Offset: 0x00A8EFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMissionItem(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			bool isMissionFinished;
			LuaObject.checkType(l, 3, out isMissionFinished);
			bool isMissionCompleted;
			LuaObject.checkType(l, 4, out isMissionCompleted);
			GameObject childGo;
			LuaObject.checkType<GameObject>(l, 5, out childGo);
			missionUIController.m_luaExportHelper.CreateMissionItem(mission, isMissionFinished, isMissionCompleted, childGo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF48 RID: 130888 RVA: 0x00A90E64 File Offset: 0x00A8F064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareMissionBySortId(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Mission m;
			LuaObject.checkType<Mission>(l, 2, out m);
			Mission m2;
			LuaObject.checkType<Mission>(l, 3, out m2);
			int i = missionUIController.m_luaExportHelper.CompareMissionBySortId(m, m2);
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

	// Token: 0x0601FF49 RID: 130889 RVA: 0x00A90ED8 File Offset: 0x00A8F0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMissionColumnRedTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionUIController.m_luaExportHelper.AddMissionColumnRedTagNum(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF4A RID: 130890 RVA: 0x00A90F34 File Offset: 0x00A8F134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetRedTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.ResetRedTagNum();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF4B RID: 130891 RVA: 0x00A90F88 File Offset: 0x00A8F188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			missionUIController.m_luaExportHelper.OnGetRewardButtonClick(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF4C RID: 130892 RVA: 0x00A90FE4 File Offset: 0x00A8F1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRewards(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			missionUIController.m_luaExportHelper.ShowRewards(rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF4D RID: 130893 RVA: 0x00A91040 File Offset: 0x00A8F240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRewardGoodsUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.GetRewardGoodsUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF4E RID: 130894 RVA: 0x00A91094 File Offset: 0x00A8F294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGotoLayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GetPathData pathInfo;
			LuaObject.checkType<GetPathData>(l, 2, out pathInfo);
			missionUIController.m_luaExportHelper.OnGotoLayerButtonClick(pathInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF4F RID: 130895 RVA: 0x00A910F0 File Offset: 0x00A8F2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF50 RID: 130896 RVA: 0x00A91144 File Offset: 0x00A8F344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTipsBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.OnTipsBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF51 RID: 130897 RVA: 0x00A91198 File Offset: 0x00A8F398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTipsConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.OnTipsConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF52 RID: 130898 RVA: 0x00A911EC File Offset: 0x00A8F3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF53 RID: 130899 RVA: 0x00A91240 File Offset: 0x00A8F440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDayMissionToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			missionUIController.m_luaExportHelper.OnDayMissionToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF54 RID: 130900 RVA: 0x00A9129C File Offset: 0x00A8F49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChallengeToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			missionUIController.m_luaExportHelper.OnChallengeToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF55 RID: 130901 RVA: 0x00A912F8 File Offset: 0x00A8F4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAchievementToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			missionUIController.m_luaExportHelper.OnAchievementToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF56 RID: 130902 RVA: 0x00A91354 File Offset: 0x00A8F554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			missionUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF57 RID: 130903 RVA: 0x00A913C0 File Offset: 0x00A8F5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF58 RID: 130904 RVA: 0x00A91414 File Offset: 0x00A8F614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF59 RID: 130905 RVA: 0x00A91468 File Offset: 0x00A8F668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = missionUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FF5A RID: 130906 RVA: 0x00A91510 File Offset: 0x00A8F710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF5B RID: 130907 RVA: 0x00A91564 File Offset: 0x00A8F764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			missionUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF5C RID: 130908 RVA: 0x00A915D0 File Offset: 0x00A8F7D0
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
				MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				missionUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MissionUIController missionUIController2 = (MissionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				missionUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FF5D RID: 130909 RVA: 0x00A916E0 File Offset: 0x00A8F8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			missionUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF5E RID: 130910 RVA: 0x00A9174C File Offset: 0x00A8F94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			missionUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF5F RID: 130911 RVA: 0x00A917B8 File Offset: 0x00A8F9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			missionUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF60 RID: 130912 RVA: 0x00A91824 File Offset: 0x00A8FA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			missionUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF61 RID: 130913 RVA: 0x00A91890 File Offset: 0x00A8FA90
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
				MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				missionUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MissionUIController missionUIController2 = (MissionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				missionUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FF62 RID: 130914 RVA: 0x00A919A0 File Offset: 0x00A8FBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			string s = missionUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FF63 RID: 130915 RVA: 0x00A919FC File Offset: 0x00A8FBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			missionUIController.m_luaExportHelper.__callDele_EventOnGetRewardButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF64 RID: 130916 RVA: 0x00A91A68 File Offset: 0x00A8FC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			missionUIController.m_luaExportHelper.__clearDele_EventOnGetRewardButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF65 RID: 130917 RVA: 0x00A91AD4 File Offset: 0x00A8FCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoLayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			missionUIController.m_luaExportHelper.__callDele_EventOnGotoLayerButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF66 RID: 130918 RVA: 0x00A91B30 File Offset: 0x00A8FD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoLayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			missionUIController.m_luaExportHelper.__clearDele_EventOnGotoLayerButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF67 RID: 130919 RVA: 0x00A91B8C File Offset: 0x00A8FD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF68 RID: 130920 RVA: 0x00A91BE0 File Offset: 0x00A8FDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			missionUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF69 RID: 130921 RVA: 0x00A91C34 File Offset: 0x00A8FE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF6A RID: 130922 RVA: 0x00A91C8C File Offset: 0x00A8FE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			missionUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF6B RID: 130923 RVA: 0x00A91CE8 File Offset: 0x00A8FEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_closeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF6C RID: 130924 RVA: 0x00A91D40 File Offset: 0x00A8FF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			missionUIController.m_luaExportHelper.m_closeButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF6D RID: 130925 RVA: 0x00A91D9C File Offset: 0x00A8FF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dayMissionToggle(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_dayMissionToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF6E RID: 130926 RVA: 0x00A91DF4 File Offset: 0x00A8FFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dayMissionToggle(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Toggle dayMissionToggle;
			LuaObject.checkType<Toggle>(l, 2, out dayMissionToggle);
			missionUIController.m_luaExportHelper.m_dayMissionToggle = dayMissionToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF6F RID: 130927 RVA: 0x00A91E50 File Offset: 0x00A90050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dayMissionToggleClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_dayMissionToggleClickTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF70 RID: 130928 RVA: 0x00A91EA8 File Offset: 0x00A900A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dayMissionToggleClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GameObject dayMissionToggleClickTag;
			LuaObject.checkType<GameObject>(l, 2, out dayMissionToggleClickTag);
			missionUIController.m_luaExportHelper.m_dayMissionToggleClickTag = dayMissionToggleClickTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF71 RID: 130929 RVA: 0x00A91F04 File Offset: 0x00A90104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dayMissionToggleClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_dayMissionToggleClickTagNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF72 RID: 130930 RVA: 0x00A91F5C File Offset: 0x00A9015C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dayMissionToggleClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Text dayMissionToggleClickTagNum;
			LuaObject.checkType<Text>(l, 2, out dayMissionToggleClickTagNum);
			missionUIController.m_luaExportHelper.m_dayMissionToggleClickTagNum = dayMissionToggleClickTagNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF73 RID: 130931 RVA: 0x00A91FB8 File Offset: 0x00A901B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dayMissionToggleUnClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_dayMissionToggleUnClickTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF74 RID: 130932 RVA: 0x00A92010 File Offset: 0x00A90210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dayMissionToggleUnClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GameObject dayMissionToggleUnClickTag;
			LuaObject.checkType<GameObject>(l, 2, out dayMissionToggleUnClickTag);
			missionUIController.m_luaExportHelper.m_dayMissionToggleUnClickTag = dayMissionToggleUnClickTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF75 RID: 130933 RVA: 0x00A9206C File Offset: 0x00A9026C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dayMissionToggleUnClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_dayMissionToggleUnClickTagNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF76 RID: 130934 RVA: 0x00A920C4 File Offset: 0x00A902C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dayMissionToggleUnClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Text dayMissionToggleUnClickTagNum;
			LuaObject.checkType<Text>(l, 2, out dayMissionToggleUnClickTagNum);
			missionUIController.m_luaExportHelper.m_dayMissionToggleUnClickTagNum = dayMissionToggleUnClickTagNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF77 RID: 130935 RVA: 0x00A92120 File Offset: 0x00A90320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeMissionToggle(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_challengeMissionToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF78 RID: 130936 RVA: 0x00A92178 File Offset: 0x00A90378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeMissionToggle(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Toggle challengeMissionToggle;
			LuaObject.checkType<Toggle>(l, 2, out challengeMissionToggle);
			missionUIController.m_luaExportHelper.m_challengeMissionToggle = challengeMissionToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF79 RID: 130937 RVA: 0x00A921D4 File Offset: 0x00A903D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeMissionToggleClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_challengeMissionToggleClickTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF7A RID: 130938 RVA: 0x00A9222C File Offset: 0x00A9042C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeMissionToggleClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GameObject challengeMissionToggleClickTag;
			LuaObject.checkType<GameObject>(l, 2, out challengeMissionToggleClickTag);
			missionUIController.m_luaExportHelper.m_challengeMissionToggleClickTag = challengeMissionToggleClickTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF7B RID: 130939 RVA: 0x00A92288 File Offset: 0x00A90488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeMissionToggleClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_challengeMissionToggleClickTagNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF7C RID: 130940 RVA: 0x00A922E0 File Offset: 0x00A904E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeMissionToggleClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Text challengeMissionToggleClickTagNum;
			LuaObject.checkType<Text>(l, 2, out challengeMissionToggleClickTagNum);
			missionUIController.m_luaExportHelper.m_challengeMissionToggleClickTagNum = challengeMissionToggleClickTagNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF7D RID: 130941 RVA: 0x00A9233C File Offset: 0x00A9053C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeMissionToggleUnClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_challengeMissionToggleUnClickTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF7E RID: 130942 RVA: 0x00A92394 File Offset: 0x00A90594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeMissionToggleUnClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GameObject challengeMissionToggleUnClickTag;
			LuaObject.checkType<GameObject>(l, 2, out challengeMissionToggleUnClickTag);
			missionUIController.m_luaExportHelper.m_challengeMissionToggleUnClickTag = challengeMissionToggleUnClickTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF7F RID: 130943 RVA: 0x00A923F0 File Offset: 0x00A905F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeMissionToggleUnClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_challengeMissionToggleUnClickTagNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF80 RID: 130944 RVA: 0x00A92448 File Offset: 0x00A90648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeMissionToggleUnClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Text challengeMissionToggleUnClickTagNum;
			LuaObject.checkType<Text>(l, 2, out challengeMissionToggleUnClickTagNum);
			missionUIController.m_luaExportHelper.m_challengeMissionToggleUnClickTagNum = challengeMissionToggleUnClickTagNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF81 RID: 130945 RVA: 0x00A924A4 File Offset: 0x00A906A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementToggle(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_achievementToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF82 RID: 130946 RVA: 0x00A924FC File Offset: 0x00A906FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementToggle(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Toggle achievementToggle;
			LuaObject.checkType<Toggle>(l, 2, out achievementToggle);
			missionUIController.m_luaExportHelper.m_achievementToggle = achievementToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF83 RID: 130947 RVA: 0x00A92558 File Offset: 0x00A90758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementToggleClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_achievementToggleClickTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF84 RID: 130948 RVA: 0x00A925B0 File Offset: 0x00A907B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementToggleClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GameObject achievementToggleClickTag;
			LuaObject.checkType<GameObject>(l, 2, out achievementToggleClickTag);
			missionUIController.m_luaExportHelper.m_achievementToggleClickTag = achievementToggleClickTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF85 RID: 130949 RVA: 0x00A9260C File Offset: 0x00A9080C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementToggleClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_achievementToggleClickTagNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF86 RID: 130950 RVA: 0x00A92664 File Offset: 0x00A90864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementToggleClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Text achievementToggleClickTagNum;
			LuaObject.checkType<Text>(l, 2, out achievementToggleClickTagNum);
			missionUIController.m_luaExportHelper.m_achievementToggleClickTagNum = achievementToggleClickTagNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF87 RID: 130951 RVA: 0x00A926C0 File Offset: 0x00A908C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementToggleUnClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_achievementToggleUnClickTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF88 RID: 130952 RVA: 0x00A92718 File Offset: 0x00A90918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementToggleUnClickTag(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GameObject achievementToggleUnClickTag;
			LuaObject.checkType<GameObject>(l, 2, out achievementToggleUnClickTag);
			missionUIController.m_luaExportHelper.m_achievementToggleUnClickTag = achievementToggleUnClickTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF89 RID: 130953 RVA: 0x00A92774 File Offset: 0x00A90974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementToggleUnClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_achievementToggleUnClickTagNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF8A RID: 130954 RVA: 0x00A927CC File Offset: 0x00A909CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementToggleUnClickTagNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Text achievementToggleUnClickTagNum;
			LuaObject.checkType<Text>(l, 2, out achievementToggleUnClickTagNum);
			missionUIController.m_luaExportHelper.m_achievementToggleUnClickTagNum = achievementToggleUnClickTagNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF8B RID: 130955 RVA: 0x00A92828 File Offset: 0x00A90A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_missionListScrollView(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_missionListScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF8C RID: 130956 RVA: 0x00A92880 File Offset: 0x00A90A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionListScrollView(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			ScrollRect missionListScrollView;
			LuaObject.checkType<ScrollRect>(l, 2, out missionListScrollView);
			missionUIController.m_luaExportHelper.m_missionListScrollView = missionListScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF8D RID: 130957 RVA: 0x00A928DC File Offset: 0x00A90ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_missionListContentObj(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_missionListContentObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF8E RID: 130958 RVA: 0x00A92934 File Offset: 0x00A90B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionListContentObj(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GameObject missionListContentObj;
			LuaObject.checkType<GameObject>(l, 2, out missionListContentObj);
			missionUIController.m_luaExportHelper.m_missionListContentObj = missionListContentObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF8F RID: 130959 RVA: 0x00A92990 File Offset: 0x00A90B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tipsUIStateController(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_tipsUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF90 RID: 130960 RVA: 0x00A929E8 File Offset: 0x00A90BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tipsUIStateController(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			CommonUIStateController tipsUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out tipsUIStateController);
			missionUIController.m_luaExportHelper.m_tipsUIStateController = tipsUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF91 RID: 130961 RVA: 0x00A92A44 File Offset: 0x00A90C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tipsCancelButton(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_tipsCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF92 RID: 130962 RVA: 0x00A92A9C File Offset: 0x00A90C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tipsCancelButton(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Button tipsCancelButton;
			LuaObject.checkType<Button>(l, 2, out tipsCancelButton);
			missionUIController.m_luaExportHelper.m_tipsCancelButton = tipsCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF93 RID: 130963 RVA: 0x00A92AF8 File Offset: 0x00A90CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tipsConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_tipsConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF94 RID: 130964 RVA: 0x00A92B50 File Offset: 0x00A90D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tipsConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Button tipsConfirmButton;
			LuaObject.checkType<Button>(l, 2, out tipsConfirmButton);
			missionUIController.m_luaExportHelper.m_tipsConfirmButton = tipsConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF95 RID: 130965 RVA: 0x00A92BAC File Offset: 0x00A90DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_missionItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_missionItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF96 RID: 130966 RVA: 0x00A92C04 File Offset: 0x00A90E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GameObject missionItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out missionItemPrefab);
			missionUIController.m_luaExportHelper.m_missionItemPrefab = missionItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF97 RID: 130967 RVA: 0x00A92C60 File Offset: 0x00A90E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Action<int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					missionUIController.EventOnGetRewardButtonClick += value;
				}
				else if (num == 2)
				{
					missionUIController.EventOnGetRewardButtonClick -= value;
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

	// Token: 0x0601FF98 RID: 130968 RVA: 0x00A92CE0 File Offset: 0x00A90EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoLayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Action<GetPathData> value;
			int num = LuaObject.checkDelegate<Action<GetPathData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					missionUIController.EventOnGotoLayerButtonClick += value;
				}
				else if (num == 2)
				{
					missionUIController.EventOnGotoLayerButtonClick -= value;
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

	// Token: 0x0601FF99 RID: 130969 RVA: 0x00A92D60 File Offset: 0x00A90F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					missionUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					missionUIController.EventOnClose -= value;
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

	// Token: 0x0601FF9A RID: 130970 RVA: 0x00A92DE0 File Offset: 0x00A90FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dayCompleteNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_dayCompleteNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF9B RID: 130971 RVA: 0x00A92E38 File Offset: 0x00A91038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dayCompleteNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			int dayCompleteNum;
			LuaObject.checkType(l, 2, out dayCompleteNum);
			missionUIController.m_luaExportHelper.m_dayCompleteNum = dayCompleteNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF9C RID: 130972 RVA: 0x00A92E94 File Offset: 0x00A91094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeCompleteNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_challengeCompleteNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF9D RID: 130973 RVA: 0x00A92EEC File Offset: 0x00A910EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeCompleteNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			int challengeCompleteNum;
			LuaObject.checkType(l, 2, out challengeCompleteNum);
			missionUIController.m_luaExportHelper.m_challengeCompleteNum = challengeCompleteNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF9E RID: 130974 RVA: 0x00A92F48 File Offset: 0x00A91148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementCompleteNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_achievementCompleteNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF9F RID: 130975 RVA: 0x00A92FA0 File Offset: 0x00A911A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementCompleteNum(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			int achievementCompleteNum;
			LuaObject.checkType(l, 2, out achievementCompleteNum);
			missionUIController.m_luaExportHelper.m_achievementCompleteNum = achievementCompleteNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA0 RID: 130976 RVA: 0x00A92FFC File Offset: 0x00A911FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curMissionColumnType(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)missionUIController.m_luaExportHelper.m_curMissionColumnType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA1 RID: 130977 RVA: 0x00A93054 File Offset: 0x00A91254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curMissionColumnType(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			MissionColumnType curMissionColumnType;
			LuaObject.checkEnum<MissionColumnType>(l, 2, out curMissionColumnType);
			missionUIController.m_luaExportHelper.m_curMissionColumnType = curMissionColumnType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA2 RID: 130978 RVA: 0x00A930B0 File Offset: 0x00A912B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA3 RID: 130979 RVA: 0x00A93108 File Offset: 0x00A91308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			missionUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA4 RID: 130980 RVA: 0x00A93164 File Offset: 0x00A91364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA5 RID: 130981 RVA: 0x00A931BC File Offset: 0x00A913BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			missionUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA6 RID: 130982 RVA: 0x00A93218 File Offset: 0x00A91418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_getRewardGoodsUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA7 RID: 130983 RVA: 0x00A93270 File Offset: 0x00A91470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			GetRewardGoodsUITask getRewardGoodsUITask;
			LuaObject.checkType<GetRewardGoodsUITask>(l, 2, out getRewardGoodsUITask);
			missionUIController.m_luaExportHelper.m_getRewardGoodsUITask = getRewardGoodsUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA8 RID: 130984 RVA: 0x00A932CC File Offset: 0x00A914CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oldPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_oldPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFA9 RID: 130985 RVA: 0x00A93324 File Offset: 0x00A91524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_oldPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			int oldPlayerLevel;
			LuaObject.checkType(l, 2, out oldPlayerLevel);
			missionUIController.m_luaExportHelper.m_oldPlayerLevel = oldPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFAA RID: 130986 RVA: 0x00A93380 File Offset: 0x00A91580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_missionID(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_missionID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFAB RID: 130987 RVA: 0x00A933D8 File Offset: 0x00A915D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionID(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			int missionID;
			LuaObject.checkType(l, 2, out missionID);
			missionUIController.m_luaExportHelper.m_missionID = missionID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFAC RID: 130988 RVA: 0x00A93434 File Offset: 0x00A91634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardList(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionUIController.m_luaExportHelper.m_rewardList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFAD RID: 130989 RVA: 0x00A9348C File Offset: 0x00A9168C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardList(IntPtr l)
	{
		int result;
		try
		{
			MissionUIController missionUIController = (MissionUIController)LuaObject.checkSelf(l);
			List<Goods> rewardList;
			LuaObject.checkType<List<Goods>>(l, 2, out rewardList);
			missionUIController.m_luaExportHelper.m_rewardList = rewardList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFAE RID: 130990 RVA: 0x00A934E8 File Offset: 0x00A916E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MissionUIController");
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.ShowMissionListByMissionColumnType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.ShowToggleTagNumText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.CreateMissionItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.CompareMissionBySortId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.AddMissionColumnRedTagNum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.ResetRedTagNum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.ShowRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.GetRewardGoodsUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnGotoLayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnTipsBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnTipsConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnDayMissionToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnChallengeToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.OnAchievementToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callDele_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__clearDele_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callDele_EventOnGotoLayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__clearDele_EventOnGotoLayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache24);
		string name = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_marginTransform);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache26, true);
		string name2 = "m_closeButton";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_closeButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_closeButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache28, true);
		string name3 = "m_dayMissionToggle";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_dayMissionToggle);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_dayMissionToggle);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2A, true);
		string name4 = "m_dayMissionToggleClickTag";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_dayMissionToggleClickTag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_dayMissionToggleClickTag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2C, true);
		string name5 = "m_dayMissionToggleClickTagNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_dayMissionToggleClickTagNum);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_dayMissionToggleClickTagNum);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2E, true);
		string name6 = "m_dayMissionToggleUnClickTag";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_dayMissionToggleUnClickTag);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_dayMissionToggleUnClickTag);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache30, true);
		string name7 = "m_dayMissionToggleUnClickTagNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_dayMissionToggleUnClickTagNum);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_dayMissionToggleUnClickTagNum);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache32, true);
		string name8 = "m_challengeMissionToggle";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_challengeMissionToggle);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_challengeMissionToggle);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache34, true);
		string name9 = "m_challengeMissionToggleClickTag";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_challengeMissionToggleClickTag);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_challengeMissionToggleClickTag);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache36, true);
		string name10 = "m_challengeMissionToggleClickTagNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_challengeMissionToggleClickTagNum);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_challengeMissionToggleClickTagNum);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache38, true);
		string name11 = "m_challengeMissionToggleUnClickTag";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_challengeMissionToggleUnClickTag);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_challengeMissionToggleUnClickTag);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3A, true);
		string name12 = "m_challengeMissionToggleUnClickTagNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_challengeMissionToggleUnClickTagNum);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_challengeMissionToggleUnClickTagNum);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3C, true);
		string name13 = "m_achievementToggle";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_achievementToggle);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_achievementToggle);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3E, true);
		string name14 = "m_achievementToggleClickTag";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_achievementToggleClickTag);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_achievementToggleClickTag);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache40, true);
		string name15 = "m_achievementToggleClickTagNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_achievementToggleClickTagNum);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_achievementToggleClickTagNum);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache42, true);
		string name16 = "m_achievementToggleUnClickTag";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_achievementToggleUnClickTag);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_achievementToggleUnClickTag);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache44, true);
		string name17 = "m_achievementToggleUnClickTagNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_achievementToggleUnClickTagNum);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_achievementToggleUnClickTagNum);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache46, true);
		string name18 = "m_missionListScrollView";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_missionListScrollView);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_missionListScrollView);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache48, true);
		string name19 = "m_missionListContentObj";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_missionListContentObj);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_missionListContentObj);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4A, true);
		string name20 = "m_tipsUIStateController";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_tipsUIStateController);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_tipsUIStateController);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4C, true);
		string name21 = "m_tipsCancelButton";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_tipsCancelButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_tipsCancelButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4E, true);
		string name22 = "m_tipsConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_tipsConfirmButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_tipsConfirmButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache50, true);
		string name23 = "m_missionItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_missionItemPrefab);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_missionItemPrefab);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache52, true);
		string name24 = "EventOnGetRewardButtonClick";
		LuaCSFunction get24 = null;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache53, true);
		string name25 = "EventOnGotoLayerButtonClick";
		LuaCSFunction get25 = null;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_EventOnGotoLayerButtonClick);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache54, true);
		string name26 = "EventOnClose";
		LuaCSFunction get26 = null;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache55, true);
		string name27 = "m_dayCompleteNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_dayCompleteNum);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_dayCompleteNum);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache57, true);
		string name28 = "m_challengeCompleteNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_challengeCompleteNum);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_challengeCompleteNum);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache59, true);
		string name29 = "m_achievementCompleteNum";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_achievementCompleteNum);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_achievementCompleteNum);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5B, true);
		string name30 = "m_curMissionColumnType";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_curMissionColumnType);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_curMissionColumnType);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5D, true);
		string name31 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_playerContext);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache5F, true);
		string name32 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_configDataLoader);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache61, true);
		string name33 = "m_getRewardGoodsUITask";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_getRewardGoodsUITask);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_getRewardGoodsUITask);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache63, true);
		string name34 = "m_oldPlayerLevel";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_oldPlayerLevel);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_oldPlayerLevel);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache65, true);
		string name35 = "m_missionID";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_missionID);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_missionID);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache67, true);
		string name36 = "m_rewardList";
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.get_m_rewardList);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionUIController.set_m_rewardList);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_MissionUIController.<>f__mg$cache69, true);
		LuaObject.createTypeMetatable(l, null, typeof(MissionUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015F04 RID: 89860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015F05 RID: 89861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015F06 RID: 89862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015F07 RID: 89863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015F08 RID: 89864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015F09 RID: 89865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015F0A RID: 89866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015F0B RID: 89867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015F0C RID: 89868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015F0D RID: 89869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015F0E RID: 89870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015F0F RID: 89871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015F10 RID: 89872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015F11 RID: 89873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015F12 RID: 89874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015F13 RID: 89875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015F14 RID: 89876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015F15 RID: 89877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015F16 RID: 89878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015F17 RID: 89879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015F18 RID: 89880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015F19 RID: 89881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015F1A RID: 89882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015F1B RID: 89883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015F1C RID: 89884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015F1D RID: 89885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015F1E RID: 89886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015F1F RID: 89887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015F20 RID: 89888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015F21 RID: 89889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015F22 RID: 89890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015F23 RID: 89891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015F24 RID: 89892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015F25 RID: 89893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015F26 RID: 89894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015F27 RID: 89895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015F28 RID: 89896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015F29 RID: 89897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015F2A RID: 89898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015F2B RID: 89899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015F2C RID: 89900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015F2D RID: 89901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015F2E RID: 89902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015F2F RID: 89903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015F30 RID: 89904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015F31 RID: 89905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015F32 RID: 89906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015F33 RID: 89907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015F34 RID: 89908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015F35 RID: 89909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015F36 RID: 89910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015F37 RID: 89911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015F38 RID: 89912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015F39 RID: 89913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015F3A RID: 89914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015F3B RID: 89915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015F3C RID: 89916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015F3D RID: 89917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015F3E RID: 89918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015F3F RID: 89919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015F40 RID: 89920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015F41 RID: 89921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015F42 RID: 89922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015F43 RID: 89923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015F44 RID: 89924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015F45 RID: 89925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015F46 RID: 89926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015F47 RID: 89927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015F48 RID: 89928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04015F49 RID: 89929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04015F4A RID: 89930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04015F4B RID: 89931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04015F4C RID: 89932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04015F4D RID: 89933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04015F4E RID: 89934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04015F4F RID: 89935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04015F50 RID: 89936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04015F51 RID: 89937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04015F52 RID: 89938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04015F53 RID: 89939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04015F54 RID: 89940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04015F55 RID: 89941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04015F56 RID: 89942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04015F57 RID: 89943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04015F58 RID: 89944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04015F59 RID: 89945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04015F5A RID: 89946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04015F5B RID: 89947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04015F5C RID: 89948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04015F5D RID: 89949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04015F5E RID: 89950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04015F5F RID: 89951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04015F60 RID: 89952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04015F61 RID: 89953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04015F62 RID: 89954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04015F63 RID: 89955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04015F64 RID: 89956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04015F65 RID: 89957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04015F66 RID: 89958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04015F67 RID: 89959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04015F68 RID: 89960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04015F69 RID: 89961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04015F6A RID: 89962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04015F6B RID: 89963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04015F6C RID: 89964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04015F6D RID: 89965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;
}
