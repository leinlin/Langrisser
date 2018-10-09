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

// Token: 0x02001418 RID: 5144
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController : LuaObject
{
	// Token: 0x0601D20C RID: 119308 RVA: 0x00929988 File Offset: 0x00927B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRoomToggleInfo(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			drillRoomToggleUIController.InitRoomToggleInfo(roomId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D20D RID: 119309 RVA: 0x009299E0 File Offset: 0x00927BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			drillRoomToggleUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D20E RID: 119310 RVA: 0x00929A34 File Offset: 0x00927C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleValueChange(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillRoomToggleUIController.m_luaExportHelper.OnToggleValueChange(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D20F RID: 119311 RVA: 0x00929A90 File Offset: 0x00927C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			drillRoomToggleUIController.m_luaExportHelper.OnLockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D210 RID: 119312 RVA: 0x00929AE4 File Offset: 0x00927CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D211 RID: 119313 RVA: 0x00929B50 File Offset: 0x00927D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D212 RID: 119314 RVA: 0x00929BA4 File Offset: 0x00927DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D213 RID: 119315 RVA: 0x00929BF8 File Offset: 0x00927DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = drillRoomToggleUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D214 RID: 119316 RVA: 0x00929CA0 File Offset: 0x00927EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D215 RID: 119317 RVA: 0x00929CF4 File Offset: 0x00927EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D216 RID: 119318 RVA: 0x00929D60 File Offset: 0x00927F60
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
				DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				drillRoomToggleUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DrillRoomToggleUIController drillRoomToggleUIController2 = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				drillRoomToggleUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D217 RID: 119319 RVA: 0x00929E70 File Offset: 0x00928070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D218 RID: 119320 RVA: 0x00929EDC File Offset: 0x009280DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D219 RID: 119321 RVA: 0x00929F48 File Offset: 0x00928148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D21A RID: 119322 RVA: 0x00929FB4 File Offset: 0x009281B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillRoomToggleUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D21B RID: 119323 RVA: 0x0092A020 File Offset: 0x00928220
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
				DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				drillRoomToggleUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DrillRoomToggleUIController drillRoomToggleUIController2 = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				drillRoomToggleUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D21C RID: 119324 RVA: 0x0092A130 File Offset: 0x00928330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			string s = drillRoomToggleUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D21D RID: 119325 RVA: 0x0092A18C File Offset: 0x0092838C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnToggleClick(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			DrillRoomToggleUIController obj;
			LuaObject.checkType<DrillRoomToggleUIController>(l, 2, out obj);
			drillRoomToggleUIController.m_luaExportHelper.__callDele_EventOnToggleClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D21E RID: 119326 RVA: 0x0092A1E8 File Offset: 0x009283E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnToggleClick(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			DrillRoomToggleUIController obj;
			LuaObject.checkType<DrillRoomToggleUIController>(l, 2, out obj);
			drillRoomToggleUIController.m_luaExportHelper.__clearDele_EventOnToggleClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D21F RID: 119327 RVA: 0x0092A244 File Offset: 0x00928444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnToggleClick(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			Action<DrillRoomToggleUIController> value;
			int num = LuaObject.checkDelegate<Action<DrillRoomToggleUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillRoomToggleUIController.EventOnToggleClick += value;
				}
				else if (num == 2)
				{
					drillRoomToggleUIController.EventOnToggleClick -= value;
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

	// Token: 0x0601D220 RID: 119328 RVA: 0x0092A2C4 File Offset: 0x009284C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillRoomToggleUIController.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D221 RID: 119329 RVA: 0x0092A31C File Offset: 0x0092851C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			drillRoomToggleUIController.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D222 RID: 119330 RVA: 0x0092A378 File Offset: 0x00928578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillRoomToggleUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D223 RID: 119331 RVA: 0x0092A3D0 File Offset: 0x009285D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			drillRoomToggleUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D224 RID: 119332 RVA: 0x0092A42C File Offset: 0x0092862C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillRoomToggleUIController.m_luaExportHelper.m_lvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D225 RID: 119333 RVA: 0x0092A484 File Offset: 0x00928684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			Text lvValueText;
			LuaObject.checkType<Text>(l, 2, out lvValueText);
			drillRoomToggleUIController.m_luaExportHelper.m_lvValueText = lvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D226 RID: 119334 RVA: 0x0092A4E0 File Offset: 0x009286E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lockGreyButton(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillRoomToggleUIController.m_luaExportHelper.m_lockGreyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D227 RID: 119335 RVA: 0x0092A538 File Offset: 0x00928738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockGreyButton(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			Button lockGreyButton;
			LuaObject.checkType<Button>(l, 2, out lockGreyButton);
			drillRoomToggleUIController.m_luaExportHelper.m_lockGreyButton = lockGreyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D228 RID: 119336 RVA: 0x0092A594 File Offset: 0x00928794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillRoomToggleUIController.m_luaExportHelper.m_redMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D229 RID: 119337 RVA: 0x0092A5EC File Offset: 0x009287EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			GameObject redMark;
			LuaObject.checkType<GameObject>(l, 2, out redMark);
			drillRoomToggleUIController.m_luaExportHelper.m_redMark = redMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D22A RID: 119338 RVA: 0x0092A648 File Offset: 0x00928848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Room(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillRoomToggleUIController.Room);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D22B RID: 119339 RVA: 0x0092A69C File Offset: 0x0092889C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Room(IntPtr l)
	{
		int result;
		try
		{
			DrillRoomToggleUIController drillRoomToggleUIController = (DrillRoomToggleUIController)LuaObject.checkSelf(l);
			TrainingRoom room;
			LuaObject.checkType<TrainingRoom>(l, 2, out room);
			drillRoomToggleUIController.m_luaExportHelper.Room = room;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D22C RID: 119340 RVA: 0x0092A6F8 File Offset: 0x009288F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DrillRoomToggleUIController");
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.InitRoomToggleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.OnToggleValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.OnLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__callDele_EventOnToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.__clearDele_EventOnToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache12);
		string name = "EventOnToggleClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.set_EventOnToggleClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache13, true);
		string name2 = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.get_m_toggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.set_m_toggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache15, true);
		string name3 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.get_m_stateCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache17, true);
		string name4 = "m_lvValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.get_m_lvValueText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.set_m_lvValueText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache19, true);
		string name5 = "m_lockGreyButton";
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.get_m_lockGreyButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.set_m_lockGreyButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1B, true);
		string name6 = "m_redMark";
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.get_m_redMark);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.set_m_redMark);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1D, true);
		string name7 = "Room";
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.get_Room);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.set_Room);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.<>f__mg$cache1F, true);
		LuaObject.createTypeMetatable(l, null, typeof(DrillRoomToggleUIController), typeof(UIControllerBase));
	}

	// Token: 0x040133BE RID: 78782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040133BF RID: 78783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040133C0 RID: 78784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040133C1 RID: 78785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040133C2 RID: 78786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040133C3 RID: 78787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040133C4 RID: 78788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040133C5 RID: 78789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040133C6 RID: 78790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040133C7 RID: 78791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040133C8 RID: 78792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040133C9 RID: 78793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040133CA RID: 78794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040133CB RID: 78795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040133CC RID: 78796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040133CD RID: 78797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040133CE RID: 78798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040133CF RID: 78799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040133D0 RID: 78800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040133D1 RID: 78801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040133D2 RID: 78802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040133D3 RID: 78803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040133D4 RID: 78804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040133D5 RID: 78805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040133D6 RID: 78806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040133D7 RID: 78807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040133D8 RID: 78808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040133D9 RID: 78809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040133DA RID: 78810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040133DB RID: 78811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040133DC RID: 78812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040133DD RID: 78813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
