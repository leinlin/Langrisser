using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001419 RID: 5145
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController : LuaObject
{
	// Token: 0x0601D22E RID: 119342 RVA: 0x0092AB9C File Offset: 0x00928D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D22F RID: 119343 RVA: 0x0092ABE8 File Offset: 0x00928DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInDrillSoliderManual(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			List<ConfigDataSoldierInfo> soldierList;
			LuaObject.checkType<List<ConfigDataSoldierInfo>>(l, 2, out soldierList);
			int totalPageCount;
			LuaObject.checkType(l, 3, out totalPageCount);
			drillSoldierManualUIController.UpdateViewInDrillSoliderManual(soldierList, totalPageCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D230 RID: 119344 RVA: 0x0092AC4C File Offset: 0x00928E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetData(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.ResetData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D231 RID: 119345 RVA: 0x0092AC98 File Offset: 0x00928E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D232 RID: 119346 RVA: 0x0092ACEC File Offset: 0x00928EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddListenerToSortToggles(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.AddListenerToSortToggles();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D233 RID: 119347 RVA: 0x0092AD40 File Offset: 0x00928F40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			SoldierManualItemUIController ctrl;
			LuaObject.checkType<SoldierManualItemUIController>(l, 2, out ctrl);
			drillSoldierManualUIController.m_luaExportHelper.OnSoldierItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D234 RID: 119348 RVA: 0x0092AD9C File Offset: 0x00928F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierInfoDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfoDetailPanel;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfoDetailPanel);
			drillSoldierManualUIController.m_luaExportHelper.SetSoldierInfoDetailPanel(soldierInfoDetailPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D235 RID: 119349 RVA: 0x0092ADF8 File Offset: 0x00928FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPageNextButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.OnPageNextButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D236 RID: 119350 RVA: 0x0092AE4C File Offset: 0x0092904C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPagePrevButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.OnPagePrevButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D237 RID: 119351 RVA: 0x0092AEA0 File Offset: 0x009290A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAllRankToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillSoldierManualUIController.m_luaExportHelper.OnAllRankToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D238 RID: 119352 RVA: 0x0092AEFC File Offset: 0x009290FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnRank1ToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillSoldierManualUIController.m_luaExportHelper.OnRank1ToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D239 RID: 119353 RVA: 0x0092AF58 File Offset: 0x00929158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnRank2ToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillSoldierManualUIController.m_luaExportHelper.OnRank2ToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D23A RID: 119354 RVA: 0x0092AFB4 File Offset: 0x009291B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnRank3ToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillSoldierManualUIController.m_luaExportHelper.OnRank3ToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D23B RID: 119355 RVA: 0x0092B010 File Offset: 0x00929210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSoldierSkillToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillSoldierManualUIController.m_luaExportHelper.OnSoldierSkillToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D23C RID: 119356 RVA: 0x0092B06C File Offset: 0x0092926C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSoldierDescToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillSoldierManualUIController.m_luaExportHelper.OnSoldierDescToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D23D RID: 119357 RVA: 0x0092B0C8 File Offset: 0x009292C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetSoldierNoticGoToButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.OnGetSoldierNoticGoToButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D23E RID: 119358 RVA: 0x0092B11C File Offset: 0x0092931C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSortButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.OnSortButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D23F RID: 119359 RVA: 0x0092B170 File Offset: 0x00929370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CloseSortTypesPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.CloseSortTypesPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D240 RID: 119360 RVA: 0x0092B1C4 File Offset: 0x009293C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D241 RID: 119361 RVA: 0x0092B218 File Offset: 0x00929418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D242 RID: 119362 RVA: 0x0092B284 File Offset: 0x00929484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D243 RID: 119363 RVA: 0x0092B2D8 File Offset: 0x009294D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D244 RID: 119364 RVA: 0x0092B32C File Offset: 0x0092952C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = drillSoldierManualUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D245 RID: 119365 RVA: 0x0092B3D4 File Offset: 0x009295D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D246 RID: 119366 RVA: 0x0092B428 File Offset: 0x00929628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D247 RID: 119367 RVA: 0x0092B494 File Offset: 0x00929694
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
				DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				drillSoldierManualUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DrillSoldierManualUIController drillSoldierManualUIController2 = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				drillSoldierManualUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D248 RID: 119368 RVA: 0x0092B5A4 File Offset: 0x009297A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D249 RID: 119369 RVA: 0x0092B610 File Offset: 0x00929810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D24A RID: 119370 RVA: 0x0092B67C File Offset: 0x0092987C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D24B RID: 119371 RVA: 0x0092B6E8 File Offset: 0x009298E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillSoldierManualUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D24C RID: 119372 RVA: 0x0092B754 File Offset: 0x00929954
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				drillSoldierManualUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DrillSoldierManualUIController drillSoldierManualUIController2 = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				drillSoldierManualUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D24D RID: 119373 RVA: 0x0092B864 File Offset: 0x00929A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			string s = drillSoldierManualUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D24E RID: 119374 RVA: 0x0092B8C0 File Offset: 0x00929AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D24F RID: 119375 RVA: 0x0092B914 File Offset: 0x00929B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			drillSoldierManualUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D250 RID: 119376 RVA: 0x0092B968 File Offset: 0x00929B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNeedUpdateView(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			ArmyTag arg3;
			LuaObject.checkEnum<ArmyTag>(l, 4, out arg3);
			drillSoldierManualUIController.m_luaExportHelper.__callDele_EventOnNeedUpdateView(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D251 RID: 119377 RVA: 0x0092B9E0 File Offset: 0x00929BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNeedUpdateView(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			ArmyTag arg3;
			LuaObject.checkEnum<ArmyTag>(l, 4, out arg3);
			drillSoldierManualUIController.m_luaExportHelper.__clearDele_EventOnNeedUpdateView(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D252 RID: 119378 RVA: 0x0092BA58 File Offset: 0x00929C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToTraingTech(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			drillSoldierManualUIController.m_luaExportHelper.__callDele_EventOnGoToTraingTech(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D253 RID: 119379 RVA: 0x0092BAB4 File Offset: 0x00929CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToTraingTech(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			drillSoldierManualUIController.m_luaExportHelper.__clearDele_EventOnGoToTraingTech(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D254 RID: 119380 RVA: 0x0092BB10 File Offset: 0x00929D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillSoldierManualUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					drillSoldierManualUIController.EventOnReturn -= value;
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

	// Token: 0x0601D255 RID: 119381 RVA: 0x0092BB90 File Offset: 0x00929D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNeedUpdateView(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Action<int, int, ArmyTag> value;
			int num = LuaObject.checkDelegate<Action<int, int, ArmyTag>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillSoldierManualUIController.EventOnNeedUpdateView += value;
				}
				else if (num == 2)
				{
					drillSoldierManualUIController.EventOnNeedUpdateView -= value;
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

	// Token: 0x0601D256 RID: 119382 RVA: 0x0092BC10 File Offset: 0x00929E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToTraingTech(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillSoldierManualUIController.EventOnGoToTraingTech += value;
				}
				else if (num == 2)
				{
					drillSoldierManualUIController.EventOnGoToTraingTech -= value;
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

	// Token: 0x0601D257 RID: 119383 RVA: 0x0092BC90 File Offset: 0x00929E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D258 RID: 119384 RVA: 0x0092BCE8 File Offset: 0x00929EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			drillSoldierManualUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D259 RID: 119385 RVA: 0x0092BD44 File Offset: 0x00929F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageButtonGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_pageButtonGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D25A RID: 119386 RVA: 0x0092BD9C File Offset: 0x00929F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageButtonGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			GameObject pageButtonGroup;
			LuaObject.checkType<GameObject>(l, 2, out pageButtonGroup);
			drillSoldierManualUIController.m_luaExportHelper.m_pageButtonGroup = pageButtonGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D25B RID: 119387 RVA: 0x0092BDF8 File Offset: 0x00929FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pagePrevButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_pagePrevButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D25C RID: 119388 RVA: 0x0092BE50 File Offset: 0x0092A050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pagePrevButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Button pagePrevButton;
			LuaObject.checkType<Button>(l, 2, out pagePrevButton);
			drillSoldierManualUIController.m_luaExportHelper.m_pagePrevButton = pagePrevButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D25D RID: 119389 RVA: 0x0092BEAC File Offset: 0x0092A0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageNextButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_pageNextButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D25E RID: 119390 RVA: 0x0092BF04 File Offset: 0x0092A104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageNextButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Button pageNextButton;
			LuaObject.checkType<Button>(l, 2, out pageNextButton);
			drillSoldierManualUIController.m_luaExportHelper.m_pageNextButton = pageNextButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D25F RID: 119391 RVA: 0x0092BF60 File Offset: 0x0092A160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allRankToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_allRankToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D260 RID: 119392 RVA: 0x0092BFB8 File Offset: 0x0092A1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allRankToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Toggle allRankToggle;
			LuaObject.checkType<Toggle>(l, 2, out allRankToggle);
			drillSoldierManualUIController.m_luaExportHelper.m_allRankToggle = allRankToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D261 RID: 119393 RVA: 0x0092C014 File Offset: 0x0092A214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rank1Toggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_rank1Toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D262 RID: 119394 RVA: 0x0092C06C File Offset: 0x0092A26C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rank1Toggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Toggle rank1Toggle;
			LuaObject.checkType<Toggle>(l, 2, out rank1Toggle);
			drillSoldierManualUIController.m_luaExportHelper.m_rank1Toggle = rank1Toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D263 RID: 119395 RVA: 0x0092C0C8 File Offset: 0x0092A2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rank2Toggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_rank2Toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D264 RID: 119396 RVA: 0x0092C120 File Offset: 0x0092A320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rank2Toggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Toggle rank2Toggle;
			LuaObject.checkType<Toggle>(l, 2, out rank2Toggle);
			drillSoldierManualUIController.m_luaExportHelper.m_rank2Toggle = rank2Toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D265 RID: 119397 RVA: 0x0092C17C File Offset: 0x0092A37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rank3Toggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_rank3Toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D266 RID: 119398 RVA: 0x0092C1D4 File Offset: 0x0092A3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rank3Toggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Toggle rank3Toggle;
			LuaObject.checkType<Toggle>(l, 2, out rank3Toggle);
			drillSoldierManualUIController.m_luaExportHelper.m_rank3Toggle = rank3Toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D267 RID: 119399 RVA: 0x0092C230 File Offset: 0x0092A430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierListContent(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierListContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D268 RID: 119400 RVA: 0x0092C288 File Offset: 0x0092A488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierListContent(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			GameObject soldierListContent;
			LuaObject.checkType<GameObject>(l, 2, out soldierListContent);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierListContent = soldierListContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D269 RID: 119401 RVA: 0x0092C2E4 File Offset: 0x0092A4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D26A RID: 119402 RVA: 0x0092C33C File Offset: 0x0092A53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			GameObject soldierItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out soldierItemPrefab);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierItemPrefab = soldierItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D26B RID: 119403 RVA: 0x0092C398 File Offset: 0x0092A598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_sortButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D26C RID: 119404 RVA: 0x0092C3F0 File Offset: 0x0092A5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Button sortButton;
			LuaObject.checkType<Button>(l, 2, out sortButton);
			drillSoldierManualUIController.m_luaExportHelper.m_sortButton = sortButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D26D RID: 119405 RVA: 0x0092C44C File Offset: 0x0092A64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortButtonTypeText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_sortButtonTypeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D26E RID: 119406 RVA: 0x0092C4A4 File Offset: 0x0092A6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortButtonTypeText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text sortButtonTypeText;
			LuaObject.checkType<Text>(l, 2, out sortButtonTypeText);
			drillSoldierManualUIController.m_luaExportHelper.m_sortButtonTypeText = sortButtonTypeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D26F RID: 119407 RVA: 0x0092C500 File Offset: 0x0092A700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypes(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_sortTypes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D270 RID: 119408 RVA: 0x0092C558 File Offset: 0x0092A758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortTypes(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			GameObject sortTypes;
			LuaObject.checkType<GameObject>(l, 2, out sortTypes);
			drillSoldierManualUIController.m_luaExportHelper.m_sortTypes = sortTypes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D271 RID: 119409 RVA: 0x0092C5B4 File Offset: 0x0092A7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypesReturnBgImage(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_sortTypesReturnBgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D272 RID: 119410 RVA: 0x0092C60C File Offset: 0x0092A80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortTypesReturnBgImage(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Button sortTypesReturnBgImage;
			LuaObject.checkType<Button>(l, 2, out sortTypesReturnBgImage);
			drillSoldierManualUIController.m_luaExportHelper.m_sortTypesReturnBgImage = sortTypesReturnBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D273 RID: 119411 RVA: 0x0092C668 File Offset: 0x0092A868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypesGridLayout(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_sortTypesGridLayout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D274 RID: 119412 RVA: 0x0092C6C0 File Offset: 0x0092A8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortTypesGridLayout(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			GameObject sortTypesGridLayout;
			LuaObject.checkType<GameObject>(l, 2, out sortTypesGridLayout);
			drillSoldierManualUIController.m_luaExportHelper.m_sortTypesGridLayout = sortTypesGridLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D275 RID: 119413 RVA: 0x0092C71C File Offset: 0x0092A91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierTypeIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D276 RID: 119414 RVA: 0x0092C774 File Offset: 0x0092A974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Image soldierTypeIcon;
			LuaObject.checkType<Image>(l, 2, out soldierTypeIcon);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierTypeIcon = soldierTypeIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D277 RID: 119415 RVA: 0x0092C7D0 File Offset: 0x0092A9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierQualityIcon(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierQualityIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D278 RID: 119416 RVA: 0x0092C828 File Offset: 0x0092AA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierQualityIcon(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Image soldierQualityIcon;
			LuaObject.checkType<Image>(l, 2, out soldierQualityIcon);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierQualityIcon = soldierQualityIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D279 RID: 119417 RVA: 0x0092C884 File Offset: 0x0092AA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D27A RID: 119418 RVA: 0x0092C8DC File Offset: 0x0092AADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierNameText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierNameText = soldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D27B RID: 119419 RVA: 0x0092C938 File Offset: 0x0092AB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropHpValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropHpValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D27C RID: 119420 RVA: 0x0092C990 File Offset: 0x0092AB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropHpValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierPropHpValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropHpValueText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropHpValueText = soldierPropHpValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D27D RID: 119421 RVA: 0x0092C9EC File Offset: 0x0092ABEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D27E RID: 119422 RVA: 0x0092CA44 File Offset: 0x0092AC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierPropATValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropATValueText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropATValueText = soldierPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D27F RID: 119423 RVA: 0x0092CAA0 File Offset: 0x0092ACA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D280 RID: 119424 RVA: 0x0092CAF8 File Offset: 0x0092ACF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropDFValueText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropDFValueText = soldierPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D281 RID: 119425 RVA: 0x0092CB54 File Offset: 0x0092AD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D282 RID: 119426 RVA: 0x0092CBAC File Offset: 0x0092ADAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropMagicDFValueText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropMagicDFValueText = soldierPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D283 RID: 119427 RVA: 0x0092CC08 File Offset: 0x0092AE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropRangeValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropRangeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D284 RID: 119428 RVA: 0x0092CC60 File Offset: 0x0092AE60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierPropRangeValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierPropRangeValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropRangeValueText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropRangeValueText = soldierPropRangeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D285 RID: 119429 RVA: 0x0092CCBC File Offset: 0x0092AEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropMoveValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropMoveValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D286 RID: 119430 RVA: 0x0092CD14 File Offset: 0x0092AF14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierPropMoveValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierPropMoveValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropMoveValueText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropMoveValueText = soldierPropMoveValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D287 RID: 119431 RVA: 0x0092CD70 File Offset: 0x0092AF70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierPropRestrainValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropRestrainValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D288 RID: 119432 RVA: 0x0092CDC8 File Offset: 0x0092AFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropRestrainValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierPropRestrainValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropRestrainValueText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropRestrainValueText = soldierPropRestrainValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D289 RID: 119433 RVA: 0x0092CE24 File Offset: 0x0092B024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropWeakValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropWeakValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D28A RID: 119434 RVA: 0x0092CE7C File Offset: 0x0092B07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropWeakValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierPropWeakValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropWeakValueText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropWeakValueText = soldierPropWeakValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D28B RID: 119435 RVA: 0x0092CED8 File Offset: 0x0092B0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropTypeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierPropTypeStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D28C RID: 119436 RVA: 0x0092CF30 File Offset: 0x0092B130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropTypeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierPropTypeStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierPropTypeStateCtrl);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierPropTypeStateCtrl = soldierPropTypeStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D28D RID: 119437 RVA: 0x0092CF8C File Offset: 0x0092B18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D28E RID: 119438 RVA: 0x0092CFE4 File Offset: 0x0092B1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text soldierDescText;
			LuaObject.checkType<Text>(l, 2, out soldierDescText);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierDescText = soldierDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D28F RID: 119439 RVA: 0x0092D040 File Offset: 0x0092B240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierSkillToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierSkillToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D290 RID: 119440 RVA: 0x0092D098 File Offset: 0x0092B298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierSkillToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Toggle soldierSkillToggle;
			LuaObject.checkType<Toggle>(l, 2, out soldierSkillToggle);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierSkillToggle = soldierSkillToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D291 RID: 119441 RVA: 0x0092D0F4 File Offset: 0x0092B2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierDescToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D292 RID: 119442 RVA: 0x0092D14C File Offset: 0x0092B34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Toggle soldierDescToggle;
			LuaObject.checkType<Toggle>(l, 2, out soldierDescToggle);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierDescToggle = soldierDescToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D293 RID: 119443 RVA: 0x0092D1A8 File Offset: 0x0092B3A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D294 RID: 119444 RVA: 0x0092D200 File Offset: 0x0092B400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			GameObject soldierGraphic;
			LuaObject.checkType<GameObject>(l, 2, out soldierGraphic);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierGraphic = soldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D295 RID: 119445 RVA: 0x0092D25C File Offset: 0x0092B45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getSoldierNotic(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_getSoldierNotic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D296 RID: 119446 RVA: 0x0092D2B4 File Offset: 0x0092B4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getSoldierNotic(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			GameObject getSoldierNotic;
			LuaObject.checkType<GameObject>(l, 2, out getSoldierNotic);
			drillSoldierManualUIController.m_luaExportHelper.m_getSoldierNotic = getSoldierNotic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D297 RID: 119447 RVA: 0x0092D310 File Offset: 0x0092B510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getSoldierNoticText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_getSoldierNoticText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D298 RID: 119448 RVA: 0x0092D368 File Offset: 0x0092B568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getSoldierNoticText(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Text getSoldierNoticText;
			LuaObject.checkType<Text>(l, 2, out getSoldierNoticText);
			drillSoldierManualUIController.m_luaExportHelper.m_getSoldierNoticText = getSoldierNoticText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D299 RID: 119449 RVA: 0x0092D3C4 File Offset: 0x0092B5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getSoldierNoticGoToButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_getSoldierNoticGoToButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D29A RID: 119450 RVA: 0x0092D41C File Offset: 0x0092B61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getSoldierNoticGoToButton(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			Button getSoldierNoticGoToButton;
			LuaObject.checkType<Button>(l, 2, out getSoldierNoticGoToButton);
			drillSoldierManualUIController.m_luaExportHelper.m_getSoldierNoticGoToButton = getSoldierNoticGoToButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D29B RID: 119451 RVA: 0x0092D478 File Offset: 0x0092B678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D29C RID: 119452 RVA: 0x0092D4D0 File Offset: 0x0092B6D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			drillSoldierManualUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D29D RID: 119453 RVA: 0x0092D52C File Offset: 0x0092B72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curPage(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_curPage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D29E RID: 119454 RVA: 0x0092D584 File Offset: 0x0092B784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curPage(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			int curPage;
			LuaObject.checkType(l, 2, out curPage);
			drillSoldierManualUIController.m_luaExportHelper.m_curPage = curPage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D29F RID: 119455 RVA: 0x0092D5E0 File Offset: 0x0092B7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSoldierInfoCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_curSoldierInfoCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A0 RID: 119456 RVA: 0x0092D638 File Offset: 0x0092B838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSoldierInfoCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			SoldierManualItemUIController curSoldierInfoCtrl;
			LuaObject.checkType<SoldierManualItemUIController>(l, 2, out curSoldierInfoCtrl);
			drillSoldierManualUIController.m_luaExportHelper.m_curSoldierInfoCtrl = curSoldierInfoCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A1 RID: 119457 RVA: 0x0092D694 File Offset: 0x0092B894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierInfoGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A2 RID: 119458 RVA: 0x0092D6EC File Offset: 0x0092B8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierInfoGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierInfoGraphic);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierInfoGraphic = soldierInfoGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A3 RID: 119459 RVA: 0x0092D748 File Offset: 0x0092B948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoList(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soldierInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A4 RID: 119460 RVA: 0x0092D7A0 File Offset: 0x0092B9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfoList(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			List<ConfigDataSoldierInfo> soldierInfoList;
			LuaObject.checkType<List<ConfigDataSoldierInfo>>(l, 2, out soldierInfoList);
			drillSoldierManualUIController.m_luaExportHelper.m_soldierInfoList = soldierInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A5 RID: 119461 RVA: 0x0092D7FC File Offset: 0x0092B9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soliderItemListCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_soliderItemListCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A6 RID: 119462 RVA: 0x0092D854 File Offset: 0x0092BA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soliderItemListCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			List<SoldierManualItemUIController> soliderItemListCtrl;
			LuaObject.checkType<List<SoldierManualItemUIController>>(l, 2, out soliderItemListCtrl);
			drillSoldierManualUIController.m_luaExportHelper.m_soliderItemListCtrl = soliderItemListCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A7 RID: 119463 RVA: 0x0092D8B0 File Offset: 0x0092BAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalPageCount(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_totalPageCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A8 RID: 119464 RVA: 0x0092D908 File Offset: 0x0092BB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalPageCount(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			int totalPageCount;
			LuaObject.checkType(l, 2, out totalPageCount);
			drillSoldierManualUIController.m_luaExportHelper.m_totalPageCount = totalPageCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2A9 RID: 119465 RVA: 0x0092D964 File Offset: 0x0092BB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curRank(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_curRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2AA RID: 119466 RVA: 0x0092D9BC File Offset: 0x0092BBBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curRank(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			int curRank;
			LuaObject.checkType(l, 2, out curRank);
			drillSoldierManualUIController.m_luaExportHelper.m_curRank = curRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2AB RID: 119467 RVA: 0x0092DA18 File Offset: 0x0092BC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curArmyTag(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)drillSoldierManualUIController.m_luaExportHelper.m_curArmyTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2AC RID: 119468 RVA: 0x0092DA70 File Offset: 0x0092BC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curArmyTag(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			ArmyTag curArmyTag;
			LuaObject.checkEnum<ArmyTag>(l, 2, out curArmyTag);
			drillSoldierManualUIController.m_luaExportHelper.m_curArmyTag = curArmyTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2AD RID: 119469 RVA: 0x0092DACC File Offset: 0x0092BCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillSoldierManualUIController.m_luaExportHelper.m_isFirstIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2AE RID: 119470 RVA: 0x0092DB24 File Offset: 0x0092BD24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			DrillSoldierManualUIController drillSoldierManualUIController = (DrillSoldierManualUIController)LuaObject.checkSelf(l);
			bool isFirstIn;
			LuaObject.checkType(l, 2, out isFirstIn);
			drillSoldierManualUIController.m_luaExportHelper.m_isFirstIn = isFirstIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D2AF RID: 119471 RVA: 0x0092DB80 File Offset: 0x0092BD80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DrillSoldierManualUIController");
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.UpdateViewInDrillSoliderManual);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.ResetData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.AddListenerToSortToggles);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.SetSoldierInfoDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnPageNextButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnPagePrevButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnAllRankToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnRank1ToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnRank2ToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnRank3ToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnSoldierSkillToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnSoldierDescToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnGetSoldierNoticGoToButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnSortButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.CloseSortTypesPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callDele_EventOnNeedUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__clearDele_EventOnNeedUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__callDele_EventOnGoToTraingTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.__clearDele_EventOnGoToTraingTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache25);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache26, true);
		string name2 = "EventOnNeedUpdateView";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_EventOnNeedUpdateView);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache27, true);
		string name3 = "EventOnGoToTraingTech";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_EventOnGoToTraingTech);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache28, true);
		string name4 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_returnButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2A, true);
		string name5 = "m_pageButtonGroup";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_pageButtonGroup);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_pageButtonGroup);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2C, true);
		string name6 = "m_pagePrevButton";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_pagePrevButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_pagePrevButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2E, true);
		string name7 = "m_pageNextButton";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_pageNextButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_pageNextButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache30, true);
		string name8 = "m_allRankToggle";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_allRankToggle);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_allRankToggle);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache32, true);
		string name9 = "m_rank1Toggle";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_rank1Toggle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_rank1Toggle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache34, true);
		string name10 = "m_rank2Toggle";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_rank2Toggle);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_rank2Toggle);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache36, true);
		string name11 = "m_rank3Toggle";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_rank3Toggle);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_rank3Toggle);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache38, true);
		string name12 = "m_soldierListContent";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierListContent);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierListContent);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3A, true);
		string name13 = "m_soldierItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierItemPrefab);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierItemPrefab);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3C, true);
		string name14 = "m_sortButton";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_sortButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_sortButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3E, true);
		string name15 = "m_sortButtonTypeText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_sortButtonTypeText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_sortButtonTypeText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache40, true);
		string name16 = "m_sortTypes";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_sortTypes);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_sortTypes);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache42, true);
		string name17 = "m_sortTypesReturnBgImage";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_sortTypesReturnBgImage);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_sortTypesReturnBgImage);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache44, true);
		string name18 = "m_sortTypesGridLayout";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_sortTypesGridLayout);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_sortTypesGridLayout);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache46, true);
		string name19 = "m_soldierTypeIcon";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierTypeIcon);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierTypeIcon);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache48, true);
		string name20 = "m_soldierQualityIcon";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierQualityIcon);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierQualityIcon);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4A, true);
		string name21 = "m_soldierNameText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierNameText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierNameText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4C, true);
		string name22 = "m_soldierPropHpValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropHpValueText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropHpValueText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4E, true);
		string name23 = "m_soldierPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropATValueText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropATValueText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache50, true);
		string name24 = "m_soldierPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropDFValueText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropDFValueText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache52, true);
		string name25 = "m_soldierPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropMagicDFValueText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropMagicDFValueText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache54, true);
		string name26 = "m_soldierPropRangeValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropRangeValueText);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropRangeValueText);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache56, true);
		string name27 = "m_soldierPropMoveValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropMoveValueText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropMoveValueText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache58, true);
		string name28 = "m_soldierPropRestrainValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropRestrainValueText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropRestrainValueText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5A, true);
		string name29 = "m_soldierPropWeakValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropWeakValueText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropWeakValueText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5C, true);
		string name30 = "m_soldierPropTypeStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierPropTypeStateCtrl);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierPropTypeStateCtrl);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5E, true);
		string name31 = "m_soldierDescText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierDescText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierDescText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache60, true);
		string name32 = "m_soldierSkillToggle";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierSkillToggle);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierSkillToggle);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache62, true);
		string name33 = "m_soldierDescToggle";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierDescToggle);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierDescToggle);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache64, true);
		string name34 = "m_soldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierGraphic);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierGraphic);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache66, true);
		string name35 = "m_getSoldierNotic";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_getSoldierNotic);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_getSoldierNotic);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache68, true);
		string name36 = "m_getSoldierNoticText";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_getSoldierNoticText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_getSoldierNoticText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6A, true);
		string name37 = "m_getSoldierNoticGoToButton";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_getSoldierNoticGoToButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_getSoldierNoticGoToButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6C, true);
		string name38 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_playerContext);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6E, true);
		string name39 = "m_curPage";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_curPage);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_curPage);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache70, true);
		string name40 = "m_curSoldierInfoCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_curSoldierInfoCtrl);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_curSoldierInfoCtrl);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache72, true);
		string name41 = "m_soldierInfoGraphic";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierInfoGraphic);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierInfoGraphic);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache74, true);
		string name42 = "m_soldierInfoList";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soldierInfoList);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soldierInfoList);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache76, true);
		string name43 = "m_soliderItemListCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_soliderItemListCtrl);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_soliderItemListCtrl);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache78, true);
		string name44 = "m_totalPageCount";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_totalPageCount);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_totalPageCount);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7A, true);
		string name45 = "m_curRank";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_curRank);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_curRank);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7C, true);
		string name46 = "m_curArmyTag";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_curArmyTag);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_curArmyTag);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7E, true);
		string name47 = "m_isFirstIn";
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.get_m_isFirstIn);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.set_m_isFirstIn);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.<>f__mg$cache80, true);
		LuaObject.createTypeMetatable(l, null, typeof(DrillSoldierManualUIController), typeof(UIControllerBase));
	}

	// Token: 0x040133DE RID: 78814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040133DF RID: 78815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040133E0 RID: 78816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040133E1 RID: 78817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040133E2 RID: 78818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040133E3 RID: 78819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040133E4 RID: 78820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040133E5 RID: 78821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040133E6 RID: 78822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040133E7 RID: 78823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040133E8 RID: 78824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040133E9 RID: 78825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040133EA RID: 78826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040133EB RID: 78827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040133EC RID: 78828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040133ED RID: 78829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040133EE RID: 78830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040133EF RID: 78831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040133F0 RID: 78832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040133F1 RID: 78833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040133F2 RID: 78834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040133F3 RID: 78835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040133F4 RID: 78836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040133F5 RID: 78837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040133F6 RID: 78838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040133F7 RID: 78839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040133F8 RID: 78840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040133F9 RID: 78841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040133FA RID: 78842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040133FB RID: 78843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040133FC RID: 78844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040133FD RID: 78845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040133FE RID: 78846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040133FF RID: 78847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013400 RID: 78848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013401 RID: 78849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013402 RID: 78850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013403 RID: 78851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013404 RID: 78852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013405 RID: 78853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013406 RID: 78854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013407 RID: 78855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013408 RID: 78856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013409 RID: 78857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401340A RID: 78858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401340B RID: 78859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401340C RID: 78860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401340D RID: 78861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401340E RID: 78862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401340F RID: 78863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013410 RID: 78864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013411 RID: 78865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013412 RID: 78866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013413 RID: 78867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013414 RID: 78868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013415 RID: 78869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013416 RID: 78870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013417 RID: 78871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013418 RID: 78872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013419 RID: 78873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401341A RID: 78874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401341B RID: 78875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401341C RID: 78876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401341D RID: 78877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401341E RID: 78878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401341F RID: 78879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013420 RID: 78880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013421 RID: 78881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013422 RID: 78882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013423 RID: 78883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013424 RID: 78884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013425 RID: 78885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013426 RID: 78886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013427 RID: 78887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013428 RID: 78888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013429 RID: 78889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401342A RID: 78890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401342B RID: 78891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401342C RID: 78892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401342D RID: 78893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401342E RID: 78894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401342F RID: 78895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013430 RID: 78896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013431 RID: 78897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013432 RID: 78898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013433 RID: 78899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013434 RID: 78900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04013435 RID: 78901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04013436 RID: 78902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04013437 RID: 78903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04013438 RID: 78904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04013439 RID: 78905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401343A RID: 78906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401343B RID: 78907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401343C RID: 78908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401343D RID: 78909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401343E RID: 78910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401343F RID: 78911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013440 RID: 78912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013441 RID: 78913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013442 RID: 78914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013443 RID: 78915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013444 RID: 78916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013445 RID: 78917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04013446 RID: 78918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04013447 RID: 78919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04013448 RID: 78920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04013449 RID: 78921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401344A RID: 78922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401344B RID: 78923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401344C RID: 78924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0401344D RID: 78925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0401344E RID: 78926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0401344F RID: 78927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04013450 RID: 78928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04013451 RID: 78929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04013452 RID: 78930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04013453 RID: 78931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04013454 RID: 78932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04013455 RID: 78933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04013456 RID: 78934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04013457 RID: 78935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04013458 RID: 78936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04013459 RID: 78937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401345A RID: 78938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401345B RID: 78939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401345C RID: 78940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0401345D RID: 78941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0401345E RID: 78942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;
}
