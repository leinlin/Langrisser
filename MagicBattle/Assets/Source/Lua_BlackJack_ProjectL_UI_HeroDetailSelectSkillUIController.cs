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

// Token: 0x020014B6 RID: 5302
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController : LuaObject
{
	// Token: 0x0601EEB8 RID: 126648 RVA: 0x00A0CD68 File Offset: 0x00A0AF68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateViewInSelectSkillState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailSelectSkillUIController.UpdateViewInSelectSkillState(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEB9 RID: 126649 RVA: 0x00A0CDC0 File Offset: 0x00A0AFC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			heroDetailSelectSkillUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEBA RID: 126650 RVA: 0x00A0CE14 File Offset: 0x00A0B014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectSkillContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			heroDetailSelectSkillUIController.m_luaExportHelper.ShowSelectSkillContent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEBB RID: 126651 RVA: 0x00A0CE68 File Offset: 0x00A0B068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			HeroSkillItemUIController skillCtrl;
			LuaObject.checkType<HeroSkillItemUIController>(l, 2, out skillCtrl);
			heroDetailSelectSkillUIController.m_luaExportHelper.OnSkillItemClick(skillCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEBC RID: 126652 RVA: 0x00A0CEC4 File Offset: 0x00A0B0C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnLoadOrUnLoadButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			heroDetailSelectSkillUIController.m_luaExportHelper.OnLoadOrUnLoadButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEBD RID: 126653 RVA: 0x00A0CF18 File Offset: 0x00A0B118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSaveSelectSkillsButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			heroDetailSelectSkillUIController.m_luaExportHelper.OnSaveSelectSkillsButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEBE RID: 126654 RVA: 0x00A0CF6C File Offset: 0x00A0B16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSkillDesc(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			heroDetailSelectSkillUIController.m_luaExportHelper.CloseSkillDesc();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEBF RID: 126655 RVA: 0x00A0CFC0 File Offset: 0x00A0B1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSelectSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			heroDetailSelectSkillUIController.m_luaExportHelper.CloseSelectSkillPanel(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEC0 RID: 126656 RVA: 0x00A0D01C File Offset: 0x00A0B21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcTotalCostFromSkillList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			List<int> skillIds;
			LuaObject.checkType<List<int>>(l, 2, out skillIds);
			int i = heroDetailSelectSkillUIController.m_luaExportHelper.CalcTotalCostFromSkillList(skillIds);
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

	// Token: 0x0601EEC1 RID: 126657 RVA: 0x00A0D084 File Offset: 0x00A0B284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEC2 RID: 126658 RVA: 0x00A0D0F0 File Offset: 0x00A0B2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEC3 RID: 126659 RVA: 0x00A0D144 File Offset: 0x00A0B344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEC4 RID: 126660 RVA: 0x00A0D198 File Offset: 0x00A0B398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EEC5 RID: 126661 RVA: 0x00A0D240 File Offset: 0x00A0B440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEC6 RID: 126662 RVA: 0x00A0D294 File Offset: 0x00A0B494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEC7 RID: 126663 RVA: 0x00A0D300 File Offset: 0x00A0B500
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
				HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDetailSelectSkillUIController heroDetailSelectSkillUIController2 = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDetailSelectSkillUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EEC8 RID: 126664 RVA: 0x00A0D410 File Offset: 0x00A0B610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEC9 RID: 126665 RVA: 0x00A0D47C File Offset: 0x00A0B67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EECA RID: 126666 RVA: 0x00A0D4E8 File Offset: 0x00A0B6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EECB RID: 126667 RVA: 0x00A0D554 File Offset: 0x00A0B754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EECC RID: 126668 RVA: 0x00A0D5C0 File Offset: 0x00A0B7C0
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
				HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailSelectSkillUIController heroDetailSelectSkillUIController2 = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDetailSelectSkillUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EECD RID: 126669 RVA: 0x00A0D6D0 File Offset: 0x00A0B8D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			string s = heroDetailSelectSkillUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EECE RID: 126670 RVA: 0x00A0D72C File Offset: 0x00A0B92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroSkillsSelect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			List<int> arg2;
			LuaObject.checkType<List<int>>(l, 3, out arg2);
			bool arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroDetailSelectSkillUIController.m_luaExportHelper.__callDele_EventOnHeroSkillsSelect(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EECF RID: 126671 RVA: 0x00A0D7A4 File Offset: 0x00A0B9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroSkillsSelect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			List<int> arg2;
			LuaObject.checkType<List<int>>(l, 3, out arg2);
			bool arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroDetailSelectSkillUIController.m_luaExportHelper.__clearDele_EventOnHeroSkillsSelect(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED0 RID: 126672 RVA: 0x00A0D81C File Offset: 0x00A0BA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSelectSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSelectSkillPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED1 RID: 126673 RVA: 0x00A0D874 File Offset: 0x00A0BA74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_infoSelectSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			GameObject infoSelectSkillPanel;
			LuaObject.checkType<GameObject>(l, 2, out infoSelectSkillPanel);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSelectSkillPanel = infoSelectSkillPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED2 RID: 126674 RVA: 0x00A0D8D0 File Offset: 0x00A0BAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoCloseSelectSkillButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoCloseSelectSkillButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED3 RID: 126675 RVA: 0x00A0D928 File Offset: 0x00A0BB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoCloseSelectSkillButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Button infoCloseSelectSkillButton;
			LuaObject.checkType<Button>(l, 2, out infoCloseSelectSkillButton);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoCloseSelectSkillButton = infoCloseSelectSkillButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED4 RID: 126676 RVA: 0x00A0D984 File Offset: 0x00A0BB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSelectSkillsCost(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSelectSkillsCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED5 RID: 126677 RVA: 0x00A0D9DC File Offset: 0x00A0BBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSelectSkillsCost(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			GameObject infoSelectSkillsCost;
			LuaObject.checkType<GameObject>(l, 2, out infoSelectSkillsCost);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSelectSkillsCost = infoSelectSkillsCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED6 RID: 126678 RVA: 0x00A0DA38 File Offset: 0x00A0BC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSelectSkillsContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSelectSkillsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED7 RID: 126679 RVA: 0x00A0DA90 File Offset: 0x00A0BC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSelectSkillsContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			GameObject infoSelectSkillsContent;
			LuaObject.checkType<GameObject>(l, 2, out infoSelectSkillsContent);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSelectSkillsContent = infoSelectSkillsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED8 RID: 126680 RVA: 0x00A0DAEC File Offset: 0x00A0BCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoAllSkillsContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoAllSkillsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EED9 RID: 126681 RVA: 0x00A0DB44 File Offset: 0x00A0BD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoAllSkillsContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			GameObject infoAllSkillsContent;
			LuaObject.checkType<GameObject>(l, 2, out infoAllSkillsContent);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoAllSkillsContent = infoAllSkillsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEDA RID: 126682 RVA: 0x00A0DBA0 File Offset: 0x00A0BDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSaveSelectSkillsButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSaveSelectSkillsButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEDB RID: 126683 RVA: 0x00A0DBF8 File Offset: 0x00A0BDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSaveSelectSkillsButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Button infoSaveSelectSkillsButton;
			LuaObject.checkType<Button>(l, 2, out infoSaveSelectSkillsButton);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSaveSelectSkillsButton = infoSaveSelectSkillsButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEDC RID: 126684 RVA: 0x00A0DC54 File Offset: 0x00A0BE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSkillDescLoadButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSkillDescLoadButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEDD RID: 126685 RVA: 0x00A0DCAC File Offset: 0x00A0BEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSkillDescLoadButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Button infoSkillDescLoadButton;
			LuaObject.checkType<Button>(l, 2, out infoSkillDescLoadButton);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSkillDescLoadButton = infoSkillDescLoadButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEDE RID: 126686 RVA: 0x00A0DD08 File Offset: 0x00A0BF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSkillDescUnLoadButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSkillDescUnLoadButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEDF RID: 126687 RVA: 0x00A0DD60 File Offset: 0x00A0BF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSkillDescUnLoadButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Button infoSkillDescUnLoadButton;
			LuaObject.checkType<Button>(l, 2, out infoSkillDescUnLoadButton);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSkillDescUnLoadButton = infoSkillDescUnLoadButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE0 RID: 126688 RVA: 0x00A0DDBC File Offset: 0x00A0BFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSkillDescGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSkillDescGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE1 RID: 126689 RVA: 0x00A0DE14 File Offset: 0x00A0C014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSkillDescGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			GameObject infoSkillDescGo;
			LuaObject.checkType<GameObject>(l, 2, out infoSkillDescGo);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_infoSkillDescGo = infoSkillDescGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE2 RID: 126690 RVA: 0x00A0DE70 File Offset: 0x00A0C070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroSkillsSelect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Action<int, List<int>, bool> value;
			int num = LuaObject.checkDelegate<Action<int, List<int>, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailSelectSkillUIController.EventOnHeroSkillsSelect += value;
				}
				else if (num == 2)
				{
					heroDetailSelectSkillUIController.EventOnHeroSkillsSelect -= value;
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

	// Token: 0x0601EEE3 RID: 126691 RVA: 0x00A0DEF0 File Offset: 0x00A0C0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE4 RID: 126692 RVA: 0x00A0DF48 File Offset: 0x00A0C148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE5 RID: 126693 RVA: 0x00A0DFA4 File Offset: 0x00A0C1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectSkillIds(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_curSelectSkillIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE6 RID: 126694 RVA: 0x00A0DFFC File Offset: 0x00A0C1FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectSkillIds(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			List<int> curSelectSkillIds;
			LuaObject.checkType<List<int>>(l, 2, out curSelectSkillIds);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_curSelectSkillIds = curSelectSkillIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE7 RID: 126695 RVA: 0x00A0E058 File Offset: 0x00A0C258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectedSkillCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_curSelectedSkillCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE8 RID: 126696 RVA: 0x00A0E0B0 File Offset: 0x00A0C2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectedSkillCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			HeroSkillItemUIController curSelectedSkillCtrl;
			LuaObject.checkType<HeroSkillItemUIController>(l, 2, out curSelectedSkillCtrl);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_curSelectedSkillCtrl = curSelectedSkillCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEE9 RID: 126697 RVA: 0x00A0E10C File Offset: 0x00A0C30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEEA RID: 126698 RVA: 0x00A0E164 File Offset: 0x00A0C364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEEB RID: 126699 RVA: 0x00A0E1C0 File Offset: 0x00A0C3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailSelectSkillUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEEC RID: 126700 RVA: 0x00A0E218 File Offset: 0x00A0C418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailSelectSkillUIController heroDetailSelectSkillUIController = (HeroDetailSelectSkillUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDetailSelectSkillUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEED RID: 126701 RVA: 0x00A0E274 File Offset: 0x00A0C474
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDetailSelectSkillUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.UpdateViewInSelectSkillState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.ShowSelectSkillContent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.OnSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.OnLoadOrUnLoadButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.OnSaveSelectSkillsButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.CloseSkillDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.CloseSelectSkillPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.CalcTotalCostFromSkillList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__callDele_EventOnHeroSkillsSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.__clearDele_EventOnHeroSkillsSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache17);
		string name = "m_infoSelectSkillPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoSelectSkillPanel);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoSelectSkillPanel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache19, true);
		string name2 = "m_infoCloseSelectSkillButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoCloseSelectSkillButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoCloseSelectSkillButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1B, true);
		string name3 = "m_infoSelectSkillsCost";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoSelectSkillsCost);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoSelectSkillsCost);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1D, true);
		string name4 = "m_infoSelectSkillsContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoSelectSkillsContent);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoSelectSkillsContent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache1F, true);
		string name5 = "m_infoAllSkillsContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoAllSkillsContent);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoAllSkillsContent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache21, true);
		string name6 = "m_infoSaveSelectSkillsButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoSaveSelectSkillsButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoSaveSelectSkillsButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache23, true);
		string name7 = "m_infoSkillDescLoadButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoSkillDescLoadButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoSkillDescLoadButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache25, true);
		string name8 = "m_infoSkillDescUnLoadButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoSkillDescUnLoadButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoSkillDescUnLoadButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache27, true);
		string name9 = "m_infoSkillDescGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_infoSkillDescGo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_infoSkillDescGo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache29, true);
		string name10 = "EventOnHeroSkillsSelect";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_EventOnHeroSkillsSelect);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2A, true);
		string name11 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_hero);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_hero);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2C, true);
		string name12 = "m_curSelectSkillIds";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_curSelectSkillIds);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_curSelectSkillIds);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2E, true);
		string name13 = "m_curSelectedSkillCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_curSelectedSkillCtrl);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_curSelectedSkillCtrl);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache30, true);
		string name14 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_playerContext);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache32, true);
		string name15 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.get_m_configDataLoader);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.<>f__mg$cache34, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDetailSelectSkillUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014F2E RID: 85806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014F2F RID: 85807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014F30 RID: 85808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014F31 RID: 85809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014F32 RID: 85810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014F33 RID: 85811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014F34 RID: 85812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014F35 RID: 85813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014F36 RID: 85814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014F37 RID: 85815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014F38 RID: 85816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014F39 RID: 85817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014F3A RID: 85818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014F3B RID: 85819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014F3C RID: 85820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014F3D RID: 85821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014F3E RID: 85822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014F3F RID: 85823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014F40 RID: 85824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014F41 RID: 85825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014F42 RID: 85826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014F43 RID: 85827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014F44 RID: 85828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014F45 RID: 85829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014F46 RID: 85830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014F47 RID: 85831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014F48 RID: 85832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014F49 RID: 85833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014F4A RID: 85834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014F4B RID: 85835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014F4C RID: 85836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014F4D RID: 85837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014F4E RID: 85838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014F4F RID: 85839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014F50 RID: 85840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014F51 RID: 85841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014F52 RID: 85842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014F53 RID: 85843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014F54 RID: 85844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014F55 RID: 85845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014F56 RID: 85846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014F57 RID: 85847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014F58 RID: 85848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014F59 RID: 85849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014F5A RID: 85850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014F5B RID: 85851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014F5C RID: 85852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014F5D RID: 85853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014F5E RID: 85854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014F5F RID: 85855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014F60 RID: 85856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014F61 RID: 85857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014F62 RID: 85858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
