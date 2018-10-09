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

// Token: 0x0200141C RID: 5148
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DrillUIController : LuaObject
{
	// Token: 0x0601D3F8 RID: 119800 RVA: 0x00939138 File Offset: 0x00937338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3F9 RID: 119801 RVA: 0x00939184 File Offset: 0x00937384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInDrill(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int drillState;
			LuaObject.checkType(l, 2, out drillState);
			drillUIController.UpdateViewInDrill(drillState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3FA RID: 119802 RVA: 0x009391DC File Offset: 0x009373DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeamTime(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			TimeSpan ts;
			LuaObject.checkValueType<TimeSpan>(l, 3, out ts);
			drillUIController.SetTeamTime(slot, ts);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3FB RID: 119803 RVA: 0x00939240 File Offset: 0x00937440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3FC RID: 119804 RVA: 0x00939294 File Offset: 0x00937494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTrainingDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			TrainingRoom trainingDetailPanel;
			LuaObject.checkType<TrainingRoom>(l, 2, out trainingDetailPanel);
			drillUIController.m_luaExportHelper.SetTrainingDetailPanel(trainingDetailPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3FD RID: 119805 RVA: 0x009392F0 File Offset: 0x009374F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCourseItemClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CourseItemUIController ctrl;
			LuaObject.checkType<CourseItemUIController>(l, 2, out ctrl);
			drillUIController.m_luaExportHelper.OnCourseItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3FE RID: 119806 RVA: 0x0093934C File Offset: 0x0093754C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRoomToggleClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			DrillRoomToggleUIController ctrl;
			LuaObject.checkType<DrillRoomToggleUIController>(l, 2, out ctrl);
			drillUIController.m_luaExportHelper.OnRoomToggleClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3FF RID: 119807 RVA: 0x009393A8 File Offset: 0x009375A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPropertyAddition(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.SetPropertyAddition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D400 RID: 119808 RVA: 0x009393FC File Offset: 0x009375FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetAllPropertyState(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.ResetAllPropertyState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D401 RID: 119809 RVA: 0x00939450 File Offset: 0x00937650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcSoldierPropertyModifityAddtion(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			drillUIController.m_luaExportHelper.CalcSoldierPropertyModifityAddtion(type, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D402 RID: 119810 RVA: 0x009394BC File Offset: 0x009376BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeachingDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.SetTeachingDetailPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D403 RID: 119811 RVA: 0x00939510 File Offset: 0x00937710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAssistanceTeamTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			drillUIController.m_luaExportHelper.OnAssistanceTeamTrainingButtonClick(slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D404 RID: 119812 RVA: 0x0093956C File Offset: 0x0093776C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAssistanceTeamStopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			AssistanceTeamUIController ctrl;
			LuaObject.checkType<AssistanceTeamUIController>(l, 2, out ctrl);
			drillUIController.m_luaExportHelper.OnAssistanceTeamStopButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D405 RID: 119813 RVA: 0x009395C8 File Offset: 0x009377C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenStopTeachingPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.OpenStopTeachingPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D406 RID: 119814 RVA: 0x0093961C File Offset: 0x0093781C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseStopTeachingPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.CloseStopTeachingPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D407 RID: 119815 RVA: 0x00939670 File Offset: 0x00937870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopTeachingPanelConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.OnStopTeachingPanelConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D408 RID: 119816 RVA: 0x009396C4 File Offset: 0x009378C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAssistanceTeamGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			AssistanceTeamUIController ctrl;
			LuaObject.checkType<AssistanceTeamUIController>(l, 2, out ctrl);
			drillUIController.m_luaExportHelper.OnAssistanceTeamGetRewardButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D409 RID: 119817 RVA: 0x00939720 File Offset: 0x00937920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.OnTrainingButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D40A RID: 119818 RVA: 0x00939774 File Offset: 0x00937974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.OnSoldierInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D40B RID: 119819 RVA: 0x009397C8 File Offset: 0x009379C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTrainingToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillUIController.m_luaExportHelper.OnTrainingToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D40C RID: 119820 RVA: 0x00939824 File Offset: 0x00937A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTeachingToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillUIController.m_luaExportHelper.OnTeachingToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D40D RID: 119821 RVA: 0x00939880 File Offset: 0x00937A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFastMaxButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.OnFastMaxButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D40E RID: 119822 RVA: 0x009398D4 File Offset: 0x00937AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearDataCache(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.ClearDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D40F RID: 119823 RVA: 0x00939928 File Offset: 0x00937B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D410 RID: 119824 RVA: 0x0093997C File Offset: 0x00937B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D411 RID: 119825 RVA: 0x009399D0 File Offset: 0x00937BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			drillUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D412 RID: 119826 RVA: 0x00939A3C File Offset: 0x00937C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D413 RID: 119827 RVA: 0x00939A90 File Offset: 0x00937C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D414 RID: 119828 RVA: 0x00939AE4 File Offset: 0x00937CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = drillUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D415 RID: 119829 RVA: 0x00939B8C File Offset: 0x00937D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D416 RID: 119830 RVA: 0x00939BE0 File Offset: 0x00937DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			drillUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D417 RID: 119831 RVA: 0x00939C4C File Offset: 0x00937E4C
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
				DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				drillUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DrillUIController drillUIController2 = (DrillUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				drillUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D418 RID: 119832 RVA: 0x00939D5C File Offset: 0x00937F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D419 RID: 119833 RVA: 0x00939DC8 File Offset: 0x00937FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D41A RID: 119834 RVA: 0x00939E34 File Offset: 0x00938034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D41B RID: 119835 RVA: 0x00939EA0 File Offset: 0x009380A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D41C RID: 119836 RVA: 0x00939F0C File Offset: 0x0093810C
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
				DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				drillUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DrillUIController drillUIController2 = (DrillUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				drillUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D41D RID: 119837 RVA: 0x0093A01C File Offset: 0x0093821C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			string s = drillUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D41E RID: 119838 RVA: 0x0093A078 File Offset: 0x00938278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D41F RID: 119839 RVA: 0x0093A0CC File Offset: 0x009382CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D420 RID: 119840 RVA: 0x0093A120 File Offset: 0x00938320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D421 RID: 119841 RVA: 0x0093A174 File Offset: 0x00938374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D422 RID: 119842 RVA: 0x0093A1C8 File Offset: 0x009383C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnManualButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__callDele_EventOnManualButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D423 RID: 119843 RVA: 0x0093A21C File Offset: 0x0093841C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnManualButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			drillUIController.m_luaExportHelper.__clearDele_EventOnManualButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D424 RID: 119844 RVA: 0x0093A270 File Offset: 0x00938470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			drillUIController.m_luaExportHelper.__callDele_EventOnTrainingButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D425 RID: 119845 RVA: 0x0093A2CC File Offset: 0x009384CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			drillUIController.m_luaExportHelper.__clearDele_EventOnTrainingButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D426 RID: 119846 RVA: 0x0093A328 File Offset: 0x00938528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAssistanceTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			drillUIController.m_luaExportHelper.__callDele_EventOnAssistanceTrainingButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D427 RID: 119847 RVA: 0x0093A384 File Offset: 0x00938584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAssistanceTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			drillUIController.m_luaExportHelper.__clearDele_EventOnAssistanceTrainingButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D428 RID: 119848 RVA: 0x0093A3E0 File Offset: 0x009385E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAssistanceStopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			drillUIController.m_luaExportHelper.__callDele_EventOnAssistanceStopButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D429 RID: 119849 RVA: 0x0093A458 File Offset: 0x00938658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAssistanceStopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			drillUIController.m_luaExportHelper.__clearDele_EventOnAssistanceStopButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D42A RID: 119850 RVA: 0x0093A4D0 File Offset: 0x009386D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnAssistanceGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			drillUIController.m_luaExportHelper.__callDele_EventOnAssistanceGetRewardButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D42B RID: 119851 RVA: 0x0093A53C File Offset: 0x0093873C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAssistanceGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			drillUIController.m_luaExportHelper.__clearDele_EventOnAssistanceGetRewardButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D42C RID: 119852 RVA: 0x0093A5A8 File Offset: 0x009387A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					drillUIController.EventOnReturn -= value;
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

	// Token: 0x0601D42D RID: 119853 RVA: 0x0093A628 File Offset: 0x00938828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					drillUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601D42E RID: 119854 RVA: 0x0093A6A8 File Offset: 0x009388A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnManualButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillUIController.EventOnManualButtonClick += value;
				}
				else if (num == 2)
				{
					drillUIController.EventOnManualButtonClick -= value;
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

	// Token: 0x0601D42F RID: 119855 RVA: 0x0093A728 File Offset: 0x00938928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillUIController.EventOnTrainingButtonClick += value;
				}
				else if (num == 2)
				{
					drillUIController.EventOnTrainingButtonClick -= value;
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

	// Token: 0x0601D430 RID: 119856 RVA: 0x0093A7A8 File Offset: 0x009389A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAssistanceTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillUIController.EventOnAssistanceTrainingButtonClick += value;
				}
				else if (num == 2)
				{
					drillUIController.EventOnAssistanceTrainingButtonClick -= value;
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

	// Token: 0x0601D431 RID: 119857 RVA: 0x0093A828 File Offset: 0x00938A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAssistanceStopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Action<int, int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillUIController.EventOnAssistanceStopButtonClick += value;
				}
				else if (num == 2)
				{
					drillUIController.EventOnAssistanceStopButtonClick -= value;
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

	// Token: 0x0601D432 RID: 119858 RVA: 0x0093A8A8 File Offset: 0x00938AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAssistanceGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillUIController.EventOnAssistanceGetRewardButtonClick += value;
				}
				else if (num == 2)
				{
					drillUIController.EventOnAssistanceGetRewardButtonClick -= value;
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

	// Token: 0x0601D433 RID: 119859 RVA: 0x0093A928 File Offset: 0x00938B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D434 RID: 119860 RVA: 0x0093A980 File Offset: 0x00938B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			drillUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D435 RID: 119861 RVA: 0x0093A9DC File Offset: 0x00938BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D436 RID: 119862 RVA: 0x0093AA34 File Offset: 0x00938C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			drillUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D437 RID: 119863 RVA: 0x0093AA90 File Offset: 0x00938C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D438 RID: 119864 RVA: 0x0093AAE8 File Offset: 0x00938CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			drillUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D439 RID: 119865 RVA: 0x0093AB44 File Offset: 0x00938D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastMaxButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_fastMaxButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D43A RID: 119866 RVA: 0x0093AB9C File Offset: 0x00938D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastMaxButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button fastMaxButton;
			LuaObject.checkType<Button>(l, 2, out fastMaxButton);
			drillUIController.m_luaExportHelper.m_fastMaxButton = fastMaxButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D43B RID: 119867 RVA: 0x0093ABF8 File Offset: 0x00938DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D43C RID: 119868 RVA: 0x0093AC50 File Offset: 0x00938E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingStateCtrl = trainingStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D43D RID: 119869 RVA: 0x0093ACAC File Offset: 0x00938EAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelLeftToggleGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelLeftToggleGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D43E RID: 119870 RVA: 0x0093AD04 File Offset: 0x00938F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelLeftToggleGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			GameObject trainingPanelLeftToggleGroup;
			LuaObject.checkType<GameObject>(l, 2, out trainingPanelLeftToggleGroup);
			drillUIController.m_luaExportHelper.m_trainingPanelLeftToggleGroup = trainingPanelLeftToggleGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D43F RID: 119871 RVA: 0x0093AD60 File Offset: 0x00938F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelTitleInfoLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelTitleInfoLvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D440 RID: 119872 RVA: 0x0093ADB8 File Offset: 0x00938FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelTitleInfoLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelTitleInfoLvValueText;
			LuaObject.checkType<Text>(l, 2, out trainingPanelTitleInfoLvValueText);
			drillUIController.m_luaExportHelper.m_trainingPanelTitleInfoLvValueText = trainingPanelTitleInfoLvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D441 RID: 119873 RVA: 0x0093AE14 File Offset: 0x00939014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelTitleInfoExpValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelTitleInfoExpValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D442 RID: 119874 RVA: 0x0093AE6C File Offset: 0x0093906C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelTitleInfoExpValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelTitleInfoExpValueText;
			LuaObject.checkType<Text>(l, 2, out trainingPanelTitleInfoExpValueText);
			drillUIController.m_luaExportHelper.m_trainingPanelTitleInfoExpValueText = trainingPanelTitleInfoExpValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D443 RID: 119875 RVA: 0x0093AEC8 File Offset: 0x009390C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelTitleInfoProgressBar(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelTitleInfoProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D444 RID: 119876 RVA: 0x0093AF20 File Offset: 0x00939120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelTitleInfoProgressBar(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Image trainingPanelTitleInfoProgressBar;
			LuaObject.checkType<Image>(l, 2, out trainingPanelTitleInfoProgressBar);
			drillUIController.m_luaExportHelper.m_trainingPanelTitleInfoProgressBar = trainingPanelTitleInfoProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D445 RID: 119877 RVA: 0x0093AF7C File Offset: 0x0093917C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelTrainingEventScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelTrainingEventScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D446 RID: 119878 RVA: 0x0093AFD4 File Offset: 0x009391D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelTrainingEventScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			GameObject trainingPanelTrainingEventScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out trainingPanelTrainingEventScrollViewContent);
			drillUIController.m_luaExportHelper.m_trainingPanelTrainingEventScrollViewContent = trainingPanelTrainingEventScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D447 RID: 119879 RVA: 0x0093B030 File Offset: 0x00939230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelTrainingButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelTrainingButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D448 RID: 119880 RVA: 0x0093B088 File Offset: 0x00939288
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelTrainingButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button trainingPanelTrainingButton;
			LuaObject.checkType<Button>(l, 2, out trainingPanelTrainingButton);
			drillUIController.m_luaExportHelper.m_trainingPanelTrainingButton = trainingPanelTrainingButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D449 RID: 119881 RVA: 0x0093B0E4 File Offset: 0x009392E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupHPAddStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupHPAddStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D44A RID: 119882 RVA: 0x0093B13C File Offset: 0x0093933C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupHPAddStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingPanelPropretyGroupHPAddStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingPanelPropretyGroupHPAddStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupHPAddStateCtrl = trainingPanelPropretyGroupHPAddStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D44B RID: 119883 RVA: 0x0093B198 File Offset: 0x00939398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelPropretyGroupHPAddValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupHPAddValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D44C RID: 119884 RVA: 0x0093B1F0 File Offset: 0x009393F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelPropretyGroupHPAddValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelPropretyGroupHPAddValue;
			LuaObject.checkType<Text>(l, 2, out trainingPanelPropretyGroupHPAddValue);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupHPAddValue = trainingPanelPropretyGroupHPAddValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D44D RID: 119885 RVA: 0x0093B24C File Offset: 0x0093944C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelPropretyGroupAttackAddStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupAttackAddStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D44E RID: 119886 RVA: 0x0093B2A4 File Offset: 0x009394A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupAttackAddStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingPanelPropretyGroupAttackAddStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingPanelPropretyGroupAttackAddStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupAttackAddStateCtrl = trainingPanelPropretyGroupAttackAddStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D44F RID: 119887 RVA: 0x0093B300 File Offset: 0x00939500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelPropretyGroupAttackAddValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupAttackAddValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D450 RID: 119888 RVA: 0x0093B358 File Offset: 0x00939558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelPropretyGroupAttackAddValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelPropretyGroupAttackAddValue;
			LuaObject.checkType<Text>(l, 2, out trainingPanelPropretyGroupAttackAddValue);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupAttackAddValue = trainingPanelPropretyGroupAttackAddValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D451 RID: 119889 RVA: 0x0093B3B4 File Offset: 0x009395B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupDefenseAddStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupDefenseAddStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D452 RID: 119890 RVA: 0x0093B40C File Offset: 0x0093960C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupDefenseAddStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingPanelPropretyGroupDefenseAddStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingPanelPropretyGroupDefenseAddStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupDefenseAddStateCtrl = trainingPanelPropretyGroupDefenseAddStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D453 RID: 119891 RVA: 0x0093B468 File Offset: 0x00939668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupDefenseAddValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupDefenseAddValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D454 RID: 119892 RVA: 0x0093B4C0 File Offset: 0x009396C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelPropretyGroupDefenseAddValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelPropretyGroupDefenseAddValue;
			LuaObject.checkType<Text>(l, 2, out trainingPanelPropretyGroupDefenseAddValue);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupDefenseAddValue = trainingPanelPropretyGroupDefenseAddValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D455 RID: 119893 RVA: 0x0093B51C File Offset: 0x0093971C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupMagicDFAddStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupMagicDFAddStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D456 RID: 119894 RVA: 0x0093B574 File Offset: 0x00939774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupMagicDFAddStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingPanelPropretyGroupMagicDFAddStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingPanelPropretyGroupMagicDFAddStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupMagicDFAddStateCtrl = trainingPanelPropretyGroupMagicDFAddStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D457 RID: 119895 RVA: 0x0093B5D0 File Offset: 0x009397D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelPropretyGroupMagicDFAddValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupMagicDFAddValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D458 RID: 119896 RVA: 0x0093B628 File Offset: 0x00939828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelPropretyGroupMagicDFAddValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelPropretyGroupMagicDFAddValue;
			LuaObject.checkType<Text>(l, 2, out trainingPanelPropretyGroupMagicDFAddValue);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupMagicDFAddValue = trainingPanelPropretyGroupMagicDFAddValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D459 RID: 119897 RVA: 0x0093B684 File Offset: 0x00939884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupHPPerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupHPPerStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D45A RID: 119898 RVA: 0x0093B6DC File Offset: 0x009398DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupHPPerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingPanelPropretyGroupHPPerStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingPanelPropretyGroupHPPerStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupHPPerStateCtrl = trainingPanelPropretyGroupHPPerStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D45B RID: 119899 RVA: 0x0093B738 File Offset: 0x00939938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelPropretyGroupHPPerValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupHPPerValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D45C RID: 119900 RVA: 0x0093B790 File Offset: 0x00939990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupHPPerValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelPropretyGroupHPPerValue;
			LuaObject.checkType<Text>(l, 2, out trainingPanelPropretyGroupHPPerValue);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupHPPerValue = trainingPanelPropretyGroupHPPerValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D45D RID: 119901 RVA: 0x0093B7EC File Offset: 0x009399EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupAttackPerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupAttackPerStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D45E RID: 119902 RVA: 0x0093B844 File Offset: 0x00939A44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelPropretyGroupAttackPerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingPanelPropretyGroupAttackPerStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingPanelPropretyGroupAttackPerStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupAttackPerStateCtrl = trainingPanelPropretyGroupAttackPerStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D45F RID: 119903 RVA: 0x0093B8A0 File Offset: 0x00939AA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelPropretyGroupAttackPerValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupAttackPerValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D460 RID: 119904 RVA: 0x0093B8F8 File Offset: 0x00939AF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelPropretyGroupAttackPerValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelPropretyGroupAttackPerValue;
			LuaObject.checkType<Text>(l, 2, out trainingPanelPropretyGroupAttackPerValue);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupAttackPerValue = trainingPanelPropretyGroupAttackPerValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D461 RID: 119905 RVA: 0x0093B954 File Offset: 0x00939B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingPanelPropretyGroupDefensePerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupDefensePerStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D462 RID: 119906 RVA: 0x0093B9AC File Offset: 0x00939BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupDefensePerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingPanelPropretyGroupDefensePerStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingPanelPropretyGroupDefensePerStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupDefensePerStateCtrl = trainingPanelPropretyGroupDefensePerStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D463 RID: 119907 RVA: 0x0093BA08 File Offset: 0x00939C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupDefensePerValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupDefensePerValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D464 RID: 119908 RVA: 0x0093BA60 File Offset: 0x00939C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupDefensePerValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelPropretyGroupDefensePerValue;
			LuaObject.checkType<Text>(l, 2, out trainingPanelPropretyGroupDefensePerValue);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupDefensePerValue = trainingPanelPropretyGroupDefensePerValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D465 RID: 119909 RVA: 0x0093BABC File Offset: 0x00939CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupMagicDFPerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupMagicDFPerStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D466 RID: 119910 RVA: 0x0093BB14 File Offset: 0x00939D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingPanelPropretyGroupMagicDFPerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController trainingPanelPropretyGroupMagicDFPerStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out trainingPanelPropretyGroupMagicDFPerStateCtrl);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupMagicDFPerStateCtrl = trainingPanelPropretyGroupMagicDFPerStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D467 RID: 119911 RVA: 0x0093BB70 File Offset: 0x00939D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingPanelPropretyGroupMagicDFPerValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupMagicDFPerValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D468 RID: 119912 RVA: 0x0093BBC8 File Offset: 0x00939DC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingPanelPropretyGroupMagicDFPerValue(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Text trainingPanelPropretyGroupMagicDFPerValue;
			LuaObject.checkType<Text>(l, 2, out trainingPanelPropretyGroupMagicDFPerValue);
			drillUIController.m_luaExportHelper.m_trainingPanelPropretyGroupMagicDFPerValue = trainingPanelPropretyGroupMagicDFPerValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D469 RID: 119913 RVA: 0x0093BC24 File Offset: 0x00939E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachingStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D46A RID: 119914 RVA: 0x0093BC7C File Offset: 0x00939E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teachingStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController teachingStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out teachingStateCtrl);
			drillUIController.m_luaExportHelper.m_teachingStateCtrl = teachingStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D46B RID: 119915 RVA: 0x0093BCD8 File Offset: 0x00939ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachingChar(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingChar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D46C RID: 119916 RVA: 0x0093BD30 File Offset: 0x00939F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teachingChar(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			GameObject teachingChar;
			LuaObject.checkType<GameObject>(l, 2, out teachingChar);
			drillUIController.m_luaExportHelper.m_teachingChar = teachingChar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D46D RID: 119917 RVA: 0x0093BD8C File Offset: 0x00939F8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_teachingDetailTeam1(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingDetailTeam1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D46E RID: 119918 RVA: 0x0093BDE4 File Offset: 0x00939FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teachingDetailTeam1(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			GameObject teachingDetailTeam;
			LuaObject.checkType<GameObject>(l, 2, out teachingDetailTeam);
			drillUIController.m_luaExportHelper.m_teachingDetailTeam1 = teachingDetailTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D46F RID: 119919 RVA: 0x0093BE40 File Offset: 0x0093A040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachingDetailTeam2(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingDetailTeam2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D470 RID: 119920 RVA: 0x0093BE98 File Offset: 0x0093A098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teachingDetailTeam2(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			GameObject teachingDetailTeam;
			LuaObject.checkType<GameObject>(l, 2, out teachingDetailTeam);
			drillUIController.m_luaExportHelper.m_teachingDetailTeam2 = teachingDetailTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D471 RID: 119921 RVA: 0x0093BEF4 File Offset: 0x0093A0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachingDetailTeam3(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingDetailTeam3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D472 RID: 119922 RVA: 0x0093BF4C File Offset: 0x0093A14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teachingDetailTeam3(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			GameObject teachingDetailTeam;
			LuaObject.checkType<GameObject>(l, 2, out teachingDetailTeam);
			drillUIController.m_luaExportHelper.m_teachingDetailTeam3 = teachingDetailTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D473 RID: 119923 RVA: 0x0093BFA8 File Offset: 0x0093A1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachingTodayRewardArmyIcon1(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingTodayRewardArmyIcon1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D474 RID: 119924 RVA: 0x0093C000 File Offset: 0x0093A200
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teachingTodayRewardArmyIcon1(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Image teachingTodayRewardArmyIcon;
			LuaObject.checkType<Image>(l, 2, out teachingTodayRewardArmyIcon);
			drillUIController.m_luaExportHelper.m_teachingTodayRewardArmyIcon1 = teachingTodayRewardArmyIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D475 RID: 119925 RVA: 0x0093C05C File Offset: 0x0093A25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachingTodayRewardArmyIcon2(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingTodayRewardArmyIcon2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D476 RID: 119926 RVA: 0x0093C0B4 File Offset: 0x0093A2B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teachingTodayRewardArmyIcon2(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Image teachingTodayRewardArmyIcon;
			LuaObject.checkType<Image>(l, 2, out teachingTodayRewardArmyIcon);
			drillUIController.m_luaExportHelper.m_teachingTodayRewardArmyIcon2 = teachingTodayRewardArmyIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D477 RID: 119927 RVA: 0x0093C110 File Offset: 0x0093A310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_trainingToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D478 RID: 119928 RVA: 0x0093C168 File Offset: 0x0093A368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Toggle trainingToggle;
			LuaObject.checkType<Toggle>(l, 2, out trainingToggle);
			drillUIController.m_luaExportHelper.m_trainingToggle = trainingToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D479 RID: 119929 RVA: 0x0093C1C4 File Offset: 0x0093A3C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_teachingToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D47A RID: 119930 RVA: 0x0093C21C File Offset: 0x0093A41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teachingToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Toggle teachingToggle;
			LuaObject.checkType<Toggle>(l, 2, out teachingToggle);
			drillUIController.m_luaExportHelper.m_teachingToggle = teachingToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D47B RID: 119931 RVA: 0x0093C278 File Offset: 0x0093A478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachingToggleClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingToggleClickRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D47C RID: 119932 RVA: 0x0093C2D0 File Offset: 0x0093A4D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teachingToggleClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			GameObject teachingToggleClickRedMark;
			LuaObject.checkType<GameObject>(l, 2, out teachingToggleClickRedMark);
			drillUIController.m_luaExportHelper.m_teachingToggleClickRedMark = teachingToggleClickRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D47D RID: 119933 RVA: 0x0093C32C File Offset: 0x0093A52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachingToggleUnClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_teachingToggleUnClickRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D47E RID: 119934 RVA: 0x0093C384 File Offset: 0x0093A584
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teachingToggleUnClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			GameObject teachingToggleUnClickRedMark;
			LuaObject.checkType<GameObject>(l, 2, out teachingToggleUnClickRedMark);
			drillUIController.m_luaExportHelper.m_teachingToggleUnClickRedMark = teachingToggleUnClickRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D47F RID: 119935 RVA: 0x0093C3E0 File Offset: 0x0093A5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_soldierInfoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D480 RID: 119936 RVA: 0x0093C438 File Offset: 0x0093A638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfoButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button soldierInfoButton;
			LuaObject.checkType<Button>(l, 2, out soldierInfoButton);
			drillUIController.m_luaExportHelper.m_soldierInfoButton = soldierInfoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D481 RID: 119937 RVA: 0x0093C494 File Offset: 0x0093A694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stopTeachingPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_stopTeachingPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D482 RID: 119938 RVA: 0x0093C4EC File Offset: 0x0093A6EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stopTeachingPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			CommonUIStateController stopTeachingPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stopTeachingPanelStateCtrl);
			drillUIController.m_luaExportHelper.m_stopTeachingPanelStateCtrl = stopTeachingPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D483 RID: 119939 RVA: 0x0093C548 File Offset: 0x0093A748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stopTeachingPanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_stopTeachingPanelBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D484 RID: 119940 RVA: 0x0093C5A0 File Offset: 0x0093A7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stopTeachingPanelBackButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button stopTeachingPanelBackButton;
			LuaObject.checkType<Button>(l, 2, out stopTeachingPanelBackButton);
			drillUIController.m_luaExportHelper.m_stopTeachingPanelBackButton = stopTeachingPanelBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D485 RID: 119941 RVA: 0x0093C5FC File Offset: 0x0093A7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stopTeachingPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_stopTeachingPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D486 RID: 119942 RVA: 0x0093C654 File Offset: 0x0093A854
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stopTeachingPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button stopTeachingPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out stopTeachingPanelConfirmButton);
			drillUIController.m_luaExportHelper.m_stopTeachingPanelConfirmButton = stopTeachingPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D487 RID: 119943 RVA: 0x0093C6B0 File Offset: 0x0093A8B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_stopTeachingPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_stopTeachingPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D488 RID: 119944 RVA: 0x0093C708 File Offset: 0x0093A908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stopTeachingPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			Button stopTeachingPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out stopTeachingPanelCancelButton);
			drillUIController.m_luaExportHelper.m_stopTeachingPanelCancelButton = stopTeachingPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D489 RID: 119945 RVA: 0x0093C764 File Offset: 0x0093A964
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curDrillState(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)drillUIController.m_luaExportHelper.m_curDrillState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D48A RID: 119946 RVA: 0x0093C7BC File Offset: 0x0093A9BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curDrillState(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			DrillUIController.DrillState curDrillState;
			LuaObject.checkEnum<DrillUIController.DrillState>(l, 2, out curDrillState);
			drillUIController.m_luaExportHelper.m_curDrillState = curDrillState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D48B RID: 119947 RVA: 0x0093C818 File Offset: 0x0093AA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curTrainingRoom(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_curTrainingRoom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D48C RID: 119948 RVA: 0x0093C870 File Offset: 0x0093AA70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curTrainingRoom(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			TrainingRoom curTrainingRoom;
			LuaObject.checkType<TrainingRoom>(l, 2, out curTrainingRoom);
			drillUIController.m_luaExportHelper.m_curTrainingRoom = curTrainingRoom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D48D RID: 119949 RVA: 0x0093C8CC File Offset: 0x0093AACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_assistanceTeamUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_assistanceTeamUICtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D48E RID: 119950 RVA: 0x0093C924 File Offset: 0x0093AB24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_assistanceTeamUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			List<AssistanceTeamUIController> assistanceTeamUICtrlList;
			LuaObject.checkType<List<AssistanceTeamUIController>>(l, 2, out assistanceTeamUICtrlList);
			drillUIController.m_luaExportHelper.m_assistanceTeamUICtrlList = assistanceTeamUICtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D48F RID: 119951 RVA: 0x0093C980 File Offset: 0x0093AB80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D490 RID: 119952 RVA: 0x0093C9D8 File Offset: 0x0093ABD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			drillUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D491 RID: 119953 RVA: 0x0093CA34 File Offset: 0x0093AC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D492 RID: 119954 RVA: 0x0093CA8C File Offset: 0x0093AC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			drillUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D493 RID: 119955 RVA: 0x0093CAE8 File Offset: 0x0093ACE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffPropArr(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_buffPropArr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D494 RID: 119956 RVA: 0x0093CB40 File Offset: 0x0093AD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffPropArr(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			int[] buffPropArr;
			LuaObject.checkArray<int>(l, 2, out buffPropArr);
			drillUIController.m_luaExportHelper.m_buffPropArr = buffPropArr;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D495 RID: 119957 RVA: 0x0093CB9C File Offset: 0x0093AD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D496 RID: 119958 RVA: 0x0093CBF4 File Offset: 0x0093ADF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			drillUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D497 RID: 119959 RVA: 0x0093CC50 File Offset: 0x0093AE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stopHeroAssistantsTaskCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.m_stopHeroAssistantsTaskCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D498 RID: 119960 RVA: 0x0093CCA8 File Offset: 0x0093AEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stopHeroAssistantsTaskCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			AssistanceTeamUIController stopHeroAssistantsTaskCtrl;
			LuaObject.checkType<AssistanceTeamUIController>(l, 2, out stopHeroAssistantsTaskCtrl);
			drillUIController.m_luaExportHelper.m_stopHeroAssistantsTaskCtrl = stopHeroAssistantsTaskCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D499 RID: 119961 RVA: 0x0093CD04 File Offset: 0x0093AF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_propStateCtrlList(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.propStateCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D49A RID: 119962 RVA: 0x0093CD5C File Offset: 0x0093AF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_propStateCtrlList(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			List<CommonUIStateController> propStateCtrlList;
			LuaObject.checkType<List<CommonUIStateController>>(l, 2, out propStateCtrlList);
			drillUIController.m_luaExportHelper.propStateCtrlList = propStateCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D49B RID: 119963 RVA: 0x0093CDB8 File Offset: 0x0093AFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_propGoList(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillUIController.m_luaExportHelper.propGoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D49C RID: 119964 RVA: 0x0093CE10 File Offset: 0x0093B010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_propGoList(IntPtr l)
	{
		int result;
		try
		{
			DrillUIController drillUIController = (DrillUIController)LuaObject.checkSelf(l);
			List<Text> propGoList;
			LuaObject.checkType<List<Text>>(l, 2, out propGoList);
			drillUIController.m_luaExportHelper.propGoList = propGoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D49D RID: 119965 RVA: 0x0093CE6C File Offset: 0x0093B06C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DrillUIController");
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.UpdateViewInDrill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.SetTeamTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.SetTrainingDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnCourseItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnRoomToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.SetPropertyAddition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.ResetAllPropertyState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.CalcSoldierPropertyModifityAddtion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.SetTeachingDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnAssistanceTeamTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnAssistanceTeamStopButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OpenStopTeachingPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.CloseStopTeachingPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnStopTeachingPanelConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnAssistanceTeamGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnSoldierInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnTrainingToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnTeachingToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnFastMaxButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.ClearDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callDele_EventOnManualButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__clearDele_EventOnManualButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callDele_EventOnTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__clearDele_EventOnTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callDele_EventOnAssistanceTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__clearDele_EventOnAssistanceTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callDele_EventOnAssistanceStopButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__clearDele_EventOnAssistanceStopButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__callDele_EventOnAssistanceGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.__clearDele_EventOnAssistanceGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache33);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache34, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache35, true);
		string name3 = "EventOnManualButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_EventOnManualButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache36, true);
		string name4 = "EventOnTrainingButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_EventOnTrainingButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache37, true);
		string name5 = "EventOnAssistanceTrainingButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_EventOnAssistanceTrainingButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache38, true);
		string name6 = "EventOnAssistanceStopButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_EventOnAssistanceStopButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache39, true);
		string name7 = "EventOnAssistanceGetRewardButtonClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_EventOnAssistanceGetRewardButtonClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3A, true);
		string name8 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_marginTransform);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3C, true);
		string name9 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_returnButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3E, true);
		string name10 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_helpButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache40, true);
		string name11 = "m_fastMaxButton";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_fastMaxButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_fastMaxButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache42, true);
		string name12 = "m_trainingStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache44, true);
		string name13 = "m_trainingPanelLeftToggleGroup";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelLeftToggleGroup);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelLeftToggleGroup);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache46, true);
		string name14 = "m_trainingPanelTitleInfoLvValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelTitleInfoLvValueText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelTitleInfoLvValueText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache48, true);
		string name15 = "m_trainingPanelTitleInfoExpValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelTitleInfoExpValueText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelTitleInfoExpValueText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4A, true);
		string name16 = "m_trainingPanelTitleInfoProgressBar";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelTitleInfoProgressBar);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelTitleInfoProgressBar);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4C, true);
		string name17 = "m_trainingPanelTrainingEventScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelTrainingEventScrollViewContent);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelTrainingEventScrollViewContent);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4E, true);
		string name18 = "m_trainingPanelTrainingButton";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelTrainingButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelTrainingButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache50, true);
		string name19 = "m_trainingPanelPropretyGroupHPAddStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupHPAddStateCtrl);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupHPAddStateCtrl);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache52, true);
		string name20 = "m_trainingPanelPropretyGroupHPAddValue";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupHPAddValue);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupHPAddValue);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache54, true);
		string name21 = "m_trainingPanelPropretyGroupAttackAddStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupAttackAddStateCtrl);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupAttackAddStateCtrl);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache56, true);
		string name22 = "m_trainingPanelPropretyGroupAttackAddValue";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupAttackAddValue);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupAttackAddValue);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache58, true);
		string name23 = "m_trainingPanelPropretyGroupDefenseAddStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupDefenseAddStateCtrl);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupDefenseAddStateCtrl);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5A, true);
		string name24 = "m_trainingPanelPropretyGroupDefenseAddValue";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupDefenseAddValue);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupDefenseAddValue);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5C, true);
		string name25 = "m_trainingPanelPropretyGroupMagicDFAddStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupMagicDFAddStateCtrl);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupMagicDFAddStateCtrl);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5E, true);
		string name26 = "m_trainingPanelPropretyGroupMagicDFAddValue";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupMagicDFAddValue);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupMagicDFAddValue);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache60, true);
		string name27 = "m_trainingPanelPropretyGroupHPPerStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupHPPerStateCtrl);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupHPPerStateCtrl);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache62, true);
		string name28 = "m_trainingPanelPropretyGroupHPPerValue";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupHPPerValue);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupHPPerValue);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache64, true);
		string name29 = "m_trainingPanelPropretyGroupAttackPerStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupAttackPerStateCtrl);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupAttackPerStateCtrl);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache66, true);
		string name30 = "m_trainingPanelPropretyGroupAttackPerValue";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupAttackPerValue);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupAttackPerValue);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache68, true);
		string name31 = "m_trainingPanelPropretyGroupDefensePerStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupDefensePerStateCtrl);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupDefensePerStateCtrl);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6A, true);
		string name32 = "m_trainingPanelPropretyGroupDefensePerValue";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupDefensePerValue);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupDefensePerValue);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6C, true);
		string name33 = "m_trainingPanelPropretyGroupMagicDFPerStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupMagicDFPerStateCtrl);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupMagicDFPerStateCtrl);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6E, true);
		string name34 = "m_trainingPanelPropretyGroupMagicDFPerValue";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingPanelPropretyGroupMagicDFPerValue);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingPanelPropretyGroupMagicDFPerValue);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache70, true);
		string name35 = "m_teachingStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingStateCtrl);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingStateCtrl);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache72, true);
		string name36 = "m_teachingChar";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingChar);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingChar);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache74, true);
		string name37 = "m_teachingDetailTeam1";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingDetailTeam1);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingDetailTeam1);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache76, true);
		string name38 = "m_teachingDetailTeam2";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingDetailTeam2);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingDetailTeam2);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache78, true);
		string name39 = "m_teachingDetailTeam3";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingDetailTeam3);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingDetailTeam3);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7A, true);
		string name40 = "m_teachingTodayRewardArmyIcon1";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingTodayRewardArmyIcon1);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingTodayRewardArmyIcon1);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7C, true);
		string name41 = "m_teachingTodayRewardArmyIcon2";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingTodayRewardArmyIcon2);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingTodayRewardArmyIcon2);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7E, true);
		string name42 = "m_trainingToggle";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_trainingToggle);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_trainingToggle);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache80, true);
		string name43 = "m_teachingToggle";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingToggle);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingToggle);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache82, true);
		string name44 = "m_teachingToggleClickRedMark";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingToggleClickRedMark);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingToggleClickRedMark);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache84, true);
		string name45 = "m_teachingToggleUnClickRedMark";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_teachingToggleUnClickRedMark);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_teachingToggleUnClickRedMark);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache86, true);
		string name46 = "m_soldierInfoButton";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_soldierInfoButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_soldierInfoButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache88, true);
		string name47 = "m_stopTeachingPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_stopTeachingPanelStateCtrl);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_stopTeachingPanelStateCtrl);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8A, true);
		string name48 = "m_stopTeachingPanelBackButton";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_stopTeachingPanelBackButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_stopTeachingPanelBackButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8C, true);
		string name49 = "m_stopTeachingPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_stopTeachingPanelConfirmButton);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_stopTeachingPanelConfirmButton);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8E, true);
		string name50 = "m_stopTeachingPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_stopTeachingPanelCancelButton);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_stopTeachingPanelCancelButton);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache90, true);
		string name51 = "m_curDrillState";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_curDrillState);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_curDrillState);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache92, true);
		string name52 = "m_curTrainingRoom";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_curTrainingRoom);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_curTrainingRoom);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache94, true);
		string name53 = "m_assistanceTeamUICtrlList";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_assistanceTeamUICtrlList);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_assistanceTeamUICtrlList);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache96, true);
		string name54 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_playerContext);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache98, true);
		string name55 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_configDataLoader);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9A, true);
		string name56 = "m_buffPropArr";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_buffPropArr);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_buffPropArr);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9C, true);
		string name57 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9E, true);
		string name58 = "m_stopHeroAssistantsTaskCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_m_stopHeroAssistantsTaskCtrl);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_m_stopHeroAssistantsTaskCtrl);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA0, true);
		string name59 = "propStateCtrlList";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_propStateCtrlList);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_propStateCtrlList);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA2, true);
		string name60 = "propGoList";
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.get_propGoList);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillUIController.set_propGoList);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_DrillUIController.<>f__mg$cacheA4, true);
		LuaObject.createTypeMetatable(l, null, typeof(DrillUIController), typeof(UIControllerBase));
	}

	// Token: 0x040135A2 RID: 79266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040135A3 RID: 79267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040135A4 RID: 79268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040135A5 RID: 79269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040135A6 RID: 79270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040135A7 RID: 79271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040135A8 RID: 79272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040135A9 RID: 79273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040135AA RID: 79274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040135AB RID: 79275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040135AC RID: 79276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040135AD RID: 79277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040135AE RID: 79278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040135AF RID: 79279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040135B0 RID: 79280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040135B1 RID: 79281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040135B2 RID: 79282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040135B3 RID: 79283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040135B4 RID: 79284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040135B5 RID: 79285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040135B6 RID: 79286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040135B7 RID: 79287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040135B8 RID: 79288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040135B9 RID: 79289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040135BA RID: 79290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040135BB RID: 79291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040135BC RID: 79292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040135BD RID: 79293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040135BE RID: 79294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040135BF RID: 79295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040135C0 RID: 79296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040135C1 RID: 79297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040135C2 RID: 79298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040135C3 RID: 79299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040135C4 RID: 79300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040135C5 RID: 79301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040135C6 RID: 79302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040135C7 RID: 79303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040135C8 RID: 79304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040135C9 RID: 79305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040135CA RID: 79306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040135CB RID: 79307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040135CC RID: 79308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040135CD RID: 79309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040135CE RID: 79310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040135CF RID: 79311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040135D0 RID: 79312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040135D1 RID: 79313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040135D2 RID: 79314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040135D3 RID: 79315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040135D4 RID: 79316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040135D5 RID: 79317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040135D6 RID: 79318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040135D7 RID: 79319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040135D8 RID: 79320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040135D9 RID: 79321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040135DA RID: 79322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040135DB RID: 79323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040135DC RID: 79324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040135DD RID: 79325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040135DE RID: 79326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040135DF RID: 79327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040135E0 RID: 79328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040135E1 RID: 79329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040135E2 RID: 79330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040135E3 RID: 79331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040135E4 RID: 79332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040135E5 RID: 79333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040135E6 RID: 79334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040135E7 RID: 79335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040135E8 RID: 79336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040135E9 RID: 79337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040135EA RID: 79338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040135EB RID: 79339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040135EC RID: 79340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040135ED RID: 79341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040135EE RID: 79342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040135EF RID: 79343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040135F0 RID: 79344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040135F1 RID: 79345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040135F2 RID: 79346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040135F3 RID: 79347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040135F4 RID: 79348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040135F5 RID: 79349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040135F6 RID: 79350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040135F7 RID: 79351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040135F8 RID: 79352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040135F9 RID: 79353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040135FA RID: 79354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040135FB RID: 79355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040135FC RID: 79356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040135FD RID: 79357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040135FE RID: 79358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040135FF RID: 79359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04013600 RID: 79360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013601 RID: 79361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04013602 RID: 79362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04013603 RID: 79363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013604 RID: 79364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013605 RID: 79365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013606 RID: 79366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013607 RID: 79367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013608 RID: 79368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013609 RID: 79369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401360A RID: 79370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401360B RID: 79371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401360C RID: 79372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401360D RID: 79373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401360E RID: 79374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401360F RID: 79375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04013610 RID: 79376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04013611 RID: 79377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04013612 RID: 79378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04013613 RID: 79379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04013614 RID: 79380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04013615 RID: 79381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04013616 RID: 79382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04013617 RID: 79383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04013618 RID: 79384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04013619 RID: 79385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401361A RID: 79386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401361B RID: 79387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401361C RID: 79388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401361D RID: 79389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401361E RID: 79390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401361F RID: 79391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04013620 RID: 79392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04013621 RID: 79393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04013622 RID: 79394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04013623 RID: 79395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04013624 RID: 79396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04013625 RID: 79397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04013626 RID: 79398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04013627 RID: 79399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04013628 RID: 79400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04013629 RID: 79401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401362A RID: 79402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401362B RID: 79403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401362C RID: 79404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401362D RID: 79405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401362E RID: 79406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401362F RID: 79407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04013630 RID: 79408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04013631 RID: 79409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04013632 RID: 79410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04013633 RID: 79411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04013634 RID: 79412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04013635 RID: 79413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04013636 RID: 79414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04013637 RID: 79415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04013638 RID: 79416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04013639 RID: 79417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0401363A RID: 79418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0401363B RID: 79419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0401363C RID: 79420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0401363D RID: 79421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0401363E RID: 79422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401363F RID: 79423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04013640 RID: 79424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04013641 RID: 79425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04013642 RID: 79426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04013643 RID: 79427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04013644 RID: 79428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04013645 RID: 79429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04013646 RID: 79430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;
}
