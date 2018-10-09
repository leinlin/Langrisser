using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001352 RID: 4946
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController : LuaObject
{
	// Token: 0x0601A91C RID: 108828 RVA: 0x007E3894 File Offset: 0x007E1A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateItemInfo(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			string resName;
			LuaObject.checkType(l, 3, out resName);
			int index;
			LuaObject.checkType(l, 4, out index);
			activityNoticeBigItemUIController.UpdateItemInfo(activityId, resName, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A91D RID: 108829 RVA: 0x007E3908 File Offset: 0x007E1B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			int index = activityNoticeBigItemUIController.GetIndex();
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

	// Token: 0x0601A91E RID: 108830 RVA: 0x007E395C File Offset: 0x007E1B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			activityNoticeBigItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A91F RID: 108831 RVA: 0x007E39B0 File Offset: 0x007E1BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			activityNoticeBigItemUIController.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A920 RID: 108832 RVA: 0x007E3A04 File Offset: 0x007E1C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A921 RID: 108833 RVA: 0x007E3A70 File Offset: 0x007E1C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A922 RID: 108834 RVA: 0x007E3AC4 File Offset: 0x007E1CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A923 RID: 108835 RVA: 0x007E3B18 File Offset: 0x007E1D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = activityNoticeBigItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601A924 RID: 108836 RVA: 0x007E3BC0 File Offset: 0x007E1DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A925 RID: 108837 RVA: 0x007E3C14 File Offset: 0x007E1E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A926 RID: 108838 RVA: 0x007E3C80 File Offset: 0x007E1E80
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
				ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				activityNoticeBigItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ActivityNoticeBigItemUIController activityNoticeBigItemUIController2 = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				activityNoticeBigItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601A927 RID: 108839 RVA: 0x007E3D90 File Offset: 0x007E1F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A928 RID: 108840 RVA: 0x007E3DFC File Offset: 0x007E1FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A929 RID: 108841 RVA: 0x007E3E68 File Offset: 0x007E2068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A92A RID: 108842 RVA: 0x007E3ED4 File Offset: 0x007E20D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			activityNoticeBigItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A92B RID: 108843 RVA: 0x007E3F40 File Offset: 0x007E2140
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
				ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				activityNoticeBigItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ActivityNoticeBigItemUIController activityNoticeBigItemUIController2 = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				activityNoticeBigItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601A92C RID: 108844 RVA: 0x007E4050 File Offset: 0x007E2250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			string s = activityNoticeBigItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601A92D RID: 108845 RVA: 0x007E40AC File Offset: 0x007E22AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			activityNoticeBigItemUIController.m_luaExportHelper.__callDele_EventOnButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A92E RID: 108846 RVA: 0x007E4108 File Offset: 0x007E2308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			activityNoticeBigItemUIController.m_luaExportHelper.__clearDele_EventOnButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A92F RID: 108847 RVA: 0x007E4164 File Offset: 0x007E2364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeBigItemUIController.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A930 RID: 108848 RVA: 0x007E41BC File Offset: 0x007E23BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			activityNoticeBigItemUIController.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A931 RID: 108849 RVA: 0x007E4218 File Offset: 0x007E2418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeBigItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A932 RID: 108850 RVA: 0x007E4270 File Offset: 0x007E2470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			activityNoticeBigItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A933 RID: 108851 RVA: 0x007E42CC File Offset: 0x007E24CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					activityNoticeBigItemUIController.EventOnButtonClick += value;
				}
				else if (num == 2)
				{
					activityNoticeBigItemUIController.EventOnButtonClick -= value;
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

	// Token: 0x0601A934 RID: 108852 RVA: 0x007E434C File Offset: 0x007E254C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeBigItemUIController.ActivityId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A935 RID: 108853 RVA: 0x007E43A0 File Offset: 0x007E25A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			activityNoticeBigItemUIController.ActivityId = activityId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A936 RID: 108854 RVA: 0x007E43F8 File Offset: 0x007E25F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activityNoticeBigItemUIController.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A937 RID: 108855 RVA: 0x007E4450 File Offset: 0x007E2650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = (ActivityNoticeBigItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			activityNoticeBigItemUIController.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A938 RID: 108856 RVA: 0x007E44AC File Offset: 0x007E26AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityNoticeBigItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.UpdateItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__callDele_EventOnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.__clearDele_EventOnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache12);
		string name = "m_image";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.get_m_image);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.set_m_image);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache14, true);
		string name2 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.get_m_button);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache16, true);
		string name3 = "EventOnButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.set_EventOnButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache17, true);
		string name4 = "ActivityId";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.get_ActivityId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.set_ActivityId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache19, true);
		string name5 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.get_m_index);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.set_m_index);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.<>f__mg$cache1B, true);
		LuaObject.createTypeMetatable(l, null, typeof(ActivityNoticeBigItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010C5A RID: 68698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010C5B RID: 68699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010C5C RID: 68700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010C5D RID: 68701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010C5E RID: 68702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010C5F RID: 68703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010C60 RID: 68704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010C61 RID: 68705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010C62 RID: 68706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010C63 RID: 68707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010C64 RID: 68708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010C65 RID: 68709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010C66 RID: 68710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010C67 RID: 68711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010C68 RID: 68712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010C69 RID: 68713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010C6A RID: 68714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010C6B RID: 68715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010C6C RID: 68716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010C6D RID: 68717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010C6E RID: 68718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010C6F RID: 68719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010C70 RID: 68720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010C71 RID: 68721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010C72 RID: 68722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010C73 RID: 68723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010C74 RID: 68724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010C75 RID: 68725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
