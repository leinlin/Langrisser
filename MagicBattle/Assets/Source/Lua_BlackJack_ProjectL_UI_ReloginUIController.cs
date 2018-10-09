using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001558 RID: 5464
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ReloginUIController : LuaObject
{
	// Token: 0x06020A87 RID: 133767 RVA: 0x00AEA44C File Offset: 0x00AE864C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A88 RID: 133768 RVA: 0x00AEA498 File Offset: 0x00AE8698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A89 RID: 133769 RVA: 0x00AEA4E4 File Offset: 0x00AE86E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaitForReloginConfirm(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.ShowWaitForReloginConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A8A RID: 133770 RVA: 0x00AEA530 File Offset: 0x00AE8730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaitForReloginProcessing(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.ShowWaitForReloginProcessing();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A8B RID: 133771 RVA: 0x00AEA57C File Offset: 0x00AE877C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaitReturnToLoginConfirm(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.ShowWaitReturnToLoginConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A8C RID: 133772 RVA: 0x00AEA5C8 File Offset: 0x00AE87C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A8D RID: 133773 RVA: 0x00AEA61C File Offset: 0x00AE881C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			reloginUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A8E RID: 133774 RVA: 0x00AEA688 File Offset: 0x00AE8888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A8F RID: 133775 RVA: 0x00AEA6DC File Offset: 0x00AE88DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A90 RID: 133776 RVA: 0x00AEA730 File Offset: 0x00AE8930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = reloginUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020A91 RID: 133777 RVA: 0x00AEA7D8 File Offset: 0x00AE89D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			reloginUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A92 RID: 133778 RVA: 0x00AEA82C File Offset: 0x00AE8A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			reloginUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A93 RID: 133779 RVA: 0x00AEA898 File Offset: 0x00AE8A98
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
				ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				reloginUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ReloginUIController reloginUIController2 = (ReloginUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				reloginUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020A94 RID: 133780 RVA: 0x00AEA9A8 File Offset: 0x00AE8BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			reloginUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A95 RID: 133781 RVA: 0x00AEAA14 File Offset: 0x00AE8C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			reloginUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A96 RID: 133782 RVA: 0x00AEAA80 File Offset: 0x00AE8C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			reloginUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A97 RID: 133783 RVA: 0x00AEAAEC File Offset: 0x00AE8CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			reloginUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A98 RID: 133784 RVA: 0x00AEAB58 File Offset: 0x00AE8D58
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
				ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				reloginUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ReloginUIController reloginUIController2 = (ReloginUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				reloginUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020A99 RID: 133785 RVA: 0x00AEAC68 File Offset: 0x00AE8E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			string s = reloginUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020A9A RID: 133786 RVA: 0x00AEACC4 File Offset: 0x00AE8EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A9B RID: 133787 RVA: 0x00AEAD1C File Offset: 0x00AE8F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			reloginUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A9C RID: 133788 RVA: 0x00AEAD78 File Offset: 0x00AE8F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogBoxGameObject(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUIController.m_luaExportHelper.m_dialogBoxGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A9D RID: 133789 RVA: 0x00AEADD0 File Offset: 0x00AE8FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogBoxGameObject(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			GameObject dialogBoxGameObject;
			LuaObject.checkType<GameObject>(l, 2, out dialogBoxGameObject);
			reloginUIController.m_luaExportHelper.m_dialogBoxGameObject = dialogBoxGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A9E RID: 133790 RVA: 0x00AEAE2C File Offset: 0x00AE902C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RetryLoginButton(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUIController.m_luaExportHelper.RetryLoginButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A9F RID: 133791 RVA: 0x00AEAE84 File Offset: 0x00AE9084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RetryLoginButton(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			Button retryLoginButton;
			LuaObject.checkType<Button>(l, 2, out retryLoginButton);
			reloginUIController.m_luaExportHelper.RetryLoginButton = retryLoginButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AA0 RID: 133792 RVA: 0x00AEAEE0 File Offset: 0x00AE90E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReturnToLoginButton(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUIController.m_luaExportHelper.ReturnToLoginButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AA1 RID: 133793 RVA: 0x00AEAF38 File Offset: 0x00AE9138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ReturnToLoginButton(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			Button returnToLoginButton;
			LuaObject.checkType<Button>(l, 2, out returnToLoginButton);
			reloginUIController.m_luaExportHelper.ReturnToLoginButton = returnToLoginButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AA2 RID: 133794 RVA: 0x00AEAF94 File Offset: 0x00AE9194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitingGameObject(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reloginUIController.m_luaExportHelper.m_waitingGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AA3 RID: 133795 RVA: 0x00AEAFEC File Offset: 0x00AE91EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitingGameObject(IntPtr l)
	{
		int result;
		try
		{
			ReloginUIController reloginUIController = (ReloginUIController)LuaObject.checkSelf(l);
			GameObject waitingGameObject;
			LuaObject.checkType<GameObject>(l, 2, out waitingGameObject);
			reloginUIController.m_luaExportHelper.m_waitingGameObject = waitingGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AA4 RID: 133796 RVA: 0x00AEB048 File Offset: 0x00AE9248
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ReloginUIController");
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.ShowWaitForReloginConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.ShowWaitForReloginProcessing);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.ShowWaitReturnToLoginConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache12);
		string name = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache14, true);
		string name2 = "m_dialogBoxGameObject";
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.get_m_dialogBoxGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.set_m_dialogBoxGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache16, true);
		string name3 = "RetryLoginButton";
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.get_RetryLoginButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.set_RetryLoginButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache18, true);
		string name4 = "ReturnToLoginButton";
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.get_ReturnToLoginButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.set_ReturnToLoginButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1A, true);
		string name5 = "m_waitingGameObject";
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.get_m_waitingGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ReloginUIController.set_m_waitingGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ReloginUIController.<>f__mg$cache1C, true);
		LuaObject.createTypeMetatable(l, null, typeof(ReloginUIController), typeof(UIControllerBase));
	}

	// Token: 0x040169B9 RID: 92601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040169BA RID: 92602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040169BB RID: 92603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040169BC RID: 92604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040169BD RID: 92605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040169BE RID: 92606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040169BF RID: 92607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040169C0 RID: 92608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040169C1 RID: 92609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040169C2 RID: 92610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040169C3 RID: 92611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040169C4 RID: 92612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040169C5 RID: 92613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040169C6 RID: 92614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040169C7 RID: 92615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040169C8 RID: 92616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040169C9 RID: 92617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040169CA RID: 92618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040169CB RID: 92619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040169CC RID: 92620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040169CD RID: 92621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040169CE RID: 92622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040169CF RID: 92623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040169D0 RID: 92624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040169D1 RID: 92625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040169D2 RID: 92626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040169D3 RID: 92627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040169D4 RID: 92628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040169D5 RID: 92629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
