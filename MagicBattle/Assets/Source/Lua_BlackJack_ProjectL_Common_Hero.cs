using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001235 RID: 4661
[Preserve]
public class Lua_BlackJack_ProjectL_Common_Hero : LuaObject
{
	// Token: 0x060182A2 RID: 98978 RVA: 0x006B95A8 File Offset: 0x006B77A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Hero o = new Hero();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				Hero other;
				LuaObject.checkType<Hero>(l, 2, out other);
				Hero o = new Hero(other);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182A3 RID: 98979 RVA: 0x006B9640 File Offset: 0x006B7840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroCopy(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			Hero heroCopy = hero.GetHeroCopy();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCopy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182A4 RID: 98980 RVA: 0x006B9694 File Offset: 0x006B7894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEquipmentWeared(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			bool b = hero.IsEquipmentWeared(slot);
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

	// Token: 0x060182A5 RID: 98981 RVA: 0x006B96F8 File Offset: 0x006B78F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TakeOffEquipment(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			hero.TakeOffEquipment(slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182A6 RID: 98982 RVA: 0x006B9750 File Offset: 0x006B7950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasOwnSoldier(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			bool b = hero.HasOwnSoldier(soldierId);
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

	// Token: 0x060182A7 RID: 98983 RVA: 0x006B97B4 File Offset: 0x006B79B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSoldierSkinId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			int soldierSkinId = hero.GetSoldierSkinId(soldierId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182A8 RID: 98984 RVA: 0x006B9818 File Offset: 0x006B7A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetJob(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int jobRelatedId;
			LuaObject.checkType(l, 2, out jobRelatedId);
			HeroJob job = hero.GetJob(jobRelatedId);
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

	// Token: 0x060182A9 RID: 98985 RVA: 0x006B987C File Offset: 0x006B7A7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActiveJob(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			HeroJob activeJob = hero.GetActiveJob();
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

	// Token: 0x060182AA RID: 98986 RVA: 0x006B98D0 File Offset: 0x006B7AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroCharImageSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			ConfigDataCharImageSkinResourceInfo heroCharImageSkinResourceInfo = hero.GetHeroCharImageSkinResourceInfo();
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

	// Token: 0x060182AB RID: 98987 RVA: 0x006B9924 File Offset: 0x006B7B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			ConfigDataModelSkinResourceInfo soldierModelSkinResourceInfo = hero.GetSoldierModelSkinResourceInfo(soldierId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182AC RID: 98988 RVA: 0x006B9988 File Offset: 0x006B7B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroToPBHero_s(IntPtr l)
	{
		int result;
		try
		{
			Hero hero;
			LuaObject.checkType<Hero>(l, 1, out hero);
			ProHero o = Hero.HeroToPBHero(hero);
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

	// Token: 0x060182AD RID: 98989 RVA: 0x006B99DC File Offset: 0x006B7BDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBHeroToHero_s(IntPtr l)
	{
		int result;
		try
		{
			ProHero pbHero;
			LuaObject.checkType<ProHero>(l, 1, out pbHero);
			Hero o = Hero.PBHeroToHero(pbHero);
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

	// Token: 0x060182AE RID: 98990 RVA: 0x006B9A30 File Offset: 0x006B7C30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillIds(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.SkillIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182AF RID: 98991 RVA: 0x006B9A84 File Offset: 0x006B7C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkillIds(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			List<int> skillIds;
			LuaObject.checkType<List<int>>(l, 2, out skillIds);
			hero.SkillIds = skillIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B0 RID: 98992 RVA: 0x006B9ADC File Offset: 0x006B7CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierIds(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.SoldierIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B1 RID: 98993 RVA: 0x006B9B30 File Offset: 0x006B7D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierIds(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			List<int> soldierIds;
			LuaObject.checkType<List<int>>(l, 2, out soldierIds);
			hero.SoldierIds = soldierIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B2 RID: 98994 RVA: 0x006B9B88 File Offset: 0x006B7D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelectedSkills(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.SelectedSkills);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B3 RID: 98995 RVA: 0x006B9BDC File Offset: 0x006B7DDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelectedSkills(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			List<int> selectedSkills;
			LuaObject.checkType<List<int>>(l, 2, out selectedSkills);
			hero.SelectedSkills = selectedSkills;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B4 RID: 98996 RVA: 0x006B9C34 File Offset: 0x006B7E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NeedGetAchievementsJobRelatedIdList(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.NeedGetAchievementsJobRelatedIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B5 RID: 98997 RVA: 0x006B9C88 File Offset: 0x006B7E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NeedGetAchievementsJobRelatedIdList(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			List<int> needGetAchievementsJobRelatedIdList;
			LuaObject.checkType<List<int>>(l, 2, out needGetAchievementsJobRelatedIdList);
			hero.NeedGetAchievementsJobRelatedIdList = needGetAchievementsJobRelatedIdList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B6 RID: 98998 RVA: 0x006B9CE0 File Offset: 0x006B7EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EquipmentIds(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.EquipmentIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B7 RID: 98999 RVA: 0x006B9D34 File Offset: 0x006B7F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EquipmentIds(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			ulong[] equipmentIds;
			LuaObject.checkArray<ulong>(l, 2, out equipmentIds);
			hero.EquipmentIds = equipmentIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B8 RID: 99000 RVA: 0x006B9D8C File Offset: 0x006B7F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Fetters(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.Fetters);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182B9 RID: 99001 RVA: 0x006B9DE0 File Offset: 0x006B7FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Fetters(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			Dictionary<int, int> fetters;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out fetters);
			hero.Fetters = fetters;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182BA RID: 99002 RVA: 0x006B9E38 File Offset: 0x006B8038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Jobs(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.Jobs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182BB RID: 99003 RVA: 0x006B9E8C File Offset: 0x006B808C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Jobs(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			List<HeroJob> jobs;
			LuaObject.checkType<List<HeroJob>>(l, 2, out jobs);
			hero.Jobs = jobs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182BC RID: 99004 RVA: 0x006B9EE4 File Offset: 0x006B80E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnlockedJobs(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.UnlockedJobs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182BD RID: 99005 RVA: 0x006B9F38 File Offset: 0x006B8138
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UnlockedJobs(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			List<int> unlockedJobs;
			LuaObject.checkType<List<int>>(l, 2, out unlockedJobs);
			hero.UnlockedJobs = unlockedJobs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182BE RID: 99006 RVA: 0x006B9F90 File Offset: 0x006B8190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierSkins(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.SoldierSkins);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182BF RID: 99007 RVA: 0x006B9FE4 File Offset: 0x006B81E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierSkins(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			List<SoldierSkin> soldierSkins;
			LuaObject.checkType<List<SoldierSkin>>(l, 2, out soldierSkins);
			hero.SoldierSkins = soldierSkins;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C0 RID: 99008 RVA: 0x006BA03C File Offset: 0x006B823C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActionPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.ActionPositionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C1 RID: 99009 RVA: 0x006BA090 File Offset: 0x006B8290
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ActionPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int actionPositionIndex;
			LuaObject.checkType(l, 2, out actionPositionIndex);
			hero.ActionPositionIndex = actionPositionIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C2 RID: 99010 RVA: 0x006BA0E8 File Offset: 0x006B82E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.ActionValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C3 RID: 99011 RVA: 0x006BA13C File Offset: 0x006B833C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int actionValue;
			LuaObject.checkType(l, 2, out actionValue);
			hero.ActionValue = actionValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C4 RID: 99012 RVA: 0x006BA194 File Offset: 0x006B8394
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C5 RID: 99013 RVA: 0x006BA1E8 File Offset: 0x006B83E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			hero.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C6 RID: 99014 RVA: 0x006BA240 File Offset: 0x006B8440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C7 RID: 99015 RVA: 0x006BA294 File Offset: 0x006B8494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			hero.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C8 RID: 99016 RVA: 0x006BA2EC File Offset: 0x006B84EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Exp(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.Exp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182C9 RID: 99017 RVA: 0x006BA340 File Offset: 0x006B8540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Exp(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			hero.Exp = exp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182CA RID: 99018 RVA: 0x006BA398 File Offset: 0x006B8598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StarLevel(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.StarLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182CB RID: 99019 RVA: 0x006BA3EC File Offset: 0x006B85EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StarLevel(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int starLevel;
			LuaObject.checkType(l, 2, out starLevel);
			hero.StarLevel = starLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182CC RID: 99020 RVA: 0x006BA444 File Offset: 0x006B8644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FightNums(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.FightNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182CD RID: 99021 RVA: 0x006BA498 File Offset: 0x006B8698
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FightNums(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int fightNums;
			LuaObject.checkType(l, 2, out fightNums);
			hero.FightNums = fightNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182CE RID: 99022 RVA: 0x006BA4F0 File Offset: 0x006B86F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActiveHeroJobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.ActiveHeroJobRelatedId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182CF RID: 99023 RVA: 0x006BA544 File Offset: 0x006B8744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActiveHeroJobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int activeHeroJobRelatedId;
			LuaObject.checkType(l, 2, out activeHeroJobRelatedId);
			hero.ActiveHeroJobRelatedId = activeHeroJobRelatedId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D0 RID: 99024 RVA: 0x006BA59C File Offset: 0x006B879C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharSkinId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.CharSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D1 RID: 99025 RVA: 0x006BA5F0 File Offset: 0x006B87F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CharSkinId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int charSkinId;
			LuaObject.checkType(l, 2, out charSkinId);
			hero.CharSkinId = charSkinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D2 RID: 99026 RVA: 0x006BA648 File Offset: 0x006B8848
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.FavorabilityLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D3 RID: 99027 RVA: 0x006BA69C File Offset: 0x006B889C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int favorabilityLevel;
			LuaObject.checkType(l, 2, out favorabilityLevel);
			hero.FavorabilityLevel = favorabilityLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D4 RID: 99028 RVA: 0x006BA6F4 File Offset: 0x006B88F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.FavorabilityExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D5 RID: 99029 RVA: 0x006BA748 File Offset: 0x006B8948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int favorabilityExp;
			LuaObject.checkType(l, 2, out favorabilityExp);
			hero.FavorabilityExp = favorabilityExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D6 RID: 99030 RVA: 0x006BA7A0 File Offset: 0x006B89A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Confessed(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.Confessed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D7 RID: 99031 RVA: 0x006BA7F4 File Offset: 0x006B89F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Confessed(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			bool confessed;
			LuaObject.checkType(l, 2, out confessed);
			hero.Confessed = confessed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D8 RID: 99032 RVA: 0x006BA84C File Offset: 0x006B8A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectedSoldierId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.SelectedSoldierId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182D9 RID: 99033 RVA: 0x006BA8A0 File Offset: 0x006B8AA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelectedSoldierId(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int selectedSoldierId;
			LuaObject.checkType(l, 2, out selectedSoldierId);
			hero.SelectedSoldierId = selectedSoldierId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182DA RID: 99034 RVA: 0x006BA8F8 File Offset: 0x006B8AF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CanTransferMaxRank(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.CanTransferMaxRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182DB RID: 99035 RVA: 0x006BA94C File Offset: 0x006B8B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CanTransferMaxRank(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int canTransferMaxRank;
			LuaObject.checkType(l, 2, out canTransferMaxRank);
			hero.CanTransferMaxRank = canTransferMaxRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182DC RID: 99036 RVA: 0x006BA9A4 File Offset: 0x006B8BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePower(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.BattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182DD RID: 99037 RVA: 0x006BA9F8 File Offset: 0x006B8BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePower(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int battlePower;
			LuaObject.checkType(l, 2, out battlePower);
			hero.BattlePower = battlePower;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182DE RID: 99038 RVA: 0x006BAA50 File Offset: 0x006B8C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePowerUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.BattlePowerUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182DF RID: 99039 RVA: 0x006BAAA8 File Offset: 0x006B8CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePowerUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			DateTime battlePowerUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out battlePowerUpdateTime);
			hero.BattlePowerUpdateTime = battlePowerUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182E0 RID: 99040 RVA: 0x006BAB00 File Offset: 0x006B8D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastRank(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.LastRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182E1 RID: 99041 RVA: 0x006BAB54 File Offset: 0x006B8D54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastRank(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			int lastRank;
			LuaObject.checkType(l, 2, out lastRank);
			hero.LastRank = lastRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182E2 RID: 99042 RVA: 0x006BABAC File Offset: 0x006B8DAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.HeroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182E3 RID: 99043 RVA: 0x006BAC00 File Offset: 0x006B8E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectedSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			Hero hero = (Hero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero.SelectedSoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182E4 RID: 99044 RVA: 0x006BAC54 File Offset: 0x006B8E54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.Hero");
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.GetHeroCopy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.IsEquipmentWeared);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.TakeOffEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.HasOwnSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.GetSoldierSkinId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.GetJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.GetActiveJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.GetHeroCharImageSkinResourceInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.GetSoldierModelSkinResourceInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.HeroToPBHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.PBHeroToHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheA);
		string name = "SkillIds";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_SkillIds);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_SkillIds);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheC, true);
		string name2 = "SoldierIds";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_SoldierIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_SoldierIds);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheE, true);
		string name3 = "SelectedSkills";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_SelectedSkills);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_SelectedSkills);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache10, true);
		string name4 = "NeedGetAchievementsJobRelatedIdList";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_NeedGetAchievementsJobRelatedIdList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_NeedGetAchievementsJobRelatedIdList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache12, true);
		string name5 = "EquipmentIds";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_EquipmentIds);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_EquipmentIds);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache14, true);
		string name6 = "Fetters";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_Fetters);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_Fetters);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache16, true);
		string name7 = "Jobs";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_Jobs);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_Jobs);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache18, true);
		string name8 = "UnlockedJobs";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_UnlockedJobs);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_UnlockedJobs);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1A, true);
		string name9 = "SoldierSkins";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_SoldierSkins);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_SoldierSkins);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1C, true);
		string name10 = "ActionPositionIndex";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_ActionPositionIndex);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_ActionPositionIndex);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1E, true);
		string name11 = "ActionValue";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_ActionValue);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_ActionValue);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache20, true);
		string name12 = "HeroId";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_HeroId);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_HeroId);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache22, true);
		string name13 = "Level";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_Level);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_Level);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache24, true);
		string name14 = "Exp";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_Exp);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_Exp);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache26, true);
		string name15 = "StarLevel";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_StarLevel);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_StarLevel);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache28, true);
		string name16 = "FightNums";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_FightNums);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_FightNums);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2A, true);
		string name17 = "ActiveHeroJobRelatedId";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_ActiveHeroJobRelatedId);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_ActiveHeroJobRelatedId);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2C, true);
		string name18 = "CharSkinId";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_CharSkinId);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_CharSkinId);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2E, true);
		string name19 = "FavorabilityLevel";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_FavorabilityLevel);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_FavorabilityLevel);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache30, true);
		string name20 = "FavorabilityExp";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_FavorabilityExp);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_FavorabilityExp);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache32, true);
		string name21 = "Confessed";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_Confessed);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_Confessed);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache34, true);
		string name22 = "SelectedSoldierId";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_SelectedSoldierId);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_SelectedSoldierId);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache36, true);
		string name23 = "CanTransferMaxRank";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_CanTransferMaxRank);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_CanTransferMaxRank);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache38, true);
		string name24 = "BattlePower";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_BattlePower);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_BattlePower);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3A, true);
		string name25 = "BattlePowerUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_BattlePowerUpdateTime);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_BattlePowerUpdateTime);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3C, true);
		string name26 = "LastRank";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_LastRank);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.set_LastRank);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3E, true);
		string name27 = "HeroInfo";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_HeroInfo);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache3F, null, true);
		string name28 = "SelectedSoldierInfo";
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.get_SelectedSoldierInfo);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache40, null, true);
		if (Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Hero.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_Hero.<>f__mg$cache41, typeof(Hero));
	}

	// Token: 0x0400E81A RID: 59418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E81B RID: 59419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E81C RID: 59420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E81D RID: 59421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E81E RID: 59422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E81F RID: 59423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E820 RID: 59424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E821 RID: 59425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E822 RID: 59426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E823 RID: 59427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E824 RID: 59428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E825 RID: 59429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E826 RID: 59430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E827 RID: 59431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E828 RID: 59432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E829 RID: 59433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E82A RID: 59434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E82B RID: 59435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E82C RID: 59436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E82D RID: 59437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E82E RID: 59438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E82F RID: 59439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E830 RID: 59440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E831 RID: 59441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E832 RID: 59442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E833 RID: 59443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E834 RID: 59444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E835 RID: 59445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E836 RID: 59446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E837 RID: 59447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E838 RID: 59448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E839 RID: 59449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E83A RID: 59450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E83B RID: 59451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E83C RID: 59452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E83D RID: 59453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E83E RID: 59454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E83F RID: 59455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E840 RID: 59456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E841 RID: 59457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E842 RID: 59458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E843 RID: 59459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E844 RID: 59460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E845 RID: 59461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E846 RID: 59462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E847 RID: 59463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E848 RID: 59464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E849 RID: 59465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E84A RID: 59466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E84B RID: 59467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E84C RID: 59468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400E84D RID: 59469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400E84E RID: 59470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400E84F RID: 59471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400E850 RID: 59472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400E851 RID: 59473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400E852 RID: 59474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400E853 RID: 59475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400E854 RID: 59476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400E855 RID: 59477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400E856 RID: 59478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400E857 RID: 59479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400E858 RID: 59480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400E859 RID: 59481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400E85A RID: 59482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400E85B RID: 59483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;
}
