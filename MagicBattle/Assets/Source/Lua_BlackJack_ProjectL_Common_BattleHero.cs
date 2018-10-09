using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011CB RID: 4555
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleHero : LuaObject
{
	// Token: 0x06017A0A RID: 96778 RVA: 0x0067C010 File Offset: 0x0067A210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleHero o = new BattleHero();
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

	// Token: 0x06017A0B RID: 96779 RVA: 0x0067C058 File Offset: 0x0067A258
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetJob(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int jobRelatedId;
			LuaObject.checkType(l, 2, out jobRelatedId);
			BattleHeroJob job = battleHero.GetJob(jobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, job);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A0C RID: 96780 RVA: 0x0067C0BC File Offset: 0x0067A2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActiveJob(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			BattleHeroJob activeJob = battleHero.GetActiveJob();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activeJob);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A0D RID: 96781 RVA: 0x0067C110 File Offset: 0x0067A310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroCharImageSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			ConfigDataCharImageSkinResourceInfo heroCharImageSkinResourceInfo = battleHero.GetHeroCharImageSkinResourceInfo(configDataLoader);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharImageSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A0E RID: 96782 RVA: 0x0067C174 File Offset: 0x0067A374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroActiveJobModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			ConfigDataModelSkinResourceInfo heroActiveJobModelSkinResourceInfo = battleHero.GetHeroActiveJobModelSkinResourceInfo(configDataLoader);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroActiveJobModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A0F RID: 96783 RVA: 0x0067C1D8 File Offset: 0x0067A3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSelectedSoldierModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			ConfigDataModelSkinResourceInfo selectedSoldierModelSkinResourceInfo = battleHero.GetSelectedSoldierModelSkinResourceInfo(configDataLoader);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectedSoldierModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A10 RID: 96784 RVA: 0x0067C23C File Offset: 0x0067A43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroToBattleHero_s(IntPtr l)
	{
		int result;
		try
		{
			Hero hero;
			LuaObject.checkType<Hero>(l, 1, out hero);
			BattleHero o = BattleHero.HeroToBattleHero(hero);
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

	// Token: 0x06017A11 RID: 96785 RVA: 0x0067C290 File Offset: 0x0067A490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBBattleHeroToBattleHero_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattleHero pbBattleHero;
			LuaObject.checkType<ProBattleHero>(l, 1, out pbBattleHero);
			BattleHero o = BattleHero.PBBattleHeroToBattleHero(pbBattleHero);
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

	// Token: 0x06017A12 RID: 96786 RVA: 0x0067C2E4 File Offset: 0x0067A4E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleHeroToPBBattleHero_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero;
			LuaObject.checkType<BattleHero>(l, 1, out battleHero);
			ProBattleHero o = BattleHero.BattleHeroToPBBattleHero(battleHero);
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

	// Token: 0x06017A13 RID: 96787 RVA: 0x0067C338 File Offset: 0x0067A538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ViewBattleHeroToPBBattleHero_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero;
			LuaObject.checkType<BattleHero>(l, 1, out battleHero);
			ProBattleHero o = BattleHero.ViewBattleHeroToPBBattleHero(battleHero);
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

	// Token: 0x06017A14 RID: 96788 RVA: 0x0067C38C File Offset: 0x0067A58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBBattleHeroToViewBattleHero_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattleHero pbBattleHero;
			LuaObject.checkType<ProBattleHero>(l, 1, out pbBattleHero);
			BattleHero o = BattleHero.PBBattleHeroToViewBattleHero(pbBattleHero);
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

	// Token: 0x06017A15 RID: 96789 RVA: 0x0067C3E0 File Offset: 0x0067A5E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateHeroInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			battleHero.m_luaExportHelper.UpdateHeroInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A16 RID: 96790 RVA: 0x0067C434 File Offset: 0x0067A634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			battleHero.m_luaExportHelper.UpdateSoldierInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A17 RID: 96791 RVA: 0x0067C488 File Offset: 0x0067A688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.m_luaExportHelper.m_heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A18 RID: 96792 RVA: 0x0067C4E0 File Offset: 0x0067A6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			battleHero.m_luaExportHelper.m_heroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A19 RID: 96793 RVA: 0x0067C53C File Offset: 0x0067A73C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Jobs(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.Jobs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A1A RID: 96794 RVA: 0x0067C590 File Offset: 0x0067A790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Jobs(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			List<BattleHeroJob> jobs;
			LuaObject.checkType<List<BattleHeroJob>>(l, 2, out jobs);
			battleHero.Jobs = jobs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A1B RID: 96795 RVA: 0x0067C5E8 File Offset: 0x0067A7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectedSkillList(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.SelectedSkillList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A1C RID: 96796 RVA: 0x0067C63C File Offset: 0x0067A83C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelectedSkillList(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			List<int> selectedSkillList;
			LuaObject.checkType<List<int>>(l, 2, out selectedSkillList);
			battleHero.SelectedSkillList = selectedSkillList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A1D RID: 96797 RVA: 0x0067C694 File Offset: 0x0067A894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_selectedSoldierId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.m_luaExportHelper.m_selectedSoldierId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A1E RID: 96798 RVA: 0x0067C6EC File Offset: 0x0067A8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectedSoldierId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int selectedSoldierId;
			LuaObject.checkType(l, 2, out selectedSoldierId);
			battleHero.m_luaExportHelper.m_selectedSoldierId = selectedSoldierId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A1F RID: 96799 RVA: 0x0067C748 File Offset: 0x0067A948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Equipments(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.Equipments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A20 RID: 96800 RVA: 0x0067C79C File Offset: 0x0067A99C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Equipments(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			List<BattleHeroEquipment> equipments;
			LuaObject.checkType<List<BattleHeroEquipment>>(l, 2, out equipments);
			battleHero.Equipments = equipments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A21 RID: 96801 RVA: 0x0067C7F4 File Offset: 0x0067A9F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Fetters(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.Fetters);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A22 RID: 96802 RVA: 0x0067C848 File Offset: 0x0067AA48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Fetters(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			Dictionary<int, int> fetters;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out fetters);
			battleHero.Fetters = fetters;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A23 RID: 96803 RVA: 0x0067C8A0 File Offset: 0x0067AAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A24 RID: 96804 RVA: 0x0067C8F4 File Offset: 0x0067AAF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			battleHero.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A25 RID: 96805 RVA: 0x0067C94C File Offset: 0x0067AB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActionPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.ActionPositionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A26 RID: 96806 RVA: 0x0067C9A0 File Offset: 0x0067ABA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ActionPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int actionPositionIndex;
			LuaObject.checkType(l, 2, out actionPositionIndex);
			battleHero.ActionPositionIndex = actionPositionIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A27 RID: 96807 RVA: 0x0067C9F8 File Offset: 0x0067ABF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.ActionValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A28 RID: 96808 RVA: 0x0067CA4C File Offset: 0x0067AC4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int actionValue;
			LuaObject.checkType(l, 2, out actionValue);
			battleHero.ActionValue = actionValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A29 RID: 96809 RVA: 0x0067CAA4 File Offset: 0x0067ACA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A2A RID: 96810 RVA: 0x0067CAF8 File Offset: 0x0067ACF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			battleHero.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A2B RID: 96811 RVA: 0x0067CB50 File Offset: 0x0067AD50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StarLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.StarLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A2C RID: 96812 RVA: 0x0067CBA4 File Offset: 0x0067ADA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StarLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int starLevel;
			LuaObject.checkType(l, 2, out starLevel);
			battleHero.StarLevel = starLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A2D RID: 96813 RVA: 0x0067CBFC File Offset: 0x0067ADFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActiveHeroJobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.ActiveHeroJobRelatedId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A2E RID: 96814 RVA: 0x0067CC50 File Offset: 0x0067AE50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ActiveHeroJobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int activeHeroJobRelatedId;
			LuaObject.checkType(l, 2, out activeHeroJobRelatedId);
			battleHero.ActiveHeroJobRelatedId = activeHeroJobRelatedId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A2F RID: 96815 RVA: 0x0067CCA8 File Offset: 0x0067AEA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ModelSkinId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.ModelSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A30 RID: 96816 RVA: 0x0067CCFC File Offset: 0x0067AEFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ModelSkinId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int modelSkinId;
			LuaObject.checkType(l, 2, out modelSkinId);
			battleHero.ModelSkinId = modelSkinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A31 RID: 96817 RVA: 0x0067CD54 File Offset: 0x0067AF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharSkinId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.CharSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A32 RID: 96818 RVA: 0x0067CDA8 File Offset: 0x0067AFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CharSkinId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int charSkinId;
			LuaObject.checkType(l, 2, out charSkinId);
			battleHero.CharSkinId = charSkinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A33 RID: 96819 RVA: 0x0067CE00 File Offset: 0x0067B000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectedSoldierSkinId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.SelectedSoldierSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A34 RID: 96820 RVA: 0x0067CE54 File Offset: 0x0067B054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SelectedSoldierSkinId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int selectedSoldierSkinId;
			LuaObject.checkType(l, 2, out selectedSoldierSkinId);
			battleHero.SelectedSoldierSkinId = selectedSoldierSkinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A35 RID: 96821 RVA: 0x0067CEAC File Offset: 0x0067B0AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelectedSoldierId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.SelectedSoldierId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A36 RID: 96822 RVA: 0x0067CF00 File Offset: 0x0067B100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelectedSoldierId(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int selectedSoldierId;
			LuaObject.checkType(l, 2, out selectedSoldierId);
			battleHero.SelectedSoldierId = selectedSoldierId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A37 RID: 96823 RVA: 0x0067CF58 File Offset: 0x0067B158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Power(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.Power);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A38 RID: 96824 RVA: 0x0067CFAC File Offset: 0x0067B1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Power(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			int power;
			LuaObject.checkType(l, 2, out power);
			battleHero.Power = power;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A39 RID: 96825 RVA: 0x0067D004 File Offset: 0x0067B204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.HeroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A3A RID: 96826 RVA: 0x0067D058 File Offset: 0x0067B258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			battleHero.m_luaExportHelper.HeroInfo = heroInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A3B RID: 96827 RVA: 0x0067D0B4 File Offset: 0x0067B2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectedSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero.SelectedSoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A3C RID: 96828 RVA: 0x0067D108 File Offset: 0x0067B308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelectedSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHero battleHero = (BattleHero)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo selectedSoldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out selectedSoldierInfo);
			battleHero.m_luaExportHelper.SelectedSoldierInfo = selectedSoldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A3D RID: 96829 RVA: 0x0067D164 File Offset: 0x0067B364
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleHero");
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.GetJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.GetActiveJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.GetHeroCharImageSkinResourceInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.GetHeroActiveJobModelSkinResourceInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.GetSelectedSoldierModelSkinResourceInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.HeroToBattleHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.PBBattleHeroToBattleHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.BattleHeroToPBBattleHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.ViewBattleHeroToPBBattleHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.PBBattleHeroToViewBattleHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.UpdateHeroInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.UpdateSoldierInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheB);
		string name = "m_heroId";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_m_heroId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_m_heroId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheD, true);
		string name2 = "Jobs";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_Jobs);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_Jobs);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cacheF, true);
		string name3 = "SelectedSkillList";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_SelectedSkillList);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_SelectedSkillList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache11, true);
		string name4 = "m_selectedSoldierId";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_m_selectedSoldierId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_m_selectedSoldierId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache13, true);
		string name5 = "Equipments";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_Equipments);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_Equipments);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache15, true);
		string name6 = "Fetters";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_Fetters);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_Fetters);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache17, true);
		string name7 = "HeroId";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_HeroId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_HeroId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache19, true);
		string name8 = "ActionPositionIndex";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_ActionPositionIndex);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_ActionPositionIndex);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1B, true);
		string name9 = "ActionValue";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_ActionValue);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_ActionValue);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1D, true);
		string name10 = "Level";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_Level);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_Level);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache1F, true);
		string name11 = "StarLevel";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_StarLevel);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_StarLevel);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache21, true);
		string name12 = "ActiveHeroJobRelatedId";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_ActiveHeroJobRelatedId);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_ActiveHeroJobRelatedId);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache23, true);
		string name13 = "ModelSkinId";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_ModelSkinId);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_ModelSkinId);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache25, true);
		string name14 = "CharSkinId";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_CharSkinId);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_CharSkinId);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache27, true);
		string name15 = "SelectedSoldierSkinId";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_SelectedSoldierSkinId);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_SelectedSoldierSkinId);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache29, true);
		string name16 = "SelectedSoldierId";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_SelectedSoldierId);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_SelectedSoldierId);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2B, true);
		string name17 = "Power";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_Power);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_Power);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2D, true);
		string name18 = "HeroInfo";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_HeroInfo);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_HeroInfo);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache2F, true);
		string name19 = "SelectedSoldierInfo";
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.get_SelectedSoldierInfo);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.set_SelectedSoldierInfo);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache31, true);
		if (Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHero.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleHero.<>f__mg$cache32, typeof(BattleHero));
	}

	// Token: 0x0400E056 RID: 57430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E057 RID: 57431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E058 RID: 57432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E059 RID: 57433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E05A RID: 57434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E05B RID: 57435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E05C RID: 57436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E05D RID: 57437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E05E RID: 57438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E05F RID: 57439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E060 RID: 57440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E061 RID: 57441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E062 RID: 57442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E063 RID: 57443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E064 RID: 57444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E065 RID: 57445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E066 RID: 57446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E067 RID: 57447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E068 RID: 57448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E069 RID: 57449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E06A RID: 57450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E06B RID: 57451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E06C RID: 57452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E06D RID: 57453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E06E RID: 57454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E06F RID: 57455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E070 RID: 57456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E071 RID: 57457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E072 RID: 57458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E073 RID: 57459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E074 RID: 57460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E075 RID: 57461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E076 RID: 57462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E077 RID: 57463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E078 RID: 57464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E079 RID: 57465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E07A RID: 57466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E07B RID: 57467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E07C RID: 57468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E07D RID: 57469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E07E RID: 57470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E07F RID: 57471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E080 RID: 57472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E081 RID: 57473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E082 RID: 57474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E083 RID: 57475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E084 RID: 57476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E085 RID: 57477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E086 RID: 57478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E087 RID: 57479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E088 RID: 57480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
