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

// Token: 0x020014F2 RID: 5362
[Preserve]
public class Lua_BlackJack_ProjectL_UI_InviteNotifyUIController : LuaObject
{
	// Token: 0x0601FA90 RID: 129680 RVA: 0x00A6BEF8 File Offset: 0x00A6A0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenIcon(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.OpenIcon();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA91 RID: 129681 RVA: 0x00A6BF44 File Offset: 0x00A6A144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenPanel(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.OpenPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA92 RID: 129682 RVA: 0x00A6BF90 File Offset: 0x00A6A190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPanelOpened(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			bool b = inviteNotifyUIController.IsPanelOpened();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA93 RID: 129683 RVA: 0x00A6BFE4 File Offset: 0x00A6A1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			inviteNotifyUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA94 RID: 129684 RVA: 0x00A6C03C File Offset: 0x00A6A23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeamRoomInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			TeamRoomInviteInfo info;
			LuaObject.checkType<TeamRoomInviteInfo>(l, 2, out info);
			int count;
			LuaObject.checkType(l, 3, out count);
			bool inBattle;
			LuaObject.checkType(l, 4, out inBattle);
			inviteNotifyUIController.SetTeamRoomInviteInfo(info, count, inBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA95 RID: 129685 RVA: 0x00A6C0B0 File Offset: 0x00A6A2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPVPInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			PVPInviteInfo info;
			LuaObject.checkType<PVPInviteInfo>(l, 2, out info);
			int count;
			LuaObject.checkType(l, 3, out count);
			bool isBattle;
			LuaObject.checkType(l, 4, out isBattle);
			inviteNotifyUIController.SetPVPInviteInfo(info, count, isBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA96 RID: 129686 RVA: 0x00A6C124 File Offset: 0x00A6A324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA97 RID: 129687 RVA: 0x00A6C178 File Offset: 0x00A6A378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosePanel(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.ClosePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA98 RID: 129688 RVA: 0x00A6C1CC File Offset: 0x00A6A3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBackgroundButtonActive(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.UpdateBackgroundButtonActive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA99 RID: 129689 RVA: 0x00A6C220 File Offset: 0x00A6A420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAcceptButtonClick(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.OnAcceptButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA9A RID: 129690 RVA: 0x00A6C274 File Offset: 0x00A6A474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRefuseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.OnRefuseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA9B RID: 129691 RVA: 0x00A6C2C8 File Offset: 0x00A6A4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA9C RID: 129692 RVA: 0x00A6C31C File Offset: 0x00A6A51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnIconButtonClick(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.OnIconButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA9D RID: 129693 RVA: 0x00A6C370 File Offset: 0x00A6A570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			inviteNotifyUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA9E RID: 129694 RVA: 0x00A6C3DC File Offset: 0x00A6A5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA9F RID: 129695 RVA: 0x00A6C430 File Offset: 0x00A6A630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAA0 RID: 129696 RVA: 0x00A6C484 File Offset: 0x00A6A684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = inviteNotifyUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FAA1 RID: 129697 RVA: 0x00A6C52C File Offset: 0x00A6A72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAA2 RID: 129698 RVA: 0x00A6C580 File Offset: 0x00A6A780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			inviteNotifyUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAA3 RID: 129699 RVA: 0x00A6C5EC File Offset: 0x00A6A7EC
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
				InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				inviteNotifyUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				InviteNotifyUIController inviteNotifyUIController2 = (InviteNotifyUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				inviteNotifyUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FAA4 RID: 129700 RVA: 0x00A6C6FC File Offset: 0x00A6A8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			inviteNotifyUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAA5 RID: 129701 RVA: 0x00A6C768 File Offset: 0x00A6A968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			inviteNotifyUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAA6 RID: 129702 RVA: 0x00A6C7D4 File Offset: 0x00A6A9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			inviteNotifyUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAA7 RID: 129703 RVA: 0x00A6C840 File Offset: 0x00A6AA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			inviteNotifyUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAA8 RID: 129704 RVA: 0x00A6C8AC File Offset: 0x00A6AAAC
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
				InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				inviteNotifyUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				InviteNotifyUIController inviteNotifyUIController2 = (InviteNotifyUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				inviteNotifyUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FAA9 RID: 129705 RVA: 0x00A6C9BC File Offset: 0x00A6ABBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			string s = inviteNotifyUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FAAA RID: 129706 RVA: 0x00A6CA18 File Offset: 0x00A6AC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAccept(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__callDele_EventOnAccept();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAAB RID: 129707 RVA: 0x00A6CA6C File Offset: 0x00A6AC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAccept(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__clearDele_EventOnAccept();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAAC RID: 129708 RVA: 0x00A6CAC0 File Offset: 0x00A6ACC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRefuse(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__callDele_EventOnRefuse();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAAD RID: 129709 RVA: 0x00A6CB14 File Offset: 0x00A6AD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRefuse(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__clearDele_EventOnRefuse();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAAE RID: 129710 RVA: 0x00A6CB68 File Offset: 0x00A6AD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClickIcon(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__callDele_EventOnClickIcon();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAAF RID: 129711 RVA: 0x00A6CBBC File Offset: 0x00A6ADBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClickIcon(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			inviteNotifyUIController.m_luaExportHelper.__clearDele_EventOnClickIcon();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAB0 RID: 129712 RVA: 0x00A6CC10 File Offset: 0x00A6AE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAccept(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					inviteNotifyUIController.EventOnAccept += value;
				}
				else if (num == 2)
				{
					inviteNotifyUIController.EventOnAccept -= value;
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

	// Token: 0x0601FAB1 RID: 129713 RVA: 0x00A6CC90 File Offset: 0x00A6AE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRefuse(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					inviteNotifyUIController.EventOnRefuse += value;
				}
				else if (num == 2)
				{
					inviteNotifyUIController.EventOnRefuse -= value;
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

	// Token: 0x0601FAB2 RID: 129714 RVA: 0x00A6CD10 File Offset: 0x00A6AF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClickIcon(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					inviteNotifyUIController.EventOnClickIcon += value;
				}
				else if (num == 2)
				{
					inviteNotifyUIController.EventOnClickIcon -= value;
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

	// Token: 0x0601FAB3 RID: 129715 RVA: 0x00A6CD90 File Offset: 0x00A6AF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconUIStateController(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_iconUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAB4 RID: 129716 RVA: 0x00A6CDE8 File Offset: 0x00A6AFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconUIStateController(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			CommonUIStateController iconUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out iconUIStateController);
			inviteNotifyUIController.m_luaExportHelper.m_iconUIStateController = iconUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAB5 RID: 129717 RVA: 0x00A6CE44 File Offset: 0x00A6B044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconButton(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_iconButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAB6 RID: 129718 RVA: 0x00A6CE9C File Offset: 0x00A6B09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconButton(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Button iconButton;
			LuaObject.checkType<Button>(l, 2, out iconButton);
			inviteNotifyUIController.m_luaExportHelper.m_iconButton = iconButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAB7 RID: 129719 RVA: 0x00A6CEF8 File Offset: 0x00A6B0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAB8 RID: 129720 RVA: 0x00A6CF50 File Offset: 0x00A6B150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			inviteNotifyUIController.m_luaExportHelper.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAB9 RID: 129721 RVA: 0x00A6CFAC File Offset: 0x00A6B1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_panelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FABA RID: 129722 RVA: 0x00A6D004 File Offset: 0x00A6B204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			CommonUIStateController panelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out panelUIStateController);
			inviteNotifyUIController.m_luaExportHelper.m_panelUIStateController = panelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FABB RID: 129723 RVA: 0x00A6D060 File Offset: 0x00A6B260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_acceptButton(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_acceptButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FABC RID: 129724 RVA: 0x00A6D0B8 File Offset: 0x00A6B2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_acceptButton(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Button acceptButton;
			LuaObject.checkType<Button>(l, 2, out acceptButton);
			inviteNotifyUIController.m_luaExportHelper.m_acceptButton = acceptButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FABD RID: 129725 RVA: 0x00A6D114 File Offset: 0x00A6B314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refuseButton(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_refuseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FABE RID: 129726 RVA: 0x00A6D16C File Offset: 0x00A6B36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refuseButton(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Button refuseButton;
			LuaObject.checkType<Button>(l, 2, out refuseButton);
			inviteNotifyUIController.m_luaExportHelper.m_refuseButton = refuseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FABF RID: 129727 RVA: 0x00A6D1C8 File Offset: 0x00A6B3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC0 RID: 129728 RVA: 0x00A6D220 File Offset: 0x00A6B420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			inviteNotifyUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC1 RID: 129729 RVA: 0x00A6D27C File Offset: 0x00A6B47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC2 RID: 129730 RVA: 0x00A6D2D4 File Offset: 0x00A6B4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			inviteNotifyUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC3 RID: 129731 RVA: 0x00A6D330 File Offset: 0x00A6B530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC4 RID: 129732 RVA: 0x00A6D388 File Offset: 0x00A6B588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			inviteNotifyUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC5 RID: 129733 RVA: 0x00A6D3E4 File Offset: 0x00A6B5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleNameText(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_battleNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC6 RID: 129734 RVA: 0x00A6D43C File Offset: 0x00A6B63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleNameText(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			Text battleNameText;
			LuaObject.checkType<Text>(l, 2, out battleNameText);
			inviteNotifyUIController.m_luaExportHelper.m_battleNameText = battleNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC7 RID: 129735 RVA: 0x00A6D498 File Offset: 0x00A6B698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPanelOpened(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteNotifyUIController.m_luaExportHelper.m_isPanelOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC8 RID: 129736 RVA: 0x00A6D4F0 File Offset: 0x00A6B6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPanelOpened(IntPtr l)
	{
		int result;
		try
		{
			InviteNotifyUIController inviteNotifyUIController = (InviteNotifyUIController)LuaObject.checkSelf(l);
			bool isPanelOpened;
			LuaObject.checkType(l, 2, out isPanelOpened);
			inviteNotifyUIController.m_luaExportHelper.m_isPanelOpened = isPanelOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FAC9 RID: 129737 RVA: 0x00A6D54C File Offset: 0x00A6B74C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.InviteNotifyUIController");
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.OpenIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.OpenPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.IsPanelOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.SetTeamRoomInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.SetPVPInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.ClosePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.UpdateBackgroundButtonActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.OnAcceptButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.OnRefuseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.OnIconButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callDele_EventOnAccept);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__clearDele_EventOnAccept);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callDele_EventOnRefuse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__clearDele_EventOnRefuse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__callDele_EventOnClickIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.__clearDele_EventOnClickIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache1F);
		string name = "EventOnAccept";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_EventOnAccept);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache20, true);
		string name2 = "EventOnRefuse";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_EventOnRefuse);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache21, true);
		string name3 = "EventOnClickIcon";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_EventOnClickIcon);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache22, true);
		string name4 = "m_iconUIStateController";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_iconUIStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_iconUIStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache24, true);
		string name5 = "m_iconButton";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_iconButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_iconButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache26, true);
		string name6 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_countText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_countText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache28, true);
		string name7 = "m_panelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_panelUIStateController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_panelUIStateController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2A, true);
		string name8 = "m_acceptButton";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_acceptButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_acceptButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2C, true);
		string name9 = "m_refuseButton";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_refuseButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_refuseButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2E, true);
		string name10 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_backgroundButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache30, true);
		string name11 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_playerNameText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache32, true);
		string name12 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_playerLevelText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache34, true);
		string name13 = "m_battleNameText";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_battleNameText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_battleNameText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache36, true);
		string name14 = "m_isPanelOpened";
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.get_m_isPanelOpened);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.set_m_isPanelOpened);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.<>f__mg$cache38, true);
		LuaObject.createTypeMetatable(l, null, typeof(InviteNotifyUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015A8E RID: 88718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015A8F RID: 88719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015A90 RID: 88720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015A91 RID: 88721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015A92 RID: 88722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015A93 RID: 88723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015A94 RID: 88724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015A95 RID: 88725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015A96 RID: 88726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015A97 RID: 88727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015A98 RID: 88728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015A99 RID: 88729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015A9A RID: 88730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015A9B RID: 88731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015A9C RID: 88732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015A9D RID: 88733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015A9E RID: 88734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015A9F RID: 88735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015AA0 RID: 88736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015AA1 RID: 88737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015AA2 RID: 88738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015AA3 RID: 88739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015AA4 RID: 88740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015AA5 RID: 88741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015AA6 RID: 88742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015AA7 RID: 88743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015AA8 RID: 88744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015AA9 RID: 88745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015AAA RID: 88746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015AAB RID: 88747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015AAC RID: 88748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015AAD RID: 88749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015AAE RID: 88750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015AAF RID: 88751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015AB0 RID: 88752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015AB1 RID: 88753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015AB2 RID: 88754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015AB3 RID: 88755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015AB4 RID: 88756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015AB5 RID: 88757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015AB6 RID: 88758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015AB7 RID: 88759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015AB8 RID: 88760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015AB9 RID: 88761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015ABA RID: 88762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015ABB RID: 88763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015ABC RID: 88764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015ABD RID: 88765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015ABE RID: 88766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015ABF RID: 88767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015AC0 RID: 88768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015AC1 RID: 88769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015AC2 RID: 88770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015AC3 RID: 88771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015AC4 RID: 88772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015AC5 RID: 88773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015AC6 RID: 88774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;
}
