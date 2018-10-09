using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001520 RID: 5408
[Preserve]
public class Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController : LuaObject
{
	// Token: 0x060201BE RID: 131518 RVA: 0x00AA4630 File Offset: 0x00AA2830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitOpenServiceMissonInfo(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			bool hasGot;
			LuaObject.checkType(l, 3, out hasGot);
			openServiceMissonUIController.InitOpenServiceMissonInfo(mission, hasGot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201BF RID: 131519 RVA: 0x00AA4694 File Offset: 0x00AA2894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayGetRewardEffect(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Action onStateFinish;
			LuaObject.checkDelegate<Action>(l, 2, out onStateFinish);
			openServiceMissonUIController.PlayGetRewardEffect(onStateFinish);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C0 RID: 131520 RVA: 0x00AA46EC File Offset: 0x00AA28EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			openServiceMissonUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C1 RID: 131521 RVA: 0x00AA4740 File Offset: 0x00AA2940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOpenServiceMissionInfo(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			openServiceMissonUIController.m_luaExportHelper.SetOpenServiceMissionInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C2 RID: 131522 RVA: 0x00AA4794 File Offset: 0x00AA2994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOpenServiceMissionState(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			bool openServiceMissionState;
			LuaObject.checkType(l, 2, out openServiceMissionState);
			openServiceMissonUIController.m_luaExportHelper.SetOpenServiceMissionState(openServiceMissionState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C3 RID: 131523 RVA: 0x00AA47F0 File Offset: 0x00AA29F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			openServiceMissonUIController.m_luaExportHelper.OnGotoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C4 RID: 131524 RVA: 0x00AA4844 File Offset: 0x00AA2A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			openServiceMissonUIController.m_luaExportHelper.OnGetButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C5 RID: 131525 RVA: 0x00AA4898 File Offset: 0x00AA2A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			openServiceMissonUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C6 RID: 131526 RVA: 0x00AA4904 File Offset: 0x00AA2B04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			openServiceMissonUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C7 RID: 131527 RVA: 0x00AA4958 File Offset: 0x00AA2B58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			openServiceMissonUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201C8 RID: 131528 RVA: 0x00AA49AC File Offset: 0x00AA2BAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = openServiceMissonUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060201C9 RID: 131529 RVA: 0x00AA4A54 File Offset: 0x00AA2C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			openServiceMissonUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201CA RID: 131530 RVA: 0x00AA4AA8 File Offset: 0x00AA2CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			openServiceMissonUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201CB RID: 131531 RVA: 0x00AA4B14 File Offset: 0x00AA2D14
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
				OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				openServiceMissonUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				OpenServiceMissonUIController openServiceMissonUIController2 = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				openServiceMissonUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060201CC RID: 131532 RVA: 0x00AA4C24 File Offset: 0x00AA2E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			openServiceMissonUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201CD RID: 131533 RVA: 0x00AA4C90 File Offset: 0x00AA2E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			openServiceMissonUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201CE RID: 131534 RVA: 0x00AA4CFC File Offset: 0x00AA2EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			openServiceMissonUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201CF RID: 131535 RVA: 0x00AA4D68 File Offset: 0x00AA2F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			openServiceMissonUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201D0 RID: 131536 RVA: 0x00AA4DD4 File Offset: 0x00AA2FD4
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
				OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				openServiceMissonUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				OpenServiceMissonUIController openServiceMissonUIController2 = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				openServiceMissonUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060201D1 RID: 131537 RVA: 0x00AA4EE4 File Offset: 0x00AA30E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			string s = openServiceMissonUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060201D2 RID: 131538 RVA: 0x00AA4F40 File Offset: 0x00AA3140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			openServiceMissonUIController.m_luaExportHelper.__callDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201D3 RID: 131539 RVA: 0x00AA4F9C File Offset: 0x00AA319C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			openServiceMissonUIController.m_luaExportHelper.__clearDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201D4 RID: 131540 RVA: 0x00AA4FF8 File Offset: 0x00AA31F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			OpenServiceMissonUIController obj;
			LuaObject.checkType<OpenServiceMissonUIController>(l, 2, out obj);
			openServiceMissonUIController.m_luaExportHelper.__callDele_EventOnGetButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201D5 RID: 131541 RVA: 0x00AA5054 File Offset: 0x00AA3254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			OpenServiceMissonUIController obj;
			LuaObject.checkType<OpenServiceMissonUIController>(l, 2, out obj);
			openServiceMissonUIController.m_luaExportHelper.__clearDele_EventOnGetButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201D6 RID: 131542 RVA: 0x00AA50B0 File Offset: 0x00AA32B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Action<GetPathData> value;
			int num = LuaObject.checkDelegate<Action<GetPathData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					openServiceMissonUIController.EventOnGotoButtonClick += value;
				}
				else if (num == 2)
				{
					openServiceMissonUIController.EventOnGotoButtonClick -= value;
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

	// Token: 0x060201D7 RID: 131543 RVA: 0x00AA5130 File Offset: 0x00AA3330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Action<OpenServiceMissonUIController> value;
			int num = LuaObject.checkDelegate<Action<OpenServiceMissonUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					openServiceMissonUIController.EventOnGetButtonClick += value;
				}
				else if (num == 2)
				{
					openServiceMissonUIController.EventOnGetButtonClick -= value;
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

	// Token: 0x060201D8 RID: 131544 RVA: 0x00AA51B0 File Offset: 0x00AA33B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_infoText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_infoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201D9 RID: 131545 RVA: 0x00AA5208 File Offset: 0x00AA3408
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_infoText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Text infoText;
			LuaObject.checkType<Text>(l, 2, out infoText);
			openServiceMissonUIController.m_luaExportHelper.m_infoText = infoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201DA RID: 131546 RVA: 0x00AA5264 File Offset: 0x00AA3464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemDummy(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_itemDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201DB RID: 131547 RVA: 0x00AA52BC File Offset: 0x00AA34BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_itemDummy(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			GameObject itemDummy;
			LuaObject.checkType<GameObject>(l, 2, out itemDummy);
			openServiceMissonUIController.m_luaExportHelper.m_itemDummy = itemDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201DC RID: 131548 RVA: 0x00AA5318 File Offset: 0x00AA3518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressBar(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_progressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201DD RID: 131549 RVA: 0x00AA5370 File Offset: 0x00AA3570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressBar(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Image progressBar;
			LuaObject.checkType<Image>(l, 2, out progressBar);
			openServiceMissonUIController.m_luaExportHelper.m_progressBar = progressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201DE RID: 131550 RVA: 0x00AA53CC File Offset: 0x00AA35CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressBarValueStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_progressBarValueStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201DF RID: 131551 RVA: 0x00AA5424 File Offset: 0x00AA3624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressBarValueStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			CommonUIStateController progressBarValueStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out progressBarValueStateCtrl);
			openServiceMissonUIController.m_luaExportHelper.m_progressBarValueStateCtrl = progressBarValueStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E0 RID: 131552 RVA: 0x00AA5480 File Offset: 0x00AA3680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressHaveCount(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_progressHaveCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E1 RID: 131553 RVA: 0x00AA54D8 File Offset: 0x00AA36D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressHaveCount(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Text progressHaveCount;
			LuaObject.checkType<Text>(l, 2, out progressHaveCount);
			openServiceMissonUIController.m_luaExportHelper.m_progressHaveCount = progressHaveCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E2 RID: 131554 RVA: 0x00AA5534 File Offset: 0x00AA3734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressNeedCount(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_progressNeedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E3 RID: 131555 RVA: 0x00AA558C File Offset: 0x00AA378C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_progressNeedCount(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Text progressNeedCount;
			LuaObject.checkType<Text>(l, 2, out progressNeedCount);
			openServiceMissonUIController.m_luaExportHelper.m_progressNeedCount = progressNeedCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E4 RID: 131556 RVA: 0x00AA55E8 File Offset: 0x00AA37E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressDoneText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_progressDoneText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E5 RID: 131557 RVA: 0x00AA5640 File Offset: 0x00AA3840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressDoneText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			GameObject progressDoneText;
			LuaObject.checkType<GameObject>(l, 2, out progressDoneText);
			openServiceMissonUIController.m_luaExportHelper.m_progressDoneText = progressDoneText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E6 RID: 131558 RVA: 0x00AA569C File Offset: 0x00AA389C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_buttonGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E7 RID: 131559 RVA: 0x00AA56F4 File Offset: 0x00AA38F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buttonGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			CommonUIStateController buttonGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out buttonGroupStateCtrl);
			openServiceMissonUIController.m_luaExportHelper.m_buttonGroupStateCtrl = buttonGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E8 RID: 131560 RVA: 0x00AA5750 File Offset: 0x00AA3950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gotoButton(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_gotoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201E9 RID: 131561 RVA: 0x00AA57A8 File Offset: 0x00AA39A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gotoButton(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Button gotoButton;
			LuaObject.checkType<Button>(l, 2, out gotoButton);
			openServiceMissonUIController.m_luaExportHelper.m_gotoButton = gotoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201EA RID: 131562 RVA: 0x00AA5804 File Offset: 0x00AA3A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getButton(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.m_luaExportHelper.m_getButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201EB RID: 131563 RVA: 0x00AA585C File Offset: 0x00AA3A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getButton(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Button getButton;
			LuaObject.checkType<Button>(l, 2, out getButton);
			openServiceMissonUIController.m_luaExportHelper.m_getButton = getButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201EC RID: 131564 RVA: 0x00AA58B8 File Offset: 0x00AA3AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Mission(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceMissonUIController.Mission);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201ED RID: 131565 RVA: 0x00AA590C File Offset: 0x00AA3B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Mission(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceMissonUIController openServiceMissonUIController = (OpenServiceMissonUIController)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			openServiceMissonUIController.m_luaExportHelper.Mission = mission;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201EE RID: 131566 RVA: 0x00AA5968 File Offset: 0x00AA3B68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.OpenServiceMissonUIController");
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.InitOpenServiceMissonInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.PlayGetRewardEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.SetOpenServiceMissionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.SetOpenServiceMissionState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.OnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.OnGetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__clearDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__callDele_EventOnGetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.__clearDele_EventOnGetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache17);
		string name = "EventOnGotoButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache18, true);
		string name2 = "EventOnGetButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_EventOnGetButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache19, true);
		string name3 = "m_infoText";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_infoText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_infoText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1B, true);
		string name4 = "m_itemDummy";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_itemDummy);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_itemDummy);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1D, true);
		string name5 = "m_progressBar";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_progressBar);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_progressBar);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache1F, true);
		string name6 = "m_progressBarValueStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_progressBarValueStateCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_progressBarValueStateCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache21, true);
		string name7 = "m_progressHaveCount";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_progressHaveCount);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_progressHaveCount);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache23, true);
		string name8 = "m_progressNeedCount";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_progressNeedCount);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_progressNeedCount);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache25, true);
		string name9 = "m_progressDoneText";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_progressDoneText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_progressDoneText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache27, true);
		string name10 = "m_buttonGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_buttonGroupStateCtrl);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_buttonGroupStateCtrl);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache29, true);
		string name11 = "m_gotoButton";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_gotoButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_gotoButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2B, true);
		string name12 = "m_getButton";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_m_getButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_m_getButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2D, true);
		string name13 = "Mission";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.get_Mission);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.set_Mission);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(OpenServiceMissonUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016160 RID: 90464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016161 RID: 90465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016162 RID: 90466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016163 RID: 90467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016164 RID: 90468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016165 RID: 90469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016166 RID: 90470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016167 RID: 90471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016168 RID: 90472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016169 RID: 90473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401616A RID: 90474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401616B RID: 90475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401616C RID: 90476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401616D RID: 90477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401616E RID: 90478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401616F RID: 90479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016170 RID: 90480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016171 RID: 90481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016172 RID: 90482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016173 RID: 90483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016174 RID: 90484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016175 RID: 90485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016176 RID: 90486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016177 RID: 90487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016178 RID: 90488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016179 RID: 90489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401617A RID: 90490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401617B RID: 90491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401617C RID: 90492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401617D RID: 90493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401617E RID: 90494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401617F RID: 90495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016180 RID: 90496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016181 RID: 90497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016182 RID: 90498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016183 RID: 90499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016184 RID: 90500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016185 RID: 90501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016186 RID: 90502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016187 RID: 90503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016188 RID: 90504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016189 RID: 90505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401618A RID: 90506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401618B RID: 90507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401618C RID: 90508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401618D RID: 90509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401618E RID: 90510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401618F RID: 90511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
