using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200141A RID: 5146
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DrillTrainingUIController : LuaObject
{
	// Token: 0x0601D2B1 RID: 119473 RVA: 0x0092ED74 File Offset: 0x0092CF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2B2 RID: 119474 RVA: 0x0092EDC0 File Offset: 0x0092CFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInDrillTraining(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			int courseId;
			LuaObject.checkType(l, 2, out courseId);
			int techId;
			LuaObject.checkType(l, 3, out techId);
			drillTrainingUIController.UpdateViewInDrillTraining(courseId, techId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2B3 RID: 119475 RVA: 0x0092EE24 File Offset: 0x0092D024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2B4 RID: 119476 RVA: 0x0092EE78 File Offset: 0x0092D078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowTechClickPanelByTechId(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			drillTrainingUIController.m_luaExportHelper.ShowTechClickPanelByTechId(techId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2B5 RID: 119477 RVA: 0x0092EED4 File Offset: 0x0092D0D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRoomCoachInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.SetRoomCoachInfoPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2B6 RID: 119478 RVA: 0x0092EF28 File Offset: 0x0092D128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCoursesListPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.SetCoursesListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2B7 RID: 119479 RVA: 0x0092EF7C File Offset: 0x0092D17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCourseItemClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CourseItemUIController ctrl;
			LuaObject.checkType<CourseItemUIController>(l, 2, out ctrl);
			drillTrainingUIController.m_luaExportHelper.OnCourseItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2B8 RID: 119480 RVA: 0x0092EFD8 File Offset: 0x0092D1D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.SetSkillPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2B9 RID: 119481 RVA: 0x0092F02C File Offset: 0x0092D22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTrainingSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			TrainingSkillItemUIController ctrl;
			LuaObject.checkType<TrainingSkillItemUIController>(l, 2, out ctrl);
			drillTrainingUIController.m_luaExportHelper.OnTrainingSkillItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2BA RID: 119482 RVA: 0x0092F088 File Offset: 0x0092D288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkillItemInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			TrainingSkillItemUIController skillItemInfoPanel;
			LuaObject.checkType<TrainingSkillItemUIController>(l, 2, out skillItemInfoPanel);
			drillTrainingUIController.m_luaExportHelper.SetSkillItemInfoPanel(skillItemInfoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2BB RID: 119483 RVA: 0x0092F0E4 File Offset: 0x0092D2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int id;
			LuaObject.checkType(l, 3, out id);
			int needCount;
			LuaObject.checkType(l, 4, out needCount);
			drillTrainingUIController.m_luaExportHelper.OnEvolutionMaterialClick(goodsType, id, needCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2BC RID: 119484 RVA: 0x0092F15C File Offset: 0x0092D35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierDetailPanel;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierDetailPanel);
			drillTrainingUIController.m_luaExportHelper.SetSoldierDetailPanel(soldierDetailPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2BD RID: 119485 RVA: 0x0092F1B8 File Offset: 0x0092D3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoPanelPromoteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnInfoPanelPromoteButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2BE RID: 119486 RVA: 0x0092F20C File Offset: 0x0092D40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowSoldierDetailButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnShowSoldierDetailButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2BF RID: 119487 RVA: 0x0092F260 File Offset: 0x0092D460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillItemInfoPanelBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnSkillItemInfoPanelBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C0 RID: 119488 RVA: 0x0092F2B4 File Offset: 0x0092D4B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnGoldAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C1 RID: 119489 RVA: 0x0092F308 File Offset: 0x0092D508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCrystalAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnCrystalAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C2 RID: 119490 RVA: 0x0092F35C File Offset: 0x0092D55C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSkillItemInfoPanelFastMaxButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnSkillItemInfoPanelFastMaxButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C3 RID: 119491 RVA: 0x0092F3B0 File Offset: 0x0092D5B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillItemInfoPanelFastLevelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnSkillItemInfoPanelFastLevelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C4 RID: 119492 RVA: 0x0092F404 File Offset: 0x0092D604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C5 RID: 119493 RVA: 0x0092F458 File Offset: 0x0092D658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			drillTrainingUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C6 RID: 119494 RVA: 0x0092F4C4 File Offset: 0x0092D6C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C7 RID: 119495 RVA: 0x0092F518 File Offset: 0x0092D718
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2C8 RID: 119496 RVA: 0x0092F56C File Offset: 0x0092D76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = drillTrainingUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D2C9 RID: 119497 RVA: 0x0092F614 File Offset: 0x0092D814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2CA RID: 119498 RVA: 0x0092F668 File Offset: 0x0092D868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			drillTrainingUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2CB RID: 119499 RVA: 0x0092F6D4 File Offset: 0x0092D8D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				drillTrainingUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DrillTrainingUIController drillTrainingUIController2 = (DrillTrainingUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				drillTrainingUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D2CC RID: 119500 RVA: 0x0092F7E4 File Offset: 0x0092D9E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillTrainingUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2CD RID: 119501 RVA: 0x0092F850 File Offset: 0x0092DA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillTrainingUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2CE RID: 119502 RVA: 0x0092F8BC File Offset: 0x0092DABC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillTrainingUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2CF RID: 119503 RVA: 0x0092F928 File Offset: 0x0092DB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillTrainingUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2D0 RID: 119504 RVA: 0x0092F994 File Offset: 0x0092DB94
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
				DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				drillTrainingUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DrillTrainingUIController drillTrainingUIController2 = (DrillTrainingUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				drillTrainingUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D2D1 RID: 119505 RVA: 0x0092FAA4 File Offset: 0x0092DCA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			string s = drillTrainingUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D2D2 RID: 119506 RVA: 0x0092FB00 File Offset: 0x0092DD00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2D3 RID: 119507 RVA: 0x0092FB54 File Offset: 0x0092DD54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2D4 RID: 119508 RVA: 0x0092FBA8 File Offset: 0x0092DDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__callDele_EventOnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2D5 RID: 119509 RVA: 0x0092FBFC File Offset: 0x0092DDFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__clearDele_EventOnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2D6 RID: 119510 RVA: 0x0092FC50 File Offset: 0x0092DE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__callDele_EventOnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2D7 RID: 119511 RVA: 0x0092FCA4 File Offset: 0x0092DEA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			drillTrainingUIController.m_luaExportHelper.__clearDele_EventOnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2D8 RID: 119512 RVA: 0x0092FCF8 File Offset: 0x0092DEF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnTechLevelup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			drillTrainingUIController.m_luaExportHelper.__callDele_EventOnTechLevelup(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2D9 RID: 119513 RVA: 0x0092FD64 File Offset: 0x0092DF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnTechLevelup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			drillTrainingUIController.m_luaExportHelper.__clearDele_EventOnTechLevelup(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2DA RID: 119514 RVA: 0x0092FDD0 File Offset: 0x0092DFD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			drillTrainingUIController.m_luaExportHelper.__callDele_EventOnEvolutionMaterialClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2DB RID: 119515 RVA: 0x0092FE48 File Offset: 0x0092E048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			drillTrainingUIController.m_luaExportHelper.__clearDele_EventOnEvolutionMaterialClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2DC RID: 119516 RVA: 0x0092FEC0 File Offset: 0x0092E0C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillTrainingUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					drillTrainingUIController.EventOnReturn -= value;
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

	// Token: 0x0601D2DD RID: 119517 RVA: 0x0092FF40 File Offset: 0x0092E140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillTrainingUIController.EventOnAddGold += value;
				}
				else if (num == 2)
				{
					drillTrainingUIController.EventOnAddGold -= value;
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

	// Token: 0x0601D2DE RID: 119518 RVA: 0x0092FFC0 File Offset: 0x0092E1C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillTrainingUIController.EventOnAddCrystal += value;
				}
				else if (num == 2)
				{
					drillTrainingUIController.EventOnAddCrystal -= value;
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

	// Token: 0x0601D2DF RID: 119519 RVA: 0x00930040 File Offset: 0x0092E240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTechLevelup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Action<int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillTrainingUIController.EventOnTechLevelup += value;
				}
				else if (num == 2)
				{
					drillTrainingUIController.EventOnTechLevelup -= value;
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

	// Token: 0x0601D2E0 RID: 119520 RVA: 0x009300C0 File Offset: 0x0092E2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillTrainingUIController.EventOnEvolutionMaterialClick += value;
				}
				else if (num == 2)
				{
					drillTrainingUIController.EventOnEvolutionMaterialClick -= value;
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

	// Token: 0x0601D2E1 RID: 119521 RVA: 0x00930140 File Offset: 0x0092E340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2E2 RID: 119522 RVA: 0x00930198 File Offset: 0x0092E398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			drillTrainingUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2E3 RID: 119523 RVA: 0x009301F4 File Offset: 0x0092E3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_crystalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2E4 RID: 119524 RVA: 0x0093024C File Offset: 0x0092E44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text crystalText;
			LuaObject.checkType<Text>(l, 2, out crystalText);
			drillTrainingUIController.m_luaExportHelper.m_crystalText = crystalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2E5 RID: 119525 RVA: 0x009302A8 File Offset: 0x0092E4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalAddButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_crystalAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2E6 RID: 119526 RVA: 0x00930300 File Offset: 0x0092E500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_crystalAddButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button crystalAddButton;
			LuaObject.checkType<Button>(l, 2, out crystalAddButton);
			drillTrainingUIController.m_luaExportHelper.m_crystalAddButton = crystalAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2E7 RID: 119527 RVA: 0x0093035C File Offset: 0x0092E55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_goldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2E8 RID: 119528 RVA: 0x009303B4 File Offset: 0x0092E5B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text goldText;
			LuaObject.checkType<Text>(l, 2, out goldText);
			drillTrainingUIController.m_luaExportHelper.m_goldText = goldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2E9 RID: 119529 RVA: 0x00930410 File Offset: 0x0092E610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_goldAddButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_goldAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2EA RID: 119530 RVA: 0x00930468 File Offset: 0x0092E668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldAddButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button goldAddButton;
			LuaObject.checkType<Button>(l, 2, out goldAddButton);
			drillTrainingUIController.m_luaExportHelper.m_goldAddButton = goldAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2EB RID: 119531 RVA: 0x009304C4 File Offset: 0x0092E6C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_trainingNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2EC RID: 119532 RVA: 0x0093051C File Offset: 0x0092E71C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text trainingNameText;
			LuaObject.checkType<Text>(l, 2, out trainingNameText);
			drillTrainingUIController.m_luaExportHelper.m_trainingNameText = trainingNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2ED RID: 119533 RVA: 0x00930578 File Offset: 0x0092E778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_roomInfoImageStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_roomInfoImageStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2EE RID: 119534 RVA: 0x009305D0 File Offset: 0x0092E7D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_roomInfoImageStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController roomInfoImageStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out roomInfoImageStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_roomInfoImageStateCtrl = roomInfoImageStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2EF RID: 119535 RVA: 0x0093062C File Offset: 0x0092E82C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_roomInfoLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_roomInfoLvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F0 RID: 119536 RVA: 0x00930684 File Offset: 0x0092E884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_roomInfoLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text roomInfoLvValueText;
			LuaObject.checkType<Text>(l, 2, out roomInfoLvValueText);
			drillTrainingUIController.m_luaExportHelper.m_roomInfoLvValueText = roomInfoLvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F1 RID: 119537 RVA: 0x009306E0 File Offset: 0x0092E8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roomInfoExpValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_roomInfoExpValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F2 RID: 119538 RVA: 0x00930738 File Offset: 0x0092E938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roomInfoExpValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text roomInfoExpValueText;
			LuaObject.checkType<Text>(l, 2, out roomInfoExpValueText);
			drillTrainingUIController.m_luaExportHelper.m_roomInfoExpValueText = roomInfoExpValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F3 RID: 119539 RVA: 0x00930794 File Offset: 0x0092E994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roomInfoProgressBar(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_roomInfoProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F4 RID: 119540 RVA: 0x009307EC File Offset: 0x0092E9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roomInfoProgressBar(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Image roomInfoProgressBar;
			LuaObject.checkType<Image>(l, 2, out roomInfoProgressBar);
			drillTrainingUIController.m_luaExportHelper.m_roomInfoProgressBar = roomInfoProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F5 RID: 119541 RVA: 0x00930848 File Offset: 0x0092EA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingCourseScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_trainingCourseScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F6 RID: 119542 RVA: 0x009308A0 File Offset: 0x0092EAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingCourseScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject trainingCourseScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out trainingCourseScrollViewContent);
			drillTrainingUIController.m_luaExportHelper.m_trainingCourseScrollViewContent = trainingCourseScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F7 RID: 119543 RVA: 0x009308FC File Offset: 0x0092EAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_skillPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F8 RID: 119544 RVA: 0x00930954 File Offset: 0x0092EB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject skillPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out skillPanelGameObject);
			drillTrainingUIController.m_luaExportHelper.m_skillPanelGameObject = skillPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2F9 RID: 119545 RVA: 0x009309B0 File Offset: 0x0092EBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_skillItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2FA RID: 119546 RVA: 0x00930A08 File Offset: 0x0092EC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject skillItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out skillItemPrefab);
			drillTrainingUIController.m_luaExportHelper.m_skillItemPrefab = skillItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2FB RID: 119547 RVA: 0x00930A64 File Offset: 0x0092EC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillItemInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2FC RID: 119548 RVA: 0x00930ABC File Offset: 0x0092ECBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillItemInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillItemInfoPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillItemInfoPanelStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelStateCtrl = skillItemInfoPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2FD RID: 119549 RVA: 0x00930B18 File Offset: 0x0092ED18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillItemInfoPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2FE RID: 119550 RVA: 0x00930B70 File Offset: 0x0092ED70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillItemInfoPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button skillItemInfoPanelBGButton;
			LuaObject.checkType<Button>(l, 2, out skillItemInfoPanelBGButton);
			drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelBGButton = skillItemInfoPanelBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2FF RID: 119551 RVA: 0x00930BCC File Offset: 0x0092EDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillItemInfoPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D300 RID: 119552 RVA: 0x00930C24 File Offset: 0x0092EE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillItemInfoPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button skillItemInfoPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out skillItemInfoPanelCloseButton);
			drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelCloseButton = skillItemInfoPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D301 RID: 119553 RVA: 0x00930C80 File Offset: 0x0092EE80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_skillItemInfoPanelFastMaxButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelFastMaxButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D302 RID: 119554 RVA: 0x00930CD8 File Offset: 0x0092EED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillItemInfoPanelFastMaxButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button skillItemInfoPanelFastMaxButton;
			LuaObject.checkType<Button>(l, 2, out skillItemInfoPanelFastMaxButton);
			drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelFastMaxButton = skillItemInfoPanelFastMaxButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D303 RID: 119555 RVA: 0x00930D34 File Offset: 0x0092EF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillItemInfoPanelFastLevelButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelFastLevelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D304 RID: 119556 RVA: 0x00930D8C File Offset: 0x0092EF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillItemInfoPanelFastLevelButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button skillItemInfoPanelFastLevelButton;
			LuaObject.checkType<Button>(l, 2, out skillItemInfoPanelFastLevelButton);
			drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelFastLevelButton = skillItemInfoPanelFastLevelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D305 RID: 119557 RVA: 0x00930DE8 File Offset: 0x0092EFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillItemInfoPanelFastLevelInputField(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelFastLevelInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D306 RID: 119558 RVA: 0x00930E40 File Offset: 0x0092F040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillItemInfoPanelFastLevelInputField(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			InputField skillItemInfoPanelFastLevelInputField;
			LuaObject.checkType<InputField>(l, 2, out skillItemInfoPanelFastLevelInputField);
			drillTrainingUIController.m_luaExportHelper.m_skillItemInfoPanelFastLevelInputField = skillItemInfoPanelFastLevelInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D307 RID: 119559 RVA: 0x00930E9C File Offset: 0x0092F09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D308 RID: 119560 RVA: 0x00930EF4 File Offset: 0x0092F0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject soldierDetailPanel;
			LuaObject.checkType<GameObject>(l, 2, out soldierDetailPanel);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanel = soldierDetailPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D309 RID: 119561 RVA: 0x00930F50 File Offset: 0x0092F150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D30A RID: 119562 RVA: 0x00930FA8 File Offset: 0x0092F1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierDetailPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierDetailPanelStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelStateCtrl = soldierDetailPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D30B RID: 119563 RVA: 0x00931004 File Offset: 0x0092F204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierDetailPanelSoldierTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelSoldierTypeIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D30C RID: 119564 RVA: 0x0093105C File Offset: 0x0092F25C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDetailPanelSoldierTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Image soldierDetailPanelSoldierTypeIcon;
			LuaObject.checkType<Image>(l, 2, out soldierDetailPanelSoldierTypeIcon);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelSoldierTypeIcon = soldierDetailPanelSoldierTypeIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D30D RID: 119565 RVA: 0x009310B8 File Offset: 0x0092F2B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierDetailPanelSoldierQualityIcon(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelSoldierQualityIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D30E RID: 119566 RVA: 0x00931110 File Offset: 0x0092F310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelSoldierQualityIcon(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Image soldierDetailPanelSoldierQualityIcon;
			LuaObject.checkType<Image>(l, 2, out soldierDetailPanelSoldierQualityIcon);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelSoldierQualityIcon = soldierDetailPanelSoldierQualityIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D30F RID: 119567 RVA: 0x0093116C File Offset: 0x0092F36C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierDetailPanelSoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelSoldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D310 RID: 119568 RVA: 0x009311C4 File Offset: 0x0092F3C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDetailPanelSoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelSoldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelSoldierNameText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelSoldierNameText = soldierDetailPanelSoldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D311 RID: 119569 RVA: 0x00931220 File Offset: 0x0092F420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupHPValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D312 RID: 119570 RVA: 0x00931278 File Offset: 0x0092F478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelPorpretyGroupHPValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupHPValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupHPValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupHPValueText = soldierDetailPanelPorpretyGroupHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D313 RID: 119571 RVA: 0x009312D4 File Offset: 0x0092F4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupATValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D314 RID: 119572 RVA: 0x0093132C File Offset: 0x0092F52C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDetailPanelPorpretyGroupATValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupATValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupATValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupATValueText = soldierDetailPanelPorpretyGroupATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D315 RID: 119573 RVA: 0x00931388 File Offset: 0x0092F588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupDFValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D316 RID: 119574 RVA: 0x009313E0 File Offset: 0x0092F5E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDetailPanelPorpretyGroupDFValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupDFValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupDFValueText = soldierDetailPanelPorpretyGroupDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D317 RID: 119575 RVA: 0x0093143C File Offset: 0x0092F63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D318 RID: 119576 RVA: 0x00931494 File Offset: 0x0092F694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelPorpretyGroupMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupMagicDFValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupMagicDFValueText = soldierDetailPanelPorpretyGroupMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D319 RID: 119577 RVA: 0x009314F0 File Offset: 0x0092F6F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierDetailPanelPorpretyGroupRangeValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupRangeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D31A RID: 119578 RVA: 0x00931548 File Offset: 0x0092F748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelPorpretyGroupRangeValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupRangeValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupRangeValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupRangeValueText = soldierDetailPanelPorpretyGroupRangeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D31B RID: 119579 RVA: 0x009315A4 File Offset: 0x0092F7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupMoveValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupMoveValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D31C RID: 119580 RVA: 0x009315FC File Offset: 0x0092F7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelPorpretyGroupMoveValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupMoveValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupMoveValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupMoveValueText = soldierDetailPanelPorpretyGroupMoveValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D31D RID: 119581 RVA: 0x00931658 File Offset: 0x0092F858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupRestrainValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupRestrainValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D31E RID: 119582 RVA: 0x009316B0 File Offset: 0x0092F8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelPorpretyGroupRestrainValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupRestrainValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupRestrainValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupRestrainValueText = soldierDetailPanelPorpretyGroupRestrainValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D31F RID: 119583 RVA: 0x0093170C File Offset: 0x0092F90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupWeakValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupWeakValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D320 RID: 119584 RVA: 0x00931764 File Offset: 0x0092F964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelPorpretyGroupWeakValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupWeakValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupWeakValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupWeakValueText = soldierDetailPanelPorpretyGroupWeakValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D321 RID: 119585 RVA: 0x009317C0 File Offset: 0x0092F9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupTypeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupTypeStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D322 RID: 119586 RVA: 0x00931818 File Offset: 0x0092FA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelPorpretyGroupTypeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierDetailPanelPorpretyGroupTypeStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierDetailPanelPorpretyGroupTypeStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupTypeStateCtrl = soldierDetailPanelPorpretyGroupTypeStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D323 RID: 119587 RVA: 0x00931874 File Offset: 0x0092FA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelPorpretyGroupDescText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D324 RID: 119588 RVA: 0x009318CC File Offset: 0x0092FACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDetailPanelPorpretyGroupDescText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierDetailPanelPorpretyGroupDescText;
			LuaObject.checkType<Text>(l, 2, out soldierDetailPanelPorpretyGroupDescText);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelPorpretyGroupDescText = soldierDetailPanelPorpretyGroupDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D325 RID: 119589 RVA: 0x00931928 File Offset: 0x0092FB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelHeroListStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelHeroListStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D326 RID: 119590 RVA: 0x00931980 File Offset: 0x0092FB80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDetailPanelHeroListStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierDetailPanelHeroListStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierDetailPanelHeroListStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelHeroListStateCtrl = soldierDetailPanelHeroListStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D327 RID: 119591 RVA: 0x009319DC File Offset: 0x0092FBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelHeroListContent(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelHeroListContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D328 RID: 119592 RVA: 0x00931A34 File Offset: 0x0092FC34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDetailPanelHeroListContent(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject soldierDetailPanelHeroListContent;
			LuaObject.checkType<GameObject>(l, 2, out soldierDetailPanelHeroListContent);
			drillTrainingUIController.m_luaExportHelper.m_soldierDetailPanelHeroListContent = soldierDetailPanelHeroListContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D329 RID: 119593 RVA: 0x00931A90 File Offset: 0x0092FC90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierAndSkillInfoSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D32A RID: 119594 RVA: 0x00931AE8 File Offset: 0x0092FCE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierAndSkillInfoSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Image soldierAndSkillInfoSkillIconImage;
			LuaObject.checkType<Image>(l, 2, out soldierAndSkillInfoSkillIconImage);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSkillIconImage = soldierAndSkillInfoSkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D32B RID: 119595 RVA: 0x00931B44 File Offset: 0x0092FD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D32C RID: 119596 RVA: 0x00931B9C File Offset: 0x0092FD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoSkillNameText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoSkillNameText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSkillNameText = soldierAndSkillInfoSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D32D RID: 119597 RVA: 0x00931BF8 File Offset: 0x0092FDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoSoldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSoldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D32E RID: 119598 RVA: 0x00931C50 File Offset: 0x0092FE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoSoldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject soldierAndSkillInfoSoldierGraphic;
			LuaObject.checkType<GameObject>(l, 2, out soldierAndSkillInfoSoldierGraphic);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSoldierGraphic = soldierAndSkillInfoSoldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D32F RID: 119599 RVA: 0x00931CAC File Offset: 0x0092FEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoSoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSoldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D330 RID: 119600 RVA: 0x00931D04 File Offset: 0x0092FF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoSoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoSoldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoSoldierNameText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSoldierNameText = soldierAndSkillInfoSoldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D331 RID: 119601 RVA: 0x00931D60 File Offset: 0x0092FF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoSkillUpdateEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSkillUpdateEffectGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D332 RID: 119602 RVA: 0x00931DB8 File Offset: 0x0092FFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoSkillUpdateEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject soldierAndSkillInfoSkillUpdateEffectGroup;
			LuaObject.checkType<GameObject>(l, 2, out soldierAndSkillInfoSkillUpdateEffectGroup);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoSkillUpdateEffectGroup = soldierAndSkillInfoSkillUpdateEffectGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D333 RID: 119603 RVA: 0x00931E14 File Offset: 0x00930014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D334 RID: 119604 RVA: 0x00931E6C File Offset: 0x0093006C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierAndSkillInfoPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierAndSkillInfoPanelStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelStateCtrl = soldierAndSkillInfoPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D335 RID: 119605 RVA: 0x00931EC8 File Offset: 0x009300C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelWatchDetailButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelWatchDetailButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D336 RID: 119606 RVA: 0x00931F20 File Offset: 0x00930120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelWatchDetailButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button soldierAndSkillInfoPanelWatchDetailButton;
			LuaObject.checkType<Button>(l, 2, out soldierAndSkillInfoPanelWatchDetailButton);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelWatchDetailButton = soldierAndSkillInfoPanelWatchDetailButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D337 RID: 119607 RVA: 0x00931F7C File Offset: 0x0093017C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoPanelDetailStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_infoPanelDetailStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D338 RID: 119608 RVA: 0x00931FD4 File Offset: 0x009301D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoPanelDetailStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController infoPanelDetailStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out infoPanelDetailStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_infoPanelDetailStateCtrl = infoPanelDetailStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D339 RID: 119609 RVA: 0x00932030 File Offset: 0x00930230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelNowLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelNowLvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D33A RID: 119610 RVA: 0x00932088 File Offset: 0x00930288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelNowLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoPanelNowLvValueText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoPanelNowLvValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelNowLvValueText = soldierAndSkillInfoPanelNowLvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D33B RID: 119611 RVA: 0x009320E4 File Offset: 0x009302E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierAndSkillInfoPanelNowEffectText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelNowEffectText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D33C RID: 119612 RVA: 0x0093213C File Offset: 0x0093033C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelNowEffectText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoPanelNowEffectText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoPanelNowEffectText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelNowEffectText = soldierAndSkillInfoPanelNowEffectText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D33D RID: 119613 RVA: 0x00932198 File Offset: 0x00930398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelIntensifyLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelIntensifyLvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D33E RID: 119614 RVA: 0x009321F0 File Offset: 0x009303F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelIntensifyLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoPanelIntensifyLvValueText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoPanelIntensifyLvValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelIntensifyLvValueText = soldierAndSkillInfoPanelIntensifyLvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D33F RID: 119615 RVA: 0x0093224C File Offset: 0x0093044C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelIntensifyNowEffectText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelIntensifyNowEffectText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D340 RID: 119616 RVA: 0x009322A4 File Offset: 0x009304A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelIntensifyNowEffectText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoPanelIntensifyNowEffectText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoPanelIntensifyNowEffectText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelIntensifyNowEffectText = soldierAndSkillInfoPanelIntensifyNowEffectText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D341 RID: 119617 RVA: 0x00932300 File Offset: 0x00930500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelAfterIntensifyLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelAfterIntensifyLvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D342 RID: 119618 RVA: 0x00932358 File Offset: 0x00930558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelAfterIntensifyLvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoPanelAfterIntensifyLvValueText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoPanelAfterIntensifyLvValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelAfterIntensifyLvValueText = soldierAndSkillInfoPanelAfterIntensifyLvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D343 RID: 119619 RVA: 0x009323B4 File Offset: 0x009305B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelAfterIntensifyEffectText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelAfterIntensifyEffectText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D344 RID: 119620 RVA: 0x0093240C File Offset: 0x0093060C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelAfterIntensifyEffectText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoPanelAfterIntensifyEffectText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoPanelAfterIntensifyEffectText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelAfterIntensifyEffectText = soldierAndSkillInfoPanelAfterIntensifyEffectText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D345 RID: 119621 RVA: 0x00932468 File Offset: 0x00930668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelItemGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelItemGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D346 RID: 119622 RVA: 0x009324C0 File Offset: 0x009306C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelItemGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject soldierAndSkillInfoPanelItemGroup;
			LuaObject.checkType<GameObject>(l, 2, out soldierAndSkillInfoPanelItemGroup);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelItemGroup = soldierAndSkillInfoPanelItemGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D347 RID: 119623 RVA: 0x0093251C File Offset: 0x0093071C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelPromoteButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelPromoteButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D348 RID: 119624 RVA: 0x00932574 File Offset: 0x00930774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelPromoteButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Button soldierAndSkillInfoPanelPromoteButton;
			LuaObject.checkType<Button>(l, 2, out soldierAndSkillInfoPanelPromoteButton);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelPromoteButton = soldierAndSkillInfoPanelPromoteButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D349 RID: 119625 RVA: 0x009325D0 File Offset: 0x009307D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelPromoteButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelPromoteButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D34A RID: 119626 RVA: 0x00932628 File Offset: 0x00930828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelPromoteButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierAndSkillInfoPanelPromoteButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierAndSkillInfoPanelPromoteButtonStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelPromoteButtonStateCtrl = soldierAndSkillInfoPanelPromoteButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D34B RID: 119627 RVA: 0x00932684 File Offset: 0x00930884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelGoldenValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelGoldenValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D34C RID: 119628 RVA: 0x009326DC File Offset: 0x009308DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelGoldenValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			Text soldierAndSkillInfoPanelGoldenValueText;
			LuaObject.checkType<Text>(l, 2, out soldierAndSkillInfoPanelGoldenValueText);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelGoldenValueText = soldierAndSkillInfoPanelGoldenValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D34D RID: 119629 RVA: 0x00932738 File Offset: 0x00930938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelGoldenStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelGoldenStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D34E RID: 119630 RVA: 0x00932790 File Offset: 0x00930990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelGoldenStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierAndSkillInfoPanelGoldenStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierAndSkillInfoPanelGoldenStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelGoldenStateCtrl = soldierAndSkillInfoPanelGoldenStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D34F RID: 119631 RVA: 0x009327EC File Offset: 0x009309EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAndSkillInfoPanelConditionGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelConditionGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D350 RID: 119632 RVA: 0x00932844 File Offset: 0x00930A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAndSkillInfoPanelConditionGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			GameObject soldierAndSkillInfoPanelConditionGroup;
			LuaObject.checkType<GameObject>(l, 2, out soldierAndSkillInfoPanelConditionGroup);
			drillTrainingUIController.m_luaExportHelper.m_soldierAndSkillInfoPanelConditionGroup = soldierAndSkillInfoPanelConditionGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D351 RID: 119633 RVA: 0x009328A0 File Offset: 0x00930AA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enhanceSuccessEffectPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_enhanceSuccessEffectPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D352 RID: 119634 RVA: 0x009328F8 File Offset: 0x00930AF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enhanceSuccessEffectPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CommonUIStateController enhanceSuccessEffectPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out enhanceSuccessEffectPanelStateCtrl);
			drillTrainingUIController.m_luaExportHelper.m_enhanceSuccessEffectPanelStateCtrl = enhanceSuccessEffectPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D353 RID: 119635 RVA: 0x00932954 File Offset: 0x00930B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_isFirstIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D354 RID: 119636 RVA: 0x009329AC File Offset: 0x00930BAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			bool isFirstIn;
			LuaObject.checkType(l, 2, out isFirstIn);
			drillTrainingUIController.m_luaExportHelper.m_isFirstIn = isFirstIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D355 RID: 119637 RVA: 0x00932A08 File Offset: 0x00930C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_soldierInfoGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D356 RID: 119638 RVA: 0x00932A60 File Offset: 0x00930C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierInfoGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierInfoGraphic);
			drillTrainingUIController.m_luaExportHelper.m_soldierInfoGraphic = soldierInfoGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D357 RID: 119639 RVA: 0x00932ABC File Offset: 0x00930CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D358 RID: 119640 RVA: 0x00932B14 File Offset: 0x00930D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			drillTrainingUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D359 RID: 119641 RVA: 0x00932B70 File Offset: 0x00930D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D35A RID: 119642 RVA: 0x00932BC8 File Offset: 0x00930DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			drillTrainingUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D35B RID: 119643 RVA: 0x00932C24 File Offset: 0x00930E24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curTrainingRoom(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_curTrainingRoom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D35C RID: 119644 RVA: 0x00932C7C File Offset: 0x00930E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curTrainingRoom(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			TrainingRoom curTrainingRoom;
			LuaObject.checkType<TrainingRoom>(l, 2, out curTrainingRoom);
			drillTrainingUIController.m_luaExportHelper.m_curTrainingRoom = curTrainingRoom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D35D RID: 119645 RVA: 0x00932CD8 File Offset: 0x00930ED8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curTrainingCourse(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_curTrainingCourse);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D35E RID: 119646 RVA: 0x00932D30 File Offset: 0x00930F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curTrainingCourse(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			TrainingCourse curTrainingCourse;
			LuaObject.checkType<TrainingCourse>(l, 2, out curTrainingCourse);
			drillTrainingUIController.m_luaExportHelper.m_curTrainingCourse = curTrainingCourse;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D35F RID: 119647 RVA: 0x00932D8C File Offset: 0x00930F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curTrainingSkillItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_curTrainingSkillItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D360 RID: 119648 RVA: 0x00932DE4 File Offset: 0x00930FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curTrainingSkillItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			TrainingSkillItemUIController curTrainingSkillItemCtrl;
			LuaObject.checkType<TrainingSkillItemUIController>(l, 2, out curTrainingSkillItemCtrl);
			drillTrainingUIController.m_luaExportHelper.m_curTrainingSkillItemCtrl = curTrainingSkillItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D361 RID: 119649 RVA: 0x00932E40 File Offset: 0x00931040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastCourseItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_lastCourseItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D362 RID: 119650 RVA: 0x00932E98 File Offset: 0x00931098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastCourseItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			CourseItemUIController lastCourseItemCtrl;
			LuaObject.checkType<CourseItemUIController>(l, 2, out lastCourseItemCtrl);
			drillTrainingUIController.m_luaExportHelper.m_lastCourseItemCtrl = lastCourseItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D363 RID: 119651 RVA: 0x00932EF4 File Offset: 0x009310F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingSkillItemUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTrainingUIController.m_luaExportHelper.m_trainingSkillItemUICtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D364 RID: 119652 RVA: 0x00932F4C File Offset: 0x0093114C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingSkillItemUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			DrillTrainingUIController drillTrainingUIController = (DrillTrainingUIController)LuaObject.checkSelf(l);
			List<TrainingSkillItemUIController> trainingSkillItemUICtrlList;
			LuaObject.checkType<List<TrainingSkillItemUIController>>(l, 2, out trainingSkillItemUICtrlList);
			drillTrainingUIController.m_luaExportHelper.m_trainingSkillItemUICtrlList = trainingSkillItemUICtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D365 RID: 119653 RVA: 0x00932FA8 File Offset: 0x009311A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DrillTrainingUIController");
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.UpdateViewInDrillTraining);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.ShowTechClickPanelByTechId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.SetRoomCoachInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.SetCoursesListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnCourseItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.SetSkillPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnTrainingSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.SetSkillItemInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.SetSoldierDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnInfoPanelPromoteButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnShowSoldierDetailButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnSkillItemInfoPanelBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnCrystalAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnSkillItemInfoPanelFastMaxButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnSkillItemInfoPanelFastLevelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callDele_EventOnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__clearDele_EventOnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callDele_EventOnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__clearDele_EventOnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callDele_EventOnTechLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__clearDele_EventOnTechLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__callDele_EventOnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.__clearDele_EventOnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2A);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2B, true);
		string name2 = "EventOnAddGold";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_EventOnAddGold);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2C, true);
		string name3 = "EventOnAddCrystal";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_EventOnAddCrystal);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2D, true);
		string name4 = "EventOnTechLevelup";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_EventOnTechLevelup);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2E, true);
		string name5 = "EventOnEvolutionMaterialClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_EventOnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache2F, true);
		string name6 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_returnButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache31, true);
		string name7 = "m_crystalText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_crystalText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_crystalText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache33, true);
		string name8 = "m_crystalAddButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_crystalAddButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_crystalAddButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache35, true);
		string name9 = "m_goldText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_goldText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_goldText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache37, true);
		string name10 = "m_goldAddButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_goldAddButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_goldAddButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache39, true);
		string name11 = "m_trainingNameText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_trainingNameText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_trainingNameText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3B, true);
		string name12 = "m_roomInfoImageStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_roomInfoImageStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_roomInfoImageStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3D, true);
		string name13 = "m_roomInfoLvValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_roomInfoLvValueText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_roomInfoLvValueText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache3F, true);
		string name14 = "m_roomInfoExpValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_roomInfoExpValueText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_roomInfoExpValueText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache41, true);
		string name15 = "m_roomInfoProgressBar";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_roomInfoProgressBar);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_roomInfoProgressBar);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache43, true);
		string name16 = "m_trainingCourseScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_trainingCourseScrollViewContent);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_trainingCourseScrollViewContent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache45, true);
		string name17 = "m_skillPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_skillPanelGameObject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_skillPanelGameObject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache47, true);
		string name18 = "m_skillItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_skillItemPrefab);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_skillItemPrefab);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache49, true);
		string name19 = "m_skillItemInfoPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_skillItemInfoPanelStateCtrl);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_skillItemInfoPanelStateCtrl);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4B, true);
		string name20 = "m_skillItemInfoPanelBGButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_skillItemInfoPanelBGButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_skillItemInfoPanelBGButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4D, true);
		string name21 = "m_skillItemInfoPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_skillItemInfoPanelCloseButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_skillItemInfoPanelCloseButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache4F, true);
		string name22 = "m_skillItemInfoPanelFastMaxButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_skillItemInfoPanelFastMaxButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_skillItemInfoPanelFastMaxButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache51, true);
		string name23 = "m_skillItemInfoPanelFastLevelButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_skillItemInfoPanelFastLevelButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_skillItemInfoPanelFastLevelButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache53, true);
		string name24 = "m_skillItemInfoPanelFastLevelInputField";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_skillItemInfoPanelFastLevelInputField);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_skillItemInfoPanelFastLevelInputField);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache55, true);
		string name25 = "m_soldierDetailPanel";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanel);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanel);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache57, true);
		string name26 = "m_soldierDetailPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelStateCtrl);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelStateCtrl);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache59, true);
		string name27 = "m_soldierDetailPanelSoldierTypeIcon";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelSoldierTypeIcon);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelSoldierTypeIcon);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5B, true);
		string name28 = "m_soldierDetailPanelSoldierQualityIcon";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelSoldierQualityIcon);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelSoldierQualityIcon);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5D, true);
		string name29 = "m_soldierDetailPanelSoldierNameText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelSoldierNameText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelSoldierNameText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache5F, true);
		string name30 = "m_soldierDetailPanelPorpretyGroupHPValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupHPValueText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupHPValueText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache61, true);
		string name31 = "m_soldierDetailPanelPorpretyGroupATValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupATValueText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupATValueText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache63, true);
		string name32 = "m_soldierDetailPanelPorpretyGroupDFValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupDFValueText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupDFValueText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache65, true);
		string name33 = "m_soldierDetailPanelPorpretyGroupMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupMagicDFValueText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupMagicDFValueText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache67, true);
		string name34 = "m_soldierDetailPanelPorpretyGroupRangeValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupRangeValueText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupRangeValueText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache69, true);
		string name35 = "m_soldierDetailPanelPorpretyGroupMoveValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupMoveValueText);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupMoveValueText);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6B, true);
		string name36 = "m_soldierDetailPanelPorpretyGroupRestrainValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupRestrainValueText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupRestrainValueText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6D, true);
		string name37 = "m_soldierDetailPanelPorpretyGroupWeakValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupWeakValueText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupWeakValueText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache6F, true);
		string name38 = "m_soldierDetailPanelPorpretyGroupTypeStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupTypeStateCtrl);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupTypeStateCtrl);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache71, true);
		string name39 = "m_soldierDetailPanelPorpretyGroupDescText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelPorpretyGroupDescText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelPorpretyGroupDescText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache73, true);
		string name40 = "m_soldierDetailPanelHeroListStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelHeroListStateCtrl);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelHeroListStateCtrl);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache75, true);
		string name41 = "m_soldierDetailPanelHeroListContent";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierDetailPanelHeroListContent);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierDetailPanelHeroListContent);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache77, true);
		string name42 = "m_soldierAndSkillInfoSkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoSkillIconImage);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoSkillIconImage);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache79, true);
		string name43 = "m_soldierAndSkillInfoSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoSkillNameText);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoSkillNameText);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7B, true);
		string name44 = "m_soldierAndSkillInfoSoldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoSoldierGraphic);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoSoldierGraphic);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7D, true);
		string name45 = "m_soldierAndSkillInfoSoldierNameText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoSoldierNameText);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoSoldierNameText);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache7F, true);
		string name46 = "m_soldierAndSkillInfoSkillUpdateEffectGroup";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoSkillUpdateEffectGroup);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoSkillUpdateEffectGroup);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache81, true);
		string name47 = "m_soldierAndSkillInfoPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelStateCtrl);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelStateCtrl);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache83, true);
		string name48 = "m_soldierAndSkillInfoPanelWatchDetailButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelWatchDetailButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelWatchDetailButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache85, true);
		string name49 = "m_infoPanelDetailStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_infoPanelDetailStateCtrl);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_infoPanelDetailStateCtrl);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache87, true);
		string name50 = "m_soldierAndSkillInfoPanelNowLvValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelNowLvValueText);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelNowLvValueText);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache89, true);
		string name51 = "m_soldierAndSkillInfoPanelNowEffectText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelNowEffectText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelNowEffectText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8B, true);
		string name52 = "m_soldierAndSkillInfoPanelIntensifyLvValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelIntensifyLvValueText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelIntensifyLvValueText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8D, true);
		string name53 = "m_soldierAndSkillInfoPanelIntensifyNowEffectText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelIntensifyNowEffectText);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelIntensifyNowEffectText);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache8F, true);
		string name54 = "m_soldierAndSkillInfoPanelAfterIntensifyLvValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelAfterIntensifyLvValueText);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelAfterIntensifyLvValueText);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache91, true);
		string name55 = "m_soldierAndSkillInfoPanelAfterIntensifyEffectText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelAfterIntensifyEffectText);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelAfterIntensifyEffectText);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache93, true);
		string name56 = "m_soldierAndSkillInfoPanelItemGroup";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelItemGroup);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelItemGroup);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache95, true);
		string name57 = "m_soldierAndSkillInfoPanelPromoteButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelPromoteButton);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelPromoteButton);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache97, true);
		string name58 = "m_soldierAndSkillInfoPanelPromoteButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelPromoteButtonStateCtrl);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelPromoteButtonStateCtrl);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache99, true);
		string name59 = "m_soldierAndSkillInfoPanelGoldenValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelGoldenValueText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelGoldenValueText);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9B, true);
		string name60 = "m_soldierAndSkillInfoPanelGoldenStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelGoldenStateCtrl);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelGoldenStateCtrl);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9D, true);
		string name61 = "m_soldierAndSkillInfoPanelConditionGroup";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierAndSkillInfoPanelConditionGroup);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierAndSkillInfoPanelConditionGroup);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cache9F, true);
		string name62 = "m_enhanceSuccessEffectPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_enhanceSuccessEffectPanelStateCtrl);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_enhanceSuccessEffectPanelStateCtrl);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA1, true);
		string name63 = "m_isFirstIn";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_isFirstIn);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_isFirstIn);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA3, true);
		string name64 = "m_soldierInfoGraphic";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_soldierInfoGraphic);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_soldierInfoGraphic);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA5, true);
		string name65 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_playerContext);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA7, true);
		string name66 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_configDataLoader);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheA9, true);
		string name67 = "m_curTrainingRoom";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_curTrainingRoom);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_curTrainingRoom);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAB, true);
		string name68 = "m_curTrainingCourse";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_curTrainingCourse);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_curTrainingCourse);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAD, true);
		string name69 = "m_curTrainingSkillItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_curTrainingSkillItemCtrl);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_curTrainingSkillItemCtrl);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheAF, true);
		string name70 = "m_lastCourseItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_lastCourseItemCtrl);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_lastCourseItemCtrl);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB1, true);
		string name71 = "m_trainingSkillItemUICtrlList";
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.get_m_trainingSkillItemUICtrlList);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.set_m_trainingSkillItemUICtrlList);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.<>f__mg$cacheB3, true);
		LuaObject.createTypeMetatable(l, null, typeof(DrillTrainingUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401345F RID: 78943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013460 RID: 78944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013461 RID: 78945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013462 RID: 78946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013463 RID: 78947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013464 RID: 78948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013465 RID: 78949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013466 RID: 78950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013467 RID: 78951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013468 RID: 78952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013469 RID: 78953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401346A RID: 78954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401346B RID: 78955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401346C RID: 78956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401346D RID: 78957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401346E RID: 78958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401346F RID: 78959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013470 RID: 78960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013471 RID: 78961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013472 RID: 78962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013473 RID: 78963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013474 RID: 78964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013475 RID: 78965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013476 RID: 78966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013477 RID: 78967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013478 RID: 78968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013479 RID: 78969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401347A RID: 78970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401347B RID: 78971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401347C RID: 78972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401347D RID: 78973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401347E RID: 78974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401347F RID: 78975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013480 RID: 78976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013481 RID: 78977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013482 RID: 78978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013483 RID: 78979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013484 RID: 78980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013485 RID: 78981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013486 RID: 78982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013487 RID: 78983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013488 RID: 78984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013489 RID: 78985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401348A RID: 78986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401348B RID: 78987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401348C RID: 78988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401348D RID: 78989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401348E RID: 78990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401348F RID: 78991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013490 RID: 78992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013491 RID: 78993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013492 RID: 78994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013493 RID: 78995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013494 RID: 78996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013495 RID: 78997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013496 RID: 78998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013497 RID: 78999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013498 RID: 79000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013499 RID: 79001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401349A RID: 79002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401349B RID: 79003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401349C RID: 79004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401349D RID: 79005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401349E RID: 79006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401349F RID: 79007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040134A0 RID: 79008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040134A1 RID: 79009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040134A2 RID: 79010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040134A3 RID: 79011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040134A4 RID: 79012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040134A5 RID: 79013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040134A6 RID: 79014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040134A7 RID: 79015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040134A8 RID: 79016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040134A9 RID: 79017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040134AA RID: 79018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040134AB RID: 79019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040134AC RID: 79020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040134AD RID: 79021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040134AE RID: 79022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040134AF RID: 79023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040134B0 RID: 79024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040134B1 RID: 79025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040134B2 RID: 79026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040134B3 RID: 79027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040134B4 RID: 79028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040134B5 RID: 79029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040134B6 RID: 79030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040134B7 RID: 79031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040134B8 RID: 79032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040134B9 RID: 79033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040134BA RID: 79034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040134BB RID: 79035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040134BC RID: 79036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040134BD RID: 79037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040134BE RID: 79038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040134BF RID: 79039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040134C0 RID: 79040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040134C1 RID: 79041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040134C2 RID: 79042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040134C3 RID: 79043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040134C4 RID: 79044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040134C5 RID: 79045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040134C6 RID: 79046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040134C7 RID: 79047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040134C8 RID: 79048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040134C9 RID: 79049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040134CA RID: 79050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040134CB RID: 79051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040134CC RID: 79052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040134CD RID: 79053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040134CE RID: 79054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040134CF RID: 79055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040134D0 RID: 79056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040134D1 RID: 79057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040134D2 RID: 79058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040134D3 RID: 79059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040134D4 RID: 79060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040134D5 RID: 79061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040134D6 RID: 79062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040134D7 RID: 79063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040134D8 RID: 79064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040134D9 RID: 79065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040134DA RID: 79066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040134DB RID: 79067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040134DC RID: 79068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040134DD RID: 79069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040134DE RID: 79070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040134DF RID: 79071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040134E0 RID: 79072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040134E1 RID: 79073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040134E2 RID: 79074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040134E3 RID: 79075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040134E4 RID: 79076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040134E5 RID: 79077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040134E6 RID: 79078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040134E7 RID: 79079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040134E8 RID: 79080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040134E9 RID: 79081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040134EA RID: 79082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040134EB RID: 79083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040134EC RID: 79084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040134ED RID: 79085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040134EE RID: 79086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040134EF RID: 79087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040134F0 RID: 79088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040134F1 RID: 79089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040134F2 RID: 79090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040134F3 RID: 79091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040134F4 RID: 79092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040134F5 RID: 79093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040134F6 RID: 79094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040134F7 RID: 79095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040134F8 RID: 79096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040134F9 RID: 79097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040134FA RID: 79098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040134FB RID: 79099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040134FC RID: 79100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040134FD RID: 79101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040134FE RID: 79102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x040134FF RID: 79103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04013500 RID: 79104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04013501 RID: 79105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04013502 RID: 79106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04013503 RID: 79107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04013504 RID: 79108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04013505 RID: 79109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04013506 RID: 79110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04013507 RID: 79111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04013508 RID: 79112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04013509 RID: 79113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0401350A RID: 79114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0401350B RID: 79115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0401350C RID: 79116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0401350D RID: 79117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0401350E RID: 79118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0401350F RID: 79119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04013510 RID: 79120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04013511 RID: 79121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04013512 RID: 79122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;
}
