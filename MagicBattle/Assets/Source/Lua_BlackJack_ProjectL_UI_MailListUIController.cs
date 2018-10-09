using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001504 RID: 5380
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MailListUIController : LuaObject
{
	// Token: 0x0601FDAC RID: 130476 RVA: 0x00A84190 File Offset: 0x00A82390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDAD RID: 130477 RVA: 0x00A841DC File Offset: 0x00A823DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMailInfoList(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			List<Mail> mailInfoList;
			LuaObject.checkType<List<Mail>>(l, 2, out mailInfoList);
			Mail selectedMail;
			LuaObject.checkType<Mail>(l, 3, out selectedMail);
			bool needReSetScrollView;
			LuaObject.checkType(l, 4, out needReSetScrollView);
			mailListUIController.UpdateMailInfoList(mailInfoList, selectedMail, needReSetScrollView);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDAE RID: 130478 RVA: 0x00A84250 File Offset: 0x00A82450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReSetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.ReSetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDAF RID: 130479 RVA: 0x00A8429C File Offset: 0x00A8249C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateCurrentSelectedMailDetail(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Mail mailInfo;
			LuaObject.checkType<Mail>(l, 2, out mailInfo);
			bool listIsEmpty;
			LuaObject.checkType(l, 3, out listIsEmpty);
			mailListUIController.UpdateCurrentSelectedMailDetail(mailInfo, listIsEmpty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB0 RID: 130480 RVA: 0x00A84300 File Offset: 0x00A82500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB1 RID: 130481 RVA: 0x00A84354 File Offset: 0x00A82554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMailItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			MailItemUIController obj;
			LuaObject.checkType<MailItemUIController>(l, 2, out obj);
			mailListUIController.m_luaExportHelper.OnMailItemButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB2 RID: 130482 RVA: 0x00A843B0 File Offset: 0x00A825B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB3 RID: 130483 RVA: 0x00A84404 File Offset: 0x00A82604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetAllButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.OnGetAllButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB4 RID: 130484 RVA: 0x00A84458 File Offset: 0x00A82658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			mailListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB5 RID: 130485 RVA: 0x00A844C4 File Offset: 0x00A826C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB6 RID: 130486 RVA: 0x00A84518 File Offset: 0x00A82718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB7 RID: 130487 RVA: 0x00A8456C File Offset: 0x00A8276C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = mailListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FDB8 RID: 130488 RVA: 0x00A84614 File Offset: 0x00A82814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDB9 RID: 130489 RVA: 0x00A84668 File Offset: 0x00A82868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			mailListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDBA RID: 130490 RVA: 0x00A846D4 File Offset: 0x00A828D4
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
				MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				mailListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MailListUIController mailListUIController2 = (MailListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				mailListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FDBB RID: 130491 RVA: 0x00A847E4 File Offset: 0x00A829E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDBC RID: 130492 RVA: 0x00A84850 File Offset: 0x00A82A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDBD RID: 130493 RVA: 0x00A848BC File Offset: 0x00A82ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDBE RID: 130494 RVA: 0x00A84928 File Offset: 0x00A82B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDBF RID: 130495 RVA: 0x00A84994 File Offset: 0x00A82B94
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
				MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				mailListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MailListUIController mailListUIController2 = (MailListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				mailListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FDC0 RID: 130496 RVA: 0x00A84AA4 File Offset: 0x00A82CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			string s = mailListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FDC1 RID: 130497 RVA: 0x00A84B00 File Offset: 0x00A82D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnMailItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Mail obj;
			LuaObject.checkType<Mail>(l, 2, out obj);
			mailListUIController.m_luaExportHelper.__callDele_EventOnMailItemButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDC2 RID: 130498 RVA: 0x00A84B5C File Offset: 0x00A82D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMailItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Mail obj;
			LuaObject.checkType<Mail>(l, 2, out obj);
			mailListUIController.m_luaExportHelper.__clearDele_EventOnMailItemButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDC3 RID: 130499 RVA: 0x00A84BB8 File Offset: 0x00A82DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.__callDele_EventOnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDC4 RID: 130500 RVA: 0x00A84C0C File Offset: 0x00A82E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.__clearDele_EventOnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDC5 RID: 130501 RVA: 0x00A84C60 File Offset: 0x00A82E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetAllAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.__callDele_EventOnGetAllAttachments();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDC6 RID: 130502 RVA: 0x00A84CB4 File Offset: 0x00A82EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetAllAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			mailListUIController.m_luaExportHelper.__clearDele_EventOnGetAllAttachments();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDC7 RID: 130503 RVA: 0x00A84D08 File Offset: 0x00A82F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_itemUICtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDC8 RID: 130504 RVA: 0x00A84D60 File Offset: 0x00A82F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			List<MailItemUIController> itemUICtrlList;
			LuaObject.checkType<List<MailItemUIController>>(l, 2, out itemUICtrlList);
			mailListUIController.m_luaExportHelper.m_itemUICtrlList = itemUICtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDC9 RID: 130505 RVA: 0x00A84DBC File Offset: 0x00A82FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailDetailUICtrl(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_mailDetailUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDCA RID: 130506 RVA: 0x00A84E10 File Offset: 0x00A83010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailDetailUICtrl(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			MailDetailUIController mailDetailUICtrl;
			LuaObject.checkType<MailDetailUIController>(l, 2, out mailDetailUICtrl);
			mailListUIController.m_mailDetailUICtrl = mailDetailUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDCB RID: 130507 RVA: 0x00A84E68 File Offset: 0x00A83068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curMailItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_curMailItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDCC RID: 130508 RVA: 0x00A84EBC File Offset: 0x00A830BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curMailItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			MailItemUIController curMailItemCtrl;
			LuaObject.checkType<MailItemUIController>(l, 2, out curMailItemCtrl);
			mailListUIController.m_curMailItemCtrl = curMailItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDCD RID: 130509 RVA: 0x00A84F14 File Offset: 0x00A83114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMailItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Action<Mail> value;
			int num = LuaObject.checkDelegate<Action<Mail>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					mailListUIController.EventOnMailItemButtonClick += value;
				}
				else if (num == 2)
				{
					mailListUIController.EventOnMailItemButtonClick -= value;
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

	// Token: 0x0601FDCE RID: 130510 RVA: 0x00A84F94 File Offset: 0x00A83194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					mailListUIController.EventOnCloseButtonClick += value;
				}
				else if (num == 2)
				{
					mailListUIController.EventOnCloseButtonClick -= value;
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

	// Token: 0x0601FDCF RID: 130511 RVA: 0x00A85014 File Offset: 0x00A83214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetAllAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					mailListUIController.EventOnGetAllAttachments += value;
				}
				else if (num == 2)
				{
					mailListUIController.EventOnGetAllAttachments -= value;
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

	// Token: 0x0601FDD0 RID: 130512 RVA: 0x00A85094 File Offset: 0x00A83294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD1 RID: 130513 RVA: 0x00A850EC File Offset: 0x00A832EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			mailListUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD2 RID: 130514 RVA: 0x00A85148 File Offset: 0x00A83348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_bgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD3 RID: 130515 RVA: 0x00A851A0 File Offset: 0x00A833A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			mailListUIController.m_luaExportHelper.m_bgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD4 RID: 130516 RVA: 0x00A851FC File Offset: 0x00A833FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_mailItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD5 RID: 130517 RVA: 0x00A85254 File Offset: 0x00A83454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			GameObject mailItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out mailItemPrefab);
			mailListUIController.m_luaExportHelper.m_mailItemPrefab = mailItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD6 RID: 130518 RVA: 0x00A852B0 File Offset: 0x00A834B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailDetailGo(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_mailDetailGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD7 RID: 130519 RVA: 0x00A85308 File Offset: 0x00A83508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailDetailGo(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			GameObject mailDetailGo;
			LuaObject.checkType<GameObject>(l, 2, out mailDetailGo);
			mailListUIController.m_luaExportHelper.m_mailDetailGo = mailDetailGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD8 RID: 130520 RVA: 0x00A85364 File Offset: 0x00A83564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listScrollRect(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_listScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDD9 RID: 130521 RVA: 0x00A853BC File Offset: 0x00A835BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listScrollRect(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			ScrollRect listScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out listScrollRect);
			mailListUIController.m_luaExportHelper.m_listScrollRect = listScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDDA RID: 130522 RVA: 0x00A85418 File Offset: 0x00A83618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailListContent(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_mailListContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDDB RID: 130523 RVA: 0x00A85470 File Offset: 0x00A83670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailListContent(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			GameObject mailListContent;
			LuaObject.checkType<GameObject>(l, 2, out mailListContent);
			mailListUIController.m_luaExportHelper.m_mailListContent = mailListContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDDC RID: 130524 RVA: 0x00A854CC File Offset: 0x00A836CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailListPointBgContent(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_mailListPointBgContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDDD RID: 130525 RVA: 0x00A85524 File Offset: 0x00A83724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailListPointBgContent(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			GameObject mailListPointBgContent;
			LuaObject.checkType<GameObject>(l, 2, out mailListPointBgContent);
			mailListUIController.m_luaExportHelper.m_mailListPointBgContent = mailListPointBgContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDDE RID: 130526 RVA: 0x00A85580 File Offset: 0x00A83780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailListPointItem(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_mailListPointItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDDF RID: 130527 RVA: 0x00A855D8 File Offset: 0x00A837D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailListPointItem(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			GameObject mailListPointItem;
			LuaObject.checkType<GameObject>(l, 2, out mailListPointItem);
			mailListUIController.m_luaExportHelper.m_mailListPointItem = mailListPointItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDE0 RID: 130528 RVA: 0x00A85634 File Offset: 0x00A83834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_closeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDE1 RID: 130529 RVA: 0x00A8568C File Offset: 0x00A8388C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			mailListUIController.m_luaExportHelper.m_closeButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDE2 RID: 130530 RVA: 0x00A856E8 File Offset: 0x00A838E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getAllButton(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailListUIController.m_luaExportHelper.m_getAllButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDE3 RID: 130531 RVA: 0x00A85740 File Offset: 0x00A83940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getAllButton(IntPtr l)
	{
		int result;
		try
		{
			MailListUIController mailListUIController = (MailListUIController)LuaObject.checkSelf(l);
			Button getAllButton;
			LuaObject.checkType<Button>(l, 2, out getAllButton);
			mailListUIController.m_luaExportHelper.m_getAllButton = getAllButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDE4 RID: 130532 RVA: 0x00A8579C File Offset: 0x00A8399C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MailListUIController");
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.UpdateMailInfoList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.ReSetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.UpdateCurrentSelectedMailDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.OnMailItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.OnGetAllButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callDele_EventOnMailItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__clearDele_EventOnMailItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callDele_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__clearDele_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__callDele_EventOnGetAllAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.__clearDele_EventOnGetAllAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1A);
		string name = "m_itemUICtrlList";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_itemUICtrlList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_itemUICtrlList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1C, true);
		string name2 = "m_mailDetailUICtrl";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_mailDetailUICtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_mailDetailUICtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1E, true);
		string name3 = "m_curMailItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_curMailItemCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_curMailItemCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache20, true);
		string name4 = "EventOnMailItemButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_EventOnMailItemButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache21, true);
		string name5 = "EventOnCloseButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache22, true);
		string name6 = "EventOnGetAllAttachments";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_EventOnGetAllAttachments);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache23, true);
		string name7 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_stateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache25, true);
		string name8 = "m_bgButton";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_bgButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_bgButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache27, true);
		string name9 = "m_mailItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_mailItemPrefab);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_mailItemPrefab);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache29, true);
		string name10 = "m_mailDetailGo";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_mailDetailGo);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_mailDetailGo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2B, true);
		string name11 = "m_listScrollRect";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_listScrollRect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_listScrollRect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2D, true);
		string name12 = "m_mailListContent";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_mailListContent);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_mailListContent);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache2F, true);
		string name13 = "m_mailListPointBgContent";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_mailListPointBgContent);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_mailListPointBgContent);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache31, true);
		string name14 = "m_mailListPointItem";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_mailListPointItem);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_mailListPointItem);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache33, true);
		string name15 = "m_closeButton";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_closeButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_closeButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache35, true);
		string name16 = "m_getAllButton";
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.get_m_getAllButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailListUIController.set_m_getAllButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_MailListUIController.<>f__mg$cache37, true);
		LuaObject.createTypeMetatable(l, null, typeof(MailListUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015D86 RID: 89478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015D87 RID: 89479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015D88 RID: 89480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015D89 RID: 89481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015D8A RID: 89482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015D8B RID: 89483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015D8C RID: 89484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015D8D RID: 89485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015D8E RID: 89486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015D8F RID: 89487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015D90 RID: 89488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015D91 RID: 89489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015D92 RID: 89490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015D93 RID: 89491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015D94 RID: 89492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015D95 RID: 89493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015D96 RID: 89494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015D97 RID: 89495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015D98 RID: 89496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015D99 RID: 89497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015D9A RID: 89498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015D9B RID: 89499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015D9C RID: 89500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015D9D RID: 89501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015D9E RID: 89502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015D9F RID: 89503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015DA0 RID: 89504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015DA1 RID: 89505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015DA2 RID: 89506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015DA3 RID: 89507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015DA4 RID: 89508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015DA5 RID: 89509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015DA6 RID: 89510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015DA7 RID: 89511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015DA8 RID: 89512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015DA9 RID: 89513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015DAA RID: 89514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015DAB RID: 89515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015DAC RID: 89516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015DAD RID: 89517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015DAE RID: 89518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015DAF RID: 89519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015DB0 RID: 89520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015DB1 RID: 89521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015DB2 RID: 89522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015DB3 RID: 89523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015DB4 RID: 89524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015DB5 RID: 89525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015DB6 RID: 89526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015DB7 RID: 89527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015DB8 RID: 89528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015DB9 RID: 89529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015DBA RID: 89530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015DBB RID: 89531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015DBC RID: 89532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015DBD RID: 89533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
