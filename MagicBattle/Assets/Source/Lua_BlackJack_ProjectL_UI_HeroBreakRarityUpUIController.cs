using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014A5 RID: 5285
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController : LuaObject
{
	// Token: 0x0601E9B1 RID: 125361 RVA: 0x009E48C8 File Offset: 0x009E2AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroBreakRarityUpUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			heroBreakRarityUpUIController.HeroBreakRarityUpUpdateView(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9B2 RID: 125362 RVA: 0x009E4920 File Offset: 0x009E2B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9B3 RID: 125363 RVA: 0x009E496C File Offset: 0x009E2B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9B4 RID: 125364 RVA: 0x009E49B8 File Offset: 0x009E2BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9B5 RID: 125365 RVA: 0x009E4A0C File Offset: 0x009E2C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9B6 RID: 125366 RVA: 0x009E4A60 File Offset: 0x009E2C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9B7 RID: 125367 RVA: 0x009E4ACC File Offset: 0x009E2CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9B8 RID: 125368 RVA: 0x009E4B20 File Offset: 0x009E2D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9B9 RID: 125369 RVA: 0x009E4B74 File Offset: 0x009E2D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroBreakRarityUpUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E9BA RID: 125370 RVA: 0x009E4C1C File Offset: 0x009E2E1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9BB RID: 125371 RVA: 0x009E4C70 File Offset: 0x009E2E70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9BC RID: 125372 RVA: 0x009E4CDC File Offset: 0x009E2EDC
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
				HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroBreakRarityUpUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroBreakRarityUpUIController heroBreakRarityUpUIController2 = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroBreakRarityUpUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E9BD RID: 125373 RVA: 0x009E4DEC File Offset: 0x009E2FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9BE RID: 125374 RVA: 0x009E4E58 File Offset: 0x009E3058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9BF RID: 125375 RVA: 0x009E4EC4 File Offset: 0x009E30C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9C0 RID: 125376 RVA: 0x009E4F30 File Offset: 0x009E3130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroBreakRarityUpUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9C1 RID: 125377 RVA: 0x009E4F9C File Offset: 0x009E319C
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
				HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroBreakRarityUpUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroBreakRarityUpUIController heroBreakRarityUpUIController2 = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroBreakRarityUpUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E9C2 RID: 125378 RVA: 0x009E50AC File Offset: 0x009E32AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			string s = heroBreakRarityUpUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E9C3 RID: 125379 RVA: 0x009E5108 File Offset: 0x009E3308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9C4 RID: 125380 RVA: 0x009E515C File Offset: 0x009E335C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			heroBreakRarityUpUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9C5 RID: 125381 RVA: 0x009E51B0 File Offset: 0x009E33B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9C6 RID: 125382 RVA: 0x009E5208 File Offset: 0x009E3408
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			heroBreakRarityUpUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9C7 RID: 125383 RVA: 0x009E5264 File Offset: 0x009E3464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUIController.m_luaExportHelper.m_heroCharGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9C8 RID: 125384 RVA: 0x009E52BC File Offset: 0x009E34BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroCharGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			GameObject heroCharGameObject;
			LuaObject.checkType<GameObject>(l, 2, out heroCharGameObject);
			heroBreakRarityUpUIController.m_luaExportHelper.m_heroCharGameObject = heroCharGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9C9 RID: 125385 RVA: 0x009E5318 File Offset: 0x009E3518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakEffectReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUIController.m_luaExportHelper.m_heroBreakEffectReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9CA RID: 125386 RVA: 0x009E5370 File Offset: 0x009E3570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakEffectReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			Button heroBreakEffectReturnButton;
			LuaObject.checkType<Button>(l, 2, out heroBreakEffectReturnButton);
			heroBreakRarityUpUIController.m_luaExportHelper.m_heroBreakEffectReturnButton = heroBreakEffectReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9CB RID: 125387 RVA: 0x009E53CC File Offset: 0x009E35CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroBreakRarityUpUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroBreakRarityUpUIController.EventOnReturn -= value;
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

	// Token: 0x0601E9CC RID: 125388 RVA: 0x009E544C File Offset: 0x009E364C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9CD RID: 125389 RVA: 0x009E54A4 File Offset: 0x009E36A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroBreakRarityUpUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9CE RID: 125390 RVA: 0x009E5500 File Offset: 0x009E3700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9CF RID: 125391 RVA: 0x009E5558 File Offset: 0x009E3758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			heroBreakRarityUpUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9D0 RID: 125392 RVA: 0x009E55B4 File Offset: 0x009E37B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakRarityUpUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9D1 RID: 125393 RVA: 0x009E560C File Offset: 0x009E380C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakRarityUpUIController heroBreakRarityUpUIController = (HeroBreakRarityUpUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroBreakRarityUpUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E9D2 RID: 125394 RVA: 0x009E5668 File Offset: 0x009E3868
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroBreakRarityUpUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.HeroBreakRarityUpUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache13);
		string name = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.get_m_stateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache15, true);
		string name2 = "m_heroCharGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.get_m_heroCharGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.set_m_heroCharGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache17, true);
		string name3 = "m_heroBreakEffectReturnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.get_m_heroBreakEffectReturnButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.set_m_heroBreakEffectReturnButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache19, true);
		string name4 = "EventOnReturn";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1A, true);
		string name5 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.get_m_hero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.set_m_hero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1C, true);
		string name6 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1E, true);
		string name7 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.get_m_playerContext);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.<>f__mg$cache20, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroBreakRarityUpUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014A49 RID: 84553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014A4A RID: 84554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014A4B RID: 84555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014A4C RID: 84556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014A4D RID: 84557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014A4E RID: 84558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014A4F RID: 84559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014A50 RID: 84560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014A51 RID: 84561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014A52 RID: 84562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014A53 RID: 84563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014A54 RID: 84564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014A55 RID: 84565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014A56 RID: 84566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014A57 RID: 84567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014A58 RID: 84568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014A59 RID: 84569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014A5A RID: 84570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014A5B RID: 84571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014A5C RID: 84572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014A5D RID: 84573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014A5E RID: 84574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014A5F RID: 84575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014A60 RID: 84576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014A61 RID: 84577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014A62 RID: 84578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014A63 RID: 84579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014A64 RID: 84580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014A65 RID: 84581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014A66 RID: 84582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014A67 RID: 84583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014A68 RID: 84584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014A69 RID: 84585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
