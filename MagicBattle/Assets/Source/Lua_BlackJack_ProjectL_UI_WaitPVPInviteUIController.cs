using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015DF RID: 5599
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController : LuaObject
{
	// Token: 0x06022322 RID: 140066 RVA: 0x00BAE178 File Offset: 0x00BAC378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			waitPVPInviteUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022323 RID: 140067 RVA: 0x00BAE1C4 File Offset: 0x00BAC3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			waitPVPInviteUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022324 RID: 140068 RVA: 0x00BAE21C File Offset: 0x00BAC41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			waitPVPInviteUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022325 RID: 140069 RVA: 0x00BAE270 File Offset: 0x00BAC470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			waitPVPInviteUIController.m_luaExportHelper.OnCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022326 RID: 140070 RVA: 0x00BAE2C4 File Offset: 0x00BAC4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022327 RID: 140071 RVA: 0x00BAE330 File Offset: 0x00BAC530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022328 RID: 140072 RVA: 0x00BAE384 File Offset: 0x00BAC584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022329 RID: 140073 RVA: 0x00BAE3D8 File Offset: 0x00BAC5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = waitPVPInviteUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602232A RID: 140074 RVA: 0x00BAE480 File Offset: 0x00BAC680
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602232B RID: 140075 RVA: 0x00BAE4D4 File Offset: 0x00BAC6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602232C RID: 140076 RVA: 0x00BAE540 File Offset: 0x00BAC740
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
				WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				waitPVPInviteUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WaitPVPInviteUIController waitPVPInviteUIController2 = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				waitPVPInviteUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602232D RID: 140077 RVA: 0x00BAE650 File Offset: 0x00BAC850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602232E RID: 140078 RVA: 0x00BAE6BC File Offset: 0x00BAC8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602232F RID: 140079 RVA: 0x00BAE728 File Offset: 0x00BAC928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022330 RID: 140080 RVA: 0x00BAE794 File Offset: 0x00BAC994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			waitPVPInviteUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022331 RID: 140081 RVA: 0x00BAE800 File Offset: 0x00BACA00
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
				WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				waitPVPInviteUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WaitPVPInviteUIController waitPVPInviteUIController2 = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				waitPVPInviteUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06022332 RID: 140082 RVA: 0x00BAE910 File Offset: 0x00BACB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			string s = waitPVPInviteUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06022333 RID: 140083 RVA: 0x00BAE96C File Offset: 0x00BACB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			waitPVPInviteUIController.m_luaExportHelper.__callDele_EventOnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022334 RID: 140084 RVA: 0x00BAE9C0 File Offset: 0x00BACBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			waitPVPInviteUIController.m_luaExportHelper.__clearDele_EventOnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022335 RID: 140085 RVA: 0x00BAEA14 File Offset: 0x00BACC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					waitPVPInviteUIController.EventOnCancel += value;
				}
				else if (num == 2)
				{
					waitPVPInviteUIController.EventOnCancel -= value;
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

	// Token: 0x06022336 RID: 140086 RVA: 0x00BAEA94 File Offset: 0x00BACC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022337 RID: 140087 RVA: 0x00BAEAEC File Offset: 0x00BACCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			waitPVPInviteUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022338 RID: 140088 RVA: 0x00BAEB48 File Offset: 0x00BACD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUIController.m_luaExportHelper.m_cancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022339 RID: 140089 RVA: 0x00BAEBA0 File Offset: 0x00BACDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			Button cancelButton;
			LuaObject.checkType<Button>(l, 2, out cancelButton);
			waitPVPInviteUIController.m_luaExportHelper.m_cancelButton = cancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602233A RID: 140090 RVA: 0x00BAEBFC File Offset: 0x00BACDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitPVPInviteUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602233B RID: 140091 RVA: 0x00BAEC54 File Offset: 0x00BACE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			WaitPVPInviteUIController waitPVPInviteUIController = (WaitPVPInviteUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			waitPVPInviteUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602233C RID: 140092 RVA: 0x00BAECB0 File Offset: 0x00BACEB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WaitPVPInviteUIController");
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.OnCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__callDele_EventOnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.__clearDele_EventOnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache12);
		string name = "EventOnCancel";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.set_EventOnCancel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache13, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache15, true);
		string name3 = "m_cancelButton";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.get_m_cancelButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.set_m_cancelButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache17, true);
		string name4 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.get_m_isOpened);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.<>f__mg$cache19, true);
		LuaObject.createTypeMetatable(l, null, typeof(WaitPVPInviteUIController), typeof(UIControllerBase));
	}

	// Token: 0x04018146 RID: 98630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018147 RID: 98631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018148 RID: 98632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018149 RID: 98633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401814A RID: 98634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401814B RID: 98635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401814C RID: 98636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401814D RID: 98637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401814E RID: 98638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401814F RID: 98639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018150 RID: 98640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018151 RID: 98641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018152 RID: 98642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018153 RID: 98643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018154 RID: 98644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018155 RID: 98645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018156 RID: 98646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018157 RID: 98647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018158 RID: 98648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018159 RID: 98649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401815A RID: 98650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401815B RID: 98651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401815C RID: 98652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401815D RID: 98653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401815E RID: 98654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401815F RID: 98655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
