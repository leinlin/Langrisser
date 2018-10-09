using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001496 RID: 5270
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController : LuaObject
{
	// Token: 0x0601E803 RID: 124931 RVA: 0x009D79F4 File Offset: 0x009D5BF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitGuildRaidListItemInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatDifficultyInfo info;
			LuaObject.checkType<ConfigDataGuildMassiveCombatDifficultyInfo>(l, 2, out info);
			guildRaidListItemUIController.InitGuildRaidListItemInfo(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E804 RID: 124932 RVA: 0x009D7A4C File Offset: 0x009D5C4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			guildRaidListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E805 RID: 124933 RVA: 0x009D7AA0 File Offset: 0x009D5CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			guildRaidListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E806 RID: 124934 RVA: 0x009D7AF4 File Offset: 0x009D5CF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E807 RID: 124935 RVA: 0x009D7B60 File Offset: 0x009D5D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E808 RID: 124936 RVA: 0x009D7BB4 File Offset: 0x009D5DB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E809 RID: 124937 RVA: 0x009D7C08 File Offset: 0x009D5E08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildRaidListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E80A RID: 124938 RVA: 0x009D7CB0 File Offset: 0x009D5EB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E80B RID: 124939 RVA: 0x009D7D04 File Offset: 0x009D5F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E80C RID: 124940 RVA: 0x009D7D70 File Offset: 0x009D5F70
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
				GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildRaidListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildRaidListItemUIController guildRaidListItemUIController2 = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildRaidListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E80D RID: 124941 RVA: 0x009D7E80 File Offset: 0x009D6080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E80E RID: 124942 RVA: 0x009D7EEC File Offset: 0x009D60EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E80F RID: 124943 RVA: 0x009D7F58 File Offset: 0x009D6158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E810 RID: 124944 RVA: 0x009D7FC4 File Offset: 0x009D61C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildRaidListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E811 RID: 124945 RVA: 0x009D8030 File Offset: 0x009D6230
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
				GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildRaidListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildRaidListItemUIController guildRaidListItemUIController2 = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildRaidListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E812 RID: 124946 RVA: 0x009D8140 File Offset: 0x009D6340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			string s = guildRaidListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E813 RID: 124947 RVA: 0x009D819C File Offset: 0x009D639C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			GuildRaidListItemUIController obj;
			LuaObject.checkType<GuildRaidListItemUIController>(l, 2, out obj);
			guildRaidListItemUIController.m_luaExportHelper.__callDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E814 RID: 124948 RVA: 0x009D81F8 File Offset: 0x009D63F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			GuildRaidListItemUIController obj;
			LuaObject.checkType<GuildRaidListItemUIController>(l, 2, out obj);
			guildRaidListItemUIController.m_luaExportHelper.__clearDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E815 RID: 124949 RVA: 0x009D8254 File Offset: 0x009D6454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			Action<GuildRaidListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<GuildRaidListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildRaidListItemUIController.EventOnStartButtonClick += value;
				}
				else if (num == 2)
				{
					guildRaidListItemUIController.EventOnStartButtonClick -= value;
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

	// Token: 0x0601E816 RID: 124950 RVA: 0x009D82D4 File Offset: 0x009D64D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidListItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E817 RID: 124951 RVA: 0x009D832C File Offset: 0x009D652C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			guildRaidListItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E818 RID: 124952 RVA: 0x009D8388 File Offset: 0x009D6588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidListItemUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E819 RID: 124953 RVA: 0x009D83E0 File Offset: 0x009D65E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			guildRaidListItemUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E81A RID: 124954 RVA: 0x009D843C File Offset: 0x009D663C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E81B RID: 124955 RVA: 0x009D8494 File Offset: 0x009D6694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			guildRaidListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E81C RID: 124956 RVA: 0x009D84F0 File Offset: 0x009D66F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidListItemUIController.m_luaExportHelper.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E81D RID: 124957 RVA: 0x009D8548 File Offset: 0x009D6748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			guildRaidListItemUIController.m_luaExportHelper.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E81E RID: 124958 RVA: 0x009D85A4 File Offset: 0x009D67A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_difficultTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidListItemUIController.m_luaExportHelper.m_difficultTextStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E81F RID: 124959 RVA: 0x009D85FC File Offset: 0x009D67FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_difficultTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController difficultTextStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out difficultTextStateCtrl);
			guildRaidListItemUIController.m_luaExportHelper.m_difficultTextStateCtrl = difficultTextStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E820 RID: 124960 RVA: 0x009D8658 File Offset: 0x009D6858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_conditionDescText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidListItemUIController.m_luaExportHelper.m_conditionDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E821 RID: 124961 RVA: 0x009D86B0 File Offset: 0x009D68B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_conditionDescText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			Text conditionDescText;
			LuaObject.checkType<Text>(l, 2, out conditionDescText);
			guildRaidListItemUIController.m_luaExportHelper.m_conditionDescText = conditionDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E822 RID: 124962 RVA: 0x009D870C File Offset: 0x009D690C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidListItemUIController.m_luaExportHelper.m_lockedText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E823 RID: 124963 RVA: 0x009D8764 File Offset: 0x009D6964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			Text lockedText;
			LuaObject.checkType<Text>(l, 2, out lockedText);
			guildRaidListItemUIController.m_luaExportHelper.m_lockedText = lockedText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E824 RID: 124964 RVA: 0x009D87C0 File Offset: 0x009D69C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildMassiveCombatDifficultyInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRaidListItemUIController.GuildMassiveCombatDifficultyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E825 RID: 124965 RVA: 0x009D8814 File Offset: 0x009D6A14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GuildMassiveCombatDifficultyInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildRaidListItemUIController guildRaidListItemUIController = (GuildRaidListItemUIController)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatDifficultyInfo guildMassiveCombatDifficultyInfo;
			LuaObject.checkType<ConfigDataGuildMassiveCombatDifficultyInfo>(l, 2, out guildMassiveCombatDifficultyInfo);
			guildRaidListItemUIController.GuildMassiveCombatDifficultyInfo = guildMassiveCombatDifficultyInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E826 RID: 124966 RVA: 0x009D886C File Offset: 0x009D6A6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildRaidListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.InitGuildRaidListItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__callDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.__clearDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache11);
		string name = "EventOnStartButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache12, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache14, true);
		string name3 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.get_m_startButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache16, true);
		string name4 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.get_m_levelText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache18, true);
		string name5 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.get_m_countText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_m_countText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1A, true);
		string name6 = "m_difficultTextStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.get_m_difficultTextStateCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_m_difficultTextStateCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1C, true);
		string name7 = "m_conditionDescText";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.get_m_conditionDescText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_m_conditionDescText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1E, true);
		string name8 = "m_lockedText";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.get_m_lockedText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_m_lockedText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache20, true);
		string name9 = "GuildMassiveCombatDifficultyInfo";
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.get_GuildMassiveCombatDifficultyInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.set_GuildMassiveCombatDifficultyInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.<>f__mg$cache22, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildRaidListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040148B9 RID: 84153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040148BA RID: 84154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040148BB RID: 84155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040148BC RID: 84156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040148BD RID: 84157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040148BE RID: 84158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040148BF RID: 84159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040148C0 RID: 84160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040148C1 RID: 84161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040148C2 RID: 84162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040148C3 RID: 84163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040148C4 RID: 84164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040148C5 RID: 84165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040148C6 RID: 84166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040148C7 RID: 84167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040148C8 RID: 84168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040148C9 RID: 84169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040148CA RID: 84170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040148CB RID: 84171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040148CC RID: 84172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040148CD RID: 84173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040148CE RID: 84174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040148CF RID: 84175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040148D0 RID: 84176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040148D1 RID: 84177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040148D2 RID: 84178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040148D3 RID: 84179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040148D4 RID: 84180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040148D5 RID: 84181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040148D6 RID: 84182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040148D7 RID: 84183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040148D8 RID: 84184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040148D9 RID: 84185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040148DA RID: 84186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040148DB RID: 84187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
