using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001389 RID: 5001
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ARHeroListUIController : LuaObject
{
	// Token: 0x0601B371 RID: 111473 RVA: 0x00835C98 File Offset: 0x00833E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUITask(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			UITask uitask;
			LuaObject.checkType<UITask>(l, 2, out uitask);
			arheroListUIController.SetUITask(uitask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B372 RID: 111474 RVA: 0x00835CF0 File Offset: 0x00833EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.Show();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B373 RID: 111475 RVA: 0x00835D3C File Offset: 0x00833F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshSelectHeroShow(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.RefreshSelectHeroShow();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B374 RID: 111476 RVA: 0x00835D88 File Offset: 0x00833F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B375 RID: 111477 RVA: 0x00835DDC File Offset: 0x00833FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectHero(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			ARHeroListUIController.HeroWrap selectHeroWrap;
			LuaObject.checkType<ARHeroListUIController.HeroWrap>(l, 2, out selectHeroWrap);
			arheroListUIController.m_luaExportHelper.SelectHero(selectHeroWrap);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B376 RID: 111478 RVA: 0x00835E38 File Offset: 0x00834038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleTypeShowClick(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.m_luaExportHelper.OnBattleTypeShowClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B377 RID: 111479 RVA: 0x00835E8C File Offset: 0x0083408C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroDrawShowClick(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.m_luaExportHelper.OnHeroDrawShowClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B378 RID: 111480 RVA: 0x00835EE0 File Offset: 0x008340E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTeamShowClick(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.m_luaExportHelper.OnTeamShowClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B379 RID: 111481 RVA: 0x00835F34 File Offset: 0x00834134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.m_luaExportHelper.OnBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B37A RID: 111482 RVA: 0x00835F88 File Offset: 0x00834188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			ARHeroCardUIController ctrl;
			LuaObject.checkType<ARHeroCardUIController>(l, 2, out ctrl);
			arheroListUIController.m_luaExportHelper.OnHeroItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B37B RID: 111483 RVA: 0x00835FE4 File Offset: 0x008341E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateInfinityHeroItemCallback(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Transform trans;
			LuaObject.checkType<Transform>(l, 3, out trans);
			arheroListUIController.m_luaExportHelper.UpdateInfinityHeroItemCallback(index, trans);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B37C RID: 111484 RVA: 0x00836050 File Offset: 0x00834250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arheroListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B37D RID: 111485 RVA: 0x008360BC File Offset: 0x008342BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B37E RID: 111486 RVA: 0x00836110 File Offset: 0x00834310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B37F RID: 111487 RVA: 0x00836164 File Offset: 0x00834364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arheroListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B380 RID: 111488 RVA: 0x0083620C File Offset: 0x0083440C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			arheroListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B381 RID: 111489 RVA: 0x00836260 File Offset: 0x00834460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arheroListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B382 RID: 111490 RVA: 0x008362CC File Offset: 0x008344CC
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
				ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arheroListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ARHeroListUIController arheroListUIController2 = (ARHeroListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arheroListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B383 RID: 111491 RVA: 0x008363DC File Offset: 0x008345DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arheroListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B384 RID: 111492 RVA: 0x00836448 File Offset: 0x00834648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arheroListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B385 RID: 111493 RVA: 0x008364B4 File Offset: 0x008346B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arheroListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B386 RID: 111494 RVA: 0x00836520 File Offset: 0x00834720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arheroListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B387 RID: 111495 RVA: 0x0083658C File Offset: 0x0083478C
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
				ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arheroListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ARHeroListUIController arheroListUIController2 = (ARHeroListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arheroListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B388 RID: 111496 RVA: 0x0083669C File Offset: 0x0083489C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			string s = arheroListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B389 RID: 111497 RVA: 0x008366F8 File Offset: 0x008348F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arHeroListAnimation(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_arHeroListAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B38A RID: 111498 RVA: 0x00836750 File Offset: 0x00834950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arHeroListAnimation(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			CommonUIStateController arHeroListAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out arHeroListAnimation);
			arheroListUIController.m_luaExportHelper.m_arHeroListAnimation = arHeroListAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B38B RID: 111499 RVA: 0x008367AC File Offset: 0x008349AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListInfinityGrid(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_heroListInfinityGrid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B38C RID: 111500 RVA: 0x00836804 File Offset: 0x00834A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListInfinityGrid(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			InfinityGridLayoutGroup heroListInfinityGrid;
			LuaObject.checkType<InfinityGridLayoutGroup>(l, 2, out heroListInfinityGrid);
			arheroListUIController.m_luaExportHelper.m_heroListInfinityGrid = heroListInfinityGrid;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B38D RID: 111501 RVA: 0x00836860 File Offset: 0x00834A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTypeButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_battleTypeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B38E RID: 111502 RVA: 0x008368B8 File Offset: 0x00834AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTypeButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			ButtonEx battleTypeButton;
			LuaObject.checkType<ButtonEx>(l, 2, out battleTypeButton);
			arheroListUIController.m_luaExportHelper.m_battleTypeButton = battleTypeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B38F RID: 111503 RVA: 0x00836914 File Offset: 0x00834B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDrawButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_heroDrawButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B390 RID: 111504 RVA: 0x0083696C File Offset: 0x00834B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDrawButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			ButtonEx heroDrawButton;
			LuaObject.checkType<ButtonEx>(l, 2, out heroDrawButton);
			arheroListUIController.m_luaExportHelper.m_heroDrawButton = heroDrawButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B391 RID: 111505 RVA: 0x008369C8 File Offset: 0x00834BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamShowButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_teamShowButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B392 RID: 111506 RVA: 0x00836A20 File Offset: 0x00834C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamShowButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			ButtonEx teamShowButton;
			LuaObject.checkType<ButtonEx>(l, 2, out teamShowButton);
			arheroListUIController.m_luaExportHelper.m_teamShowButton = teamShowButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B393 RID: 111507 RVA: 0x00836A7C File Offset: 0x00834C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_bgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B394 RID: 111508 RVA: 0x00836AD4 File Offset: 0x00834CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			arheroListUIController.m_luaExportHelper.m_bgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B395 RID: 111509 RVA: 0x00836B30 File Offset: 0x00834D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_heroListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B396 RID: 111510 RVA: 0x00836B88 File Offset: 0x00834D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			GameObject heroListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroListItemPrefab);
			arheroListUIController.m_luaExportHelper.m_heroListItemPrefab = heroListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B397 RID: 111511 RVA: 0x00836BE4 File Offset: 0x00834DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroWrapList(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_heroWrapList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B398 RID: 111512 RVA: 0x00836C3C File Offset: 0x00834E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroWrapList(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			List<ARHeroListUIController.HeroWrap> heroWrapList;
			LuaObject.checkType<List<ARHeroListUIController.HeroWrap>>(l, 2, out heroWrapList);
			arheroListUIController.m_luaExportHelper.m_heroWrapList = heroWrapList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B399 RID: 111513 RVA: 0x00836C98 File Offset: 0x00834E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arHeroCardUIControllerList(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_arHeroCardUIControllerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B39A RID: 111514 RVA: 0x00836CF0 File Offset: 0x00834EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arHeroCardUIControllerList(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			List<ARHeroCardUIController> arHeroCardUIControllerList;
			LuaObject.checkType<List<ARHeroCardUIController>>(l, 2, out arHeroCardUIControllerList);
			arheroListUIController.m_luaExportHelper.m_arHeroCardUIControllerList = arHeroCardUIControllerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B39B RID: 111515 RVA: 0x00836D4C File Offset: 0x00834F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectHeroWrap(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_selectHeroWrap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B39C RID: 111516 RVA: 0x00836DA4 File Offset: 0x00834FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectHeroWrap(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			ARHeroListUIController.HeroWrap selectHeroWrap;
			LuaObject.checkType<ARHeroListUIController.HeroWrap>(l, 2, out selectHeroWrap);
			arheroListUIController.m_luaExportHelper.m_selectHeroWrap = selectHeroWrap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B39D RID: 111517 RVA: 0x00836E00 File Offset: 0x00835000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B39E RID: 111518 RVA: 0x00836E58 File Offset: 0x00835058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			arheroListUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B39F RID: 111519 RVA: 0x00836EB4 File Offset: 0x008350B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3A0 RID: 111520 RVA: 0x00836F0C File Offset: 0x0083510C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			arheroListUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3A1 RID: 111521 RVA: 0x00836F68 File Offset: 0x00835168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_task(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroListUIController.m_luaExportHelper.m_task);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3A2 RID: 111522 RVA: 0x00836FC0 File Offset: 0x008351C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_task(IntPtr l)
	{
		int result;
		try
		{
			ARHeroListUIController arheroListUIController = (ARHeroListUIController)LuaObject.checkSelf(l);
			UITask task;
			LuaObject.checkType<UITask>(l, 2, out task);
			arheroListUIController.m_luaExportHelper.m_task = task;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3A3 RID: 111523 RVA: 0x0083701C File Offset: 0x0083521C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ARHeroListUIController");
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.SetUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.RefreshSelectHeroShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.SelectHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.OnBattleTypeShowClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.OnHeroDrawShowClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.OnTeamShowClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.OnBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.OnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.UpdateInfinityHeroItemCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache17);
		string name = "m_arHeroListAnimation";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_arHeroListAnimation);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_arHeroListAnimation);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache19, true);
		string name2 = "m_heroListInfinityGrid";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_heroListInfinityGrid);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_heroListInfinityGrid);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1B, true);
		string name3 = "m_battleTypeButton";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_battleTypeButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_battleTypeButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1D, true);
		string name4 = "m_heroDrawButton";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_heroDrawButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_heroDrawButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache1F, true);
		string name5 = "m_teamShowButton";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_teamShowButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_teamShowButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache21, true);
		string name6 = "m_bgButton";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_bgButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_bgButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache23, true);
		string name7 = "m_heroListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_heroListItemPrefab);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_heroListItemPrefab);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache25, true);
		string name8 = "m_heroWrapList";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_heroWrapList);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_heroWrapList);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache27, true);
		string name9 = "m_arHeroCardUIControllerList";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_arHeroCardUIControllerList);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_arHeroCardUIControllerList);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache29, true);
		string name10 = "m_selectHeroWrap";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_selectHeroWrap);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_selectHeroWrap);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2B, true);
		string name11 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_playerContext);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2D, true);
		string name12 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_configDataLoader);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache2F, true);
		string name13 = "m_task";
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.get_m_task);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.set_m_task);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ARHeroListUIController.<>f__mg$cache31, true);
		LuaObject.createTypeMetatable(l, null, typeof(ARHeroListUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011641 RID: 71233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011642 RID: 71234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011643 RID: 71235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011644 RID: 71236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011645 RID: 71237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011646 RID: 71238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011647 RID: 71239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011648 RID: 71240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011649 RID: 71241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401164A RID: 71242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401164B RID: 71243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401164C RID: 71244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401164D RID: 71245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401164E RID: 71246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401164F RID: 71247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011650 RID: 71248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011651 RID: 71249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011652 RID: 71250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011653 RID: 71251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011654 RID: 71252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011655 RID: 71253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011656 RID: 71254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011657 RID: 71255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011658 RID: 71256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011659 RID: 71257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401165A RID: 71258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401165B RID: 71259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401165C RID: 71260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401165D RID: 71261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401165E RID: 71262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401165F RID: 71263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011660 RID: 71264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011661 RID: 71265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011662 RID: 71266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011663 RID: 71267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011664 RID: 71268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011665 RID: 71269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011666 RID: 71270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011667 RID: 71271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011668 RID: 71272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011669 RID: 71273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401166A RID: 71274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401166B RID: 71275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401166C RID: 71276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401166D RID: 71277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401166E RID: 71278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401166F RID: 71279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011670 RID: 71280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011671 RID: 71281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011672 RID: 71282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;
}
