using System;
using System.Collections.Generic;
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

// Token: 0x020014E6 RID: 5350
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController : LuaObject
{
	// Token: 0x0601F89B RID: 129179 RVA: 0x00A5C588 File Offset: 0x00A5A788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F89C RID: 129180 RVA: 0x00A5C5D4 File Offset: 0x00A5A7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInHeroSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool isFromHeroTab;
			LuaObject.checkType(l, 3, out isFromHeroTab);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 4, out soldierInfo);
			heroSoldierSkinUIController.UpdateViewInHeroSoldierSkin(hero, isFromHeroTab, soldierInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F89D RID: 129181 RVA: 0x00A5C648 File Offset: 0x00A5A848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F89E RID: 129182 RVA: 0x00A5C69C File Offset: 0x00A5A89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LateUpdate(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.LateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F89F RID: 129183 RVA: 0x00A5C6F0 File Offset: 0x00A5A8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.ShowHeroSkin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A0 RID: 129184 RVA: 0x00A5C744 File Offset: 0x00A5A944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatDefaultHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.CreatDefaultHeroSkin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A1 RID: 129185 RVA: 0x00A5C798 File Offset: 0x00A5A998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			HeroOrSoliderSkinUIController heroInfoPanel;
			LuaObject.checkType<HeroOrSoliderSkinUIController>(l, 2, out heroInfoPanel);
			heroSoldierSkinUIController.m_luaExportHelper.SetHeroInfoPanel(heroInfoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A2 RID: 129186 RVA: 0x00A5C7F4 File Offset: 0x00A5A9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroButtonState(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			HeroOrSoliderSkinUIController heroButtonState;
			LuaObject.checkType<HeroOrSoliderSkinUIController>(l, 2, out heroButtonState);
			heroSoldierSkinUIController.m_luaExportHelper.SetHeroButtonState(heroButtonState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A3 RID: 129187 RVA: 0x00A5C850 File Offset: 0x00A5AA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.ShowSoldierSkin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A4 RID: 129188 RVA: 0x00A5C8A4 File Offset: 0x00A5AAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateDefaultSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.CreateDefaultSoldier();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A5 RID: 129189 RVA: 0x00A5C8F8 File Offset: 0x00A5AAF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			HeroOrSoliderSkinUIController soldierInfoPanel;
			LuaObject.checkType<HeroOrSoliderSkinUIController>(l, 2, out soldierInfoPanel);
			heroSoldierSkinUIController.m_luaExportHelper.SetSoldierInfoPanel(soldierInfoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A6 RID: 129190 RVA: 0x00A5C954 File Offset: 0x00A5AB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			HeroOrSoliderSkinUIController ctrl;
			LuaObject.checkType<HeroOrSoliderSkinUIController>(l, 2, out ctrl);
			heroSoldierSkinUIController.m_luaExportHelper.OnSkinItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A7 RID: 129191 RVA: 0x00A5C9B0 File Offset: 0x00A5ABB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowHeroToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroSoldierSkinUIController.m_luaExportHelper.OnShowHeroToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A8 RID: 129192 RVA: 0x00A5CA0C File Offset: 0x00A5AC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowSoldierToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroSoldierSkinUIController.m_luaExportHelper.OnShowSoldierToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8A9 RID: 129193 RVA: 0x00A5CA68 File Offset: 0x00A5AC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoUnavailableButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.OnInfoUnavailableButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8AA RID: 129194 RVA: 0x00A5CABC File Offset: 0x00A5ACBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.OnInfoBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8AB RID: 129195 RVA: 0x00A5CB10 File Offset: 0x00A5AD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoSwitchButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.OnInfoSwitchButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8AC RID: 129196 RVA: 0x00A5CB64 File Offset: 0x00A5AD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8AD RID: 129197 RVA: 0x00A5CBB8 File Offset: 0x00A5ADB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8AE RID: 129198 RVA: 0x00A5CC24 File Offset: 0x00A5AE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8AF RID: 129199 RVA: 0x00A5CC78 File Offset: 0x00A5AE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8B0 RID: 129200 RVA: 0x00A5CCCC File Offset: 0x00A5AECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroSoldierSkinUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F8B1 RID: 129201 RVA: 0x00A5CD74 File Offset: 0x00A5AF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8B2 RID: 129202 RVA: 0x00A5CDC8 File Offset: 0x00A5AFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8B3 RID: 129203 RVA: 0x00A5CE34 File Offset: 0x00A5B034
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
				HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroSoldierSkinUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroSoldierSkinUIController heroSoldierSkinUIController2 = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroSoldierSkinUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F8B4 RID: 129204 RVA: 0x00A5CF44 File Offset: 0x00A5B144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8B5 RID: 129205 RVA: 0x00A5CFB0 File Offset: 0x00A5B1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8B6 RID: 129206 RVA: 0x00A5D01C File Offset: 0x00A5B21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8B7 RID: 129207 RVA: 0x00A5D088 File Offset: 0x00A5B288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSoldierSkinUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8B8 RID: 129208 RVA: 0x00A5D0F4 File Offset: 0x00A5B2F4
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
				HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroSoldierSkinUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroSoldierSkinUIController heroSoldierSkinUIController2 = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroSoldierSkinUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F8B9 RID: 129209 RVA: 0x00A5D204 File Offset: 0x00A5B404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			string s = heroSoldierSkinUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F8BA RID: 129210 RVA: 0x00A5D260 File Offset: 0x00A5B460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			heroSoldierSkinUIController.m_luaExportHelper.__callDele_EventOnReturn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8BB RID: 129211 RVA: 0x00A5D2BC File Offset: 0x00A5B4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			heroSoldierSkinUIController.m_luaExportHelper.__clearDele_EventOnReturn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8BC RID: 129212 RVA: 0x00A5D318 File Offset: 0x00A5B518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBuyHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSoldierSkinUIController.m_luaExportHelper.__callDele_EventOnBuyHeroSkin(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8BD RID: 129213 RVA: 0x00A5D374 File Offset: 0x00A5B574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBuyHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSoldierSkinUIController.m_luaExportHelper.__clearDele_EventOnBuyHeroSkin(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8BE RID: 129214 RVA: 0x00A5D3D0 File Offset: 0x00A5B5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBuySoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSoldierSkinUIController.m_luaExportHelper.__callDele_EventOnBuySoldierSkin(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8BF RID: 129215 RVA: 0x00A5D42C File Offset: 0x00A5B62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBuySoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSoldierSkinUIController.m_luaExportHelper.__clearDele_EventOnBuySoldierSkin(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C0 RID: 129216 RVA: 0x00A5D488 File Offset: 0x00A5B688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTakeOffModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSoldierSkinUIController.m_luaExportHelper.__callDele_EventOnTakeOffModelSkin(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C1 RID: 129217 RVA: 0x00A5D4F4 File Offset: 0x00A5B6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTakeOffModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSoldierSkinUIController.m_luaExportHelper.__clearDele_EventOnTakeOffModelSkin(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C2 RID: 129218 RVA: 0x00A5D560 File Offset: 0x00A5B760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTakeOffSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSoldierSkinUIController.m_luaExportHelper.__callDele_EventOnTakeOffSoldierSkin(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C3 RID: 129219 RVA: 0x00A5D5CC File Offset: 0x00A5B7CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTakeOffSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSoldierSkinUIController.m_luaExportHelper.__clearDele_EventOnTakeOffSoldierSkin(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C4 RID: 129220 RVA: 0x00A5D638 File Offset: 0x00A5B838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnWearModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroSoldierSkinUIController.m_luaExportHelper.__callDele_EventOnWearModelSkin(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C5 RID: 129221 RVA: 0x00A5D6B0 File Offset: 0x00A5B8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWearModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroSoldierSkinUIController.m_luaExportHelper.__clearDele_EventOnWearModelSkin(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C6 RID: 129222 RVA: 0x00A5D728 File Offset: 0x00A5B928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnWearSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroSoldierSkinUIController.m_luaExportHelper.__callDele_EventOnWearSoldierSkin(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C7 RID: 129223 RVA: 0x00A5D7A0 File Offset: 0x00A5B9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWearSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroSoldierSkinUIController.m_luaExportHelper.__clearDele_EventOnWearSoldierSkin(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C8 RID: 129224 RVA: 0x00A5D818 File Offset: 0x00A5BA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8C9 RID: 129225 RVA: 0x00A5D870 File Offset: 0x00A5BA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroSoldierSkinUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8CA RID: 129226 RVA: 0x00A5D8CC File Offset: 0x00A5BACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rootGo(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_rootGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8CB RID: 129227 RVA: 0x00A5D924 File Offset: 0x00A5BB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rootGo(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			GameObject rootGo;
			LuaObject.checkType<GameObject>(l, 2, out rootGo);
			heroSoldierSkinUIController.m_luaExportHelper.m_rootGo = rootGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8CC RID: 129228 RVA: 0x00A5D980 File Offset: 0x00A5BB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollContent(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_scrollContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8CD RID: 129229 RVA: 0x00A5D9D8 File Offset: 0x00A5BBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollContent(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			GameObject scrollContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollContent);
			heroSoldierSkinUIController.m_luaExportHelper.m_scrollContent = scrollContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8CE RID: 129230 RVA: 0x00A5DA34 File Offset: 0x00A5BC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showToggleStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_showToggleStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8CF RID: 129231 RVA: 0x00A5DA8C File Offset: 0x00A5BC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showToggleStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			CommonUIStateController showToggleStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out showToggleStateCtrl);
			heroSoldierSkinUIController.m_luaExportHelper.m_showToggleStateCtrl = showToggleStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D0 RID: 129232 RVA: 0x00A5DAE8 File Offset: 0x00A5BCE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showHeroToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_showHeroToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D1 RID: 129233 RVA: 0x00A5DB40 File Offset: 0x00A5BD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showHeroToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Toggle showHeroToggle;
			LuaObject.checkType<Toggle>(l, 2, out showHeroToggle);
			heroSoldierSkinUIController.m_luaExportHelper.m_showHeroToggle = showHeroToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D2 RID: 129234 RVA: 0x00A5DB9C File Offset: 0x00A5BD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showSoliderToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_showSoliderToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D3 RID: 129235 RVA: 0x00A5DBF4 File Offset: 0x00A5BDF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showSoliderToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Toggle showSoliderToggle;
			LuaObject.checkType<Toggle>(l, 2, out showSoliderToggle);
			heroSoldierSkinUIController.m_luaExportHelper.m_showSoliderToggle = showSoliderToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D4 RID: 129236 RVA: 0x00A5DC50 File Offset: 0x00A5BE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_infoPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D5 RID: 129237 RVA: 0x00A5DCA8 File Offset: 0x00A5BEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			CommonUIStateController infoPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out infoPanelStateCtrl);
			heroSoldierSkinUIController.m_luaExportHelper.m_infoPanelStateCtrl = infoPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D6 RID: 129238 RVA: 0x00A5DD04 File Offset: 0x00A5BF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoTitleText(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_infoTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D7 RID: 129239 RVA: 0x00A5DD5C File Offset: 0x00A5BF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoTitleText(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Text infoTitleText;
			LuaObject.checkType<Text>(l, 2, out infoTitleText);
			heroSoldierSkinUIController.m_luaExportHelper.m_infoTitleText = infoTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D8 RID: 129240 RVA: 0x00A5DDB8 File Offset: 0x00A5BFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_infoDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8D9 RID: 129241 RVA: 0x00A5DE10 File Offset: 0x00A5C010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Text infoDescText;
			LuaObject.checkType<Text>(l, 2, out infoDescText);
			heroSoldierSkinUIController.m_luaExportHelper.m_infoDescText = infoDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8DA RID: 129242 RVA: 0x00A5DE6C File Offset: 0x00A5C06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroJobContent(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_infoHeroJobContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8DB RID: 129243 RVA: 0x00A5DEC4 File Offset: 0x00A5C0C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroJobContent(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			GameObject infoHeroJobContent;
			LuaObject.checkType<GameObject>(l, 2, out infoHeroJobContent);
			heroSoldierSkinUIController.m_luaExportHelper.m_infoHeroJobContent = infoHeroJobContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8DC RID: 129244 RVA: 0x00A5DF20 File Offset: 0x00A5C120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSwitchButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_infoSwitchButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8DD RID: 129245 RVA: 0x00A5DF78 File Offset: 0x00A5C178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSwitchButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Button infoSwitchButton;
			LuaObject.checkType<Button>(l, 2, out infoSwitchButton);
			heroSoldierSkinUIController.m_luaExportHelper.m_infoSwitchButton = infoSwitchButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8DE RID: 129246 RVA: 0x00A5DFD4 File Offset: 0x00A5C1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoUnavailableButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_infoUnavailableButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8DF RID: 129247 RVA: 0x00A5E02C File Offset: 0x00A5C22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoUnavailableButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Button infoUnavailableButton;
			LuaObject.checkType<Button>(l, 2, out infoUnavailableButton);
			heroSoldierSkinUIController.m_luaExportHelper.m_infoUnavailableButton = infoUnavailableButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8E0 RID: 129248 RVA: 0x00A5E088 File Offset: 0x00A5C288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoBuyButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_infoBuyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8E1 RID: 129249 RVA: 0x00A5E0E0 File Offset: 0x00A5C2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoBuyButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Button infoBuyButton;
			LuaObject.checkType<Button>(l, 2, out infoBuyButton);
			heroSoldierSkinUIController.m_luaExportHelper.m_infoBuyButton = infoBuyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8E2 RID: 129250 RVA: 0x00A5E13C File Offset: 0x00A5C33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoFromDetailText(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_infoFromDetailText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8E3 RID: 129251 RVA: 0x00A5E194 File Offset: 0x00A5C394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoFromDetailText(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Text infoFromDetailText;
			LuaObject.checkType<Text>(l, 2, out infoFromDetailText);
			heroSoldierSkinUIController.m_luaExportHelper.m_infoFromDetailText = infoFromDetailText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8E4 RID: 129252 RVA: 0x00A5E1F0 File Offset: 0x00A5C3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSoldierSkinItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_heroSoldierSkinItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8E5 RID: 129253 RVA: 0x00A5E248 File Offset: 0x00A5C448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSoldierSkinItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			GameObject heroSoldierSkinItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroSoldierSkinItemPrefab);
			heroSoldierSkinUIController.m_luaExportHelper.m_heroSoldierSkinItemPrefab = heroSoldierSkinItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8E6 RID: 129254 RVA: 0x00A5E2A4 File Offset: 0x00A5C4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSoldierSkinUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroSoldierSkinUIController.EventOnReturn -= value;
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

	// Token: 0x0601F8E7 RID: 129255 RVA: 0x00A5E324 File Offset: 0x00A5C524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBuyHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSoldierSkinUIController.EventOnBuyHeroSkin += value;
				}
				else if (num == 2)
				{
					heroSoldierSkinUIController.EventOnBuyHeroSkin -= value;
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

	// Token: 0x0601F8E8 RID: 129256 RVA: 0x00A5E3A4 File Offset: 0x00A5C5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBuySoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSoldierSkinUIController.EventOnBuySoldierSkin += value;
				}
				else if (num == 2)
				{
					heroSoldierSkinUIController.EventOnBuySoldierSkin -= value;
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

	// Token: 0x0601F8E9 RID: 129257 RVA: 0x00A5E424 File Offset: 0x00A5C624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTakeOffModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSoldierSkinUIController.EventOnTakeOffModelSkin += value;
				}
				else if (num == 2)
				{
					heroSoldierSkinUIController.EventOnTakeOffModelSkin -= value;
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

	// Token: 0x0601F8EA RID: 129258 RVA: 0x00A5E4A4 File Offset: 0x00A5C6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTakeOffSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSoldierSkinUIController.EventOnTakeOffSoldierSkin += value;
				}
				else if (num == 2)
				{
					heroSoldierSkinUIController.EventOnTakeOffSoldierSkin -= value;
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

	// Token: 0x0601F8EB RID: 129259 RVA: 0x00A5E524 File Offset: 0x00A5C724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWearModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Action<int, int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSoldierSkinUIController.EventOnWearModelSkin += value;
				}
				else if (num == 2)
				{
					heroSoldierSkinUIController.EventOnWearModelSkin -= value;
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

	// Token: 0x0601F8EC RID: 129260 RVA: 0x00A5E5A4 File Offset: 0x00A5C7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWearSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Action<int, int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSoldierSkinUIController.EventOnWearSoldierSkin += value;
				}
				else if (num == 2)
				{
					heroSoldierSkinUIController.EventOnWearSoldierSkin -= value;
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

	// Token: 0x0601F8ED RID: 129261 RVA: 0x00A5E624 File Offset: 0x00A5C824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8EE RID: 129262 RVA: 0x00A5E67C File Offset: 0x00A5C87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroSoldierSkinUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8EF RID: 129263 RVA: 0x00A5E6D8 File Offset: 0x00A5C8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFromHeroTab(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_isFromHeroTab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F0 RID: 129264 RVA: 0x00A5E730 File Offset: 0x00A5C930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFromHeroTab(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			bool isFromHeroTab;
			LuaObject.checkType(l, 2, out isFromHeroTab);
			heroSoldierSkinUIController.m_luaExportHelper.m_isFromHeroTab = isFromHeroTab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F1 RID: 129265 RVA: 0x00A5E78C File Offset: 0x00A5C98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_soldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F2 RID: 129266 RVA: 0x00A5E7E4 File Offset: 0x00A5C9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			heroSoldierSkinUIController.m_luaExportHelper.m_soldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F3 RID: 129267 RVA: 0x00A5E840 File Offset: 0x00A5CA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectHeroSkinItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_curSelectHeroSkinItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F4 RID: 129268 RVA: 0x00A5E898 File Offset: 0x00A5CA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectHeroSkinItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			HeroOrSoliderSkinUIController curSelectHeroSkinItemCtrl;
			LuaObject.checkType<HeroOrSoliderSkinUIController>(l, 2, out curSelectHeroSkinItemCtrl);
			heroSoldierSkinUIController.m_luaExportHelper.m_curSelectHeroSkinItemCtrl = curSelectHeroSkinItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F5 RID: 129269 RVA: 0x00A5E8F4 File Offset: 0x00A5CAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_itemCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F6 RID: 129270 RVA: 0x00A5E94C File Offset: 0x00A5CB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			List<HeroOrSoliderSkinUIController> itemCtrlList;
			LuaObject.checkType<List<HeroOrSoliderSkinUIController>>(l, 2, out itemCtrlList);
			heroSoldierSkinUIController.m_luaExportHelper.m_itemCtrlList = itemCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F7 RID: 129271 RVA: 0x00A5E9A8 File Offset: 0x00A5CBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F8 RID: 129272 RVA: 0x00A5EA00 File Offset: 0x00A5CC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroSoldierSkinUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8F9 RID: 129273 RVA: 0x00A5EA5C File Offset: 0x00A5CC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8FA RID: 129274 RVA: 0x00A5EAB4 File Offset: 0x00A5CCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUIController heroSoldierSkinUIController = (HeroSoldierSkinUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroSoldierSkinUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F8FB RID: 129275 RVA: 0x00A5EB10 File Offset: 0x00A5CD10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSoldierSkinUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.UpdateViewInHeroSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.LateUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.ShowHeroSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.CreatDefaultHeroSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.SetHeroInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.SetHeroButtonState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.ShowSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.CreateDefaultSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.SetSoldierInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.OnSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.OnShowHeroToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.OnShowSoldierToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.OnInfoUnavailableButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.OnInfoBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.OnInfoSwitchButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callDele_EventOnBuyHeroSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__clearDele_EventOnBuyHeroSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callDele_EventOnBuySoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__clearDele_EventOnBuySoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callDele_EventOnTakeOffModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__clearDele_EventOnTakeOffModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callDele_EventOnTakeOffSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__clearDele_EventOnTakeOffSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callDele_EventOnWearModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__clearDele_EventOnWearModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__callDele_EventOnWearSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.__clearDele_EventOnWearSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2C);
		string name = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_returnButton);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2E, true);
		string name2 = "m_rootGo";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_rootGo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_rootGo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache30, true);
		string name3 = "m_scrollContent";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_scrollContent);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_scrollContent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache32, true);
		string name4 = "m_showToggleStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_showToggleStateCtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_showToggleStateCtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache34, true);
		string name5 = "m_showHeroToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_showHeroToggle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_showHeroToggle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache36, true);
		string name6 = "m_showSoliderToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_showSoliderToggle);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_showSoliderToggle);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache38, true);
		string name7 = "m_infoPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_infoPanelStateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_infoPanelStateCtrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3A, true);
		string name8 = "m_infoTitleText";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_infoTitleText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_infoTitleText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3C, true);
		string name9 = "m_infoDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_infoDescText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_infoDescText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3E, true);
		string name10 = "m_infoHeroJobContent";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_infoHeroJobContent);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_infoHeroJobContent);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache40, true);
		string name11 = "m_infoSwitchButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_infoSwitchButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_infoSwitchButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache42, true);
		string name12 = "m_infoUnavailableButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_infoUnavailableButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_infoUnavailableButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache44, true);
		string name13 = "m_infoBuyButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_infoBuyButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_infoBuyButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache46, true);
		string name14 = "m_infoFromDetailText";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_infoFromDetailText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_infoFromDetailText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache48, true);
		string name15 = "m_heroSoldierSkinItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_heroSoldierSkinItemPrefab);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_heroSoldierSkinItemPrefab);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4A, true);
		string name16 = "EventOnReturn";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4B, true);
		string name17 = "EventOnBuyHeroSkin";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_EventOnBuyHeroSkin);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4C, true);
		string name18 = "EventOnBuySoldierSkin";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_EventOnBuySoldierSkin);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4D, true);
		string name19 = "EventOnTakeOffModelSkin";
		LuaCSFunction get19 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_EventOnTakeOffModelSkin);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4E, true);
		string name20 = "EventOnTakeOffSoldierSkin";
		LuaCSFunction get20 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_EventOnTakeOffSoldierSkin);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache4F, true);
		string name21 = "EventOnWearModelSkin";
		LuaCSFunction get21 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_EventOnWearModelSkin);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache50, true);
		string name22 = "EventOnWearSoldierSkin";
		LuaCSFunction get22 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_EventOnWearSoldierSkin);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache51, true);
		string name23 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_hero);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_hero);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache53, true);
		string name24 = "m_isFromHeroTab";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_isFromHeroTab);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_isFromHeroTab);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache55, true);
		string name25 = "m_soldierInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_soldierInfo);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_soldierInfo);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache57, true);
		string name26 = "m_curSelectHeroSkinItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_curSelectHeroSkinItemCtrl);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_curSelectHeroSkinItemCtrl);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache59, true);
		string name27 = "m_itemCtrlList";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_itemCtrlList);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_itemCtrlList);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5B, true);
		string name28 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_playerContext);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5D, true);
		string name29 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.get_m_configDataLoader);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.<>f__mg$cache5F, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroSoldierSkinUIController), typeof(UIControllerBase));
	}

	// Token: 0x040158B1 RID: 88241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040158B2 RID: 88242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040158B3 RID: 88243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040158B4 RID: 88244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040158B5 RID: 88245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040158B6 RID: 88246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040158B7 RID: 88247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040158B8 RID: 88248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040158B9 RID: 88249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040158BA RID: 88250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040158BB RID: 88251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040158BC RID: 88252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040158BD RID: 88253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040158BE RID: 88254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040158BF RID: 88255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040158C0 RID: 88256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040158C1 RID: 88257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040158C2 RID: 88258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040158C3 RID: 88259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040158C4 RID: 88260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040158C5 RID: 88261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040158C6 RID: 88262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040158C7 RID: 88263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040158C8 RID: 88264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040158C9 RID: 88265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040158CA RID: 88266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040158CB RID: 88267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040158CC RID: 88268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040158CD RID: 88269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040158CE RID: 88270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040158CF RID: 88271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040158D0 RID: 88272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040158D1 RID: 88273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040158D2 RID: 88274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040158D3 RID: 88275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040158D4 RID: 88276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040158D5 RID: 88277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040158D6 RID: 88278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040158D7 RID: 88279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040158D8 RID: 88280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040158D9 RID: 88281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040158DA RID: 88282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040158DB RID: 88283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040158DC RID: 88284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040158DD RID: 88285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040158DE RID: 88286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040158DF RID: 88287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040158E0 RID: 88288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040158E1 RID: 88289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040158E2 RID: 88290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040158E3 RID: 88291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040158E4 RID: 88292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040158E5 RID: 88293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040158E6 RID: 88294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040158E7 RID: 88295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040158E8 RID: 88296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040158E9 RID: 88297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040158EA RID: 88298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040158EB RID: 88299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040158EC RID: 88300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040158ED RID: 88301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040158EE RID: 88302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040158EF RID: 88303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040158F0 RID: 88304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040158F1 RID: 88305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040158F2 RID: 88306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040158F3 RID: 88307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040158F4 RID: 88308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040158F5 RID: 88309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040158F6 RID: 88310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040158F7 RID: 88311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040158F8 RID: 88312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040158F9 RID: 88313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040158FA RID: 88314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040158FB RID: 88315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040158FC RID: 88316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040158FD RID: 88317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040158FE RID: 88318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040158FF RID: 88319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04015900 RID: 88320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04015901 RID: 88321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04015902 RID: 88322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04015903 RID: 88323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04015904 RID: 88324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04015905 RID: 88325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04015906 RID: 88326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04015907 RID: 88327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04015908 RID: 88328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04015909 RID: 88329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401590A RID: 88330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401590B RID: 88331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401590C RID: 88332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401590D RID: 88333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401590E RID: 88334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401590F RID: 88335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04015910 RID: 88336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;
}
