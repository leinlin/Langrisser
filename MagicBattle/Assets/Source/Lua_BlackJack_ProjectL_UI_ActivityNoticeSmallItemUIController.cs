using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001354 RID: 4948
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController : LuaObject
{
	// Token: 0x0601A947 RID: 108871 RVA: 0x007E4E14 File Offset: 0x007E3014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateItemInfo(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			string resName;
			LuaObject.checkType(l, 3, out resName);
			string desc;
			LuaObject.checkType(l, 4, out desc);
			activityNoticeSmallItemUIController.UpdateItemInfo(activityId, resName, desc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A948 RID: 108872 RVA: 0x007E4E88 File Offset: 0x007E3088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			activityNoticeSmallItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A949 RID: 108873 RVA: 0x007E4EDC File Offset: 0x007E30DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			activityNoticeSmallItemUIController.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A94A RID: 108874 RVA: 0x007E4F30 File Offset: 0x007E3130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A94B RID: 108875 RVA: 0x007E4F9C File Offset: 0x007E319C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A94C RID: 108876 RVA: 0x007E4FF0 File Offset: 0x007E31F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A94D RID: 108877 RVA: 0x007E5044 File Offset: 0x007E3244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601A94E RID: 108878 RVA: 0x007E50EC File Offset: 0x007E32EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A94F RID: 108879 RVA: 0x007E5140 File Offset: 0x007E3340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A950 RID: 108880 RVA: 0x007E51AC File Offset: 0x007E33AC
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
				ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController2 = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				activityNoticeSmallItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601A951 RID: 108881 RVA: 0x007E52BC File Offset: 0x007E34BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A952 RID: 108882 RVA: 0x007E5328 File Offset: 0x007E3528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A953 RID: 108883 RVA: 0x007E5394 File Offset: 0x007E3594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A954 RID: 108884 RVA: 0x007E5400 File Offset: 0x007E3600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A955 RID: 108885 RVA: 0x007E546C File Offset: 0x007E366C
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
				ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController2 = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				activityNoticeSmallItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601A956 RID: 108886 RVA: 0x007E557C File Offset: 0x007E377C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			string s = activityNoticeSmallItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601A957 RID: 108887 RVA: 0x007E55D8 File Offset: 0x007E37D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			activityNoticeSmallItemUIController.m_luaExportHelper.__callDele_EventOnButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A958 RID: 108888 RVA: 0x007E5634 File Offset: 0x007E3834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			activityNoticeSmallItemUIController.m_luaExportHelper.__clearDele_EventOnButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A959 RID: 108889 RVA: 0x007E5690 File Offset: 0x007E3890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeSmallItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A95A RID: 108890 RVA: 0x007E56E8 File Offset: 0x007E38E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			activityNoticeSmallItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A95B RID: 108891 RVA: 0x007E5744 File Offset: 0x007E3944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeSmallItemUIController.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A95C RID: 108892 RVA: 0x007E579C File Offset: 0x007E399C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			activityNoticeSmallItemUIController.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A95D RID: 108893 RVA: 0x007E57F8 File Offset: 0x007E39F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descText(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeSmallItemUIController.m_luaExportHelper.m_descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A95E RID: 108894 RVA: 0x007E5850 File Offset: 0x007E3A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descText(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			activityNoticeSmallItemUIController.m_luaExportHelper.m_descText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A95F RID: 108895 RVA: 0x007E58AC File Offset: 0x007E3AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityNoticeSmallItemUIController.EventOnButtonClick += value;
				}
				else if (num == 2)
				{
					activityNoticeSmallItemUIController.EventOnButtonClick -= value;
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

	// Token: 0x0601A960 RID: 108896 RVA: 0x007E592C File Offset: 0x007E3B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeSmallItemUIController.ActivityId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A961 RID: 108897 RVA: 0x007E5980 File Offset: 0x007E3B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = (ActivityNoticeSmallItemUIController)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			activityNoticeSmallItemUIController.ActivityId = activityId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A962 RID: 108898 RVA: 0x007E59D8 File Offset: 0x007E3BD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityNoticeSmallItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.UpdateItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__callDele_EventOnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.__clearDele_EventOnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache11);
		string name = "m_button";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.get_m_button);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache13, true);
		string name2 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.get_m_image);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.set_m_image);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache15, true);
		string name3 = "m_descText";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.get_m_descText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.set_m_descText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache17, true);
		string name4 = "EventOnButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.set_EventOnButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache18, true);
		string name5 = "ActivityId";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.get_ActivityId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.set_ActivityId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.<>f__mg$cache1A, true);
		LuaObject.createTypeMetatable(l, null, typeof(ActivityNoticeSmallItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010C81 RID: 68737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010C82 RID: 68738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010C83 RID: 68739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010C84 RID: 68740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010C85 RID: 68741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010C86 RID: 68742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010C87 RID: 68743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010C88 RID: 68744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010C89 RID: 68745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010C8A RID: 68746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010C8B RID: 68747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010C8C RID: 68748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010C8D RID: 68749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010C8E RID: 68750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010C8F RID: 68751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010C90 RID: 68752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010C91 RID: 68753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010C92 RID: 68754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010C93 RID: 68755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010C94 RID: 68756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010C95 RID: 68757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010C96 RID: 68758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010C97 RID: 68759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010C98 RID: 68760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010C99 RID: 68761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010C9A RID: 68762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010C9B RID: 68763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
