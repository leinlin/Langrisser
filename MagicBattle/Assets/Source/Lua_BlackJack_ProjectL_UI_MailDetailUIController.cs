using System;
using System.Collections.Generic;
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

// Token: 0x02001502 RID: 5378
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MailDetailUIController : LuaObject
{
	// Token: 0x0601FD52 RID: 130386 RVA: 0x00A812E0 File Offset: 0x00A7F4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateMailDetail(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Mail mailInfo;
			LuaObject.checkType<Mail>(l, 2, out mailInfo);
			bool haveMail;
			LuaObject.checkType(l, 3, out haveMail);
			mailDetailUIController.UpdateMailDetail(mailInfo, haveMail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD53 RID: 130387 RVA: 0x00A81344 File Offset: 0x00A7F544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			mailDetailUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD54 RID: 130388 RVA: 0x00A81398 File Offset: 0x00A7F598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAttachmentsUI(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Mail mailInfo;
			LuaObject.checkType<Mail>(l, 2, out mailInfo);
			mailDetailUIController.m_luaExportHelper.ShowAttachmentsUI(mailInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD55 RID: 130389 RVA: 0x00A813F4 File Offset: 0x00A7F5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			mailDetailUIController.m_luaExportHelper.OnGotoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD56 RID: 130390 RVA: 0x00A81448 File Offset: 0x00A7F648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetAttachmentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			mailDetailUIController.m_luaExportHelper.OnGetAttachmentButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD57 RID: 130391 RVA: 0x00A8149C File Offset: 0x00A7F69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			mailDetailUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD58 RID: 130392 RVA: 0x00A81508 File Offset: 0x00A7F708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			mailDetailUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD59 RID: 130393 RVA: 0x00A8155C File Offset: 0x00A7F75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			mailDetailUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD5A RID: 130394 RVA: 0x00A815B0 File Offset: 0x00A7F7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = mailDetailUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FD5B RID: 130395 RVA: 0x00A81658 File Offset: 0x00A7F858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			mailDetailUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD5C RID: 130396 RVA: 0x00A816AC File Offset: 0x00A7F8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			mailDetailUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD5D RID: 130397 RVA: 0x00A81718 File Offset: 0x00A7F918
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
				MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				mailDetailUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MailDetailUIController mailDetailUIController2 = (MailDetailUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				mailDetailUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FD5E RID: 130398 RVA: 0x00A81828 File Offset: 0x00A7FA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailDetailUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD5F RID: 130399 RVA: 0x00A81894 File Offset: 0x00A7FA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD60 RID: 130400 RVA: 0x00A81900 File Offset: 0x00A7FB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD61 RID: 130401 RVA: 0x00A8196C File Offset: 0x00A7FB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			mailDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD62 RID: 130402 RVA: 0x00A819D8 File Offset: 0x00A7FBD8
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
				MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				mailDetailUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MailDetailUIController mailDetailUIController2 = (MailDetailUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				mailDetailUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FD63 RID: 130403 RVA: 0x00A81AE8 File Offset: 0x00A7FCE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			string s = mailDetailUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FD64 RID: 130404 RVA: 0x00A81B44 File Offset: 0x00A7FD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetAttachmentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Mail obj;
			LuaObject.checkType<Mail>(l, 2, out obj);
			mailDetailUIController.m_luaExportHelper.__callDele_EventOnGetAttachmentButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD65 RID: 130405 RVA: 0x00A81BA0 File Offset: 0x00A7FDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetAttachmentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Mail obj;
			LuaObject.checkType<Mail>(l, 2, out obj);
			mailDetailUIController.m_luaExportHelper.__clearDele_EventOnGetAttachmentButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD66 RID: 130406 RVA: 0x00A81BFC File Offset: 0x00A7FDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Mail obj;
			LuaObject.checkType<Mail>(l, 2, out obj);
			mailDetailUIController.m_luaExportHelper.__callDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD67 RID: 130407 RVA: 0x00A81C58 File Offset: 0x00A7FE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Mail obj;
			LuaObject.checkType<Mail>(l, 2, out obj);
			mailDetailUIController.m_luaExportHelper.__clearDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD68 RID: 130408 RVA: 0x00A81CB4 File Offset: 0x00A7FEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentMailInfo(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.m_luaExportHelper.m_currentMailInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD69 RID: 130409 RVA: 0x00A81D0C File Offset: 0x00A7FF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentMailInfo(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Mail currentMailInfo;
			LuaObject.checkType<Mail>(l, 2, out currentMailInfo);
			mailDetailUIController.m_luaExportHelper.m_currentMailInfo = currentMailInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD6A RID: 130410 RVA: 0x00A81D68 File Offset: 0x00A7FF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD6B RID: 130411 RVA: 0x00A81DC0 File Offset: 0x00A7FFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			mailDetailUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD6C RID: 130412 RVA: 0x00A81E1C File Offset: 0x00A8001C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attachmentUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.m_luaExportHelper.m_attachmentUICtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD6D RID: 130413 RVA: 0x00A81E74 File Offset: 0x00A80074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attachmentUICtrlList(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			List<RewardGoodsUIController> attachmentUICtrlList;
			LuaObject.checkType<List<RewardGoodsUIController>>(l, 2, out attachmentUICtrlList);
			mailDetailUIController.m_luaExportHelper.m_attachmentUICtrlList = attachmentUICtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD6E RID: 130414 RVA: 0x00A81ED0 File Offset: 0x00A800D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetAttachmentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Action<Mail> value;
			int num = LuaObject.checkDelegate<Action<Mail>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					mailDetailUIController.EventOnGetAttachmentButtonClick += value;
				}
				else if (num == 2)
				{
					mailDetailUIController.EventOnGetAttachmentButtonClick -= value;
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

	// Token: 0x0601FD6F RID: 130415 RVA: 0x00A81F50 File Offset: 0x00A80150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Action<Mail> value;
			int num = LuaObject.checkDelegate<Action<Mail>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					mailDetailUIController.EventOnGotoButtonClick += value;
				}
				else if (num == 2)
				{
					mailDetailUIController.EventOnGotoButtonClick -= value;
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

	// Token: 0x0601FD70 RID: 130416 RVA: 0x00A81FD0 File Offset: 0x00A801D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemUICtrlPrefab(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.m_luaExportHelper.ItemUICtrlPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD71 RID: 130417 RVA: 0x00A82028 File Offset: 0x00A80228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ItemUICtrlPrefab(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			GameObject itemUICtrlPrefab;
			LuaObject.checkType<GameObject>(l, 2, out itemUICtrlPrefab);
			mailDetailUIController.m_luaExportHelper.ItemUICtrlPrefab = itemUICtrlPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD72 RID: 130418 RVA: 0x00A82084 File Offset: 0x00A80284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BgUIState(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.BgUIState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD73 RID: 130419 RVA: 0x00A820D8 File Offset: 0x00A802D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BgUIState(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			CommonUIStateController bgUIState;
			LuaObject.checkType<CommonUIStateController>(l, 2, out bgUIState);
			mailDetailUIController.BgUIState = bgUIState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD74 RID: 130420 RVA: 0x00A82130 File Offset: 0x00A80330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TitleText(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.TitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD75 RID: 130421 RVA: 0x00A82184 File Offset: 0x00A80384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TitleText(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Text titleText;
			LuaObject.checkType<Text>(l, 2, out titleText);
			mailDetailUIController.TitleText = titleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD76 RID: 130422 RVA: 0x00A821DC File Offset: 0x00A803DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TimeOutText(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.TimeOutText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD77 RID: 130423 RVA: 0x00A82230 File Offset: 0x00A80430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TimeOutText(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Text timeOutText;
			LuaObject.checkType<Text>(l, 2, out timeOutText);
			mailDetailUIController.TimeOutText = timeOutText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD78 RID: 130424 RVA: 0x00A82288 File Offset: 0x00A80488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ContextText(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.ContextText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD79 RID: 130425 RVA: 0x00A822DC File Offset: 0x00A804DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ContextText(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Text contextText;
			LuaObject.checkType<Text>(l, 2, out contextText);
			mailDetailUIController.ContextText = contextText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD7A RID: 130426 RVA: 0x00A82334 File Offset: 0x00A80534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SmallContextText(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.SmallContextText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD7B RID: 130427 RVA: 0x00A82388 File Offset: 0x00A80588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SmallContextText(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Text smallContextText;
			LuaObject.checkType<Text>(l, 2, out smallContextText);
			mailDetailUIController.SmallContextText = smallContextText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD7C RID: 130428 RVA: 0x00A823E0 File Offset: 0x00A805E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardRoot(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.RewardRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD7D RID: 130429 RVA: 0x00A82434 File Offset: 0x00A80634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RewardRoot(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			GameObject rewardRoot;
			LuaObject.checkType<GameObject>(l, 2, out rewardRoot);
			mailDetailUIController.RewardRoot = rewardRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD7E RID: 130430 RVA: 0x00A8248C File Offset: 0x00A8068C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GetButton(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.GetButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD7F RID: 130431 RVA: 0x00A824E0 File Offset: 0x00A806E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetButton(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			ButtonEx getButton;
			LuaObject.checkType<ButtonEx>(l, 2, out getButton);
			mailDetailUIController.GetButton = getButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD80 RID: 130432 RVA: 0x00A82538 File Offset: 0x00A80738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GotoButton(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.GotoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD81 RID: 130433 RVA: 0x00A8258C File Offset: 0x00A8078C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GotoButton(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			Button gotoButton;
			LuaObject.checkType<Button>(l, 2, out gotoButton);
			mailDetailUIController.GotoButton = gotoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD82 RID: 130434 RVA: 0x00A825E4 File Offset: 0x00A807E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChooseTextGo(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.ChooseTextGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD83 RID: 130435 RVA: 0x00A82638 File Offset: 0x00A80838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChooseTextGo(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			GameObject chooseTextGo;
			LuaObject.checkType<GameObject>(l, 2, out chooseTextGo);
			mailDetailUIController.ChooseTextGo = chooseTextGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD84 RID: 130436 RVA: 0x00A82690 File Offset: 0x00A80890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NoneTextGo(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailDetailUIController.NoneTextGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD85 RID: 130437 RVA: 0x00A826E4 File Offset: 0x00A808E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NoneTextGo(IntPtr l)
	{
		int result;
		try
		{
			MailDetailUIController mailDetailUIController = (MailDetailUIController)LuaObject.checkSelf(l);
			GameObject noneTextGo;
			LuaObject.checkType<GameObject>(l, 2, out noneTextGo);
			mailDetailUIController.NoneTextGo = noneTextGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD86 RID: 130438 RVA: 0x00A8273C File Offset: 0x00A8093C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MailDetailUIController");
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.UpdateMailDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.ShowAttachmentsUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.OnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.OnGetAttachmentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callDele_EventOnGetAttachmentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__clearDele_EventOnGetAttachmentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__callDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.__clearDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache15);
		string name = "m_currentMailInfo";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_m_currentMailInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_m_currentMailInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache17, true);
		string name2 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_m_playerContext);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache19, true);
		string name3 = "m_attachmentUICtrlList";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_m_attachmentUICtrlList);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_m_attachmentUICtrlList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1B, true);
		string name4 = "EventOnGetAttachmentButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_EventOnGetAttachmentButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1C, true);
		string name5 = "EventOnGotoButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1D, true);
		string name6 = "ItemUICtrlPrefab";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_ItemUICtrlPrefab);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_ItemUICtrlPrefab);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache1F, true);
		string name7 = "BgUIState";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_BgUIState);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_BgUIState);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache21, true);
		string name8 = "TitleText";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_TitleText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_TitleText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache23, true);
		string name9 = "TimeOutText";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_TimeOutText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_TimeOutText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache25, true);
		string name10 = "ContextText";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_ContextText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_ContextText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache27, true);
		string name11 = "SmallContextText";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_SmallContextText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_SmallContextText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache29, true);
		string name12 = "RewardRoot";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_RewardRoot);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_RewardRoot);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2B, true);
		string name13 = "GetButton";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_GetButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_GetButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2D, true);
		string name14 = "GotoButton";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_GotoButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_GotoButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache2F, true);
		string name15 = "ChooseTextGo";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_ChooseTextGo);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_ChooseTextGo);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache31, true);
		string name16 = "NoneTextGo";
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.get_NoneTextGo);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailDetailUIController.set_NoneTextGo);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_MailDetailUIController.<>f__mg$cache33, true);
		LuaObject.createTypeMetatable(l, null, typeof(MailDetailUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015D30 RID: 89392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015D31 RID: 89393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015D32 RID: 89394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015D33 RID: 89395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015D34 RID: 89396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015D35 RID: 89397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015D36 RID: 89398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015D37 RID: 89399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015D38 RID: 89400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015D39 RID: 89401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015D3A RID: 89402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015D3B RID: 89403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015D3C RID: 89404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015D3D RID: 89405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015D3E RID: 89406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015D3F RID: 89407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015D40 RID: 89408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015D41 RID: 89409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015D42 RID: 89410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015D43 RID: 89411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015D44 RID: 89412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015D45 RID: 89413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015D46 RID: 89414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015D47 RID: 89415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015D48 RID: 89416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015D49 RID: 89417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015D4A RID: 89418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015D4B RID: 89419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015D4C RID: 89420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015D4D RID: 89421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015D4E RID: 89422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015D4F RID: 89423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015D50 RID: 89424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015D51 RID: 89425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015D52 RID: 89426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015D53 RID: 89427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015D54 RID: 89428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015D55 RID: 89429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015D56 RID: 89430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015D57 RID: 89431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015D58 RID: 89432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015D59 RID: 89433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015D5A RID: 89434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015D5B RID: 89435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015D5C RID: 89436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015D5D RID: 89437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015D5E RID: 89438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015D5F RID: 89439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015D60 RID: 89440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015D61 RID: 89441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015D62 RID: 89442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015D63 RID: 89443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;
}
