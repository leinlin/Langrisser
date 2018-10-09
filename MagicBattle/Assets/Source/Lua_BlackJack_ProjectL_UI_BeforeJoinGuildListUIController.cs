using System;
using System.Collections.Generic;
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

// Token: 0x020013CB RID: 5067
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController : LuaObject
{
	// Token: 0x0601C4F1 RID: 115953 RVA: 0x008C114C File Offset: 0x008BF34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			BeforeJoinGuildUIController guildUIController;
			LuaObject.checkType<BeforeJoinGuildUIController>(l, 2, out guildUIController);
			beforeJoinGuildListUIController.Init(guildUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4F2 RID: 115954 RVA: 0x008C11A4 File Offset: 0x008BF3A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RefreshGuildList(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
				List<GuildSearchInfo> guildSearchInfoList;
				LuaObject.checkType<List<GuildSearchInfo>>(l, 2, out guildSearchInfoList);
				beforeJoinGuildListUIController.RefreshGuildList(guildSearchInfoList);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				BeforeJoinGuildListUIController beforeJoinGuildListUIController2 = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
				beforeJoinGuildListUIController2.RefreshGuildList();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RefreshGuildList to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4F3 RID: 115955 RVA: 0x008C1250 File Offset: 0x008BF450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			beforeJoinGuildListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4F4 RID: 115956 RVA: 0x008C12A4 File Offset: 0x008BF4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomGuildList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			Action<int> onReqFinish;
			LuaObject.checkDelegate<Action<int>>(l, 2, out onReqFinish);
			beforeJoinGuildListUIController.m_luaExportHelper.GetRandomGuildList(onReqFinish);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4F5 RID: 115957 RVA: 0x008C1300 File Offset: 0x008BF500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGuildItemSelect(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			BeforeJoinSingleGuildUIController guildItemSelect;
			LuaObject.checkType<BeforeJoinSingleGuildUIController>(l, 2, out guildItemSelect);
			beforeJoinGuildListUIController.m_luaExportHelper.SetGuildItemSelect(guildItemSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4F6 RID: 115958 RVA: 0x008C135C File Offset: 0x008BF55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCreateGuildClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			beforeJoinGuildListUIController.m_luaExportHelper.OnCreateGuildClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4F7 RID: 115959 RVA: 0x008C13B0 File Offset: 0x008BF5B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeGuildClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			beforeJoinGuildListUIController.m_luaExportHelper.OnChangeGuildClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4F8 RID: 115960 RVA: 0x008C1404 File Offset: 0x008BF604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSearchClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			beforeJoinGuildListUIController.m_luaExportHelper.OnSearchClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4F9 RID: 115961 RVA: 0x008C1458 File Offset: 0x008BF658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeleteSearchClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			beforeJoinGuildListUIController.m_luaExportHelper.OnDeleteSearchClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4FA RID: 115962 RVA: 0x008C14AC File Offset: 0x008BF6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildItemClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			BeforeJoinSingleGuildUIController guildItemUIController;
			LuaObject.checkType<BeforeJoinSingleGuildUIController>(l, 2, out guildItemUIController);
			beforeJoinGuildListUIController.m_luaExportHelper.OnGuildItemClick(guildItemUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4FB RID: 115963 RVA: 0x008C1508 File Offset: 0x008BF708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4FC RID: 115964 RVA: 0x008C1574 File Offset: 0x008BF774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4FD RID: 115965 RVA: 0x008C15C8 File Offset: 0x008BF7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4FE RID: 115966 RVA: 0x008C161C File Offset: 0x008BF81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = beforeJoinGuildListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C4FF RID: 115967 RVA: 0x008C16C4 File Offset: 0x008BF8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C500 RID: 115968 RVA: 0x008C1718 File Offset: 0x008BF918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C501 RID: 115969 RVA: 0x008C1784 File Offset: 0x008BF984
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
				BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				beforeJoinGuildListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BeforeJoinGuildListUIController beforeJoinGuildListUIController2 = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				beforeJoinGuildListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C502 RID: 115970 RVA: 0x008C1894 File Offset: 0x008BFA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C503 RID: 115971 RVA: 0x008C1900 File Offset: 0x008BFB00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C504 RID: 115972 RVA: 0x008C196C File Offset: 0x008BFB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C505 RID: 115973 RVA: 0x008C19D8 File Offset: 0x008BFBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C506 RID: 115974 RVA: 0x008C1A44 File Offset: 0x008BFC44
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
				BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				beforeJoinGuildListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BeforeJoinGuildListUIController beforeJoinGuildListUIController2 = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				beforeJoinGuildListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C507 RID: 115975 RVA: 0x008C1B54 File Offset: 0x008BFD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			string s = beforeJoinGuildListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C508 RID: 115976 RVA: 0x008C1BB0 File Offset: 0x008BFDB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_listPanelAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_listPanelAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C509 RID: 115977 RVA: 0x008C1C08 File Offset: 0x008BFE08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_listPanelAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			CommonUIStateController listPanelAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out listPanelAnimation);
			beforeJoinGuildListUIController.m_luaExportHelper.m_listPanelAnimation = listPanelAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C50A RID: 115978 RVA: 0x008C1C64 File Offset: 0x008BFE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildListContent(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildListContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C50B RID: 115979 RVA: 0x008C1CBC File Offset: 0x008BFEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildListContent(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			Transform guildListContent;
			LuaObject.checkType<Transform>(l, 2, out guildListContent);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildListContent = guildListContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C50C RID: 115980 RVA: 0x008C1D18 File Offset: 0x008BFF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_changeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C50D RID: 115981 RVA: 0x008C1D70 File Offset: 0x008BFF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			Button changeButton;
			LuaObject.checkType<Button>(l, 2, out changeButton);
			beforeJoinGuildListUIController.m_luaExportHelper.m_changeButton = changeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C50E RID: 115982 RVA: 0x008C1DCC File Offset: 0x008BFFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildCreateButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildCreateButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C50F RID: 115983 RVA: 0x008C1E24 File Offset: 0x008C0024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildCreateButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			Button guildCreateButton;
			LuaObject.checkType<Button>(l, 2, out guildCreateButton);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildCreateButton = guildCreateButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C510 RID: 115984 RVA: 0x008C1E80 File Offset: 0x008C0080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSearchButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildSearchButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C511 RID: 115985 RVA: 0x008C1ED8 File Offset: 0x008C00D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSearchButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			Button guildSearchButton;
			LuaObject.checkType<Button>(l, 2, out guildSearchButton);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildSearchButton = guildSearchButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C512 RID: 115986 RVA: 0x008C1F34 File Offset: 0x008C0134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_deleteSearchButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_deleteSearchButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C513 RID: 115987 RVA: 0x008C1F8C File Offset: 0x008C018C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_deleteSearchButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			Button deleteSearchButton;
			LuaObject.checkType<Button>(l, 2, out deleteSearchButton);
			beforeJoinGuildListUIController.m_luaExportHelper.m_deleteSearchButton = deleteSearchButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C514 RID: 115988 RVA: 0x008C1FE8 File Offset: 0x008C01E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildItem(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C515 RID: 115989 RVA: 0x008C2040 File Offset: 0x008C0240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildItem(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			GameObject guildItem;
			LuaObject.checkType<GameObject>(l, 2, out guildItem);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildItem = guildItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C516 RID: 115990 RVA: 0x008C209C File Offset: 0x008C029C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildNameInputField(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildNameInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C517 RID: 115991 RVA: 0x008C20F4 File Offset: 0x008C02F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildNameInputField(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			InputField guildNameInputField;
			LuaObject.checkType<InputField>(l, 2, out guildNameInputField);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildNameInputField = guildNameInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C518 RID: 115992 RVA: 0x008C2150 File Offset: 0x008C0350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C519 RID: 115993 RVA: 0x008C21A8 File Offset: 0x008C03A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			beforeJoinGuildListUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C51A RID: 115994 RVA: 0x008C2204 File Offset: 0x008C0404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C51B RID: 115995 RVA: 0x008C225C File Offset: 0x008C045C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			beforeJoinGuildListUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C51C RID: 115996 RVA: 0x008C22B8 File Offset: 0x008C04B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C51D RID: 115997 RVA: 0x008C2310 File Offset: 0x008C0510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			BeforeJoinGuildUIController guildUIController;
			LuaObject.checkType<BeforeJoinGuildUIController>(l, 2, out guildUIController);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildUIController = guildUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C51E RID: 115998 RVA: 0x008C236C File Offset: 0x008C056C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildSearchInfoList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildSearchInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C51F RID: 115999 RVA: 0x008C23C4 File Offset: 0x008C05C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSearchInfoList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			List<GuildSearchInfo> guildSearchInfoList;
			LuaObject.checkType<List<GuildSearchInfo>>(l, 2, out guildSearchInfoList);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildSearchInfoList = guildSearchInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C520 RID: 116000 RVA: 0x008C2420 File Offset: 0x008C0620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildRecommendInfoList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildRecommendInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C521 RID: 116001 RVA: 0x008C2478 File Offset: 0x008C0678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildRecommendInfoList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			List<GuildSearchInfo> guildRecommendInfoList;
			LuaObject.checkType<List<GuildSearchInfo>>(l, 2, out guildRecommendInfoList);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildRecommendInfoList = guildRecommendInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C522 RID: 116002 RVA: 0x008C24D4 File Offset: 0x008C06D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showGuildInfoList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_showGuildInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C523 RID: 116003 RVA: 0x008C252C File Offset: 0x008C072C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_showGuildInfoList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			List<GuildSearchInfo> showGuildInfoList;
			LuaObject.checkType<List<GuildSearchInfo>>(l, 2, out showGuildInfoList);
			beforeJoinGuildListUIController.m_luaExportHelper.m_showGuildInfoList = showGuildInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C524 RID: 116004 RVA: 0x008C2588 File Offset: 0x008C0788
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_guildInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C525 RID: 116005 RVA: 0x008C25E0 File Offset: 0x008C07E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			List<BeforeJoinSingleGuildUIController> guildInfoUIController;
			LuaObject.checkType<List<BeforeJoinSingleGuildUIController>>(l, 2, out guildInfoUIController);
			beforeJoinGuildListUIController.m_luaExportHelper.m_guildInfoUIController = guildInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C526 RID: 116006 RVA: 0x008C263C File Offset: 0x008C083C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectGuildItemUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildListUIController.m_luaExportHelper.m_selectGuildItemUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C527 RID: 116007 RVA: 0x008C2694 File Offset: 0x008C0894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectGuildItemUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildListUIController beforeJoinGuildListUIController = (BeforeJoinGuildListUIController)LuaObject.checkSelf(l);
			BeforeJoinSingleGuildUIController selectGuildItemUIController;
			LuaObject.checkType<BeforeJoinSingleGuildUIController>(l, 2, out selectGuildItemUIController);
			beforeJoinGuildListUIController.m_luaExportHelper.m_selectGuildItemUIController = selectGuildItemUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C528 RID: 116008 RVA: 0x008C26F0 File Offset: 0x008C08F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BeforeJoinGuildListUIController");
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.RefreshGuildList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.GetRandomGuildList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.SetGuildItemSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.OnCreateGuildClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.OnChangeGuildClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.OnSearchClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.OnDeleteSearchClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.OnGuildItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache16);
		string name = "m_listPanelAnimation";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_listPanelAnimation);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_listPanelAnimation);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache18, true);
		string name2 = "m_guildListContent";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildListContent);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildListContent);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1A, true);
		string name3 = "m_changeButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_changeButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_changeButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1C, true);
		string name4 = "m_guildCreateButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildCreateButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildCreateButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1E, true);
		string name5 = "m_guildSearchButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildSearchButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildSearchButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache20, true);
		string name6 = "m_deleteSearchButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_deleteSearchButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_deleteSearchButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache22, true);
		string name7 = "m_guildItem";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildItem);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildItem);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache24, true);
		string name8 = "m_guildNameInputField";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildNameInputField);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildNameInputField);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache26, true);
		string name9 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_playerContext);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache28, true);
		string name10 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_configDataLoader);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2A, true);
		string name11 = "m_guildUIController";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildUIController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildUIController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2C, true);
		string name12 = "m_guildSearchInfoList";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildSearchInfoList);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildSearchInfoList);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2E, true);
		string name13 = "m_guildRecommendInfoList";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildRecommendInfoList);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildRecommendInfoList);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache30, true);
		string name14 = "m_showGuildInfoList";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_showGuildInfoList);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_showGuildInfoList);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache32, true);
		string name15 = "m_guildInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_guildInfoUIController);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_guildInfoUIController);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache34, true);
		string name16 = "m_selectGuildItemUIController";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.get_m_selectGuildItemUIController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.set_m_selectGuildItemUIController);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.<>f__mg$cache36, true);
		LuaObject.createTypeMetatable(l, null, typeof(BeforeJoinGuildListUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401273D RID: 75581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401273E RID: 75582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401273F RID: 75583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012740 RID: 75584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012741 RID: 75585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012742 RID: 75586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012743 RID: 75587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012744 RID: 75588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012745 RID: 75589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012746 RID: 75590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012747 RID: 75591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012748 RID: 75592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012749 RID: 75593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401274A RID: 75594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401274B RID: 75595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401274C RID: 75596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401274D RID: 75597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401274E RID: 75598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401274F RID: 75599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012750 RID: 75600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012751 RID: 75601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012752 RID: 75602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012753 RID: 75603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012754 RID: 75604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012755 RID: 75605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012756 RID: 75606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012757 RID: 75607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012758 RID: 75608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012759 RID: 75609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401275A RID: 75610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401275B RID: 75611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401275C RID: 75612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401275D RID: 75613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401275E RID: 75614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401275F RID: 75615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012760 RID: 75616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012761 RID: 75617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012762 RID: 75618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012763 RID: 75619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012764 RID: 75620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012765 RID: 75621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012766 RID: 75622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012767 RID: 75623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012768 RID: 75624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012769 RID: 75625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401276A RID: 75626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401276B RID: 75627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401276C RID: 75628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401276D RID: 75629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401276E RID: 75630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401276F RID: 75631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012770 RID: 75632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012771 RID: 75633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012772 RID: 75634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012773 RID: 75635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
