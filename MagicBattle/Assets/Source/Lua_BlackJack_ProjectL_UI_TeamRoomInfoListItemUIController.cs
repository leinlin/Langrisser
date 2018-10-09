using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001598 RID: 5528
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController : LuaObject
{
	// Token: 0x060216A2 RID: 136866 RVA: 0x00B4B93C File Offset: 0x00B49B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			teamRoomInfoListItemUIController.SetText(text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216A3 RID: 136867 RVA: 0x00B4B994 File Offset: 0x00B49B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTextAlpha(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			float textAlpha;
			LuaObject.checkType(l, 2, out textAlpha);
			teamRoomInfoListItemUIController.SetTextAlpha(textAlpha);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216A4 RID: 136868 RVA: 0x00B4B9EC File Offset: 0x00B49BEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			teamRoomInfoListItemUIController.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216A5 RID: 136869 RVA: 0x00B4BA44 File Offset: 0x00B49C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int index = teamRoomInfoListItemUIController.GetIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216A6 RID: 136870 RVA: 0x00B4BA98 File Offset: 0x00B49C98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetValue(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			teamRoomInfoListItemUIController.SetValue(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216A7 RID: 136871 RVA: 0x00B4BAF0 File Offset: 0x00B49CF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetValue(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int value = teamRoomInfoListItemUIController.GetValue();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216A8 RID: 136872 RVA: 0x00B4BB44 File Offset: 0x00B49D44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetValue2(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			teamRoomInfoListItemUIController.SetValue2(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216A9 RID: 136873 RVA: 0x00B4BB9C File Offset: 0x00B49D9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetValue2(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int value = teamRoomInfoListItemUIController.GetValue2();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216AA RID: 136874 RVA: 0x00B4BBF0 File Offset: 0x00B49DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			teamRoomInfoListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216AB RID: 136875 RVA: 0x00B4BC48 File Offset: 0x00B49E48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			bool b = teamRoomInfoListItemUIController.IsLocked();
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

	// Token: 0x060216AC RID: 136876 RVA: 0x00B4BC9C File Offset: 0x00B49E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			teamRoomInfoListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216AD RID: 136877 RVA: 0x00B4BCF0 File Offset: 0x00B49EF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			teamRoomInfoListItemUIController.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216AE RID: 136878 RVA: 0x00B4BD44 File Offset: 0x00B49F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216AF RID: 136879 RVA: 0x00B4BDB0 File Offset: 0x00B49FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216B0 RID: 136880 RVA: 0x00B4BE04 File Offset: 0x00B4A004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216B1 RID: 136881 RVA: 0x00B4BE58 File Offset: 0x00B4A058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060216B2 RID: 136882 RVA: 0x00B4BF00 File Offset: 0x00B4A100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216B3 RID: 136883 RVA: 0x00B4BF54 File Offset: 0x00B4A154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216B4 RID: 136884 RVA: 0x00B4BFC0 File Offset: 0x00B4A1C0
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
				TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamRoomInfoListItemUIController teamRoomInfoListItemUIController2 = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamRoomInfoListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060216B5 RID: 136885 RVA: 0x00B4C0D0 File Offset: 0x00B4A2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216B6 RID: 136886 RVA: 0x00B4C13C File Offset: 0x00B4A33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216B7 RID: 136887 RVA: 0x00B4C1A8 File Offset: 0x00B4A3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216B8 RID: 136888 RVA: 0x00B4C214 File Offset: 0x00B4A414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216B9 RID: 136889 RVA: 0x00B4C280 File Offset: 0x00B4A480
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
				TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamRoomInfoListItemUIController teamRoomInfoListItemUIController2 = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamRoomInfoListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060216BA RID: 136890 RVA: 0x00B4C390 File Offset: 0x00B4A590
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			string s = teamRoomInfoListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060216BB RID: 136891 RVA: 0x00B4C3EC File Offset: 0x00B4A5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			TeamRoomInfoListItemUIController obj;
			LuaObject.checkType<TeamRoomInfoListItemUIController>(l, 2, out obj);
			teamRoomInfoListItemUIController.m_luaExportHelper.__callDele_EventOnButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216BC RID: 136892 RVA: 0x00B4C448 File Offset: 0x00B4A648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			TeamRoomInfoListItemUIController obj;
			LuaObject.checkType<TeamRoomInfoListItemUIController>(l, 2, out obj);
			teamRoomInfoListItemUIController.m_luaExportHelper.__clearDele_EventOnButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216BD RID: 136893 RVA: 0x00B4C4A4 File Offset: 0x00B4A6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			Action<TeamRoomInfoListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomInfoListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomInfoListItemUIController.EventOnButtonClick += value;
				}
				else if (num == 2)
				{
					teamRoomInfoListItemUIController.EventOnButtonClick -= value;
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

	// Token: 0x060216BE RID: 136894 RVA: 0x00B4C524 File Offset: 0x00B4A724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoListItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216BF RID: 136895 RVA: 0x00B4C57C File Offset: 0x00B4A77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			teamRoomInfoListItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C0 RID: 136896 RVA: 0x00B4C5D8 File Offset: 0x00B4A7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoListItemUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C1 RID: 136897 RVA: 0x00B4C630 File Offset: 0x00B4A830
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			teamRoomInfoListItemUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C2 RID: 136898 RVA: 0x00B4C68C File Offset: 0x00B4A88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoListItemUIController.m_luaExportHelper.m_lockGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C3 RID: 136899 RVA: 0x00B4C6E4 File Offset: 0x00B4A8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			GameObject lockGameObject;
			LuaObject.checkType<GameObject>(l, 2, out lockGameObject);
			teamRoomInfoListItemUIController.m_luaExportHelper.m_lockGameObject = lockGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C4 RID: 136900 RVA: 0x00B4C740 File Offset: 0x00B4A940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoListItemUIController.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C5 RID: 136901 RVA: 0x00B4C798 File Offset: 0x00B4A998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			teamRoomInfoListItemUIController.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C6 RID: 136902 RVA: 0x00B4C7F4 File Offset: 0x00B4A9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_value(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoListItemUIController.m_luaExportHelper.m_value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C7 RID: 136903 RVA: 0x00B4C84C File Offset: 0x00B4AA4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_value(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			teamRoomInfoListItemUIController.m_luaExportHelper.m_value = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C8 RID: 136904 RVA: 0x00B4C8A8 File Offset: 0x00B4AAA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_value2(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoListItemUIController.m_luaExportHelper.m_value2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216C9 RID: 136905 RVA: 0x00B4C900 File Offset: 0x00B4AB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_value2(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			teamRoomInfoListItemUIController.m_luaExportHelper.m_value2 = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216CA RID: 136906 RVA: 0x00B4C95C File Offset: 0x00B4AB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInfoListItemUIController.m_luaExportHelper.m_isLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216CB RID: 136907 RVA: 0x00B4C9B4 File Offset: 0x00B4ABB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = (TeamRoomInfoListItemUIController)LuaObject.checkSelf(l);
			bool isLocked;
			LuaObject.checkType(l, 2, out isLocked);
			teamRoomInfoListItemUIController.m_luaExportHelper.m_isLocked = isLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216CC RID: 136908 RVA: 0x00B4CA10 File Offset: 0x00B4AC10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInfoListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.SetText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.SetTextAlpha);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.SetValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.GetValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.SetValue2);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.GetValue2);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.IsLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__callDele_EventOnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.__clearDele_EventOnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1A);
		string name = "EventOnButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.set_EventOnButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1B, true);
		string name2 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.get_m_button);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1D, true);
		string name3 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.get_m_text);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.set_m_text);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache1F, true);
		string name4 = "m_lockGameObject";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.get_m_lockGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.set_m_lockGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache21, true);
		string name5 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.get_m_index);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.set_m_index);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache23, true);
		string name6 = "m_value";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.get_m_value);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.set_m_value);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache25, true);
		string name7 = "m_value2";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.get_m_value2);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.set_m_value2);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache27, true);
		string name8 = "m_isLocked";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.get_m_isLocked);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.set_m_isLocked);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.<>f__mg$cache29, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamRoomInfoListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017554 RID: 95572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017555 RID: 95573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017556 RID: 95574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017557 RID: 95575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017558 RID: 95576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017559 RID: 95577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401755A RID: 95578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401755B RID: 95579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401755C RID: 95580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401755D RID: 95581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401755E RID: 95582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401755F RID: 95583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017560 RID: 95584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017561 RID: 95585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017562 RID: 95586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017563 RID: 95587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017564 RID: 95588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017565 RID: 95589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017566 RID: 95590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017567 RID: 95591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017568 RID: 95592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017569 RID: 95593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401756A RID: 95594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401756B RID: 95595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401756C RID: 95596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401756D RID: 95597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401756E RID: 95598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401756F RID: 95599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017570 RID: 95600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017571 RID: 95601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017572 RID: 95602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017573 RID: 95603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017574 RID: 95604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017575 RID: 95605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017576 RID: 95606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017577 RID: 95607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017578 RID: 95608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017579 RID: 95609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401757A RID: 95610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401757B RID: 95611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401757C RID: 95612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401757D RID: 95613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
