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

// Token: 0x02001478 RID: 5240
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController : LuaObject
{
	// Token: 0x0601E49E RID: 124062 RVA: 0x009BD37C File Offset: 0x009BB57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			UserSummary player;
			LuaObject.checkType<UserSummary>(l, 2, out player);
			bool isInvited;
			LuaObject.checkType(l, 3, out isInvited);
			guildInviteMemberInfoItemUIController.InitPlayerInfo(player, isInvited);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E49F RID: 124063 RVA: 0x009BD3E0 File Offset: 0x009BB5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4A0 RID: 124064 RVA: 0x009BD434 File Offset: 0x009BB634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.OnAddClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4A1 RID: 124065 RVA: 0x009BD488 File Offset: 0x009BB688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4A2 RID: 124066 RVA: 0x009BD4F4 File Offset: 0x009BB6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4A3 RID: 124067 RVA: 0x009BD548 File Offset: 0x009BB748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4A4 RID: 124068 RVA: 0x009BD59C File Offset: 0x009BB79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E4A5 RID: 124069 RVA: 0x009BD644 File Offset: 0x009BB844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4A6 RID: 124070 RVA: 0x009BD698 File Offset: 0x009BB898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4A7 RID: 124071 RVA: 0x009BD704 File Offset: 0x009BB904
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
				GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController2 = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildInviteMemberInfoItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E4A8 RID: 124072 RVA: 0x009BD814 File Offset: 0x009BBA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4A9 RID: 124073 RVA: 0x009BD880 File Offset: 0x009BBA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4AA RID: 124074 RVA: 0x009BD8EC File Offset: 0x009BBAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4AB RID: 124075 RVA: 0x009BD958 File Offset: 0x009BBB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4AC RID: 124076 RVA: 0x009BD9C4 File Offset: 0x009BBBC4
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
				GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController2 = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildInviteMemberInfoItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E4AD RID: 124077 RVA: 0x009BDAD4 File Offset: 0x009BBCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			string s = guildInviteMemberInfoItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E4AE RID: 124078 RVA: 0x009BDB30 File Offset: 0x009BBD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildInviteMemberInfoItemUIController obj;
			LuaObject.checkType<GuildInviteMemberInfoItemUIController>(l, 2, out obj);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4AF RID: 124079 RVA: 0x009BDB8C File Offset: 0x009BBD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildInviteMemberInfoItemUIController obj;
			LuaObject.checkType<GuildInviteMemberInfoItemUIController>(l, 2, out obj);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B0 RID: 124080 RVA: 0x009BDBE8 File Offset: 0x009BBDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Action<GuildInviteMemberInfoItemUIController> value;
			int num = LuaObject.checkDelegate<Action<GuildInviteMemberInfoItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildInviteMemberInfoItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					guildInviteMemberInfoItemUIController.EventOnClick -= value;
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

	// Token: 0x0601E4B1 RID: 124081 RVA: 0x009BDC68 File Offset: 0x009BBE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_headIconStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B2 RID: 124082 RVA: 0x009BDCC0 File Offset: 0x009BBEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController headIconStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out headIconStateCtrl);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_headIconStateCtrl = headIconStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B3 RID: 124083 RVA: 0x009BDD1C File Offset: 0x009BBF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIconGrey(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_headIconGrey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B4 RID: 124084 RVA: 0x009BDD74 File Offset: 0x009BBF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headIconGrey(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Image headIconGrey;
			LuaObject.checkType<Image>(l, 2, out headIconGrey);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_headIconGrey = headIconGrey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B5 RID: 124085 RVA: 0x009BDDD0 File Offset: 0x009BBFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_headIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B6 RID: 124086 RVA: 0x009BDE28 File Offset: 0x009BC028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Image headIcon;
			LuaObject.checkType<Image>(l, 2, out headIcon);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_headIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B7 RID: 124087 RVA: 0x009BDE84 File Offset: 0x009BC084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_HeadFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_HeadFrameDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B8 RID: 124088 RVA: 0x009BDEDC File Offset: 0x009BC0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_HeadFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Transform headFrameDummy;
			LuaObject.checkType<Transform>(l, 2, out headFrameDummy);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_HeadFrameDummy = headFrameDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4B9 RID: 124089 RVA: 0x009BDF38 File Offset: 0x009BC138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4BA RID: 124090 RVA: 0x009BDF90 File Offset: 0x009BC190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4BB RID: 124091 RVA: 0x009BDFEC File Offset: 0x009BC1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4BC RID: 124092 RVA: 0x009BE044 File Offset: 0x009BC244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4BD RID: 124093 RVA: 0x009BE0A0 File Offset: 0x009BC2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_powerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4BE RID: 124094 RVA: 0x009BE0F8 File Offset: 0x009BC2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text powerText;
			LuaObject.checkType<Text>(l, 2, out powerText);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_powerText = powerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4BF RID: 124095 RVA: 0x009BE154 File Offset: 0x009BC354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addButton(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_addButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C0 RID: 124096 RVA: 0x009BE1AC File Offset: 0x009BC3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addButton(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Button addButton;
			LuaObject.checkType<Button>(l, 2, out addButton);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_addButton = addButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C1 RID: 124097 RVA: 0x009BE208 File Offset: 0x009BC408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_addButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C2 RID: 124098 RVA: 0x009BE260 File Offset: 0x009BC460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController addButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out addButtonStateCtrl);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_addButtonStateCtrl = addButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C3 RID: 124099 RVA: 0x009BE2BC File Offset: 0x009BC4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_onlineStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C4 RID: 124100 RVA: 0x009BE314 File Offset: 0x009BC514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController onlineStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out onlineStateCtrl);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_onlineStateCtrl = onlineStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C5 RID: 124101 RVA: 0x009BE370 File Offset: 0x009BC570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_OffLineText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_OffLineText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C6 RID: 124102 RVA: 0x009BE3C8 File Offset: 0x009BC5C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_OffLineText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text offLineText;
			LuaObject.checkType<Text>(l, 2, out offLineText);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_OffLineText = offLineText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C7 RID: 124103 RVA: 0x009BE424 File Offset: 0x009BC624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAdd(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.m_luaExportHelper.m_isAdd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C8 RID: 124104 RVA: 0x009BE47C File Offset: 0x009BC67C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isAdd(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			bool isAdd;
			LuaObject.checkType(l, 2, out isAdd);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.m_isAdd = isAdd;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4C9 RID: 124105 RVA: 0x009BE4D8 File Offset: 0x009BC6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InvitePlayer(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteMemberInfoItemUIController.InvitePlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4CA RID: 124106 RVA: 0x009BE52C File Offset: 0x009BC72C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_InvitePlayer(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController = (GuildInviteMemberInfoItemUIController)LuaObject.checkSelf(l);
			UserSummary invitePlayer;
			LuaObject.checkType<UserSummary>(l, 2, out invitePlayer);
			guildInviteMemberInfoItemUIController.m_luaExportHelper.InvitePlayer = invitePlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4CB RID: 124107 RVA: 0x009BE588 File Offset: 0x009BC788
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildInviteMemberInfoItemUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.InitPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.OnAddClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache11);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache12, true);
		string name2 = "m_headIconStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_headIconStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_headIconStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache14, true);
		string name3 = "m_headIconGrey";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_headIconGrey);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_headIconGrey);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache16, true);
		string name4 = "m_headIcon";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_headIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_headIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache18, true);
		string name5 = "m_HeadFrameDummy";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_HeadFrameDummy);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_HeadFrameDummy);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1A, true);
		string name6 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_levelText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1C, true);
		string name7 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_nameText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1E, true);
		string name8 = "m_powerText";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_powerText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_powerText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache20, true);
		string name9 = "m_addButton";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_addButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_addButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache22, true);
		string name10 = "m_addButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_addButtonStateCtrl);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_addButtonStateCtrl);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache24, true);
		string name11 = "m_onlineStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_onlineStateCtrl);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_onlineStateCtrl);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache26, true);
		string name12 = "m_OffLineText";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_OffLineText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_OffLineText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache28, true);
		string name13 = "m_isAdd";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_m_isAdd);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_m_isAdd);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2A, true);
		string name14 = "InvitePlayer";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.get_InvitePlayer);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.set_InvitePlayer);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.<>f__mg$cache2C, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildInviteMemberInfoItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014590 RID: 83344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014591 RID: 83345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014592 RID: 83346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014593 RID: 83347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014594 RID: 83348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014595 RID: 83349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014596 RID: 83350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014597 RID: 83351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014598 RID: 83352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014599 RID: 83353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401459A RID: 83354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401459B RID: 83355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401459C RID: 83356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401459D RID: 83357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401459E RID: 83358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401459F RID: 83359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040145A0 RID: 83360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040145A1 RID: 83361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040145A2 RID: 83362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040145A3 RID: 83363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040145A4 RID: 83364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040145A5 RID: 83365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040145A6 RID: 83366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040145A7 RID: 83367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040145A8 RID: 83368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040145A9 RID: 83369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040145AA RID: 83370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040145AB RID: 83371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040145AC RID: 83372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040145AD RID: 83373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040145AE RID: 83374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040145AF RID: 83375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040145B0 RID: 83376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040145B1 RID: 83377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040145B2 RID: 83378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040145B3 RID: 83379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040145B4 RID: 83380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040145B5 RID: 83381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040145B6 RID: 83382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040145B7 RID: 83383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040145B8 RID: 83384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040145B9 RID: 83385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040145BA RID: 83386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040145BB RID: 83387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040145BC RID: 83388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
