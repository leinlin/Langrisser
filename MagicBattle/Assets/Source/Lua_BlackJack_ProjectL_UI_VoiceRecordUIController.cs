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

// Token: 0x020015DD RID: 5597
[Preserve]
public class Lua_BlackJack_ProjectL_UI_VoiceRecordUIController : LuaObject
{
	// Token: 0x060222C9 RID: 139977 RVA: 0x00BAB5C0 File Offset: 0x00BA97C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowVoiceRecordTip(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			voiceRecordUIController.ShowVoiceRecordTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222CA RID: 139978 RVA: 0x00BAB60C File Offset: 0x00BA980C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HideVoiceRecordTip(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			voiceRecordUIController.HideVoiceRecordTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222CB RID: 139979 RVA: 0x00BAB658 File Offset: 0x00BA9858
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowVoiceCancelTip(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			voiceRecordUIController.ShowVoiceCancelTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222CC RID: 139980 RVA: 0x00BAB6A4 File Offset: 0x00BA98A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowVoiceShortTip(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			voiceRecordUIController.ShowVoiceShortTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222CD RID: 139981 RVA: 0x00BAB6F0 File Offset: 0x00BA98F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateVoiceRecordTime(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			voiceRecordUIController.UpdateVoiceRecordTime(time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222CE RID: 139982 RVA: 0x00BAB748 File Offset: 0x00BA9948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			voiceRecordUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222CF RID: 139983 RVA: 0x00BAB79C File Offset: 0x00BA999C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			voiceRecordUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222D0 RID: 139984 RVA: 0x00BAB808 File Offset: 0x00BA9A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			voiceRecordUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222D1 RID: 139985 RVA: 0x00BAB85C File Offset: 0x00BA9A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			voiceRecordUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222D2 RID: 139986 RVA: 0x00BAB8B0 File Offset: 0x00BA9AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = voiceRecordUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060222D3 RID: 139987 RVA: 0x00BAB958 File Offset: 0x00BA9B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			voiceRecordUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222D4 RID: 139988 RVA: 0x00BAB9AC File Offset: 0x00BA9BAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			voiceRecordUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222D5 RID: 139989 RVA: 0x00BABA18 File Offset: 0x00BA9C18
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
				VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				voiceRecordUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				VoiceRecordUIController voiceRecordUIController2 = (VoiceRecordUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				voiceRecordUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060222D6 RID: 139990 RVA: 0x00BABB28 File Offset: 0x00BA9D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			voiceRecordUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222D7 RID: 139991 RVA: 0x00BABB94 File Offset: 0x00BA9D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			voiceRecordUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222D8 RID: 139992 RVA: 0x00BABC00 File Offset: 0x00BA9E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			voiceRecordUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222D9 RID: 139993 RVA: 0x00BABC6C File Offset: 0x00BA9E6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			voiceRecordUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222DA RID: 139994 RVA: 0x00BABCD8 File Offset: 0x00BA9ED8
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
				VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				voiceRecordUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				VoiceRecordUIController voiceRecordUIController2 = (VoiceRecordUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				voiceRecordUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060222DB RID: 139995 RVA: 0x00BABDE8 File Offset: 0x00BA9FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			string s = voiceRecordUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060222DC RID: 139996 RVA: 0x00BABE44 File Offset: 0x00BAA044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_voiceTimeText(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUIController.voiceTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222DD RID: 139997 RVA: 0x00BABE98 File Offset: 0x00BAA098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_voiceTimeText(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			Text voiceTimeText;
			LuaObject.checkType<Text>(l, 2, out voiceTimeText);
			voiceRecordUIController.voiceTimeText = voiceTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222DE RID: 139998 RVA: 0x00BABEF0 File Offset: 0x00BAA0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_voiceRecordStateUICtrl(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUIController.voiceRecordStateUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222DF RID: 139999 RVA: 0x00BABF44 File Offset: 0x00BAA144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_voiceRecordStateUICtrl(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			CommonUIStateController voiceRecordStateUICtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out voiceRecordStateUICtrl);
			voiceRecordUIController.voiceRecordStateUICtrl = voiceRecordStateUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222E0 RID: 140000 RVA: 0x00BABF9C File Offset: 0x00BAA19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_recordTimeProgressBar(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUIController.recordTimeProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222E1 RID: 140001 RVA: 0x00BABFF0 File Offset: 0x00BAA1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_recordTimeProgressBar(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			Image recordTimeProgressBar;
			LuaObject.checkType<Image>(l, 2, out recordTimeProgressBar);
			voiceRecordUIController.recordTimeProgressBar = recordTimeProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222E2 RID: 140002 RVA: 0x00BAC048 File Offset: 0x00BAA248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222E3 RID: 140003 RVA: 0x00BAC0A0 File Offset: 0x00BAA2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUIController voiceRecordUIController = (VoiceRecordUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			voiceRecordUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222E4 RID: 140004 RVA: 0x00BAC0FC File Offset: 0x00BAA2FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.VoiceRecordUIController");
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.ShowVoiceRecordTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.HideVoiceRecordTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.ShowVoiceCancelTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.ShowVoiceShortTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.UpdateVoiceRecordTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache12);
		string name = "voiceTimeText";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.get_voiceTimeText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.set_voiceTimeText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache14, true);
		string name2 = "voiceRecordStateUICtrl";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.get_voiceRecordStateUICtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.set_voiceRecordStateUICtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache16, true);
		string name3 = "recordTimeProgressBar";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.get_recordTimeProgressBar);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.set_recordTimeProgressBar);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache18, true);
		string name4 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.get_m_configDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.<>f__mg$cache1A, true);
		LuaObject.createTypeMetatable(l, null, typeof(VoiceRecordUIController), typeof(UIControllerBase));
	}

	// Token: 0x040180F1 RID: 98545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040180F2 RID: 98546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040180F3 RID: 98547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040180F4 RID: 98548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040180F5 RID: 98549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040180F6 RID: 98550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040180F7 RID: 98551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040180F8 RID: 98552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040180F9 RID: 98553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040180FA RID: 98554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040180FB RID: 98555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040180FC RID: 98556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040180FD RID: 98557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040180FE RID: 98558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040180FF RID: 98559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018100 RID: 98560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018101 RID: 98561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018102 RID: 98562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018103 RID: 98563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018104 RID: 98564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018105 RID: 98565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018106 RID: 98566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018107 RID: 98567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018108 RID: 98568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018109 RID: 98569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401810A RID: 98570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401810B RID: 98571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
