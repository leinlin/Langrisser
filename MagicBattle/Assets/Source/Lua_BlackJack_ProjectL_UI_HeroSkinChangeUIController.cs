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

// Token: 0x020014E2 RID: 5346
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController : LuaObject
{
	// Token: 0x0601F7C4 RID: 128964 RVA: 0x00A5598C File Offset: 0x00A53B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string mode;
			LuaObject.checkType(l, 2, out mode);
			heroSkinChangeUIController.Open(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7C5 RID: 128965 RVA: 0x00A559E4 File Offset: 0x00A53BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInHeroCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int heroSkinInfoId;
			LuaObject.checkType(l, 2, out heroSkinInfoId);
			string mode;
			LuaObject.checkType(l, 3, out mode);
			Hero hero;
			LuaObject.checkType<Hero>(l, 4, out hero);
			heroSkinChangeUIController.UpdateViewInHeroCharSkin(heroSkinInfoId, mode, hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7C6 RID: 128966 RVA: 0x00A55A58 File Offset: 0x00A53C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseHeroSkinChangePanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			heroSkinChangeUIController.CloseHeroSkinChangePanel(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7C7 RID: 128967 RVA: 0x00A55AB0 File Offset: 0x00A53CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearData(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.ClearData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7C8 RID: 128968 RVA: 0x00A55AFC File Offset: 0x00A53CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7C9 RID: 128969 RVA: 0x00A55B50 File Offset: 0x00A53D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LateUpdate(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.LateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7CA RID: 128970 RVA: 0x00A55BA4 File Offset: 0x00A53DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectSkinPanelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.SetSelectSkinPanelInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7CB RID: 128971 RVA: 0x00A55BF8 File Offset: 0x00A53DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateHeroDefaultSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.CreateHeroDefaultSkin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7CC RID: 128972 RVA: 0x00A55C4C File Offset: 0x00A53E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkinInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController skinInfoPanel;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out skinInfoPanel);
			heroSkinChangeUIController.m_luaExportHelper.SetSkinInfoPanel(skinInfoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7CD RID: 128973 RVA: 0x00A55CA8 File Offset: 0x00A53EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNotDefaultSkinInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController notDefaultSkinInfoPanel;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out notDefaultSkinInfoPanel);
			heroSkinChangeUIController.m_luaExportHelper.SetNotDefaultSkinInfoPanel(notDefaultSkinInfoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7CE RID: 128974 RVA: 0x00A55D04 File Offset: 0x00A53F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetButtonState(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController buttonState;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out buttonState);
			heroSkinChangeUIController.m_luaExportHelper.SetButtonState(buttonState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7CF RID: 128975 RVA: 0x00A55D60 File Offset: 0x00A53F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroSkinCharAndSpine(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController heroSkinCharAndSpine;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out heroSkinCharAndSpine);
			heroSkinChangeUIController.m_luaExportHelper.SetHeroSkinCharAndSpine(heroSkinCharAndSpine);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D0 RID: 128976 RVA: 0x00A55DBC File Offset: 0x00A53FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDefaultSkinInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController defaultSkinInfoPanel;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out defaultSkinInfoPanel);
			heroSkinChangeUIController.m_luaExportHelper.SetDefaultSkinInfoPanel(defaultSkinInfoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D1 RID: 128977 RVA: 0x00A55E18 File Offset: 0x00A54018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroCharSkinItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController ctrl;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out ctrl);
			heroSkinChangeUIController.m_luaExportHelper.OnHeroCharSkinItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D2 RID: 128978 RVA: 0x00A55E74 File Offset: 0x00A54074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkinsScrollSnapCenter_OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.SkinsScrollSnapCenter_OnEndDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D3 RID: 128979 RVA: 0x00A55EC8 File Offset: 0x00A540C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.OnInfoBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D4 RID: 128980 RVA: 0x00A55F1C File Offset: 0x00A5411C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoSwitchButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.OnInfoSwitchButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D5 RID: 128981 RVA: 0x00A55F70 File Offset: 0x00A54170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D6 RID: 128982 RVA: 0x00A55FC4 File Offset: 0x00A541C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkinTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.OnSkinTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D7 RID: 128983 RVA: 0x00A56018 File Offset: 0x00A54218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.OnBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D8 RID: 128984 RVA: 0x00A5606C File Offset: 0x00A5426C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7D9 RID: 128985 RVA: 0x00A560D8 File Offset: 0x00A542D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7DA RID: 128986 RVA: 0x00A5612C File Offset: 0x00A5432C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7DB RID: 128987 RVA: 0x00A56180 File Offset: 0x00A54380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroSkinChangeUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F7DC RID: 128988 RVA: 0x00A56228 File Offset: 0x00A54428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7DD RID: 128989 RVA: 0x00A5627C File Offset: 0x00A5447C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7DE RID: 128990 RVA: 0x00A562E8 File Offset: 0x00A544E8
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
				HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroSkinChangeUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroSkinChangeUIController heroSkinChangeUIController2 = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroSkinChangeUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F7DF RID: 128991 RVA: 0x00A563F8 File Offset: 0x00A545F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7E0 RID: 128992 RVA: 0x00A56464 File Offset: 0x00A54664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7E1 RID: 128993 RVA: 0x00A564D0 File Offset: 0x00A546D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7E2 RID: 128994 RVA: 0x00A5653C File Offset: 0x00A5473C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkinChangeUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7E3 RID: 128995 RVA: 0x00A565A8 File Offset: 0x00A547A8
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
				HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroSkinChangeUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroSkinChangeUIController heroSkinChangeUIController2 = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroSkinChangeUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F7E4 RID: 128996 RVA: 0x00A566B8 File Offset: 0x00A548B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string s = heroSkinChangeUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F7E5 RID: 128997 RVA: 0x00A56714 File Offset: 0x00A54914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7E6 RID: 128998 RVA: 0x00A56768 File Offset: 0x00A54968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7E7 RID: 128999 RVA: 0x00A567BC File Offset: 0x00A549BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBuySkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSkinChangeUIController.m_luaExportHelper.__callDele_EventOnBuySkin(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7E8 RID: 129000 RVA: 0x00A56818 File Offset: 0x00A54A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBuySkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSkinChangeUIController.m_luaExportHelper.__clearDele_EventOnBuySkin(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7E9 RID: 129001 RVA: 0x00A56874 File Offset: 0x00A54A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnWearCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSkinChangeUIController.m_luaExportHelper.__callDele_EventOnWearCharSkin(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7EA RID: 129002 RVA: 0x00A568E0 File Offset: 0x00A54AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWearCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSkinChangeUIController.m_luaExportHelper.__clearDele_EventOnWearCharSkin(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7EB RID: 129003 RVA: 0x00A5694C File Offset: 0x00A54B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTakeOffCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSkinChangeUIController.m_luaExportHelper.__callDele_EventOnTakeOffCharSkin(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7EC RID: 129004 RVA: 0x00A569A8 File Offset: 0x00A54BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTakeOffCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSkinChangeUIController.m_luaExportHelper.__clearDele_EventOnTakeOffCharSkin(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7ED RID: 129005 RVA: 0x00A56A04 File Offset: 0x00A54C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkinChangedPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSkinChangeUIController.m_luaExportHelper.__callDele_EventOnSkinChangedPreview(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7EE RID: 129006 RVA: 0x00A56A70 File Offset: 0x00A54C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkinChangedPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSkinChangeUIController.m_luaExportHelper.__clearDele_EventOnSkinChangedPreview(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7EF RID: 129007 RVA: 0x00A56ADC File Offset: 0x00A54CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkinTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.__callDele_EventOnSkinTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7F0 RID: 129008 RVA: 0x00A56B30 File Offset: 0x00A54D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkinTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			heroSkinChangeUIController.m_luaExportHelper.__clearDele_EventOnSkinTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7F1 RID: 129009 RVA: 0x00A56B84 File Offset: 0x00A54D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUIController.EventOnReturn -= value;
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

	// Token: 0x0601F7F2 RID: 129010 RVA: 0x00A56C04 File Offset: 0x00A54E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBuySkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUIController.EventOnBuySkin += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUIController.EventOnBuySkin -= value;
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

	// Token: 0x0601F7F3 RID: 129011 RVA: 0x00A56C84 File Offset: 0x00A54E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWearCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUIController.EventOnWearCharSkin += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUIController.EventOnWearCharSkin -= value;
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

	// Token: 0x0601F7F4 RID: 129012 RVA: 0x00A56D04 File Offset: 0x00A54F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTakeOffCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUIController.EventOnTakeOffCharSkin += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUIController.EventOnTakeOffCharSkin -= value;
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

	// Token: 0x0601F7F5 RID: 129013 RVA: 0x00A56D84 File Offset: 0x00A54F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkinChangedPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Action<string, int> value;
			int num = LuaObject.checkDelegate<Action<string, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUIController.EventOnSkinChangedPreview += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUIController.EventOnSkinChangedPreview -= value;
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

	// Token: 0x0601F7F6 RID: 129014 RVA: 0x00A56E04 File Offset: 0x00A55004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkinTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUIController.EventOnSkinTicketButtonClick += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUIController.EventOnSkinTicketButtonClick -= value;
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

	// Token: 0x0601F7F7 RID: 129015 RVA: 0x00A56E84 File Offset: 0x00A55084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7F8 RID: 129016 RVA: 0x00A56EDC File Offset: 0x00A550DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroSkinChangeUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7F9 RID: 129017 RVA: 0x00A56F38 File Offset: 0x00A55138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7FA RID: 129018 RVA: 0x00A56F90 File Offset: 0x00A55190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			heroSkinChangeUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7FB RID: 129019 RVA: 0x00A56FEC File Offset: 0x00A551EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_facelifPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_facelifPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7FC RID: 129020 RVA: 0x00A57044 File Offset: 0x00A55244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_facelifPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			GameObject facelifPanel;
			LuaObject.checkType<GameObject>(l, 2, out facelifPanel);
			heroSkinChangeUIController.m_luaExportHelper.m_facelifPanel = facelifPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7FD RID: 129021 RVA: 0x00A570A0 File Offset: 0x00A552A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7FE RID: 129022 RVA: 0x00A570F8 File Offset: 0x00A552F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroSkinChangeUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7FF RID: 129023 RVA: 0x00A57154 File Offset: 0x00A55354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_closeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F800 RID: 129024 RVA: 0x00A571AC File Offset: 0x00A553AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			heroSkinChangeUIController.m_luaExportHelper.m_closeButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F801 RID: 129025 RVA: 0x00A57208 File Offset: 0x00A55408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_blackBgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_blackBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F802 RID: 129026 RVA: 0x00A57260 File Offset: 0x00A55460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_blackBgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Button blackBgButton;
			LuaObject.checkType<Button>(l, 2, out blackBgButton);
			heroSkinChangeUIController.m_luaExportHelper.m_blackBgButton = blackBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F803 RID: 129027 RVA: 0x00A572BC File Offset: 0x00A554BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinsScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_skinsScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F804 RID: 129028 RVA: 0x00A57314 File Offset: 0x00A55514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinsScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			ScrollRect skinsScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out skinsScrollRect);
			heroSkinChangeUIController.m_luaExportHelper.m_skinsScrollRect = skinsScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F805 RID: 129029 RVA: 0x00A57370 File Offset: 0x00A55570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinSelectContent(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_skinSelectContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F806 RID: 129030 RVA: 0x00A573C8 File Offset: 0x00A555C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinSelectContent(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			GameObject skinSelectContent;
			LuaObject.checkType<GameObject>(l, 2, out skinSelectContent);
			heroSkinChangeUIController.m_luaExportHelper.m_skinSelectContent = skinSelectContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F807 RID: 129031 RVA: 0x00A57424 File Offset: 0x00A55624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinJobGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_skinJobGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F808 RID: 129032 RVA: 0x00A5747C File Offset: 0x00A5567C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinJobGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			GameObject skinJobGroup;
			LuaObject.checkType<GameObject>(l, 2, out skinJobGroup);
			heroSkinChangeUIController.m_luaExportHelper.m_skinJobGroup = skinJobGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F809 RID: 129033 RVA: 0x00A574D8 File Offset: 0x00A556D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinCharGo(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_skinCharGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F80A RID: 129034 RVA: 0x00A57530 File Offset: 0x00A55730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinCharGo(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			GameObject skinCharGo;
			LuaObject.checkType<GameObject>(l, 2, out skinCharGo);
			heroSkinChangeUIController.m_luaExportHelper.m_skinCharGo = skinCharGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F80B RID: 129035 RVA: 0x00A5758C File Offset: 0x00A5578C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_skinDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F80C RID: 129036 RVA: 0x00A575E4 File Offset: 0x00A557E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Text skinDescText;
			LuaObject.checkType<Text>(l, 2, out skinDescText);
			heroSkinChangeUIController.m_luaExportHelper.m_skinDescText = skinDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F80D RID: 129037 RVA: 0x00A57640 File Offset: 0x00A55840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_buttonGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F80E RID: 129038 RVA: 0x00A57698 File Offset: 0x00A55898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buttonGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			CommonUIStateController buttonGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out buttonGroupStateCtrl);
			heroSkinChangeUIController.m_luaExportHelper.m_buttonGroupStateCtrl = buttonGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F80F RID: 129039 RVA: 0x00A576F4 File Offset: 0x00A558F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fromText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_fromText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F810 RID: 129040 RVA: 0x00A5774C File Offset: 0x00A5594C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fromText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Text fromText;
			LuaObject.checkType<Text>(l, 2, out fromText);
			heroSkinChangeUIController.m_luaExportHelper.m_fromText = fromText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F811 RID: 129041 RVA: 0x00A577A8 File Offset: 0x00A559A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSwitchButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_infoSwitchButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F812 RID: 129042 RVA: 0x00A57800 File Offset: 0x00A55A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSwitchButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Button infoSwitchButton;
			LuaObject.checkType<Button>(l, 2, out infoSwitchButton);
			heroSkinChangeUIController.m_luaExportHelper.m_infoSwitchButton = infoSwitchButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F813 RID: 129043 RVA: 0x00A5785C File Offset: 0x00A55A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoBuyButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_infoBuyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F814 RID: 129044 RVA: 0x00A578B4 File Offset: 0x00A55AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoBuyButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Button infoBuyButton;
			LuaObject.checkType<Button>(l, 2, out infoBuyButton);
			heroSkinChangeUIController.m_luaExportHelper.m_infoBuyButton = infoBuyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F815 RID: 129045 RVA: 0x00A57910 File Offset: 0x00A55B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoBuyValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_infoBuyValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F816 RID: 129046 RVA: 0x00A57968 File Offset: 0x00A55B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoBuyValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Text infoBuyValueText;
			LuaObject.checkType<Text>(l, 2, out infoBuyValueText);
			heroSkinChangeUIController.m_luaExportHelper.m_infoBuyValueText = infoBuyValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F817 RID: 129047 RVA: 0x00A579C4 File Offset: 0x00A55BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinTicketCountText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_skinTicketCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F818 RID: 129048 RVA: 0x00A57A1C File Offset: 0x00A55C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinTicketCountText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Text skinTicketCountText;
			LuaObject.checkType<Text>(l, 2, out skinTicketCountText);
			heroSkinChangeUIController.m_luaExportHelper.m_skinTicketCountText = skinTicketCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F819 RID: 129049 RVA: 0x00A57A78 File Offset: 0x00A55C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinTicketAddButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_skinTicketAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F81A RID: 129050 RVA: 0x00A57AD0 File Offset: 0x00A55CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinTicketAddButton(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Button skinTicketAddButton;
			LuaObject.checkType<Button>(l, 2, out skinTicketAddButton);
			heroSkinChangeUIController.m_luaExportHelper.m_skinTicketAddButton = skinTicketAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F81B RID: 129051 RVA: 0x00A57B2C File Offset: 0x00A55D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F81C RID: 129052 RVA: 0x00A57B84 File Offset: 0x00A55D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroSkinChangeUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F81D RID: 129053 RVA: 0x00A57BE0 File Offset: 0x00A55DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F81E RID: 129054 RVA: 0x00A57C38 File Offset: 0x00A55E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroSkinChangeUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F81F RID: 129055 RVA: 0x00A57C94 File Offset: 0x00A55E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F820 RID: 129056 RVA: 0x00A57CEC File Offset: 0x00A55EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroSkinChangeUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F821 RID: 129057 RVA: 0x00A57D48 File Offset: 0x00A55F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mode(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_mode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F822 RID: 129058 RVA: 0x00A57DA0 File Offset: 0x00A55FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mode(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			string mode;
			LuaObject.checkType(l, 2, out mode);
			heroSkinChangeUIController.m_luaExportHelper.m_mode = mode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F823 RID: 129059 RVA: 0x00A57DFC File Offset: 0x00A55FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSkinInfoId(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_heroSkinInfoId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F824 RID: 129060 RVA: 0x00A57E54 File Offset: 0x00A56054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSkinInfoId(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int heroSkinInfoId;
			LuaObject.checkType(l, 2, out heroSkinInfoId);
			heroSkinChangeUIController.m_luaExportHelper.m_heroSkinInfoId = heroSkinInfoId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F825 RID: 129061 RVA: 0x00A57EB0 File Offset: 0x00A560B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curCharSkinIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_curCharSkinIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F826 RID: 129062 RVA: 0x00A57F08 File Offset: 0x00A56108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curCharSkinIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			int curCharSkinIndex;
			LuaObject.checkType(l, 2, out curCharSkinIndex);
			heroSkinChangeUIController.m_luaExportHelper.m_curCharSkinIndex = curCharSkinIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F827 RID: 129063 RVA: 0x00A57F64 File Offset: 0x00A56164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_heroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F828 RID: 129064 RVA: 0x00A57FBC File Offset: 0x00A561BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			heroSkinChangeUIController.m_luaExportHelper.m_heroInfo = heroInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F829 RID: 129065 RVA: 0x00A58018 File Offset: 0x00A56218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_playerHeroGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F82A RID: 129066 RVA: 0x00A58070 File Offset: 0x00A56270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			UISpineGraphic playerHeroGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out playerHeroGraphic);
			heroSkinChangeUIController.m_luaExportHelper.m_playerHeroGraphic = playerHeroGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F82B RID: 129067 RVA: 0x00A580CC File Offset: 0x00A562CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinsScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_skinsScrollSnapCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F82C RID: 129068 RVA: 0x00A58124 File Offset: 0x00A56324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinsScrollSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			ScrollSnapCenter skinsScrollSnapCenter;
			LuaObject.checkType<ScrollSnapCenter>(l, 2, out skinsScrollSnapCenter);
			heroSkinChangeUIController.m_luaExportHelper.m_skinsScrollSnapCenter = skinsScrollSnapCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F82D RID: 129069 RVA: 0x00A58180 File Offset: 0x00A56380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F82E RID: 129070 RVA: 0x00A581D8 File Offset: 0x00A563D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			heroSkinChangeUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F82F RID: 129071 RVA: 0x00A58234 File Offset: 0x00A56434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectHeroCharSkinItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_curSelectHeroCharSkinItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F830 RID: 129072 RVA: 0x00A5828C File Offset: 0x00A5648C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectHeroCharSkinItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController curSelectHeroCharSkinItemCtrl;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out curSelectHeroCharSkinItemCtrl);
			heroSkinChangeUIController.m_luaExportHelper.m_curSelectHeroCharSkinItemCtrl = curSelectHeroCharSkinItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F831 RID: 129073 RVA: 0x00A582E8 File Offset: 0x00A564E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charSkinCtrlsList(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUIController.m_luaExportHelper.m_charSkinCtrlsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F832 RID: 129074 RVA: 0x00A58340 File Offset: 0x00A56540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charSkinCtrlsList(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUIController heroSkinChangeUIController = (HeroSkinChangeUIController)LuaObject.checkSelf(l);
			List<HeroCharSkinItemUIController> charSkinCtrlsList;
			LuaObject.checkType<List<HeroCharSkinItemUIController>>(l, 2, out charSkinCtrlsList);
			heroSkinChangeUIController.m_luaExportHelper.m_charSkinCtrlsList = charSkinCtrlsList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F833 RID: 129075 RVA: 0x00A5839C File Offset: 0x00A5659C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSkinChangeUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.UpdateViewInHeroCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.CloseHeroSkinChangePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.ClearData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.LateUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.SetSelectSkinPanelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.CreateHeroDefaultSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.SetSkinInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.SetNotDefaultSkinInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.SetButtonState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.SetHeroSkinCharAndSpine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.SetDefaultSkinInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.OnHeroCharSkinItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.SkinsScrollSnapCenter_OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.OnInfoBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.OnInfoSwitchButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.OnSkinTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.OnBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callDele_EventOnBuySkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__clearDele_EventOnBuySkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callDele_EventOnWearCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__clearDele_EventOnWearCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callDele_EventOnTakeOffCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__clearDele_EventOnTakeOffCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callDele_EventOnSkinChangedPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__clearDele_EventOnSkinChangedPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__callDele_EventOnSkinTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.__clearDele_EventOnSkinTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2C);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2D, true);
		string name2 = "EventOnBuySkin";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_EventOnBuySkin);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2E, true);
		string name3 = "EventOnWearCharSkin";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_EventOnWearCharSkin);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache2F, true);
		string name4 = "EventOnTakeOffCharSkin";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_EventOnTakeOffCharSkin);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache30, true);
		string name5 = "EventOnSkinChangedPreview";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_EventOnSkinChangedPreview);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache31, true);
		string name6 = "EventOnSkinTicketButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_EventOnSkinTicketButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache32, true);
		string name7 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_marginTransform);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache34, true);
		string name8 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_stateCtrl);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache36, true);
		string name9 = "m_facelifPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_facelifPanel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_facelifPanel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache38, true);
		string name10 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_returnButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3A, true);
		string name11 = "m_closeButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_closeButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_closeButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3C, true);
		string name12 = "m_blackBgButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_blackBgButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_blackBgButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3E, true);
		string name13 = "m_skinsScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_skinsScrollRect);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_skinsScrollRect);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache40, true);
		string name14 = "m_skinSelectContent";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_skinSelectContent);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_skinSelectContent);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache42, true);
		string name15 = "m_skinJobGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_skinJobGroup);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_skinJobGroup);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache44, true);
		string name16 = "m_skinCharGo";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_skinCharGo);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_skinCharGo);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache46, true);
		string name17 = "m_skinDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_skinDescText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_skinDescText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache48, true);
		string name18 = "m_buttonGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_buttonGroupStateCtrl);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_buttonGroupStateCtrl);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4A, true);
		string name19 = "m_fromText";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_fromText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_fromText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4C, true);
		string name20 = "m_infoSwitchButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_infoSwitchButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_infoSwitchButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4E, true);
		string name21 = "m_infoBuyButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_infoBuyButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_infoBuyButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache50, true);
		string name22 = "m_infoBuyValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_infoBuyValueText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_infoBuyValueText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache52, true);
		string name23 = "m_skinTicketCountText";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_skinTicketCountText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_skinTicketCountText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache54, true);
		string name24 = "m_skinTicketAddButton";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_skinTicketAddButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_skinTicketAddButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache56, true);
		string name25 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_playerContext);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache58, true);
		string name26 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_configDataLoader);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5A, true);
		string name27 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_hero);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_hero);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5C, true);
		string name28 = "m_mode";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_mode);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_mode);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5E, true);
		string name29 = "m_heroSkinInfoId";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_heroSkinInfoId);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_heroSkinInfoId);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache60, true);
		string name30 = "m_curCharSkinIndex";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_curCharSkinIndex);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_curCharSkinIndex);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache62, true);
		string name31 = "m_heroInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_heroInfo);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_heroInfo);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache64, true);
		string name32 = "m_playerHeroGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_playerHeroGraphic);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_playerHeroGraphic);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache66, true);
		string name33 = "m_skinsScrollSnapCenter";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_skinsScrollSnapCenter);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_skinsScrollSnapCenter);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache68, true);
		string name34 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6A, true);
		string name35 = "m_curSelectHeroCharSkinItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_curSelectHeroCharSkinItemCtrl);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_curSelectHeroCharSkinItemCtrl);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6C, true);
		string name36 = "m_charSkinCtrlsList";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.get_m_charSkinCtrlsList);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.set_m_charSkinCtrlsList);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.<>f__mg$cache6E, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroSkinChangeUIController), typeof(UIControllerBase));
	}

	// Token: 0x040157E2 RID: 88034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040157E3 RID: 88035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040157E4 RID: 88036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040157E5 RID: 88037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040157E6 RID: 88038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040157E7 RID: 88039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040157E8 RID: 88040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040157E9 RID: 88041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040157EA RID: 88042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040157EB RID: 88043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040157EC RID: 88044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040157ED RID: 88045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040157EE RID: 88046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040157EF RID: 88047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040157F0 RID: 88048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040157F1 RID: 88049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040157F2 RID: 88050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040157F3 RID: 88051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040157F4 RID: 88052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040157F5 RID: 88053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040157F6 RID: 88054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040157F7 RID: 88055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040157F8 RID: 88056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040157F9 RID: 88057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040157FA RID: 88058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040157FB RID: 88059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040157FC RID: 88060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040157FD RID: 88061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040157FE RID: 88062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040157FF RID: 88063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015800 RID: 88064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015801 RID: 88065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015802 RID: 88066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015803 RID: 88067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015804 RID: 88068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015805 RID: 88069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015806 RID: 88070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015807 RID: 88071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015808 RID: 88072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015809 RID: 88073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401580A RID: 88074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401580B RID: 88075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401580C RID: 88076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401580D RID: 88077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401580E RID: 88078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401580F RID: 88079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015810 RID: 88080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015811 RID: 88081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015812 RID: 88082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015813 RID: 88083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015814 RID: 88084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015815 RID: 88085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015816 RID: 88086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015817 RID: 88087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015818 RID: 88088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015819 RID: 88089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401581A RID: 88090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401581B RID: 88091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401581C RID: 88092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401581D RID: 88093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401581E RID: 88094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401581F RID: 88095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015820 RID: 88096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015821 RID: 88097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015822 RID: 88098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015823 RID: 88099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015824 RID: 88100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015825 RID: 88101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015826 RID: 88102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04015827 RID: 88103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04015828 RID: 88104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04015829 RID: 88105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401582A RID: 88106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401582B RID: 88107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401582C RID: 88108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401582D RID: 88109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401582E RID: 88110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401582F RID: 88111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04015830 RID: 88112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04015831 RID: 88113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04015832 RID: 88114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04015833 RID: 88115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04015834 RID: 88116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04015835 RID: 88117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04015836 RID: 88118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04015837 RID: 88119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04015838 RID: 88120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04015839 RID: 88121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401583A RID: 88122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401583B RID: 88123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401583C RID: 88124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401583D RID: 88125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401583E RID: 88126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401583F RID: 88127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04015840 RID: 88128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04015841 RID: 88129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04015842 RID: 88130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04015843 RID: 88131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04015844 RID: 88132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04015845 RID: 88133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04015846 RID: 88134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04015847 RID: 88135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04015848 RID: 88136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04015849 RID: 88137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401584A RID: 88138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401584B RID: 88139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401584C RID: 88140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401584D RID: 88141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401584E RID: 88142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401584F RID: 88143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04015850 RID: 88144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;
}
