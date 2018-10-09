using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001477 RID: 5239
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController : LuaObject
{
	// Token: 0x0601E470 RID: 124016 RVA: 0x009BBBB4 File Offset: 0x009B9DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			GuildJoinInvitation guildJoinInvitation;
			LuaObject.checkType<GuildJoinInvitation>(l, 2, out guildJoinInvitation);
			guildInviteItemUIController.Init(guildJoinInvitation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E471 RID: 124017 RVA: 0x009BBC0C File Offset: 0x009B9E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Refresh(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.Refresh();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E472 RID: 124018 RVA: 0x009BBC58 File Offset: 0x009B9E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E473 RID: 124019 RVA: 0x009BBCAC File Offset: 0x009B9EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAcceptClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.OnAcceptClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E474 RID: 124020 RVA: 0x009BBD00 File Offset: 0x009B9F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRefuseClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.OnRefuseClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E475 RID: 124021 RVA: 0x009BBD54 File Offset: 0x009B9F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDetailClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.OnDetailClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E476 RID: 124022 RVA: 0x009BBDA8 File Offset: 0x009B9FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildInviteItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E477 RID: 124023 RVA: 0x009BBE14 File Offset: 0x009BA014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E478 RID: 124024 RVA: 0x009BBE68 File Offset: 0x009BA068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E479 RID: 124025 RVA: 0x009BBEBC File Offset: 0x009BA0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildInviteItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E47A RID: 124026 RVA: 0x009BBF64 File Offset: 0x009BA164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E47B RID: 124027 RVA: 0x009BBFB8 File Offset: 0x009BA1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildInviteItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E47C RID: 124028 RVA: 0x009BC024 File Offset: 0x009BA224
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
				GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildInviteItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildInviteItemUIController guildInviteItemUIController2 = (GuildInviteItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildInviteItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E47D RID: 124029 RVA: 0x009BC134 File Offset: 0x009BA334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildInviteItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E47E RID: 124030 RVA: 0x009BC1A0 File Offset: 0x009BA3A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildInviteItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E47F RID: 124031 RVA: 0x009BC20C File Offset: 0x009BA40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildInviteItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E480 RID: 124032 RVA: 0x009BC278 File Offset: 0x009BA478
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildInviteItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E481 RID: 124033 RVA: 0x009BC2E4 File Offset: 0x009BA4E4
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
				GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildInviteItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildInviteItemUIController guildInviteItemUIController2 = (GuildInviteItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildInviteItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E482 RID: 124034 RVA: 0x009BC3F4 File Offset: 0x009BA5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			string s = guildInviteItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E483 RID: 124035 RVA: 0x009BC450 File Offset: 0x009BA650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_ItemRefreshEvent(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.__callDele_ItemRefreshEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E484 RID: 124036 RVA: 0x009BC4A4 File Offset: 0x009BA6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_ItemRefreshEvent(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			guildInviteItemUIController.m_luaExportHelper.__clearDele_ItemRefreshEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E485 RID: 124037 RVA: 0x009BC4F8 File Offset: 0x009BA6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charLevelText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_charLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E486 RID: 124038 RVA: 0x009BC550 File Offset: 0x009BA750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charLevelText(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Text charLevelText;
			LuaObject.checkType<Text>(l, 2, out charLevelText);
			guildInviteItemUIController.m_luaExportHelper.m_charLevelText = charLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E487 RID: 124039 RVA: 0x009BC5AC File Offset: 0x009BA7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_charIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E488 RID: 124040 RVA: 0x009BC604 File Offset: 0x009BA804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Image charIcon;
			LuaObject.checkType<Image>(l, 2, out charIcon);
			guildInviteItemUIController.m_luaExportHelper.m_charIcon = charIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E489 RID: 124041 RVA: 0x009BC660 File Offset: 0x009BA860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_headFrameDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E48A RID: 124042 RVA: 0x009BC6B8 File Offset: 0x009BA8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Transform headFrameDummy;
			LuaObject.checkType<Transform>(l, 2, out headFrameDummy);
			guildInviteItemUIController.m_luaExportHelper.m_headFrameDummy = headFrameDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E48B RID: 124043 RVA: 0x009BC714 File Offset: 0x009BA914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charName(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_charName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E48C RID: 124044 RVA: 0x009BC76C File Offset: 0x009BA96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charName(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Text charName;
			LuaObject.checkType<Text>(l, 2, out charName);
			guildInviteItemUIController.m_luaExportHelper.m_charName = charName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E48D RID: 124045 RVA: 0x009BC7C8 File Offset: 0x009BA9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteGuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_inviteGuildName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E48E RID: 124046 RVA: 0x009BC820 File Offset: 0x009BAA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteGuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Text inviteGuildName;
			LuaObject.checkType<Text>(l, 2, out inviteGuildName);
			guildInviteItemUIController.m_luaExportHelper.m_inviteGuildName = inviteGuildName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E48F RID: 124047 RVA: 0x009BC87C File Offset: 0x009BAA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detialButton(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_detialButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E490 RID: 124048 RVA: 0x009BC8D4 File Offset: 0x009BAAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detialButton(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Button detialButton;
			LuaObject.checkType<Button>(l, 2, out detialButton);
			guildInviteItemUIController.m_luaExportHelper.m_detialButton = detialButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E491 RID: 124049 RVA: 0x009BC930 File Offset: 0x009BAB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_acceptButton(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_acceptButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E492 RID: 124050 RVA: 0x009BC988 File Offset: 0x009BAB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_acceptButton(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Button acceptButton;
			LuaObject.checkType<Button>(l, 2, out acceptButton);
			guildInviteItemUIController.m_luaExportHelper.m_acceptButton = acceptButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E493 RID: 124051 RVA: 0x009BC9E4 File Offset: 0x009BABE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refuseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_refuseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E494 RID: 124052 RVA: 0x009BCA3C File Offset: 0x009BAC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refuseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Button refuseButton;
			LuaObject.checkType<Button>(l, 2, out refuseButton);
			guildInviteItemUIController.m_luaExportHelper.m_refuseButton = refuseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E495 RID: 124053 RVA: 0x009BCA98 File Offset: 0x009BAC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ItemRefreshEvent(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildInviteItemUIController.ItemRefreshEvent += value;
				}
				else if (num == 2)
				{
					guildInviteItemUIController.ItemRefreshEvent -= value;
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

	// Token: 0x0601E496 RID: 124054 RVA: 0x009BCB18 File Offset: 0x009BAD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E497 RID: 124055 RVA: 0x009BCB70 File Offset: 0x009BAD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			guildInviteItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E498 RID: 124056 RVA: 0x009BCBCC File Offset: 0x009BADCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E499 RID: 124057 RVA: 0x009BCC24 File Offset: 0x009BAE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			guildInviteItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E49A RID: 124058 RVA: 0x009BCC80 File Offset: 0x009BAE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJoinInvitation(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInviteItemUIController.m_luaExportHelper.m_guildJoinInvitation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E49B RID: 124059 RVA: 0x009BCCD8 File Offset: 0x009BAED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildJoinInvitation(IntPtr l)
	{
		int result;
		try
		{
			GuildInviteItemUIController guildInviteItemUIController = (GuildInviteItemUIController)LuaObject.checkSelf(l);
			GuildJoinInvitation guildJoinInvitation;
			LuaObject.checkType<GuildJoinInvitation>(l, 2, out guildJoinInvitation);
			guildInviteItemUIController.m_luaExportHelper.m_guildJoinInvitation = guildJoinInvitation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E49C RID: 124060 RVA: 0x009BCD34 File Offset: 0x009BAF34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildInviteItemUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.Refresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.OnAcceptClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.OnRefuseClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.OnDetailClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__callDele_ItemRefreshEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.__clearDele_ItemRefreshEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache14);
		string name = "m_charLevelText";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_charLevelText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_charLevelText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache16, true);
		string name2 = "m_charIcon";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_charIcon);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_charIcon);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache18, true);
		string name3 = "m_headFrameDummy";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_headFrameDummy);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_headFrameDummy);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_charName";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_charName);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_charName);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1C, true);
		string name5 = "m_inviteGuildName";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_inviteGuildName);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_inviteGuildName);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1E, true);
		string name6 = "m_detialButton";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_detialButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_detialButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache20, true);
		string name7 = "m_acceptButton";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_acceptButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_acceptButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache22, true);
		string name8 = "m_refuseButton";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_refuseButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_refuseButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache24, true);
		string name9 = "ItemRefreshEvent";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_ItemRefreshEvent);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache25, true);
		string name10 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_playerContext);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache27, true);
		string name11 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache29, true);
		string name12 = "m_guildJoinInvitation";
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.get_m_guildJoinInvitation);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.set_m_guildJoinInvitation);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.<>f__mg$cache2B, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildInviteItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014564 RID: 83300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014565 RID: 83301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014566 RID: 83302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014567 RID: 83303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014568 RID: 83304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014569 RID: 83305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401456A RID: 83306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401456B RID: 83307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401456C RID: 83308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401456D RID: 83309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401456E RID: 83310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401456F RID: 83311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014570 RID: 83312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014571 RID: 83313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014572 RID: 83314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014573 RID: 83315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014574 RID: 83316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014575 RID: 83317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014576 RID: 83318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014577 RID: 83319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014578 RID: 83320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014579 RID: 83321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401457A RID: 83322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401457B RID: 83323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401457C RID: 83324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401457D RID: 83325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401457E RID: 83326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401457F RID: 83327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014580 RID: 83328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014581 RID: 83329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014582 RID: 83330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014583 RID: 83331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014584 RID: 83332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014585 RID: 83333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014586 RID: 83334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014587 RID: 83335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014588 RID: 83336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014589 RID: 83337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401458A RID: 83338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401458B RID: 83339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401458C RID: 83340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401458D RID: 83341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401458E RID: 83342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401458F RID: 83343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
