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

// Token: 0x020013CD RID: 5069
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController : LuaObject
{
	// Token: 0x0601C557 RID: 116055 RVA: 0x008C45C0 File Offset: 0x008C27C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C558 RID: 116056 RVA: 0x008C460C File Offset: 0x008C280C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C559 RID: 116057 RVA: 0x008C4660 File Offset: 0x008C2860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C55A RID: 116058 RVA: 0x008C46B4 File Offset: 0x008C28B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInviteMsgList(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.GetInviteMsgList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C55B RID: 116059 RVA: 0x008C4708 File Offset: 0x008C2908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshMessageRedPoint(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.RefreshMessageRedPoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C55C RID: 116060 RVA: 0x008C475C File Offset: 0x008C295C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.OnReturnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C55D RID: 116061 RVA: 0x008C47B0 File Offset: 0x008C29B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMessageClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.OnMessageClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C55E RID: 116062 RVA: 0x008C4804 File Offset: 0x008C2A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.OnInfoClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C55F RID: 116063 RVA: 0x008C4858 File Offset: 0x008C2A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildUpdateInfoNtf(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			GuildLog log;
			LuaObject.checkType<GuildLog>(l, 2, out log);
			beforeJoinGuildUIController.m_luaExportHelper.OnGuildUpdateInfoNtf(log);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C560 RID: 116064 RVA: 0x008C48B4 File Offset: 0x008C2AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C561 RID: 116065 RVA: 0x008C4920 File Offset: 0x008C2B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C562 RID: 116066 RVA: 0x008C4974 File Offset: 0x008C2B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C563 RID: 116067 RVA: 0x008C49C8 File Offset: 0x008C2BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = beforeJoinGuildUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C564 RID: 116068 RVA: 0x008C4A70 File Offset: 0x008C2C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C565 RID: 116069 RVA: 0x008C4AC4 File Offset: 0x008C2CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C566 RID: 116070 RVA: 0x008C4B30 File Offset: 0x008C2D30
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
				BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				beforeJoinGuildUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BeforeJoinGuildUIController beforeJoinGuildUIController2 = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				beforeJoinGuildUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C567 RID: 116071 RVA: 0x008C4C40 File Offset: 0x008C2E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C568 RID: 116072 RVA: 0x008C4CAC File Offset: 0x008C2EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C569 RID: 116073 RVA: 0x008C4D18 File Offset: 0x008C2F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C56A RID: 116074 RVA: 0x008C4D84 File Offset: 0x008C2F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C56B RID: 116075 RVA: 0x008C4DF0 File Offset: 0x008C2FF0
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
				BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				beforeJoinGuildUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BeforeJoinGuildUIController beforeJoinGuildUIController2 = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				beforeJoinGuildUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C56C RID: 116076 RVA: 0x008C4F00 File Offset: 0x008C3100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			string s = beforeJoinGuildUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C56D RID: 116077 RVA: 0x008C4F5C File Offset: 0x008C315C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoPanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_infoPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C56E RID: 116078 RVA: 0x008C4FB4 File Offset: 0x008C31B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoPanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			GameObject infoPanel;
			LuaObject.checkType<GameObject>(l, 2, out infoPanel);
			beforeJoinGuildUIController.m_luaExportHelper.m_infoPanel = infoPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C56F RID: 116079 RVA: 0x008C5010 File Offset: 0x008C3210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankingPanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_rankingPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C570 RID: 116080 RVA: 0x008C5068 File Offset: 0x008C3268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankingPanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			GameObject rankingPanel;
			LuaObject.checkType<GameObject>(l, 2, out rankingPanel);
			beforeJoinGuildUIController.m_luaExportHelper.m_rankingPanel = rankingPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C571 RID: 116081 RVA: 0x008C50C4 File Offset: 0x008C32C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listPanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_listPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C572 RID: 116082 RVA: 0x008C511C File Offset: 0x008C331C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listPanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			GameObject listPanel;
			LuaObject.checkType<GameObject>(l, 2, out listPanel);
			beforeJoinGuildUIController.m_luaExportHelper.m_listPanel = listPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C573 RID: 116083 RVA: 0x008C5178 File Offset: 0x008C3378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messagePanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_messagePanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C574 RID: 116084 RVA: 0x008C51D0 File Offset: 0x008C33D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messagePanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			GameObject messagePanel;
			LuaObject.checkType<GameObject>(l, 2, out messagePanel);
			beforeJoinGuildUIController.m_luaExportHelper.m_messagePanel = messagePanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C575 RID: 116085 RVA: 0x008C522C File Offset: 0x008C342C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_createGuildPanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_createGuildPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C576 RID: 116086 RVA: 0x008C5284 File Offset: 0x008C3484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_createGuildPanel(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			GameObject createGuildPanel;
			LuaObject.checkType<GameObject>(l, 2, out createGuildPanel);
			beforeJoinGuildUIController.m_luaExportHelper.m_createGuildPanel = createGuildPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C577 RID: 116087 RVA: 0x008C52E0 File Offset: 0x008C34E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_messageButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C578 RID: 116088 RVA: 0x008C5338 File Offset: 0x008C3538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			Button messageButton;
			LuaObject.checkType<Button>(l, 2, out messageButton);
			beforeJoinGuildUIController.m_luaExportHelper.m_messageButton = messageButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C579 RID: 116089 RVA: 0x008C5394 File Offset: 0x008C3594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C57A RID: 116090 RVA: 0x008C53EC File Offset: 0x008C35EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			beforeJoinGuildUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C57B RID: 116091 RVA: 0x008C5448 File Offset: 0x008C3648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_infoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C57C RID: 116092 RVA: 0x008C54A0 File Offset: 0x008C36A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			Button infoButton;
			LuaObject.checkType<Button>(l, 2, out infoButton);
			beforeJoinGuildUIController.m_luaExportHelper.m_infoButton = infoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C57D RID: 116093 RVA: 0x008C54FC File Offset: 0x008C36FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageRedPoint(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_messageRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C57E RID: 116094 RVA: 0x008C5554 File Offset: 0x008C3754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageRedPoint(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			GameObject messageRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out messageRedPoint);
			beforeJoinGuildUIController.m_luaExportHelper.m_messageRedPoint = messageRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C57F RID: 116095 RVA: 0x008C55B0 File Offset: 0x008C37B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C580 RID: 116096 RVA: 0x008C5608 File Offset: 0x008C3808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			beforeJoinGuildUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C581 RID: 116097 RVA: 0x008C5664 File Offset: 0x008C3864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C582 RID: 116098 RVA: 0x008C56BC File Offset: 0x008C38BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			beforeJoinGuildUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C583 RID: 116099 RVA: 0x008C5718 File Offset: 0x008C3918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildListUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_guildListUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C584 RID: 116100 RVA: 0x008C576C File Offset: 0x008C396C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildListUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			BeforeJoinGuildListUIController guildListUIController;
			LuaObject.checkType<BeforeJoinGuildListUIController>(l, 2, out guildListUIController);
			beforeJoinGuildUIController.m_guildListUIController = guildListUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C585 RID: 116101 RVA: 0x008C57C4 File Offset: 0x008C39C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_guildInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C586 RID: 116102 RVA: 0x008C5818 File Offset: 0x008C3A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			BeforeJoinGuildInfoUIController guildInfoUIController;
			LuaObject.checkType<BeforeJoinGuildInfoUIController>(l, 2, out guildInfoUIController);
			beforeJoinGuildUIController.m_guildInfoUIController = guildInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C587 RID: 116103 RVA: 0x008C5870 File Offset: 0x008C3A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_receiveMsgUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_receiveMsgUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C588 RID: 116104 RVA: 0x008C58C4 File Offset: 0x008C3AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_receiveMsgUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			BeforeJoinGuildMsgUIController receiveMsgUIController;
			LuaObject.checkType<BeforeJoinGuildMsgUIController>(l, 2, out receiveMsgUIController);
			beforeJoinGuildUIController.m_receiveMsgUIController = receiveMsgUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C589 RID: 116105 RVA: 0x008C591C File Offset: 0x008C3B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_createGuildUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_createGuildUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C58A RID: 116106 RVA: 0x008C5970 File Offset: 0x008C3B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_createGuildUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			CreateGuildUIController createGuildUIController;
			LuaObject.checkType<CreateGuildUIController>(l, 2, out createGuildUIController);
			beforeJoinGuildUIController.m_createGuildUIController = createGuildUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C58B RID: 116107 RVA: 0x008C59C8 File Offset: 0x008C3BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildUITask(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildUIController.m_luaExportHelper.m_guildUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C58C RID: 116108 RVA: 0x008C5A20 File Offset: 0x008C3C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildUITask(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildUIController beforeJoinGuildUIController = (BeforeJoinGuildUIController)LuaObject.checkSelf(l);
			GuildUITask guildUITask;
			LuaObject.checkType<GuildUITask>(l, 2, out guildUITask);
			beforeJoinGuildUIController.m_luaExportHelper.m_guildUITask = guildUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C58D RID: 116109 RVA: 0x008C5A7C File Offset: 0x008C3C7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BeforeJoinGuildUIController");
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.GetInviteMsgList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.RefreshMessageRedPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.OnReturnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.OnMessageClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.OnInfoClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.OnGuildUpdateInfoNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache15);
		string name = "m_infoPanel";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_infoPanel);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_infoPanel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache17, true);
		string name2 = "m_rankingPanel";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_rankingPanel);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_rankingPanel);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache19, true);
		string name3 = "m_listPanel";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_listPanel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_listPanel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1B, true);
		string name4 = "m_messagePanel";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_messagePanel);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_messagePanel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1D, true);
		string name5 = "m_createGuildPanel";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_createGuildPanel);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_createGuildPanel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache1F, true);
		string name6 = "m_messageButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_messageButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_messageButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache21, true);
		string name7 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_returnButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache23, true);
		string name8 = "m_infoButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_infoButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_infoButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache25, true);
		string name9 = "m_messageRedPoint";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_messageRedPoint);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_messageRedPoint);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache27, true);
		string name10 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_playerContext);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache29, true);
		string name11 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_configDataLoader);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2B, true);
		string name12 = "m_guildListUIController";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_guildListUIController);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_guildListUIController);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2D, true);
		string name13 = "m_guildInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_guildInfoUIController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_guildInfoUIController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache2F, true);
		string name14 = "m_receiveMsgUIController";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_receiveMsgUIController);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_receiveMsgUIController);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache31, true);
		string name15 = "m_createGuildUIController";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_createGuildUIController);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_createGuildUIController);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache33, true);
		string name16 = "m_guildUITask";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.get_m_guildUITask);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.set_m_guildUITask);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.<>f__mg$cache35, true);
		LuaObject.createTypeMetatable(l, null, typeof(BeforeJoinGuildUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401279F RID: 75679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040127A0 RID: 75680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040127A1 RID: 75681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040127A2 RID: 75682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040127A3 RID: 75683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040127A4 RID: 75684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040127A5 RID: 75685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040127A6 RID: 75686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040127A7 RID: 75687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040127A8 RID: 75688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040127A9 RID: 75689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040127AA RID: 75690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040127AB RID: 75691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040127AC RID: 75692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040127AD RID: 75693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040127AE RID: 75694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040127AF RID: 75695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040127B0 RID: 75696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040127B1 RID: 75697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040127B2 RID: 75698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040127B3 RID: 75699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040127B4 RID: 75700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040127B5 RID: 75701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040127B6 RID: 75702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040127B7 RID: 75703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040127B8 RID: 75704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040127B9 RID: 75705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040127BA RID: 75706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040127BB RID: 75707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040127BC RID: 75708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040127BD RID: 75709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040127BE RID: 75710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040127BF RID: 75711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040127C0 RID: 75712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040127C1 RID: 75713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040127C2 RID: 75714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040127C3 RID: 75715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040127C4 RID: 75716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040127C5 RID: 75717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040127C6 RID: 75718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040127C7 RID: 75719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040127C8 RID: 75720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040127C9 RID: 75721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040127CA RID: 75722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040127CB RID: 75723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040127CC RID: 75724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040127CD RID: 75725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040127CE RID: 75726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040127CF RID: 75727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040127D0 RID: 75728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040127D1 RID: 75729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040127D2 RID: 75730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040127D3 RID: 75731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040127D4 RID: 75732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;
}
