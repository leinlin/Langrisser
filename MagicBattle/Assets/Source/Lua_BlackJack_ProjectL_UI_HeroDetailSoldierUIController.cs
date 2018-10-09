using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014B7 RID: 5303
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController : LuaObject
{
	// Token: 0x0601EEEF RID: 126703 RVA: 0x00A0E9F8 File Offset: 0x00A0CBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInSoldierState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailSoldierUIController.UpdateViewInSoldierState(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF0 RID: 126704 RVA: 0x00A0EA50 File Offset: 0x00A0CC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonUIState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			string commonUIState;
			LuaObject.checkType(l, 2, out commonUIState);
			heroDetailSoldierUIController.SetCommonUIState(commonUIState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF1 RID: 126705 RVA: 0x00A0EAA8 File Offset: 0x00A0CCA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			heroDetailSoldierUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF2 RID: 126706 RVA: 0x00A0EAFC File Offset: 0x00A0CCFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowSoldierInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			bool isSoldierGet;
			LuaObject.checkType(l, 3, out isSoldierGet);
			heroDetailSoldierUIController.m_luaExportHelper.ShowSoldierInfoPanel(soldierInfo, isSoldierGet);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF3 RID: 126707 RVA: 0x00A0EB68 File Offset: 0x00A0CD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSoldierSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailSoldierUIController.m_luaExportHelper.ShowSoldierSelectPanel(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF4 RID: 126708 RVA: 0x00A0EBC4 File Offset: 0x00A0CDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoliderSortComparar(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo s;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out s);
			ConfigDataSoldierInfo s2;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out s2);
			int soliderSortComparar = heroDetailSoldierUIController.m_luaExportHelper.GetSoliderSortComparar(s, s2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soliderSortComparar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF5 RID: 126709 RVA: 0x00A0EC38 File Offset: 0x00A0CE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NotGetSoliderSortComparar(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo s;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out s);
			ConfigDataSoldierInfo s2;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out s2);
			int i = heroDetailSoldierUIController.m_luaExportHelper.NotGetSoliderSortComparar(s, s2);
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

	// Token: 0x0601EEF6 RID: 126710 RVA: 0x00A0ECAC File Offset: 0x00A0CEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			SoldierItemUIController ctrl;
			LuaObject.checkType<SoldierItemUIController>(l, 2, out ctrl);
			heroDetailSoldierUIController.m_luaExportHelper.OnSoldierItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF7 RID: 126711 RVA: 0x00A0ED08 File Offset: 0x00A0CF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierGetConditionGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			heroDetailSoldierUIController.m_luaExportHelper.OnSoldierGetConditionGotoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF8 RID: 126712 RVA: 0x00A0ED5C File Offset: 0x00A0CF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierItemAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			heroDetailSoldierUIController.m_luaExportHelper.OnSoldierItemAttackButtonClick(soldierInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEF9 RID: 126713 RVA: 0x00A0EDB8 File Offset: 0x00A0CFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CleanSoldierPanelDataOnHeroChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			heroDetailSoldierUIController.m_luaExportHelper.CleanSoldierPanelDataOnHeroChanged();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEFA RID: 126714 RVA: 0x00A0EE0C File Offset: 0x00A0D00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			heroDetailSoldierUIController.m_luaExportHelper.OnSkinInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEFB RID: 126715 RVA: 0x00A0EE60 File Offset: 0x00A0D060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEFC RID: 126716 RVA: 0x00A0EECC File Offset: 0x00A0D0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEFD RID: 126717 RVA: 0x00A0EF20 File Offset: 0x00A0D120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEFE RID: 126718 RVA: 0x00A0EF74 File Offset: 0x00A0D174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDetailSoldierUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EEFF RID: 126719 RVA: 0x00A0F01C File Offset: 0x00A0D21C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF00 RID: 126720 RVA: 0x00A0F070 File Offset: 0x00A0D270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF01 RID: 126721 RVA: 0x00A0F0DC File Offset: 0x00A0D2DC
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
				HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDetailSoldierUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDetailSoldierUIController heroDetailSoldierUIController2 = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDetailSoldierUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EF02 RID: 126722 RVA: 0x00A0F1EC File Offset: 0x00A0D3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF03 RID: 126723 RVA: 0x00A0F258 File Offset: 0x00A0D458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF04 RID: 126724 RVA: 0x00A0F2C4 File Offset: 0x00A0D4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF05 RID: 126725 RVA: 0x00A0F330 File Offset: 0x00A0D530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailSoldierUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF06 RID: 126726 RVA: 0x00A0F39C File Offset: 0x00A0D59C
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
				HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDetailSoldierUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailSoldierUIController heroDetailSoldierUIController2 = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDetailSoldierUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EF07 RID: 126727 RVA: 0x00A0F4AC File Offset: 0x00A0D6AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			string s = heroDetailSoldierUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EF08 RID: 126728 RVA: 0x00A0F508 File Offset: 0x00A0D708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnSoldierAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroDetailSoldierUIController.m_luaExportHelper.__callDele_EventOnSoldierAttackButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF09 RID: 126729 RVA: 0x00A0F580 File Offset: 0x00A0D780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSoldierAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroDetailSoldierUIController.m_luaExportHelper.__clearDele_EventOnSoldierAttackButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF0A RID: 126730 RVA: 0x00A0F5F8 File Offset: 0x00A0D7F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGotoDrill(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailSoldierUIController.m_luaExportHelper.__callDele_EventOnGotoDrill(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF0B RID: 126731 RVA: 0x00A0F654 File Offset: 0x00A0D854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoDrill(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailSoldierUIController.m_luaExportHelper.__clearDele_EventOnGotoDrill(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF0C RID: 126732 RVA: 0x00A0F6B0 File Offset: 0x00A0D8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo obj;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out obj);
			heroDetailSoldierUIController.m_luaExportHelper.__callDele_EventOnGotoJobTransfer(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF0D RID: 126733 RVA: 0x00A0F70C File Offset: 0x00A0D90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo obj;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out obj);
			heroDetailSoldierUIController.m_luaExportHelper.__clearDele_EventOnGotoJobTransfer(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF0E RID: 126734 RVA: 0x00A0F768 File Offset: 0x00A0D968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo obj;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out obj);
			heroDetailSoldierUIController.m_luaExportHelper.__callDele_EventOnSkinInfoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF0F RID: 126735 RVA: 0x00A0F7C4 File Offset: 0x00A0D9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo obj;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out obj);
			heroDetailSoldierUIController.m_luaExportHelper.__clearDele_EventOnSkinInfoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF10 RID: 126736 RVA: 0x00A0F820 File Offset: 0x00A0DA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF11 RID: 126737 RVA: 0x00A0F878 File Offset: 0x00A0DA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroDetailSoldierUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF12 RID: 126738 RVA: 0x00A0F8D4 File Offset: 0x00A0DAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF13 RID: 126739 RVA: 0x00A0F92C File Offset: 0x00A0DB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Image soldierIconImage;
			LuaObject.checkType<Image>(l, 2, out soldierIconImage);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierIconImage = soldierIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF14 RID: 126740 RVA: 0x00A0F988 File Offset: 0x00A0DB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierQualityIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierQualityIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF15 RID: 126741 RVA: 0x00A0F9E0 File Offset: 0x00A0DBE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierQualityIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Image soldierQualityIcon;
			LuaObject.checkType<Image>(l, 2, out soldierQualityIcon);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierQualityIcon = soldierQualityIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF16 RID: 126742 RVA: 0x00A0FA3C File Offset: 0x00A0DC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF17 RID: 126743 RVA: 0x00A0FA94 File Offset: 0x00A0DC94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierNameText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierNameText = soldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF18 RID: 126744 RVA: 0x00A0FAF0 File Offset: 0x00A0DCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF19 RID: 126745 RVA: 0x00A0FB48 File Offset: 0x00A0DD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			GameObject soldierGraphic;
			LuaObject.checkType<GameObject>(l, 2, out soldierGraphic);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierGraphic = soldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF1A RID: 126746 RVA: 0x00A0FBA4 File Offset: 0x00A0DDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierFactionRangeText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierFactionRangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF1B RID: 126747 RVA: 0x00A0FBFC File Offset: 0x00A0DDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierFactionRangeText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierFactionRangeText;
			LuaObject.checkType<Text>(l, 2, out soldierFactionRangeText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierFactionRangeText = soldierFactionRangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF1C RID: 126748 RVA: 0x00A0FC58 File Offset: 0x00A0DE58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierFactionMoveText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierFactionMoveText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF1D RID: 126749 RVA: 0x00A0FCB0 File Offset: 0x00A0DEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierFactionMoveText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierFactionMoveText;
			LuaObject.checkType<Text>(l, 2, out soldierFactionMoveText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierFactionMoveText = soldierFactionMoveText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF1E RID: 126750 RVA: 0x00A0FD0C File Offset: 0x00A0DF0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF1F RID: 126751 RVA: 0x00A0FD64 File Offset: 0x00A0DF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierHPValueText;
			LuaObject.checkType<Text>(l, 2, out soldierHPValueText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierHPValueText = soldierHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF20 RID: 126752 RVA: 0x00A0FDC0 File Offset: 0x00A0DFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHPAddPercentText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierHPAddPercentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF21 RID: 126753 RVA: 0x00A0FE18 File Offset: 0x00A0E018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHPAddPercentText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierHPAddPercentText;
			LuaObject.checkType<Text>(l, 2, out soldierHPAddPercentText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierHPAddPercentText = soldierHPAddPercentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF22 RID: 126754 RVA: 0x00A0FE74 File Offset: 0x00A0E074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHPAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierHPAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF23 RID: 126755 RVA: 0x00A0FECC File Offset: 0x00A0E0CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierHPAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierHPAddValueText;
			LuaObject.checkType<Text>(l, 2, out soldierHPAddValueText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierHPAddValueText = soldierHPAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF24 RID: 126756 RVA: 0x00A0FF28 File Offset: 0x00A0E128
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF25 RID: 126757 RVA: 0x00A0FF80 File Offset: 0x00A0E180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierATValueText;
			LuaObject.checkType<Text>(l, 2, out soldierATValueText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierATValueText = soldierATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF26 RID: 126758 RVA: 0x00A0FFDC File Offset: 0x00A0E1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierATAddPercentText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierATAddPercentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF27 RID: 126759 RVA: 0x00A10034 File Offset: 0x00A0E234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierATAddPercentText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierATAddPercentText;
			LuaObject.checkType<Text>(l, 2, out soldierATAddPercentText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierATAddPercentText = soldierATAddPercentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF28 RID: 126760 RVA: 0x00A10090 File Offset: 0x00A0E290
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierATAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierATAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF29 RID: 126761 RVA: 0x00A100E8 File Offset: 0x00A0E2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierATAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierATAddValueText;
			LuaObject.checkType<Text>(l, 2, out soldierATAddValueText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierATAddValueText = soldierATAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF2A RID: 126762 RVA: 0x00A10144 File Offset: 0x00A0E344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF2B RID: 126763 RVA: 0x00A1019C File Offset: 0x00A0E39C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDFValueText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierDFValueText = soldierDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF2C RID: 126764 RVA: 0x00A101F8 File Offset: 0x00A0E3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDFAddPercentText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierDFAddPercentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF2D RID: 126765 RVA: 0x00A10250 File Offset: 0x00A0E450
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierDFAddPercentText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierDFAddPercentText;
			LuaObject.checkType<Text>(l, 2, out soldierDFAddPercentText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierDFAddPercentText = soldierDFAddPercentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF2E RID: 126766 RVA: 0x00A102AC File Offset: 0x00A0E4AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierDFAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierDFAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF2F RID: 126767 RVA: 0x00A10304 File Offset: 0x00A0E504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDFAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierDFAddValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDFAddValueText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierDFAddValueText = soldierDFAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF30 RID: 126768 RVA: 0x00A10360 File Offset: 0x00A0E560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF31 RID: 126769 RVA: 0x00A103B8 File Offset: 0x00A0E5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFValueText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierMagicDFValueText = soldierMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF32 RID: 126770 RVA: 0x00A10414 File Offset: 0x00A0E614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFAddPercentText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierMagicDFAddPercentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF33 RID: 126771 RVA: 0x00A1046C File Offset: 0x00A0E66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFAddPercentText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFAddPercentText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFAddPercentText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierMagicDFAddPercentText = soldierMagicDFAddPercentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF34 RID: 126772 RVA: 0x00A104C8 File Offset: 0x00A0E6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierMagicDFAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF35 RID: 126773 RVA: 0x00A10520 File Offset: 0x00A0E720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFAddValueText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFAddValueText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierMagicDFAddValueText = soldierMagicDFAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF36 RID: 126774 RVA: 0x00A1057C File Offset: 0x00A0E77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierStrongText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierStrongText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF37 RID: 126775 RVA: 0x00A105D4 File Offset: 0x00A0E7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierStrongText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierStrongText;
			LuaObject.checkType<Text>(l, 2, out soldierStrongText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierStrongText = soldierStrongText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF38 RID: 126776 RVA: 0x00A10630 File Offset: 0x00A0E830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierWeakText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierWeakText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF39 RID: 126777 RVA: 0x00A10688 File Offset: 0x00A0E888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierWeakText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierWeakText;
			LuaObject.checkType<Text>(l, 2, out soldierWeakText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierWeakText = soldierWeakText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF3A RID: 126778 RVA: 0x00A106E4 File Offset: 0x00A0E8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF3B RID: 126779 RVA: 0x00A1073C File Offset: 0x00A0E93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierDescText;
			LuaObject.checkType<Text>(l, 2, out soldierDescText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierDescText = soldierDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF3C RID: 126780 RVA: 0x00A10798 File Offset: 0x00A0E998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierSelectContentScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierSelectContentScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF3D RID: 126781 RVA: 0x00A107F0 File Offset: 0x00A0E9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierSelectContentScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ScrollRect soldierSelectContentScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out soldierSelectContentScrollRect);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierSelectContentScrollRect = soldierSelectContentScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF3E RID: 126782 RVA: 0x00A1084C File Offset: 0x00A0EA4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierSelectContentObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierSelectContentObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF3F RID: 126783 RVA: 0x00A108A4 File Offset: 0x00A0EAA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierSelectContentObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			GameObject soldierSelectContentObj;
			LuaObject.checkType<GameObject>(l, 2, out soldierSelectContentObj);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierSelectContentObj = soldierSelectContentObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF40 RID: 126784 RVA: 0x00A10900 File Offset: 0x00A0EB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGetCondition(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF41 RID: 126785 RVA: 0x00A10958 File Offset: 0x00A0EB58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierGetCondition(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			GameObject soldierGetCondition;
			LuaObject.checkType<GameObject>(l, 2, out soldierGetCondition);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetCondition = soldierGetCondition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF42 RID: 126786 RVA: 0x00A109B4 File Offset: 0x00A0EBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGetConditionDescStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetConditionDescStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF43 RID: 126787 RVA: 0x00A10A0C File Offset: 0x00A0EC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGetConditionDescStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierGetConditionDescStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierGetConditionDescStateCtrl);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetConditionDescStateCtrl = soldierGetConditionDescStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF44 RID: 126788 RVA: 0x00A10A68 File Offset: 0x00A0EC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGetConditionDescJobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetConditionDescJobNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF45 RID: 126789 RVA: 0x00A10AC0 File Offset: 0x00A0ECC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGetConditionDescJobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierGetConditionDescJobNameText;
			LuaObject.checkType<Text>(l, 2, out soldierGetConditionDescJobNameText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetConditionDescJobNameText = soldierGetConditionDescJobNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF46 RID: 126790 RVA: 0x00A10B1C File Offset: 0x00A0ED1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGetConditionDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetConditionDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF47 RID: 126791 RVA: 0x00A10B74 File Offset: 0x00A0ED74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGetConditionDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Text soldierGetConditionDescText;
			LuaObject.checkType<Text>(l, 2, out soldierGetConditionDescText);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetConditionDescText = soldierGetConditionDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF48 RID: 126792 RVA: 0x00A10BD0 File Offset: 0x00A0EDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGetConditionGotoButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetConditionGotoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF49 RID: 126793 RVA: 0x00A10C28 File Offset: 0x00A0EE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGetConditionGotoButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Button soldierGetConditionGotoButton;
			LuaObject.checkType<Button>(l, 2, out soldierGetConditionGotoButton);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierGetConditionGotoButton = soldierGetConditionGotoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF4A RID: 126794 RVA: 0x00A10C84 File Offset: 0x00A0EE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierItemPrefabObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierItemPrefabObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF4B RID: 126795 RVA: 0x00A10CDC File Offset: 0x00A0EEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierItemPrefabObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			GameObject soldierItemPrefabObj;
			LuaObject.checkType<GameObject>(l, 2, out soldierItemPrefabObj);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierItemPrefabObj = soldierItemPrefabObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF4C RID: 126796 RVA: 0x00A10D38 File Offset: 0x00A0EF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinInfoButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_skinInfoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF4D RID: 126797 RVA: 0x00A10D90 File Offset: 0x00A0EF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinInfoButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Button skinInfoButton;
			LuaObject.checkType<Button>(l, 2, out skinInfoButton);
			heroDetailSoldierUIController.m_luaExportHelper.m_skinInfoButton = skinInfoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF4E RID: 126798 RVA: 0x00A10DEC File Offset: 0x00A0EFEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnSoldierAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Action<int, int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailSoldierUIController.EventOnSoldierAttackButtonClick += value;
				}
				else if (num == 2)
				{
					heroDetailSoldierUIController.EventOnSoldierAttackButtonClick -= value;
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

	// Token: 0x0601EF4F RID: 126799 RVA: 0x00A10E6C File Offset: 0x00A0F06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoDrill(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailSoldierUIController.EventOnGotoDrill += value;
				}
				else if (num == 2)
				{
					heroDetailSoldierUIController.EventOnGotoDrill -= value;
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

	// Token: 0x0601EF50 RID: 126800 RVA: 0x00A10EEC File Offset: 0x00A0F0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Action<ConfigDataJobConnectionInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataJobConnectionInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailSoldierUIController.EventOnGotoJobTransfer += value;
				}
				else if (num == 2)
				{
					heroDetailSoldierUIController.EventOnGotoJobTransfer -= value;
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

	// Token: 0x0601EF51 RID: 126801 RVA: 0x00A10F6C File Offset: 0x00A0F16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Action<ConfigDataSoldierInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataSoldierInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailSoldierUIController.EventOnSkinInfoButtonClick += value;
				}
				else if (num == 2)
				{
					heroDetailSoldierUIController.EventOnSkinInfoButtonClick -= value;
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

	// Token: 0x0601EF52 RID: 126802 RVA: 0x00A10FEC File Offset: 0x00A0F1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF53 RID: 126803 RVA: 0x00A11044 File Offset: 0x00A0F244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailSoldierUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF54 RID: 126804 RVA: 0x00A110A0 File Offset: 0x00A0F2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierInfoGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF55 RID: 126805 RVA: 0x00A110F8 File Offset: 0x00A0F2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierInfoGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierInfoGraphic);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierInfoGraphic = soldierInfoGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF56 RID: 126806 RVA: 0x00A11154 File Offset: 0x00A0F354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierIDToJobInfoDict(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soldierIDToJobInfoDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF57 RID: 126807 RVA: 0x00A111AC File Offset: 0x00A0F3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierIDToJobInfoDict(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			Dictionary<int, ConfigDataJobConnectionInfo> soldierIDToJobInfoDict;
			LuaObject.checkType<Dictionary<int, ConfigDataJobConnectionInfo>>(l, 2, out soldierIDToJobInfoDict);
			heroDetailSoldierUIController.m_luaExportHelper.m_soldierIDToJobInfoDict = soldierIDToJobInfoDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF58 RID: 126808 RVA: 0x00A11208 File Offset: 0x00A0F408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastClickSoldierItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_lastClickSoldierItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF59 RID: 126809 RVA: 0x00A11260 File Offset: 0x00A0F460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastClickSoldierItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			SoldierItemUIController lastClickSoldierItemCtrl;
			LuaObject.checkType<SoldierItemUIController>(l, 2, out lastClickSoldierItemCtrl);
			heroDetailSoldierUIController.m_luaExportHelper.m_lastClickSoldierItemCtrl = lastClickSoldierItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF5A RID: 126810 RVA: 0x00A112BC File Offset: 0x00A0F4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastClickSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_lastClickSoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF5B RID: 126811 RVA: 0x00A11314 File Offset: 0x00A0F514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastClickSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo lastClickSoldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out lastClickSoldierInfo);
			heroDetailSoldierUIController.m_luaExportHelper.m_lastClickSoldierInfo = lastClickSoldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF5C RID: 126812 RVA: 0x00A11370 File Offset: 0x00A0F570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soliderItemListCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_soliderItemListCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF5D RID: 126813 RVA: 0x00A113C8 File Offset: 0x00A0F5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soliderItemListCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			List<SoldierItemUIController> soliderItemListCtrl;
			LuaObject.checkType<List<SoldierItemUIController>>(l, 2, out soliderItemListCtrl);
			heroDetailSoldierUIController.m_luaExportHelper.m_soliderItemListCtrl = soliderItemListCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF5E RID: 126814 RVA: 0x00A11424 File Offset: 0x00A0F624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF5F RID: 126815 RVA: 0x00A1147C File Offset: 0x00A0F67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDetailSoldierUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF60 RID: 126816 RVA: 0x00A114D8 File Offset: 0x00A0F6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSoldierUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF61 RID: 126817 RVA: 0x00A11530 File Offset: 0x00A0F730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSoldierUIController heroDetailSoldierUIController = (HeroDetailSoldierUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDetailSoldierUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF62 RID: 126818 RVA: 0x00A1158C File Offset: 0x00A0F78C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDetailSoldierUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.UpdateViewInSoldierState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.SetCommonUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.ShowSoldierInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.ShowSoldierSelectPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.GetSoliderSortComparar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.NotGetSoliderSortComparar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.OnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.OnSoldierGetConditionGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.OnSoldierItemAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.CleanSoldierPanelDataOnHeroChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.OnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callDele_EventOnSoldierAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__clearDele_EventOnSoldierAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callDele_EventOnGotoDrill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__clearDele_EventOnGotoDrill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callDele_EventOnGotoJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__clearDele_EventOnGotoJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__callDele_EventOnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.__clearDele_EventOnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache20);
		string name = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_marginTransform);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache22, true);
		string name2 = "m_soldierIconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierIconImage);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierIconImage);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache24, true);
		string name3 = "m_soldierQualityIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierQualityIcon);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierQualityIcon);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache26, true);
		string name4 = "m_soldierNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierNameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierNameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache28, true);
		string name5 = "m_soldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierGraphic);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierGraphic);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2A, true);
		string name6 = "m_soldierFactionRangeText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierFactionRangeText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierFactionRangeText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2C, true);
		string name7 = "m_soldierFactionMoveText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierFactionMoveText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierFactionMoveText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2E, true);
		string name8 = "m_soldierHPValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierHPValueText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierHPValueText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache30, true);
		string name9 = "m_soldierHPAddPercentText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierHPAddPercentText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierHPAddPercentText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache32, true);
		string name10 = "m_soldierHPAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierHPAddValueText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierHPAddValueText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache34, true);
		string name11 = "m_soldierATValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierATValueText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierATValueText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache36, true);
		string name12 = "m_soldierATAddPercentText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierATAddPercentText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierATAddPercentText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache38, true);
		string name13 = "m_soldierATAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierATAddValueText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierATAddValueText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3A, true);
		string name14 = "m_soldierDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierDFValueText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierDFValueText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3C, true);
		string name15 = "m_soldierDFAddPercentText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierDFAddPercentText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierDFAddPercentText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3E, true);
		string name16 = "m_soldierDFAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierDFAddValueText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierDFAddValueText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache40, true);
		string name17 = "m_soldierMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierMagicDFValueText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierMagicDFValueText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache42, true);
		string name18 = "m_soldierMagicDFAddPercentText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierMagicDFAddPercentText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierMagicDFAddPercentText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache44, true);
		string name19 = "m_soldierMagicDFAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierMagicDFAddValueText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierMagicDFAddValueText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache46, true);
		string name20 = "m_soldierStrongText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierStrongText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierStrongText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache48, true);
		string name21 = "m_soldierWeakText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierWeakText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierWeakText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4A, true);
		string name22 = "m_soldierDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierDescText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierDescText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4C, true);
		string name23 = "m_soldierSelectContentScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierSelectContentScrollRect);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierSelectContentScrollRect);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4E, true);
		string name24 = "m_soldierSelectContentObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierSelectContentObj);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierSelectContentObj);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache50, true);
		string name25 = "m_soldierGetCondition";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierGetCondition);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierGetCondition);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache52, true);
		string name26 = "m_soldierGetConditionDescStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierGetConditionDescStateCtrl);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierGetConditionDescStateCtrl);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache54, true);
		string name27 = "m_soldierGetConditionDescJobNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierGetConditionDescJobNameText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierGetConditionDescJobNameText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache56, true);
		string name28 = "m_soldierGetConditionDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierGetConditionDescText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierGetConditionDescText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache58, true);
		string name29 = "m_soldierGetConditionGotoButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierGetConditionGotoButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierGetConditionGotoButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5A, true);
		string name30 = "m_soldierItemPrefabObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierItemPrefabObj);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierItemPrefabObj);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5C, true);
		string name31 = "m_skinInfoButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_skinInfoButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_skinInfoButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5E, true);
		string name32 = "EventOnSoldierAttackButtonClick";
		LuaCSFunction get32 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_EventOnSoldierAttackButtonClick);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache5F, true);
		string name33 = "EventOnGotoDrill";
		LuaCSFunction get33 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_EventOnGotoDrill);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache60, true);
		string name34 = "EventOnGotoJobTransfer";
		LuaCSFunction get34 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_EventOnGotoJobTransfer);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache61, true);
		string name35 = "EventOnSkinInfoButtonClick";
		LuaCSFunction get35 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_EventOnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache62, true);
		string name36 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_hero);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_hero);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache64, true);
		string name37 = "m_soldierInfoGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierInfoGraphic);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierInfoGraphic);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache66, true);
		string name38 = "m_soldierIDToJobInfoDict";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soldierIDToJobInfoDict);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soldierIDToJobInfoDict);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache68, true);
		string name39 = "m_lastClickSoldierItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_lastClickSoldierItemCtrl);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_lastClickSoldierItemCtrl);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6A, true);
		string name40 = "m_lastClickSoldierInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_lastClickSoldierInfo);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_lastClickSoldierInfo);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6C, true);
		string name41 = "m_soliderItemListCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_soliderItemListCtrl);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_soliderItemListCtrl);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6E, true);
		string name42 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_playerContext);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache70, true);
		string name43 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.get_m_configDataLoader);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.<>f__mg$cache72, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDetailSoldierUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014F63 RID: 85859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014F64 RID: 85860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014F65 RID: 85861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014F66 RID: 85862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014F67 RID: 85863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014F68 RID: 85864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014F69 RID: 85865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014F6A RID: 85866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014F6B RID: 85867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014F6C RID: 85868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014F6D RID: 85869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014F6E RID: 85870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014F6F RID: 85871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014F70 RID: 85872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014F71 RID: 85873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014F72 RID: 85874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014F73 RID: 85875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014F74 RID: 85876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014F75 RID: 85877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014F76 RID: 85878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014F77 RID: 85879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014F78 RID: 85880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014F79 RID: 85881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014F7A RID: 85882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014F7B RID: 85883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014F7C RID: 85884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014F7D RID: 85885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014F7E RID: 85886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014F7F RID: 85887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014F80 RID: 85888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014F81 RID: 85889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014F82 RID: 85890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014F83 RID: 85891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014F84 RID: 85892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014F85 RID: 85893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014F86 RID: 85894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014F87 RID: 85895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014F88 RID: 85896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014F89 RID: 85897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014F8A RID: 85898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014F8B RID: 85899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014F8C RID: 85900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014F8D RID: 85901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014F8E RID: 85902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014F8F RID: 85903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014F90 RID: 85904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014F91 RID: 85905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014F92 RID: 85906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014F93 RID: 85907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014F94 RID: 85908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014F95 RID: 85909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014F96 RID: 85910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014F97 RID: 85911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014F98 RID: 85912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014F99 RID: 85913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014F9A RID: 85914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014F9B RID: 85915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014F9C RID: 85916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014F9D RID: 85917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014F9E RID: 85918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014F9F RID: 85919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014FA0 RID: 85920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014FA1 RID: 85921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014FA2 RID: 85922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014FA3 RID: 85923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014FA4 RID: 85924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014FA5 RID: 85925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014FA6 RID: 85926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014FA7 RID: 85927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014FA8 RID: 85928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014FA9 RID: 85929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014FAA RID: 85930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014FAB RID: 85931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014FAC RID: 85932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014FAD RID: 85933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014FAE RID: 85934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014FAF RID: 85935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04014FB0 RID: 85936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04014FB1 RID: 85937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04014FB2 RID: 85938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014FB3 RID: 85939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014FB4 RID: 85940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014FB5 RID: 85941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014FB6 RID: 85942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014FB7 RID: 85943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014FB8 RID: 85944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014FB9 RID: 85945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014FBA RID: 85946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014FBB RID: 85947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014FBC RID: 85948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014FBD RID: 85949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014FBE RID: 85950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04014FBF RID: 85951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04014FC0 RID: 85952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04014FC1 RID: 85953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04014FC2 RID: 85954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014FC3 RID: 85955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014FC4 RID: 85956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014FC5 RID: 85957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014FC6 RID: 85958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014FC7 RID: 85959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04014FC8 RID: 85960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04014FC9 RID: 85961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04014FCA RID: 85962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04014FCB RID: 85963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04014FCC RID: 85964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04014FCD RID: 85965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04014FCE RID: 85966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04014FCF RID: 85967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04014FD0 RID: 85968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04014FD1 RID: 85969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04014FD2 RID: 85970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04014FD3 RID: 85971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04014FD4 RID: 85972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04014FD5 RID: 85973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;
}
