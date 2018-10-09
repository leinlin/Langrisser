using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200159E RID: 5534
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController : LuaObject
{
	// Token: 0x060217B2 RID: 137138 RVA: 0x00B53F38 File Offset: 0x00B52138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUserId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			teamRoomInvitePlayerListItemUIController.SetUserId(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217B3 RID: 137139 RVA: 0x00B53F90 File Offset: 0x00B52190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string userId = teamRoomInvitePlayerListItemUIController.GetUserId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217B4 RID: 137140 RVA: 0x00B53FE4 File Offset: 0x00B521E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			teamRoomInvitePlayerListItemUIController.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217B5 RID: 137141 RVA: 0x00B5403C File Offset: 0x00B5223C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLevel(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			teamRoomInvitePlayerListItemUIController.SetLevel(level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217B6 RID: 137142 RVA: 0x00B54094 File Offset: 0x00B52294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			teamRoomInvitePlayerListItemUIController.SetHeadIcon(headIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217B7 RID: 137143 RVA: 0x00B540EC File Offset: 0x00B522EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIsRecent(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			bool isRecent;
			LuaObject.checkType(l, 2, out isRecent);
			teamRoomInvitePlayerListItemUIController.SetIsRecent(isRecent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217B8 RID: 137144 RVA: 0x00B54144 File Offset: 0x00B52344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelected(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			bool selected;
			LuaObject.checkType(l, 2, out selected);
			teamRoomInvitePlayerListItemUIController.SetSelected(selected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217B9 RID: 137145 RVA: 0x00B5419C File Offset: 0x00B5239C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSelected(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			bool b = teamRoomInvitePlayerListItemUIController.IsSelected();
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

	// Token: 0x060217BA RID: 137146 RVA: 0x00B541F0 File Offset: 0x00B523F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInviteState(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			TeamRoomPlayerInviteState inviteState;
			LuaObject.checkEnum<TeamRoomPlayerInviteState>(l, 2, out inviteState);
			teamRoomInvitePlayerListItemUIController.SetInviteState(inviteState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217BB RID: 137147 RVA: 0x00B54248 File Offset: 0x00B52448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217BC RID: 137148 RVA: 0x00B5429C File Offset: 0x00B5249C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnCanNotInviteButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.OnCanNotInviteButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217BD RID: 137149 RVA: 0x00B542F0 File Offset: 0x00B524F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217BE RID: 137150 RVA: 0x00B5435C File Offset: 0x00B5255C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217BF RID: 137151 RVA: 0x00B543B0 File Offset: 0x00B525B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217C0 RID: 137152 RVA: 0x00B54404 File Offset: 0x00B52604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060217C1 RID: 137153 RVA: 0x00B544AC File Offset: 0x00B526AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217C2 RID: 137154 RVA: 0x00B54500 File Offset: 0x00B52700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217C3 RID: 137155 RVA: 0x00B5456C File Offset: 0x00B5276C
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
				TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController2 = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamRoomInvitePlayerListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060217C4 RID: 137156 RVA: 0x00B5467C File Offset: 0x00B5287C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217C5 RID: 137157 RVA: 0x00B546E8 File Offset: 0x00B528E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217C6 RID: 137158 RVA: 0x00B54754 File Offset: 0x00B52954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217C7 RID: 137159 RVA: 0x00B547C0 File Offset: 0x00B529C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217C8 RID: 137160 RVA: 0x00B5482C File Offset: 0x00B52A2C
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
				TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController2 = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamRoomInvitePlayerListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060217C9 RID: 137161 RVA: 0x00B5493C File Offset: 0x00B52B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string s = teamRoomInvitePlayerListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060217CA RID: 137162 RVA: 0x00B54998 File Offset: 0x00B52B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recentUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_recentUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217CB RID: 137163 RVA: 0x00B549F0 File Offset: 0x00B52BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recentUIStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController recentUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out recentUIStateController);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_recentUIStateController = recentUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217CC RID: 137164 RVA: 0x00B54A4C File Offset: 0x00B52C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217CD RID: 137165 RVA: 0x00B54AA4 File Offset: 0x00B52CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217CE RID: 137166 RVA: 0x00B54B00 File Offset: 0x00B52D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217CF RID: 137167 RVA: 0x00B54B58 File Offset: 0x00B52D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D0 RID: 137168 RVA: 0x00B54BB4 File Offset: 0x00B52DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIconImage(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_headIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D1 RID: 137169 RVA: 0x00B54C0C File Offset: 0x00B52E0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headIconImage(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Image headIconImage;
			LuaObject.checkType<Image>(l, 2, out headIconImage);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_headIconImage = headIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D2 RID: 137170 RVA: 0x00B54C68 File Offset: 0x00B52E68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_headIconImageGrey(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_headIconImageGrey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D3 RID: 137171 RVA: 0x00B54CC0 File Offset: 0x00B52EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headIconImageGrey(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Image headIconImageGrey;
			LuaObject.checkType<Image>(l, 2, out headIconImageGrey);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_headIconImageGrey = headIconImageGrey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D4 RID: 137172 RVA: 0x00B54D1C File Offset: 0x00B52F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_headFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D5 RID: 137173 RVA: 0x00B54D74 File Offset: 0x00B52F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Transform headFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out headFrameTransform);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_headFrameTransform = headFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D6 RID: 137174 RVA: 0x00B54DD0 File Offset: 0x00B52FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectToggle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_selectToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D7 RID: 137175 RVA: 0x00B54E28 File Offset: 0x00B53028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectToggle(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Toggle selectToggle;
			LuaObject.checkType<Toggle>(l, 2, out selectToggle);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_selectToggle = selectToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D8 RID: 137176 RVA: 0x00B54E84 File Offset: 0x00B53084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_canNotInviteButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_canNotInviteButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217D9 RID: 137177 RVA: 0x00B54EDC File Offset: 0x00B530DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canNotInviteButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Button canNotInviteButton;
			LuaObject.checkType<Button>(l, 2, out canNotInviteButton);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_canNotInviteButton = canNotInviteButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217DA RID: 137178 RVA: 0x00B54F38 File Offset: 0x00B53138
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_canNotInviteText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_canNotInviteText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217DB RID: 137179 RVA: 0x00B54F90 File Offset: 0x00B53190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canNotInviteText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			Text canNotInviteText;
			LuaObject.checkType<Text>(l, 2, out canNotInviteText);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_canNotInviteText = canNotInviteText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217DC RID: 137180 RVA: 0x00B54FEC File Offset: 0x00B531EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_userId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217DD RID: 137181 RVA: 0x00B55044 File Offset: 0x00B53244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_userId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = (TeamRoomInvitePlayerListItemUIController)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			teamRoomInvitePlayerListItemUIController.m_luaExportHelper.m_userId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060217DE RID: 137182 RVA: 0x00B550A0 File Offset: 0x00B532A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInvitePlayerListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.SetUserId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.GetUserId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.SetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.SetHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.SetIsRecent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.SetSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.IsSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.SetInviteState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.OnCanNotInviteButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache17);
		string name = "m_recentUIStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_recentUIStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_recentUIStateController);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache19, true);
		string name2 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_nameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1B, true);
		string name3 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_levelText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1D, true);
		string name4 = "m_headIconImage";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_headIconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_headIconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache1F, true);
		string name5 = "m_headIconImageGrey";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_headIconImageGrey);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_headIconImageGrey);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache21, true);
		string name6 = "m_headFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_headFrameTransform);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_headFrameTransform);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache23, true);
		string name7 = "m_selectToggle";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_selectToggle);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_selectToggle);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache25, true);
		string name8 = "m_canNotInviteButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_canNotInviteButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_canNotInviteButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache27, true);
		string name9 = "m_canNotInviteText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_canNotInviteText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_canNotInviteText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache29, true);
		string name10 = "m_userId";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.get_m_userId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.set_m_userId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.<>f__mg$cache2B, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamRoomInvitePlayerListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017658 RID: 95832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017659 RID: 95833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401765A RID: 95834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401765B RID: 95835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401765C RID: 95836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401765D RID: 95837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401765E RID: 95838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401765F RID: 95839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017660 RID: 95840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017661 RID: 95841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017662 RID: 95842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017663 RID: 95843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017664 RID: 95844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017665 RID: 95845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017666 RID: 95846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017667 RID: 95847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017668 RID: 95848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017669 RID: 95849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401766A RID: 95850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401766B RID: 95851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401766C RID: 95852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401766D RID: 95853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401766E RID: 95854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401766F RID: 95855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017670 RID: 95856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017671 RID: 95857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017672 RID: 95858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017673 RID: 95859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017674 RID: 95860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017675 RID: 95861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017676 RID: 95862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017677 RID: 95863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017678 RID: 95864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017679 RID: 95865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401767A RID: 95866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401767B RID: 95867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401767C RID: 95868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401767D RID: 95869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401767E RID: 95870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401767F RID: 95871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017680 RID: 95872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017681 RID: 95873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017682 RID: 95874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017683 RID: 95875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
