using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014CE RID: 5326
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController : LuaObject
{
	// Token: 0x0601F291 RID: 127633 RVA: 0x00A2C018 File Offset: 0x00A2A218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSoldierItem(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			Hero hero;
			LuaObject.checkType<Hero>(l, 3, out hero);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 4, out go);
			heroJobTransferSoldierItemUIController.InitSoldierItem(soldierInfo, hero, go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F292 RID: 127634 RVA: 0x00A2C08C File Offset: 0x00A2A28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F293 RID: 127635 RVA: 0x00A2C0E0 File Offset: 0x00A2A2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.OnSoldierItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F294 RID: 127636 RVA: 0x00A2C134 File Offset: 0x00A2A334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F295 RID: 127637 RVA: 0x00A2C1A0 File Offset: 0x00A2A3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F296 RID: 127638 RVA: 0x00A2C1F4 File Offset: 0x00A2A3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F297 RID: 127639 RVA: 0x00A2C248 File Offset: 0x00A2A448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F298 RID: 127640 RVA: 0x00A2C2F0 File Offset: 0x00A2A4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F299 RID: 127641 RVA: 0x00A2C344 File Offset: 0x00A2A544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F29A RID: 127642 RVA: 0x00A2C3B0 File Offset: 0x00A2A5B0
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
				HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController2 = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroJobTransferSoldierItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F29B RID: 127643 RVA: 0x00A2C4C0 File Offset: 0x00A2A6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F29C RID: 127644 RVA: 0x00A2C52C File Offset: 0x00A2A72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F29D RID: 127645 RVA: 0x00A2C598 File Offset: 0x00A2A798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F29E RID: 127646 RVA: 0x00A2C604 File Offset: 0x00A2A804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F29F RID: 127647 RVA: 0x00A2C670 File Offset: 0x00A2A870
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
				HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController2 = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroJobTransferSoldierItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F2A0 RID: 127648 RVA: 0x00A2C780 File Offset: 0x00A2A980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			string s = heroJobTransferSoldierItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F2A1 RID: 127649 RVA: 0x00A2C7DC File Offset: 0x00A2A9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferSoldierItemUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2A2 RID: 127650 RVA: 0x00A2C834 File Offset: 0x00A2AA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2A3 RID: 127651 RVA: 0x00A2C890 File Offset: 0x00A2AA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descGo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferSoldierItemUIController.m_luaExportHelper.m_descGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2A4 RID: 127652 RVA: 0x00A2C8E8 File Offset: 0x00A2AAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descGo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			GameObject descGo;
			LuaObject.checkType<GameObject>(l, 2, out descGo);
			heroJobTransferSoldierItemUIController.m_luaExportHelper.m_descGo = descGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2A5 RID: 127653 RVA: 0x00A2C944 File Offset: 0x00A2AB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferSoldierItemUIController.m_soldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2A6 RID: 127654 RVA: 0x00A2C998 File Offset: 0x00A2AB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = (HeroJobTransferSoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			heroJobTransferSoldierItemUIController.m_soldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2A7 RID: 127655 RVA: 0x00A2C9F0 File Offset: 0x00A2ABF0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobTransferSoldierItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.InitSoldierItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.OnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cacheF);
		string name = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.get_m_hero);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.set_m_hero);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache11, true);
		string name2 = "m_descGo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.get_m_descGo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.set_m_descGo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache13, true);
		string name3 = "m_soldierInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.get_m_soldierInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.set_m_soldierInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.<>f__mg$cache15, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroJobTransferSoldierItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040152D7 RID: 86743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040152D8 RID: 86744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040152D9 RID: 86745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040152DA RID: 86746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040152DB RID: 86747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040152DC RID: 86748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040152DD RID: 86749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040152DE RID: 86750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040152DF RID: 86751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040152E0 RID: 86752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040152E1 RID: 86753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040152E2 RID: 86754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040152E3 RID: 86755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040152E4 RID: 86756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040152E5 RID: 86757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040152E6 RID: 86758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040152E7 RID: 86759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040152E8 RID: 86760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040152E9 RID: 86761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040152EA RID: 86762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040152EB RID: 86763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040152EC RID: 86764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
