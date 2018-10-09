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

// Token: 0x020013CA RID: 5066
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController : LuaObject
{
	// Token: 0x0601C4BE RID: 115902 RVA: 0x008BF724 File Offset: 0x008BD924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			BeforeJoinGuildUIController guildUIController;
			LuaObject.checkType<BeforeJoinGuildUIController>(l, 2, out guildUIController);
			beforeJoinGuildInfoUIController.Init(guildUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4BF RID: 115903 RVA: 0x008BF77C File Offset: 0x008BD97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInfoPanelState(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			bool infoPanelState;
			LuaObject.checkType(l, 2, out infoPanelState);
			beforeJoinGuildInfoUIController.SetInfoPanelState(infoPanelState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C0 RID: 115904 RVA: 0x008BF7D4 File Offset: 0x008BD9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectGuildInfo(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			GuildSearchInfo selectGuildInfo;
			LuaObject.checkType<GuildSearchInfo>(l, 2, out selectGuildInfo);
			beforeJoinGuildInfoUIController.SetSelectGuildInfo(selectGuildInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C1 RID: 115905 RVA: 0x008BF82C File Offset: 0x008BDA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			beforeJoinGuildInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C2 RID: 115906 RVA: 0x008BF880 File Offset: 0x008BDA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildJoinClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			beforeJoinGuildInfoUIController.m_luaExportHelper.OnGuildJoinClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C3 RID: 115907 RVA: 0x008BF8D4 File Offset: 0x008BDAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildDetailClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			beforeJoinGuildInfoUIController.m_luaExportHelper.OnGuildDetailClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C4 RID: 115908 RVA: 0x008BF928 File Offset: 0x008BDB28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C5 RID: 115909 RVA: 0x008BF994 File Offset: 0x008BDB94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C6 RID: 115910 RVA: 0x008BF9E8 File Offset: 0x008BDBE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C7 RID: 115911 RVA: 0x008BFA3C File Offset: 0x008BDC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C4C8 RID: 115912 RVA: 0x008BFAE4 File Offset: 0x008BDCE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4C9 RID: 115913 RVA: 0x008BFB38 File Offset: 0x008BDD38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4CA RID: 115914 RVA: 0x008BFBA4 File Offset: 0x008BDDA4
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
				BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController2 = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				beforeJoinGuildInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C4CB RID: 115915 RVA: 0x008BFCB4 File Offset: 0x008BDEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4CC RID: 115916 RVA: 0x008BFD20 File Offset: 0x008BDF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4CD RID: 115917 RVA: 0x008BFD8C File Offset: 0x008BDF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4CE RID: 115918 RVA: 0x008BFDF8 File Offset: 0x008BDFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4CF RID: 115919 RVA: 0x008BFE64 File Offset: 0x008BE064
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
				BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController2 = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				beforeJoinGuildInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C4D0 RID: 115920 RVA: 0x008BFF74 File Offset: 0x008BE174
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			string s = beforeJoinGuildInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C4D1 RID: 115921 RVA: 0x008BFFD0 File Offset: 0x008BE1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoPanelAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_infoPanelAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4D2 RID: 115922 RVA: 0x008C0028 File Offset: 0x008BE228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoPanelAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController infoPanelAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out infoPanelAnimation);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_infoPanelAnimation = infoPanelAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4D3 RID: 115923 RVA: 0x008C0084 File Offset: 0x008BE284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charLevelText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_charLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4D4 RID: 115924 RVA: 0x008C00DC File Offset: 0x008BE2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charLevelText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Text charLevelText;
			LuaObject.checkType<Text>(l, 2, out charLevelText);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_charLevelText = charLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4D5 RID: 115925 RVA: 0x008C0138 File Offset: 0x008BE338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charIcon(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_charIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4D6 RID: 115926 RVA: 0x008C0190 File Offset: 0x008BE390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_charIcon(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Image charIcon;
			LuaObject.checkType<Image>(l, 2, out charIcon);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_charIcon = charIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4D7 RID: 115927 RVA: 0x008C01EC File Offset: 0x008BE3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_headFrameDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4D8 RID: 115928 RVA: 0x008C0244 File Offset: 0x008BE444
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Transform headFrameDummy;
			LuaObject.checkType<Transform>(l, 2, out headFrameDummy);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_headFrameDummy = headFrameDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4D9 RID: 115929 RVA: 0x008C02A0 File Offset: 0x008BE4A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_charName(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_charName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4DA RID: 115930 RVA: 0x008C02F8 File Offset: 0x008BE4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charName(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Text charName;
			LuaObject.checkType<Text>(l, 2, out charName);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_charName = charName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4DB RID: 115931 RVA: 0x008C0354 File Offset: 0x008BE554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildNameText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4DC RID: 115932 RVA: 0x008C03AC File Offset: 0x008BE5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildNameText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Text guildNameText;
			LuaObject.checkType<Text>(l, 2, out guildNameText);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildNameText = guildNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4DD RID: 115933 RVA: 0x008C0408 File Offset: 0x008BE608
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildDeclarationText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildDeclarationText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4DE RID: 115934 RVA: 0x008C0460 File Offset: 0x008BE660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildDeclarationText(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Text guildDeclarationText;
			LuaObject.checkType<Text>(l, 2, out guildDeclarationText);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildDeclarationText = guildDeclarationText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4DF RID: 115935 RVA: 0x008C04BC File Offset: 0x008BE6BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildDetailButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildDetailButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E0 RID: 115936 RVA: 0x008C0514 File Offset: 0x008BE714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildDetailButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Button guildDetailButton;
			LuaObject.checkType<Button>(l, 2, out guildDetailButton);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildDetailButton = guildDetailButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E1 RID: 115937 RVA: 0x008C0570 File Offset: 0x008BE770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildDetailButtonAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildDetailButtonAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E2 RID: 115938 RVA: 0x008C05C8 File Offset: 0x008BE7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildDetailButtonAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildDetailButtonAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildDetailButtonAnimation);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildDetailButtonAnimation = guildDetailButtonAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E3 RID: 115939 RVA: 0x008C0624 File Offset: 0x008BE824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJoinButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildJoinButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E4 RID: 115940 RVA: 0x008C067C File Offset: 0x008BE87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildJoinButton(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			Button guildJoinButton;
			LuaObject.checkType<Button>(l, 2, out guildJoinButton);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildJoinButton = guildJoinButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E5 RID: 115941 RVA: 0x008C06D8 File Offset: 0x008BE8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJoinButtonAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildJoinButtonAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E6 RID: 115942 RVA: 0x008C0730 File Offset: 0x008BE930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildJoinButtonAnimation(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildJoinButtonAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildJoinButtonAnimation);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildJoinButtonAnimation = guildJoinButtonAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E7 RID: 115943 RVA: 0x008C078C File Offset: 0x008BE98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E8 RID: 115944 RVA: 0x008C07E4 File Offset: 0x008BE9E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4E9 RID: 115945 RVA: 0x008C0840 File Offset: 0x008BEA40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4EA RID: 115946 RVA: 0x008C0898 File Offset: 0x008BEA98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4EB RID: 115947 RVA: 0x008C08F4 File Offset: 0x008BEAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectGuildInfo(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_selectGuildInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4EC RID: 115948 RVA: 0x008C094C File Offset: 0x008BEB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectGuildInfo(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			GuildSearchInfo selectGuildInfo;
			LuaObject.checkType<GuildSearchInfo>(l, 2, out selectGuildInfo);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_selectGuildInfo = selectGuildInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4ED RID: 115949 RVA: 0x008C09A8 File Offset: 0x008BEBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4EE RID: 115950 RVA: 0x008C0A00 File Offset: 0x008BEC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildUIController(IntPtr l)
	{
		int result;
		try
		{
			BeforeJoinGuildInfoUIController beforeJoinGuildInfoUIController = (BeforeJoinGuildInfoUIController)LuaObject.checkSelf(l);
			BeforeJoinGuildUIController guildUIController;
			LuaObject.checkType<BeforeJoinGuildUIController>(l, 2, out guildUIController);
			beforeJoinGuildInfoUIController.m_luaExportHelper.m_guildUIController = guildUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C4EF RID: 115951 RVA: 0x008C0A5C File Offset: 0x008BEC5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BeforeJoinGuildInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.SetInfoPanelState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.SetSelectGuildInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.OnGuildJoinClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.OnGuildDetailClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache12);
		string name = "m_infoPanelAnimation";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_infoPanelAnimation);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_infoPanelAnimation);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache14, true);
		string name2 = "m_charLevelText";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_charLevelText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_charLevelText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache16, true);
		string name3 = "m_charIcon";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_charIcon);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_charIcon);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache18, true);
		string name4 = "m_headFrameDummy";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_headFrameDummy);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_headFrameDummy);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1A, true);
		string name5 = "m_charName";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_charName);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_charName);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1C, true);
		string name6 = "m_guildNameText";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_guildNameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_guildNameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1E, true);
		string name7 = "m_guildDeclarationText";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_guildDeclarationText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_guildDeclarationText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache20, true);
		string name8 = "m_guildDetailButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_guildDetailButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_guildDetailButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache22, true);
		string name9 = "m_guildDetailButtonAnimation";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_guildDetailButtonAnimation);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_guildDetailButtonAnimation);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache24, true);
		string name10 = "m_guildJoinButton";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_guildJoinButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_guildJoinButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache26, true);
		string name11 = "m_guildJoinButtonAnimation";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_guildJoinButtonAnimation);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_guildJoinButtonAnimation);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache28, true);
		string name12 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_playerContext);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2A, true);
		string name13 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_configDataLoader);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2C, true);
		string name14 = "m_selectGuildInfo";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_selectGuildInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_selectGuildInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2E, true);
		string name15 = "m_guildUIController";
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.get_m_guildUIController);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.set_m_guildUIController);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.<>f__mg$cache30, true);
		LuaObject.createTypeMetatable(l, null, typeof(BeforeJoinGuildInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401270C RID: 75532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401270D RID: 75533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401270E RID: 75534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401270F RID: 75535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012710 RID: 75536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012711 RID: 75537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012712 RID: 75538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012713 RID: 75539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012714 RID: 75540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012715 RID: 75541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012716 RID: 75542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012717 RID: 75543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012718 RID: 75544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012719 RID: 75545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401271A RID: 75546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401271B RID: 75547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401271C RID: 75548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401271D RID: 75549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401271E RID: 75550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401271F RID: 75551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012720 RID: 75552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012721 RID: 75553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012722 RID: 75554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012723 RID: 75555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012724 RID: 75556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012725 RID: 75557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012726 RID: 75558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012727 RID: 75559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012728 RID: 75560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012729 RID: 75561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401272A RID: 75562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401272B RID: 75563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401272C RID: 75564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401272D RID: 75565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401272E RID: 75566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401272F RID: 75567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012730 RID: 75568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012731 RID: 75569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012732 RID: 75570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012733 RID: 75571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012734 RID: 75572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012735 RID: 75573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012736 RID: 75574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012737 RID: 75575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012738 RID: 75576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012739 RID: 75577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401273A RID: 75578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401273B RID: 75579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401273C RID: 75580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
