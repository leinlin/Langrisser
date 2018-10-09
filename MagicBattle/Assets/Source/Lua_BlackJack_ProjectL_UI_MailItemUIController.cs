using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001503 RID: 5379
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MailItemUIController : LuaObject
{
	// Token: 0x0601FD88 RID: 130440 RVA: 0x00A82EA4 File Offset: 0x00A810A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMailInfo(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Mail mailInfo;
			LuaObject.checkType<Mail>(l, 2, out mailInfo);
			bool isSelected;
			LuaObject.checkType(l, 3, out isSelected);
			mailItemUIController.UpdateMailInfo(mailInfo, isSelected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD89 RID: 130441 RVA: 0x00A82F08 File Offset: 0x00A81108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			mailItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD8A RID: 130442 RVA: 0x00A82F5C File Offset: 0x00A8115C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStateIconSpriteByMailState(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Mail stateIconSpriteByMailState;
			LuaObject.checkType<Mail>(l, 2, out stateIconSpriteByMailState);
			mailItemUIController.m_luaExportHelper.SetStateIconSpriteByMailState(stateIconSpriteByMailState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD8B RID: 130443 RVA: 0x00A82FB8 File Offset: 0x00A811B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMailItemClick(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			mailItemUIController.m_luaExportHelper.OnMailItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD8C RID: 130444 RVA: 0x00A8300C File Offset: 0x00A8120C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			mailItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD8D RID: 130445 RVA: 0x00A83078 File Offset: 0x00A81278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			mailItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD8E RID: 130446 RVA: 0x00A830CC File Offset: 0x00A812CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			mailItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD8F RID: 130447 RVA: 0x00A83120 File Offset: 0x00A81320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = mailItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FD90 RID: 130448 RVA: 0x00A831C8 File Offset: 0x00A813C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			mailItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD91 RID: 130449 RVA: 0x00A8321C File Offset: 0x00A8141C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			mailItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD92 RID: 130450 RVA: 0x00A83288 File Offset: 0x00A81488
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
				MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				mailItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MailItemUIController mailItemUIController2 = (MailItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				mailItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FD93 RID: 130451 RVA: 0x00A83398 File Offset: 0x00A81598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD94 RID: 130452 RVA: 0x00A83404 File Offset: 0x00A81604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD95 RID: 130453 RVA: 0x00A83470 File Offset: 0x00A81670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD96 RID: 130454 RVA: 0x00A834DC File Offset: 0x00A816DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD97 RID: 130455 RVA: 0x00A83548 File Offset: 0x00A81748
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
				MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				mailItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MailItemUIController mailItemUIController2 = (MailItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				mailItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FD98 RID: 130456 RVA: 0x00A83658 File Offset: 0x00A81858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			string s = mailItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FD99 RID: 130457 RVA: 0x00A836B4 File Offset: 0x00A818B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnMailItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			MailItemUIController obj;
			LuaObject.checkType<MailItemUIController>(l, 2, out obj);
			mailItemUIController.m_luaExportHelper.__callDele_EventOnMailItemButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD9A RID: 130458 RVA: 0x00A83710 File Offset: 0x00A81910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMailItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			MailItemUIController obj;
			LuaObject.checkType<MailItemUIController>(l, 2, out obj);
			mailItemUIController.m_luaExportHelper.__clearDele_EventOnMailItemButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD9B RID: 130459 RVA: 0x00A8376C File Offset: 0x00A8196C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CurrentMailInfo(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailItemUIController.CurrentMailInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD9C RID: 130460 RVA: 0x00A837C0 File Offset: 0x00A819C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CurrentMailInfo(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Mail currentMailInfo;
			LuaObject.checkType<Mail>(l, 2, out currentMailInfo);
			mailItemUIController.CurrentMailInfo = currentMailInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD9D RID: 130461 RVA: 0x00A83818 File Offset: 0x00A81A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailItemUIController.m_luaExportHelper.m_playerCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD9E RID: 130462 RVA: 0x00A83870 File Offset: 0x00A81A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerCtx;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerCtx);
			mailItemUIController.m_luaExportHelper.m_playerCtx = playerCtx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD9F RID: 130463 RVA: 0x00A838CC File Offset: 0x00A81ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMailItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Action<MailItemUIController> value;
			int num = LuaObject.checkDelegate<Action<MailItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					mailItemUIController.EventOnMailItemButtonClick += value;
				}
				else if (num == 2)
				{
					mailItemUIController.EventOnMailItemButtonClick -= value;
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

	// Token: 0x0601FDA0 RID: 130464 RVA: 0x00A8394C File Offset: 0x00A81B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MailItemButton(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailItemUIController.MailItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA1 RID: 130465 RVA: 0x00A839A0 File Offset: 0x00A81BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MailItemButton(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Button mailItemButton;
			LuaObject.checkType<Button>(l, 2, out mailItemButton);
			mailItemUIController.MailItemButton = mailItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA2 RID: 130466 RVA: 0x00A839F8 File Offset: 0x00A81BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailItemUIController.m_uiStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA3 RID: 130467 RVA: 0x00A83A4C File Offset: 0x00A81C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateCtrl);
			mailItemUIController.m_uiStateCtrl = uiStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA4 RID: 130468 RVA: 0x00A83AA4 File Offset: 0x00A81CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MailTitleText(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailItemUIController.MailTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA5 RID: 130469 RVA: 0x00A83AF8 File Offset: 0x00A81CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MailTitleText(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Text mailTitleText;
			LuaObject.checkType<Text>(l, 2, out mailTitleText);
			mailItemUIController.MailTitleText = mailTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA6 RID: 130470 RVA: 0x00A83B50 File Offset: 0x00A81D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SendTimeText(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailItemUIController.SendTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA7 RID: 130471 RVA: 0x00A83BA4 File Offset: 0x00A81DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SendTimeText(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Text sendTimeText;
			LuaObject.checkType<Text>(l, 2, out sendTimeText);
			mailItemUIController.SendTimeText = sendTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA8 RID: 130472 RVA: 0x00A83BFC File Offset: 0x00A81DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectedImage(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailItemUIController.SelectedImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDA9 RID: 130473 RVA: 0x00A83C50 File Offset: 0x00A81E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SelectedImage(IntPtr l)
	{
		int result;
		try
		{
			MailItemUIController mailItemUIController = (MailItemUIController)LuaObject.checkSelf(l);
			Image selectedImage;
			LuaObject.checkType<Image>(l, 2, out selectedImage);
			mailItemUIController.SelectedImage = selectedImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDAA RID: 130474 RVA: 0x00A83CA8 File Offset: 0x00A81EA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MailItemUIController");
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.UpdateMailInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.SetStateIconSpriteByMailState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.OnMailItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__callDele_EventOnMailItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.__clearDele_EventOnMailItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache12);
		string name = "CurrentMailInfo";
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.get_CurrentMailInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.set_CurrentMailInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache14, true);
		string name2 = "m_playerCtx";
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.get_m_playerCtx);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.set_m_playerCtx);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache16, true);
		string name3 = "EventOnMailItemButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.set_EventOnMailItemButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache17, true);
		string name4 = "MailItemButton";
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.get_MailItemButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.set_MailItemButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache19, true);
		string name5 = "m_uiStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.get_m_uiStateCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.set_m_uiStateCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1B, true);
		string name6 = "MailTitleText";
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.get_MailTitleText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.set_MailTitleText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1D, true);
		string name7 = "SendTimeText";
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.get_SendTimeText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.set_SendTimeText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache1F, true);
		string name8 = "SelectedImage";
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.get_SelectedImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailItemUIController.set_SelectedImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_MailItemUIController.<>f__mg$cache21, true);
		LuaObject.createTypeMetatable(l, null, typeof(MailItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015D64 RID: 89444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015D65 RID: 89445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015D66 RID: 89446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015D67 RID: 89447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015D68 RID: 89448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015D69 RID: 89449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015D6A RID: 89450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015D6B RID: 89451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015D6C RID: 89452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015D6D RID: 89453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015D6E RID: 89454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015D6F RID: 89455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015D70 RID: 89456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015D71 RID: 89457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015D72 RID: 89458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015D73 RID: 89459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015D74 RID: 89460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015D75 RID: 89461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015D76 RID: 89462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015D77 RID: 89463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015D78 RID: 89464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015D79 RID: 89465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015D7A RID: 89466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015D7B RID: 89467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015D7C RID: 89468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015D7D RID: 89469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015D7E RID: 89470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015D7F RID: 89471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015D80 RID: 89472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015D81 RID: 89473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015D82 RID: 89474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015D83 RID: 89475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015D84 RID: 89476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015D85 RID: 89477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
