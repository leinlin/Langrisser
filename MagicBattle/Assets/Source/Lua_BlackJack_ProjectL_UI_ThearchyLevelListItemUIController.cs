using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015B1 RID: 5553
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController : LuaObject
{
	// Token: 0x06021B6A RID: 138090 RVA: 0x00B718E0 File Offset: 0x00B6FAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetThearchyLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo thearchyLevelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out thearchyLevelInfo);
			thearchyLevelListItemUIController.SetThearchyLevelInfo(thearchyLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B6B RID: 138091 RVA: 0x00B71938 File Offset: 0x00B6FB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetThearchyLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo thearchyLevelInfo = thearchyLevelListItemUIController.GetThearchyLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B6C RID: 138092 RVA: 0x00B7198C File Offset: 0x00B6FB8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			thearchyLevelListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B6D RID: 138093 RVA: 0x00B719E4 File Offset: 0x00B6FBE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			thearchyLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B6E RID: 138094 RVA: 0x00B71A38 File Offset: 0x00B6FC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			thearchyLevelListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B6F RID: 138095 RVA: 0x00B71A8C File Offset: 0x00B6FC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			thearchyLevelListItemUIController.m_luaExportHelper.OnLockedButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B70 RID: 138096 RVA: 0x00B71AE0 File Offset: 0x00B6FCE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B71 RID: 138097 RVA: 0x00B71B4C File Offset: 0x00B6FD4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B72 RID: 138098 RVA: 0x00B71BA0 File Offset: 0x00B6FDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B73 RID: 138099 RVA: 0x00B71BF4 File Offset: 0x00B6FDF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = thearchyLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021B74 RID: 138100 RVA: 0x00B71C9C File Offset: 0x00B6FE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B75 RID: 138101 RVA: 0x00B71CF0 File Offset: 0x00B6FEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B76 RID: 138102 RVA: 0x00B71D5C File Offset: 0x00B6FF5C
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
				ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				thearchyLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ThearchyLevelListItemUIController thearchyLevelListItemUIController2 = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				thearchyLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021B77 RID: 138103 RVA: 0x00B71E6C File Offset: 0x00B7006C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B78 RID: 138104 RVA: 0x00B71ED8 File Offset: 0x00B700D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B79 RID: 138105 RVA: 0x00B71F44 File Offset: 0x00B70144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B7A RID: 138106 RVA: 0x00B71FB0 File Offset: 0x00B701B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			thearchyLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B7B RID: 138107 RVA: 0x00B7201C File Offset: 0x00B7021C
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
				ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				thearchyLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ThearchyLevelListItemUIController thearchyLevelListItemUIController2 = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				thearchyLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021B7C RID: 138108 RVA: 0x00B7212C File Offset: 0x00B7032C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			string s = thearchyLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021B7D RID: 138109 RVA: 0x00B72188 File Offset: 0x00B70388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			ThearchyLevelListItemUIController obj;
			LuaObject.checkType<ThearchyLevelListItemUIController>(l, 2, out obj);
			thearchyLevelListItemUIController.m_luaExportHelper.__callDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B7E RID: 138110 RVA: 0x00B721E4 File Offset: 0x00B703E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			ThearchyLevelListItemUIController obj;
			LuaObject.checkType<ThearchyLevelListItemUIController>(l, 2, out obj);
			thearchyLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B7F RID: 138111 RVA: 0x00B72240 File Offset: 0x00B70440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			Action<ThearchyLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<ThearchyLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					thearchyLevelListItemUIController.EventOnStartButtonClick += value;
				}
				else if (num == 2)
				{
					thearchyLevelListItemUIController.EventOnStartButtonClick -= value;
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

	// Token: 0x06021B80 RID: 138112 RVA: 0x00B722C0 File Offset: 0x00B704C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B81 RID: 138113 RVA: 0x00B72318 File Offset: 0x00B70518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			thearchyLevelListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B82 RID: 138114 RVA: 0x00B72374 File Offset: 0x00B70574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B83 RID: 138115 RVA: 0x00B723CC File Offset: 0x00B705CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			thearchyLevelListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B84 RID: 138116 RVA: 0x00B72428 File Offset: 0x00B70628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelListItemUIController.m_luaExportHelper.m_lockedButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B85 RID: 138117 RVA: 0x00B72480 File Offset: 0x00B70680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			Button lockedButton;
			LuaObject.checkType<Button>(l, 2, out lockedButton);
			thearchyLevelListItemUIController.m_luaExportHelper.m_lockedButton = lockedButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B86 RID: 138118 RVA: 0x00B724DC File Offset: 0x00B706DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelListItemUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B87 RID: 138119 RVA: 0x00B72534 File Offset: 0x00B70734
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			thearchyLevelListItemUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B88 RID: 138120 RVA: 0x00B72590 File Offset: 0x00B70790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B89 RID: 138121 RVA: 0x00B725E8 File Offset: 0x00B707E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			thearchyLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B8A RID: 138122 RVA: 0x00B72644 File Offset: 0x00B70844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_thearchyLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelListItemUIController.m_luaExportHelper.m_thearchyLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B8B RID: 138123 RVA: 0x00B7269C File Offset: 0x00B7089C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_thearchyLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = (ThearchyLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo thearchyLevelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out thearchyLevelInfo);
			thearchyLevelListItemUIController.m_luaExportHelper.m_thearchyLevelInfo = thearchyLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B8C RID: 138124 RVA: 0x00B726F8 File Offset: 0x00B708F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ThearchyLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.SetThearchyLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.GetThearchyLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.OnLockedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__callDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.__clearDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache14);
		string name = "EventOnStartButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.set_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache15, true);
		string name2 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.get_m_levelText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache17, true);
		string name3 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.get_m_energyText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache19, true);
		string name4 = "m_lockedButton";
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.get_m_lockedButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.set_m_lockedButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.get_m_startButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_thearchyLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.get_m_thearchyLevelInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.set_m_thearchyLevelInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.<>f__mg$cache21, true);
		LuaObject.createTypeMetatable(l, null, typeof(ThearchyLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040179EA RID: 96746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040179EB RID: 96747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040179EC RID: 96748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040179ED RID: 96749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040179EE RID: 96750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040179EF RID: 96751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040179F0 RID: 96752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040179F1 RID: 96753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040179F2 RID: 96754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040179F3 RID: 96755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040179F4 RID: 96756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040179F5 RID: 96757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040179F6 RID: 96758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040179F7 RID: 96759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040179F8 RID: 96760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040179F9 RID: 96761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040179FA RID: 96762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040179FB RID: 96763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040179FC RID: 96764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040179FD RID: 96765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040179FE RID: 96766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040179FF RID: 96767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017A00 RID: 96768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017A01 RID: 96769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017A02 RID: 96770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017A03 RID: 96771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017A04 RID: 96772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017A05 RID: 96773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017A06 RID: 96774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017A07 RID: 96775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017A08 RID: 96776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017A09 RID: 96777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017A0A RID: 96778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017A0B RID: 96779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
