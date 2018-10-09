using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013E9 RID: 5097
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatExpressionUIController : LuaObject
{
	// Token: 0x0601C8F1 RID: 116977 RVA: 0x008E0C08 File Offset: 0x008DEE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOrHideExpressionPanel(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			chatExpressionUIController.ShowOrHideExpressionPanel(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8F2 RID: 116978 RVA: 0x008E0C60 File Offset: 0x008DEE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SwitchExpressionPanel(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			chatExpressionUIController.SwitchExpressionPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8F3 RID: 116979 RVA: 0x008E0CAC File Offset: 0x008DEEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DelayInstancePrefab(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			IEnumerator o = chatExpressionUIController.DelayInstancePrefab();
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

	// Token: 0x0601C8F4 RID: 116980 RVA: 0x008E0D00 File Offset: 0x008DEF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitExpressionPageAndItem(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			IEnumerator o = chatExpressionUIController.InitExpressionPageAndItem();
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

	// Token: 0x0601C8F5 RID: 116981 RVA: 0x008E0D54 File Offset: 0x008DEF54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			chatExpressionUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8F6 RID: 116982 RVA: 0x008E0DA8 File Offset: 0x008DEFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			chatExpressionUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8F7 RID: 116983 RVA: 0x008E0DFC File Offset: 0x008DEFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp4ExpressionScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			chatExpressionUIController.m_luaExportHelper.OnPointerUp4ExpressionScrollRect(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8F8 RID: 116984 RVA: 0x008E0E58 File Offset: 0x008DF058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSmallExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			SmallExpressionItemContrller uCtrl;
			LuaObject.checkType<SmallExpressionItemContrller>(l, 2, out uCtrl);
			chatExpressionUIController.m_luaExportHelper.OnSmallExpressionClick(uCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8F9 RID: 116985 RVA: 0x008E0EB4 File Offset: 0x008DF0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpressionBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			UIControllerBase uCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out uCtrl);
			chatExpressionUIController.m_luaExportHelper.OnExpressionBgButtonClick(uCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8FA RID: 116986 RVA: 0x008E0F10 File Offset: 0x008DF110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSmallExpressionToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			bool isSelected;
			LuaObject.checkType(l, 2, out isSelected);
			chatExpressionUIController.m_luaExportHelper.OnSmallExpressionToggleValueChanged(isSelected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8FB RID: 116987 RVA: 0x008E0F6C File Offset: 0x008DF16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBigExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			chatExpressionUIController.m_luaExportHelper.OnBigExpressionClick(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8FC RID: 116988 RVA: 0x008E0FC8 File Offset: 0x008DF1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSmallExpressionPageImmediate(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			int smallExpressionPageImmediate;
			LuaObject.checkType(l, 2, out smallExpressionPageImmediate);
			chatExpressionUIController.m_luaExportHelper.SetSmallExpressionPageImmediate(smallExpressionPageImmediate);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8FD RID: 116989 RVA: 0x008E1024 File Offset: 0x008DF224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSmallExpressionPage(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			int smallExpressionPage;
			LuaObject.checkType(l, 2, out smallExpressionPage);
			IEnumerator o = chatExpressionUIController.m_luaExportHelper.SetSmallExpressionPage(smallExpressionPage);
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

	// Token: 0x0601C8FE RID: 116990 RVA: 0x008E108C File Offset: 0x008DF28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			chatExpressionUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8FF RID: 116991 RVA: 0x008E10F8 File Offset: 0x008DF2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			chatExpressionUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C900 RID: 116992 RVA: 0x008E114C File Offset: 0x008DF34C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			chatExpressionUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C901 RID: 116993 RVA: 0x008E11A0 File Offset: 0x008DF3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = chatExpressionUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C902 RID: 116994 RVA: 0x008E1248 File Offset: 0x008DF448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			chatExpressionUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C903 RID: 116995 RVA: 0x008E129C File Offset: 0x008DF49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			chatExpressionUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C904 RID: 116996 RVA: 0x008E1308 File Offset: 0x008DF508
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
				ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				chatExpressionUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ChatExpressionUIController chatExpressionUIController2 = (ChatExpressionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				chatExpressionUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C905 RID: 116997 RVA: 0x008E1418 File Offset: 0x008DF618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatExpressionUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C906 RID: 116998 RVA: 0x008E1484 File Offset: 0x008DF684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatExpressionUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C907 RID: 116999 RVA: 0x008E14F0 File Offset: 0x008DF6F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatExpressionUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C908 RID: 117000 RVA: 0x008E155C File Offset: 0x008DF75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatExpressionUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C909 RID: 117001 RVA: 0x008E15C8 File Offset: 0x008DF7C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				chatExpressionUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ChatExpressionUIController chatExpressionUIController2 = (ChatExpressionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				chatExpressionUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C90A RID: 117002 RVA: 0x008E16D8 File Offset: 0x008DF8D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			string s = chatExpressionUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C90B RID: 117003 RVA: 0x008E1734 File Offset: 0x008DF934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSmallExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			SmallExpressionItemContrller obj;
			LuaObject.checkType<SmallExpressionItemContrller>(l, 2, out obj);
			chatExpressionUIController.m_luaExportHelper.__callDele_EventOnSmallExpressionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C90C RID: 117004 RVA: 0x008E1790 File Offset: 0x008DF990
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnSmallExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			SmallExpressionItemContrller obj;
			LuaObject.checkType<SmallExpressionItemContrller>(l, 2, out obj);
			chatExpressionUIController.m_luaExportHelper.__clearDele_EventOnSmallExpressionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C90D RID: 117005 RVA: 0x008E17EC File Offset: 0x008DF9EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnExpressionBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			chatExpressionUIController.m_luaExportHelper.__callDele_EventOnExpressionBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C90E RID: 117006 RVA: 0x008E1840 File Offset: 0x008DFA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExpressionBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			chatExpressionUIController.m_luaExportHelper.__clearDele_EventOnExpressionBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C90F RID: 117007 RVA: 0x008E1894 File Offset: 0x008DFA94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnSmallExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			Action<SmallExpressionItemContrller> value;
			int num = LuaObject.checkDelegate<Action<SmallExpressionItemContrller>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatExpressionUIController.EventOnSmallExpressionClick += value;
				}
				else if (num == 2)
				{
					chatExpressionUIController.EventOnSmallExpressionClick -= value;
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

	// Token: 0x0601C910 RID: 117008 RVA: 0x008E1914 File Offset: 0x008DFB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExpressionBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatExpressionUIController.EventOnExpressionBgButtonClick += value;
				}
				else if (num == 2)
				{
					chatExpressionUIController.EventOnExpressionBgButtonClick -= value;
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

	// Token: 0x0601C911 RID: 117009 RVA: 0x008E1994 File Offset: 0x008DFB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigExpressionInChatController(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.m_bigExpressionInChatController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C912 RID: 117010 RVA: 0x008E19E8 File Offset: 0x008DFBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigExpressionInChatController(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			BigExpressionInChatController bigExpressionInChatController;
			LuaObject.checkType<BigExpressionInChatController>(l, 2, out bigExpressionInChatController);
			chatExpressionUIController.m_bigExpressionInChatController = bigExpressionInChatController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C913 RID: 117011 RVA: 0x008E1A40 File Offset: 0x008DFC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_emptySpaceNormalRatio(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.m_luaExportHelper.m_emptySpaceNormalRatio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C914 RID: 117012 RVA: 0x008E1A98 File Offset: 0x008DFC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_emptySpaceNormalRatio(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			float emptySpaceNormalRatio;
			LuaObject.checkType(l, 2, out emptySpaceNormalRatio);
			chatExpressionUIController.m_luaExportHelper.m_emptySpaceNormalRatio = emptySpaceNormalRatio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C915 RID: 117013 RVA: 0x008E1AF4 File Offset: 0x008DFCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currSmallPageIndex(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.m_luaExportHelper.m_currSmallPageIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C916 RID: 117014 RVA: 0x008E1B4C File Offset: 0x008DFD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currSmallPageIndex(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			int currSmallPageIndex;
			LuaObject.checkType(l, 2, out currSmallPageIndex);
			chatExpressionUIController.m_luaExportHelper.m_currSmallPageIndex = currSmallPageIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C917 RID: 117015 RVA: 0x008E1BA8 File Offset: 0x008DFDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smallExpressionPagePointList(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.m_luaExportHelper.m_smallExpressionPagePointList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C918 RID: 117016 RVA: 0x008E1C00 File Offset: 0x008DFE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smallExpressionPagePointList(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			List<CommonUIStateController> smallExpressionPagePointList;
			LuaObject.checkType<List<CommonUIStateController>>(l, 2, out smallExpressionPagePointList);
			chatExpressionUIController.m_luaExportHelper.m_smallExpressionPagePointList = smallExpressionPagePointList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C919 RID: 117017 RVA: 0x008E1C5C File Offset: 0x008DFE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smallExpressionPageSubSectionList(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.m_luaExportHelper.m_smallExpressionPageSubSectionList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C91A RID: 117018 RVA: 0x008E1CB4 File Offset: 0x008DFEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smallExpressionPageSubSectionList(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			List<KeyValuePair<float, float>> smallExpressionPageSubSectionList;
			LuaObject.checkType<List<KeyValuePair<float, float>>>(l, 2, out smallExpressionPageSubSectionList);
			chatExpressionUIController.m_luaExportHelper.m_smallExpressionPageSubSectionList = smallExpressionPageSubSectionList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C91B RID: 117019 RVA: 0x008E1D10 File Offset: 0x008DFF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_smallExpressionCtrlList(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.m_luaExportHelper.m_smallExpressionCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C91C RID: 117020 RVA: 0x008E1D68 File Offset: 0x008DFF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_smallExpressionCtrlList(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			List<SmallExpressionItemContrller> smallExpressionCtrlList;
			LuaObject.checkType<List<SmallExpressionItemContrller>>(l, 2, out smallExpressionCtrlList);
			chatExpressionUIController.m_luaExportHelper.m_smallExpressionCtrlList = smallExpressionCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C91D RID: 117021 RVA: 0x008E1DC4 File Offset: 0x008DFFC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SmallExpressionToggle(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.SmallExpressionToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C91E RID: 117022 RVA: 0x008E1E18 File Offset: 0x008E0018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SmallExpressionToggle(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			Toggle smallExpressionToggle;
			LuaObject.checkType<Toggle>(l, 2, out smallExpressionToggle);
			chatExpressionUIController.SmallExpressionToggle = smallExpressionToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C91F RID: 117023 RVA: 0x008E1E70 File Offset: 0x008E0070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpressionBgButton(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.ExpressionBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C920 RID: 117024 RVA: 0x008E1EC4 File Offset: 0x008E00C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExpressionBgButton(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			Button expressionBgButton;
			LuaObject.checkType<Button>(l, 2, out expressionBgButton);
			chatExpressionUIController.ExpressionBgButton = expressionBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C921 RID: 117025 RVA: 0x008E1F1C File Offset: 0x008E011C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.PanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C922 RID: 117026 RVA: 0x008E1F70 File Offset: 0x008E0170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			CommonUIStateController panelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out panelStateCtrl);
			chatExpressionUIController.PanelStateCtrl = panelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C923 RID: 117027 RVA: 0x008E1FC8 File Offset: 0x008E01C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SmallExpressionRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.SmallExpressionRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C924 RID: 117028 RVA: 0x008E201C File Offset: 0x008E021C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SmallExpressionRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject smallExpressionRoot;
			LuaObject.checkType<GameObject>(l, 2, out smallExpressionRoot);
			chatExpressionUIController.SmallExpressionRoot = smallExpressionRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C925 RID: 117029 RVA: 0x008E2074 File Offset: 0x008E0274
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SmallExpressionContent(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.SmallExpressionContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C926 RID: 117030 RVA: 0x008E20C8 File Offset: 0x008E02C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SmallExpressionContent(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject smallExpressionContent;
			LuaObject.checkType<GameObject>(l, 2, out smallExpressionContent);
			chatExpressionUIController.SmallExpressionContent = smallExpressionContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C927 RID: 117031 RVA: 0x008E2120 File Offset: 0x008E0320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SmallExpressionItem(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.SmallExpressionItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C928 RID: 117032 RVA: 0x008E2174 File Offset: 0x008E0374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SmallExpressionItem(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject smallExpressionItem;
			LuaObject.checkType<GameObject>(l, 2, out smallExpressionItem);
			chatExpressionUIController.SmallExpressionItem = smallExpressionItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C929 RID: 117033 RVA: 0x008E21CC File Offset: 0x008E03CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SmallExpressionPage(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.SmallExpressionPage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C92A RID: 117034 RVA: 0x008E2220 File Offset: 0x008E0420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SmallExpressionPage(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject smallExpressionPage;
			LuaObject.checkType<GameObject>(l, 2, out smallExpressionPage);
			chatExpressionUIController.SmallExpressionPage = smallExpressionPage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C92B RID: 117035 RVA: 0x008E2278 File Offset: 0x008E0478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpressionPagePoint(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.ExpressionPagePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C92C RID: 117036 RVA: 0x008E22CC File Offset: 0x008E04CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExpressionPagePoint(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject expressionPagePoint;
			LuaObject.checkType<GameObject>(l, 2, out expressionPagePoint);
			chatExpressionUIController.ExpressionPagePoint = expressionPagePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C92D RID: 117037 RVA: 0x008E2324 File Offset: 0x008E0524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpressionPagePointRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.ExpressionPagePointRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C92E RID: 117038 RVA: 0x008E2378 File Offset: 0x008E0578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExpressionPagePointRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject expressionPagePointRoot;
			LuaObject.checkType<GameObject>(l, 2, out expressionPagePointRoot);
			chatExpressionUIController.ExpressionPagePointRoot = expressionPagePointRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C92F RID: 117039 RVA: 0x008E23D0 File Offset: 0x008E05D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BigExpressionGroupDummy(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.BigExpressionGroupDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C930 RID: 117040 RVA: 0x008E2424 File Offset: 0x008E0624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BigExpressionGroupDummy(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject bigExpressionGroupDummy;
			LuaObject.checkType<GameObject>(l, 2, out bigExpressionGroupDummy);
			chatExpressionUIController.BigExpressionGroupDummy = bigExpressionGroupDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C931 RID: 117041 RVA: 0x008E247C File Offset: 0x008E067C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpressionDetailRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionUIController.ExpressionDetailRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C932 RID: 117042 RVA: 0x008E24D0 File Offset: 0x008E06D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExpressionDetailRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatExpressionUIController chatExpressionUIController = (ChatExpressionUIController)LuaObject.checkSelf(l);
			GameObject expressionDetailRoot;
			LuaObject.checkType<GameObject>(l, 2, out expressionDetailRoot);
			chatExpressionUIController.ExpressionDetailRoot = expressionDetailRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C933 RID: 117043 RVA: 0x008E2528 File Offset: 0x008E0728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SmallExpressionCount4OnePage(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatExpressionUIController.LuaExportHelper.SmallExpressionCount4OnePage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C934 RID: 117044 RVA: 0x008E2570 File Offset: 0x008E0770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpressionPageEmptySpaceWidth(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatExpressionUIController.LuaExportHelper.ExpressionPageEmptySpaceWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C935 RID: 117045 RVA: 0x008E25B8 File Offset: 0x008E07B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatExpressionUIController");
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.ShowOrHideExpressionPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.SwitchExpressionPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.DelayInstancePrefab);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.InitExpressionPageAndItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.OnPointerUp4ExpressionScrollRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.OnSmallExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.OnExpressionBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.OnSmallExpressionToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.OnBigExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.SetSmallExpressionPageImmediate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.SetSmallExpressionPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callDele_EventOnSmallExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__clearDele_EventOnSmallExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__callDele_EventOnExpressionBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.__clearDele_EventOnExpressionBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1D);
		string name = "EventOnSmallExpressionClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_EventOnSmallExpressionClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1E, true);
		string name2 = "EventOnExpressionBgButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_EventOnExpressionBgButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache1F, true);
		string name3 = "m_bigExpressionInChatController";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_m_bigExpressionInChatController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_m_bigExpressionInChatController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache21, true);
		string name4 = "m_emptySpaceNormalRatio";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_m_emptySpaceNormalRatio);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_m_emptySpaceNormalRatio);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache23, true);
		string name5 = "m_currSmallPageIndex";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_m_currSmallPageIndex);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_m_currSmallPageIndex);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache25, true);
		string name6 = "m_smallExpressionPagePointList";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_m_smallExpressionPagePointList);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_m_smallExpressionPagePointList);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache27, true);
		string name7 = "m_smallExpressionPageSubSectionList";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_m_smallExpressionPageSubSectionList);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_m_smallExpressionPageSubSectionList);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache29, true);
		string name8 = "m_smallExpressionCtrlList";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_m_smallExpressionCtrlList);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_m_smallExpressionCtrlList);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2B, true);
		string name9 = "SmallExpressionToggle";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_SmallExpressionToggle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_SmallExpressionToggle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2D, true);
		string name10 = "ExpressionBgButton";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_ExpressionBgButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_ExpressionBgButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache2F, true);
		string name11 = "PanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_PanelStateCtrl);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_PanelStateCtrl);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache31, true);
		string name12 = "SmallExpressionRoot";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_SmallExpressionRoot);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_SmallExpressionRoot);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache33, true);
		string name13 = "SmallExpressionContent";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_SmallExpressionContent);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_SmallExpressionContent);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache35, true);
		string name14 = "SmallExpressionItem";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_SmallExpressionItem);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_SmallExpressionItem);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache37, true);
		string name15 = "SmallExpressionPage";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_SmallExpressionPage);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_SmallExpressionPage);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache39, true);
		string name16 = "ExpressionPagePoint";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_ExpressionPagePoint);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_ExpressionPagePoint);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3B, true);
		string name17 = "ExpressionPagePointRoot";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_ExpressionPagePointRoot);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_ExpressionPagePointRoot);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3D, true);
		string name18 = "BigExpressionGroupDummy";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_BigExpressionGroupDummy);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_BigExpressionGroupDummy);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache3F, true);
		string name19 = "ExpressionDetailRoot";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_ExpressionDetailRoot);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.set_ExpressionDetailRoot);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache41, true);
		string name20 = "SmallExpressionCount4OnePage";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_SmallExpressionCount4OnePage);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache42, null, false);
		string name21 = "ExpressionPageEmptySpaceWidth";
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.get_ExpressionPageEmptySpaceWidth);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.<>f__mg$cache43, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(ChatExpressionUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012B01 RID: 76545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012B02 RID: 76546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012B03 RID: 76547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012B04 RID: 76548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012B05 RID: 76549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012B06 RID: 76550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012B07 RID: 76551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012B08 RID: 76552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012B09 RID: 76553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012B0A RID: 76554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012B0B RID: 76555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012B0C RID: 76556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012B0D RID: 76557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012B0E RID: 76558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012B0F RID: 76559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012B10 RID: 76560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012B11 RID: 76561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012B12 RID: 76562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012B13 RID: 76563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012B14 RID: 76564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012B15 RID: 76565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012B16 RID: 76566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012B17 RID: 76567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012B18 RID: 76568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012B19 RID: 76569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012B1A RID: 76570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012B1B RID: 76571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012B1C RID: 76572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012B1D RID: 76573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012B1E RID: 76574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012B1F RID: 76575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012B20 RID: 76576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012B21 RID: 76577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012B22 RID: 76578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012B23 RID: 76579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012B24 RID: 76580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012B25 RID: 76581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012B26 RID: 76582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012B27 RID: 76583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012B28 RID: 76584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012B29 RID: 76585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012B2A RID: 76586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012B2B RID: 76587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012B2C RID: 76588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012B2D RID: 76589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012B2E RID: 76590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012B2F RID: 76591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012B30 RID: 76592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012B31 RID: 76593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012B32 RID: 76594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012B33 RID: 76595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012B34 RID: 76596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012B35 RID: 76597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012B36 RID: 76598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012B37 RID: 76599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012B38 RID: 76600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012B39 RID: 76601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012B3A RID: 76602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012B3B RID: 76603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012B3C RID: 76604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012B3D RID: 76605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012B3E RID: 76606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012B3F RID: 76607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012B40 RID: 76608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012B41 RID: 76609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012B42 RID: 76610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012B43 RID: 76611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012B44 RID: 76612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;
}
