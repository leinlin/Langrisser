using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200158E RID: 5518
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SystemChatItemUIController : LuaObject
{
	// Token: 0x060215FB RID: 136699 RVA: 0x00B466E8 File Offset: 0x00B448E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChatInfo(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient chatInfo;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out chatInfo);
			systemChatItemUIController.UpdateChatInfo(chatInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215FC RID: 136700 RVA: 0x00B46740 File Offset: 0x00B44940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FakePlayerCount(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			int trueCount;
			LuaObject.checkType(l, 2, out trueCount);
			int i = systemChatItemUIController.m_luaExportHelper.FakePlayerCount(trueCount);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215FD RID: 136701 RVA: 0x00B467A8 File Offset: 0x00B449A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			systemChatItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215FE RID: 136702 RVA: 0x00B46814 File Offset: 0x00B44A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			systemChatItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215FF RID: 136703 RVA: 0x00B46868 File Offset: 0x00B44A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			systemChatItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021600 RID: 136704 RVA: 0x00B468BC File Offset: 0x00B44ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = systemChatItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021601 RID: 136705 RVA: 0x00B46964 File Offset: 0x00B44B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			systemChatItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021602 RID: 136706 RVA: 0x00B469B8 File Offset: 0x00B44BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			systemChatItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021603 RID: 136707 RVA: 0x00B46A24 File Offset: 0x00B44C24
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
				SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				systemChatItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SystemChatItemUIController systemChatItemUIController2 = (SystemChatItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				systemChatItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021604 RID: 136708 RVA: 0x00B46B34 File Offset: 0x00B44D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			systemChatItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021605 RID: 136709 RVA: 0x00B46BA0 File Offset: 0x00B44DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			systemChatItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021606 RID: 136710 RVA: 0x00B46C0C File Offset: 0x00B44E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			systemChatItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021607 RID: 136711 RVA: 0x00B46C78 File Offset: 0x00B44E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			systemChatItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021608 RID: 136712 RVA: 0x00B46CE4 File Offset: 0x00B44EE4
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
				SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				systemChatItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SystemChatItemUIController systemChatItemUIController2 = (SystemChatItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				systemChatItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021609 RID: 136713 RVA: 0x00B46DF4 File Offset: 0x00B44FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			string s = systemChatItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602160A RID: 136714 RVA: 0x00B46E50 File Offset: 0x00B45050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ContentText(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, systemChatItemUIController.ContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602160B RID: 136715 RVA: 0x00B46EA4 File Offset: 0x00B450A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ContentText(IntPtr l)
	{
		int result;
		try
		{
			SystemChatItemUIController systemChatItemUIController = (SystemChatItemUIController)LuaObject.checkSelf(l);
			Text contentText;
			LuaObject.checkType<Text>(l, 2, out contentText);
			systemChatItemUIController.ContentText = contentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602160C RID: 136716 RVA: 0x00B46EFC File Offset: 0x00B450FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SystemChatItemUIController");
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.UpdateChatInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.FakePlayerCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheE);
		string name = "ContentText";
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.get_ContentText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.set_ContentText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.<>f__mg$cache10, true);
		LuaObject.createTypeMetatable(l, null, typeof(SystemChatItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040174C1 RID: 95425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040174C2 RID: 95426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040174C3 RID: 95427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040174C4 RID: 95428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040174C5 RID: 95429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040174C6 RID: 95430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040174C7 RID: 95431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040174C8 RID: 95432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040174C9 RID: 95433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040174CA RID: 95434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040174CB RID: 95435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040174CC RID: 95436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040174CD RID: 95437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040174CE RID: 95438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040174CF RID: 95439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040174D0 RID: 95440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040174D1 RID: 95441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
