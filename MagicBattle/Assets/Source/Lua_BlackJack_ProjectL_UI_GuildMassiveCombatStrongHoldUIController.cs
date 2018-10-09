using System;
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

// Token: 0x0200148D RID: 5261
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController : LuaObject
{
	// Token: 0x0601E702 RID: 124674 RVA: 0x009CFC84 File Offset: 0x009CDE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitGuildMassiveCombatStrongHoldInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold strongHold;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out strongHold);
			guildMassiveCombatStrongHoldUIController.InitGuildMassiveCombatStrongHoldInfo(strongHold);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E703 RID: 124675 RVA: 0x009CFCDC File Offset: 0x009CDEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuppressText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			guildMassiveCombatStrongHoldUIController.SetSuppressText();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E704 RID: 124676 RVA: 0x009CFD28 File Offset: 0x009CDF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E705 RID: 124677 RVA: 0x009CFD7C File Offset: 0x009CDF7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E706 RID: 124678 RVA: 0x009CFDD0 File Offset: 0x009CDFD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E707 RID: 124679 RVA: 0x009CFE3C File Offset: 0x009CE03C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E708 RID: 124680 RVA: 0x009CFE90 File Offset: 0x009CE090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E709 RID: 124681 RVA: 0x009CFEE4 File Offset: 0x009CE0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E70A RID: 124682 RVA: 0x009CFF8C File Offset: 0x009CE18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E70B RID: 124683 RVA: 0x009CFFE0 File Offset: 0x009CE1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E70C RID: 124684 RVA: 0x009D004C File Offset: 0x009CE24C
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
				GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController2 = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildMassiveCombatStrongHoldUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E70D RID: 124685 RVA: 0x009D015C File Offset: 0x009CE35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E70E RID: 124686 RVA: 0x009D01C8 File Offset: 0x009CE3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E70F RID: 124687 RVA: 0x009D0234 File Offset: 0x009CE434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E710 RID: 124688 RVA: 0x009D02A0 File Offset: 0x009CE4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E711 RID: 124689 RVA: 0x009D030C File Offset: 0x009CE50C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController2 = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildMassiveCombatStrongHoldUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E712 RID: 124690 RVA: 0x009D041C File Offset: 0x009CE61C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			string s = guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E713 RID: 124691 RVA: 0x009D0478 File Offset: 0x009CE678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStrongHoldUIController obj;
			LuaObject.checkType<GuildMassiveCombatStrongHoldUIController>(l, 2, out obj);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E714 RID: 124692 RVA: 0x009D04D4 File Offset: 0x009CE6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStrongHoldUIController obj;
			LuaObject.checkType<GuildMassiveCombatStrongHoldUIController>(l, 2, out obj);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E715 RID: 124693 RVA: 0x009D0530 File Offset: 0x009CE730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			Action<GuildMassiveCombatStrongHoldUIController> value;
			int num = LuaObject.checkDelegate<Action<GuildMassiveCombatStrongHoldUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildMassiveCombatStrongHoldUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					guildMassiveCombatStrongHoldUIController.EventOnClick -= value;
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

	// Token: 0x0601E716 RID: 124694 RVA: 0x009D05B0 File Offset: 0x009CE7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E717 RID: 124695 RVA: 0x009D0608 File Offset: 0x009CE808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E718 RID: 124696 RVA: 0x009D0664 File Offset: 0x009CE864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonEx(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_buttonEx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E719 RID: 124697 RVA: 0x009D06BC File Offset: 0x009CE8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buttonEx(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			ButtonEx buttonEx;
			LuaObject.checkType<ButtonEx>(l, 2, out buttonEx);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_buttonEx = buttonEx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E71A RID: 124698 RVA: 0x009D0718 File Offset: 0x009CE918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_suppressValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_suppressValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E71B RID: 124699 RVA: 0x009D0770 File Offset: 0x009CE970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_suppressValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			Text suppressValueText;
			LuaObject.checkType<Text>(l, 2, out suppressValueText);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_suppressValueText = suppressValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E71C RID: 124700 RVA: 0x009D07CC File Offset: 0x009CE9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_campImage(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_campImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E71D RID: 124701 RVA: 0x009D0824 File Offset: 0x009CEA24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_campImage(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			Image campImage;
			LuaObject.checkType<Image>(l, 2, out campImage);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_campImage = campImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E71E RID: 124702 RVA: 0x009D0880 File Offset: 0x009CEA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E71F RID: 124703 RVA: 0x009D08D8 File Offset: 0x009CEAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			Image icon;
			LuaObject.checkType<Image>(l, 2, out icon);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E720 RID: 124704 RVA: 0x009D0934 File Offset: 0x009CEB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_strongHold(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStrongHoldUIController.m_strongHold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E721 RID: 124705 RVA: 0x009D0988 File Offset: 0x009CEB88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_strongHold(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold strongHold;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out strongHold);
			guildMassiveCombatStrongHoldUIController.m_strongHold = strongHold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E722 RID: 124706 RVA: 0x009D09E0 File Offset: 0x009CEBE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E723 RID: 124707 RVA: 0x009D0A38 File Offset: 0x009CEC38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E724 RID: 124708 RVA: 0x009D0A94 File Offset: 0x009CEC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E725 RID: 124709 RVA: 0x009D0AEC File Offset: 0x009CECEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = (GuildMassiveCombatStrongHoldUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			guildMassiveCombatStrongHoldUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E726 RID: 124710 RVA: 0x009D0B48 File Offset: 0x009CED48
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMassiveCombatStrongHoldUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.InitGuildMassiveCombatStrongHoldInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.SetSuppressText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache12);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache13, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache15, true);
		string name3 = "m_buttonEx";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.get_m_buttonEx);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_m_buttonEx);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache17, true);
		string name4 = "m_suppressValueText";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.get_m_suppressValueText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_m_suppressValueText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache19, true);
		string name5 = "m_campImage";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.get_m_campImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_m_campImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1B, true);
		string name6 = "m_icon";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.get_m_icon);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_m_icon);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1D, true);
		string name7 = "m_strongHold";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.get_m_strongHold);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_m_strongHold);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache1F, true);
		string name8 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.get_m_playerContext);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache21, true);
		string name9 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.get_m_configDataLoader);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildMassiveCombatStrongHoldUIController), typeof(UIControllerBase));
	}

	// Token: 0x040147CA RID: 83914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040147CB RID: 83915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040147CC RID: 83916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040147CD RID: 83917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040147CE RID: 83918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040147CF RID: 83919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040147D0 RID: 83920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040147D1 RID: 83921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040147D2 RID: 83922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040147D3 RID: 83923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040147D4 RID: 83924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040147D5 RID: 83925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040147D6 RID: 83926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040147D7 RID: 83927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040147D8 RID: 83928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040147D9 RID: 83929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040147DA RID: 83930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040147DB RID: 83931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040147DC RID: 83932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040147DD RID: 83933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040147DE RID: 83934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040147DF RID: 83935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040147E0 RID: 83936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040147E1 RID: 83937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040147E2 RID: 83938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040147E3 RID: 83939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040147E4 RID: 83940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040147E5 RID: 83941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040147E6 RID: 83942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040147E7 RID: 83943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040147E8 RID: 83944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040147E9 RID: 83945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040147EA RID: 83946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040147EB RID: 83947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040147EC RID: 83948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040147ED RID: 83949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
