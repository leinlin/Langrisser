using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001445 RID: 5189
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendBigItemUIController : LuaObject
{
	// Token: 0x0601DE75 RID: 122485 RVA: 0x0098CAF4 File Offset: 0x0098ACF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFriendInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			UserSummary userSummy;
			LuaObject.checkType<UserSummary>(l, 2, out userSummy);
			FriendInfoType friendInfoType;
			LuaObject.checkEnum<FriendInfoType>(l, 3, out friendInfoType);
			bool isChatGroupOwner;
			LuaObject.checkType(l, 4, out isChatGroupOwner);
			friendBigItemUIController.SetFriendInfo(userSummy, friendInfoType, isChatGroupOwner);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE76 RID: 122486 RVA: 0x0098CB68 File Offset: 0x0098AD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserID(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string userID = friendBigItemUIController.GetUserID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE77 RID: 122487 RVA: 0x0098CBBC File Offset: 0x0098ADBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserSummy(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			UserSummary userSummy = friendBigItemUIController.GetUserSummy();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE78 RID: 122488 RVA: 0x0098CC10 File Offset: 0x0098AE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSimpleInfoPostionType(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			PlayerSimpleInfoUITask.PostionType simpleInfoPostionType = friendBigItemUIController.GetSimpleInfoPostionType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)simpleInfoPostionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE79 RID: 122489 RVA: 0x0098CC64 File Offset: 0x0098AE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerSimpleInfoPos(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Vector3 playerSimpleInfoPos = friendBigItemUIController.GetPlayerSimpleInfoPos();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE7A RID: 122490 RVA: 0x0098CCB8 File Offset: 0x0098AEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE7B RID: 122491 RVA: 0x0098CD0C File Offset: 0x0098AF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetServerName(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			string serverName = friendBigItemUIController.m_luaExportHelper.GetServerName(userId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE7C RID: 122492 RVA: 0x0098CD74 File Offset: 0x0098AF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnItemButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE7D RID: 122493 RVA: 0x0098CDC8 File Offset: 0x0098AFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE7E RID: 122494 RVA: 0x0098CE1C File Offset: 0x0098B01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnKickButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnKickButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE7F RID: 122495 RVA: 0x0098CE70 File Offset: 0x0098B070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnblockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnUnblockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE80 RID: 122496 RVA: 0x0098CEC4 File Offset: 0x0098B0C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE81 RID: 122497 RVA: 0x0098CF18 File Offset: 0x0098B118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnSendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE82 RID: 122498 RVA: 0x0098CF6C File Offset: 0x0098B16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnGetButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE83 RID: 122499 RVA: 0x0098CFC0 File Offset: 0x0098B1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDoneButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.OnDoneButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE84 RID: 122500 RVA: 0x0098D014 File Offset: 0x0098B214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			friendBigItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE85 RID: 122501 RVA: 0x0098D080 File Offset: 0x0098B280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE86 RID: 122502 RVA: 0x0098D0D4 File Offset: 0x0098B2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE87 RID: 122503 RVA: 0x0098D128 File Offset: 0x0098B328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = friendBigItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DE88 RID: 122504 RVA: 0x0098D1D0 File Offset: 0x0098B3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			friendBigItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE89 RID: 122505 RVA: 0x0098D224 File Offset: 0x0098B424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			friendBigItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE8A RID: 122506 RVA: 0x0098D290 File Offset: 0x0098B490
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
				FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				friendBigItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FriendBigItemUIController friendBigItemUIController2 = (FriendBigItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				friendBigItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DE8B RID: 122507 RVA: 0x0098D3A0 File Offset: 0x0098B5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendBigItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE8C RID: 122508 RVA: 0x0098D40C File Offset: 0x0098B60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendBigItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE8D RID: 122509 RVA: 0x0098D478 File Offset: 0x0098B678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendBigItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE8E RID: 122510 RVA: 0x0098D4E4 File Offset: 0x0098B6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendBigItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE8F RID: 122511 RVA: 0x0098D550 File Offset: 0x0098B750
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
				FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				friendBigItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FriendBigItemUIController friendBigItemUIController2 = (FriendBigItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				friendBigItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DE90 RID: 122512 RVA: 0x0098D660 File Offset: 0x0098B860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string s = friendBigItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DE91 RID: 122513 RVA: 0x0098D6BC File Offset: 0x0098B8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__callDele_EventOnShowPlayerSimpleInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE92 RID: 122514 RVA: 0x0098D718 File Offset: 0x0098B918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__clearDele_EventOnShowPlayerSimpleInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE93 RID: 122515 RVA: 0x0098D774 File Offset: 0x0098B974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAdd(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__callDele_EventOnAdd(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE94 RID: 122516 RVA: 0x0098D7D0 File Offset: 0x0098B9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAdd(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__clearDele_EventOnAdd(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE95 RID: 122517 RVA: 0x0098D82C File Offset: 0x0098BA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnKickFromGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__callDele_EventOnKickFromGroup(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE96 RID: 122518 RVA: 0x0098D888 File Offset: 0x0098BA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnKickFromGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__clearDele_EventOnKickFromGroup(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE97 RID: 122519 RVA: 0x0098D8E4 File Offset: 0x0098BAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUnblock(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__callDele_EventOnUnblock(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE98 RID: 122520 RVA: 0x0098D940 File Offset: 0x0098BB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUnblock(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__clearDele_EventOnUnblock(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE99 RID: 122521 RVA: 0x0098D99C File Offset: 0x0098BB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__callDele_EventOnChat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE9A RID: 122522 RVA: 0x0098D9F8 File Offset: 0x0098BBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__clearDele_EventOnChat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE9B RID: 122523 RVA: 0x0098DA54 File Offset: 0x0098BC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSendFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__callDele_EventOnSendFriendShipPoints(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE9C RID: 122524 RVA: 0x0098DAB0 File Offset: 0x0098BCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSendFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__clearDele_EventOnSendFriendShipPoints(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE9D RID: 122525 RVA: 0x0098DB0C File Offset: 0x0098BD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__callDele_EventOnGetFriendShipPoints(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE9E RID: 122526 RVA: 0x0098DB68 File Offset: 0x0098BD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__clearDele_EventOnGetFriendShipPoints(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE9F RID: 122527 RVA: 0x0098DBC4 File Offset: 0x0098BDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFriendShipPointsDone(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__callDele_EventOnFriendShipPointsDone(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEA0 RID: 122528 RVA: 0x0098DC20 File Offset: 0x0098BE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFriendShipPointsDone(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController obj;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out obj);
			friendBigItemUIController.m_luaExportHelper.__clearDele_EventOnFriendShipPointsDone(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEA1 RID: 122529 RVA: 0x0098DC7C File Offset: 0x0098BE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Action<FriendBigItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendBigItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendBigItemUIController.EventOnShowPlayerSimpleInfo += value;
				}
				else if (num == 2)
				{
					friendBigItemUIController.EventOnShowPlayerSimpleInfo -= value;
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

	// Token: 0x0601DEA2 RID: 122530 RVA: 0x0098DCFC File Offset: 0x0098BEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAdd(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Action<FriendBigItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendBigItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendBigItemUIController.EventOnAdd += value;
				}
				else if (num == 2)
				{
					friendBigItemUIController.EventOnAdd -= value;
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

	// Token: 0x0601DEA3 RID: 122531 RVA: 0x0098DD7C File Offset: 0x0098BF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnKickFromGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Action<FriendBigItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendBigItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendBigItemUIController.EventOnKickFromGroup += value;
				}
				else if (num == 2)
				{
					friendBigItemUIController.EventOnKickFromGroup -= value;
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

	// Token: 0x0601DEA4 RID: 122532 RVA: 0x0098DDFC File Offset: 0x0098BFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUnblock(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Action<FriendBigItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendBigItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendBigItemUIController.EventOnUnblock += value;
				}
				else if (num == 2)
				{
					friendBigItemUIController.EventOnUnblock -= value;
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

	// Token: 0x0601DEA5 RID: 122533 RVA: 0x0098DE7C File Offset: 0x0098C07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Action<FriendBigItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendBigItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendBigItemUIController.EventOnChat += value;
				}
				else if (num == 2)
				{
					friendBigItemUIController.EventOnChat -= value;
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

	// Token: 0x0601DEA6 RID: 122534 RVA: 0x0098DEFC File Offset: 0x0098C0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSendFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Action<FriendBigItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendBigItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendBigItemUIController.EventOnSendFriendShipPoints += value;
				}
				else if (num == 2)
				{
					friendBigItemUIController.EventOnSendFriendShipPoints -= value;
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

	// Token: 0x0601DEA7 RID: 122535 RVA: 0x0098DF7C File Offset: 0x0098C17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Action<FriendBigItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendBigItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendBigItemUIController.EventOnGetFriendShipPoints += value;
				}
				else if (num == 2)
				{
					friendBigItemUIController.EventOnGetFriendShipPoints -= value;
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

	// Token: 0x0601DEA8 RID: 122536 RVA: 0x0098DFFC File Offset: 0x0098C1FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnFriendShipPointsDone(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Action<FriendBigItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendBigItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendBigItemUIController.EventOnFriendShipPointsDone += value;
				}
				else if (num == 2)
				{
					friendBigItemUIController.EventOnFriendShipPointsDone -= value;
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

	// Token: 0x0601DEA9 RID: 122537 RVA: 0x0098E07C File Offset: 0x0098C27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_itemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEAA RID: 122538 RVA: 0x0098E0D4 File Offset: 0x0098C2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button itemButton;
			LuaObject.checkType<Button>(l, 2, out itemButton);
			friendBigItemUIController.m_luaExportHelper.m_itemButton = itemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEAB RID: 122539 RVA: 0x0098E130 File Offset: 0x0098C330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_chatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEAC RID: 122540 RVA: 0x0098E188 File Offset: 0x0098C388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button chatButton;
			LuaObject.checkType<Button>(l, 2, out chatButton);
			friendBigItemUIController.m_luaExportHelper.m_chatButton = chatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEAD RID: 122541 RVA: 0x0098E1E4 File Offset: 0x0098C3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonGroupUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_buttonGroupUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEAE RID: 122542 RVA: 0x0098E23C File Offset: 0x0098C43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buttonGroupUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController buttonGroupUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out buttonGroupUIStateController);
			friendBigItemUIController.m_luaExportHelper.m_buttonGroupUIStateController = buttonGroupUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEAF RID: 122543 RVA: 0x0098E298 File Offset: 0x0098C498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendOnlineUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_friendOnlineUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB0 RID: 122544 RVA: 0x0098E2F0 File Offset: 0x0098C4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendOnlineUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController friendOnlineUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out friendOnlineUIStateController);
			friendBigItemUIController.m_luaExportHelper.m_friendOnlineUIStateController = friendOnlineUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB1 RID: 122545 RVA: 0x0098E34C File Offset: 0x0098C54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendIconImage(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_friendIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB2 RID: 122546 RVA: 0x0098E3A4 File Offset: 0x0098C5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendIconImage(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Image friendIconImage;
			LuaObject.checkType<Image>(l, 2, out friendIconImage);
			friendBigItemUIController.m_luaExportHelper.m_friendIconImage = friendIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB3 RID: 122547 RVA: 0x0098E400 File Offset: 0x0098C600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendIconGreyImage(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_friendIconGreyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB4 RID: 122548 RVA: 0x0098E458 File Offset: 0x0098C658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendIconGreyImage(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Image friendIconGreyImage;
			LuaObject.checkType<Image>(l, 2, out friendIconGreyImage);
			friendBigItemUIController.m_luaExportHelper.m_friendIconGreyImage = friendIconGreyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB5 RID: 122549 RVA: 0x0098E4B4 File Offset: 0x0098C6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_friendHeadFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB6 RID: 122550 RVA: 0x0098E50C File Offset: 0x0098C70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Transform friendHeadFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out friendHeadFrameTransform);
			friendBigItemUIController.m_luaExportHelper.m_friendHeadFrameTransform = friendHeadFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB7 RID: 122551 RVA: 0x0098E568 File Offset: 0x0098C768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendNameText(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_friendNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB8 RID: 122552 RVA: 0x0098E5C0 File Offset: 0x0098C7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendNameText(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Text friendNameText;
			LuaObject.checkType<Text>(l, 2, out friendNameText);
			friendBigItemUIController.m_luaExportHelper.m_friendNameText = friendNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEB9 RID: 122553 RVA: 0x0098E61C File Offset: 0x0098C81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendLevelText(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_friendLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEBA RID: 122554 RVA: 0x0098E674 File Offset: 0x0098C874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendLevelText(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Text friendLevelText;
			LuaObject.checkType<Text>(l, 2, out friendLevelText);
			friendBigItemUIController.m_luaExportHelper.m_friendLevelText = friendLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEBB RID: 122555 RVA: 0x0098E6D0 File Offset: 0x0098C8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendServerText(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_friendServerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEBC RID: 122556 RVA: 0x0098E728 File Offset: 0x0098C928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendServerText(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Text friendServerText;
			LuaObject.checkType<Text>(l, 2, out friendServerText);
			friendBigItemUIController.m_luaExportHelper.m_friendServerText = friendServerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEBD RID: 122557 RVA: 0x0098E784 File Offset: 0x0098C984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendOnlineLongText(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_friendOnlineLongText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEBE RID: 122558 RVA: 0x0098E7DC File Offset: 0x0098C9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendOnlineLongText(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Text friendOnlineLongText;
			LuaObject.checkType<Text>(l, 2, out friendOnlineLongText);
			friendBigItemUIController.m_luaExportHelper.m_friendOnlineLongText = friendOnlineLongText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEBF RID: 122559 RVA: 0x0098E838 File Offset: 0x0098CA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_addButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC0 RID: 122560 RVA: 0x0098E890 File Offset: 0x0098CA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button addButton;
			LuaObject.checkType<Button>(l, 2, out addButton);
			friendBigItemUIController.m_luaExportHelper.m_addButton = addButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC1 RID: 122561 RVA: 0x0098E8EC File Offset: 0x0098CAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unblockButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_unblockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC2 RID: 122562 RVA: 0x0098E944 File Offset: 0x0098CB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unblockButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button unblockButton;
			LuaObject.checkType<Button>(l, 2, out unblockButton);
			friendBigItemUIController.m_luaExportHelper.m_unblockButton = unblockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC3 RID: 122563 RVA: 0x0098E9A0 File Offset: 0x0098CBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_kickButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_kickButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC4 RID: 122564 RVA: 0x0098E9F8 File Offset: 0x0098CBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_kickButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button kickButton;
			LuaObject.checkType<Button>(l, 2, out kickButton);
			friendBigItemUIController.m_luaExportHelper.m_kickButton = kickButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC5 RID: 122565 RVA: 0x0098EA54 File Offset: 0x0098CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigChatButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_bigChatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC6 RID: 122566 RVA: 0x0098EAAC File Offset: 0x0098CCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigChatButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button bigChatButton;
			LuaObject.checkType<Button>(l, 2, out bigChatButton);
			friendBigItemUIController.m_luaExportHelper.m_bigChatButton = bigChatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC7 RID: 122567 RVA: 0x0098EB08 File Offset: 0x0098CD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sendButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_sendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC8 RID: 122568 RVA: 0x0098EB60 File Offset: 0x0098CD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sendButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button sendButton;
			LuaObject.checkType<Button>(l, 2, out sendButton);
			friendBigItemUIController.m_luaExportHelper.m_sendButton = sendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEC9 RID: 122569 RVA: 0x0098EBBC File Offset: 0x0098CDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_getButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DECA RID: 122570 RVA: 0x0098EC14 File Offset: 0x0098CE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button getButton;
			LuaObject.checkType<Button>(l, 2, out getButton);
			friendBigItemUIController.m_luaExportHelper.m_getButton = getButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DECB RID: 122571 RVA: 0x0098EC70 File Offset: 0x0098CE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_doneButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_doneButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DECC RID: 122572 RVA: 0x0098ECC8 File Offset: 0x0098CEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_doneButton(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			Button doneButton;
			LuaObject.checkType<Button>(l, 2, out doneButton);
			friendBigItemUIController.m_luaExportHelper.m_doneButton = doneButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DECD RID: 122573 RVA: 0x0098ED24 File Offset: 0x0098CF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userID(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_userID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DECE RID: 122574 RVA: 0x0098ED7C File Offset: 0x0098CF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userID(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			friendBigItemUIController.m_luaExportHelper.m_userID = userID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DECF RID: 122575 RVA: 0x0098EDD8 File Offset: 0x0098CFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userSummy(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_userSummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DED0 RID: 122576 RVA: 0x0098EE30 File Offset: 0x0098D030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userSummy(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			UserSummary userSummy;
			LuaObject.checkType<UserSummary>(l, 2, out userSummy);
			friendBigItemUIController.m_luaExportHelper.m_userSummy = userSummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DED1 RID: 122577 RVA: 0x0098EE8C File Offset: 0x0098D08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DED2 RID: 122578 RVA: 0x0098EEE4 File Offset: 0x0098D0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			friendBigItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DED3 RID: 122579 RVA: 0x0098EF40 File Offset: 0x0098D140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendBigItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DED4 RID: 122580 RVA: 0x0098EF98 File Offset: 0x0098D198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FriendBigItemUIController friendBigItemUIController = (FriendBigItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			friendBigItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DED5 RID: 122581 RVA: 0x0098EFF4 File Offset: 0x0098D1F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendBigItemUIController");
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.SetFriendInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.GetUserID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.GetUserSummy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.GetSimpleInfoPostionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.GetPlayerSimpleInfoPos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.GetServerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnKickButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnUnblockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnSendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnGetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.OnDoneButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callDele_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__clearDele_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callDele_EventOnAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__clearDele_EventOnAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callDele_EventOnKickFromGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__clearDele_EventOnKickFromGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callDele_EventOnUnblock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__clearDele_EventOnUnblock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callDele_EventOnChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__clearDele_EventOnChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callDele_EventOnSendFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__clearDele_EventOnSendFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callDele_EventOnGetFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__clearDele_EventOnGetFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__callDele_EventOnFriendShipPointsDone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.__clearDele_EventOnFriendShipPointsDone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2B);
		string name = "EventOnShowPlayerSimpleInfo";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2C, true);
		string name2 = "EventOnAdd";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_EventOnAdd);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2D, true);
		string name3 = "EventOnKickFromGroup";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_EventOnKickFromGroup);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2E, true);
		string name4 = "EventOnUnblock";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_EventOnUnblock);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache2F, true);
		string name5 = "EventOnChat";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_EventOnChat);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache30, true);
		string name6 = "EventOnSendFriendShipPoints";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_EventOnSendFriendShipPoints);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache31, true);
		string name7 = "EventOnGetFriendShipPoints";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_EventOnGetFriendShipPoints);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache32, true);
		string name8 = "EventOnFriendShipPointsDone";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_EventOnFriendShipPointsDone);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache33, true);
		string name9 = "m_itemButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_itemButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_itemButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache35, true);
		string name10 = "m_chatButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_chatButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_chatButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache37, true);
		string name11 = "m_buttonGroupUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_buttonGroupUIStateController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_buttonGroupUIStateController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache39, true);
		string name12 = "m_friendOnlineUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_friendOnlineUIStateController);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_friendOnlineUIStateController);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3B, true);
		string name13 = "m_friendIconImage";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_friendIconImage);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_friendIconImage);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3D, true);
		string name14 = "m_friendIconGreyImage";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_friendIconGreyImage);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_friendIconGreyImage);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache3F, true);
		string name15 = "m_friendHeadFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_friendHeadFrameTransform);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_friendHeadFrameTransform);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache41, true);
		string name16 = "m_friendNameText";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_friendNameText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_friendNameText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache43, true);
		string name17 = "m_friendLevelText";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_friendLevelText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_friendLevelText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache45, true);
		string name18 = "m_friendServerText";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_friendServerText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_friendServerText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache47, true);
		string name19 = "m_friendOnlineLongText";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_friendOnlineLongText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_friendOnlineLongText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache49, true);
		string name20 = "m_addButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_addButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_addButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4B, true);
		string name21 = "m_unblockButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_unblockButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_unblockButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4D, true);
		string name22 = "m_kickButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_kickButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_kickButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache4F, true);
		string name23 = "m_bigChatButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_bigChatButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_bigChatButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache51, true);
		string name24 = "m_sendButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_sendButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_sendButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache53, true);
		string name25 = "m_getButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_getButton);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_getButton);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache55, true);
		string name26 = "m_doneButton";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_doneButton);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_doneButton);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache57, true);
		string name27 = "m_userID";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_userID);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_userID);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache59, true);
		string name28 = "m_userSummy";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_userSummy);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_userSummy);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5B, true);
		string name29 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5D, true);
		string name30 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.get_m_playerContext);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.<>f__mg$cache5F, true);
		LuaObject.createTypeMetatable(l, null, typeof(FriendBigItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013FCD RID: 81869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013FCE RID: 81870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013FCF RID: 81871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013FD0 RID: 81872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013FD1 RID: 81873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013FD2 RID: 81874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013FD3 RID: 81875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013FD4 RID: 81876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013FD5 RID: 81877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013FD6 RID: 81878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013FD7 RID: 81879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013FD8 RID: 81880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013FD9 RID: 81881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013FDA RID: 81882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013FDB RID: 81883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013FDC RID: 81884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013FDD RID: 81885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013FDE RID: 81886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013FDF RID: 81887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013FE0 RID: 81888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013FE1 RID: 81889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013FE2 RID: 81890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013FE3 RID: 81891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013FE4 RID: 81892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013FE5 RID: 81893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013FE6 RID: 81894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013FE7 RID: 81895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013FE8 RID: 81896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013FE9 RID: 81897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013FEA RID: 81898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013FEB RID: 81899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013FEC RID: 81900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013FED RID: 81901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013FEE RID: 81902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013FEF RID: 81903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013FF0 RID: 81904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013FF1 RID: 81905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013FF2 RID: 81906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013FF3 RID: 81907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013FF4 RID: 81908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013FF5 RID: 81909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013FF6 RID: 81910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013FF7 RID: 81911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013FF8 RID: 81912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013FF9 RID: 81913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013FFA RID: 81914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013FFB RID: 81915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013FFC RID: 81916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013FFD RID: 81917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013FFE RID: 81918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013FFF RID: 81919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014000 RID: 81920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014001 RID: 81921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014002 RID: 81922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014003 RID: 81923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014004 RID: 81924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014005 RID: 81925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014006 RID: 81926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014007 RID: 81927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014008 RID: 81928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014009 RID: 81929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401400A RID: 81930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401400B RID: 81931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401400C RID: 81932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401400D RID: 81933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401400E RID: 81934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401400F RID: 81935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014010 RID: 81936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014011 RID: 81937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014012 RID: 81938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014013 RID: 81939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014014 RID: 81940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014015 RID: 81941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014016 RID: 81942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014017 RID: 81943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014018 RID: 81944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014019 RID: 81945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401401A RID: 81946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401401B RID: 81947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401401C RID: 81948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401401D RID: 81949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401401E RID: 81950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401401F RID: 81951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014020 RID: 81952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014021 RID: 81953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014022 RID: 81954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014023 RID: 81955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014024 RID: 81956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014025 RID: 81957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014026 RID: 81958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014027 RID: 81959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014028 RID: 81960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04014029 RID: 81961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401402A RID: 81962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401402B RID: 81963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401402C RID: 81964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;
}
