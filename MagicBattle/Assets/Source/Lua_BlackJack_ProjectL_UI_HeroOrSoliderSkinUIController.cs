using System;
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

// Token: 0x020014D5 RID: 5333
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController : LuaObject
{
	// Token: 0x0601F5CF RID: 128463 RVA: 0x00A45B44 File Offset: 0x00A43D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroSkinItem(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 3, out jobConnectionInfo);
			int skinId;
			LuaObject.checkType(l, 4, out skinId);
			heroOrSoliderSkinUIController.InitHeroSkinItem(hero, jobConnectionInfo, skinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D0 RID: 128464 RVA: 0x00A45BB8 File Offset: 0x00A43DB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitDefaultHeroSkinItem(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroOrSoliderSkinUIController.InitDefaultHeroSkinItem(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D1 RID: 128465 RVA: 0x00A45C10 File Offset: 0x00A43E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSoldierSkinItem(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Soldier2SkinResource item;
			LuaObject.checkType<Soldier2SkinResource>(l, 2, out item);
			ConfigDataSoldierSkinInfo soldierSkinInfo;
			LuaObject.checkType<ConfigDataSoldierSkinInfo>(l, 3, out soldierSkinInfo);
			Hero hero;
			LuaObject.checkType<Hero>(l, 4, out hero);
			heroOrSoliderSkinUIController.InitSoldierSkinItem(item, soldierSkinInfo, hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D2 RID: 128466 RVA: 0x00A45C84 File Offset: 0x00A43E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDefaultSoldierSkinItem(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out soldierInfo);
			heroOrSoliderSkinUIController.InitDefaultSoldierSkinItem(hero, soldierInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D3 RID: 128467 RVA: 0x00A45CE8 File Offset: 0x00A43EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			heroOrSoliderSkinUIController.ShowSelectImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D4 RID: 128468 RVA: 0x00A45D40 File Offset: 0x00A43F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLimitTime(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			heroOrSoliderSkinUIController.SetLimitTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D5 RID: 128469 RVA: 0x00A45D8C File Offset: 0x00A43F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			heroOrSoliderSkinUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D6 RID: 128470 RVA: 0x00A45DE0 File Offset: 0x00A43FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroJobCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			heroOrSoliderSkinUIController.m_luaExportHelper.OnHeroJobCardItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D7 RID: 128471 RVA: 0x00A45E34 File Offset: 0x00A44034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D8 RID: 128472 RVA: 0x00A45EA0 File Offset: 0x00A440A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5D9 RID: 128473 RVA: 0x00A45EF4 File Offset: 0x00A440F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5DA RID: 128474 RVA: 0x00A45F48 File Offset: 0x00A44148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F5DB RID: 128475 RVA: 0x00A45FF0 File Offset: 0x00A441F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5DC RID: 128476 RVA: 0x00A46044 File Offset: 0x00A44244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5DD RID: 128477 RVA: 0x00A460B0 File Offset: 0x00A442B0
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
				HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroOrSoliderSkinUIController heroOrSoliderSkinUIController2 = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroOrSoliderSkinUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F5DE RID: 128478 RVA: 0x00A461C0 File Offset: 0x00A443C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5DF RID: 128479 RVA: 0x00A4622C File Offset: 0x00A4442C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5E0 RID: 128480 RVA: 0x00A46298 File Offset: 0x00A44498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5E1 RID: 128481 RVA: 0x00A46304 File Offset: 0x00A44504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5E2 RID: 128482 RVA: 0x00A46370 File Offset: 0x00A44570
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
				HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroOrSoliderSkinUIController heroOrSoliderSkinUIController2 = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroOrSoliderSkinUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F5E3 RID: 128483 RVA: 0x00A46480 File Offset: 0x00A44680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			string s = heroOrSoliderSkinUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F5E4 RID: 128484 RVA: 0x00A464DC File Offset: 0x00A446DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			HeroOrSoliderSkinUIController obj;
			LuaObject.checkType<HeroOrSoliderSkinUIController>(l, 2, out obj);
			heroOrSoliderSkinUIController.m_luaExportHelper.__callDele_EventOnItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5E5 RID: 128485 RVA: 0x00A46538 File Offset: 0x00A44738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			HeroOrSoliderSkinUIController obj;
			LuaObject.checkType<HeroOrSoliderSkinUIController>(l, 2, out obj);
			heroOrSoliderSkinUIController.m_luaExportHelper.__clearDele_EventOnItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5E6 RID: 128486 RVA: 0x00A46594 File Offset: 0x00A44794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Action<HeroOrSoliderSkinUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroOrSoliderSkinUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroOrSoliderSkinUIController.EventOnItemClick += value;
				}
				else if (num == 2)
				{
					heroOrSoliderSkinUIController.EventOnItemClick -= value;
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

	// Token: 0x0601F5E7 RID: 128487 RVA: 0x00A46614 File Offset: 0x00A44814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5E8 RID: 128488 RVA: 0x00A4666C File Offset: 0x00A4486C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5E9 RID: 128489 RVA: 0x00A466C8 File Offset: 0x00A448C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_selectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5EA RID: 128490 RVA: 0x00A46720 File Offset: 0x00A44920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			GameObject selectImage;
			LuaObject.checkType<GameObject>(l, 2, out selectImage);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_selectImage = selectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5EB RID: 128491 RVA: 0x00A4677C File Offset: 0x00A4497C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5EC RID: 128492 RVA: 0x00A467D4 File Offset: 0x00A449D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5ED RID: 128493 RVA: 0x00A46830 File Offset: 0x00A44A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_charGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5EE RID: 128494 RVA: 0x00A46888 File Offset: 0x00A44A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			GameObject charGameObject;
			LuaObject.checkType<GameObject>(l, 2, out charGameObject);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_charGameObject = charGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5EF RID: 128495 RVA: 0x00A468E4 File Offset: 0x00A44AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeGo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_timeGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F0 RID: 128496 RVA: 0x00A4693C File Offset: 0x00A44B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeGo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			GameObject timeGo;
			LuaObject.checkType<GameObject>(l, 2, out timeGo);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_timeGo = timeGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F1 RID: 128497 RVA: 0x00A46998 File Offset: 0x00A44B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_timeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F2 RID: 128498 RVA: 0x00A469F0 File Offset: 0x00A44BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Text timeValueText;
			LuaObject.checkType<Text>(l, 2, out timeValueText);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_timeValueText = timeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F3 RID: 128499 RVA: 0x00A46A4C File Offset: 0x00A44C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_playerHeroGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F4 RID: 128500 RVA: 0x00A46AA4 File Offset: 0x00A44CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			UISpineGraphic playerHeroGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out playerHeroGraphic);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_playerHeroGraphic = playerHeroGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F5 RID: 128501 RVA: 0x00A46B00 File Offset: 0x00A44D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_soldierInfoGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F6 RID: 128502 RVA: 0x00A46B58 File Offset: 0x00A44D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierInfoGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierInfoGraphic);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_soldierInfoGraphic = soldierInfoGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F7 RID: 128503 RVA: 0x00A46BB4 File Offset: 0x00A44DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F8 RID: 128504 RVA: 0x00A46C0C File Offset: 0x00A44E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5F9 RID: 128505 RVA: 0x00A46C68 File Offset: 0x00A44E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5FA RID: 128506 RVA: 0x00A46CC0 File Offset: 0x00A44EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5FB RID: 128507 RVA: 0x00A46D1C File Offset: 0x00A44F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5FC RID: 128508 RVA: 0x00A46D74 File Offset: 0x00A44F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroOrSoliderSkinUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5FD RID: 128509 RVA: 0x00A46DD0 File Offset: 0x00A44FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.JobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5FE RID: 128510 RVA: 0x00A46E24 File Offset: 0x00A45024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			heroOrSoliderSkinUIController.m_luaExportHelper.JobConnectionInfo = jobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5FF RID: 128511 RVA: 0x00A46E80 File Offset: 0x00A45080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.HeroSkinInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F600 RID: 128512 RVA: 0x00A46ED4 File Offset: 0x00A450D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			ConfigDataHeroSkinInfo heroSkinInfo;
			LuaObject.checkType<ConfigDataHeroSkinInfo>(l, 2, out heroSkinInfo);
			heroOrSoliderSkinUIController.m_luaExportHelper.HeroSkinInfo = heroSkinInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F601 RID: 128513 RVA: 0x00A46F30 File Offset: 0x00A45130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.ModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F602 RID: 128514 RVA: 0x00A46F84 File Offset: 0x00A45184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo modelSkinResourceInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 2, out modelSkinResourceInfo);
			heroOrSoliderSkinUIController.m_luaExportHelper.ModelSkinResourceInfo = modelSkinResourceInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F603 RID: 128515 RVA: 0x00A46FE0 File Offset: 0x00A451E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.SoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F604 RID: 128516 RVA: 0x00A47034 File Offset: 0x00A45234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			heroOrSoliderSkinUIController.m_luaExportHelper.SoldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F605 RID: 128517 RVA: 0x00A47090 File Offset: 0x00A45290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.SoldierSkinInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F606 RID: 128518 RVA: 0x00A470E4 File Offset: 0x00A452E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierSkinInfo soldierSkinInfo;
			LuaObject.checkType<ConfigDataSoldierSkinInfo>(l, 2, out soldierSkinInfo);
			heroOrSoliderSkinUIController.m_luaExportHelper.SoldierSkinInfo = soldierSkinInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F607 RID: 128519 RVA: 0x00A47140 File Offset: 0x00A45340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.IsHeroSkin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F608 RID: 128520 RVA: 0x00A47194 File Offset: 0x00A45394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			bool isHeroSkin;
			LuaObject.checkType(l, 2, out isHeroSkin);
			heroOrSoliderSkinUIController.m_luaExportHelper.IsHeroSkin = isHeroSkin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F609 RID: 128521 RVA: 0x00A471F0 File Offset: 0x00A453F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsDefaultSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroOrSoliderSkinUIController.IsDefaultSkin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F60A RID: 128522 RVA: 0x00A47244 File Offset: 0x00A45444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsDefaultSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroOrSoliderSkinUIController heroOrSoliderSkinUIController = (HeroOrSoliderSkinUIController)LuaObject.checkSelf(l);
			bool isDefaultSkin;
			LuaObject.checkType(l, 2, out isDefaultSkin);
			heroOrSoliderSkinUIController.m_luaExportHelper.IsDefaultSkin = isDefaultSkin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F60B RID: 128523 RVA: 0x00A472A0 File Offset: 0x00A454A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroOrSoliderSkinUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.InitHeroSkinItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.InitDefaultHeroSkinItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.InitSoldierSkinItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.InitDefaultSoldierSkinItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.ShowSelectImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.SetLimitTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.OnHeroJobCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__callDele_EventOnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.__clearDele_EventOnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache16);
		string name = "EventOnItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_EventOnItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache17, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache19, true);
		string name3 = "m_selectImage";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_selectImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_selectImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1B, true);
		string name4 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_nameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1D, true);
		string name5 = "m_charGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_charGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_charGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache1F, true);
		string name6 = "m_timeGo";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_timeGo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_timeGo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache21, true);
		string name7 = "m_timeValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_timeValueText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_timeValueText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache23, true);
		string name8 = "m_playerHeroGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_playerHeroGraphic);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_playerHeroGraphic);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache25, true);
		string name9 = "m_soldierInfoGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_soldierInfoGraphic);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_soldierInfoGraphic);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache27, true);
		string name10 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_hero);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_hero);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache29, true);
		string name11 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_playerContext);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2B, true);
		string name12 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_m_configDataLoader);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2D, true);
		string name13 = "JobConnectionInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_JobConnectionInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_JobConnectionInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache2F, true);
		string name14 = "HeroSkinInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_HeroSkinInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_HeroSkinInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache31, true);
		string name15 = "ModelSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_ModelSkinResourceInfo);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_ModelSkinResourceInfo);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache33, true);
		string name16 = "SoldierInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_SoldierInfo);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_SoldierInfo);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache35, true);
		string name17 = "SoldierSkinInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_SoldierSkinInfo);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_SoldierSkinInfo);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache37, true);
		string name18 = "IsHeroSkin";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_IsHeroSkin);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_IsHeroSkin);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache39, true);
		string name19 = "IsDefaultSkin";
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.get_IsDefaultSkin);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.set_IsDefaultSkin);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.<>f__mg$cache3B, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroOrSoliderSkinUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015607 RID: 87559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015608 RID: 87560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015609 RID: 87561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401560A RID: 87562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401560B RID: 87563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401560C RID: 87564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401560D RID: 87565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401560E RID: 87566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401560F RID: 87567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015610 RID: 87568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015611 RID: 87569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015612 RID: 87570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015613 RID: 87571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015614 RID: 87572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015615 RID: 87573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015616 RID: 87574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015617 RID: 87575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015618 RID: 87576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015619 RID: 87577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401561A RID: 87578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401561B RID: 87579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401561C RID: 87580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401561D RID: 87581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401561E RID: 87582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401561F RID: 87583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015620 RID: 87584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015621 RID: 87585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015622 RID: 87586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015623 RID: 87587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015624 RID: 87588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015625 RID: 87589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015626 RID: 87590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015627 RID: 87591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015628 RID: 87592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015629 RID: 87593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401562A RID: 87594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401562B RID: 87595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401562C RID: 87596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401562D RID: 87597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401562E RID: 87598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401562F RID: 87599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015630 RID: 87600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015631 RID: 87601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015632 RID: 87602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015633 RID: 87603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015634 RID: 87604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015635 RID: 87605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015636 RID: 87606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015637 RID: 87607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015638 RID: 87608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015639 RID: 87609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401563A RID: 87610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401563B RID: 87611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401563C RID: 87612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401563D RID: 87613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401563E RID: 87614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401563F RID: 87615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015640 RID: 87616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015641 RID: 87617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015642 RID: 87618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
