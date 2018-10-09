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

// Token: 0x02001497 RID: 5271
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildRaidUIController : LuaObject
{
	// Token: 0x0601E828 RID: 124968 RVA: 0x009D8D78 File Offset: 0x009D6F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildRaidUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.GuildRaidUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E829 RID: 124969 RVA: 0x009D8DC4 File Offset: 0x009D6FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E82A RID: 124970 RVA: 0x009D8E10 File Offset: 0x009D7010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E82B RID: 124971 RVA: 0x009D8E5C File Offset: 0x009D705C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E82C RID: 124972 RVA: 0x009D8EB0 File Offset: 0x009D70B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildRaidListItemStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			GuildRaidListItemUIController ctrl;
			LuaObject.checkType<GuildRaidListItemUIController>(l, 2, out ctrl);
			guildRaidUIController.m_luaExportHelper.OnGuildRaidListItemStartButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E82D RID: 124973 RVA: 0x009D8F0C File Offset: 0x009D710C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E82E RID: 124974 RVA: 0x009D8F60 File Offset: 0x009D7160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildRaidUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E82F RID: 124975 RVA: 0x009D8FCC File Offset: 0x009D71CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E830 RID: 124976 RVA: 0x009D9020 File Offset: 0x009D7220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E831 RID: 124977 RVA: 0x009D9074 File Offset: 0x009D7274
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildRaidUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E832 RID: 124978 RVA: 0x009D911C File Offset: 0x009D731C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E833 RID: 124979 RVA: 0x009D9170 File Offset: 0x009D7370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildRaidUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E834 RID: 124980 RVA: 0x009D91DC File Offset: 0x009D73DC
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
				GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildRaidUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildRaidUIController guildRaidUIController2 = (GuildRaidUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildRaidUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E835 RID: 124981 RVA: 0x009D92EC File Offset: 0x009D74EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildRaidUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E836 RID: 124982 RVA: 0x009D9358 File Offset: 0x009D7558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildRaidUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E837 RID: 124983 RVA: 0x009D93C4 File Offset: 0x009D75C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildRaidUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E838 RID: 124984 RVA: 0x009D9430 File Offset: 0x009D7630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildRaidUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E839 RID: 124985 RVA: 0x009D949C File Offset: 0x009D769C
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
				GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildRaidUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildRaidUIController guildRaidUIController2 = (GuildRaidUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildRaidUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E83A RID: 124986 RVA: 0x009D95AC File Offset: 0x009D77AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			string s = guildRaidUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E83B RID: 124987 RVA: 0x009D9608 File Offset: 0x009D7808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E83C RID: 124988 RVA: 0x009D965C File Offset: 0x009D785C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			guildRaidUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E83D RID: 124989 RVA: 0x009D96B0 File Offset: 0x009D78B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGuildRaidListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatDifficultyInfo obj;
			LuaObject.checkType<ConfigDataGuildMassiveCombatDifficultyInfo>(l, 2, out obj);
			guildRaidUIController.m_luaExportHelper.__callDele_EventOnGuildRaidListItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E83E RID: 124990 RVA: 0x009D970C File Offset: 0x009D790C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnGuildRaidListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatDifficultyInfo obj;
			LuaObject.checkType<ConfigDataGuildMassiveCombatDifficultyInfo>(l, 2, out obj);
			guildRaidUIController.m_luaExportHelper.__clearDele_EventOnGuildRaidListItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E83F RID: 124991 RVA: 0x009D9768 File Offset: 0x009D7968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E840 RID: 124992 RVA: 0x009D97C0 File Offset: 0x009D79C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			guildRaidUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E841 RID: 124993 RVA: 0x009D981C File Offset: 0x009D7A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E842 RID: 124994 RVA: 0x009D9874 File Offset: 0x009D7A74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			guildRaidUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E843 RID: 124995 RVA: 0x009D98D0 File Offset: 0x009D7AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timesText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUIController.m_luaExportHelper.m_timesText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E844 RID: 124996 RVA: 0x009D9928 File Offset: 0x009D7B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timesText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			Text timesText;
			LuaObject.checkType<Text>(l, 2, out timesText);
			guildRaidUIController.m_luaExportHelper.m_timesText = timesText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E845 RID: 124997 RVA: 0x009D9984 File Offset: 0x009D7B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUIController.m_luaExportHelper.m_scrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E846 RID: 124998 RVA: 0x009D99DC File Offset: 0x009D7BDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollRect);
			guildRaidUIController.m_luaExportHelper.m_scrollRect = scrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E847 RID: 124999 RVA: 0x009D9A38 File Offset: 0x009D7C38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_scrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUIController.m_luaExportHelper.m_scrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E848 RID: 125000 RVA: 0x009D9A90 File Offset: 0x009D7C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			GameObject scrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewContent);
			guildRaidUIController.m_luaExportHelper.m_scrollViewContent = scrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E849 RID: 125001 RVA: 0x009D9AEC File Offset: 0x009D7CEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUIController.m_luaExportHelper.m_levelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E84A RID: 125002 RVA: 0x009D9B44 File Offset: 0x009D7D44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			GameObject levelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out levelListItemPrefab);
			guildRaidUIController.m_luaExportHelper.m_levelListItemPrefab = levelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E84B RID: 125003 RVA: 0x009D9BA0 File Offset: 0x009D7DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildRaidUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					guildRaidUIController.EventOnReturn -= value;
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

	// Token: 0x0601E84C RID: 125004 RVA: 0x009D9C20 File Offset: 0x009D7E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGuildRaidListItemClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			Action<ConfigDataGuildMassiveCombatDifficultyInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataGuildMassiveCombatDifficultyInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildRaidUIController.EventOnGuildRaidListItemClick += value;
				}
				else if (num == 2)
				{
					guildRaidUIController.EventOnGuildRaidListItemClick -= value;
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

	// Token: 0x0601E84D RID: 125005 RVA: 0x009D9CA0 File Offset: 0x009D7EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E84E RID: 125006 RVA: 0x009D9CF8 File Offset: 0x009D7EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			guildRaidUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E84F RID: 125007 RVA: 0x009D9D54 File Offset: 0x009D7F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E850 RID: 125008 RVA: 0x009D9DAC File Offset: 0x009D7FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidUIController guildRaidUIController = (GuildRaidUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			guildRaidUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E851 RID: 125009 RVA: 0x009D9E08 File Offset: 0x009D8008
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildRaidUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.GuildRaidUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.OnGuildRaidListItemStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__callDele_EventOnGuildRaidListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.__clearDele_EventOnGuildRaidListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache16);
		string name = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.get_m_stateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache18, true);
		string name2 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.get_m_returnButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1A, true);
		string name3 = "m_timesText";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.get_m_timesText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_m_timesText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1C, true);
		string name4 = "m_scrollRect";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.get_m_scrollRect);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_m_scrollRect);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1E, true);
		string name5 = "m_scrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.get_m_scrollViewContent);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_m_scrollViewContent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache20, true);
		string name6 = "m_levelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.get_m_levelListItemPrefab);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_m_levelListItemPrefab);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache22, true);
		string name7 = "EventOnReturn";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache23, true);
		string name8 = "EventOnGuildRaidListItemClick";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_EventOnGuildRaidListItemClick);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache24, true);
		string name9 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.get_m_playerContext);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache26, true);
		string name10 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.get_m_configDataLoader);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GuildRaidUIController.<>f__mg$cache28, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildRaidUIController), typeof(UIControllerBase));
	}

	// Token: 0x040148DC RID: 84188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040148DD RID: 84189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040148DE RID: 84190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040148DF RID: 84191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040148E0 RID: 84192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040148E1 RID: 84193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040148E2 RID: 84194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040148E3 RID: 84195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040148E4 RID: 84196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040148E5 RID: 84197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040148E6 RID: 84198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040148E7 RID: 84199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040148E8 RID: 84200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040148E9 RID: 84201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040148EA RID: 84202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040148EB RID: 84203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040148EC RID: 84204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040148ED RID: 84205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040148EE RID: 84206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040148EF RID: 84207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040148F0 RID: 84208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040148F1 RID: 84209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040148F2 RID: 84210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040148F3 RID: 84211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040148F4 RID: 84212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040148F5 RID: 84213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040148F6 RID: 84214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040148F7 RID: 84215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040148F8 RID: 84216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040148F9 RID: 84217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040148FA RID: 84218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040148FB RID: 84219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040148FC RID: 84220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040148FD RID: 84221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040148FE RID: 84222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040148FF RID: 84223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014900 RID: 84224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014901 RID: 84225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014902 RID: 84226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014903 RID: 84227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014904 RID: 84228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
