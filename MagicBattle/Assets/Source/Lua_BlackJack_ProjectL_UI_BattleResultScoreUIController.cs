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

// Token: 0x020013B2 RID: 5042
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController : LuaObject
{
	// Token: 0x0601BDAC RID: 114092 RVA: 0x00887538 File Offset: 0x00885738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBattleResultScore(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			battleResultScoreUIController.ShowBattleResultScore(battleReward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDAD RID: 114093 RVA: 0x00887590 File Offset: 0x00885790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextUnchartedScoreRewardGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			int rewardGroupId;
			LuaObject.checkType(l, 2, out rewardGroupId);
			int curScore;
			LuaObject.checkType(l, 3, out curScore);
			ConfigDataUnchartedScoreRewardGroupInfo nextUnchartedScoreRewardGroupInfo = battleResultScoreUIController.GetNextUnchartedScoreRewardGroupInfo(rewardGroupId, curScore);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextUnchartedScoreRewardGroupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDAE RID: 114094 RVA: 0x00887600 File Offset: 0x00885800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextGuildMassiveCombatIndividualPointsRewardInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			int curScore;
			LuaObject.checkType(l, 2, out curScore);
			ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo nextGuildMassiveCombatIndividualPointsRewardInfo = battleResultScoreUIController.GetNextGuildMassiveCombatIndividualPointsRewardInfo(curScore);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextGuildMassiveCombatIndividualPointsRewardInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDAF RID: 114095 RVA: 0x00887664 File Offset: 0x00885864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			battleResultScoreUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDB0 RID: 114096 RVA: 0x008876B8 File Offset: 0x008858B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowBattleResultScore(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			IEnumerator o = battleResultScoreUIController.m_luaExportHelper.Co_ShowBattleResultScore(battleReward);
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

	// Token: 0x0601BDB1 RID: 114097 RVA: 0x00887720 File Offset: 0x00885920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetUnchartedScoreReward(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			BattleReward unchartedScoreReward;
			LuaObject.checkType<BattleReward>(l, 2, out unchartedScoreReward);
			battleResultScoreUIController.m_luaExportHelper.SetUnchartedScoreReward(unchartedScoreReward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDB2 RID: 114098 RVA: 0x0088777C File Offset: 0x0088597C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGuildMassiveCombatScoreReward(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			BattleReward guildMassiveCombatScoreReward;
			LuaObject.checkType<BattleReward>(l, 2, out guildMassiveCombatScoreReward);
			battleResultScoreUIController.m_luaExportHelper.SetGuildMassiveCombatScoreReward(guildMassiveCombatScoreReward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDB3 RID: 114099 RVA: 0x008877D8 File Offset: 0x008859D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReward(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			BattleReward battleReward;
			LuaObject.checkType<BattleReward>(l, 2, out battleReward);
			string scoreName;
			LuaObject.checkType(l, 3, out scoreName);
			int curScore;
			LuaObject.checkType(l, 4, out curScore);
			string bonusDesc;
			LuaObject.checkType(l, 5, out bonusDesc);
			int nextScore;
			LuaObject.checkType(l, 6, out nextScore);
			List<Goods> nextRewardGoods;
			LuaObject.checkType<List<Goods>>(l, 7, out nextRewardGoods);
			battleResultScoreUIController.m_luaExportHelper.SetReward(battleReward, scoreName, curScore, bonusDesc, nextScore, nextRewardGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDB4 RID: 114100 RVA: 0x00887874 File Offset: 0x00885A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetAndWaitUIState(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out ctrl);
			string state;
			LuaObject.checkType(l, 3, out state);
			IEnumerator o = battleResultScoreUIController.m_luaExportHelper.Co_SetAndWaitUIState(ctrl, state);
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

	// Token: 0x0601BDB5 RID: 114101 RVA: 0x008878E8 File Offset: 0x00885AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			IEnumerator o = battleResultScoreUIController.m_luaExportHelper.Co_WaitClick();
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

	// Token: 0x0601BDB6 RID: 114102 RVA: 0x00887944 File Offset: 0x00885B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			battleResultScoreUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDB7 RID: 114103 RVA: 0x00887998 File Offset: 0x00885B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleResultScoreUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDB8 RID: 114104 RVA: 0x00887A04 File Offset: 0x00885C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			battleResultScoreUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDB9 RID: 114105 RVA: 0x00887A58 File Offset: 0x00885C58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			battleResultScoreUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDBA RID: 114106 RVA: 0x00887AAC File Offset: 0x00885CAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleResultScoreUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601BDBB RID: 114107 RVA: 0x00887B54 File Offset: 0x00885D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			battleResultScoreUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDBC RID: 114108 RVA: 0x00887BA8 File Offset: 0x00885DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleResultScoreUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDBD RID: 114109 RVA: 0x00887C14 File Offset: 0x00885E14
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
				BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleResultScoreUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleResultScoreUIController battleResultScoreUIController2 = (BattleResultScoreUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleResultScoreUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601BDBE RID: 114110 RVA: 0x00887D24 File Offset: 0x00885F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleResultScoreUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDBF RID: 114111 RVA: 0x00887D90 File Offset: 0x00885F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleResultScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDC0 RID: 114112 RVA: 0x00887DFC File Offset: 0x00885FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleResultScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDC1 RID: 114113 RVA: 0x00887E68 File Offset: 0x00886068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleResultScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDC2 RID: 114114 RVA: 0x00887ED4 File Offset: 0x008860D4
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
				BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleResultScoreUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleResultScoreUIController battleResultScoreUIController2 = (BattleResultScoreUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleResultScoreUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601BDC3 RID: 114115 RVA: 0x00887FE4 File Offset: 0x008861E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			string s = battleResultScoreUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601BDC4 RID: 114116 RVA: 0x00888040 File Offset: 0x00886240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			battleResultScoreUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDC5 RID: 114117 RVA: 0x00888094 File Offset: 0x00886294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			battleResultScoreUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDC6 RID: 114118 RVA: 0x008880E8 File Offset: 0x008862E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetUnchartedScoreInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo unchartedScoreInfo = BattleResultScoreUIController.LuaExportHelper.GetUnchartedScoreInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDC7 RID: 114119 RVA: 0x00888130 File Offset: 0x00886330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGuildMassiveCombatLevelInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo guildMassiveCombatLevelInfo = BattleResultScoreUIController.LuaExportHelper.GetGuildMassiveCombatLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDC8 RID: 114120 RVA: 0x00888178 File Offset: 0x00886378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleResultScoreUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleResultScoreUIController.EventOnClose -= value;
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

	// Token: 0x0601BDC9 RID: 114121 RVA: 0x008881F8 File Offset: 0x008863F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDCA RID: 114122 RVA: 0x00888250 File Offset: 0x00886450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			battleResultScoreUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDCB RID: 114123 RVA: 0x008882AC File Offset: 0x008864AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDCC RID: 114124 RVA: 0x00888304 File Offset: 0x00886504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			battleResultScoreUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDCD RID: 114125 RVA: 0x00888360 File Offset: 0x00886560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getScoreNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_getScoreNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDCE RID: 114126 RVA: 0x008883B8 File Offset: 0x008865B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_getScoreNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Text getScoreNameText;
			LuaObject.checkType<Text>(l, 2, out getScoreNameText);
			battleResultScoreUIController.m_luaExportHelper.m_getScoreNameText = getScoreNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDCF RID: 114127 RVA: 0x00888414 File Offset: 0x00886614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getScoreText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_getScoreText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD0 RID: 114128 RVA: 0x0088846C File Offset: 0x0088666C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getScoreText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Text getScoreText;
			LuaObject.checkType<Text>(l, 2, out getScoreText);
			battleResultScoreUIController.m_luaExportHelper.m_getScoreText = getScoreText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD1 RID: 114129 RVA: 0x008884C8 File Offset: 0x008866C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getScoreDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_getScoreDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD2 RID: 114130 RVA: 0x00888520 File Offset: 0x00886720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getScoreDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Text getScoreDescText;
			LuaObject.checkType<Text>(l, 2, out getScoreDescText);
			battleResultScoreUIController.m_luaExportHelper.m_getScoreDescText = getScoreDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD3 RID: 114131 RVA: 0x0088857C File Offset: 0x0088677C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_haveScoreNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_haveScoreNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD4 RID: 114132 RVA: 0x008885D4 File Offset: 0x008867D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_haveScoreNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Text haveScoreNameText;
			LuaObject.checkType<Text>(l, 2, out haveScoreNameText);
			battleResultScoreUIController.m_luaExportHelper.m_haveScoreNameText = haveScoreNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD5 RID: 114133 RVA: 0x00888630 File Offset: 0x00886830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_haveScoreText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_haveScoreText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD6 RID: 114134 RVA: 0x00888688 File Offset: 0x00886888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_haveScoreText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Text haveScoreText;
			LuaObject.checkType<Text>(l, 2, out haveScoreText);
			battleResultScoreUIController.m_luaExportHelper.m_haveScoreText = haveScoreText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD7 RID: 114135 RVA: 0x008886E4 File Offset: 0x008868E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_rewardGroupScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD8 RID: 114136 RVA: 0x0088873C File Offset: 0x0088693C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupScrollRect(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			ScrollRect rewardGroupScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out rewardGroupScrollRect);
			battleResultScoreUIController.m_luaExportHelper.m_rewardGroupScrollRect = rewardGroupScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDD9 RID: 114137 RVA: 0x00888798 File Offset: 0x00886998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_nextRewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDDA RID: 114138 RVA: 0x008887F0 File Offset: 0x008869F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			GameObject nextRewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out nextRewardGroupGameObject);
			battleResultScoreUIController.m_luaExportHelper.m_nextRewardGroupGameObject = nextRewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDDB RID: 114139 RVA: 0x0088884C File Offset: 0x00886A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextRewardScoreText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_nextRewardScoreText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDDC RID: 114140 RVA: 0x008888A4 File Offset: 0x00886AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextRewardScoreText(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Text nextRewardScoreText;
			LuaObject.checkType<Text>(l, 2, out nextRewardScoreText);
			battleResultScoreUIController.m_luaExportHelper.m_nextRewardScoreText = nextRewardScoreText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDDD RID: 114141 RVA: 0x00888900 File Offset: 0x00886B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextRewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_nextRewardGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDDE RID: 114142 RVA: 0x00888958 File Offset: 0x00886B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextRewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			Transform nextRewardGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out nextRewardGroupTransform);
			battleResultScoreUIController.m_luaExportHelper.m_nextRewardGroupTransform = nextRewardGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDDF RID: 114143 RVA: 0x008889B4 File Offset: 0x00886BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleResultScoreUIController.m_luaExportHelper.m_isClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDE0 RID: 114144 RVA: 0x00888A0C File Offset: 0x00886C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			BattleResultScoreUIController battleResultScoreUIController = (BattleResultScoreUIController)LuaObject.checkSelf(l);
			bool isClick;
			LuaObject.checkType(l, 2, out isClick);
			battleResultScoreUIController.m_luaExportHelper.m_isClick = isClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BDE1 RID: 114145 RVA: 0x00888A68 File Offset: 0x00886C68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleResultScoreUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.ShowBattleResultScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.GetNextUnchartedScoreRewardGroupInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.GetNextGuildMassiveCombatIndividualPointsRewardInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.Co_ShowBattleResultScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.SetUnchartedScoreReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.SetGuildMassiveCombatScoreReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.SetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.Co_SetAndWaitUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.Co_WaitClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.GetUnchartedScoreInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.GetGuildMassiveCombatLevelInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1B);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1C, true);
		string name2 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_backgroundButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1E, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache20, true);
		string name4 = "m_getScoreNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_getScoreNameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_getScoreNameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache22, true);
		string name5 = "m_getScoreText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_getScoreText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_getScoreText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache24, true);
		string name6 = "m_getScoreDescText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_getScoreDescText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_getScoreDescText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache26, true);
		string name7 = "m_haveScoreNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_haveScoreNameText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_haveScoreNameText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache28, true);
		string name8 = "m_haveScoreText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_haveScoreText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_haveScoreText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2A, true);
		string name9 = "m_rewardGroupScrollRect";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_rewardGroupScrollRect);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_rewardGroupScrollRect);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2C, true);
		string name10 = "m_nextRewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_nextRewardGroupGameObject);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_nextRewardGroupGameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2E, true);
		string name11 = "m_nextRewardScoreText";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_nextRewardScoreText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_nextRewardScoreText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache30, true);
		string name12 = "m_nextRewardGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_nextRewardGroupTransform);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_nextRewardGroupTransform);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache32, true);
		string name13 = "m_isClick";
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.get_m_isClick);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.set_m_isClick);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.<>f__mg$cache34, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleResultScoreUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401202A RID: 73770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401202B RID: 73771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401202C RID: 73772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401202D RID: 73773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401202E RID: 73774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401202F RID: 73775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012030 RID: 73776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012031 RID: 73777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012032 RID: 73778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012033 RID: 73779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012034 RID: 73780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012035 RID: 73781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012036 RID: 73782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012037 RID: 73783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012038 RID: 73784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012039 RID: 73785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401203A RID: 73786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401203B RID: 73787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401203C RID: 73788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401203D RID: 73789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401203E RID: 73790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401203F RID: 73791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012040 RID: 73792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012041 RID: 73793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012042 RID: 73794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012043 RID: 73795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012044 RID: 73796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012045 RID: 73797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012046 RID: 73798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012047 RID: 73799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012048 RID: 73800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012049 RID: 73801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401204A RID: 73802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401204B RID: 73803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401204C RID: 73804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401204D RID: 73805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401204E RID: 73806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401204F RID: 73807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012050 RID: 73808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012051 RID: 73809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012052 RID: 73810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012053 RID: 73811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012054 RID: 73812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012055 RID: 73813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012056 RID: 73814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012057 RID: 73815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012058 RID: 73816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012059 RID: 73817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401205A RID: 73818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401205B RID: 73819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401205C RID: 73820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401205D RID: 73821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401205E RID: 73822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
