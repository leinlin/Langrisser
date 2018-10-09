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

// Token: 0x0200140A RID: 5130
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CourseItemUIController : LuaObject
{
	// Token: 0x0601CFA7 RID: 118695 RVA: 0x009162A4 File Offset: 0x009144A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitCourseInfo(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			TrainingCourse course;
			LuaObject.checkType<TrainingCourse>(l, 2, out course);
			courseItemUIController.InitCourseInfo(course);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFA8 RID: 118696 RVA: 0x009162FC File Offset: 0x009144FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowSelectFrame(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			courseItemUIController.ShowSelectFrame(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFA9 RID: 118697 RVA: 0x00916354 File Offset: 0x00914554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			courseItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFAA RID: 118698 RVA: 0x009163A8 File Offset: 0x009145A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCourseItemClick(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			courseItemUIController.m_luaExportHelper.OnCourseItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFAB RID: 118699 RVA: 0x009163FC File Offset: 0x009145FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			courseItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFAC RID: 118700 RVA: 0x00916468 File Offset: 0x00914668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			courseItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFAD RID: 118701 RVA: 0x009164BC File Offset: 0x009146BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			courseItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFAE RID: 118702 RVA: 0x00916510 File Offset: 0x00914710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = courseItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CFAF RID: 118703 RVA: 0x009165B8 File Offset: 0x009147B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			courseItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFB0 RID: 118704 RVA: 0x0091660C File Offset: 0x0091480C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			courseItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFB1 RID: 118705 RVA: 0x00916678 File Offset: 0x00914878
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
				CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				courseItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CourseItemUIController courseItemUIController2 = (CourseItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				courseItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CFB2 RID: 118706 RVA: 0x00916788 File Offset: 0x00914988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			courseItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFB3 RID: 118707 RVA: 0x009167F4 File Offset: 0x009149F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			courseItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFB4 RID: 118708 RVA: 0x00916860 File Offset: 0x00914A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			courseItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFB5 RID: 118709 RVA: 0x009168CC File Offset: 0x00914ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			courseItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFB6 RID: 118710 RVA: 0x00916938 File Offset: 0x00914B38
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
				CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				courseItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CourseItemUIController courseItemUIController2 = (CourseItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				courseItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CFB7 RID: 118711 RVA: 0x00916A48 File Offset: 0x00914C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			string s = courseItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CFB8 RID: 118712 RVA: 0x00916AA4 File Offset: 0x00914CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCourseItemClick(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			CourseItemUIController obj;
			LuaObject.checkType<CourseItemUIController>(l, 2, out obj);
			courseItemUIController.m_luaExportHelper.__callDele_EventOnCourseItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFB9 RID: 118713 RVA: 0x00916B00 File Offset: 0x00914D00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnCourseItemClick(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			CourseItemUIController obj;
			LuaObject.checkType<CourseItemUIController>(l, 2, out obj);
			courseItemUIController.m_luaExportHelper.__clearDele_EventOnCourseItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFBA RID: 118714 RVA: 0x00916B5C File Offset: 0x00914D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCourseItemClick(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			Action<CourseItemUIController> value;
			int num = LuaObject.checkDelegate<Action<CourseItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					courseItemUIController.EventOnCourseItemClick += value;
				}
				else if (num == 2)
				{
					courseItemUIController.EventOnCourseItemClick -= value;
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

	// Token: 0x0601CFBB RID: 118715 RVA: 0x00916BDC File Offset: 0x00914DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFBC RID: 118716 RVA: 0x00916C34 File Offset: 0x00914E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			courseItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFBD RID: 118717 RVA: 0x00916C90 File Offset: 0x00914E90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFBE RID: 118718 RVA: 0x00916CE8 File Offset: 0x00914EE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			courseItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFBF RID: 118719 RVA: 0x00916D44 File Offset: 0x00914F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressBar(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_progressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC0 RID: 118720 RVA: 0x00916D9C File Offset: 0x00914F9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_progressBar(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			Image progressBar;
			LuaObject.checkType<Image>(l, 2, out progressBar);
			courseItemUIController.m_luaExportHelper.m_progressBar = progressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC1 RID: 118721 RVA: 0x00916DF8 File Offset: 0x00914FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_point(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_point);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC2 RID: 118722 RVA: 0x00916E50 File Offset: 0x00915050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_point(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			GameObject point;
			LuaObject.checkType<GameObject>(l, 2, out point);
			courseItemUIController.m_luaExportHelper.m_point = point;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC3 RID: 118723 RVA: 0x00916EAC File Offset: 0x009150AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC4 RID: 118724 RVA: 0x00916F04 File Offset: 0x00915104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			courseItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC5 RID: 118725 RVA: 0x00916F60 File Offset: 0x00915160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_valueText(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_valueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC6 RID: 118726 RVA: 0x00916FB8 File Offset: 0x009151B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_valueText(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			Text valueText;
			LuaObject.checkType<Text>(l, 2, out valueText);
			courseItemUIController.m_luaExportHelper.m_valueText = valueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC7 RID: 118727 RVA: 0x00917014 File Offset: 0x00915214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maxText(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_maxText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC8 RID: 118728 RVA: 0x0091706C File Offset: 0x0091526C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_maxText(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			GameObject maxText;
			LuaObject.checkType<GameObject>(l, 2, out maxText);
			courseItemUIController.m_luaExportHelper.m_maxText = maxText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFC9 RID: 118729 RVA: 0x009170C8 File Offset: 0x009152C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockNameText(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_lockNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFCA RID: 118730 RVA: 0x00917120 File Offset: 0x00915320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockNameText(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			Text lockNameText;
			LuaObject.checkType<Text>(l, 2, out lockNameText);
			courseItemUIController.m_luaExportHelper.m_lockNameText = lockNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFCB RID: 118731 RVA: 0x0091717C File Offset: 0x0091537C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_luaExportHelper.m_redMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFCC RID: 118732 RVA: 0x009171D4 File Offset: 0x009153D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			GameObject redMark;
			LuaObject.checkType<GameObject>(l, 2, out redMark);
			courseItemUIController.m_luaExportHelper.m_redMark = redMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFCD RID: 118733 RVA: 0x00917230 File Offset: 0x00915430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingCourse(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, courseItemUIController.m_trainingCourse);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFCE RID: 118734 RVA: 0x00917284 File Offset: 0x00915484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingCourse(IntPtr l)
	{
		int result;
		try
		{
			CourseItemUIController courseItemUIController = (CourseItemUIController)LuaObject.checkSelf(l);
			TrainingCourse trainingCourse;
			LuaObject.checkType<TrainingCourse>(l, 2, out trainingCourse);
			courseItemUIController.m_trainingCourse = trainingCourse;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFCF RID: 118735 RVA: 0x009172DC File Offset: 0x009154DC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CourseItemUIController");
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.InitCourseInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.ShowSelectFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.OnCourseItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__callDele_EventOnCourseItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.__clearDele_EventOnCourseItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache12);
		string name = "EventOnCourseItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_EventOnCourseItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache13, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache15, true);
		string name3 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_button);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache17, true);
		string name4 = "m_progressBar";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_progressBar);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_progressBar);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache19, true);
		string name5 = "m_point";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_point);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_point);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_nameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_valueText";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_valueText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_valueText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache1F, true);
		string name8 = "m_maxText";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_maxText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_maxText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache21, true);
		string name9 = "m_lockNameText";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_lockNameText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_lockNameText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache23, true);
		string name10 = "m_redMark";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_redMark);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_redMark);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache25, true);
		string name11 = "m_trainingCourse";
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.get_m_trainingCourse);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CourseItemUIController.set_m_trainingCourse);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_CourseItemUIController.<>f__mg$cache27, true);
		LuaObject.createTypeMetatable(l, null, typeof(CourseItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013175 RID: 78197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013176 RID: 78198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013177 RID: 78199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013178 RID: 78200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013179 RID: 78201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401317A RID: 78202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401317B RID: 78203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401317C RID: 78204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401317D RID: 78205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401317E RID: 78206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401317F RID: 78207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013180 RID: 78208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013181 RID: 78209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013182 RID: 78210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013183 RID: 78211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013184 RID: 78212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013185 RID: 78213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013186 RID: 78214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013187 RID: 78215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013188 RID: 78216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013189 RID: 78217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401318A RID: 78218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401318B RID: 78219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401318C RID: 78220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401318D RID: 78221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401318E RID: 78222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401318F RID: 78223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013190 RID: 78224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013191 RID: 78225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013192 RID: 78226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013193 RID: 78227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013194 RID: 78228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013195 RID: 78229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013196 RID: 78230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013197 RID: 78231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013198 RID: 78232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013199 RID: 78233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401319A RID: 78234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401319B RID: 78235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401319C RID: 78236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
