using System;
using System.Collections.Generic;
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

// Token: 0x020013CC RID: 5068
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController : LuaObject
{
	// Token: 0x0601C52A RID: 116010 RVA: 0x008C2EB0 File Offset: 0x008C10B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.Show();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C52B RID: 116011 RVA: 0x008C2EFC File Offset: 0x008C10FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Refresh(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.Refresh();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C52C RID: 116012 RVA: 0x008C2F48 File Offset: 0x008C1148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C52D RID: 116013 RVA: 0x008C2F9C File Offset: 0x008C119C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnable(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.OnEnable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C52E RID: 116014 RVA: 0x008C2FF0 File Offset: 0x008C11F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInviteMsgList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.GetInviteMsgList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C52F RID: 116015 RVA: 0x008C3044 File Offset: 0x008C1244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.OnCloseClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C530 RID: 116016 RVA: 0x008C3098 File Offset: 0x008C1298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBGClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.OnBGClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C531 RID: 116017 RVA: 0x008C30EC File Offset: 0x008C12EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRefuseAllClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.OnRefuseAllClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C532 RID: 116018 RVA: 0x008C3140 File Offset: 0x008C1340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C533 RID: 116019 RVA: 0x008C31AC File Offset: 0x008C13AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C534 RID: 116020 RVA: 0x008C3200 File Offset: 0x008C1400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C535 RID: 116021 RVA: 0x008C3254 File Offset: 0x008C1454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C536 RID: 116022 RVA: 0x008C32FC File Offset: 0x008C14FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C537 RID: 116023 RVA: 0x008C3350 File Offset: 0x008C1550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C538 RID: 116024 RVA: 0x008C33BC File Offset: 0x008C15BC
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
				BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController2 = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				beforeJoinGuildMsgUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C539 RID: 116025 RVA: 0x008C34CC File Offset: 0x008C16CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C53A RID: 116026 RVA: 0x008C3538 File Offset: 0x008C1738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C53B RID: 116027 RVA: 0x008C35A4 File Offset: 0x008C17A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C53C RID: 116028 RVA: 0x008C3610 File Offset: 0x008C1810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C53D RID: 116029 RVA: 0x008C367C File Offset: 0x008C187C
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
				BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController2 = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				beforeJoinGuildMsgUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C53E RID: 116030 RVA: 0x008C378C File Offset: 0x008C198C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			string s = beforeJoinGuildMsgUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C53F RID: 116031 RVA: 0x008C37E8 File Offset: 0x008C19E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildMsgAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_guildMsgAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C540 RID: 116032 RVA: 0x008C3840 File Offset: 0x008C1A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildMsgAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildMsgAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildMsgAnimation);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_guildMsgAnimation = guildMsgAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C541 RID: 116033 RVA: 0x008C389C File Offset: 0x008C1A9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_allRefuseButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_allRefuseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C542 RID: 116034 RVA: 0x008C38F4 File Offset: 0x008C1AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allRefuseButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			Button allRefuseButton;
			LuaObject.checkType<Button>(l, 2, out allRefuseButton);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_allRefuseButton = allRefuseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C543 RID: 116035 RVA: 0x008C3950 File Offset: 0x008C1B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_colseButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_colseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C544 RID: 116036 RVA: 0x008C39A8 File Offset: 0x008C1BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_colseButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			Button colseButton;
			LuaObject.checkType<Button>(l, 2, out colseButton);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_colseButton = colseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C545 RID: 116037 RVA: 0x008C3A04 File Offset: 0x008C1C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_bgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C546 RID: 116038 RVA: 0x008C3A5C File Offset: 0x008C1C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_bgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C547 RID: 116039 RVA: 0x008C3AB8 File Offset: 0x008C1CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildItemTemplate(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_guildItemTemplate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C548 RID: 116040 RVA: 0x008C3B10 File Offset: 0x008C1D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildItemTemplate(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			GameObject guildItemTemplate;
			LuaObject.checkType<GameObject>(l, 2, out guildItemTemplate);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_guildItemTemplate = guildItemTemplate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C549 RID: 116041 RVA: 0x008C3B6C File Offset: 0x008C1D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_msgListContent(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_msgListContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C54A RID: 116042 RVA: 0x008C3BC4 File Offset: 0x008C1DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_msgListContent(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			GameObject msgListContent;
			LuaObject.checkType<GameObject>(l, 2, out msgListContent);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_msgListContent = msgListContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C54B RID: 116043 RVA: 0x008C3C20 File Offset: 0x008C1E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noMessage(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_noMessage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C54C RID: 116044 RVA: 0x008C3C78 File Offset: 0x008C1E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noMessage(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			GameObject noMessage;
			LuaObject.checkType<GameObject>(l, 2, out noMessage);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_noMessage = noMessage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C54D RID: 116045 RVA: 0x008C3CD4 File Offset: 0x008C1ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C54E RID: 116046 RVA: 0x008C3D2C File Offset: 0x008C1F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C54F RID: 116047 RVA: 0x008C3D88 File Offset: 0x008C1F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C550 RID: 116048 RVA: 0x008C3DE0 File Offset: 0x008C1FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C551 RID: 116049 RVA: 0x008C3E3C File Offset: 0x008C203C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJoinInvitationList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_guildJoinInvitationList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C552 RID: 116050 RVA: 0x008C3E94 File Offset: 0x008C2094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildJoinInvitationList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			List<GuildJoinInvitation> guildJoinInvitationList;
			LuaObject.checkType<List<GuildJoinInvitation>>(l, 2, out guildJoinInvitationList);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_guildJoinInvitationList = guildJoinInvitationList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C553 RID: 116051 RVA: 0x008C3EF0 File Offset: 0x008C20F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildInviteItemUIControllerList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildMsgUIController.m_luaExportHelper.m_guildInviteItemUIControllerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C554 RID: 116052 RVA: 0x008C3F48 File Offset: 0x008C2148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildInviteItemUIControllerList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildMsgUIController beforeJoinGuildMsgUIController = (BeforeJoinGuildMsgUIController)LuaObject.checkSelf(l);
			List<GuildInviteItemUIController> guildInviteItemUIControllerList;
			LuaObject.checkType<List<GuildInviteItemUIController>>(l, 2, out guildInviteItemUIControllerList);
			beforeJoinGuildMsgUIController.m_luaExportHelper.m_guildInviteItemUIControllerList = guildInviteItemUIControllerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C555 RID: 116053 RVA: 0x008C3FA4 File Offset: 0x008C21A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BeforeJoinGuildMsgUIController");
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.Refresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.OnEnable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.GetInviteMsgList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.OnCloseClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.OnBGClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.OnRefuseAllClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache14);
		string name = "m_guildMsgAnimation";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_guildMsgAnimation);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_guildMsgAnimation);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache16, true);
		string name2 = "m_allRefuseButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_allRefuseButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_allRefuseButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache18, true);
		string name3 = "m_colseButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_colseButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_colseButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1A, true);
		string name4 = "m_bgButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_bgButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_bgButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1C, true);
		string name5 = "m_guildItemTemplate";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_guildItemTemplate);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_guildItemTemplate);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1E, true);
		string name6 = "m_msgListContent";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_msgListContent);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_msgListContent);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache20, true);
		string name7 = "m_noMessage";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_noMessage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_noMessage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache22, true);
		string name8 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_playerContext);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache24, true);
		string name9 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_configDataLoader);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache26, true);
		string name10 = "m_guildJoinInvitationList";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_guildJoinInvitationList);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_guildJoinInvitationList);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache28, true);
		string name11 = "m_guildInviteItemUIControllerList";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.get_m_guildInviteItemUIControllerList);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.set_m_guildInviteItemUIControllerList);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.<>f__mg$cache2A, true);
		LuaObject.createTypeMetatable(l, null, typeof(BeforeJoinGuildMsgUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012774 RID: 75636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012775 RID: 75637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012776 RID: 75638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012777 RID: 75639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012778 RID: 75640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012779 RID: 75641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401277A RID: 75642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401277B RID: 75643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401277C RID: 75644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401277D RID: 75645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401277E RID: 75646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401277F RID: 75647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012780 RID: 75648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012781 RID: 75649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012782 RID: 75650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012783 RID: 75651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012784 RID: 75652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012785 RID: 75653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012786 RID: 75654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012787 RID: 75655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012788 RID: 75656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012789 RID: 75657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401278A RID: 75658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401278B RID: 75659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401278C RID: 75660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401278D RID: 75661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401278E RID: 75662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401278F RID: 75663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012790 RID: 75664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012791 RID: 75665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012792 RID: 75666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012793 RID: 75667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012794 RID: 75668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012795 RID: 75669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012796 RID: 75670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012797 RID: 75671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012798 RID: 75672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012799 RID: 75673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401279A RID: 75674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401279B RID: 75675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401279C RID: 75676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401279D RID: 75677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401279E RID: 75678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
