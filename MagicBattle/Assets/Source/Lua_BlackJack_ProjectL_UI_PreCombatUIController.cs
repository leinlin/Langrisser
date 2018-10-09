using System;
using System.Collections;
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

// Token: 0x02001539 RID: 5433
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PreCombatUIController : LuaObject
{
	// Token: 0x06020642 RID: 132674 RVA: 0x00AC87E4 File Offset: 0x00AC69E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			FxPlayer fxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out fxPlayer);
			preCombatUIController.Initialize(fxPlayer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020643 RID: 132675 RVA: 0x00AC883C File Offset: 0x00AC6A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020644 RID: 132676 RVA: 0x00AC8888 File Offset: 0x00AC6A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			bool b = preCombatUIController.IsOpened();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020645 RID: 132677 RVA: 0x00AC88DC File Offset: 0x00AC6ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFastCombat(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			bool b = preCombatUIController.IsFastCombat();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020646 RID: 132678 RVA: 0x00AC8930 File Offset: 0x00AC6B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleActorInfo(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleActor a2;
			LuaObject.checkType<BattleActor>(l, 3, out a2);
			ConfigDataTerrainInfo terrain;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 4, out terrain);
			ConfigDataTerrainInfo terrain2;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 5, out terrain2);
			bool isMagicAttack;
			LuaObject.checkType(l, 6, out isMagicAttack);
			bool isMagicAttack2;
			LuaObject.checkType(l, 7, out isMagicAttack2);
			int armyRelationValue;
			LuaObject.checkType(l, 8, out armyRelationValue);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 9, out attackerSkillInfo);
			int attackerSide;
			LuaObject.checkType(l, 10, out attackerSide);
			preCombatUIController.SetBattleActorInfo(a, a2, terrain, terrain2, isMagicAttack, isMagicAttack2, armyRelationValue, attackerSkillInfo, attackerSide);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020647 RID: 132679 RVA: 0x00AC89EC File Offset: 0x00AC6BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenAndShowFastCombat(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			FastCombatActorInfo a;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out a);
			FastCombatActorInfo a2;
			LuaObject.checkType<FastCombatActorInfo>(l, 3, out a2);
			preCombatUIController.OpenAndShowFastCombat(a, a2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020648 RID: 132680 RVA: 0x00AC8A50 File Offset: 0x00AC6C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFastCombat(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			FastCombatActorInfo a;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out a);
			FastCombatActorInfo a2;
			LuaObject.checkType<FastCombatActorInfo>(l, 3, out a2);
			preCombatUIController.ShowFastCombat(a, a2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020649 RID: 132681 RVA: 0x00AC8AB4 File Offset: 0x00AC6CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActorPassiveSkill(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			int side;
			LuaObject.checkType(l, 2, out side);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 3, out sourceBuffState);
			preCombatUIController.OnActorPassiveSkill(side, sourceBuffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602064A RID: 132682 RVA: 0x00AC8B18 File Offset: 0x00AC6D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602064B RID: 132683 RVA: 0x00AC8B64 File Offset: 0x00AC6D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602064C RID: 132684 RVA: 0x00AC8BB8 File Offset: 0x00AC6DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602064D RID: 132685 RVA: 0x00AC8C0C File Offset: 0x00AC6E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.Show();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602064E RID: 132686 RVA: 0x00AC8C60 File Offset: 0x00AC6E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOkCancelButton(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			preCombatUIController.m_luaExportHelper.ShowOkCancelButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602064F RID: 132687 RVA: 0x00AC8CBC File Offset: 0x00AC6EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroHp(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			int side;
			LuaObject.checkType(l, 2, out side);
			int hp;
			LuaObject.checkType(l, 3, out hp);
			int hpMax;
			LuaObject.checkType(l, 4, out hpMax);
			preCombatUIController.m_luaExportHelper.SetHeroHp(side, hp, hpMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020650 RID: 132688 RVA: 0x00AC8D34 File Offset: 0x00AC6F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierHp(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			int side;
			LuaObject.checkType(l, 2, out side);
			int hp;
			LuaObject.checkType(l, 3, out hp);
			int hpMax;
			LuaObject.checkType(l, 4, out hpMax);
			preCombatUIController.m_luaExportHelper.SetSoldierHp(side, hp, hpMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020651 RID: 132689 RVA: 0x00AC8DAC File Offset: 0x00AC6FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_OpenAndFastCombat(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			FastCombatActorInfo a;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out a);
			FastCombatActorInfo a2;
			LuaObject.checkType<FastCombatActorInfo>(l, 3, out a2);
			IEnumerator o = preCombatUIController.m_luaExportHelper.Co_OpenAndFastCombat(a, a2);
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

	// Token: 0x06020652 RID: 132690 RVA: 0x00AC8E20 File Offset: 0x00AC7020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_FastCombat(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			FastCombatActorInfo a;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out a);
			FastCombatActorInfo a2;
			LuaObject.checkType<FastCombatActorInfo>(l, 3, out a2);
			IEnumerator o = preCombatUIController.m_luaExportHelper.Co_FastCombat(a, a2);
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

	// Token: 0x06020653 RID: 132691 RVA: 0x00AC8E94 File Offset: 0x00AC7094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_PlayDamage(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
				int side;
				LuaObject.checkType(l, 2, out side);
				FastCombatActorInfo a;
				LuaObject.checkType<FastCombatActorInfo>(l, 3, out a);
				IEnumerator o = preCombatUIController.m_luaExportHelper.Co_PlayDamage(side, a);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 9)
			{
				PreCombatUIController preCombatUIController2 = (PreCombatUIController)LuaObject.checkSelf(l);
				GameObject fxParent;
				LuaObject.checkType<GameObject>(l, 2, out fxParent);
				int side2;
				LuaObject.checkType(l, 3, out side2);
				int beforeHp;
				LuaObject.checkType(l, 4, out beforeHp);
				int afterHp;
				LuaObject.checkType(l, 5, out afterHp);
				int hpMax;
				LuaObject.checkType(l, 6, out hpMax);
				bool isHero;
				LuaObject.checkType(l, 7, out isHero);
				int totalDamage;
				LuaObject.checkType(l, 8, out totalDamage);
				bool isCritical;
				LuaObject.checkType(l, 9, out isCritical);
				IEnumerator o2 = preCombatUIController2.m_luaExportHelper.Co_PlayDamage(fxParent, side2, beforeHp, afterHp, hpMax, isHero, totalDamage, isCritical);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Co_PlayDamage to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020654 RID: 132692 RVA: 0x00AC8FDC File Offset: 0x00AC71DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayDamageFx(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject fxParent;
			LuaObject.checkType<GameObject>(l, 2, out fxParent);
			int side;
			LuaObject.checkType(l, 3, out side);
			int hp;
			LuaObject.checkType(l, 4, out hp);
			int hpMax;
			LuaObject.checkType(l, 5, out hpMax);
			int damage;
			LuaObject.checkType(l, 6, out damage);
			bool isLargeFx;
			LuaObject.checkType(l, 7, out isLargeFx);
			preCombatUIController.m_luaExportHelper.PlayDamageFx(fxParent, side, hp, hpMax, damage, isLargeFx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020655 RID: 132693 RVA: 0x00AC9078 File Offset: 0x00AC7278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.OnOkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020656 RID: 132694 RVA: 0x00AC90CC File Offset: 0x00AC72CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.OnCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020657 RID: 132695 RVA: 0x00AC9120 File Offset: 0x00AC7320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020658 RID: 132696 RVA: 0x00AC9174 File Offset: 0x00AC7374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			preCombatUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020659 RID: 132697 RVA: 0x00AC91E0 File Offset: 0x00AC73E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602065A RID: 132698 RVA: 0x00AC9234 File Offset: 0x00AC7434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602065B RID: 132699 RVA: 0x00AC9288 File Offset: 0x00AC7488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = preCombatUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602065C RID: 132700 RVA: 0x00AC9330 File Offset: 0x00AC7530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602065D RID: 132701 RVA: 0x00AC9384 File Offset: 0x00AC7584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			preCombatUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602065E RID: 132702 RVA: 0x00AC93F0 File Offset: 0x00AC75F0
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
				PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				preCombatUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PreCombatUIController preCombatUIController2 = (PreCombatUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				preCombatUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602065F RID: 132703 RVA: 0x00AC9500 File Offset: 0x00AC7700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			preCombatUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020660 RID: 132704 RVA: 0x00AC956C File Offset: 0x00AC776C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			preCombatUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020661 RID: 132705 RVA: 0x00AC95D8 File Offset: 0x00AC77D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			preCombatUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020662 RID: 132706 RVA: 0x00AC9644 File Offset: 0x00AC7844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			preCombatUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020663 RID: 132707 RVA: 0x00AC96B0 File Offset: 0x00AC78B0
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
				PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				preCombatUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PreCombatUIController preCombatUIController2 = (PreCombatUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				preCombatUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020664 RID: 132708 RVA: 0x00AC97C0 File Offset: 0x00AC79C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			string s = preCombatUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020665 RID: 132709 RVA: 0x00AC981C File Offset: 0x00AC7A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnOk(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__callDele_EventOnOk();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020666 RID: 132710 RVA: 0x00AC9870 File Offset: 0x00AC7A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnOk(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__clearDele_EventOnOk();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020667 RID: 132711 RVA: 0x00AC98C4 File Offset: 0x00AC7AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__callDele_EventOnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020668 RID: 132712 RVA: 0x00AC9918 File Offset: 0x00AC7B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__clearDele_EventOnCancel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020669 RID: 132713 RVA: 0x00AC996C File Offset: 0x00AC7B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStop(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__callDele_EventOnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602066A RID: 132714 RVA: 0x00AC99C0 File Offset: 0x00AC7BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStop(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			preCombatUIController.m_luaExportHelper.__clearDele_EventOnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602066B RID: 132715 RVA: 0x00AC9A14 File Offset: 0x00AC7C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnOk(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					preCombatUIController.EventOnOk += value;
				}
				else if (num == 2)
				{
					preCombatUIController.EventOnOk -= value;
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

	// Token: 0x0602066C RID: 132716 RVA: 0x00AC9A94 File Offset: 0x00AC7C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCancel(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					preCombatUIController.EventOnCancel += value;
				}
				else if (num == 2)
				{
					preCombatUIController.EventOnCancel -= value;
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

	// Token: 0x0602066D RID: 132717 RVA: 0x00AC9B14 File Offset: 0x00AC7D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStop(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					preCombatUIController.EventOnStop += value;
				}
				else if (num == 2)
				{
					preCombatUIController.EventOnStop -= value;
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

	// Token: 0x0602066E RID: 132718 RVA: 0x00AC9B94 File Offset: 0x00AC7D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602066F RID: 132719 RVA: 0x00AC9BEC File Offset: 0x00AC7DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			preCombatUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020670 RID: 132720 RVA: 0x00AC9C48 File Offset: 0x00AC7E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePreviewStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_battlePreviewStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020671 RID: 132721 RVA: 0x00AC9CA0 File Offset: 0x00AC7EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePreviewStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController battlePreviewStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out battlePreviewStateCtrl);
			preCombatUIController.m_luaExportHelper.m_battlePreviewStateCtrl = battlePreviewStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020672 RID: 132722 RVA: 0x00AC9CFC File Offset: 0x00AC7EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020673 RID: 132723 RVA: 0x00AC9D54 File Offset: 0x00AC7F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			preCombatUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020674 RID: 132724 RVA: 0x00AC9DB0 File Offset: 0x00AC7FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0TerrainText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0TerrainText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020675 RID: 132725 RVA: 0x00AC9E08 File Offset: 0x00AC8008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0TerrainText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0TerrainText;
			LuaObject.checkType<Text>(l, 2, out actor0TerrainText);
			preCombatUIController.m_luaExportHelper.m_actor0TerrainText = actor0TerrainText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020676 RID: 132726 RVA: 0x00AC9E64 File Offset: 0x00AC8064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0TerrainDefText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0TerrainDefText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020677 RID: 132727 RVA: 0x00AC9EBC File Offset: 0x00AC80BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0TerrainDefText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0TerrainDefText;
			LuaObject.checkType<Text>(l, 2, out actor0TerrainDefText);
			preCombatUIController.m_luaExportHelper.m_actor0TerrainDefText = actor0TerrainDefText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020678 RID: 132728 RVA: 0x00AC9F18 File Offset: 0x00AC8118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0TerrainImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0TerrainImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020679 RID: 132729 RVA: 0x00AC9F70 File Offset: 0x00AC8170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0TerrainImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0TerrainImage;
			LuaObject.checkType<Image>(l, 2, out actor0TerrainImage);
			preCombatUIController.m_luaExportHelper.m_actor0TerrainImage = actor0TerrainImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602067A RID: 132730 RVA: 0x00AC9FCC File Offset: 0x00AC81CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0UIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602067B RID: 132731 RVA: 0x00ACA024 File Offset: 0x00AC8224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0UIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor0UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor0UIStateController);
			preCombatUIController.m_luaExportHelper.m_actor0UIStateController = actor0UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602067C RID: 132732 RVA: 0x00ACA080 File Offset: 0x00AC8280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0CharUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0CharUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602067D RID: 132733 RVA: 0x00ACA0D8 File Offset: 0x00AC82D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0CharUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor0CharUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor0CharUIStateController);
			preCombatUIController.m_luaExportHelper.m_actor0CharUIStateController = actor0CharUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602067E RID: 132734 RVA: 0x00ACA134 File Offset: 0x00AC8334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0CharIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0CharIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602067F RID: 132735 RVA: 0x00ACA18C File Offset: 0x00AC838C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0CharIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0CharIcon;
			LuaObject.checkType<Image>(l, 2, out actor0CharIcon);
			preCombatUIController.m_luaExportHelper.m_actor0CharIcon = actor0CharIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020680 RID: 132736 RVA: 0x00ACA1E8 File Offset: 0x00AC83E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SkillGo(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SkillGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020681 RID: 132737 RVA: 0x00ACA240 File Offset: 0x00AC8440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SkillGo(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject actor0SkillGo;
			LuaObject.checkType<GameObject>(l, 2, out actor0SkillGo);
			preCombatUIController.m_luaExportHelper.m_actor0SkillGo = actor0SkillGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020682 RID: 132738 RVA: 0x00ACA29C File Offset: 0x00AC849C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020683 RID: 132739 RVA: 0x00ACA2F4 File Offset: 0x00AC84F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0SkillIconImage;
			LuaObject.checkType<Image>(l, 2, out actor0SkillIconImage);
			preCombatUIController.m_luaExportHelper.m_actor0SkillIconImage = actor0SkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020684 RID: 132740 RVA: 0x00ACA350 File Offset: 0x00AC8550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0TypeIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0TypeIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020685 RID: 132741 RVA: 0x00ACA3A8 File Offset: 0x00AC85A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0TypeIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0TypeIcon;
			LuaObject.checkType<Image>(l, 2, out actor0TypeIcon);
			preCombatUIController.m_luaExportHelper.m_actor0TypeIcon = actor0TypeIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020686 RID: 132742 RVA: 0x00ACA404 File Offset: 0x00AC8604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0HpText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0HpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020687 RID: 132743 RVA: 0x00ACA45C File Offset: 0x00AC865C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0HpText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0HpText;
			LuaObject.checkType<Text>(l, 2, out actor0HpText);
			preCombatUIController.m_luaExportHelper.m_actor0HpText = actor0HpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020688 RID: 132744 RVA: 0x00ACA4B8 File Offset: 0x00AC86B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0HpProgressBar(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0HpProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020689 RID: 132745 RVA: 0x00ACA510 File Offset: 0x00AC8710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0HpProgressBar(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0HpProgressBar;
			LuaObject.checkType<Image>(l, 2, out actor0HpProgressBar);
			preCombatUIController.m_luaExportHelper.m_actor0HpProgressBar = actor0HpProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602068A RID: 132746 RVA: 0x00ACA56C File Offset: 0x00AC876C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0HeroHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0HeroHpFxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602068B RID: 132747 RVA: 0x00ACA5C4 File Offset: 0x00AC87C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0HeroHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject actor0HeroHpFxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out actor0HeroHpFxGameObeject);
			preCombatUIController.m_luaExportHelper.m_actor0HeroHpFxGameObeject = actor0HeroHpFxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602068C RID: 132748 RVA: 0x00ACA620 File Offset: 0x00AC8820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0Proprety1NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0Proprety1NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602068D RID: 132749 RVA: 0x00ACA678 File Offset: 0x00AC8878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0Proprety1NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor0Proprety1NameText;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor0Proprety1NameText);
			preCombatUIController.m_luaExportHelper.m_actor0Proprety1NameText = actor0Proprety1NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602068E RID: 132750 RVA: 0x00ACA6D4 File Offset: 0x00AC88D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0Proprety1ValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0Proprety1ValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602068F RID: 132751 RVA: 0x00ACA72C File Offset: 0x00AC892C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0Proprety1ValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0Proprety1ValueText;
			LuaObject.checkType<Text>(l, 2, out actor0Proprety1ValueText);
			preCombatUIController.m_luaExportHelper.m_actor0Proprety1ValueText = actor0Proprety1ValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020690 RID: 132752 RVA: 0x00ACA788 File Offset: 0x00AC8988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0Proprety2NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0Proprety2NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020691 RID: 132753 RVA: 0x00ACA7E0 File Offset: 0x00AC89E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0Proprety2NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor0Proprety2NameText;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor0Proprety2NameText);
			preCombatUIController.m_luaExportHelper.m_actor0Proprety2NameText = actor0Proprety2NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020692 RID: 132754 RVA: 0x00ACA83C File Offset: 0x00AC8A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0Proprety2ValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0Proprety2ValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020693 RID: 132755 RVA: 0x00ACA894 File Offset: 0x00AC8A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0Proprety2ValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0Proprety2ValueText;
			LuaObject.checkType<Text>(l, 2, out actor0Proprety2ValueText);
			preCombatUIController.m_luaExportHelper.m_actor0Proprety2ValueText = actor0Proprety2ValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020694 RID: 132756 RVA: 0x00ACA8F0 File Offset: 0x00AC8AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020695 RID: 132757 RVA: 0x00ACA948 File Offset: 0x00AC8B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0NameText;
			LuaObject.checkType<Text>(l, 2, out actor0NameText);
			preCombatUIController.m_luaExportHelper.m_actor0NameText = actor0NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020696 RID: 132758 RVA: 0x00ACA9A4 File Offset: 0x00AC8BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0LvValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0LvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020697 RID: 132759 RVA: 0x00ACA9FC File Offset: 0x00AC8BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0LvValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0LvValueText;
			LuaObject.checkType<Text>(l, 2, out actor0LvValueText);
			preCombatUIController.m_luaExportHelper.m_actor0LvValueText = actor0LvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020698 RID: 132760 RVA: 0x00ACAA58 File Offset: 0x00AC8C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SituationGroup(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SituationGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020699 RID: 132761 RVA: 0x00ACAAB0 File Offset: 0x00AC8CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SituationGroup(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor0SituationGroup;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor0SituationGroup);
			preCombatUIController.m_luaExportHelper.m_actor0SituationGroup = actor0SituationGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602069A RID: 132762 RVA: 0x00ACAB0C File Offset: 0x00AC8D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SoldierGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SoldierGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602069B RID: 132763 RVA: 0x00ACAB64 File Offset: 0x00AC8D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SoldierGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject actor0SoldierGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out actor0SoldierGroupGameObject);
			preCombatUIController.m_luaExportHelper.m_actor0SoldierGroupGameObject = actor0SoldierGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602069C RID: 132764 RVA: 0x00ACABC0 File Offset: 0x00AC8DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SoldierTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SoldierTypeIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602069D RID: 132765 RVA: 0x00ACAC18 File Offset: 0x00AC8E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SoldierTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0SoldierTypeIcon;
			LuaObject.checkType<Image>(l, 2, out actor0SoldierTypeIcon);
			preCombatUIController.m_luaExportHelper.m_actor0SoldierTypeIcon = actor0SoldierTypeIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602069E RID: 132766 RVA: 0x00ACAC74 File Offset: 0x00AC8E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SoldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602069F RID: 132767 RVA: 0x00ACACCC File Offset: 0x00AC8ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0SoldierNameText;
			LuaObject.checkType<Text>(l, 2, out actor0SoldierNameText);
			preCombatUIController.m_luaExportHelper.m_actor0SoldierNameText = actor0SoldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A0 RID: 132768 RVA: 0x00ACAD28 File Offset: 0x00AC8F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SoldierHpProgressBar(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SoldierHpProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A1 RID: 132769 RVA: 0x00ACAD80 File Offset: 0x00AC8F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SoldierHpProgressBar(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0SoldierHpProgressBar;
			LuaObject.checkType<Image>(l, 2, out actor0SoldierHpProgressBar);
			preCombatUIController.m_luaExportHelper.m_actor0SoldierHpProgressBar = actor0SoldierHpProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A2 RID: 132770 RVA: 0x00ACADDC File Offset: 0x00AC8FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SoldierHpText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SoldierHpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A3 RID: 132771 RVA: 0x00ACAE34 File Offset: 0x00AC9034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SoldierHpText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0SoldierHpText;
			LuaObject.checkType<Text>(l, 2, out actor0SoldierHpText);
			preCombatUIController.m_luaExportHelper.m_actor0SoldierHpText = actor0SoldierHpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A4 RID: 132772 RVA: 0x00ACAE90 File Offset: 0x00AC9090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0SoldierHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0SoldierHpFxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A5 RID: 132773 RVA: 0x00ACAEE8 File Offset: 0x00AC90E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0SoldierHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject actor0SoldierHpFxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out actor0SoldierHpFxGameObeject);
			preCombatUIController.m_luaExportHelper.m_actor0SoldierHpFxGameObeject = actor0SoldierHpFxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A6 RID: 132774 RVA: 0x00ACAF44 File Offset: 0x00AC9144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0DamageUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0DamageUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A7 RID: 132775 RVA: 0x00ACAF9C File Offset: 0x00AC919C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0DamageUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor0DamageUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor0DamageUIStateController);
			preCombatUIController.m_luaExportHelper.m_actor0DamageUIStateController = actor0DamageUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A8 RID: 132776 RVA: 0x00ACAFF8 File Offset: 0x00AC91F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0DamageText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0DamageText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206A9 RID: 132777 RVA: 0x00ACB050 File Offset: 0x00AC9250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0DamageText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0DamageText;
			LuaObject.checkType<Text>(l, 2, out actor0DamageText);
			preCombatUIController.m_luaExportHelper.m_actor0DamageText = actor0DamageText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206AA RID: 132778 RVA: 0x00ACB0AC File Offset: 0x00AC92AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0DamageCriticalText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0DamageCriticalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206AB RID: 132779 RVA: 0x00ACB104 File Offset: 0x00AC9304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0DamageCriticalText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0DamageCriticalText;
			LuaObject.checkType<Text>(l, 2, out actor0DamageCriticalText);
			preCombatUIController.m_luaExportHelper.m_actor0DamageCriticalText = actor0DamageCriticalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206AC RID: 132780 RVA: 0x00ACB160 File Offset: 0x00AC9360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0PassiveSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0PassiveSkillUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206AD RID: 132781 RVA: 0x00ACB1B8 File Offset: 0x00AC93B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0PassiveSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor0PassiveSkillUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor0PassiveSkillUIStateController);
			preCombatUIController.m_luaExportHelper.m_actor0PassiveSkillUIStateController = actor0PassiveSkillUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206AE RID: 132782 RVA: 0x00ACB214 File Offset: 0x00AC9414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0PassiveSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0PassiveSkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206AF RID: 132783 RVA: 0x00ACB26C File Offset: 0x00AC946C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0PassiveSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0PassiveSkillIconImage;
			LuaObject.checkType<Image>(l, 2, out actor0PassiveSkillIconImage);
			preCombatUIController.m_luaExportHelper.m_actor0PassiveSkillIconImage = actor0PassiveSkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B0 RID: 132784 RVA: 0x00ACB2C8 File Offset: 0x00AC94C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0PassiveSkillTalentIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0PassiveSkillTalentIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B1 RID: 132785 RVA: 0x00ACB320 File Offset: 0x00AC9520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0PassiveSkillTalentIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor0PassiveSkillTalentIconImage;
			LuaObject.checkType<Image>(l, 2, out actor0PassiveSkillTalentIconImage);
			preCombatUIController.m_luaExportHelper.m_actor0PassiveSkillTalentIconImage = actor0PassiveSkillTalentIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B2 RID: 132786 RVA: 0x00ACB37C File Offset: 0x00AC957C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor0PassiveSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor0PassiveSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B3 RID: 132787 RVA: 0x00ACB3D4 File Offset: 0x00AC95D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor0PassiveSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor0PassiveSkillNameText;
			LuaObject.checkType<Text>(l, 2, out actor0PassiveSkillNameText);
			preCombatUIController.m_luaExportHelper.m_actor0PassiveSkillNameText = actor0PassiveSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B4 RID: 132788 RVA: 0x00ACB430 File Offset: 0x00AC9630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1TerrainText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1TerrainText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B5 RID: 132789 RVA: 0x00ACB488 File Offset: 0x00AC9688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1TerrainText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1TerrainText;
			LuaObject.checkType<Text>(l, 2, out actor1TerrainText);
			preCombatUIController.m_luaExportHelper.m_actor1TerrainText = actor1TerrainText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B6 RID: 132790 RVA: 0x00ACB4E4 File Offset: 0x00AC96E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1TerrainDefText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1TerrainDefText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B7 RID: 132791 RVA: 0x00ACB53C File Offset: 0x00AC973C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1TerrainDefText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1TerrainDefText;
			LuaObject.checkType<Text>(l, 2, out actor1TerrainDefText);
			preCombatUIController.m_luaExportHelper.m_actor1TerrainDefText = actor1TerrainDefText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B8 RID: 132792 RVA: 0x00ACB598 File Offset: 0x00AC9798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1TerrainImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1TerrainImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206B9 RID: 132793 RVA: 0x00ACB5F0 File Offset: 0x00AC97F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1TerrainImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1TerrainImage;
			LuaObject.checkType<Image>(l, 2, out actor1TerrainImage);
			preCombatUIController.m_luaExportHelper.m_actor1TerrainImage = actor1TerrainImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206BA RID: 132794 RVA: 0x00ACB64C File Offset: 0x00AC984C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1UIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206BB RID: 132795 RVA: 0x00ACB6A4 File Offset: 0x00AC98A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1UIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor1UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor1UIStateController);
			preCombatUIController.m_luaExportHelper.m_actor1UIStateController = actor1UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206BC RID: 132796 RVA: 0x00ACB700 File Offset: 0x00AC9900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1CharUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1CharUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206BD RID: 132797 RVA: 0x00ACB758 File Offset: 0x00AC9958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1CharUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor1CharUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor1CharUIStateController);
			preCombatUIController.m_luaExportHelper.m_actor1CharUIStateController = actor1CharUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206BE RID: 132798 RVA: 0x00ACB7B4 File Offset: 0x00AC99B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1CharIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1CharIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206BF RID: 132799 RVA: 0x00ACB80C File Offset: 0x00AC9A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1CharIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1CharIcon;
			LuaObject.checkType<Image>(l, 2, out actor1CharIcon);
			preCombatUIController.m_luaExportHelper.m_actor1CharIcon = actor1CharIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C0 RID: 132800 RVA: 0x00ACB868 File Offset: 0x00AC9A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SkillGo(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SkillGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C1 RID: 132801 RVA: 0x00ACB8C0 File Offset: 0x00AC9AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SkillGo(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject actor1SkillGo;
			LuaObject.checkType<GameObject>(l, 2, out actor1SkillGo);
			preCombatUIController.m_luaExportHelper.m_actor1SkillGo = actor1SkillGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C2 RID: 132802 RVA: 0x00ACB91C File Offset: 0x00AC9B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C3 RID: 132803 RVA: 0x00ACB974 File Offset: 0x00AC9B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1SkillIconImage;
			LuaObject.checkType<Image>(l, 2, out actor1SkillIconImage);
			preCombatUIController.m_luaExportHelper.m_actor1SkillIconImage = actor1SkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C4 RID: 132804 RVA: 0x00ACB9D0 File Offset: 0x00AC9BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1TypeIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1TypeIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C5 RID: 132805 RVA: 0x00ACBA28 File Offset: 0x00AC9C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1TypeIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1TypeIcon;
			LuaObject.checkType<Image>(l, 2, out actor1TypeIcon);
			preCombatUIController.m_luaExportHelper.m_actor1TypeIcon = actor1TypeIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C6 RID: 132806 RVA: 0x00ACBA84 File Offset: 0x00AC9C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1HpText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1HpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C7 RID: 132807 RVA: 0x00ACBADC File Offset: 0x00AC9CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1HpText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1HpText;
			LuaObject.checkType<Text>(l, 2, out actor1HpText);
			preCombatUIController.m_luaExportHelper.m_actor1HpText = actor1HpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C8 RID: 132808 RVA: 0x00ACBB38 File Offset: 0x00AC9D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1HpProgressBar(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1HpProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206C9 RID: 132809 RVA: 0x00ACBB90 File Offset: 0x00AC9D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1HpProgressBar(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1HpProgressBar;
			LuaObject.checkType<Image>(l, 2, out actor1HpProgressBar);
			preCombatUIController.m_luaExportHelper.m_actor1HpProgressBar = actor1HpProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206CA RID: 132810 RVA: 0x00ACBBEC File Offset: 0x00AC9DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1HeroHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1HeroHpFxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206CB RID: 132811 RVA: 0x00ACBC44 File Offset: 0x00AC9E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1HeroHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject actor1HeroHpFxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out actor1HeroHpFxGameObeject);
			preCombatUIController.m_luaExportHelper.m_actor1HeroHpFxGameObeject = actor1HeroHpFxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206CC RID: 132812 RVA: 0x00ACBCA0 File Offset: 0x00AC9EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1Proprety1NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1Proprety1NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206CD RID: 132813 RVA: 0x00ACBCF8 File Offset: 0x00AC9EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1Proprety1NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor1Proprety1NameText;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor1Proprety1NameText);
			preCombatUIController.m_luaExportHelper.m_actor1Proprety1NameText = actor1Proprety1NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206CE RID: 132814 RVA: 0x00ACBD54 File Offset: 0x00AC9F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1Proprety1ValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1Proprety1ValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206CF RID: 132815 RVA: 0x00ACBDAC File Offset: 0x00AC9FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1Proprety1ValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1Proprety1ValueText;
			LuaObject.checkType<Text>(l, 2, out actor1Proprety1ValueText);
			preCombatUIController.m_luaExportHelper.m_actor1Proprety1ValueText = actor1Proprety1ValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D0 RID: 132816 RVA: 0x00ACBE08 File Offset: 0x00ACA008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1Proprety2NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1Proprety2NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D1 RID: 132817 RVA: 0x00ACBE60 File Offset: 0x00ACA060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1Proprety2NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor1Proprety2NameText;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor1Proprety2NameText);
			preCombatUIController.m_luaExportHelper.m_actor1Proprety2NameText = actor1Proprety2NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D2 RID: 132818 RVA: 0x00ACBEBC File Offset: 0x00ACA0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1Proprety2ValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1Proprety2ValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D3 RID: 132819 RVA: 0x00ACBF14 File Offset: 0x00ACA114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1Proprety2ValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1Proprety2ValueText;
			LuaObject.checkType<Text>(l, 2, out actor1Proprety2ValueText);
			preCombatUIController.m_luaExportHelper.m_actor1Proprety2ValueText = actor1Proprety2ValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D4 RID: 132820 RVA: 0x00ACBF70 File Offset: 0x00ACA170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D5 RID: 132821 RVA: 0x00ACBFC8 File Offset: 0x00ACA1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1NameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1NameText;
			LuaObject.checkType<Text>(l, 2, out actor1NameText);
			preCombatUIController.m_luaExportHelper.m_actor1NameText = actor1NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D6 RID: 132822 RVA: 0x00ACC024 File Offset: 0x00ACA224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1LvValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1LvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D7 RID: 132823 RVA: 0x00ACC07C File Offset: 0x00ACA27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1LvValueText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1LvValueText;
			LuaObject.checkType<Text>(l, 2, out actor1LvValueText);
			preCombatUIController.m_luaExportHelper.m_actor1LvValueText = actor1LvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D8 RID: 132824 RVA: 0x00ACC0D8 File Offset: 0x00ACA2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SituationGroup(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SituationGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206D9 RID: 132825 RVA: 0x00ACC130 File Offset: 0x00ACA330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SituationGroup(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor1SituationGroup;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor1SituationGroup);
			preCombatUIController.m_luaExportHelper.m_actor1SituationGroup = actor1SituationGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206DA RID: 132826 RVA: 0x00ACC18C File Offset: 0x00ACA38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SoldierGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SoldierGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206DB RID: 132827 RVA: 0x00ACC1E4 File Offset: 0x00ACA3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SoldierGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject actor1SoldierGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out actor1SoldierGroupGameObject);
			preCombatUIController.m_luaExportHelper.m_actor1SoldierGroupGameObject = actor1SoldierGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206DC RID: 132828 RVA: 0x00ACC240 File Offset: 0x00ACA440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SoldierTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SoldierTypeIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206DD RID: 132829 RVA: 0x00ACC298 File Offset: 0x00ACA498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SoldierTypeIcon(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1SoldierTypeIcon;
			LuaObject.checkType<Image>(l, 2, out actor1SoldierTypeIcon);
			preCombatUIController.m_luaExportHelper.m_actor1SoldierTypeIcon = actor1SoldierTypeIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206DE RID: 132830 RVA: 0x00ACC2F4 File Offset: 0x00ACA4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SoldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206DF RID: 132831 RVA: 0x00ACC34C File Offset: 0x00ACA54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1SoldierNameText;
			LuaObject.checkType<Text>(l, 2, out actor1SoldierNameText);
			preCombatUIController.m_luaExportHelper.m_actor1SoldierNameText = actor1SoldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E0 RID: 132832 RVA: 0x00ACC3A8 File Offset: 0x00ACA5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SoldierHpProgressBar(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SoldierHpProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E1 RID: 132833 RVA: 0x00ACC400 File Offset: 0x00ACA600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SoldierHpProgressBar(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1SoldierHpProgressBar;
			LuaObject.checkType<Image>(l, 2, out actor1SoldierHpProgressBar);
			preCombatUIController.m_luaExportHelper.m_actor1SoldierHpProgressBar = actor1SoldierHpProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E2 RID: 132834 RVA: 0x00ACC45C File Offset: 0x00ACA65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SoldierHpText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SoldierHpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E3 RID: 132835 RVA: 0x00ACC4B4 File Offset: 0x00ACA6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SoldierHpText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1SoldierHpText;
			LuaObject.checkType<Text>(l, 2, out actor1SoldierHpText);
			preCombatUIController.m_luaExportHelper.m_actor1SoldierHpText = actor1SoldierHpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E4 RID: 132836 RVA: 0x00ACC510 File Offset: 0x00ACA710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1SoldierHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1SoldierHpFxGameObeject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E5 RID: 132837 RVA: 0x00ACC568 File Offset: 0x00ACA768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1SoldierHpFxGameObeject(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			GameObject actor1SoldierHpFxGameObeject;
			LuaObject.checkType<GameObject>(l, 2, out actor1SoldierHpFxGameObeject);
			preCombatUIController.m_luaExportHelper.m_actor1SoldierHpFxGameObeject = actor1SoldierHpFxGameObeject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E6 RID: 132838 RVA: 0x00ACC5C4 File Offset: 0x00ACA7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1DamageUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1DamageUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E7 RID: 132839 RVA: 0x00ACC61C File Offset: 0x00ACA81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1DamageUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor1DamageUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor1DamageUIStateController);
			preCombatUIController.m_luaExportHelper.m_actor1DamageUIStateController = actor1DamageUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E8 RID: 132840 RVA: 0x00ACC678 File Offset: 0x00ACA878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1DamageText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1DamageText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206E9 RID: 132841 RVA: 0x00ACC6D0 File Offset: 0x00ACA8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1DamageText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1DamageText;
			LuaObject.checkType<Text>(l, 2, out actor1DamageText);
			preCombatUIController.m_luaExportHelper.m_actor1DamageText = actor1DamageText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206EA RID: 132842 RVA: 0x00ACC72C File Offset: 0x00ACA92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1DamageCriticalText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1DamageCriticalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206EB RID: 132843 RVA: 0x00ACC784 File Offset: 0x00ACA984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1DamageCriticalText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1DamageCriticalText;
			LuaObject.checkType<Text>(l, 2, out actor1DamageCriticalText);
			preCombatUIController.m_luaExportHelper.m_actor1DamageCriticalText = actor1DamageCriticalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206EC RID: 132844 RVA: 0x00ACC7E0 File Offset: 0x00ACA9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1PassiveSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1PassiveSkillUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206ED RID: 132845 RVA: 0x00ACC838 File Offset: 0x00ACAA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1PassiveSkillUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			CommonUIStateController actor1PassiveSkillUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out actor1PassiveSkillUIStateController);
			preCombatUIController.m_luaExportHelper.m_actor1PassiveSkillUIStateController = actor1PassiveSkillUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206EE RID: 132846 RVA: 0x00ACC894 File Offset: 0x00ACAA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1PassiveSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1PassiveSkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206EF RID: 132847 RVA: 0x00ACC8EC File Offset: 0x00ACAAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1PassiveSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1PassiveSkillIconImage;
			LuaObject.checkType<Image>(l, 2, out actor1PassiveSkillIconImage);
			preCombatUIController.m_luaExportHelper.m_actor1PassiveSkillIconImage = actor1PassiveSkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F0 RID: 132848 RVA: 0x00ACC948 File Offset: 0x00ACAB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1PassiveSkillTalentIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1PassiveSkillTalentIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F1 RID: 132849 RVA: 0x00ACC9A0 File Offset: 0x00ACABA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1PassiveSkillTalentIconImage(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Image actor1PassiveSkillTalentIconImage;
			LuaObject.checkType<Image>(l, 2, out actor1PassiveSkillTalentIconImage);
			preCombatUIController.m_luaExportHelper.m_actor1PassiveSkillTalentIconImage = actor1PassiveSkillTalentIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F2 RID: 132850 RVA: 0x00ACC9FC File Offset: 0x00ACABFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor1PassiveSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_actor1PassiveSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F3 RID: 132851 RVA: 0x00ACCA54 File Offset: 0x00ACAC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor1PassiveSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Text actor1PassiveSkillNameText;
			LuaObject.checkType<Text>(l, 2, out actor1PassiveSkillNameText);
			preCombatUIController.m_luaExportHelper.m_actor1PassiveSkillNameText = actor1PassiveSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F4 RID: 132852 RVA: 0x00ACCAB0 File Offset: 0x00ACACB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_okButton(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_okButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F5 RID: 132853 RVA: 0x00ACCB08 File Offset: 0x00ACAD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_okButton(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Button okButton;
			LuaObject.checkType<Button>(l, 2, out okButton);
			preCombatUIController.m_luaExportHelper.m_okButton = okButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F6 RID: 132854 RVA: 0x00ACCB64 File Offset: 0x00ACAD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_cancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F7 RID: 132855 RVA: 0x00ACCBBC File Offset: 0x00ACADBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			Button cancelButton;
			LuaObject.checkType<Button>(l, 2, out cancelButton);
			preCombatUIController.m_luaExportHelper.m_cancelButton = cancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F8 RID: 132856 RVA: 0x00ACCC18 File Offset: 0x00ACAE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyRelationValue(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_armyRelationValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206F9 RID: 132857 RVA: 0x00ACCC70 File Offset: 0x00ACAE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRelationValue(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			int armyRelationValue;
			LuaObject.checkType(l, 2, out armyRelationValue);
			preCombatUIController.m_luaExportHelper.m_armyRelationValue = armyRelationValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206FA RID: 132858 RVA: 0x00ACCCCC File Offset: 0x00ACAECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalDamage0(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_totalDamage0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206FB RID: 132859 RVA: 0x00ACCD24 File Offset: 0x00ACAF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalDamage0(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			int totalDamage;
			LuaObject.checkType(l, 2, out totalDamage);
			preCombatUIController.m_luaExportHelper.m_totalDamage0 = totalDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206FC RID: 132860 RVA: 0x00ACCD80 File Offset: 0x00ACAF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalDamage1(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_totalDamage1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206FD RID: 132861 RVA: 0x00ACCDD8 File Offset: 0x00ACAFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalDamage1(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			int totalDamage;
			LuaObject.checkType(l, 2, out totalDamage);
			preCombatUIController.m_luaExportHelper.m_totalDamage1 = totalDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206FE RID: 132862 RVA: 0x00ACCE34 File Offset: 0x00ACB034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_fxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060206FF RID: 132863 RVA: 0x00ACCE8C File Offset: 0x00ACB08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			FxPlayer fxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out fxPlayer);
			preCombatUIController.m_luaExportHelper.m_fxPlayer = fxPlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020700 RID: 132864 RVA: 0x00ACCEE8 File Offset: 0x00ACB0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020701 RID: 132865 RVA: 0x00ACCF40 File Offset: 0x00ACB140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			preCombatUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020702 RID: 132866 RVA: 0x00ACCF9C File Offset: 0x00ACB19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFastCombat(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_isFastCombat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020703 RID: 132867 RVA: 0x00ACCFF4 File Offset: 0x00ACB1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFastCombat(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			bool isFastCombat;
			LuaObject.checkType(l, 2, out isFastCombat);
			preCombatUIController.m_luaExportHelper.m_isFastCombat = isFastCombat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020704 RID: 132868 RVA: 0x00ACD050 File Offset: 0x00ACB250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyComputer(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preCombatUIController.m_luaExportHelper.m_propertyComputer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020705 RID: 132869 RVA: 0x00ACD0A8 File Offset: 0x00ACB2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyComputer(IntPtr l)
	{
		int result;
		try
		{
			PreCombatUIController preCombatUIController = (PreCombatUIController)LuaObject.checkSelf(l);
			HeroPropertyComputer propertyComputer;
			LuaObject.checkType<HeroPropertyComputer>(l, 2, out propertyComputer);
			preCombatUIController.m_luaExportHelper.m_propertyComputer = propertyComputer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020706 RID: 132870 RVA: 0x00ACD104 File Offset: 0x00ACB304
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PreCombatUIController");
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.IsFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.SetBattleActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.OpenAndShowFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.ShowFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.OnActorPassiveSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.ShowOkCancelButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.SetHeroHp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.SetSoldierHp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.Co_OpenAndFastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.Co_FastCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.Co_PlayDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.PlayDamageFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.OnOkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.OnCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callDele_EventOnOk);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__clearDele_EventOnOk);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callDele_EventOnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__clearDele_EventOnCancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__callDele_EventOnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.__clearDele_EventOnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache28);
		string name = "EventOnOk";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_EventOnOk);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache29, true);
		string name2 = "EventOnCancel";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_EventOnCancel);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2A, true);
		string name3 = "EventOnStop";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_EventOnStop);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2B, true);
		string name4 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_backgroundButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2D, true);
		string name5 = "m_battlePreviewStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_battlePreviewStateCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_battlePreviewStateCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache2F, true);
		string name6 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_marginTransform);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache31, true);
		string name7 = "m_actor0TerrainText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0TerrainText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0TerrainText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache33, true);
		string name8 = "m_actor0TerrainDefText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0TerrainDefText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0TerrainDefText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache35, true);
		string name9 = "m_actor0TerrainImage";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0TerrainImage);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0TerrainImage);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache37, true);
		string name10 = "m_actor0UIStateController";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0UIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0UIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache39, true);
		string name11 = "m_actor0CharUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0CharUIStateController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0CharUIStateController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3B, true);
		string name12 = "m_actor0CharIcon";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0CharIcon);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0CharIcon);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3D, true);
		string name13 = "m_actor0SkillGo";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SkillGo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SkillGo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache3F, true);
		string name14 = "m_actor0SkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SkillIconImage);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SkillIconImage);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache41, true);
		string name15 = "m_actor0TypeIcon";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0TypeIcon);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0TypeIcon);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache43, true);
		string name16 = "m_actor0HpText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0HpText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0HpText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache45, true);
		string name17 = "m_actor0HpProgressBar";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0HpProgressBar);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0HpProgressBar);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache47, true);
		string name18 = "m_actor0HeroHpFxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0HeroHpFxGameObeject);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0HeroHpFxGameObeject);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache49, true);
		string name19 = "m_actor0Proprety1NameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0Proprety1NameText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0Proprety1NameText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4B, true);
		string name20 = "m_actor0Proprety1ValueText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0Proprety1ValueText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0Proprety1ValueText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4D, true);
		string name21 = "m_actor0Proprety2NameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0Proprety2NameText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0Proprety2NameText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache4F, true);
		string name22 = "m_actor0Proprety2ValueText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0Proprety2ValueText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0Proprety2ValueText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache51, true);
		string name23 = "m_actor0NameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0NameText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0NameText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache53, true);
		string name24 = "m_actor0LvValueText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0LvValueText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0LvValueText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache55, true);
		string name25 = "m_actor0SituationGroup";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SituationGroup);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SituationGroup);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache57, true);
		string name26 = "m_actor0SoldierGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SoldierGroupGameObject);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SoldierGroupGameObject);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache59, true);
		string name27 = "m_actor0SoldierTypeIcon";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SoldierTypeIcon);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SoldierTypeIcon);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5B, true);
		string name28 = "m_actor0SoldierNameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SoldierNameText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SoldierNameText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5D, true);
		string name29 = "m_actor0SoldierHpProgressBar";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SoldierHpProgressBar);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SoldierHpProgressBar);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache5F, true);
		string name30 = "m_actor0SoldierHpText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SoldierHpText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SoldierHpText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache61, true);
		string name31 = "m_actor0SoldierHpFxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0SoldierHpFxGameObeject);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0SoldierHpFxGameObeject);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache63, true);
		string name32 = "m_actor0DamageUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0DamageUIStateController);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0DamageUIStateController);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache65, true);
		string name33 = "m_actor0DamageText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0DamageText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0DamageText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache67, true);
		string name34 = "m_actor0DamageCriticalText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0DamageCriticalText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0DamageCriticalText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache69, true);
		string name35 = "m_actor0PassiveSkillUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0PassiveSkillUIStateController);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0PassiveSkillUIStateController);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6B, true);
		string name36 = "m_actor0PassiveSkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0PassiveSkillIconImage);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0PassiveSkillIconImage);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6D, true);
		string name37 = "m_actor0PassiveSkillTalentIconImage";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0PassiveSkillTalentIconImage);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0PassiveSkillTalentIconImage);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache6F, true);
		string name38 = "m_actor0PassiveSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor0PassiveSkillNameText);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor0PassiveSkillNameText);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache71, true);
		string name39 = "m_actor1TerrainText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1TerrainText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1TerrainText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache73, true);
		string name40 = "m_actor1TerrainDefText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1TerrainDefText);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1TerrainDefText);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache75, true);
		string name41 = "m_actor1TerrainImage";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1TerrainImage);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1TerrainImage);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache77, true);
		string name42 = "m_actor1UIStateController";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1UIStateController);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1UIStateController);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache79, true);
		string name43 = "m_actor1CharUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1CharUIStateController);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1CharUIStateController);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7B, true);
		string name44 = "m_actor1CharIcon";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1CharIcon);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1CharIcon);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7D, true);
		string name45 = "m_actor1SkillGo";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SkillGo);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SkillGo);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache7F, true);
		string name46 = "m_actor1SkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SkillIconImage);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SkillIconImage);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache81, true);
		string name47 = "m_actor1TypeIcon";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1TypeIcon);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1TypeIcon);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache83, true);
		string name48 = "m_actor1HpText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1HpText);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1HpText);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache85, true);
		string name49 = "m_actor1HpProgressBar";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1HpProgressBar);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1HpProgressBar);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache87, true);
		string name50 = "m_actor1HeroHpFxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1HeroHpFxGameObeject);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1HeroHpFxGameObeject);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache89, true);
		string name51 = "m_actor1Proprety1NameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1Proprety1NameText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1Proprety1NameText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8B, true);
		string name52 = "m_actor1Proprety1ValueText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1Proprety1ValueText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1Proprety1ValueText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8D, true);
		string name53 = "m_actor1Proprety2NameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1Proprety2NameText);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1Proprety2NameText);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache8F, true);
		string name54 = "m_actor1Proprety2ValueText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1Proprety2ValueText);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1Proprety2ValueText);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache91, true);
		string name55 = "m_actor1NameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1NameText);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1NameText);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache93, true);
		string name56 = "m_actor1LvValueText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1LvValueText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1LvValueText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache95, true);
		string name57 = "m_actor1SituationGroup";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SituationGroup);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SituationGroup);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache97, true);
		string name58 = "m_actor1SoldierGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SoldierGroupGameObject);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SoldierGroupGameObject);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache99, true);
		string name59 = "m_actor1SoldierTypeIcon";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SoldierTypeIcon);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SoldierTypeIcon);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9B, true);
		string name60 = "m_actor1SoldierNameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SoldierNameText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SoldierNameText);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9D, true);
		string name61 = "m_actor1SoldierHpProgressBar";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SoldierHpProgressBar);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SoldierHpProgressBar);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cache9F, true);
		string name62 = "m_actor1SoldierHpText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SoldierHpText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SoldierHpText);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA1, true);
		string name63 = "m_actor1SoldierHpFxGameObeject";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1SoldierHpFxGameObeject);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1SoldierHpFxGameObeject);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA3, true);
		string name64 = "m_actor1DamageUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1DamageUIStateController);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1DamageUIStateController);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA5, true);
		string name65 = "m_actor1DamageText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1DamageText);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1DamageText);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA7, true);
		string name66 = "m_actor1DamageCriticalText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1DamageCriticalText);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1DamageCriticalText);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheA9, true);
		string name67 = "m_actor1PassiveSkillUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1PassiveSkillUIStateController);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1PassiveSkillUIStateController);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAB, true);
		string name68 = "m_actor1PassiveSkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1PassiveSkillIconImage);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1PassiveSkillIconImage);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAD, true);
		string name69 = "m_actor1PassiveSkillTalentIconImage";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1PassiveSkillTalentIconImage);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1PassiveSkillTalentIconImage);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheAF, true);
		string name70 = "m_actor1PassiveSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_actor1PassiveSkillNameText);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_actor1PassiveSkillNameText);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB1, true);
		string name71 = "m_okButton";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_okButton);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_okButton);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB3, true);
		string name72 = "m_cancelButton";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_cancelButton);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_cancelButton);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB5, true);
		string name73 = "m_armyRelationValue";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_armyRelationValue);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_armyRelationValue);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB7, true);
		string name74 = "m_totalDamage0";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_totalDamage0);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_totalDamage0);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheB9, true);
		string name75 = "m_totalDamage1";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_totalDamage1);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_totalDamage1);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBB, true);
		string name76 = "m_fxPlayer";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_fxPlayer);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_fxPlayer);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBD, true);
		string name77 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_isOpened);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheBF, true);
		string name78 = "m_isFastCombat";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_isFastCombat);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_isFastCombat);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC1, true);
		string name79 = "m_propertyComputer";
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.get_m_propertyComputer);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PreCombatUIController.set_m_propertyComputer);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_PreCombatUIController.<>f__mg$cacheC3, true);
		LuaObject.createTypeMetatable(l, null, typeof(PreCombatUIController), typeof(UIControllerBase));
	}

	// Token: 0x040165B2 RID: 91570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040165B3 RID: 91571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040165B4 RID: 91572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040165B5 RID: 91573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040165B6 RID: 91574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040165B7 RID: 91575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040165B8 RID: 91576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040165B9 RID: 91577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040165BA RID: 91578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040165BB RID: 91579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040165BC RID: 91580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040165BD RID: 91581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040165BE RID: 91582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040165BF RID: 91583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040165C0 RID: 91584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040165C1 RID: 91585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040165C2 RID: 91586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040165C3 RID: 91587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040165C4 RID: 91588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040165C5 RID: 91589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040165C6 RID: 91590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040165C7 RID: 91591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040165C8 RID: 91592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040165C9 RID: 91593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040165CA RID: 91594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040165CB RID: 91595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040165CC RID: 91596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040165CD RID: 91597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040165CE RID: 91598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040165CF RID: 91599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040165D0 RID: 91600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040165D1 RID: 91601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040165D2 RID: 91602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040165D3 RID: 91603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040165D4 RID: 91604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040165D5 RID: 91605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040165D6 RID: 91606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040165D7 RID: 91607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040165D8 RID: 91608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040165D9 RID: 91609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040165DA RID: 91610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040165DB RID: 91611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040165DC RID: 91612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040165DD RID: 91613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040165DE RID: 91614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040165DF RID: 91615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040165E0 RID: 91616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040165E1 RID: 91617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040165E2 RID: 91618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040165E3 RID: 91619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040165E4 RID: 91620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040165E5 RID: 91621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040165E6 RID: 91622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040165E7 RID: 91623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040165E8 RID: 91624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040165E9 RID: 91625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040165EA RID: 91626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040165EB RID: 91627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040165EC RID: 91628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040165ED RID: 91629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040165EE RID: 91630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040165EF RID: 91631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040165F0 RID: 91632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040165F1 RID: 91633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040165F2 RID: 91634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040165F3 RID: 91635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040165F4 RID: 91636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040165F5 RID: 91637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040165F6 RID: 91638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040165F7 RID: 91639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040165F8 RID: 91640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040165F9 RID: 91641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040165FA RID: 91642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040165FB RID: 91643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040165FC RID: 91644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040165FD RID: 91645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040165FE RID: 91646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040165FF RID: 91647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016600 RID: 91648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016601 RID: 91649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016602 RID: 91650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016603 RID: 91651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016604 RID: 91652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04016605 RID: 91653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04016606 RID: 91654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04016607 RID: 91655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04016608 RID: 91656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04016609 RID: 91657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401660A RID: 91658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401660B RID: 91659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401660C RID: 91660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401660D RID: 91661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401660E RID: 91662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401660F RID: 91663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04016610 RID: 91664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04016611 RID: 91665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04016612 RID: 91666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04016613 RID: 91667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04016614 RID: 91668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04016615 RID: 91669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04016616 RID: 91670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04016617 RID: 91671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04016618 RID: 91672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04016619 RID: 91673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401661A RID: 91674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401661B RID: 91675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401661C RID: 91676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401661D RID: 91677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401661E RID: 91678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401661F RID: 91679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04016620 RID: 91680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04016621 RID: 91681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04016622 RID: 91682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04016623 RID: 91683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04016624 RID: 91684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04016625 RID: 91685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04016626 RID: 91686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04016627 RID: 91687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04016628 RID: 91688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04016629 RID: 91689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401662A RID: 91690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401662B RID: 91691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401662C RID: 91692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401662D RID: 91693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401662E RID: 91694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401662F RID: 91695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04016630 RID: 91696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04016631 RID: 91697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04016632 RID: 91698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04016633 RID: 91699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04016634 RID: 91700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04016635 RID: 91701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04016636 RID: 91702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04016637 RID: 91703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04016638 RID: 91704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04016639 RID: 91705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401663A RID: 91706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401663B RID: 91707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401663C RID: 91708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401663D RID: 91709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401663E RID: 91710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401663F RID: 91711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04016640 RID: 91712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04016641 RID: 91713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04016642 RID: 91714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04016643 RID: 91715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04016644 RID: 91716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04016645 RID: 91717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04016646 RID: 91718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04016647 RID: 91719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04016648 RID: 91720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04016649 RID: 91721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0401664A RID: 91722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0401664B RID: 91723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0401664C RID: 91724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0401664D RID: 91725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0401664E RID: 91726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401664F RID: 91727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04016650 RID: 91728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04016651 RID: 91729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04016652 RID: 91730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04016653 RID: 91731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04016654 RID: 91732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04016655 RID: 91733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04016656 RID: 91734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04016657 RID: 91735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04016658 RID: 91736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04016659 RID: 91737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0401665A RID: 91738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0401665B RID: 91739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0401665C RID: 91740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0401665D RID: 91741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0401665E RID: 91742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0401665F RID: 91743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04016660 RID: 91744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04016661 RID: 91745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04016662 RID: 91746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04016663 RID: 91747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04016664 RID: 91748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04016665 RID: 91749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04016666 RID: 91750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04016667 RID: 91751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04016668 RID: 91752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04016669 RID: 91753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x0401666A RID: 91754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0401666B RID: 91755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x0401666C RID: 91756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0401666D RID: 91757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0401666E RID: 91758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0401666F RID: 91759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04016670 RID: 91760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04016671 RID: 91761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04016672 RID: 91762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04016673 RID: 91763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04016674 RID: 91764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04016675 RID: 91765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;
}
