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

// Token: 0x0200148A RID: 5258
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController : LuaObject
{
	// Token: 0x0601E6DB RID: 124635 RVA: 0x009CE968 File Offset: 0x009CCB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitGuildMassiveCombatLastHeroInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool isUsed;
			LuaObject.checkType(l, 3, out isUsed);
			bool isPowerUp;
			LuaObject.checkType(l, 4, out isPowerUp);
			guildMassiveCombatLastHeroUIController.InitGuildMassiveCombatLastHeroInfo(hero, isUsed, isPowerUp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6DC RID: 124636 RVA: 0x009CE9DC File Offset: 0x009CCBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6DD RID: 124637 RVA: 0x009CEA30 File Offset: 0x009CCC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6DE RID: 124638 RVA: 0x009CEA84 File Offset: 0x009CCC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6DF RID: 124639 RVA: 0x009CEAF0 File Offset: 0x009CCCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6E0 RID: 124640 RVA: 0x009CEB44 File Offset: 0x009CCD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6E1 RID: 124641 RVA: 0x009CEB98 File Offset: 0x009CCD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E6E2 RID: 124642 RVA: 0x009CEC40 File Offset: 0x009CCE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6E3 RID: 124643 RVA: 0x009CEC94 File Offset: 0x009CCE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6E4 RID: 124644 RVA: 0x009CED00 File Offset: 0x009CCF00
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
				GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController2 = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildMassiveCombatLastHeroUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E6E5 RID: 124645 RVA: 0x009CEE10 File Offset: 0x009CD010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6E6 RID: 124646 RVA: 0x009CEE7C File Offset: 0x009CD07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6E7 RID: 124647 RVA: 0x009CEEE8 File Offset: 0x009CD0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6E8 RID: 124648 RVA: 0x009CEF54 File Offset: 0x009CD154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6E9 RID: 124649 RVA: 0x009CEFC0 File Offset: 0x009CD1C0
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
				GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController2 = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildMassiveCombatLastHeroUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E6EA RID: 124650 RVA: 0x009CF0D0 File Offset: 0x009CD2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			string s = guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E6EB RID: 124651 RVA: 0x009CF12C File Offset: 0x009CD32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatLastHeroUIController obj;
			LuaObject.checkType<GuildMassiveCombatLastHeroUIController>(l, 2, out obj);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6EC RID: 124652 RVA: 0x009CF188 File Offset: 0x009CD388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatLastHeroUIController obj;
			LuaObject.checkType<GuildMassiveCombatLastHeroUIController>(l, 2, out obj);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6ED RID: 124653 RVA: 0x009CF1E4 File Offset: 0x009CD3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			Action<GuildMassiveCombatLastHeroUIController> value;
			int num = LuaObject.checkDelegate<Action<GuildMassiveCombatLastHeroUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildMassiveCombatLastHeroUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					guildMassiveCombatLastHeroUIController.EventOnClick -= value;
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

	// Token: 0x0601E6EE RID: 124654 RVA: 0x009CF264 File Offset: 0x009CD464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6EF RID: 124655 RVA: 0x009CF2BC File Offset: 0x009CD4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F0 RID: 124656 RVA: 0x009CF318 File Offset: 0x009CD518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_heroIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F1 RID: 124657 RVA: 0x009CF370 File Offset: 0x009CD570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			Image heroIcon;
			LuaObject.checkType<Image>(l, 2, out heroIcon);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_heroIcon = heroIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F2 RID: 124658 RVA: 0x009CF3CC File Offset: 0x009CD5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_armyIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F3 RID: 124659 RVA: 0x009CF424 File Offset: 0x009CD624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			Image armyIcon;
			LuaObject.checkType<Image>(l, 2, out armyIcon);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_armyIcon = armyIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F4 RID: 124660 RVA: 0x009CF480 File Offset: 0x009CD680
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F5 RID: 124661 RVA: 0x009CF4D8 File Offset: 0x009CD6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F6 RID: 124662 RVA: 0x009CF534 File Offset: 0x009CD734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerUpGo(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_powerUpGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F7 RID: 124663 RVA: 0x009CF58C File Offset: 0x009CD78C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_powerUpGo(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController = (GuildMassiveCombatLastHeroUIController)LuaObject.checkSelf(l);
			GameObject powerUpGo;
			LuaObject.checkType<GameObject>(l, 2, out powerUpGo);
			guildMassiveCombatLastHeroUIController.m_luaExportHelper.m_powerUpGo = powerUpGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E6F8 RID: 124664 RVA: 0x009CF5E8 File Offset: 0x009CD7E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMassiveCombatLastHeroUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.InitGuildMassiveCombatLastHeroInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache11);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache12, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache14, true);
		string name3 = "m_heroIcon";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.get_m_heroIcon);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.set_m_heroIcon);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache16, true);
		string name4 = "m_armyIcon";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.get_m_armyIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.set_m_armyIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache18, true);
		string name5 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.get_m_levelText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1A, true);
		string name6 = "m_powerUpGo";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.get_m_powerUpGo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.set_m_powerUpGo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.<>f__mg$cache1C, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildMassiveCombatLastHeroUIController), typeof(UIControllerBase));
	}

	// Token: 0x040147A9 RID: 83881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040147AA RID: 83882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040147AB RID: 83883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040147AC RID: 83884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040147AD RID: 83885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040147AE RID: 83886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040147AF RID: 83887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040147B0 RID: 83888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040147B1 RID: 83889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040147B2 RID: 83890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040147B3 RID: 83891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040147B4 RID: 83892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040147B5 RID: 83893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040147B6 RID: 83894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040147B7 RID: 83895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040147B8 RID: 83896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040147B9 RID: 83897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040147BA RID: 83898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040147BB RID: 83899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040147BC RID: 83900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040147BD RID: 83901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040147BE RID: 83902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040147BF RID: 83903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040147C0 RID: 83904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040147C1 RID: 83905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040147C2 RID: 83906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040147C3 RID: 83907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040147C4 RID: 83908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040147C5 RID: 83909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
