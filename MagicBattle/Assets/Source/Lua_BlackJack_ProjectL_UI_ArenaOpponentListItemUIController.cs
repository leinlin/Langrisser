using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001378 RID: 4984
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController : LuaObject
{
	// Token: 0x0601AFB5 RID: 110517 RVA: 0x0081837C File Offset: 0x0081657C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			ArenaOpponent o;
			LuaObject.checkType<ArenaOpponent>(l, 2, out o);
			int idx;
			LuaObject.checkType(l, 3, out idx);
			bool isGuardBattle;
			LuaObject.checkType(l, 4, out isGuardBattle);
			arenaOpponentListItemUIController.SetArenaOpponent(o, idx, isGuardBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFB6 RID: 110518 RVA: 0x008183F0 File Offset: 0x008165F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			int index = arenaOpponentListItemUIController.GetIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFB7 RID: 110519 RVA: 0x00818444 File Offset: 0x00816644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			arenaOpponentListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFB8 RID: 110520 RVA: 0x00818498 File Offset: 0x00816698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			arenaOpponentListItemUIController.m_luaExportHelper.OnAttackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFB9 RID: 110521 RVA: 0x008184EC File Offset: 0x008166EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFBA RID: 110522 RVA: 0x00818558 File Offset: 0x00816758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFBB RID: 110523 RVA: 0x008185AC File Offset: 0x008167AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFBC RID: 110524 RVA: 0x00818600 File Offset: 0x00816800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaOpponentListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AFBD RID: 110525 RVA: 0x008186A8 File Offset: 0x008168A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFBE RID: 110526 RVA: 0x008186FC File Offset: 0x008168FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFBF RID: 110527 RVA: 0x00818768 File Offset: 0x00816968
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
				ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaOpponentListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaOpponentListItemUIController arenaOpponentListItemUIController2 = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaOpponentListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AFC0 RID: 110528 RVA: 0x00818878 File Offset: 0x00816A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFC1 RID: 110529 RVA: 0x008188E4 File Offset: 0x00816AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFC2 RID: 110530 RVA: 0x00818950 File Offset: 0x00816B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFC3 RID: 110531 RVA: 0x008189BC File Offset: 0x00816BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaOpponentListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFC4 RID: 110532 RVA: 0x00818A28 File Offset: 0x00816C28
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
				ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaOpponentListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaOpponentListItemUIController arenaOpponentListItemUIController2 = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaOpponentListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AFC5 RID: 110533 RVA: 0x00818B38 File Offset: 0x00816D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			string s = arenaOpponentListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AFC6 RID: 110534 RVA: 0x00818B94 File Offset: 0x00816D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			ArenaOpponentListItemUIController obj;
			LuaObject.checkType<ArenaOpponentListItemUIController>(l, 2, out obj);
			arenaOpponentListItemUIController.m_luaExportHelper.__callDele_EventOnAttackButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFC7 RID: 110535 RVA: 0x00818BF0 File Offset: 0x00816DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			ArenaOpponentListItemUIController obj;
			LuaObject.checkType<ArenaOpponentListItemUIController>(l, 2, out obj);
			arenaOpponentListItemUIController.m_luaExportHelper.__clearDele_EventOnAttackButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFC8 RID: 110536 RVA: 0x00818C4C File Offset: 0x00816E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			Action<ArenaOpponentListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<ArenaOpponentListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaOpponentListItemUIController.EventOnAttackButtonClick += value;
				}
				else if (num == 2)
				{
					arenaOpponentListItemUIController.EventOnAttackButtonClick -= value;
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

	// Token: 0x0601AFC9 RID: 110537 RVA: 0x00818CCC File Offset: 0x00816ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_uiStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFCA RID: 110538 RVA: 0x00818D24 File Offset: 0x00816F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateCtrl);
			arenaOpponentListItemUIController.m_luaExportHelper.m_uiStateCtrl = uiStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFCB RID: 110539 RVA: 0x00818D80 File Offset: 0x00816F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_playerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFCC RID: 110540 RVA: 0x00818DD8 File Offset: 0x00816FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			Image playerIconImage;
			LuaObject.checkType<Image>(l, 2, out playerIconImage);
			arenaOpponentListItemUIController.m_luaExportHelper.m_playerIconImage = playerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFCD RID: 110541 RVA: 0x00818E34 File Offset: 0x00817034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFCE RID: 110542 RVA: 0x00818E8C File Offset: 0x0081708C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			arenaOpponentListItemUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFCF RID: 110543 RVA: 0x00818EE8 File Offset: 0x008170E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD0 RID: 110544 RVA: 0x00818F40 File Offset: 0x00817140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			arenaOpponentListItemUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD1 RID: 110545 RVA: 0x00818F9C File Offset: 0x0081719C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaPointsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_arenaPointsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD2 RID: 110546 RVA: 0x00818FF4 File Offset: 0x008171F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaPointsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			GameObject arenaPointsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out arenaPointsGameObject);
			arenaOpponentListItemUIController.m_luaExportHelper.m_arenaPointsGameObject = arenaPointsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD3 RID: 110547 RVA: 0x00819050 File Offset: 0x00817250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_arenaPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD4 RID: 110548 RVA: 0x008190A8 File Offset: 0x008172A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			Text arenaPointsText;
			LuaObject.checkType<Text>(l, 2, out arenaPointsText);
			arenaOpponentListItemUIController.m_luaExportHelper.m_arenaPointsText = arenaPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD5 RID: 110549 RVA: 0x00819104 File Offset: 0x00817304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_victoryPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_victoryPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD6 RID: 110550 RVA: 0x0081915C File Offset: 0x0081735C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_victoryPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			Text victoryPointsText;
			LuaObject.checkType<Text>(l, 2, out victoryPointsText);
			arenaOpponentListItemUIController.m_luaExportHelper.m_victoryPointsText = victoryPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD7 RID: 110551 RVA: 0x008191B8 File Offset: 0x008173B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_attackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD8 RID: 110552 RVA: 0x00819210 File Offset: 0x00817410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			Button attackButton;
			LuaObject.checkType<Button>(l, 2, out attackButton);
			arenaOpponentListItemUIController.m_luaExportHelper.m_attackButton = attackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFD9 RID: 110553 RVA: 0x0081926C File Offset: 0x0081746C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentListItemUIController.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFDA RID: 110554 RVA: 0x008192C4 File Offset: 0x008174C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentListItemUIController arenaOpponentListItemUIController = (ArenaOpponentListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			arenaOpponentListItemUIController.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFDB RID: 110555 RVA: 0x00819320 File Offset: 0x00817520
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaOpponentListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.SetArenaOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.OnAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__callDele_EventOnAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.__clearDele_EventOnAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache12);
		string name = "EventOnAttackButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_EventOnAttackButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache13, true);
		string name2 = "m_uiStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_uiStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_uiStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache15, true);
		string name3 = "m_playerIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_playerIconImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_playerIconImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache17, true);
		string name4 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_playerNameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache19, true);
		string name5 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_playerLevelText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_arenaPointsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_arenaPointsGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_arenaPointsGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_arenaPointsText";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_arenaPointsText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_arenaPointsText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache1F, true);
		string name8 = "m_victoryPointsText";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_victoryPointsText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_victoryPointsText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache21, true);
		string name9 = "m_attackButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_attackButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_attackButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache23, true);
		string name10 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.get_m_index);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.set_m_index);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.<>f__mg$cache25, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaOpponentListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040112A7 RID: 70311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040112A8 RID: 70312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040112A9 RID: 70313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040112AA RID: 70314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040112AB RID: 70315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040112AC RID: 70316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040112AD RID: 70317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040112AE RID: 70318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040112AF RID: 70319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040112B0 RID: 70320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040112B1 RID: 70321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040112B2 RID: 70322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040112B3 RID: 70323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040112B4 RID: 70324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040112B5 RID: 70325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040112B6 RID: 70326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040112B7 RID: 70327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040112B8 RID: 70328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040112B9 RID: 70329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040112BA RID: 70330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040112BB RID: 70331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040112BC RID: 70332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040112BD RID: 70333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040112BE RID: 70334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040112BF RID: 70335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040112C0 RID: 70336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040112C1 RID: 70337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040112C2 RID: 70338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040112C3 RID: 70339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040112C4 RID: 70340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040112C5 RID: 70341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040112C6 RID: 70342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040112C7 RID: 70343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040112C8 RID: 70344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040112C9 RID: 70345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040112CA RID: 70346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040112CB RID: 70347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040112CC RID: 70348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
