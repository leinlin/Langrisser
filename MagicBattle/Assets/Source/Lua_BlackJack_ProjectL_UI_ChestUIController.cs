using System;
using System.Collections;
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

// Token: 0x020013F1 RID: 5105
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChestUIController : LuaObject
{
	// Token: 0x0601CAB1 RID: 117425 RVA: 0x008EE7E4 File Offset: 0x008EC9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowReward(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 2, out reward);
			bool isFirstWin;
			LuaObject.checkType(l, 3, out isFirstWin);
			bool isAutoOpen;
			LuaObject.checkType(l, 4, out isAutoOpen);
			chestUIController.ShowReward(reward, isFirstWin, isAutoOpen);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAB2 RID: 117426 RVA: 0x008EE858 File Offset: 0x008ECA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAB3 RID: 117427 RVA: 0x008EE8AC File Offset: 0x008ECAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowReward(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			BattleReward reward;
			LuaObject.checkType<BattleReward>(l, 2, out reward);
			bool isFirstWin;
			LuaObject.checkType(l, 3, out isFirstWin);
			bool isAutoOpen;
			LuaObject.checkType(l, 4, out isAutoOpen);
			IEnumerator o = chestUIController.m_luaExportHelper.Co_ShowReward(reward, isFirstWin, isAutoOpen);
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

	// Token: 0x0601CAB4 RID: 117428 RVA: 0x008EE930 File Offset: 0x008ECB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetAndWaitUIState(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out ctrl);
			string state;
			LuaObject.checkType(l, 3, out state);
			IEnumerator o = chestUIController.m_luaExportHelper.Co_SetAndWaitUIState(ctrl, state);
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

	// Token: 0x0601CAB5 RID: 117429 RVA: 0x008EE9A4 File Offset: 0x008ECBA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_PlayAndWaitTween(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			IEnumerator o = chestUIController.m_luaExportHelper.Co_PlayAndWaitTween(go);
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

	// Token: 0x0601CAB6 RID: 117430 RVA: 0x008EEA0C File Offset: 0x008ECC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitClick(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			IEnumerator o = chestUIController.m_luaExportHelper.Co_WaitClick();
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

	// Token: 0x0601CAB7 RID: 117431 RVA: 0x008EEA68 File Offset: 0x008ECC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGoodsTweenDummy(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 2, out goods);
			chestUIController.m_luaExportHelper.CreateGoodsTweenDummy(goods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAB8 RID: 117432 RVA: 0x008EEAC4 File Offset: 0x008ECCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearGoodsDummyGroup(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.ClearGoodsDummyGroup();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAB9 RID: 117433 RVA: 0x008EEB18 File Offset: 0x008ECD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRewardItems(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.ClearRewardItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CABA RID: 117434 RVA: 0x008EEB6C File Offset: 0x008ECD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CABB RID: 117435 RVA: 0x008EEBC0 File Offset: 0x008ECDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			chestUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CABC RID: 117436 RVA: 0x008EEC2C File Offset: 0x008ECE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CABD RID: 117437 RVA: 0x008EEC80 File Offset: 0x008ECE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CABE RID: 117438 RVA: 0x008EECD4 File Offset: 0x008ECED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = chestUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CABF RID: 117439 RVA: 0x008EED7C File Offset: 0x008ECF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAC0 RID: 117440 RVA: 0x008EEDD0 File Offset: 0x008ECFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			chestUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAC1 RID: 117441 RVA: 0x008EEE3C File Offset: 0x008ED03C
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
				ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				chestUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ChestUIController chestUIController2 = (ChestUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				chestUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CAC2 RID: 117442 RVA: 0x008EEF4C File Offset: 0x008ED14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chestUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAC3 RID: 117443 RVA: 0x008EEFB8 File Offset: 0x008ED1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chestUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAC4 RID: 117444 RVA: 0x008EF024 File Offset: 0x008ED224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chestUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAC5 RID: 117445 RVA: 0x008EF090 File Offset: 0x008ED290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chestUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAC6 RID: 117446 RVA: 0x008EF0FC File Offset: 0x008ED2FC
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
				ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				chestUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ChestUIController chestUIController2 = (ChestUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				chestUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CAC7 RID: 117447 RVA: 0x008EF20C File Offset: 0x008ED40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			string s = chestUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CAC8 RID: 117448 RVA: 0x008EF268 File Offset: 0x008ED468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAC9 RID: 117449 RVA: 0x008EF2BC File Offset: 0x008ED4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			chestUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CACA RID: 117450 RVA: 0x008EF310 File Offset: 0x008ED510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chestUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					chestUIController.EventOnClose -= value;
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

	// Token: 0x0601CACB RID: 117451 RVA: 0x008EF390 File Offset: 0x008ED590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CACC RID: 117452 RVA: 0x008EF3E8 File Offset: 0x008ED5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			chestUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CACD RID: 117453 RVA: 0x008EF444 File Offset: 0x008ED644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chestGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_chestGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CACE RID: 117454 RVA: 0x008EF49C File Offset: 0x008ED69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chestGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject chestGameObject;
			LuaObject.checkType<GameObject>(l, 2, out chestGameObject);
			chestUIController.m_luaExportHelper.m_chestGameObject = chestGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CACF RID: 117455 RVA: 0x008EF4F8 File Offset: 0x008ED6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chestUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_chestUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD0 RID: 117456 RVA: 0x008EF550 File Offset: 0x008ED750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chestUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			CommonUIStateController chestUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out chestUIStateController);
			chestUIController.m_luaExportHelper.m_chestUIStateController = chestUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD1 RID: 117457 RVA: 0x008EF5AC File Offset: 0x008ED7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_firstWinGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_firstWinGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD2 RID: 117458 RVA: 0x008EF604 File Offset: 0x008ED804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_firstWinGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject firstWinGameObject;
			LuaObject.checkType<GameObject>(l, 2, out firstWinGameObject);
			chestUIController.m_luaExportHelper.m_firstWinGameObject = firstWinGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD3 RID: 117459 RVA: 0x008EF660 File Offset: 0x008ED860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoodsGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_rewardGoodsGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD4 RID: 117460 RVA: 0x008EF6B8 File Offset: 0x008ED8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoodsGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject rewardGoodsGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGoodsGroupGameObject);
			chestUIController.m_luaExportHelper.m_rewardGoodsGroupGameObject = rewardGoodsGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD5 RID: 117461 RVA: 0x008EF714 File Offset: 0x008ED914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRewardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_teamRewardUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD6 RID: 117462 RVA: 0x008EF76C File Offset: 0x008ED96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRewardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			CommonUIStateController teamRewardUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out teamRewardUIStateController);
			chestUIController.m_luaExportHelper.m_teamRewardUIStateController = teamRewardUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD7 RID: 117463 RVA: 0x008EF7C8 File Offset: 0x008ED9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRewardFriendshipGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_teamRewardFriendshipGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD8 RID: 117464 RVA: 0x008EF820 File Offset: 0x008EDA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRewardFriendshipGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject teamRewardFriendshipGameObject;
			LuaObject.checkType<GameObject>(l, 2, out teamRewardFriendshipGameObject);
			chestUIController.m_luaExportHelper.m_teamRewardFriendshipGameObject = teamRewardFriendshipGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAD9 RID: 117465 RVA: 0x008EF87C File Offset: 0x008EDA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRewardFriendshipValueText(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_teamRewardFriendshipValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CADA RID: 117466 RVA: 0x008EF8D4 File Offset: 0x008EDAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRewardFriendshipValueText(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			Text teamRewardFriendshipValueText;
			LuaObject.checkType<Text>(l, 2, out teamRewardFriendshipValueText);
			chestUIController.m_luaExportHelper.m_teamRewardFriendshipValueText = teamRewardFriendshipValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CADB RID: 117467 RVA: 0x008EF930 File Offset: 0x008EDB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRewardTeamGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_teamRewardTeamGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CADC RID: 117468 RVA: 0x008EF988 File Offset: 0x008EDB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRewardTeamGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject teamRewardTeamGameObject;
			LuaObject.checkType<GameObject>(l, 2, out teamRewardTeamGameObject);
			chestUIController.m_luaExportHelper.m_teamRewardTeamGameObject = teamRewardTeamGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CADD RID: 117469 RVA: 0x008EF9E4 File Offset: 0x008EDBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRewardTeamValueText(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_teamRewardTeamValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CADE RID: 117470 RVA: 0x008EFA3C File Offset: 0x008EDC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRewardTeamValueText(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			Text teamRewardTeamValueText;
			LuaObject.checkType<Text>(l, 2, out teamRewardTeamValueText);
			chestUIController.m_luaExportHelper.m_teamRewardTeamValueText = teamRewardTeamValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CADF RID: 117471 RVA: 0x008EFA98 File Offset: 0x008EDC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRewardFriendGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_teamRewardFriendGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE0 RID: 117472 RVA: 0x008EFAF0 File Offset: 0x008EDCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRewardFriendGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject teamRewardFriendGameObject;
			LuaObject.checkType<GameObject>(l, 2, out teamRewardFriendGameObject);
			chestUIController.m_luaExportHelper.m_teamRewardFriendGameObject = teamRewardFriendGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE1 RID: 117473 RVA: 0x008EFB4C File Offset: 0x008EDD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRewardFriendValueText(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_teamRewardFriendValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE2 RID: 117474 RVA: 0x008EFBA4 File Offset: 0x008EDDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRewardFriendValueText(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			Text teamRewardFriendValueText;
			LuaObject.checkType<Text>(l, 2, out teamRewardFriendValueText);
			chestUIController.m_luaExportHelper.m_teamRewardFriendValueText = teamRewardFriendValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE3 RID: 117475 RVA: 0x008EFC00 File Offset: 0x008EDE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dailyRewardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_dailyRewardUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE4 RID: 117476 RVA: 0x008EFC58 File Offset: 0x008EDE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyRewardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			CommonUIStateController dailyRewardUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out dailyRewardUIStateController);
			chestUIController.m_luaExportHelper.m_dailyRewardUIStateController = dailyRewardUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE5 RID: 117477 RVA: 0x008EFCB4 File Offset: 0x008EDEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickScreenContinueGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_clickScreenContinueGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE6 RID: 117478 RVA: 0x008EFD0C File Offset: 0x008EDF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clickScreenContinueGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject clickScreenContinueGameObject;
			LuaObject.checkType<GameObject>(l, 2, out clickScreenContinueGameObject);
			chestUIController.m_luaExportHelper.m_clickScreenContinueGameObject = clickScreenContinueGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE7 RID: 117479 RVA: 0x008EFD68 File Offset: 0x008EDF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE8 RID: 117480 RVA: 0x008EFDC0 File Offset: 0x008EDFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			chestUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAE9 RID: 117481 RVA: 0x008EFE1C File Offset: 0x008EE01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsTweenDummyPrefab(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_goodsTweenDummyPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAEA RID: 117482 RVA: 0x008EFE74 File Offset: 0x008EE074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsTweenDummyPrefab(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			GameObject goodsTweenDummyPrefab;
			LuaObject.checkType<GameObject>(l, 2, out goodsTweenDummyPrefab);
			chestUIController.m_luaExportHelper.m_goodsTweenDummyPrefab = goodsTweenDummyPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAEB RID: 117483 RVA: 0x008EFED0 File Offset: 0x008EE0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoods(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_rewardGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAEC RID: 117484 RVA: 0x008EFF28 File Offset: 0x008EE128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoods(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			List<RewardGoodsUIController> rewardGoods;
			LuaObject.checkType<List<RewardGoodsUIController>>(l, 2, out rewardGoods);
			chestUIController.m_luaExportHelper.m_rewardGoods = rewardGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAED RID: 117485 RVA: 0x008EFF84 File Offset: 0x008EE184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chestUIController.m_luaExportHelper.m_isClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAEE RID: 117486 RVA: 0x008EFFDC File Offset: 0x008EE1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			ChestUIController chestUIController = (ChestUIController)LuaObject.checkSelf(l);
			bool isClick;
			LuaObject.checkType(l, 2, out isClick);
			chestUIController.m_luaExportHelper.m_isClick = isClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAEF RID: 117487 RVA: 0x008F0038 File Offset: 0x008EE238
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChestUIController");
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.ShowReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.Co_ShowReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.Co_SetAndWaitUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.Co_PlayAndWaitTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.Co_WaitClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.CreateGoodsTweenDummy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.ClearGoodsDummyGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.ClearRewardItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache18);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache19, true);
		string name2 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_backgroundButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1B, true);
		string name3 = "m_chestGameObject";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_chestGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_chestGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1D, true);
		string name4 = "m_chestUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_chestUIStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_chestUIStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache1F, true);
		string name5 = "m_firstWinGameObject";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_firstWinGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_firstWinGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache21, true);
		string name6 = "m_rewardGoodsGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_rewardGoodsGroupGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_rewardGoodsGroupGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache23, true);
		string name7 = "m_teamRewardUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_teamRewardUIStateController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_teamRewardUIStateController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache25, true);
		string name8 = "m_teamRewardFriendshipGameObject";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_teamRewardFriendshipGameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_teamRewardFriendshipGameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache27, true);
		string name9 = "m_teamRewardFriendshipValueText";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_teamRewardFriendshipValueText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_teamRewardFriendshipValueText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache29, true);
		string name10 = "m_teamRewardTeamGameObject";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_teamRewardTeamGameObject);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_teamRewardTeamGameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2B, true);
		string name11 = "m_teamRewardTeamValueText";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_teamRewardTeamValueText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_teamRewardTeamValueText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2D, true);
		string name12 = "m_teamRewardFriendGameObject";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_teamRewardFriendGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_teamRewardFriendGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache2F, true);
		string name13 = "m_teamRewardFriendValueText";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_teamRewardFriendValueText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_teamRewardFriendValueText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache31, true);
		string name14 = "m_dailyRewardUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_dailyRewardUIStateController);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_dailyRewardUIStateController);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache33, true);
		string name15 = "m_clickScreenContinueGameObject";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_clickScreenContinueGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_clickScreenContinueGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache35, true);
		string name16 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache37, true);
		string name17 = "m_goodsTweenDummyPrefab";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_goodsTweenDummyPrefab);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_goodsTweenDummyPrefab);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache39, true);
		string name18 = "m_rewardGoods";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_rewardGoods);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_rewardGoods);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3B, true);
		string name19 = "m_isClick";
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.get_m_isClick);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChestUIController.set_m_isClick);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ChestUIController.<>f__mg$cache3D, true);
		LuaObject.createTypeMetatable(l, null, typeof(ChestUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012CB1 RID: 76977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012CB2 RID: 76978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012CB3 RID: 76979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012CB4 RID: 76980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012CB5 RID: 76981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012CB6 RID: 76982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012CB7 RID: 76983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012CB8 RID: 76984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012CB9 RID: 76985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012CBA RID: 76986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012CBB RID: 76987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012CBC RID: 76988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012CBD RID: 76989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012CBE RID: 76990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012CBF RID: 76991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012CC0 RID: 76992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012CC1 RID: 76993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012CC2 RID: 76994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012CC3 RID: 76995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012CC4 RID: 76996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012CC5 RID: 76997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012CC6 RID: 76998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012CC7 RID: 76999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012CC8 RID: 77000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012CC9 RID: 77001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012CCA RID: 77002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012CCB RID: 77003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012CCC RID: 77004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012CCD RID: 77005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012CCE RID: 77006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012CCF RID: 77007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012CD0 RID: 77008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012CD1 RID: 77009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012CD2 RID: 77010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012CD3 RID: 77011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012CD4 RID: 77012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012CD5 RID: 77013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012CD6 RID: 77014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012CD7 RID: 77015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012CD8 RID: 77016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012CD9 RID: 77017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012CDA RID: 77018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012CDB RID: 77019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012CDC RID: 77020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012CDD RID: 77021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012CDE RID: 77022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012CDF RID: 77023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012CE0 RID: 77024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012CE1 RID: 77025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012CE2 RID: 77026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012CE3 RID: 77027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012CE4 RID: 77028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012CE5 RID: 77029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012CE6 RID: 77030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012CE7 RID: 77031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012CE8 RID: 77032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012CE9 RID: 77033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012CEA RID: 77034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012CEB RID: 77035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012CEC RID: 77036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012CED RID: 77037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012CEE RID: 77038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;
}
