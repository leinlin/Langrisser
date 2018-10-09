using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001400 RID: 5120
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CombatSceneUIController : LuaObject
{
	// Token: 0x0601CD1A RID: 118042 RVA: 0x00901B74 File Offset: 0x008FFD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.Initialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD1B RID: 118043 RVA: 0x00901BC0 File Offset: 0x008FFDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo terrain;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 2, out terrain);
			ConfigDataTerrainInfo terrain2;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrain2);
			bool splitScreen;
			LuaObject.checkType(l, 4, out splitScreen);
			int attackerTeam;
			LuaObject.checkType(l, 5, out attackerTeam);
			int myPlayerTeam;
			LuaObject.checkType(l, 6, out myPlayerTeam);
			combatSceneUIController.StartCombat(terrain, terrain2, splitScreen, attackerTeam, myPlayerTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD1C RID: 118044 RVA: 0x00901C4C File Offset: 0x008FFE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PreStopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.PreStopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD1D RID: 118045 RVA: 0x00901C98 File Offset: 0x008FFE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.StopCombat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD1E RID: 118046 RVA: 0x00901CE4 File Offset: 0x008FFEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillFadeIn(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			float alpha;
			LuaObject.checkType(l, 3, out alpha);
			combatSceneUIController.SkillFadeIn(time, alpha);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD1F RID: 118047 RVA: 0x00901D48 File Offset: 0x008FFF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillFadeOut(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			combatSceneUIController.SkillFadeOut(time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD20 RID: 118048 RVA: 0x00901DA0 File Offset: 0x008FFFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorHit(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			CombatActor attacker;
			LuaObject.checkType<CombatActor>(l, 3, out attacker);
			ConfigDataSkillInfo skill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skill);
			int hpModify;
			LuaObject.checkType(l, 5, out hpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 6, out damageNumberType);
			combatSceneUIController.OnActorHit(a, attacker, skill, hpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD21 RID: 118049 RVA: 0x00901E2C File Offset: 0x0090002C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD22 RID: 118050 RVA: 0x00901E80 File Offset: 0x00900080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD23 RID: 118051 RVA: 0x00901ED4 File Offset: 0x009000D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideFade(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.m_luaExportHelper.HideFade();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD24 RID: 118052 RVA: 0x00901F28 File Offset: 0x00900128
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetFade(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			float fade;
			LuaObject.checkType(l, 2, out fade);
			combatSceneUIController.m_luaExportHelper.SetFade(fade);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD25 RID: 118053 RVA: 0x00901F84 File Offset: 0x00900184
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateFade(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			combatSceneUIController.m_luaExportHelper.UpdateFade(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD26 RID: 118054 RVA: 0x00901FE0 File Offset: 0x009001E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBackgroundTexture(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			combatSceneUIController.m_luaExportHelper.SetBackgroundTexture(go, terrainInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD27 RID: 118055 RVA: 0x0090204C File Offset: 0x0090024C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActorGraphicPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			Vector3 o;
			bool actorGraphicPosition = combatSceneUIController.m_luaExportHelper.GetActorGraphicPosition(a, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actorGraphicPosition);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD28 RID: 118056 RVA: 0x009020C0 File Offset: 0x009002C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			combatSceneUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD29 RID: 118057 RVA: 0x0090212C File Offset: 0x0090032C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD2A RID: 118058 RVA: 0x00902180 File Offset: 0x00900380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD2B RID: 118059 RVA: 0x009021D4 File Offset: 0x009003D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = combatSceneUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CD2C RID: 118060 RVA: 0x0090227C File Offset: 0x0090047C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			combatSceneUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD2D RID: 118061 RVA: 0x009022D0 File Offset: 0x009004D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			combatSceneUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD2E RID: 118062 RVA: 0x0090233C File Offset: 0x0090053C
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
				CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				combatSceneUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CombatSceneUIController combatSceneUIController2 = (CombatSceneUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				combatSceneUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CD2F RID: 118063 RVA: 0x0090244C File Offset: 0x0090064C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatSceneUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD30 RID: 118064 RVA: 0x009024B8 File Offset: 0x009006B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD31 RID: 118065 RVA: 0x00902524 File Offset: 0x00900724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD32 RID: 118066 RVA: 0x00902590 File Offset: 0x00900790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD33 RID: 118067 RVA: 0x009025FC File Offset: 0x009007FC
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
				CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				combatSceneUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CombatSceneUIController combatSceneUIController2 = (CombatSceneUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				combatSceneUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CD34 RID: 118068 RVA: 0x0090270C File Offset: 0x0090090C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			string s = combatSceneUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CD35 RID: 118069 RVA: 0x00902768 File Offset: 0x00900968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD36 RID: 118070 RVA: 0x009027C0 File Offset: 0x009009C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			combatSceneUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD37 RID: 118071 RVA: 0x0090281C File Offset: 0x00900A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumber0Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumber0Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD38 RID: 118072 RVA: 0x00902874 File Offset: 0x00900A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumber0Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumber0Prefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumber0Prefab);
			combatSceneUIController.m_luaExportHelper.m_damageNumber0Prefab = damageNumber0Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD39 RID: 118073 RVA: 0x009028D0 File Offset: 0x00900AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumber1Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumber1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD3A RID: 118074 RVA: 0x00902928 File Offset: 0x00900B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumber1Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumber1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumber1Prefab);
			combatSceneUIController.m_luaExportHelper.m_damageNumber1Prefab = damageNumber1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD3B RID: 118075 RVA: 0x00902984 File Offset: 0x00900B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberWeak0Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberWeak0Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD3C RID: 118076 RVA: 0x009029DC File Offset: 0x00900BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberWeak0Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberWeak0Prefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberWeak0Prefab);
			combatSceneUIController.m_luaExportHelper.m_damageNumberWeak0Prefab = damageNumberWeak0Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD3D RID: 118077 RVA: 0x00902A38 File Offset: 0x00900C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberWeak1Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberWeak1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD3E RID: 118078 RVA: 0x00902A90 File Offset: 0x00900C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberWeak1Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberWeak1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberWeak1Prefab);
			combatSceneUIController.m_luaExportHelper.m_damageNumberWeak1Prefab = damageNumberWeak1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD3F RID: 118079 RVA: 0x00902AEC File Offset: 0x00900CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberStrong0Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberStrong0Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD40 RID: 118080 RVA: 0x00902B44 File Offset: 0x00900D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberStrong0Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberStrong0Prefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberStrong0Prefab);
			combatSceneUIController.m_luaExportHelper.m_damageNumberStrong0Prefab = damageNumberStrong0Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD41 RID: 118081 RVA: 0x00902BA0 File Offset: 0x00900DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberStrong1Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberStrong1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD42 RID: 118082 RVA: 0x00902BF8 File Offset: 0x00900DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberStrong1Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberStrong1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberStrong1Prefab);
			combatSceneUIController.m_luaExportHelper.m_damageNumberStrong1Prefab = damageNumberStrong1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD43 RID: 118083 RVA: 0x00902C54 File Offset: 0x00900E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberCritical0Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberCritical0Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD44 RID: 118084 RVA: 0x00902CAC File Offset: 0x00900EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberCritical0Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberCritical0Prefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberCritical0Prefab);
			combatSceneUIController.m_luaExportHelper.m_damageNumberCritical0Prefab = damageNumberCritical0Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD45 RID: 118085 RVA: 0x00902D08 File Offset: 0x00900F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberCritical1Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberCritical1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD46 RID: 118086 RVA: 0x00902D60 File Offset: 0x00900F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberCritical1Prefab(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject damageNumberCritical1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out damageNumberCritical1Prefab);
			combatSceneUIController.m_luaExportHelper.m_damageNumberCritical1Prefab = damageNumberCritical1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD47 RID: 118087 RVA: 0x00902DBC File Offset: 0x00900FBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_damageNumber0Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumber0Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD48 RID: 118088 RVA: 0x00902E14 File Offset: 0x00901014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumber0Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumber0Pool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumber0Pool);
			combatSceneUIController.m_luaExportHelper.m_damageNumber0Pool = damageNumber0Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD49 RID: 118089 RVA: 0x00902E70 File Offset: 0x00901070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_damageNumber1Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumber1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD4A RID: 118090 RVA: 0x00902EC8 File Offset: 0x009010C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumber1Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumber1Pool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumber1Pool);
			combatSceneUIController.m_luaExportHelper.m_damageNumber1Pool = damageNumber1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD4B RID: 118091 RVA: 0x00902F24 File Offset: 0x00901124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberWeak0Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberWeak0Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD4C RID: 118092 RVA: 0x00902F7C File Offset: 0x0090117C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberWeak0Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberWeak0Pool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberWeak0Pool);
			combatSceneUIController.m_luaExportHelper.m_damageNumberWeak0Pool = damageNumberWeak0Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD4D RID: 118093 RVA: 0x00902FD8 File Offset: 0x009011D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberWeak1Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberWeak1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD4E RID: 118094 RVA: 0x00903030 File Offset: 0x00901230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_damageNumberWeak1Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberWeak1Pool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberWeak1Pool);
			combatSceneUIController.m_luaExportHelper.m_damageNumberWeak1Pool = damageNumberWeak1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD4F RID: 118095 RVA: 0x0090308C File Offset: 0x0090128C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_damageNumberStrong0Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberStrong0Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD50 RID: 118096 RVA: 0x009030E4 File Offset: 0x009012E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberStrong0Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberStrong0Pool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberStrong0Pool);
			combatSceneUIController.m_luaExportHelper.m_damageNumberStrong0Pool = damageNumberStrong0Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD51 RID: 118097 RVA: 0x00903140 File Offset: 0x00901340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_damageNumberStrong1Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberStrong1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD52 RID: 118098 RVA: 0x00903198 File Offset: 0x00901398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_damageNumberStrong1Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberStrong1Pool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberStrong1Pool);
			combatSceneUIController.m_luaExportHelper.m_damageNumberStrong1Pool = damageNumberStrong1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD53 RID: 118099 RVA: 0x009031F4 File Offset: 0x009013F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberCritical0Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberCritical0Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD54 RID: 118100 RVA: 0x0090324C File Offset: 0x0090144C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_damageNumberCritical0Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberCritical0Pool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberCritical0Pool);
			combatSceneUIController.m_luaExportHelper.m_damageNumberCritical0Pool = damageNumberCritical0Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD55 RID: 118101 RVA: 0x009032A8 File Offset: 0x009014A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_damageNumberCritical1Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_damageNumberCritical1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD56 RID: 118102 RVA: 0x00903300 File Offset: 0x00901500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberCritical1Pool(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObjectPool<DamageNumber> damageNumberCritical1Pool;
			LuaObject.checkType<GameObjectPool<DamageNumber>>(l, 2, out damageNumberCritical1Pool);
			combatSceneUIController.m_luaExportHelper.m_damageNumberCritical1Pool = damageNumberCritical1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD57 RID: 118103 RVA: 0x0090335C File Offset: 0x0090155C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_background0GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_background0GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD58 RID: 118104 RVA: 0x009033B4 File Offset: 0x009015B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_background0GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject background0GameObject;
			LuaObject.checkType<GameObject>(l, 2, out background0GameObject);
			combatSceneUIController.m_luaExportHelper.m_background0GameObject = background0GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD59 RID: 118105 RVA: 0x00903410 File Offset: 0x00901610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_background1GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_background1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD5A RID: 118106 RVA: 0x00903468 File Offset: 0x00901668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_background1GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject background1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out background1GameObject);
			combatSceneUIController.m_luaExportHelper.m_background1GameObject = background1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD5B RID: 118107 RVA: 0x009034C4 File Offset: 0x009016C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_background2GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_background2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD5C RID: 118108 RVA: 0x0090351C File Offset: 0x0090171C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_background2GameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject background2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out background2GameObject);
			combatSceneUIController.m_luaExportHelper.m_background2GameObject = background2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD5D RID: 118109 RVA: 0x00903578 File Offset: 0x00901778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeGameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_fadeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD5E RID: 118110 RVA: 0x009035D0 File Offset: 0x009017D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fadeGameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			GameObject fadeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out fadeGameObject);
			combatSceneUIController.m_luaExportHelper.m_fadeGameObject = fadeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD5F RID: 118111 RVA: 0x0090362C File Offset: 0x0090182C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isFadeIn(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_isFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD60 RID: 118112 RVA: 0x00903684 File Offset: 0x00901884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isFadeIn(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			bool isFadeIn;
			LuaObject.checkType(l, 2, out isFadeIn);
			combatSceneUIController.m_luaExportHelper.m_isFadeIn = isFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD61 RID: 118113 RVA: 0x009036E0 File Offset: 0x009018E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeCurTime(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_fadeCurTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD62 RID: 118114 RVA: 0x00903738 File Offset: 0x00901938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fadeCurTime(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			float fadeCurTime;
			LuaObject.checkType(l, 2, out fadeCurTime);
			combatSceneUIController.m_luaExportHelper.m_fadeCurTime = fadeCurTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD63 RID: 118115 RVA: 0x00903794 File Offset: 0x00901994
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_fadeDuration(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_fadeDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD64 RID: 118116 RVA: 0x009037EC File Offset: 0x009019EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeDuration(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			float fadeDuration;
			LuaObject.checkType(l, 2, out fadeDuration);
			combatSceneUIController.m_luaExportHelper.m_fadeDuration = fadeDuration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD65 RID: 118117 RVA: 0x00903848 File Offset: 0x00901A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeMaterial(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_fadeMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD66 RID: 118118 RVA: 0x009038A0 File Offset: 0x00901AA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fadeMaterial(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			Material fadeMaterial;
			LuaObject.checkType<Material>(l, 2, out fadeMaterial);
			combatSceneUIController.m_luaExportHelper.m_fadeMaterial = fadeMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD67 RID: 118119 RVA: 0x009038FC File Offset: 0x00901AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeColor(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_fadeColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD68 RID: 118120 RVA: 0x00903954 File Offset: 0x00901B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeColor(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			Color fadeColor;
			LuaObject.checkType(l, 2, out fadeColor);
			combatSceneUIController.m_luaExportHelper.m_fadeColor = fadeColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD69 RID: 118121 RVA: 0x009039B0 File Offset: 0x00901BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_myPlayerTeam(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSceneUIController.m_luaExportHelper.m_myPlayerTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD6A RID: 118122 RVA: 0x00903A08 File Offset: 0x00901C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_myPlayerTeam(IntPtr l)
	{
		int result;
		try
		{
			CombatSceneUIController combatSceneUIController = (CombatSceneUIController)LuaObject.checkSelf(l);
			int myPlayerTeam;
			LuaObject.checkType(l, 2, out myPlayerTeam);
			combatSceneUIController.m_luaExportHelper.m_myPlayerTeam = myPlayerTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD6B RID: 118123 RVA: 0x00903A64 File Offset: 0x00901C64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CombatSceneUIController");
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.StartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.PreStopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.StopCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.SkillFadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.SkillFadeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.OnActorHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.HideFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.SetFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.UpdateFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.SetBackgroundTexture);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.GetActorGraphicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1A);
		string name = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1C, true);
		string name2 = "m_damageNumber0Prefab";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumber0Prefab);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumber0Prefab);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1E, true);
		string name3 = "m_damageNumber1Prefab";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumber1Prefab);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumber1Prefab);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache20, true);
		string name4 = "m_damageNumberWeak0Prefab";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberWeak0Prefab);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberWeak0Prefab);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache22, true);
		string name5 = "m_damageNumberWeak1Prefab";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberWeak1Prefab);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberWeak1Prefab);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache24, true);
		string name6 = "m_damageNumberStrong0Prefab";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberStrong0Prefab);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberStrong0Prefab);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache26, true);
		string name7 = "m_damageNumberStrong1Prefab";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberStrong1Prefab);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberStrong1Prefab);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache28, true);
		string name8 = "m_damageNumberCritical0Prefab";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberCritical0Prefab);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberCritical0Prefab);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2A, true);
		string name9 = "m_damageNumberCritical1Prefab";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberCritical1Prefab);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberCritical1Prefab);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2C, true);
		string name10 = "m_damageNumber0Pool";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumber0Pool);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumber0Pool);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2E, true);
		string name11 = "m_damageNumber1Pool";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumber1Pool);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumber1Pool);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache30, true);
		string name12 = "m_damageNumberWeak0Pool";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberWeak0Pool);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberWeak0Pool);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache32, true);
		string name13 = "m_damageNumberWeak1Pool";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberWeak1Pool);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberWeak1Pool);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache34, true);
		string name14 = "m_damageNumberStrong0Pool";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberStrong0Pool);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberStrong0Pool);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache36, true);
		string name15 = "m_damageNumberStrong1Pool";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberStrong1Pool);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberStrong1Pool);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache38, true);
		string name16 = "m_damageNumberCritical0Pool";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberCritical0Pool);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberCritical0Pool);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3A, true);
		string name17 = "m_damageNumberCritical1Pool";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_damageNumberCritical1Pool);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_damageNumberCritical1Pool);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3C, true);
		string name18 = "m_background0GameObject";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_background0GameObject);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_background0GameObject);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3E, true);
		string name19 = "m_background1GameObject";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_background1GameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_background1GameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache40, true);
		string name20 = "m_background2GameObject";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_background2GameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_background2GameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache42, true);
		string name21 = "m_fadeGameObject";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_fadeGameObject);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_fadeGameObject);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache44, true);
		string name22 = "m_isFadeIn";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_isFadeIn);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_isFadeIn);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache46, true);
		string name23 = "m_fadeCurTime";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_fadeCurTime);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_fadeCurTime);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache48, true);
		string name24 = "m_fadeDuration";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_fadeDuration);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_fadeDuration);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4A, true);
		string name25 = "m_fadeMaterial";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_fadeMaterial);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_fadeMaterial);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4C, true);
		string name26 = "m_fadeColor";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_fadeColor);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_fadeColor);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4E, true);
		string name27 = "m_myPlayerTeam";
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.get_m_myPlayerTeam);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.set_m_myPlayerTeam);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_CombatSceneUIController.<>f__mg$cache50, true);
		LuaObject.createTypeMetatable(l, null, typeof(CombatSceneUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012EFC RID: 77564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012EFD RID: 77565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012EFE RID: 77566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012EFF RID: 77567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012F00 RID: 77568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012F01 RID: 77569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012F02 RID: 77570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012F03 RID: 77571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012F04 RID: 77572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012F05 RID: 77573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012F06 RID: 77574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012F07 RID: 77575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012F08 RID: 77576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012F09 RID: 77577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012F0A RID: 77578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012F0B RID: 77579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012F0C RID: 77580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012F0D RID: 77581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012F0E RID: 77582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012F0F RID: 77583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012F10 RID: 77584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012F11 RID: 77585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012F12 RID: 77586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012F13 RID: 77587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012F14 RID: 77588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012F15 RID: 77589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012F16 RID: 77590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012F17 RID: 77591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012F18 RID: 77592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012F19 RID: 77593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012F1A RID: 77594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012F1B RID: 77595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012F1C RID: 77596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012F1D RID: 77597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012F1E RID: 77598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012F1F RID: 77599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012F20 RID: 77600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012F21 RID: 77601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012F22 RID: 77602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012F23 RID: 77603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012F24 RID: 77604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012F25 RID: 77605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012F26 RID: 77606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012F27 RID: 77607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012F28 RID: 77608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012F29 RID: 77609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012F2A RID: 77610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012F2B RID: 77611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012F2C RID: 77612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012F2D RID: 77613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012F2E RID: 77614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012F2F RID: 77615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012F30 RID: 77616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012F31 RID: 77617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012F32 RID: 77618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012F33 RID: 77619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012F34 RID: 77620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012F35 RID: 77621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012F36 RID: 77622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012F37 RID: 77623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012F38 RID: 77624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012F39 RID: 77625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012F3A RID: 77626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012F3B RID: 77627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012F3C RID: 77628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012F3D RID: 77629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012F3E RID: 77630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012F3F RID: 77631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012F40 RID: 77632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012F41 RID: 77633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04012F42 RID: 77634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04012F43 RID: 77635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04012F44 RID: 77636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04012F45 RID: 77637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04012F46 RID: 77638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04012F47 RID: 77639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012F48 RID: 77640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012F49 RID: 77641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012F4A RID: 77642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04012F4B RID: 77643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04012F4C RID: 77644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;
}
