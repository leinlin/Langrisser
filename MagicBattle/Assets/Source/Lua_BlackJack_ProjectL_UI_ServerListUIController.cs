using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001574 RID: 5492
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ServerListUIController : LuaObject
{
	// Token: 0x06021008 RID: 135176 RVA: 0x00B16730 File Offset: 0x00B14930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetServerList(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			List<LoginUITask.ServerInfo> serverList;
			LuaObject.checkType<List<LoginUITask.ServerInfo>>(l, 2, out serverList);
			List<LoginUITask.ServerInfo> recentLoginServerList;
			LuaObject.checkType<List<LoginUITask.ServerInfo>>(l, 3, out recentLoginServerList);
			List<LoginUITask.ExistCharInfo> existCharsInfo;
			LuaObject.checkType<List<LoginUITask.ExistCharInfo>>(l, 4, out existCharsInfo);
			int selectServerID;
			LuaObject.checkType(l, 5, out selectServerID);
			serverListUIController.SetServerList(serverList, recentLoginServerList, existCharsInfo, selectServerID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021009 RID: 135177 RVA: 0x00B167B0 File Offset: 0x00B149B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602100A RID: 135178 RVA: 0x00B167FC File Offset: 0x00B149FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602100B RID: 135179 RVA: 0x00B16848 File Offset: 0x00B14A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602100C RID: 135180 RVA: 0x00B1689C File Offset: 0x00B14A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearServerListItem(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject listGroup;
			LuaObject.checkType<GameObject>(l, 2, out listGroup);
			serverListUIController.m_luaExportHelper.ClearServerListItem(listGroup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602100D RID: 135181 RVA: 0x00B168F8 File Offset: 0x00B14AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshServerArea(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.RefreshServerArea();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602100E RID: 135182 RVA: 0x00B1694C File Offset: 0x00B14B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshPlayerHead(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.RefreshPlayerHead();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602100F RID: 135183 RVA: 0x00B169A0 File Offset: 0x00B14BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddServerListItem(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(GameObject), typeof(LoginUITask.ServerInfo)))
			{
				ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
				GameObject listGroup;
				LuaObject.checkType<GameObject>(l, 2, out listGroup);
				LoginUITask.ServerInfo server;
				LuaObject.checkType<LoginUITask.ServerInfo>(l, 3, out server);
				serverListUIController.m_luaExportHelper.AddServerListItem(listGroup, server);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(GameObject), typeof(List<LoginUITask.ServerInfo>)))
			{
				ServerListUIController serverListUIController2 = (ServerListUIController)LuaObject.checkSelf(l);
				GameObject listGroup2;
				LuaObject.checkType<GameObject>(l, 2, out listGroup2);
				List<LoginUITask.ServerInfo> serverList;
				LuaObject.checkType<List<LoginUITask.ServerInfo>>(l, 3, out serverList);
				serverListUIController2.m_luaExportHelper.AddServerListItem(listGroup2, serverList);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddServerListItem to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021010 RID: 135184 RVA: 0x00B16AB0 File Offset: 0x00B14CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LastLoginTimeDescription(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			int hour;
			LuaObject.checkType(l, 2, out hour);
			string s = serverListUIController.m_luaExportHelper.LastLoginTimeDescription(hour);
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

	// Token: 0x06021011 RID: 135185 RVA: 0x00B16B18 File Offset: 0x00B14D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021012 RID: 135186 RVA: 0x00B16B6C File Offset: 0x00B14D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClicked(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.OnCloseButtonClicked();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021013 RID: 135187 RVA: 0x00B16BC0 File Offset: 0x00B14DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAreaClick(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject areaItem;
			LuaObject.checkType<GameObject>(l, 2, out areaItem);
			serverListUIController.m_luaExportHelper.OnAreaClick(areaItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021014 RID: 135188 RVA: 0x00B16C1C File Offset: 0x00B14E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIClosed(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.OnUIClosed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021015 RID: 135189 RVA: 0x00B16C70 File Offset: 0x00B14E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			serverListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021016 RID: 135190 RVA: 0x00B16CDC File Offset: 0x00B14EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021017 RID: 135191 RVA: 0x00B16D30 File Offset: 0x00B14F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021018 RID: 135192 RVA: 0x00B16D84 File Offset: 0x00B14F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = serverListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021019 RID: 135193 RVA: 0x00B16E2C File Offset: 0x00B1502C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			serverListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602101A RID: 135194 RVA: 0x00B16E80 File Offset: 0x00B15080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			serverListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602101B RID: 135195 RVA: 0x00B16EEC File Offset: 0x00B150EC
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
				ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				serverListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ServerListUIController serverListUIController2 = (ServerListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				serverListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602101C RID: 135196 RVA: 0x00B16FFC File Offset: 0x00B151FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			serverListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602101D RID: 135197 RVA: 0x00B17068 File Offset: 0x00B15268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			serverListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602101E RID: 135198 RVA: 0x00B170D4 File Offset: 0x00B152D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			serverListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602101F RID: 135199 RVA: 0x00B17140 File Offset: 0x00B15340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			serverListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021020 RID: 135200 RVA: 0x00B171AC File Offset: 0x00B153AC
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
				ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				serverListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ServerListUIController serverListUIController2 = (ServerListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				serverListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021021 RID: 135201 RVA: 0x00B172BC File Offset: 0x00B154BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			string s = serverListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021022 RID: 135202 RVA: 0x00B17318 File Offset: 0x00B15518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClosed(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			serverListUIController.m_luaExportHelper.__callDele_EventOnClosed(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021023 RID: 135203 RVA: 0x00B17374 File Offset: 0x00B15574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClosed(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			serverListUIController.m_luaExportHelper.__clearDele_EventOnClosed(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021024 RID: 135204 RVA: 0x00B173D0 File Offset: 0x00B155D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021025 RID: 135205 RVA: 0x00B17428 File Offset: 0x00B15628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			serverListUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021026 RID: 135206 RVA: 0x00B17484 File Offset: 0x00B15684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021027 RID: 135207 RVA: 0x00B174DC File Offset: 0x00B156DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			serverListUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021028 RID: 135208 RVA: 0x00B17538 File Offset: 0x00B15738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_liServerListGroup(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_liServerListGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021029 RID: 135209 RVA: 0x00B17590 File Offset: 0x00B15790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_liServerListGroup(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject liServerListGroup;
			LuaObject.checkType<GameObject>(l, 2, out liServerListGroup);
			serverListUIController.m_luaExportHelper.m_liServerListGroup = liServerListGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602102A RID: 135210 RVA: 0x00B175EC File Offset: 0x00B157EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_areaGroup(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_areaGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602102B RID: 135211 RVA: 0x00B17644 File Offset: 0x00B15844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_areaGroup(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject areaGroup;
			LuaObject.checkType<GameObject>(l, 2, out areaGroup);
			serverListUIController.m_luaExportHelper.m_areaGroup = areaGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602102C RID: 135212 RVA: 0x00B176A0 File Offset: 0x00B158A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headGroup(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_headGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602102D RID: 135213 RVA: 0x00B176F8 File Offset: 0x00B158F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headGroup(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject headGroup;
			LuaObject.checkType<GameObject>(l, 2, out headGroup);
			serverListUIController.m_luaExportHelper.m_headGroup = headGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602102E RID: 135214 RVA: 0x00B17754 File Offset: 0x00B15954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noChar(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_noChar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602102F RID: 135215 RVA: 0x00B177AC File Offset: 0x00B159AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noChar(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject noChar;
			LuaObject.checkType<GameObject>(l, 2, out noChar);
			serverListUIController.m_luaExportHelper.m_noChar = noChar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021030 RID: 135216 RVA: 0x00B17808 File Offset: 0x00B15A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverListItemTemplate(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_serverListItemTemplate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021031 RID: 135217 RVA: 0x00B17860 File Offset: 0x00B15A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverListItemTemplate(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject serverListItemTemplate;
			LuaObject.checkType<GameObject>(l, 2, out serverListItemTemplate);
			serverListUIController.m_luaExportHelper.m_serverListItemTemplate = serverListItemTemplate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021032 RID: 135218 RVA: 0x00B178BC File Offset: 0x00B15ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headItemTemplate(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_headItemTemplate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021033 RID: 135219 RVA: 0x00B17914 File Offset: 0x00B15B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headItemTemplate(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject headItemTemplate;
			LuaObject.checkType<GameObject>(l, 2, out headItemTemplate);
			serverListUIController.m_luaExportHelper.m_headItemTemplate = headItemTemplate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021034 RID: 135220 RVA: 0x00B17970 File Offset: 0x00B15B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_areaItemTemplate(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_areaItemTemplate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021035 RID: 135221 RVA: 0x00B179C8 File Offset: 0x00B15BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_areaItemTemplate(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject areaItemTemplate;
			LuaObject.checkType<GameObject>(l, 2, out areaItemTemplate);
			serverListUIController.m_luaExportHelper.m_areaItemTemplate = areaItemTemplate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021036 RID: 135222 RVA: 0x00B17A24 File Offset: 0x00B15C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_liServerNameText(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_liServerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021037 RID: 135223 RVA: 0x00B17A7C File Offset: 0x00B15C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_liServerNameText(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			Text liServerNameText;
			LuaObject.checkType<Text>(l, 2, out liServerNameText);
			serverListUIController.m_luaExportHelper.m_liServerNameText = liServerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021038 RID: 135224 RVA: 0x00B17AD8 File Offset: 0x00B15CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_liNewServerIcon(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_liNewServerIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021039 RID: 135225 RVA: 0x00B17B30 File Offset: 0x00B15D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_liNewServerIcon(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject liNewServerIcon;
			LuaObject.checkType<GameObject>(l, 2, out liNewServerIcon);
			serverListUIController.m_luaExportHelper.m_liNewServerIcon = liNewServerIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602103A RID: 135226 RVA: 0x00B17B8C File Offset: 0x00B15D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_liServerStateIcon(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_liServerStateIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602103B RID: 135227 RVA: 0x00B17BE4 File Offset: 0x00B15DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_liServerStateIcon(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			Image liServerStateIcon;
			LuaObject.checkType<Image>(l, 2, out liServerStateIcon);
			serverListUIController.m_luaExportHelper.m_liServerStateIcon = liServerStateIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602103C RID: 135228 RVA: 0x00B17C40 File Offset: 0x00B15E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_liServerCharIcon(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_liServerCharIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602103D RID: 135229 RVA: 0x00B17C98 File Offset: 0x00B15E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_liServerCharIcon(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject liServerCharIcon;
			LuaObject.checkType<GameObject>(l, 2, out liServerCharIcon);
			serverListUIController.m_luaExportHelper.m_liServerCharIcon = liServerCharIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602103E RID: 135230 RVA: 0x00B17CF4 File Offset: 0x00B15EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_liServerCharImage(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_liServerCharImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602103F RID: 135231 RVA: 0x00B17D4C File Offset: 0x00B15F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_liServerCharImage(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			Image liServerCharImage;
			LuaObject.checkType<Image>(l, 2, out liServerCharImage);
			serverListUIController.m_luaExportHelper.m_liServerCharImage = liServerCharImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021040 RID: 135232 RVA: 0x00B17DA8 File Offset: 0x00B15FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_liServerCharLevel(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_liServerCharLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021041 RID: 135233 RVA: 0x00B17E00 File Offset: 0x00B16000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_liServerCharLevel(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			Text liServerCharLevel;
			LuaObject.checkType<Text>(l, 2, out liServerCharLevel);
			serverListUIController.m_luaExportHelper.m_liServerCharLevel = liServerCharLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021042 RID: 135234 RVA: 0x00B17E5C File Offset: 0x00B1605C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_liMaitainServerIcon(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_liMaitainServerIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021043 RID: 135235 RVA: 0x00B17EB4 File Offset: 0x00B160B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_liMaitainServerIcon(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject liMaitainServerIcon;
			LuaObject.checkType<GameObject>(l, 2, out liMaitainServerIcon);
			serverListUIController.m_luaExportHelper.m_liMaitainServerIcon = liMaitainServerIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021044 RID: 135236 RVA: 0x00B17F10 File Offset: 0x00B16110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021045 RID: 135237 RVA: 0x00B17F68 File Offset: 0x00B16168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			serverListUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021046 RID: 135238 RVA: 0x00B17FC4 File Offset: 0x00B161C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverGroup(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_serverGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021047 RID: 135239 RVA: 0x00B1801C File Offset: 0x00B1621C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverGroup(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			Dictionary<string, List<LoginUITask.ServerInfo>> serverGroup;
			LuaObject.checkType<Dictionary<string, List<LoginUITask.ServerInfo>>>(l, 2, out serverGroup);
			serverListUIController.m_luaExportHelper.m_serverGroup = serverGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021048 RID: 135240 RVA: 0x00B18078 File Offset: 0x00B16278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_servers(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_servers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021049 RID: 135241 RVA: 0x00B180D0 File Offset: 0x00B162D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_servers(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			List<LoginUITask.ServerInfo> servers;
			LuaObject.checkType<List<LoginUITask.ServerInfo>>(l, 2, out servers);
			serverListUIController.m_luaExportHelper.m_servers = servers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602104A RID: 135242 RVA: 0x00B1812C File Offset: 0x00B1632C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectArea(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_selectArea);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602104B RID: 135243 RVA: 0x00B18184 File Offset: 0x00B16384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectArea(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			GameObject selectArea;
			LuaObject.checkType<GameObject>(l, 2, out selectArea);
			serverListUIController.m_luaExportHelper.m_selectArea = selectArea;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602104C RID: 135244 RVA: 0x00B181E0 File Offset: 0x00B163E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClosed(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					serverListUIController.EventOnClosed += value;
				}
				else if (num == 2)
				{
					serverListUIController.EventOnClosed -= value;
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

	// Token: 0x0602104D RID: 135245 RVA: 0x00B18260 File Offset: 0x00B16460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectServerID(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_selectServerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602104E RID: 135246 RVA: 0x00B182B8 File Offset: 0x00B164B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectServerID(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			int selectServerID;
			LuaObject.checkType(l, 2, out selectServerID);
			serverListUIController.m_luaExportHelper.m_selectServerID = selectServerID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602104F RID: 135247 RVA: 0x00B18314 File Offset: 0x00B16514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_existCharsInfo(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_existCharsInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021050 RID: 135248 RVA: 0x00B1836C File Offset: 0x00B1656C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_existCharsInfo(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			List<LoginUITask.ExistCharInfo> existCharsInfo;
			LuaObject.checkType<List<LoginUITask.ExistCharInfo>>(l, 2, out existCharsInfo);
			serverListUIController.m_luaExportHelper.m_existCharsInfo = existCharsInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021051 RID: 135249 RVA: 0x00B183C8 File Offset: 0x00B165C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roleListURL(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_roleListURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021052 RID: 135250 RVA: 0x00B18420 File Offset: 0x00B16620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roleListURL(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			string roleListURL;
			LuaObject.checkType(l, 2, out roleListURL);
			serverListUIController.m_luaExportHelper.m_roleListURL = roleListURL;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021053 RID: 135251 RVA: 0x00B1847C File Offset: 0x00B1667C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fDebugReportTime(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, serverListUIController.m_luaExportHelper.m_fDebugReportTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021054 RID: 135252 RVA: 0x00B184D4 File Offset: 0x00B166D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fDebugReportTime(IntPtr l)
	{
		int result;
		try
		{
			ServerListUIController serverListUIController = (ServerListUIController)LuaObject.checkSelf(l);
			float fDebugReportTime;
			LuaObject.checkType(l, 2, out fDebugReportTime);
			serverListUIController.m_luaExportHelper.m_fDebugReportTime = fDebugReportTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021055 RID: 135253 RVA: 0x00B18530 File Offset: 0x00B16730
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ServerListUIController");
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.SetServerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.ClearServerListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.RefreshServerArea);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.RefreshPlayerHead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.AddServerListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.LastLoginTimeDescription);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.OnCloseButtonClicked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.OnAreaClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.OnUIClosed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__callDele_EventOnClosed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.__clearDele_EventOnClosed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1B);
		string name = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1D, true);
		string name2 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_backgroundButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache1F, true);
		string name3 = "m_liServerListGroup";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_liServerListGroup);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_liServerListGroup);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache21, true);
		string name4 = "m_areaGroup";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_areaGroup);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_areaGroup);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache23, true);
		string name5 = "m_headGroup";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_headGroup);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_headGroup);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache25, true);
		string name6 = "m_noChar";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_noChar);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_noChar);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache27, true);
		string name7 = "m_serverListItemTemplate";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_serverListItemTemplate);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_serverListItemTemplate);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache29, true);
		string name8 = "m_headItemTemplate";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_headItemTemplate);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_headItemTemplate);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2B, true);
		string name9 = "m_areaItemTemplate";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_areaItemTemplate);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_areaItemTemplate);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2D, true);
		string name10 = "m_liServerNameText";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_liServerNameText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_liServerNameText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache2F, true);
		string name11 = "m_liNewServerIcon";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_liNewServerIcon);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_liNewServerIcon);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache31, true);
		string name12 = "m_liServerStateIcon";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_liServerStateIcon);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_liServerStateIcon);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache33, true);
		string name13 = "m_liServerCharIcon";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_liServerCharIcon);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_liServerCharIcon);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache35, true);
		string name14 = "m_liServerCharImage";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_liServerCharImage);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_liServerCharImage);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache37, true);
		string name15 = "m_liServerCharLevel";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_liServerCharLevel);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_liServerCharLevel);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache39, true);
		string name16 = "m_liMaitainServerIcon";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_liMaitainServerIcon);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_liMaitainServerIcon);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3B, true);
		string name17 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_configDataLoader);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3D, true);
		string name18 = "m_serverGroup";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_serverGroup);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_serverGroup);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache3F, true);
		string name19 = "m_servers";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_servers);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_servers);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache41, true);
		string name20 = "m_selectArea";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_selectArea);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_selectArea);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache43, true);
		string name21 = "EventOnClosed";
		LuaCSFunction get21 = null;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_EventOnClosed);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache44, true);
		string name22 = "m_selectServerID";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_selectServerID);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_selectServerID);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache46, true);
		string name23 = "m_existCharsInfo";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_existCharsInfo);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_existCharsInfo);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache48, true);
		string name24 = "m_roleListURL";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_roleListURL);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_roleListURL);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4A, true);
		string name25 = "m_fDebugReportTime";
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.get_m_fDebugReportTime);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ServerListUIController.set_m_fDebugReportTime);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ServerListUIController.<>f__mg$cache4C, true);
		LuaObject.createTypeMetatable(l, null, typeof(ServerListUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016F02 RID: 93954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016F03 RID: 93955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016F04 RID: 93956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016F05 RID: 93957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016F06 RID: 93958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016F07 RID: 93959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016F08 RID: 93960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016F09 RID: 93961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016F0A RID: 93962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016F0B RID: 93963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016F0C RID: 93964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016F0D RID: 93965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016F0E RID: 93966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016F0F RID: 93967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016F10 RID: 93968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016F11 RID: 93969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016F12 RID: 93970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016F13 RID: 93971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016F14 RID: 93972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016F15 RID: 93973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016F16 RID: 93974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016F17 RID: 93975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016F18 RID: 93976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016F19 RID: 93977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016F1A RID: 93978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016F1B RID: 93979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016F1C RID: 93980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016F1D RID: 93981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016F1E RID: 93982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016F1F RID: 93983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016F20 RID: 93984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016F21 RID: 93985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016F22 RID: 93986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016F23 RID: 93987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016F24 RID: 93988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016F25 RID: 93989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016F26 RID: 93990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016F27 RID: 93991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016F28 RID: 93992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016F29 RID: 93993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016F2A RID: 93994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016F2B RID: 93995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016F2C RID: 93996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016F2D RID: 93997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016F2E RID: 93998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016F2F RID: 93999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016F30 RID: 94000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016F31 RID: 94001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016F32 RID: 94002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016F33 RID: 94003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016F34 RID: 94004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016F35 RID: 94005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016F36 RID: 94006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016F37 RID: 94007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016F38 RID: 94008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016F39 RID: 94009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016F3A RID: 94010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016F3B RID: 94011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016F3C RID: 94012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016F3D RID: 94013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016F3E RID: 94014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016F3F RID: 94015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016F40 RID: 94016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016F41 RID: 94017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016F42 RID: 94018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016F43 RID: 94019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016F44 RID: 94020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04016F45 RID: 94021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04016F46 RID: 94022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04016F47 RID: 94023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04016F48 RID: 94024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04016F49 RID: 94025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04016F4A RID: 94026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04016F4B RID: 94027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04016F4C RID: 94028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04016F4D RID: 94029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04016F4E RID: 94030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;
}
