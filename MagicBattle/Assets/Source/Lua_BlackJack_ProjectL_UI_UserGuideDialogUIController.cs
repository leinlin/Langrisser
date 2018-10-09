using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015D3 RID: 5587
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController : LuaObject
{
	// Token: 0x060220E2 RID: 139490 RVA: 0x00B9CAF4 File Offset: 0x00B9ACF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DialogOpenTweenPlay(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.DialogOpenTweenPlay();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220E3 RID: 139491 RVA: 0x00B9CB40 File Offset: 0x00B9AD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDialog(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			ConfigDataUserGuideDialogInfo dialog;
			LuaObject.checkType<ConfigDataUserGuideDialogInfo>(l, 2, out dialog);
			userGuideDialogUIController.SetDialog(dialog);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220E4 RID: 139492 RVA: 0x00B9CB98 File Offset: 0x00B9AD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseDialog(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.CloseDialog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220E5 RID: 139493 RVA: 0x00B9CBE4 File Offset: 0x00B9ADE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220E6 RID: 139494 RVA: 0x00B9CC38 File Offset: 0x00B9AE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220E7 RID: 139495 RVA: 0x00B9CC8C File Offset: 0x00B9AE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_CloseDialog(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = userGuideDialogUIController.m_luaExportHelper.Co_CloseDialog();
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

	// Token: 0x060220E8 RID: 139496 RVA: 0x00B9CCE8 File Offset: 0x00B9AEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDialogBox(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.ShowDialogBox();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220E9 RID: 139497 RVA: 0x00B9CD3C File Offset: 0x00B9AF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayVoice(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			IAudioPlayback o = userGuideDialogUIController.m_luaExportHelper.PlayVoice(name);
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

	// Token: 0x060220EA RID: 139498 RVA: 0x00B9CDA4 File Offset: 0x00B9AFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopVoice(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.StopVoice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220EB RID: 139499 RVA: 0x00B9CDF8 File Offset: 0x00B9AFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_NextDialog(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = userGuideDialogUIController.m_luaExportHelper.Co_NextDialog();
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

	// Token: 0x060220EC RID: 139500 RVA: 0x00B9CE54 File Offset: 0x00B9B054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.OnSkipButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220ED RID: 139501 RVA: 0x00B9CEA8 File Offset: 0x00B9B0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220EE RID: 139502 RVA: 0x00B9CEFC File Offset: 0x00B9B0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			userGuideDialogUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220EF RID: 139503 RVA: 0x00B9CF68 File Offset: 0x00B9B168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220F0 RID: 139504 RVA: 0x00B9CFBC File Offset: 0x00B9B1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220F1 RID: 139505 RVA: 0x00B9D010 File Offset: 0x00B9B210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = userGuideDialogUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060220F2 RID: 139506 RVA: 0x00B9D0B8 File Offset: 0x00B9B2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220F3 RID: 139507 RVA: 0x00B9D10C File Offset: 0x00B9B30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			userGuideDialogUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220F4 RID: 139508 RVA: 0x00B9D178 File Offset: 0x00B9B378
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
				UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				userGuideDialogUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UserGuideDialogUIController userGuideDialogUIController2 = (UserGuideDialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				userGuideDialogUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060220F5 RID: 139509 RVA: 0x00B9D288 File Offset: 0x00B9B488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideDialogUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220F6 RID: 139510 RVA: 0x00B9D2F4 File Offset: 0x00B9B4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220F7 RID: 139511 RVA: 0x00B9D360 File Offset: 0x00B9B560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220F8 RID: 139512 RVA: 0x00B9D3CC File Offset: 0x00B9B5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220F9 RID: 139513 RVA: 0x00B9D438 File Offset: 0x00B9B638
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
				UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				userGuideDialogUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UserGuideDialogUIController userGuideDialogUIController2 = (UserGuideDialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				userGuideDialogUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060220FA RID: 139514 RVA: 0x00B9D548 File Offset: 0x00B9B748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			string s = userGuideDialogUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060220FB RID: 139515 RVA: 0x00B9D5A4 File Offset: 0x00B9B7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__callDele_EventOnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220FC RID: 139516 RVA: 0x00B9D5F8 File Offset: 0x00B9B7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__clearDele_EventOnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220FD RID: 139517 RVA: 0x00B9D64C File Offset: 0x00B9B84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__callDele_EventOnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220FE RID: 139518 RVA: 0x00B9D6A0 File Offset: 0x00B9B8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__clearDele_EventOnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220FF RID: 139519 RVA: 0x00B9D6F4 File Offset: 0x00B9B8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022100 RID: 139520 RVA: 0x00B9D748 File Offset: 0x00B9B948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			userGuideDialogUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022101 RID: 139521 RVA: 0x00B9D79C File Offset: 0x00B9B99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideDialogUIController.EventOnSkip += value;
				}
				else if (num == 2)
				{
					userGuideDialogUIController.EventOnSkip -= value;
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

	// Token: 0x06022102 RID: 139522 RVA: 0x00B9D81C File Offset: 0x00B9BA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideDialogUIController.EventOnNext += value;
				}
				else if (num == 2)
				{
					userGuideDialogUIController.EventOnNext -= value;
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

	// Token: 0x06022103 RID: 139523 RVA: 0x00B9D89C File Offset: 0x00B9BA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideDialogUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					userGuideDialogUIController.EventOnClose -= value;
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

	// Token: 0x06022104 RID: 139524 RVA: 0x00B9D91C File Offset: 0x00B9BB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skipButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_skipButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022105 RID: 139525 RVA: 0x00B9D974 File Offset: 0x00B9BB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skipButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			Button skipButton;
			LuaObject.checkType<Button>(l, 2, out skipButton);
			userGuideDialogUIController.m_luaExportHelper.m_skipButton = skipButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022106 RID: 139526 RVA: 0x00B9D9D0 File Offset: 0x00B9BBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_backgroundUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022107 RID: 139527 RVA: 0x00B9DA28 File Offset: 0x00B9BC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			CommonUIStateController backgroundUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out backgroundUIStateCtrl);
			userGuideDialogUIController.m_luaExportHelper.m_backgroundUIStateCtrl = backgroundUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022108 RID: 139528 RVA: 0x00B9DA84 File Offset: 0x00B9BC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022109 RID: 139529 RVA: 0x00B9DADC File Offset: 0x00B9BCDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			userGuideDialogUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602210A RID: 139530 RVA: 0x00B9DB38 File Offset: 0x00B9BD38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_wordsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602210B RID: 139531 RVA: 0x00B9DB90 File Offset: 0x00B9BD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			GameObject wordsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out wordsGameObject);
			userGuideDialogUIController.m_luaExportHelper.m_wordsGameObject = wordsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602210C RID: 139532 RVA: 0x00B9DBEC File Offset: 0x00B9BDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_char0GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602210D RID: 139533 RVA: 0x00B9DC44 File Offset: 0x00B9BE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			GameObject char0GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char0GameObject);
			userGuideDialogUIController.m_luaExportHelper.m_char0GameObject = char0GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602210E RID: 139534 RVA: 0x00B9DCA0 File Offset: 0x00B9BEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_char1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602210F RID: 139535 RVA: 0x00B9DCF8 File Offset: 0x00B9BEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			GameObject char1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char1GameObject);
			userGuideDialogUIController.m_luaExportHelper.m_char1GameObject = char1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022110 RID: 139536 RVA: 0x00B9DD54 File Offset: 0x00B9BF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogCharUIControllers(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_dialogCharUIControllers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022111 RID: 139537 RVA: 0x00B9DDAC File Offset: 0x00B9BFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogCharUIControllers(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			DialogCharUIController[] dialogCharUIControllers;
			LuaObject.checkArray<DialogCharUIController>(l, 2, out dialogCharUIControllers);
			userGuideDialogUIController.m_luaExportHelper.m_dialogCharUIControllers = dialogCharUIControllers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022112 RID: 139538 RVA: 0x00B9DE08 File Offset: 0x00B9C008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogBoxUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_dialogBoxUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022113 RID: 139539 RVA: 0x00B9DE60 File Offset: 0x00B9C060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogBoxUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			UserGuideDialogBoxUIController dialogBoxUIController;
			LuaObject.checkType<UserGuideDialogBoxUIController>(l, 2, out dialogBoxUIController);
			userGuideDialogUIController.m_luaExportHelper.m_dialogBoxUIController = dialogBoxUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022114 RID: 139540 RVA: 0x00B9DEBC File Offset: 0x00B9C0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_dialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022115 RID: 139541 RVA: 0x00B9DF14 File Offset: 0x00B9C114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			ConfigDataUserGuideDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataUserGuideDialogInfo>(l, 2, out dialogInfo);
			userGuideDialogUIController.m_luaExportHelper.m_dialogInfo = dialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022116 RID: 139542 RVA: 0x00B9DF70 File Offset: 0x00B9C170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showDialogBoxTime(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_showDialogBoxTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022117 RID: 139543 RVA: 0x00B9DFC8 File Offset: 0x00B9C1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showDialogBoxTime(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			float showDialogBoxTime;
			LuaObject.checkType(l, 2, out showDialogBoxTime);
			userGuideDialogUIController.m_luaExportHelper.m_showDialogBoxTime = showDialogBoxTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022118 RID: 139544 RVA: 0x00B9E024 File Offset: 0x00B9C224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentAudio(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogUIController.m_luaExportHelper.m_currentAudio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022119 RID: 139545 RVA: 0x00B9E07C File Offset: 0x00B9C27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentAudio(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogUIController userGuideDialogUIController = (UserGuideDialogUIController)LuaObject.checkSelf(l);
			IAudioPlayback currentAudio;
			LuaObject.checkType<IAudioPlayback>(l, 2, out currentAudio);
			userGuideDialogUIController.m_luaExportHelper.m_currentAudio = currentAudio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602211A RID: 139546 RVA: 0x00B9E0D8 File Offset: 0x00B9C2D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UserGuideDialogUIController");
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.DialogOpenTweenPlay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.SetDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.CloseDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.Co_CloseDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.ShowDialogBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.PlayVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.StopVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.Co_NextDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.OnSkipButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callDele_EventOnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__clearDele_EventOnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__clearDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1E);
		string name = "EventOnSkip";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_EventOnSkip);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache1F, true);
		string name2 = "EventOnNext";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_EventOnNext);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache20, true);
		string name3 = "EventOnClose";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache21, true);
		string name4 = "m_skipButton";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_skipButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_skipButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache23, true);
		string name5 = "m_backgroundUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_backgroundUIStateCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_backgroundUIStateCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache25, true);
		string name6 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_backgroundButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache27, true);
		string name7 = "m_wordsGameObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_wordsGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_wordsGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache29, true);
		string name8 = "m_char0GameObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_char0GameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_char0GameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2B, true);
		string name9 = "m_char1GameObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_char1GameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_char1GameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2D, true);
		string name10 = "m_dialogCharUIControllers";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_dialogCharUIControllers);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_dialogCharUIControllers);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache2F, true);
		string name11 = "m_dialogBoxUIController";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_dialogBoxUIController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_dialogBoxUIController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache31, true);
		string name12 = "m_dialogInfo";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_dialogInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_dialogInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache33, true);
		string name13 = "m_showDialogBoxTime";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_showDialogBoxTime);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_showDialogBoxTime);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache35, true);
		string name14 = "m_currentAudio";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.get_m_currentAudio);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.set_m_currentAudio);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.<>f__mg$cache37, true);
		LuaObject.createTypeMetatable(l, null, typeof(UserGuideDialogUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017F1E RID: 98078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017F1F RID: 98079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017F20 RID: 98080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017F21 RID: 98081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017F22 RID: 98082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017F23 RID: 98083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017F24 RID: 98084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017F25 RID: 98085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017F26 RID: 98086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017F27 RID: 98087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017F28 RID: 98088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017F29 RID: 98089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017F2A RID: 98090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017F2B RID: 98091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017F2C RID: 98092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017F2D RID: 98093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017F2E RID: 98094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017F2F RID: 98095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017F30 RID: 98096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017F31 RID: 98097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017F32 RID: 98098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017F33 RID: 98099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017F34 RID: 98100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017F35 RID: 98101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017F36 RID: 98102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017F37 RID: 98103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017F38 RID: 98104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017F39 RID: 98105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017F3A RID: 98106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017F3B RID: 98107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017F3C RID: 98108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017F3D RID: 98109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017F3E RID: 98110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017F3F RID: 98111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017F40 RID: 98112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017F41 RID: 98113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017F42 RID: 98114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017F43 RID: 98115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017F44 RID: 98116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017F45 RID: 98117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017F46 RID: 98118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017F47 RID: 98119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017F48 RID: 98120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017F49 RID: 98121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017F4A RID: 98122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017F4B RID: 98123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017F4C RID: 98124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017F4D RID: 98125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017F4E RID: 98126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017F4F RID: 98127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017F50 RID: 98128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017F51 RID: 98129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017F52 RID: 98130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017F53 RID: 98131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017F54 RID: 98132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017F55 RID: 98133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
