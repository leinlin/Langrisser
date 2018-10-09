using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001491 RID: 5265
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController : LuaObject
{
	// Token: 0x0601E7C3 RID: 124867 RVA: 0x009D5C5C File Offset: 0x009D3E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitItemInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildMember member;
			LuaObject.checkType<GuildMember>(l, 2, out member);
			bool isSelf;
			LuaObject.checkType(l, 3, out isSelf);
			guildMemberInfoItemUIController.InitItemInfo(member, isSelf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7C4 RID: 124868 RVA: 0x009D5CC0 File Offset: 0x009D3EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildMemberInfoItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7C5 RID: 124869 RVA: 0x009D5D14 File Offset: 0x009D3F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTitleTextByEnum(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildTitle titleTextByEnum;
			LuaObject.checkEnum<GuildTitle>(l, 2, out titleTextByEnum);
			string s = guildMemberInfoItemUIController.m_luaExportHelper.SetTitleTextByEnum(titleTextByEnum);
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

	// Token: 0x0601E7C6 RID: 124870 RVA: 0x009D5D7C File Offset: 0x009D3F7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildMemberInfoItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7C7 RID: 124871 RVA: 0x009D5DD0 File Offset: 0x009D3FD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7C8 RID: 124872 RVA: 0x009D5E3C File Offset: 0x009D403C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7C9 RID: 124873 RVA: 0x009D5E90 File Offset: 0x009D4090
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7CA RID: 124874 RVA: 0x009D5EE4 File Offset: 0x009D40E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildMemberInfoItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E7CB RID: 124875 RVA: 0x009D5F8C File Offset: 0x009D418C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7CC RID: 124876 RVA: 0x009D5FE0 File Offset: 0x009D41E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7CD RID: 124877 RVA: 0x009D604C File Offset: 0x009D424C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildMemberInfoItemUIController guildMemberInfoItemUIController2 = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildMemberInfoItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E7CE RID: 124878 RVA: 0x009D615C File Offset: 0x009D435C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7CF RID: 124879 RVA: 0x009D61C8 File Offset: 0x009D43C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7D0 RID: 124880 RVA: 0x009D6234 File Offset: 0x009D4434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7D1 RID: 124881 RVA: 0x009D62A0 File Offset: 0x009D44A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7D2 RID: 124882 RVA: 0x009D630C File Offset: 0x009D450C
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
				GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildMemberInfoItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildMemberInfoItemUIController guildMemberInfoItemUIController2 = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildMemberInfoItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E7D3 RID: 124883 RVA: 0x009D641C File Offset: 0x009D461C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			string s = guildMemberInfoItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E7D4 RID: 124884 RVA: 0x009D6478 File Offset: 0x009D4678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildMemberInfoItemUIController obj;
			LuaObject.checkType<GuildMemberInfoItemUIController>(l, 2, out obj);
			guildMemberInfoItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7D5 RID: 124885 RVA: 0x009D64D4 File Offset: 0x009D46D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildMemberInfoItemUIController obj;
			LuaObject.checkType<GuildMemberInfoItemUIController>(l, 2, out obj);
			guildMemberInfoItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7D6 RID: 124886 RVA: 0x009D6530 File Offset: 0x009D4730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Action<GuildMemberInfoItemUIController> value;
			int num = LuaObject.checkDelegate<Action<GuildMemberInfoItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildMemberInfoItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					guildMemberInfoItemUIController.EventOnClick -= value;
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

	// Token: 0x0601E7D7 RID: 124887 RVA: 0x009D65B0 File Offset: 0x009D47B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7D8 RID: 124888 RVA: 0x009D6608 File Offset: 0x009D4808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			guildMemberInfoItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7D9 RID: 124889 RVA: 0x009D6664 File Offset: 0x009D4864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7DA RID: 124890 RVA: 0x009D66BC File Offset: 0x009D48BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			guildMemberInfoItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7DB RID: 124891 RVA: 0x009D6718 File Offset: 0x009D4918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_headIconStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7DC RID: 124892 RVA: 0x009D6770 File Offset: 0x009D4970
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController headIconStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out headIconStateCtrl);
			guildMemberInfoItemUIController.m_luaExportHelper.m_headIconStateCtrl = headIconStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7DD RID: 124893 RVA: 0x009D67CC File Offset: 0x009D49CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_headIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7DE RID: 124894 RVA: 0x009D6824 File Offset: 0x009D4A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Image headIcon;
			LuaObject.checkType<Image>(l, 2, out headIcon);
			guildMemberInfoItemUIController.m_luaExportHelper.m_headIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7DF RID: 124895 RVA: 0x009D6880 File Offset: 0x009D4A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIconGrey(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_headIconGrey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E0 RID: 124896 RVA: 0x009D68D8 File Offset: 0x009D4AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headIconGrey(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Image headIconGrey;
			LuaObject.checkType<Image>(l, 2, out headIconGrey);
			guildMemberInfoItemUIController.m_luaExportHelper.m_headIconGrey = headIconGrey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E1 RID: 124897 RVA: 0x009D6934 File Offset: 0x009D4B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_HeadFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_HeadFrameDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E2 RID: 124898 RVA: 0x009D698C File Offset: 0x009D4B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_HeadFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Transform headFrameDummy;
			LuaObject.checkType<Transform>(l, 2, out headFrameDummy);
			guildMemberInfoItemUIController.m_luaExportHelper.m_HeadFrameDummy = headFrameDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E3 RID: 124899 RVA: 0x009D69E8 File Offset: 0x009D4BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E4 RID: 124900 RVA: 0x009D6A40 File Offset: 0x009D4C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			guildMemberInfoItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E5 RID: 124901 RVA: 0x009D6A9C File Offset: 0x009D4C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E6 RID: 124902 RVA: 0x009D6AF4 File Offset: 0x009D4CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			guildMemberInfoItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E7 RID: 124903 RVA: 0x009D6B50 File Offset: 0x009D4D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_positionText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_positionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E8 RID: 124904 RVA: 0x009D6BA8 File Offset: 0x009D4DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_positionText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text positionText;
			LuaObject.checkType<Text>(l, 2, out positionText);
			guildMemberInfoItemUIController.m_luaExportHelper.m_positionText = positionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7E9 RID: 124905 RVA: 0x009D6C04 File Offset: 0x009D4E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_powerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7EA RID: 124906 RVA: 0x009D6C5C File Offset: 0x009D4E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text powerText;
			LuaObject.checkType<Text>(l, 2, out powerText);
			guildMemberInfoItemUIController.m_luaExportHelper.m_powerText = powerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7EB RID: 124907 RVA: 0x009D6CB8 File Offset: 0x009D4EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_exploitText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_exploitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7EC RID: 124908 RVA: 0x009D6D10 File Offset: 0x009D4F10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_exploitText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text exploitText;
			LuaObject.checkType<Text>(l, 2, out exploitText);
			guildMemberInfoItemUIController.m_luaExportHelper.m_exploitText = exploitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7ED RID: 124909 RVA: 0x009D6D6C File Offset: 0x009D4F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_vitalityText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_vitalityText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7EE RID: 124910 RVA: 0x009D6DC4 File Offset: 0x009D4FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_vitalityText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text vitalityText;
			LuaObject.checkType<Text>(l, 2, out vitalityText);
			guildMemberInfoItemUIController.m_luaExportHelper.m_vitalityText = vitalityText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7EF RID: 124911 RVA: 0x009D6E20 File Offset: 0x009D5020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_onlineStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7F0 RID: 124912 RVA: 0x009D6E78 File Offset: 0x009D5078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController onlineStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out onlineStateCtrl);
			guildMemberInfoItemUIController.m_luaExportHelper.m_onlineStateCtrl = onlineStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7F1 RID: 124913 RVA: 0x009D6ED4 File Offset: 0x009D50D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_OffLineText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.m_luaExportHelper.m_OffLineText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7F2 RID: 124914 RVA: 0x009D6F2C File Offset: 0x009D512C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_OffLineText(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text offLineText;
			LuaObject.checkType<Text>(l, 2, out offLineText);
			guildMemberInfoItemUIController.m_luaExportHelper.m_OffLineText = offLineText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7F3 RID: 124915 RVA: 0x009D6F88 File Offset: 0x009D5188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Member(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMemberInfoItemUIController.Member);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7F4 RID: 124916 RVA: 0x009D6FDC File Offset: 0x009D51DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Member(IntPtr l)
	{
		int result;
		try
		{
			GuildMemberInfoItemUIController guildMemberInfoItemUIController = (GuildMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildMember member;
			LuaObject.checkType<GuildMember>(l, 2, out member);
			guildMemberInfoItemUIController.m_luaExportHelper.Member = member;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E7F5 RID: 124917 RVA: 0x009D7038 File Offset: 0x009D5238
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMemberInfoItemUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.InitItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.SetTitleTextByEnum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache12);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache13, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache15, true);
		string name3 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_button);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache17, true);
		string name4 = "m_headIconStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_headIconStateCtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_headIconStateCtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache19, true);
		string name5 = "m_headIcon";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_headIcon);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_headIcon);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_headIconGrey";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_headIconGrey);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_headIconGrey);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_HeadFrameDummy";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_HeadFrameDummy);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_HeadFrameDummy);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache1F, true);
		string name8 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_levelText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache21, true);
		string name9 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_nameText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache23, true);
		string name10 = "m_positionText";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_positionText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_positionText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache25, true);
		string name11 = "m_powerText";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_powerText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_powerText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache27, true);
		string name12 = "m_exploitText";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_exploitText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_exploitText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache29, true);
		string name13 = "m_vitalityText";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_vitalityText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_vitalityText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2B, true);
		string name14 = "m_onlineStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_onlineStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_onlineStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2D, true);
		string name15 = "m_OffLineText";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_m_OffLineText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_m_OffLineText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache2F, true);
		string name16 = "Member";
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.get_Member);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.set_Member);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.<>f__mg$cache31, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildMemberInfoItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014883 RID: 84099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014884 RID: 84100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014885 RID: 84101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014886 RID: 84102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014887 RID: 84103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014888 RID: 84104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014889 RID: 84105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401488A RID: 84106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401488B RID: 84107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401488C RID: 84108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401488D RID: 84109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401488E RID: 84110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401488F RID: 84111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014890 RID: 84112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014891 RID: 84113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014892 RID: 84114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014893 RID: 84115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014894 RID: 84116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014895 RID: 84117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014896 RID: 84118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014897 RID: 84119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014898 RID: 84120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014899 RID: 84121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401489A RID: 84122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401489B RID: 84123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401489C RID: 84124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401489D RID: 84125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401489E RID: 84126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401489F RID: 84127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040148A0 RID: 84128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040148A1 RID: 84129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040148A2 RID: 84130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040148A3 RID: 84131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040148A4 RID: 84132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040148A5 RID: 84133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040148A6 RID: 84134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040148A7 RID: 84135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040148A8 RID: 84136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040148A9 RID: 84137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040148AA RID: 84138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040148AB RID: 84139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040148AC RID: 84140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040148AD RID: 84141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040148AE RID: 84142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040148AF RID: 84143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040148B0 RID: 84144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040148B1 RID: 84145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040148B2 RID: 84146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040148B3 RID: 84147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040148B4 RID: 84148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;
}
