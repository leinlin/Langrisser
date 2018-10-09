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

// Token: 0x020014FB RID: 5371
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LoginUIController : LuaObject
{
	// Token: 0x0601FB64 RID: 129892 RVA: 0x00A725BC File Offset: 0x00A707BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetServerInfo(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LoginUITask.ServerInfo serverInfo;
			LuaObject.checkType<LoginUITask.ServerInfo>(l, 2, out serverInfo);
			loginUIController.SetServerInfo(serverInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB65 RID: 129893 RVA: 0x00A72614 File Offset: 0x00A70814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaitingNet(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			loginUIController.ShowWaitingNet(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB66 RID: 129894 RVA: 0x00A7266C File Offset: 0x00A7086C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStartAnimation(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.ShowStartAnimation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB67 RID: 129895 RVA: 0x00A726B8 File Offset: 0x00A708B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAccountName(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string accountName;
			LuaObject.checkType(l, 2, out accountName);
			loginUIController.SetAccountName(accountName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB68 RID: 129896 RVA: 0x00A72710 File Offset: 0x00A70910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnablePDSDKLoginMode(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			loginUIController.EnablePDSDKLoginMode(isEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB69 RID: 129897 RVA: 0x00A72768 File Offset: 0x00A70968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAccountName(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string accountName = loginUIController.GetAccountName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, accountName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB6A RID: 129898 RVA: 0x00A727BC File Offset: 0x00A709BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPassword(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string password;
			LuaObject.checkType(l, 2, out password);
			loginUIController.SetPassword(password);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB6B RID: 129899 RVA: 0x00A72814 File Offset: 0x00A70A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPassword(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string password = loginUIController.GetPassword();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, password);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB6C RID: 129900 RVA: 0x00A72868 File Offset: 0x00A70A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMessage(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int), typeof(bool)))
			{
				LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
				string text;
				LuaObject.checkType(l, 2, out text);
				int time;
				LuaObject.checkType(l, 3, out time);
				bool isOverride;
				LuaObject.checkType(l, 4, out isOverride);
				loginUIController.ShowMessage(text, time, isOverride);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(StringTableId), typeof(int), typeof(bool)))
			{
				LoginUIController loginUIController2 = (LoginUIController)LuaObject.checkSelf(l);
				StringTableId id;
				LuaObject.checkEnum<StringTableId>(l, 2, out id);
				int time2;
				LuaObject.checkType(l, 3, out time2);
				bool isOverride2;
				LuaObject.checkType(l, 4, out isOverride2);
				loginUIController2.ShowMessage(id, time2, isOverride2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowMessage to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB6D RID: 129901 RVA: 0x00A729A8 File Offset: 0x00A70BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetClientVersion(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string clientVersion;
			LuaObject.checkType(l, 2, out clientVersion);
			loginUIController.SetClientVersion(clientVersion);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB6E RID: 129902 RVA: 0x00A72A00 File Offset: 0x00A70C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideMessage(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.HideMessage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB6F RID: 129903 RVA: 0x00A72A4C File Offset: 0x00A70C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			loginUIController.ShowAnnouncePanel(isShow, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB70 RID: 129904 RVA: 0x00A72AB0 File Offset: 0x00A70CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnnounce(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string announce;
			LuaObject.checkType(l, 2, out announce);
			loginUIController.SetAnnounce(announce);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB71 RID: 129905 RVA: 0x00A72B08 File Offset: 0x00A70D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.Start();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB72 RID: 129906 RVA: 0x00A72B5C File Offset: 0x00A70D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnable(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnEnable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB73 RID: 129907 RVA: 0x00A72BB0 File Offset: 0x00A70DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB74 RID: 129908 RVA: 0x00A72C04 File Offset: 0x00A70E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAccountTextChanged(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			loginUIController.m_luaExportHelper.OnAccountTextChanged(text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB75 RID: 129909 RVA: 0x00A72C60 File Offset: 0x00A70E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB76 RID: 129910 RVA: 0x00A72CB4 File Offset: 0x00A70EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoginPCClientButtonClick(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnLoginPCClientButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB77 RID: 129911 RVA: 0x00A72D08 File Offset: 0x00A70F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOpenUserCenterButtonClick(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnOpenUserCenterButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB78 RID: 129912 RVA: 0x00A72D5C File Offset: 0x00A70F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectServerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnSelectServerButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB79 RID: 129913 RVA: 0x00A72DB0 File Offset: 0x00A70FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoginButtonClick(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnLoginButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB7A RID: 129914 RVA: 0x00A72E04 File Offset: 0x00A71004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSaveServerConfigClick(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnSaveServerConfigClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB7B RID: 129915 RVA: 0x00A72E58 File Offset: 0x00A71058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleFastEnterGame(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			loginUIController.m_luaExportHelper.OnToggleFastEnterGame(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB7C RID: 129916 RVA: 0x00A72EB4 File Offset: 0x00A710B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleTestFirstBattle(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			loginUIController.m_luaExportHelper.OnToggleTestFirstBattle(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB7D RID: 129917 RVA: 0x00A72F10 File Offset: 0x00A71110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOpenAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnOpenAnnouncePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB7E RID: 129918 RVA: 0x00A72F64 File Offset: 0x00A71164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnCloseAnnouncePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB7F RID: 129919 RVA: 0x00A72FB8 File Offset: 0x00A711B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowServerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.OnShowServerButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB80 RID: 129920 RVA: 0x00A7300C File Offset: 0x00A7120C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			loginUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB81 RID: 129921 RVA: 0x00A73078 File Offset: 0x00A71278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB82 RID: 129922 RVA: 0x00A730CC File Offset: 0x00A712CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB83 RID: 129923 RVA: 0x00A73120 File Offset: 0x00A71320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = loginUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FB84 RID: 129924 RVA: 0x00A731C8 File Offset: 0x00A713C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB85 RID: 129925 RVA: 0x00A7321C File Offset: 0x00A7141C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			loginUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB86 RID: 129926 RVA: 0x00A73288 File Offset: 0x00A71488
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
				LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				loginUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				LoginUIController loginUIController2 = (LoginUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				loginUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FB87 RID: 129927 RVA: 0x00A73398 File Offset: 0x00A71598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			loginUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB88 RID: 129928 RVA: 0x00A73404 File Offset: 0x00A71604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			loginUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB89 RID: 129929 RVA: 0x00A73470 File Offset: 0x00A71670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			loginUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB8A RID: 129930 RVA: 0x00A734DC File Offset: 0x00A716DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			loginUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB8B RID: 129931 RVA: 0x00A73548 File Offset: 0x00A71748
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
				LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				loginUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				LoginUIController loginUIController2 = (LoginUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				loginUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FB8C RID: 129932 RVA: 0x00A73658 File Offset: 0x00A71858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string s = loginUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FB8D RID: 129933 RVA: 0x00A736B4 File Offset: 0x00A718B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCloseAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callDele_EventOnCloseAnnouncePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB8E RID: 129934 RVA: 0x00A73708 File Offset: 0x00A71908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCloseAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__clearDele_EventOnCloseAnnouncePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB8F RID: 129935 RVA: 0x00A7375C File Offset: 0x00A7195C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnOpenAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callDele_EventOnOpenAnnouncePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB90 RID: 129936 RVA: 0x00A737B0 File Offset: 0x00A719B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnOpenAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__clearDele_EventOnOpenAnnouncePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB91 RID: 129937 RVA: 0x00A73804 File Offset: 0x00A71A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callDele_EventOnLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB92 RID: 129938 RVA: 0x00A73858 File Offset: 0x00A71A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__clearDele_EventOnLogin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB93 RID: 129939 RVA: 0x00A738AC File Offset: 0x00A71AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSaveServerConfig(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callDele_EventOnSaveServerConfig();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB94 RID: 129940 RVA: 0x00A73900 File Offset: 0x00A71B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSaveServerConfig(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__clearDele_EventOnSaveServerConfig();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB95 RID: 129941 RVA: 0x00A73954 File Offset: 0x00A71B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventSelectServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callDele_EventSelectServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB96 RID: 129942 RVA: 0x00A739A8 File Offset: 0x00A71BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventSelectServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__clearDele_EventSelectServer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB97 RID: 129943 RVA: 0x00A739FC File Offset: 0x00A71BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOpenUserCenter(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callDele_EventOpenUserCenter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB98 RID: 129944 RVA: 0x00A73A50 File Offset: 0x00A71C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOpenUserCenter(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__clearDele_EventOpenUserCenter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB99 RID: 129945 RVA: 0x00A73AA4 File Offset: 0x00A71CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventLoginPCClient(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__callDele_EventLoginPCClient();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB9A RID: 129946 RVA: 0x00A73AF8 File Offset: 0x00A71CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventLoginPCClient(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			loginUIController.m_luaExportHelper.__clearDele_EventLoginPCClient();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB9B RID: 129947 RVA: 0x00A73B4C File Offset: 0x00A71D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventAccountTextChanged(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			loginUIController.m_luaExportHelper.__callDele_EventAccountTextChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB9C RID: 129948 RVA: 0x00A73BA8 File Offset: 0x00A71DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventAccountTextChanged(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			loginUIController.m_luaExportHelper.__clearDele_EventAccountTextChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB9D RID: 129949 RVA: 0x00A73C04 File Offset: 0x00A71E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCloseAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					loginUIController.EventOnCloseAnnouncePanel += value;
				}
				else if (num == 2)
				{
					loginUIController.EventOnCloseAnnouncePanel -= value;
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

	// Token: 0x0601FB9E RID: 129950 RVA: 0x00A73C84 File Offset: 0x00A71E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnOpenAnnouncePanel(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					loginUIController.EventOnOpenAnnouncePanel += value;
				}
				else if (num == 2)
				{
					loginUIController.EventOnOpenAnnouncePanel -= value;
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

	// Token: 0x0601FB9F RID: 129951 RVA: 0x00A73D04 File Offset: 0x00A71F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLogin(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					loginUIController.EventOnLogin += value;
				}
				else if (num == 2)
				{
					loginUIController.EventOnLogin -= value;
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

	// Token: 0x0601FBA0 RID: 129952 RVA: 0x00A73D84 File Offset: 0x00A71F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSaveServerConfig(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					loginUIController.EventOnSaveServerConfig += value;
				}
				else if (num == 2)
				{
					loginUIController.EventOnSaveServerConfig -= value;
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

	// Token: 0x0601FBA1 RID: 129953 RVA: 0x00A73E04 File Offset: 0x00A72004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventSelectServer(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					loginUIController.EventSelectServer += value;
				}
				else if (num == 2)
				{
					loginUIController.EventSelectServer -= value;
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

	// Token: 0x0601FBA2 RID: 129954 RVA: 0x00A73E84 File Offset: 0x00A72084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOpenUserCenter(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					loginUIController.EventOpenUserCenter += value;
				}
				else if (num == 2)
				{
					loginUIController.EventOpenUserCenter -= value;
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

	// Token: 0x0601FBA3 RID: 129955 RVA: 0x00A73F04 File Offset: 0x00A72104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventLoginPCClient(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					loginUIController.EventLoginPCClient += value;
				}
				else if (num == 2)
				{
					loginUIController.EventLoginPCClient -= value;
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

	// Token: 0x0601FBA4 RID: 129956 RVA: 0x00A73F84 File Offset: 0x00A72184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventAccountTextChanged(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					loginUIController.EventAccountTextChanged += value;
				}
				else if (num == 2)
				{
					loginUIController.EventAccountTextChanged -= value;
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

	// Token: 0x0601FBA5 RID: 129957 RVA: 0x00A74004 File Offset: 0x00A72204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBA6 RID: 129958 RVA: 0x00A7405C File Offset: 0x00A7225C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			loginUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBA7 RID: 129959 RVA: 0x00A740B8 File Offset: 0x00A722B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announcePanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_announcePanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBA8 RID: 129960 RVA: 0x00A74110 File Offset: 0x00A72310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announcePanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			CommonUIStateController announcePanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out announcePanelUIStateController);
			loginUIController.m_luaExportHelper.m_announcePanelUIStateController = announcePanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBA9 RID: 129961 RVA: 0x00A7416C File Offset: 0x00A7236C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeAnnounceButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_closeAnnounceButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBAA RID: 129962 RVA: 0x00A741C4 File Offset: 0x00A723C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeAnnounceButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button closeAnnounceButton;
			LuaObject.checkType<Button>(l, 2, out closeAnnounceButton);
			loginUIController.m_luaExportHelper.m_closeAnnounceButton = closeAnnounceButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBAB RID: 129963 RVA: 0x00A74220 File Offset: 0x00A72420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announceBGButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_announceBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBAC RID: 129964 RVA: 0x00A74278 File Offset: 0x00A72478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announceBGButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button announceBGButton;
			LuaObject.checkType<Button>(l, 2, out announceBGButton);
			loginUIController.m_luaExportHelper.m_announceBGButton = announceBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBAD RID: 129965 RVA: 0x00A742D4 File Offset: 0x00A724D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announceListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_announceListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBAE RID: 129966 RVA: 0x00A7432C File Offset: 0x00A7252C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announceListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			ScrollRect announceListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out announceListScrollRect);
			loginUIController.m_luaExportHelper.m_announceListScrollRect = announceListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBAF RID: 129967 RVA: 0x00A74388 File Offset: 0x00A72588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announceListContent(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_announceListContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB0 RID: 129968 RVA: 0x00A743E0 File Offset: 0x00A725E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announceListContent(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject announceListContent;
			LuaObject.checkType<GameObject>(l, 2, out announceListContent);
			loginUIController.m_luaExportHelper.m_announceListContent = announceListContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB1 RID: 129969 RVA: 0x00A7443C File Offset: 0x00A7263C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announceListPointItem(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_announceListPointItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB2 RID: 129970 RVA: 0x00A74494 File Offset: 0x00A72694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announceListPointItem(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject announceListPointItem;
			LuaObject.checkType<GameObject>(l, 2, out announceListPointItem);
			loginUIController.m_luaExportHelper.m_announceListPointItem = announceListPointItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB3 RID: 129971 RVA: 0x00A744F0 File Offset: 0x00A726F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announceListPointBGContent(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_announceListPointBGContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB4 RID: 129972 RVA: 0x00A74548 File Offset: 0x00A72748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announceListPointBGContent(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject announceListPointBGContent;
			LuaObject.checkType<GameObject>(l, 2, out announceListPointBGContent);
			loginUIController.m_luaExportHelper.m_announceListPointBGContent = announceListPointBGContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB5 RID: 129973 RVA: 0x00A745A4 File Offset: 0x00A727A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggleItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_toggleItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB6 RID: 129974 RVA: 0x00A745FC File Offset: 0x00A727FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject toggleItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out toggleItemPrefab);
			loginUIController.m_luaExportHelper.m_toggleItemPrefab = toggleItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB7 RID: 129975 RVA: 0x00A74658 File Offset: 0x00A72858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityNameText(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_activityNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB8 RID: 129976 RVA: 0x00A746B0 File Offset: 0x00A728B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityNameText(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Text activityNameText;
			LuaObject.checkType<Text>(l, 2, out activityNameText);
			loginUIController.m_luaExportHelper.m_activityNameText = activityNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBB9 RID: 129977 RVA: 0x00A7470C File Offset: 0x00A7290C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tabLogo(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_tabLogo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBBA RID: 129978 RVA: 0x00A74764 File Offset: 0x00A72964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tabLogo(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Image tabLogo;
			LuaObject.checkType<Image>(l, 2, out tabLogo);
			loginUIController.m_luaExportHelper.m_tabLogo = tabLogo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBBB RID: 129979 RVA: 0x00A747C0 File Offset: 0x00A729C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announceContentText(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_announceContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBBC RID: 129980 RVA: 0x00A74818 File Offset: 0x00A72A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announceContentText(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Text announceContentText;
			LuaObject.checkType<Text>(l, 2, out announceContentText);
			loginUIController.m_luaExportHelper.m_announceContentText = announceContentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBBD RID: 129981 RVA: 0x00A74874 File Offset: 0x00A72A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailScrollView(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_detailScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBBE RID: 129982 RVA: 0x00A748CC File Offset: 0x00A72ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailScrollView(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject detailScrollView;
			LuaObject.checkType<GameObject>(l, 2, out detailScrollView);
			loginUIController.m_luaExportHelper.m_detailScrollView = detailScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBBF RID: 129983 RVA: 0x00A74928 File Offset: 0x00A72B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openAnnounceButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_openAnnounceButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC0 RID: 129984 RVA: 0x00A74980 File Offset: 0x00A72B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openAnnounceButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button openAnnounceButton;
			LuaObject.checkType<Button>(l, 2, out openAnnounceButton);
			loginUIController.m_luaExportHelper.m_openAnnounceButton = openAnnounceButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC1 RID: 129985 RVA: 0x00A749DC File Offset: 0x00A72BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_serverGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC2 RID: 129986 RVA: 0x00A74A34 File Offset: 0x00A72C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject serverGameObject;
			LuaObject.checkType<GameObject>(l, 2, out serverGameObject);
			loginUIController.m_luaExportHelper.m_serverGameObject = serverGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC3 RID: 129987 RVA: 0x00A74A90 File Offset: 0x00A72C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastEnterGameToggle(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_fastEnterGameToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC4 RID: 129988 RVA: 0x00A74AE8 File Offset: 0x00A72CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastEnterGameToggle(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Toggle fastEnterGameToggle;
			LuaObject.checkType<Toggle>(l, 2, out fastEnterGameToggle);
			loginUIController.m_luaExportHelper.m_fastEnterGameToggle = fastEnterGameToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC5 RID: 129989 RVA: 0x00A74B44 File Offset: 0x00A72D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testFirstBattleToggle(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_testFirstBattleToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC6 RID: 129990 RVA: 0x00A74B9C File Offset: 0x00A72D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testFirstBattleToggle(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Toggle testFirstBattleToggle;
			LuaObject.checkType<Toggle>(l, 2, out testFirstBattleToggle);
			loginUIController.m_luaExportHelper.m_testFirstBattleToggle = testFirstBattleToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC7 RID: 129991 RVA: 0x00A74BF8 File Offset: 0x00A72DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_saveServerConfigButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_saveServerConfigButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC8 RID: 129992 RVA: 0x00A74C50 File Offset: 0x00A72E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_saveServerConfigButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button saveServerConfigButton;
			LuaObject.checkType<Button>(l, 2, out saveServerConfigButton);
			loginUIController.m_luaExportHelper.m_saveServerConfigButton = saveServerConfigButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBC9 RID: 129993 RVA: 0x00A74CAC File Offset: 0x00A72EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showServerButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_showServerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBCA RID: 129994 RVA: 0x00A74D04 File Offset: 0x00A72F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showServerButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button showServerButton;
			LuaObject.checkType<Button>(l, 2, out showServerButton);
			loginUIController.m_luaExportHelper.m_showServerButton = showServerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBCB RID: 129995 RVA: 0x00A74D60 File Offset: 0x00A72F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_accountInputField(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_accountInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBCC RID: 129996 RVA: 0x00A74DB8 File Offset: 0x00A72FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_accountInputField(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			InputField accountInputField;
			LuaObject.checkType<InputField>(l, 2, out accountInputField);
			loginUIController.m_luaExportHelper.m_accountInputField = accountInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBCD RID: 129997 RVA: 0x00A74E14 File Offset: 0x00A73014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passwordInputField(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_passwordInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBCE RID: 129998 RVA: 0x00A74E6C File Offset: 0x00A7306C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passwordInputField(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			InputField passwordInputField;
			LuaObject.checkType<InputField>(l, 2, out passwordInputField);
			loginUIController.m_luaExportHelper.m_passwordInputField = passwordInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBCF RID: 129999 RVA: 0x00A74EC8 File Offset: 0x00A730C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loginButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_loginButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD0 RID: 130000 RVA: 0x00A74F20 File Offset: 0x00A73120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loginButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button loginButton;
			LuaObject.checkType<Button>(l, 2, out loginButton);
			loginUIController.m_luaExportHelper.m_loginButton = loginButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD1 RID: 130001 RVA: 0x00A74F7C File Offset: 0x00A7317C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sdkLoginButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_sdkLoginButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD2 RID: 130002 RVA: 0x00A74FD4 File Offset: 0x00A731D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sdkLoginButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button sdkLoginButton;
			LuaObject.checkType<Button>(l, 2, out sdkLoginButton);
			loginUIController.m_luaExportHelper.m_sdkLoginButton = sdkLoginButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD3 RID: 130003 RVA: 0x00A75030 File Offset: 0x00A73230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_messageGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD4 RID: 130004 RVA: 0x00A75088 File Offset: 0x00A73288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject messageGameObject;
			LuaObject.checkType<GameObject>(l, 2, out messageGameObject);
			loginUIController.m_luaExportHelper.m_messageGameObject = messageGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD5 RID: 130005 RVA: 0x00A750E4 File Offset: 0x00A732E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_accountGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_accountGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD6 RID: 130006 RVA: 0x00A7513C File Offset: 0x00A7333C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_accountGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject accountGameObject;
			LuaObject.checkType<GameObject>(l, 2, out accountGameObject);
			loginUIController.m_luaExportHelper.m_accountGameObject = accountGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD7 RID: 130007 RVA: 0x00A75198 File Offset: 0x00A73398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passwordGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_passwordGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD8 RID: 130008 RVA: 0x00A751F0 File Offset: 0x00A733F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passwordGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			GameObject passwordGameObject;
			LuaObject.checkType<GameObject>(l, 2, out passwordGameObject);
			loginUIController.m_luaExportHelper.m_passwordGameObject = passwordGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBD9 RID: 130009 RVA: 0x00A7524C File Offset: 0x00A7344C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectServerButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_selectServerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBDA RID: 130010 RVA: 0x00A752A4 File Offset: 0x00A734A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectServerButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button selectServerButton;
			LuaObject.checkType<Button>(l, 2, out selectServerButton);
			loginUIController.m_luaExportHelper.m_selectServerButton = selectServerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBDB RID: 130011 RVA: 0x00A75300 File Offset: 0x00A73500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectServerName(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_selectServerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBDC RID: 130012 RVA: 0x00A75358 File Offset: 0x00A73558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectServerName(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Text selectServerName;
			LuaObject.checkType<Text>(l, 2, out selectServerName);
			loginUIController.m_luaExportHelper.m_selectServerName = selectServerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBDD RID: 130013 RVA: 0x00A753B4 File Offset: 0x00A735B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageText(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_messageText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBDE RID: 130014 RVA: 0x00A7540C File Offset: 0x00A7360C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageText(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Text messageText;
			LuaObject.checkType<Text>(l, 2, out messageText);
			loginUIController.m_luaExportHelper.m_messageText = messageText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBDF RID: 130015 RVA: 0x00A75468 File Offset: 0x00A73668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientVersionText(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_clientVersionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE0 RID: 130016 RVA: 0x00A754C0 File Offset: 0x00A736C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientVersionText(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Text clientVersionText;
			LuaObject.checkType<Text>(l, 2, out clientVersionText);
			loginUIController.m_luaExportHelper.m_clientVersionText = clientVersionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE1 RID: 130017 RVA: 0x00A7551C File Offset: 0x00A7371C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_switchUserButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_switchUserButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE2 RID: 130018 RVA: 0x00A75574 File Offset: 0x00A73774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_switchUserButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button switchUserButton;
			LuaObject.checkType<Button>(l, 2, out switchUserButton);
			loginUIController.m_luaExportHelper.m_switchUserButton = switchUserButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE3 RID: 130019 RVA: 0x00A755D0 File Offset: 0x00A737D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loginPCClientButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_loginPCClientButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE4 RID: 130020 RVA: 0x00A75628 File Offset: 0x00A73828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loginPCClientButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			Button loginPCClientButton;
			LuaObject.checkType<Button>(l, 2, out loginPCClientButton);
			loginUIController.m_luaExportHelper.m_loginPCClientButton = loginPCClientButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE5 RID: 130021 RVA: 0x00A75684 File Offset: 0x00A73884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_logoAnimController(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_logoAnimController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE6 RID: 130022 RVA: 0x00A756DC File Offset: 0x00A738DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_logoAnimController(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			CommonUIStateController logoAnimController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out logoAnimController);
			loginUIController.m_luaExportHelper.m_logoAnimController = logoAnimController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE7 RID: 130023 RVA: 0x00A75738 File Offset: 0x00A73938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_swordAnimController(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_swordAnimController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE8 RID: 130024 RVA: 0x00A75790 File Offset: 0x00A73990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_swordAnimController(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			CommonUIStateController swordAnimController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out swordAnimController);
			loginUIController.m_luaExportHelper.m_swordAnimController = swordAnimController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBE9 RID: 130025 RVA: 0x00A757EC File Offset: 0x00A739EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hideMessageTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_hideMessageTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBEA RID: 130026 RVA: 0x00A75844 File Offset: 0x00A73A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hideMessageTime(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			float hideMessageTime;
			LuaObject.checkType(l, 2, out hideMessageTime);
			loginUIController.m_luaExportHelper.m_hideMessageTime = hideMessageTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBEB RID: 130027 RVA: 0x00A758A0 File Offset: 0x00A73AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showServerButtonClickCount(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_showServerButtonClickCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBEC RID: 130028 RVA: 0x00A758F8 File Offset: 0x00A73AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showServerButtonClickCount(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			int showServerButtonClickCount;
			LuaObject.checkType(l, 2, out showServerButtonClickCount);
			loginUIController.m_luaExportHelper.m_showServerButtonClickCount = showServerButtonClickCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBED RID: 130029 RVA: 0x00A75954 File Offset: 0x00A73B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_networkWatingStateController(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_networkWatingStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBEE RID: 130030 RVA: 0x00A759AC File Offset: 0x00A73BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_networkWatingStateController(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			CommonUIStateController networkWatingStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out networkWatingStateController);
			loginUIController.m_luaExportHelper.m_networkWatingStateController = networkWatingStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBEF RID: 130031 RVA: 0x00A75A08 File Offset: 0x00A73C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isStartAnimShowed(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.m_luaExportHelper.m_isStartAnimShowed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF0 RID: 130032 RVA: 0x00A75A60 File Offset: 0x00A73C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isStartAnimShowed(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			bool isStartAnimShowed;
			LuaObject.checkType(l, 2, out isStartAnimShowed);
			loginUIController.m_luaExportHelper.m_isStartAnimShowed = isStartAnimShowed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF1 RID: 130033 RVA: 0x00A75ABC File Offset: 0x00A73CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_accountName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUIController.m_accountName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF2 RID: 130034 RVA: 0x00A75B04 File Offset: 0x00A73D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_accountName(IntPtr l)
	{
		int result;
		try
		{
			string accountName;
			LuaObject.checkType(l, 2, out accountName);
			LoginUIController.m_accountName = accountName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF3 RID: 130035 RVA: 0x00A75B50 File Offset: 0x00A73D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsLoginButtonClicked(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginUIController.IsLoginButtonClicked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF4 RID: 130036 RVA: 0x00A75BA4 File Offset: 0x00A73DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsLoginButtonClicked(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			bool isLoginButtonClicked;
			LuaObject.checkType(l, 2, out isLoginButtonClicked);
			loginUIController.IsLoginButtonClicked = isLoginButtonClicked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF5 RID: 130037 RVA: 0x00A75BFC File Offset: 0x00A73DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnableLoginPCClientButton(IntPtr l)
	{
		int result;
		try
		{
			LoginUIController loginUIController = (LoginUIController)LuaObject.checkSelf(l);
			bool enableLoginPCClientButton;
			LuaObject.checkType(l, 2, out enableLoginPCClientButton);
			loginUIController.EnableLoginPCClientButton = enableLoginPCClientButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF6 RID: 130038 RVA: 0x00A75C54 File Offset: 0x00A73E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsTestFirstBattle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LoginUIController.IsTestFirstBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF7 RID: 130039 RVA: 0x00A75C9C File Offset: 0x00A73E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsTestFirstBattle(IntPtr l)
	{
		int result;
		try
		{
			bool isTestFirstBattle;
			LuaObject.checkType(l, 2, out isTestFirstBattle);
			LoginUIController.LuaExportHelper.IsTestFirstBattle = isTestFirstBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FBF8 RID: 130040 RVA: 0x00A75CE8 File Offset: 0x00A73EE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LoginUIController");
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.SetServerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.ShowWaitingNet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.ShowStartAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.SetAccountName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.EnablePDSDKLoginMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.GetAccountName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.SetPassword);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.GetPassword);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.ShowMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.SetClientVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.HideMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.ShowAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.SetAnnounce);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnEnable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnAccountTextChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnLoginPCClientButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnOpenUserCenterButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnSelectServerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnLoginButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnSaveServerConfigClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnToggleFastEnterGame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnToggleTestFirstBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnOpenAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnCloseAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.OnShowServerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callDele_EventOnCloseAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__clearDele_EventOnCloseAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callDele_EventOnOpenAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__clearDele_EventOnOpenAnnouncePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callDele_EventOnLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__clearDele_EventOnLogin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callDele_EventOnSaveServerConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__clearDele_EventOnSaveServerConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callDele_EventSelectServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__clearDele_EventSelectServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callDele_EventOpenUserCenter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__clearDele_EventOpenUserCenter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callDele_EventLoginPCClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__clearDele_EventLoginPCClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__callDele_EventAccountTextChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.__clearDele_EventAccountTextChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache38);
		string name = "EventOnCloseAnnouncePanel";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EventOnCloseAnnouncePanel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache39, true);
		string name2 = "EventOnOpenAnnouncePanel";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EventOnOpenAnnouncePanel);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3A, true);
		string name3 = "EventOnLogin";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EventOnLogin);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3B, true);
		string name4 = "EventOnSaveServerConfig";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EventOnSaveServerConfig);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3C, true);
		string name5 = "EventSelectServer";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EventSelectServer);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3D, true);
		string name6 = "EventOpenUserCenter";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EventOpenUserCenter);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3E, true);
		string name7 = "EventLoginPCClient";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EventLoginPCClient);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache3F, true);
		string name8 = "EventAccountTextChanged";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EventAccountTextChanged);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache40, true);
		string name9 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_marginTransform);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache42, true);
		string name10 = "m_announcePanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_announcePanelUIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_announcePanelUIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache44, true);
		string name11 = "m_closeAnnounceButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_closeAnnounceButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_closeAnnounceButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache46, true);
		string name12 = "m_announceBGButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_announceBGButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_announceBGButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache48, true);
		string name13 = "m_announceListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_announceListScrollRect);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_announceListScrollRect);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4A, true);
		string name14 = "m_announceListContent";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_announceListContent);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_announceListContent);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4C, true);
		string name15 = "m_announceListPointItem";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_announceListPointItem);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_announceListPointItem);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4E, true);
		string name16 = "m_announceListPointBGContent";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_announceListPointBGContent);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_announceListPointBGContent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache50, true);
		string name17 = "m_toggleItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_toggleItemPrefab);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_toggleItemPrefab);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache52, true);
		string name18 = "m_activityNameText";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_activityNameText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_activityNameText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache54, true);
		string name19 = "m_tabLogo";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_tabLogo);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_tabLogo);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache56, true);
		string name20 = "m_announceContentText";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_announceContentText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_announceContentText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache58, true);
		string name21 = "m_detailScrollView";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_detailScrollView);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_detailScrollView);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5A, true);
		string name22 = "m_openAnnounceButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_openAnnounceButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_openAnnounceButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5C, true);
		string name23 = "m_serverGameObject";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_serverGameObject);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_serverGameObject);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5E, true);
		string name24 = "m_fastEnterGameToggle";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_fastEnterGameToggle);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_fastEnterGameToggle);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache60, true);
		string name25 = "m_testFirstBattleToggle";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_testFirstBattleToggle);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_testFirstBattleToggle);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache62, true);
		string name26 = "m_saveServerConfigButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_saveServerConfigButton);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_saveServerConfigButton);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache64, true);
		string name27 = "m_showServerButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_showServerButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_showServerButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache66, true);
		string name28 = "m_accountInputField";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_accountInputField);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_accountInputField);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache68, true);
		string name29 = "m_passwordInputField";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_passwordInputField);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_passwordInputField);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6A, true);
		string name30 = "m_loginButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_loginButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_loginButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6C, true);
		string name31 = "m_sdkLoginButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_sdkLoginButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_sdkLoginButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6E, true);
		string name32 = "m_messageGameObject";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_messageGameObject);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_messageGameObject);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache70, true);
		string name33 = "m_accountGameObject";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_accountGameObject);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_accountGameObject);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache72, true);
		string name34 = "m_passwordGameObject";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_passwordGameObject);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_passwordGameObject);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache74, true);
		string name35 = "m_selectServerButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_selectServerButton);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_selectServerButton);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache76, true);
		string name36 = "m_selectServerName";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_selectServerName);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_selectServerName);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache78, true);
		string name37 = "m_messageText";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_messageText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_messageText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7A, true);
		string name38 = "m_clientVersionText";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_clientVersionText);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_clientVersionText);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7C, true);
		string name39 = "m_switchUserButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_switchUserButton);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_switchUserButton);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7E, true);
		string name40 = "m_loginPCClientButton";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_loginPCClientButton);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_loginPCClientButton);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache80, true);
		string name41 = "m_logoAnimController";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_logoAnimController);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_logoAnimController);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache82, true);
		string name42 = "m_swordAnimController";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_swordAnimController);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_swordAnimController);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache84, true);
		string name43 = "m_hideMessageTime";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_hideMessageTime);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_hideMessageTime);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache86, true);
		string name44 = "m_showServerButtonClickCount";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_showServerButtonClickCount);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_showServerButtonClickCount);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache88, true);
		string name45 = "m_networkWatingStateController";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_networkWatingStateController);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_networkWatingStateController);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8A, true);
		string name46 = "m_isStartAnimShowed";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_isStartAnimShowed);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_isStartAnimShowed);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8C, true);
		string name47 = "m_accountName";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_m_accountName);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_m_accountName);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8E, false);
		string name48 = "IsLoginButtonClicked";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_IsLoginButtonClicked);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_IsLoginButtonClicked);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache90, true);
		string name49 = "EnableLoginPCClientButton";
		LuaCSFunction get49 = null;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_EnableLoginPCClientButton);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache91, true);
		string name50 = "IsTestFirstBattle";
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.get_IsTestFirstBattle);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginUIController.set_IsTestFirstBattle);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_LoginUIController.<>f__mg$cache93, false);
		LuaObject.createTypeMetatable(l, null, typeof(LoginUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015B50 RID: 88912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015B51 RID: 88913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015B52 RID: 88914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015B53 RID: 88915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015B54 RID: 88916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015B55 RID: 88917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015B56 RID: 88918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015B57 RID: 88919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015B58 RID: 88920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015B59 RID: 88921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015B5A RID: 88922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015B5B RID: 88923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015B5C RID: 88924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015B5D RID: 88925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015B5E RID: 88926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015B5F RID: 88927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015B60 RID: 88928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015B61 RID: 88929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015B62 RID: 88930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015B63 RID: 88931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015B64 RID: 88932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015B65 RID: 88933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015B66 RID: 88934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015B67 RID: 88935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015B68 RID: 88936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015B69 RID: 88937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015B6A RID: 88938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015B6B RID: 88939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015B6C RID: 88940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015B6D RID: 88941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015B6E RID: 88942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015B6F RID: 88943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015B70 RID: 88944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015B71 RID: 88945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015B72 RID: 88946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015B73 RID: 88947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015B74 RID: 88948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015B75 RID: 88949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015B76 RID: 88950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015B77 RID: 88951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015B78 RID: 88952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015B79 RID: 88953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015B7A RID: 88954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015B7B RID: 88955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015B7C RID: 88956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015B7D RID: 88957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015B7E RID: 88958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015B7F RID: 88959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015B80 RID: 88960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015B81 RID: 88961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015B82 RID: 88962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015B83 RID: 88963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015B84 RID: 88964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015B85 RID: 88965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015B86 RID: 88966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015B87 RID: 88967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015B88 RID: 88968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015B89 RID: 88969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015B8A RID: 88970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015B8B RID: 88971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015B8C RID: 88972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015B8D RID: 88973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015B8E RID: 88974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015B8F RID: 88975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015B90 RID: 88976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015B91 RID: 88977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015B92 RID: 88978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015B93 RID: 88979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015B94 RID: 88980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04015B95 RID: 88981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04015B96 RID: 88982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04015B97 RID: 88983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04015B98 RID: 88984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04015B99 RID: 88985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04015B9A RID: 88986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04015B9B RID: 88987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04015B9C RID: 88988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04015B9D RID: 88989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04015B9E RID: 88990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04015B9F RID: 88991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04015BA0 RID: 88992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04015BA1 RID: 88993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04015BA2 RID: 88994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04015BA3 RID: 88995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04015BA4 RID: 88996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04015BA5 RID: 88997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04015BA6 RID: 88998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04015BA7 RID: 88999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04015BA8 RID: 89000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04015BA9 RID: 89001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04015BAA RID: 89002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04015BAB RID: 89003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04015BAC RID: 89004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04015BAD RID: 89005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04015BAE RID: 89006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04015BAF RID: 89007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04015BB0 RID: 89008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04015BB1 RID: 89009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04015BB2 RID: 89010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04015BB3 RID: 89011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04015BB4 RID: 89012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04015BB5 RID: 89013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04015BB6 RID: 89014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04015BB7 RID: 89015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04015BB8 RID: 89016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04015BB9 RID: 89017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04015BBA RID: 89018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04015BBB RID: 89019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04015BBC RID: 89020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04015BBD RID: 89021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04015BBE RID: 89022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04015BBF RID: 89023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04015BC0 RID: 89024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04015BC1 RID: 89025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04015BC2 RID: 89026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04015BC3 RID: 89027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04015BC4 RID: 89028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04015BC5 RID: 89029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04015BC6 RID: 89030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04015BC7 RID: 89031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04015BC8 RID: 89032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04015BC9 RID: 89033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04015BCA RID: 89034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04015BCB RID: 89035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04015BCC RID: 89036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04015BCD RID: 89037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04015BCE RID: 89038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04015BCF RID: 89039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04015BD0 RID: 89040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04015BD1 RID: 89041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04015BD2 RID: 89042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04015BD3 RID: 89043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04015BD4 RID: 89044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04015BD5 RID: 89045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04015BD6 RID: 89046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04015BD7 RID: 89047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04015BD8 RID: 89048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04015BD9 RID: 89049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04015BDA RID: 89050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04015BDB RID: 89051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04015BDC RID: 89052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04015BDD RID: 89053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04015BDE RID: 89054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04015BDF RID: 89055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04015BE0 RID: 89056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04015BE1 RID: 89057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04015BE2 RID: 89058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04015BE3 RID: 89059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;
}
