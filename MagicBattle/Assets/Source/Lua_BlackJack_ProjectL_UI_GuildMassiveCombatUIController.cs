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

// Token: 0x0200148F RID: 5263
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController : LuaObject
{
	// Token: 0x0601E72B RID: 124715 RVA: 0x009D1118 File Offset: 0x009CF318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GuildMassiveCombatUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.GuildMassiveCombatUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E72C RID: 124716 RVA: 0x009D1164 File Offset: 0x009CF364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowCombatResultEffect(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			bool isWin;
			LuaObject.checkType(l, 2, out isWin);
			Action onFinish;
			LuaObject.checkDelegate<Action>(l, 3, out onFinish);
			guildMassiveCombatUIController.ShowCombatResultEffect(isWin, onFinish);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E72D RID: 124717 RVA: 0x009D11C8 File Offset: 0x009CF3C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E72E RID: 124718 RVA: 0x009D1214 File Offset: 0x009CF414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E72F RID: 124719 RVA: 0x009D1260 File Offset: 0x009CF460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E730 RID: 124720 RVA: 0x009D12B4 File Offset: 0x009CF4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LateUpdate(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.LateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E731 RID: 124721 RVA: 0x009D1308 File Offset: 0x009CF508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateStrongHolds(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.UpdateStrongHolds();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E732 RID: 124722 RVA: 0x009D135C File Offset: 0x009CF55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildMassiveCombatStrongHoldClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStrongHoldUIController ctrl;
			LuaObject.checkType<GuildMassiveCombatStrongHoldUIController>(l, 2, out ctrl);
			guildMassiveCombatUIController.m_luaExportHelper.OnGuildMassiveCombatStrongHoldClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E733 RID: 124723 RVA: 0x009D13B8 File Offset: 0x009CF5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetQuestInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold questInfoPanel;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out questInfoPanel);
			guildMassiveCombatUIController.m_luaExportHelper.SetQuestInfoPanel(questInfoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E734 RID: 124724 RVA: 0x009D1414 File Offset: 0x009CF614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRewardGroup(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			List<Goods> rewardGroup;
			LuaObject.checkType<List<Goods>>(l, 2, out rewardGroup);
			guildMassiveCombatUIController.m_luaExportHelper.SetRewardGroup(rewardGroup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E735 RID: 124725 RVA: 0x009D1470 File Offset: 0x009CF670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroListPanel(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold heroListPanel;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out heroListPanel);
			guildMassiveCombatUIController.m_luaExportHelper.SetHeroListPanel(heroListPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E736 RID: 124726 RVA: 0x009D14CC File Offset: 0x009CF6CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCombatHeroList(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold strongHoldInfo;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out strongHoldInfo);
			List<Hero> combatHeroList = guildMassiveCombatUIController.m_luaExportHelper.GetCombatHeroList(strongHoldInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatHeroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E737 RID: 124727 RVA: 0x009D1534 File Offset: 0x009CF734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComparerCombatHeroByPower(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Hero h;
			LuaObject.checkType<Hero>(l, 2, out h);
			Hero h2;
			LuaObject.checkType<Hero>(l, 3, out h2);
			int i = guildMassiveCombatUIController.m_luaExportHelper.ComparerCombatHeroByPower(h, h2);
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

	// Token: 0x0601E738 RID: 124728 RVA: 0x009D15A8 File Offset: 0x009CF7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnQuestInfoPanelBackBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.OnQuestInfoPanelBackBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E739 RID: 124729 RVA: 0x009D15FC File Offset: 0x009CF7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnQuestInfoPanelPersonalButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.OnQuestInfoPanelPersonalButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E73A RID: 124730 RVA: 0x009D1650 File Offset: 0x009CF850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnQuestInfoPanelTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.OnQuestInfoPanelTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E73B RID: 124731 RVA: 0x009D16A4 File Offset: 0x009CF8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.OnRankingButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E73C RID: 124732 RVA: 0x009D16F8 File Offset: 0x009CF8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRewardsButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.OnRewardsButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E73D RID: 124733 RVA: 0x009D174C File Offset: 0x009CF94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGiveUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.OnGiveUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E73E RID: 124734 RVA: 0x009D17A0 File Offset: 0x009CF9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E73F RID: 124735 RVA: 0x009D17F4 File Offset: 0x009CF9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E740 RID: 124736 RVA: 0x009D1860 File Offset: 0x009CFA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E741 RID: 124737 RVA: 0x009D18B4 File Offset: 0x009CFAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E742 RID: 124738 RVA: 0x009D1908 File Offset: 0x009CFB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildMassiveCombatUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E743 RID: 124739 RVA: 0x009D19B0 File Offset: 0x009CFBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E744 RID: 124740 RVA: 0x009D1A04 File Offset: 0x009CFC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E745 RID: 124741 RVA: 0x009D1A70 File Offset: 0x009CFC70
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
				GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildMassiveCombatUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildMassiveCombatUIController guildMassiveCombatUIController2 = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildMassiveCombatUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E746 RID: 124742 RVA: 0x009D1B80 File Offset: 0x009CFD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E747 RID: 124743 RVA: 0x009D1BEC File Offset: 0x009CFDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E748 RID: 124744 RVA: 0x009D1C58 File Offset: 0x009CFE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E749 RID: 124745 RVA: 0x009D1CC4 File Offset: 0x009CFEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildMassiveCombatUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E74A RID: 124746 RVA: 0x009D1D30 File Offset: 0x009CFF30
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
				GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildMassiveCombatUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildMassiveCombatUIController guildMassiveCombatUIController2 = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildMassiveCombatUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E74B RID: 124747 RVA: 0x009D1E40 File Offset: 0x009D0040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			string s = guildMassiveCombatUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E74C RID: 124748 RVA: 0x009D1E9C File Offset: 0x009D009C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E74D RID: 124749 RVA: 0x009D1EF0 File Offset: 0x009D00F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E74E RID: 124750 RVA: 0x009D1F44 File Offset: 0x009D0144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGiveUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.__callDele_EventOnGiveUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E74F RID: 124751 RVA: 0x009D1F98 File Offset: 0x009D0198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGiveUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			guildMassiveCombatUIController.m_luaExportHelper.__clearDele_EventOnGiveUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E750 RID: 124752 RVA: 0x009D1FEC File Offset: 0x009D01EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSingleBattle(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold obj;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out obj);
			guildMassiveCombatUIController.m_luaExportHelper.__callDele_EventOnSingleBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E751 RID: 124753 RVA: 0x009D2048 File Offset: 0x009D0248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSingleBattle(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold obj;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out obj);
			guildMassiveCombatUIController.m_luaExportHelper.__clearDele_EventOnSingleBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E752 RID: 124754 RVA: 0x009D20A4 File Offset: 0x009D02A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTeamBattle(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold obj;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out obj);
			guildMassiveCombatUIController.m_luaExportHelper.__callDele_EventOnTeamBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E753 RID: 124755 RVA: 0x009D2100 File Offset: 0x009D0300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTeamBattle(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold obj;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out obj);
			guildMassiveCombatUIController.m_luaExportHelper.__clearDele_EventOnTeamBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E754 RID: 124756 RVA: 0x009D215C File Offset: 0x009D035C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E755 RID: 124757 RVA: 0x009D21B4 File Offset: 0x009D03B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			guildMassiveCombatUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E756 RID: 124758 RVA: 0x009D2210 File Offset: 0x009D0410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E757 RID: 124759 RVA: 0x009D2268 File Offset: 0x009D0468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E758 RID: 124760 RVA: 0x009D22C4 File Offset: 0x009D04C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankingButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_rankingButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E759 RID: 124761 RVA: 0x009D231C File Offset: 0x009D051C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankingButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button rankingButton;
			LuaObject.checkType<Button>(l, 2, out rankingButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_rankingButton = rankingButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E75A RID: 124762 RVA: 0x009D2378 File Offset: 0x009D0578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardsButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_rewardsButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E75B RID: 124763 RVA: 0x009D23D0 File Offset: 0x009D05D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardsButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button rewardsButton;
			LuaObject.checkType<Button>(l, 2, out rewardsButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_rewardsButton = rewardsButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E75C RID: 124764 RVA: 0x009D242C File Offset: 0x009D062C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_giveUpButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_giveUpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E75D RID: 124765 RVA: 0x009D2484 File Offset: 0x009D0684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_giveUpButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button giveUpButton;
			LuaObject.checkType<Button>(l, 2, out giveUpButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_giveUpButton = giveUpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E75E RID: 124766 RVA: 0x009D24E0 File Offset: 0x009D06E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_difficultLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_difficultLevelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E75F RID: 124767 RVA: 0x009D2538 File Offset: 0x009D0738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_difficultLevelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController difficultLevelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out difficultLevelStateCtrl);
			guildMassiveCombatUIController.m_luaExportHelper.m_difficultLevelStateCtrl = difficultLevelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E760 RID: 124768 RVA: 0x009D2594 File Offset: 0x009D0794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildCoinText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_guildCoinText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E761 RID: 124769 RVA: 0x009D25EC File Offset: 0x009D07EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildCoinText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Text guildCoinText;
			LuaObject.checkType<Text>(l, 2, out guildCoinText);
			guildMassiveCombatUIController.m_luaExportHelper.m_guildCoinText = guildCoinText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E762 RID: 124770 RVA: 0x009D2648 File Offset: 0x009D0848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildIntegralText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_guildIntegralText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E763 RID: 124771 RVA: 0x009D26A0 File Offset: 0x009D08A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildIntegralText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Text guildIntegralText;
			LuaObject.checkType<Text>(l, 2, out guildIntegralText);
			guildMassiveCombatUIController.m_luaExportHelper.m_guildIntegralText = guildIntegralText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E764 RID: 124772 RVA: 0x009D26FC File Offset: 0x009D08FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questPanelGo(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questPanelGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E765 RID: 124773 RVA: 0x009D2754 File Offset: 0x009D0954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questPanelGo(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GameObject questPanelGo;
			LuaObject.checkType<GameObject>(l, 2, out questPanelGo);
			guildMassiveCombatUIController.m_luaExportHelper.m_questPanelGo = questPanelGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E766 RID: 124774 RVA: 0x009D27B0 File Offset: 0x009D09B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_contributionPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_contributionPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E767 RID: 124775 RVA: 0x009D2808 File Offset: 0x009D0A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_contributionPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController contributionPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out contributionPanelStateCtrl);
			guildMassiveCombatUIController.m_luaExportHelper.m_contributionPanelStateCtrl = contributionPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E768 RID: 124776 RVA: 0x009D2864 File Offset: 0x009D0A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_contributionPanelBackBGButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_contributionPanelBackBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E769 RID: 124777 RVA: 0x009D28BC File Offset: 0x009D0ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_contributionPanelBackBGButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button contributionPanelBackBGButton;
			LuaObject.checkType<Button>(l, 2, out contributionPanelBackBGButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_contributionPanelBackBGButton = contributionPanelBackBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E76A RID: 124778 RVA: 0x009D2918 File Offset: 0x009D0B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_rewardInfoPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E76B RID: 124779 RVA: 0x009D2970 File Offset: 0x009D0B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController rewardInfoPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out rewardInfoPanelStateCtrl);
			guildMassiveCombatUIController.m_luaExportHelper.m_rewardInfoPanelStateCtrl = rewardInfoPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E76C RID: 124780 RVA: 0x009D29CC File Offset: 0x009D0BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardInfoBackBGButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_rewardInfoBackBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E76D RID: 124781 RVA: 0x009D2A24 File Offset: 0x009D0C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardInfoBackBGButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button rewardInfoBackBGButton;
			LuaObject.checkType<Button>(l, 2, out rewardInfoBackBGButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_rewardInfoBackBGButton = rewardInfoBackBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E76E RID: 124782 RVA: 0x009D2A80 File Offset: 0x009D0C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E76F RID: 124783 RVA: 0x009D2AD8 File Offset: 0x009D0CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController questInfoPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out questInfoPanelStateCtrl);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelStateCtrl = questInfoPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E770 RID: 124784 RVA: 0x009D2B34 File Offset: 0x009D0D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelBackBGButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelBackBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E771 RID: 124785 RVA: 0x009D2B8C File Offset: 0x009D0D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelBackBGButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button questInfoPanelBackBGButton;
			LuaObject.checkType<Button>(l, 2, out questInfoPanelBackBGButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelBackBGButton = questInfoPanelBackBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E772 RID: 124786 RVA: 0x009D2BE8 File Offset: 0x009D0DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelRewardGroup(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelRewardGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E773 RID: 124787 RVA: 0x009D2C40 File Offset: 0x009D0E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelRewardGroup(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GameObject questInfoPanelRewardGroup;
			LuaObject.checkType<GameObject>(l, 2, out questInfoPanelRewardGroup);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelRewardGroup = questInfoPanelRewardGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E774 RID: 124788 RVA: 0x009D2C9C File Offset: 0x009D0E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelHardText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelHardText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E775 RID: 124789 RVA: 0x009D2CF4 File Offset: 0x009D0EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelHardText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Text questInfoPanelHardText;
			LuaObject.checkType<Text>(l, 2, out questInfoPanelHardText);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelHardText = questInfoPanelHardText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E776 RID: 124790 RVA: 0x009D2D50 File Offset: 0x009D0F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelSuppressValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelSuppressValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E777 RID: 124791 RVA: 0x009D2DA8 File Offset: 0x009D0FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelSuppressValueText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Text questInfoPanelSuppressValueText;
			LuaObject.checkType<Text>(l, 2, out questInfoPanelSuppressValueText);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelSuppressValueText = questInfoPanelSuppressValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E778 RID: 124792 RVA: 0x009D2E04 File Offset: 0x009D1004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelHeroListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelHeroListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E779 RID: 124793 RVA: 0x009D2E5C File Offset: 0x009D105C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelHeroListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			ScrollRect questInfoPanelHeroListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out questInfoPanelHeroListScrollRect);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelHeroListScrollRect = questInfoPanelHeroListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E77A RID: 124794 RVA: 0x009D2EB8 File Offset: 0x009D10B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelHeroListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelHeroListScrollContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E77B RID: 124795 RVA: 0x009D2F10 File Offset: 0x009D1110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelHeroListScrollContent(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GameObject questInfoPanelHeroListScrollContent;
			LuaObject.checkType<GameObject>(l, 2, out questInfoPanelHeroListScrollContent);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelHeroListScrollContent = questInfoPanelHeroListScrollContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E77C RID: 124796 RVA: 0x009D2F6C File Offset: 0x009D116C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelTeamButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelTeamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E77D RID: 124797 RVA: 0x009D2FC4 File Offset: 0x009D11C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelTeamButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button questInfoPanelTeamButton;
			LuaObject.checkType<Button>(l, 2, out questInfoPanelTeamButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelTeamButton = questInfoPanelTeamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E77E RID: 124798 RVA: 0x009D3020 File Offset: 0x009D1220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelPersonalButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelPersonalButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E77F RID: 124799 RVA: 0x009D3078 File Offset: 0x009D1278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelPersonalButton(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Button questInfoPanelPersonalButton;
			LuaObject.checkType<Button>(l, 2, out questInfoPanelPersonalButton);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelPersonalButton = questInfoPanelPersonalButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E780 RID: 124800 RVA: 0x009D30D4 File Offset: 0x009D12D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelBuffIconImage(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelBuffIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E781 RID: 124801 RVA: 0x009D312C File Offset: 0x009D132C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelBuffIconImage(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Image questInfoPanelBuffIconImage;
			LuaObject.checkType<Image>(l, 2, out questInfoPanelBuffIconImage);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelBuffIconImage = questInfoPanelBuffIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E782 RID: 124802 RVA: 0x009D3188 File Offset: 0x009D1388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelBuffText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelBuffText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E783 RID: 124803 RVA: 0x009D31E0 File Offset: 0x009D13E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelBuffText(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Text questInfoPanelBuffText;
			LuaObject.checkType<Text>(l, 2, out questInfoPanelBuffText);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelBuffText = questInfoPanelBuffText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E784 RID: 124804 RVA: 0x009D323C File Offset: 0x009D143C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_questInfoPanelHeroListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelHeroListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E785 RID: 124805 RVA: 0x009D3294 File Offset: 0x009D1494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_questInfoPanelHeroListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GameObject questInfoPanelHeroListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out questInfoPanelHeroListItemPrefab);
			guildMassiveCombatUIController.m_luaExportHelper.m_questInfoPanelHeroListItemPrefab = questInfoPanelHeroListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E786 RID: 124806 RVA: 0x009D32F0 File Offset: 0x009D14F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildMassiveCombatResultStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_guildMassiveCombatResultStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E787 RID: 124807 RVA: 0x009D3348 File Offset: 0x009D1548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildMassiveCombatResultStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController guildMassiveCombatResultStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out guildMassiveCombatResultStateCtrl);
			guildMassiveCombatUIController.m_luaExportHelper.m_guildMassiveCombatResultStateCtrl = guildMassiveCombatResultStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E788 RID: 124808 RVA: 0x009D33A4 File Offset: 0x009D15A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildMassiveCombatUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					guildMassiveCombatUIController.EventOnReturn -= value;
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

	// Token: 0x0601E789 RID: 124809 RVA: 0x009D3424 File Offset: 0x009D1624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGiveUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildMassiveCombatUIController.EventOnGiveUpButtonClick += value;
				}
				else if (num == 2)
				{
					guildMassiveCombatUIController.EventOnGiveUpButtonClick -= value;
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

	// Token: 0x0601E78A RID: 124810 RVA: 0x009D34A4 File Offset: 0x009D16A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSingleBattle(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Action<GuildMassiveCombatStronghold> value;
			int num = LuaObject.checkDelegate<Action<GuildMassiveCombatStronghold>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildMassiveCombatUIController.EventOnSingleBattle += value;
				}
				else if (num == 2)
				{
					guildMassiveCombatUIController.EventOnSingleBattle -= value;
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

	// Token: 0x0601E78B RID: 124811 RVA: 0x009D3524 File Offset: 0x009D1724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTeamBattle(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			Action<GuildMassiveCombatStronghold> value;
			int num = LuaObject.checkDelegate<Action<GuildMassiveCombatStronghold>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildMassiveCombatUIController.EventOnTeamBattle += value;
				}
				else if (num == 2)
				{
					guildMassiveCombatUIController.EventOnTeamBattle -= value;
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

	// Token: 0x0601E78C RID: 124812 RVA: 0x009D35A4 File Offset: 0x009D17A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E78D RID: 124813 RVA: 0x009D35FC File Offset: 0x009D17FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			guildMassiveCombatUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E78E RID: 124814 RVA: 0x009D3658 File Offset: 0x009D1858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E78F RID: 124815 RVA: 0x009D36B0 File Offset: 0x009D18B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			guildMassiveCombatUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E790 RID: 124816 RVA: 0x009D370C File Offset: 0x009D190C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curCombatInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_curCombatInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E791 RID: 124817 RVA: 0x009D3764 File Offset: 0x009D1964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curCombatInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatInfo curCombatInfo;
			LuaObject.checkType<GuildMassiveCombatInfo>(l, 2, out curCombatInfo);
			guildMassiveCombatUIController.m_luaExportHelper.m_curCombatInfo = curCombatInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E792 RID: 124818 RVA: 0x009D37C0 File Offset: 0x009D19C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curSelectStrongHold(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_curSelectStrongHold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E793 RID: 124819 RVA: 0x009D3818 File Offset: 0x009D1A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectStrongHold(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold curSelectStrongHold;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out curSelectStrongHold);
			guildMassiveCombatUIController.m_luaExportHelper.m_curSelectStrongHold = curSelectStrongHold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E794 RID: 124820 RVA: 0x009D3874 File Offset: 0x009D1A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_strongHoldsCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatUIController.m_luaExportHelper.m_strongHoldsCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E795 RID: 124821 RVA: 0x009D38CC File Offset: 0x009D1ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_strongHoldsCtrlList(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatUIController guildMassiveCombatUIController = (GuildMassiveCombatUIController)LuaObject.checkSelf(l);
			List<GuildMassiveCombatStrongHoldUIController> strongHoldsCtrlList;
			LuaObject.checkType<List<GuildMassiveCombatStrongHoldUIController>>(l, 2, out strongHoldsCtrlList);
			guildMassiveCombatUIController.m_luaExportHelper.m_strongHoldsCtrlList = strongHoldsCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E796 RID: 124822 RVA: 0x009D3928 File Offset: 0x009D1B28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMassiveCombatUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.GuildMassiveCombatUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.ShowCombatResultEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.LateUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.UpdateStrongHolds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnGuildMassiveCombatStrongHoldClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.SetQuestInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.SetRewardGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.SetHeroListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.GetCombatHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.ComparerCombatHeroByPower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnQuestInfoPanelBackBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnQuestInfoPanelPersonalButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnQuestInfoPanelTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnRankingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnRewardsButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnGiveUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callDele_EventOnGiveUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__clearDele_EventOnGiveUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callDele_EventOnSingleBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__clearDele_EventOnSingleBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__callDele_EventOnTeamBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.__clearDele_EventOnTeamBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache28);
		string name = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_stateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2A, true);
		string name2 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_returnButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2C, true);
		string name3 = "m_rankingButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_rankingButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_rankingButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2E, true);
		string name4 = "m_rewardsButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_rewardsButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_rewardsButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache30, true);
		string name5 = "m_giveUpButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_giveUpButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_giveUpButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache32, true);
		string name6 = "m_difficultLevelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_difficultLevelStateCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_difficultLevelStateCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache34, true);
		string name7 = "m_guildCoinText";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_guildCoinText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_guildCoinText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache36, true);
		string name8 = "m_guildIntegralText";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_guildIntegralText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_guildIntegralText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache38, true);
		string name9 = "m_questPanelGo";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questPanelGo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questPanelGo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3A, true);
		string name10 = "m_contributionPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_contributionPanelStateCtrl);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_contributionPanelStateCtrl);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3C, true);
		string name11 = "m_contributionPanelBackBGButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_contributionPanelBackBGButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_contributionPanelBackBGButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3E, true);
		string name12 = "m_rewardInfoPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_rewardInfoPanelStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_rewardInfoPanelStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache40, true);
		string name13 = "m_rewardInfoBackBGButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_rewardInfoBackBGButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_rewardInfoBackBGButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache42, true);
		string name14 = "m_questInfoPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache44, true);
		string name15 = "m_questInfoPanelBackBGButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelBackBGButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelBackBGButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache46, true);
		string name16 = "m_questInfoPanelRewardGroup";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelRewardGroup);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelRewardGroup);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache48, true);
		string name17 = "m_questInfoPanelHardText";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelHardText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelHardText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4A, true);
		string name18 = "m_questInfoPanelSuppressValueText";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelSuppressValueText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelSuppressValueText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4C, true);
		string name19 = "m_questInfoPanelHeroListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelHeroListScrollRect);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelHeroListScrollRect);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4E, true);
		string name20 = "m_questInfoPanelHeroListScrollContent";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelHeroListScrollContent);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelHeroListScrollContent);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache50, true);
		string name21 = "m_questInfoPanelTeamButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelTeamButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelTeamButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache52, true);
		string name22 = "m_questInfoPanelPersonalButton";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelPersonalButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelPersonalButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache54, true);
		string name23 = "m_questInfoPanelBuffIconImage";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelBuffIconImage);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelBuffIconImage);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache56, true);
		string name24 = "m_questInfoPanelBuffText";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelBuffText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelBuffText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache58, true);
		string name25 = "m_questInfoPanelHeroListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_questInfoPanelHeroListItemPrefab);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_questInfoPanelHeroListItemPrefab);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5A, true);
		string name26 = "m_guildMassiveCombatResultStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_guildMassiveCombatResultStateCtrl);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_guildMassiveCombatResultStateCtrl);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5C, true);
		string name27 = "EventOnReturn";
		LuaCSFunction get27 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5D, true);
		string name28 = "EventOnGiveUpButtonClick";
		LuaCSFunction get28 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_EventOnGiveUpButtonClick);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5E, true);
		string name29 = "EventOnSingleBattle";
		LuaCSFunction get29 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_EventOnSingleBattle);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache5F, true);
		string name30 = "EventOnTeamBattle";
		LuaCSFunction get30 = null;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_EventOnTeamBattle);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache60, true);
		string name31 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_playerContext);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache62, true);
		string name32 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_configDataLoader);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache64, true);
		string name33 = "m_curCombatInfo";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_curCombatInfo);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_curCombatInfo);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache66, true);
		string name34 = "m_curSelectStrongHold";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_curSelectStrongHold);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_curSelectStrongHold);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache68, true);
		string name35 = "m_strongHoldsCtrlList";
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.get_m_strongHoldsCtrlList);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.set_m_strongHoldsCtrlList);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.<>f__mg$cache6A, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildMassiveCombatUIController), typeof(UIControllerBase));
	}

	// Token: 0x040147EF RID: 83951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040147F0 RID: 83952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040147F1 RID: 83953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040147F2 RID: 83954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040147F3 RID: 83955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040147F4 RID: 83956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040147F5 RID: 83957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040147F6 RID: 83958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040147F7 RID: 83959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040147F8 RID: 83960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040147F9 RID: 83961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040147FA RID: 83962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040147FB RID: 83963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040147FC RID: 83964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040147FD RID: 83965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040147FE RID: 83966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040147FF RID: 83967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014800 RID: 83968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014801 RID: 83969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014802 RID: 83970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014803 RID: 83971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014804 RID: 83972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014805 RID: 83973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014806 RID: 83974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014807 RID: 83975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014808 RID: 83976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014809 RID: 83977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401480A RID: 83978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401480B RID: 83979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401480C RID: 83980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401480D RID: 83981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401480E RID: 83982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401480F RID: 83983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014810 RID: 83984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014811 RID: 83985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014812 RID: 83986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014813 RID: 83987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014814 RID: 83988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014815 RID: 83989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014816 RID: 83990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014817 RID: 83991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014818 RID: 83992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014819 RID: 83993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401481A RID: 83994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401481B RID: 83995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401481C RID: 83996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401481D RID: 83997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401481E RID: 83998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401481F RID: 83999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014820 RID: 84000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014821 RID: 84001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014822 RID: 84002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014823 RID: 84003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014824 RID: 84004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014825 RID: 84005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014826 RID: 84006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014827 RID: 84007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014828 RID: 84008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014829 RID: 84009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401482A RID: 84010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401482B RID: 84011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401482C RID: 84012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401482D RID: 84013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401482E RID: 84014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401482F RID: 84015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014830 RID: 84016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014831 RID: 84017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014832 RID: 84018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014833 RID: 84019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014834 RID: 84020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014835 RID: 84021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014836 RID: 84022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014837 RID: 84023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014838 RID: 84024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014839 RID: 84025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401483A RID: 84026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401483B RID: 84027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401483C RID: 84028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401483D RID: 84029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401483E RID: 84030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401483F RID: 84031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014840 RID: 84032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014841 RID: 84033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014842 RID: 84034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014843 RID: 84035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014844 RID: 84036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014845 RID: 84037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014846 RID: 84038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014847 RID: 84039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014848 RID: 84040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014849 RID: 84041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401484A RID: 84042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401484B RID: 84043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401484C RID: 84044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401484D RID: 84045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401484E RID: 84046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401484F RID: 84047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014850 RID: 84048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014851 RID: 84049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014852 RID: 84050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014853 RID: 84051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04014854 RID: 84052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04014855 RID: 84053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04014856 RID: 84054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04014857 RID: 84055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04014858 RID: 84056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04014859 RID: 84057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;
}
