using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001401 RID: 5121
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CombatUIController : LuaObject
{
	// Token: 0x0601CD6D RID: 118125 RVA: 0x009045B4 File Offset: 0x009027B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			FxPlayer fxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out fxPlayer);
			combatUIController.Initialize(fxPlayer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD6E RID: 118126 RVA: 0x0090460C File Offset: 0x0090280C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			bool splitScreen;
			LuaObject.checkType(l, 2, out splitScreen);
			bool isBoss;
			LuaObject.checkType(l, 3, out isBoss);
			int myPlayerTeam;
			LuaObject.checkType(l, 4, out myPlayerTeam);
			combatUIController.StartCombat(splitScreen, isBoss, myPlayerTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD6F RID: 118127 RVA: 0x00904680 File Offset: 0x00902880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceUpdateChar(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.ForceUpdateChar();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD70 RID: 118128 RVA: 0x009046CC File Offset: 0x009028CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PreStopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.PreStopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD71 RID: 118129 RVA: 0x00904718 File Offset: 0x00902918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.StopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD72 RID: 118130 RVA: 0x00904764 File Offset: 0x00902964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int heroHp;
			LuaObject.checkType(l, 3, out heroHp);
			int heroHpMax;
			LuaObject.checkType(l, 4, out heroHpMax);
			int soldierHp;
			LuaObject.checkType(l, 5, out soldierHp);
			int soldierHpMax;
			LuaObject.checkType(l, 6, out soldierHpMax);
			combatUIController.SetHealthPoint(team, heroHp, heroHpMax, soldierHp, soldierHpMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD73 RID: 118131 RVA: 0x009047F0 File Offset: 0x009029F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDamage(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			bool isHero;
			LuaObject.checkType(l, 3, out isHero);
			int hp;
			LuaObject.checkType(l, 4, out hp);
			int hpMax;
			LuaObject.checkType(l, 5, out hpMax);
			int hpModify;
			LuaObject.checkType(l, 6, out hpModify);
			int totalDamage;
			LuaObject.checkType(l, 7, out totalDamage);
			int combatFrame;
			LuaObject.checkType(l, 8, out combatFrame);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 9, out damageNumberType);
			combatUIController.ShowDamage(team, isHero, hp, hpMax, hpModify, totalDamage, combatFrame, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD74 RID: 118132 RVA: 0x009048A0 File Offset: 0x00902AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCharImageInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 3, out charImageInfo);
			ConfigDataCharImageSkinResourceInfo skinResInfo;
			LuaObject.checkType<ConfigDataCharImageSkinResourceInfo>(l, 4, out skinResInfo);
			combatUIController.SetCharImageInfo(team, charImageInfo, skinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD75 RID: 118133 RVA: 0x00904914 File Offset: 0x00902B14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowCutsceneSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			combatUIController.ShowCutsceneSkill(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD76 RID: 118134 RVA: 0x0090496C File Offset: 0x00902B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCutscenePassiveSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 2, out sourceBuffState);
			combatUIController.ShowCutscenePassiveSkill(sourceBuffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD77 RID: 118135 RVA: 0x009049C4 File Offset: 0x00902BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			bool autoBattle;
			LuaObject.checkType(l, 2, out autoBattle);
			combatUIController.SetAutoBattle(autoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD78 RID: 118136 RVA: 0x00904A1C File Offset: 0x00902C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			bool arenaAutoBattle;
			LuaObject.checkType(l, 2, out arenaAutoBattle);
			combatUIController.SetArenaAutoBattle(arenaAutoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD79 RID: 118137 RVA: 0x00904A74 File Offset: 0x00902C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD7A RID: 118138 RVA: 0x00904AC8 File Offset: 0x00902CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetHPStates(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.m_luaExportHelper.ResetHPStates();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD7B RID: 118139 RVA: 0x00904B1C File Offset: 0x00902D1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TeamToSide(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			int i = combatUIController.m_luaExportHelper.TeamToSide(team);
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

	// Token: 0x0601CD7C RID: 118140 RVA: 0x00904B84 File Offset: 0x00902D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHPState(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			int side;
			LuaObject.checkType(l, 2, out side);
			float totalHpPercent;
			LuaObject.checkType(l, 3, out totalHpPercent);
			combatUIController.m_luaExportHelper.UpdateHPState(side, totalHpPercent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD7D RID: 118141 RVA: 0x00904BF0 File Offset: 0x00902DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideCutsceneSkill(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.m_luaExportHelper.HideCutsceneSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD7E RID: 118142 RVA: 0x00904C44 File Offset: 0x00902E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAutoOffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.m_luaExportHelper.OnAutoOffButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD7F RID: 118143 RVA: 0x00904C98 File Offset: 0x00902E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnArenaAutoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.m_luaExportHelper.OnArenaAutoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD80 RID: 118144 RVA: 0x00904CEC File Offset: 0x00902EEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			combatUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD81 RID: 118145 RVA: 0x00904D58 File Offset: 0x00902F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD82 RID: 118146 RVA: 0x00904DAC File Offset: 0x00902FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD83 RID: 118147 RVA: 0x00904E00 File Offset: 0x00903000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = combatUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CD84 RID: 118148 RVA: 0x00904EA8 File Offset: 0x009030A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			combatUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD85 RID: 118149 RVA: 0x00904EFC File Offset: 0x009030FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			combatUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD86 RID: 118150 RVA: 0x00904F68 File Offset: 0x00903168
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
				CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				combatUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CombatUIController combatUIController2 = (CombatUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				combatUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CD87 RID: 118151 RVA: 0x00905078 File Offset: 0x00903278
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD88 RID: 118152 RVA: 0x009050E4 File Offset: 0x009032E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD89 RID: 118153 RVA: 0x00905150 File Offset: 0x00903350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD8A RID: 118154 RVA: 0x009051BC File Offset: 0x009033BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD8B RID: 118155 RVA: 0x00905228 File Offset: 0x00903428
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
				CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				combatUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CombatUIController combatUIController2 = (CombatUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				combatUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CD8C RID: 118156 RVA: 0x00905338 File Offset: 0x00903538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			string s = combatUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CD8D RID: 118157 RVA: 0x00905394 File Offset: 0x00903594
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			combatUIController.m_luaExportHelper.__callDele_EventOnAutoBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD8E RID: 118158 RVA: 0x009053F0 File Offset: 0x009035F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			combatUIController.m_luaExportHelper.__clearDele_EventOnAutoBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD8F RID: 118159 RVA: 0x0090544C File Offset: 0x0090364C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					combatUIController.EventOnAutoBattle += value;
				}
				else if (num == 2)
				{
					combatUIController.EventOnAutoBattle -= value;
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

	// Token: 0x0601CD90 RID: 118160 RVA: 0x009054CC File Offset: 0x009036CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD91 RID: 118161 RVA: 0x00905524 File Offset: 0x00903724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			combatUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD92 RID: 118162 RVA: 0x00905580 File Offset: 0x00903780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD93 RID: 118163 RVA: 0x009055D8 File Offset: 0x009037D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			combatUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD94 RID: 118164 RVA: 0x00905634 File Offset: 0x00903834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_autoOffButton(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_autoOffButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD95 RID: 118165 RVA: 0x0090568C File Offset: 0x0090388C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoOffButton(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Button autoOffButton;
			LuaObject.checkType<Button>(l, 2, out autoOffButton);
			combatUIController.m_luaExportHelper.m_autoOffButton = autoOffButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD96 RID: 118166 RVA: 0x009056E8 File Offset: 0x009038E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaAutoButton(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_arenaAutoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD97 RID: 118167 RVA: 0x00905740 File Offset: 0x00903940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaAutoButton(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Button arenaAutoButton;
			LuaObject.checkType<Button>(l, 2, out arenaAutoButton);
			combatUIController.m_luaExportHelper.m_arenaAutoButton = arenaAutoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD98 RID: 118168 RVA: 0x0090579C File Offset: 0x0090399C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_cutsceneSkillUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD99 RID: 118169 RVA: 0x009057F4 File Offset: 0x009039F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController cutsceneSkillUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out cutsceneSkillUIStateController);
			combatUIController.m_luaExportHelper.m_cutsceneSkillUIStateController = cutsceneSkillUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD9A RID: 118170 RVA: 0x00905850 File Offset: 0x00903A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_cutsceneSkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD9B RID: 118171 RVA: 0x009058A8 File Offset: 0x00903AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Image cutsceneSkillIconImage;
			LuaObject.checkType<Image>(l, 2, out cutsceneSkillIconImage);
			combatUIController.m_luaExportHelper.m_cutsceneSkillIconImage = cutsceneSkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD9C RID: 118172 RVA: 0x00905904 File Offset: 0x00903B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cutsceneSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_cutsceneSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD9D RID: 118173 RVA: 0x0090595C File Offset: 0x00903B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cutsceneSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text cutsceneSkillNameText;
			LuaObject.checkType<Text>(l, 2, out cutsceneSkillNameText);
			combatUIController.m_luaExportHelper.m_cutsceneSkillNameText = cutsceneSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD9E RID: 118174 RVA: 0x009059B8 File Offset: 0x00903BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp0Image(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_heroHp0Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD9F RID: 118175 RVA: 0x00905A10 File Offset: 0x00903C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp0Image(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Image heroHp0Image;
			LuaObject.checkType<Image>(l, 2, out heroHp0Image);
			combatUIController.m_luaExportHelper.m_heroHp0Image = heroHp0Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA0 RID: 118176 RVA: 0x00905A6C File Offset: 0x00903C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp0Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_heroHp0Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA1 RID: 118177 RVA: 0x00905AC4 File Offset: 0x00903CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp0Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text heroHp0Text;
			LuaObject.checkType<Text>(l, 2, out heroHp0Text);
			combatUIController.m_luaExportHelper.m_heroHp0Text = heroHp0Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA2 RID: 118178 RVA: 0x00905B20 File Offset: 0x00903D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp0FxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_heroHp0FxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA3 RID: 118179 RVA: 0x00905B78 File Offset: 0x00903D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp0FxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			GameObject heroHp0FxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out heroHp0FxGameObeject);
			combatUIController.m_luaExportHelper.m_heroHp0FxGameObeject = heroHp0FxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA4 RID: 118180 RVA: 0x00905BD4 File Offset: 0x00903DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp1Image(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_heroHp1Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA5 RID: 118181 RVA: 0x00905C2C File Offset: 0x00903E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp1Image(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Image heroHp1Image;
			LuaObject.checkType<Image>(l, 2, out heroHp1Image);
			combatUIController.m_luaExportHelper.m_heroHp1Image = heroHp1Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA6 RID: 118182 RVA: 0x00905C88 File Offset: 0x00903E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp1Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_heroHp1Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA7 RID: 118183 RVA: 0x00905CE0 File Offset: 0x00903EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp1Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text heroHp1Text;
			LuaObject.checkType<Text>(l, 2, out heroHp1Text);
			combatUIController.m_luaExportHelper.m_heroHp1Text = heroHp1Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA8 RID: 118184 RVA: 0x00905D3C File Offset: 0x00903F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp1FxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_heroHp1FxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDA9 RID: 118185 RVA: 0x00905D94 File Offset: 0x00903F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp1FxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			GameObject heroHp1FxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out heroHp1FxGameObeject);
			combatUIController.m_luaExportHelper.m_heroHp1FxGameObeject = heroHp1FxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDAA RID: 118186 RVA: 0x00905DF0 File Offset: 0x00903FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp0Image(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_soldierHp0Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDAB RID: 118187 RVA: 0x00905E48 File Offset: 0x00904048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierHp0Image(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Image soldierHp0Image;
			LuaObject.checkType<Image>(l, 2, out soldierHp0Image);
			combatUIController.m_luaExportHelper.m_soldierHp0Image = soldierHp0Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDAC RID: 118188 RVA: 0x00905EA4 File Offset: 0x009040A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp0Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_soldierHp0Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDAD RID: 118189 RVA: 0x00905EFC File Offset: 0x009040FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp0Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text soldierHp0Text;
			LuaObject.checkType<Text>(l, 2, out soldierHp0Text);
			combatUIController.m_luaExportHelper.m_soldierHp0Text = soldierHp0Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDAE RID: 118190 RVA: 0x00905F58 File Offset: 0x00904158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp0FxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_soldierHp0FxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDAF RID: 118191 RVA: 0x00905FB0 File Offset: 0x009041B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp0FxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			GameObject soldierHp0FxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out soldierHp0FxGameObeject);
			combatUIController.m_luaExportHelper.m_soldierHp0FxGameObeject = soldierHp0FxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB0 RID: 118192 RVA: 0x0090600C File Offset: 0x0090420C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp1Image(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_soldierHp1Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB1 RID: 118193 RVA: 0x00906064 File Offset: 0x00904264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp1Image(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Image soldierHp1Image;
			LuaObject.checkType<Image>(l, 2, out soldierHp1Image);
			combatUIController.m_luaExportHelper.m_soldierHp1Image = soldierHp1Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB2 RID: 118194 RVA: 0x009060C0 File Offset: 0x009042C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp1Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_soldierHp1Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB3 RID: 118195 RVA: 0x00906118 File Offset: 0x00904318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp1Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text soldierHp1Text;
			LuaObject.checkType<Text>(l, 2, out soldierHp1Text);
			combatUIController.m_luaExportHelper.m_soldierHp1Text = soldierHp1Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB4 RID: 118196 RVA: 0x00906174 File Offset: 0x00904374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp1FxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_soldierHp1FxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB5 RID: 118197 RVA: 0x009061CC File Offset: 0x009043CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp1FxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			GameObject soldierHp1FxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out soldierHp1FxGameObeject);
			combatUIController.m_luaExportHelper.m_soldierHp1FxGameObeject = soldierHp1FxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB6 RID: 118198 RVA: 0x00906228 File Offset: 0x00904428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bossHpImage(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_bossHpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB7 RID: 118199 RVA: 0x00906280 File Offset: 0x00904480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bossHpImage(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Image bossHpImage;
			LuaObject.checkType<Image>(l, 2, out bossHpImage);
			combatUIController.m_luaExportHelper.m_bossHpImage = bossHpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB8 RID: 118200 RVA: 0x009062DC File Offset: 0x009044DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bossHpText(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_bossHpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDB9 RID: 118201 RVA: 0x00906334 File Offset: 0x00904534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bossHpText(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text bossHpText;
			LuaObject.checkType<Text>(l, 2, out bossHpText);
			combatUIController.m_luaExportHelper.m_bossHpText = bossHpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDBA RID: 118202 RVA: 0x00906390 File Offset: 0x00904590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bossHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_bossHpFxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDBB RID: 118203 RVA: 0x009063E8 File Offset: 0x009045E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bossHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			GameObject bossHpFxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out bossHpFxGameObeject);
			combatUIController.m_luaExportHelper.m_bossHpFxGameObeject = bossHpFxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDBC RID: 118204 RVA: 0x00906444 File Offset: 0x00904644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damage0UIStateController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_damage0UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDBD RID: 118205 RVA: 0x0090649C File Offset: 0x0090469C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damage0UIStateController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController damage0UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out damage0UIStateController);
			combatUIController.m_luaExportHelper.m_damage0UIStateController = damage0UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDBE RID: 118206 RVA: 0x009064F8 File Offset: 0x009046F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damage1UIStateController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_damage1UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDBF RID: 118207 RVA: 0x00906550 File Offset: 0x00904750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damage1UIStateController(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController damage1UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out damage1UIStateController);
			combatUIController.m_luaExportHelper.m_damage1UIStateController = damage1UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC0 RID: 118208 RVA: 0x009065AC File Offset: 0x009047AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damage0Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_damage0Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC1 RID: 118209 RVA: 0x00906604 File Offset: 0x00904804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damage0Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text damage0Text;
			LuaObject.checkType<Text>(l, 2, out damage0Text);
			combatUIController.m_luaExportHelper.m_damage0Text = damage0Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC2 RID: 118210 RVA: 0x00906660 File Offset: 0x00904860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damage0CriticalText(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_damage0CriticalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC3 RID: 118211 RVA: 0x009066B8 File Offset: 0x009048B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damage0CriticalText(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text damage0CriticalText;
			LuaObject.checkType<Text>(l, 2, out damage0CriticalText);
			combatUIController.m_luaExportHelper.m_damage0CriticalText = damage0CriticalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC4 RID: 118212 RVA: 0x00906714 File Offset: 0x00904914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damage1Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_damage1Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC5 RID: 118213 RVA: 0x0090676C File Offset: 0x0090496C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_damage1Text(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text damage1Text;
			LuaObject.checkType<Text>(l, 2, out damage1Text);
			combatUIController.m_luaExportHelper.m_damage1Text = damage1Text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC6 RID: 118214 RVA: 0x009067C8 File Offset: 0x009049C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_damage1CriticalText(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_damage1CriticalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC7 RID: 118215 RVA: 0x00906820 File Offset: 0x00904A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damage1CriticalText(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			Text damage1CriticalText;
			LuaObject.checkType<Text>(l, 2, out damage1CriticalText);
			combatUIController.m_luaExportHelper.m_damage1CriticalText = damage1CriticalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC8 RID: 118216 RVA: 0x0090687C File Offset: 0x00904A7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_char0GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDC9 RID: 118217 RVA: 0x009068D4 File Offset: 0x00904AD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			GameObject char0GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char0GameObject);
			combatUIController.m_luaExportHelper.m_char0GameObject = char0GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDCA RID: 118218 RVA: 0x00906930 File Offset: 0x00904B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_char1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDCB RID: 118219 RVA: 0x00906988 File Offset: 0x00904B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			GameObject char1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char1GameObject);
			combatUIController.m_luaExportHelper.m_char1GameObject = char1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDCC RID: 118220 RVA: 0x009069E4 File Offset: 0x00904BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boundaryGameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_boundaryGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDCD RID: 118221 RVA: 0x00906A3C File Offset: 0x00904C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boundaryGameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			GameObject boundaryGameObject;
			LuaObject.checkType<GameObject>(l, 2, out boundaryGameObject);
			combatUIController.m_luaExportHelper.m_boundaryGameObject = boundaryGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDCE RID: 118222 RVA: 0x00906A98 File Offset: 0x00904C98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hpStates(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_hpStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDCF RID: 118223 RVA: 0x00906AF0 File Offset: 0x00904CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hpStates(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			CombatUIController.HPState[] hpStates;
			LuaObject.checkArray<CombatUIController.HPState>(l, 2, out hpStates);
			combatUIController.m_luaExportHelper.m_hpStates = hpStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDD0 RID: 118224 RVA: 0x00906B4C File Offset: 0x00904D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_fxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDD1 RID: 118225 RVA: 0x00906BA4 File Offset: 0x00904DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			FxPlayer fxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out fxPlayer);
			combatUIController.m_luaExportHelper.m_fxPlayer = fxPlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDD2 RID: 118226 RVA: 0x00906C00 File Offset: 0x00904E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isBoss(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_isBoss);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDD3 RID: 118227 RVA: 0x00906C58 File Offset: 0x00904E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isBoss(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			bool isBoss;
			LuaObject.checkType(l, 2, out isBoss);
			combatUIController.m_luaExportHelper.m_isBoss = isBoss;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDD4 RID: 118228 RVA: 0x00906CB4 File Offset: 0x00904EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myPlayerTeam(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatUIController.m_luaExportHelper.m_myPlayerTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDD5 RID: 118229 RVA: 0x00906D0C File Offset: 0x00904F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myPlayerTeam(IntPtr l)
	{
		int result;
		try
		{
			CombatUIController combatUIController = (CombatUIController)LuaObject.checkSelf(l);
			int myPlayerTeam;
			LuaObject.checkType(l, 2, out myPlayerTeam);
			combatUIController.m_luaExportHelper.m_myPlayerTeam = myPlayerTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDD6 RID: 118230 RVA: 0x00906D68 File Offset: 0x00904F68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CombatUIController");
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.StartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.ForceUpdateChar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.PreStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.StopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.SetHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.ShowDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.SetCharImageInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.ShowCutsceneSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.ShowCutscenePassiveSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.SetAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.SetArenaAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.ResetHPStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.TeamToSide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.UpdateHPState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.HideCutsceneSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.OnAutoOffButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.OnArenaAutoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__callDele_EventOnAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.__clearDele_EventOnAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache21);
		string name = "EventOnAutoBattle";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_EventOnAutoBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache22, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache24, true);
		string name3 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_marginTransform);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache26, true);
		string name4 = "m_autoOffButton";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_autoOffButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_autoOffButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache28, true);
		string name5 = "m_arenaAutoButton";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_arenaAutoButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_arenaAutoButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2A, true);
		string name6 = "m_cutsceneSkillUIStateController";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_cutsceneSkillUIStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_cutsceneSkillUIStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2C, true);
		string name7 = "m_cutsceneSkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_cutsceneSkillIconImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_cutsceneSkillIconImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2E, true);
		string name8 = "m_cutsceneSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_cutsceneSkillNameText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_cutsceneSkillNameText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache30, true);
		string name9 = "m_heroHp0Image";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_heroHp0Image);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_heroHp0Image);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache32, true);
		string name10 = "m_heroHp0Text";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_heroHp0Text);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_heroHp0Text);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache34, true);
		string name11 = "m_heroHp0FxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_heroHp0FxGameObeject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_heroHp0FxGameObeject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache36, true);
		string name12 = "m_heroHp1Image";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_heroHp1Image);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_heroHp1Image);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache38, true);
		string name13 = "m_heroHp1Text";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_heroHp1Text);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_heroHp1Text);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3A, true);
		string name14 = "m_heroHp1FxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_heroHp1FxGameObeject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_heroHp1FxGameObeject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3C, true);
		string name15 = "m_soldierHp0Image";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_soldierHp0Image);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_soldierHp0Image);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3E, true);
		string name16 = "m_soldierHp0Text";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_soldierHp0Text);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_soldierHp0Text);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache40, true);
		string name17 = "m_soldierHp0FxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_soldierHp0FxGameObeject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_soldierHp0FxGameObeject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache42, true);
		string name18 = "m_soldierHp1Image";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_soldierHp1Image);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_soldierHp1Image);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache44, true);
		string name19 = "m_soldierHp1Text";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_soldierHp1Text);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_soldierHp1Text);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache46, true);
		string name20 = "m_soldierHp1FxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_soldierHp1FxGameObeject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_soldierHp1FxGameObeject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache48, true);
		string name21 = "m_bossHpImage";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_bossHpImage);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_bossHpImage);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4A, true);
		string name22 = "m_bossHpText";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_bossHpText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_bossHpText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4C, true);
		string name23 = "m_bossHpFxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_bossHpFxGameObeject);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_bossHpFxGameObeject);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4E, true);
		string name24 = "m_damage0UIStateController";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_damage0UIStateController);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_damage0UIStateController);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache50, true);
		string name25 = "m_damage1UIStateController";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_damage1UIStateController);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_damage1UIStateController);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache52, true);
		string name26 = "m_damage0Text";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_damage0Text);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_damage0Text);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache54, true);
		string name27 = "m_damage0CriticalText";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_damage0CriticalText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_damage0CriticalText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache56, true);
		string name28 = "m_damage1Text";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_damage1Text);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_damage1Text);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache58, true);
		string name29 = "m_damage1CriticalText";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_damage1CriticalText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_damage1CriticalText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5A, true);
		string name30 = "m_char0GameObject";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_char0GameObject);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_char0GameObject);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5C, true);
		string name31 = "m_char1GameObject";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_char1GameObject);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_char1GameObject);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5E, true);
		string name32 = "m_boundaryGameObject";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_boundaryGameObject);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_boundaryGameObject);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache60, true);
		string name33 = "m_hpStates";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_hpStates);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_hpStates);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache62, true);
		string name34 = "m_fxPlayer";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_fxPlayer);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_fxPlayer);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache64, true);
		string name35 = "m_isBoss";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_isBoss);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_isBoss);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache66, true);
		string name36 = "m_myPlayerTeam";
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.get_m_myPlayerTeam);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatUIController.set_m_myPlayerTeam);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_CombatUIController.<>f__mg$cache68, true);
		LuaObject.createTypeMetatable(l, null, typeof(CombatUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012F4D RID: 77645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012F4E RID: 77646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012F4F RID: 77647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012F50 RID: 77648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012F51 RID: 77649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012F52 RID: 77650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012F53 RID: 77651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012F54 RID: 77652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012F55 RID: 77653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012F56 RID: 77654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012F57 RID: 77655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012F58 RID: 77656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012F59 RID: 77657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012F5A RID: 77658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012F5B RID: 77659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012F5C RID: 77660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012F5D RID: 77661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012F5E RID: 77662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012F5F RID: 77663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012F60 RID: 77664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012F61 RID: 77665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012F62 RID: 77666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012F63 RID: 77667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012F64 RID: 77668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012F65 RID: 77669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012F66 RID: 77670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012F67 RID: 77671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012F68 RID: 77672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012F69 RID: 77673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012F6A RID: 77674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012F6B RID: 77675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012F6C RID: 77676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012F6D RID: 77677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012F6E RID: 77678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012F6F RID: 77679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012F70 RID: 77680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012F71 RID: 77681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012F72 RID: 77682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012F73 RID: 77683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012F74 RID: 77684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012F75 RID: 77685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012F76 RID: 77686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012F77 RID: 77687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012F78 RID: 77688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012F79 RID: 77689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012F7A RID: 77690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012F7B RID: 77691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012F7C RID: 77692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012F7D RID: 77693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012F7E RID: 77694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012F7F RID: 77695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012F80 RID: 77696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012F81 RID: 77697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012F82 RID: 77698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012F83 RID: 77699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012F84 RID: 77700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012F85 RID: 77701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012F86 RID: 77702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012F87 RID: 77703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012F88 RID: 77704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012F89 RID: 77705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012F8A RID: 77706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012F8B RID: 77707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012F8C RID: 77708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012F8D RID: 77709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012F8E RID: 77710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012F8F RID: 77711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012F90 RID: 77712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012F91 RID: 77713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012F92 RID: 77714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04012F93 RID: 77715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04012F94 RID: 77716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04012F95 RID: 77717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04012F96 RID: 77718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04012F97 RID: 77719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04012F98 RID: 77720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012F99 RID: 77721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012F9A RID: 77722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012F9B RID: 77723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04012F9C RID: 77724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04012F9D RID: 77725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04012F9E RID: 77726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04012F9F RID: 77727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04012FA0 RID: 77728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04012FA1 RID: 77729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04012FA2 RID: 77730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04012FA3 RID: 77731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04012FA4 RID: 77732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04012FA5 RID: 77733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04012FA6 RID: 77734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04012FA7 RID: 77735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04012FA8 RID: 77736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04012FA9 RID: 77737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04012FAA RID: 77738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04012FAB RID: 77739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04012FAC RID: 77740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04012FAD RID: 77741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04012FAE RID: 77742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04012FAF RID: 77743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04012FB0 RID: 77744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04012FB1 RID: 77745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04012FB2 RID: 77746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04012FB3 RID: 77747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04012FB4 RID: 77748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04012FB5 RID: 77749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;
}
