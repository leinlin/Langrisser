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

// Token: 0x020013D2 RID: 5074
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController : LuaObject
{
	// Token: 0x0601C62A RID: 116266 RVA: 0x008CB1AC File Offset: 0x008C93AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBoxItemInfo(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			Goods good;
			LuaObject.checkType<Goods>(l, 2, out good);
			bool isPresent;
			LuaObject.checkType(l, 3, out isPresent);
			boxItemInfoUIController.SetBoxItemInfo(good, isPresent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C62B RID: 116267 RVA: 0x008CB210 File Offset: 0x008C9410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			boxItemInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C62C RID: 116268 RVA: 0x008CB264 File Offset: 0x008C9464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			boxItemInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C62D RID: 116269 RVA: 0x008CB2D0 File Offset: 0x008C94D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			boxItemInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C62E RID: 116270 RVA: 0x008CB324 File Offset: 0x008C9524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			boxItemInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C62F RID: 116271 RVA: 0x008CB378 File Offset: 0x008C9578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = boxItemInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C630 RID: 116272 RVA: 0x008CB420 File Offset: 0x008C9620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			boxItemInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C631 RID: 116273 RVA: 0x008CB474 File Offset: 0x008C9674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			boxItemInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C632 RID: 116274 RVA: 0x008CB4E0 File Offset: 0x008C96E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				boxItemInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BoxItemInfoUIController boxItemInfoUIController2 = (BoxItemInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				boxItemInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C633 RID: 116275 RVA: 0x008CB5F0 File Offset: 0x008C97F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			boxItemInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C634 RID: 116276 RVA: 0x008CB65C File Offset: 0x008C985C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			boxItemInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C635 RID: 116277 RVA: 0x008CB6C8 File Offset: 0x008C98C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			boxItemInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C636 RID: 116278 RVA: 0x008CB734 File Offset: 0x008C9934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			boxItemInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C637 RID: 116279 RVA: 0x008CB7A0 File Offset: 0x008C99A0
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
				BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				boxItemInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BoxItemInfoUIController boxItemInfoUIController2 = (BoxItemInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				boxItemInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C638 RID: 116280 RVA: 0x008CB8B0 File Offset: 0x008C9AB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			string s = boxItemInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C639 RID: 116281 RVA: 0x008CB90C File Offset: 0x008C9B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemGoodsDummy(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxItemInfoUIController.m_luaExportHelper.m_itemGoodsDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C63A RID: 116282 RVA: 0x008CB964 File Offset: 0x008C9B64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_itemGoodsDummy(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			GameObject itemGoodsDummy;
			LuaObject.checkType<GameObject>(l, 2, out itemGoodsDummy);
			boxItemInfoUIController.m_luaExportHelper.m_itemGoodsDummy = itemGoodsDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C63B RID: 116283 RVA: 0x008CB9C0 File Offset: 0x008C9BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemNameText(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxItemInfoUIController.m_luaExportHelper.m_itemNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C63C RID: 116284 RVA: 0x008CBA18 File Offset: 0x008C9C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemNameText(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			Text itemNameText;
			LuaObject.checkType<Text>(l, 2, out itemNameText);
			boxItemInfoUIController.m_luaExportHelper.m_itemNameText = itemNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C63D RID: 116285 RVA: 0x008CBA74 File Offset: 0x008C9C74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_presentLogo(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxItemInfoUIController.m_luaExportHelper.m_presentLogo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C63E RID: 116286 RVA: 0x008CBACC File Offset: 0x008C9CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentLogo(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			GameObject presentLogo;
			LuaObject.checkType<GameObject>(l, 2, out presentLogo);
			boxItemInfoUIController.m_luaExportHelper.m_presentLogo = presentLogo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C63F RID: 116287 RVA: 0x008CBB28 File Offset: 0x008C9D28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boxItemInfoUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C640 RID: 116288 RVA: 0x008CBB80 File Offset: 0x008C9D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BoxItemInfoUIController boxItemInfoUIController = (BoxItemInfoUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			boxItemInfoUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C641 RID: 116289 RVA: 0x008CBBDC File Offset: 0x008C9DDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BoxItemInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.SetBoxItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheE);
		string name = "m_itemGoodsDummy";
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.get_m_itemGoodsDummy);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.set_m_itemGoodsDummy);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache10, true);
		string name2 = "m_itemNameText";
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.get_m_itemNameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.set_m_itemNameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache12, true);
		string name3 = "m_presentLogo";
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.get_m_presentLogo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.set_m_presentLogo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache14, true);
		string name4 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.get_m_configDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.<>f__mg$cache16, true);
		LuaObject.createTypeMetatable(l, null, typeof(BoxItemInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012868 RID: 75880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012869 RID: 75881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401286A RID: 75882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401286B RID: 75883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401286C RID: 75884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401286D RID: 75885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401286E RID: 75886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401286F RID: 75887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012870 RID: 75888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012871 RID: 75889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012872 RID: 75890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012873 RID: 75891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012874 RID: 75892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012875 RID: 75893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012876 RID: 75894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012877 RID: 75895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012878 RID: 75896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012879 RID: 75897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401287A RID: 75898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401287B RID: 75899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401287C RID: 75900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401287D RID: 75901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401287E RID: 75902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
