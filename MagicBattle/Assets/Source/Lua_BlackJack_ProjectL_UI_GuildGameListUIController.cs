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

// Token: 0x02001472 RID: 5234
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildGameListUIController : LuaObject
{
	// Token: 0x0601E40D RID: 123917 RVA: 0x009B8D08 File Offset: 0x009B6F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildGameListUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.GuildGameListUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E40E RID: 123918 RVA: 0x009B8D54 File Offset: 0x009B6F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E40F RID: 123919 RVA: 0x009B8DA0 File Offset: 0x009B6FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E410 RID: 123920 RVA: 0x009B8DEC File Offset: 0x009B6FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E411 RID: 123921 RVA: 0x009B8E40 File Offset: 0x009B7040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGuildPlayListPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.SetGuildPlayListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E412 RID: 123922 RVA: 0x009B8E94 File Offset: 0x009B7094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildPlayListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			GuildGameListItemUIController ctrl;
			LuaObject.checkType<GuildGameListItemUIController>(l, 2, out ctrl);
			guildGameListUIController.m_luaExportHelper.OnGuildPlayListItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E413 RID: 123923 RVA: 0x009B8EF0 File Offset: 0x009B70F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E414 RID: 123924 RVA: 0x009B8F44 File Offset: 0x009B7144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildGameListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E415 RID: 123925 RVA: 0x009B8FB0 File Offset: 0x009B71B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E416 RID: 123926 RVA: 0x009B9004 File Offset: 0x009B7204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E417 RID: 123927 RVA: 0x009B9058 File Offset: 0x009B7258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildGameListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E418 RID: 123928 RVA: 0x009B9100 File Offset: 0x009B7300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E419 RID: 123929 RVA: 0x009B9154 File Offset: 0x009B7354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildGameListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E41A RID: 123930 RVA: 0x009B91C0 File Offset: 0x009B73C0
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
				GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildGameListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildGameListUIController guildGameListUIController2 = (GuildGameListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildGameListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E41B RID: 123931 RVA: 0x009B92D0 File Offset: 0x009B74D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildGameListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E41C RID: 123932 RVA: 0x009B933C File Offset: 0x009B753C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildGameListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E41D RID: 123933 RVA: 0x009B93A8 File Offset: 0x009B75A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildGameListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E41E RID: 123934 RVA: 0x009B9414 File Offset: 0x009B7614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildGameListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E41F RID: 123935 RVA: 0x009B9480 File Offset: 0x009B7680
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
				GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildGameListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildGameListUIController guildGameListUIController2 = (GuildGameListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildGameListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E420 RID: 123936 RVA: 0x009B9590 File Offset: 0x009B7790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			string s = guildGameListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E421 RID: 123937 RVA: 0x009B95EC File Offset: 0x009B77EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E422 RID: 123938 RVA: 0x009B9640 File Offset: 0x009B7840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E423 RID: 123939 RVA: 0x009B9694 File Offset: 0x009B7894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGuildPlayListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.__callDele_EventOnGuildPlayListItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E424 RID: 123940 RVA: 0x009B96E8 File Offset: 0x009B78E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGuildPlayListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			guildGameListUIController.m_luaExportHelper.__clearDele_EventOnGuildPlayListItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E425 RID: 123941 RVA: 0x009B973C File Offset: 0x009B793C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildRaidListPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUIController.m_luaExportHelper.m_guildRaidListPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E426 RID: 123942 RVA: 0x009B9794 File Offset: 0x009B7994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildRaidListPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildRaidListPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildRaidListPanelStateCtrl);
			guildGameListUIController.m_luaExportHelper.m_guildRaidListPanelStateCtrl = guildRaidListPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E427 RID: 123943 RVA: 0x009B97F0 File Offset: 0x009B79F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildRaidListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUIController.m_luaExportHelper.m_guildRaidListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E428 RID: 123944 RVA: 0x009B9848 File Offset: 0x009B7A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildRaidListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			ScrollRect guildRaidListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out guildRaidListScrollRect);
			guildGameListUIController.m_luaExportHelper.m_guildRaidListScrollRect = guildRaidListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E429 RID: 123945 RVA: 0x009B98A4 File Offset: 0x009B7AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildRaidListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUIController.m_luaExportHelper.m_guildRaidListScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E42A RID: 123946 RVA: 0x009B98FC File Offset: 0x009B7AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildRaidListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			GameObject guildRaidListScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out guildRaidListScrollViewContent);
			guildGameListUIController.m_luaExportHelper.m_guildRaidListScrollViewContent = guildRaidListScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E42B RID: 123947 RVA: 0x009B9958 File Offset: 0x009B7B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E42C RID: 123948 RVA: 0x009B99B0 File Offset: 0x009B7BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			guildGameListUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E42D RID: 123949 RVA: 0x009B9A0C File Offset: 0x009B7C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildRaidListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUIController.m_luaExportHelper.m_guildRaidListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E42E RID: 123950 RVA: 0x009B9A64 File Offset: 0x009B7C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildRaidListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			GameObject guildRaidListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out guildRaidListItemPrefab);
			guildGameListUIController.m_luaExportHelper.m_guildRaidListItemPrefab = guildRaidListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E42F RID: 123951 RVA: 0x009B9AC0 File Offset: 0x009B7CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildGameListUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					guildGameListUIController.EventOnReturn -= value;
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

	// Token: 0x0601E430 RID: 123952 RVA: 0x009B9B40 File Offset: 0x009B7D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGuildPlayListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildGameListUIController.EventOnGuildPlayListItemClick += value;
				}
				else if (num == 2)
				{
					guildGameListUIController.EventOnGuildPlayListItemClick -= value;
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

	// Token: 0x0601E431 RID: 123953 RVA: 0x009B9BC0 File Offset: 0x009B7DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E432 RID: 123954 RVA: 0x009B9C18 File Offset: 0x009B7E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			guildGameListUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E433 RID: 123955 RVA: 0x009B9C74 File Offset: 0x009B7E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGameListUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E434 RID: 123956 RVA: 0x009B9CCC File Offset: 0x009B7ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildGameListUIController guildGameListUIController = (GuildGameListUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			guildGameListUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E435 RID: 123957 RVA: 0x009B9D28 File Offset: 0x009B7F28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildGameListUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.GuildGameListUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.SetGuildPlayListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.OnGuildPlayListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__callDele_EventOnGuildPlayListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.__clearDele_EventOnGuildPlayListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache17);
		string name = "m_guildRaidListPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.get_m_guildRaidListPanelStateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_m_guildRaidListPanelStateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache19, true);
		string name2 = "m_guildRaidListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.get_m_guildRaidListScrollRect);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_m_guildRaidListScrollRect);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1B, true);
		string name3 = "m_guildRaidListScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.get_m_guildRaidListScrollViewContent);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_m_guildRaidListScrollViewContent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1D, true);
		string name4 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.get_m_returnButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache1F, true);
		string name5 = "m_guildRaidListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.get_m_guildRaidListItemPrefab);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_m_guildRaidListItemPrefab);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache21, true);
		string name6 = "EventOnReturn";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache22, true);
		string name7 = "EventOnGuildPlayListItemClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_EventOnGuildPlayListItemClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache23, true);
		string name8 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.get_m_playerContext);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache25, true);
		string name9 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.get_m_configDataLoader);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildGameListUIController.<>f__mg$cache27, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildGameListUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401450B RID: 83211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401450C RID: 83212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401450D RID: 83213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401450E RID: 83214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401450F RID: 83215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014510 RID: 83216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014511 RID: 83217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014512 RID: 83218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014513 RID: 83219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014514 RID: 83220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014515 RID: 83221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014516 RID: 83222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014517 RID: 83223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014518 RID: 83224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014519 RID: 83225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401451A RID: 83226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401451B RID: 83227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401451C RID: 83228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401451D RID: 83229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401451E RID: 83230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401451F RID: 83231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014520 RID: 83232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014521 RID: 83233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014522 RID: 83234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014523 RID: 83235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014524 RID: 83236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014525 RID: 83237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014526 RID: 83238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014527 RID: 83239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014528 RID: 83240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014529 RID: 83241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401452A RID: 83242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401452B RID: 83243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401452C RID: 83244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401452D RID: 83245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401452E RID: 83246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401452F RID: 83247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014530 RID: 83248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014531 RID: 83249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014532 RID: 83250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
