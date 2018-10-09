using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001355 RID: 4949
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController : LuaObject
{
	// Token: 0x0601A964 RID: 108900 RVA: 0x007E5DCC File Offset: 0x007E3FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SignOpenTween(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.SignOpenTween();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A965 RID: 108901 RVA: 0x007E5E18 File Offset: 0x007E4018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateActivityList(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			List<ActivityNoticeInfo> activityList;
			LuaObject.checkType<List<ActivityNoticeInfo>>(l, 2, out activityList);
			activityNoticeUIController.UpdateActivityList(activityList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A966 RID: 108902 RVA: 0x007E5E70 File Offset: 0x007E4070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A967 RID: 108903 RVA: 0x007E5EC4 File Offset: 0x007E40C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshLampActive(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.RefreshLampActive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A968 RID: 108904 RVA: 0x007E5F18 File Offset: 0x007E4118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LateUpdate(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.LateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A969 RID: 108905 RVA: 0x007E5F6C File Offset: 0x007E416C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActivityItemClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			activityNoticeUIController.m_luaExportHelper.OnActivityItemClick(activityId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A96A RID: 108906 RVA: 0x007E5FC8 File Offset: 0x007E41C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A96B RID: 108907 RVA: 0x007E601C File Offset: 0x007E421C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			activityNoticeUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A96C RID: 108908 RVA: 0x007E6088 File Offset: 0x007E4288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A96D RID: 108909 RVA: 0x007E60DC File Offset: 0x007E42DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A96E RID: 108910 RVA: 0x007E6130 File Offset: 0x007E4330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = activityNoticeUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601A96F RID: 108911 RVA: 0x007E61D8 File Offset: 0x007E43D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A970 RID: 108912 RVA: 0x007E622C File Offset: 0x007E442C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			activityNoticeUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A971 RID: 108913 RVA: 0x007E6298 File Offset: 0x007E4498
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
				ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				activityNoticeUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ActivityNoticeUIController activityNoticeUIController2 = (ActivityNoticeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				activityNoticeUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601A972 RID: 108914 RVA: 0x007E63A8 File Offset: 0x007E45A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A973 RID: 108915 RVA: 0x007E6414 File Offset: 0x007E4614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A974 RID: 108916 RVA: 0x007E6480 File Offset: 0x007E4680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A975 RID: 108917 RVA: 0x007E64EC File Offset: 0x007E46EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A976 RID: 108918 RVA: 0x007E6558 File Offset: 0x007E4758
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
				ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				activityNoticeUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ActivityNoticeUIController activityNoticeUIController2 = (ActivityNoticeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				activityNoticeUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601A977 RID: 108919 RVA: 0x007E6668 File Offset: 0x007E4868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			string s = activityNoticeUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601A978 RID: 108920 RVA: 0x007E66C4 File Offset: 0x007E48C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnActivityClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			activityNoticeUIController.m_luaExportHelper.__callDele_EventOnActivityClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A979 RID: 108921 RVA: 0x007E6720 File Offset: 0x007E4920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnActivityClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			activityNoticeUIController.m_luaExportHelper.__clearDele_EventOnActivityClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A97A RID: 108922 RVA: 0x007E677C File Offset: 0x007E497C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.__callDele_EventOnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A97B RID: 108923 RVA: 0x007E67D0 File Offset: 0x007E49D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			activityNoticeUIController.m_luaExportHelper.__clearDele_EventOnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A97C RID: 108924 RVA: 0x007E6824 File Offset: 0x007E4A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A97D RID: 108925 RVA: 0x007E687C File Offset: 0x007E4A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			activityNoticeUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A97E RID: 108926 RVA: 0x007E68D8 File Offset: 0x007E4AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lampGroupObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_lampGroupObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A97F RID: 108927 RVA: 0x007E6930 File Offset: 0x007E4B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lampGroupObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObject lampGroupObj;
			LuaObject.checkType<GameObject>(l, 2, out lampGroupObj);
			activityNoticeUIController.m_luaExportHelper.m_lampGroupObj = lampGroupObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A980 RID: 108928 RVA: 0x007E698C File Offset: 0x007E4B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigActiveScrollViewContentObject(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_bigActiveScrollViewContentObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A981 RID: 108929 RVA: 0x007E69E4 File Offset: 0x007E4BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigActiveScrollViewContentObject(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObject bigActiveScrollViewContentObject;
			LuaObject.checkType<GameObject>(l, 2, out bigActiveScrollViewContentObject);
			activityNoticeUIController.m_luaExportHelper.m_bigActiveScrollViewContentObject = bigActiveScrollViewContentObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A982 RID: 108930 RVA: 0x007E6A40 File Offset: 0x007E4C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smallActiveScrollViewContentObject(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_smallActiveScrollViewContentObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A983 RID: 108931 RVA: 0x007E6A98 File Offset: 0x007E4C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smallActiveScrollViewContentObject(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObject smallActiveScrollViewContentObject;
			LuaObject.checkType<GameObject>(l, 2, out smallActiveScrollViewContentObject);
			activityNoticeUIController.m_luaExportHelper.m_smallActiveScrollViewContentObject = smallActiveScrollViewContentObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A984 RID: 108932 RVA: 0x007E6AF4 File Offset: 0x007E4CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lampPrefabObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_lampPrefabObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A985 RID: 108933 RVA: 0x007E6B4C File Offset: 0x007E4D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lampPrefabObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObject lampPrefabObj;
			LuaObject.checkType<GameObject>(l, 2, out lampPrefabObj);
			activityNoticeUIController.m_luaExportHelper.m_lampPrefabObj = lampPrefabObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A986 RID: 108934 RVA: 0x007E6BA8 File Offset: 0x007E4DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigActivePrefabObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_bigActivePrefabObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A987 RID: 108935 RVA: 0x007E6C00 File Offset: 0x007E4E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigActivePrefabObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObject bigActivePrefabObj;
			LuaObject.checkType<GameObject>(l, 2, out bigActivePrefabObj);
			activityNoticeUIController.m_luaExportHelper.m_bigActivePrefabObj = bigActivePrefabObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A988 RID: 108936 RVA: 0x007E6C5C File Offset: 0x007E4E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smallActivePrefabObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_smallActivePrefabObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A989 RID: 108937 RVA: 0x007E6CB4 File Offset: 0x007E4EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smallActivePrefabObj(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObject smallActivePrefabObj;
			LuaObject.checkType<GameObject>(l, 2, out smallActivePrefabObj);
			activityNoticeUIController.m_luaExportHelper.m_smallActivePrefabObj = smallActivePrefabObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A98A RID: 108938 RVA: 0x007E6D10 File Offset: 0x007E4F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_closeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A98B RID: 108939 RVA: 0x007E6D68 File Offset: 0x007E4F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			activityNoticeUIController.m_luaExportHelper.m_closeButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A98C RID: 108940 RVA: 0x007E6DC4 File Offset: 0x007E4FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigItemScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_bigItemScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A98D RID: 108941 RVA: 0x007E6E1C File Offset: 0x007E501C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigItemScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			ScrollRect bigItemScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out bigItemScrollRect);
			activityNoticeUIController.m_luaExportHelper.m_bigItemScrollRect = bigItemScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A98E RID: 108942 RVA: 0x007E6E78 File Offset: 0x007E5078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgCloseButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_bgCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A98F RID: 108943 RVA: 0x007E6ED0 File Offset: 0x007E50D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgCloseButton(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			Button bgCloseButton;
			LuaObject.checkType<Button>(l, 2, out bgCloseButton);
			activityNoticeUIController.m_luaExportHelper.m_bgCloseButton = bgCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A990 RID: 108944 RVA: 0x007E6F2C File Offset: 0x007E512C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnActivityClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityNoticeUIController.EventOnActivityClick += value;
				}
				else if (num == 2)
				{
					activityNoticeUIController.EventOnActivityClick -= value;
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

	// Token: 0x0601A991 RID: 108945 RVA: 0x007E6FAC File Offset: 0x007E51AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityNoticeUIController.EventOnCloseButtonClick += value;
				}
				else if (num == 2)
				{
					activityNoticeUIController.EventOnCloseButtonClick -= value;
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

	// Token: 0x0601A992 RID: 108946 RVA: 0x007E702C File Offset: 0x007E522C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigItemPool(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_bigItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A993 RID: 108947 RVA: 0x007E7084 File Offset: 0x007E5284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigItemPool(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObjectPool<ActivityNoticeBigItemUIController> bigItemPool;
			LuaObject.checkType<GameObjectPool<ActivityNoticeBigItemUIController>>(l, 2, out bigItemPool);
			activityNoticeUIController.m_luaExportHelper.m_bigItemPool = bigItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A994 RID: 108948 RVA: 0x007E70E0 File Offset: 0x007E52E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smallItemPool(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_smallItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A995 RID: 108949 RVA: 0x007E7138 File Offset: 0x007E5338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smallItemPool(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObjectPool<ActivityNoticeSmallItemUIController> smallItemPool;
			LuaObject.checkType<GameObjectPool<ActivityNoticeSmallItemUIController>>(l, 2, out smallItemPool);
			activityNoticeUIController.m_luaExportHelper.m_smallItemPool = smallItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A996 RID: 108950 RVA: 0x007E7194 File Offset: 0x007E5394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lampItemPool(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_lampItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A997 RID: 108951 RVA: 0x007E71EC File Offset: 0x007E53EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lampItemPool(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			GameObjectPool lampItemPool;
			LuaObject.checkType<GameObjectPool>(l, 2, out lampItemPool);
			activityNoticeUIController.m_luaExportHelper.m_lampItemPool = lampItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A998 RID: 108952 RVA: 0x007E7248 File Offset: 0x007E5448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lampUIStateCtrlList(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_lampUIStateCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A999 RID: 108953 RVA: 0x007E72A0 File Offset: 0x007E54A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lampUIStateCtrlList(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			List<CommonUIStateController> lampUIStateCtrlList;
			LuaObject.checkType<List<CommonUIStateController>>(l, 2, out lampUIStateCtrlList);
			activityNoticeUIController.m_luaExportHelper.m_lampUIStateCtrlList = lampUIStateCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A99A RID: 108954 RVA: 0x007E72FC File Offset: 0x007E54FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigItemScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_bigItemScrollSnapCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A99B RID: 108955 RVA: 0x007E7354 File Offset: 0x007E5554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigItemScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			ScrollSnapCenter bigItemScrollSnapCenter;
			LuaObject.checkType<ScrollSnapCenter>(l, 2, out bigItemScrollSnapCenter);
			activityNoticeUIController.m_luaExportHelper.m_bigItemScrollSnapCenter = bigItemScrollSnapCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A99C RID: 108956 RVA: 0x007E73B0 File Offset: 0x007E55B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curBigItemIndex(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeUIController.m_luaExportHelper.m_curBigItemIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A99D RID: 108957 RVA: 0x007E7408 File Offset: 0x007E5608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curBigItemIndex(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeUIController activityNoticeUIController = (ActivityNoticeUIController)LuaObject.checkSelf(l);
			int curBigItemIndex;
			LuaObject.checkType(l, 2, out curBigItemIndex);
			activityNoticeUIController.m_luaExportHelper.m_curBigItemIndex = curBigItemIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A99E RID: 108958 RVA: 0x007E7464 File Offset: 0x007E5664
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityNoticeUIController");
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.SignOpenTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.UpdateActivityList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.RefreshLampActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.LateUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.OnActivityItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callDele_EventOnActivityClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__clearDele_EventOnActivityClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__callDele_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.__clearDele_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache17);
		string name = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache19, true);
		string name2 = "m_lampGroupObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_lampGroupObj);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_lampGroupObj);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1B, true);
		string name3 = "m_bigActiveScrollViewContentObject";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_bigActiveScrollViewContentObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_bigActiveScrollViewContentObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1D, true);
		string name4 = "m_smallActiveScrollViewContentObject";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_smallActiveScrollViewContentObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_smallActiveScrollViewContentObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache1F, true);
		string name5 = "m_lampPrefabObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_lampPrefabObj);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_lampPrefabObj);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache21, true);
		string name6 = "m_bigActivePrefabObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_bigActivePrefabObj);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_bigActivePrefabObj);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache23, true);
		string name7 = "m_smallActivePrefabObj";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_smallActivePrefabObj);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_smallActivePrefabObj);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache25, true);
		string name8 = "m_closeButton";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_closeButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_closeButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache27, true);
		string name9 = "m_bigItemScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_bigItemScrollRect);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_bigItemScrollRect);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache29, true);
		string name10 = "m_bgCloseButton";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_bgCloseButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_bgCloseButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2B, true);
		string name11 = "EventOnActivityClick";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_EventOnActivityClick);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2C, true);
		string name12 = "EventOnCloseButtonClick";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2D, true);
		string name13 = "m_bigItemPool";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_bigItemPool);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_bigItemPool);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache2F, true);
		string name14 = "m_smallItemPool";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_smallItemPool);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_smallItemPool);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache31, true);
		string name15 = "m_lampItemPool";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_lampItemPool);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_lampItemPool);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache33, true);
		string name16 = "m_lampUIStateCtrlList";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_lampUIStateCtrlList);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_lampUIStateCtrlList);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache35, true);
		string name17 = "m_bigItemScrollSnapCenter";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_bigItemScrollSnapCenter);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_bigItemScrollSnapCenter);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache37, true);
		string name18 = "m_curBigItemIndex";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.get_m_curBigItemIndex);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.set_m_curBigItemIndex);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.<>f__mg$cache39, true);
		LuaObject.createTypeMetatable(l, null, typeof(ActivityNoticeUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010C9C RID: 68764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010C9D RID: 68765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010C9E RID: 68766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010C9F RID: 68767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010CA0 RID: 68768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010CA1 RID: 68769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010CA2 RID: 68770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010CA3 RID: 68771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010CA4 RID: 68772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010CA5 RID: 68773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010CA6 RID: 68774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010CA7 RID: 68775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010CA8 RID: 68776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010CA9 RID: 68777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010CAA RID: 68778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010CAB RID: 68779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010CAC RID: 68780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010CAD RID: 68781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010CAE RID: 68782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010CAF RID: 68783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010CB0 RID: 68784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010CB1 RID: 68785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010CB2 RID: 68786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010CB3 RID: 68787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010CB4 RID: 68788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010CB5 RID: 68789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010CB6 RID: 68790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010CB7 RID: 68791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010CB8 RID: 68792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010CB9 RID: 68793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010CBA RID: 68794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010CBB RID: 68795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010CBC RID: 68796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010CBD RID: 68797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010CBE RID: 68798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010CBF RID: 68799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010CC0 RID: 68800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010CC1 RID: 68801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010CC2 RID: 68802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010CC3 RID: 68803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010CC4 RID: 68804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010CC5 RID: 68805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010CC6 RID: 68806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010CC7 RID: 68807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010CC8 RID: 68808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010CC9 RID: 68809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010CCA RID: 68810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010CCB RID: 68811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010CCC RID: 68812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010CCD RID: 68813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010CCE RID: 68814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010CCF RID: 68815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010CD0 RID: 68816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010CD1 RID: 68817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010CD2 RID: 68818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010CD3 RID: 68819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010CD4 RID: 68820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010CD5 RID: 68821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;
}
