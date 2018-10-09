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

// Token: 0x020013CE RID: 5070
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController : LuaObject
{
	// Token: 0x0601C58F RID: 116111 RVA: 0x008C621C File Offset: 0x008C441C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			GuildSearchInfo guildSearchInfo;
			LuaObject.checkType<GuildSearchInfo>(l, 2, out guildSearchInfo);
			Action<BeforeJoinSingleGuildUIController> selectClick;
			LuaObject.checkDelegate<Action<BeforeJoinSingleGuildUIController>>(l, 3, out selectClick);
			beforeJoinSingleGuildUIController.Init(guildSearchInfo, selectClick);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C590 RID: 116112 RVA: 0x008C6280 File Offset: 0x008C4480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelect(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			bool select;
			LuaObject.checkType(l, 2, out select);
			beforeJoinSingleGuildUIController.SetSelect(select);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C591 RID: 116113 RVA: 0x008C62D8 File Offset: 0x008C44D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetApply(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			bool apply;
			LuaObject.checkType(l, 2, out apply);
			beforeJoinSingleGuildUIController.SetApply(apply);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C592 RID: 116114 RVA: 0x008C6330 File Offset: 0x008C4530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Refresh(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			GuildSearchInfo guildSearchInfo;
			LuaObject.checkType<GuildSearchInfo>(l, 2, out guildSearchInfo);
			beforeJoinSingleGuildUIController.Refresh(guildSearchInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C593 RID: 116115 RVA: 0x008C6388 File Offset: 0x008C4588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			beforeJoinSingleGuildUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C594 RID: 116116 RVA: 0x008C63DC File Offset: 0x008C45DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			beforeJoinSingleGuildUIController.m_luaExportHelper.OnItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C595 RID: 116117 RVA: 0x008C6430 File Offset: 0x008C4630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C596 RID: 116118 RVA: 0x008C649C File Offset: 0x008C469C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C597 RID: 116119 RVA: 0x008C64F0 File Offset: 0x008C46F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C598 RID: 116120 RVA: 0x008C6544 File Offset: 0x008C4744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C599 RID: 116121 RVA: 0x008C65EC File Offset: 0x008C47EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C59A RID: 116122 RVA: 0x008C6640 File Offset: 0x008C4840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C59B RID: 116123 RVA: 0x008C66AC File Offset: 0x008C48AC
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
				BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController2 = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				beforeJoinSingleGuildUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C59C RID: 116124 RVA: 0x008C67BC File Offset: 0x008C49BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C59D RID: 116125 RVA: 0x008C6828 File Offset: 0x008C4A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C59E RID: 116126 RVA: 0x008C6894 File Offset: 0x008C4A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C59F RID: 116127 RVA: 0x008C6900 File Offset: 0x008C4B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5A0 RID: 116128 RVA: 0x008C696C File Offset: 0x008C4B6C
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
				BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController2 = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				beforeJoinSingleGuildUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C5A1 RID: 116129 RVA: 0x008C6A7C File Offset: 0x008C4C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			string s = beforeJoinSingleGuildUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C5A2 RID: 116130 RVA: 0x008C6AD8 File Offset: 0x008C4CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_OnEventSelect(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			BeforeJoinSingleGuildUIController obj;
			LuaObject.checkType<BeforeJoinSingleGuildUIController>(l, 2, out obj);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__callDele_OnEventSelect(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5A3 RID: 116131 RVA: 0x008C6B34 File Offset: 0x008C4D34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_OnEventSelect(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			BeforeJoinSingleGuildUIController obj;
			LuaObject.checkType<BeforeJoinSingleGuildUIController>(l, 2, out obj);
			beforeJoinSingleGuildUIController.m_luaExportHelper.__clearDele_OnEventSelect(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5A4 RID: 116132 RVA: 0x008C6B90 File Offset: 0x008C4D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_guildButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5A5 RID: 116133 RVA: 0x008C6BE8 File Offset: 0x008C4DE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			Button guildButton;
			LuaObject.checkType<Button>(l, 2, out guildButton);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_guildButton = guildButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5A6 RID: 116134 RVA: 0x008C6C44 File Offset: 0x008C4E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildCreateButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_guildCreateButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5A7 RID: 116135 RVA: 0x008C6C9C File Offset: 0x008C4E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildCreateButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			Image guildCreateButton;
			LuaObject.checkType<Image>(l, 2, out guildCreateButton);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_guildCreateButton = guildCreateButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5A8 RID: 116136 RVA: 0x008C6CF8 File Offset: 0x008C4EF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_sociatyNameText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_sociatyNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5A9 RID: 116137 RVA: 0x008C6D50 File Offset: 0x008C4F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sociatyNameText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			Text sociatyNameText;
			LuaObject.checkType<Text>(l, 2, out sociatyNameText);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_sociatyNameText = sociatyNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5AA RID: 116138 RVA: 0x008C6DAC File Offset: 0x008C4FAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_peopleValueText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_peopleValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5AB RID: 116139 RVA: 0x008C6E04 File Offset: 0x008C5004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_peopleValueText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			Text peopleValueText;
			LuaObject.checkType<Text>(l, 2, out peopleValueText);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_peopleValueText = peopleValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5AC RID: 116140 RVA: 0x008C6E60 File Offset: 0x008C5060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_LevelRequireText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_LevelRequireText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5AD RID: 116141 RVA: 0x008C6EB8 File Offset: 0x008C50B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_LevelRequireText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			Text levelRequireText;
			LuaObject.checkType<Text>(l, 2, out levelRequireText);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_LevelRequireText = levelRequireText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5AE RID: 116142 RVA: 0x008C6F14 File Offset: 0x008C5114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_vitalityText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_vitalityText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5AF RID: 116143 RVA: 0x008C6F6C File Offset: 0x008C516C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_vitalityText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			Text vitalityText;
			LuaObject.checkType<Text>(l, 2, out vitalityText);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_vitalityText = vitalityText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B0 RID: 116144 RVA: 0x008C6FC8 File Offset: 0x008C51C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_applyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_applyGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B1 RID: 116145 RVA: 0x008C7020 File Offset: 0x008C5220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_applyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			GameObject applyGameObject;
			LuaObject.checkType<GameObject>(l, 2, out applyGameObject);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_applyGameObject = applyGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B2 RID: 116146 RVA: 0x008C707C File Offset: 0x008C527C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OnEventSelect(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			Action<BeforeJoinSingleGuildUIController> action;
			int num = LuaObject.checkDelegate<Action<BeforeJoinSingleGuildUIController>>(l, 2, out action);
			if (num == 0)
			{
				beforeJoinSingleGuildUIController.m_luaExportHelper.OnEventSelect = action;
			}
			else if (num == 1)
			{
				BeforeJoinSingleGuildUIController.LuaExportHelper luaExportHelper = beforeJoinSingleGuildUIController.m_luaExportHelper;
				luaExportHelper.OnEventSelect = (Action<BeforeJoinSingleGuildUIController>)Delegate.Combine(luaExportHelper.OnEventSelect, action);
			}
			else if (num == 2)
			{
				BeforeJoinSingleGuildUIController.LuaExportHelper luaExportHelper2 = beforeJoinSingleGuildUIController.m_luaExportHelper;
				luaExportHelper2.OnEventSelect = (Action<BeforeJoinSingleGuildUIController>)Delegate.Remove(luaExportHelper2.OnEventSelect, action);
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

	// Token: 0x0601C5B3 RID: 116147 RVA: 0x008C7130 File Offset: 0x008C5330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B4 RID: 116148 RVA: 0x008C7188 File Offset: 0x008C5388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B5 RID: 116149 RVA: 0x008C71E4 File Offset: 0x008C53E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B6 RID: 116150 RVA: 0x008C723C File Offset: 0x008C543C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			beforeJoinSingleGuildUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B7 RID: 116151 RVA: 0x008C7298 File Offset: 0x008C5498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSearchInfo(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinSingleGuildUIController.m_guildSearchInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B8 RID: 116152 RVA: 0x008C72EC File Offset: 0x008C54EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSearchInfo(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController = (BeforeJoinSingleGuildUIController)LuaObject.checkSelf(l);
			GuildSearchInfo guildSearchInfo;
			LuaObject.checkType<GuildSearchInfo>(l, 2, out guildSearchInfo);
			beforeJoinSingleGuildUIController.m_guildSearchInfo = guildSearchInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5B9 RID: 116153 RVA: 0x008C7344 File Offset: 0x008C5544
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BeforeJoinSingleGuildUIController");
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.SetSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.SetApply);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.Refresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.OnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__callDele_OnEventSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.__clearDele_OnEventSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache14);
		string name = "m_guildButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_guildButton);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_guildButton);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache16, true);
		string name2 = "m_guildCreateButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_guildCreateButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_guildCreateButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache18, true);
		string name3 = "m_sociatyNameText";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_sociatyNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_sociatyNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1A, true);
		string name4 = "m_peopleValueText";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_peopleValueText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_peopleValueText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1C, true);
		string name5 = "m_LevelRequireText";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_LevelRequireText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_LevelRequireText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1E, true);
		string name6 = "m_vitalityText";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_vitalityText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_vitalityText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache20, true);
		string name7 = "m_applyGameObject";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_applyGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_applyGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache22, true);
		string name8 = "OnEventSelect";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_OnEventSelect);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache23, true);
		string name9 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_playerContext);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache25, true);
		string name10 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_configDataLoader);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache27, true);
		string name11 = "m_guildSearchInfo";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.get_m_guildSearchInfo);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.set_m_guildSearchInfo);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.<>f__mg$cache29, true);
		LuaObject.createTypeMetatable(l, null, typeof(BeforeJoinSingleGuildUIController), typeof(UIControllerBase));
	}

	// Token: 0x040127D5 RID: 75733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040127D6 RID: 75734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040127D7 RID: 75735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040127D8 RID: 75736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040127D9 RID: 75737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040127DA RID: 75738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040127DB RID: 75739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040127DC RID: 75740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040127DD RID: 75741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040127DE RID: 75742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040127DF RID: 75743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040127E0 RID: 75744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040127E1 RID: 75745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040127E2 RID: 75746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040127E3 RID: 75747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040127E4 RID: 75748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040127E5 RID: 75749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040127E6 RID: 75750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040127E7 RID: 75751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040127E8 RID: 75752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040127E9 RID: 75753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040127EA RID: 75754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040127EB RID: 75755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040127EC RID: 75756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040127ED RID: 75757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040127EE RID: 75758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040127EF RID: 75759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040127F0 RID: 75760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040127F1 RID: 75761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040127F2 RID: 75762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040127F3 RID: 75763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040127F4 RID: 75764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040127F5 RID: 75765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040127F6 RID: 75766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040127F7 RID: 75767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040127F8 RID: 75768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040127F9 RID: 75769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040127FA RID: 75770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040127FB RID: 75771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040127FC RID: 75772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040127FD RID: 75773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040127FE RID: 75774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
