using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001413 RID: 5139
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DayButtonUIController : LuaObject
{
	// Token: 0x0601D0CB RID: 118987 RVA: 0x0091F600 File Offset: 0x0091D800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDayButtonInfo(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			int day;
			LuaObject.checkType(l, 2, out day);
			dayButtonUIController.InitDayButtonInfo(day);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0CC RID: 118988 RVA: 0x0091F658 File Offset: 0x0091D858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectFrame(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			dayButtonUIController.ShowSelectFrame(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0CD RID: 118989 RVA: 0x0091F6B0 File Offset: 0x0091D8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			dayButtonUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0CE RID: 118990 RVA: 0x0091F704 File Offset: 0x0091D904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			dayButtonUIController.m_luaExportHelper.OnDayButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0CF RID: 118991 RVA: 0x0091F758 File Offset: 0x0091D958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			dayButtonUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0D0 RID: 118992 RVA: 0x0091F7C4 File Offset: 0x0091D9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			dayButtonUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0D1 RID: 118993 RVA: 0x0091F818 File Offset: 0x0091DA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			dayButtonUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0D2 RID: 118994 RVA: 0x0091F86C File Offset: 0x0091DA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = dayButtonUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D0D3 RID: 118995 RVA: 0x0091F914 File Offset: 0x0091DB14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			dayButtonUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0D4 RID: 118996 RVA: 0x0091F968 File Offset: 0x0091DB68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			dayButtonUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0D5 RID: 118997 RVA: 0x0091F9D4 File Offset: 0x0091DBD4
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
				DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				dayButtonUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DayButtonUIController dayButtonUIController2 = (DayButtonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				dayButtonUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D0D6 RID: 118998 RVA: 0x0091FAE4 File Offset: 0x0091DCE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dayButtonUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0D7 RID: 118999 RVA: 0x0091FB50 File Offset: 0x0091DD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dayButtonUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0D8 RID: 119000 RVA: 0x0091FBBC File Offset: 0x0091DDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dayButtonUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0D9 RID: 119001 RVA: 0x0091FC28 File Offset: 0x0091DE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dayButtonUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0DA RID: 119002 RVA: 0x0091FC94 File Offset: 0x0091DE94
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
				DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				dayButtonUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DayButtonUIController dayButtonUIController2 = (DayButtonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				dayButtonUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D0DB RID: 119003 RVA: 0x0091FDA4 File Offset: 0x0091DFA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			string s = dayButtonUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D0DC RID: 119004 RVA: 0x0091FE00 File Offset: 0x0091E000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnDayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			DayButtonUIController obj;
			LuaObject.checkType<DayButtonUIController>(l, 2, out obj);
			dayButtonUIController.m_luaExportHelper.__callDele_EventOnDayButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0DD RID: 119005 RVA: 0x0091FE5C File Offset: 0x0091E05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			DayButtonUIController obj;
			LuaObject.checkType<DayButtonUIController>(l, 2, out obj);
			dayButtonUIController.m_luaExportHelper.__clearDele_EventOnDayButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0DE RID: 119006 RVA: 0x0091FEB8 File Offset: 0x0091E0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			Action<DayButtonUIController> value;
			int num = LuaObject.checkDelegate<Action<DayButtonUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					dayButtonUIController.EventOnDayButtonClick += value;
				}
				else if (num == 2)
				{
					dayButtonUIController.EventOnDayButtonClick -= value;
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

	// Token: 0x0601D0DF RID: 119007 RVA: 0x0091FF38 File Offset: 0x0091E138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dayButtonUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E0 RID: 119008 RVA: 0x0091FF90 File Offset: 0x0091E190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			dayButtonUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E1 RID: 119009 RVA: 0x0091FFEC File Offset: 0x0091E1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dayButtonUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E2 RID: 119010 RVA: 0x00920044 File Offset: 0x0091E244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			dayButtonUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E3 RID: 119011 RVA: 0x009200A0 File Offset: 0x0091E2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dayButtonUIController.m_luaExportHelper.m_redMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E4 RID: 119012 RVA: 0x009200F8 File Offset: 0x0091E2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			GameObject redMark;
			LuaObject.checkType<GameObject>(l, 2, out redMark);
			dayButtonUIController.m_luaExportHelper.m_redMark = redMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E5 RID: 119013 RVA: 0x00920154 File Offset: 0x0091E354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dayButtonUIController.m_luaExportHelper.m_isLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E6 RID: 119014 RVA: 0x009201AC File Offset: 0x0091E3AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			bool isLocked;
			LuaObject.checkType(l, 2, out isLocked);
			dayButtonUIController.m_luaExportHelper.m_isLocked = isLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E7 RID: 119015 RVA: 0x00920208 File Offset: 0x0091E408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Day(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dayButtonUIController.Day);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E8 RID: 119016 RVA: 0x0092025C File Offset: 0x0091E45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Day(IntPtr l)
	{
		int result;
		try
		{
			DayButtonUIController dayButtonUIController = (DayButtonUIController)LuaObject.checkSelf(l);
			int day;
			LuaObject.checkType(l, 2, out day);
			dayButtonUIController.m_luaExportHelper.Day = day;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0E9 RID: 119017 RVA: 0x009202B8 File Offset: 0x0091E4B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DayButtonUIController");
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.InitDayButtonInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.ShowSelectFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.OnDayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__callDele_EventOnDayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.__clearDele_EventOnDayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache12);
		string name = "EventOnDayButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.set_EventOnDayButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache13, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache15, true);
		string name3 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.get_m_button);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.set_m_button);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache17, true);
		string name4 = "m_redMark";
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.get_m_redMark);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.set_m_redMark);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache19, true);
		string name5 = "m_isLocked";
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.get_m_isLocked);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.set_m_isLocked);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1B, true);
		string name6 = "Day";
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.get_Day);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DayButtonUIController.set_Day);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DayButtonUIController.<>f__mg$cache1D, true);
		LuaObject.createTypeMetatable(l, null, typeof(DayButtonUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013287 RID: 78471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013288 RID: 78472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013289 RID: 78473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401328A RID: 78474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401328B RID: 78475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401328C RID: 78476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401328D RID: 78477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401328E RID: 78478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401328F RID: 78479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013290 RID: 78480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013291 RID: 78481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013292 RID: 78482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013293 RID: 78483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013294 RID: 78484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013295 RID: 78485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013296 RID: 78486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013297 RID: 78487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013298 RID: 78488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013299 RID: 78489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401329A RID: 78490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401329B RID: 78491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401329C RID: 78492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401329D RID: 78493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401329E RID: 78494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401329F RID: 78495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040132A0 RID: 78496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040132A1 RID: 78497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040132A2 RID: 78498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040132A3 RID: 78499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040132A4 RID: 78500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
