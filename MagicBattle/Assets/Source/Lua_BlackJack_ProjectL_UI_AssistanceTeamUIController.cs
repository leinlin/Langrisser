using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200138D RID: 5005
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController : LuaObject
{
	// Token: 0x0601B48D RID: 111757 RVA: 0x0083EB58 File Offset: 0x0083CD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAssistanceTeamInfo(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			HeroAssistantsTaskAssignment task;
			LuaObject.checkType<HeroAssistantsTaskAssignment>(l, 2, out task);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			assistanceTeamUIController.InitAssistanceTeamInfo(task, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B48E RID: 111758 RVA: 0x0083EBBC File Offset: 0x0083CDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTimeText(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			TimeSpan timeText;
			LuaObject.checkValueType<TimeSpan>(l, 2, out timeText);
			assistanceTeamUIController.SetTimeText(timeText);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B48F RID: 111759 RVA: 0x0083EC14 File Offset: 0x0083CE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			assistanceTeamUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B490 RID: 111760 RVA: 0x0083EC68 File Offset: 0x0083CE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierSpine(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			assistanceTeamUIController.m_luaExportHelper.SetSoldierSpine();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B491 RID: 111761 RVA: 0x0083ECBC File Offset: 0x0083CEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			assistanceTeamUIController.m_luaExportHelper.OnTrainingButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B492 RID: 111762 RVA: 0x0083ED10 File Offset: 0x0083CF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			assistanceTeamUIController.m_luaExportHelper.OnStopButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B493 RID: 111763 RVA: 0x0083ED64 File Offset: 0x0083CF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			assistanceTeamUIController.m_luaExportHelper.OnGetRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B494 RID: 111764 RVA: 0x0083EDB8 File Offset: 0x0083CFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			assistanceTeamUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B495 RID: 111765 RVA: 0x0083EE24 File Offset: 0x0083D024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			assistanceTeamUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B496 RID: 111766 RVA: 0x0083EE78 File Offset: 0x0083D078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			assistanceTeamUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B497 RID: 111767 RVA: 0x0083EECC File Offset: 0x0083D0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = assistanceTeamUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B498 RID: 111768 RVA: 0x0083EF74 File Offset: 0x0083D174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			assistanceTeamUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B499 RID: 111769 RVA: 0x0083EFC8 File Offset: 0x0083D1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			assistanceTeamUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B49A RID: 111770 RVA: 0x0083F034 File Offset: 0x0083D234
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
				AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				assistanceTeamUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				AssistanceTeamUIController assistanceTeamUIController2 = (AssistanceTeamUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				assistanceTeamUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B49B RID: 111771 RVA: 0x0083F144 File Offset: 0x0083D344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			assistanceTeamUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B49C RID: 111772 RVA: 0x0083F1B0 File Offset: 0x0083D3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			assistanceTeamUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B49D RID: 111773 RVA: 0x0083F21C File Offset: 0x0083D41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			assistanceTeamUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B49E RID: 111774 RVA: 0x0083F288 File Offset: 0x0083D488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			assistanceTeamUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B49F RID: 111775 RVA: 0x0083F2F4 File Offset: 0x0083D4F4
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
				AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				assistanceTeamUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				AssistanceTeamUIController assistanceTeamUIController2 = (AssistanceTeamUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				assistanceTeamUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B4A0 RID: 111776 RVA: 0x0083F404 File Offset: 0x0083D604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			string s = assistanceTeamUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B4A1 RID: 111777 RVA: 0x0083F460 File Offset: 0x0083D660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			assistanceTeamUIController.m_luaExportHelper.__callDele_EventOnTrainingButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4A2 RID: 111778 RVA: 0x0083F4BC File Offset: 0x0083D6BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			assistanceTeamUIController.m_luaExportHelper.__clearDele_EventOnTrainingButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4A3 RID: 111779 RVA: 0x0083F518 File Offset: 0x0083D718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			AssistanceTeamUIController obj;
			LuaObject.checkType<AssistanceTeamUIController>(l, 2, out obj);
			assistanceTeamUIController.m_luaExportHelper.__callDele_EventOnStopButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4A4 RID: 111780 RVA: 0x0083F574 File Offset: 0x0083D774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			AssistanceTeamUIController obj;
			LuaObject.checkType<AssistanceTeamUIController>(l, 2, out obj);
			assistanceTeamUIController.m_luaExportHelper.__clearDele_EventOnStopButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4A5 RID: 111781 RVA: 0x0083F5D0 File Offset: 0x0083D7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			AssistanceTeamUIController obj;
			LuaObject.checkType<AssistanceTeamUIController>(l, 2, out obj);
			assistanceTeamUIController.m_luaExportHelper.__callDele_EventOnGetRewardButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4A6 RID: 111782 RVA: 0x0083F62C File Offset: 0x0083D82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			AssistanceTeamUIController obj;
			LuaObject.checkType<AssistanceTeamUIController>(l, 2, out obj);
			assistanceTeamUIController.m_luaExportHelper.__clearDele_EventOnGetRewardButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4A7 RID: 111783 RVA: 0x0083F688 File Offset: 0x0083D888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					assistanceTeamUIController.EventOnTrainingButtonClick += value;
				}
				else if (num == 2)
				{
					assistanceTeamUIController.EventOnTrainingButtonClick -= value;
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

	// Token: 0x0601B4A8 RID: 111784 RVA: 0x0083F708 File Offset: 0x0083D908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStopButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Action<AssistanceTeamUIController> value;
			int num = LuaObject.checkDelegate<Action<AssistanceTeamUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					assistanceTeamUIController.EventOnStopButtonClick += value;
				}
				else if (num == 2)
				{
					assistanceTeamUIController.EventOnStopButtonClick -= value;
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

	// Token: 0x0601B4A9 RID: 111785 RVA: 0x0083F788 File Offset: 0x0083D988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Action<AssistanceTeamUIController> value;
			int num = LuaObject.checkDelegate<Action<AssistanceTeamUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					assistanceTeamUIController.EventOnGetRewardButtonClick += value;
				}
				else if (num == 2)
				{
					assistanceTeamUIController.EventOnGetRewardButtonClick -= value;
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

	// Token: 0x0601B4AA RID: 111786 RVA: 0x0083F808 File Offset: 0x0083DA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4AB RID: 111787 RVA: 0x0083F860 File Offset: 0x0083DA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			assistanceTeamUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4AC RID: 111788 RVA: 0x0083F8BC File Offset: 0x0083DABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_charGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4AD RID: 111789 RVA: 0x0083F914 File Offset: 0x0083DB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			GameObject charGameObject;
			LuaObject.checkType<GameObject>(l, 2, out charGameObject);
			assistanceTeamUIController.m_luaExportHelper.m_charGameObject = charGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4AE RID: 111790 RVA: 0x0083F970 File Offset: 0x0083DB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingButton(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_trainingButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4AF RID: 111791 RVA: 0x0083F9C8 File Offset: 0x0083DBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingButton(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Button trainingButton;
			LuaObject.checkType<Button>(l, 2, out trainingButton);
			assistanceTeamUIController.m_luaExportHelper.m_trainingButton = trainingButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B0 RID: 111792 RVA: 0x0083FA24 File Offset: 0x0083DC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stopButton(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_stopButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B1 RID: 111793 RVA: 0x0083FA7C File Offset: 0x0083DC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stopButton(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Button stopButton;
			LuaObject.checkType<Button>(l, 2, out stopButton);
			assistanceTeamUIController.m_luaExportHelper.m_stopButton = stopButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B2 RID: 111794 RVA: 0x0083FAD8 File Offset: 0x0083DCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getRewardButton(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_getRewardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B3 RID: 111795 RVA: 0x0083FB30 File Offset: 0x0083DD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getRewardButton(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Button getRewardButton;
			LuaObject.checkType<Button>(l, 2, out getRewardButton);
			assistanceTeamUIController.m_luaExportHelper.m_getRewardButton = getRewardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B4 RID: 111796 RVA: 0x0083FB8C File Offset: 0x0083DD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_difficultyText(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_difficultyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B5 RID: 111797 RVA: 0x0083FBE4 File Offset: 0x0083DDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_difficultyText(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Text difficultyText;
			LuaObject.checkType<Text>(l, 2, out difficultyText);
			assistanceTeamUIController.m_luaExportHelper.m_difficultyText = difficultyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B6 RID: 111798 RVA: 0x0083FC40 File Offset: 0x0083DE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeStateText(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_timeStateText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B7 RID: 111799 RVA: 0x0083FC98 File Offset: 0x0083DE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeStateText(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			Text timeStateText;
			LuaObject.checkType<Text>(l, 2, out timeStateText);
			assistanceTeamUIController.m_luaExportHelper.m_timeStateText = timeStateText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B8 RID: 111800 RVA: 0x0083FCF4 File Offset: 0x0083DEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_playerHeroGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4B9 RID: 111801 RVA: 0x0083FD4C File Offset: 0x0083DF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			UISpineGraphic playerHeroGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out playerHeroGraphic);
			assistanceTeamUIController.m_luaExportHelper.m_playerHeroGraphic = playerHeroGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4BA RID: 111802 RVA: 0x0083FDA8 File Offset: 0x0083DFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slot(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4BB RID: 111803 RVA: 0x0083FDFC File Offset: 0x0083DFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slot(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			assistanceTeamUIController.m_slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4BC RID: 111804 RVA: 0x0083FE54 File Offset: 0x0083E054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroAssistantsTask(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_heroAssistantsTask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4BD RID: 111805 RVA: 0x0083FEA8 File Offset: 0x0083E0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroAssistantsTask(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			HeroAssistantsTaskAssignment heroAssistantsTask;
			LuaObject.checkType<HeroAssistantsTaskAssignment>(l, 2, out heroAssistantsTask);
			assistanceTeamUIController.m_heroAssistantsTask = heroAssistantsTask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4BE RID: 111806 RVA: 0x0083FF00 File Offset: 0x0083E100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assistanceTeamUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4BF RID: 111807 RVA: 0x0083FF58 File Offset: 0x0083E158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			AssistanceTeamUIController assistanceTeamUIController = (AssistanceTeamUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			assistanceTeamUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4C0 RID: 111808 RVA: 0x0083FFB4 File Offset: 0x0083E1B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AssistanceTeamUIController");
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.InitAssistanceTeamInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.SetTimeText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.SetSoldierSpine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.OnTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.OnStopButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.OnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callDele_EventOnTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__clearDele_EventOnTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callDele_EventOnStopButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__clearDele_EventOnStopButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__callDele_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.__clearDele_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache19);
		string name = "EventOnTrainingButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_EventOnTrainingButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1A, true);
		string name2 = "EventOnStopButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_EventOnStopButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1B, true);
		string name3 = "EventOnGetRewardButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_EventOnGetRewardButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1C, true);
		string name4 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_stateCtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1E, true);
		string name5 = "m_charGameObject";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_charGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_charGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache20, true);
		string name6 = "m_trainingButton";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_trainingButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_trainingButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache22, true);
		string name7 = "m_stopButton";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_stopButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_stopButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache24, true);
		string name8 = "m_getRewardButton";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_getRewardButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_getRewardButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache26, true);
		string name9 = "m_difficultyText";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_difficultyText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_difficultyText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache28, true);
		string name10 = "m_timeStateText";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_timeStateText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_timeStateText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2A, true);
		string name11 = "m_playerHeroGraphic";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_playerHeroGraphic);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_playerHeroGraphic);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2C, true);
		string name12 = "m_slot";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_slot);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_slot);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2E, true);
		string name13 = "m_heroAssistantsTask";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_heroAssistantsTask);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_heroAssistantsTask);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache30, true);
		string name14 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.get_m_playerContext);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.<>f__mg$cache32, true);
		LuaObject.createTypeMetatable(l, null, typeof(AssistanceTeamUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011755 RID: 71509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011756 RID: 71510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011757 RID: 71511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011758 RID: 71512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011759 RID: 71513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401175A RID: 71514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401175B RID: 71515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401175C RID: 71516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401175D RID: 71517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401175E RID: 71518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401175F RID: 71519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011760 RID: 71520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011761 RID: 71521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011762 RID: 71522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011763 RID: 71523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011764 RID: 71524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011765 RID: 71525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011766 RID: 71526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011767 RID: 71527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011768 RID: 71528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011769 RID: 71529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401176A RID: 71530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401176B RID: 71531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401176C RID: 71532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401176D RID: 71533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401176E RID: 71534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401176F RID: 71535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011770 RID: 71536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011771 RID: 71537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011772 RID: 71538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011773 RID: 71539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011774 RID: 71540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011775 RID: 71541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011776 RID: 71542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011777 RID: 71543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011778 RID: 71544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011779 RID: 71545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401177A RID: 71546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401177B RID: 71547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401177C RID: 71548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401177D RID: 71549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401177E RID: 71550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401177F RID: 71551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011780 RID: 71552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011781 RID: 71553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011782 RID: 71554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011783 RID: 71555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011784 RID: 71556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011785 RID: 71557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011786 RID: 71558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011787 RID: 71559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
