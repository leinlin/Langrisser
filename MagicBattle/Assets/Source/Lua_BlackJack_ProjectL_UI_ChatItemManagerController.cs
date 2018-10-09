using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013EB RID: 5099
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatItemManagerController : LuaObject
{
	// Token: 0x0601C93A RID: 117050 RVA: 0x008E3008 File Offset: 0x008E1208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHasNeedChatItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			string poolName;
			LuaObject.checkType(l, 2, out poolName);
			bool b = chatItemManagerController.IsHasNeedChatItemPrefab(poolName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C93B RID: 117051 RVA: 0x008E306C File Offset: 0x008E126C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			chatItemManagerController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C93C RID: 117052 RVA: 0x008E30C0 File Offset: 0x008E12C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			chatItemManagerController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C93D RID: 117053 RVA: 0x008E312C File Offset: 0x008E132C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			chatItemManagerController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C93E RID: 117054 RVA: 0x008E3180 File Offset: 0x008E1380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			chatItemManagerController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C93F RID: 117055 RVA: 0x008E31D4 File Offset: 0x008E13D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = chatItemManagerController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C940 RID: 117056 RVA: 0x008E327C File Offset: 0x008E147C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			chatItemManagerController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C941 RID: 117057 RVA: 0x008E32D0 File Offset: 0x008E14D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			chatItemManagerController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C942 RID: 117058 RVA: 0x008E333C File Offset: 0x008E153C
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
				ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				chatItemManagerController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ChatItemManagerController chatItemManagerController2 = (ChatItemManagerController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				chatItemManagerController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C943 RID: 117059 RVA: 0x008E344C File Offset: 0x008E164C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatItemManagerController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C944 RID: 117060 RVA: 0x008E34B8 File Offset: 0x008E16B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatItemManagerController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C945 RID: 117061 RVA: 0x008E3524 File Offset: 0x008E1724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatItemManagerController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C946 RID: 117062 RVA: 0x008E3590 File Offset: 0x008E1790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatItemManagerController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C947 RID: 117063 RVA: 0x008E35FC File Offset: 0x008E17FC
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
				ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				chatItemManagerController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ChatItemManagerController chatItemManagerController2 = (ChatItemManagerController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				chatItemManagerController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C948 RID: 117064 RVA: 0x008E370C File Offset: 0x008E190C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			string s = chatItemManagerController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C949 RID: 117065 RVA: 0x008E3768 File Offset: 0x008E1968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_childPrefabPoolName(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatItemManagerController.m_childPrefabPoolName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C94A RID: 117066 RVA: 0x008E37BC File Offset: 0x008E19BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_childPrefabPoolName(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			string childPrefabPoolName;
			LuaObject.checkType(l, 2, out childPrefabPoolName);
			chatItemManagerController.m_childPrefabPoolName = childPrefabPoolName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C94B RID: 117067 RVA: 0x008E3814 File Offset: 0x008E1A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_childPrefab(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatItemManagerController.m_childPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C94C RID: 117068 RVA: 0x008E3868 File Offset: 0x008E1A68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_childPrefab(IntPtr l)
	{
		int result;
		try
		{
			ChatItemManagerController chatItemManagerController = (ChatItemManagerController)LuaObject.checkSelf(l);
			GameObject childPrefab;
			LuaObject.checkType<GameObject>(l, 2, out childPrefab);
			chatItemManagerController.m_childPrefab = childPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C94D RID: 117069 RVA: 0x008E38C0 File Offset: 0x008E1AC0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatItemManagerController");
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.IsHasNeedChatItemPrefab);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheE);
		string name = "m_childPrefabPoolName";
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.get_m_childPrefabPoolName);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.set_m_childPrefabPoolName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache10, true);
		string name2 = "m_childPrefab";
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.get_m_childPrefab);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.set_m_childPrefab);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ChatItemManagerController.<>f__mg$cache12, true);
		LuaObject.createTypeMetatable(l, null, typeof(ChatItemManagerController), typeof(UIControllerBase));
	}

	// Token: 0x04012B46 RID: 76614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012B47 RID: 76615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012B48 RID: 76616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012B49 RID: 76617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012B4A RID: 76618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012B4B RID: 76619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012B4C RID: 76620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012B4D RID: 76621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012B4E RID: 76622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012B4F RID: 76623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012B50 RID: 76624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012B51 RID: 76625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012B52 RID: 76626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012B53 RID: 76627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012B54 RID: 76628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012B55 RID: 76629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012B56 RID: 76630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012B57 RID: 76631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012B58 RID: 76632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
